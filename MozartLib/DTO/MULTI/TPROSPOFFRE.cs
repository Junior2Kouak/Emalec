using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPROSPOFFRE")]
  public partial class TPROSPOFFRE
  {
    [Key]
    public int NOFFREID { get; set; }
    [ForeignKey("TPROSP")]
    public int NPROSNUM { get; set; }
    public DateTime DOFFREDATECRE { get; set; }
    public int NPERNUMCRE { get; set; }
    public int NSOCIETE { get; set; }
    public int NOFFREORICONTACT { get; set; }
    public string VOFFRETEXT { get; set; }
    public int NOFFRETYPEOFFRE { get; set; }
    public string COFFREDEFENSIF { get; set; }
    public int NOFFREDASEMALEC { get; set; }
    public string COFFREPERIMETREPAYS { get; set; }
    public DateTime? DOFFREREPONSE { get; set; }
    public DateTime? DOFFREDEMARRRAGECONTRAT { get; set; }
    public double NOFFRECAFORFAITPREV { get; set; }
    public double NOFFRECAESTIMATIFGLOBAL { get; set; }
    public double NOFFRECADEFENSIF { get; set; }
    public int NOFFRESTATUT { get; set; }
    public int NOFFRECHANCEGAIN { get; set; }
    public string VOFFRECOMMENTAIRE { get; set; }
    public string COFFREARCHIVEE { get; set; }

    [ForeignKey("NPROSNUM")]
    public virtual TPROSP TPROSP { get; set; }
  }
}
