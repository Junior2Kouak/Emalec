using System;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Net;
using System.Data.SqlClient;
using MozartNet;
using MZUtils = MozartControls.Utils;
using MozartLib;


namespace MozartCS
{
	class Geronimmo
	{

    //const string API_ID = "c2db9d9f-952a-435f-8781-b647f495df3c";
    //const string API_SECRET = "a5f020c1-00e7-4966-a220-e718a93e13d9";
    //const string BASE_TOKEN = "https://www.sun-api-auth-ppr.bpce.fr/api/oauth/token";

    const string API_ID = "e5b963d0-e3f8-46c7-bb16-3fefff1603cf";
    const string API_SECRET = "e3272774-d837-400a-8603-b9f15275b098";
    const string BASE_TOKEN = "https://www.sun-api-auth.bpce.fr/api/oauth/token";


    private static string GetToken()
    {
      string res = "";

      try
      {
        // Initialiser RestSharp
        var client = new RestClient();
        var request = new RestRequest(BASE_TOKEN, Method.POST);

        // Ajouter les en-têtes
        string basicAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{API_ID}:{API_SECRET}"));
        request.AddHeader("Authorization", $"Basic {basicAuth}");
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

        // Ajouter les paramètres au corps de la requête
        request.AddParameter("grant_type", "client_credentials");

        // interrogation de l'API
        IRestResponse response = client.Execute(request);

        if (response?.StatusCode == HttpStatusCode.OK)
        {
          GERO_TOKEN Token = JsonConvert.DeserializeObject<GERO_TOKEN>(response.Content);
          res = Token.access_token;
        }
        else
        {
          res = "Erreur de token";
          LogInfo("Erreur de token");
        }

      }
      catch (Exception ex)
      {
        LogInfo($"Erreur de token {ex.Message}");
        res = "Erreur de token";
      }

      return res;
    }


    public static bool  CallUpdateTask(Uri url, GERONIMMO_UPDATE body, ref string result)
    {
      bool res = false;

      // Token Bearer pour l'authentification
      string bearerToken = GetToken();

      if (bearerToken == "Erreur de token")
      {
        return false;
      }

      try
      {
          // Initialiser RestSharp
          var client = new RestClient(url);

          // Créer la requête PATCH
          var request = new RestRequest(Method.PATCH);

          // Ajouter le token Bearer dans l'en-tête
          request.AddHeader("Authorization", $"Bearer {bearerToken}");
          request.AddHeader("Content-Type", "application/json");

          // Ajouter le corps de la requête
          request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);

          // Envoyer la requête
          IRestResponse response = client.Execute(request);

          res = response?.StatusCode == HttpStatusCode.OK;

          if (!string.IsNullOrEmpty(response?.Content))
            result = response.Content;
          else if (response != null)
            result = $"StatusCode : {response.StatusCode}";
      }
      catch (Exception ex)
      {
          result = ex.Message;
      }

      return res;
    }

    public static bool CallSendDocument(string NumTask, Uri url, string fileName, string filePath, ref string result)
    {
      bool res = false;

      // Token Bearer pour l'authentification
      string bearerToken = GetToken();

      if (bearerToken == "Erreur de token")
      {
        return false;
      }

      try
      {

        // Initialiser RestSharp
        var client = new RestClient(url);

        // Créer la requête PATCH
        var request = new RestRequest(Method.POST);

        // Ajouter le token Bearer dans l'en-tête
        request.AddHeader("Authorization", $"Bearer {bearerToken}");
        request.AddHeader("Content-Type", "application/json");

        // Ajouter les paramètres de requête
        request.AddQueryParameter("u_number", NumTask);   //"SCTASK0000617002"
        request.AddQueryParameter("u_file_name", fileName);

        // Ajouter le fichier au corps de la requête
        request.AddFile("file", filePath);

        // Envoyer la requête
        IRestResponse response = client.Execute(request);

        res = response?.StatusCode == HttpStatusCode.OK;

        if (!string.IsNullOrEmpty(response?.Content))
          result = response.Content;
        else if (response != null)
          result = $"StatusCode : {response.StatusCode}";
      }
      catch (Exception ex)
      {
        result = ex.Message;
      }

      return res;
    }


    public static bool GetDI(RestSharp.Method method, Uri url)
    {

      bool res = false;

      string timestamp = DateTime.UtcNow.ToString("s");

      RestSharp.RestClient client = new RestSharp.RestClient();
      RestSharp.RestRequest request = new RestSharp.RestRequest(url, method);
      request.AddHeader("X-Timestamp", timestamp);
     // request.AddHeader("Authorization", $"TCN {apiToken}:{CreateDigest(method.ToString(), url, apiSecret, timestamp)}");
      request.AddParameter("application/json", "", RestSharp.ParameterType.RequestBody);

      RestSharp.IRestResponse response = client.Execute(request);

      res = response?.StatusCode == HttpStatusCode.OK;

      //RestResponse response = (RestResponse)client.Execute(request);

      if (response.StatusCode == HttpStatusCode.OK)
      {

        GERO_DI[] DIs = JsonConvert.DeserializeObject<GERO_DI[]>(response.Content);

        if (DIs.Count() > 0)
        {
					SaveToBD(DIs);
        }
      }

      return res;
    }

    private static void SaveToBD(GERO_DI[] DIS)
    {
      try
      {

        foreach (GERO_DI di in DIS)
        {

          string sql = "INSERT INTO TDIKIMOCE ([NSITNUM], [NACTNUM]) \n";
          sql += $"VALUES ('{di.u_number}', '{di.u_external_reference}');\n" +
                 $"Select @@identity";

          using (SqlCommand cmd = new SqlCommand(sql, MozartDatabase.cnxMozart))
          {
            cmd.ExecuteScalar();
          }
        }
      }

      catch (Exception ex) 
      {
        MZUtils.displayError("SaveToBD", ex); 
      }
    }

    private static void LogInfo(string message)
    {
      ModuleData.ExecuteNonQuery($"Insert into TGERONIMMO_LOG (VLOGMSG) Values ('{message.Replace("'", "''")}')");
    }


    public class GERONIMMO_UPDATE
    {
      public string u_number { get; set; }
      public string u_action { get; set; }
      public string u_external_reference { get; set; }
      // commentaire EMALEC
      public string u_maintainer_comment { get; set; }
      public string u_planned_date { get; set; }
      public string u_effective_date_of_intervention { get; set; }
      public string u_end_date_of_intervention { get; set; }
    }

    public class GERO_DI
    {
      // number
      public string u_number { get; set; }
      // Action
      public string u_action { get; set; }
      // Ref
      public string u_external_reference { get; set; }
      // commentaire EMALEC
      public string u_maintainer_comment { get; set; }
      // Date intervention
      public string u_end_date_of_intervention { get; set; }
    }

    public class GERO_TOKEN
    {
      public string token_type { get; set; }
      public string access_token { get; set; }
      public string expires_in { get; set; }
      public string scope { get; set; }
    }

  }
}
