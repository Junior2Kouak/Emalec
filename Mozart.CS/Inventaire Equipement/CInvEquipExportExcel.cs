using DevExpress.CodeParser;
using DevExpress.Utils.Extensions;
using DevExpress.XtraCharts.UI;
using MozartLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using MZUtils = MozartControls.Utils;
using System.Threading;
using static DevExpress.Utils.Drawing.GlyphPainter;
using static MozartCS.Inventaire_Equipement.CEQUIPEMENT_FICHE_ITEM;

namespace MozartCS.Inventaire_Equipement
{
    class CInvEquipExportExcel
    {

        private List<MyThreadHandle> List_thrd = new List<MyThreadHandle>();

        string sFileOut = "";
        public static List<Color> sColorList = new List<Color>() { Color.Yellow, Color.PeachPuff, Color.LightGreen, Color.LightSkyBlue, Color.LightCoral, Color.LightGray };
        //couleur champ site et N° équipement
        public static Color color_entete = Color.Gainsboro; //gris

        //couleur grille
        public static Color color_pair = Color.LightCyan; //bleu clair
        public static Color color_impair = Color.White; //blanc
               

        public CInvEquipExportExcel(string c_FileOut, List<Int32> lstInvFiches, List<Int32> lstInvSites)
        {

            sFileOut = c_FileOut;

            //on créer le fichier excel
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Excel.Worksheet xlWorksheet = null;

            // Get reference to the default sheet(often "Feuil1" or "Sheet1")
            Excel.Worksheet defaultSheet = xlWorkbook.Sheets["Feuil1"] as Excel.Worksheet;

            int index_fiche = 1;

            //pour chaque fiche, on crée une feuille excel
            foreach (Int32 NID_EQUIPEMENT_FICHE in lstInvFiches)
            {
                xlWorksheet = index_fiche == 1 ? defaultSheet : (Excel.Worksheet)xlWorkbook.Sheets.Add();

                List_thrd.Add(new MyThreadHandle(xlWorksheet, NID_EQUIPEMENT_FICHE, lstInvSites));


                //MyThreadHandle threadHandle = 
                //Thread t = new Thread(new ThreadStart(threadHandle.ThreadLoop));

                //t.Start();
                //t.Join(); // Attendre que le thread se termine avant de continuer

                //xlWorksheet.Name = GetFicheNom(NID_EQUIPEMENT_FICHE, xlWorksheet.Name); //on nomme la feuille avec le nom de la fiche
                //Excel.Range xlRange = xlWorksheet.UsedRange;


                //CInvEquipExportExcelFiche exportFiche = new CInvEquipExportExcelFiche(NID_EQUIPEMENT_FICHE, lstInvSites);
                //DataTable dtOut = exportFiche.dtOut;
                //DataTable dt_data = exportFiche.dt_data;

                //int index = 1;

                ////1er ligne : chapitres
                //var lstChap = dt_data.AsEnumerable()
                //              .GroupBy(p => new { NID_EQUIPEMENT_FICHE_CHAP = p.Field<int>("NID_EQUIPEMENT_FICHE_CHAP"), NID_EQUIPEMENT_FICHE_ITEM = p.Field<int>("NID_EQUIPEMENT_FICHE_ITEM") })
                //              .Select(picTag => new
                //              {
                //                  NID_EQUIPEMENT_FICHE_CHAP = picTag.Key.NID_EQUIPEMENT_FICHE_CHAP,
                //                  NID_EQUIPEMENT_FICHE_ITEM = picTag.Key.NID_EQUIPEMENT_FICHE_ITEM
                //              }).GroupBy(grp => grp.NID_EQUIPEMENT_FICHE_CHAP)
                //              .Select(g => new
                //              {
                //                  NID_EQUIPEMENT_FICHE_CHAP = g.Key,
                //                  TOTAL = g.Count()
                //              }).ToList();

                //int totalColByChap = 0;
                //int iColumn = 5;  //Index column du 1er chapitre (on laisse 4 colonnes pour les champs NSITNUM, NSIT_INV_EQUIPEMENT_RECEIVE_ID, VLIBEQUIPEMENT et VTYPECONTRAT)
                //int ind_color = 0;
                //foreach (object chap in lstChap)
                //{

                //    totalColByChap = (int)chap.GetType().GetProperty("TOTAL").GetValue(chap, null);
                //    Excel.Range range = xlWorksheet.Range[xlWorksheet.Cells[index, iColumn], xlWorksheet.Cells[index, iColumn + totalColByChap - 1]];
                //    range.Merge();

                //    // Center the text horizontally and vertically
                //    range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //    range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                //    // range.WrapText = true;
                //    //range.AutoFit();
                //    // Set a value in the merged cell
                //    range.Value = GetChapitreName((int)chap.GetType().GetProperty("NID_EQUIPEMENT_FICHE_CHAP").GetValue(chap, null));
                //    range.Font.Bold = true;
                //    range.Font.Size = 10F;
                //    range.Interior.Color = sColorList[ind_color]; //gris
                //    range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                //    ind_color = (ind_color + 1) % sColorList.Count; //on change la couleur pour le prochain chapitre
                //    iColumn += totalColByChap;
                //}


                //index = 2;
                ////on supprime la colonne id capitre
                //dtOut.Columns.Remove("NID_EQUIPEMENT_FICHE_CHAP");

                ////2ligne : titre des colonnes
                //foreach (DataColumn column in dtOut.Columns)
                //{                                       

                //    CEQUIPEMENT_FICHE_ITEM oOut = new CEQUIPEMENT_FICHE_ITEM(column.ColumnName);

                //    xlRange.Cells[index, column.Ordinal + 1] = oOut.VEQUIPEMENT_FICHE_ITEM_LIB; //+1 car Excel commence à 1

                //    switch(oOut.NID_EQUIPEMENT_FICHE_TYPE_CHAMP)
                //    {
                //        case 1: //texte
                //        case 4: //texte multi ligne
                //            xlRange.EntireColumn[column.Ordinal + 1].NumberFormat = "@"; //largeur colonne
                //            break;
                //        case 2: //nombre        
                //            //xlRange.EntireColumn[xlRange.Cells[index, column.Ordinal + 1]].NumberFormat = "0"; //largeur colonne
                //            xlRange.EntireColumn[column.Ordinal + 1].NumberFormat = "0";
                //            break;
                //        //case 3: //date                              
                //        //    xlRange.EntireColumn[column.Ordinal + 1].NumberFormat = "MM/DD/YYYY"; //largeur colonne
                //        //    break;                        
                //    }

                //    xlRange.Cells[index, column.Ordinal + 1].Font.Bold = true;
                //    xlRange.Cells[index, column.Ordinal + 1].Font.Size = 10F;
                //    xlRange.Cells[index, column.Ordinal + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //    xlRange.Cells[index, column.Ordinal + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                //    //xlRange.Cells[index, column.Ordinal + 1].WrapText = true;

                //    if (column.ColumnName == "NSITNUM" || column.ColumnName == "NSIT_INV_EQUIPEMENT_RECEIVE_ID" || column.ColumnName == "VLIBEQUIPEMENT" || column.ColumnName == "VTYPECONTRAT")
                //    {
                //        xlRange.Cells[index, column.Ordinal + 1].Interior.Color = color_entete; //gris
                //    }
                //    else
                //    {
                //        //on récupère la couleur de la celluledu chapitre
                //        xlRange.Cells[index, column.Ordinal + 1].Interior.Color = xlRange.Cells[(index - 1 == 0 ? 0 : index - 1), column.Ordinal + 1].Interior.Color;
                //    }

                //    xlRange.Cells[index, column.Ordinal + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //}

                ////on écrit les données dans le fichier excel
                //int rowCount = index + 1;
                //foreach (DataRow row in dtOut.Rows)
                //{
                //    for (int i = 0; i < dtOut.Columns.Count; i++)
                //    {
                //        xlRange.Cells[rowCount, i + 1] = dtOut.Columns[i].ColumnName == "NSITNUM" ? GetSiteNom(row[i].ToString()) : SetValue(row[i].ToString());
                //        xlRange.Cells[rowCount, i + 1].Interior.Color = (rowCount % 2 == 0 ? color_impair : color_pair); //gris
                //        xlRange.Cells[rowCount, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //        xlRange.Cells[rowCount, i + 1].Font.Size = 10F;
                //    }
                //    rowCount++;
                //}

                //xlWorksheet.Columns.AutoFit();

                //xlWorksheet.Rows[2].AutoFilter();

                index_fiche = index_fiche + 1; //on incrémente le numéro de fiche
            }

            ///on lance les traitements
            for(int i = 0; i < List_thrd.Count; i++)
            {
                MyThreadHandle threadHandle = List_thrd[i];
                Thread t = new Thread(new ThreadStart(threadHandle.ThreadLoop));
                t.Start();
                t.Join(); // Attendre que le thread se termine avant de continuer
            }

            //Save
            xlWorkbook.SaveAs($@"{sFileOut}");

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            ////release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

        }
        public static string GetChapitreName(int NID_EQUIPEMENT_FICHE_CHAP)
        {
            return MozartDatabase.ExecuteScalarString($"EXEC api_sp_InvEquip_GetFicheChapitre {NID_EQUIPEMENT_FICHE_CHAP}", MozartDatabase.cnxMozart);
        }

