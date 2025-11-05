using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCSIT")]
  public partial class TCSIT
  {
    [Key]
    public int NCSITNUM { get; set; }
    public int NTYPCSITNUM { get; set; }
    public int NSITNUM { get; set; }
    public string VCSITCIV { get; set; }
    public string VCSITNOM { get; set; }
    public string VCSITPRE { get; set; }
    public string VCSITTEL { get; set; }
    public string VCSITPOR { get; set; }
    public string VCSITFAX { get; set; }
    public string VCSITMAI { get; set; }
    public string CCSITACTIF { get; set; }

    [ForeignKey("NSITNUM")]
    public virtual TSIT TSIT { get; set; }
  }
}
