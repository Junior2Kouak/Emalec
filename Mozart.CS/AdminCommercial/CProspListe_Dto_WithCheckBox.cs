using System;

namespace MozartCS
{
  public class CProspListe_Dto_WithCheckBox
  {
    public int NPROSNUM { get; set; }                   // jamais null
    public bool IsSelected { get; set; }
    public string VPROSNOM { get; set; }
    public string VSUIVQUI { get; set; }
    public DateTime? DPROSDATECRE { get; set; }
    public string VPROSCP { get; set; }
    public string VPROSVIL { get; set; }
    public string VPROSPAYS { get; set; }
    public string VPROSAD1 { get; set; }
    public string VPROSAD2 { get; set; }
    public string CPROSPOFFRE { get; set; }
    public string VPRODEP { get; set; }
    public string VCODEAPE { get; set; }
    public string VLIBPROSORICONT { get; set; }
    public string NPROSURGENCE { get; set; }
    public string VPROSSERVICE { get; set; }
    public string VPROSGROUPE { get; set; }
    public string VPROSPSOCIETE { get; set; }
    public int? NPROSCOMSUIVINUM { get; set; }
    public string VLISTEPAYS { get; set; }
    public string VPROSCOMSUIVI { get; set; }

    public CProspListe_Dto_WithCheckBox(CProspListe_Dto pProspListe_Dto)
    {
      IsSelected = false;

      NPROSNUM = pProspListe_Dto.NPROSNUM;
      VPROSNOM = pProspListe_Dto.VPROSNOM;
      VSUIVQUI = pProspListe_Dto.VSUIVQUI;
      DPROSDATECRE = pProspListe_Dto.DPROSDATECRE;

      VPROSCP = pProspListe_Dto.VPROSCP;
      VPROSVIL = pProspListe_Dto.VPROSVIL;
      VPROSPAYS = pProspListe_Dto.VPROSPAYS;
      VPROSAD1 = pProspListe_Dto.VPROSAD1;
      VPROSAD2 = pProspListe_Dto.VPROSAD2;
      CPROSPOFFRE = pProspListe_Dto.CPROSPOFFRE;
      VPRODEP = pProspListe_Dto.VPRODEP;

      VCODEAPE = pProspListe_Dto.VCODEAPE;
      VLIBPROSORICONT = pProspListe_Dto.VLIBPROSORICONT;
      NPROSURGENCE = pProspListe_Dto.NPROSURGENCE;
      VPROSSERVICE = pProspListe_Dto.VPROSSERVICE;
      VPROSGROUPE = pProspListe_Dto.VPROSGROUPE;
      VPROSPSOCIETE = pProspListe_Dto.VPROSPSOCIETE;
      NPROSCOMSUIVINUM = pProspListe_Dto.NPROSCOMSUIVINUM;
      VLISTEPAYS = pProspListe_Dto.VLISTEPAYS;
      VPROSCOMSUIVI = pProspListe_Dto.VPROSCOMSUIVI;
    }
  }
}
