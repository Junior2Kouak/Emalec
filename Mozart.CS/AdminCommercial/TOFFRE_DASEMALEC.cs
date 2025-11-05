using System.Collections.Generic;

namespace MozartCS
{
  public class TOFFRE_DASEMALEC
  {
    public int NOFFRE_DASEMALEC_ID { get; set; }
    public string VOFFRE_DASEMALEC_NOM { get; set; }
  }

  public static class TOFFRE_DASEMALEC_Liste
  {
    public static List<TOFFRE_DASEMALEC> TOFFRE_DASEMALECs = new List<TOFFRE_DASEMALEC>()
    {
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 1,
        VOFFRE_DASEMALEC_NOM = "Maintenance Multitechnique (itinérante)"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 2,
        VOFFRE_DASEMALEC_NOM = "Maintenance Multitechnique (Posté)"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 3,
        VOFFRE_DASEMALEC_NOM = "Correctif MultitechnIque"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 4,
        VOFFRE_DASEMALEC_NOM = "Agencement"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 5,
        VOFFRE_DASEMALEC_NOM = "CVC / Plomberie"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 6,
        VOFFRE_DASEMALEC_NOM = "Extinction Incendie"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 7,
        VOFFRE_DASEMALEC_NOM = "Marché Bons Commande"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 8,
        VOFFRE_DASEMALEC_NOM = "Travaux CFO / CFA"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 9,
        VOFFRE_DASEMALEC_NOM = "Maintenance monolot"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 10,
        VOFFRE_DASEMALEC_NOM = "Déploiement"
      },
      new TOFFRE_DASEMALEC()
      {
        NOFFRE_DASEMALEC_ID = 11,
        VOFFRE_DASEMALEC_NOM = "Sureté"
      }
    };
  }
}
