using MozartCS.Properties;
using MozartLib;
using MozartLib.Entites.COMMUN;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmProspModifierEnMasse : Form
  {
    private List<TPER> mListeCommercial;

    private List<int> mListeProsNum;

    public frmProspModifierEnMasse() : this(null)
    {
    }

    public frmProspModifierEnMasse(BindingList<CProspListe_Dto_WithCheckBox> mProspectsSelected)
    {
      InitializeComponent();

      if (mProspectsSelected == null)
      {
        mListeProsNum = new List<int>();
      }
      else
      {
        mListeProsNum = mProspectsSelected.Select(x => x.NPROSNUM).ToList();
      }
    }
    
    private void frmProspModifierEnMasse_Load(object sender, EventArgs e)
    {
      string lTmpStr;

      MULTIEntities mMULTIEntities = new MULTIEntities();
      COMMUNEntities mCOMMUNEntities = new COMMUNEntities();

      // Commercial de suivi
      mListeCommercial = mMULTIEntities.TPER.Where(x => (x.CPERTYP != TREF_TYPEPER.STR_TE) && (x.CPERACTIF == CEntiteConstants.STR_CHAMP_O) && (x.VSOCIETE == MozartParams.NomSociete))
                                            .OrderBy(x => x.VPERNOM).ToList();
      mListeCommercial.Insert(0, new TPER()
      {
        NPERNUM = 0,
        VPERNOM = ""
      });
      cboComSuivi.DataSource = mListeCommercial;
      cboComSuivi.ValueMember = "NPERNUM";
      cboComSuivi.DisplayMember = "VPERNOM";

      // Priorité
      lTmpStr = $"select NPROSPNUM, VPROSPNOM from TREF_PROSP_URGE INNER JOIN TPAYS ON TPAYS.NPAYSNUM=TREF_PROSP_URGE.NPAYSNUM where VLANGUEABR = '{MozartParams.Langue}' order by NPROSPNUM";
      ModuleData.RemplirCombo(cboUrgence, lTmpStr);
      cboUrgence.ValueMember = "NPROSPNUM";
      cboUrgence.DisplayMember = "VPROSPNOM";
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      MULTIEntities mMULTIEntities = new MULTIEntities();

      // Récupération des prospects
      List<TPROSP> lListeProsp =  mMULTIEntities.TPROSP.Where(x => mListeProsNum.Contains(x.NPROSNUM)).ToList();

      // Priorité : Mise à jour si une urgence est sélectionnée
      if (cboUrgence.SelectedIndex != 0)
      {
        lListeProsp.ForEach(x => x.NPROSURGENCE = (int)cboUrgence.SelectedValue);
      }

      // Commercial de suivi
      if (cboComSuivi.Text != "")
      {
        // Liste des suivis associés aux TPROSP sélectionnés
        List<int> listeNumProspects = lListeProsp.Select(p => p.NPROSNUM).ToList();
        List<TPROSPSUIV> lListeProspSuivi = mMULTIEntities.TPROSPSUIV.Where(x => listeNumProspects.Contains(x.NPROSNUM)).ToList();

        int lNPerNumNewComSuivi = ((TPER)cboComSuivi.SelectedItem).NPERNUM;
        TPER lNewComSuivi = mMULTIEntities.TPER.Find(lNPerNumNewComSuivi);

        // Création d'un dictionnaire pour les derniers DOMCOM par prospect
        Dictionary<int, int> dernierSuiviParProspect = lListeProspSuivi.GroupBy(s => s.NPROSNUM).ToDictionary(
                          g => g.Key,
                          g => g.OrderByDescending(s => s.DSUIVDATE)
                      .Select(s => s.NDOMCOMID)
                      .FirstOrDefault());

        Dictionary<int, DateTime?> dernierDateRapParProspect = lListeProspSuivi.GroupBy(s => s.NPROSNUM).ToDictionary(
                  g => g.Key,
                  g => g.OrderByDescending(s => s.DSUIVDATE)
              .Select(s => s.DSUIVDATERAP)
              .FirstOrDefault());

        // MàJ du commercial de suivi sur les prospects
        lListeProsp.ForEach(x => x.NPROSCOMSUIVINUM = lNPerNumNewComSuivi);

        // Création d'un nouveau suivi pour chaque prospect
        List<TPROSPSUIV> lListeNewSuivi = lListeProsp.Select(x => new TPROSPSUIV
        {
          DSUIVDATE = DateTime.Now,
          NPROSNUM = x.NPROSNUM,
          DSUIVDATERAP = dernierDateRapParProspect.TryGetValue(x.NPROSNUM, out var dsuivrap) ? dsuivrap : DateTime.Now.AddDays(1),
          VSUIVACTION = $"{Resources.txt_ActTransfCommVers} {lNewComSuivi.getNomPrenom()}",
          NDOMCOMID = dernierSuiviParProspect.TryGetValue(x.NPROSNUM, out var domcomId) ? domcomId : 0,
          VSUIVQUI = lNewComSuivi.VPERADSI
        }).ToList();

        // Ajout dans la base
        mMULTIEntities.TPROSPSUIV.AddRange(lListeNewSuivi);
      }

      mMULTIEntities.SaveChanges();
    }
  }
}
