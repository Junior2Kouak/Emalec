using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockEdition : Form
  {
    private DataTable dt = new DataTable();
    string sSQL;
    //Dim rsArt As ADODB.Recordset
    //Dim sSQL As String
    public frmStockEdition()
    {
      InitializeComponent();
      GridLocalizer.Active = new CustomGridLocalizer();
    }
    class CustomGridLocalizer : GridLocalizer
    {
      public override string GetLocalizedString(GridStringId id)
      {
        if (id == GridStringId.CheckboxSelectorColumnCaption)
        {
          return " ";
        }
        return base.GetLocalizedString(id);
      }
    }
    private void frmStockEdition_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeFournitures");
        apiTGridH.GridControl.DataSource = dt;

        // correctif cas colonne check à null
        foreach (DataRow row in dt.Rows)
          if (row["CHECK"] == DBNull.Value) row["Check"] = false;

        InitapiGridH();
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
    //Dim sFile As String
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  InitBoutons Me, frmMenu
    //    
    //  Set rsArt = New ADODB.Recordset
    //  rsArt.Open "exec api_sp_ListeFournitures ", cnx
    //  sFile = gstrCheminUtilisateur & "\mozart\ListeRupt.tmp"
    //  On Error Resume Next
    //  Kill sFile
    //  rsArt.Save sFile
    //  rsArt.Close
    //  
    //  Set rsArt = New ADODB.Recordset
    //  rsArt.Open sFile, , adOpenKeyset, adLockOptimistic
    //  apiTGridH.Init rsArt, True
    //  Screen.MousePointer = vbDefault
    //  
    //  InitapiGridH
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string[,] TdbGlobal = { { "", "" }, { "", "" }, { "", "" }, { "", "" }, { "", "" } };

      new frmBrowser()
      {
        miPlanningAn = 0
      }.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TEtiquetteMag.rtf",
                      @"TEtiquetteMagOut.rtf",
                      TdbGlobal,
                      SelectListe(),
                      " (Visualisation d'un site)",
                      "PREVIEW");
    }
    //Private Sub cmdVisu_Click()
    //
    //Dim TdbGlobal(0 To 5, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TEtiquetteMag.rtf", _
    //                           "\TEtiquetteMagOut.rtf", _
    //                           TdbGlobal(), _
    //                           SelectListe, _
    //                           " (Visualisation d'un site)", _
    //                           "PREVIEW"
    //
    //End Sub
    //' UPGRADE_INFO (#0501): The 'Command2_Click' member isn't used anywhere in current application.
    //'Private Sub Command2_Click()
    //''  rsArt!VSTFGRPNOM = dbGrid.Columns("Fournisseur").Text
    //''  rsArt!PRIX = Replace(dbGrid.Columns("Prix HT").Text, ",", ".")
    //''  rsArt!nStfGrpNum = CInt(dbGrid.Columns("Num").Text)
    //''  Frame1.Visible = False
    //'End Sub
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
    //
    /* --------------------------------------------------------------------------------------- */
    private string SelectListe()
    {
      sSQL = "SELECT ";
      int i = 1;
      string SelectListe;

      foreach (DataRow row in dt.Rows)
      {
        if (row["CHECK"].ToString() != "0")
        {
          sSQL = sSQL + "'" + row["VFOUMAT"].ToString().Replace("'", "''") + "' as VFOUMAT" + i + " , ";
          sSQL = sSQL + "'" + Utils.BlankIfNull(row["VFOUTYP"].ToString().Replace("'", "''")) + "'  as VFOUTYP" + i + " , ";
          sSQL = sSQL + "'" + Utils.BlankIfNull(row["VFOUREF"].ToString().Replace("'", "''")) + "' as VFOUREF" + i + " , ";
          sSQL = sSQL + "'" + Utils.BlankIfNull(row["CCFOCOD"].ToString().Replace("'", "''")) + "' as CCFOCOD" + i + " , ";

          i = i + 1;
        }
      }
      if (i < 11)
      {
        i = 11 - i;
        while (i >= 0)
        {
          sSQL = sSQL + "'' as VFOUMAT" + (10 - i) + " , ";
          sSQL = sSQL + "'' as VFOUTYP" + (10 - i) + " , ";
          sSQL = sSQL + "'' as VFOUREF" + (10 - i) + " , ";
          sSQL = sSQL + "'' as CCFOCOD" + (10 - i) + " , ";

          i = i - 1;
        }
      }
      SelectListe = sSQL + " '' as fin";

      return SelectListe;
    }
    //Private Function SelectListe() As String
    //  
    //Dim i As Integer
    //
    //  On Error Resume Next
    //  rsArt.MoveFirst
    //  On Error GoTo handler
    //  
    //  sSQL = "SELECT "
    //  i = 1
    //  While Not rsArt.EOF
    //    If rsArt!Check <> 0 Then
    //      sSQL = sSQL + "'" & Replace(rsArt("VFOUMAT"), "'", "''") & "' as VFOUMAT" & i & " , "
    //      sSQL = sSQL + "'" & Replace(BlankIfNull(rsArt("VFOUTYP")), "'", "''") & "'  as VFOUTYP" & i & " , "
    //      sSQL = sSQL + "'" & Replace(BlankIfNull(rsArt("VFOUREF")), "'", "''") & "' as VFOUREF" & i & " , "
    //      sSQL = sSQL + "'" & Replace(BlankIfNull(rsArt("CCFOCOD")), "'", "''") & "' as CCFOCOD" & i & " , "
    //      
    //'        rsArt.Delete      ' Faire disparaitre de la liste du haut
    //      i = i + 1
    //    End If
    //    rsArt.MoveNext
    //  Wend
    //  
    //  If i < 11 Then
    //    i = 11 - i
    //    While i >= 0
    //      sSQL = sSQL + "'' as VFOUMAT" & 10 - i & " , "
    //      sSQL = sSQL + "''  as VFOUTYP" & 10 - i & " , "
    //      sSQL = sSQL + "'' as VFOUREF" & 10 - i & " , "
    //      sSQL = sSQL + "'' as CCFOCOD" & 10 - i & " , "
    //      i = i - 1
    //    Wend
    //  End If
    //  
    //  SelectListe = sSQL & " '' as fin"
    //  
    //  rsArt.MoveFirst
    //  Exit Function
    //  Resume
    //handler:
    //  ShowError "SelectListe dans " & Me.Name
    //End Function
    //  
    /* --------------------------------------------------------------------------------------- */
    private void InitapiGridH()
    {
      //apiTGridH.AddColumn("", "CHECK", 300, "", 0, false, false, true);
      apiTGridH.AddColumn(Resources.col_Article, "VFOUMAT", 7000);
      apiTGridH.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
      apiTGridH.AddColumn(Resources.col_Ref, "VFOUREF", 2000);
      apiTGridH.AddColumn(Resources.col_série, "CCFOCOD", 1500);

      apiTGridH.InitColumnList();

      apiTGridH.dgv.OptionsSelection.MultiSelect = true;
      apiTGridH.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
      apiTGridH.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
      apiTGridH.dgv.OptionsSelection.CheckBoxSelectorField = "CHECK";
    }
    //Private Sub InitapiGridH()
    //  On Error GoTo handler
    //
    //  apiTGridH.AddColumn " ", "CHECK", 300, , , , , True
    //  apiTGridH.AddColumn "§Article§", "VFOUMAT", 7000
    //  apiTGridH.AddColumn "§Type§", "VFOUTYP", 1500
    //  apiTGridH.AddColumn "§Référence§", "VFOUREF", 2000
    //  apiTGridH.AddColumn "§Série§", "CCFOCOD", 1500
    //  
    //  apiTGridH.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiTGridH.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiTGridH.AddCellTip "VFOUREF", &HFDF0DA
    //  apiTGridH.AddCellTip "CCFOCOD", &HFDF0DA
    //  
    //  
    //  apiTGridH.DelockColumn "CHECK"  ' automatique dans le cas d'une checkbox
    //  apiTGridH.Init rsArt
    //  
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApiapiTGridH dans " & Me.Name
    //End Sub
    //
  }
}
