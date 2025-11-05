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
  public partial class frmMedia : Form
  {
    public string mstrStatut;
    public string mstrClient;
    public string mstrSite;
    public string mstrObjet;
    public string mstrImage;
    public string sType;
    public long miSitNum;
    public long miObjet;
    private bool bEnrOK;
    public long miImage;

    private int imgX;
    private int imgY;
    private int imgH;
    private int imgW;
    private bool bModif;
    private bool bModFile;
    private string strRepImage;
    OpenFileDialog CommonDialog1 = new OpenFileDialog();


    //Public mstrStatut As String
    //Public mstrClient As String
    //Public mstrSite As String
    //Public miSitNum As Long
    //Public miObjet As Long
    //Public mstrObjet As String
    //Public miImage As Long
    //Public mstrImage As String
    //Public sType As String
    //
    //Dim strImage As String
    //Dim mRepertoireDoc As String
    //Dim bModif As Boolean
    //Dim bModFile As Boolean
    //Dim bEnrOK As Boolean
    //Dim tFormats() As String
    //Dim imgX As Integer
    //Dim ImgY As Integer
    //Dim ImgH  As Integer
    //Dim ImgW As Integer
    //
    //Dim Fichier() As String

    public frmMedia() { InitializeComponent(); }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmMedia_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        imgX = Image1.Left;
        imgY = Image1.Top;
        imgH = Image1.Height;
        imgW = Image1.Width;

        //  Recherche du répertoire de sauvegarde des images sur le serveur
        strRepImage = Utils.RechercheParam("REP_MEDIA");

        if (sType == "GIDTCLI")
          strRepImage += @"GIDTCLI\";

        //  initialisation à vide
        brwWebBrowser.Navigate("about:");

        txtClient.Text = mstrClient;
        TextSite.Text = mstrSite;
        TextRep.Text = mstrObjet;
        TextLib.Text = mstrObjet;

        //  traitement du cas de modification ou de création
        if (mstrStatut == "C")
        {
          miImage = 0;
          Combo1.SelectedIndex = 0;
          TextDate.Text = DateTime.Now.ToShortDateString();
        }
        else
          OuvertureEnModification();

        bModif = false;
        bModFile = false;

        Cursor.Current = Cursors.Default;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //    
    //  imgX = Image1.Left
    //  ImgY = Image1.Top
    //  ImgH = Image1.height
    //  ImgW = Image1.width
    //  
    //  ' initialisation des images des boutons
    //  InitBoutons Me, frmMenu
    //  
    //  ' recherche du répertoire de sauvegarde des images sur le serveur
    //  mRepertoireDoc = RechercheParam("REP_MEDIA")
    //     
    //  If sType = "GIDTCLI" Then mRepertoireDoc = mRepertoireDoc + "GIDTCLI\"
    //  
    //  ' initialisation à vide
    //  brwWebBrowser.Navigate "about:"
    //
    //  ' Site
    //  txtClient = Me.mstrClient
    //  TextSite = Me.mstrSite
    //  TextRep = Me.mstrObjet
    //  TextLib = Me.mstrObjet
    //  
    //  ' traitement du cas de modification ou de création
    //  If Me.mstrStatut = "C" Then
    //    Me.miImage = 0
    //    Me.Combo1.ListIndex = 0
    //    TextDate = Now
    //  Else
    //    OuvertureEnModification
    //  End If
    //  
    //  bModif = False
    //  bModFile = False
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Combo1.SelectedIndex > -1)
      {
        CommonDialog1.FilterIndex = 1;
        Image1.Visible = true;
        brwWebBrowser.Visible = false;

        // Définit les filtres
        switch (Combo1.SelectedIndex)
        {
          case 0:
            if (TextImg.Text.EndsWith("JPG"))
              CommonDialog1.Filter = "Fichiers JPEG (*.JPG)|*.JPG";
            break;
          case 1:
            if (TextImg.Text.EndsWith("BMP"))
              CommonDialog1.Filter = "Fichiers Bitmap (*.BMP)|*.BMP";
            break;
          case 2:
            if (TextImg.Text.EndsWith("GIF"))
              CommonDialog1.Filter = "Fichiers GIF (*.GIF)|*.GIF";
            break;
          case 3:
            if (TextImg.Text.EndsWith("PDF"))
            {
              CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
              Image1.Visible = false;
              brwWebBrowser.Visible = true;
            }
            break;
        }
      }
    }
    //Private Sub Combo1_Click()
    //
    //Dim strFiltre As String
    //
    //If Combo1.ListIndex > -1 Then
    //  ' Définit les filtres
    //  Select Case Me.Combo1.ListIndex
    //  Case 0
    //    If Right(TextImg, 3) <> "JPG" Then
    //      TextImg = ""
    //      CommonDialog1.Filter = "Fichiers JPEG (*.JPG)|*.JPG"
    //      CommonDialog1.FilterIndex = 1
    //      Image1.Visible = True
    //      brwWebBrowser.Visible = False
    //    End If
    //  Case 1
    //    If Right(TextImg, 3) <> "BMP" Then
    //      TextImg = ""
    //      CommonDialog1.Filter = "Fichiers Bitmap (*.BMP)|*.BMP"
    //      CommonDialog1.FilterIndex = 1
    //      Image1.Visible = True
    //      brwWebBrowser.Visible = False
    //    End If
    //  Case 2
    //    If Right(TextImg, 3) <> "GIF" Then
    //      TextImg = ""
    //      CommonDialog1.Filter = "Fichiers GIF (*.GIF)|*.GIF"
    //      CommonDialog1.FilterIndex = 1
    //      Image1.Visible = True
    //      brwWebBrowser.Visible = False
    //    End If
    //  Case 3
    //    If Right(TextImg, 3) <> "PDF" Then
    //      TextImg = ""
    //      CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF"
    //      CommonDialog1.FilterIndex = 1
    //      Image1.Visible = False
    //      brwWebBrowser.Visible = True
    //    End If
    //  End Select
    //End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFile_Click(object sender, EventArgs e)
    {
      try
      {
        //  CommonDialog1.flags = &H200 Or &H80000
        if (CommonDialog1.ShowDialog() == DialogResult.OK)
        {
          //    Afficher la premiere image
          AfficheImg(CommonDialog1.FileName);
          TextImg.Text = CommonDialog1.SafeFileName;
          bModif = true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdFile_Click()
    //Dim ts
    //Dim n, i, iprecedent
    //
    //  On Error GoTo errHandler
    //  
    //  ' Attribue à CancelError la valeur True
    //  CommonDialog1.CancelError = True
    //  
    //  ' Définit la propriété Flags  &H200 Or &H80000
    //  CommonDialog1.flags = &H200 Or &H80000
    //  
    //  ' Affiche la boîte de dialogue Ouverture
    //  On Error GoTo ExitHandler
    //  CommonDialog1.ShowOpen
    //  
    //  On Error GoTo errHandler
    //
    //  If CommonDialog1.FileTitle = "" Then
    //    ' pas de gestion du multi select des fichiers
    //    Exit Sub
    //  Else
    //    'Placer ici le code a effectuer lors d'une sélection simple
    //    ' Afficher la premiere image
    //    AfficheImg CommonDialog1.FileName
    //    TextImg = CommonDialog1.FileTitle
    //    bModif = True
    //  End If
    //
    //ExitHandler:
    //Exit Sub
    //Resume
    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "cmdFile dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void OuvertureEnModification()
    {
      try
      {
        string strImg;

        //  Donnees générales de l'objet
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_RetourImg {miImage}, '{sType}'"))
        {
          if (dr.Read())
          {
            switch (dr["CFORMAT"].ToString())
            {
              case "JPG": Combo1.SelectedIndex = 0; break;
              case "BMP": Combo1.SelectedIndex = 1; break;
              case "GIF": Combo1.SelectedIndex = 2; break;
              case "PDF": Combo1.SelectedIndex = 3; break;
            }
            TextLib.Text = dr["VFICLIB"].ToString();
            TextImg.Text = dr["VFICHIER"].ToString();
            TextComment.Text = Utils.BlankIfNull(dr["VCOMMENT"]);
            TextDate.Text = dr["DFICDAT"].ToString();

            Label1.Text = Resources.msg_Detail_fichier;

            if (dr["VFICHIER"].ToString() != "")
            {
              strImg = strRepImage + dr["VFICHIER"].ToString();
              AfficheImg(strImg);
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnModification()
    // 
    //Dim rs As ADODB.Recordset
    //Dim strImg As String
    //
    //On Error GoTo handler
    //
    //  ' Donnees générales de l'objet
    //  Set rs = New ADODB.Recordset
    //  rs.Open "api_sp_RetourImg " & Me.miImage & ", '" & sType & "'", cnx
    //  Select Case rs("CFORMAT")
    //  Case "JPG"
    //    Me.Combo1.ListIndex = 0
    //  Case "BMP"
    //    Me.Combo1.ListIndex = 1
    //  Case "GIF"
    //    Me.Combo1.ListIndex = 2
    //  Case "PDF"
    //    Me.Combo1.ListIndex = 3
    //  End Select
    //  Me.TextLib = rs("VFICLIB")
    //  Me.TextImg = rs("VFICHIER")
    //  Me.TextComment = BlankIfNull(rs("VCOMMENT"))
    //  Me.TextDate = rs("DFICDAT")
    //  
    //  Label1.Caption = "§Détail d'un fichier§"
    //  
    //  If rs("VFICHIER") <> "" Then
    //    strImg = mRepertoireDoc & rs("VFICHIER")
    //  End If
    //  AfficheImg strImg
    //
    //  rs.Close
    //  Set rs = Nothing
    //  Exit Sub
    //  Resume
    //
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (Combo1.SelectedIndex == -1)
        {
          MessageBox.Show(Resources.msg_Choix_type_image, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Combo1.Focus();
          return;
        }

        if (TextLib.Text == "")
        {
          MessageBox.Show(Resources.msg_DecrireImg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          TextLib.Focus();
          return;
        }

        if (TextImg.Text == "")
        {
          MessageBox.Show(Resources.msg_PreciserFichImg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cmdFile.Focus();
          return;
        }

        int iCount = 0;
        if ((mstrStatut == "M" && bModFile) || (mstrStatut == "C"))
        {
          //    Récupération compteur
          using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@iCpt"].Value = 0;
            cmd.Parameters["@cElt"].Value = "MEDIA";
            cmd.ExecuteNonQuery();
            iCount = Convert.ToInt32(cmd.Parameters["@iCpt"].Value);
          }

          string[] ts = TextImg.Text.Split('.');
          TextImg.Text = $"{miSitNum}_{ts[0].Replace(" ", "_")}_{iCount}.{ts[1]}";
          TextImg.Text = TextImg.Text.Replace("'", "");
        }

        EnregistrerImg(TextImg.Text, TextLib.Text, TextComment.Text);

        if (bEnrOK)
        {
          //Recopier le fichier sélectionné sur serveur
          if ((mstrStatut == "M" && bModFile) || (mstrStatut == "C"))
            File.Copy(CommonDialog1.FileName, strRepImage + TextImg.Text);

          mstrImage = TextLib.Text;
          mstrStatut = "M";
          bModif = false;
          bModFile = false;

          OuvertureEnModification();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //Dim fs As New FileSystemObject
    //Dim strFile As String
    //Dim lcount As Long
    //Dim ts
    //Dim c As New ADODB.Command
    //
    //On Error GoTo handler
    //
    //  If IsNull(Combo1.ListIndex = -1) Then
    //    MsgBox "§Choisissez un type d'image§"
    //    Combo1.SetFocus
    //    Exit Sub
    //  End If
    //  If TextLib = "" Then
    //    MsgBox "§Décrivez l'image§"
    //    TextLib.SetFocus
    //    Exit Sub
    //  End If
    //  If TextImg = "" Then
    //    MsgBox "§Précisez le fichier image§"
    //    cmdFile.SetFocus
    //    Exit Sub
    //  End If
    //    
    //  If (Me.mstrStatut = "M" And bModFile) Or (Me.mstrStatut = "C") Then
    //    ' Récupération compteur
    //    Set c.ActiveConnection = cnx
    //    c.CommandText = "api_sp_GetCpt"
    //    c.CommandType = adCmdStoredProc
    //    'c.Parameters.Refresh
    //    c.Parameters("@cElt").value = "MEDIA"
    //    c.Execute
    //    lcount = c.Parameters("@iCpt").value
    //    Set c = Nothing
    //    
    //    ts = Split(TextImg, ".")
    //    TextImg = miSitNum & "_" & Replace(ts(0), " ", "_") & "_" & lcount & "." & ts(1)
    //    TextImg = Replace(TextImg, "'", "")
    //  End If
    //  
    //  Call enregistrerImg(TextImg, TextLib, TextComment)
    //                
    //  If bEnrOK Then
    //                
    //  If (Me.mstrStatut = "M" And bModFile) Or (Me.mstrStatut = "C") Then
    //    ' Recopier le fichier sélectionné sur serveur
    //    fs.CopyFile CommonDialog1.FileName, mRepertoireDoc & TextImg
    //  End If
    //  
    //  Me.mstrImage = TextLib
    //  Me.mstrStatut = "M"
    //  bModif = False
    //  bModFile = False
    //  
    //  Call OuvertureEnModification
    //    
    //  End If
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "cmdValider_click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      if (bModif)
      {

        switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2))
        {
          case DialogResult.Yes:
            cmdValider_Click(null, null);
            Dispose();
            break;
          case DialogResult.No:
            Dispose();
            break;
          case DialogResult.Cancel:
            return;
        }
      }
      else
        Dispose();
    }
    //Private Sub cmdFermer_Click()
    //
    //Dim response As String
    //  
    //On Error GoTo handler
    //
    //  If bModif Then
    //    response = MsgBox("§Voulez-vous enregistrer les modifications ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //    Select Case response
    //      Case vbYes
    //        cmdValider_Click
    //        Unload Me
    //      Case vbNo
    //        Unload Me
    //      Case vbCancel
    //        Exit Sub
    //    End Select
    //  Else
    //    Screen.MousePointer = vbHourglass
    //    Unload Me
    //  End If
    //
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdFermer_click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public void EnregistrerImg(string Img, string Lib, string Comment)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_enregistrerImg", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iOBJET"].Value = miObjet;
          cmd.Parameters["@iNIMAGE"].Value = miImage;
          cmd.Parameters["@vVIMAGE"].Value = Img.Trim();
          cmd.Parameters["@vVLIBIMG"].Value = Lib.Trim();
          cmd.Parameters["@vVCOMMENT"].Value = Comment;
          cmd.Parameters["@ctyp"].Value = sType;

          switch (Combo1.SelectedIndex)
          {
            case 0: cmd.Parameters["@cCFORMAT"].Value = "JPG"; break;
            case 1: cmd.Parameters["@cCFORMAT"].Value = "BMP"; break;
            case 2: cmd.Parameters["@cCFORMAT"].Value = "GIF"; break;
            case 3: cmd.Parameters["@cCFORMAT"].Value = "PDF"; break;
            default: break;
          }

          cmd.ExecuteNonQuery();
          miImage = Convert.ToInt32(cmd.Parameters[0].Value);
          bEnrOK = true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub enregistrerImg(ByVal Img As String, Lib As String, Comment As String)
    //
    //Dim c As New ADODB.Command
    //Dim strTypObj As String
    //
    //On Error GoTo handler
    //
    //  ' création/mise à jour de l'objet
    //  Set c.ActiveConnection = cnx
    //  c.CommandText = "api_sp_enregistrerImg"
    //  c.CommandType = adCmdStoredProc
    //  'c.Parameters.Refresh
    //
    //  c.Parameters("@iOBJET").value = miObjet
    //  c.Parameters("@iNIMAGE").value = Me.miImage
    //    
    //  Select Case Me.Combo1.ListIndex
    //    Case 0
    //      c.Parameters("@cCFORMAT").value = "JPG"
    //    Case 1
    //      c.Parameters("@cCFORMAT").value = "BMP"
    //    Case 2
    //      c.Parameters("@cCFORMAT").value = "GIF"
    //    Case 3
    //      c.Parameters("@cCFORMAT").value = "PDF"
    //  End Select
    //  
    //  c.Parameters("@vVIMAGE").value = Trim(Img)
    //  c.Parameters("@vVLIBIMG").value = Trim(Lib)
    //  c.Parameters("@vVCOMMENT").value = Comment
    //  c.Parameters("@ctyp").value = sType
    //  
    //  c.Execute
    //  Me.miImage = c.Parameters("@iNIMAGE").value
    //  Set c = Nothing
    //  
    //  bEnrOK = True
    //
    //Exit Sub
    //Resume
    //handler:
    //  bEnrOK = False
    //  ShowError "enregistrerImg dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void TextImg_TextChanged(object sender, EventArgs e)
    {
      bModFile = true;
    }
    //Private Sub TextImg_Change()
    //  bModFile = True
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void TextLib_TextChanged(object sender, EventArgs e)
    {
      bModif = true;
    }
    //Private Sub TextLib_Change()
    //  bModif = True
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void AfficheImg(String strFile)
    {
      int w = 0;
      int h = 0;

      ToolTip tt = new ToolTip();

      if (strFile.ToUpper().EndsWith(".PDF"))
      {
        brwWebBrowser.Visible = true;
        Image1.Visible = false;
        brwWebBrowser.Navigate(strFile);
      }
      else
      {
        brwWebBrowser.Visible = false;
        Image1.Visible = true;
        mstrImage = strFile;
        tt.SetToolTip(Image1, "");

        if (strFile == "")
        {
          Image1.Image = null;
          Image1.SizeMode = PictureBoxSizeMode.StretchImage;
          Image1.Left = imgX;
          Image1.Top = imgY;
          Image1.Height = imgH;
          Image1.Width = imgW;
          Image1.Tag = "KO";
        }
        else
        {
          Image1.SizeMode = PictureBoxSizeMode.AutoSize;
          Image img = Image.FromFile(strFile);
          Image1.Image = new Bitmap(img);
          img.Dispose();

          if (Image1.Height > imgH || Image1.Width > imgW)
          {
            if (Image1.Height > imgH)
            {
              h = imgH;
              w = (int)(Image1.Width * (Convert.ToDouble(imgH) / Image1.Height));
            }
            else if (Image1.Width > imgW)
            {
              w = imgW;
              h = (Image1.Height * imgW) / Image1.Width;
            }

            Image1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image1.Height = h;
            Image1.Width = w;
            Image1.Tag = "OK";
            tt.SetToolTip(Image1, Resources.txt_doubleCliquezImageTailleReelle);
          }
          else
          {
            Image1.SizeMode = PictureBoxSizeMode.AutoSize;
            Image1.Tag = "KO";
          }
        }
      }

      //Image1.Tag = $"{strFile}|{strFile}";
      Image1.Visible = true;
    }
    //Private Sub AfficheImg(strFile As String)
    //Dim strHtml As String
    //Dim w, h As Integer
    //
    //  'type de fichier
    //  If Majuscule(Right(strFile, 3)) = "PDF" Then
    //      brwWebBrowser.Navigate strFile
    //  Else
    //    strImage = strFile
    //    If strFile = "" Then
    //      Me.Image1.Picture = Nothing
    //      Image1.Stretch = True
    //      Image1.Left = imgX
    //      Image1.Top = ImgY
    //      Image1.height = ImgH
    //      Image1.width = ImgW
    //      Image1.ToolTipText = ""
    //      Image1.Tag = "KO"
    //    Else
    //      Me.Image1.Picture = LoadPicture(strFile)
    //      'traitement taille image
    //      Image1.Stretch = False
    //      If Image1.height > ImgH Or Image1.width > ImgW Then
    //        If Image1.height > ImgH Then
    //          h = ImgH
    //          w = Image1.width * ImgH / Image1.height
    //        ElseIf Image1.width > ImgW Then
    //          w = ImgW
    //          h = Image1.height * ImgW / Image1.width
    //        End If
    //        Image1.Stretch = True
    //        Image1.height = h
    //        Image1.width = w
    //        Image1.Tag = "OK"
    //        Image1.ToolTipText = "§DoubleCliquez pour voir l'image en taille réelle§"
    //      Else
    //        Image1.Stretch = False
    //        Image1.ToolTipText = ""
    //        Image1.Tag = "KO"
    //      End If
    //    End If
    //  End If
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      if (Image1.Tag.ToString() == "OK")
        new frmxVisuImg { msImage = mstrImage }.ShowDialog();
    }
    //Private Sub Image1_DblClick()
    //  If Image1.Tag = "OK" Then
    //    frmxVisuImg.mstrImage = strImage
    //    frmxVisuImg.Show vbModal
    //  End If
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Me.mstrImage = TextLib
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //'Private Sub Image1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    //'
    //'  If Button = 2 Then
    //'    PopupMenu mnuAffichage
    //'  End If
    //'
    //'End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //'Private Sub mnuEnregImage_Click()
    //'Dim fs As New FileSystemObject
    //'
    //'    On Error GoTo errHandler
    //'
    //'    ' Attribue à CancelError la valeur True
    //'    CommonDialog1.CancelError = True
    //'
    //'    CommonDialog1.DialogTitle = "§Enregistrer l'image sous ...§"
    //'    CommonDialog1.FileName = gstrCheminUtilisateur & "\Mozart\image1.jpg"
    //'
    //'    On Error GoTo ExitHandler
    //'    CommonDialog1.ShowSave      ' commune Enregistrer.
    //'    On Error GoTo errHandler
    //'    fs.CopyFile strImage, CommonDialog1.FileName
    //'
    //'ExitHandler:
    //'  Exit Sub
    //'
    //'errHandler:
    //'  'L'utilisateur a cliqué sur Annuler
    //'  ShowError "command2_Click dans " & Me.Name
    //'End Sub
  }
}