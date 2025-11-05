using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmAbout : Form
  {
    public frmAbout()
    {
      InitializeComponent();
    }

    //VB6
    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  Me.Caption = "§À propos de §" & App.Title
    //  lblVersion.Caption = "§Version §" & App.Major & "." & App.Minor & "." & App.Revision
    //  lblTitle.Caption = App.Title
    //  If gstrNomSociete <> "EMALEC" Then
    //    lblTest.Visible = True
    //  End If
    //  If gstrNomServeur <> "SRV-VMSQLPROD" Then
    //    lblTest.Visible = True
    //  End If
    //  lblTapiLine = gstrPosteTel
    //End Sub

    private void FrmAbout_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
      lblTitle.Text = Resources.lbl_APropos + MozartParams.NomSociete;
      lblVersion.Text = Resources.lbl_Version + Application.ProductVersion;
      lblDescription.Text = Resources.lbl_AppDescription + MozartParams.NomSociete;
      lblTest.Text = Resources.lbl_BaseDeTest;
      this.Text = Resources.lbl_MozarisPour + MozartParams.NomSociete;
      cmdSuppr.Visible = false;

      lblTest.Visible = (MozartParams.NomSociete.ToUpper() != "EMALEC" ||
                         MozartParams.NomServeur.ToUpper() != "SRV-VMSQLPROD");
    }

    private void cmdOK_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }


}
