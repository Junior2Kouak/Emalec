using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MozartLib
{
  [Table("TSOCIETE")]
  public partial class TSOCIETE
  {
    [Key]
    [Column(Order = 0)]
    public int NSOCIETEID { get; set; }

    [Key]
    [Column(Order = 1)]
    [StringLength(20)]
    public string VSOCIETENOM { get; set; }

    [Key]
    [Column(Order = 2)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int NSOCIETENODE { get; set; }

    public string VSOCIETEACTIF { get; set; }

    public int? NCLINUM { get; set; }

    public string VSOCIETE_NOM_USUEL { get; set; }

    public string VSOCIETE_MAIL_COMPTA { get; set; }

    public string BISFILIALEEMALEC { get; set; }
  }
}
