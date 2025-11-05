using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public class FacturesUtils
  {
    // mise a jour du flag d'impression d'une facture
    public static void SetFactureEditee(int NumFac)
    {
      ModuleData.ExecuteNonQuery($"update TFAC set VFACSTA = 'OUI' , DFACEDI = getdate() where VSOCIETE = '{MozartParams.NomSociete}' AND NFACNUM ={NumFac}");
      ModuleData.ExecuteNonQuery($"update TELF set VELFSTA = 'Edité' where NELFNUM in (select distinct NELFNUM from TFAC where VSOCIETE = '{MozartParams.NomSociete}' AND NFACNUM={NumFac})");
    }

    // Imrime ou visualise ou génère un PDF d'une facture ou d'un avoir
    // sOption : PREVIEW, PRINT ou PDF
    public static void EditionFacture(string sOption, int NumFac, DataRow row)
    {
      string sTypeReport;

      string sIdentifiant = NumFac.ToString();
      string sInfosMail = $"TCLI|NCLINUM|{row["NCLINUM"]}";
      string sLangue = row["VRSFLANGUE"].ToString();

      if (row["VFACTYP"].ToString() == "F")
      {
        int icontrat = RechercheContratFacture(NumFac);

        if (icontrat == 247)
        {
          // messagebox sur impression du CRVP
          if (MessageBox.Show(Resources.msg_imprimer_CRVP_gammes_de_facture, Program.AppTitle, MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            // impression des crvp et gamme ei de toutes les actions concernes de la facture
            // demande JJ le 01/06/2017. Modif fait par MC le 08/06/2017
            new FrmPrintFileForFactureEI(sIdentifiant).ShowDialog();
          }

          sTypeReport = PrepareReport.TFACTURECLIENTEXTINCTEUR;
        }
        else
        {
          string sTypeDevis = RechercheTypeDevis(NumFac);
          switch (sTypeDevis)
          {
            case "P":
              sTypeReport = PrepareReport.TFACTURECLIENTPRESTATION;
              break;

            case "AV":
              sTypeReport = PrepareReport.TFACTURECLIENTPRESTATIONAVANCEMENT;
              break;

            case "AVA":
              sTypeReport = PrepareReport.TFACTURECLIENTPRESTATIONAVANCEMENTAV;
              break;

            case "R":
            case "D":
              sTypeReport = PrepareReport.TFACTURECLIENTREGIE;
              sIdentifiant += $"|{row["VCLITYPEFAC"]}";
              break;

            default:
              sTypeReport = PrepareReport.TFACTURECLIENT;
              sIdentifiant += $"|{row["VCLITYPEFAC"]}";
              break;
          }
        }
      }
      else
      {
        // c'est un avoir
        sTypeReport = PrepareReport.TAVOIRCLIENT;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = sTypeReport,
        sIdentifiant = sIdentifiant,
        InfosMail = sInfosMail,
        sNomSociete = MozartParams.NomSociete,
        sLangue = sLangue,
        sOption = sOption
      }.ShowDialog();
    }

    public static string RechercheTypeDevis(int nfacnum)
    {
      //utiliser pour l'impression des factures
      string sSql = $"SELECT COUNT(NELFNUM) FROM TFAC WHERE VSOCIETE = App_Name() AND NFACNUM = {nfacnum}";

      //facturation a partir d'un devis de prestation
      //uniquement si la facture ne comporte qu'un seul élément de facturation
      using (SqlDataReader dr = ModuleData.ExecuteReader(sSql))
      {
        if (!dr.Read() || Utils.ZeroIfNull(dr[0]) != 1) return "F";

        sSql = "select coalesce(cdevistype,'') , TELF.CELFTYP FROM TFAC WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TFAC.NELFNUM=TACT.NELFNUM LEFT OUTER JOIN" +
               " TDCL WITH (NOLOCK) ON TACT.NACTNUM = TDCL.NACTNUM INNER JOIN TELF WITH (NOLOCK) ON TACT.NELFNUM = TELF.NELFNUM" +
               $" WHERE CACTSTA='F' AND TFAC.NFACNUM= {nfacnum}  AND VSOCIETE = App_Name()";

        using (SqlDataReader drTypeDevis = ModuleData.ExecuteReader(sSql))
        {
          if (!drTypeDevis.Read()) return "F";

          if (Utils.BlankIfNull(drTypeDevis["CELFTYP"]) == "AV")
          {
            using (SqlDataReader drAvenant = ModuleData.ExecuteReader($"SELECT COUNT(*) FROM TAVANCEMENT, TFAC WHERE TAVANCEMENT.NELFNUM = TFAC.NELFNUM AND NLDCLPRESTID = 0 AND TFAC.NFACNUM= {nfacnum} AND VSOCIETE = App_Name()"))
            {
              if (drAvenant.Read())
              {
                if (Utils.ZeroIfNull(drAvenant[0]) > 0) return "AVA";
                return "AV";
              }
            }
          }
          else
          {
            if (Utils.BlankIfNull(drTypeDevis[0]) == "P")
            {
              if (MessageBox.Show($"{Resources.msg_ActionF_Contient_Devis_Prestation}\r\n{Resources.msg_Demande_Impressions_Facture_Devis_Prestation}\r\n{Resources.msg_Oui_Facture_Prestation}\r\n{Resources.msg_Non_Facture_Classique}", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return "P";
            }
          }
        }
        return "F";
      }
    }

    public static int RechercheContratFacture(int nfacnum)
    {
      //utiliser pour l'impression des factures
      string sSql = $"SELECT NTYPECONTRAT,(select count(*) FROM TFAC WHERE TFAC.VSOCIETE = '{MozartParams.NomSociete}' AND TFAC.NFACNUM = {nfacnum}) AS CPT" +
                     " FROM TFAC WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TFAC.NELFNUM = TACT.NELFNUM INNER JOIN " +
                     " TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM INNER JOIN " +
                     " TFFA WITH (NOLOCK) ON TFAC.NELFNUM = TFFA.NELFNUM " +
                     $" WHERE TFAC.VSOCIETE = '{MozartParams.NomSociete}' AND TFAC.NFACNUM = {nfacnum} " +
                     " GROUP BY NTYPECONTRAT";

      using (SqlDataReader dr = ModuleData.ExecuteReader(sSql))
      {
        if (dr.Read())
        {
          int NTYPECONTRAT = (int)Convert.ToInt32(dr["NTYPECONTRAT"]);
          if (Utils.ZeroIfNull(dr["CPT"]) > 1 || dr.Read())
            return 0;
          return NTYPECONTRAT;
        }
      }
      return 0;
    }

    // depuis de modExcel.bas
    public static void GenerateFichierExcelFactureClient(int inumFact, string sClient, string sRequete)
    {
      Excel.Application xlApp = null;
      Excel.Workbook xlBook = null;
      Excel.Worksheet xlSheet = null; // Feuille Excel

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"{sRequete} {inumFact}"))
        {
          // copie du fichier modele
          string sFile1 = $@"{MozartParams.CheminModeles}FR\Facture{sClient}.xls";
          string sFile2 = $@"{MozartParams.CheminUtilisateurMozart}Facture{sClient}{inumFact}.xls";
          if (File.Exists(sFile1))
            File.Copy(sFile1, sFile2, overwrite: true);
          else
          {
            MessageBox.Show("Fichier inexistant : " + sFile1, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //  ouverture du fichier   utilisation de l'objet feuille d'Excel
          xlApp = new Excel.Application();
          xlBook = xlApp.Workbooks.Open(sFile2, Missing.Value, false);
          xlSheet = (Excel.Worksheet)xlBook.ActiveSheet;

          //  ecriture des données
          int i = 6;
          while (reader.Read())
          {
            //  utilisation de la méthode value de l'objet Sheet
            for (int j = 0; j < reader.FieldCount; j++)
            {
              if (reader[j].GetType() == typeof(DateTime))
                xlSheet.Cells[i, j + 1] = "'" + Utils.UnBlancIfDBNull(reader[j]);  //pas de conversion des dates
              else
                xlSheet.Cells[i, j + 1] = Utils.BlankIfNull(reader[j]); ;   //conversion en string
            }
            Utils.Quadrillage(xlSheet.Range[xlSheet.Cells[i, 1], xlSheet.Cells[i, reader.FieldCount]]);
            i++;
          }

          xlBook.Saved = true;
          xlBook.Save();
          xlApp.Quit();
        }

        xlSheet = null;
        xlApp = null;
        xlApp = null;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;

        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Public Sub GenerateFichierExcelFactureClient(ByVal inumFact As Long, ByVal sClient As String, ByVal sRequete As String)

    //Dim OBJxL As Excel.Application  'application Excel
    //Dim objWbs As Excel.Workbooks   'classeur Excel
    //Dim objSh As Excel.Worksheet    'feuille Excel


    //Dim rs As ADODB.Recordset
    //Dim i, j

    //  Screen.MousePointer = vbHourglass

    //  ' récup du recordset
    //  Set rs = New ADODB.Recordset
    //  rs.Open sRequete & " " & inumFact, cnx

    //  If rs.EOF Then Exit Sub


    //  On Error Resume Next


    //  Set OBJxL = GetObject(, "Excel.Application")
    //  If Err.Number<> 0 Then
    //    Err.Clear
    //    Set OBJxL = CreateObject("Excel.Application")
    //  End If


    //  On Error GoTo handler


    //  Set objWbs = OBJxL.Workbooks

    //  'copie du fichier modele
    //  FileCopy gstrCheminModeles & "FR\Facture" & sClient & ".xls", gstrCheminUtilisateur & "\Mozart\Facture" & sClient & inumFact & ".xls"

    //  'ouverture du fichier
    //  objWbs.Open FileName:=gstrCheminUtilisateur & "\Mozart\Facture" & sClient & inumFact & ".xls", ReadOnly:=False, IgnoreReadOnlyRecommended:=True

    //  'utilisation de l'objet feuille d'Excel
    //  Set objSh = OBJxL.ActiveSheet

    //  ' objSh.Cells(3, 1) = "§Fichier concernant la facture §" & gstrNomSociete & "§ N° F§" & inumFact

    //  ' ecriture des données
    //  i = 6
    //  While Not rs.EOF
    //  'utilisation de la méthode value de l'objet Sheet
    //    For j = 0 To rs.Fields.Count - 1
    //      If rs(j).Type = adDBTimeStamp Then
    //        objSh.Cells(i, j + 1) = "'" & UnBlancIfNull(rs(j))   'pas de conversion des dates
    //      Else
    //        objSh.Cells(i, j + 1) = CStr(UnBlancIfNull(rs(j)))    'conversion en string
    //      End If
    //    Next
    //    Quadrillage objSh.Range(objSh.Cells(i, 1), objSh.Cells(i, rs.Fields.Count))
    //    i = i + 1
    //    rs.MoveNext
    //  Wend


    //  objWbs.Item(1).Saved = True
    //  objWbs.Item(1).Save
    //  objWbs.Item(1).Close

    //  rs.Close
    //  Set rs = Nothing


    //  Set objSh = Nothing
    //  Set objWbs = Nothing
    //  Set OBJxL = Nothing


    //  Screen.MousePointer = vbDefault
    //  Exit Sub


    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "GenerateFichierExcelFactureClient"
    //End Sub

    // depuis modExcel.bas
    public static void GenerateFichierExcelFactureClientXLSX(int inumFact, string sClient, string sRequete)
    {
      Excel.Application xlApp = null;
      Excel.Workbook xlBook = null;
      Excel.Worksheet xlSheet = null; // Feuille Excel

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"{sRequete} {inumFact}"))
        {
          // copie du fichier modele
          string sFile1 = $@"{MozartParams.CheminModeles}FR\Facture{sClient}.xlsx";
          string sFile2 = $@"{MozartParams.CheminUtilisateurMozart}Facture{sClient}{inumFact}.xlsx";
          if (File.Exists(sFile1))
            File.Copy(sFile1, sFile2, overwrite: true);
          else
          {
            MessageBox.Show("Fichier inexistant : " + sFile1, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          ///  ouverture du fichier   utilisation de l'objet feuille d'Excel
          xlApp = new Excel.Application();
          xlBook = xlApp.Workbooks.Open(sFile2, Missing.Value, false);
          xlSheet = (Excel.Worksheet)xlBook.ActiveSheet;

          //  ecriture des données
          int i = 6;
          while (reader.Read())
          {
            //  utilisation de la méthode value de l'objet Sheet
            for (int j = 0; j < reader.FieldCount; j++)
            {
              if (reader[j].GetType() == typeof(DateTime))
                xlSheet.Cells[i, j + 1] = "'" + Utils.DateBlankIfNull(reader[j]);//pas de conversion des dates
              else if (sClient == "MEDIAPOST" && j == 13)
                xlSheet.Cells[i, j + 1] = Utils.ZeroIfNull(reader[j]);// conversion en dbl
              else
                xlSheet.Cells[i, j + 1] = Utils.UnBlancIfDBNull(reader[j]);//conversion en string
            }
            Utils.Quadrillage(xlSheet.Range[xlSheet.Cells[i, 1], xlSheet.Cells[i, reader.FieldCount]]);
            i++;
          }

          xlBook.Saved = true;
          xlBook.Save();
          xlApp.Quit();
        }

        xlSheet = null;
        xlApp = null;
        xlApp = null;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;

        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Public Sub GenerateFichierExcelFactureClientXLSX(ByVal inumFact As Long, ByVal sClient As String, ByVal sRequete As String)

    //Dim OBJxL As Excel.Application  'application Excel
    //Dim objWbs As Excel.Workbooks   'classeur Excel
    //Dim objSh As Excel.Worksheet    'feuille Excel


    //Dim rs As ADODB.Recordset
    //Dim i, j

    //  Screen.MousePointer = vbHourglass

    //  ' récup du recordset
    //  Set rs = New ADODB.Recordset
    //  rs.Open sRequete & " " & inumFact, cnx

    //  If rs.EOF Then Exit Sub


    //  On Error Resume Next


    //  Set OBJxL = GetObject(, "Excel.Application")
    //  If Err.Number<> 0 Then
    //    Err.Clear
    //    Set OBJxL = CreateObject("Excel.Application")
    //  End If


    //  On Error GoTo handler


    //  Set objWbs = OBJxL.Workbooks

    //  'copie du fichier modele
    //  FileCopy gstrCheminModeles & "FR\Facture" & sClient & ".xlsx", gstrCheminUtilisateur & "\Mozart\Facture" & sClient & inumFact & ".xlsx"

    //  'ouverture du fichier
    //  objWbs.Open FileName:=gstrCheminUtilisateur & "\Mozart\Facture" & sClient & inumFact & ".xlsx", ReadOnly:=False, IgnoreReadOnlyRecommended:=True

    //  'utilisation de l'objet feuille d'Excel
    //  Set objSh = OBJxL.ActiveSheet

    //  ' objSh.Cells(3, 1) = "§Fichier concernant la facture §" & gstrNomSociete & "§ N° F§" & inumFact

    //  ' ecriture des données
    //  i = 6
    //  While Not rs.EOF
    //  'utilisation de la méthode value de l'objet Sheet
    //    For j = 0 To rs.Fields.Count - 1
    //      If rs(j).Type = adDBTimeStamp Then
    //        objSh.Cells(i, j + 1) = "'" & UnBlancIfNull(rs(j))   'pas de conversion des dates
    //      Else
    //        If sClient = "MEDIAPOST" And j = 13 Then
    //          objSh.Cells(i, j + 1) = CDbl(UnBlancIfNull(rs(j)))    'conversion en dbl
    //        Else
    //          objSh.Cells(i, j + 1) = CStr(UnBlancIfNull(rs(j)))    'conversion en string
    //        End If
    //      End If
    //    Next
    //    Quadrillage objSh.Range(objSh.Cells(i, 1), objSh.Cells(i, rs.Fields.Count))
    //    i = i + 1
    //    rs.MoveNext
    //  Wend


    //  objWbs.Item(1).Saved = True
    //  objWbs.Item(1).Save
    //  objWbs.Item(1).Close

    //  rs.Close
    //  Set rs = Nothing


    //  Set objSh = Nothing
    //  Set objWbs = Nothing
    //  Set OBJxL = Nothing


    //  Screen.MousePointer = vbDefault
    //  Exit Sub


    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "GenerateFichierExcelFactureClient"
    //End Sub

    // depuis modExcel.bas
    public static int iNbLinesFacLOIRETAL;
    public static int iNbLinesARGEDISOnlyUser;
    // init des variables lignes pour le fichier EXCEL
    public static int iNbLinesARGEDIS;
    public static int iNbLinesLOIRETAL;
    public static int iNbLinesFacARGEDIS;

    public static void GenerateFichierExcelFactureClientARGEDIS(string sNomFicOut, int inumFact)
    {
      Excel.Application xlApp = null;
      Excel.Workbook xlBook = null;
      Excel.Worksheet xlSheet = null; // Feuille Excel

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_MailFactureARGEDIS {inumFact}"))
        {
          if (!reader.Read()) return;

          // ouverture du fichier
          string fichier = $@"{MozartParams.CheminUtilisateurMozart}{sNomFicOut}";
          if (!File.Exists(fichier))
          {
            MessageBox.Show("Fichier inexistant : " + fichier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          //  ouverture du fichier   utilisation de l'objet feuille d'Excel
          xlApp = new Excel.Application();
          xlBook = xlApp.Workbooks.Open(fichier, Missing.Value, false);
          xlSheet = (Excel.Worksheet)xlBook.ActiveSheet;

          int i = 0, iNbLinesFac = 0, iNbLines = 0;
          int iTypeFacture = (int)Utils.ZeroIfNull(reader["NRSFNUM"]);
          switch (iTypeFacture)
          {
            case 30274://RS : ARGEDIS
              xlSheet.Name = "ARGEDIS";
              i = 10 + iNbLinesARGEDIS;
              iNbLinesFacARGEDIS++;
              iNbLinesFac = iNbLinesFacARGEDIS;
              break;
            case 30636://RS : LOIRETAL
              xlSheet.Name = "LOIRETAL";
              i = 10 + iNbLinesLOIRETAL;
              iNbLinesFacLOIRETAL++;
              iNbLinesFac = iNbLinesFacLOIRETAL;
              break;
            case 55744:
              xlSheet.Name = "SAS PROGERES";
              i = 10 + iNbLinesARGEDIS;
              iNbLinesFacARGEDIS++;
              iNbLinesFac = iNbLinesFacARGEDIS;
              break;
            default:
              xlSheet.Name = "ARGEDIS";
              i = 10 + iNbLinesARGEDIS;
              iNbLinesFacARGEDIS++;
              iNbLinesFac = iNbLinesFacARGEDIS;
              break;
          }

          // Copie du N° Fournisseur
          xlSheet.Cells[2, 2] = 257449;
          xlSheet.Cells[2, 5] = MozartParams.NomSociete;

          // Gestion de l'entete
          using (SqlDataReader readerEnt = ModuleData.ExecuteReader($"exec api_sp_MailFactureARGEDISEntete {inumFact}"))
          {
            if (readerEnt.Read())
            {
              // Ici on renseigne les entetes du fichiers
              xlSheet.Cells[iNbLinesFac, 4] = inumFact;
              xlSheet.Cells[iNbLinesFac, 2] = "'" + Utils.UnBlancIfDBNull(reader["DFACDAT"]);
              xlSheet.Cells[iNbLinesFac, 5] = Utils.ZeroIfNull(readerEnt["TOTHT"]);
              xlSheet.Cells[iNbLinesFac, 6] = Utils.ZeroIfNull(readerEnt["TOTTVA"]);
              xlSheet.Cells[iNbLinesFac, 7] = Utils.ZeroIfNull(readerEnt["TOTTTC"]);
            }
          }

          // ecriture des données
          do
          {
            iNbLines++;
            // utilisation de la méthode value de l'objet Sheet
            xlSheet.Cells[i, 1] = Utils.UnBlancIfDBNull(reader["VSITNOM"]);
            xlSheet.Cells[i, 2] = Utils.UnBlancIfDBNull(reader["VCODIMPL"]);
            xlSheet.Cells[i, 3] = Utils.UnBlancIfDBNull(reader["NSITNUE"]);
            xlSheet.Cells[i, 4] = Utils.UnBlancIfDBNull(reader["NCLINUM"]);
            xlSheet.Cells[i, 5] = "'" + Utils.UnBlancIfDBNull(reader["DACTDEX"]);
            xlSheet.Cells[i, 6] = Utils.UnBlancIfDBNull(reader["NDINNUM"]);
            xlSheet.Cells[i, 7] = Utils.ZeroIfNull(reader["NELFTHT"]);
            xlSheet.Cells[i, 8] = Utils.UnBlancIfDBNull(reader["NFACNUM"]);

            //for (int j = 0; j <= reader.FieldCount - 4; j++)
            //{
            //  if (j == 6)
            //  {
            //    xlSheet.Cells[i, 9] = Utils.ZeroIfNull(reader["NELFTHT"]);
            //  }
            //  else if (j == 4)
            //  {
            //    xlSheet.Cells[i, j + 1] = "'" + Utils.UnBlancIfDBNull(reader[j]);//pas de conversion des dates
            //  }
            //  else
            //  {
            //    if (j < 6) xlSheet.Cells[i, j + 1] = Utils.UnBlancIfDBNull(reader[j]);// conversion en string
            //  }
            //}

            i++;
          }
          while (reader.Read());

          switch (iTypeFacture)
          {
            case 30274://RS : ARGEDIS
              iNbLinesARGEDIS += iNbLines;
              break;
            case 30636://RS : LOIRETAL
              iNbLinesLOIRETAL += iNbLines;
              break;
            default:
              iNbLinesARGEDIS += iNbLines;
              break;
          }

          xlBook.Saved = true;
          xlBook.Save();
          xlApp.Quit();
        }

        xlSheet = null;
        xlApp = null;
        xlApp = null;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    // depuis modExcel.bas
    //'******************************************************************************************************
    //'Fonction permettant de générer le détail des factures ARGEDIS
    //'******************************************************************************************************
    public static void GenerateFichierExcelFactureClientARGEDISPOnlyUser(string sNomFicOut, int inumFact)
    {
      Excel.Application xlApp = null;
      Excel.Workbook xlBook = null;
      Excel.Worksheet xlSheet = null; // Feuille Excel

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_MailFactureARGEDIS {inumFact}"))
        {
          if (!reader.Read()) return;

          // ouverture du fichier
          string fichier = $@"{MozartParams.CheminUtilisateurMozart}{sNomFicOut}";
          if (!File.Exists(fichier))
          {
            MessageBox.Show("Fichier inexistant : " + fichier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //  ouverture du fichier   utilisation de l'objet feuille d'Excel
          xlApp = new Excel.Application();
          xlBook = xlApp.Workbooks.Open(fichier, Missing.Value, false);
          xlSheet = (Excel.Worksheet)xlBook.ActiveSheet;

          int iNbLinesOnlyUser = 0;
          int iTypeFactureOnlyUser = (int)Utils.ZeroIfNull(reader["NRSFNUM"]);
          int i = iNbLinesARGEDISOnlyUser + 10;

          // Copie du N° Fournisseur
          xlSheet.Cells[2, 2] = 257449;
          xlSheet.Cells[2, 5] = MozartParams.NomSociete;

          // Gestion de l'entete
          // Ici on renseigne les entetes du fichiers
          xlSheet.Cells[4, 2] = "'" + DateTime.Today.AddMonths(1).AddDays(-DateAndTime.DatePart("d", DateTime.Today.AddMonths(1)));

          // ecriture des données
          do
          {
            iNbLinesOnlyUser++;

            xlSheet.Cells[i, 1] = Utils.UnBlancIfDBNull(reader["VSITNOM"]);
            xlSheet.Cells[i, 2] = Utils.UnBlancIfDBNull(reader["VCODIMPL"]);
            xlSheet.Cells[i, 3] = Utils.UnBlancIfDBNull(reader["NSITNUE"]);
            xlSheet.Cells[i, 4] = Utils.UnBlancIfDBNull(reader["NCLINUM"]);
            xlSheet.Cells[i, 5] = Utils.UnBlancIfDBNull(reader["VACTDES"]);
            xlSheet.Cells[i, 5].VerticalAlignment = 1;
            xlSheet.Cells[i, 5].WrapText = false;
            xlSheet.Cells[i, 6] = Utils.UnBlancIfDBNull(reader["NDCLNUM"]);
            xlSheet.Cells[i, 7] = "'" + Utils.UnBlancIfDBNull(reader["DACTDEX"]);
            xlSheet.Cells[i, 8] = Utils.UnBlancIfDBNull(reader["NDINNUM"]);
            if (Utils.ZeroIfNull(reader["NELFFOR"]) == 0)
              xlSheet.Cells[i, 9] = Utils.ZeroIfNull(reader["NELFTPREST"]);
            else
              xlSheet.Cells[i, 9] = Utils.ZeroIfNull(reader["NELFFOR"]);
            xlSheet.Cells[i, 10] = Utils.ZeroIfNull(reader["NELFFOU"]);
            xlSheet.Cells[i, 11] = Utils.ZeroIfNull(reader["NELFTHT"]);
            xlSheet.Cells[i, 12] = Utils.ZeroIfNull(reader["NFACNUM"]);


            i++;
          }
          while (reader.Read());

          iNbLinesARGEDISOnlyUser += iNbLinesOnlyUser;

          xlBook.Saved = true;
          xlBook.Save();
          xlApp.Quit();
        }

        xlSheet = null;
        xlApp = null;
        xlApp = null;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    public static void GenerateFichierExcelFactureClientLAFRANCEMUTUALISTE(string sNomFicOut, int inumFact)
    {
      Excel.Application xlApp = null;
      Excel.Workbook xlBook = null;
      Excel.Worksheet xlSheet = null; // Feuille Excel

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_MailFactureLFM {inumFact}"))
        {
          if (!reader.Read()) return;

          // ouverture du fichier
          string fichier = $@"{MozartParams.CheminUtilisateurMozart}{sNomFicOut}";
          if (!File.Exists(fichier))
          {
            MessageBox.Show("Fichier inexistant : " + fichier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          //  ouverture du fichier   utilisation de l'objet feuille d'Excel
          xlApp = new Excel.Application();
          xlBook = xlApp.Workbooks.Open(fichier, Missing.Value, false);
          xlSheet = (Excel.Worksheet)xlBook.ActiveSheet;

          int i = 0, iNbLinesFac = 0, iNbLines = 0;
          i = 10 + iNbLinesARGEDIS;
          iNbLinesFacARGEDIS++;
          iNbLinesFac = iNbLinesFacARGEDIS;

          // Copie du N° Fournisseur
          xlSheet.Cells[2, 2] = 257449;
          xlSheet.Cells[2, 5] = MozartParams.NomSociete;

          // Gestion de l'entete (la proc ARGEDIS fonctionne également pour le client LFM)
          using (SqlDataReader readerEnt = ModuleData.ExecuteReader($"exec api_sp_MailFactureARGEDISEntete {inumFact}"))
          {
            if (readerEnt.Read())
            {
              // Ici on renseigne les entetes du fichiers
              xlSheet.Cells[iNbLinesFac, 4] = inumFact;
              xlSheet.Cells[iNbLinesFac, 2] = "'" + Utils.UnBlancIfDBNull(reader["DFACDAT"]);
              xlSheet.Cells[iNbLinesFac, 5] = Utils.ZeroIfNull(readerEnt["TOTHT"]);
              xlSheet.Cells[iNbLinesFac, 6] = Utils.ZeroIfNull(readerEnt["TOTTVA"]);
              xlSheet.Cells[iNbLinesFac, 7] = Utils.ZeroIfNull(readerEnt["TOTTTC"]);
            }
          }

          // ecriture des données
          do
          {
            iNbLines++;
            // utilisation de la méthode value de l'objet Sheet
            for (int j = 0; j <= reader.FieldCount - 3; j++)
            {
              if (j == 6 || j == 7)
              {
                xlSheet.Cells[i, j + 1] = Utils.ZeroIfNull(reader[j]);
              }
              else if (j == 4)
              {
                xlSheet.Cells[i, j + 1] = "'" + Utils.UnBlancIfDBNull(reader[j]);//pas de conversion des dates
              }
              else
              {
                if (j < 8) xlSheet.Cells[i, j + 1] = Utils.UnBlancIfDBNull(reader[j]);// conversion en string
              }
            }

            i++;
          }
          while (reader.Read());

          iNbLinesARGEDIS += iNbLines;

          xlBook.Saved = true;
          xlBook.Save();
          xlApp.Quit();
        }

        xlSheet = null;
        xlApp = null;
        xlApp = null;
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    // depuis modMain.bas
    public static void SendMailFactureClient(int numFact, string sClient, string sPJ, DateTime dDate, string sDest, string sCopy)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        CSendMail oMail = new CSendMail
        {
          Dest = sDest,
          CopyDest = sCopy,
          PJ = sPJ,
          BlindCopyDest = (MozartParams.NomGroupe == "EMALEC") ? "info@emalec.com" : "",
          Subject = $"{Resources.msg_Facture_F0}{numFact}{Resources.msg_pour}{sClient}",
          Message = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                    $"Veuillez trouver en pièce jointe le listing relatif à la facture F0{numFact} du {DateTime.Today.ToShortDateString()}{Environment.NewLine}{Environment.NewLine}" +
                    $"{MozartParams.NomSociete}"
        };
        oMail.SendMail();

        MessageBox.Show(Resources.msg_courriel_envoye, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Public Sub SendMailFactureClient(numFact As Long, sClient As String, sPJ As String, dDate As Date, sDest As String, sCopy As String)
    //Dim sMsg As String
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String
    //Dim oMail As New apiMail
    //' UPGRADE_INFO (#0501): The 'rs' member isn't used anywhere in current application.
    //' Dim rs As New ADODB.Recordset


    // On Error GoTo Handler


    //  sMsg = "§Bonjour,§" & Chr(10) & Chr(10)
    //  sMsg = sMsg & "Veuillez trouver en pièce jointe le listing relatif à la facture F0" & numFact & " du " & dDate & "." & Chr(10) & Chr(10)
    //  sMsg = sMsg & gstrNomSociete

    //'  Select Case sClient
    //'
    //'    Case "ORCHESTRA"
    //'      oMail.dest = "pborja@orchestra.fr;cf@orchestra-premaman.com"
    //'      oMail.CopyDest = "pbenay@emalec.com"
    //'    Case "REXEL"
    //'      oMail.dest = "stephanie.hermitte@rexel.fr"
    //'    Case "ESPRIT"
    //'      oMail.dest = "habi.drame@esprit.com"
    //'    Case "HYGENA"
    //'      oMail.dest = "clefebvre@hygena.fr"
    //'    Case "EDDIA"
    //'      oMail.dest = "cecile.franche@diagroup.com;nadia.manchelin@diagroup.com"
    //'      oMail.CopyDest = "pbenay@emalec.com"
    //'    Case "KIABI"
    //'      oMail.dest = "l.carneau@kiabi.com"
    //'      oMail.CopyDest = "equinson@emalec.com"
    //'    Case "NOCIBE"
    //'      oMail.dest = "cwitkowski@nocibe.fr"
    //'    Case "THOMEUROPE"
    //'      oMail.dest = "mligere@thomeurope.com;nassi@thomeurope.com;"
    //'      oMail.CopyDest = "edalbepierre@emalec.com"
    //'  End Select
    //  oMail.dest = sDest
    //  oMail.CopyDest = sCopy
    //  If gstrNomGroupe = "EMALEC" Then oMail.CopyDestCache = "info@emalec.com"
    //  oMail.Sujet = "§Facture F0§" & numFact & "§ pour §" & sClient
    //  oMail.PieceJointe = sPJ
    //  oMail.TextBody = sMsg


    //  oMail.Send
    //  Set oMail = Nothing
    //  MsgBox "§Le mail a été envoyé§", vbInformation

    //Exit Sub
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "SendMailFactureClient dans ModMain"
    //End Sub

    // depuis modMain.bas
    //'*******************************************************************************
    //'Envoi mail facture : RECAP + FICHE DETAILS + FACTURES en PDF: founitures et prestations
    //'*******************************************************************************
    public static void SendMailFactureWithPJ(string numFact, string sPJ, string dDate, string sNomClient)
    {
      // Envoi du mail à cette adresse après vérification des factures et du fichier EXCEL service.fournisseur@argedis.fr
      // Pour proseca : c.cunha@argedis.fr
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string sNomClientSubj, sDestMailClient;
        switch (sNomClient)
        {
          case "ARGEDIS":
            sNomClientSubj = "ARGEDIS/LOIRETAL";
            sDestMailClient = "service.fournisseur@argedis.fr";
            break;
          case "PROSECA":
            sNomClientSubj = "PROSECA";
            sDestMailClient = "service.fournisseurs.proseca@proseca.com";
            break;
          case "GSH NEW LOOK":
            sNomClientSubj = "GSH NEW LOOK";
            sDestMailClient = "International.Purchaseinvoices@GSHGROUP.COM"; //'"mcavallaro@emalec.com"
            break;
          case "LA FRANCE MUTUALISTE":
            sNomClientSubj = "LA FRANCE MUTUALISTE";
            sDestMailClient = "";
            break;
          /*  case "ZEEMAN":// ne pas reprendre FG 22/12/2021
              sNomClientSubj = "ZEEMAN";
              sDestMailClient = "mfodjagbo@zeeman.com;pviguier@emalec.com";
              break;*/
          default: throw new Exception();
        }

        CSendMail oMail = new CSendMail();
        // on définit le destinataire du mail
        string sDestMail = MozartParams.UserMail;
        if (sDestMail == "" && MozartParams.NomGroupe == "EMALEC") sDestMail = "mcavallaro@emalec.com";
        oMail.Dest = sDestMail;
        if (MozartParams.NomGroupe == "EMALEC") oMail.BlindCopyDest = "info@emalec.com";

        oMail.Subject = $"{Resources.txt_facturation} {sNomClientSubj}{Resources.txt_du}{DateTime.Today.ToShortDateString()} - {MozartParams.NomSociete}";
        oMail.PJ = sPJ;

        if (sNomClient == "ARGEDIS")
          oMail.Message = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                          $"Veuillez trouver en pièce jointe le fichier EXCEL du mois {dDate}{Environment.NewLine}{Environment.NewLine}" +
                          $"{Resources.msg_mail_envoyer_adresse_mail_suivante}{sDestMailClient}{Environment.NewLine}{Environment.NewLine}" +
                          $"{MozartParams.NomSociete}";
        else
          oMail.Message = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                          $"{Resources.msg_Veuillez_trouver_pièce_jointe_facture} {numFact} {Resources.msg_du_mois} {dDate}{Environment.NewLine}{Environment.NewLine}" +
                          $"{Resources.msg_fichier_contient_montant_total_facture_excel}.{Environment.NewLine}{Environment.NewLine}" +
                          $"{Resources.msg_mail_envoyer_adresse_mail_suivante}{sDestMailClient}{Environment.NewLine}{Environment.NewLine}" +
                          $"{MozartParams.NomSociete}";
        oMail.SendMail();

        // il y a déjà un message d'envoie du mail dans oMail.SendMail
        //MessageBox.Show(Resources.msg_courriel_envoye, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    // depuis modMain.bas
    public static void ImprimerAttestation_TVA_5_5(int iNumFac, int iclient)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT max(NELFTVA) as tva FROM TFAC INNER JOIN TELF ON TFAC.NELFNUM = TELF.NELFNUM INNER JOIN TDIN ON TELF.NDINNUM = TDIN.NDINNUM " +
                                                              $" WHERE TFAC.NFACNUM = {iNumFac} AND TDIN.NCLINUM ={iclient}"))
        {
          if (reader.Read())
          {
            string tva = Utils.BlankIfNull(reader["tva"]);
            if (tva == MozartParams.TVA2.ToString() || tva == "5.5" || tva == "7")
            {// mc le 10/01/14 attestion pour les tva a 10% et 7%
              new frmMainReport
              {
                bLaunchByProcessStart = false,
                sTypeReport = "TAttestation_TVA_10",
                sIdentifiant = iNumFac.ToString(),
                InfosMail = $"TCLI|NCLINUM|000",
                sNomSociete = MozartParams.NomSociete,
                sLangue = "FR",
                sOption = "PRINT"
              }.ShowDialog();
            }
          }
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    public static void ImprimerFichierWord(string strFileOut)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        // Version avec ouverture du fichier dans Word
        Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add(strFileOut);
        doc.PrintOut();
        doc.Close(SaveChanges: false);
        doc = null;
        wordApp = null;
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Public Sub ImprimerFichierWord(ByVal strFileOut As String)

    //  Dim wdApp As Word.Application
    //  Dim doc As New Word.Document

    //    On Error Resume Next

    //    ' affichage curseur
    //    Screen.MousePointer = vbHourglass

    //    ' selection de l'imprimante avant l'ouverture de word
    //  '  SelectImprimante "lexmark"

    //    ' récupération d'une instance de word
    //    Set wdApp = GetObject(, "word.application")
    //    If Err.Number = 429 Then
    //      Set wdApp = CreateObject("word.application")
    //      wdApp.Visible = False
    //      wdApp.WindowState = wdWindowStateMinimize
    //    End If

    //    ' Version avec ouverture du fichier dans Word
    //    If wdApp.Documents.Count< 1 Then Set doc = wdApp.Documents.Add()
    //    wdApp.PrintOut , , , , , , , , , , , , strFileOut

    //  '  Set doc = wdApp.Documents.Open(strFileOut)     ' création du document
    //  '  doc.PrintOut    ' impression
    //  '  doc.Close SaveChanges:=wdDoNotSaveChanges     ' on ferme sans sauvegarder


    //    Set doc = Nothing

    //    Screen.MousePointer = vbDefault


    //  Exit Sub
    //  Handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "ImprimerFichierWord dans ModMain"
    //  End Sub


    // depuis modMain.bas
    public static bool IsRSFActif(int p_NRSFNUM)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select count(*) from TRSF WITH (NOLOCK) where TRSF.NRSFNUM={p_NRSFNUM} AND TRSF.CRSFACTIF = 'O'"))
        {
          if (reader.Read() && Utils.ZeroIfNull(reader[0]) > 0) return true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
      return false;
    }
    // Public Function IsRSFActif(ByVal p_NRSFNUM As Long) As Boolean
    //' UPGRADE_INFO (#0501): The 'i' member isn't used anywhere in current application.
    // ' Dim i As Integer

    //   On Error GoTo Handler


    //   IsRSFActif = False


    //   Set rs = New ADODB.Recordset
    //   rs.Open "select count(*) from TRSF WITH (NOLOCK) where TRSF.NRSFNUM=" & p_NRSFNUM & " AND TRSF.CRSFACTIF = 'O'", cnx

    //   If rs(0).value > 0 Then IsRSFActif = True
    //   rs.Close

    // Exit Function
    // Resume
    // Handler:
    //   ShowError "IsRSFActif"
    // End Function
  }
}
