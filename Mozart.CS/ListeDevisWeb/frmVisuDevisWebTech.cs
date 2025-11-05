using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmVisuDevisWebTech : Form
  {
    public frmVisuDevisWebTech() { InitializeComponent(); }

    public string gsCodeRetour = "";

    public string mBrowseText = "";
    public string mStartingAddress = "";
    public bool mbPrintAuto;
    public string mInfosMail = "";
    public string mInfosMail2 = "";
    public bool mbcmdFicheTech;
    public bool mbSTFAccessWeb;

    string sMessageAvert;

    const int OLECMDID_PRINT = 6;
    const int OLECMDEXECOPT_DONTPROMPTUSER = 2;

    private void frmVisuDevisWebTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // pour l'impression des Datagrid

        if (mBrowseText != "")
        {
          string sFile = Path.GetTempPath();
          File.WriteAllText(sFile, mBrowseText);
          mStartingAddress = sFile;
        }
        if (mStartingAddress.Length > 0)
        {
          brwWebBrowser.Navigate(mStartingAddress);
          brwWebBrowser.Visible = true;
        }

        Cursor = Cursors.Default;
        ToolTip tt = new ToolTip();
        tt.SetToolTip(cmdPrint, MozartParams.Printer);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //  On Error Resume Next
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  ' pour l'impression des Datagrid
    //  If BrowseText <> "" Then StartingAddress = CreerHTMLFile(BrowseText)
    //  
    //  If Len(StartingAddress) > 0 Then
    //    brwWebBrowser.Navigate StartingAddress
    //    brwWebBrowser.Visible = True
    //  End If
    //  Screen.MousePointer = vbDefault
    //  
    //  cmdPrint.ToolTipText = gstrPrinter
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    /*
    public static class PrinterClass
    {
      [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
      public static extern bool SetDefaultPrinter(string Printer);
    }*/
    /* --------------------------------------------------------------------------------------- */
    // pas de fax
    private void cmdFax_Click(object sender, EventArgs e)
    {
      /*
      try
      {
        //eQuery = brwWebBrowser.QueryStatusWB(OLECMDID_PRINT)
        brwWebBrowser.Focus();
        if (mbSTFAccessWeb)
        {
          sMessageAvert = Resources.msg_WarningEnvoieNonObligatoire;
        }
        else
        {
          sMessageAvert = Resources.msg_WarningMailsOverFaxs;
        }
        if (MessageBox.Show(sMessageAvert, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.No)
        {
          return;
        }
        //if(Err == 0)
        //{
        //  //if (eQuery && OLECMDF_ENABLED)
        //  //{
        //  //  brwWebBrowser.ExecWRB(OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER, 0, 0);
        //  //}
        //}else{
        //  MessageBox.Show(Resources.msg_ImprimanteFaxNonInstall);
        //}
        //ReinitImprimanteWord();
        PrinterClass.SetDefaultPrinter("");
        //cmdPrint.ToolTipText = gstrPrinter;
        //toolTip1.Show(MozartParams.CheminUtilisateurstrPrinter, cmdPrint);
        Cursor.Current = Cursors.Default;
        //if (Err.Number != 0 && Err.Number != -2147221248)
        //{
        //  MessageBox.Show(Resources.msg_ErrorImpression + Err.Description);
        //}
        //Err = 0;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
                        Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      */
    }
    //Private Sub cmdFax_Click()
    //
    //Dim eQuery As OLECMDF       'return value type for QueryStatusWB
    //
    //  On Error Resume Next
    //    
    //  'get print command status
    //  eQuery = brwWebBrowser.QueryStatusWB(OLECMDID_PRINT)
    //  
    //  brwWebBrowser.SetFocus
    //  
    //  If Err.Number = 0 Then
    //    If eQuery And OLECMDF_ENABLED Then
    //      brwWebBrowser.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_PROMPTUSER, 0, 0   'Ok to Print?
    //    Else
    //      MsgBox "L'impression Internet Explorer n'est pas disponible."
    //    End If
    //  End If
    //    
    //  ReinitImprimanteWord
    //  cmdPrint.ToolTipText = gstrPrinter
    // 
    //  Me.MousePointer = vbDefault
    //  If Err.Number <> 0 And Err.Number <> -2147221248 Then MsgBox "Erreur d'impression : " & Err.Description
    //  Err = 0
    //  
    //End Sub
    //

    /*  ok --------------------------------------------------------------------------------------- */
    private void cmdPrint_Click(object sender, EventArgs e)
    {
      try
      {
        brwWebBrowser.Focus();
        if (mbSTFAccessWeb)
          sMessageAvert = Resources.msg_WarningEnvoieNonObligatoire;
        else
          sMessageAvert = Resources.msg_WarningMailsOverFaxs;

        if (!mbPrintAuto)
          if (MessageBox.Show(sMessageAvert, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.No)
            return;

        dynamic iwb2 = brwWebBrowser.ActiveXInstance;
        iwb2.ExecWB(OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER, 0, 0);
        Cursor.Current = Cursors.Default;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdrint_Click()
    //
    //Dim eQuery As OLECMDF       'return value type for QueryStatusWB
    //
    //  On Error Resume Next
    //  
    //  brwWebBrowser.SetFocus
    //  
    //  eQuery = brwWebBrowser.QueryStatusWB(OLECMDID_PRINT)  'get print command status
    //  
    //  If Err.Number = 0 Then
    //    If eQuery And OLECMDF_ENABLED Then
    //      brwWebBrowser.ExecWB OLECMDID_PRINT, OLECMDEXECOPT_DONTPROMPTUSER, 0, 0     'Ok to Print?
    //    Else
    //      MsgBox "L'impression Internet Explorer n'est pas disponible."
    //    End If
    //  End If
    //  
    //  Me.MousePointer = vbDefault
    //  If Err.Number <> 0 And Err.Number <> -2147221248 Then MsgBox "Erreur d'impression : " & Err.Description
    //  
    //End Sub
    //
    /* OK--------------------------------------------------------------------------------------- */
    private void cmdExit_Click(object sender, EventArgs e)
    {
      //  passage du code de retour
      gsCodeRetour = "";
      mInfosMail = "";
      mInfosMail2 = "";

      Dispose();
    }
    //Private Sub cmdExit_Click()
    //  ' passage du code de retour
    //  gsCodeRetour = ""
    //  InfosMail = ""
    //  InfosMail2 = ""
    //  Unload Me
    //End Sub
    //
    /* OK--------------------------------------------------------------------------------------- */
    // => anchor
    //Private Sub Form_Resize()
    //  On Error Resume Next    'dans le cas du WindowState = minimize
    //  If bPrintAuto Then
    //    Me.WindowState = 1
    //  Else
    //    brwWebBrowser.width = Me.ScaleWidth - 150
    //    brwWebBrowser.height = Me.ScaleHeight - 1050
    //    brwWebBrowser.SetFocus
    //  End If
    //End Sub
    //
    /* a priori ok--------------------------------------------------------------------------------------- */
    public void Preview_Print(string strFileIn,
                              string strFileOut,
                              string[,] tGlobal,
                              string strSQL,
                              string strErreur,
                              string strAction,
                              ADODB.Connection lCnx = null,
                              bool bCnx = false)
    {
      try
      {
        //   ' instanciation de l'objet
        ADODB.Connection cnxVisu;
        //' affichage curseur
        Cursor.Current = Cursors.WaitCursor;
        //  ' affectation de la connexion
        if (bCnx)
          cnxVisu = lCnx;
        else
        {
          cnxVisu = new ADODB.Connection
          {
            ConnectionString = $"Provider=SQLOLEDB.1;Data Source={MozartParams.NomServeur};Initial Catalog=MULTI;trusted_connection=yes;APP={MozartParams.NomSociete}",
            CursorLocation = ADODB.CursorLocationEnum.adUseClientBatch
          };
          cnxVisu.Open();
        }

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
          this.mBrowseText = "";
          this.mbPrintAuto = (strAction == "PRINT");
          this.mStartingAddress = strFileOutLong;

          this.ShowDialog();

          // frmBrowser fait référence à la fenêtre déjà ouverte et non pas à celle que l'on va afficher
          if (mbcmdFicheTech)
            this.WindowState = FormWindowState.Normal;
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
    //Public Sub Preview_Print(ByVal strFileIn As String, _
    //                         strFileOut As String, _
    //                         tGlobal(), _
    //                         strSQL As String, _
    //                         strErreur As String, _
    //                         strAction As String, _
    //                         Optional lCnx As ADODB.Connection, _
    //                         Optional bCnx As Boolean = False)
    //
    //Dim Ret%
    // 
    //
    //
    //   ' instanciation de l'objet
    //  Set objGenEtat = New GenEtat
    //  If Err.Number <> 0 Then MsgBox Err.Description
    //    
    //  ' affichage curseur
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' affectation de la connexion
    //  If bCnx = False Then
    //    Set objGenEtat.Connection = cnx
    //  Else
    //    Set objGenEtat.Connection = lCnx
    //  End If
    //
    //  ' affectation du modele
    //    objGenEtat.Modele = strFileIn
    //  objGenEtat.Result = gstrCheminUtilisateur & "\Mozart" & strFileOut
    //  objGenEtat.Globals = tGlobal()
    //  objGenEtat.sql = strSQL
    //    
    //  ' génération du fichier
    //  Ret% = objGenEtat.GenEtatMkRTF()
    //    
    //  ' si il y a une erreur, on supprime le processus word en cause
    //  If Ret% Then
    //    ' si erreur, on kill le processus word et on relance genetat
    //    EndWordProcess Mid(strFileOut, 2)
    //    ' génération du fichier
    //    Ret% = objGenEtat.GenEtatMkRTF()
    //  End If
    //  
    //    
    //  ' si il y a encore une erreur, on supprime tous les processus word
    //  If Ret% Then
    //    ' si erreur, on kill le processus word et on relance genetat
    //    EndAllWordProcess
    //    ' génération du fichier
    //    Ret% = objGenEtat.GenEtatMkRTF()
    //  End If
    //  
    //  If Ret% Then
    //    Screen.MousePointer = vbDefault
    //    MsgBox objGenEtat.LastError & strErreur
    //  Else
    //  '  TypeBrowser = "HTML"
    //    Me.bPrintAuto = (strAction = "PRINT")
    //    Me.BrowseText = ""
    //    Me.StartingAddress = objGenEtat.Result
    //'    frmBrowser.bPlanningAn = 0
    //    Screen.MousePointer = vbDefault
    //    
    //    ' frmBrowser fait référence à la fenêtre déjà ouverte et non pas à celle que l'on va afficher
    //    If frmBrowser.bcmdFicheTech Then Me.WindowState = vbNormal
    //    Me.Show vbModal     ' Mail possible
    //  End If
    //  
    //'  If Err Then MsgBox Err.Description & strErreur
    //  
    //  ' liberation de l'objet
    //  Set objGenEtat = Nothing
    //
    //End Sub
    //

  }
}

