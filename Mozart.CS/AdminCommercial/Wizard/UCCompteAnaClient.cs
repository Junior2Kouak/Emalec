using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MozartLib;
using MozartLib.Entites.COMMUN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  partial class UCCompteAnaClient : UCWizardBase
  {
    public List<TCAN> TCANs { get; set; }

    private class CCompteAna
    {
      public int NCANNUM { get; set; }
      public string VCANLIB { get; set; }
    }

    public UCCompteAnaClient() : this(null, null, null)
    {
    }

    public UCCompteAnaClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();

      TCANs = new List<TCAN>();

      GCCPTANA.DataSource = TCANs;
    }

    public override bool VerifSaisieChamp()
    {
      if (TCANs.Where(x => (x.NCANNUM == 0) || (x.NPERNUM == 0)).Count() != 0)
      {
        MessageBox.Show("Il faut sélectionner au moins une personne et un compte.", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        return false;
      }

      // Remplissage des comptes analytiques : Rien à faire, la liste est updatée au fur et à mesure

      return true;
    }

    private void LoadDataCbo()
    {
      RepCboChaff.DataSource = mMULTIEntities.TPER.Where(x => (x.CPERTYP == TREF_TYPEPER.STR_CA) && (x.CPERACTIF == "O") && (x.VSOCIETE == mTCLIEnreg.VSOCIETE))
                                                  .OrderBy(x => x.VPERNOM).ToList();

      RepCboNCANNUM.DataSource = mMULTIEntities.TREF_CTEANA.Where(x => (x.VSOCIETE == mTCLIEnreg.VSOCIETE) && (x.CCTEANAACTIF == "O"))
                                          .Select(x => new CCompteAna { NCANNUM = x.NCANNUM, VCANLIB = x.NCANNUM.ToString() + " - " + x.VCANLIB }).ToList();

      //RepositoryItemGV_ASS.DataSource = mMULTIEntities.api_sp_ListePersonnelAssistant().ToList();
      RepositoryItemGV_ASS.DataSource = mMULTIEntities.TPER
                                          .Where(x => (new string[] { TREF_TYPEPER.STR_AA, TREF_TYPEPER.STR_AS }.Contains(x.CPERTYP)) &&
                                                (x.VSOCIETE == mTCLIEnreg.VSOCIETE) && (x.DPERSOR == null || x.DPERSOR > DateTime.Now))
                                          .Select(x => new
                                          {
                                            NPERNUMASS = x.NPERNUM,
                                            VPERNOMASS = x.VPERNOM + " " + x.VPERPRE
                                          })
                                          .OrderBy(x => x.VPERNOMASS).ToList();

      //RepositoryItemGV_FACTU.DataSource = mMULTIEntities.api_sp_ListePersonnelFactu().ToList();
      RepositoryItemGV_FACTU.DataSource = mMULTIEntities.TPER
                                          .Where(x => (new string[] { TREF_TYPEPER.STR_FA }.Contains(x.CPERTYP)) && (x.CPERACTIF == "O") &&
                                                (x.VSOCIETE == mTCLIEnreg.VSOCIETE) && (x.DPERSOR == null || x.DPERSOR > DateTime.Now))
                                          .Select(x => new
                                          {
                                            NPERNUMFAC = x.NPERNUM,
                                            VPERNOMFAC = x.VPERNOM + " " + x.VPERPRE
                                          })
                                          .OrderBy(x => x.VPERNOMFAC).ToList();

      //RepositoryItemGV_ASSCHAFF.DataSource = mMULTIEntities.api_sp_ListePersonnelAssistantChaff().ToList();
      RepositoryItemGV_ASSCHAFF.DataSource = mMULTIEntities.TPER
                                          .Where(x => (new string[] { TREF_TYPEPER.STR_AA, TREF_TYPEPER.STR_AS, TREF_TYPEPER.STR_BE, TREF_TYPEPER.STR_CT }.Contains(x.CPERTYP)) &&
                                                (x.VSOCIETE == mTCLIEnreg.VSOCIETE) && (x.DPERSOR == null || x.DPERSOR > DateTime.Now))
                                          .Select(x => new
                                          {
                                            NPERNUMASSCHAFF = x.NPERNUM,
                                            VPERNOMASSCHAFF = x.VPERNOM + " " + x.VPERPRE
                                          })
                                          .OrderBy(x => x.VPERNOMASSCHAFF).ToList();
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
      LoadDataCbo();

      if (TCANs.Where(x => x.NCANNUM == 0).Count() == 0)
      {
        TCAN lCan = new TCAN
        {
          NPERNUM = 0,
          NCANNUM = 0,
          NPERNUMASS = 0,
          NPERNUMFAC = 0,
          NPERNUMASSCHAFF = 0,
          TCLI = mTCLIEnreg
        };

        TCANs.Add(lCan);
        GCCPTANA.RefreshDataSource();
      }
    }

    private void GVCPTANA_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
    }

    private void BtnDel_Click(object sender, EventArgs e)
    {
      if (TCANs.Count > 0)
      {
        TCAN lCan = (TCAN) GVCPTANA.GetRow(GVCPTANA.FocusedRowHandle);
        TCANs.Remove(lCan);
        GCCPTANA.RefreshDataSource();
      }
    }

    private void GVCPTANA_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      TCAN lSelected = (TCAN)GVCPTANA.GetRow(e.RowHandle);
      if ((lSelected.NCANNUM == 0) || (lSelected.NPERNUM == 0))
      {
        MessageBox.Show("Il faut sélectionner un compte analytique et un chargé d'affaires !", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        e.Valid = false;
        return;
      }

      if (TCANs.Where(x => x.NCANNUM == lSelected.NCANNUM).Count() > 1)
      {
        MessageBox.Show($"Le compte analytique N° {lSelected.NCANNUM} est déjà affecté à ce client !", MZCtrlResources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);

        e.Valid = false;

        lSelected.NCANNUM = 0;
        lSelected.NPERNUM = 0;
        lSelected.NPERNUMASS = 0;
        lSelected.NPERNUMFAC = 0;
        lSelected.NPERNUMASSCHAFF = 0;

        return;
      }

      lSelected.TPER = mMULTIEntities.TPER.Find(lSelected.NPERNUM);
    }

    private void GVCBOCHAFF_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      TCAN lFocusedCanCPTAna = (TCAN)GVCPTANA.GetRow(GVCPTANA.FocusedRowHandle);
      if (lFocusedCanCPTAna == null) return;

      updateGrid(lFocusedCanCPTAna);
    }

    private void GVCBOCPTANA_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      GridView view = (GridView)sender;

      CCompteAna lFocusedCpteAna = (CCompteAna)view.GetRow(e.RowHandle);
      if (lFocusedCpteAna == null) return;

      TCAN lFocusedCPTAnaSelected = (TCAN)GVCPTANA.GetRow(GVCPTANA.FocusedRowHandle);
      if (lFocusedCPTAnaSelected == null) return;

      if (lFocusedCpteAna.NCANNUM == lFocusedCPTAnaSelected.NCANNUM) return;

      lFocusedCPTAnaSelected.NCANNUM = lFocusedCpteAna.NCANNUM;

      updateGrid(lFocusedCPTAnaSelected);
    }

    private void updateGrid(TCAN pTCANConcerne)
    {
      pTCANConcerne.NPERNUM = mMULTIEntities.TCAN.Where(x => x.NCANNUM == pTCANConcerne.NCANNUM && x.CCANACTIF == "O" && x.TPER.CPERACTIF == "O"
                                                        && x.TPER.VSOCIETE == mTCLIEnreg.VSOCIETE)
                                    .Select(x => x.NPERNUM).Distinct().FirstOrDefault();
      // Remplace : lFocusedCPTAnaSelected.NPERNUMASS = mMULTIEntities.api_sp_GetASSDefaultByCAN(lFocusedCPTAnaSelected.NPERNUM, mTCLIEnreg.VSOCIETE);
      pTCANConcerne.NPERNUMASS = (int)mMULTIEntities.TCAN.Where(x => x.NCANNUM == pTCANConcerne.NCANNUM && x.CCANACTIF == "O"
                                                                && x.TCLI.VSOCIETE == mTCLIEnreg.VSOCIETE
                                                                && x.NPERNUM == pTCANConcerne.NPERNUM && x.TPER_ASS.CPERACTIF == "O")
                                    .FirstOrDefault().NPERNUMASS;

      // Remplace : lFocusedCPTAnaSelected.NPERNUMFAC = mMULTIEntities.api_sp_GetFactuDefaultByCAN(lFocusedCPTAnaSelected.NPERNUM, mTCLIEnreg.VSOCIETE);
      pTCANConcerne.NPERNUMFAC = (int)mMULTIEntities.TCAN.Where(x => x.NCANNUM == pTCANConcerne.NCANNUM && x.CCANACTIF == "O"
                                                                && x.TCLI.VSOCIETE == mTCLIEnreg.VSOCIETE
                                                                && x.NPERNUM == pTCANConcerne.NPERNUM && x.TPER_FAC.CPERACTIF == "O")
                                    .FirstOrDefault().NPERNUMFAC;

      // Remplace : lFocusedCPTAnaSelected.NPERNUMASSCHAFF = mMULTIEntities.api_sp_GetASSCHAFFDefaultByCAN(lFocusedCPTAnaSelected.NPERNUM, mTCLIEnreg.VSOCIETE);
      pTCANConcerne.NPERNUMASSCHAFF = (int)mMULTIEntities.TCAN.Where(x => x.NCANNUM == pTCANConcerne.NCANNUM && x.CCANACTIF == "O"
                                                                     && x.TCLI.VSOCIETE == mTCLIEnreg.VSOCIETE
                                                                     && x.NPERNUM == pTCANConcerne.NPERNUM && x.TPER_ASSCHAFF.CPERACTIF == "O")
                                    .FirstOrDefault().NPERNUMASSCHAFF;

      GVCPTANA.RefreshData();
    }

    private void GVCPTANA_ShownEditor(object sender, EventArgs e)
    {
      GridView view = (GridView)sender;
      if (view.FocusedColumn.FieldName != "NPERNUM") return;
      if (!(view.ActiveEditor is GridLookUpEdit)) return;

      TCAN lCan = (TCAN) view.GetRow(view.FocusedRowHandle);
      ((GridLookUpEdit) view.ActiveEditor).Properties.DataSource = mMULTIEntities.api_sp_CboListChaffFreeByCptAna(lCan.NCANNUM);
    }
  }
}
