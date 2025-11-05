using System;

namespace MozartCS
{
  public class CProspListe_Dto
  {
    public int NORDERBY { get; set; }                    // jamais null, calculé
    public string VPROSNOM { get; set; }
    public DateTime? DSUIVDATE { get; set; }
    public string VSUIVQUI { get; set; }
    public DateTime? DSUIVDATERAP { get; set; }
    public string VSUIVACTION { get; set; }
    public DateTime? DPROSDATECRE { get; set; }
    public string VPROSNOM2 { get; set; }

    public int? NSUIVNUM { get; set; }                  // nullable car peut être NULL
    public int NPROSNUM { get; set; }                   // jamais null
    public string VPROSCP { get; set; }
    public string VPROSVIL { get; set; }
    public string VPROSRENS { get; set; }
    public int? NPROSNBSUC { get; set; }                // nullable si SQL peut renvoyer NULL
    public string VPROSPAYS { get; set; }
    public string VPROSAD1 { get; set; }
    public string VPROSAD2 { get; set; }
    public string CPROSPOFFRE { get; set; }
    public string CPROSRDV { get; set; }
    public string VPROSACT { get; set; }

    public int? NCLINUM { get; set; }                   // nullable car LEFT JOIN
    public string VCLINOM { get; set; }
    public string VPRODEP { get; set; }
    public string VSOCIETE { get; set; }
    public string VCODEAPE { get; set; }
    public string VLIBPROSORICONT { get; set; }
    public string NPROSURGENCE { get; set; }
    public string VPROSSERVICE { get; set; }
    public string VPROSGROUPE { get; set; }
    public string VPROSPSOCIETE { get; set; }
    public int? NPROSCOMSUIVINUM { get; set; }
    public string VLISTEPAYS { get; set; }
    public string VPROSCOMSUIVI { get; set; }

    public string BLEU { get; set; }
    public string VERT { get; set; }
    public string ROUGE { get; set; }
    public string DATERELDEP { get; set; }
  }
}
