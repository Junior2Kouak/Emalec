using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TDIRECTION")]
  public class TDIRECTION
  {
    [Key]
    public int NPERNUM { get; set; }

    public string CSTATUTDIR { get; set; }
  }
}
