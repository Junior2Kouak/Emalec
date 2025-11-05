using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPrixClientContratPays_ListePays : Form
  {
    private int mCliNum;

    public List<api_sp_PrixClientContrat_ListePays_Result> DtPays { get; set; }

    public frmPrixClientContratPays_ListePays(int pCliNum)
    {
      InitializeComponent();

      mCliNum = pCliNum;

      DtPays = new List<api_sp_PrixClientContrat_ListePays_Result>();
    }

    private void frmPrixClientContratPays_ListePays_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        LoadData();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void LoadData()
    {
      if (DtPays.Count() == 0)
      {
        using(MULTIEntities lMULTIEntities = new MULTIEntities())
        {
          DtPays = lMULTIEntities.api_sp_PrixClientContrat_ListePays(mCliNum).ToList();
        }
      }

      GCPays.DataSource = DtPays;
    }

    private void GVPays_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
    {
      Rectangle oPos = e.Bounds;
      oPos.Location = new Point(oPos.Left + 1, oPos.Top + 4);
      oPos.Size -= new Size(2, 2);

      StringFormat oFormat = new StringFormat
      {
        Alignment = StringAlignment.Center
      };

      int lNbPaysSelected = DtPays.Where(x => x.BPAYSSELECT == 1).Count();

      e.Appearance.DrawString(e.Cache, $"Nombre de pays sélectionné(s) : {lNbPaysSelected} / {DtPays.Count()}", oPos, oFormat);
      e.Handled = true;
    }

    private void RepositoryItemCheckEditCHECK_CheckedChanged(object sender, EventArgs e)
    {
      GVPays.PostEditor();
      GVPays.RefreshData();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
