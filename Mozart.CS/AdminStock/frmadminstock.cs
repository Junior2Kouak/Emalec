using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmAdminStock : Form
  {
    public frmAdminStock() { InitializeComponent(); }


    private void frmAdminStock_Load(object sender, System.EventArgs e)
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

    private void cmdChantier_Click(object sender, EventArgs e)
    {
      new frmStockListeRetourChantiers().ShowDialog();
    }

    private void CmdInvVehTec_Click(object sender, EventArgs e)
    {
      new frmInvVehTec().ShowDialog();
    }

    private void CmdStatPrepa_Click(object sender, EventArgs e)
    {
      new frmStatPreparation().ShowDialog();
    }

    private void cmdStatLogistique_Click(object sender, EventArgs e)
    {
      new frmStockSuivi().ShowDialog();
    }

    private void cmdStatProduitDanger_Click(object sender, EventArgs e)
    {
      new frmListeProduitsDangereux().ShowDialog();
    }

    private void cmdListeReap_Click(object sender, EventArgs e)
    {
      new frmChoixListeReappro().ShowDialog();
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      new frmStockListeReexpedition().ShowDialog();
    }

    private void cmdCmd_Click(object sender, EventArgs e)
    {
      new frmStockRupture().ShowDialog();
    }

    private void cmdStatTech_Click(object sender, EventArgs e)
    {
      new frmStockStatsTech().ShowDialog();
    }

    private void cmdEtiquette_Click(object sender, EventArgs e)
    {
      new frmStockEdition().ShowDialog();
    }

    private void cmdStatsCan_Click(object sender, EventArgs e)
    {
      new frmStockStatsCan().ShowDialog();
    }

    //private void cmdMG_Click(object sender, EventArgs e)
    //{
    //  new frmListeStockClient().ShowDialog();
    //}
    ////Private Sub cmdMG_Click()
    ////  frmListeStockClient.Show vbModal
    ////End Sub

    private void cmdListeReception_Click(object sender, EventArgs e)
    {
      frmStockListeReceptions f = new frmStockListeReceptions();
      f.mstrType = "995";
      f.ShowDialog();
    }

    private void cmdDdeReappro_Click(object sender, EventArgs e)
    {
      new frmStockDdeReappro().ShowDialog();
    }

    private void cmdStockAjout_Click(object sender, EventArgs e)
    {
      new frmStockAjout().ShowDialog();
    }

    private void cmDdeSortie_Click(object sender, EventArgs e)
    {
      frmStockListeDdeSortie f = new frmStockListeDdeSortie();
      f.miNumAction = 0;
      f.ShowDialog();
    }

    private void cmdArticleWeb_Click(object sender, EventArgs e)
    {
      new frmListeArtClientWeb().ShowDialog();
    }

    private void cmdRetourTech_Click(object sender, EventArgs e)
    {
      new frmStockListeRetourTechniciens().ShowDialog();
    }

    private void CmdFluideFrigo_Click(object sender, EventArgs e)
    {
      MessageBox.Show("En cours de développement");
    }

    private void BtnFouPerissable_Click(object sender, EventArgs e)
    {
      new frmListeProduitsPerissables().ShowDialog();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub CmdFluideFrigo_Click()
    //
    //'On Error GoTo handler
    //'
    //'  InitRecordsetArticle
    //'
    //'     ' affichage de la feuille  de recherche des fournitures avec numero de fournisseur si connu
    //'     Screen.MousePointer = vbHourglass
    //'     frmRechercheArticles.bAfficheInfoFou = False
    //'     frmRechercheArticles.brechercheSite = True
    //'     frmRechercheArticles.bSaisieQte = True
    //'     frmRechercheArticles.mstrType = "FluidesFrigo"
    //'     frmRechercheArticles.Show vbModal
    //'
    //'     If rsarticle.RecordCount > 0 Then
    //'
    //'        Dim oFrmComdFluide As New frmCommandeFournisseur
    //'        oFrmComdFluide.Show vbModal
    //'
    //'     End If
    //'
    //'
    //'     ' retour avec le recordset des articles selectionnés
    //'     'apiTGridArt.Init rsarticle
    //'     'FormatGridArticle
    //'     'RemplirTxtTotaux
    //'     'CalculTotal
    //'     Exit Sub
    //'
    //'handler:
    //'     ShowError " CmdFluideFrigo_Click dans " & Me.Name
    //End Sub
    //' UPGRADE_INFO (#0501): The 'InitRecordsetArticle' member isn't used anywhere in current application.
    //'Public Sub InitRecordsetArticle()
    //'
    //'On Error GoTo handler
    //'
    //'  Set rsarticle = New ADODB.Recordset
    //'
    //'  rsarticle.Fields.Append "Serie", adVarChar, 70
    //'  rsarticle.Fields.Append "Article", adVarChar, 150
    //'  rsarticle.Fields.Append "Marque", adVarChar, 100
    //'  rsarticle.Fields.Append "Type", adVarChar, 2000
    //'  rsarticle.Fields.Append "Reference", adVarChar, 150
    //'  rsarticle.Fields.Append "PCB", adInteger
    //'  rsarticle.Fields.Append "Prix U", adDouble
    //'  rsarticle.Fields.Append "Date prix", adVarChar, 25
    //'  rsarticle.Fields.Append "coeff", adDouble
    //'  rsarticle.Fields.Append "Prix Client", adDouble
    //'  rsarticle.Fields.Append "Quantite", adInteger
    //'  rsarticle.Fields.Append "Prix T", adDouble
    //'  rsarticle.Fields.Append "Fournisseur", adVarChar, 100
    //'  rsarticle.Fields.Append "NumArticle", adInteger
    //'  rsarticle.Fields.Append "NumFour", adInteger
    //'  rsarticle.Fields.Append "NumSiteFour", adInteger
    //'  rsarticle.Fields.Append "NCFOCOD", adInteger, , adFldIsNullable
    //'  rsarticle.Fields.Append "PRIXVENTE2MOIS", adDouble
    //'
    //'  rsarticle.Open , , adOpenDynamic, adLockOptimistic
    //'
    //'Exit Sub
    //'Resume
    //'handler:
    //'  ShowError "InitRecordsetArticle dans " & Me.Name
    //'End Sub
  }
}

