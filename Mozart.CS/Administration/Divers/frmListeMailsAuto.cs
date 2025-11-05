using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.Administration
{
  public partial class frmListeMailsAuto : Form
  {
    DataTable dt = new DataTable();

    public frmListeMailsAuto()
    {
      InitializeComponent();
    }

    private void frmListeMailsAuto_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Pour infoDev seulement
        setButtonsState(false);

        initGrid();

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM TGESTION WHERE VGESTACTIF='OUI' AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY VCLINOM");
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

    private void initGrid()
    {
      apiTGrid1.AddColumn(Resources.col_ID, "NGESTNUM", 0);
      apiTGrid1.AddColumn("Client", "VCLINOM", 1800);
      apiTGrid1.AddColumn("Action", "VGESTLIB", 2600);
      apiTGrid1.AddColumn("Destinataire", "VGESTDEST", 2100);
      apiTGrid1.AddColumn("Périodicité", "VGESTPERIODE", 2000);
      apiTGrid1.AddColumn("Actif", "VGESTACTIF", 500);
      apiTGrid1.AddColumn("VSOCIETE", "VSOCIETE", 0);
      apiTGrid1.AddColumn("NCLINUM", "NCLINUM", 0);
      apiTGrid1.AddColumn("NTYPEMAIL", "NTYPEMAIL", 0);
    }

    private void frmListeMailsAuto_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.KeyCode == Keys.Add) && (e.Modifiers == (Keys.Control | Keys.Shift | Keys.Alt)))
      {
        setButtonsState(true);
      }
    }

    private void setButtonsState(bool bEnable)
    {
      cmdAdd.Visible = bEnable;
      cmdModifier.Visible = bEnable;
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {

    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmActionExecPlanif()
      {
        mRow = row
      }.ShowDialog();
    }
  }
}
