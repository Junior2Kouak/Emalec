using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminReapro : Form
  {
    public frmAdminReapro()
    {
      InitializeComponent();
    }

    private void frmAdminReapro_Load(object sender, System.EventArgs e)
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    // Cet évènement traite tous les boutons en fonction du TAG
    private void cmdListeArtTechAll_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeTypeReappro f = new frmListeTypeReappro();
      f.msType = (sender as Button).Tag.ToString();
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdListeArtTech_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "MULTI"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdGun_Click()
    //   Screen.MousePointer = vbHourglass
    //   frmListeTypeReappro.sType = "GUNNEBO"
    //   frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdCouvreur_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "COUV"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListeArtTechClim_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "CLIM"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListeArtTechFaible_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "FAIBLE"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListeArtTechFort_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "FORT"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListReapArgedis_Click()
    //   Screen.MousePointer = vbHourglass
    //   frmListeTypeReappro.sType = "ARGEDIS"
    //   frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListReapDirickx_Click()
    //    ' c'est l'ancienne liste dirickx que l'on reutilise pour l'extinction incendie
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "DIRICKX"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdPlomb_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "PLOMBIER"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub CmdED_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "ED"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListReapVis_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "VIS"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListReapMultiEI_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "MULTIEI"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub Command1_Click()
    //    Screen.MousePointer = vbHourglass
    //    frmListeTypeReappro.sType = "PHOTOVOLT"
    //    frmListeTypeReappro.Show vbModal
    //End Sub
    //
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdCrownHeights_Click()
    //   Screen.MousePointer = vbHourglass
    //   frmListeTypeReappro.sType = "CROWN"
    //   frmListeTypeReappro.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    //Private Sub cmdListReapMultiServ_Click()
    //    Screen.MousePointer = vbHourglass
    //   frmListeTypeReappro.sType = "MULTISERV_FOU"
    //   frmListeTypeReappro.Show vbModal
    //End Sub
  }
}