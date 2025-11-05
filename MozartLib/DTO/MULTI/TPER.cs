using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPER")]
  public partial class TPER
  {
    [Key]
    public int NPERNUM { get; set; }

    public string CPERTYP { get; set; }
    public string VPERNOM { get; set; }
    public string VPERPRE { get; set; }
    public string CPERINI { get; set; }
    public string VPERTEL { get; set; }
    public string VPERPOR { get; set; }
    public string VPERFAX { get; set; }
    public string VPERPAS { get; set; }
    public string VPERMAI { get; set; }
    public string VPERAD1 { get; set; }
    public string VPERAD2 { get; set; }
    public string VPERCP { get; set; }
    public string VPERVIL { get; set; }
    public int? NSERNUM { get; set; }
    public int? NREGCOD { get; set; }
    public DateTime? DPERNAI { get; set; }
    public DateTime? DPERENT { get; set; }
    public DateTime? DPERSOR { get; set; }
    public string CPERTCT { get; set; }
    public string VPERCOL { get; set; }
    public string VPERNIV { get; set; }
    public string VPERECH { get; set; }
    public string VPERCAT { get; set; }
    public string VPERCOE { get; set; }
    public int? NPERHEU { get; set; }
    public decimal? NPERSAL { get; set; }
    public decimal? NPERCOU { get; set; }
    public DateTime? DPERVIS { get; set; }
    public DateTime? DPERHAB { get; set; }
    public DateTime? DPERAVF { get; set; }
    public decimal? NPERMAV { get; set; }
    public int? NPERCOD { get; set; }
    public string NPERSTD { get; set; }
    public int? NPERTAPI { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CPERACTIF { get; set; }
    public string CPERCIV { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? NPERCPTINFO { get; set; }
    public double? FPERLAT { get; set; }
    public double? FPERLON { get; set; }
    public string VPERPAYS { get; set; }
    public string VPERADSI { get; set; }
    public string CPERTCT2 { get; set; }
    public string VPERIMAGE { get; set; }
    public string VPERSITFAM { get; set; }
    public DateTime? DPERENTINT { get; set; }
    public string VPERPERMI { get; set; }
    public string VPERMAILPRO { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public byte? BGROUPE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public byte? BUTILISATEUR { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VLANGUESYS { get; set; }
    public int? NPERCONTREMAITRE { get; set; }
    public string VPERSECTSAL { get; set; }
    public string VPERNUMSECU { get; set; }
    public string VPERNOMJEUNF { get; set; }
    public string VPERCOMNAISS { get; set; }
    public string VPERNATIONAL { get; set; }
    public string VPERNCARDSEJ { get; set; }
    public DateTime? DPEREXPCARDSEJ { get; set; }
    public decimal? VPERDELCARDSEJ { get; set; }
    public int? NTYPTRAV { get; set; }
    public string VPERLIBEMPLOI { get; set; }
    public string VPERCODINSEE { get; set; }
    public string VPERCODCONVCOLL { get; set; }
    public string VPERCODCONVDADS { get; set; }
    public string VPERTXAT { get; set; }
    public string VPERTXTRANSP { get; set; }
    public string VPERCPTDIF { get; set; }
    public string VPERCPTCP { get; set; }
    public string VPERCODBTP { get; set; }
    public string VPERNBENF { get; set; }
    public int? NPERSITUFAM { get; set; }
    public int? NPERPAYSNAISS { get; set; }
    public string VSOCIETE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string VPERCPTWAVESOFT { get; set; }
    public DateTime? DPERRAPPEL { get; set; }
    public int? NQUIRAPPEL { get; set; }
    public int? IDGROUPE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? MTVALIDATION { get; set; }
    public DateTime? DPERPERMIS { get; set; }
    public string VPERSIGN { get; set; }
    public int? NPERCHAFF { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public byte? BVISUPLANNING { get; set; }
    public int? NPERTUTEUR { get; set; }
    public DateTime? DPERINF { get; set; }
    public string CPERTYPDETAIL { get; set; }
    public int? NPERPLANIFICATEUR { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CPERPOSTE { get; set; }
    public int? NPERTYPPOSTE { get; set; }
    public bool? BPERNONCONCU { get; set; }
    public bool? BPEROBJ { get; set; }
    public int? NIDTYPEVEH { get; set; }
    public int? BPERMANIPFLUIDE { get; set; }
    public byte[] OPERSIGNATURE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CAUTORISATION { get; set; }
    public int? NPERRRET { get; set; }
    public decimal? NPERNBMOIS { get; set; }
    public decimal? NPERSALANNUEL { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public bool? BPERDEMANDEAUTOKMS { get; set; }
    public bool? BAFFICHEPROCURG { get; set; }
    public int? NPERCONTRAT { get; set; }
    public bool? BPER_TICK_REST { get; set; }
    public int? MTVALIDATIONDEVIS { get; set; }
    public bool? BPER_RESTRICTION { get; set; }
    public decimal? NPERKMDOMICILE { get; set; }
    public string VPERCONTACT { get; set; }
    public string VPERTELCONTACT { get; set; }
    public bool? BPERBALANCE { get; set; }
  }
}
