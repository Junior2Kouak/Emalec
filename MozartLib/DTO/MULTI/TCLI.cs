using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TCLI")]
  public partial class TCLI
  {
    [Key]
    public int NCLINUM { get; set; }
    public string VCLINOM { get; set; }
    public string VCLIAD1 { get; set; }
    public string VCLIAD2 { get; set; }
    public string VCLICP { get; set; }
    public string VCLIVIL { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal NCLIHOR { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal NCLIDEP { get; set; }
    public string VCLIOBS { get; set; }
    public DateTime? DCLIDEB { get; set; }
    public DateTime? DCLIFIN { get; set; }
    public string VCLIMESS { get; set; }
    public DateTime? DCLIDMESS { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCLIACTIF { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCLIQUICRE { get; set; }
    public DateTime? DCLIDATECRE { get; set; }
    public string VCLIPAYS { get; set; }
    public string VCLIQUIMOD { get; set; }
    public DateTime? DCLIDATMOD { get; set; }
    public string VCLICEDEX { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCLITYPEFAC { get; set; }
    public string VCLICPCEDEX { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? MCLIMTDBL { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal? NCLIHORNUIDIM { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal? NCLIHORSAM { get; set; }
    public int? NCLIAUTOSTOCK { get; set; }
    public bool? BCLISOLDES { get; set; }
    public string VCLICONTRATWEB { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCLICHOIXRES { get; set; }
    public string CCLITYPE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCLIP3 { get; set; }
    public string CCLIACCWEBRESP { get; set; }
    public string VSOCIETE { get; set; }
    public double? FCLILAT { get; set; }
    public double? FCLILON { get; set; }
    public decimal? NSOLDECPTA { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public bool? BCLIGESTNUM { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public bool? BCLIGESTCPTEUR { get; set; }
    public string VCLIACTIVITE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? BCLIFORMEI { get; set; }
    public bool? BEIFACTDIFFEREE { get; set; }
    public bool? BDIINF12MOIS { get; set; }
    public string VFICHEPASSATION { get; set; }
    public string VCLIINFOSPLANIF { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CEMALECHABITAT { get; set; }
    public string VTYPECLIENT { get; set; }
    public bool? BCLIRAPPORTFM { get; set; }
    public bool? BATTACHMARCHPUBLIC { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VCLILANGUE { get; set; }
    public int? NCLITYPOLOGIE { get; set; }
    public string VCLICODEAPE { get; set; }
    public bool? NCLI_KPI_PLA_PREV { get; set; }
    public bool? BCLI_PDP_ACTION { get; set; }
    public bool? BCLIRELANCEIMPAYE { get; set; }
    public bool? BCLI_ATTACH_HR_ARR_EXE { get; set; }
    public bool? BCLI_NUMCDE_DI { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public bool? NCLI_KPI_DELAI_CONT { get; set; }
  }
}
