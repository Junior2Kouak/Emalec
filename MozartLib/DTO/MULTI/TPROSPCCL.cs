using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPROSPCCL")]
  public partial class TPROSPCCL
  {
    [Key]
    // TODO FGB : A voir [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NIDPROSPCCLNUM { get; set; }
    public int NPROSNUM { get; set; }
    public string VPROSPCCLCIV { get; set; }
    public string VPROSPCCLNOM { get; set; }
    public string VPROSPCCLPRE { get; set; }
    public string VPROSPCCLQUAL { get; set; }
    public string VPROSPCCLTEL { get; set; }
    public string VPROSPCCLFAX { get; set; }
    public string VPROSPCCLPORT { get; set; }
    public string VPROSPCCLMAIL { get; set; }
    public string CPROSPCCLACTIF { get; set; }
    public int? NQUICREE { get; set; }
    public int? NQUIMOD { get; set; }
    public DateTime? DDATCRE { get; set; }
    public DateTime? DDATMODIF { get; set; }

    [ForeignKey("NPROSNUM")]
    public virtual TPROSP TPROSP { get; set; }

    [ForeignKey("NQUICREE")]
    public virtual TPER TPERCreateur { get; set; }

    [ForeignKey("NQUIMOD")]
    public virtual TPER TPERModificateur { get; set; }
  }
}
