using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmAdminMat : Form
  {
    public frmAdminMat()
    {
      InitializeComponent();
    }

    private void frmAdminMat_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

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

    private void cmdAuto_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeVehicules().ShowDialog();
      Cursor.Current = Cursors.WaitCursor;
    }

    private void cmdTel_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeTelephones().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCle_Click(object sender, EventArgs e)
    {

      //new frmListeCles().ShowDialog();  -- migration VB.net vers C#
      new frmListeCle().ShowDialog();
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeInformatique().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdFournitures_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeFournitures().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "MULTI";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void Command3_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "CLIM";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdOutInd_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeFournituresInd().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCfaible_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "FAIBLE";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdPlomb_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "PLOMBIER";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDirickx_Click(object sender, EventArgs e)
    {
      // réutilisation de la liste dirickx pour extinction incendie
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "DIRICKX";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdMultiEI_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "MULTIEI";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdATEX_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "ATEX";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdChauff_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "CHAUFF";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCfort_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "FORT";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCouvreur_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "COUV";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdOutEPI_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "EPI";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdOutSecondOeuvre_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "PHOTOVOLT";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void BtnOutReapproVet_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeArtNewTech f = new frmListeArtNewTech();
      f.msType = "VETEMENT";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }
  }
}

