using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeGIDTobj : Form
  {
    public int miNumClient;
    public int miNumSite;
    public string mstrNomClient;

    private string strRepImage;
    private int NbImg = 0;
    private long lObjNum = 0;
    DataTable dtObj = new DataTable();

    List<PictureBox> lstImages = new List<PictureBox>();

    //Public mlNumClient As Long
    //Public mstrNomClient As String
    //Public mlNumSite As Long
    //
    //Dim rsObj As New ADODB.Recordset
    //Dim mRepertoireDoc As String
    //
    //Dim NbImg As Integer
    //Dim lObjNum As Long

    public frmListeGIDTobj() { InitializeComponent(); }

    /* OK ----------------------------------------------------------------------------------------*/
    private void frmListeGIDTobj_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        this.Text = Resources.msg_liste_objets_client + mstrNomClient;
        strRepImage = Utils.RechercheParam("REP_MEDIA");

        string sSql = "SELECT * FROM api_v_GIDT_ListeObjet WHERE NCLINUM = " + miNumClient + " AND NSITNUM = " + miNumSite + " ORDER BY VSITNOM, VNIV1, VNIV2, VNIV3, VOBJLIB";
        Grid.LoadData(dtObj, MozartDatabase.cnxMozart, sSql);
        InitGrid();

        cmdShape1.Tag = "";

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
    //  lObjNum = 0
    //  NbImg = 0
    //  
    //  InitBoutons Me, frmMenu
    //  Me.Caption = "§Liste des objets du client : §" & mstrNomClient
    //  rsObj.Open "SELECT * FROM api_v_GIDT_ListeObjet WHERE NCLINUM = " & mlNumClient & " and NSITNUM=" & mlNumSite & " ORDER BY VSITNOM, VNIV1, VNIV2, VNIV3, VOBJLIB ", cnx, adOpenDynamic, adLockReadOnly
    //  InitGrid
    //  mRepertoireDoc = RechercheParam("REP_MEDIA")
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCancel_Click(object sender, EventArgs e)
    {
      Frame2.Visible = false;
    }
    //Private Sub CmdCancel_Click()
    //  Frame2.Visible = False
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdOK_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        string sSql = $"UPDATE TGIDTOBJ set VOBJMAR = '{txtMarque.Text.Replace("'", "''")}', VOBJREF = '{txtRef.Text.Replace("'", "''")}', " +
                      $"VOBJTYPE = '{txtType.Text.Replace("'", "''")}', NOBJQTE = {Utils.ZeroIfNull(txtQte.Text)}, VOBJCOMP = '{txtCompl.Text.Replace("'", "''")}' " +
                      $"WHERE NOBJNUM = {lObjNum}";
        ModuleData.ExecuteNonQuery(sSql);
        Grid.Requery(dtObj, MozartDatabase.cnxMozart);
        Frame2.Visible = false;
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdOK_Click()
    //  
    //Dim sSQL As String
    //
    //  On Error GoTo handler
    //
    //  sSQL = "update TGIDTOBJ set VOBJMAR = '" & Replace(txtMarque.Text, "'", "''") & "', VOBJREF = '" & Replace(txtRef.Text, "'", "''") & "',"
    //  sSQL = sSQL & " VOBJTYPE = '" & Replace(txtType.Text, "'", "''") & "', NOBJQTE = " & ZeroIfNull(txtQte.Text) & ","
    //  sSQL = sSQL & " VOBJCOMP = '" & Replace(txtCompl.Text, "'", "''") & "'"
    //  sSQL = sSQL & " WHERE NOBJNUM = " & lObjNum
    //  
    //  cnx.Execute sSQL
    //  
    //  rsObj.Requery
    //  Frame2.Visible = False
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdOK_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Grid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      //  Eviter de recharger les images si on ne change pas d'objet
      cmdShape1.Visible = false;

      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      long objNum = Convert.ToInt32(row["NOBJNUM"]);
      if (objNum == lObjNum) return;

      cmdShape1.Tag = "";

      Cursor.Current = Cursors.WaitCursor;
      lObjNum = objNum;
      ChargerImages(lObjNum, this, NbImg, strRepImage);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Grid_RowColChange()
    //
    //  ' Eviter de recharger les images si on ne change pas d'objet
    //  If ZeroIfNull(Grid.Columns.Item("NOBJNUM").value) = lObjNum Then Exit Sub
    //  
    //  lObjNum = ZeroIfNull(Grid.Columns.Item("NOBJNUM").value)
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' Décharger toutes les images. Recherche des images et affichage en miniature
    //  ChargerImages lObjNum, Me, NbImg, mRepertoireDoc
    //  
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitGrid()
    {
      Grid.AddColumn("NOBJNUM", "NOBJNUM", 0);
      Grid.AddColumn("NCLINUM", "NCLINUM", 0);
      Grid.AddColumn("Site", "VSITNOM", 1800);
      Grid.AddColumn("Contrat", "VTYPECONTRAT", 1800);
      Grid.AddColumn("Niveau 1", "VNIV1", 1800);
      Grid.AddColumn("Niveau 2", "VNIV2", 1800);
      Grid.AddColumn("Niveau 3", "VNIV3", 1800);
      Grid.AddColumn("Objet", "VOBJLIB", 1900);
      Grid.AddColumn("Numero", "VOBJNUMERO", 1900);
      Grid.AddColumn("Marque", "VOBJMAR", 1700);
      Grid.AddColumn("Type", "VOBJTYPE", 1300);
      Grid.AddColumn("Référence", "VOBJREF", 1300);
      Grid.AddColumn("Qté", "NOBJQTE", 800, "", 2);
      Grid.AddColumn("Compl", "VOBJCOMP", 2000);

      Grid.dgv.OptionsView.AllowCellMerge = true;
      Grid.dgv.Columns["VNIV3"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      Grid.dgv.Columns["VOBJNUMERO"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      Grid.dgv.Columns["VOBJMAR"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      Grid.dgv.Columns["VOBJTYPE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      Grid.dgv.Columns["VOBJREF"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      Grid.dgv.Columns["NOBJQTE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      Grid.dgv.Columns["VOBJCOMP"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

      Grid.InitColumnList();
      Grid.GridControl.DataSource = dtObj;
    }
    //Sub InitGrid()
    //  On Error GoTo handler
    //  
    //  Grid.AddColumn "NOBJNUM", "NOBJNUM", 0
    //  Grid.AddColumn "NCLINUM", "NCLINUM", 0
    //  Grid.AddColumn "§Site§", "VSITNOM", 1800, , , , , , True
    //  Grid.AddColumn "§Niveau 1§", "VNIV1", 1800, , , , , , True
    //  Grid.AddColumn "§Niveau 2§", "VNIV2", 1800, , , , , , True
    //  Grid.AddColumn "§Niveau 3§", "VNIV3", 1800
    //  Grid.AddColumn "§Objet§", "VOBJLIB", 1900
    //  Grid.AddColumn "Numéro", "VOBJNUMERO", 1300
    //  Grid.AddColumn "§Marque§", "VOBJMAR", 1700
    //  Grid.AddColumn "§Type§", "VOBJTYPE", 1300
    //  Grid.AddColumn "§Référence§", "VOBJREF", 1300
    //  Grid.AddColumn "§Qté§", "NOBJQTE", 800, , 2
    //  Grid.AddColumn "§Compl§", "VOBJCOMP", 2000      // Resources.col_complement
    //  
    //  Grid.AddCellTip "VOBJCOMP", &HFDF0DA
    //  Grid.Init rsObj
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitGrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Image1_Click(object sender, EventArgs e)
    {
      PictureBox pic = sender as PictureBox;
      cmdShape1.Top = pic.Top - 4;
      cmdShape1.Left = pic.Left - 4;
      cmdShape1.Height = pic.Height + 8;
      cmdShape1.Width = pic.Width + 8;
      cmdShape1.Visible = true;
      cmdShape1.Tag = pic.Tag;
      cmdShape1.Visible = true;
    }
    //Private Sub Image1_Click(Index As Integer)
    //  Shape1.Move Image1(Index).Left - 20, Image1(Index).Top - 20, Image1(Index).width + 40, Image1(Index).height + 40
    //  Shape1.Visible = True
    //  Shape1.Tag = Index
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      frmxVisuImg f = new frmxVisuImg();
      f.msImage = (sender as PictureBox).Tag.ToString().Split('|')[0];
      f.ShowDialog();
    }
    //Private Sub Image1_DblClick(Index As Integer)
    //  If Shape1.Tag = "" Then Exit Sub
    //  
    //  frmxVisuImg.mstrImage = Left(Image1(Shape1.Tag).Tag, InStr(Image1(Shape1.Tag).Tag, "|") - 1)
    //  frmxVisuImg.Show vbModal
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void ChargerImages(long lObjet, Form frm, int iNbImg, string strRepImage)
    {
      //shape1.Visible = false;

      if (lObjet < 1)
        return;

      for (int i = 0; i < lstImages.Count; i++)
      {
        lstImages[i].Image.Dispose();
        lstImages[i].Dispose();
      }
      lstImages.Clear(); lstImages.Clear();

      foreach (Control item in Frame1.Controls.OfType<Control>().ToList())
        if (!item.Name.StartsWith("cmd"))
          Frame1.Controls.Remove(item);

      //  Recherche et affichage des images de cet objet
      DataTable dtImg = new DataTable();
      dtImg.Load(ModuleData.ExecuteReader("SELECT * from TFICOBJ where NOBJET = " + lObjet));

      foreach (DataRow item in dtImg.Rows)
      {
        PictureBox pic = new PictureBox();
        pic.Height = 100;
        pic.Width = 100;
        pic.Left = (120 * lstImages.Count) + 120;
        lstImages.Add(pic);
        pic.Name = $"Img_{lstImages.Count}";
        Frame1.Controls.Add(pic);
        pic.BringToFront();
        pic.DoubleClick += new EventHandler(Image1_DoubleClick);
        pic.Click += new EventHandler(Image1_Click);
        ChargementImage(lstImages[iNbImg], strRepImage + item["VFICHIER"].ToString(), Convert.ToInt32(item["NFICHIER"]));
        iNbImg = iNbImg + 1;
      }
    }
    //Public Sub ChargerImages(lObjet As Long, frm As Form, ByRef iNbImg As Integer, mRepertoireDoc As String, Optional sType As String = "")
    //Dim rsImg As New Recordset
    //
    //
    //  On Error Resume Next
    //  While iNbImg > 0
    //    Unload frm.Image1(iNbImg)
    //    iNbImg = iNbImg - 1
    //  Wend
    //  
    //  ' Cacher la dernière image
    //  frm.Image1(iNbImg).Visible = False
    //  frm.Shape1.Visible = False
    //  frm.Shape1.Tag = ""
    //  If lObjet < 1 Then Exit Sub
    //    
    //  On Error GoTo errH
    //  
    //  ' Recherche et affichage des images de cet objet
    //  If sType = "" Then
    //    rsImg.Open "SELECT * from TFICOBJ where NOBJET = " & lObjet, cnx
    //  Else
    //    rsImg.Open "SELECT * from TFICDIA where NDIANUM = " & lObjet, cnx
    //  End If
    //  
    //  If Not (rsImg.BOF And rsImg.EOF) Then
    //    While Not rsImg.EOF
    //      If iNbImg > 0 Then
    //        Load frm.Image1(iNbImg)
    //        frm.Image1(iNbImg).Left = frm.Image1(iNbImg - 1).Left + frm.Image1(iNbImg - 1).width + 300
    //      End If
    //      ChargementImage frm.Image1(iNbImg), mRepertoireDoc & rsImg!VFICHIER, rsImg!NFICHIER
    //      iNbImg = iNbImg + 1
    //      rsImg.MoveNext
    //    Wend
    //  End If
    //  rsImg.Close
    //  Set rsImg = Nothing
    //  Exit Sub
    //  Resume
    //  
    //errH:
    //  ShowError "ChargerImages dans modGIDT"
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void ChargementImage(PictureBox imgCtl, string sFichier, long iFichier)
    {
      try
      {
        int w = 100;
        int h = 100;
        float ratio;

        if (sFichier.ToUpper().EndsWith(".PDF"))
        {
          imgCtl.SizeMode = PictureBoxSizeMode.Zoom;
          imgCtl.Top = 16;
          imgCtl.Image = imgPDF.Image;
        }
        else
        {
          imgCtl.SizeMode = PictureBoxSizeMode.AutoSize;
          imgCtl.Image = Image.FromFile(sFichier);
          ratio = (float)((double)imgCtl.Height / imgCtl.Width);

          if (ratio <= 1)
            h = Convert.ToInt32(w * ratio);
          else
            w = Convert.ToInt32(h / ratio);

          imgCtl.Top = 16;
          imgCtl.SizeMode = PictureBoxSizeMode.StretchImage;
          imgCtl.Height = h;
          imgCtl.Width = w;
        }

        imgCtl.Tag = $"{sFichier}|{iFichier}";
        imgCtl.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub ChargementImage(imgCtl As Image, sFichier As String, iFichier As Long)
    //Dim w As Integer
    //Dim h As Integer
    //Dim ratio As Single
    //  
    //  w = 1500:  h = 1500
    //  
    //  If UCase(Mid(sFichier, InStrRev(sFichier, "."))) = ".PDF" Then
    //    imgCtl.Stretch = False
    //    imgCtl.Top = 480
    //    imgCtl.Picture = imgPDF.Picture
    //  Else
    //    imgCtl.Picture = LoadPicture(sFichier)
    //    imgCtl.Stretch = False
    //    ratio = imgCtl.height / imgCtl.width
    //    
    //    If ratio <= 1 Then
    //      h = w * ratio
    //      imgCtl.Top = 250
    //    Else
    //      w = h / ratio
    //      imgCtl.Top = 250
    //    End If
    //    
    //    imgCtl.Stretch = True
    //    imgCtl.height = h
    //    imgCtl.width = w
    //  End If
    //  
    //  imgCtl.Tag = sFichier & "|" & iFichier
    //  imgCtl.Visible = True
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdAddMedia_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = Grid.GetFocusedDataRow();
        if (row == null) return;

        Cursor.Current = Cursors.WaitCursor;
        frmMedia f = new frmMedia();
        f.mstrClient = mstrNomClient;
        f.mstrSite = row["VSITNOM"].ToString();
        f.miSitNum = miNumSite;
        f.mstrStatut = "C";
        f.sType = "GIDT";
        f.mstrObjet = row["VOBJLIB"].ToString();
        f.miObjet = Convert.ToInt32(row["NOBJNUM"]);
        f.ShowDialog();

        lObjNum = 0;   // Pour forcer le RowColChange à faire son boulot
        Grid.Requery(dtObj, MozartDatabase.cnxMozart);

        //ChargerImages(Convert.ToInt32(row["NOBJNUM"]), this, NbImg, mRepertoireDoc);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdAddMedia_Click()
    //  On Error GoTo handler
    //
    //  If rsObj.BOF And rsObj.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  frmMedia.mstrClient = mstrNomClient
    //  frmMedia.mstrSite = rsObj!VSITNOM
    //  frmMedia.miSitNum = mlNumSite
    //  frmMedia.mstrStatut = "C"
    //  frmMedia.sType = "GIDT"
    //  frmMedia.mstrObjet = rsObj!VOBJLIB
    //  frmMedia.miObjet = rsObj!NOBJNUM
    //  frmMedia.Show vbModal
    //  'lObjNum = 0   ' Pour forcer le RowColChange à faire son boulot
    //  rsObj.Requery
    //  
    //  ChargerImages rsObj!NOBJNUM, Me, NbImg, mRepertoireDoc
    //  
    //  Exit Sub
    //  Resume
    //
    //handler:
    //  ShowError "mnuAjouterMedia_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifMedia_Click(object sender, EventArgs e)
    {
      if (cmdShape1.Tag.ToString() == "") return;

      try
      {
        DataRow row = Grid.GetFocusedDataRow();
        if (row == null) return;

        Cursor.Current = Cursors.WaitCursor;
        frmMedia f = new frmMedia();
        f.mstrClient = mstrNomClient;
        f.mstrSite = row["VSITNOM"].ToString();
        f.miSitNum = miNumSite;
        f.mstrStatut = "M";
        f.sType = "GIDT";
        f.mstrObjet = row["VOBJLIB"].ToString();
        f.miObjet = Convert.ToInt32(row["NOBJNUM"]);
        f.miImage = Convert.ToInt32(cmdShape1.Tag.ToString().Split('|')[1]);
        f.ShowDialog();

        lObjNum = 0;   // Pour forcer le RowColChange à faire son boulot
        Grid.Requery(dtObj, MozartDatabase.cnxMozart);

        row = Grid.GetFocusedDataRow();
        ChargerImages(Convert.ToInt32(row["NOBJNUM"]), this, NbImg, strRepImage);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdModifMedia_Click()
    //  On Error GoTo errH
    //
    //  If Shape1.Tag = "" Then Exit Sub
    //  If rsObj.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  frmMedia.mstrClient = mstrNomClient
    //  frmMedia.mstrSite = rsObj!VSITNOM
    //  frmMedia.miSitNum = mlNumSite
    //  frmMedia.mstrStatut = "M"
    //  frmMedia.sType = "GIDT"
    //  frmMedia.miImage = Mid(Image1(Shape1.Tag).Tag, InStrRev(Image1(Shape1.Tag).Tag, "|") + 1)
    //  frmMedia.mstrObjet = rsObj!VOBJLIB
    //  frmMedia.miObjet = rsObj!NOBJNUM
    //  frmMedia.Show vbModal
    //  'lObjNum = 0   ' Pour forcer le RowColChange à faire son boulot
    //  rsObj.Requery
    //  
    //  ChargerImages rsObj!NOBJNUM, Me, NbImg, mRepertoireDoc
    //  
    //  Exit Sub
    //  Resume Next
    //errH:
    //  ShowError "mnuAjouterMedia_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdVisuMedia_Click(object sender, EventArgs e)
    {
      if (cmdShape1.Tag.ToString() == "") return;

      frmxVisuImg f = new frmxVisuImg();
      f.msImage = cmdShape1.Tag.ToString().Split('|')[0];
      f.ShowDialog();
    }
    //Private Sub cmdVisuMedia_Click()
    //  If Shape1.Tag = "" Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  frmxVisuImg.mstrImage = Left(Image1(Shape1.Tag).Tag, InStr(Image1(Shape1.Tag).Tag, "|") - 1)
    //  frmxVisuImg.Show vbModal
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDelMedia_Click(object sender, EventArgs e)
    {
      try
      {
        if (cmdShape1.Tag.ToString() == "") return;

        if (MessageBox.Show(Resources.msg_ConfirmDelImg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        // Suppression en base (la suppression du fichier sur le disque se fait par le trigger TU_DELETE sur la table TFICOBJ)
        // VL -> Visiblement le trigger n'existe pas sur la table TFICOBJ !!!
        ModuleData.ExecuteNonQuery($"exec api_sp_SupprimerMedia {cmdShape1.Tag.ToString().Split('|')[1]}");

        lObjNum = 0;
        Grid.Requery(dtObj, MozartDatabase.cnxMozart);
        cmdShape1.Visible = false;

        File.SetAttributes(cmdShape1.Tag.ToString().Split('|')[0], FileAttributes.Normal);
        File.Delete(cmdShape1.Tag.ToString().Split('|')[0]);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdDelMedia_Click()
    //  On Error GoTo errH
    // 
    //  If Shape1.Tag = "" Then Exit Sub
    //  
    //  If MsgBox("Voulez-vous vraiment supprimer cette image ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then Exit Sub
    //  
    //  ' Suppression en base (la suppression du fichier sur le disque se fait par le trigger TU_DELETE sur la table TFICOBJ)
    //  cnx.Execute "exec api_sp_SupprimerMedia " & Mid(Image1(Shape1.Tag).Tag, InStrRev(Image1(Shape1.Tag).Tag, "|") + 1)
    //  Kill Left(Image1(Shape1.Tag).Tag, InStr(Image1(Shape1.Tag).Tag, "|") - 1)
    //  Image1(Shape1.Tag).Visible = False
    //  Shape1.Tag = ""
    //  Exit Sub
    //  
    //errH:
    //  ShowError "cmdDelMedia_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      //  si pas de sélection on sort
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      if (Convert.ToInt32(row["NOBJNUM"]) == 0) return;

      lObjNum = Convert.ToInt32(row["NOBJNUM"]);
      lblLabels4.Text = "Objet : " + row["VOBJLIB"].ToString();
      txtMarque.Text = row["VOBJMAR"].ToString();
      txtRef.Text = row["VOBJREF"].ToString();
      txtType.Text = row["VOBJTYPE"].ToString();
      txtQte.Text = row["NOBJQTE"].ToString();
      txtCompl.Text = row["VOBJCOMP"].ToString();

      Frame2.Visible = true;
    }
    //Private Sub cmdModifier_Click()
    // 
    //  ' si pas de sélection on sort
    //  If ZeroIfNull(Grid.Columns.Item("NOBJNUM").value) = 0 Then Exit Sub
    //  
    //  lObjNum = ZeroIfNull(Grid.Columns.Item("NOBJNUM").value)
    //  
    //  lblLabels(4).Caption = "Objet : " & Grid.Columns.Item("VOBJLIB").value
    //  txtMarque.Text = Grid.Columns.Item("VOBJMAR").value
    //  txtRef.Text = Grid.Columns.Item("VOBJREF").value
    //  txtType.Text = Grid.Columns.Item("VOBJTYPE").value
    //  txtQte.Text = Grid.Columns.Item("NOBJQTE").value
    //  txtCompl.Text = Grid.Columns.Item("VOBJCOMP").value
    //  
    //  Frame2.Visible = True
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void Grid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle == this.Grid.dgv.FocusedRowHandle)
      {
        e.Appearance.BackColor = Color.LightSkyBlue;
        //return;
        GridViewInfo info = this.Grid.dgv.GetViewInfo() as GridViewInfo;
        GridCellInfo cellInfo = info.GetGridCellInfo(e.RowHandle, this.Grid.dgv.Columns["VSITNOM"]);

        if (cellInfo == null) return;

        if (cellInfo.IsMerged)
        {
          for (int i = 0; i < cellInfo.MergedCell.MergedCells.Count; i++)
          {
            if (cellInfo.MergedCell.MergedCells[i].RowHandle == this.Grid.dgv.FocusedRowHandle) // && e.Column.FieldName == "VTYPECONTRAT")
            {
              e.Appearance.BackColor = Color.LightSkyBlue;
              //return;
            }
          }
          //e.Appearance.BackColor = Color.Yellow;
        }
        //else
      }
      else
        e.Appearance.BackColor = Color.Azure;
    }

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  On Error Resume Next
    //  rsObj.Close
    //  Set rsObj = Nothing
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Resize()
    //  Grid.height = Me.height - Grid.Top - Frame1.height - 1000
    //  Frame1.Top = Grid.Top + Grid.height + 100
    //  Grid.width = Me.width - Grid.Left - 200
    //End Sub
  }
}