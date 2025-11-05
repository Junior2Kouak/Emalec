using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartCS
{
	class CCONTRATCLI_DETAIL
	{

		public int NIDCONTRATCLI_DETAIL;
		public int NCLINUM;
		public int NTYPECONTRAT;
		public int NIDCONTRAT_TYPEDOC;
		public string VNOMDOCUMENT;
		public DateTime? DDATE_DOCUMENT;
		public string VFILE_DOCUMENT;
		public DateTime? DDATE_DEBUT;
		public DateTime? DDATE_FIN;
		public bool BCONTRATCLI_TACITE;
		public int NIDFORMULE_REV;
		public string VOBS_DOC;
		public string VOBS_REMISE;
		public string VOBS_MANUEL;
		public DateTime? DLAST_APPLICATION;
		public string VHISTO_LAST_APPLICATION;
		public decimal? PC_CUR;
		public decimal? PC_PREV;
		public decimal? PC_BPU;
		public string VHISTO_PC_CUR;
		public string VHISTO_PC_PREV;
		public string VHISTO_PC_BPU;
		public DateTime? DNEXT_APPLICATION;
		public string VHISTO_NEXT_APPLICATION;
		public bool BACTIF;
		public bool BREMISE_AUCUNE;
		public int NIDCONTRATCLI_DETAIL_AVENANT;
		public bool bNewDocument;
		public string sPathAndFileNameNewDoc;
		public bool bNoDoc;
		public string VOBS_CONTRAT;

		public DataTable dtComptes;
		public DataTable dtPays;
		public DataTable dtSites;
		public DataTable dtTypeDocument;
		public DataTable dtContratAvenant;
		public DataTable dtFormuleRev;

		public List<Object> LstComptesSelected;
		public List<Object> LstPaysSelected;
		public List<Object> LstSitesSelected;

		public string RepertoireDoc;

		public CCONTRATCLI_DETAIL(int C_NIDCONTRATCLI_DETAIL, int P_NCLINUM)
		{
			NIDCONTRATCLI_DETAIL = C_NIDCONTRATCLI_DETAIL;
			NCLINUM = P_NCLINUM;
			Load();
		}

		public void Load()
		{

			//init
			RepertoireDoc = Utils.RechercheParam("REP_INFO");
			sPathAndFileNameNewDoc = "";

			string sSQL = $"EXEC [api_sp_ContratClient_Detail_Load] {NIDCONTRATCLI_DETAIL}, {NCLINUM}";

			using (SqlDataReader sdr = ModuleData.ExecuteReader(sSQL))
			{
				if (sdr.Read())
				{
					NCLINUM = (int)Utils.ZeroIfNull(sdr["NCLINUM"]);
					NTYPECONTRAT = (int)Utils.ZeroIfNull(sdr["NTYPECONTRAT"]);
					NIDCONTRAT_TYPEDOC = (int)Utils.ZeroIfNull(sdr["NIDCONTRAT_TYPEDOC"]);
					VNOMDOCUMENT = (string)Utils.BlankIfNull(sdr["VNOMDOCUMENT"]);
					if (Utils.BlankIfNull(sdr["DDATE_DOCUMENT"]) == "") { DDATE_DOCUMENT = null; } else { DDATE_DOCUMENT = (DateTime)sdr["DDATE_DOCUMENT"]; }
					VFILE_DOCUMENT = (string)Utils.BlankIfNull(sdr["VFILE_DOCUMENT"]);
					if (Utils.BlankIfNull(sdr["DDATE_DEBUT"]) == "") { DDATE_DEBUT = null; } else { DDATE_DEBUT = (DateTime)sdr["DDATE_DEBUT"]; }
					if (Utils.BlankIfNull(sdr["DDATE_FIN"]) == "") { DDATE_FIN = null; } else { DDATE_FIN = (DateTime)sdr["DDATE_FIN"]; }
					if (Utils.BlankIfNull(sdr["BCONTRATCLI_TACITE"]) == "") { BCONTRATCLI_TACITE = false; } else { BCONTRATCLI_TACITE = (bool)sdr["BCONTRATCLI_TACITE"]; }
					NIDFORMULE_REV = (int)Utils.ZeroIfNull(sdr["NIDFORMULE_REV"]);
					VOBS_DOC = (string)Utils.BlankIfNull(sdr["VOBS_DOC"]);
					VOBS_REMISE = (string)Utils.BlankIfNull(sdr["VOBS_REMISE"]);
					if (Utils.BlankIfNull(sdr["BREMISE_AUCUNE"]) == "") { BREMISE_AUCUNE = false; } else { BREMISE_AUCUNE = (bool)sdr["BREMISE_AUCUNE"]; }
					VOBS_MANUEL = (string)Utils.BlankIfNull(sdr["VOBS_MANUEL"]);
					VOBS_CONTRAT = (string)Utils.BlankIfNull(sdr["VOBS_CONTRAT"]);
					if (Utils.BlankIfNull(sdr["DLAST_APPLICATION"]) == "") { DLAST_APPLICATION = null; } else { DLAST_APPLICATION = (DateTime)sdr["DLAST_APPLICATION"]; }
					VHISTO_LAST_APPLICATION = (string)Utils.BlankIfNull(sdr["VHISTO_LAST_APPLICATION"]);
					if (Utils.BlankIfNull(sdr["PC_CUR"]) == "") { PC_CUR = null; } else { PC_CUR = (decimal)sdr["PC_CUR"]; }
					if (Utils.BlankIfNull(sdr["PC_PREV"]) == "") { PC_PREV = null; } else { PC_PREV = (decimal)sdr["PC_PREV"]; }
					if (Utils.BlankIfNull(sdr["PC_BPU"]) == "") { PC_BPU = null; } else { PC_BPU = (decimal)sdr["PC_BPU"]; }
					VHISTO_PC_CUR = (string)Utils.BlankIfNull(sdr["VHISTO_PC_CUR"]);
					VHISTO_PC_PREV = (string)Utils.BlankIfNull(sdr["VHISTO_PC_PREV"]);
					VHISTO_PC_BPU = (string)Utils.BlankIfNull(sdr["VHISTO_PC_BPU"]);
					if (Utils.BlankIfNull(sdr["DNEXT_APPLICATION"]) == "") { DNEXT_APPLICATION = null; } else { DNEXT_APPLICATION = (DateTime)sdr["DNEXT_APPLICATION"]; }
					VHISTO_NEXT_APPLICATION = (string)Utils.BlankIfNull(sdr["VHISTO_NEXT_APPLICATION"]);
					if (Utils.BlankIfNull(sdr["BACTIF"]) == "") { BACTIF = true; } else { BACTIF = (bool)sdr["BACTIF"]; }
					NIDCONTRATCLI_DETAIL_AVENANT = (int)Utils.ZeroIfNull(sdr["NIDCONTRATCLI_DETAIL_AVENANT"]);
					bNewDocument = false;
					bNoDoc = (bool)(Utils.ZeroIfNull(sdr["BNODOC"]) == 0 ? false : (bool)sdr["BNODOC"]);
				}
			}


			//load comtpes      
			dtComptes = new DataTable();
			dtComptes.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Cbo_ListeComptesAnaByClientToGestContrat] {NIDCONTRATCLI_DETAIL}, {NCLINUM}, '{MozartLib.MozartParams.NomSociete.Replace("'", "''")}'"));
			LstComptesSelected = new List<Object>();
			if (dtComptes.Select("[BSELECTED] = 1").Count() > 0)
			{
				foreach (DataRow dr in dtComptes.Select("[BSELECTED] = 1").CopyToDataTable().Rows)
				{
					LstComptesSelected.Add((Int32)dr["NCANNUM"]);
				}
			}

			//load pays           
			dtPays = new DataTable();
			dtPays.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Cbo_ListePaysByClientToGestContrat] {NIDCONTRATCLI_DETAIL}"));
			LstPaysSelected = new List<Object>();
			if (dtPays.Select("[BSELECTED] = 1").Count() > 0)
			{
				foreach (DataRow dr in dtPays.Select("[BSELECTED] = 1").CopyToDataTable().Rows)
				{
					LstPaysSelected.Add((Int32)dr["NPAYSNUM"]);
				}
			}

			//load sites      
			dtSites = new DataTable();
			dtSites.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Cbo_ListeSitesByClientToGestContrat] {NIDCONTRATCLI_DETAIL}, {NCLINUM}"));
			LstSitesSelected = new List<Object>();
			if (dtSites.Select("[BSELECTED] = 1").Count() > 0)
			{
				foreach (DataRow dr in dtSites.Select("[BSELECTED] = 1").CopyToDataTable().Rows)
				{
					LstSitesSelected.Add((Int32)dr["NSITNUM"]);
				}
			}

			//Type document
			dtTypeDocument = new DataTable();
			dtTypeDocument.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Cbo_ListeTypeDocumentByClientToGestContrat] {NIDCONTRATCLI_DETAIL}"));

			//contrat
			dtContratAvenant = new DataTable();
			//dtContratAvenant.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Cbo_ListeContratByClientToGestContrat] {NIDCONTRATCLI_DETAIL}, {NCLINUM}"));
			dtContratAvenant.Load(ModuleData.ExecuteReader($"EXEC [api_sp_ContratClient_Detail_ListeInCombo] {NCLINUM}, {NIDCONTRATCLI_DETAIL}"));

			////Formule revision
			dtFormuleRev = new DataTable();
			dtFormuleRev.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Cbo_ListeFormuleRevByClientToGestContrat] {NIDCONTRATCLI_DETAIL}"));

		}

		public void UpdateFileDocContrat(string p_FileName_new, string p_PathAndFileName_old, string p_sPath_dest)
		{

			string NewFileName;

			if (p_FileName_new == "")
			{
				NewFileName = "";
			}
			else
			{
				NewFileName = $"CONTRAT_{NIDCONTRATCLI_DETAIL}_{System.IO.Path.GetFileName(p_FileName_new)}";
			}

			//on supprime l'ancien document
			//if (System.IO.File.Exists(p_PathAndFileName_old)) System.IO.File.Delete(p_PathAndFileName_old);
			if (CImpersonation.FileExistImpersonated(p_PathAndFileName_old))
			{
				CImpersonation.DeleteFileImpersonated(p_PathAndFileName_old);
			}



			//on copie le fichier avant de save son nom en bdd
			if (p_FileName_new != "" && !System.IO.File.Exists(p_FileName_new))
			{
				return;
			}

			if (p_FileName_new != "") CImpersonation.CopyFileImpersonated(p_FileName_new, p_sPath_dest + NewFileName); //System.IO.File.Copy(p_FileName_new, p_sPath_dest + NewFileName, true);

			using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_SaveFileDocument]", MozartDatabase.cnxMozart))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres
																										//  liste des paramètres
				cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
				cmd.Parameters["@P_VFILE_DOCUMENT"].Value = NewFileName;
				cmd.ExecuteNonQuery();
				VFILE_DOCUMENT = NewFileName;
			}

		}
		public void Save()
		{

			using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Save]", MozartDatabase.cnxMozart))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

				//  liste des paramètres
				cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
				cmd.Parameters["@P_NCLINUM"].Value = NCLINUM;
				cmd.Parameters["@P_NTYPECONTRAT"].Value = NTYPECONTRAT;
				cmd.Parameters["@P_NIDCONTRAT_TYPEDOC"].Value = NIDCONTRAT_TYPEDOC;
				cmd.Parameters["@P_VNOMDOCUMENT"].Value = VNOMDOCUMENT;
				cmd.Parameters["@P_DDATE_DOCUMENT"].Value = (object)DDATE_DOCUMENT ?? DBNull.Value;
				cmd.Parameters["@P_VFILE_DOCUMENT"].Value = VFILE_DOCUMENT;
				cmd.Parameters["@P_DDATE_DEBUT"].Value = (object)DDATE_DEBUT ?? DBNull.Value;
				cmd.Parameters["@P_DDATE_FIN"].Value = (object)DDATE_FIN ?? DBNull.Value;
				cmd.Parameters["@P_BCONTRATCLI_TACITE"].Value = BCONTRATCLI_TACITE;
				cmd.Parameters["@P_NIDFORMULE_REV"].Value = NIDFORMULE_REV;
				cmd.Parameters["@P_VOBS_DOC"].Value = VOBS_DOC;
				cmd.Parameters["@P_VOBS_REMISE"].Value = VOBS_REMISE;
				cmd.Parameters["@P_VOBS_MANUEL"].Value = VOBS_MANUEL;
				cmd.Parameters["@P_VOBS_CONTRAT"].Value = VOBS_CONTRAT;
				cmd.Parameters["@P_DLAST_APPLICATION"].Value = (object)DLAST_APPLICATION ?? DBNull.Value;
				cmd.Parameters["@P_PC_CUR"].Value = (object)PC_CUR ?? DBNull.Value;
				cmd.Parameters["@P_PC_PREV"].Value = (object)PC_PREV ?? DBNull.Value;
				cmd.Parameters["@P_PC_BPU"].Value = (object)PC_BPU ?? DBNull.Value;
				cmd.Parameters["@P_DNEXT_APPLICATION"].Value = (object)DNEXT_APPLICATION ?? DBNull.Value;
				cmd.Parameters["@P_BACTIF"].Value = BACTIF;
				cmd.Parameters["@P_BREMISE_AUCUNE"].Value = BREMISE_AUCUNE == true ? 1 : 0;
				cmd.Parameters["@P_NIDCONTRATCLI_DETAIL_AVENANT"].Value = NIDCONTRATCLI_DETAIL_AVENANT;
				cmd.Parameters["@P_BNODOC"].Value = bNoDoc == true ? 1 : 0;

				cmd.ExecuteNonQuery();
				NIDCONTRATCLI_DETAIL = (int)cmd.Parameters[0].Value;

			}

			if (NIDCONTRATCLI_DETAIL == 0) return;

			//save comptes   
			//on charge la liste des sites de la base de données
			//on les compare
			DataTable dtCompteOnBase = new DataTable();
			dtCompteOnBase.Load(ModuleData.ExecuteReader($"EXEC [api_sp_ContratClient_Detail_Compte_Load] {NIDCONTRATCLI_DETAIL}"));
			foreach (DataRow drCompteToDel in dtCompteOnBase.Rows)
			{
				//on delete les lignes qui ne sont plus affectés
				if (LstComptesSelected.Contains(drCompteToDel["NCANNUM"]) == false)
				{
					using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Compte_Save]", MozartDatabase.cnxMozart))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

						//  liste des paramètres
						cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
						cmd.Parameters["@P_NCANNUM"].Value = drCompteToDel["NCANNUM"];
						cmd.Parameters["@P_SELECTED"].Value = 0;

						cmd.ExecuteNonQuery();
					}

				}
			}

			foreach (Object drCompteSelected in LstComptesSelected)
			{

				using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Compte_Save]", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

					//  liste des paramètres
					cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
					cmd.Parameters["@P_NCANNUM"].Value = drCompteSelected;
					cmd.Parameters["@P_SELECTED"].Value = 1;

					cmd.ExecuteNonQuery();
				}

			}

			//save des pays
			//on charge la liste des sites de la base de données
			//on les compare
			DataTable dtPaysOnBase = new DataTable();
			dtPaysOnBase.Load(ModuleData.ExecuteReader($"EXEC [api_sp_ContratClient_Detail_Pays_Load] {NIDCONTRATCLI_DETAIL}"));
			foreach (DataRow drPaysToDel in dtPaysOnBase.Rows)
			{
				//on delete les lignes qui ne sont plus affectés
				if (LstPaysSelected.Contains(drPaysToDel["NPAYSNUM"]) == false)
				{
					using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Pays_Save]", MozartDatabase.cnxMozart))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

						//  liste des paramètres
						cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
						cmd.Parameters["@P_NPAYSNUM"].Value = drPaysToDel["NPAYSNUM"];
						cmd.Parameters["@P_SELECTED"].Value = 0;

						cmd.ExecuteNonQuery();
					}

				}

			}
			foreach (Object drPaysSelected in LstPaysSelected)
			{

				using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Pays_Save]", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

					//  liste des paramètres
					cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
					cmd.Parameters["@P_NPAYSNUM"].Value = drPaysSelected;
					cmd.Parameters["@P_SELECTED"].Value = 1;

					cmd.ExecuteNonQuery();
				}

			}

			//save des sites
			//on charge la liste des sites de la base de données
			//on les compare
			DataTable dtSitesOnBase = new DataTable();
			dtSitesOnBase.Load(ModuleData.ExecuteReader($"EXEC [api_sp_ContratClient_Detail_Site_Load] {NIDCONTRATCLI_DETAIL}"));
			foreach (DataRow drSiteToDel in dtSitesOnBase.Rows)
			{
				//on delete les lignes qui ne sont plus affectés
				if (LstSitesSelected.Contains(drSiteToDel["NSITNUM"]) == false)
				{
					using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Site_Save]", MozartDatabase.cnxMozart))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

						//  liste des paramètres
						cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
						cmd.Parameters["@P_NSITNUM"].Value = drSiteToDel["NSITNUM"];
						cmd.Parameters["@P_SELECTED"].Value = 0;

						cmd.ExecuteNonQuery();
					}

				}

			}

			//on ajoute les lignes affectes
			foreach (Object drSiteSelected in LstSitesSelected)
			{

				using (SqlCommand cmd = new SqlCommand("[api_sp_ContratClient_Detail_Site_Save]", MozartDatabase.cnxMozart))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

					//  liste des paramètres
					cmd.Parameters["@P_NIDCONTRATCLI_DETAIL"].Value = NIDCONTRATCLI_DETAIL;
					cmd.Parameters["@P_NSITNUM"].Value = drSiteSelected;
					cmd.Parameters["@P_SELECTED"].Value = 1;

					cmd.ExecuteNonQuery();
				}

			}

			//on mets à jour le document
			if (bNewDocument == true)
			{
				// si nouveau document vide alors on supprime le contrat
				if (sPathAndFileNameNewDoc == "")
				{
					if (CImpersonation.FileExistImpersonated(RepertoireDoc + VFILE_DOCUMENT)) CImpersonation.DeleteFileImpersonated(RepertoireDoc + VFILE_DOCUMENT);
					//System.IO.File.Delete(RepertoireDoc + VFILE_DOCUMENT);          
					UpdateFileDocContrat(sPathAndFileNameNewDoc, RepertoireDoc + VFILE_DOCUMENT, RepertoireDoc);
				}
				else
				{
					UpdateFileDocContrat(sPathAndFileNameNewDoc, RepertoireDoc + VFILE_DOCUMENT, RepertoireDoc);
				}
			}

		}

	}
}