using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Data.SqlClient;
using MozartNet;
using MZUtils = MozartControls.Utils;
using System.ComponentModel.DataAnnotations;


namespace MozartCS
{
	class Planon
	{

		// paramètre de test
		//const string API_ID = "APISVC08";
		//const string API_SECRET = "HsZCRQzKjym14pwR8I3Li9hXnmR7oLtjt425yvYQ7AHI2UkzxLTPNH8uv4zcyYtW";
		//const string BASE_TOKEN = "https://services.samfm.net/svcplatform08/OAuth/OAuth/Token";

		// paramètre de prod
		const string API_ID = "API18A060";
		const string API_SECRET = "5fb6c5d7589ceb31ac203e1622b9e92ae8ae7b3edb81cdf7f66f3acc58bcf097e8779927f08c0e28e099d940d1c18048";
		const string BASE_TOKEN = "https://api.samfm.net/samfmbpifrance/OAuth/OAuth/Token";


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
					TOKEN Token = JsonConvert.DeserializeObject<TOKEN>(response.Content);
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


		public static bool CallUpdateTask(Uri url, RootObject body, ref string result)
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

				// Créer la requête POST
				var request = new RestRequest(Method.POST);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");
				request.AddHeader("Content-Type", "application/json");

				var failoverId = Guid.NewGuid().ToString();
				request.AddHeader("x-failoverid", failoverId);

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



		public static bool CallUpdateStatut(Uri url, OperationResponse body, ref string result)
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

				// Créer la requête POST
				var request = new RestRequest(Method.PUT);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");
				request.AddHeader("Content-Type", "application/json");

				var failoverId = Guid.NewGuid().ToString();
				request.AddHeader("x-failoverid", failoverId);

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

		public static bool CallCreateWorkOrder(Uri url, OperationResponse body, ref string result)
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

				// Créer la requête POST
				var request = new RestRequest(Method.POST);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");
				request.AddHeader("Content-Type", "application/json");

				var failoverId = Guid.NewGuid().ToString();
				request.AddHeader("x-failoverid", failoverId);

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

				// Créer la requête POST
				var request = new RestRequest(Method.POST);

				byte[] fileBytes = File.ReadAllBytes(filePath);
				string base64Content = Convert.ToBase64String(fileBytes);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");
				request.AddHeader("Content-Type", "application/json");

				// pour ajout d'image
				//var failoverId = Guid.NewGuid().ToString();
				//request.AddHeader("x-failoverid", failoverId);

				// Ajouter le fichier au corps de la requête
				// request.AddFile("images", filePath);

				// request.AlwaysMultipartFormData = true;

				request.AddParameter("filename", Path.GetFileName(filePath));
				request.AddParameter("content", base64Content);

				//Ajouter le corps de la requête(JSON)
				var body = new
				{
					filename = Path.GetFileName(filePath),
					content = base64Content
				};
				request.AddJsonBody(body);

				//// Envoyer la requête
				IRestResponse response = client.Execute(request);

				res = response?.StatusCode == HttpStatusCode.Created;

				result = $"StatusCode : {response.StatusCode}";

				if (!string.IsNullOrEmpty(response?.Content))
					result = $"{result}\r\n{response.Content}";

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

			// Token Bearer pour l'authentification
			string bearerToken = GetToken();

			if (bearerToken == "Erreur de token")
			{
				return false;
			}

			var client = new RestClient();

			// Créer la requête
			var request = new RestRequest(url, Method.GET);

			// Ajouter le token Bearer dans l'en-tête
			request.AddHeader("Authorization", $"Bearer {bearerToken}");

			// ajout des paramètres de date de recherche
			DateTime date = DateTime.Now;
			string rfc3339 = date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", System.Globalization.CultureInfo.InvariantCulture);
			string rfc3339b = date.AddHours(-1).ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", System.Globalization.CultureInfo.InvariantCulture);

			IRestResponse response = client.Execute(request);

			res = response?.StatusCode == HttpStatusCode.OK;


			if (response.StatusCode == HttpStatusCode.OK)
			{

				OperationResponse[] DIs = JsonConvert.DeserializeObject<OperationResponse[]>(response.Content);

				if (DIs.Count() > 0)
				{
					SaveToBD(DIs);
				}
			}

