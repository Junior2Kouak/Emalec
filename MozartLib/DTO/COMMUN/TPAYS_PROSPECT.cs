using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPAYS_PROSPECT")]
  public partial class TPAYS_PROSPECT
  {
    [Key, ForeignKey("TPAYS")]
    public int NPAYSNUM { get; set; }

    [ForeignKey("NPAYSNUM")]
    public virtual TPAYS TPAYS { get; set; }
  }
}
