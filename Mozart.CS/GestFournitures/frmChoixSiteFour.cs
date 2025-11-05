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
  public partial class frmChoixSiteFour : Form
  {
    public int miNumFourn;

    public frmChoixSiteFour()
    {
      InitializeComponent();
    }

    private void frmChoixSiteFour_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitGrid();

        DataTable dt = new DataTable();
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from tstf where nstfgrpnum = {miNumFourn} order by vstfnom, vstfcp, vstfvil");
        apiTGrid1.GridControl.DataSource = dt;
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


    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //  Option Explicit
    //
    //Public miNumFourn As Long
    //
    //Dim rs As ADODB.Recordset
    //
    //Private Sub cmdFermer_Click()
    //
    //    rs.Close
    //    Unload Me
    //
    //End Sub
    //

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      new frmListeContactsFour()
      {
        miNumFourn = (int)Utils.ZeroIfNull(row["NSTFNUM"])
      }.ShowDialog();
    }
    //Private Sub cmdValider_Click()
    //    
    //    frmListeContactsFour.miNumFourn = rs("NSTFNUM")
    //    frmListeContactsFour.Show vbModal
    //    
    //End Sub
    //
    //Private Sub Form_Load()
    //
    //    InitBoutons Me, frmMenu
    //
    //    Set rs = New ADODB.Recordset
    //    
    //    rs.Open "select * from tstf where nstfgrpnum = " & miNumFourn & " order by vstfnom, vstfcp, vstfvil", cnx
    //
    //    InitGrid
    //    
    //End Sub
    //

    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VSTFNOM", 2000);
      apiTGrid1.AddColumn(Resources.col_CP, "VSTFCP", 1000);
      apiTGrid1.AddColumn(Resources.col_Ville, "VSTFVIL", 2000);

      apiTGrid1.InitColumnList();
    }
    //Private Sub InitGrid()
    //
    //    apiTGrid1.AddColumn "§Nom§", "VSTFNOM", 2000
    //    apiTGrid1.AddColumn "§CP§", "VSTFCP", 1000
    //    apiTGrid1.AddColumn "§Ville§", "VSTFVIL", 2000
    //    
    //    apiTGrid1.Init rs
    //    
    //End Sub
  }
}

