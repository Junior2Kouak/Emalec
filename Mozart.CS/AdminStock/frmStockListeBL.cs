using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockListeBL : Form
  {
    DataTable dtBL = new DataTable();
    DataTable dtDetail = new DataTable();
    //Dim rsBL As ADODB.Recordset
    //Dim rsDetail As ADODB.Recordset

    public frmStockListeBL() { InitializeComponent(); }

    private void frmStockListeBL_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridH.LoadData(dtBL, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_ListeBLNew ORDER BY NBLNUM DESC");
        apiTGridH.GridControl.DataSource = dtBL;

        InitapiGridH();

        DataRow row = apiTGridH.GetFocusedDataRow();
        apiTGridB.LoadData(dtDetail, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_ListeBLDetails WHERE NBLNUM =" + row["NBLNUM"] + "ORDER BY VFOUSER, VFOUMAT");
        apiTGridB.GridControl.DataSource = dtDetail;

        InitapiGridB();
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
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  Set rsBL = New ADODB.Recordset
    //  rsBL.Open "SELECT * FROM api_v_ListeBLNew ORDER BY NBLNUM DESC ", cnx
    //  InitapiGridH
    //  
    //  Set rsDetail = New ADODB.Recordset
    //  rsDetail.Open "SELECT * FROM api_v_ListeBLDetails WHERE NBLNUM = 0 ORDER BY VFOUSER, VFOUMAT", cnx
    //  apiTGridH_Click
    //  InitapiGridB
    //  Screen.MousePointer = vbDefault
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGridH.GetFocusedDataRow() == null) return;
      DataRow row = apiTGridH.GetFocusedDataRow();

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TBordereau",
        sIdentifiant = $"{row["NBLNUM"]}|T|L",
        InfosMail = $"0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
      }.ShowDialog();
    }
    //Private Sub cmdVisu_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  ' Impression du BL
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "1/2 Original"
    //  TdbGlobal(1, 0) = "INFO"
    //  TdbGlobal(1, 1) = "sInfo"
    //
    //  
    // If rsBL.EOF Then Exit Sub
    // 
    //  Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsBL!NBLNUM & "|T|L;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PREVIEW", vbNormalFocus
    //
    //'  CréationFicher gstrCheminModeles & gstrLangue & "\" & "TBLNew.rtf", _
    //'                  "\TBLOut1.rtf", _
    //'                  TdbGlobal(), _
    //'                  "exec api_sp_impBL " & rsBL!NBLNUM & ", 1", _
    //'                  "(Bordereau de livraison)"
    //'
    //'  frmBrowser.Preview_Print gstrCheminUtilisateur & "\Mozart\TBLOut1.rtf", _
    //'                            "\TBLOut.rtf", _
    //'                            TdbGlobal(), _
    //'                            "exec api_sp_impBL " & rsBL!NBLNUM & ", 2", _
    //'                            " (Prévisualisation BL)", _
    //                            "PREVIEW"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCde_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);
      frmCommandeFournisseur f = new frmCommandeFournisseur();
      f.miNumCommande = (0);
      f.miNumCom = (0);
      f.mstrStatutCommande = "C";
      f.mbStock = true;
      f.ShowDialog();

      MessageBox.Show($"{Resources.msg_laCommande} {f.miNumCom}{Resources.msg_eteCreee}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      MozartParams.NumAction = 0;
    }
    //Private Sub cmdCde_Click()
    //    
    //    If rsBL.EOF Then Exit Sub
    //   
    //    glNumAction = rsBL!NACTNUM
    //    frmCommandeFournisseur.iNumCommande = 0
    //    frmCommandeFournisseur.iNumCom = 0
    //    frmCommandeFournisseur.mstrStatutCommande = "C"
    //    frmCommandeFournisseur.bStock = True
    //    frmCommandeFournisseur.Show vbModal
    //    
    //    MsgBox "§La commande §" & frmCommandeFournisseur.iNumCom & "§ a été créée§"
    //    
    //    glNumAction = 0
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub apiTGridH_RowColChange()
    //  
    //  If rsBL.EOF Then Exit Sub
    //
    //  rsDetail.Close
    //  rsDetail.Open "SELECT * FROM api_v_ListeBLDetails WHERE NBLNUM = " & rsBL!NBLNUM & " ORDER BY VFOUSER, VFOUMAT", cnx
    //
    //  apiTGridB.Init rsDetail, True
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiTGridH_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (row == null) return;

      apiTGridB.LoadData(dtDetail, MozartDatabase.cnxMozart, "SELECT * FROM api_v_ListeBLDetails WHERE NBLNUM = " + row["NBLNUM"] + " ORDER BY VFOUSER, VFOUMAT");
      apiTGridB.GridControl.DataSource = dtDetail;
    }
    //Private Sub apiTGridH_Click()
    //
    //  If rsBL.EOF Then Exit Sub
    //
    //  rsDetail.Close
    //  rsDetail.Open "SELECT * FROM api_v_ListeBLDetails WHERE NBLNUM = " & rsBL!NBLNUM & " ORDER BY VFOUSER, VFOUMAT", cnx
    //
    //  apiTGridB.Init rsDetail, True
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitapiGridH()
    {
      apiTGridH.AddColumn(Resources.col_BL, "NBLNUM", 800, "", 2);
      apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 800);
      apiTGridH.AddColumn("ActNum", "NACTNUM", 0);
      apiTGridH.AddColumn(Resources.col_Dde, "NDDENUM", 800);
      apiTGridH.AddColumn(Resources.col_Action, "NACTID", 600, "", 2);
      apiTGridH.AddColumn(Resources.col_date_BL, "DBLDATE", 1100, "Date");
      apiTGridH.AddColumn(Resources.col_dateLivr_souhait, "DDDELIVR", 2100, "", 2);
      apiTGridH.AddColumn(Resources.col_Qui, "VBLCREATEUR", 1800);
      apiTGridH.AddColumn(Resources.col_Lbl, "VACTDES", 2800);
      apiTGridH.AddColumn(Resources.col_Cpt, "NBLANA", 800, "", 2);
      apiTGridH.AddColumn(Resources.col_Transfert, "NBLXFER", 0, "", 2);
      apiTGridH.AddColumn(Resources.col_Dest, "VDDETYPDEST", 1200);
      apiTGridH.AddColumn(Resources.col_Qui, "VPERNOM", 1500);
      apiTGridH.FilterBar = true;

      apiTGridH.InitColumnList();
    }
    //Private Sub InitapiGridH()
    //  
    //On Error GoTo handler
    //
    //  apiTGridH.AddColumn "§BL§", "NBLNUM", 800, , 2
    //  apiTGridH.AddColumn "§DI§", "NDINNUM", 800
    //  apiTGridH.AddColumn "ActNum", "NACTNUM", 0
    //  apiTGridH.AddColumn "§Dde§", "NDDENUM", 800
    //  apiTGridH.AddColumn "§Action§", "NACTID", 600, , 2
    //  apiTGridH.AddColumn "§Date BL§", "DBLDATE", 1100
    //  apiTGridH.AddColumn "§Date livraison souhaitée§", "DDDELIVR", 2100, , 2
    //  apiTGridH.AddColumn "§Qui§", "VBLCREATEUR", 1800
    //  apiTGridH.AddColumn "§Libellé§", "VACTDES", 2800
    //  apiTGridH.AddColumn "§Cpt§", "NBLANA", 800, , 2
    //'  apiTGridH.AddColumn "§Transfert§", "NBLXFER", 0, , 2
    //  apiTGridH.AddColumn "§Dest§", "VDDETYPDEST", 1200
    //  apiTGridH.AddColumn "§Qui§", "VPERNOM", 1500
    //  
    //  apiTGridH.AddCellStyle "DDDELIVR", "", &H0, &HCCCCCC
    //  
    //  
    //  apiTGridH.AddCellTip "VACTDES", &HFDF0DA
    //  apiTGridH.AddCellTip "VPERNOM", &HFDF0DA
    //  
    //  apiTGridH.FilterBar = False
    //  apiTGridH.Init rsBL
    //  
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApigridH dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiTGridH_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "DDDELIVR")
      {
        GridView view = sender as GridView;
        if (view.GetDataRow(e.RowHandle)["DDDELIVR"].GetType().Name != "String") return;
        if (view.GetDataRow(e.RowHandle)["DBLDATE"].GetType().Name != "DateTime") return;
        DateTime livr = Convert.ToDateTime(view.GetDataRow(e.RowHandle)["DDDELIVR"]);
        DateTime bl = (DateTime)view.GetDataRow(e.RowHandle)["DBLDATE"];
        if (livr.Year > bl.Year) return;
        if (livr.Month > bl.Month) return;
        if (livr.Day < bl.Day)
          e.Appearance.BackColor = Color.Red;
      }
    }
    //Private Sub apiTGridH_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //
    //    On Error Resume Next
    //      
    //    If DataField = "DDDELIVR" Then
    //    
    //      If CDate(CellText) < Format$(Cols(col - 1).CellText(BookMark), "dd/mm/yyyy") Then
    //          CellStyle.BackColor = vbRed
    //      End If
    //      
    //    End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitapiGridB()
    {
      apiTGridB.AddColumn(Resources.col_BL, "NBLNUM", 0);
      apiTGridB.AddColumn("FOUNum", "NFOUNUM", 0);
      apiTGridB.AddColumn(Resources.col_série, "VFOUSER", 1700);
      apiTGridB.AddColumn(Resources.col_Article, "VFOUMAT", 4500);
      apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1700);
      apiTGridB.AddColumn(Resources.col_Type, "VFOUTYP", 1700);
      apiTGridB.AddColumn(Resources.col_reference, "VFOUREF", 1700);
      apiTGridB.AddColumn(Resources.col_QteDde, "NBLLQTE", 1400, "", 2);
      apiTGridB.FilterBar = false;

      apiTGridB.InitColumnList();
    }
    //Private Sub InitapiGridB()
    //  
    //On Error GoTo handler
    //
    //  apiTGridB.AddColumn "§BL§", "NBLNUM", 0
    //  apiTGridB.AddColumn "FOUNum", "NFOUNUM", 0
    //  apiTGridB.AddColumn "§Série§", "VFOUSER", 1700
    //  apiTGridB.AddColumn "§Article§", "VFOUMAT", 4500
    //  apiTGridB.AddColumn "§Marque§", "VFOUMAR", 1700
    //  apiTGridB.AddColumn "§Type§", "VFOUTYP", 1700
    //  apiTGridB.AddColumn "§Référence§", "VFOUREF", 1700
    //  apiTGridB.AddColumn "§Qté dde§", "NBLLQTE", 1400, , 2
    //  
    //  apiTGridB.FilterBar = False
    //  apiTGridB.Init rsDetail
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigridB dans " & Me.Name
    //End Sub

  }
}

