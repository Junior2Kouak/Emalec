using MozartControls.Properties;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MozartControls
{
  public static class Utils
  {
    public static bool VerifTVAIntra(string p_NNUMTVAINTRA, string p_vpays)
    {
      string strReg;

      switch (p_vpays)
      {
        case "ALLEMAGNE": strReg = "DE[0-9]{9}"; break;
        case "AUTRICHE": strReg = "ATU[0-9]{8}"; break;
        case "BELGIQUE": strReg = "BE[0-9]{10}"; break;
        case "BULGARIE": strReg = "BG[0-9]{9}|BG[0-9]{10}"; break;
        case "CHYPRE": strReg = "CY[0-9]{9}L"; break;
        case "CROATIE": strReg = "HR[0-9]{11}"; break;
        case "DANEMARK": strReg = "DK[0-9]{8}"; break;
        case "ESPAGNE": strReg = "ES[A-Z0-9]{1}[0-9]{7}[A-Z0-9]{1}"; break;
        case "ESTONIE": strReg = "EE[0-9]{9}"; break;
        case "FINLANDE": strReg = "FI[0-9]{8}"; break;
        case "FRANCE": strReg = "FR[A-Z0-9]{2}[0-9]{9}"; break;
        case "GRANDE BRETAGNE": strReg = "GB[0-9]{9}"; break;
        case "GRECE": strReg = "EL[0-9]{9}"; break;
        case "HONGRIE": strReg = "EL[0-9]{8}"; break;
        case "IRLANDE": strReg = "IE[0-9]{7}[A-Z]{2}"; break;
        case "ITALIE": strReg = "IT[0-9]{11}"; break;
        case "LETTONIE": strReg = "LV[0-9]{11}"; break;
        case "LITUANIE": strReg = "LT[0-9]{9}|LT[0-9]{12}"; break;
        case "LUXEMBOURG": strReg = "LU[0-9]{8}"; break;
        case "MALTE": strReg = "MT[0-9]{8}"; break;
        case "PAYS-BAS": strReg = "NL[0-9]{9}[A-Z]{1}[0-9]{2}"; break;
        case "POLOGNE": strReg = "PL[0-9]{10}"; break;
        case "PORTUGAL": strReg = "PT[0-9]{9}"; break;
        case "REPUBLIQUE TCHEQUE": strReg = "CZ[0-9]{8}|CZ[0-9]{9}|CZ[0-9]{10}"; break;
        case "ROUMANIE": strReg = "RO[0-9]{2-10}"; break;
        case "SLOVAQUIE": strReg = "SK[0-9]{10}"; break;
        case "SLOVENIE": strReg = "SI[0-9]{8}"; break;
        case "SUEDE": strReg = "SE[0-9]{10}01"; break;
        default:
          // Exception pour la Suisse, pas vide ça suffira !
          // Et pour les autres pays, ils commencent à me faire chier avec leur TVA batardes
          if (p_NNUMTVAINTRA != "")
          {
            return true;
          } else
          {
            strReg = "";
          }
          break;
      }

      if (strReg == "")
      {
        return false;
      }

      Regex oRegIsMatch = new Regex(strReg);
      return oRegIsMatch.IsMatch(p_NNUMTVAINTRA.Replace(" ", ""));
    }

    public static void displayError(string pCalledMethod, Exception pEx)
    {
      MessageBox.Show($"{pEx.Message}{Environment.NewLine}{Environment.NewLine}{Resources.Global_dans} {pCalledMethod}",
                      Resources.Global_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }
}
