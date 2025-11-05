using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace MozartLib
{
  public partial class MULTIEntities : DbContext
  {
    public MULTIEntities(string pServeurName) : base((pServeurName == "SRV-VMSQLPROD") ?
        $"data source=SRV-VMSQLPROD;initial catalog=MULTI;integrated security=True;MultipleActiveResultSets=True;App={MozartParams.NomSociete}" :
      $"data source=SRV-VMSQLTEST;initial catalog=MULTI;integrated security=True;MultipleActiveResultSets=True;App={MozartParams.NomSociete}")
    {
      //Database.Log = Console.WriteLine;
    }

    public MULTIEntities() : this(MozartParams.NomServeur)
    {
    }

    public DbSet<TCAN> TCAN { get; set; }
    public DbSet<TCCL> TCCL { get; set; }
    public DbSet<TCLI> TCLI { get; set; }
    public DbSet<TPER> TPER { get; set; }
    public DbSet<TRSF> TRSF { get; set; }
    public DbSet<TCONTRATCLI> TCONTRATCLI { get; set; }
    public DbSet<TREF_CTEANA> TREF_CTEANA { get; set; }
    public DbSet<TCLIPER> TCLIPER { get; set; }
    public DbSet<TSIT> TSIT { get; set; }
    public DbSet<TCSIT> TCSIT { get; set; }
    public DbSet<TCONT> TCONT { get; set; }
    public DbSet<TCLIPRIXTYPCONT> TCLIPRIXTYPCONT { get; set; }
    //public DbSet<api_v_TREF_TYPECONTRAT> api_v_TREF_TYPECONTRAT { get; set; }
    public DbSet<TPROSP> TPROSP { get; set; }
    public DbSet<TPROSPCCL> TPROSPCCL { get; set; }
    public DbSet<TPROSP_CLI> TPROSP_CLI { get; set; }
    public DbSet<TPROSPSUIV> TPROSPSUIV { get; set; }
    public DbSet<TREF_PROSPGROUPE> TREF_PROSPGROUPE { get; set; }
    public DbSet<TPROSP_PAYS> TPROSP_PAYS { get; set; }
    public DbSet<TPROSPOFFRE> TPROSPOFFRE { get; set; }
    public DbSet<TCONTRATCLIDETAIL> TCONTRATCLIDETAIL { get; set; }
    public DbSet<TDIRECTION> TDIRECTION { get; set; }
    public DbSet<TREF_GROUPE> TREF_GROUPE { get; set; }

    #region "PROC STOCK"

    public virtual List<api_sp_ComboRSFListeType_Result> api_sp_ComboRSFListeType()
    {
      return Database.SqlQuery<api_sp_ComboRSFListeType_Result>("api_sp_ComboRSFListeType").ToList();
    }

    public virtual List<api_sp_ComboRSFListeNBJ_Result> api_sp_ComboRSFListeNBJ()
    {
      return Database.SqlQuery<api_sp_ComboRSFListeNBJ_Result>("api_sp_ComboRSFListeNBJ").ToList();
    }

    public virtual List<api_sp_ComboRSFListeFinMois_Result> api_sp_ComboRSFListeFinMois()
    {
      return Database.SqlQuery<api_sp_ComboRSFListeFinMois_Result>("api_sp_ComboRSFListeFinMois").ToList();
    }

    public virtual List<api_sp_PrixClientContrat_ListePays_Result> api_sp_PrixClientContrat_ListePays(int? p_NCLINUM)
    {
      var p_NCLINUMParameter = p_NCLINUM.HasValue ?
          new SqlParameter("@P_NCLINUM", p_NCLINUM) :
          new SqlParameter("@P_NCLINUM", typeof(int));

      return Database.SqlQuery<api_sp_PrixClientContrat_ListePays_Result>("api_sp_PrixClientContrat_ListePays @P_NCLINUM", p_NCLINUMParameter).ToList();
    }

    public virtual List<api_sp_ListeContratsExistant_Result> api_sp_ListeContratsExistant(string p_VLANGUE)
    {
      var p_VLANGUEParameter = p_VLANGUE != null ?
          new SqlParameter("@P_VLANGUE", p_VLANGUE) :
          new SqlParameter("@P_VLANGUE", typeof(string));

      return Database.SqlQuery<api_sp_ListeContratsExistant_Result>("api_sp_ListeContratsExistant @P_VLANGUE", p_VLANGUEParameter).ToList();
    }

    public virtual List<api_sp_CboListChaffFreeByCptAna_Result> api_sp_CboListChaffFreeByCptAna(int? p_NCANNUM)
    {
      var p_NCANNUMParameter = p_NCANNUM.HasValue ?
          new SqlParameter("@P_NCANNUM", p_NCANNUM) :
          new SqlParameter("@P_NCANNUM", typeof(int));

      return Database.SqlQuery<api_sp_CboListChaffFreeByCptAna_Result>("api_sp_CboListChaffFreeByCptAna @P_NCANNUM", p_NCANNUMParameter).ToList();
    }

    public virtual int api_sp_SendMailNewClient(int? inclinum)
    {
      var inclinumParameter = inclinum.HasValue ?
          new SqlParameter("@inclinum", inclinum) :
          new SqlParameter("@inclinum", typeof(int));

      return Database.ExecuteSqlCommand("api_sp_SendMailNewClient @inclinum", inclinumParameter);
    }

    #endregion

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<TREF_CTEANA>()
          .HasKey(t => new { t.NCANNUM, t.VSOCIETE });

      modelBuilder.Entity<TCAN>()
          .HasKey(t => new { t.NPERNUM, t.NCANNUM, t.NCLINUM });

      modelBuilder.Entity<TCLIPRIXTYPCONT>()
         .HasKey(t => new { t.NCLINUM, t.NTYPECONTRAT, t.VPAYS });

      modelBuilder.Entity<TCONT>()
         .HasKey(t => new { t.NSITNUM, t.NTYPECONTRAT });

      modelBuilder.Entity<TCONTRATCLI>()
         .HasKey(t => new { t.NCLINUM, t.NTYPECONTRAT });

      modelBuilder.Entity<TPROSP_CLI>()
         .HasKey(t => new { t.NCLINUM, t.NPROSNUM });

      base.OnModelCreating(modelBuilder);
    }
  }

  #region "PROC STOCK RESULT"

  public partial class api_sp_PrixClientContrat_ListePays_Result
  {
    public string VPAYSNOM { get; set; }
    public int BPAYSSELECT { get; set; }
  }

  public partial class api_sp_ComboRSFListeType_Result
  {
    public string VRSFTYPE { get; set; }
  }

  public partial class api_sp_ComboRSFListeNBJ_Result
  {
    public int NRSFNBJ { get; set; }
    public string VRSFNBJ { get; set; }
  }

  public partial class api_sp_ComboRSFListeFinMois_Result
  {
    public string VRSFFINMOIS { get; set; }
  }

  public partial class api_sp_ListeContratsExistant_Result
  {
    public int NTYPECONTRAT { get; set; }
    public int BCONTRATAFFECTE { get; set; }
    public string VTYPECONTRAT { get; set; }
  }

  public partial class api_sp_CboListChaffFreeByCptAna_Result
  {
    public int NPERNUM { get; set; }
    public string VPERNOM { get; set; }
  }

  #endregion
}
