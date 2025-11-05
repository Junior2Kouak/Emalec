using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeCourrierAction : Form
  {
    public int miClient;
    public int miSite;
    public string mstrClient;
    public int miSTFcontact;
    public string mstrSite;
    public string mstrCompte;

    string NSERVTECHNUM;
    DataTable dtAdoRs = new DataTable();
    DataTable dtStFou = new DataTable();
    DataTable dt = new DataTable();

    DataTable dtLettre = new DataTable();

    // variables pour frmDetailsTrvaux
    public string mtxtDateA2;
    public string mtxtAction;


    public frmListeCourrierAction() { InitializeComponent(); }

    private void frmListeCourrierAction_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        NSERVTECHNUM = "";

        dtLettre.Columns.Add(new DataColumn("TypeDest", Type.GetType("System.String")));
        dtLettre.Columns.Add(new DataColumn("IDdest", Type.GetType("System.Int64")));

        ApiGrid.LoadData(dtAdoRs, MozartDatabase.cnxMozart, $"exec api_sp_ListeCourrierAction {MozartParams.NumAction}");
        ApiGrid.GridControl.DataSource = dtAdoRs;
        InitApigrid();

        RemplirLBTypeCourrier(lstTypeCour);

        Utils.InitComboBox(cboContact, $"select NCCLNUM, VCCLNOM from TCCL WHERE CCCLACTIF='O' AND NCLINUM= {miClient} ORDER BY VCCLNOM");

        cboType.SelectedIndex = 0;

        FormatGrid();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdCreer_Click(object sender, EventArgs e)
    {

      try
      {
        string sLangueDest = "";
        DataRow currentRow = ApiGridFou.GetFocusedDataRow();

        if (cboType.Text == "Fournisseur")
        {
          if (currentRow == null)
          {
            MessageBox.Show("Il faut choisir un fournisseur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          if (currentRow["NINTNUM"] == null)
          {
            MessageBox.Show("Il manque le contact sur le fournisseur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        dtLettre.Rows.Clear();
        DataRow rowLettre = dtLettre.NewRow();
        rowLettre["TypeDest"] = cboType.Text;

        switch (cboType.Text)
        {
          case "Client":
            rowLettre["IDdest"] = (int)cboContact.SelectedValue;
            string sTemp = ModuleData.ExecuteScalarString($"SELECT VCCLPAYS FROM TCCL WHERE NCCLNUM = {cboContact.SelectedValue}");
            if (sTemp != "") sLangueDest = ModuleMain.CodePays(sTemp).Replace(@"\", "");
            break;
          case "Site":
            rowLettre["IDdest"] = miSite;
            string sTempSite = ModuleData.ExecuteScalarString($"SELECT VSITPAYS FROM TSIT WHERE NSITNUM = {miSite}");
            if (sTempSite != "") sLangueDest = ModuleMain.CodePays(sTempSite).Replace(@"\", "");
            break;
          case "Sous-traitant":
            rowLettre["IDdest"] = miSTFcontact;
            string sTempST = ModuleData.ExecuteScalarString($"SELECT TSTF.VLANGUEABR FROM TSTF INNER JOIN TINT ON TINT.NSTFNUM = TSTF.NSTFNUM WHERE TINT.NINTNUM = {miSTFcontact}");
            if (sTempST != "") sLangueDest = sTempST;
            break;
          case "Fournisseur":
            rowLettre["IDdest"] = Utils.ZeroIfNull(currentRow["NINTNUM"]);
            string sTempF = ModuleData.ExecuteScalarString($"SELECT TSTF.VLANGUEABR FROM TSTF INNER JOIN TINT ON TINT.NSTFNUM = TSTF.NSTFNUM WHERE TINT.NINTNUM = {currentRow["NINTNUM"]}");
            if (sTempF != "") sLangueDest = sTempF;
            break;
          case "PC sécurité":
            //Modif du 04/02/2016 : On prend comme référence la liste des service techniques
            rowLettre["IDdest"] = NSERVTECHNUM;
            sLangueDest = "FR"; // pas de gestion de la langue pour les PC sécu
            if (MozartParams.NomSociete == "EMALECLUXEMBOURG") sLangueDest = "EN";
            break;
          default:
            break;
        }

        // par défaut
        if (sLangueDest == "") sLangueDest = "FR";

        string sSite = ModuleData.ExecuteScalarString($"SELECT VSITENSEIGNE FROM TSIT WITH(NOLOCK) WHERE NSITNUM = {miSite}");
        if (sSite != "") mstrSite += $" ({Utils.BlankIfNull(sSite)})";

        // ici on passe en parametre la société source MOZART
        MozartParams.NomSocieteTemp = MozartParams.NomSociete;

        frmSaisieLettre fSaisieL = new frmSaisieLettre();
        fSaisieL.mstrTypeDest = cboType.Text == "PC sécurité" ? "Service Technique" : cboType.Text;
        fSaisieL.lNumAction = MozartParams.NumAction;
        if (optAR0.Checked || optAR1.Checked) fSaisieL.mstrTypeCour = "L";
        else if (optAR2.Checked) fSaisieL.mstrTypeCour = "F";
        if (optAR0.Checked || optAR2.Checked) fSaisieL.mstrTypeAR = "S";
        else if (optAR1.Checked) fSaisieL.mstrTypeAR = "R";
        fSaisieL.iNumCourrier = 0;
        fSaisieL.mstrStatutCourrier = "C";
        if (cboType.Text == "PC sécurité")
        {
          fSaisieL.txtRef.Text = $"DI{MozartParams.NumDi} - {mstrClient} - {mstrSite}";
          fSaisieL.txtObjet.Text = $"{RechercheTradLibre("frmListeCourrierAction", "0", "INFORMATION PASSAGE TECHNICIEN", sLangueDest)} {MozartParams.GetNomSociete()}"; // INFORMATION PASSAGE TECHNICIEN EMALEC
        }
        else if (cboType.Text == "Sous-traitant")
        {
          fSaisieL.txtRef.Text = $"DI{MozartParams.NumDi} - {mstrClient} - {mstrSite}";

          // ajout le 19/09/2019 par mc
          // si on ne coche rien alors on n'affiche vide
          bool itemCoche = false;
          string strCoche = "";

          for (int i = 0; i <= lstTypeCour.Items.Count - 1; i++)
          {
            if (lstTypeCour.GetItemChecked(i))
            {
              strCoche = lstTypeCour.Text;
              itemCoche = true;
              break;
            }
          }
          fSaisieL.txtObjet.Text = itemCoche == false ? "" : strCoche;
        }
        else
        {
          fSaisieL.txtRef.Text = $"DI{MozartParams.NumDi} - {mstrSite}";
          fSaisieL.txtObjet.Text = ""; // lstTypeCour.Text
        }

        fSaisieL.txtCompte.Text = mstrCompte;
        fSaisieL.txtLettre.Text = "";

        string sql_req;
        string txt;
        for (int i = 0; i <= lstTypeCour.Items.Count - 1; i++)
        {
          if (lstTypeCour.GetItemChecked(i) == true)
          {
            sql_req = $"SELECT VLIBLONG from TREF_COURACTION WHERE LANGUE = '{sLangueDest}' AND NTYPNUM ={dt.Rows[i].ItemArray[0]}";
            fSaisieL.txtLettre.Text = GetExpression_SQL_REQUEST_By_Langue(sql_req) + "\r\n";

            if (lstTypeCour.SelectedIndex == 5 && cboType.Text == "Sous-Taitant")
            {
              fSaisieL.txtObjet.Text = RechercheTradLibre("frmListeCourrierAction", "0", "Relance facture et attachement. MISE EN DEMEURE", sLangueDest);

              //recherche du texte du contrat

              txt = $"{RechercheTradLibre("frmListeCourrierAction", "0", "Concernant votre intervention suivante", sLangueDest)} : \r\n{RechercheTradLibre("frmListeCourrierAction", "0", "Date", sLangueDest)} : ";
              txt += $"{mtxtDateA2} \r\n {RechercheTradLibre("frmListeCourrierAction", "0", "Client", sLangueDest)} : {mstrClient} \r\n{RechercheTradLibre("frmListeCourrierAction", "0", "Site", sLangueDest)} : {mstrSite}\r\n";

              using (SqlDataReader sdrSTF = ModuleData.ExecuteReader($"select TCSTPRE from tcst where nactnum={MozartParams.NumAction}"))
              {
                if (sdrSTF.Read())
                {
                  txt += $"{RechercheTradLibre("frmListeCourrierAction", "0", "Prestation", sLangueDest)} : \r\n{ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdrSTF[0]), "RTF")}\r\n";
                }
                else
                {
                  txt += $"{RechercheTradLibre("frmListeCourrierAction", "0", "Prestation", sLangueDest)} : \r\n{mtxtAction}\r\n";
                }
              }
              fSaisieL.txtLettre.Text = $"{txt}\r\n{dt.Rows[i].ItemArray[2]}";
            }
            else if (lstTypeCour.SelectedIndex == 3)
            {
              fSaisieL.txtObjet.Text = $"{RechercheTradLibre("frmListeCourrierAction", "0", "INFORMATION PASSAGE TECHNICIEN", sLangueDest)} {MozartParams.GetNomSociete()}"; //NFORMATION PASSAGE TECHNICIEN EMALEC
              fSaisieL.txtLettre.Text = ReplaceChampByModele(fSaisieL.txtLettre.Text);

            }
            else if (lstTypeCour.SelectedIndex == 4)
            {
              sql_req = $"SELECT VLIBCOURT from TREF_COURACTION WHERE LANGUE = '{sLangueDest}' AND NTYPNUM ={dt.Rows[i].ItemArray[0]}";
              fSaisieL.txtObjet.Text = GetExpression_SQL_REQUEST_By_Langue(sql_req); //lstTypeCour.Text
              fSaisieL.txtLettre.Text = ReplaceChampByModele(fSaisieL.txtLettre.Text);

            }
            else if (lstTypeCour.SelectedIndex == 2)
            {
              // fga le 05/12/23
              //fSaisieL.txtObjet.Text = RechercheTradLibre("frmListeCourrierAction", "0", "Demande de documents administratifs", sLangueDest); //Demande de documents administratifs
              int miStfGrpNnum = Convert.ToInt32(ModuleData.ExecuteScalarString($"SELECT TSTF.NSTFGRPNUM FROM TSTF INNER JOIN TINT ON TINT.NSTFNUM = TSTF.NSTFNUM " +
                                                          $" WHERE TINT.NINTNUM = {miSTFcontact}"));

              GestionRelanceDocAdminSTF(miStfGrpNnum, fSaisieL);
              // dans le cas de relanceDocAdmin, il faut passer le inumstfgrp
              rowLettre["IDdest"] = miStfGrpNnum;
            }
            else
            {
              sql_req = $"SELECT VLIBCOURT from TREF_COURACTION WHERE LANGUE = '{sLangueDest}' AND NTYPNUM ={dt.Rows[i].ItemArray[0]}";
              fSaisieL.txtObjet.Text = GetExpression_SQL_REQUEST_By_Langue(sql_req); //lstTypeCour.Text
            }
          }
        }

        if (cboType.Text == "Sous-traitant" && Utils.ZeroIfNull(rowLettre["IDdest"]) == 0)
        {
          MessageBox.Show("pas de courrier Sous-traitant si pas de sous-traitant sur l'action", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        dtLettre.Rows.Add(rowLettre);

        fSaisieL.dtLettre = dtLettre;

        fSaisieL.ShowDialog();


        ApiGrid.Requery(dtAdoRs, MozartDatabase.cnxMozart);

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public string RechercheTradLibre(string fichier, string ligne, string sCle, string sLangue)
    {
      string returnTradLibre = "";

      string sql = $"SELECT * FROM COMMUN.dbo.TLGMOZART where Fichier = '{fichier}' and Ligne = {ligne} and Chaine = '§{sCle}§'";
      using (SqlDataReader sdr = ModuleData.ExecuteReader(sql))
      {
        if (sdr.Read())
        {
          if (Utils.BlankIfNull(sdr["Chaine" + sLangue]) == "")
          {
            MessageBox.Show("Erreur dans la traduction! (RechercheTradLibre)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            returnTradLibre = sCle;
          }
          else returnTradLibre = sdr["Chaine" + sLangue].ToString();
        }
        else
          MessageBox.Show("Erreur dans la traduction! (RechercheTradLibre) : " + sql, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }

      return returnTradLibre;
    }

    public string GetExpression_SQL_REQUEST_By_Langue(string p_sreq)
    {
      string returnExpress = "";

      using (SqlDataReader sdr = ModuleData.ExecuteReader(p_sreq))
      {
        if (sdr.Read())
        {
          if (Utils.BlankIfNull(sdr[0]) == "")
          {
            MessageBox.Show("Erreur dans la traduction! (GetExpression_SQL_REQUEST_By_Langue)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            returnExpress = "";
          }
          else
          {
            returnExpress = sdr[0].ToString();
          }
        }
        else
          MessageBox.Show("Erreur dans la traduction! (GetExpression_SQL_REQUEST_By_Langue) : " + p_sreq, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }

      return returnExpress;
    }

    private string ReplaceChampByModele(string p_sCorps)
    {
      string returnReplace = "";

      using (SqlDataReader sdrChamp = ModuleData.ExecuteReader($"exec api_sp_RetourChampCourAction {MozartParams.NumAction}"))
      {
        if (sdrChamp.Read())
        {
          returnReplace = p_sCorps.Replace("#VACTDES#", Utils.BlankIfNull(sdrChamp["VACTDES"]));
          returnReplace = returnReplace.Replace("#TECH#", Utils.BlankIfNull(sdrChamp["TECH"]));
          returnReplace = returnReplace.Replace("#DACTPLA#", Utils.BlankIfNull(sdrChamp["DACTPLA"]));
          returnReplace = returnReplace.Replace("#VACTHRRDV#", Utils.BlankIfNull(sdrChamp["VACTHRRDV"]));
        }
      }

      return returnReplace;
    }
    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = ApiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      string lTypeCour = Utils.BlankIfNull(currentRow["CCOURTYPCOUR"]);
      switch (lTypeCour)
      {
        case "A":
          new frmSaisieAttestation
          {
            mstrTypeDest = Utils.BlankIfNull(currentRow["VCOURTYPDEST"]),
            mstrTypeCour = "A",
            mstrTypeAR = Utils.BlankIfNull(currentRow["VCOURTYPAR"]),
            miNumCourrier = Convert.ToInt64(currentRow["NCOURID"]),
            miAction = Convert.ToInt64(currentRow["NACTNUM"]),
            mstrStatutCourrier = "M"
          }.ShowDialog();
          break;

        default:
          // ici on passe en paramètre le nom de la société source MOZART
          MozartParams.NomSocieteTemp = MozartParams.NomSociete;
          new frmModifLettre()
          {
            mstrTypeDest = Utils.BlankIfNull(currentRow["VCOURTYPDEST"]),
            mstrTypeCour = lTypeCour,
            mstrTypeAR = Utils.BlankIfNull(currentRow["VCOURTYPAR"]),
            iNumCourrier = (long)Utils.ZeroIfNull(currentRow["NUMCOUR"]),
            iNumDest = (long)Utils.ZeroIfNull(currentRow["NCOURIDDEST"])
          }.ShowDialog();
          break;
      }

      ApiGrid.Requery(dtAdoRs, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        //suppression
        DataRow currentRow = ApiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_Confirm_courrier_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // ici on passe en paramètres directement le gstrnomsociete car on est obligatoirement sur le mozart de la société source
          ModuleData.SupprimerEnreg((long)Utils.ZeroIfNull(currentRow["NCOURNUM"]), "api_sp_SupprimerCourrier", "@iNumCourrier");
        }
        else
        {
          return;
        }

        ApiGrid.Requery(dtAdoRs, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboType_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        Frame4.Enabled = cmdCreer.Enabled = true;
        if (cboType.Text == "Client" || cboType.Text == "Site")
        {
          Utils.InitComboBox(cboContact, $"select NCCLNUM, VCCLNOM from TCCL WHERE CCCLACTIF='O' AND NCLINUM= { miClient} ORDER BY VCCLNOM");
          cboContact.Visible = lblContact.Visible = true;
          fraSTFO.Visible = false;
        }
        else if (cboType.Text == "Sous-traitant")
        {
          Utils.InitComboBox(cboContact, $"select NINTNUM, VINTNOM from TINT WHERE NINTNUM ={ miSTFcontact} ORDER BY VINTNOM");
          cboContact.Visible = lblContact.Visible = true;
          fraSTFO.Visible = false;
        }
        else if (cboType.Text == "Fournisseur")
        {
          InitialiserListeStFou(Strings.Left(cboType.Text, 1));
          cboContact.Visible = lblContact.Visible = false;
          fraSTFO.Text = cboType.Text + "s";
          fraSTFO.Visible = true;
        }
        else if (cboType.Text == "PC sécurité")
        {
          lblContact.Visible = false;
          using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT NSERVTECHNUM FROM TSIT WITH(NOLOCK) WHERE NSITNUM = {miSite}"))
          {
            if (sdr.Read())
            {
              NSERVTECHNUM = Utils.BlankIfNull(sdr["NSERVTECHNUM"]);
              if (NSERVTECHNUM != "")
              {
                // Recherche si un document préimprimé existe 
                using (SqlDataReader sdrDocument = ModuleData.ExecuteReader($"SELECT VDOCSPECIF, CMULTIDOCSPECIF FROM TSERVTECH WITH(NOLOCK) WHERE NSERVTECHNUM = {NSERVTECHNUM}"))
                {
                  if (sdrDocument.Read())
                  {
                    string VDOCSPECIF = Utils.BlankIfNull(sdrDocument["VDOCSPECIF"]);
                    string CMULTIDOCSPECIF = Utils.BlankIfNull(sdrDocument["CMULTIDOCSPECIF"]);

                    if (VDOCSPECIF != "")
                    {
                      // si un document de renseigné
                      if (CMULTIDOCSPECIF == "1")
                      {
                        // message spécial si le PDF est "multi-document"
                        MessageBox.Show($"Veuillez imprimer le document spécifique qui va s'ouvrir, le compléter et l'envoyer au PC Sécurité.\r\nATTENTION: Le document PDF contient plusieurs documents, n'imprimez que le nécessaire.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      }
                      else MessageBox.Show("Veuillez imprimer le document spécifique qui va s'ouvrir, le compléter et l'envoyer au PC Sécurité.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                      // lancer le PDF
                      string sCheminPDF = ModuleData.RechercheParam("REP_DOCS_SERV_TECH", MozartParams.NomSociete);
                      Process.Start(sCheminPDF + VDOCSPECIF);
                      Frame4.Enabled = cmdCreer.Enabled = false;
                    }
                  }
                  else MessageBox.Show("Problème lors de la recherche du Service Technique.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              }
              else
              {
                MessageBox.Show("Aucun PC Sécurité n'est paramétré pour ce site. Veuillez le paramétrer avant de pouvoir éditer le courrier.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Frame4.Enabled = cmdCreer.Enabled = false;
              }
            }
            else
            {
              MessageBox.Show("Aucun PC Sécurité n'est paramétré pour ce site. Veuillez le paramétrer avant de pouvoir éditer le courrier.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              cmdCreer.Enabled = Frame4.Enabled = false;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    void InitApigrid()
    {
      try
      {
        ApiGrid.AddColumn("Num", "NCOURNUM", 800);
        ApiGrid.AddColumn(Resources.col_Date, "DCOURDAT", 900, "dd/mm/yy");
        ApiGrid.AddColumn(Resources.col_Auteur, "VPERNOM", 1300);
        ApiGrid.AddColumn(Resources.col_nature, "VTYPCOUR", 800);
        ApiGrid.AddColumn(Resources.col_destinataire, "VCOURTYPDEST", 1100);
        ApiGrid.AddColumn(Resources.col_Nom, "Nom", 1500);
        ApiGrid.AddColumn(Resources.col_Contact, "Contact", 1500);
        ApiGrid.AddColumn(Resources.col_Ref, "VCOURREF", 2100);
        ApiGrid.AddColumn(Resources.col_Objet, "VCOUROBJET", 2300);
        ApiGrid.AddColumn(Resources.col_Objet, "CCOURTYPCOUR", 0);
        ApiGrid.AddColumn(Resources.col_Objet, "VCOURTYPAR", 0);
        ApiGrid.AddColumn(Resources.col_Objet, "NCOURID", 0);
        ApiGrid.AddColumn("NumCOUR", "NUMCOUR", 0);
        ApiGrid.AddColumn(Resources.col_iddest, "NCOURIDDEST", 0);
        ApiGrid.AddColumn(Resources.col_Action, "NACTNUM", 0);
        ApiGrid.AddColumn("NumAR", "VCOURNUMAR", 0);

        ApiGrid.InitColumnList();
        return;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void InitialiserListeStFou(string sType)
    {
      try
      {
        // ici on passe en paramètre gstrNomSociete car on est obligatoirement sur une action de la société source
        string sTemp = "";
        if (sType == "F") sTemp = "FO";
        else if (sType == "P") sTemp = "PC";
        else if (sType == "S") sTemp = "ST";
        ApiGridFou.LoadData(dtStFou, MozartDatabase.cnxMozart, $"api_sp_DestCourrier {sTemp},{MozartParams.NomSociete}");
        ApiGridFou.GridControl.DataSource = dtStFou;
        ApiGridFou.dgv.OptionsView.ColumnAutoWidth = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void RemplirLBTypeCourrier(CheckedListBox CLB)
    {
      try
      {
        CLB.Items.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select * from TREF_COURACTION WHERE LANGUE = '{MozartParams.Langue}' ORDER BY VLIBCOURT"))
        {
          dt.Load(sdr);
          sdr.Close();
        }

        CLB.DataSource = dt;
        CLB.DisplayMember = "VLIBCOURT";
        CLB.ValueMember = "NTYPNUM";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FormatGrid()
    {
      try
      {
        ApiGridFou.AddColumn("Num", "NSTFNUM", 0);
        ApiGridFou.AddColumn(Resources.col_Nom, "VSTFNOM", 2500);
        ApiGridFou.AddColumn(Resources.col_Contact, "VINTNOM", 2000);
        ApiGridFou.AddColumn(Resources.col_Adresse1, "VSTFAD1", 0);
        ApiGridFou.AddColumn(Resources.col_Adresse2, "VSTFAD2", 0);
        ApiGridFou.AddColumn(Resources.col_CP, "VSTFCP", 700);
        ApiGridFou.AddColumn(MZCtrlResources.col_Ville, "VSTFVIL", 2000);
        ApiGridFou.AddColumn(Resources.col_Telephone, "VINTTEL", 0);
        ApiGridFou.AddColumn(Resources.col_Portable, "VINTPOR", 0);
        ApiGridFou.AddColumn("NumContact", "VINTNUM", 0);
        ApiGridFou.AddColumn("VSTFOBS", "VSTFOBS", 1500);
        ApiGridFou.AddColumn("NINTNUM", "NINTNUM", 800);

        ApiGridFou.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void GestionRelanceDocAdminSTF(int miStfGrpNnum, frmSaisieLettre frmLettre)
    {
      string sSQL;
      string sLangueABR = "";
      int iAttestFluide = 0;
      bool ConditionGeneral = false;

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
             $"AND (CTYPEDOCSTFOBLIG = 'O' OR (NTYPEDOCSTFNUM = 13) OR (NTYPEDOCSTFNUM = 11 AND {iAttestFluide} > 0))" +
             $"and NTYPEDOCSTFNUM not in (select NTYPEDOCSTFNUM from TDOCSTF where NSTFGRPNUM = {miStfGrpNnum} AND TDOCSTF.BDOCSTFACTIF = 1 " +
             $"and ddocstfedi > getdate()) and NTYPEDOCSTFNUM not in (select (case when CSTFGRPDEC='N' THEN 3 ELSE 0 END) " +
             $"from TSTFGRP where NSTFGRPNUM = {miStfGrpNnum})";


      using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
      {
        if (dr.Read())
        {
          frmLettre.mstrTypeDest = "RelanceDocAdmin";
          frmLettre.mstrTypeCour = "L";
          frmLettre.mstrTypeAR = "S";

          frmLettre.mstrStatutCourrier = "C";
          frmLettre.txtRef.Text = sLangueABR == "FR" ? "Mise à jour documents administratifs" : "Up to date administrative documents";

          // début du courrier
          if (sLangueABR == "FR")
          {
            frmLettre.txtObjet.Text = "Transmission obligatoire de vos documents administratifs manquants";
            frmLettre.txtLettre.Text = "Bonjour,\r\n\r\n Nous avons démarré il y a peu une relation commerciale avec vous.\r\n\r\n" +
              "Afin de finaliser votre intégration dans notre base de donnée, nous n’avons, sauf erreur, pas reçu vos documents :\r\n\r\n";
          }
          else
          {
            frmLettre.txtObjet.Text = "administrative documents";
            frmLettre.txtLettre.Text = "In accordance with the law, we need to ensure the administrative compliance of your company\r\n\r\n" +
                               "Therefore, we need the following documents:\r\n\r\n";
          }

          // boucle sur les documents qui sont manquants ou pas à jour
          do
          {
            // le texte pour les conditions générales d'achats est en dessous, mais pas ici
            if ((int)dr["NTYPEDOCSTFNUM"] == 13)
              ConditionGeneral = true;
            else
              frmLettre.txtLettre.Text += " - " + Utils.BlankIfNull(dr["VTYPEDOCSTFLIB2017"]) + "\r\n\r\n";
  
          } while (dr.Read());

          // fin du courrier
          if (sLangueABR == "FR")
          {
            // uniquement si les conditions générales sont nécessaires
            if (ConditionGeneral)
            {
              frmLettre.txtLettre.Text += "Vous trouverez également ci-joint nos conditions générales d’achats prestataires que nous " +
                "vous demandons de dater, signer et nous renvoyer le document.\r\n\r\n";
            }

            frmLettre.txtLettre.Text += "Nous souhaitons exclusivement les recevoir par mail au format PDF (1 fichier par document demandé) à l'adresse " +
              "Nous souhaitons exclusivement les recevoir par mail au format PDF (1 fichier par document demandé) à l'adresse suivante : stt@emalec.com.\r\n\r\n" +
              "Nous espérons pouvoir construire ensemble, un partenariat durable.\r\n\r\n" +
              "N’hésitez pas à nous contacter pour toutes questions : stt@emalec.com\r\n\r\n" +
              "Nous vous remercions par avance.\r\n\r\nEMALEC\r\n\r\nService Achats";
          }
          else
          {
            frmLettre.txtLettre.Text += $"Please send us a copy of these documents by email in PDF format to : partners@emalec.com\r\n" +
                            $"We need these documents in order to continue sending you new work orders and make sure to be covered " +
                            $"for the works that you carry out.:\r\n";
          }
        }
        else
          MessageBox.Show("Tous les documents de ce sous-traitant sont à jour.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }
  }
}

