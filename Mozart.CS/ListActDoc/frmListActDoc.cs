using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListActDoc : Form
  {
    SaveFileDialog CommonDialofg1 = new SaveFileDialog();

    public frmListActDoc() { InitializeComponent(); }

    public string mstrClient;
    public string mstrSite;
    public string mstrNumDI;
    public string mstrAction;
    public long mlAction;
    public long mlImage;
    public string mstrTypeDoc;
    public string mstrVueWeb;
    public bool mbInterditDepose;

    string strRepImage;
    string strRepAtt;
    string strRepFacSTF;
    string strRepFacCOT;
    string strRepFacRavel;

    DataTable dt = new DataTable();

    Point wbLocation = new Point();
    Size wbSize = new Size();


    private void frmListActDoc_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        txtInfo.Text = Resources.lbl_choisir_nouveau_type_document;

        WebBrowser1.Navigate("about:blank");

        wbLocation = WebBrowser1.Location;
        wbSize = WebBrowser1.Size;

        if (mbInterditDepose)
          cmdAjout.Visible = cmdModifier.Visible = cmdSupprimer.Visible = cmdVueWeb.Visible = false;
        else
        {
          cmdAjout.Visible = cmdModifier.Visible = true;
          if (MozartParams.CodePageDemarrage == "ADD_DOC")
            cmdSupprimer.Visible = cmdVueWeb.Visible = false;
        }

        txtClient.Text = mstrClient;
        txtSite.Text = mstrSite;
        txtDI.Text = mstrNumDI;
        strRepImage = Utils.RechercheParam("REP_PHOTOS_ACT");
        strRepAtt = Utils.RechercheParam("REP_ATTGAM");
        strRepFacSTF = Utils.RechercheParam("REP_FACTURE_STF"); // Facture STT non saisie dans ravel
        strRepFacCOT = Utils.RechercheParam("REP_FACTURE_COTRAIT");
        strRepFacRavel = Utils.RechercheParam("REP_FACT_RAVEL"); // Facture STT saisie dans ravel

        mstrVueWeb = mstrTypeDoc == "Interne" ? "N" : "O";

        ModuleData.LoadData(dt, "exec api_sp_ListeImgAct " + mlAction + ",'" + mstrVueWeb + "'");

        // il faudrait revoir cette gestion pour ce bouton (affichage que pour le client emalec et pour les filiales faciliteam et espagne)
        if (dt.Rows.Count != 0 && mstrClient.Contains("EMALEC FRANCE") &&
           (MozartParams.NomSociete.ToUpper() == "EMALECFACILITEAM" || MozartParams.NomSociete.ToUpper() == "EMALECESPAGNE"))
          cmdFromBelgiqueToEMALEC.Visible = true;

        InitApigrid();

        if (mstrTypeDoc == "Client")
          Label1.Text = Resources.liste_docs_visibles_par_client;
        else if (mstrTypeDoc == "Interne")
          Label1.Text = Resources.liste_docs_non_visibles_par_client;

        ModuleData.RemplirCombo(cboDoc, $"select NTYPEDOC, VTYPEDOCLIB from TREF_TYPEDOC WITH (NOLOCK) WHERE LANGUE = '{MozartParams.Langue}' AND VTYPEDEST = '" +
                                        $"{(mstrTypeDoc.Substring(0, 1) == "C" ? "I" : "C")}' ORDER BY  VTYPEDOCLIB");
        cboDoc.ValueMember = "NTYPEDOC";
        cboDoc.DisplayMember = "VTYPEDOCLIB";

        cmdVueWeb.Text = mstrVueWeb == "O" ? Resources.msg_passer_en_doc_interne : Resources.msg_passer_en_doc_client;

        // On n'autorise l'envoi de mail que pour les visu de docs clients
        if (mstrTypeDoc != "Client" || dt.Rows.Count < 1)
          cmdMail.Visible = false;

        // Gestion des boutons, si cocher attachement avec photos
        cmdGenererPhotoWithAtt.Visible = GetClientAttachementPhotos();
        
      }

      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    public bool GetClientAttachementPhotos()
    {
      bool breturn = false;

      using (SqlDataReader dr = ModuleData.ExecuteReader("exec [api_sp_getCliAttachementPhoto] " + mlAction))
        if (dr.Read())
          breturn = Convert.ToBoolean(dr["BATTACHMARCHPUBLIC"]);

      return breturn;
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      new frmChoixDestMailCli()
      {
        msNACTNUM = mlAction.ToString(),
        msPieceJointe = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST"
                        ? strRepAtt : strRepImage) + row["VFICHIER"].ToString(),
        msNomFichier = row["VFICHIER"].ToString()
      }.ShowDialog();
    }

    private void cmdAnnuler_Click(object sender, EventArgs e)
    {
      frmChoix.Visible = false;
    }

    private void cmdCorrectAttach_Click(object sender, EventArgs e)
    {
      if (dt.Rows.Count == 0) return;

      DataRow row = apigrid.GetFocusedDataRow();

      if (row == null) return;

      if (Convert.ToInt16(apigrid.GetFocusedDataRow()["NTYPEDOC"]) != 29)
      {
        MessageBox.Show(Resources.msg_il_faut_sel_attachement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      WebBrowser1.Navigate("about:blank");

      new FrmCorrectAttach(row["NACTNUM"], row["NIMAGE"]).ShowDialog();
    }

    private void cmdTransfEMASOLAR_Click(object sender, EventArgs e)
    {
      // demande de confirmation
      if (MessageBox.Show("Confirmer la copie du document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {

        // Copie d'un fichier sur les doc techniciens 
        DataRow row = apigrid.GetFocusedDataRow();
        if (row == null) return;

        // FGA le 25/09/24 autres documents sur doc tech
        //if (row["VFICHIER"].ToString().Substring(row["VFICHIER"].ToString().Length - 3).ToUpper() != "PDF")
        //  MessageBox.Show("On ne peut copier que les documents PDF", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //else
        CopieFichier(Convert.ToInt32(row["NIMAGE"]));
      }
    }

    private Int16 TestIfAttachTablet(long p_NACTNUM)
    {
      try
      {
        return Convert.ToInt16(ModuleData.ExecuteScalarInt("EXEC api_sp_AttachProvideTablet " + p_NACTNUM));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return 0;
    }


    private void cmdOK_Click(object sender, EventArgs e)
    {
      if (apigrid.GetFocusedDataRow() == null) return;

      ModuleData.ExecuteNonQuery($"UPDATE TIMAC SET CVUEWEB = '{(mstrVueWeb == "O" ? "N" : "O")}', VTYPEDEST = '{(mstrVueWeb == "O" ? "I" : "C")}', NTYPEDOC = {cboDoc.GetItemData()}  WHERE NIMAGE = " +
                                 $"{apigrid.GetFocusedDataRow()["NIMAGE"]}");

      // Rafraichissement du recordset (ne fonctionne pas)
      //apigrid.Requery(dt, MozartDatabase.cnxMozart);
      ModuleData.LoadData(dt, "exec api_sp_ListeImgAct " + mlAction + ",'" + mstrVueWeb + "'");

      if (dt.Rows.Count == 0)
        WebBrowser1.Navigate("about:blank");

      frmChoix.Visible = false;
    }

    private void cmdAjout_Click(object sender, EventArgs e)
    {
      try
      {
        WebBrowser1.Navigate("about:blank");

        // Passage des paramètres
        new frmxActImg()
        {
          mstrTypeDoc = mstrTypeDoc,
          mstrVueWeb = mstrVueWeb,
          mstrStatut = "C",
          mstrClient = txtClient.Text,
          mstrSite = txtSite.Text,
          mstrDI = txtDI.Text,
          mlAction = mlAction,
          miImage = 0
        }.ShowDialog();

        // Rafraîchissement du Recordset
        //apigrid.Requery(dt, MozartDatabase.cnxMozart);

        ModuleData.LoadData(dt, $"exec api_sp_ListeImgAct {mlAction}, '{mstrVueWeb}'");

        if (mstrTypeDoc == "Client" && dt.Rows.Count >= 1)
          cmdMail.Visible = true;

        cmdFromBelgiqueToEMALEC.Visible = dt.Rows.Count >= 1;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        // Pas de modification des factures sous traitant
        DataRow row = apigrid.GetFocusedDataRow();
        if (row == null) return;

        if (row["VTYPE"].ToString() == "FACTURE" || row["VTYPE"].ToString() == "FACTURECOT" || row["VTYPE"].ToString() == "AVOIR")
        {
          MessageBox.Show(Resources.msg_factures_stt_pas_modifiables, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        WebBrowser1.Navigate("about:blank");

        Thread.Sleep(1000);

        new frmxActImg()
        {
          mstrTypeDoc = mstrTypeDoc,
          mstrVueWeb = mstrVueWeb,
          mstrStatut = "M",
          mstrClient = txtClient.Text,
          mstrSite = txtSite.Text,
          mstrDI = txtDI.Text,
          mlAction = mlAction,
          miImage = Convert.ToInt64(apigrid.GetFocusedDataRow()["NIMAGE"])
        }.ShowDialog();

        ModuleData.LoadData(dt, "exec api_sp_ListeImgAct " + mlAction + ",'" + mstrVueWeb + "'");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apigrid.GetFocusedDataRow();
        if (row == null) return;

        // Pas de suppression des factures des sous-traitants
        if (row["VTYPE"].ToString() == "FACTURE" || row["VTYPE"].ToString() == "FACTURECOT" || row["VTYPE"].ToString() == "AVOIR")
        {
          MessageBox.Show(Resources.msg_fact_stt_pas_supprimees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (MessageBox.Show(Resources.msg_ConfirmDelImg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // fermer le document pour pouvoir le suppprimer
          // il faut faire un dispose du webbrowser car le naavigate ne fonctionne pas
          //WebBrowser1.Navigate("about:blank");

          // supprimer l'enregistrement dans la table
          ModuleData.ExecuteNonQuery("DELETE FROM dbo.TIMAC WHERE NIMAGE = " + row["NIMAGE"]);

          WebBrowser wb = WebBrowser1.CloneControl();
          WebBrowser1.Dispose();
          WebBrowser1 = wb;
          WebBrowser1.Location = wbLocation;
          WebBrowser1.Size = wbSize;
          this.Controls.Add(WebBrowser1);
          WebBrowser1.BringToFront();

          Thread.Sleep(1000);

          // supprimer le fichier physique
          // certain fichiers physiques correspondent à plusieurs enregistrements dans la table TIMAC.
          // donc si on supprime le fichier, cela peut avoir des conséquences sur d'autres enregistrements
          // donc on test si présence de ce fichier dans la table TIMAC
          // avec nb=0 car on a déjà supprimé l'enregistrement du fichier en cours juste au dessus
          int nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(VFICHIER) FROM dbo.TIMAC WHERE VFICHIER = '{row["VFICHIER"].ToString().Replace("'", "''")}'");
          if (nb == 0)
          {
            if (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME")
              File.Delete(strRepAtt + row["VFICHIER"]);
            else
              File.Delete(strRepImage + row["VFICHIER"]);
          }
        }
        else
          return;

        if (mstrTypeDoc != "Client" || dt.Rows.Count < 1)
          cmdMail.Visible = false;

        cmdFromBelgiqueToEMALEC.Visible = dt.Rows.Count >= 1;

        ModuleData.LoadData(dt, "exec api_sp_ListeImgAct " + mlAction + ",'" + mstrVueWeb + "'");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void cmdMax_Click(object sender, EventArgs e)
    {
      if (cmdMax.Text == Resources.txt_Maxi)
      {
        WebBrowser1.Width = Screen.PrimaryScreen.Bounds.Width - 175;
        WebBrowser1.Height = Screen.PrimaryScreen.Bounds.Height - 65;
        WebBrowser1.Top = 30;
        WebBrowser1.Left = 100;
        cmdMax.Text = Resources.txt_Mini;
      }
      else
      {
        WebBrowser1.Location = wbLocation;
        WebBrowser1.Size = wbSize;
        cmdMax.Text = Resources.txt_Maxi;
      }
    }

    private void InitApigrid()
    {
      try
      {
        apigrid.AddColumn(Resources.col_NumImage, "NIMAGE", 0);
        apigrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
        apigrid.AddColumn(Resources.col_Image, "VIMAGE", 3500);
        apigrid.AddColumn(Resources.col_Fichier, "VFICHIER", 0);
        apigrid.AddColumn(Resources.col_CodeFmt, "CFORMAT", 0);
        apigrid.AddColumn(Resources.col_Format, "VFORMAT", 1500);
        apigrid.AddColumn(Resources.col_Commentaire, "VCOMMENT", 1500);
        apigrid.AddColumn("Ouvrir", "BTN_VOIR", 7500, "", 2);
        apigrid.AddColumn(Resources.col_Vueweb, "VTYPE", 0);
        apigrid.AddColumn("NTYPEDOC", "NTYPEDOC", 0);
        apigrid.InitColumnList();
        apigrid.DesactiveListe();
        apigrid.GridControl.DataSource = dt;
        //apigrid_ClickE(null, null);
        cmdModifier.Enabled = cmdSupprimer.Enabled = dt.Rows.Count > 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apigrid_ClickE(object sender, EventArgs e)
    {

      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      if (mbInterditDepose)
        cmdSupprimer.Visible = cmdModifier.Visible = cmdVueWeb.Visible = false;
      else
      {
        cmdVueWeb.Visible = cmdSupprimer.Visible = !(MozartParams.CodePageDemarrage == "ADD_DOC");
        cmdModifier.Visible = true;
      }

      string strFile;
      if (row["VTYPE"].ToString() == "FACTURE")
      {
        // Facture saisie dans ravel ou pas encore saisie
        if (Convert.ToInt32(row["NIMAGE"]) == 0)
          strFile = strRepFacRavel + row["VFICHIER"].ToString();
        else
          strFile = strRepFacSTF + row["VFICHIER"];
      }

      else if (row["VTYPE"].ToString() == "FACTURECOT")
        strFile = strRepFacSTF + row["VFICHIER"];

      else if (row["VTYPE"].ToString() == "RETCHANTIER")
      {
        strFile = GenerateListeArtRetChantier(Convert.ToInt64(row["NIMAGE"]));
        cmdSupprimer.Visible = cmdModifier.Visible = cmdVueWeb.Visible = false;
      }

      else
      {
        strFile = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST" ? strRepAtt : strRepImage) + row["VFICHIER"];
        cmdCorrectAttach.Visible = row["VTYPE"].ToString() == "ATTACH" && TestIfAttachTablet(Convert.ToInt64(row["NACTNUM"])) == 1 && mstrTypeDoc == "Interne"
                                   && ModuleMain.RechercheDroitMenu(cmdCorrectAttach.HelpContextID);
        cmdAffectCertEtanch.Visible = Convert.ToInt16(row["NTYPEDOC"]) == 47; //certificat etancheite
        BtnCorrectCRVP.Visible = Convert.ToInt16(row["NTYPEDOC"]) == 37;  //CRVP
            }

      WebBrowser1.Navigate("about:blank");

      // fichier existe ?
      if (System.IO.File.Exists(strFile))
      {
        WebBrowser1.Navigate(FileTempLocal(strFile));
        //WebBrowser1.Navigate(strFile);
      }
      else
      // le fichier n'existe pas (soit il est archivé soit c'est un problème de doc) 
      {
        if ((int)row["ANNEE"] < 2019 && MozartParams.NomSociete == "EMALEC")
        {
          WebBrowser1.Navigate(FileTempLocal(strRepImage + "Archive.pdf"));
        }
        else
        {
          MessageBox.Show("Le fichier demandé n'existe pas", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      }

    }


    private void cmdVueWeb_Click(object sender, EventArgs e)
    {
      if (dt.Rows.Count == 0) return;

      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      if (Utils.ZeroIfNull(row["NIMAGE"]) == 0)
      {
        MessageBox.Show(Resources.msg_factures_stt_pas_transferables, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // Pas de modification des factures sous traitant
      if (row["VTYPE"].ToString() == "FACTURE" || row["VTYPE"].ToString() == "FACTURECOT" || row["VTYPE"].ToString() == "AVOIR")
      {
        MessageBox.Show(Resources.msg_factures_stt_pas_modifiables, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (Convert.ToInt16(row["NTYPEDOC"]) == 44)
      {
        MessageBox.Show(Resources.msg_plans_préventions_pas_transférables, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (Convert.ToInt16(row["NTYPEDOC"]) == 46)
      {
        MessageBox.Show(Resources.msg_certificat_etancheite_bsd_pas_transferable, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      frmChoix.Visible = MessageBox.Show(mstrVueWeb == "O"
                              ? Resources.msg_attention_doc_plus_visible_sur_web_client
                              : Resources.msg_attention_doc_visible_sur_web_client,
                         Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

      frmChoix.BringToFront();
      cboDoc.SelectedIndex = -1;

      apigrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CopieFichier(int NumFichier)
    {
      string strFichier;
      long lCount;
      string[] ts;
      string strFileTemp = "";
      string TextFic;

      try
      {
        DataRow row = apigrid.GetFocusedDataRow();
        if (row == null) return;

        // Interdiction de copier les factures
        if (row["VTYPE"].ToString() == "FACTURE" || row["VTYPE"].ToString() == "FACTURECOT" || row["VTYPE"].ToString() == "AVOIR")
        {
          MessageBox.Show(Resources.msg_factures_non_transferables_dans_doc_technicien, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // Recherche du chemin physique des fichiers
        strFichier = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" ? strRepAtt : strRepImage) + row["VFICHIER"];

        // Récupération compteur de document
        using (SqlCommand ado_cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
        {
          ado_cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(ado_cmd);

          ado_cmd.Parameters["@cElt"].Value = "IMGACT";
          ado_cmd.Parameters["@iCpt"].Value = 0;

          ado_cmd.ExecuteNonQuery();

          lCount = Convert.ToInt64(ado_cmd.Parameters["@iCpt"].Value);
        }

        // Nommage du fichier
        ts = row["VFICHIER"].ToString().Split(Convert.ToChar("."));

        foreach (string t in ts)
        {
          if (t == ts[ts.Length - 1])
            strFileTemp += t;
          else
            strFileTemp += t + ".";
        }

        TextFic = $"{strFileTemp.Replace(" ", "_")}{lCount}.{ts[ts.Length - 1]}";

        // Recopier le fichier sélectionné sur le serveur
        File.Copy(strFichier, MozartParams.CheminDocTechnicien + TextFic, true);

        // Création de l'enregistrement du fichier dans la base de données
        using (SqlCommand ado_cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          ado_cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(ado_cmd);

          // Liste des paramètres
          ado_cmd.Parameters["@iNIMAGE"].Value = 0;
          ado_cmd.Parameters["@iNACTNUM"].Value = mlAction;
          ado_cmd.Parameters["@vVIMAGE"].Value = "Fichier";
          ado_cmd.Parameters["@vVFICHIER"].Value = Strings.Trim(TextFic);
          ado_cmd.Parameters["@cCFORMAT"].Value = ts[ts.Length - 1];
          ado_cmd.Parameters["@vVCOMMENT"].Value = "";
          ado_cmd.Parameters["@vWEB"].Value = "";
          ado_cmd.Parameters["@vVTYPE"].Value = "DOCTECH";
          ado_cmd.Parameters["@vTypeDest"].Value = "T";
          ado_cmd.Parameters["@nTypeDoc"].Value = 7;

          ado_cmd.ExecuteNonQuery();
          lCount = Convert.ToInt64(ado_cmd.Parameters["@iNIMAGE"].Value);
        }

        MessageBox.Show(Resources.msg_fichier_a_ete_copie_dans_docs_technicien, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private string GenerateListeArtRetChantier(long lNumRetourChantier)
    {
      StringBuilder strHtml = new StringBuilder();
      try
      {
        using (SqlDataReader drImpList = ModuleData.ExecuteReader("SELECT VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, FSTOCKPUHT, NSTOCKQTE FROM TSTOCK INNER JOIN TFOU ON TSTOCK.NFOUNUM = TFOU.NFOUNUM" +
                                                                  $" INNER JOIN TSTOCKRETOUR ON TSTOCKRETOUR.NSTOCKNUM = TSTOCK.NSTOCKNUM WHERE TSTOCKRETOUR.NRETNUM = {lNumRetourChantier}"))
        {
          strHtml.Append("<html><head><title> </title></head><body>\r\n");
          if (drImpList.Read())
          {
            // Titre du document
            strHtml.Append($@"<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>{ MozartParams.NomSociete} </H2></TD>");
            strHtml.Append("<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Liste des articles d'un retour chantier :</CENTER></H3></TD>");
            strHtml.Append($"<TD width=15%><H3>le {DateTime.Now.ToString("dd/MM/yyyy")}</H3></TD></TR></TABLE>");

            // Tableau des jours du mois
            strHtml.Append("<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>\r\n");
            strHtml.Append("<td width=18% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Matériel</b></FONT></td>");
            strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Marque</b></FONT></td>");
            strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Type</b></FONT></td>");
            strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Référence</b></FONT></td>");
            strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Prix U</b></FONT></td>");
            strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Quantité</b></FONT></td>");
            strHtml.Append("</tr>\r\n");

            do
            {
              // Personne  et planning de cette personne
              strHtml.Append("<tr><td bgcolor=white><font face=Arial size=1>" + drImpList["VFOUMAT"] + "</FONT></td> ");
              strHtml.Append("<td bgcolor=white><font face=Arial size=1>" + drImpList["VFOUMAR"] + "</FONT></td> ");
              strHtml.Append("<td bgcolor=white><font face=Arial size=1>" + drImpList["VFOUTYP"] + "</FONT></td> ");
              strHtml.Append("<td bgcolor=white><font face=Arial size=1>" + drImpList["VFOUREF"] + "</FONT></td> ");
              strHtml.Append("<td bgcolor=white align='right'><font face=Arial size=1>" + drImpList["FSTOCKPUHT"] + "</FONT></td> ");
              strHtml.Append("<td bgcolor=white align='right'><font face=Arial size=1>" + drImpList["NSTOCKQTE"] + "</FONT></td> ");
              strHtml.Append("</tr>\r\n");

            } while (drImpList.Read());

            strHtml.Append("</table>\r\n");
          }

          File.WriteAllText($@"{MozartParams.CheminUtilisateurMozart}tlistretchant.html", strHtml.ToString(), Encoding.UTF8);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return MozartParams.CheminUtilisateurMozart + "tlistretchant.html";
    }

    private void cmdFromBelgiqueToEMALEC_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();

      if (row == null) return;

      int NumActEMALEC = 0;
      try
      {
        using (SqlCommand ado_cmd = new SqlCommand("api_sp_CopieDocInterneToEMALEC", MozartDatabase.cnxMozart))
        {
          ado_cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(ado_cmd);

          ado_cmd.Parameters["@numActionFiliale"].Value = mlAction;
          ado_cmd.Parameters["@nImageSource"].Value = row["NIMAGE"];

          ado_cmd.ExecuteNonQuery();

          // Récupération du n° d'action EMALEC, si existe
          NumActEMALEC = Convert.ToInt32(ado_cmd.Parameters[0].Value);
        }

        // Copie du fichier si OK
        if (NumActEMALEC == 0)
          MessageBox.Show(Resources.msg_aucune_action_correspondance_emalec, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
        {
          string strFile;

          if (row["VTYPE"].ToString() == "FACTURE")
            strFile = strRepFacSTF + row["VFICHIER"];
          else if (row["VTYPE"].ToString() == "FACTURECOT")
            strFile = strRepFacCOT + row["VFICHIER"];
          else
            strFile = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST" ? strRepAtt : strRepImage) + row["VFICHIER"];

          string newfile = strFile.Replace(mlAction.ToString(), NumActEMALEC.ToString()).Replace(MozartParams.NomSociete.ToUpper(), "EMALEC").ToUpper();
          File.Copy(strFile, newfile, true);

          // Insert dans la table TACTTABLETFILIALE
          ModuleData.ExecuteNonQuery($"insert into TACTTABLETFILIALE (VFILIALE, NACTNUM, VRMQ, DDATET) VALUES ('{MozartParams.NomSociete.ToUpper()}', {NumActEMALEC}, 'Copie de document', GetDate())");

          MessageBox.Show(Resources.msg_doc_duplique_dans_emalec, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdTampon_Click(object sender, EventArgs e)
    {
      //DataRow row = apigrid.GetFocusedDataRow();

      //if (row == null) return;

      //int NCLINUM = Convert.ToInt32(ModuleData.ExecuteScalarInt($"SELECT TSIT.NCLINUM FROM TACT WITH(NOLOCK) INNER JOIN TSIT WITH(NOLOCK) " +
      //                                                           $"ON TSIT.NSITNUM = TACT.NSITNUM WHERE TACT.NACTNUM = {mlAction}"));
      //// Client XEROX
      ////  TB SAMSIC CITY SPEC
      //if (NCLINUM == 13891 && MozartParams.NomGroupe == "EMALEC")
      //{
      //  // Si devis client
      //  if (Convert.ToInt16(row["NTYPEDOC"]) == 4)
      //  {
      //    if (MessageBox.Show(Resources.msg_voulez_vous_tamponner_doc, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      //    {
      //      WebBrowser1.Navigate("about:blank");
      //      Size pdfSize = WebBrowser1.Size;
      //      Point pdfLocation = WebBrowser1.Location;
      //      AnchorStyles pdfAnchor = WebBrowser1.Anchor;
      //      WebBrowser1.Dispose();
      //      WebBrowser1 = null;
      //      WebBrowser1 = new WebBrowser();
      //      WebBrowser1.Size = pdfSize;
      //      WebBrowser1.Location = pdfLocation;
      //      WebBrowser1.Anchor = pdfAnchor;
      //      this.Controls.Add(WebBrowser1);

      //      new frmMail_Devis_Tampon($"{mRepertoireDoc}{row["VFICHIER"]}").ShowDialog();

      //      WebBrowser1.Navigate(mRepertoireDoc + row["VFICHIER"]);

      //      MessageBox.Show(Resources.msg_devis_tamponne, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //    }
      //  }
      //  else
      //    MessageBox.Show("On ne peut tamponner qu'un document de type \"Devis Client\"", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //}
      //else
      //  MessageBox.Show(Resources.msg_fonct_spe_a_xerox, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    //Private Sub CmdTampon_Click()
    //    
    //    If adoRS.EOF Then Exit Sub
    //    
    //    'on test si nclinum = xerox
    //    'If mlAction = 0 Then
    //    Dim rsClient As New ADODB.Recordset
    //    Dim sSql As String
    //    Dim NCLINUM As Long
    // 
    //     'INIT
    //     NCLINUM = 0
    //    sSql = "SELECT TSIT.NCLINUM FROM TACT WITH(NOLOCK) INNER JOIN TSIT WITH(NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM WHERE TACT.NACTNUM = " & mlAction
    //    rsClient.Open sSql, cnx, adOpenDynamic, adLockOptimistic
    //    
    //    While rsClient.EOF = False
    //        NCLINUM = rsClient("NCLINUM")
    //        rsClient.MoveNext
    //    Wend
    //    
    //    rsClient.Close
    //    Set rsClient = Nothing
    //    
    //    'Client XEROX
    //    ' TB SAMSIC CITY SPEC
    //    If NCLINUM = 13891 And gstrNomGroupe = "EMALEC" Then
    //         
    //      'si devis client
    //      If adoRS("NTYPEDOC") = 4 Then
    //      
    //          If MsgBox("§Voulez-vous tamponner le document ?§", vbYesNoCancel + vbQuestion) = vbYes Then
    //          
    //              WebBrowser1.Navigate2 "about:blank"
    //              
    //              VerifMOZARTNET
    //    
    //              If Not gModeActiveX Then
    //                ShellAndWait gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmMail_Devis_Tampon" & " " & mRepertoireDoc & adoRS("VFICHIER").value, vbHide
    //              Else
    //                OpenNetFormAndWait gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmMail_Devis_Tampon" & " " & mRepertoireDoc & adoRS("VFICHIER").value, vbHide
    //              End If
    //              
    //              WebBrowser1.Navigate2 mRepertoireDoc & adoRS("VFICHIER").value
    //          
    //              MsgBox "§Devis tamponné§", vbInformation
    //          
    //          End If
    //    
    //        Else
    //        
    //            MsgBox "§On ne peut tamponné qu' document de type 'devis client'", vbExclamation
    //    
    //      End If
    //
    //    Else
    //    
    //        MsgBox "§Fonctionnalité spécifique au client XEROX§", vbExclamation
    //
    //    End If
    //
    //End Sub

    //' Start the indicated program and wait for it
    //' to finish, hiding while we wait.

    private void cmdGenererPhotoWithAtt_Click(object sender, EventArgs e)
    {

      DataRow row = apigrid.GetFocusedDataRow();

      if (row == null) return;

      if ((int)row["NTYPEDOC"] != 1 && (int)row["NTYPEDOC"] != 29)
      {
        MessageBox.Show("Il faut sélectionner un attachement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (MessageBox.Show(Resources.msg_generer_att_avec_photos_doc_client, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

      WebBrowser1.Navigate("about:blank");

      Int16 CodeReturnAttahcProvide = TestIfAttachTablet(Convert.ToInt64(row["NACTNUM"]));

      //on test si l'attachement existe en base de données technicien
      if (CodeReturnAttahcProvide == 0)
      {
        MessageBox.Show("Vous ne pouvez pas générer d'attachement avec des photos car l'attachement ne provient pas d'un attachement technicien ou d'un attachement du sous-traitant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //si attachment st car st existant
      if (CodeReturnAttahcProvide == 2)
      {
        //test si attachment du St est en PDF car il va etre concat avec les photos
        if (Path.GetExtension((string)row["VFICHIER"]).ToUpper() != ".PDF")
        {
          MessageBox.Show("Vous ne pouvez pas générer d'attachement avec des photos car l'attachement du sous-traitant n'est pas au formt PDF", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }

      new frmGenAttachementWithPhotosSelectPhotos(mlAction, (string)row["VFICHIER"], (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST" ? strRepAtt : strRepImage), row["NIMAGE"], CodeReturnAttahcProvide).ShowDialog();
    }
    //Private Sub Command1_Click()
    //
    //    If MsgBox("§Voulez-vous générer l'attachement avec les photos de doc client ?§", vbYesNoCancel + vbQuestion) = vbYes Then
    //    
    //        WebBrowser1.Navigate2 "about:blank"
    //        
    //        VerifMOZARTNET
    //    
    //        If Not gModeActiveX Then
    //          ShellAndWait gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmGenAttachementWithPhotosSelectPhotos" & " " & mlAction, vbNormalFocus
    //        Else
    //          OpenNetFormAndWait gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmGenAttachementWithPhotosSelectPhotos" & " " & mlAction, vbNormalFocus
    //        End If
    //    
    //    End If
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdAffectCertEtanch_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();

      if (row == null) return;

      new frmAffectationCertificatEtancheite(row["NIMAGE"], mlAction).ShowDialog();
    }

    private void apigrid_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {

      if (e.Column.FieldName == "BTN_VOIR")
      {
        DataRow row = apigrid.GetFocusedDataRow();
        if (row == null) return;

        if (mbInterditDepose)
          cmdSupprimer.Visible = cmdModifier.Visible = cmdVueWeb.Visible = false;
        else
        {
          cmdVueWeb.Visible = cmdSupprimer.Visible = !(MozartParams.CodePageDemarrage == "ADD_DOC");
          cmdModifier.Visible = true;
        }

        string strFile;
        if (row["VTYPE"].ToString() == "FACTURE")
        {
          // Facture saisie dans ravel ou pas encore saisie
          if (Convert.ToInt32(row["NIMAGE"]) == 0)
            strFile = strRepFacRavel + row["VFICHIER"].ToString();
          else
            strFile = strRepFacSTF + row["VFICHIER"];
        }

        else if (row["VTYPE"].ToString() == "FACTURECOT")
          strFile = strRepFacSTF + row["VFICHIER"];

        else if (row["VTYPE"].ToString() == "RETCHANTIER")
        {
          strFile = GenerateListeArtRetChantier(Convert.ToInt64(row["NIMAGE"]));
          cmdSupprimer.Visible = cmdModifier.Visible = cmdVueWeb.Visible = false;
        }

        else
        {
          strFile = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST" ? strRepAtt : strRepImage) + row["VFICHIER"];
          cmdCorrectAttach.Visible = row["VTYPE"].ToString() == "ATTACH" && TestIfAttachTablet(Convert.ToInt64(row["NACTNUM"])) == 1 && mstrTypeDoc == "Interne"
                                     && ModuleMain.RechercheDroitMenu(cmdCorrectAttach.HelpContextID);
          cmdAffectCertEtanch.Visible = Convert.ToInt16(row["NTYPEDOC"]) == 47;
        }


        Process.Start("msedge.exe", FileTempLocal(strFile).Replace(" ", "%20"));

      }

    }

    private string FileTempLocal(string sfile_src)
    {

      string fileName_out = Path.GetTempFileName();
      FileInfo fileInfo = new FileInfo(fileName_out);
      fileInfo.Attributes = FileAttributes.Temporary;

      File.Copy(sfile_src, fileName_out, true);

      string sNewTempFile = $"{fileName_out}.Mozart{Path.GetExtension(sfile_src)}";
      File.Move(fileName_out, sNewTempFile);

      return sNewTempFile;

    }


    private void apigrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.FieldName == "BTN_VOIR")
      {
        e.Appearance.ForeColor = Color.Blue;
        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily.Name, e.Appearance.Font.Size, FontStyle.Underline);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

        private void BtnCorrectCRVP_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0) return;

            DataRow row = apigrid.GetFocusedDataRow();

            if (row == null) return;

            if (Convert.ToInt16(apigrid.GetFocusedDataRow()["NTYPEDOC"]) != 37)
            {
                MessageBox.Show("Il faut sélectionner un CRVP", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            WebBrowser1.Navigate("about:blank");
            //while (WebBrowser1.ReadyState != WebBrowserReadyState.Complete)
            //{
            //    Application.DoEvents();
            //}

            new frmCorrectionCRVP((int)row["NACTNUM"]).ShowDialog();
        }
    }
}