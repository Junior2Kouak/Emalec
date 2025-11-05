using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatDepNonReso : Form
  {
    DataTable dt = new DataTable();
    //Dim ado_rs As ADODB.Recordset

    public frmStatDepNonReso()
    {
      InitializeComponent();
    }

    private void frmStatDepNonReso_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        lblinfo.Text = "DI dont la première action est un dépannage et ou il y a au moins 3 actions. \r\n\r\n";
        lblinfo.Text += "DI non terminée (il reste une action non exécutée ou non archivée).  \r\n\r\n";

        InitFeuille();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  Screen.MousePointer = vbHourglass
    //  
    //  On Error GoTo handler:
    //  
    //  InitBoutons Me, frmMenu
    //         
    //  lblinfo.Caption = lblinfo.Caption & "DI dont la première action est un dépannage et ou il y a au moins 3 actions." & vbCrLf
    //  lblinfo.Caption = lblinfo.Caption & "DI non terminée (il reste une action non exécutée ou non archivée)." & vbCrLf
    //
    //  InitFeuille
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {

      if (dt.Rows.Count == 0) return;

      DataRow currentRow = apiTGrid.GetFocusedDataRow();

      // écran de modification de la demande
      frmAddAction f = new frmAddAction();
      f.mstrStatutDI = "M";

      MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);
      f.ShowDialog();

      Cursor = Cursors.WaitCursor;

      // on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //  If ado_rs.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = val(ado_rs("NDINNUM").value)
    //  glNumAction = val(ado_rs("NACTNUM").value)
    //  frmAddAction.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //    
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //  
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void InitFeuille()
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatDepannageNonResolu ");
        apiTGrid.GridControl.DataSource = dt;

        InitTGrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitFeuille()
    //
    //On Error GoTo handler:
    //
    //    Screen.MousePointer = vbHourglass
    //    
    //    Set ado_rs = New ADODB.Recordset
    //    
    //    ado_rs.Open "exec api_sp_StatDepannageNonResolu ", cnx
    //
    //    InitTGrid
    //  
    //    Screen.MousePointer = vbDefault
    //    
    //Exit Sub
    //Resume
    //handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "InitFeuille dans " & Me.Name
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void InitTGrid()
    {

      apiTGrid.AddColumn("N°DI", "ndinnum", 1200, "", 2);
      apiTGrid.AddColumn("Client", "Client", 4000);
      apiTGrid.AddColumn("Site", "site", 3500);
      apiTGrid.AddColumn("Date dépannage", "datedem", 2000, "dd/mm/yyyy", 2);
      apiTGrid.AddColumn("Nb action", "NBACT", 900, "", 2);
      apiTGrid.AddColumn("Chaff", "Chaff", 2500);
      apiTGrid.AddColumn("nactnum", "nactnum", 0);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitTGrid()
    //  
    //  apiTGrid.AddColumn "N°DI", "NDINNUM", 1200, , 2
    //  apiTGrid.AddColumn "Client", "CLIENT", 4000
    //  apiTGrid.AddColumn "Site", "SITE", 3500
    //  apiTGrid.AddColumn "Date dépannage", "DATEDEM", 2000, "dd/mm/yyyy", 2
    //  apiTGrid.AddColumn "Nb action", "NBACT", 900, , 2
    //  apiTGrid.AddColumn "Chaff", "CHAFF", 2500
    //  apiTGrid.AddColumn "nactnum", "NACTNUM", 0
    //  
    //  apiTGrid.Init ado_rs
    //
    //End Sub
    //
  }
}