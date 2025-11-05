using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartLib
{
  [Table("TRSF")]
  public partial class TRSF
  {
    [Key]
    public int NRSFNUM { get; set; }

    public int? NCLINUM { get; set; }
    public string VRSFSER { get; set; }
    public string VRSFAD1 { get; set; }
    public string VRSFAD2 { get; set; }
    public string VRSFCP { get; set; }
    public string VRSFVIL { get; set; }
    public string VRSFTYP { get; set; }
    public string VRSFECH { get; set; }
    public string VRSFRSF { get; set; }
    public int? NRSFNBJ { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string NRSFFIN { get; set; }
    public int? NRSFSUP { get; set; }
    public string VRSFCPT8 { get; set; }
    public string VRSFAPE { get; set; }
    public string VRSFSIRET { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CRSFACTIF { get; set; }
    public string VRSFTVAINTRA { get; set; }
    public string VRSFPAYS { get; set; }
    public int? NRSFSITNUM { get; set; }
    public string VRSFREGION { get; set; }
    public string VRSFMAI { get; set; }
    public string VRSFBIC { get; set; }
    public string VRSFIBAN { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VRSFLANGUE { get; set; }
    public int? NIDBANQUE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public bool? BFILIALEEMALEC { get; set; }

    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
  }
}
