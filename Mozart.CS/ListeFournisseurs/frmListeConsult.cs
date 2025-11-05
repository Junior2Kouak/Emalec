using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;


namespace MozartCS
{
  public partial class frmListeConsult : Form
  {
    //Public iAction As Long
    public int miAction;

    DataTable dt;

    public frmListeConsult() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeConsult_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        dt = new DataTable();
        if (miAction == 0)
          apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeConsultation order by NCONSULTNUM desc");
        else
          apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeConsultation where nactnum = {miAction} order by NCONSULTNUM desc");
        InitApigrid();
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
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from api_v_listeConsultation " + IIf(ZeroIfNull(iAction) = 0, "", " where nactnum = " + CStr(iAction)) + " order by NCONSULTNUM desc", cnx
    //  
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      new frmConsultationFour
      {
        miNumConsult = 0,
        mstrStatut = "C"
      }.ShowDialog();

      Cursor = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;
    }
    //Private Sub cmdAjouter_Click()
    //  
    //  Screen.MousePointer = vbHourglass
    //  frmConsultationFour.miNumConsult = 0
    //  frmConsultationFour.mstrstatut = "C"
    //  frmConsultationFour.Show vbModal
    //  
    //  adoRS.Requery
    //  apiGrid.MajLabel
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dt.Rows.Count == 0 || currentRow == null) return;

      string[,] TdbGlobal = { { "Copie", "Original" } };
      new frmBrowser().Preview_Print($"{MozartParams.CheminModeles}{ModuleMain.CodePays(currentRow["VSTFPAYS"].ToString())}TConsultationFourniture.rtf",
                                      @"TConsultationFournitureOut.rtf",
                                      TdbGlobal,
                                      $"exec api_sp_impConsultation {currentRow["NCONSULTNUM"]},{currentRow["NSTFNUM"]}",
                                      " (Impression consultation)",
                                      "PREVIEW");
    }
    //Private Sub cmdVisu_Click()
    // 
    // Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //  On Error GoTo handler
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  TdbGlobal(0, 0) = "Copie"
    //  
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  
    //  frmBrowser.InfosMail = "TINT|NSTFNUM|" & adoRS("NSTFNUM")     ' TABLE | ID    --VL 16/11/04
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & CodePays(adoRS("VSTFPAYS")) & "TConsultationFourniture.rtf", _
    //                           "\TConsultationFournitureOut.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impConsultation " & adoRS("NCONSULTNUM") & "," & adoRS("NSTFNUM"), _
    //                           " (Impression consultation)", _
    //                           "PREVIEW"
    //    
    //Exit Sub
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdEditer_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dt.Rows.Count == 0 || currentRow == null) return;

      string[,] TdbGlobal = { { "Copie", "Original" } };
      try
      {
        new frmBrowser().ImprimerFichier($"{MozartParams.CheminModeles}{ModuleMain.CodePays(currentRow["VSTFPAYS"].ToString())}TConsultationFourniture.rtf",
                                         @"TConsultationFournitureOut.rtf",
                                         TdbGlobal,
                                         $"exec api_sp_impConsultation {currentRow["NCONSULTNUM"]},{currentRow["NSTFNUM"]}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdEditer_Click()
    // 
    //  Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error GoTo handler
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  TdbGlobal(0, 0) = "Copie"
    //  
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //                         
    //                         
    //  ImprimerFichier gstrCheminModeles & CodePays(adoRS("VSTFPAYS")) & "TConsultationFourniture.rtf", _
    //                     "\TConsultationFournitureOut.rtf", _
    //                     TdbGlobal(), _
    //                    "exec api_sp_impConsultation " & adoRS("NCONSULTNUM") & "," & adoRS("NSTFNUM")
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdEditer_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dt.Rows.Count == 0 || currentRow == null) return;

      new frmConsultationFour
      {
        miNumConsult = (int)Utils.ZeroIfNull(currentRow["NCONSULTNUM"]),
        mstrStatut = "M"
      }.ShowDialog();

      Cursor = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //  
    //  If adoRS.RecordCount = 0 Then Exit Sub
    //  
    //  frmConsultationFour.miNumConsult = adoRS("NCONSULTNUM")
    //  frmConsultationFour.mstrstatut = "M"
    //  frmConsultationFour.Show vbModal
    //  
    //  adoRS.Requery
    //  apiGrid.MajLabel
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiGrid.AddColumn("N°", "NCONSULTNUM", 700);
      apiGrid.AddColumn(MZCtrlResources.date_creation, "DQUICRE", 1700, "dd/mm/yyyy");
      apiGrid.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 3000);
      apiGrid.AddColumn(Resources.col_Ville, "VSTFVIL", 3000);
      apiGrid.AddColumn(Resources.col_Demandeur, "Expr1", 2000);
      apiGrid.AddColumn(Resources.col_dateRetour, "DCONSULTDAT", 1700, "dd/mm/yyyy");
      apiGrid.AddColumn("NSTFNUM", "NSTFNUM", 0);
      apiGrid.AddColumn("VSTFPAYS", "VSTFPAYS", 0);
      apiGrid.AddColumn("Di", "DI", 1000);
      apiGrid.AddColumn("NACTNUM", "NACTNUM", 0);

      apiGrid.InitColumnList();
      apiGrid.GridControl.DataSource = dt;
    }
    //Private Sub InitApigrid()
    //  
    //  apiGrid.AddColumn "N°", "NCONSULTNUM", 700
    //  apiGrid.AddColumn "§Date création§", "DQUICRE", 1700, "dd/mm/yyyy"
    //  apiGrid.AddColumn "§Fournisseur§", "VSTFNOM", 3000
    //  apiGrid.AddColumn "§Ville§", "VSTFVIL", 3000
    //  apiGrid.AddColumn "§Demandeur§", "Expr1", 2000
    //  apiGrid.AddColumn "§Date retour§", "DCONSULTDAT", 1700, "dd/mm/yyyy"
    //  apiGrid.AddColumn "NSTFNUM", "NSTFNUM", 0
    //  apiGrid.AddColumn "VSTFPAYS", "VSTFPAYS", 0
    //  apiGrid.AddColumn "Di", "DI", 1000
    //  apiGrid.AddColumn "NACTNUM", "NACTNUM", 0
    //  
    //  apiGrid.Init adoRS
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  iAction = 0
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
  }
}

