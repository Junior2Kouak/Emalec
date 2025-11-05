using DevExpress.XtraEditors.Controls;
using MozartControls.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmExtInvSelectCliSite : Form
  {
    public frmExtInvSelectCliSite()
    {
      InitializeComponent();
    }

    private void frmExtInvSelectCliSite_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        LookUpEditCli.Properties.DataSource = MozartDatabase.GetDataTable("api_sp_ExtListeCli");
        LookUpEditCli.Properties.DisplayMember = "VCLINOM";
        LookUpEditCli.Properties.ValueMember = "NCLINUM";

        LookUpEditCli.Properties.Columns.Clear();
        LookUpEditCli.Properties.Columns.Add(new LookUpColumnInfo("NCLINUM", "", 0, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default));
        LookUpEditCli.Properties.Columns.Add(new LookUpColumnInfo("VCLINOM"));

        rdoTousSites.Checked = true;
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

    private void BtnInvModif_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        DataRowView oDataRowCliSelected = (DataRowView)LookUpEditCli.GetSelectedDataRow();
        if (oDataRowCliSelected == null)
        {
          return;
        }

        if (rdoTousSites.Checked)
        {
          // on recherche un id de l'inventaire pour un des sites
          int iIdInventaire = MozartDatabase.ExecuteScalarInt($"api_sp_ExtInvReturnID {oDataRowCliSelected["NCLINUM"]}, 0");
          if (iIdInventaire == 0)
          {
            MessageBox.Show("Pas d'inventaire pour ce client !!", Resources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          else
          {
            new frmExtGestInv((int) oDataRowCliSelected["NCLINUM"], oDataRowCliSelected["VCLINOM"].ToString()).ShowDialog();
          }
        }
        else
        {
          DataRowView oDataRowSiteSelected = (DataRowView)LookUpEditSite.GetSelectedDataRow();
          if (oDataRowSiteSelected == null)
          {
            return;
          }

          // on recherche le id de l'inventaire
          int iIdInventaire = MozartDatabase.ExecuteScalarInt($"api_sp_ExtInvReturnID {oDataRowCliSelected["NCLINUM"]}, {oDataRowSiteSelected["NSITNUM"]}");
          if (iIdInventaire == 0)
          {
            MessageBox.Show("Pas d'inventaire sur ce site !!", Resources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          else
          {
            new frmExtGestInv(iIdInventaire, oDataRowCliSelected["VCLINOM"].ToString(), oDataRowSiteSelected["VSITNOM"].ToString()).ShowDialog();
          }
        }
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

    private void LookUpEditCli_EditValueChanged(object sender, EventArgs e)
    {
      try
      {
        if (LookUpEditCli.Properties.DataSource == null)
        {
          return;
        }

        Cursor.Current = Cursors.WaitCursor;
        
        LookUpEditSite.Properties.DataSource = MozartDatabase.GetDataTable($"api_sp_ExtListeSit {(int)LookUpEditCli.GetColumnValue("NCLINUM")}");
        LookUpEditSite.Properties.DisplayMember = "VSITNOM";
        LookUpEditSite.Properties.ValueMember = "NSITNUM";

        LookUpEditSite.Properties.Columns.Clear();
        LookUpEditSite.Properties.Columns.Add(new LookUpColumnInfo("NSITNUM", "", 0, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default));
        LookUpEditSite.Properties.Columns.Add(new LookUpColumnInfo("VSITNOM"));
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

    private void rdoSites_chechedChanged(object sender, EventArgs e)
    {
      LookUpEditSite.Visible = !rdoTousSites.Checked;
    }
  }
}
