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
  public partial class frmDetailDocComSTF : Form
  {
    public long miNumDoc = 0;
    public long miSTFGRPNUM = 0;
    public string mstrNom = "";
    bool mbModFile;

    public frmDetailDocComSTF() { InitializeComponent(); }

    private void frmDetailDocAdminSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Label2.Text = mstrNom;

        //Init
        mbModFile = false;
        Ouverture();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {

      try
      {
        //On enregistre le fichier
        //if (txtDate.Text == "" || Utils.IsDate(txtDate.Text) == false)
        //{
        //  MessageBox.Show(Resources.msg_Format_date_incorrect);
        //  txtDate.Focus();
        //  return;
        //}

        if (txtNomDoc.Text == "")
        {
          MessageBox.Show("Saisir un nom de fichier");
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

        //en création génération d'un nom unique pour le fichier physique
        string sNomFichier;
        if (mbModFile == true)
          //         sNomFichier = $"{DateTime.Now.ToString("yyyyddmmhhmmss")}_{miSTFGRPNUM}.{Strings.Right(txtFic.Text, 3)}";
          sNomFichier = $"{DateTime.Now.ToString("yyyyddmmhhmmss")}_{miSTFGRPNUM}.{Path.GetExtension(txtFic.Text)}";
        else
          sNomFichier = txtFic.Text;

        //enregistrement du document
        Enregistrer(sNomFichier);

        //Recopier le fichier sélectionné sur le serveur
        if (mbModFile == true)
          File.Copy(CommonDialog1.FileName, Utils.RechercheParam("REP_DOC_COND_COM_STF") + sNomFichier, true);

        // fermeture du fichier
        WebBrowser1.Navigate("");

        // fermeture form
        Dispose();

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
        CommonDialog1.Filter = "Fichiers  |*.PDF;*.XLSX;*.XLS;*.DOC;*.DOCX";
        CommonDialog1.ShowDialog();
        if (CommonDialog1.FileName != "")
        {
          //on teste si le nom du fichier a changé
          mbModFile = txtFic.Text == CommonDialog1.SafeFileName ? false : true;
          txtFic.Text = CommonDialog1.SafeFileName;

          WebBrowser1.Navigate(CommonDialog1.FileName);
        }
      }

      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Ouverture()
    {
      try
      {
        // chargement combo type doc
        ModuleData.RemplirCombo(cboTypeDoc, $"SELECT NID, VLIBELLE FROM TREF_TYPEDOCCOMSTF");
        cboTypeDoc.ValueMember = "NID";
        cboTypeDoc.DisplayMember = "VLIBELLE";
        cboTypeDoc.SelectedIndex = 0;

        //  Recherche des infos du documents en modification
        if (miNumDoc > 0)
        {
          using (SqlDataReader dr = ModuleData.ExecuteReader($"select * from TDOCSTFCONDCOM where NIDDOCSTFCONDCOM={miNumDoc}"))
          {
            while (dr.Read())
            {
              txtNomDoc.Text = Utils.BlankIfNull(dr["VTITLE"]);
              txtFic.Text = Utils.BlankIfNull(dr["VFILE"]);
              if (dr["DDATEDOC"] != DBNull.Value) txtDateSignature.DateTime = (DateTime)dr["DDATEDOC"];
              cboTypeDoc.SetItemData(dr["NTYPEDOC"].ToString());
              //visualisation du fichier
              WebBrowser1.Navigate($"{Utils.RechercheParam("REP_DOC_COND_COM_STF")}{dr["VFILE"]}");
            }
          }
        }
        else
          // en création uniquement on peut choisir un document
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
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDocComSTF", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@P_NIDDOCSTFCONDCOM"].Value = miNumDoc;   // 0 si création
          cmd.Parameters["@P_NSTFGRPNUM"].Value = miSTFGRPNUM;
          cmd.Parameters["@P_NTYPEDOC"].Value = cboTypeDoc.GetItemData();
          cmd.Parameters["@P_VFILENAME"].Value = NomFichier;
          cmd.Parameters["@P_VTITLE"].Value = txtNomDoc.Text;
          if (txtDateSignature.Text != "") cmd.Parameters["@P_DDoc"].Value = txtDateSignature.Text;

          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          miNumDoc = Convert.ToInt64(cmd.Parameters[0].Value);

          // gestion des critères SSE
          // Aspirant : A
          // Partenaire : P
          if (cboTypeDoc.GetItemData() == 5 || cboTypeDoc.GetItemData() == 6)
          {
            string CodeType = cboTypeDoc.GetItemData() == 5 ? "A" : "P";
            ModuleData.ExecuteReader($"Update TSTFGRP set CSTFGRPTYPE = '{CodeType}', DSTFGRPTYPE=Getdate(), NSTFGRPQUITYPE = dbo.[GetUserID]() " +
                                  $"where NSTFGRPNUM = {miSTFGRPNUM}");
          }


        }
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

  }
}