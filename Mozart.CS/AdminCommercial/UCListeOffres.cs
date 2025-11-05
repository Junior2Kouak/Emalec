using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class UCListeOffres : UserControl
  {
    public GridControl GridControl => apiTGridOffre.GridControl;
    public GridView GridView => apiTGridOffre.dgv;

    // Permet de déterminer si la grille affiche les offres de plusieurs prospects ou pas
    public bool MultiProspects { get; set; }

    // Filtrage sur les offres
    public const int OFFRE_ALL = 0;
    public const int OFFRE_ACTIVE = 1;
    public const int OFFRE_ARCHIVEE = 2;
    public int TypeFiltreOffre { get; set; }

    public UCListeOffres()
    {
      InitializeComponent();

      MultiProspects = false;
      TypeFiltreOffre = OFFRE_ALL;
    }

    private void UCListeOffres_Load(object sender, EventArgs e)
    {
      if (DesignMode) return;
    }

    public void initColumnsGrid(bool bForMultiProspects)
    {
      try
      {
        MultiProspects = bForMultiProspects;

        int lTmp;

        apiTGridOffre.dgv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
        apiTGridOffre.dgv.ColumnPanelRowHeight = 40;
        apiTGridOffre.dgv.OptionsView.ColumnAutoWidth = false;

        lTmp = apiTGridOffre.AddBand("");
        if (MultiProspects)
        {
          apiTGridOffre.AddColumn(lTmp, MZCtrlResources.nom, "VPROSNOM", 1100, "", MozartUCConstants.GRID_COL_ALIGN_LEFT);
        }
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.date_creation, "DOFFREDATECRE", 500, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.commercial_suivi, "VPERNUMCRE", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.filiale_concernee, "VSOCIETE", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.orig_de_contact, "VOFFREORICONTACT", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.col_libelle, "VOFFRETEXT", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.type_offre, "VOFFRETYPEOFFRE", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.defensif, "VOFFREDEFENSIF", 800, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.DAS_Emalec, "VOFFREDASEMALEC", 1500, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.perimetre_pays, "VOFFREPERIMETREPAYS", 1000, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.date_reponse, "DOFFREREPONSE", 700, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_CENTER);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.date_demarrage_contrat, "DOFFREDEMARRRAGECONTRAT", 900, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_CENTER);

        lTmp = apiTGridOffre.AddBand(Resources.col_CA); // "Chiffre d'affaires"
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.forfaitaire_preventif, "NOFFRECAFORFAITPREV", 800, "N2", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.estimatif_global, "NOFFRECAESTIMATIFGLOBAL", 800, "N2", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.defensif, "NOFFRECADEFENSIF", 800, "N2", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddCalculatedColumn(lTmp, MZCtrlResources.developpement, $"NOFFRECADEVELOPPEMENT_CALC", $"ToDecimal([NOFFRECAESTIMATIFGLOBAL]) - ToDecimal([NOFFRECADEFENSIF])",
                                  UnboundColumnType.Decimal, 800, "N2");

        lTmp = apiTGridOffre.AddBand("");
        apiTGridOffre.AddColumn(lTmp, Resources.col_Statut, "VOFFRESTATUT", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.pourc_chance_gain, "VOFFRECHANCEGAIN", 900, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
        apiTGridOffre.AddColumn(lTmp, MZCtrlResources.Commentaires, "VOFFRECOMMENTAIRE", 1100, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);

        apiTGridOffre.AddColumn(lTmp, "NOFFREID", "NOFFREID", 0);
        apiTGridOffre.AddColumn(lTmp, "NPROSNUM", "NPROSNUM", 0);

        apiTGridOffre.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private List<TPROSPOFFRE> getOffreDependOnFilter(MULTIEntities pMULTIEntities)
    {
      List<TPROSPOFFRE> lResult;

      switch (TypeFiltreOffre)
      {
        case OFFRE_ACTIVE:
          lResult = pMULTIEntities.TPROSPOFFRE.Where(x => x.COFFREARCHIVEE == CEntiteConstants.STR_CHAMP_N).ToList();
          break;

        case OFFRE_ARCHIVEE:
          lResult = pMULTIEntities.TPROSPOFFRE.Where(x => x.COFFREARCHIVEE == CEntiteConstants.STR_CHAMP_O).ToList();
          break;

        // Default ou OFFRE_ALL
        default:
          lResult = pMULTIEntities.TPROSPOFFRE.ToList();
          break;
      }

      // Filtrage des offres selon le commercial de suivi si c'est la visu de toutes les offres
      if (MultiProspects)
      {
        lResult = MozartParams.UserConnecte.getOffresFiltrees(lResult);
      }

      return lResult;
    }

    public void fillGrid(int miNumProspect)
    {
      MULTIEntities lMULTIEntities = new MULTIEntities();
      COMMUNEntities lCOMMUNEntities = new COMMUNEntities();

      // Charger les données nécessaires
      Dictionary<int, string> dictProspect;

      List<TPROSPOFFRE> listeOffres = getOffreDependOnFilter(lMULTIEntities);

      if (MultiProspects)
      {
        var listeProspect = lMULTIEntities.TPROSP.Select(x => new { x.NPROSNUM, x.VPROSNOM }).ToList();
        dictProspect = listeProspect.ToDictionary(x => x.NPROSNUM, x => x.VPROSNOM);
      
        //Pas de filtre sur miNumPRospect
        //listeOffres = listeOffres.ToList();
      }
      else
      {
        var listeProspect = lMULTIEntities.TPROSP.Where(x => x.NPROSNUM == miNumProspect).Select(x => new { x.NPROSNUM, x.VPROSNOM }).ToList();
        dictProspect = listeProspect.ToDictionary(x => x.NPROSNUM, x => x.VPROSNOM);
      
        listeOffres = listeOffres.Where(x => x.NPROSNUM == miNumProspect).ToList();
      }

      var listeSociete = lCOMMUNEntities.TSOCIETE.Where(x => x.BISFILIALEEMALEC == CEntiteConstants.STR_CHAMP_O)
          .Select(x => new { x.NSOCIETEID, x.VSOCIETE_NOM_USUEL })
          .ToList();
      var dictSociete = listeSociete.ToDictionary(x => x.NSOCIETEID, x => x.VSOCIETE_NOM_USUEL);

      var listeTPER = lMULTIEntities.TPER.ToList().Select(x => new { x.NPERNUM, NomPrenom = x.getNomPrenom() }).ToList();
      var dictTPER = listeTPER.ToDictionary(x => x.NPERNUM, x => x.NomPrenom);

      // Mapping optimisé
      var result = listeOffres.Select(x => new COffreListe_DTO
      {
        NOFFREID = x.NOFFREID,
        NPROSNUM = x.NPROSNUM,
        VPROSNOM = dictProspect.TryGetValue(x.NPROSNUM, out var nom) ? nom : string.Empty,
        DOFFREDATECRE = x.DOFFREDATECRE,
        NPERNUMCRE = x.NPERNUMCRE,
        VPERNUMCRE = dictTPER.TryGetValue(x.NPERNUMCRE, out var nomPrenom) ? nomPrenom : string.Empty,
        NSOCIETE = x.NSOCIETE,
        VSOCIETE = dictSociete.TryGetValue(x.NSOCIETE, out var societeNom) ? societeNom : string.Empty,
        NOFFREORICONTACT = x.NOFFREORICONTACT,
        VOFFRETEXT = x.VOFFRETEXT,
        NOFFRETYPEOFFRE = x.NOFFRETYPEOFFRE,
        VOFFREDEFENSIF = x.COFFREDEFENSIF == CEntiteConstants.STR_CHAMP_O ? CEntiteConstants.STR_CHAMP_OUI : CEntiteConstants.STR_CHAMP_NON,
        NOFFREDASEMALEC = x.NOFFREDASEMALEC,
        VOFFREPERIMETREPAYS = x.COFFREPERIMETREPAYS == CEntiteConstants.STR_CHAMP_O ? CEntiteConstants.STR_CHAMP_OUI : CEntiteConstants.STR_CHAMP_NON,
        DOFFREREPONSE = x.DOFFREREPONSE,
        DOFFREDEMARRRAGECONTRAT = x.DOFFREDEMARRRAGECONTRAT,
        NOFFRECAFORFAITPREV = x.NOFFRECAFORFAITPREV,
        NOFFRECAESTIMATIFGLOBAL = x.NOFFRECAESTIMATIFGLOBAL,
        NOFFRECADEFENSIF = x.NOFFRECADEFENSIF,
        NOFFRESTATUT = x.NOFFRESTATUT,
        NOFFRECHANCEGAIN = x.NOFFRECHANCEGAIN,
        VOFFRECOMMENTAIRE = x.VOFFRECOMMENTAIRE
      })
      .OrderByDescending(x => x.DOFFREDATECRE)
      .ToList();

      var temps = new BindingList<COffreListe_DTO>(result);

      GridControl.DataSource = temps;
    }
  }
}
