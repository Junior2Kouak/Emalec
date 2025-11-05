using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeCourrierSTT : Form
  {
    public long miStfGrpNnum;
    public string mvStfGrpNom;

    DataTable dt = new DataTable();

    public frmListeCourrierSTT()
    {
      InitializeComponent();
    }

    private void frmListeCourrierSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        InitFeuille();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdCreer_Click(object sender, EventArgs e)
    {
      InitCourrier();
    }

    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      if ((int)currentRow["NCOURNUM"] == 0)
      {
        MessageBox.Show("Visualisation du courrier impossible." + "\r\n" + "C'est une relance par mail", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      frmModifLettre f = new frmModifLettre();
      f.mstrTypeDest = currentRow["VCOURTYPDEST"].ToString();
      f.mstrTypeCour = "L";
      f.mstrTypeAR = Utils.BlankIfNull(currentRow["VCOURTYPAR"]);
      f.iNumCourrier = (long)Utils.ZeroIfNull(currentRow["NCOURNUM"]);
      f.iNumDest = (long)Utils.ZeroIfNull(currentRow["NCOURIDDEST"]);
      f.ShowDialog();

    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        //suppression
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if ((int)currentRow["NCOURNUM"] == 0)
        {
          MessageBox.Show("Suppression du courrier impossible." + "\r\n" + "C'est une relance par mail", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (MessageBox.Show(Resources.msg_Confirm_courrier_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          if (currentRow["VTYPECOUR"].ToString() == "C")
            ModuleData.ExecuteNonQuery($"api_sp_SupprimerCourrier {currentRow["NCOURNUM"]}");
        }
        else
          return;

        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitCourrier()
    {
      string sSQL;
      string sLangueABR = "";
      int iAttestFluide = 0;
      Boolean ConditionGeneral=false;

      DataTable dtLettre = new DataTable();

      // gestion du cas des STT Clim avec le doc attestation fluide en plus
      sSQL = $"SELECT COUNT(NSTFGRPNUM) FROM TSTF WHERE NSTFGRPNUM = {miStfGrpNnum} " +
        $"AND (VLISTEACTIVITESRECHERCHE LIKE '%CLIMATISATION%' OR VLISTEACTIVITESRECHERCHE LIKE '%FROID COMMERCIAL%')";
      using (SqlDataReader reader = ModuleData.ExecuteReader(sSQL))
      {
        while (reader.Read())
          iAttestFluide = (int)reader[0];
      }

      // gestion de la langue (FR ou EN uniquement : soit FR sinon EN)
      sSQL = $"SELECT case when isnull((SELECT VPAYSABR FROM TPAYS WHERE VPAYSNOM = TSTFGRP.VSTFGRPPAYS), 'FR') = 'FR' " +
            $"then 'FR' Else 'EN' End AS VLANGUEABR FROM TSTFGRP WHERE NSTFGRPNUM = {miStfGrpNnum}";

      using (SqlDataReader reader = ModuleData.ExecuteReader(sSQL))
      {
        while (reader.Read())
          sLangueABR = Utils.BlankIfNull(reader["VLANGUEABR"]);
      }

      // liste des docs manquants
      //gestion du cas de la décennale pas obligatoire sur tous les STT
      sSQL = $"select VTYPEDOCSTFLIB, isnull(VTYPEDOCSTFLIB2017, '') AS VTYPEDOCSTFLIB2017, NTYPEDOCSTFNUM, ISNULL(VTYPEDOCSTFINFOREL, '') " +
             $"AS VTYPEDOCSTFINFOREL From tref_typedocstf where Vlangue = '{sLangueABR}' AND CTYPEDOCSTFACTIF = 'O' " +
             $"AND (CTYPEDOCSTFOBLIG = 'O' OR (NTYPEDOCSTFNUM = 13) OR (NTYPEDOCSTFNUM = 11 AND {iAttestFluide} > 0)) " +
             $"and NTYPEDOCSTFNUM not in (select NTYPEDOCSTFNUM from TDOCSTF where NSTFGRPNUM = {miStfGrpNnum} AND TDOCSTF.BDOCSTFACTIF = 1 " +
             $"and ddocstfedi > getdate()) and NTYPEDOCSTFNUM not in (select (case when CSTFGRPDEC='N' THEN 3 ELSE 0 END) " +
             $"from TSTFGRP where NSTFGRPNUM = {miStfGrpNnum})";


      using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
      {
        if (dr.Read())
        {
          dtLettre.Columns.Add("TypeDest", typeof(string));
          dtLettre.Columns.Add("IDdest", typeof(int));

          DataRow newRow = dtLettre.NewRow();
          newRow["TypeDest"] = "RelanceDocAdmin";
          newRow["IDdest"] = miStfGrpNnum;
          dtLettre.Rows.Add(newRow);

          frmSaisieLettre f = new frmSaisieLettre();
          f.dtLettre = dtLettre;
          f.mstrTypeDest = "RelanceDocAdmin";
          f.mstrTypeCour = "L";
          f.mstrTypeAR = "S";

          f.iNumCourrier = 0;
          f.lNumAction = 0;

          f.mstrStatutCourrier = "C";
          f.txtRef.Text = sLangueABR == "FR" ? "Mise à jour documents administratifs" : "Up to date administrative documents";
          f.txtCompte.Text = "0";

          // début du courrier
          if (sLangueABR == "FR")
          {
            f.txtObjet.Text = "Transmission obligatoire de vos documents administratifs manquants";
            f.txtLettre.Text = "Bonjour, \r\n\r\n Nous avons démarré il y a peu une relation commerciale avec vous.\r\n\r\n" +
              "Afin de finaliser votre intégration dans notre base de donnée, nous n’avons, sauf erreur, pas reçu vos documents :\r\n\r\n";
          }
          else
          {
            f.txtObjet.Text = "administrative documents";
            f.txtLettre.Text = "In accordance with the law, we need to ensure the administrative compliance of your company\r\n\r\n" +
                               "Therefore, we need the following documents:\r\n\r\n";
          }

          // boucle sur les documents qui sont manquants ou pas à jour
          do
          {
            // le texte pour les conditions générales d'achats est en dessous, mais pas ici
            if ((int)dr["NTYPEDOCSTFNUM"]==13)
              ConditionGeneral = true;
            else
              f.txtLettre.Text += " - " + Utils.BlankIfNull(dr["VTYPEDOCSTFLIB2017"]) + "\r\n\r\n";

          } while (dr.Read());

          // fin du courrier
          if (sLangueABR == "FR")
          {
            // uniquement si les conditions générales sont nécessaires
            if (ConditionGeneral)
						{
              f.txtLettre.Text += "Vous trouverez également ci-joint nos conditions générales d’achats prestataires que nous " +
                "vous demandons de dater, signer et nous renvoyer le document.\r\n\r\n";
            }
            
            f.txtLettre.Text += "Nous souhaitons exclusivement les recevoir par mail au format PDF (1 fichier par document demandé) à l'adresse " +
              "suivante : stt@emalec.com.\r\n\r\n" +
              "Nous espérons pouvoir construire ensemble, un partenariat durable.\r\n\r\n" +
              "N’hésitez pas à nous contacter pour toutes questions : stt @emalec.com\r\n\r\n" +
              "Nous vous remercions par avance.\r\n\r\nEMALEC\r\n\r\nService Achats";
          }
          else
          {
            f.txtLettre.Text += $"Please send us a copy of these documents  by email in PDF format to : partners@emalec.com\r\n" +
                            $"We need these documents in order to continue sending you new work orders and make sure to be covered " +
                            $"for the works that you carry out.:\r\n";
          }

          f.ShowDialog();
        }
        else
          MessageBox.Show("Tous les documents de ce sous-traitant sont à jour.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void InitFeuille()
    {
      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeCourrierRelance {miStfGrpNnum}");
      apiTGrid.GridControl.DataSource = dt;
      InitApigrid();
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn("Numéro", "NCOURNUM", 1200);
        apiTGrid.AddColumn("Date", "DCOURDAT", 1500);
        apiTGrid.AddColumn("Rédacteur", "VPERNOM", 3000, "", 2);
        apiTGrid.AddColumn("Destinataire", "VINTNOM", 3000);
        apiTGrid.AddColumn("STT", "VSTFNOM", 0);
        apiTGrid.AddColumn("Référence", "VCOURREF", 2000);
        apiTGrid.AddColumn("Objet", "VCOUROBJET", 4000);
        apiTGrid.AddColumn("CourID", "NCOURID", 0);
        apiTGrid.AddColumn("TYPE", "VCOURTYPDEST", 0);
        apiTGrid.AddColumn("AR", "VCOURTYPAR", 0);
        apiTGrid.AddColumn("VTYPECOUR", "VTYPECOUR", 0);

        apiTGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}