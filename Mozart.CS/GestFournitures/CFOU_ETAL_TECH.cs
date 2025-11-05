using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MozartNet;
using MozartLib;

namespace MozartCS
{
    public class CFOU_ETAL_TECH
    {
        public int NID_FOU_ETAL_TECH;
        public int NFOUNUM;
        public decimal? NMAXVALUE;
        public decimal? NMINVALUE;

        public CFOU_ETAL_TECH(int p_NFOUNUM)
        {
            using (SqlCommand cmd = new SqlCommand("[api_sp_Fourniture_Etalonnage_Tolerance_Load]", MozartDatabase.cnxMozart))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);

                cmd.Parameters["@NFOUNUM"].Value = p_NFOUNUM;

                SqlDataReader sqldr = cmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    sqldr.Read();
                    NID_FOU_ETAL_TECH = (int)sqldr["NID_FOU_ETAL_TECH"];
                    NFOUNUM = (int)sqldr["NFOUNUM"];
                    NMAXVALUE = Convert.ToDecimal(sqldr["NMAXVALUE"]);
                    NMINVALUE = Convert.ToDecimal(sqldr["NMINVALUE"]);
                }
                else
                {
                    NID_FOU_ETAL_TECH = 0;
                    NFOUNUM = 0;
                    NMAXVALUE = null;
                    NMINVALUE = null;
                }
                sqldr.Close();

            }
        }

        //private void Load(int p_NFOUNUM_load)
        //{
        //    using (SqlCommand cmd = new SqlCommand("[api_sp_Fourniture_Etalonnage_Tolerance_Load]", MozartDatabase.cnxMozart))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlCommandBuilder.DeriveParameters(cmd);

        //        cmd.Parameters["@NFOUNUM"].Value = p_NFOUNUM_load;

        //        SqlDataReader sqldr = cmd.ExecuteReader();
        //        if (sqldr.HasRows)
        //        {
        //            sqldr.Read();
        //            NID_FOU_ETAL_TECH = (int)sqldr["NID_FOU_ETAL_TECH"];
        //            NFOUNUM = (int)sqldr["NFOUNUM"];
        //            NMAXVALUE = (decimal)sqldr["NMINVALUE"];
        //            NMINVALUE = (decimal)sqldr["NMAXVALUE"];
        //        }
        //        else
        //        {
        //            NID_FOU_ETAL_TECH = 0;
        //            NFOUNUM = 0;
        //            NMAXVALUE = null;
        //            NMINVALUE = null;
        //        }
        //        sqldr.Close();

        //    }
        //}

        public void Save()
        {
            using (SqlCommand cmd = new SqlCommand("[api_sp_Fourniture_Etalonnage_Tolerance_Save]", MozartDatabase.cnxMozart))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);

                cmd.Parameters["@NID_FOU_ETAL_TECH"].Value = NID_FOU_ETAL_TECH;
                cmd.Parameters["@NFOUNUM"].Value = NFOUNUM;
                cmd.Parameters["@NMINVALUE"].Value = NMINVALUE;
                cmd.Parameters["@NMAXVALUE"].Value = NMAXVALUE;  

                cmd.ExecuteNonQuery();

                NID_FOU_ETAL_TECH = Convert.ToInt32(cmd.Parameters["@NID_FOU_ETAL_TECH"].Value);
            }
        }

        public void Delete()
        {
            using (SqlCommand cmd = new SqlCommand("[api_sp_Fourniture_Etalonnage_Tolerance_Delete]", MozartDatabase.cnxMozart))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);

                cmd.Parameters["@NID_FOU_ETAL_TECH"].Value = NID_FOU_ETAL_TECH;              

                cmd.ExecuteNonQuery();

                NID_FOU_ETAL_TECH = 0;
                NFOUNUM = 0;
                NMAXVALUE = null;
                NMINVALUE = null;
            }
        }

    }
}
