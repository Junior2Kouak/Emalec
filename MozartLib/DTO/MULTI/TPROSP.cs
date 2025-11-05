namespace MozartLib
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  [Table("TPROSP")]
  public partial class TPROSP
  {
    [Key]
    public int NPROSNUM { get; set; }
    public string VPROSNOM { get; set; }
    public string VPROSCIV { get; set; }
    public string VPROSCONT { get; set; }
    public string VPROSPRENOM { get; set; }
    public string VPROSQUAL { get; set; }
    public string VPROSCIV2 { get; set; }
    public string VPROSNOM2 { get; set; }
    public string VPROSPRENOM2 { get; set; }
    public string VPROSQUAL2 { get; set; }
    public string VPROSAD1 { get; set; }
    public string VPROSAD2 { get; set; }
    public string VPROSCP { get; set; }
    public string VPROSVIL { get; set; }
    public string VPROSPAYS { get; set; }
    public string VPROSTEL { get; set; }
    public string VPROSFAX { get; set; }
    public string VPROSPORT { get; set; }
    public string VPROSMAIL { get; set; }
    public string VPROSRENS { get; set; }
    public int? NPROSNBSUC { get; set; }
    public string CPROSACTIF { get; set; }
    public string VPROSQUICRE { get; set; }
    public DateTime? DPROSDATECRE { get; set; }
    public string VPROSQUIMOD { get; set; }
    public DateTime? DPROSDATMOD { get; set; }
    public string VPROSACT { get; set; }
    public string VPROSTEL1 { get; set; }
    public string VPROSTEL2 { get; set; }
    public string VPROSFAX1 { get; set; }
    public string VPROSFAX2 { get; set; }
    public string VPROSPORT1 { get; set; }
    public string VPROSPORT2 { get; set; }
    public string VPROSMAIL1 { get; set; }
    public string VPROSMAIL2 { get; set; }
    public string CPROSRDV { get; set; }
    public string CPROSPOFFRE { get; set; }
    public string VPROSCEDEX { get; set; }
    public int? NACTIVITE { get; set; }
    public int? NQUIRDV { get; set; }
    public DateTime? DRDV { get; set; }
    public int? NQUIOFFR { get; set; }
    public DateTime? DOFFRE { get; set; }
    public string VSOCIETE { get; set; }
    public double? FPROSLAT { get; set; }
    public double? FPROSLON { get; set; }
    public int? NPROSCHAFF { get; set; }
    public int? NPROSPACTINUM { get; set; }
    public int? NCLINUM { get; set; }
    public int? NIDPROSORICONT { get; set; }
    [ForeignKey("TREF_SECTEUR")]
    public int? NSECTEUR { get; set; }
    public string CPROSRDVPRIS { get; set; }
    public int? NQUIRDVPRIS { get; set; }
    public DateTime? DRDVPRIS { get; set; }
    public int NPROSURGENCE { get; set; }
    public int? NPROSGROUPE { get; set; }
    public int? NPROSCOMSUIVINUM { get; set; }

    [ForeignKey("NSECTEUR")]
    public virtual TREF_SECTEUR TREF_SECTEUR { get; set; }
    [ForeignKey("NPROSCOMSUIVINUM")]
    public virtual TPER TPER_COMSUIVI { get; set; }

    //public virtual ICollection<TPROSP_PAYS> ProspectPays { get; set; }
  }
}
