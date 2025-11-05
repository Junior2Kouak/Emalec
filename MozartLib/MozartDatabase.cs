using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartLib
{
  public class MozartDatabase
  {
    public static string DATABASE_MULTI = "MULTI";

    public static SqlConnection cnxMozart = new SqlConnection();

    public static void initConnection(string pNomServeur, string pNomSociete)
    {
      if (cnxMozart == null)
      {
        cnxMozart = new SqlConnection();
      }

      if (cnxMozart.State != ConnectionState.Open)
      {
        MozartParams.NomServeur = pNomServeur.ToUpper();
        MozartParams.NomSociete = pNomSociete;

        cnxMozart.ConnectionString = $"Data Source={pNomServeur};Database={DATABASE_MULTI};MultipleActiveResultSets=True;trusted_connection=true;APP={pNomSociete}";
        cnxMozart.Open();

        // TODO : Ici, il faudrait charger tous les chemins nécessaires à terme
        MozartParams.CheminMozart = MozartParams.RechercheParam("REP_MOZART", pNomSociete);
      }
    }

    public static SqlDataReader ExecuteReader(string sSql, int pTimeout)
    {
      using (SqlCommand cmd = new SqlCommand(sSql, cnxMozart)
      {
        CommandTimeout = pTimeout
      })
      {
        return cmd.ExecuteReader();
      }
    }

    public static SqlDataReader ExecuteReader(string sSql)
    {
      return ExecuteReader(sSql, 30);
    }

    public static string ExecuteScalarString(string sSql)
    {
      return ExecuteScalarString(sSql, null);
    }

    public static string ExecuteScalarString(string sSql, SqlConnection pCnx)
    {
      if (pCnx != null)
      {
        cnxMozart = pCnx;
      }

      using (SqlCommand cmd = new SqlCommand(sSql, cnxMozart))
      {
        object o = cmd.ExecuteScalar();
        if (o == null)
        {
          return "";
        }

        return o.ToString();
      }
    }

    public static int ExecuteScalarInt(string sSql)
    {
      try
      {
        string lRetValue = ExecuteScalarString(sSql);

        return Convert.ToInt32(lRetValue);
      }
      catch (Exception)
      {
        return 0;
      }
    }

    public static int ExecuteScalarInt(string sSql, SqlParameter[] pListParameters)
    {
        try
        {

                using (SqlCommand cmd = new SqlCommand(sSql, cnxMozart)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 90
                })
                {
                    if (pListParameters != null)
                    {
                        cmd.Parameters.AddRange(pListParameters);
                    }
                    object o = cmd.ExecuteScalar();
                    if (o == null)
                    {
                        return -1;
                    }
                    else
                    {
                        return Convert.ToInt32(o);
                    }
                }
            
        }
        catch (Exception)
        {
            return -1;
        }
    }

        public static void ExecuteNonQuery(string sSql)
    {
      using (SqlCommand cmd = new SqlCommand(sSql, cnxMozart))
      {
        cmd.CommandTimeout = 90;
        cmd.ExecuteNonQuery();
      }
    }

    public static void ExecuteNonQuery(string sSql, SqlParameter[] pListParameters)
    {
      using (SqlCommand cmd = new SqlCommand(sSql, cnxMozart)
      {
        CommandType = CommandType.StoredProcedure,
        CommandTimeout = 90
      })
      {
        if (pListParameters != null)
        {
          cmd.Parameters.AddRange(pListParameters);
        }
        cmd.ExecuteNonQuery();
      }
    }

    public static DataTable GetDataTable(string sRequete)
    {
      DataTable lRetValue = new DataTable();

      try
      {
        SqlDataReader lSDR = ExecuteReader(sRequete, 0);
        lRetValue.Load(lSDR);
       
        return lRetValue;
      }
      catch (Exception ex)
      {
        // TODO : Voir si il faut vraiment afficher une messageBox en cas d'erreur
        MessageBox.Show($"MozartDatabase - GetDataTable : {ex.Message}", "Erreur");
        
        return lRetValue;
      }
    }
  }
}
