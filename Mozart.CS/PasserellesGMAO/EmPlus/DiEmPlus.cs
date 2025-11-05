using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MozartCS
{
    public class DiEmPlus
    {

        private static string CreateDigest(string verb, Uri url, string secret, string timestamp)
        {
            //string s = $"{verb.ToUpper()}+{url.AbsolutePath.ToLower()}+{timestamp}";
            //byte[] digest = new System.Security.Cryptography.HMACSHA256(UTF8Encoding.UTF8.GetBytes(secret)).ComputeHash(UTF8Encoding.UTF8.GetBytes(s));

            //return Convert.ToBase64String(digest);
            string s = $"{verb.ToUpper()}+{url.AbsolutePath.ToLower()}+{timestamp}";

            using (var hmacsha256 = new System.Security.Cryptography.HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                return Convert.ToBase64String(hashmessage);
            }
        }

        private static bool CallApi(string apiToken, string apiSecret, RestSharp.Method method, Uri url, string body, ref string result)
        {
            bool res = false;

            try
            {
                string timestamp = DateTime.UtcNow.ToString("s");

                RestSharp.RestClient client = new RestSharp.RestClient();
                RestSharp.RestRequest request = new RestSharp.RestRequest(url, method);
                request.AddHeader("X-Timestamp", timestamp);
                request.AddHeader("Authorization", $"TCN {apiToken}:{CreateDigest(method.ToString(), url, apiSecret, timestamp)}");
                request.AddParameter("application/json", body, RestSharp.ParameterType.RequestBody);

                RestSharp.IRestResponse response = client.Execute(request);
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

        private static bool CallApi(string apiToken, string apiSecret, RestSharp.Method method, Uri url, FileInfo fileInfo, byte[] content, ref string result)
        {
            bool res = false;

            try
            {
                string timestamp = DateTime.UtcNow.ToString("s");

                var webRequest = WebRequest.CreateHttp(url);
                webRequest.Method = method.ToString();
                webRequest.Headers.Add("X-Timestamp", timestamp);
                webRequest.Headers.Add("Authorization", $"TCN {apiToken}:{CreateDigest(method.ToString(), url, apiSecret, timestamp)}");

                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(content, 0, content.Length);
                }

                using (HttpWebResponse wr = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (Stream response = wr.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(response);
                        result = reader.ReadToEnd();
                    }
                }

                res = true;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return res;
        }

        public static bool AddNote(string apiToken, string apiSecret, string baseUrl, string identifier, string tenant, AddNoteBody addNoteBody, ref string result)
        {
            Uri url = new Uri($"{baseUrl}/rest/task/{tenant}/{identifier}/notes");
            return CallApi(apiToken, apiSecret, RestSharp.Method.POST, url, Newtonsoft.Json.JsonConvert.SerializeObject(addNoteBody), ref result);
        }

        public static bool ChangeStatus(string apiToken, string apiSecret, string baseUrl, string identifier, string tenant, ChangeStatusBody changeStatusBody, ref string result)
        {
            Uri url = new Uri($"{baseUrl}/rest/task/{tenant}/{identifier}/status");
            return CallApi(apiToken, apiSecret, RestSharp.Method.PUT, url, Newtonsoft.Json.JsonConvert.SerializeObject(changeStatusBody), ref result);
        }

    public static bool UploadDocument(string apiToken, string apiSecret, string baseUrl, string identifier, string tenant, FileInfo fileInfo, byte[] fileContent, string mimeType, ref string result)
    {
        bool res = false;
        string sFileName = DateTime.Now.ToString("yyyyddmmhhmmssf") + fileInfo.Extension;

        Uri url = new Uri($"{baseUrl}/rest/documents/{tenant}/task/{identifier}");
        res = CallApi(apiToken, apiSecret, RestSharp.Method.POST, url, Newtonsoft.Json.JsonConvert.SerializeObject(new UploadDocumentMetadaBody() { Filename = sFileName, MimeType = mimeType, ByteSize = fileContent.Length, DocumentCategories = new[] { "General" } }), ref result);
        if (res)
        {
            UploadDocumentMetadaResponse uploadDocumentMetadaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<UploadDocumentMetadaResponse>(result);

            if (uploadDocumentMetadaResponse?.DocumentIdentifier != null)
            {
                url = new Uri($"{baseUrl}/rest/documents/{tenant}/{uploadDocumentMetadaResponse.DocumentIdentifier}");
                res = CallApi(apiToken, apiSecret, RestSharp.Method.POST, url, fileInfo, fileContent, ref result);
            }
        }

        return res;
    }

        public static bool AddQuote(string apiToken, string apiSecret, string baseUrl, string identifier, string tenant, decimal amount, FileInfo fileInfo, byte[] fileContent, string mimeType, ref string result)
        {
            bool res = false;

            Uri url = new Uri($"{baseUrl}/rest/task/{tenant}/{identifier}/quote");
            AddQuoteBody addQuoteBody = new AddQuoteBody() { AmountNet = amount, FileMetadata = new FileMetadata() { Filename = fileInfo.Name, ByteSize = fileContent.Length, MimeType = mimeType }, Notes = "" };

            res = CallApi(apiToken, apiSecret, RestSharp.Method.POST, url, Newtonsoft.Json.JsonConvert.SerializeObject(addQuoteBody), ref result);
            if (res)
            {
                UploadDocumentMetadaResponse uploadDocumentMetadaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<UploadDocumentMetadaResponse>(result);

                url = new Uri($"{baseUrl}/rest/documents/{tenant}/{uploadDocumentMetadaResponse.DocumentIdentifier}");
                res = CallApi(apiToken, apiSecret, RestSharp.Method.POST, url, fileInfo, fileContent, ref result);
            }

            return res;
        }

        public class AddNoteBody
        {
            public string Note { get; set; }
        }

        public class ChangeStatusBody
        {
            public string StatusName { get; set; }

            public string StatusChangeDateTimeUtc { get; set; }

            public object[] TaskCompliance { get; set; }

            public object AssetDowntime { get; set; }
        }

        public class UploadDocumentMetadaBody
        {
            public string Filename { get; set; }

            public string MimeType { get; set; }

            public int ByteSize { get; set; }

            public string[] DocumentCategories { get; set; }
        }

        public class UploadDocumentMetadaResponse
        {
            public string DocumentIdentifier { get; set; }

            public object[] Messages { get; set; }
        }

        public class AddQuoteBody
        {
            public decimal AmountNet { get; set; }

            public string Notes { get; set; }

            public FileMetadata FileMetadata { get; set; }

        }

        public class FileMetadata
        {
            public string Filename { get; set; }

            public int ByteSize { get; set; }

            public string MimeType { get; set; }

        }
    }
}
