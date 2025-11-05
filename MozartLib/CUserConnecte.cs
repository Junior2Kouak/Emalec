using MozartLib.Entites.COMMUN;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MozartLib
{
  [NotMapped]
  public class CUserConnecte
  {
    public int NPERNUM { get; set; }
    public string CPERTYP { get; set; }
    public string CPERTYPDETAIL { get; set; }
    public int NSERNUM { get; set; }
    public string VPERADSI { get; set; }
    public int NSOCIETEID { get; set; }

    public CUserConnecte()
    {
      NPERNUM = 0;
      CPERTYP = string.Empty;
      CPERTYPDETAIL = string.Empty;
      NSERNUM = 0;
    }

    public CUserConnecte(TPER tper) : this()
    {
      if (tper != null)
      {
        NPERNUM = tper.NPERNUM;
        CPERTYP = tper.CPERTYP;
        CPERTYPDETAIL = tper.CPERTYPDETAIL;
        NSERNUM = tper.NSERNUM ?? 0;
        VPERADSI = tper.VPERADSI;
      }
    }

    // Renvoit les offres visibles par l'utilisateur connecté
    public List<TPROSPOFFRE> getOffresFiltrees(List<TPROSPOFFRE> pOffresDispo)
    {
      MULTIEntities mMULTIEntities = new MULTIEntities();

      // Membre de la Direction
      bool isDirection = mMULTIEntities.TDIRECTION.Any(x => x.NPERNUM == NPERNUM);
      if (isDirection)
      {
        return pOffresDispo;
      }

      // Membre des chefs de groupe
      bool isChefDeGroupe = mMULTIEntities.TREF_GROUPE.Any(x => x.NPERNUM == NPERNUM);

      // DIREX
      if ((CPERTYPDETAIL == TREF_TYPEPERDETAIL.STR_DE) || isChefDeGroupe)
      {
        return pOffresDispo.Where(x => x.NSOCIETE == NSOCIETEID).ToList();
      }

      // Rectif : En fait, n'importe qui d'autres voit au moins les offres qu'il a créées
      // Commercial
      //if (NSERNUM == TSER.TSER_NSERNUM_COMMERCIAL)
      //{
      List<int> myDifferentNPERNUM = mMULTIEntities.TPER.Where(x => x.VPERADSI == VPERADSI).Select(y => y.NPERNUM).ToList();

      return pOffresDispo.Where(x => myDifferentNPERNUM.Contains(x.NPERNUMCRE)).ToList();
      //}

      // Rien dans les autres cas
      //return new List<TPROSPOFFRE>();
    }

    // Prospects que le user connecté doit voir : Si null, on rapatrie tout
    public List<int> getProspectsFiltres(List<int> pProspects)
    {
      MULTIEntities mMULTIEntities = new MULTIEntities();

      // Membre de la Direction
      bool isDirection = mMULTIEntities.TDIRECTION.Any(x => x.NPERNUM == NPERNUM);
      // Membre des chefs de groupe
      bool isChefDeGroupe = mMULTIEntities.TREF_GROUPE.Any(x => x.NPERNUM == NPERNUM);

      // Si direction, chef de groupe, commercial ou DirEx : Tout !
      if (isDirection || isChefDeGroupe || (NSERNUM == TSER.TSER_NSERNUM_COMMERCIAL) || (CPERTYPDETAIL == TREF_TYPEPERDETAIL.STR_DE))
      {
        return pProspects;
      }

      List<TCAN> TCANs;

      // Chaff
      if (CPERTYPDETAIL == TREF_TYPEPERDETAIL.STR_CA)
      {
        TCANs = mMULTIEntities.TCAN.Where(x => x.NPERNUM == NPERNUM).ToList();
      }
      else
      {
        TCANs = mMULTIEntities.TCAN.ToList();
      }

      List<int> lCliVisible = TCANs.Select(x => x.NCLINUM).Distinct().ToList();
      List<int> lProsps = mMULTIEntities.TPROSP_CLI.Where(x => lCliVisible.Contains(x.NCLINUM)).Distinct().Select(x => x.NPROSNUM).ToList();

      return pProspects.Where(x => lProsps.Contains(x)).ToList();
    }
  }
}
