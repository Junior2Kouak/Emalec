using MozartLib;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace MozartCS
{
  public static class CTotalDaisyWS
  {
    //private static string mUrl = "https://totaldaisywwtest.service-now.com/api/futo/v1/contractor_interface/wm_task";
    private static string mUrl = "https://totaldaisyww.service-now.com/api/futo/v1/contractor_interface/wm_task";

    private static string mMethod = "POST";

    //private static string mAuthorization = "ZW1hbGVjLmZyLndzOlg0eUBjOWQkUHFMOHc=";
    private static string mUser = "emalec.fr.ws";
    private static string mPwd = "X4y@c9d$PqL8w";

    //string uAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes("emalec.fr.ws:X4y@c9d$PqL8w"));
    private static string mContentType = "application/json";

    // Appel du WebService DaisyWW pour l'action "get_updated_list"
    public static void getList()
    {
      HttpWebRequest httpRequest = buildHttpRequestObject();

      CDaisyWWRequest_get_updated_list lDataFlow = new CDaisyWWRequest_get_updated_list
      {
        action = "get_updated_list",
        data = new data()
      };

      string data = JsonConvert.SerializeObject(lDataFlow);

      using (StreamWriter streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
      {
        streamWriter.Write(data);
      }

      HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
      {
        string result = streamReader.ReadToEnd();

        CDaisyWWResponse_get_updated_list resultJSon = JsonConvert.DeserializeObject<CDaisyWWResult_get_updated_list>(result).result;

        // Insertion des tickets dans la base
        foreach (TaskDesc lTicket in resultJSon.data)
        {
          // Le try catch ici pour ignorer les erreurs d'insert dans la base, WORKORDER est une clé primaire
          try
          {
            string lSql = $"INSERT INTO TDITOTAL(WORKORDER, WORKORDERTASK, DDATEAJOUT) VALUES('{lTicket.wo_number}','{lTicket.number}','{DateTime.Now}')";
            MozartDatabase.ExecuteNonQuery(lSql);
          }
          catch (Exception pEx)
          {
            logToTDITotalLog(pEx.Message);
          }
        }
      }
    }

    private static void logToTDITotalLog(string pMsg)
    {
      string lSql = $"INSERT INTO TDITOTALLOG(DTDITOTALDATE, VTDITOTALMSG) VALUES('{DateTime.Now}',STRING_ESCAPE('{pMsg.Replace('\'', ' ')}', 'json'))";
      MozartDatabase.ExecuteNonQuery(lSql);
    }

    private static string getWOTNumber(string pWONumber) {
      return MozartDatabase.ExecuteScalarString($"SELECT WORKORDERTASK FROM TDITOTAL WHERE WORKORDER = '{pWONumber}'");
    }

    // Appel du WebService DaisyWW pour l'action "update_state_gti" de Daisy pour cela
    public static CDaisyWWResponse_update_state_gti declarePassageGTI(string pWONumber, DateTime pGTIDate, string pGTIComment)
    {
      getList();

      HttpWebRequest httpRequest = buildHttpRequestObject();

      CDaisyWWRequest_update_state_gti lDataFlow = new CDaisyWWRequest_update_state_gti
      {
        action = "update_state_gti"
      };
      lDataFlow.data = new CDaisyWWRequestDatas_update_state_gti()
      {
        wo_number = pWONumber,
        gti_date = ConvertToUnixTimestamp(pGTIDate).ToString(),
        gti_comment = pGTIComment
      };

      string data = JsonConvert.SerializeObject(lDataFlow);

      using (StreamWriter streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
      {
        streamWriter.Write(data);
      }

      HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
      {
        string result = streamReader.ReadToEnd();

        CDaisyWWResponse_update_state_gti resultJSon = JsonConvert.DeserializeObject<CDaisyWWResult_update_state_gti>(result).result;

        return resultJSon;
      }
    }

    // Ferme un incident : On utilise l'action "update_state" de Daisy pour cela
    public static CDaisyWWResponse_update_state close_incident(string pWONumber, DateTime pRealInterventionDate, string pNotes)
    {
      getList();

      // Récupération du WO Task number
      string lWOTNumber = getWOTNumber(pWONumber);
      if (lWOTNumber == "")
      {
        string lErreur = $"Pas de WOT Number pour le WO Number : {pWONumber}";
        logToTDITotalLog(lErreur);

        throw (new Exception(lErreur));
      }

      HttpWebRequest httpRequest = buildHttpRequestObject();

      CDaisyWWRequestDatas_close_incident lDataFlow = new CDaisyWWRequestDatas_close_incident
      {
        action = "update_state"
      };
      lDataFlow.data = new CDaisyWWRequestDatas_update_state()
      {
        wot_number = lWOTNumber,
        state = "closed",
        closure_code = "41272885dba7e454f22d14a05b961909",            // Code pour "Resolved"
        root_cause_code = "e26e5999db653f8032b7f3b31d9619b0",         // Code pour "Autres"
        type_intervention_code = "338b55e2db89bb40ebadf5461d9619f4",  // Code pour "Intervention terrain"
        type_action_code = "0e152511dba53f8032b7f3b31d961914",        // Code pour "Remplacement d'accessoire'
        real_intervention_date = ConvertToUnixTimestamp(pRealInterventionDate).ToString(), //.ToString("yyyy-MM-dd HH:mm:ss"),
        work_notes = pNotes
      };

      string data = JsonConvert.SerializeObject(lDataFlow);

      using (StreamWriter streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
      {
        streamWriter.Write(data);
      }

      HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
      {
        string result = streamReader.ReadToEnd();

        CDaisyWWResponse_update_state resultJSon = JsonConvert.DeserializeObject<CDaisyWWResult_update_state>(result).result;

        return resultJSon;
      }
    }

    // Ajoute un attachement à un incident : On utilise l'action "attachments" de Daisy pour cela
    public static CDaisyWWResponse_attachment_incident add_attachement(string pWONumber, string pFullFileName)
    {
      getList();

      // Récupération du WO Task number
      string lWOTNumber = getWOTNumber(pWONumber);
      if (lWOTNumber == "")
      {
        string lErreur = $"Pas de WOT Number pour le WO Number : {pWONumber}";
        logToTDITotalLog(lErreur);

        throw (new Exception(lErreur));
      }

      // Conversion du fichier en base64 string
      Byte[] bytes = File.ReadAllBytes(pFullFileName);
      String lFileContent = Convert.ToBase64String(bytes);

      HttpWebRequest httpRequest = buildHttpRequestObject();

      CDaisyWWRequestDatas_add_attachment lDataFlow = new CDaisyWWRequestDatas_add_attachment
      {
        action = "attachments"
      };
      lDataFlow.data = new CDaisyWWRequestDatas_attachment_incident()
      {
        operation = "add",
        wot_number = lWOTNumber,
        filename = Path.GetFileName(pFullFileName),
        categorization_value = "0",
        content = lFileContent
      };

      string data = JsonConvert.SerializeObject(lDataFlow);

      using (StreamWriter streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
      {
        streamWriter.Write(data);
      }

      HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
      using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
      {
        string result = streamReader.ReadToEnd();

        CDaisyWWResponse_attachment_incident resultJSon = JsonConvert.DeserializeObject<CDaisyWWResult_attachment_incident>(result).result;

        return resultJSon;
      }
    }

    private static DateTime ConvertFromUnixTimestamp(long timestamp)
    {
      DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
      return origin.AddSeconds(timestamp);
    }

    private static long ConvertToUnixTimestamp(DateTime date)
    {
      DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
      TimeSpan diff = date.ToUniversalTime() - origin;
      return (long) Math.Floor(diff.TotalSeconds);
    }

    private static HttpWebRequest buildHttpRequestObject()
    {
      // TODO: C'est un bouchon
      //HttpWebRequest lTestFGB = (HttpWebRequest)WebRequest.Create("http://localhost:64592/");
      //lTestFGB.Method = mMethod;
      //lTestFGB.ContentType = mContentType;
      //return lTestFGB;

      //string uAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes("emalec.fr.ws:X4y@c9d$PqL8w"));
      string uAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{mUser}:{mPwd}"));

      HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(mUrl);
      httpRequest.Method = mMethod;
      //httpRequest.Headers["Authorization"] = "Basic " + mAuthorization;
      httpRequest.Headers["Authorization"] = "Basic " + uAuth;
      httpRequest.ContentType = mContentType;

      return httpRequest;
    }
  }
}
