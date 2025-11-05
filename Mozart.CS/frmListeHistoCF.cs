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

  public partial class frmListeHistoCF : Form
  {
    public int miNumFour;

    DataTable dt = new DataTable();

    public frmListeHistoCF()
    {
      InitializeComponent();
      ModuleMain.Initboutons(this);
    }

    //Private Sub Form_Load()
    //  On Error GoTo Handler:
    //  InitBoutons Me, frmMenu
    //  Set rs = New ADODB.Recordset
    //  rs.Open "exec [api_sp_ListeHistoCF] " & frmDetailsFourniture.miNumFour & ",'" & gstrNomSociete & "'", cnx
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    private void frmListeHistoCF_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Cursor.Current = Cursors.WaitCursor;
        // TESTS ONLY
        // ModuleData.LoadData(dt, MozartDatabase.cnxMozart, "select top 10 NCOMNUM, convert(varchar(10),DCOMDAT,103) AS DCOMDAT, 10 NLCOPU, 11 NLCOQTE, 'toto' VPERNOM, 'TOTO' VSTFNOM from TCOM");
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec [api_sp_ListeHistoCF] " + miNumFour.ToString() + ", '" + MozartParams.NomSociete + "'");
        apiTGrid1.GridControl.DataSource = dt;
        InitApiGrid();
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

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    //VB6
    //Private Sub InitApigrid()
    //  apiTGrid1.AddColumn "N° CF", "NCOMNUM", 1800
    //  apiTGrid1.AddColumn "Date", "DCOMDAT", 2000, , 2
    //  apiTGrid1.AddColumn "€ unitaire", "NLCOPU", 1400, "Currency", 2
    //  apiTGrid1.AddColumn "Qté cdé", "NLCOQTE", 1400, , 1
    //  apiTGrid1.AddColumn "Créateur", "VPERNOM", 1400, , 2
    //  apiTGrid1.AddColumn "Fournisseur", "VSTFNOM", 1400, , 2

    //  apiTGrid1.Init rs
    //End Sub

    private void InitApiGrid()
    {
      apiTGrid1.AddColumn(Resources.col_NumCF, "NCOMNUM", 400);
      apiTGrid1.AddColumn(Resources.col_Date, "DCOMDAT", 900, "", 2);
      apiTGrid1.AddColumn(Resources.col_EuroUnit, "NLCOPU", 400, "Currency", 2);
      apiTGrid1.AddColumn(Resources.col_QteCde, "NLCOQTE", 400, "", 1);
      apiTGrid1.AddColumn(Resources.col_Creator, "VPERNOM", 1800, "", 2);
      apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 2400, "", 2);

      apiTGrid1.InitColumnList();
    }
  }
}
