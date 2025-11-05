using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmIntercalairesLibre : Form
  {
    public frmIntercalairesLibre()
    {
      InitializeComponent();
    }

    private void frmIntercalairesLibre_Load(object sender, System.EventArgs e)
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

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string[,] TdbGlobal = { { "SITE", txtInter.Text } };

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TSites.rtf",
                      @"TSites.Out.rtf",
                      TdbGlobal,
                      "select 1 from tcpt",
                      "(Visualisation d'un site)", "PREVIEW");
    }
    //Private Sub cmdVisu_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //  TdbGlobal(0, 0) = "SITE"
    //  TdbGlobal(0, 1) = txtInter
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TSites.rtf", _
    //                           "\TSites.Out.rtf", _
    //                           TdbGlobal(), _
    //                           "select * from tcpt", _
    //                           " (Visualisation d'un site)", _
    //                           "PREVIEW"
    //
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdEdition_Click(object sender, EventArgs e)
    {
      //string[,] TdbGlobal = new string[1, 1];
      string[,] TdbGlobal = { { "SITE", txtInter.Text } };

      //  utilisation d'une requete bidon !
      new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + MozartParams.Langue + @"\TSites.rtf",
                                       @"TSitesOut.rtf",
                                       TdbGlobal,
                                       "select 1 from tcpt");
    }
    //Private Sub CmdEdition_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //  ' utilisation d'une requete bidon !
    //
    //  TdbGlobal(0, 0) = "SITE"
    //  TdbGlobal(0, 1) = txtInter
    //  
    //'  frmBrowser.Preview_Print  "\Modeles\TSites.rtf", _
    //'                           "\TSitesOut.rtf", _
    //'                           TdbGlobal(), _
    //'                           "select * from tcpt", _
    //'                           " (Impression d'un site)", _
    //'                           "PRINT"
    //                           
    //      ImprimerFichier gstrCheminModeles & gstrLangue & "\" & "TSites.rtf", _
    //                       "\TSitesOut.rtf", _
    //                       TdbGlobal(), _
    //                      "select * from tcpt"
    //
    //  
    //End Sub
    //
  }
}