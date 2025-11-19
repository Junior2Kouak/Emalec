using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PictureDirect.WCF
{
  public class Database
  {
    public static int VerifLogin(int numUser, string username, string password)
    {
      int res = 1;
      SqlDataReader dr = null;

      try
      {
        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
        {
          connection.Open();
          SqlCommand cmd = new SqlCommand($"api_sp_www_VerifLoginTech {numUser},'{username}','{password}'", connection);
          dr = cmd.ExecuteReader();

          while (dr.Read())
            res = dr.GetInt32(dr.GetOrdinal("LOGIN")) == 0 ? 1 : 0;// Retourne 0 en cas d'erreur

          dr.Close();
        }
      }
      catch (Exception ex)
      {
        throw;
      }

      return res;
    }

    public static List<DemandeContract> GetDemandes(int numUser, DateTime fromDate, DateTime toDate)
    {
      List<DemandeContract> res = new List<DemandeContract>();
      SqlDataReader dr = null;

      try
      {
        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
        {
          connection.Open();
          SqlCommand cmd = new SqlCommand($"api_smart_GetDiAction {numUser},'{fromDate.ToShortDateString()}','{toDate.ToShortDateString()}'", connection);
          dr = cmd.ExecuteReader();

          int? demandeIdColumnIndex = null;
          int? actionIdColumnIndex = null;
          int? clientNameColumnIndex = null;
          int? siteNameColumnIndex = null;
          int? descriptionColumnIndex = null;

          Dictionary<DemandeContract, List<ActionContract>> actions = new Dictionary<DemandeContract, List<ActionContract>>();

          while (dr.Read())
          {
            if (demandeIdColumnIndex == null)
              demandeIdColumnIndex = dr.GetOrdinal("NDINNUM");

            if (actionIdColumnIndex == null)
              actionIdColumnIndex = dr.GetOrdinal("NACTNUM");

            if (clientNameColumnIndex == null)
              clientNameColumnIndex = dr.GetOrdinal("VCLINOM");

            if (siteNameColumnIndex == null)
              siteNameColumnIndex = dr.GetOrdinal("VSITNOM");

            if (descriptionColumnIndex == null)
              descriptionColumnIndex = dr.GetOrdinal("VACTDES");

            int demandeId = dr.GetInt32(demandeIdColumnIndex.Value);
            string demandeName = $"{dr.GetString(clientNameColumnIndex.Value)} - {dr.GetString(siteNameColumnIndex.Value)}";

            DemandeContract demande = new DemandeContract() { Id = demandeId, Name = demandeName };
            ActionContract action = new ActionContract() { Id = dr.GetInt32(actionIdColumnIndex.Value), Name = dr.GetString(descriptionColumnIndex.Value)?.Substring(0, Math.Min(50, (dr.GetString(descriptionColumnIndex.Value)?.Length ?? 0))) };

            if (actions.ContainsKey(demande))
              actions[demande].Add(action);
            else
              actions.Add(demande, new List<ActionContract>() { action });
          }

          res = actions.Select(x => new DemandeContract() { Id = x.Key.Id, Name = x.Key.Name, Actions = x.Value }).ToList();

          dr.Close();
        }
      }
      catch (Exception ex)
      {
        throw;
      }

      return res;
    }

    public static string GetFolderPath(int numUser)
    {
      string res = null;

      try
      {
        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
        {
          connection.Open();

          SqlCommand cmd = new SqlCommand($"SELECT TOP 1 VPARVAL FROM TPAR WHERE vparlib = 'REP_PHOTOS_ACT' and vsociete = (select VSOCIETE from TPER Where NPERNUM = {numUser})", connection);
          res = cmd.ExecuteScalar()?.ToString();
        }
      }
      catch (Exception ex)
      {
        throw;
      }

      return res;
    }

    public static int AddPicture(int numUser, int actionId, string fileName, string pictureDescription)
    {
      int res = 1;
      SqlDataReader dr = null;

      try
      {
        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
        {
          connection.Open();

          SqlCommand cmd = new SqlCommand($"api_smart_AddPhotoToDiAction {numUser},{actionId},'{fileName.Replace("'","''")}', '{pictureDescription.Replace("'", "''")}'", connection);
          dr = cmd.ExecuteReader();

          dr.Close();
        }
      }
      catch (Exception ex)
      {
        throw;
      }

      return res;
    }
  }
}