			return res;
		}

		public static OperationResponse GetWork(string url)
		{
			try
			{
				// récupération d'un token
				string bearerToken = GetToken();

				// Initialiser RestSharp
				var client = new RestClient();

				// Créer la requête
				var request = new RestRequest(url, Method.GET);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");

				// Envoyer la requête
				IRestResponse response = client.Execute(request);

				if (response.StatusCode == HttpStatusCode.OK)
				{
					return JsonConvert.DeserializeObject<OperationResponse>(response.Content);
				}
				else
					return null;
			}

			catch (Exception ex)
			{
				LogInfo($"Erreur dans GetTask : {ex.Message}");
				return null;
			}
		}

		public static void GetListWork(string url)
		{
			try
			{
				// récupération d'un token
				string bearerToken = GetToken();

				// Initialiser RestSharp
				var client = new RestClient();


				// Créer la requête
				var request = new RestRequest(url, Method.GET);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");
		
				// ajout des paramètres de date de recherche sur la dernière heure
				DateTime date = DateTime.Now;
				string rfc3339 = date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", System.Globalization.CultureInfo.InvariantCulture);
				string rfc3339b = date.AddHours(-1).ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", System.Globalization.CultureInfo.InvariantCulture);

				request.AddQueryParameter("beginDate", rfc3339b);
				request.AddQueryParameter("endDate", rfc3339);
				//
				// Envoyer la requête
				IRestResponse response = client.Execute(request);

				if (response.StatusCode == HttpStatusCode.OK)
				{

					OperationResponse[] DIs = JsonConvert.DeserializeObject<OperationResponse[]>(response.Content);

					if (DIs.Count() > 0)
					{
						SaveToBD(DIs);
					}
				}
			}

			catch (Exception ex)
			{
				LogInfo($"Erreur dans GetListWork : {ex.Message}");
			}
		}


		public static bool MajWordOrder(RestSharp.Method method, Uri url, int NACTNUM)
		{

			bool res = false;

			try
			{

				// Token Bearer pour l'authentification
				string bearerToken = GetToken();

				if (bearerToken == "Erreur de token")
				{
					return false;
				}

				var client = new RestClient();

				// Créer la requête
				var request = new RestRequest(url, Method.GET);

				// Ajouter le token Bearer dans l'en-tête
				request.AddHeader("Authorization", $"Bearer {bearerToken}");

				IRestResponse response = client.Execute(request);

				res = response?.StatusCode == HttpStatusCode.OK;

				if (response.StatusCode == HttpStatusCode.OK)
				{

					var operation = JsonConvert.DeserializeObject<OperationResponse>(response.Content);

					string sql = $"UPDATE TDIPLANON  SET NACTNUM={NACTNUM}, DomainId={operation.DomainId}, ActivityTypeId={operation.ActivityTypeId}," +
						$" StatusId={operation.StatusId} where VCODEOPE = '{operation.Code}'";

					ModuleData.ExecuteNonQuery(sql);
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError("MajWordOrder", ex);
			}

			return res;
		}

		private static void SaveToBD(OperationResponse[] DIS)
		{
			try
			{
				foreach (OperationResponse di in DIS)
				{

					// traitement de recherche pour déterminer si on a déjà cette demande
					if (!ExisteDeja(di.Id))
					{

						string sql = "INSERT INTO TDIPLANON (NIDOPE, VCODEOPE, Label ) \n";
						sql += $"VALUES ({di.Id},'{di.Code}','{di.Label.Replace("'", "''")}')";

						ModuleData.ExecuteNonQuery(sql);
					}
				}
			}
			catch (Exception ex)
			{
				MZUtils.displayError("SaveToBD", ex);
			}
		}

		private static bool ExisteDeja(int number)
		{

			bool res;

			string sql = $"Select count(ID) from TDIPLANON  where NIDOPE = {number}";

			int count = (int)ModuleData.ExecuteScalarInt(sql);
			res = count == 0 ? false : true;

			return res;
		}


		private static void LogInfo(string message)
		{
			ModuleData.ExecuteNonQuery($"Insert into TPLANON_LOG (VLOGMSG) Values ('{message.Replace("'", "''")}')");
		}

