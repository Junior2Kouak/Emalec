using System;
using System.Linq;

namespace MozartCS
{
  public class COffreListe_DTO
  {
    public int NOFFREID { get; set; }
    public int NPROSNUM { get; set; }
    public string VPROSNOM { get; set; }
    public DateTime DOFFREDATECRE { get; set; }
    public int NPERNUMCRE { get; set; }
    public int NSOCIETE { get; set; }
    public int NOFFREORICONTACT { get; set; }
    public string VOFFRETEXT { get; set; }
    public int NOFFRETYPEOFFRE { get; set; }
    public string VOFFREDEFENSIF { get; set; }
    public int NOFFREDASEMALEC { get; set; }
    public string VOFFREPERIMETREPAYS { get; set; }
    public DateTime? DOFFREREPONSE { get; set; }
    public DateTime? DOFFREDEMARRRAGECONTRAT { get; set; }
    public double NOFFRECAFORFAITPREV { get; set; }
    public double NOFFRECAESTIMATIFGLOBAL { get; set; }
    public double NOFFRECADEFENSIF { get; set; }
    public double NOFFRECADEVELOPPEMENT { get; set; }
    public int NOFFRESTATUT { get; set; }
    public int NOFFRECHANCEGAIN { get; set; }
    public string VOFFRECOMMENTAIRE { get; set; }

    public string VOFFRETYPEOFFRE =>
        TOFFRE_TYPEOFFRE_Liste.TOFFRE_TYPEOFFREs
            .FirstOrDefault(t => t.NOFFRE_TYPEOFFRE_ID == NOFFRETYPEOFFRE)?
            .VOFFRE_TYPEOFFRE_NOM ?? string.Empty;
    public string VOFFREORICONTACT =>
        TOFFRE_ORICONTACT_Liste.TOFFRE_ORICONTACTs
            .FirstOrDefault(t => t.NOFFRE_ORICONTACT_ID == NOFFREORICONTACT)?
            .VOFFRE_ORICONTACT_NOM ?? string.Empty;
    public string VOFFREDASEMALEC =>
        TOFFRE_DASEMALEC_Liste.TOFFRE_DASEMALECs
            .FirstOrDefault(t => t.NOFFRE_DASEMALEC_ID == NOFFREDASEMALEC)?
            .VOFFRE_DASEMALEC_NOM ?? string.Empty;
    public string VOFFRESTATUT =>
        TOFFRE_STATUT_Liste.TOFFRE_STATUTs
            .FirstOrDefault(t => t.NOFFRE_STATUT_ID == NOFFRESTATUT)?
            .VOFFRE_STATUT_NOM ?? string.Empty;
    public string VOFFRECHANCEGAIN =>
        TOFFRE_CHANCEGAIN_Liste.TOFFRE_CHANCEGAINs
            .FirstOrDefault(t => t.NOFFRE_CHANCEGAIN_ID == NOFFRECHANCEGAIN)?
            .VOFFRE_CHANCEGAIN_NOM ?? string.Empty;

    public string VSOCIETE { get; set; }
    public string VPERNUMCRE { get; set; }
  }
}
