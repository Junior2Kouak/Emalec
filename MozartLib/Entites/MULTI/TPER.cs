namespace MozartLib
{
  public partial class TPER
  {
    public string getNomPrenom()
    {
      return (VPERNOM ?? "") + " " + (VPERPRE ?? "").Trim();
    }
  }
}