		public class RootObject
		{
			public DateTime beginDate { get; set; }
			public DateTime endDate { get; set; }
			public double duration { get; set; }
			public string comment { get; set; }
			public int operatorId { get; set; }
			public bool workFinished { get; set; }
			public List<Furniture> furnitures { get; set; }
			public List<MiscCost> miscCosts { get; set; }
		}

		public class Furniture
		{
			public int productId { get; set; }
			public int storeId { get; set; }
			public double realQuantity { get; set; }
			public double coefficientApplied { get; set; }
			public string comment { get; set; }
		}

		public class MiscCost
		{
			public string title { get; set; }
			public double estimatedAmount { get; set; }
			public double realAmount { get; set; }
			public string comment { get; set; }
		}

		public class TOKEN
		{
			public string token_type { get; set; }
			public string access_token { get; set; }
			public string expires_in { get; set; }
			public string scope { get; set; }
		}


		//public class OperationBody
		//{
		//	// Required fields
		//	[Required]
		//	[StringLength(40)]
		//	public string Label { get; set; }
		//	[Required]
		//	public int DomainId { get; set; }
		//	[Required]
		//	public int ActivityTypeId { get; set; }
		//	// Optional fields
		//	[StringLength(10)]
		//	[RegularExpression("^[A-Z0-9_]+$")]
		//	public string Code { get; set; }
		//	public string Detail { get; set; }
		//	public string SpecificInstruction { get; set; }
		//	[DataType(DataType.DateTime)]
		//	public DateTime? ExpectedBeginDate { get; set; }
		//	[DataType(DataType.DateTime)]
		//	public DateTime? ExpectedEndDate { get; set; }
		//	public double? ExpectedDuration { get; set; }
		//	public int? StatusId { get; set; }
		//	public int? OperatorId { get; set; }
		//	public int? ParentOperationId { get; set; }
		//	public int? PreventiveId { get; set; }
		//	public int? TaskId { get; set; }
		//	public int? Origin { get; set; }
		//	public int? EquipmentId { get; set; }
		//	public int? CriticalityId { get; set; }
		//	public int? SiteId { get; set; }
		//	public int? BuildingId { get; set; }
		//	public int? ZoneId { get; set; }
		//	public int? SpaceId { get; set; }
		//	public int? RequestorId { get; set; }
		//	public int? SupervisorId { get; set; }
		//	public int? WorkTeamId { get; set; }
		//	public Dictionary<string, string> Attributes { get; set; }
		//}

		public class OperationResponse
		{
			public int Id { get; set; }
			public string Code { get; set; }
			public string Label { get; set; }
			public string Detail { get; set; }
			public string SpecificInstruction { get; set; }
			public DateTime? ExpectedBeginDate { get; set; }
			public DateTime? ExpectedEndDate { get; set; }
			public double? ExpectedDuration { get; set; }
			public int StatusId { get; set; }
			public int? OperatorId { get; set; }
			public int? ParentOperationId { get; set; }
			public int? PreventiveId { get; set; }
			public int? TaskId { get; set; }
			public int? Origin { get; set; }
			public int? EquipmentId { get; set; }
			public int? ActivityTypeId { get; set; }
			public int? CriticalityId { get; set; }
			public int? DomainId { get; set; }
			public int? SiteId { get; set; }
			public int? BuildingId { get; set; }
			public int? ZoneId { get; set; }
			public int? SpaceId { get; set; }
			public int? RequestorId { get; set; }
			public int? SupervisorId { get; set; }
			public int? WorkTeamId { get; set; }
		//	public Dictionary<string, string> Attributes { get; set; }
			public string RegisteredBy { get; set; }
			public DateTime? LastUpdated { get; set; }
			public string LastUpdatedBy { get; set; }
			public DateTime? CreationDate { get; set; }
			public DateTime? AcknowledgedDate { get; set; }
			public string AcknowledgedBy { get; set; }
			public string ReportSummary { get; set; }
			public DateTime? RealizedBeginDate { get; set; }
			public DateTime? RealizedEndDate { get; set; }
			public DateTime? FirstPlanificationBeginDate { get; set; }
			public DateTime? FirstPlanificationEndDate { get; set; }
			public DateTime? MaxAllowedTimeToAcknowledge { get; set; }
			public DateTime? MaxAllowedTimeToBegin { get; set; }
			public DateTime? MaxAllowedTimeToFinish { get; set; }
			public int? FollowUpCount { get; set; }
			public int? Rating { get; set; }
		}

