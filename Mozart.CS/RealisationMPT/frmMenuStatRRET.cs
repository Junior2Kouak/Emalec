using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmMenuStatRRET : Form
  {
    public frmMenuStatRRET() { InitializeComponent(); }

    private void frmMenuStatRRET_Load(object sender, System.EventArgs e)
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
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdStatTech_Click(object sender, EventArgs e)
    {
      new frmChoixStatTech().ShowDialog();
    }

    private void cmdMaitre_Click(object sender, EventArgs e)
    {
      new frmChoixDateStatTech("C").ShowDialog();
    }

    private void cmdCor_Click(object sender, EventArgs e)
    {
      new frmListeCorDevisTech().ShowDialog();
    }

    private void cmdTechtech_Click(object sender, EventArgs e)
    {
      new frmStatHeureDevisTech()
      {
        mTypeStat = "Tech"
      }.ShowDialog();
    }

    private void cmdTech_Click(object sender, EventArgs e)
    {
      new frmStatHeureDevisTech()
      {
        mTypeStat = "Client"
      }.ShowDialog();
    }

    private void cmdHeureDepTech_Click(object sender, EventArgs e)
    {
      new frmStatTechHeuresDepannage().ShowDialog();
    }

    private void cmdStatVehicules_Click(object sender, EventArgs e)
    {
      new frmStatFrais("T", "KM3", DateTime.Now.AddYears(-1).ToShortDateString(), DateTime.Now.ToShortDateString()).ShowDialog();
    }

    private void cmdGeoInst_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmBrowser f = new frmBrowser();
      f.msStartingAddress = "https://maps.emalec.com/LastPosTechniciensRRET.asp?BASE=MULTI&APP=EMALEC&RRET=" + MozartParams.UID;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdGeoLoc_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeGeoLocalisation f = new frmListeGeoLocalisation();
      f.miNumRRET = MozartParams.UID;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    //Private Sub cmdStatVehicules_Click()
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmStatFrais T|KM3|" & DateAdd("yyyy", -1, Date) & "|" & Date, vbNormalFocus
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //


  }
}

