using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartLib
{
  [Table("TCONTRATCLIDETAIL")]
  public class TCONTRATCLIDETAIL
  {
    [Key, Column(Order = 0)]
    public int NIDCONTRATCLI_DETAIL { get; set; }
    [Key, Column(Order = 1)]
    public int NCLINUM { get; set; }

    public int? NTYPECONTRAT { get; set; }
    public int? NIDCONTRAT_TYPEDOC { get; set; }
    public string VNOMDOCUMENT { get; set; }
    public DateTime? DDATE_DOCUMENT { get; set; }
    public string VFILE_DOCUMENT { get; set; }
    public DateTime? DDATE_DEBUT { get; set; }
    public DateTime? DDATE_FIN { get; set; }
    public bool? BCONTRATCLI_TACITE { get; set; }
    public int? NIDFORMULE_REV { get; set; }
    public string VOBS_DOC { get; set; }
    public string VOBS_REMISE { get; set; }
    public string VOBS_MANUEL { get; set; }
    public DateTime? DLAST_APPLICATION { get; set; }
    public string VHISTO_LAST_APPLICATION { get; set; }
    public decimal? PC_CUR { get; set; }
    public decimal? PC_PREV { get; set; }
    public decimal? PC_BPU { get; set; }
    public string VHISTO_PC_CUR { get; set; }
    public string VHISTO_PC_PREV { get; set; }
    public string VHISTO_PC_BPU { get; set; }
    public DateTime? DNEXT_APPLICATION { get; set; }
    public string VHISTO_NEXT_APPLICATION { get; set; }
    public bool? BACTIF { get; set; }
    public bool? BREMISE_AUCUNE { get; set; }
    public int? NIDCONTRATCLI_DETAIL_AVENANT { get; set; }
    public bool? BNODOC { get; set; }
    public string VOBS_CONTRAT { get; set; }
  }
}
