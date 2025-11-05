using System.Collections.Generic;

namespace MozartCS
{
  public class TOFFRE_CHANCEGAIN
  {
    public int NOFFRE_CHANCEGAIN_ID { get; set; }
    public string VOFFRE_CHANCEGAIN_NOM { get; set; }
  }

  public static class TOFFRE_CHANCEGAIN_Liste
  {
    public static List<TOFFRE_CHANCEGAIN> TOFFRE_CHANCEGAINs = new List<TOFFRE_CHANCEGAIN>()
    {
      new TOFFRE_CHANCEGAIN()
      {
        NOFFRE_CHANCEGAIN_ID = 1,
        VOFFRE_CHANCEGAIN_NOM = "0 %"
      },
      new TOFFRE_CHANCEGAIN()
      {
        NOFFRE_CHANCEGAIN_ID = 2,
        VOFFRE_CHANCEGAIN_NOM = "25 %"
      },
      new TOFFRE_CHANCEGAIN()
      {
        NOFFRE_CHANCEGAIN_ID = 3,
        VOFFRE_CHANCEGAIN_NOM = "50 %"
      },
      new TOFFRE_CHANCEGAIN()
      {
        NOFFRE_CHANCEGAIN_ID = 4,
        VOFFRE_CHANCEGAIN_NOM = "75 %"
      },
      new TOFFRE_CHANCEGAIN()
      {
        NOFFRE_CHANCEGAIN_ID = 5,
        VOFFRE_CHANCEGAIN_NOM = "100 %"
      }
    };
  }
}
