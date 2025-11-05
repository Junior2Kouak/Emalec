using System.ComponentModel.DataAnnotations;

namespace MozartLib
{
  public class TREF_GROUPE
  {
    [Key]
    public int IDGROUPE { get; set; }
    public int NPERNUM { get; set; }
  }
}
