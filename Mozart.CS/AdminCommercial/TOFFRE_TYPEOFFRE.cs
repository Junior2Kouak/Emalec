using System.Collections.Generic;

namespace MozartCS
{
  public class TOFFRE_TYPEOFFRE
  {
    public int NOFFRE_TYPEOFFRE_ID { get; set; }
    public string VOFFRE_TYPEOFFRE_NOM { get; set; }
  }

  public static class TOFFRE_TYPEOFFRE_Liste
  {
    public static List<TOFFRE_TYPEOFFRE> TOFFRE_TYPEOFFREs = new List<TOFFRE_TYPEOFFRE>()
    {
      new TOFFRE_TYPEOFFRE()
      {
        NOFFRE_TYPEOFFRE_ID = 1,
        VOFFRE_TYPEOFFRE_NOM = "Appel d'offre"
      },
      new TOFFRE_TYPEOFFRE()
      {
        NOFFRE_TYPEOFFRE_ID = 2,
        VOFFRE_TYPEOFFRE_NOM = "Offre de contrat"
      }
    };
  }
}
