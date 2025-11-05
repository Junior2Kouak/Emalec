using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TREF_CTEANA")]
  public partial class TREF_CTEANA
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NCANNUM { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string VSOCIETE { get; set; }

    public string VCANLIB { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CTYPECTE { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string CCTEANAACTIF { get; set; }
    public decimal? NRFAPOURC { get; set; }
    public string VTYPEMBE { get; set; }
    public DateTime? DDATCREE { get; set; }
  }
}
