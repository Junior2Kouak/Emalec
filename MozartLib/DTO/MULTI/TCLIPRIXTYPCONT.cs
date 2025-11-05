using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCLIPRIXTYPCONT")]
  public partial class TCLIPRIXTYPCONT
  {
    public int NCLINUM { get; set; }
    public int NTYPECONTRAT { get; set; }
    public string VPAYS { get; set; }
    public Decimal? NCLICONTHOR { get; set; }
    public Decimal? NCLICONTDEP { get; set; }
    public Decimal? NCLICONTHORSAM { get; set; }
    public Decimal? NCLICONTHORNUIDIM { get; set; }
    public Decimal? NMTTFORFAITASTR { get; set; }
    public string VACTTEXTASTR { get; set; }

    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
  }
}
