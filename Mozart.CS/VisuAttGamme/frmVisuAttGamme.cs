using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmVisuAttGamme : Form
  {
    public frmVisuAttGamme() { InitializeComponent(); }

    public string msFichier;
    public string msNewFichier;

    DataTable dt = new DataTable();
    string msFichierGamme;
    string msFichierAttach;
    string msFichierAttest;
    string mstrType;
    string msRepFic;        //' repertoire de stokage des documents PDF
    string msRepScan;       //' repertoire des scan

    int miImage;
    int miImageAttach;
    int miImageGamme;
    int miImageAttest;


    private void frmVisuAttGamme_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //  ' répertoire de stokage des documents PDF (sur serveur web)
        msRepFic = Utils.RechercheParam("REP_ATTGAM");
        //  ' pour les facturieres Emalec (qui travaillent sur Emalec et sur les autres societes)
        //TB SAMSIC CITY PATH
        if (MozartParams.NomGroupe == "EMALEC")
        {
          switch (MozartParams.strUID)
          {
            case "PAQUELET": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 129; break;
            case "BENAY": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 168; break;
            case "BUISSON": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 381; break;
            case "RUTY": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 1682; break;
            case "MONTAGNON": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 3083; break;
            case "REYNIER": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 1363; break;
            case "GONON": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 2762; break;
            case "JEANJEAN": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 3125; break;
            case "BENZAIT": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 4266; break;
            case "BRUNNER": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 4253; break;
            case "DUSSAUT": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 4561; break;
            case "ESCURE": msRepScan = Utils.RechercheParam("SCAN_ATT_GAM") + 4999; break;
            default: msRepScan = Utils.RechercheParam("REP_SCAN"); break;
          }
        }
        else // on garde le repertoire strRepScan par défaut
          msRepScan = Utils.RechercheParam("REP_SCAN");

        msFichierAttach = msFichierGamme = msFichierAttest = "";

        //recherche des attachements
        using (SqlDataReader dr = ModuleData.ExecuteReader("select VFICHIER, NIMAGE FROM TIMAC WITH (NOLOCK) where VTYPE = 'ATTACH' AND NACTNUM = " + MozartParams.NumAction))
        {
          if (dr.Read())
          {
            msFichierAttach = Utils.BlankIfNull(dr["VFICHIER"]);
            miImageAttach = (int)Utils.ZeroIfNull(dr["NIMAGE"]);
          }
        }

        //recherche des gammes
        using (SqlDataReader dr = ModuleData.ExecuteReader("select VFICHIER, NIMAGE FROM TIMAC WITH (NOLOCK) where VTYPE = 'GAMME' AND NACTNUM = " + MozartParams.NumAction))
        {
          if (dr.Read())
          {
            msFichierGamme = Utils.BlankIfNull(dr["VFICHIER"]);
            miImageGamme = (int)Utils.ZeroIfNull(dr["NIMAGE"]);
          }
        }

        //recherche des attestations
        using (SqlDataReader dr = ModuleData.ExecuteReader("select VFICHIER, NIMAGE FROM TIMAC WITH (NOLOCK) where VTYPE = 'ATTEST' AND NACTNUM = " + MozartParams.NumAction))
        {
          if (dr.Read())
          {
            msFichierAttest = Utils.BlankIfNull(dr["VFICHIER"]);
            miImageAttest = (int)Utils.ZeroIfNull(dr["NIMAGE"]);
          }
        }

        if (msFichierAttach != "")
        {
          mstrType = "ATTACH";
          msFichier = msFichierAttach;
          miImage = miImageAttach;
          Text = lblTitre.Text = Resources.txt_Visualisation_attachement;
          Pdf1.Navigate(msRepFic + msFichier);
        }
        else
        {
          if (msFichierGamme != "")
          {
            mstrType = "GAMME";
            msFichier = msFichierGamme;
            miImage = miImageGamme;
            Text = lblTitre.Text = Resources.txt_Visualisation_gamme;
            Pdf1.Navigate(msRepFic + msFichier);
          }
          else
          {
            if (msFichierAttest != "")
            {
              mstrType = "ATTEST";
              msFichier = msFichierAttest;
              miImage = miImageAttest;
              this.Text = lblTitre.Text = Resources.txt_Visualisation_attestation;
              Pdf1.Navigate(msRepFic + msFichier);
            }
            else
            {
              msFichier = "";
              miImage = 0;
              Pdf1.Navigate("about:blank");
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdvoirAttach_Click(object sender, EventArgs e)
    {
      mstrType = "ATTACH";
      msFichier = msFichierAttach;
      lblTitre.Text = Resources.txt_Visualisation_attachement;

      if (msFichierAttach != "")
      {
        miImage = miImageAttach;
        Pdf1.Navigate(msRepFic + msFichier);
      }
      else
      {
        miImage = 0;
        Pdf1.Navigate("about:blank");
      }
    }

    private void cmdAddAttach_Click(object sender, EventArgs e)
    {
      try
      {
        mstrType = "ATTACH";
        Cursor.Current = Cursors.WaitCursor;
        frmChoixImage f = new frmChoixImage { mForm = this, mstrDirPDFFiles = msRepScan };
        f.ShowDialog();

        msNewFichier = f.mstrNewFichier;

        Cursor.Current = Cursors.WaitCursor;

        if (msNewFichier != "")
        {
          if (msFichierAttach != "")
          {
            miImage = miImageAttach;
            msFichier = msFichierAttach;

            // le travail se passe dans PdfAsm.cmd, il faut libérer le fichier
            Pdf1.Navigate("about:blank");
            Size pdfSize = Pdf1.Size;
            Point pdfLocation = Pdf1.Location;
            AnchorStyles pdfAnchor = Pdf1.Anchor;
            Pdf1.Dispose();
            Pdf1 = null;
            Pdf1 = new WebBrowser();
            Pdf1.Size = pdfSize;
            Pdf1.Location = pdfLocation;
            Pdf1.Anchor = pdfAnchor;
            this.Controls.Add(Pdf1);

            Process p = new Process();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = $@"/C net use P: {msRepScan} & p:PdfAsm.cmd {msFichierAttach} {Strings.Mid(msNewFichier, Strings.InStrRev(msNewFichier, @"\") + 1)} {msRepFic}";
            p.Start();

            p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            int i = 0;
            //  On teste que le fichier disparaisse du répertoire avec un max de 5 secondes pour ne pas rester bloqué
            while (File.Exists(msRepScan + @"\" + msFichierAttach) && i < 20)
            {
              Thread.Sleep(1000);   // Pour laisser le temps à PdfAsm de travailler
              i++;
            }
          }
          else
          {
            Thread.Sleep(1000);
            miImage = 0;
            // c'est le premier fichier pdf. pas d'assemblage necessaire
            // il faut juste de copier dans le répertoire de stockage et dans les archives   
            msFichierAttach = Path.GetFileName(msNewFichier);
            File.Copy(msNewFichier, msRepFic + msFichierAttach, true);
            File.Delete(msNewFichier);
            msFichier = msFichierAttach;

            EnregistrerImg();

            //test si on est sur une action liée à une DI de filiale, si oui, il faut enregistrer l'attachement sur l'action liée
            // date de 2010, jamais mis en production
            //actionLiee = NumIsActionFiliale(MozartParams.NumAction);
            //if (actionLiee > 0)  TraiterFiliale(actionLiee);
          }
        }
        if (msNewFichier != "")
        {
          lblTitre.Text = Resources.txt_Visualisation_attachement;
          Pdf1.Navigate(msRepFic + msFichier);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdAddAttach_Click()
    //Dim sCmd As String
    //Dim fsx As New FileSystemObject
    // 
    //  strType = "ATTACH"
    //  Screen.MousePointer = vbHourglass
    //  Set frmChoixImage.mForm = Me
    //  frmChoixImage.mstrDirPDFFiles = strRepScan   ' chemin du repertoire scan
    //  frmChoixImage.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  If mstrNewFichier <> "" Then
    //    If sFichierAttach <> "" Then
    //        miImage = miImageAttach
    //        mstrFichier = sFichierAttach
    //        ' le travail se passe dans PdfAsm.cmd
    //        ' il faut libérer le fichier
    //        Pdf1.Navigate "About:Blank"
    //        Shell "Net Use P: " & strRepScan
    //        ' il faut laisser le temps au fichier d'être libéré et au net use de faire la connexion réseau
    //        Pause 1
    //        sCmd = "p:PdfAsm.cmd "
    //        sCmd = sCmd & sFichierAttach & " "
    //        sCmd = sCmd & Mid(mstrNewFichier, InStrRev(mstrNewFichier, "\") + 1) & " "
    //        sCmd = sCmd & strRepFic
    //        
    //        ' L'ajout se fait après
    //        ' pour ajouter le nouveau fichier avant il faut modifier
    //        ' le PdfAsm.cmd en ajoutant l'option "-z"
    //        Shell sCmd
    //        MsgWaitObj 1000
    //        i = 0
    //        ' on test que le fichier disparaisse du répertoire avec un max de 5 secondes pour ne pas rester bloqué
    //        While (fsx.FileExists(strRepScan & "\" & sFichierAttach) And i < 20)
    //          MsgWaitObj 1000   ' Pour laisser le temps à PdfAsm de travailler
    //          i = i + 1
    //        Wend
    //    Else
    //        Pause 1
    //
    //        miImage = 0
    //        ' c'est le premier fichier pdf. pas d'assemblage necessaire
    //        ' il faut juste de copier dans le répertoire de stockage et dans les archives
    //        fsx.MoveFile mstrNewFichier, strRepFic
    //'        fsx.CopyFile mstrNewFichier, strRepFic, True
    //'        fsx.DeleteFile mstrNewFichier
    //        
    //        sFichierAttach = fsx.GetFileName(mstrNewFichier)
    //        mstrFichier = sFichierAttach
    //        
    //        enregistrerImg
    //        
    //        ' test si on est sur une action lié a une di de filiale
    //        ' si oui, il faut enregistrer l'attachement sur l'action liée
    //        actionLiee = NumIsActionFiliale(glNumAction)
    //        If actionLiee > 0 Then
    //          TraiterFiliale actionLiee
    //        End If
    //
    //    End If
    //  End If
    //  
    //  If mstrNewFichier <> "" Then
    //    lblTitre.Caption = "§Visualisation de l'attachement§"
    //    Pdf1.Navigate strRepFic & mstrFichier
    //  End If
    //
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdSuppAttch_Click(object sender, EventArgs e)
    {
      try
      {
        if (mstrType != "ATTACH") return;

        if (MessageBox.Show(Resources.msg_Confirm_Del_Attachement, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          if (msFichier != "")
          {
            ModuleData.ExecuteNonQuery($"delete from TIMAC where VTYPE = 'ATTACH' AND NACTNUM = {MozartParams.NumAction}");
            Pdf1.Navigate("about:blank");
            Thread.Sleep(200);
            File.Delete(msRepFic + msFichier);

            msFichier = "";
            msFichierAttach = "";
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVoirGamme_Click(object sender, EventArgs e)
    {
      lblTitre.Text = Resources.txt_Visualisation_gamme;
      msFichier = msFichierGamme;
      mstrType = "GAMME";

      if (msFichierGamme != "")
      {
        miImage = miImageGamme;
        Pdf1.Navigate(msRepFic + msFichier);
      }
      else
      {
        miImage = 0;
        Pdf1.Navigate("about:blank");
      }
    }

    private void cmdAddGamme_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      mstrType = "GAMME";
      frmChoixImage f = new frmChoixImage { mForm = this, mstrDirPDFFiles = msRepScan };
      f.ShowDialog();

      msNewFichier = f.mstrNewFichier;

      Cursor.Current = Cursors.Default;

      if (msNewFichier != "")
      {
        if (msFichierGamme != "")
        {
          miImage = miImageGamme;
          msFichier = msFichierGamme;

          // le travail se passe dans PdfAsm.cmd, il faut libérer le fichier
          Pdf1.Navigate("about:blank");
          Size pdfSize = Pdf1.Size;
          Point pdfLocation = Pdf1.Location;
          AnchorStyles pdfAnchor = Pdf1.Anchor;
          Pdf1.Dispose();
          Pdf1 = null;
          Pdf1 = new WebBrowser();
          Pdf1.Size = pdfSize;
          Pdf1.Location = pdfLocation;
          Pdf1.Anchor = pdfAnchor;
          this.Controls.Add(Pdf1);

          Process p = new Process();
          p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
          p.StartInfo.RedirectStandardOutput = true;
          p.StartInfo.RedirectStandardError = true;
          p.StartInfo.UseShellExecute = false;
          p.StartInfo.CreateNoWindow = false;
          p.StartInfo.FileName = "cmd.exe";
          p.StartInfo.Arguments = $@"/C net use P: {msRepScan} & p:PdfAsm.cmd {msFichierGamme} {Strings.Mid(msNewFichier, Strings.InStrRev(msNewFichier, @"\") + 1)} {msRepFic}";
          p.Start();

          p.StandardOutput.ReadToEnd();
          p.WaitForExit();

          int i = 0;
          //  on test que le fichier disparaisse du répertoire avec un max de 5 secondes pour ne pas rester bloqué
          while (File.Exists($@"{msRepScan}\{msFichierAttach}") && i < 20)
          {
            Thread.Sleep(1000);
            i++;
          }
        }
        else
        {
          Thread.Sleep(1000);

          // c'est le premier fichier pdf.pas d'assemblage necessaire
          // il faut juste de copier dans le répertoire de stockage et dans les archives
          msFichierGamme = Path.GetFileName(msNewFichier);
          File.Copy(msNewFichier, msRepFic + msFichierGamme, true);
          File.Delete(msNewFichier);
          msFichier = msFichierGamme;

          EnregistrerImg();

          // test si on est sur une action lié a une di de filiale, si oui, il faut enregistrer l'attachement sur l'action liée
          // date de 2010, jamais mis en production
          //actionLiee = NumIsActionFiliale(MozartParams.NumAction);
          //if (actionLiee > 0) TraiterFiliale(actionLiee);
        }
      }
      if (msNewFichier != "")
      {
        lblTitre.Text = Resources.txt_Visualisation_gamme;
        Pdf1.Navigate(msRepFic + msFichier);
      }
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdAddGamme_Click()
    //
    //Dim sCmd As String
    //Dim fsx As New FileSystemObject
    // 
    //  Screen.MousePointer = vbHourglass
    //  strType = "GAMME"
    //  Set frmChoixImage.mForm = Me
    //  frmChoixImage.mstrDirPDFFiles = strRepScan
    //  frmChoixImage.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  If mstrNewFichier <> "" Then
    //    If sFichierGamme <> "" Then
    //        miImage = miImageGamme
    //        mstrFichier = sFichierGamme
    //        ' Ajout du fichier affiché (tFiles(i)) au fichier sélectionné (mstrFichier)
    //        ' le travail se passe dans PdfAsm.cmd
    //        Pdf1.Navigate "About:Blank"
    //        Shell "Net Use P: " & strRepScan
    //         ' il faut laisser le temps au fichier d'être libéré et au net use de faire la connexion réseau
    //        Pause 1
    //        sCmd = "p:PdfAsm.cmd "
    //        sCmd = sCmd & sFichierAttach & " "
    //        sCmd = sCmd & Mid(mstrNewFichier, InStrRev(mstrNewFichier, "\") + 1) & " "
    //        sCmd = sCmd & strRepFic
    //        ' L'ajout se fait après
    //        ' pour ajouter le nouveau fichier avant il faut modifier
    //        ' le PdfAsm.cmd en ajoutant l'option "-z"
    //        Shell sCmd
    //        MsgWaitObj 1000
    //        i = 0
    //        ' on test que le fichier disparaisse du répertoire avec un max de 5 secondes pour ne pas rester bloqué
    //        While (fsx.FileExists(strRepScan & "\" & sFichierAttach) And i < 20)
    //          MsgWaitObj 1000   ' Pour laisser le temps à PdfAsm de travailler
    //          i = i + 1
    //        Wend
    //        ' move dans le repertoire de stockage
    //'        fsx.MoveFile strRepScan & sFichierGamme, strRepFic
    //    Else
    //        Pause 1
    //    
    //        miImage = 0
    //      ' c'est le premier fichier pdf. pas d'assemblage necessaire
    //        ' il faut juste de copier dans le répertoire de stockage et dans les archives
    //        fsx.MoveFile mstrNewFichier, strRepFic
    //        sFichierGamme = fsx.GetFileName(mstrNewFichier)
    //        mstrFichier = sFichierGamme
    //        
    //        enregistrerImg
    //        
    //        ' test si on est sur une action lié a une di de filiale
    //        ' si oui, il faut enregistrer l'attachement sur l'action liée
    //        actionLiee = NumIsActionFiliale(glNumAction)
    //        If actionLiee > 0 Then
    //          TraiterFiliale actionLiee
    //        End If
    //        
    //    End If
    //  End If
    //  
    //  If mstrNewFichier <> "" Then
    //     lblTitre.Caption = "§Visualisation de la gamme§"
    //     Pdf1.Navigate strRepFic & mstrFichier
    //  End If
    //  
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdSupGamme_Click(object sender, EventArgs e)
    {
      try
      {
        if (mstrType != "GAMME") return;

        if (MessageBox.Show(Resources.msg_Confirm_Del_Gamme, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          if (msFichier != "")
          {
            ModuleData.ExecuteNonQuery($"delete from TIMAC where VTYPE = 'GAMME' AND NACTNUM = {MozartParams.NumAction}");
            Pdf1.Navigate("about:blank");
            Thread.Sleep(200);
            File.Delete(msRepFic + msFichier);
            msFichier = "";
            msFichierGamme = "";
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVoirAttest_Click(object sender, EventArgs e)
    {
      lblTitre.Text = Resources.txt_Visualisation_attestation;
      msFichier = msFichierAttest;
      mstrType = "ATTEST";
      if (msFichierAttest != "")
      {
        miImage = miImageAttest;
        Pdf1.Navigate(msRepFic + msFichier);
      }
      else
      {
        miImage = 0;
        Pdf1.Navigate("about:blank");
      }
    }

    private void cmdAddAttest_Click(object sender, EventArgs e)
    {
      mstrType = "ATTEST";

      frmChoixImage f = new frmChoixImage { mForm = this, mstrDirPDFFiles = msRepScan };
      f.ShowDialog();

      msNewFichier = f.mstrNewFichier;

      Cursor.Current = Cursors.WaitCursor;

      if (msNewFichier != "")
      {
        if (msFichierAttest != "")
        {
          miImage = miImageAttest;
          msFichier = msFichierAttest;

          // le travail se passe dans PdfAsm.cmd, il faut libérer le fichier
          Pdf1.Navigate("about:blank");
          Size pdfSize = Pdf1.Size;
          Point pdfLocation = Pdf1.Location;
          AnchorStyles pdfAnchor = Pdf1.Anchor;
          Pdf1.Dispose();
          Pdf1 = null;
          Pdf1 = new WebBrowser();
          Pdf1.Size = pdfSize;
          Pdf1.Location = pdfLocation;
          Pdf1.Anchor = pdfAnchor;
          this.Controls.Add(Pdf1);

          Process p = new Process();
          p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
          p.StartInfo.RedirectStandardOutput = true;
          p.StartInfo.RedirectStandardError = true;
          p.StartInfo.UseShellExecute = false;
          p.StartInfo.CreateNoWindow = false;
          p.StartInfo.FileName = "cmd.exe";
          p.StartInfo.Arguments = $@"/C net use P: {msRepScan} & p:PdfAsm.cmd {msFichierAttest} {Strings.Mid(msNewFichier, Strings.InStrRev(msNewFichier, @"\") + 1)} {msRepFic}";
          p.Start();

          p.StandardOutput.ReadToEnd();
          p.WaitForExit();

          int i = 0;
          // on test que le fichier disparaisse du répertoire avec un max de 5 secondes pour ne pas rester bloqué
          while (File.Exists($@"{msRepScan}\{msFichierAttach}") && i < 20)
          {
            Thread.Sleep(1000);   // Pour laisser le temps à PdfAsm de travailler
            i++;
          }
          // move dans le repertoire de stockage
          // fsx.MoveFile strRepScan & sFichierAttest, strRepFic
        }
        else
        {
          Thread.Sleep(1000);
          miImage = 0;
          // c'est le premier fichier pdf.pas d'assemblage nécessaire
          // il faut juste de copier dans le répertoire de stockage et dans les archives
          msFichierAttest = Path.GetFileName(msNewFichier);
          File.Copy(msNewFichier, msRepFic + msFichierAttest, true);
          File.Delete(msNewFichier);
          msFichier = msFichierAttest;

          EnregistrerImg();

          // test si on est sur une action liée à une DI de filiale, si oui, il faut enregistrer l'attachement sur l'action liée
          // date de 2010, jamais mis en production
          //actionLiee = NumIsActionFiliale(MozartParams.NumAction);
          //if (actionLiee > 0) TraiterFiliale(actionLiee);
        }
      }

      if (msNewFichier != "")
      {
        lblTitre.Text = Resources.txt_Visualisation_attestation;
        Pdf1.Navigate(msRepFic + msFichier);
      }

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdAddAttest_Click()
    //
    //Dim sCmd As String
    //Dim fsx As New FileSystemObject
    // 
    //  Screen.MousePointer = vbHourglass
    //  strType = "ATTEST"
    //  Set frmChoixImage.mForm = Me
    //  frmChoixImage.mstrDirPDFFiles = strRepScan
    //  
    //  frmChoixImage.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  If mstrNewFichier <> "" Then
    //    If sFichierAttest <> "" Then
    //        miImage = miImageAttest
    //        mstrFichier = sFichierAttest
    //  
    //        ' Ajout du fichier affiché (tFiles(i)) au fichier sélectionné (mstrFichier)
    //        ' le travail se passe dans PdfAsm.cmd
    //         Pdf1.Navigate "About:Blank"
    //        Shell "Net Use P: " & strRepScan
    //        ' il faut laisser le temps au fichier d'être libéré et au net use de faire la connexion réseau
    //        Pause 1
    //        sCmd = "p:PdfAsm.cmd "
    //        sCmd = sCmd & sFichierAttest & " "
    //        sCmd = sCmd & Mid(mstrNewFichier, InStrRev(mstrNewFichier, "\") + 1) & " "
    //        sCmd = sCmd & strRepFic
    //        ' L'ajout se fait après
    //        ' pour ajouter le nouveau fichier avant il faut modifier
    //        ' le PdfAsm.cmd en ajoutant l'option "-z"
    //        Shell sCmd
    //        MsgWaitObj 1000
    //        i = 0
    //        ' on test que le fichier disparaisse du répertoire avec un max de 5 secondes pour ne pas rester bloqué
    //        While (fsx.FileExists(strRepScan & "\" & sFichierAttach) And i < 20)
    //          MsgWaitObj 1000   ' Pour laisser le temps à PdfAsm de travailler
    //          i = i + 1
    //        Wend
    //        ' move dans le repertoire de stockage
    //        ' fsx.MoveFile strRepScan & sFichierAttest, strRepFic
    //    Else
    //        Pause 1
    //    
    //        miImage = 0
    //      ' c'est le premier fichier pdf. pas d'assemblage necessaire
    //        ' il faut juste de copier dans le répertoire de stockage et dans les archives
    //        fsx.MoveFile mstrNewFichier, strRepFic
    //        sFichierAttest = fsx.GetFileName(mstrNewFichier)
    //        mstrFichier = sFichierAttest
    //        
    //        enregistrerImg
    //        
    //        ' test si on est sur une action lié a une di de filiale
    //        ' si oui, il faut enregistrer l'attachement sur l'action liée
    //        actionLiee = NumIsActionFiliale(glNumAction)
    //        If actionLiee > 0 Then
    //          TraiterFiliale actionLiee
    //        End If
    //
    //    End If
    //  End If
    //  
    //  If mstrNewFichier <> "" Then
    //     lblTitre.Caption = "§Visualisation de l'attestation§"
    //     Pdf1.Navigate strRepFic & mstrFichier
    //  End If
    //  
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdSupAttest_Click(object sender, EventArgs e)
    {
      try
      {
        if (mstrType != "ATTEST")
          return;

        if (MessageBox.Show(Resources.msg_Confirm_Del_Attestation, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          if (msFichier != "")
          {
            ModuleData.ExecuteNonQuery($"delete from TIMAC where VTYPE = 'ATTEST' AND NACTNUM = {MozartParams.NumAction}");
            Pdf1.Navigate("about:blank");
            Thread.Sleep(200);
            File.Delete(msRepFic + msFichier);
            msFichier = "";
            msFichierAttest = "";
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupAttest_Click()
    //On Error GoTo handler
    //  
    //  If strType <> "ATTEST" Then Exit Sub
    //  
    //  Select Case MsgBox("§Voulez-vous vraiment supprimer cette attestation ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      If mstrFichier <> "" Then
    //        cnx.Execute "delete from TIMAC where VTYPE = 'ATTEST' AND NACTNUM = " & glNumAction
    //        Pdf1.Navigate "about:blank"
    //        Pdf1.Quit
    //        Pause 1
    //        Kill strRepFic & mstrFichier
    //        mstrFichier = ""
    //        sFichierAttest = ""
    //      End If
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //            
    //Exit Sub
    //handler:
    //  ShowError "cmdSupprimer_Click dans " & Me.Name
    //End Sub


    private void EnregistrerImg()
    {
      int res = 0;
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNIMAGE"].Value = miImage;
          cmd.Parameters["@iNACTNUM"].Value = MozartParams.NumAction;
          cmd.Parameters["@vVIMAGE"].Value = "Fichier pdf";
          cmd.Parameters["@vVFICHIER"].Value = msFichier;
          cmd.Parameters["@cCFORMAT"].Value = "pdf";
          cmd.Parameters["@vVCOMMENT"].Value = "";
          cmd.Parameters["@vVTYPE"].Value = mstrType;
          cmd.Parameters["@vWEB"].Value = mstrType == "ATTEST" ? "N" : "O";
          cmd.Parameters["@vTypeDest"].Value = mstrType == "ATTEST" ? "I" : "C";
          switch (mstrType)
          {
            case "ATTEST":
              res = 13;
              break;
            case "ATTACH":
              res = 1;
              break;
            case "GAMME":
              res = 11;
              break;
          }
          cmd.Parameters["@nTypeDoc"].Value = res;

          cmd.ExecuteNonQuery();
          miImage = (int)cmd.Parameters["@iNIMAGE"].Value;
          miImageAttach = miImage;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private int NumIsActionFiliale(long numAction)
    {
      // test dans la table des filiales
      return (int)Utils.ZeroIfNull(ModuleData.ExecuteScalarString($"select NACTNUMACTFILIALE from TACTCOMP where NACTNUM = {numAction}"));
    }

    private void TraiterFiliale(long numAction)
    {
      //recherche de la filiale liée
      string sSte = ModuleData.ExecuteScalarString($"SELECT VSOCIETE FROM TACT WITH (NOLOCK) INNER JOIN TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM " +
                                                   $"INNER JOIN TCLI WITH (NOLOCK) ON TCLI.NCLINUM = TDIN.NCLINUM AND NACTNUM = {numAction}");
      //recherche du répertoire de copie du fichier
      string sDir = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE TPAR.VPARLIB = 'REP_ATTGAM' AND VSOCIETE = '{sSte}'");

      //  copie du fichier dans le répertoire
      File.Copy(msRepFic + msFichier, sDir, true);

      ModuleData.ExecuteNonQuery($"INSERT INTO dbo.TIMAC (NACTNUM, VIMAGE, VFICHIER, CFORMAT, VCOMMENT, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC) " +
                                 $"VALUES ({numAction}, 'Fichier pdf', '{msFichier}', 'pdf', '', '{mstrType}', 'O', 'C', 1)");

      MessageBox.Show("Le document a été automatiquement envoyé à " + sSte);
    }
  }
}