using DevExpress.XtraGrid.Views.Grid;
using MozartLib;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmGestGroupeProsp : Form
  {
    private const string COL_NOM_GROUPE = "VREF_PROSPGROUPENOM";

    private MULTIEntities mMULTIEntities;

    private BindingList<TREF_PROSPGROUPE> mProspGroupe;

    public frmGestGroupeProsp()
    {
      InitializeComponent();

      mMULTIEntities = new MULTIEntities();

      mProspGroupe = new BindingList<TREF_PROSPGROUPE>(mMULTIEntities.TREF_PROSPGROUPE.OrderBy(x => x.VREF_PROSPGROUPENOM).ToList());

      apiTGrid1.dgv.InvalidRowException += (sender, e) =>
      {
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
      };
    }

    private void frmGestGroupeProsp_Load(object sender, EventArgs e)
    {
      InitApigrid();

      apiTGrid1.GridControl.DataSource = mProspGroupe;
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.nom, COL_NOM_GROUPE, 600);
      apiTGrid1.DelockColumn(COL_NOM_GROUPE);

      apiTGrid1.AddHiddenColumn("NREF_PROSPGROUPEID");

      apiTGrid1.InitColumnList();

      apiTGrid1.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      apiTGrid1.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
    }

    private void apiTGrid1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
    {
      GridView view = sender as GridView;
      if (view.FocusedColumn.FieldName != COL_NOM_GROUPE)
      {
        return;
      }

      string newValue = e.Value?.ToString();
      var currentRow = view.GetFocusedRow() as TREF_PROSPGROUPE;

      if (currentRow != null)
      {
        bool exists = mProspGroupe.Any(p => p != currentRow && p.VREF_PROSPGROUPENOM.ToUpper() == newValue.ToUpper());

        if (exists)
        {
          e.Valid = false;
          e.ErrorText = "Ce nom de groupe existe déjà !";
        }
      }
    }

    private void apiEnreg_Click(object sender, EventArgs e)
    {
      mMULTIEntities.TREF_PROSPGROUPE.AddOrUpdate(mProspGroupe.ToArray());
      mMULTIEntities.SaveChanges();
    }
  }
}
