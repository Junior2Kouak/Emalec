using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCONT")]
  public partial class TCONT
  {
    public int NSITNUM { get; set; }
    public int NTYPECONTRAT { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCONTETAT { get; set; }
    public int? NINTNUM { get; set; }
    public string VSTIMPOSE { get; set; }
    public int? NNBVISANNUEL { get; set; }
    public Decimal? NDUREEINTER { get; set; }
    public Decimal? NMONTANTINTER { get; set; }
    public int? NNBEQUIP { get; set; }
    public Decimal? NMONTANTP3 { get; set; }
    public DateTime? DDEBP2 { get; set; }
    public DateTime? DFINP2 { get; set; }
    public DateTime? DDEBP3 { get; set; }
    public DateTime? DFINP3 { get; set; }
    public string VCOTRAITANT { get; set; }
    public int? NSTFNUM { get; set; }
    public Decimal? NMONTANTSTTP2 { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCONTNACELLE { get; set; }

    [ForeignKey("NSITNUM")]
    public virtual TSIT TSIT { get; set; }
  }
}
