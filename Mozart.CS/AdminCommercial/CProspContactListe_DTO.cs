using MozartLib;
using System;

namespace MozartCS
{
  public class CProspContactListe_DTO
  {
    public int NIDPROSPCCLNUM { get; set; }
    public string VPROSPCCLCIV { get; set; }
    public string VPROSPCCLNOM { get; set; }
    public string VPROSPCCLPRE { get; set; }
    public string VPROSPCCLQUAL { get; set; }
    public string VPROSPCCLTEL { get; set; }
    public string VPROSPCCLPORT { get; set; }
    public string VPROSPCCLMAIL { get; set; }
    public string VQUICREE { get; set; }
    public DateTime? DDATCRE { get; set; }
    public string VQUIMODIF { get; set; }
    public DateTime? DDATMODIF { get; set; }
    public string CPROSPCCLACTIF { get; set; }

    public CProspContactListe_DTO(TPROSPCCL x)
    {
      NIDPROSPCCLNUM = x.NIDPROSPCCLNUM;
      VPROSPCCLCIV = x.VPROSPCCLCIV;
      VPROSPCCLNOM = x.VPROSPCCLNOM;
      VPROSPCCLPRE = x.VPROSPCCLPRE;
      VPROSPCCLQUAL = x.VPROSPCCLQUAL;
      VPROSPCCLTEL = x.VPROSPCCLTEL;
      VPROSPCCLPORT = x.VPROSPCCLPORT;
      VPROSPCCLMAIL = x.VPROSPCCLMAIL;
      VQUICREE = x.TPERCreateur?.getNomPrenom() ?? string.Empty;
      DDATCRE = x.DDATCRE;
      VQUIMODIF = x.TPERModificateur?.getNomPrenom() ?? string.Empty;
      DDATMODIF = x.DDATMODIF;
      CPROSPCCLACTIF = x.CPROSPCCLACTIF;
    }
  }
}
