using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MozartLib
{
    public class CNumerotationAuto
    {

        public static async Task<string> MakeCallByAvaya(string UserTelInt, string NumOutCompose, String MachineName)
        {
            List<string> listNomPosteExclude = new List<string> { "FRLYVS-TSE01", "FRLYVS-TSE02", "FRLYVS-TSE03", "FRLYVS-TSE04" };
            bool bVPN = CVpnDetector.IsVpnConnected();
            if (!(NumOutCompose == "") && !(bVPN || listNomPosteExclude.Contains(MachineName)))
            {
                string baseUrlGet = $"https://{MozartParams.urlApiMozaris}/Avaya/MakeCallByAvaya";
                string sVPN = bVPN ? "true" : "false";

                // Corrected JSON body with proper escaping and interpolation
                //string jsonBody = $@"{{""lineUser"": ""{UserTelInt}"", ""numCompose"": ""{NumOutCompose}"", ""nomPoste"": ""{MachineName}"", ""vpn"": ""{sVPN}""}}";

                var parameters = new Dictionary<string, string>
                            {
                                { "lineUser", UserTelInt},
                                { "numCompose", NumOutCompose},
                                { "nomPoste", MachineName },
                                { "vpn", sVPN }
                            };

                //string response = await CApiMozarisEntraID.PostToApiWithBasicAuth(baseUrlGet, jsonBody, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);
                string response = await CApiMozarisEntraID.GetFromApiWithBasicAuthAndParams(baseUrlGet, parameters, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);
                return response;
            }

            if(NumOutCompose == "")
            {
                return "Erreur : Numéro de téléphone vide";
            }
            if (listNomPosteExclude.Contains(MachineName))
            {
                return "Erreur : La numérotation automatique ne fonctionne pas lorsque vous êtes connecté sur un serveur distant";
            }
            if (bVPN)
            {
                return "Erreur : La numérotation automatique ne fonctionne pas lorsque vous êtes connecté avec un VPN";
            }      
            return "Erreur : Numérotation automatiue impossible";
        }

    }
}
