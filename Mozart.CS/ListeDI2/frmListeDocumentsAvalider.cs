using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.Pdf;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeDocumentsAvalider : Form
  {
    DataTable dt = new DataTable();

    string CheminDocATraiter = "";
    DataRow Selectedrow;
    private string TypeMail;

    public frmListeDocumentsAvalider() { InitializeComponent(); }

    private void frmSousTenCours_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        CheminDocATraiter = ModuleData.RechercheParam("REP_DOCUMENTS_A_VALIDER", MozartParams.NomSociete);

        //ouverture du recordset
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeDocAvalider");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn("Type document", "VDOCTYPE", 1600, "", 2);
      apiTGrid1.AddColumn(Resources.col_NomSTT, "VSTFNOM", 2000);
      apiTGrid1.AddColumn("Date", "DDOCCRE", 1500, "", 2);
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 1300, "", 2);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1600, "", 2);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1600);
      apiTGrid1.AddColumn(Resources.col_Chaff, "CHAFF", 1600);
      apiTGrid1.AddColumn(Resources.col_ChefGroupe, "CHEFF", 1600);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 5000);

      apiTGrid1.InitColumnList();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Selectedrow = apiTGrid1.GetFocusedDataRow();
      if (Selectedrow == null) return;

      // pas de traitement pour les documents inconnus
      if (Selectedrow["VDOCTYPE"].ToString() == "INCONNU")
      {
        MessageBox.Show("Pas de validation automatique possible pour ce document. \r\n Vous devez le traiter  manuellement.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // validation du pps par le chaff de la di ou bien de tous les chefs de groupe
      // recherche de ces personnes et compare avec gintuid
      //  BARBOSA, DALBEPIERRE, roussillion, VIGIEUR,  bouyssi, Dumont.
      int[] ListeChefDeGroupe = { 226, 300, 1837, 1843, 3497, 3766, 4021, 4493, 3936 };


      if (MozartParams.UID == Convert.ToInt32(Selectedrow["NCHAFF"]) || MozartParams.UID == Convert.ToInt32(Selectedrow["NCHEFF"]) || (Array.Exists(ListeChefDeGroupe, element => element == MozartParams.UID)))
      {
        // demande de confirmation de la validation
        if (MessageBox.Show("Voulez-vous confirmer la validation du PPS ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;
      }
      else
      {
        MessageBox.Show("Ce document ne peut être validé que par le chaff du client ou un chef de groupe.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      //test si le document est déjà pris en traitement 
      if (ModuleData.ExecuteScalarInt($"SELECT BDOCLOCK FROM TDOCUMENTS WHERE NIDDOCUMENT={Selectedrow["NIDDOCUMENT"]}") == 1)
      {
        MessageBox.Show("Ce document est déjà en cours de traitement", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // blocage du document durant  le traitement  
      ModuleData.CnxExecute($"UPDATE TDOCUMENTS SET BDOCLOCK=1 WHERE NIDDOCUMENT={Convert.ToInt32(Selectedrow["NIDDOCUMENT"])}");

      //ajout de la date, du nom du valideur et de la case validation sur le document
      // lock du document (fermeture des champs de formulaire)
      SignatureDocument(CheminDocATraiter + Selectedrow["VDOCFILE"].ToString(), MozartParams.strUID);

      // transfert dans les docs internes de l'action en type PPS
      EnregistrerDocument(CheminDocATraiter + Selectedrow["VDOCFILE"].ToString(), Convert.ToInt32(Selectedrow["NACTNUM"]));

      // mise à jour de la table DOCUMENTS avec les infos de traitement
      ModuleData.CnxExecute($"UPDATE TDOCUMENTS SET VDOCSTATUT='V', NQUITRAITE={MozartParams.UID}, DDOCTRAITE=GetDate() WHERE NIDDOCUMENT={Convert.ToInt32(Selectedrow["NIDDOCUMENT"])}");

      // information dans l'action de la validation du PPS par le chaff
      string sSqlr = "update TACT set VACTOBS = 'Réception du PPS n° " + Selectedrow["NIDPPS"].ToString() + " le ";
      sSqlr += DateTime.Now.ToShortDateString() + " par " + MozartParams.strUID + ".' + char(13) + char(10) +";
      sSqlr += " COALESCE(VACTOBS, '') Where NACTNUM = " + Convert.ToInt32(Selectedrow["NACTNUM"]);
      ModuleData.CnxExecute(sSqlr);

      // mise à jour du statut du PPS (reçu)
      ModuleData.CnxExecute($"UPDATE TACTCOMP SET NACTPPS = 1 WHERE NACTNUM = {Convert.ToInt32(Selectedrow["NACTNUM"])}");

      //renvoi du document validé au STT ?
      MessageBox.Show("Vous devez envoyer le PPS validé au sous-traitant.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

      // choix du destinataire et envoi du mail
      // liste des destinataires
      lstDest.Items.Clear();
      SqlDataReader mRs = ModuleData.ExecuteReader($"EXEC api_sp_listeDestMailFromTable 'TINT', 'NINTNUM', {Selectedrow["NINTNUM"]}");

      while (mRs.Read())
        lstDest.Items.Add(mRs[0]);
      mRs.Close();

      // sujet
      txtSujet.Text = $"Plan de prévention simplifié n° {Selectedrow["NIDPPS"]} signé pour la Di {Selectedrow["NDINNUM"]} :  {Selectedrow["VSITENSEIGNE"]} / {Selectedrow["VSITNOM"]}.";

      // message
      txtMessage.Text = $"Bonjour, \r\n\r\nVeuillez trouver ci-joint le Plan de prévention simplifié n° {Selectedrow["NIDPPS"]} validé et signé. \r\n\r\n" +
        $" DI : {Selectedrow["NDINNUM"]} \r\n Client : {Selectedrow["VSITENSEIGNE"]} \r\n Site : {Selectedrow["VSITNOM"]}. \r\n\r\n" +
        $" Prestation : { Selectedrow["VACTDES"]}";

      TypeMail = "ENVOI_PPS";

      // affichage de la liste des destinataires
      panel1.Visible = true;
    }

    private void EnvoyerMail()
    {
      bool bOK = false;
      string sListeDest = "";

      try
      {
        if (txtMessage.Text == "" || txtSujet.Text == "")
        {
          MessageBox.Show(Resources.msg_SubjectAndMessageRequired, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        foreach (string item in lstDest.CheckedItems)
        {
          bOK = true;
          sListeDest += item.Substring(0, item.IndexOf("(") - 1) + ";";
        }

        if (txtAdrMail.Text.IndexOf("@") > 0)
        {
          bOK = true;
          sListeDest += txtAdrMail.Text;
        }

        if (bOK == false)
          MessageBox.Show(Resources.msg_MustChooseDest, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
        {

          string sPJ = @"\\" + MozartParams.NomServeur + @"\PJMail\" + Selectedrow["VDOCFILE"].ToString();
          File.Copy(CheminDocATraiter + Selectedrow["VDOCFILE"].ToString(), sPJ, true);

          string sSql = "EXEC msdb..sp_send_dbmail ";
          sSql += "@profile_name = 'Web" + MozartParams.NomSociete + "', ";
          sSql += "@from_address = 'documents@emalec.com', ";
          //sSql += "@recipients   = 'fgalotti@emalec.com', ";
          sSql += "@recipients   = '" + sListeDest + "', ";
          sSql += "@body         = '" + Strings.Replace(txtMessage.Text, "'", "''") + "', ";
          sSql += "@subject      = '" + Strings.Replace(txtSujet.Text, "'", "''") + "', ";
          sSql += "@file_attachments = '" + sPJ + "' ";

          ModuleData.CnxExecute(sSql);

          if (TypeMail == "ENVOI_PPS")
          {
            // information dans l'action d'envoie du PPS validé par le chaff et le STT
            string sSqlp = "update TACT set VACTOBS = 'Envoi du PPS n°" + Selectedrow["NIDPPS"].ToString() + " validé par Emalec et le STT le ";
            sSqlp += DateTime.Now.ToShortDateString() + " par " + MozartParams.strUID + " à " + sListeDest + ".' + char(13) + char(10) +";
            sSqlp += " COALESCE(VACTOBS, '') Where NACTNUM = " + Convert.ToInt32(Selectedrow["NACTNUM"]);
            ModuleData.CnxExecute(sSqlp);
          }

          // rafraichissement de la liste
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

          // cacher la liste des destinataires
          panel1.Visible = false;
        }
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
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        // demande de confirmation de la suppression
        if (MessageBox.Show(Resources.msg_confirm_del_ligne, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;

        // suppression de la ligne dans la base
        ModuleData.CnxExecute($"DELETE FROM TDOCUMENTS WHERE NIDDOCUMENT = {Convert.ToInt32(row["NIDDOCUMENT"])}");

        // suppression du fichier 
        CImpersonation.DeleteFileImpersonated(CheminDocATraiter + row["VDOCFILE"].ToString());

        // mise a jour de la liste
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisualiser_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        new frmBrowserSimple()
        {
          StartingAddress = CImpersonation.OpenFileImpersonated(CheminDocATraiter + row["VDOCFILE"].ToString())
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void SignatureDocument(string File, string Valideur)
    {
      PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();

      // chargement du fichier pdf
      documentProcessor.LoadDocument(File);

      using (PdfGraphics graph = documentProcessor.CreateGraphics())
      {
        //*****************************************************************************************************************************
        // recherche de la position du libellé de référence pour poser la signature (en blanc sur fond blanc dans le document) 
        PdfTextSearchResults result;

        result = documentProcessor.FindText("Code--Case--Signature--Chaff");

        // ajout de la case à cocher validation
        RectangleF rect =
        new RectangleF(new PointF((float)result.Rectangles[0].Left + 115, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top + 7),
        new SizeF(13, 13));

        var checkBox = new PdfGraphicsAcroFormCheckBoxField("boxchaff", rect);

        // Couleur et Check  de la case a cocher
        checkBox.IsChecked = true;
        checkBox.ButtonStyle = PdfAcroFormButtonStyle.Check;
        checkBox.Appearance.BackgroundColor = Color.Silver;

        graph.AddFormField(checkBox);

        // Ajout des textes (valideur, date, et validation)
        string Validation = "Je valide ce document";
        string text = $"le {DateTime.Now.ToShortDateString()}";

        using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, Color.DarkBlue)))
        {
          using (Font font = new Font("Segoe UI", 11, FontStyle.Regular))
          {
            // calcul de la position en fonction de la position du libellé de référence
            PointF textPoint = new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top - 20);
            PointF textPoint2 = new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top + 5);
            PointF textPoint3 = new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top + 40);

            // ajout date dans le document
            graph.DrawString(Valideur, font, textBrush, textPoint);
            graph.DrawString(Validation, font, textBrush, textPoint2);
            graph.DrawString(text, font, textBrush, textPoint3);
            graph.AddToPageForeground(result.Page, 72, 72);
          }
        }
        // desactivation des form Field
        documentProcessor.FlattenForm();

        // enregistrement du document
        documentProcessor.SaveDocument(File);
      }
    }

    private void EnregistrerDocument(string strNomDocument, int Nactnum)
    {
      try
      {
        // repertoire de destination
        string strRepDest = Utils.RechercheParam("REP_PHOTOS_ACT");

        int iCount = 0;
        // recherche du numéro d'image
        using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@cElt"].Value = "IMGACT";
          cmd.Parameters["@iCpt"].Value = 0;
          cmd.ExecuteNonQuery();
          iCount = Convert.ToInt32(cmd.Parameters["@iCpt"].Value);
        }

        // composition du nom de l'image
        string textFic = $"{Nactnum}_{iCount}.pdf";

        // enregistrement de l'image dans la table
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iNIMAGE"].Value = 0;
          cmd.Parameters["@iNACTNUM"].Value = Nactnum;
          cmd.Parameters["@vVIMAGE"].Value = "PPS";
          cmd.Parameters["@vVFICHIER"].Value = textFic.Trim();
          cmd.Parameters["@cCFORMAT"].Value = "PDF";
          cmd.Parameters["@vVCOMMENT"].Value = "";
          cmd.Parameters["@vVTYPE"].Value = "IMAGE";
          cmd.Parameters["@vWEB"].Value = "N";
          cmd.Parameters["@vTypeDest"].Value = "I";
          cmd.Parameters["@nTypeDoc"].Value = 44;

          cmd.ExecuteNonQuery();
        }

        // copy physique de l'image
        File.Copy(strNomDocument, strRepDest + textFic, true);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAnnuler_Click(object sender, EventArgs e)
    {
      panel1.Visible = false;
    }

    private void cmdValiderMail_Click(object sender, EventArgs e)
    {
      EnvoyerMail();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      // document INCONNU, pas de possibilité d'aller sur la DI
      if (row["VDOCTYPE"].ToString() == "INCONNU")
      {
        MessageBox.Show("Document inconnu / opération impossible", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //écran de modification de la demande
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;

      new frmDetailstravaux
      {
        sModeReadOnly = "0",
        mstrStatutAction = "M",
      }.ShowDialog();

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      Selectedrow = apiTGrid1.GetFocusedDataRow();
      if (Selectedrow == null) return;

      lstDest.Items.Clear();

      // sujet
      txtSujet.Text = $"Transfert document";

      // message
      txtMessage.Text = $"Transfert document"; ;

      TypeMail = "ENVOI_LIBRE";

      // affichage de la fenetre d'envoi du document
      panel1.Visible = true;
    }
  }
}

