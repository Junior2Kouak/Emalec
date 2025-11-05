using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixListeReappro : Form
  {
    public frmChoixListeReappro() { InitializeComponent(); }


    private void frmChoixListeReappro_Load(object sender, System.EventArgs e)
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


    private void cmdListeArtTech_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "MULTI" }.ShowDialog();
    }

    private void cmdListeArtTechFaible_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "FAIBLE" }.ShowDialog();
    }
    
    private void cmdListReapArgedis_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "ARGEDIS" }.ShowDialog();
    }

    private void cmdListReapPhotoVolt_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "PHOTOVOLT" }.ShowDialog();
    }

    private void cmdListeArtTechClim_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "CLIM" }.ShowDialog();
    }

    private void cmdListReapDirickx_Click(object sender, EventArgs e)
    {
      //    ' c'est l'ancienne liste dirickx que l'on reutilise pour l'extinction incendie
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "DIRICKX" }.ShowDialog();
    }

    private void cmdGun_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "LAPOSTE" }.ShowDialog();
    }

    private void cmdCrown_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "CROwN" }.ShowDialog();
    }

    private void cmdPlomb_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "PLOMBIER" }.ShowDialog();
    }

    private void cmdED_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "ED" }.ShowDialog();
    }

    private void cmdListReapMultiEI_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "MULTIEI" }.ShowDialog();
    }

    private void CmdMultiServices_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "MULTISERV_FOU" }.ShowDialog();
    }

    private void cmdListeArtTechFort_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "FORT" }.ShowDialog();
    }

    private void cmdCouvreur_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "COUV" }.ShowDialog();
    }

    private void cmdListReapVis_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeArtReapproTech { msType = "VIS" }.ShowDialog();
    }
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}