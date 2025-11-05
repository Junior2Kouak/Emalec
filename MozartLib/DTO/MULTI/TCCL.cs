using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCCL")]
  public partial class TCCL
  {
    [Key]
    public int NCCLNUM { get; set; }
    public int NCLINUM { get; set; }
    public string CCCLCIV { get; set; }
    public string VCCLNOM { get; set; }
    public string VCCLPRE { get; set; }
    public string VCCLTEL { get; set; }
    public string VCCLFAX { get; set; }
    public string VCCLMAIL { get; set; }
    public string VINTPOR { get; set; }
    public string VCCLFONC { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCCLDEVIS { get; set; }
    public string VCCLAD1 { get; set; }
    public string VCCLAD2 { get; set; }
    public string VCCLCP { get; set; }
    public string VCCLVIL { get; set; }
    public string VCCLREG { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCCLATT { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCCLACTIF { get; set; }
    public string VCCLCEDEX { get; set; }
    public string VCCLPAYS { get; set; }
    public string VCCLDEVISDEF { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCCLSTAT { get; set; }
    public int? NRSFNUM { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCCLMAILING { get; set; }
    public string VCCLMAILFAC { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCCLMAILREL { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? DDATECRE { get; set; }
    public DateTime? DDATEMOD { get; set; }
    public int? NQUICRE { get; set; }
    public int? NQUIMOD { get; set; }

    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
  }
}
