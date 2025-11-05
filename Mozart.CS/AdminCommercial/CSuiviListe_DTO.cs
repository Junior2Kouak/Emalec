using MozartLib;
using System;

namespace MozartCS
{
  public class CSuiviListe_DTO
  {
    public int NSUIVNUM { get; set; }
    public int NPROSNUM { get; set; }
    public DateTime? DSUIVDATE { get; set; }
    public string VSUIVQUI { get; set; }
    public string VSUIVACTION { get; set; }
    public DateTime? DSUIVDATERAP { get; set; }
    public int NDOMCOMID { get; set; }
    public DateTime? DSUIVRDV { get; set; }
    public string CSUIVRDVREALISE { get; set; }
    public string VLIBDOMCOM { get; set; }

    public CSuiviListe_DTO()
    {
    }

    public CSuiviListe_DTO(TPROSPSUIV pProspSuiv)
    {
      NSUIVNUM = pProspSuiv.NSUIVNUM;
      NPROSNUM = pProspSuiv.NPROSNUM;
      DSUIVDATE = pProspSuiv.DSUIVDATE;
      VSUIVQUI = pProspSuiv.VSUIVQUI;
      VSUIVACTION = pProspSuiv.VSUIVACTION;
      DSUIVDATERAP = pProspSuiv.DSUIVDATERAP;
      NDOMCOMID = pProspSuiv.NDOMCOMID;
      DSUIVRDV = pProspSuiv.DSUIVRDV;
      CSUIVRDVREALISE = pProspSuiv.CSUIVRDVREALISE;
    }
  }
}
