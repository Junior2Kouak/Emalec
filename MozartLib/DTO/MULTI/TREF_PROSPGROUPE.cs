using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TREF_PROSPGROUPE")]
  public partial class TREF_PROSPGROUPE
  {
    [Key]
    [Column("NREF_PROSPGROUPEID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NREF_PROSPGROUPEID { get; set; }

    [Column("VREF_PROSPGROUPENOM")]
    public string VREF_PROSPGROUPENOM { get; set; }
  }
}
