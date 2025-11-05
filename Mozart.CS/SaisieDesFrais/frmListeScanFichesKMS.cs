using System;
using System.IO;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MozartNet;
using MozartCS.Properties;
using System.Collections.Generic;
using MozartLib;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeScanFichesKMS : Form
  {
    int i = 0;
    int iNbFiche = 0;
    List<string> lstFiles = new List<string>();
    string sCheminFicheScan;
    string sCheminFicheArchi;

    public string mP_DATESEM;
    public int mP_NPERNUM;
    public int mP_NVEHNUM;
    //Dim tFiles() As String
    //Dim i As Integer
    //Dim NbFiche As Integer
    //Dim cChFicheScan As String
    //Dim cChFicheArchi As String
    //
    //Public P_NPERNUM As Integer
    //Public P_NVEHNUM As Integer
    //Public P_DATESEM As String
    public frmListeScanFichesKMS()
    {
      InitializeComponent();
    }

    /* OK Trouver un exemple avec des files--------------------------------------------------------------------------*/
    private void frmListeScanFichesKMS_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        //  on définit le chemin des fiches scannées
        if (MozartParams.NomSociete == "EMALEC")
          sCheminFicheScan = Utils.RechercheParam("REP_FICHESKMS") + MozartParams.NomSociete + "\\SCAN\\";
        else
          sCheminFicheScan = Utils.RechercheParam("REP_SCAN") + "\\";

        sCheminFicheArchi = Utils.RechercheParam("REP_FICHESKMS") + MozartParams.NomSociete + "\\ARCHIVES\\";

        LoadPdfFiles();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo Handler
    //  
    //  InitBoutons Me, frmMenu
    //
    //  'on défini le chemin des fiches scannées
    //  If gstrNomSociete = "EMALEC" Then
    //    cChFicheScan = RechercheParam("REP_FICHESKMS") & gstrNomSociete & "\SCAN\"
    //  Else
    //    cChFicheScan = RechercheParam("REP_SCAN") & "\"
    //  End If
    //  cChFicheArchi = RechercheParam("REP_FICHESKMS") & gstrNomSociete & "\ARCHIVES\"
    //
    //  InitPdfFiles 0
    //  Exit Sub
    //
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub


    /* OK--------------------------------------------------------------------------*/
    private void cmdFirst_Click(object sender, EventArgs e)
    {
      i = 0;
      InitPdfFiles(i);
    }
    //Private Sub cmdFirst_Click()
    //    i = 0
    //    InitPdfFiles (i)
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdPrev_Click(object sender, EventArgs e)
    {
      InitPdfFiles(--i);
    }
    //Private Sub cmdPrev_Click()
    //  If i > 0 Then
    //    i = i - 1
    //    InitPdfFiles (i)
    //  End If
    //End Sub

    /*OK --------------------------------------------------------------------------*/
    private void cmdNext_Click(object sender, EventArgs e)
    {
      InitPdfFiles(++i);
    }
    //Private Sub cmdNext_Click()
    //  If i < NbFiche - 1 Then
    //    i = i + 1
    //    InitPdfFiles (i)
    //  End If
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdLast_Click(object sender, EventArgs e)
    {
      i = iNbFiche - 1;
      InitPdfFiles(i);
    }
    //Private Sub cmdDernier_Click()
    //  i = NbFiche - 1
    //  InitPdfFiles i, True
    //End Sub

    private void LoadPdfFiles()
    {
      lstFiles.Clear();
      foreach (var item in Directory.GetFiles(sCheminFicheScan, "*.pdf"))
        lstFiles.Add(Path.GetFileName(item));
      iNbFiche = lstFiles.Count;
      i = 0;
      InitPdfFiles(i);
    }

    private void InitPdfFiles(int iPos)
    {
      try
      {
        if (lstFiles.Count == 0)
        {
          this.Text = Resources.txt_NoFicheScan;
          Pdf1.Navigate("");
          cmdFirst.Enabled = cmdPrev.Enabled = cmdNext.Enabled = cmdLast.Enabled = cmdDel.Enabled = cmdOK.Enabled = false;
        }
        else
        {
          Pdf1.Navigate(sCheminFicheScan + lstFiles[iPos]);

          cmdFirst.Enabled = iPos != 0;
          cmdPrev.Enabled = iPos > 0;
          cmdNext.Enabled = iPos + 1 < iNbFiche;
          cmdLast.Enabled = iPos + 1 < iNbFiche;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //private void InitPdfFiles(int iPosInitiale, bool PosLastFiche)
    //{
    //  try
    //  {
    //    i = 0;
    //    Array.Resize(ref lstFiles, 1);
    //    iNbFiche = i;
    //    if (iPosInitiale == 0)
    //      i = 0;
    //    else
    //    {
    //      if (i == iNbFiche - 1)
    //        i = iNbFiche - 1;
    //      else
    //      {
    //        if (iNbFiche > 1)
    //          i = iPosInitiale;
    //        else
    //          i = iPosInitiale - 1;
    //      }
    //    }
    //    //si on ve le dernier fax reçu, on force a se positionner sur le dernier
    //    if (PosLastFiche == true)
    //      i = iNbFiche - 1;

    //    //gestion des boutons
    //    if (i == 0 && iNbFiche > 1)
    //    {
    //      cmdPrev.Enabled = false;
    //      cmdNext.Enabled = true;
    //    }
    //    else
    //    {
    //      if (i == 0 && iNbFiche == 1)
    //      {
    //        cmdPrev.Enabled = false;
    //        cmdNext.Enabled = false;
    //      }
    //      else
    //      {
    //        if (i == iNbFiche - 1 && iNbFiche > 1)
    //        {
    //          cmdPrev.Enabled = true;
    //          cmdNext.Enabled = false;
    //        }
    //        else
    //        {
    //          if (i == iNbFiche - 1 && iNbFiche == 1)
    //          {
    //            cmdPrev.Enabled = false;
    //            cmdNext.Enabled = false;
    //          }
    //          else
    //          {
    //            cmdPrev.Enabled = true;
    //            cmdNext.Enabled = true;
    //          }
    //        }
    //      }
    //    }
    //    if (lstFiles[i] != "")
    //    {
    //      Pdf1.Navigate(mcChFicheScan + lstFiles[i]);
    //    }
    //    else
    //    {
    //      Pdf1.Navigate("about:blank");
    //      cmdOK.Enabled = false;
    //      cmdFirst.Enabled = false;
    //      cmdPrev.Enabled = false;
    //      cmdNext.Enabled = false;
    //      cmdLast.Enabled = false;
    //      cmdDel.Enabled = false;
    //      this.Text = Resources.txt_NoFicheScan;
    //    }

    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
    //                    Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //  }
    //}
    //Private Sub InitPdfFiles(iPosInitiale As Integer, Optional PosLastFiche As Boolean)
    //Dim fs As New FileSystemObject
    //Dim F As File
    //
    //  On Error GoTo Handler:
    //
    //  i = 0
    //  ReDim tFiles(1)
    //  ReDim tFiles(fs.GetFolder(cChFicheScan).Files.count)
    //
    //  For Each F In fs.GetFolder(cChFicheScan).Files
    //    If UCase(Right(F, 3)) = "PDF" Then
    //      tFiles(i) = F.Name
    //      i = i + 1
    //    End If
    //  Next
    //  NbFiche = i
    //  If iPosInitiale = 0 Then
    //    i = 0
    //  ElseIf i = NbFiche - 1 Then
    //    i = NbFiche - 1
    //  ElseIf NbFiche > 1 Then
    //    i = iPosInitiale
    //  Else
    //    i = iPosInitiale - 1
    //  End If
    //  
    //  'si on ve le dernier fax reçu, on force a se positionner sur le dernier
    //  If PosLastFiche = True Then i = NbFiche - 1
    //  
    //  'gestion des boutons
    //  If i = 0 And NbFiche > 1 Then
    //    cmdPrev.Enabled = False
    //    cmdNext.Enabled = True
    //  ElseIf i = 0 And NbFiche = 1 Then
    //    cmdPrev.Enabled = False
    //    cmdNext.Enabled = False
    //  ElseIf i = NbFiche - 1 And NbFiche > 1 Then
    //    cmdPrev.Enabled = True
    //    cmdNext.Enabled = False
    //  ElseIf i = NbFiche - 1 And NbFiche = 1 Then
    //    cmdPrev.Enabled = False
    //    cmdNext.Enabled = False
    //  Else
    //    cmdPrev.Enabled = True
    //    cmdNext.Enabled = True
    //  End If
    //    
    //  If tFiles(i) <> "" Then
    //    Pdf1.Navigate2 cChFicheScan & tFiles(i)
    //  Else
    //    Pdf1.Navigate2 "about:blank"
    //    cmdOK.Enabled = False
    //    cmdFirst.Enabled = False
    //    cmdPrev.Enabled = False
    //    cmdNext.Enabled = False
    //    cmdDernier.Enabled = False
    //    cmdDel.Enabled = False
    //    Me.Caption = "Aucun fiche scannée"
    //  End If
    //  Exit Sub
    //  
    //Handler:
    //  ShowError "InitPdfFiles dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdOK_Click(object sender, EventArgs e)
    {
      try
      {
        // on enregistre le fichier dans la base
        long result = (long)ModuleData.ExecuteScalarInt($"EXEC api_sp_CreationFicheKMS {mP_NPERNUM}, {mP_NVEHNUM}, '{mP_DATESEM}', '{lstFiles[i]}'");

        // on copie le fichie ficheir dans ARCHIVES
        File.Copy(sCheminFicheScan + lstFiles[i], sCheminFicheArchi + result);
        System.Threading.Thread.Sleep(1000);

        File.Delete(sCheminFicheScan + lstFiles[i]);
        System.Threading.Thread.Sleep(1000);

        //'recharge le tableau
        LoadPdfFiles();

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdOK_Click()
    //
    //Dim adoresult As New ADODB.Recordset
    //
    //On Error GoTo Handler:
    //    
    //    Pdf1.Navigate2 "about:blank"
    //    Pause 1
    //            
    //    'on enregistre le fichier dans la base
    //    Set adoresult = cnx.Execute("EXEC api_sp_CreationFicheKMS " & P_NPERNUM & ", " & P_NVEHNUM & ", '" & P_DATESEM & "', '" & tFiles(i) & "'")
    //    
    //    'on copie le fichie ficheir dans ARCHIVES
    //    FileCopy cChFicheScan & tFiles(i), cChFicheArchi & adoresult(0)
    //    
    //    Pause 1
    //    Kill cChFicheScan & tFiles(i)
    //    Pause 1
    //    
    //    'recharge le tableau
    //    InitPdfFiles (0)
    //
    //    If adoresult.state = adStateOpen Then adoresult.Close
    //
    //    Unload Me
    //    
    //Exit Sub
    //Resume
    //Handler:
    //    ShowError "cmdOK_Click dans " & Me.Name
    //    Err.Clear
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdDel_Click(object sender, EventArgs e)
    {
      try
      {
        if (MessageBox.Show(Resources.msg_ConfirmDelFile, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // il faut fermer le fichier avant de le supprimer
          Pdf1.Navigate("");
          // test fichier existe
          if (File.Exists(sCheminFicheScan + lstFiles[i]) == true)
          {
            System.Threading.Thread.Sleep(1000);
            File.Delete(sCheminFicheScan + lstFiles[i]);
            // test di fichier est présent dans ma table alors on l enleve
            // recharge le tableau
            LoadPdfFiles();
          }
          else
            MessageBox.Show(Resources.msg_FileAlreadyUsedCannotDel, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdDel_Click()
    //
    //On Error GoTo Handler:
    //
    //  If MsgBox("§Voulez vous vraiment supprimer cette fiche ?§", vbYesNo) = vbYes Then
    //    ' il faut fermer le fichier avant de le supprimer
    //    Pdf1.Navigate2 "about:blank"
    //    'test fichier existe
    //    If Dir$(cChFicheScan & tFiles(i)) <> "" Then
    //      Pause 1
    //      Kill cChFicheScan & tFiles(i)
    //      'test di fichier est présent dans ma table alors on l enleve
    //      'recharge le tableau
    //      InitPdfFiles (0)
    //    Else
    //      InitPdfFiles (0)
    //      MsgBox "§Ce fichier est utilisé par un autre utilisateur!Impossible de supprimer§", vbCritical
    //    End If
    //  End If
    //
    //Exit Sub
    //Resume
    //Handler:
    //    ShowError "cmdDel_Click dans " & Me.Name
    //    Err.Clear
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub

  }
}

