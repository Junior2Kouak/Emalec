using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace MozartLib
{
  public partial class STATISTIQUEEntities : DbContext
  {
    public STATISTIQUEEntities(string pServeurName) : base((pServeurName == "SRV-VMSQLPROD") ?
        $"data source=SRV-VMSQLPROD;initial catalog=STATISTIQUE;integrated security=True;MultipleActiveResultSets=True;App={MozartParams.NomSociete}" :
      $"data source=SRV-VMSQLTEST;initial catalog=STATISTIQUE;integrated security=True;MultipleActiveResultSets=True;App={MozartParams.NomSociete}")
    {
      //Database.Log = Console.WriteLine;
    }

    public DbSet<TSUIVIPROSPECT> TSUIVIPROSPECT { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      //modelBuilder.Entity<TREF_CTEANA>()
      //    .HasKey(t => new { t.NCANNUM, t.VSOCIETE });

      //modelBuilder.Entity<TCAN>()
      //    .HasKey(t => new { t.NPERNUM, t.NCANNUM, t.NCLINUM });

      //modelBuilder.Entity<TCLIPRIXTYPCONT>()
      //   .HasKey(t => new { t.NCLINUM, t.NTYPECONTRAT, t.VPAYS });

      //modelBuilder.Entity<TCONT>()
      //   .HasKey(t => new { t.NSITNUM, t.NTYPECONTRAT });

      //modelBuilder.Entity<TCONTRATCLI>()
      //   .HasKey(t => new { t.NCLINUM, t.NTYPECONTRAT });

      //modelBuilder.Entity<TPROSP_CLI>()
      //   .HasKey(t => new { t.NCLINUM, t.NPROSNUM });

      base.OnModelCreating(modelBuilder);
    }
  }
}
