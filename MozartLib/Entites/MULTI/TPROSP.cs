using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MozartLib
{

  public partial class TPROSP
  {
    public const string TPROSP_NOMCOL_NPROSNUM = "NPROSNUM";
    public const string TPROSP_NOMCOL_CPROSRDV = "CPROSRDV";

    //[NotMapped]
    //public string ListePays
    //{
    //  get
    //  {
    //    return ProspectPays != null && ProspectPays.Any()
    //        ? string.Join(", ", ProspectPays.Select(pp => pp.TPAYS.VPAYSNOM))
    //        : string.Empty;
    //  }
    //}

    //[NotMapped]
    //public string NomComSuivi
    //{
    //  get
    //  {
    //    return TPER_COMSUIVI != null
    //        ? TPER_COMSUIVI.getNomPrenom()
    //        : string.Empty;
    //  }
    //}
  }
}