        public static string GetFicheNom(int NID_EQUIPEMENT_FICHE, string NomDefault)
        {
            string FicheNom = string.Empty;
            FicheNom = MozartDatabase.ExecuteScalarString($"EXEC api_sp_InvEquip_GetFicheNom {NID_EQUIPEMENT_FICHE}", MozartDatabase.cnxMozart);

            //ref : https://support.microsoft.com/fr-fr/office/renommer-une-feuille-de-calcul-3f1f7148-ee83-404d-8ef0-9ff99fbad1f9

            //on remaplace les caraceteres interdits dans les noms de fichiers
            FicheNom = FicheNom.Replace(":", "_").Replace("/", "_").Replace("\\", "_").Replace("?", "_").Replace("*", "_").Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_");
            if (FicheNom.Length > 31)
            {
                FicheNom = FicheNom.Substring(0, 31); //Excel ne peut pas avoir de nom de feuille de plus de 31 caractères
            }
            if (FicheNom != "" && FicheNom.Substring(1, 1) == "'")
            {
                FicheNom = FicheNom.Substring(2, FicheNom.Length - 1);
            }
            if (FicheNom != "" && FicheNom.Substring(FicheNom.Length - 1, 1) == "'")
            {
                FicheNom = FicheNom.Substring(1, FicheNom.Length - 1);
            }
            if (FicheNom == "Historique")
            {
                FicheNom = "Histo";
            }
            if (FicheNom == "")
            {
                FicheNom = NomDefault;
            }

            return FicheNom;
        }

