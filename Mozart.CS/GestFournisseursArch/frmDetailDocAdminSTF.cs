using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailDocAdminSTF : Form
  {
    public long miDocAdminSTFNum = 0;
    public long miSTFGRPNUM = 0;
    public string mstrNom = "";
    bool mbModFile;
    bool mbArchive;

    public frmDetailDocAdminSTF() { InitializeComponent(); }

    private void frmDetailDocAdminSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Label2.Text = mstrNom;

        //Init
        mbModFile = false;
        mbArchive = false;
        ModuleData.RemplirCombo(cboTypeDoc, $"SELECT NTYPEDOCSTFNUM, VTYPEDOCSTFLIB FROM TREF_TYPEDOCSTF WHERE VLANGUE = '{MozartParams.Langue}' AND CTYPEDOCSTFACTIF = 'O'");
        cboTypeDoc.ValueMember = "NTYPEDOCSTFNUM";
        cboTypeDoc.DisplayMember = "VTYPEDOCSTFLIB";
        cboTypeDoc.SelectedIndex = 0;
        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      cmdEnregistrer.Enabled = false;
      try
      {
        //On enregistre le fichier
        if (DateValidite.Text == "")
        {
          MessageBox.Show(Resources.msg_Format_date_incorrect);
          return;
        }

        if (txtFic.Text == "")
        {
          MessageBox.Show(Resources.msg_Select_PDF_file);
          return;
        }

        if (cboTypeDoc.Text == "")
        {
          MessageBox.Show(Resources.msg_Select_type_doc);
          return;
        }

        //gestion de l'archivage auto du 05/11/13 vu avec JJ
        //on ajoute parfois des documents de date plus ancienne(pour des assurances de travaux)
        //donc lors de l'ajout d'un doc, on ne peut pas archiver automatiquement le dernier doc si la date est antéieure.
        if (miDocAdminSTFNum == 0)
        {
          //on recherche le document de même type avec la date de validité

          using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT ddocstfedi FROM TDOCSTF WITH(NOLOCK) WHERE  NSTFGRPNUM = {miSTFGRPNUM} AND NTYPEDOCSTFNUM = {cboTypeDoc.GetItemData()} AND BDOCSTFACTIF = 1"))
          {
            if (dr.Read())
            {
              DateTime ddocstfedi = Convert.ToDateTime(dr[0]);
              if (ddocstfedi > DateTime.Parse(DateValidite.Text))
              {
                // on ajoute un doc plus ancien que celui en place, donc on archive celui que l'on ajoute
                MessageBox.Show(Resources.msg_Ajout_new_doc_validite_date_anterieur_a_doc_present + "\r\n" + Resources.msg_Doc_auto_archived);
                mbArchive = true;
              }
              else
              {
                //on archive l'ancien doc car on va le remplacer par le nouveau
                ArchivageAutoDoc(miSTFGRPNUM, cboTypeDoc.GetItemData());
              }
            }
          }
        }
        //DateTime ddocstfedi = Convert.ToDateTime(ModuleData.ExecuteScalarString($"SELECT ddocstfedi FROM TDOCSTF WITH(NOLOCK) WHERE  NSTFGRPNUM = {miSTFGRPNUM} AND NTYPEDOCSTFNUM = {cboTypeDoc.GetItemData()} AND BDOCSTFACTIF = 1"));

        //si on change le fichier, génération d'un numéro unique pour le nom physique
        string sNomFichier;
        if (mbModFile == true)
          sNomFichier = DateTime.Now.ToString("yyyyddmmhhmmss") + "_" + miSTFGRPNUM + "." + Strings.Right(txtFic.Text, 3);
        else
          sNomFichier = txtFic.Text;

        //enregistrement du document
        Enregistrer(sNomFichier);
        //si c'est un document plus ancien que l'on ajoute, on l'archive

        //Copie du fichier dans le répertoire de prod si c'est un nouveau fichier
        //Recopier le fichier sélectionné sur le serveur
        if (mbModFile == true)
          File.Copy(CommonDialog1.FileName, Utils.RechercheParam("REP_DOC_STF") + sNomFichier, true);

        mbModFile = mbArchive = false;

        Dispose(); // 03/04/2017 : On sort
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        CommonDialog1.Filter = "Fichier PDF|*.PDF";
        CommonDialog1.ShowDialog();
        if (CommonDialog1.FileName != "")
        {
          //on teste si le nom du fichier a changé
          mbModFile = txtFic.Text == CommonDialog1.SafeFileName ? false : true;
          txtFic.Text = CommonDialog1.SafeFileName;
          cmdEnregistrer.Enabled = true;

          WebBrowser1.Navigate(CommonDialog1.FileName);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        //  Recherche des infos du documents si existe déjà
        if (miDocAdminSTFNum > 0)
        {
          //cboTypeDoc.Enabled = false;

          using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC api_sp_InfoDocAdminSTF " + miDocAdminSTFNum.ToString()))
          {
            while (dr.Read())
            {
              DateValidite.Text = Utils.DateBlankIfNull(dr["DDOCSTFEDI"]);
              txtFic.Text = Utils.BlankIfNull(dr["VDOCSTFNOM"]);
              cboTypeDoc.SetItemData(dr["NTYPEDOCSTFNUM"].ToString());
              //visualisation du fichier
              WebBrowser1.Navigate($"{Utils.RechercheParam("REP_DOC_STF")}{dr["VDOCSTFNOM"]}");
            }
          }
        }
        else
          CmdFind.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Enregistrer(string NomFichier)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDocAdminSTF", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@p_ndocstfnum"].Value = miDocAdminSTFNum;   // 0 si création
          cmd.Parameters["@p_nstfgrpnum"].Value = miSTFGRPNUM;
          cmd.Parameters["@p_ntypedocnum"].Value = cboTypeDoc.GetItemData();
          cmd.Parameters["@p_vdocfile"].Value = NomFichier;
          cmd.Parameters["@p_vcomment"].Value = "";
          cmd.Parameters["@p_ddocstfedi"].Value = DateValidite.Text;
          cmd.Parameters["@p_bArchive"].Value = !mbArchive;

          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          miDocAdminSTFNum = Convert.ToInt64(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ArchivageAutoDoc(long P_NSTFGRPNUM, int P_NTYPEDOC)
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC api_sp_ArchivageAutoDocSTF {P_NSTFGRPNUM.ToString()}, {P_NTYPEDOC.ToString()}"))
      {
        if (dr.HasRows)
        {
          MessageBox.Show(Resources.msg_Note_tous_doc_type + " '" + cboTypeDoc.Text + "' " + Resources.msg_du_sous_traitant_seront_arch, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          while (dr.Read())
          {
            //archivage auto
            ModuleData.ExecuteNonQuery($"UPDATE TDOCSTF SET BDOCSTFACTIF = 0 WHERE NDOCSTFNUM = {dr["NDOCSTFNUM"]}");
          }
        }
      }
    }
  }
}