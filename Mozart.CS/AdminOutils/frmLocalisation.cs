using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmLocalisation : Form
  {
    public frmLocalisation()
    {
      InitializeComponent();
    }

    private void frmLocalisation_Load(object sender, System.EventArgs e)
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

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        frmBrowser f = new frmBrowser();
        f.msStartingAddress = "https://maps.emalec.com/SiteParAdresse.asp?NOM=" + "&AD1=&VILLE=" + txtCP.Text + " " + txtVille.Text + "&PAYS=" + txtPays.Text;
        f.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdEnregistrer_Click()
    // 
    //  On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' Modif VL 02/01/2008
    //  ' TB SAMSIC CITY SPEC
    //  If gstrNomGroupe = "EMALEC" Then
    //    frmBrowser.StartingAddress = "http://maps.emalec.com/SiteParAdresse.asp?NOM=" & "&AD1=&VILLE=" & txtCP.Text & " " & txtVille.Text & "&PAYS=" & txtPays.Text
    //  End If ' TB SAMSIC CITY TODO -> Prévoir else pour samsic
    //  frmBrowser.Show vbModal
    //  ' Modif VL 02/01/2008
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub
  }
}

