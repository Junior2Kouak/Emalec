using System.Collections.Generic;

namespace MozartCS
{
  public class TOFFRE_STATUT
  {
    public int NOFFRE_STATUT_ID { get; set; }
    public string VOFFRE_STATUT_NOM { get; set; }
  }

  public static class TOFFRE_STATUT_Liste
  {
    public static List<TOFFRE_STATUT> TOFFRE_STATUTs = new List<TOFFRE_STATUT>()
    {
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 1,
        VOFFRE_STATUT_NOM = "RFI en cours"
      },
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 2,
        VOFFRE_STATUT_NOM = "RFI envoyé"
      },
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 3,
        VOFFRE_STATUT_NOM = "En cours de chiffrage"
      },
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 4,
        VOFFRE_STATUT_NOM = "En attente"
      },
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 5,
        VOFFRE_STATUT_NOM = "Gagné"
      },
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 6,
        VOFFRE_STATUT_NOM = "Perdu"
      },
      new TOFFRE_STATUT()
      {
        NOFFRE_STATUT_ID = 7,
        VOFFRE_STATUT_NOM = "Annulé"
      }
    };
  }
}
