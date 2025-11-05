using MozartLib;
using MozartNet;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmProcedures : Form
  {
    public frmProcedures() { InitializeComponent(); }
    //
    //  Option Explicit
    //
    /* pas testé--------------------------------------------------------------*/
    private void frmProcedures_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        InitFeuille();

        if (!cmdEnreg.Visible)
          txtInfo.Enabled = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  InitFeuille
    //  Screen.MousePointer = vbDefault
    //End Sub
    /* finit pas testé --------------------------------------------------------------------------------------- */
    private void CmdEdition_Click(object sender, System.EventArgs e)
    {
      String sEnteteHTML, sCorpsHTML, sPiedHTML;

      sEnteteHTML = $"<HTML><BODY><CENTER><H3>{lblInfo.Text}</H3></CENTER>";
      sCorpsHTML = txtInfo.Text.Replace(Environment.NewLine, "<BR>");
      sPiedHTML = "</BODY></HTML>";

      string lNomFichier = $"{MozartParams.CheminUtilisateurMozart}EditUrg.html";
      //on détruit le fichier
      File.Delete(lNomFichier);

      //création document en html pour edition
      FileStream fs = File.Open(lNomFichier, FileMode.Create);
      StreamWriter lStreamWriter = new StreamWriter(fs, Encoding.UTF8);
      lStreamWriter.Write($"{sEnteteHTML}<BR>{sCorpsHTML}<BR>{sPiedHTML}");
      lStreamWriter.Close();
      fs.Close();

      //ouverture dans browser
      new frmBrowser()
      {
        msStartingAddress = lNomFichier,
      }.ShowDialog();
    }
    //Private Sub CmdEdition_Click()
    //
    //Dim sEnteteHTML As String
    //Dim sCorpsHTML As String
    //Dim sPiedHTML As String
    //
    //  sEnteteHTML = "<HTML><BODY><CENTER><H3>§PROCEDURE D'URGENCE§</H3></CENTER>"
    //  sCorpsHTML = Replace(txtInfo.Text, Chr(10), "<BR>")
    //  sPiedHTML = "</BODY></HTML>"
    //  
    //  'on détruit le fichier
    //  If Dir$(gstrCheminUtilisateur & "\Mozart\EditUrg.html") <> "" Then Kill gstrCheminUtilisateur & "\Mozart\EditUrg.html"
    //
    //  'création document en html pour edition
    //  Open gstrCheminUtilisateur & "\Mozart\EditUrg.html" For Output As #1
    //  Print #1, sEnteteHTML & "<BR>" & sCorpsHTML & "<BR>" & sPiedHTML
    //  Close (1)
    //  'ouverture dans browser
    //  frmBrowser.StartingAddress = gstrCheminUtilisateur & "\Mozart\EditUrg.html"
    //  frmBrowser.Show vbModal
    //
    //End Sub
    //

    /* pas testé--------------------------------------------------------------------------------------- */
    private void InitFeuille()
    {
      txtInfo.Text = ModuleData.RechercheParam("PROCEDURES", MozartParams.NomSociete);
      txtInfo.SelectionStart = 0;
    }
    //Private Sub InitFeuille()
    //Dim rsI As New ADODB.Recordset
    // 
    //  txtInfo = ""
    //  rsI.Open "SELECT VPARVAL FROM TPAR WHERE VPARLIB='PROCEDURES' AND VSOCIETE = '" & gstrNomSociete & "'", cnx
    //  txtInfo = BlankIfNull(rsI!VPARVAL)
    //  
    //End Sub
    //
    /* pas testé--------------------------------------------------------------------------------------- */
    private void cmdEnreg_Click(object sender, System.EventArgs e)
    {
      try
      {
        ModuleData.CnxExecute($"UPDATE TPAR SET VPARVAL = '{txtInfo.Text.Replace("'", "''")}' WHERE VPARLIB='PROCEDURES' AND VSOCIETE = '{MozartParams.NomSociete}'");
        InitFeuille();
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdEnreg_Click()
    //
    //  cnx.Execute "UPDATE TPAR SET VPARVAL = '" & Replace(txtInfo.Text, "'", "''") & "' WHERE VPARLIB='PROCEDURES' AND VSOCIETE = '" & gstrNomSociete & "'"
    //  InitFeuille
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdEnreg_Click dans " & Me.Name
    //End Sub
    //
    /* pas testé--------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // fait dans load
    //Private Sub Timer1_Timer()
    //  If Not cmdEnreg.Visible Then txtInfo.Locked = True
    //  Timer1.Enabled = False
    //End Sub

  }
}