        public static string GetSiteNom(string NSITNUM)
        {
            int.TryParse(NSITNUM, out int siteNum);

            return MozartDatabase.ExecuteScalarString($"EXEC [api_sp_InvEquip_GetSiteNom] {siteNum}", MozartDatabase.cnxMozart);
        }

        public static string GetSiteNue(string NSITNUM)
        {
            int.TryParse(NSITNUM, out int siteNum);

            return MozartDatabase.ExecuteScalarString($"EXEC [api_sp_InvEquip_GetSiteNUE] {siteNum}", MozartDatabase.cnxMozart);
        }

        public static string SetValue(string value)
        {
            //pour emepcher le chevauchement des cellules vides
            if (value == "") value = " ";

            return value;
        }

    }

    //class pour fiche item
    class CEQUIPEMENT_FICHE_ITEM
    {
        public string VEQUIPEMENT_FICHE_ITEM_LIB { get; set; }
        public int NID_EQUIPEMENT_FICHE_TYPE_CHAMP { get; set; }

        public CEQUIPEMENT_FICHE_ITEM(string nid_equipement_fiche_item)
        {
            // Initialize the property before using it  
            VEQUIPEMENT_FICHE_ITEM_LIB = string.Empty;
            NID_EQUIPEMENT_FICHE_TYPE_CHAMP = 0;

            switch (nid_equipement_fiche_item)
            {
                case "NSITNUM":
                    VEQUIPEMENT_FICHE_ITEM_LIB = "Site";
                    break;

                case "NSITNUE":
                    VEQUIPEMENT_FICHE_ITEM_LIB = "N° Site";
                    break;

                case "NSIT_INV_EQUIPEMENT_RECEIVE_ID":
                    VEQUIPEMENT_FICHE_ITEM_LIB = "N° équipement";
                    break;

                case "NID_EQUIPEMENT_FICHE_CHAP":
                    VEQUIPEMENT_FICHE_ITEM_LIB = "";
                    break;

                case "VLIBEQUIPEMENT":
                    VEQUIPEMENT_FICHE_ITEM_LIB = "Type équipement";
                    break;

                case "VTYPECONTRAT":
                    VEQUIPEMENT_FICHE_ITEM_LIB = "Contrat";
                    break;

                default:

                    SqlDataReader reader = MozartDatabase.ExecuteReader($"EXEC api_sp_InvEquip_GetFicheChampLibelle {nid_equipement_fiche_item}", 1500);

                    if (reader.Read())
                    {
                        VEQUIPEMENT_FICHE_ITEM_LIB = reader["VEQUIPEMENT_FICHE_ITEM_LIB"].ToString();
                        NID_EQUIPEMENT_FICHE_TYPE_CHAMP = Convert.ToInt32(reader["NID_EQUIPEMENT_FICHE_TYPE_CHAMP"]);
                    }
                    reader.Close();
                    break;
            }
        }

