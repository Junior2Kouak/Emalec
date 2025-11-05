using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPROSP_CLI")]
  public partial class TPROSP_CLI
  {
    public int NPROSNUM { get; set; }
    public int NCLINUM { get; set; }
    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
    [ForeignKey("NPROSNUM")]
    public virtual TPROSP TPROSP { get; set; }

  }
}
