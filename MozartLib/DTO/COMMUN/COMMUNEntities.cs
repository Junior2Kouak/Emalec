using System.Data.Entity;

namespace MozartLib
{
  public partial class COMMUNEntities : DbContext
  {
    public COMMUNEntities(string pServeurName) : base((pServeurName == "SRV-VMSQLPROD") ?
        $"data source=SRV-VMSQLPROD;initial catalog=COMMUN;integrated security=True;MultipleActiveResultSets=True;App={MozartParams.NomSociete}" :
      $"data source=SRV-VMSQLTEST;initial catalog=COMMUN;integrated security=True;MultipleActiveResultSets=True;App={MozartParams.NomSociete}")
    {
      //Database.Log = Console.WriteLine;
    }

    public COMMUNEntities() : this(MozartParams.NomServeur)
    {
    }

    public virtual DbSet<TCOMMUNE> TCOMMUNE { get; set; }
    public virtual DbSet<TPAYS> TPAYS { get; set; }
    public virtual DbSet<TREF_SECTEUR> TREF_SECTEUR { get; set; }
    public virtual DbSet<TREF_BANQUE> TREF_BANQUE { get; set; }
    public virtual DbSet<TREF_TYPECONTRAT> TREF_TYPECONTRAT { get; set; }
    public virtual DbSet<TSOCIETE> TSOCIETE { get; set; }
    public virtual DbSet<TREF_DOMCOM> TREF_DOMCOM { get; set; }
    public virtual DbSet<TPAYS_PROSPECT> TPAYS_PROSPECT { get; set; }
  }
}
