using System;

namespace MozartCS
{
  public class CProspectListeCli_DTO
  {
    public int NCLINUM { get; set; }
    public string VCLINOM { get; set; }
    public string VSOCIETE { get; set; }
    public int NCA { get; set; }
    public DateTime? DDINDAT { get; set; }
    public string VNOMCHAFF { get; set; }
    /*
		NCLINUM INT,
		VCLINOM VARCHAR(500),
		VSOCIETE VARCHAR(50),
		NCA INT,
		DDINDAT DATETIME,
		VNOMCHAFF VARCHAR(50)
     * */
  }
}
