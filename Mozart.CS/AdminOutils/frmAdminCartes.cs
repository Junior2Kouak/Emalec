using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmAdminCartes : Form
  {
    public frmAdminCartes()
    {
      InitializeComponent();
    }

    private void frmAdminCartes_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdCarte_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmLocalisation().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdGeoInst_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      frmBrowser f = new frmBrowser();
      f.msStartingAddress = "https://maps.emalec.com/LastPosTechniciens.asp?BASE=MULTI&APP=" + MozartParams.NomSociete;
      f.ShowDialog();

      Cursor.Current = Cursors.Default;
    }


    /* OK ---------------------------------------------------------------------*/
    private void cmdGeoLoc_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeGeoLocalisation f = new frmListeGeoLocalisation();
      f.miNumRRET = 0;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    //Private Sub cmdGeoLoc_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmListeGeoLocalisation.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdRep_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmChoixContratCarte().ShowDialog();
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdRep_Click()
    //  frmChoixContratCarte.Show vbModal
    //End Sub
  }
}
