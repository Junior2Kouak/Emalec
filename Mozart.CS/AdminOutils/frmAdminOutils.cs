using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Reflection;
using System.Web;
using System.Windows.Forms;

using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminOutils : Form
  {
    public frmAdminOutils()
    {
      InitializeComponent();
    }

    private void frmAdminOutils_Load(object sender, System.EventArgs e)
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

    private void CmdTelInternes_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeTelephone().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdWeb_Click(object sender, EventArgs e)
    {
      try
      {
				//new frmMainReport
				//{
				//	bLaunchByProcessStart = false,
				//	sTypeReport = "TWORD",
				//	sIdentifiant = "HTML",
				//	InfosMail = $"TCLI|NCLINUM|255",
				//	sNomSociete = MozartParams.NomSociete,
				//	sLangue = "FR",
				//	sOption = "PREVIEW"
				//}.ShowDialog();

				C_CRYPTAGE oGenCrypt = new C_CRYPTAGE("password");

				frmBrowserSimple f = new frmBrowserSimple();
				f.StartingAddress = $"https://tablets.emalec.com/MessageTechnicien.aspx?NPERNUM={HttpUtility.UrlEncode(oGenCrypt.AES_Encrypt("0"))}&VSOCIETE=" + MozartParams.NomSociete;
        f.ShowDialog();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception)
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      GestionStock("EMALEC");
    }

    private void Command3_Click(object sender, EventArgs e)
    {
      GestionStock("EQUIPAGE");
    }

    private static void GestionStock(string societe)
    {
      string currentSociete = MozartParams.NomSociete;
      MozartParams.NomSociete = societe;

      Cursor.Current = Cursors.WaitCursor;
      new frmListeStockFiliales().ShowDialog();

      MozartParams.NomSociete = currentSociete;
      Cursor.Current = Cursors.Default;
    }

    private void Command4_Click(object sender, EventArgs e)
    {
      GestionStock("FITELEC");
    }

    private void Command5_Click(object sender, EventArgs e)
    {
      GestionStock("SCS");
    }

    private void cmdVeh_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminStockVeh().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      frmIntercalaires f = new frmIntercalaires();
      f.mstrType = "DOSCLASSEURSECU";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCarte_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmAdminCartes().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdVille_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmTechDansVille().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdIntercal_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmChoixIntercalaires().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdLstCptAna_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeCompteAnaByCliAndChaff("R").ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdInventaireExtincteur_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmExtInvSelectCliSite().ShowDialog();
      Cursor.Current = Cursors.Default;
    }   

    private void cmdGLPI_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeVisites().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

  }
}