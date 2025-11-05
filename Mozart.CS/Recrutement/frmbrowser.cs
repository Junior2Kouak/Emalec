using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmBrowser : Form
  {
    public string gsCodeRetour = "";
    public string msBrowseText = "";
    public string msStartingAddress = "";
    public string msInfosMail = "";
    public string msInfosMail2 = "";
    public string mstrType = "";
    public bool mbPrintAuto;
    public bool mbFleches;
    public bool mbSTFAccessWeb;
    public bool mbcmdFicheTech;
    public int miPlanningAn = 0;
    public int minpernum;
    public long mlNumRavel;
    public DateTime mddate = DateTime.Now;
    public bool bPrintable = true;

    apifrmToolPic apiToolPic1;
    string sMessageAvert;

    int OLECMDID_PRINT = 6;
    int OLECMDEXECOPT_PROMPTUSER = 1;
    int OLECMDEXECOPT_DONTPROMPTUSER = 2;

    public frmBrowser()
    {
      InitializeComponent();
    }

    private void frmBrowser_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        cmdSuiv.Visible = cmdPrec.Visible = mbFleches;

        //affichage bouton lien vers ravel
        if (mlNumRavel > 0 && MozartParams.RoleFacturation == "OUI")
          cmdRavel.Visible = true;

        cmdFicheTech.Visible = mbcmdFicheTech;

        if (apiToolPic1 != null)
          apiToolPic1.Visible = mbcmdFicheTech;

        if (mstrType == "GEOLOC")
        {
          //Affichage du planning de la journée
          AffichePlanning(mddate.ToString());
          mstrType = "";
        }

        if (mstrType == "PRESTBR")
        {
          //Affichage du planning de la journée
          cmdMail.Visible = false;
          mstrType = "";
        }

        //pour l'impression des Datagrid
        if (msBrowseText != "")
        {
          string sFile = Path.GetTempPath();
          File.WriteAllText(sFile + "Preview.html", msBrowseText);
          msStartingAddress = sFile;
        }

        cmdPrintChoix.Visible = cmdPrint.Visible = bPrintable;

        if (msStartingAddress.Length > 0)
        {
          if (msStartingAddress.EndsWith(".xlsx") || msStartingAddress.EndsWith(".xls") || msStartingAddress.EndsWith(".doc") || msStartingAddress.EndsWith(".docx") || msStartingAddress.EndsWith(".rtf"))
          {
            webView21.Visible = false;
            brwWebBrowser.Navigate(msStartingAddress);
            brwWebBrowser.Visible = true;
          }
          else
          {
            brwWebBrowser.Visible = false;
            webView21.Source = new Uri(msStartingAddress);
            webView21.Visible = true;
          }
        }

        toolTip1.SetToolTip(cmdPrint, MozartParams.Printer);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private async void cmdFicheTech_Click(object sender, EventArgs e)
    {
      try
      {
        int miNumPer = 0;

        string Adr = await webView21.ExecuteScriptAsync("document.getElementById('tech').value;");
        if (Adr == null)
        {
          Adr = "";
        }
        else
        {
          Adr = Adr.Trim().Replace("\"", "");
        }

        miNumPer = (Adr == "") ? 0 : Convert.ToInt32(Adr);

        string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };
        //récupération dans le contenu de la page Web affichée du NPERNUM dans le champ hidden "tech"       

        frmBrowser F = new frmBrowser();
        F.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TFichePersonnelPhoto2.rtf",
                       @"TFichePersonnel.Out.rtf",
                       TdbGlobal,
                       $"select * from api_v_InfoPersonnelRTF where NPERNUM = {miNumPer}",
                       " (Visualisation fiche personnel)",
                       "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      try
      {
        if (webView21.Visible)
        {
          webView21.CoreWebView2.ShowPrintUI();
        }
        else
        {
          brwWebBrowser.Focus();
          if (mbSTFAccessWeb)
            sMessageAvert = Resources.msg_WarningEnvoieNonObligatoire;
          else
            sMessageAvert = Resources.msg_WarningMailsOverFaxs;

          if (!mbPrintAuto)
            if (MessageBox.Show(sMessageAvert, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.No)
              return;

          if (mstrType == "GEOLOC")
          {
            this.ImprimerDansWord();
            return;
          }

          dynamic iwb2 = brwWebBrowser.ActiveXInstance;
          if (miPlanningAn == 1)
            //    ' impression du planning annuel
            iwb2.ExecWB(OLECMDID_PRINT, OLECMDEXECOPT_PROMPTUSER, null, null);
          else
            //    ' autres impressions 
            iwb2.ExecWB(OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER, 0, 0);
          Cursor.Current = Cursors.Default;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      //  ' Affichage, choix des destinataires et envoi du mail avec la pièce jointe
      try
      {
        if (msInfosMail == "")
          return;

        if (!mstrType.StartsWith("FA"))
        {
          new frmChoixDestMail()
          {
            mstrType = mstrType,
            msBrowserUrl = msStartingAddress,
            msInfosMail = msInfosMail,
          }.ShowDialog();
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdExit_Click(object sender, EventArgs e)
    {
      try
      {
        //  ' passage du code de retour
        gsCodeRetour = "0";
        msInfosMail = "";
        msInfosMail2 = "";
        cmdPrec.Visible = false;
        cmdSuiv.Visible = false;
        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdRavel_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(MozartParams.CheminProgramme + @"\Mozart\SynchroRavel.exe", MozartParams.NomServeur + ";" + MozartParams.NomSociete + ";" + mlNumRavel);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdPrec_Click(object sender, EventArgs e)
    {
      //  ' passage du code de retour
      gsCodeRetour = "P";
      Close();
    }

    private void cmdSuiv_Click(object sender, EventArgs e)
    {
      gsCodeRetour = "S";
      Close();
    }

    private void frmBrowser_Resize(object sender, EventArgs e)
    {
      try
      {
        if (mbPrintAuto)
          WindowState = FormWindowState.Minimized;
        else
        {
          brwWebBrowser.Width = ClientSize.Width - 30;
          brwWebBrowser.Height = ClientSize.Height - 110;
          webView21.Width = brwWebBrowser.Width;
          webView21.Height = brwWebBrowser.Height;

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void Preview_Print(string strFileIn,
                              string strFileOut,
                              string[,] tGlobal,
                              string strSQL,
                              string strErreur,
                              string strAction)
    {
      try
      {
        //   ' instanciation de l'objet
        ADODB.Connection cnxVisu;
        //' affichage curseur
        Cursor.Current = Cursors.WaitCursor;
        //  ' affectation de la connexion
          cnxVisu = new ADODB.Connection
          {
            ConnectionString = $"Provider=SQLOLEDB.1;Data Source={MozartParams.NomServeur};Initial Catalog=MULTI;trusted_connection=yes;APP={MozartParams.NomSociete}",
            CursorLocation = ADODB.CursorLocationEnum.adUseClientBatch
          };
          cnxVisu.Open();

        long ret;
        GenEtat objGenEtat = new GenEtat();

        // génération du fichier
        string strFileOutLong = MozartParams.CheminUtilisateurMozart + strFileOut;
        ret = objGenEtat.MkRTF(strFileIn, strFileOutLong, strSQL, ref cnxVisu, tGlobal);

        cnxVisu.Close();
        //    ' si erreur, on kill le processus word et on relance genetat
        if (ret > 0)
        {
          MessageBox.Show(strErreur + "\r\n\r\n\t" + objGenEtat.ReturnError(ret), "Error GenEtat");
        }
        else
        {
          msBrowseText = "";
          mbPrintAuto = (strAction == "PRINT");
          msStartingAddress = strFileOutLong;
          
          ShowDialog();

          // frmBrowser fait référence à la fenêtre déjà ouverte et non pas à celle que l'on va afficher
          if (mbcmdFicheTech)
            WindowState = FormWindowState.Normal;
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
    }

    private void AffichePlanning(string sDate)
    {
      int i = 0;
      string inter;
      int tempIplNum = 0;

      StringBuilder sb = new StringBuilder("");
      SqlDataReader rsIP;
      try
      {
        apiToolPic1 = new apifrmToolPic();
        apiToolPic1.PicMouseUp += new apifrmToolPic.PicMouseUpEventHandler(PicMouseUp); ;
        apiToolPic1.Owner = this;
        apiToolPic1.Show();
        apiToolPic1.Left = Width - apiToolPic1.Width - 4;
        apiToolPic1.Top = brwWebBrowser.Top + 30;
        apiToolPic1.Text = sDate;
        for (int p = 0; p < 9; p++)
          apiToolPic1.mBackColor(p, Color.FromArgb(255, 255, 192));

        //  ' placement des interventions
        using (rsIP = ModuleData.ExecuteReader($"api_sp_listeInterventions {minpernum} , '{sDate}', 0, 8"))
        {
          while (rsIP.Read())
          {
            i = Convert.ToInt32(rsIP["NIPLIND"]) - 1;
            sb.Clear();
            sb.Append("D#");
            sb.Append(rsIP["NIPLNUM"].ToString()); sb.Append("#");
            sb.Append(rsIP["NSITNUM"].ToString()); sb.Append("#0#");
            sb.Append(rsIP["VCLINOM"].ToString()); sb.Append("\r\n");
            sb.Append(rsIP["VSITNOM"].ToString()); sb.Append("\r\n"); sb.Append("#");
            sb.Append(rsIP["NIPLDUR"].ToString()); sb.Append("#");
            sb.Append(rsIP["CIPLDEB"].ToString()); sb.Append("#");
            sb.Append(rsIP["DIPLDATJ"].ToString()); sb.Append("#");
            sb.Append(rsIP["CIPLMULT"].ToString());
            apiToolPic1.SetTag(i, sb.ToString());

            if (rsIP["VCLINOM"].ToString() == MozartParams.NomSociete)
            {
              //' pour les sites emalec spéciaux couleur : jaune
              apiToolPic1.mBackColor(i, Color.Yellow);
            }
            else
            {
              apiToolPic1.mBackColor(i, Color.FromArgb(192, 255, 255));
              if (rsIP["CIPLMULT"].ToString() == "O")
                apiToolPic1.mBackColor(i, Color.FromArgb(0, 255, 255));     //' si multi-jour : bleu foncé
              if (rsIP["CACTNUIT"].ToString() == "O")
                apiToolPic1.mBackColor(i, Color.Red);       //' si c'est la nuit: rouge

              tempIplNum = Convert.ToInt32(rsIP["NIPLNUM"]);

              using (SqlDataReader rsCode = ModuleData.ExecuteReader($"exec api_sp_ControleDateExec_Attach {tempIplNum}"))
              {
                rsCode.Read();
                if (Convert.ToInt32(rsCode[0]) == 0)
                  apiToolPic1.mBackColor(i, Color.FromArgb(255, 193, 125));      //' si date d'execution: orange
                if (Convert.ToInt32(rsCode[1]) == 0)
                  apiToolPic1.mBackColor(i, Color.FromArgb(192, 255, 192));      //' si attachement (et exécution): Vert
              }

              //      ' si facture, et exec, et attach : blanc
              if (Convert.ToInt32(rsIP["nbfact"]) > 0 && apiToolPic1.GetBackColor(i) == Color.FromArgb(192, 255, 192))
                apiToolPic1.mBackColor(i, Color.White);
            }
            //  ' affichage des informations dans l'image
            if (rsIP["VACTHRRDV"].ToString() != "")
            {
              inter = $"{rsIP["VCLINOM"]}\r\n{rsIP["VSITNOM"]}\r\n {rsIP["NIPLDURJ"]}h  {rsIP["sCODE"]}\r\n RDV : {rsIP["VACTHRRDV"]}";
            }
            else
            {
              inter = $"{rsIP["VCLINOM"]}\r\n{rsIP["VSITNOM"]}\r\n {rsIP["NIPLDURJ"]}h  {rsIP["sCODE"]}";
            }

            if (Convert.ToInt32(rsIP["nbfact"]) > 0)
              inter += " ";

            if (Convert.ToInt32(rsIP["PrevMag"]) > 0)
              inter += "  #";

            apiToolPic1.Ecrire(i, inter);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void PicMouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        contextMenuStrip1.Show(Cursor.Position);
      }
    }

    private void mnuDetails_Click(object sender, EventArgs e)
    {
      String t = apiToolPic1.GetTag();
      if (t == "")
        return;

      int iNumIp;
      if (!int.TryParse(t.Split('#')[1], out iNumIp) || iNumIp == 0)
        return;

      new frmDetailIP()
      {
        miNumIP = iNumIp
      }.ShowDialog();
    }

    private void brwWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      try
      {
        if (brwWebBrowser.Url.ToString() == "")
          return;

        cmdMail.Visible = true;

        if (mbPrintAuto)
        {
          cmdPrint_Click(null, null);
          Thread.Sleep(1000);
          Close();
          mbPrintAuto = false;
        }
        else
          brwWebBrowser.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e)
    {
      mstrType = "";
      if (apiToolPic1 != null)
        apiToolPic1.Dispose();

      Dispose();
    }

    public void ImprimerFichier(string strFileIn, string strFileOut, string[,] tGlobal, string strSQL)
    {
      try
      {
        Microsoft.Office.Interop.Word.Application wdApp = new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

        GenEtat objGenEtat = new GenEtat();
        Cursor.Current = Cursors.WaitCursor;

        ADODB.Connection cnx = new ADODB.Connection
        {
          ConnectionString = $"Provider=SQLOLEDB.1;Data Source={MozartParams.NomServeur};Initial Catalog=MULTI;trusted_connection=yes;APP={MozartParams.NomSociete}",
          CursorLocation = ADODB.CursorLocationEnum.adUseClientBatch
        };
        cnx.Open();

        // génération du fichier
        string strFileOutLong = MozartParams.CheminUtilisateurMozart + strFileOut;
        long ret = objGenEtat.MkRTF(strFileIn, strFileOutLong, strSQL, ref cnx, tGlobal);

        if (ret != 0)
          MessageBox.Show(Resources.msg_printer_problem + "\r\nErreur GenEtat :" + objGenEtat.LastError, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
        {
          // récupération d'une instance de word et création sinon
          try
          {
            wdApp = (Microsoft.Office.Interop.Word.Application)Microsoft.VisualBasic.Interaction.GetObject(null, "word.application");
          }
          catch (Exception)
          {
            wdApp = (Microsoft.Office.Interop.Word.Application)Microsoft.VisualBasic.Interaction.CreateObject("word.application");
            wdApp.Visible = false;
            wdApp.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMinimize;
          }

#if APITECHTEST       // Ne pas imprimer mais rendre Word visible
          wdApp.Documents.Add(strFileOutLong);
          wdApp.Visible = true;
#else
          // Version sans ouvrir le fichier .doc ou .rtf
          if (wdApp.Documents.Count < 1)
            wdApp.Documents.Add();

          wdApp.PrintOut(FileName: strFileOutLong);
          /// modif MC le 05/11/10
          while (wdApp.BackgroundPrintingStatus > 0)
            Thread.Sleep(500);
#endif
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
    }

    private void cmdPrintChoix_Click(object sender, EventArgs e)
    {
      try
      {

        if (webView21.Visible == true)
        {
          webView21.CoreWebView2.ShowPrintUI();
        }
        else
        {

          brwWebBrowser.Focus();
          if (mbSTFAccessWeb)
            sMessageAvert = Resources.msg_WarningEnvoieNonObligatoire;
          else
            sMessageAvert = Resources.msg_WarningMailsOverFaxs;

          if (!mbPrintAuto)
            if (MessageBox.Show(sMessageAvert, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.No)
              return;

          if (mstrType == "GEOLOC")
          {
            this.ImprimerDansWord();
            return;
          }

          brwWebBrowser.ShowPrintDialog();

        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

