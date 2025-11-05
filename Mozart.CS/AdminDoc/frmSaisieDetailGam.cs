using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieDetailGam : Form
  {
    //Public miNumTrame As Long
    //Public miNumGamCli As Long
    //Public miClient As Long
    //Public miSite As Long
    public long miNumTrame;
    public long miNumGamCli;
    public long miClient;
    public long miSite;

    public frmSaisieDetailGam()
    {
      InitializeComponent();
    }

    private void frmSaisieDetailGam_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
      Initialise();
    }

    private void Initialise()
    {
      string sSql;
      try
      {
        txtDetail.Text = "";
        if (miClient == 0)
          sSql = $"SELECT  VTRASITDET From TGAMSITE WHERE  NTRASITNUM = {miNumGamCli}  AND NGAMTRAMENUM = {miNumTrame}  AND NSITNUM = {miSite}";
        else
          sSql = $"SELECT  VTRACLIDET From TGAMCLIENT WHERE  NTRACLINUM = {miNumGamCli}  AND NGAMTRAMENUM = {miNumTrame}  AND NCLINUM = {miClient}";

        txtDetail.Text = ModuleData.ExecuteScalarString(sSql);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Initialise()
    //Dim rs As New Recordset
    //Dim ssql As String
    //  On Error GoTo handler
    //  txtDetail = ""
    //  If miClient = 0 Then
    //    ssql = "SELECT  VTRASITDET From TGAMSITE WHERE  NTRASITNUM =" & miNumGamCli & "  AND NGAMTRAMENUM = " & miNumTrame & "  AND NSITNUM = " & miSite
    //  Else
    //    ssql = "SELECT  VTRACLIDET From TGAMCLIENT WHERE  NTRACLINUM =" & miNumGamCli & "  AND NGAMTRAMENUM = " & miNumTrame & "  AND NCLINUM = " & miClient
    //  End If
    //  ' recherche des différents type de contrat
    //  rs.Open ssql, cnx
    //  If rs.EOF Then Exit Sub
    //  txtDetail = BlankIfNull(rs(0))
    //Exit Sub
    //handler:
    //  ShowError " Initialise dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (miClient == 0)
          ModuleData.ExecuteScalarString($"update TGAMSITE set VTRASITDET='{txtDetail.Text.Replace("'", "''")}'  WHERE  NTRASITNUM = {miNumGamCli}  " +
                                         $"AND NGAMTRAMENUM = {miNumTrame}  AND NSITNUM = {miSite}");
        else
          ModuleData.ExecuteScalarString($"update TGAMCLIENT set VTRACLIDET='{txtDetail.Text.Replace("'", "''")}'  WHERE  NTRACLINUM = {miNumGamCli}  " +
                                         $"AND NGAMTRAMENUM = {miNumTrame}  AND NCLINUM = {miClient}");
        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //  On Error Resume Next
    //  If miClient = 0 Then
    //    cnx.Execute "update  TGAMSITE set VTRASITDET='" & Replace(txtDetail, "'", "''") & "'  WHERE  NTRASITNUM =" & miNumGamCli & "  AND NGAMTRAMENUM = " & miNumTrame & "  AND NSITNUM = " & miSite
    //  Else
    //    cnx.Execute "update  TGAMCLIENT set VTRACLIDET='" & Replace(txtDetail, "'", "''") & "'  WHERE  NTRACLINUM =" & miNumGamCli & "  AND NGAMTRAMENUM = " & miNumTrame & "  AND NCLINUM = " & miClient
    //  End If
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
  }
}
