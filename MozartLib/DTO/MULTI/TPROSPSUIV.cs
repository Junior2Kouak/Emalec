using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TPROSPSUIV")]
  public partial class TPROSPSUIV
  {
    [Key]
    public int NSUIVNUM { get; set; }
    public int NPROSNUM { get; set; }
    public DateTime? DSUIVDATE { get; set; }
    public string VSUIVQUI { get; set; }
    public string VSUIVACTION { get; set; }
    public string VSUIVETAT { get; set; }
    public DateTime? DSUIVDATERAP { get; set; }
    public int NDOMCOMID { get; set; }
    public DateTime? DSUIVRDV { get; set; }
    public int? NSUIVQUI { get; set; }
    public string CSUIVPREM { get; set; }
    public string CSUIVRDVREALISE { get; set; }
    public string CSUIVRDV { get; set; }
    public int? NSUIVQUIRDV { get; set; }
    public int? NSUIVRDVREALISE { get; set; }

    [ForeignKey("NPROSNUM")]
    public virtual TPROSP TPROSP { get; set; }
    [ForeignKey("NSUIVQUIRDV")]
    public virtual TPER TPER_QUIRDV { get; set; }
    [ForeignKey("NSUIVRDVREALISE")]
    public virtual TPER TPER_QUIRDVREALISE { get; set; }
  }
}
