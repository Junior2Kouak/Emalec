using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuFacturation : Form
  {
    public frmMenuFacturation()
    {
      InitializeComponent();
    }

    private void frmMenuFacturation_Load(object sender, System.EventArgs e)
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

    private void cmdPrixVenteCoef_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new FrmStatPVByClient_Pays_Contrat().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatFactu_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDelaiFact() { iTypeStat = 1 }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdServGeneraux_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmFraisGeneraux().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdMarge_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmTauxConformite("F").ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdStatFact_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFacture().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdCAFF_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatModeleCA(0).ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdCAN_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatModeleCA(1).ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdCA_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFacturationCA().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdChiffr_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFacturation().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdFacture_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFacturationParPersonne("Montant").ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdNbFacture_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFacturationParPersonne("Nombre").ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdEncours_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatListeEncoursClients().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdRepartitionPresta_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmReportingFacturation().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdReportingGeo_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmReportingGeographique().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdEvolutionClientele_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmEvolutionClientele().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdReportingGeoEurope_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmReportingGeographiqueEurope().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDelaisPaiements_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatDelaisPaiementsFO_CLIENTS().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdCNF_Click(object sender, EventArgs e)
    {
      {
        Cursor = Cursors.WaitCursor;
        new frmStatPrestationNF().ShowDialog();
        Cursor = Cursors.Default;
      }
    }

    private void cmdStatNF_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatFourNF().ShowDialog();
      //new frmListeFourNF().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

        private void BtnStatChiffrageDelai_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new frmStatDelaiFact() { iTypeStat = 2 }.ShowDialog();
            Cursor = Cursors.Default;
        }
    }
}

