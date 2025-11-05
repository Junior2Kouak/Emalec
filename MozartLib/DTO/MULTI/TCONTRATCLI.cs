using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCONTRATCLI")]
  public partial class TCONTRATCLI
  {
    public int NCLINUM { get; set; }
    public int NTYPECONTRAT { get; set; }

    public string VCONTRATOLD { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCODEFACT { get; set; }
    public string VDELAIS { get; set; }
    public string VCODEOPE { get; set; }
    public DateTime? DDATCREE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal? NMONTANTCONTRAT { get; set; }

    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
  }
}
