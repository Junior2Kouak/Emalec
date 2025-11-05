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
  public partial class frmxActImg : Form
  {
    //ouverture de la fenetre en création ou modification
    public string mstrStatut = "";
    public string mstrClient = "";
    public string mstrSite = "";
    public string mstrDI = "";
    public string mstrVueWeb = "";
    public string mstrTypeDoc = "";
    public long mlAction = 0;
    public long miImage = 0;

    string strRepImage;
    string strImage = "";

    bool bModif;
    bool bModFile;
    bool bEnrOK;

    string sTypeFile;

    Point locPdf;
    Size szPdf;
    

    public frmxActImg()
    {
      InitializeComponent();
    }

    private void frmxActImg_Load(object sender, System.EventArgs e)
    {
      try
      {
        // Position et taille du browser gardés pour Maxi/Mini
        locPdf = WebBrowser1.Location;
        szPdf = WebBrowser1.Size;

        //  ' initialisation des images des boutons
        ModuleMain.Initboutons(this);

        // En-tête
        txtClient.Text = mstrClient;
        txtSite.Text = mstrSite;
        txtDI.Text = mstrDI;

        ModuleData.RemplirCombo(cboDoc, $"select NTYPEDOC, VTYPEDOCLIB from TREF_TYPEDOC WITH (NOLOCK) WHERE LANGUE='{MozartParams.Langue}' " +
                                        $"AND VTYPEDEST = '{mstrTypeDoc.Substring(0, 1)} ' ORDER BY  VTYPEDOCLIB");
        cboDoc.ValueMember = "NTYPEDOC";
        cboDoc.DisplayMember = "VTYPEDOCLIB";
        if (cboDoc.Items.Count > 0)
          cboDoc.SelectedIndex = 0;

        //recherche du répertoire de sauvegarde des documents
        if (mstrTypeDoc == "Technicien")
        {
          strRepImage = MozartParams.CheminDocTechnicien;
          // On ne peut ajouter que des PDF dans les doc techniciens
          // fGA le 25/0924 ajout gestion des photos
          CommonDialog1.Filter = "Fichiers  |*.PDF;*.JPG;*.PNG;*.GIF;*.JPEG";
          //CommonDialog1.FilterIndex = 1;

        }
        else
          strRepImage = Utils.RechercheParam("REP_PHOTOS_ACT");

        switch (mstrTypeDoc)
        {
          case "Client":
            Label1.Text = "Gestion d'un document visible par le client";
            break;
          case "Interne":
            Label1.Text = "Gestion d'un document interne, non visible par le client";
            break;
          case "Technicien":
            Label1.Text = "Gestion d'un document technicien, non visible par le client";
            break;
        }

        // traitement du cas de modification ou de création
        if (mstrStatut == "M")
          OuvertureEnModification();

        bModif = false;
        bModFile = false;
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (bModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
          {
            case DialogResult.Yes:
              cmdValider_Click(null, null);
              Close();
              break;
            case DialogResult.No:
              Close();
              break;
            case DialogResult.Cancel:
              return;
          }
        }
        else
        {
          Cursor.Current = Cursors.WaitCursor;
          Close();
        }
        return;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      int lcount;
      string[] ts;
      try
      {
        if (mstrTypeDoc == "Client" && mstrStatut == "C")
          MessageBox.Show(Resources.msg_Warning_Ajout_Doc_Visible_Client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        //si le type est divers historique, il faut le changer
        if (mstrTypeDoc == "client" && cboDoc.GetItemData() == 9)
          MessageBox.Show(Resources.msg_MustChooseDoc, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        //si le type est divers historique, il faut le changer
        if (mstrTypeDoc == "Interne" && cboDoc.GetItemData() == 31)
          MessageBox.Show(Resources.msg_MustChooseDoc, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        if (txtLib.Text == "")
        {
          MessageBox.Show(Resources.msg_DecrireImg);
          txtLib.Focus();
          return;
        }

        if (txtFic.Text == "")
        {
          MessageBox.Show(Resources.msg_PreciserFichImg);
          txtFic.Focus();
          return;
        }

        if (cboDoc.Text == "")
        {
          MessageBox.Show(Resources.msg_SelectDocType);
          cboDoc.Focus();
          return;
        }

        // les assistantes n'ont pas le droit de poser des attachements visible client
        if (mstrTypeDoc == "Client" && cboDoc.GetItemData() == 1)
        {
          string res = ModuleData.ExecuteScalarString($"select CPERTYP from TPER where NPERNUM = {MozartParams.UID}");
          if (res == "AS" || res == "AA")
            MessageBox.Show(Resources.msg_CannotAddAttchToDocClient, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        if ((mstrStatut == "M" && bModFile) || (mstrStatut == "C"))
        {
          using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            // Liste des paramètres
            cmd.Parameters["@iCpt"].Value = 0;
            cmd.Parameters["@cElt"].Value = "IMGACT";

            cmd.ExecuteNonQuery();
            lcount = (int)cmd.Parameters["@iCpt"].Value;
          }

          string sFileTemp = "";

          ts = txtFic.Text.Split('.');
          sTypeFile = ts[ts.Length - 1];

          for (int t = 0; t < ts.Length - 1; t++)
          {
            if (t == ts.Length - 1)
              sFileTemp += ts[t];
            else
              sFileTemp += ts[t] + ".";
          }
          txtFic.Text = mlAction + "_" + lcount.ToString() + "." + sTypeFile;
        }
        EnregistrerImg();

        if (bEnrOK)
        {
          if ((mstrStatut == "M" && bModFile) || (mstrStatut == "C"))
            File.Copy(CommonDialog1.FileName, strRepImage + txtFic.Text, overwrite: true);

          mstrStatut = "M";
          bModif = false;
          bModFile = false;
        }
        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdMax_Click(object sender, EventArgs e)
    {
      if (CmdMax.Text == Resources.txt_Maxi)
      {
        WebBrowser1.Width = this.Width - 120;
        WebBrowser1.Height = this.Height - 90;
        WebBrowser1.Top = 40;
        WebBrowser1.Left = 100;
        CmdMax.Text = Resources.txt_Mini;
      }
      else
      {
        WebBrowser1.Location = locPdf;
        WebBrowser1.Size = szPdf;
        CmdMax.Text = Resources.txt_Maxi;
      }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      try
      {
        CommonDialog1.ShowReadOnly = false;
        CommonDialog1.Title = Resources.msg_select_image_file;

        CommonDialog1.ShowDialog();

        //test du format de fichier (autoriser pdf,doc,xls,bmp,png,jpg,jpeg,gif,txt,docx,xlsx)
        string sExt = Path.GetExtension(CommonDialog1.FileName).ToLower();
        if (sExt != ".txt" && sExt != ".rtf" && sExt != ".pdf" && sExt != ".doc" && sExt != ".docx" && sExt != ".xls"
            && sExt != ".xlsx" && sExt != ".png" && sExt != ".jpg" && sExt != ".jpeg" && sExt != ".gif")
        {
          MessageBox.Show(Resources.msg_Forbidden_file_type);
          txtFic.Text = "";
          return;
        }

        //Affiche le nom du fichier sélectionné
        txtFic.Text = Path.GetFileName(CommonDialog1.FileName).ToLower();

        //on teste le nom du fichier si celui-ci possède un accent
        if (WithAccents(txtFic.Text) == true && mstrTypeDoc == "Technicien")
        {
          MessageBox.Show(Resources.msg_Rename_file_without_accent);
          txtFic.Text = "";
          return;
        }

        FileInfo fi = new FileInfo(CommonDialog1.FileName);
        if (fi.Length > 11000000)
        {
          MessageBox.Show(Resources.msg_file_too_big_cannot_insert_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtFic.Text = "";
          return;
        }

        //   Afficher l'image
        WebBrowser1.Navigate(CommonDialog1.FileName);

        bModif = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Command1_Click()
    //Dim ts
    //  
    //  On Error GoTo errHandler
    //  
    //  ' Attribue à CancelError la valeur True
    //  CommonDialog1.CancelError = True
    //  ' Définit la propriété Flags
    //  CommonDialog1.flags = cdlOFNHideReadOnly
    //  ' titre de la aboite
    //  CommonDialog1.DialogTitle = "§Choix d'un fichier image§"
    //  
    //    
    //  ' Affiche la boîte de dialogue Ouverture
    //  On Error GoTo ExitHandler
    //  CommonDialog1.ShowOpen
    //  On Error GoTo errHandler
    //  
    //  ' test du format de fichier (autoriser pdf,doc,xls,bmp,png,jpg,jpeg,gif,txt,docx,xlsx)
    //  ts = Split(CommonDialog1.FileName, ".")
    //  TextFic = LCase(ts(UBound(ts)))
    //  If TextFic <> "txt" And TextFic <> "rtf" And TextFic <> "pdf" And TextFic <> "doc" And TextFic <> "docx" And TextFic <> "xls" And TextFic <> "xlsx" And TextFic <> "png" And TextFic <> "jpg" And TextFic <> "jpeg" And TextFic <> "gif" Then
    //    MsgBox "Type de fichier interdit "
    //    TextFic.Text = ""
    //    Exit Sub
    //  End If
    //  
    //   ' Affiche le nom du fichier sélectionné
    //  ts = Split(CommonDialog1.FileName, "\")
    //  TextFic = ts(UBound(ts))
    //
    //  'on teste le nom du fichier si celui-ci possède un accent
    //  If WithAccents(TextFic.Text) = True And mstrTypeDoc = "Technicien" Then
    //    MsgBox "§Ce fichier comporte un ou des acents. Renommer le nom du fichier sans accent.§"
    //    TextFic.Text = ""
    //    Exit Sub
    //  End If
    //  
    //  Dim fso As New FileSystemObject
    //  Dim Fichier As File
    // 
    //  Set Fichier = fso.GetFile(CommonDialog1.FileName)
    //  
    //  If Fichier.Size > 11000000 Then
    //    MsgBox "§Ce fichier est trop gros. Vous ne pouvez pas l'insérer sur l'action (limite 1Mo)§"
    //    TextFic.Text = ""
    //    Exit Sub
    //  End If
    //    
    //  ' Afficher l'image
    //'  AfficheImg CommonDialog1.FileName
    //  WebBrowser1.Navigate "about:blank"
    //  WebBrowser1.Navigate CommonDialog1.FileName
    // 
    //  bModif = True
    //
    //ExitHandler:
    //  Exit Sub
    //
    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "command1_Click dans " & Me.Name
    //End Sub

    private void frmxActImg_FormClosed(object sender, FormClosedEventArgs e)
    {
      //TODO frmListActDoc
      //frmListActDoc.miImage = miImage;
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  frmListActDoc.miImage = Me.miImage
    //  Screen.MousePointer = vbDefault
    //End Sub

    private void OuvertureEnModification()
    {
      string strImg = "";
      try
      {

        Label1.Text = Resources.txt_DetailImg;
        //Donnees générales de l'objet
        using (SqlDataReader rs = ModuleData.ExecuteReader("api_sp_RetourImgAct " + miImage))
        {
          if (rs.Read())
          {
            sTypeFile = rs["CFORMAT"].ToString().ToUpper();
            txtLib.Text = rs["VIMAGE"].ToString();
            txtFic.Text = rs["VFICHIER"].ToString();
            txtComment.Text = Utils.BlankIfNull(rs["VCOMMENT"]);
            cboDoc.SelectedValue = (int)rs["NTYPEDOC"];

            //mRepertoireDoc est mis par défaut à RechercheParam("REP_PHOTOS_ACT") au début du load, donc il faut le changer dans selon les docuements affichés
            if (rs["VTYPE"].ToString() == "ATTACH" || rs["VTYPE"].ToString() == "GAMME" || rs["VTYPE"].ToString() == "ATTEST")
              strRepImage = Utils.RechercheParam("REP_ATTGAM");

            if (rs["VFICHIER"].ToString() != "")
              strImg = strRepImage + rs["VFICHIER"].ToString();

            WebBrowser1.Visible = true;
            WebBrowser1.Navigate(strImg);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnModification()
    //Dim rs As ADODB.Recordset
    //Dim strImg As String
    //On Error GoTo handler
    //
    //  Label1.Caption = "§Détail d'une image§"
    //  
    //  ' Donnees générales de l'objet
    //  Set rs = New ADODB.Recordset
    //  rs.Open "api_sp_RetourImgAct " & Me.miImage, cnx
    //  sTypeFile = UCase(rs("CFORMAT"))
    //''  For i = 0 To UBound(tFormats)
    //''    If tFormats(i) = UCase(rs("CFORMAT")) Then cboFormat.ListIndex = i
    //''  Next
    //  Me.TextLib = rs("VIMAGE")
    //  Me.TextFic = rs("VFICHIER")
    //  Me.TextComment = BlankIfNull(rs("VCOMMENT"))
    //    
    //  SelectLB cboDoc, rs("NTYPEDOC")
    //  
    //  ' mRepertoireDoc est mis par défaut à RechercheParam("REP_PHOTOS_ACT") au début du load, donc il faut le changer dans selon les docuements affichés
    //  If (rs("VTYPE") = "ATTACH" Or rs("VTYPE") = "GAMME" Or rs("VTYPE") = "ATTEST") Then
    //    mRepertoireDoc = RechercheParam("REP_ATTGAM")
    //  End If
    //  
    //  If rs("VFICHIER") <> "" Then
    //    strImg = mRepertoireDoc & rs("VFICHIER")
    //  End If
    //
    //  WebBrowser1.Visible = True
    //  WebBrowser1.Navigate "about:blank"
    //  WebBrowser1.Navigate strImg
    //
    //  rs.Close
    //  Set rs = Nothing
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    private void EnregistrerImg()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNIMAGE"].Value = miImage;
          cmd.Parameters["@iNACTNUM"].Value = mlAction;
          cmd.Parameters["@vVIMAGE"].Value = txtLib.Text.Trim();

          cmd.Parameters["@vVFICHIER"].Value = txtFic.Text.Trim();
          cmd.Parameters["@cCFORMAT"].Value = sTypeFile;
          cmd.Parameters["@vVCOMMENT"].Value = txtComment.Text;
          cmd.Parameters["@vWEB"].Value = mstrVueWeb;

          if (mstrTypeDoc == "Technicien")
            cmd.Parameters["@vVTYPE"].Value = "DOCTECH";

          cmd.Parameters["@vTypeDest"].Value = mstrTypeDoc.Substring(0, 1);

          cmd.Parameters["@nTypeDoc"].Value = cboDoc.GetItemData();

          cmd.ExecuteNonQuery();
          miImage = (int)cmd.Parameters["@iNIMAGE"].Value;

          bEnrOK = true;
        }
      }
      catch (Exception ex)
      {
        bEnrOK = false;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub enregistrerImg()
    //
    //Dim ado_cmd As New ADODB.Command
    //
    //On Error GoTo handler
    //
    //  ' création/mise à jour de l'objet
    //  Set ado_cmd.ActiveConnection = cnx
    //  ado_cmd.CommandText = "api_sp_EnregImgAct"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  ado_cmd.Parameters.Refresh
    //
    //  ' liste des paramètres
    //  ado_cmd.Parameters("@iNIMAGE").value = Me.miImage
    //  ado_cmd.Parameters("@iNACTNUM").value = Me.mlAction
    //  ado_cmd.Parameters("@vVIMAGE").value = Trim(TextLib)
    //  ado_cmd.Parameters("@vVFICHIER").value = Trim(TextFic)
    //  ado_cmd.Parameters("@cCFORMAT").value = sTypeFile 'tFormats(cboFormat.ListIndex)
    //  ado_cmd.Parameters("@vVCOMMENT").value = TextComment
    //  ado_cmd.Parameters("@vWEB").value = mstrVueWeb
    //  If mstrTypeDoc = "Technicien" Then ado_cmd.Parameters("@vVTYPE").value = "DOCTECH"  ' pour l'instant on laisse ça
    //  ado_cmd.Parameters("@vTypeDest").value = Left(mstrTypeDoc, 1)
    //  ado_cmd.Parameters("@nTypeDoc").value = cboDoc.ItemData(cboDoc.ListIndex)
    //
    //  ado_cmd.Execute
    //  Me.miImage = ado_cmd.Parameters("@iNIMAGE").value
    //  Set ado_cmd = Nothing
    //  
    //  bEnrOK = True
    //
    //Exit Sub
    //Resume
    //handler:
    //  bEnrOK = False
    //  ShowError "enregistrerImg dans " & Me.Name
    //End Sub

    //TODO Ajouter une image au bouton comme sur VB6
    private void mnuEnregImage_Click(object sender, EventArgs e)
    {
      try
      {
        saveFileDialog1.Title = Resources.tlt_EnregistrerSous;
        saveFileDialog1.FileName = MozartParams.CheminProgramme + @"\Mozart\image1.jpg";

        if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
          File.Copy(strImage, saveFileDialog1.FileName);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub mnuEnregImage_Click()
    //Dim fs As New FileSystemObject
    //      
    //    On Error GoTo errHandler
    //    
    //    ' Attribue à CancelError la valeur True
    //    CommonDialog1.CancelError = True
    //  
    //    CommonDialog1.DialogTitle = "§Enregistrer l'image sous ...§"
    //    CommonDialog1.FileName = gstrCheminProgramme & "\Mozart\image1.jpg"
    //    
    //    On Error GoTo ExitHandler
    //    CommonDialog1.ShowSave      ' commune Enregistrer.
    //    On Error GoTo errHandler
    //    fs.CopyFile strImage, CommonDialog1.FileName
    //    
    //
    //ExitHandler:
    //  Exit Sub
    //
    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "command2_Click dans " & Me.Name
    //End Sub

    private void txtFic_TextChanged(object sender, EventArgs e)
    {
      bModFile = true;
    }
    //Private Sub TextFic_Change()
    //  bModFile = True
    //End Sub

    private void txtLib_TextChanged(object sender, EventArgs e)
    {
      bModif = true;
    }
    //Private Sub TextLib_Change()
    //  bModif = True
    //End Sub

    private bool WithAccents(string s)
    {
      // La fonction qui permet de tester sil y a un ou des accents dans le nom du fichier (utilisé pour les doc tech car probleme si accent pour l'assemblage PDF)
      string accent = "ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêëÌÍÎÏìíîïÙÚÛÜùúûüÿÑñÇç";

      foreach (char item in accent)
      {
        if (s.Contains(item.ToString()))
          return true;
      }
      return false;
    }
    //Private Function WithAccents(ByRef s As String) As Boolean
    //
    //' Définition de la conversion
    //Dim accent As String
    //Dim i As Integer
    //Dim lettre As String
    //    
    //    WithAccents = False
    //    
    //    accent = "ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêëÌÍÎÏìíîïÙÚÛÜùúûüÿÑñÇç"
    //    
    //    For i = 1 To Len(accent)
    //        lettre = Mid$(accent, i, 1)
    //        If InStr(s, lettre) > 0 Then
    //            WithAccents = True
    //            Exit For
    //        End If
    //    Next i
    //
    //End Function
  }
}