using System.Collections.Generic;

namespace MozartCS
{
  public class TOFFRE_ORICONTACT
  {
    public int NOFFRE_ORICONTACT_ID { get; set; }
    public string VOFFRE_ORICONTACT_NOM { get; set; }
  }

  public static class TOFFRE_ORICONTACT_Liste
  {
    public static List<TOFFRE_ORICONTACT> TOFFRE_ORICONTACTs = new List<TOFFRE_ORICONTACT>()
    {
      new TOFFRE_ORICONTACT()
      {
        NOFFRE_ORICONTACT_ID = 1,
        VOFFRE_ORICONTACT_NOM = "Compte clé (rang 2)"
      },
      new TOFFRE_ORICONTACT()
      {
        NOFFRE_ORICONTACT_ID = 2,
        VOFFRE_ORICONTACT_NOM = "Prospection"
      },
      new TOFFRE_ORICONTACT()
      {
        NOFFRE_ORICONTACT_ID = 3,
        VOFFRE_ORICONTACT_NOM = "Compte prioritaire"
      },
      new TOFFRE_ORICONTACT()
      {
        NOFFRE_ORICONTACT_ID = 4,
        VOFFRE_ORICONTACT_NOM = "Notoriété EMALEC"
      },
      new TOFFRE_ORICONTACT()
      {
        NOFFRE_ORICONTACT_ID = 5,
        VOFFRE_ORICONTACT_NOM = "Client actif"
      },
      new TOFFRE_ORICONTACT()
      {
        NOFFRE_ORICONTACT_ID = 6,
        VOFFRE_ORICONTACT_NOM = "Plateforme Appel d'offres"
      }
    };
  }
}
