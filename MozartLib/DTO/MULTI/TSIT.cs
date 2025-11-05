using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TSIT")]
  public partial class TSIT
  {
    [Key]
    public int NSITNUM { get; set; }
    public int NCLINUM { get; set; }
    public string NSITNUE { get; set; }
    public string VSITNOM { get; set; }
    public string VSITAD1 { get; set; }
    public string VSITAD2 { get; set; }
    public string VSITCP { get; set; }
    public string VSITVIL { get; set; }
    public string VSITTEL { get; set; }
    public string VSITFAX { get; set; }
    public int? NSITSFV { get; set; }
    public int? NSITSFR { get; set; }
    public DateTime? DSITSEC { get; set; }
    public string VSITRES { get; set; }
    public int NRSFNUM { get; set; }
    public int NREGCOD { get; set; }
    public string VSITMAI { get; set; }
    public string VSITREG { get; set; }
    public string VSITHOR { get; set; }
    public string VSITENSEIGNE { get; set; }
    public int? NSITRESPREG { get; set; }
    public int? NSITRESPMAG { get; set; }
    public int? NSITRESPMAINT { get; set; }
    public string VSITMESS { get; set; }
    public DateTime? DSITDMESS { get; set; }
    public string VSITPRENOM { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CSITACTIF { get; set; }
    public string VSITPAYS { get; set; }
    public string VSITCEDEX { get; set; }
    public double? FSITLAT { get; set; }
    public double? FSITLON { get; set; }
    public string VSITTYPE { get; set; }
    public string VSITQUICRE { get; set; }
    public DateTime? DSITDATCRE { get; set; }
    public string VSITQUIMOD { get; set; }
    public DateTime? DSITDATMOD { get; set; }
    public DateTime? DSITDCREMAG { get; set; }
    public string VSITPORT { get; set; }
    public string VSITCIV { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CSITPART { get; set; }
    public string VSITCPCEDEX { get; set; }
    public string VSITCONCEPT { get; set; }
    public int? NSERVTECHNUM { get; set; }
    public string VSITINFOSTOCK { get; set; }
    public int? NSITNBOCUP { get; set; }
    public int? NSITRATCH { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? NSITGARANTIE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? NSITTYPE { get; set; }
    public int? NSITNBCOUVERT { get; set; }
    public string CSITSTATJUR { get; set; }
    public int? NSITNBCHAMBRE { get; set; }
    public string VCODIMPL { get; set; }
    public int? NSITPRIO { get; set; }
    public string VSITEXTCERT { get; set; }
    public DateTime? DSITEXTCERT { get; set; }
    public string CCLIGESTPEXTINCT { get; set; }
    public int? NSITRESPSECT { get; set; }
    public int? NSITNBNIVO { get; set; }
    public string VSITEXTCARACT { get; set; }
    public string VSITEXTPART { get; set; }
    public DateTime? DSITEXTDERVIS { get; set; }
    public string VNUMCODEMS { get; set; }
    public string VNUMCODEMF { get; set; }
    public string VNUMCODEMC { get; set; }
    public string VNUMCODEMM { get; set; }
    public int? NVILLECIBLE { get; set; }
    public string VNUMCODEML { get; set; }
    public bool? BSITPERPOSTE { get; set; }
    public string VSITSECTEUR { get; set; }
    [ForeignKey("NCLINUM")]
    public virtual TCLI TCLI { get; set; }
    [ForeignKey("NRSFNUM")]
    public virtual TRSF TRSF { get; set; }
  }
}
