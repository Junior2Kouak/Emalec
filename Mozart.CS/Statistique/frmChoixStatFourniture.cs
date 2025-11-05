using System;
using System.IO;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using MozartNet;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmMenuCommercial : Form
  {
    public frmMenuCommercial() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmMenuCommercial_Load(object sender, System.EventArgs e)
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
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //
    //    InitBoutons Me, frmMenu
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdStatClient_Click(object sender, EventArgs e)
    {
      new frmStatComGenerale("MULTI").ShowDialog();
    }

    //Private Sub cmdStatClient_Click()
    //    modMain.VerifMOZARTNET
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmStatComGenerale" & " " & "MULTI", vbNormalFocus
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void Command1_Click(object sender, EventArgs e)
    {
      new frmStatComGenerale("EXT").ShowDialog();
    }

    //Private Sub Command1_Click()
    //    modMain.VerifMOZARTNET
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmStatComGenerale" & " " & "EXT", vbNormalFocus
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdProsp_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmProspGestion().ShowDialog();
      Cursor = Cursors.Default;
    }

    //Private Sub cmdProsp_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmProspGestion.Show vbModal
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdStatCliCom_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmStatComCACliByCom().ShowDialog();
      Cursor = Cursors.Default;
    }

    //Private Sub CmdStatCliCom_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmStatComCACliByCom.Show vbModal
    //  Screen.MousePointer = vbDefault
    //End Sub
    //


  }
}

