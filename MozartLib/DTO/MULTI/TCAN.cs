using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCAN")]
  public partial class TCAN
  {
    public int NPERNUM { get; set; }
    public int NCANNUM { get; set; }
    public int NCLINUM { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCANACTIF { get; set; }
    public int? NPERNUMASS { get; set; }
    public int? NPERNUMFAC { get; set; }
    public int? NPERNUMASSCHAFF { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCANDEFWEBCLI { get; set; }


    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
    [ForeignKey("NPERNUM")]
    public virtual TPER TPER { get; set; }
    [ForeignKey("NPERNUMASSCHAFF")]
    public virtual TPER TPER_ASSCHAFF { get; set; }
    [ForeignKey("NPERNUMASS")]
    public virtual TPER TPER_ASS { get; set; }
    [ForeignKey("NPERNUMFAC")]
    public virtual TPER TPER_FAC { get; set; }
  }
}
