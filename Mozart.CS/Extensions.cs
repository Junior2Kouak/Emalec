using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Google.Cloud.Translation.V2;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public static class Extensions
  {
    public static T CloneControl<T>(this T controlToClone) where T : Control
    {
      PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

      T instance = Activator.CreateInstance<T>();
      try
      {
        foreach (PropertyInfo propInfo in controlProperties)
        {
          if (propInfo.CanWrite)
          {
            if (propInfo.Name != "WindowTarget")
              propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
          }
        }
      }
      catch (Exception) { }
      return instance;
    }

    public static int GetItemData(this ComboBox cbo)
    {
      if (cbo.SelectedItem.GetType() == typeof(ModuleData.ListItem))
        return Convert.ToInt32(((ModuleData.ListItem)cbo.SelectedItem).ItemData);
      else
        return Convert.ToInt32(((DataRowView)cbo.SelectedItem).Row.ItemArray[0]);
    }

    public static void SetItemData(this ComboBox cbo, string itemToFind)
    {
      cbo.SelectedItem = cbo.Items.OfType<DataRowView>().Where(x => x.Row.ItemArray[0].ToString() == itemToFind).FirstOrDefault();
    }

    public static void SetItemValue(this ComboBox cbo, string itemToFind)
    {
      cbo.SelectedItem = cbo.Items.OfType<DataRowView>().Where(x => x.Row.ItemArray[1].ToString() == itemToFind).FirstOrDefault();
    }

    public static string GetAllMessages(this Exception ex)
    {
      int line = 0;
      string method = "";
      StackTrace st = new StackTrace(ex, true);
      StackFrame frame = st.GetFrame(0);

      if (frame != null)
      {
        line = frame.GetFileLineNumber();
        method = frame.GetMethod().GetFullName();
      }

      string message = $"{method} => line {line}{Environment.NewLine}{Environment.NewLine}{ex.Message}";

      if (ex.InnerException != null)
        message += "\r\n\r\n" + GetAllMessages(ex.InnerException);

      return message;
    }

    public static string GetFullName(this MethodBase m)
    {
      return $"{m.DeclaringType}.{m.Name}";
    }
  }

  public static class Utils
  {
    public static Cursor Cursor { get; private set; }

    public static void ShowException(Exception _ex, string _method, string stacktrace)
    {
      //if (MozartCsUtils.UserInTestMode())
      //en mode TESTS :
      //new frmInfoDebug(_ex, MethodBase.GetCurrentMethod().Name, _ex.StackTrace).ShowDialog();
      //else
      // Mode Normal
      MZUtils.displayError(_method, _ex);
    }

    public static bool IsDate(string text)
    {
      return DateTime.TryParse(text, out DateTime res);
    }

    public static bool IsNumeric(string text)
    {
      return float.TryParse(text, out float res);
    }

    public static string BlankIfNull(object o)
    {
      return o?.ToString() ?? "";
    }

    public static string UnBlancIfDBNull(object o)
    {
      return Convert.IsDBNull(o) ? " " : o.ToString();
    }

    public static string DateBlankIfNull(object o, string sFormat = "")
    {
      return o == DBNull.Value ? "" : Convert.ToDateTime(o).ToString(sFormat == "" ? "dd/MM/yyyy" : sFormat);
    }

    public static string DateLongBlankIfNull(object o)
    {
      return o == DBNull.Value ? "" : Convert.ToDateTime(o).ToString("dd/MM/yyyy HH:mm:ss");
    }

    public static string DateLongIfHMBlankIfNull(object o)
    {
      if (o == DBNull.Value) return "";
      DateTime d = Convert.ToDateTime(o);
      if (d.Hour == 0 && d.Minute == 0) return d.ToString("dd/MM/yyyy");
      return d.ToString("dd/MM/yyyy HH:mm:ss");
    }

    public static Double ZeroIfNull(object o)
    {
      return o == null || o == DBNull.Value || o.ToString() == "" ? 0 : Convert.ToDouble(o);
    }

    public static double ZeroIfBlank(object o)
    {
      return o.ToString() == "" ? 0 : Convert.ToDouble(o);
    }

    public static string RechercheParam(string nomParam)
    {
      return MozartParams.RechercheParam(nomParam, MozartParams.NomSociete, MozartDatabase.cnxMozart);
    }

    public static void Quadrillage(Excel.Range selection)
    {
      selection.Select();

      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

      selection.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlThin;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

      selection.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlThin;
      selection.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
    }

    public static string Mois(int iMois)
    {
      string Mois = "";
      switch (iMois)
      {
        case 1:
          Mois = Resources.mois_01;
          break;
        case 2:
          Mois = Resources.mois_02;
          break;
        case 3:
          Mois = Resources.mois_03;
          break;
        case 4:
          Mois = Resources.mois_04;
          break;
        case 5:
          Mois = Resources.mois_05;
          break;
        case 6:
          Mois = Resources.mois_06;
          break;
        case 7:
          Mois = Resources.mois_07;
          break;
        case 8:
          Mois = Resources.mois_08;
          break;
        case 9:
          Mois = Resources.mois_09;
          break;
        case 10:
          Mois = Resources.mois_10;
          break;
        case 11:
          Mois = Resources.mois_11;
          break;
        case 12:
          Mois = Resources.mois_12;
          break;
      }
      return Mois;
    }

    public static void DeleteTemporaryFile()
    {
      try
      {
        var fileNames = Directory.GetFiles(Path.GetTempPath(), "*.Mozart.*");
        foreach (string f in fileNames)
        {
          System.Threading.Tasks.Task.Run(() => System.IO.File.Delete(f));
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public static void ShowError(Exception ex, string infos = "")
    {
      try
      {
        //  tentative de reconnexion si erreur de connexion
        try
        {
          // https://docs.microsoft.com/fr-fr/dotnet/api/system.data.connectionstate?view=netframework-4.6.1
          if (MozartDatabase.cnxMozart.State.HasFlag(ConnectionState.Broken) ||
            !MozartDatabase.cnxMozart.State.HasFlag(ConnectionState.Open))
          {
            MozartDatabase.cnxMozart.Dispose();

            MozartDatabase.cnxMozart = new SqlConnection($"Data Source ={MozartParams.NomServeur}; Database = MULTI; MultipleActiveResultSets = True; trusted_connection = true;" +
                                               $" APP ={MozartParams.NomSociete}");
            MozartDatabase.cnxMozart.Open();

            // si pas d'erreur, on sort
            return;
          }
        }
        catch (Exception) { }

        string sTmp = $"L'erreur suivante est survenue :{Environment.NewLine}{Environment.NewLine}Erreur numéro: {ex.HResult} - {ex.Message}";

        if (infos != "") sTmp += $"{Environment.NewLine}Info complémentaire : {infos}";

        // Insertion dans la table des erreurs
        using (SqlCommand cmd = new SqlCommand("api_sp_TraceErreur", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // liste des paramètres
          cmd.Parameters["@nerrnum"].Value = ex.HResult;
          cmd.Parameters["@verrdes"].Value = ex.Message;
          cmd.Parameters["@verrpro"].Value = infos;
          cmd.Parameters["@ndinnum"].Value = MozartParams.NumDi;
          cmd.Parameters["@nactnum"].Value = MozartParams.NumAction;

          // exécuter la commande.
          cmd.ExecuteNonQuery();
        }

        MessageBox.Show(sTmp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception pEx)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, pEx);
      }
    }

    public class C_PJ
    {
      public long NIMAGE { get; set; }
      public string VIMAGE { get; set; }
      public string VFICHIER { get; set; }
      public string PATH_FILE { get; set; }

      public void Init()
      {
        NIMAGE = 0;
        VIMAGE = "";
        VFICHIER = "";
        PATH_FILE = "";
      }
    }

    public static string GetLanguePays(string sTable, string sChamp, string sChampCle, string sCle)
    {
      try
      {
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT {sChamp} FROM {sTable} WHERE {sChampCle} = {sCle}"))
        {
          if (sdr.Read()) return $@"{sdr[0]}\";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return @"FR\";
    }

    [DllImport("User32.dll")]
    public static extern Int32 SetForegroundWindow(int hWnd);

    [DllImport("user32.dll")]
    public static extern int FindWindow(string lpClassName, int nptWindowName);

    /// <summary>
    /// get the spelling check handle
    /// </summary>
    private static void GetSpellcheckingHandle()
    {
      int h = FindWindow("bosa_sdm_msword", (int)IntPtr.Zero);
      while (h == 0)
      {
        Thread.Sleep(500);
        h = FindWindow("bosa_sdm_msword", (int)IntPtr.Zero);
      }
      if (h != 0)
      {
        // bring the spelling check dialog to the front.
      SetForegroundWindow(FindWindow("bosa_sdm_msword", (int)IntPtr.Zero));
      }
    }

    public static void SpellCheck(TextBox text1)
    {
      try
      {
        Microsoft.Office.Interop.Word.Application objWord;
        Microsoft.Office.Interop.Word.Document objDoc = new Microsoft.Office.Interop.Word.Document();

        object wordAsObject = System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
        //If there is a running Word instance, it gets saved into the word variable
        if (wordAsObject != null)
          objWord = (Microsoft.Office.Interop.Word.Application)wordAsObject;
        else
          objWord = new Microsoft.Office.Interop.Word.Application();

        Cursor = Cursors.WaitCursor;

        switch (objWord.Version)
        {
          case "9.0":     // Office 2000 and later
          case "10.0":
          case "11.0":
          case "14.0":
          case "15.0":
          case "16.0":
            objDoc = objWord.Documents.Add(DocumentType: 1, Visible: true);
            break;
          case "8.0":     // Office 97
            objDoc = objWord.Documents.Add();
            break;
          default:
            MessageBox.Show($@"La version ""{objWord.Version}"" de Word n'est pas supportée.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            break;
        }

        objDoc.Content.Text = text1.Text;

        // create a new thread to get the spelling check dialog
        Thread t = new Thread(new ThreadStart(GetSpellcheckingHandle));
        t.Start();

        objDoc.CheckSpelling();
        objWord.Visible = false;

        string strResult = Strings.Left(objDoc.Content.Text, objDoc.Content.Text.Length - 1);
        //  Reformat carriage returns
        strResult = strResult.Replace("\r", "\r\n");

        // Clean 
        objDoc.Close(false);
        objDoc = null;
        objWord.Application.Quit(SaveChanges: false);
        objWord = null;

        if (text1.Text != strResult)
          text1.Text = strResult;
        else
          MessageBox.Show("Aucune modification", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);  // There were no errors, so give the user a visual signal that something happened
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    public static string Traduction(string txtIn)
    {
      frmChoixLanguesTraduction f = new frmChoixLanguesTraduction();
      f.ShowDialog();

      if (f.msLgFrom == "" || f.msLgTo == "")
      {
        return txtIn;
      }

      string lReturn = txtIn + Environment.NewLine;
      lReturn += "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
      lReturn += Environment.NewLine;

      Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", $@"\\emalec.com\mozart\MOZART_SYSTEM\Translate\EmalecTranslate.json");
      TranslationClient client = TranslationClient.Create();
      TranslationResult response = client.TranslateText(txtIn, f.msLgTo, f.msLgFrom);

      string lResult = response.TranslatedText;
      lResult = lResult.Replace((char)160, ' ').Replace((char)194, ' ');
      lResult = lResult.Replace((char)63, 'é');
      // FGA pour corriger des problèmes de sauts de ligne en Anglais uniquement
      lResult = lResult.Replace("\n", "\r\n");

      lReturn += lResult;

      return lReturn;
    }

    public static int GetMozart_Soc_By_Site(int p_NSITNUM)
    {
      return (int)ModuleData.ExecuteScalarInt($"EXEC [api_sp_GetMozart_Soc_by_Site] {p_NSITNUM}");
    }

    public static bool Is_OK_PrixMiniFourniture(long p_nfounum, double p_NPUHTCLI, string p_VFOUMAT)
    {
      //using (Sql)
      double? NFOUPRIXMINI = ModuleData.ExecuteScalarDouble($"SELECT TFOU.NFOUPRIXMINI FROM TFOU WITH (NOLOCK) WHERE NFOUNUM = {p_nfounum}");
      double pmini = (double)ZeroIfNull(NFOUPRIXMINI);
      if (pmini > p_NPUHTCLI)
      {
        MessageBox.Show($"Le prix de vente mini de la fourniture {p_VFOUMAT} est de {NFOUPRIXMINI} € ht.\r\nVous ne pouvez pas la vendre en dessous.\r\nSi problème, contacter la Direction.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      //'par défaut
      return true;
    }

    public static bool bModOKprix(long NumFour)
    {
      bool bOK = ModuleMain.RechercheDroitMenu(530);

      int nb = (int)ModuleData.ExecuteScalarInt($"exec api_sp_TestModificationPrixFourniture {NumFour}");
      if (nb > 0 && bOK)
      {
        if (bOK)
        {
          //' test avec droits de modification de la fourniture
          if (MessageBox.Show($"{Resources.msg_article_utilise_stock_client}\r\n{Resources.msg_effectuer_modification}", "",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            return true;
        }
        else
        {
          //' test sans les droits de modification de la fourniture
          MessageBox.Show($"{Resources.msg_article_util_gamme_client}\r\n{Resources.mmsg_direction_effectue_modification}", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //' test si pas dans une liste
      }
      if (nb == 0)
        return true;

      return false;
    }

    public static int bModOK(long NumFour)
    {
      bool bOK = ModuleMain.RechercheDroitMenu(530);
      bool bOKEmplacement = ModuleMain.RechercheDroitMenu(513);

      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_TestSuppressionFourniture {NumFour}"))
      {
        reader.Read();
        int nb = (int)Utils.ZeroIfNull(reader[0]);
        switch (nb)
        {
          case 31:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_utilise_stock_client} (EMALEC)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (EMALEC)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (EMALEC)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 33:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_utilise_stock_client} (EQUIPAGE)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (EQUIPAGE)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (EQUIPAGE)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 34:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_utilise_stock_client} (ALC)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (ALC)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (ALC)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 35:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_utilise_stock_client} (SCS)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (SCS)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_gamme_client} (SCS)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 21:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_att_article_util_reappro_vehicule_tech} (EMALEC)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (EMALEC)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (EMALEC)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 23:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_att_article_util_reappro_vehicule_tech} (EQUIPAGE)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (EQUIPAGE)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (EQUIPAGE)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 24:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_att_article_util_reappro_vehicule_tech} (ALC)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (ALC)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (ALC)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 25:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_att_article_util_reappro_vehicule_tech} (SCS)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (SCS)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_util_reappro_vehicule_tech} (SCS)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 11:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_stock_magasin} (EMALEC)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (EMALEC)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (EMALEC)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 13:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_stock_magasin} (EQUIPAGE)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (EQUIPAGE)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (EQUIPAGE)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 14:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_stock_magasin} (ALC)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (ALC)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (ALC)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          case 15:
            if (bOK)
            {
              if (MessageBox.Show($"{Resources.msg_article_stock_magasin} (SCS)\r\n{Resources.msg_effectuer_modification}", "",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return 1;
            }
            else
            {
              if (bOKEmplacement)
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (SCS)\r\nVous pouvez modifier seulement l'emplacement", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 2;
              }
              else
              {
                MessageBox.Show($"{Resources.msg_article_stock_magasin} (SCS)\r\n{Resources.mmsg_direction_effectue_modification}", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            break;
          default:
            return 1;
        }
      }

      return 0;
    }

    public static bool RechercheCotraitantAct(int numAction)
    {
      return (int)ModuleData.ExecuteScalarInt($"api_sp_FindCotraitant {numAction}") > 0 ? true : false;
    }

    public static bool RechercheCertificatFluideFrigoExists(int numAction)
    {
      return (int)ModuleData.ExecuteScalarInt($"api_sp_CertificatFluideFrigo_Exist {numAction}") > 0 ? true : false;
    }

    public static void ImpressionGammeST(long iNumGamme, string sCodePays)
    {
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TGAMMECLIENTST",
        sIdentifiant = $"{iNumGamme}|{MozartParams.NumAction}",
        InfosMail = "0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = Strings.Left(sCodePays, 2),
        sOption = "PRINT"
      }.ShowDialog();

    }

    // implementation de modMain.bas 
    public static string TestFouEnStockExistInStock(int nfounum)
    {
      SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_TestIfFouExistStock {nfounum}");
      if (reader.Read())
      {
        return Utils.BlankIfNull(reader["VSOCIETE"]);
      }
      else { return "OK"; }
    }

    // implementation de modMain.bas ArchiverPrestation
    private static void ArchiverPrestation(int nfounum)
    {
      // recherche des prestations conteannt cette fournitures
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select distinct NPRESTID from TLPRESTFOU where NFOUNUM={nfounum}"))
      {
        while (reader.Read())
        {
          ModuleData.SupprimerEnreg((int)Utils.ZeroIfNull(reader["NPRESTID"]), "api_sp_DesactiverPrest", "@iNumPrest");
        }
      }
    }

    // implementation de modMain.bas bSuppOK
    public static int bSuppOK(int nfounum)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_TestSuppressionFourniture {nfounum}"))
        {
          if (reader.Read())
          {
            int nb = (int)Utils.ZeroIfNull(reader[0]);

            switch (nb)
            {
              case 40:
                if (ModuleMain.RechercheDroitMenu(547))
                {
                  if (MessageBox.Show($"{Resources.msg_article_dans_prestation}\r\n" +
                                      $"Voulez vous archiver la prestation et l'article.", Program.AppTitle, MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                  {
                    //' archiver prestation
                    ArchiverPrestation(nfounum);
                    //' traitement des cas ou la fourniture est dans la liste de stock client (sans etre cochée comme gérée)
                    //' on supprime de TSTOCKARTCLI et de TSTOCKARTCLISIT pour tous les clients
                    ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLISIT where  NFOUNUM={nfounum}");
                    ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLI where  NFOUNUM={nfounum}");
                    //'si fourniture web marchand
                    if ((int)ModuleData.ExecuteScalarInt($"exec api_sp_TestIfFouExistWebMarchand {nfounum}") > 0)
                    {
                      frmMessageBox frm = new frmMessageBox()
                      {
                        msTitle = "Confirmation",
                        msMessage = "Attention cette fourniture est utilisée par notre site marchand LES FOURNITURES DU BATIMENT. Voulez-vous toutefois archiver cette fourniture ?"
                      };
                      frm.ShowDialog();
                      if (frm.mbReponse == 1)
                      {
                        //' archiver article
                        ModuleData.ExecuteNonQuery($"exec api_sp_DeactiverArt @iNumArt={nfounum}");
                      }
                    }
                    else
                    {
                      //' archiver article
                      ModuleData.ExecuteNonQuery($"exec api_sp_DeactiverArt @iNumArt={nfounum}");
                    }

                    return 2;
                  }

                  return 0;
                }
                else
                {
                  return MsgPasSupprimer(Resources.msg_article_dans_prestation);
                }

              case 31: return MsgPasSupprimer($"{Resources.msg_article_stock_client} (EMALEC)");

              case 33: return MsgPasSupprimer($"{Resources.msg_article_stock_client} (EQUIPAGE)");

              case 34: return MsgPasSupprimer($"{Resources.msg_article_stock_client} (ALC)");

              case 35: return MsgPasSupprimer($"{Resources.msg_article_stock_client} (SCS)");

              case 21: return MsgPasSupprimer($"{Resources.msg_article_reapro_tech} (EMALEC)");

              case 23: return MsgPasSupprimer($"{Resources.msg_article_reapro_tech} (EQUIPAGE)");

              case 24: return MsgPasSupprimer($"{Resources.msg_article_reapro_tech} (ALC)");

              case 25: return MsgPasSupprimer($"{Resources.msg_article_reapro_tech} (SCS)");

              case 11: return MsgPasSupprimer($"{Resources.msg_article_stock_magasin} (EMALEC)");

              case 13: return MsgPasSupprimer($"{Resources.msg_article_stock_magasin} (EQUIPAGE)");

              case 14: return MsgPasSupprimer($"{Resources.msg_article_stock_magasin} (ALC)");

              case 15: return MsgPasSupprimer($"{Resources.msg_article_stock_magasin} (SCS)");

              case 50: return MsgPasSupprimer("Cet article fait partie d'un inventaire EI.");

              default: return 1;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }

      return 0;
    }

    private static int MsgPasSupprimer(string msg)
    {
      MessageBox.Show($"{msg}\r\n{Resources.msg_pouvez_pas_supprimer}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

      return 0;
    }


    /// <summary>
    /// Initialisation d'un ComboBox
    /// Si les noms de colonnes ne sont pas renseignés, la méthode détermine automatiquement ceux-ci à partir des résultats de la requête
    /// (1ere colonne => DisplayMember)
    /// </summary>
    /// <param name="cbo">Instane ComboBox</param>
    /// <param name="sql">Chaine de la requête sql</param>
    /// <param name="col0">Nom de la colonne pour ValueMember (optionnel)</param>
    /// <param name="col1">Nom de la colonne pour DisplayMember (optionnel)</param>
    /// <param name="addBlanc">Si true ajoute en début une entrée vide (les colonnes doivent être du type int32 ou string)</param>
    public static void InitComboBox(ComboBox cbo, string sql, string col0 = "", string col1 = "", bool addBlanc = false)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader(sql))
      {
        DataTable dt = new DataTable();
        dt.Load(reader);
        if (addBlanc)
        {
          DataRow r = dt.NewRow();
          // colonne : type int32 sinon string
          if (dt.Columns[0].DataType == System.Type.GetType("System.Int32")) r[0] = 0;
          else r[0] = "";
          if (dt.Columns[1].DataType == System.Type.GetType("System.Int32")) r[1] = 0;
          else r[1] = "";
          dt.Rows.InsertAt(r, 0);
        }
        cbo.DataSource = dt;
        if (col1 != "") cbo.DisplayMember = col1;
        else cbo.DisplayMember = dt.Columns[1].ColumnName;
        if (col0 != "") cbo.ValueMember = col0;
        else cbo.ValueMember = dt.Columns[0].ColumnName;
      }
    }

    public static void MailDuBLauClient(int nActnum)
    {

      // recherche des infos
      SqlDataReader rsLoad = MozartDatabase.ExecuteReader($"EXEC api_sp_RechercheInfoMailBLClient {nActnum}");

      // si pas d'info, c'est qu'il manque le mail du site
      if (rsLoad.Read())
      {

        // génération du BL
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TBordereau",
          sIdentifiant = $"{nActnum}|S|M",
          InfosMail = "0|0|0;",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PDF",
          strType = "PDF"
        }.ShowDialog();

        if (rsLoad["VCSITMAI"].ToString() != "")
        {
          // chemin du serveur de mail
          string sPJ = $"\\\\{MozartParams.NomServeur}\\PJMail\\{nActnum}.pdf";
          File.Copy($"{MozartParams.CheminUtilisateurMozart}\\PDF\\{nActnum}.pdf", sPJ, true);

          string Sujet = $"Livraison Colis EMALEC – DI Emalec [{rsLoad["NDINNUM"]}] – Ref client : [{rsLoad["VACTNUMCDE"]}] – GMAO [{rsLoad["VACTNUMGMAO"]}]";
          string Message = $"Bonjour,\r\n\r\n";
          Message = Message + "Vous allez recevoir dans les jours à venir un colis de la part d’Emalec dont le contenu est décrit en pièce jointe pour l’intervention suivante :\r\n\r\n";
          Message = Message + rsLoad["VACTDES"] + Environment.NewLine + Environment.NewLine;
          Message = Message + "Nos équipes prendront contact ultérieurement avec vous pour valider la date de rendez-vous.\r\n\r\n";
          Message = Message + "A bientôt,";

          Message = Message.Replace("'", "''");
          Sujet = Sujet.Replace("'", "''");

          string sSql = "EXEC msdb..sp_send_dbmail ";
          sSql += "@profile_name = 'Web" + MozartParams.NomSociete + "', ";
          sSql += "@recipients   = '" + rsLoad["VCSITMAI"] + "', ";
          sSql += "@body         = '" + Message + "', ";
          sSql += "@subject      = '" + Sujet + "', ";
          sSql += "@file_attachments = '" + Strings.Replace(sPJ, "'", "''") + "' ";
          sSql += ", @blind_copy_recipients ='info@emalec.com'";

          MozartDatabase.ExecuteNonQuery(sSql);
        }

      }
      rsLoad.Close();

    }
  }

  public static class DateTimePickerExtensions
  {
    [DllImport("user32")]
    static extern int SendMessage(IntPtr hWnd, uint uMsg, int wParam, int lParam);

    private const int WM_LBUTTONDOWN = 0x0201;
    private const int WM_LBUTTONUP = 0x0202;

    public static void ShowCalendar(this DateTimePicker picker, MouseEventArgs clickEvent)
    {
      if (picker != null)
      {
        // Remove any existing event to prevent an infinite loop.
        //var suppressor = new EventSuppressor(picker);
        //suppressor.Suppress();

        // Get the position on the button.
        int x = picker.Width - 10;
        int y = picker.Height / 2;
        int lParam = x + y * 0x00010000;

        picker.Left = clickEvent.X;
        picker.Top = clickEvent.Y;
        // Ignore if the calendar button was clicked
        //if (clickEvent.X < picker.Width - 35)
        //{
        SendMessage(picker.Handle, WM_LBUTTONDOWN, 1, lParam);
        SendMessage(picker.Handle, WM_LBUTTONUP, 1, lParam);
        //}

        //suppressor.Resume();
      }
    }
  }


  public static class MozartColors
  {
    public static Color ColorH80FFFF = Color.FromArgb(255, 255, 128); 
    public static Color ColorHC0FFFF = Color.FromArgb(255, 255, 192);
    public static Color colorHC0C0FF = Color.FromArgb(255, 192, 192);
    public static Color colorHFFC0FF = Color.FromArgb(255, 192, 255);
    public static Color ColorHC0E0FF = Color.FromArgb(255, 224, 192);
    public static Color ColorHFFF0FF = Color.FromArgb(255, 240, 255);
    public static Color ColorH8080FF = Color.FromArgb(255, 128, 128);
    public static Color ColorH80FF00 = Color.FromArgb(255, 128, 0);
    public static Color ColorFF00000 = Color.FromArgb(255, 0, 0);
    public static Color colorHDBE6FD = Color.FromArgb(253, 230, 219);
    public static Color colorHEEFFE3 = Color.FromArgb(227, 255, 238);
    public static Color colorHCCCCCC = Color.FromArgb(204, 204, 204);
    public static Color ColorHDDFFBB = Color.FromArgb(187, 255, 221);
    public static Color ColorHFF8080 = Color.FromArgb(128, 128, 255);
    public static Color ColorH80FF80 = Color.FromArgb(128, 255, 128);
    public static Color ColorHFFC0C0 = Color.FromArgb(192, 192, 255);
    public static Color ColorHFFFFC0 = Color.FromArgb(192, 255, 255);
    public static Color ColorHC0C0C0 = Color.FromArgb(192, 192, 192);
    public static Color ColorHC0FFC0 = Color.FromArgb(192, 255, 192);
    public static Color ColorHFFFF00 = Color.FromArgb(0, 255, 255);
    public static Color ColorHC000 = Color.FromArgb(0, 0, 192);
    public static Color ColorH8000000F = SystemColors.ButtonFace;
  }

  public static class KeyValidator
  {
    public static void KeyPress_SaisieMontant(KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Back) return;
      if (e.KeyChar == ',') return;
      if (e.KeyChar == '.') e.KeyChar = ',';
      else if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
    }

    public static void KeyPress_SaisieNombre(KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Back) return;
      else if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
    }
  }

  /// <summary>
  /// Affichage des tooltip sur les colonnes "CTECCOD", "CPRECOD", "CETACOD"
  /// </summary>
  public class TooltipGridTPE
  {
    apiTGrid _grid;
    DataTable dtTooltip = new DataTable();

    public TooltipGridTPE(apiTGrid grille, ToolTipController tooltipCtrl)
    {
      _grid = grille;

      ModuleData.LoadData(dtTooltip, $"exec api_sp_TooltipCode '{MozartParams.Langue}'");
      grille.GridControl.ToolTipController = tooltipCtrl;
      grille.GridControl.ToolTipController.AutoPopDelay = 10 * 60 * 1000;
      tooltipCtrl.GetActiveObjectInfo += toolTipController1_GetActiveObjectInfo;
    }

    private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
    {
      if (e.Info == null && e.SelectedControl == _grid.GridControl)
      {
        GridHitInfo info = _grid.dgv.CalcHitInfo(e.ControlMousePosition);
        // Il faut faire les 3 colonnes
        string[] cols = { "CTECCOD", "CPRECOD", "CETACOD", "CETATADMINCPL", "CETATCPL" };
        if (info.InRowCell && Array.Exists(cols, element => element == info.Column.Name))
        {
          string lettre = _grid.dgv.GetRowCellDisplayText(info.RowHandle, info.Column);
          string cellKey = info.RowHandle.ToString() + ":" + info.Column.ToString();
          e.Info = new ToolTipControlInfo(cellKey, GetTooltipTextForColumn(info.Column.Name, lettre));
        }
      }
    }

    string GetTooltipTextForColumn(string column, string txt)
    {
      foreach (DataRow row in dtTooltip.Rows)
        if ((string)row["CODE"] == column && (string)row["CTECCOD"] == txt)
          return (string)row["VTECLIB"];
      return txt;
    }

  }

  

}
