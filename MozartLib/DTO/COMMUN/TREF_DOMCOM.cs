using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartLib
{
  [Table("TREF_DOMCOM")]
  public partial class TREF_DOMCOM
  {
    [Key]
    [Column(Order = 1)]
    public int NDOMCOMID { get; set; }
    [Key]
    [Column(Order = 2)]
    public string VLANGUE { get; set; }
    public string VLIBDOMCOM { get; set; }
    public int NMENUNUM { get; set; }
  }
}
