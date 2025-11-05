using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmStockListeBE : Form
  {
    DataTable dtBL = new DataTable();
    DataTable dtDetail = new DataTable();

    public frmStockListeBE() { InitializeComponent(); }

    private void frmStockListeBE_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridH.LoadData(dtBL, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeBE 'O'");
        apiTGridH.GridControl.DataSource = dtBL;

        InitapiGridH();

        LoadRsDetail();

        InitapiGridB();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  Set rsBL = New ADODB.Recordset
    //  rsBL.Open "EXEC api_sp_ListeBE 'O'", cnx
    //  InitapiGridH
    //  
    //  Set rsDetail = New ADODB.Recordset
    //  rsDetail.Open "SELECT NLBLNUM, NACTNUM, VLART, NLARTQTE FROM  TLBLLIBRE  order by VLART", cnx, adOpenKeyset, adLockBatchOptimistic ' pas d'update automatique
    //  apiTGridH_Click
    //  InitapiGridB
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void LoadRsDetail()
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (row == null) return;

      apiTGridB.LoadData(dtDetail, MozartDatabase.cnxMozart, "SELECT NLBLNUM, NACTNUM, VLART, NLARTQTE FROM  TLBLLIBRE WHERE NLBLNUM = " + row["NBENUM"] + " order by VLART");
      apiTGridB.GridControl.DataSource = dtDetail;
    }
    //Private Sub LoadRsDetail()
    //  Set rsDetail = New ADODB.Recordset
    //
    //  rsDetail.Open "SELECT NLBLNUM, NACTNUM, VLART, NLARTQTE FROM  TLBLLIBRE  WHERE NLBLNUM = " & rsBL!NBENUM & " order by VLART", cnx, adOpenKeyset, adLockBatchOptimistic ' pas d'update automatique
    //  apiTGridB.Init rsDetail
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (apiTGridH.GetFocusedDataRow() == null) return;

      if (row["VBETYPDEST"].ToString() == "Personnel")
      {
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TBordereau",
          sIdentifiant = $"{row["NBENUM"]}|T|E",
          InfosMail = $"0|0|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PREVIEW",
        }.ShowDialog();
      }

      else if (row["VBETYPDEST"].ToString() == "Site")
      {
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TBordereau",
          sIdentifiant = $"{row["NBENUM"]}|S|E",
          InfosMail = $"0|0|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PREVIEW",
        }.ShowDialog();
      }

      else if (row["VBETYPDEST"].ToString() == "Sous-traitant")
      {
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TBordereau",
          sIdentifiant = $"{row["NBENUM"]}|F|E",
          InfosMail = $"0|0|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PREVIEW",
        }.ShowDialog();
      }
    }
    //Private Sub cmdVisu_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //  If rsBL.EOF And rsBL.BOF Then Exit Sub
    //
    //'  TdbGlobal(0, 0) = "Copie"
    //'  TdbGlobal(0, 1) = "1/2 Original"
    //'  TdbGlobal(1, 0) = "INFO"
    //'  TdbGlobal(1, 1) = "Nous vous demandons de bien vouloir nous retourner l'accusé de réception ci-joint."
    //'
    //'  ' selon les cas
    //'  frmBrowser.bPlanningAn = 0
    //
    //  ' FG le 11/05/21 gestion BL Report
    //
    //  If rsBL!VBETYPDEST = "Personnel" Then  ' Tech
    //
    //    Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsBL!NBENUM & "|T|E;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PREVIEW", vbNormalFocus
    //    
    //'    frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TBordereau.rtf", _
    //'                             "\TTBordereauOut.rtf", _
    //'                           TdbGlobal(), _
    //'                           "exec api_sp_ImpBE " & rsBL!NBENUM & ", T", _
    //'                           " (Prévisualisation commande)", _
    //'                           "PREVIEW"
    //  ElseIf rsBL!VBETYPDEST = "Site" Then    ' site
    //    Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsBL!NBENUM & "|S|E;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PREVIEW", vbNormalFocus
    //    
    //'    frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TBordereau.rtf", _
    //'                             "\TTBordereauOut.rtf", _
    //'                           TdbGlobal(), _
    //'                           "exec api_sp_ImpBE " & rsBL!NBENUM & ", S", _
    //'                           " (Prévisualisation commande)", _
    //'                           "PREVIEW"
    //  
    //  ElseIf rsBL!VBETYPDEST = "Sous-traitant" Then    ' st
    //    Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsBL!NBENUM & "|F|E;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PREVIEW", vbNormalFocus
    //    
    //'    frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TBordereau.rtf", _
    //'                             "\TTBordereauOut.rtf", _
    //'                           TdbGlobal(), _
    //'                           "exec api_sp_ImpBE " & rsBL!NBENUM & ", F", _
    //'                           " (Prévisualisation commande)", _
    //'                           "PREVIEW"
    //  End If
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
    private void apiTGridH_Click(object sender, EventArgs e)
    {
      LoadRsDetail();
    }
    //Private Sub apiTGridH_Click()
    //
    //  If rsBL.EOF Then Exit Sub
    //  LoadRsDetail
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitapiGridH()
    {
      apiTGridH.AddColumn(Resources.col_num_bl, "NBENUM", 900);
      apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 700, "", 1);
      apiTGridH.AddColumn(Resources.col_dateLivr, "DBEDATEEXPE", 1100);
      apiTGridH.AddColumn(Resources.col_datePrepa, "DBEDPREPA", 1600, "Date");
      apiTGridH.AddColumn(Resources.col_Qui, "VBECREATEUR", 1300);
      apiTGridH.AddColumn(Resources.col_OBS, "VBEOBJET", 3000);
      apiTGridH.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1000);
      apiTGridH.AddColumn(Resources.col_destinataire, "VDEST", 1000, "", 0);
      apiTGridH.AddColumn(Resources.col_Tech, "VPERNOM", 900, "", 0);
      apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1300);
      apiTGridH.AddColumn(Resources.col_Code, "VBETYPDEST", 0);
      apiTGridH.FilterBar = true;

      apiTGridH.InitColumnList();
    }
    //Private Sub InitapiGridH()
    //On Error GoTo handler
    //
    //  apiTGridH.AddColumn "§N° BL§", "NBENUM", 900
    //  apiTGridH.AddColumn "§DI§", "NDINNUM", 700, , 1
    //  apiTGridH.AddColumn "§Date livr§", "DBEDATEEXPE", 1100
    //  apiTGridH.AddColumn "§Date prépa§", "DBEDPREPA", 1600
    //  apiTGridH.AddColumn "§Qui§", "VBECREATEUR", 1300
    //  apiTGridH.AddColumn "§OBS§", "VBEOBJET", 3000
    //  apiTGridH.AddColumn "§Chaff§", "VDINCHAFF", 1000
    //  apiTGridH.AddColumn "§Destinataire§", "VDEST", 1000, , 0
    //  apiTGridH.AddColumn "§Tech§", "VPERNOM", 900, , 0
    //  apiTGridH.AddColumn "§Client§", "VCLINOM", 1300
    //  apiTGridH.AddColumn "§code§", "VBETYPDEST", 0
    //  
    //  apiTGridH.AddCellStyle "DBEDPREPA", "", &H0, &HCCCCCC
    //  
    //  apiTGridH.AddCellTip "VBEOBJET", &HFDF0DA
    //  apiTGridH.AddCellTip "VCLINOM", &HFDF0DA
    //  apiTGridH.AddCellTip "VDEST", &HFDF0DA
    //  apiTGridH.FilterBar = True
    //  apiTGridH.Init rsBL
    //  
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
      if (e.RowHandle >= 0 && e.Column.Name == "DBEDPREPA")
      {
        GridView view = sender as GridView;
        if (view.GetDataRow(e.RowHandle)["DBEDPREPA"].GetType().Name != "DateTime") return;
        if (view.GetDataRow(e.RowHandle)["DBEDATEEXPE"].GetType().Name != "DateTime") return;
        DateTime prepa = (DateTime)view.GetDataRow(e.RowHandle)["DBEDPREPA"];
        DateTime expe = (DateTime)view.GetDataRow(e.RowHandle)["DBEDATEEXPE"];
        if (prepa.Year < expe.Year) return;
        if (prepa.Month < expe.Month) return;
        if (prepa.Day > expe.Day)
          e.Appearance.BackColor = Color.Red;
      }
    }
    //Private Sub apiTGridH_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //
    //    On Error Resume Next
    //      
    //    If DataField = "DBEDPREPA" Then
    //                
    //        If DateDiff("d", Format$(Cols(col - 1).CellText(BookMark), "dd/mm/yyyy"), CDate(CellText)) > 0 Then
    //            CellStyle.BackColor = vbRed
    //        End If
    //      
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitapiGridB()
    {
      apiTGridB.AddColumn("Num", "NLBLNUM", 0);
      apiTGridB.AddColumn("ActNum", "NACTNUM", 0);
      apiTGridB.AddColumn(Resources.col_Article, "VLART", 6000);
      apiTGridB.AddColumn(Resources.col_qte2, "NLARTQTE", 1100, "", 2);

      apiTGridB.FilterBar = false;
      apiTGridB.InitColumnList();
    }
    //Private Sub InitapiGridB()
    //  
    //On Error GoTo handler
    //
    //  apiTGridB.AddColumn "Num", "NLBLNUM", 0
    //  apiTGridB.AddColumn "ActNum", "NACTNUM", 0
    //  apiTGridB.AddColumn "§Article§", "VLART", 6000
    //  apiTGridB.AddColumn "§Qté§", "NLARTQTE", 1100, , 2
    //  
    //  apiTGridB.AddCellTip "VLART", &HFDF0DA
    //  
    //  apiTGridB.FilterBar = False
    //  apiTGridB.Init rsDetail
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigridB dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void chkOnlyPlanif_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkOnlyPlanif.Checked)
      {
        apiTGridH.dgv.ActiveFilterString = "DACTPLA != NULL";
      }
      else
      {
        apiTGridH.dgv.ActiveFilterString = "";
      }
    }
    //Private Sub ChkOnlyPlanif_Click()
    //
    //    If ChkOnlyPlanif.value = 1 Then
    //      apiTGridH.stag = "DACTPLA <> NULL"
    //    Else
    //      apiTGridH.stag = ""
    //    End If
    //
    //
    //End Sub

  }
}

