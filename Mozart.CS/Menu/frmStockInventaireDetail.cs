using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockInventaireDetail : Form
  {
    DataTable dt = new DataTable();
    public int miNumInv;
    //Dim adoRS As ADODB.Recordset
    //Public miNumInv As Long

    public frmStockInventaireDetail() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStockInventaireDetail_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from  api_v_DetailInventaire where NINVNUM={miNumInv} order by VFOUMAT");
        ApiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /*  --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //On Error GoTo handler
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from  api_v_DetailInventaire where NINVNUM=" & miNumInv & " order by VFOUMAT", cnx
    //
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCommande_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null) return;

      if (String.IsNullOrEmpty(row["NCOMNUM"].ToString()))
        return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TCOMMANDE,
        sIdentifiant = Strings.Mid(row["NCOMNUM"].ToString(), 3),
        InfosMail = $"TINT|NSTFNUM|{Strings.Mid(row["NCOMNUM"].ToString(), 3)}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleData.GetLangueByNSFTNUM((int)Utils.ZeroIfNull(row["NSTFNUM"])),
        sOption = "PREVIEW",
        strType = "CF",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }
    //Private Sub cmdCommande_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //    
    //    If adoRS.EOF Then Exit Sub
    //    If IsNull(adoRS!NCOMNUM) Then Exit Sub
    //    
    //'    ' trois exemplaires
    //'    TdbGlobal(0, 0) = "Copie"
    //'    TdbGlobal(0, 1) = "COPIE COMPTA"
    //'
    //'    frmBrowser.bPlanningAn = 0
    //                
    //    Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TCommande;" & Mid(adoRS!NCOMNUM, 3) & ";TINT|NSTFNUM|" & Mid(adoRS!NCOMNUM, 3) & ";" & gstrNomSociete & ";" & GetLangueByNSTFNUM(adoRS("NSTFNUM")) & ";PREVIEW;CF;" & glNumAction & """, vbNormalFocus"
    //    
    //'    frmBrowser.Preview_Print gstrCheminModeles & CodePays(adoRS("VSTFPAYS")) & "TCommandeFourniture.rtf", _
    //'                             "\" & Mid(adoRS!NCOMNUM, 3) & "_TCommandeFournitureOut.rtf", _
    //'                           TdbGlobal(), _
    //'                           "exec api_sp_impCommande " & Mid(adoRS!NCOMNUM, 3), _
    //'                           " (Prévisualisation commande)", _
    //'                           "PREVIEW"
    //  
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
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      ApiGrid.AddColumn(Resources.col_Articles, "VFOUMAT", 3500);
      ApiGrid.AddColumn(Resources.col_Qte_Voulue_Site, "NQTESTOK", 1500, "", 2);
      ApiGrid.AddColumn(Resources.col_Qte_Restant_Site, "NQTE", 1500, "", 0);
      ApiGrid.AddColumn(Resources.col_Qte_cmde, "NLCOQTE", 1200, "", 2);
      ApiGrid.AddColumn(Resources.col_Num_Cmd, "NCOMNUM", 1200);
      ApiGrid.AddColumn(Resources.col_NumCmd, "NINVNUM", 0);

      ApiGrid.InitColumnList();
    }
    //Public Sub InitApigrid()
    //  
    //  
    //On Error GoTo handler
    //
    //  ApiGrid.AddColumn "§Articles§", "VFOUMAT", 3500
    //  ApiGrid.AddColumn "§Qté voulue sur site§", "NQTESTOK", 1500, , 2
    //  ApiGrid.AddColumn "§Qté restant sur site§", "NQTE", 1500, , 2
    //  ApiGrid.AddColumn "§Qté cmdé§", "NLCOQTE", 1000, , 2
    //  ApiGrid.AddColumn "§N° Cmd§", "NCOMNUM", 1200
    //  ApiGrid.AddColumn "§NumCmd§", "NINVNUM", 0
    //  
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    //

  }
}

