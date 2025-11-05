using Microsoft.VisualBasic;
using MozartNet;
using MozartUC;
using MozartLib;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSaisieWebContrat : Form
  {
    //Public NCLINUM As Long
    public long miNCLINUM;
    //Dim rsContrat As ADODB.Recordset

    public frmSaisieWebContrat()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmSaisieWebContrat_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      txtContrat.Text = ModuleData.ExecuteScalarString($"SELECT VCLICONTRATWEB FROM TCLI WHERE VSOCIETE = '{MozartParams.NomSociete}' " +
                                                       $"AND NCLINUM = {miNCLINUM}");
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, "", "SELECT", "NCLINUM:" + miNCLINUM);
    }
    //Private Sub Form_Load()
    //Dim sSQL As String
    //  InitBoutons Me, frmMenu
    //  sSQL = "SELECT VCLICONTRATWEB FROM TCLI WHERE VSOCIETE = '" & gstrNomSociete & "' AND NCLINUM = " & NCLINUM
    //  Set rsContrat = New ADODB.Recordset
    //  rsContrat.Open sSQL, cnx, adOpenDynamic, adLockOptimistic
    //  If rsContrat.RecordCount > 0 Then
    //    txtContrat.Text = BlankIfNull(rsContrat("VCLICONTRATWEB"))
    //  End If
    //  SpyLog Me.Caption, "", "SELECT", "NCLINUM:" & NCLINUM
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      string sSQL = "UPDATE TCLI SET VCLICONTRATWEB = '" + Strings.Replace(txtContrat.Text, "'", "''") + "' WHERE NCLINUM = " + miNCLINUM;
      ModuleData.ExecuteNonQuery(sSQL);

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, ttEnregister.GetToolTip(cmdEnregistrer), "Modification", "NCLINUM:" + miNCLINUM);

      Dispose();
    }
    //Private Sub cmdEnregistrer_Click()
    //Dim sSQL As String
    //  sSQL = "UPDATE TCLI SET VCLICONTRATWEB = '" & Replace(txtContrat.Text, "'", "''") & "' WHERE NCLINUM = " & NCLINUM
    //  cnx.Execute sSQL
    //  SpyLog Me.Caption, cmdEnregistrer.ToolTipText, "Modification", "NCLINUM:" & NCLINUM
    //  Unload Me
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    //Private Sub Form_Unload(Cancel As Integer)
    //  rsContrat.Close
    //End Sub
    //  }
  }
}
