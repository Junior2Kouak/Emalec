using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class CApiMozarisEntraID
{
    public static async Task<string> GetFromApiWithBasicAuthAndParams(string baseUrl, Dictionary<string, string> queryParams, string username, string password)
    {
        try
        {
            //cette commande permet de bypasser la validation du certificat SSL
            // UTILISER UNQIEMENTEN INTERNE CAR PAS DE CERTIFICAT SSL VALIDE
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=    (sender, cert, chain, sslPolicyErrors) => true;
                      

            using (HttpClient client = new HttpClient())
            {
                // Authentification Basic
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);

                // Ajout des paramètres dans l'URL
                string fullUrl = baseUrl;
                if (queryParams != null && queryParams.Count > 0)
                {
                    var queryString = new FormUrlEncodedContent(queryParams).ReadAsStringAsync().Result;
                    fullUrl += "?" + queryString;
                }

                // Appel GET
                HttpResponseMessage response = await client.GetAsync(fullUrl);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
        catch (Exception ex)
        {
            return $"Erreur: {ex.Message}";
        }
    }

    //POST avec authentification Basic
    public static async Task<string> PostToApiWithBasicAuth(
        string baseUrl,        
        string jsonBody,
        string username,
        string password)
    {
        try
        {
            //cette commande permet de bypasser la validation du certificat SSL
            // UTILISER UNQIEMENTEN INTERNE CAR PAS DE CERTIFICAT SSL VALIDE
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient())
            {
                // Authentification Basic
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);

                // Préparation du contenu JSON
                var json = JsonConvert.SerializeObject(jsonBody);

                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Envoi POST
                HttpResponseMessage response = await client.PostAsync(baseUrl, content);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
        catch (Exception ex)
        {
            return $"Erreur: {ex.Message}";
        }
    }

    //DELETE avec authentification Basic
    public static async Task<string> DeleteToApiWithBasicAuth(
        string baseUrl,
        string jsonBody,
        string username,
        string password)
    {
        try
        {
            //cette commande permet de bypasser la validation du certificat SSL
            // UTILISER UNQIEMENTEN INTERNE CAR PAS DE CERTIFICAT SSL VALIDE
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient())
            {
                // Authentification Basic
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);

                // Préparation du contenu JSON
                HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(baseUrl),
                    Content = content
                };

                // Envoi POST
                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
        catch (Exception ex)
        {
            return $"Erreur: {ex.Message}";
        }
    }

    public class LineUserInfo
    {
        public string lineUser { get; set; }
        public string numCompose { get; set; }
        public string nomPoste { get; set; }
        public string vpn { get; set; }
    }


}