        public class MyThreadHandle
        {
            // Cet entier sera utilisé comme paramètre
            Excel.Worksheet xlWorksheet;
            int NID_EQUIPEMENT_FICHE = 0; // Numéro de la fiche d'équipement
            List<int> lstInvSites; // Liste des sites d'inventaire associés à la fiche d'équipement

            // Constructeur
            public MyThreadHandle(Excel.Worksheet xlWorksheet, int NID_EQUIPEMENT_FICHE, List<int> lstInvSites)
            {
                this.xlWorksheet = xlWorksheet;
                this.NID_EQUIPEMENT_FICHE = NID_EQUIPEMENT_FICHE;
                this.lstInvSites = lstInvSites; 
            }

            // Méthode de modification du paramètre
            public void SetParam(Excel.Worksheet xlWorksheet, int NID_EQUIPEMENT_FICHE, List<int> lstInvSites)
            {
                this.xlWorksheet = xlWorksheet;
                this.NID_EQUIPEMENT_FICHE = NID_EQUIPEMENT_FICHE;
                this.lstInvSites = lstInvSites;
            }

            // Méthode boucle du thread
            public void ThreadLoop()
            {
                xlWorksheet.Name = CInvEquipExportExcel.GetFicheNom(NID_EQUIPEMENT_FICHE, xlWorksheet.Name); //on nomme la feuille avec le nom de la fiche
                Excel.Range xlRange = xlWorksheet.UsedRange;


                CInvEquipExportExcelFiche exportFiche = new CInvEquipExportExcelFiche(NID_EQUIPEMENT_FICHE, lstInvSites);
                DataTable dtOut = exportFiche.dtOut;
                DataTable dt_data = exportFiche.dt_data;

                int index = 1;

                //1er ligne : chapitres
                var lstChap = dt_data.AsEnumerable()
                              .GroupBy(p => new { NID_EQUIPEMENT_FICHE_CHAP = p.Field<int>("NID_EQUIPEMENT_FICHE_CHAP"), NID_EQUIPEMENT_FICHE_ITEM = p.Field<int>("NID_EQUIPEMENT_FICHE_ITEM") })
                              .Select(picTag => new
                              {
                                  NID_EQUIPEMENT_FICHE_CHAP = picTag.Key.NID_EQUIPEMENT_FICHE_CHAP,
                                  NID_EQUIPEMENT_FICHE_ITEM = picTag.Key.NID_EQUIPEMENT_FICHE_ITEM
                              }).GroupBy(grp => grp.NID_EQUIPEMENT_FICHE_CHAP)
                              .Select(g => new
                              {
                                  NID_EQUIPEMENT_FICHE_CHAP = g.Key,
                                  TOTAL = g.Count()
                              }).ToList();

                int totalColByChap = 0;
                int iColumn = 6;  //Index column du 1er chapitre (on laisse 4 colonnes pour les champs NSITNUM, NSIT_INV_EQUIPEMENT_RECEIVE_ID, VLIBEQUIPEMENT et VTYPECONTRAT)
                int ind_color = 0;
                foreach (object chap in lstChap)
                {

                    totalColByChap = (int)chap.GetType().GetProperty("TOTAL").GetValue(chap, null);
                    Excel.Range range = xlWorksheet.Range[xlWorksheet.Cells[index, iColumn], xlWorksheet.Cells[index, iColumn + totalColByChap - 1]];
                    range.Merge();

                    // Center the text horizontally and vertically
                    range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    // range.WrapText = true;
                    //range.AutoFit();
                    // Set a value in the merged cell
                    range.Value = CInvEquipExportExcel.GetChapitreName((int)chap.GetType().GetProperty("NID_EQUIPEMENT_FICHE_CHAP").GetValue(chap, null));
                    range.Font.Bold = true;
                    range.Font.Size = 10F;
                    range.Interior.Color = CInvEquipExportExcel.sColorList[ind_color]; //gris
                    range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    ind_color = (ind_color + 1) % CInvEquipExportExcel.sColorList.Count; //on change la couleur pour le prochain chapitre
                    iColumn += totalColByChap;
                }


                index = 2;
                //on supprime la colonne id capitre
                dtOut.Columns.Remove("NID_EQUIPEMENT_FICHE_CHAP");

                //2ligne : titre des colonnes
                foreach (DataColumn column in dtOut.Columns)
                {

                    CEQUIPEMENT_FICHE_ITEM oOut = new CEQUIPEMENT_FICHE_ITEM(column.ColumnName);

                    xlRange.Cells[index, column.Ordinal + 1] = oOut.VEQUIPEMENT_FICHE_ITEM_LIB; //+1 car Excel commence à 1

                    switch (oOut.NID_EQUIPEMENT_FICHE_TYPE_CHAMP)
                    {
                        case 1: //texte
                        case 4: //texte multi ligne
                            xlRange.EntireColumn[column.Ordinal + 1].NumberFormat = "@"; //largeur colonne
                            break;
                        case 2: //nombre        
                            //xlRange.EntireColumn[xlRange.Cells[index, column.Ordinal + 1]].NumberFormat = "0"; //largeur colonne
                            xlRange.EntireColumn[column.Ordinal + 1].NumberFormat = "0";
                            break;
                            //case 3: //date                              
                            //    xlRange.EntireColumn[column.Ordinal + 1].NumberFormat = "MM/DD/YYYY"; //largeur colonne
                            //    break;                        
                    }

                    xlRange.Cells[index, column.Ordinal + 1].Font.Bold = true;
                    xlRange.Cells[index, column.Ordinal + 1].Font.Size = 10F;
                    xlRange.Cells[index, column.Ordinal + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    xlRange.Cells[index, column.Ordinal + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    //xlRange.Cells[index, column.Ordinal + 1].WrapText = true;

                    if (column.ColumnName == "NSITNUM" || column.ColumnName == "NSITNUE" || column.ColumnName == "NSIT_INV_EQUIPEMENT_RECEIVE_ID" || column.ColumnName == "VLIBEQUIPEMENT" || column.ColumnName == "VTYPECONTRAT")
                    {
                        xlRange.Cells[index, column.Ordinal + 1].Interior.Color = CInvEquipExportExcel.color_entete; //gris
                    }
                    else
                    {
                        //on récupère la couleur de la celluledu chapitre
                        xlRange.Cells[index, column.Ordinal + 1].Interior.Color = xlRange.Cells[(index - 1 == 0 ? 0 : index - 1), column.Ordinal + 1].Interior.Color;
                    }

                    xlRange.Cells[index, column.Ordinal + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                //on écrit les données dans le fichier excel
                int rowCount = index + 1;
                foreach (DataRow row in dtOut.Rows)
                {
                    for (int i = 0; i < dtOut.Columns.Count; i++)
                    {
                        //xlRange.Cells[rowCount, i + 1] = dtOut.Columns[i].ColumnName == "NSITNUM" ? CInvEquipExportExcel.GetSiteNom(row[i].ToString()) : CInvEquipExportExcel.SetValue(row[i].ToString());
                        xlRange.Cells[rowCount, i + 1] = GetSite(dtOut.Columns[i].ColumnName, row[i].ToString());
                        xlRange.Cells[rowCount, i + 1].Interior.Color = (rowCount % 2 == 0 ? CInvEquipExportExcel.color_impair : CInvEquipExportExcel.color_pair); //gris
                        xlRange.Cells[rowCount, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        xlRange.Cells[rowCount, i + 1].Font.Size = 10F;
                    }
                    rowCount++;
                }

                xlWorksheet.Columns.AutoFit();

                xlWorksheet.Rows[2].AutoFilter();

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);


            }

            private string GetSite(string ColName, string p_value)
            {
                switch(ColName)
                {
                    case "NSITNUM":
                        return CInvEquipExportExcel.GetSiteNom(p_value.ToString());
                    case "NSITNUE":

                        return CInvEquipExportExcel.SetValue(p_value.ToString());     
                     default:   
                        return CInvEquipExportExcel.SetValue(p_value.ToString());
                }
            }

        }

    }

}