		// statuts PLANON
		//{ "id":1,"code":"IN","label":"Inscrit","order":100,"default":true}
		//{ "id":2,"code":"PR","label":"Programmé","order":200,"default":true}
		//{ "id":3,"code":"EC","label":"En cours","order":300,"default":true}
		//{ "id":4,"code":"TE","label":"Terminé","order":400,"default":true}
		//{ "id":5,"code":"AR","label":"Archivé Réalisé","order":500,"default":true}
		//{ "id":6,"code":"AN","label":"Annulé","order":490,"default":true}
		//{ "id":7,"code":"AA","label":"Archivé Annulé","order":590,"default":true}
		//{ "id":8,"code":"T+","label":"Terminé+","order":410,"default":true}
		//{ "id":9,"code":"ED","label":"Devis en cours","order":310,"default":false}
		//{ "id":10,"code":"AP","label":"Attente Pièces","order":320,"default":false}]
		//{ "id":11,"code":"DF","label":"Devis à faire","order":330,"default":false}]
		//{ "id":12,"code":"DD","label":"Devis déposé","order":340,"default":false}]

		// Domaines PLANON
		//{ "id":30,"code":"H.C","label":"TRAVAUX HORS CONTRAT"}
		//{ "id":33,"code":"C.FA","label":"Prestations courants faibles"}
		//{ "id":34,"code":"SECU-I","label":"Sécurité Incendie"}
		//{ "id":35,"code":"SECU-P","label":"Sécurité personne"}
		//{ "id":36,"code":"CVC","label":"Chauf- Venti- Clima"}
		//{ "id":37,"code":"PLO","label":"Installation plomberie"}
		//{ "id":38,"code":"CFORT","label":"Installation courant fort"}
		//{ "id":39,"code":"CFA","label":"Installation courant faible"}
		//{ "id":40,"code":"CTR","label":"Contrôle reglementaire"}
		//{ "id":41,"code":"TCE","label":"Tous corps d'état"}
		//{ "id":42,"code":"SERV","label":"Service"}
		//{ "id":43,"code":"LEVA","label":"Installation levage"}
		//{ "id":44,"code":"PAUT","label":"Porte automatique"}
		//{ "id":45,"code":"GEST","label":"Pilotage gestion"}
		//{ "id":46,"code":"RIE","label":"Equipement cuisine"}
		//{ "id":47,"code":"MOB","label":"Mobilier"}]


		// Activitées PLANON
		//{ "id":1,"code":"PS","label":"Préventif systématique","activity":2}
		//{ "id":2,"code":"PC","label":"Préventif conditionnel","activity":2}
		//{ "id":3,"code":"CO","label":"Correctif","activity":1}
		//{ "id":4,"code":"TU","label":"Tournée","activity":0}
		//{ "id":5,"code":"CU","label":"Correctif URGENT","activity":1}
		//{ "id":6,"code":"TN","label":"Travaux neufs","activity":0}
		//{ "id":7,"code":"TH","label":"Travaux hors contrat","activity":0}
		//{ "id":8,"code":"DP","label":"Dépannage","activity":1}
		//{ "id":9,"code":"AT","label":"Assistance Technique","activity":0}
		//{ "id":10,"code":"SE","label":"Service","activity":2}
		//{ "id":11,"code":"AS","label":"ASTREINTE","activity":0}
		//{ "id":12,"code":"CR","label":"Contrôle réglementaire","activity":2}
		//{ "id":13,"code":"ME","label":"Relevée de compteur","activity":0}
		//{ "id":14,"code":"LR","label":"Levées de reserves","activity":1}
		//{ "id":15,"code":"VS","label":"Visite de sites","activity":0}
		//{ "id":16,"code":"RV","label":"Reserves visites sites","activity":0}
		//{ "id":17,"code":"PA","label":"Plan d'Action","activity":0}
		//{ "id":18,"code":"LA","label":"Levées des Actions","activity":1}]

	}
}
