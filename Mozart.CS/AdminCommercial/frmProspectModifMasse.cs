using MozartNet;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmProspectModifMasse : Form
  {
    private BindingList<CProspListe_Dto_WithCheckBox> mProspects;
    private BindingList<CProspListe_Dto_WithCheckBox> mProspectsSelected;

    public frmProspectModifMasse() : this(null)
    {
    }

    public frmProspectModifMasse(BindingList<CProspListe_Dto> pProspects)
    {
      InitializeComponent();

      mProspects = new BindingList<CProspListe_Dto_WithCheckBox>(pProspects.GroupBy(x => x.NPROSNUM).Select(p => new CProspListe_Dto_WithCheckBox(p.First())
      {
        IsSelected = false
      }).ToList());
      mProspectsSelected = new BindingList<CProspListe_Dto_WithCheckBox>();
    }

    private void frmModifMasse_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridAll.GridControl.DataSource = mProspects;
        apiTGridAll.EnableCheckboxSelection();

        apiTGridSelected.GridControl.DataSource = mProspectsSelected;
        apiTGridSelected.EnableCheckboxSelection();
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

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (mProspectsSelected.Count == 0)
      {
        MessageBox.Show("Vous devez sélectionner des prospects pour modifer en masse.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        return;
      }

      new frmProspModifierEnMasse(mProspectsSelected).ShowDialog();
    }

    private void cmdUp_Click(object sender, EventArgs e)
    {
      moveFromTo(mProspectsSelected, mProspects);
    }

    private void moveFromTo(BindingList<CProspListe_Dto_WithCheckBox> pSrc, BindingList<CProspListe_Dto_WithCheckBox> pDest)
    {
      // Récupérer tous les éléments cochés
      var selectedItems = pSrc.Where(p => p.IsSelected).ToList();
      if (selectedItems.Count == 0) return;

      // Ajouter à la liste des sélectionnés
      foreach (var item in selectedItems)
      {
        item.IsSelected = false;
        pDest.Add(item);
        pSrc.Remove(item);
      }
    }

    private void cmdDown_Click(object sender, EventArgs e)
    {
      moveFromTo(mProspects, mProspectsSelected);
    }
  }
}
