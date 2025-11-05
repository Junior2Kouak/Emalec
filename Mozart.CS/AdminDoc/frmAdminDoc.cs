using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminDoc : Form
  {
    public frmAdminDoc()
    {
      InitializeComponent();
    }

    private void frmAdminDoc_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        cmdDocEmalec.Text = cmdDocEmalec.Text.Replace("EMALEC", MozartParams.GetNomSociete());
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void cmdQualif_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeQualif().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDoc_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeDocuments().ShowDialog();
    }

    private void cmdGamme_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmDocGamme().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdFicheTech_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeFicheTech f = new frmListeFicheTech();
      f.mstrTypeFiche = "FQ";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdPR_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeFicheTech f = new frmListeFicheTech();
      f.mstrTypeFiche = "PR";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdNormes_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeFicheTech f = new frmListeFicheTech();
      f.mstrTypeFiche = "N";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }
    private void cmdFT_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeFicheTech f = new frmListeFicheTech();
      f.mstrTypeFiche = "FT";
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDocEmalec_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmGestProcedure f = new frmGestProcedure();
      f.miNumSite = 0;
      f.mstrType = "ADMINISTRATIF";
      f.miNumClient = MozartParams.SOCIETE;
      f.msTitre = " du client : " + MozartParams.NomSociete;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdDocDUP_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeFicheCSE().ShowDialog();
      //new frmGestDocDUPWebTech().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdNotice_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeDoc().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdGestQCM_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmQCMListe("1").ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdDocSupportTech_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new FrmGestDocSupportTech("SP").ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    /* --------------------------------------------------------------------------*/
    //' NL, le 16/12/2015 : Les fiches DTU ne sont plus gérées dans Mozart...
    //' Suppression du bouton cmdDTU et mise en commentaire du code
    //'Private Sub cmdDTU_Click()
    //'    frmListeDoc.strType = "DTU"
    //'    frmListeDoc.sTitre = " du client : " & gstrNomSociete
    //'    frmListeDoc.Show vbModal
    //'End Sub
    //
    //
    //
    //
    //
    //


  }
}

