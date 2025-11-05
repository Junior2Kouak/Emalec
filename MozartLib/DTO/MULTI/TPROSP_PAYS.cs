using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPROSP_PAYS")]
  public partial class TPROSP_PAYS
  {
    [Key, ForeignKey("TPROSP")]
    [Column(Order = 1)]
    public int NPROSNUM { get; set; }
    [Key, ForeignKey("TPAYS")]
    [Column(Order = 2)]
    public int NPAYSNUM { get; set; }

    [ForeignKey("NPROSNUM")]
    public virtual TPROSP TPROSP { get; set; }
    [ForeignKey("NPAYSNUM")]
    public virtual TPAYS TPAYS { get; set; }
  }
}
