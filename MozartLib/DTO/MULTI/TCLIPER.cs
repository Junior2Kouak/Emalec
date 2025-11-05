using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCLIPER")]
  public partial class TCLIPER
  {
    [Key, ForeignKey("TCLI")]
    public int NCLINUM { get; set; }
    public int NPERNUM { get; set; }
    public int NTECHNICONUM { get; set; }

    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
    [ForeignKey("NPERNUM")]
    public virtual TPER TPER { get; set; }
  }
}
