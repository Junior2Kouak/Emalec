using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuAchat : Form
  {
    public frmMenuAchat() { InitializeComponent(); }

    private void frmMenuAchat_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdStatFourn_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFournCA().ShowDialog();
      Cursor = Cursors.Default;
    }

    //Private Sub cmdStatFourn_Click()
    //  If gModeActiveX Then
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmStatFournCA", vbNormalFocus
    //  Else
    //    Screen.MousePointer = vbHourglass
    //    frmStatFournCA.Show vbModal
    //    Screen.MousePointer = vbDefault
    //  End If
    //End Sub
    //

    private void cmdMoyNote_Click(object sender, EventArgs e)
    {
      new frmStatNotationSTTMoyenne().ShowDialog();
    }

    private void cmdDetailNotePersonne_Click(object sender, EventArgs e)
    {
      new frmStatNotationParPersonne().ShowDialog();
    }

    private void cmdDetailNoteSTT_Click(object sender, EventArgs e)
    {
      new frmStatNotationParSTT().ShowDialog();
    }

    private void cmdIndicAchatAcheteur_Click(object sender, EventArgs e)
    {
      new frmStatAchat(0).ShowDialog();
    }

    private void cmdTauxSTT_Click(object sender, EventArgs e)
    {
      new frmStatTauxSousTraitance().ShowDialog();
    }

    private void cmdIndicAchatGlobaux_Click(object sender, EventArgs e)
    {
      new frmStatAchat(1).ShowDialog();
    }

    private void cmdAchatsParFourniture_Click(object sender, EventArgs e)
    {
      new frmReportingAchatsFourniture().ShowDialog();
    }

    private void cmdSaisieDocsAdmin_Click(object sender, EventArgs e)
    {
      new frmDetailSaisieDocsAdmin().ShowDialog();
    }

    private void cmdTauxACH_Click(object sender, EventArgs e)
    {
      new frmTauxConformite("C").ShowDialog();
    }
  }
}

