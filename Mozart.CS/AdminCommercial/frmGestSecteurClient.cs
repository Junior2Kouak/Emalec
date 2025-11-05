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
  public partial class frmGestSecteurClient : Form
  {
    private const string COL_NOM_SOUSACTIVITE = "VSOUSACTIVITE";
    private const string COL_NOM_CODEAPE = "VCODEAPE";

    private COMMUNEntities mCOMMUNEntities;

    private BindingList<TREF_SECTEUR> mProspSecteurs;

    public frmGestSecteurClient()
    {
      InitializeComponent();

      mCOMMUNEntities = new COMMUNEntities();

      mProspSecteurs = new BindingList<TREF_SECTEUR>(mCOMMUNEntities.TREF_SECTEUR.OrderBy(x => x.VSOUSACTIVITE).ToList());

      apiTGrid1.dgv.InvalidRowException += (sender, e) =>
      {
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
      };
    }

    private void frmGestSecteurClient_Load(object sender, EventArgs e)
    {
      InitApigrid();

      apiTGrid1.GridControl.DataSource = mProspSecteurs;
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.nom, COL_NOM_SOUSACTIVITE, 1500);
      apiTGrid1.DelockColumn(COL_NOM_SOUSACTIVITE);
      apiTGrid1.AddColumn(MZCtrlResources.codeAPE, COL_NOM_CODEAPE, 600);
      apiTGrid1.DelockColumn(COL_NOM_CODEAPE);

      apiTGrid1.AddHiddenColumn("NSECTEUR");

      apiTGrid1.InitColumnList();

      apiTGrid1.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      apiTGrid1.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
    }

    private void apiTGrid1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
    {
      GridView view = sender as GridView;
      if (view.FocusedColumn.FieldName != COL_NOM_SOUSACTIVITE)
      {
        return;
      }

      string newValue = e.Value?.ToString();
      TREF_SECTEUR currentRow = view.GetFocusedRow() as TREF_SECTEUR;

      if (currentRow != null)
      {
        bool exists = mProspSecteurs.Any(p => p != currentRow && p.VSOUSACTIVITE.ToUpper() == newValue.ToUpper());

        if (exists)
        {
          e.Valid = false;
          e.ErrorText = "Ce secteur client existe déjà !";
        }
      }
    }

    private void apiEnreg_Click(object sender, EventArgs e)
    {
      mCOMMUNEntities.TREF_SECTEUR.AddOrUpdate(mProspSecteurs.ToArray());
      mCOMMUNEntities.SaveChanges();
    }

    private void apiTGrid1_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      GridView view = sender as GridView;
      TREF_SECTEUR secteur = view.GetRow(e.RowHandle) as TREF_SECTEUR;
      if (secteur != null)
      {
        secteur.LANGUE = "FR";
        secteur.VSECTEUR = "";
      }
    }
  }
}
