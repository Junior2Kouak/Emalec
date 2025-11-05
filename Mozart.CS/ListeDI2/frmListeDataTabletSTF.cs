using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeDataTabletSTF : Form
  {
    DataTable dt = new DataTable();
    //Dim rsGrid As New ADODB.Recordset

    public frmListeDataTabletSTF() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeDataTabletSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec [api_sp_ListeActTabletSTF] 'O'");
        apiTGrid.GridControl.DataSource = dt;

        InitData();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //  Option Explicit
    //
    //Dim rsGrid As New ADODB.Recordset
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //    On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    // 
    //  rsGrid.Open "exec [api_sp_ListeActTabletSTF] 'O'", cnx
    // 
    //  InitData
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        //écran de modification de l'action
        MozartParams.NumActTablet = (int)row["NACTNUM"];
        MozartParams.NumCSTTablet = (int)row["NCSTNUM"];
        MozartParams.NumDi = (int)row["NDINNUM"];
        MozartParams.NumAction = (int)row["NACTNUM"];

        Cursor.Current = Cursors.WaitCursor;
        new frmAddAction
        {
          mstrStatutDI = "TabletSTF",
        }.ShowDialog();

        Cursor.Current = Cursors.WaitCursor;
        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //On Error GoTo handler
    //
    //  If rsGrid.EOF Then Exit Sub
    //
    //  'If BlankIfNull(rsGrid("DACTDEX")) = "" Then Exit Sub
    //
    //  ' écran de modification de l' action
    //  giNumActTablet = rsGrid("NACTNUM").value
    //  giNumCSTTablet = rsGrid("NCSTNUM").value
    //  frmAddAction.mstrStatutDI = "TabletSTF"
    //  glNumAction = rsGrid("NACTNUM").value
    //  giNumDi = rsGrid("NDINNUM")
    //
    //  frmAddAction.Show vbModal
    //  
    //  'avant le requery sinon perte du recordset sélectionné
    //  'cnx.Execute ("exec api_sp_SendMailTabletHrPrevCtrl " & rsGrid("NACTNUM").Value & ", '" & gstrNomSociete & "'")
    //  
    //  rsGrid.Requery
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdAnnule_Click(object sender, EventArgs e)
    {
      FrameWeb.Visible = false;
      framAct.Visible = false;
    }
    //Private Sub CmdAnnule_Click()
    //    FrameWeb.Visible = False
    //    framAct.Visible = False
    //End Sub
    //
    //' UPGRADE_INFO (#0501): The 'cmdFer_Click' member isn't used anywhere in current application.
    //'Private Sub cmdFer_Click()
    //'    FrameWeb.Visible = False
    //'    framAct.Visible = False
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Vous allez-archiver cette ligne, êtes-vous sûre?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.ExecuteNonQuery($"UPDATE TACTTABLETSTF SET NPERNUM = {MozartParams.UID}, DDATVALIDATION = getdate() WHERE NACTNUM = {row["NACTNUM"]}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdArchiver_Click()
    //Dim sSql As String
    //  
    //  If MsgBox("Vous allez-archiver cette ligne, êtes-vous sûre?", vbYesNo) = vbYes Then
    //    sSql = "UPDATE TACTTABLETSTF SET NPERNUM = " & gintUID & " , DDATVALIDATION = getdate() WHERE NACTNUM = " & rsGrid("NACTNUM").value
    //    cnx.Execute sSql
    //    rsGrid.Requery
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        txtAct.Text = (string)row["VACTDES"];
        string sAttach = "";

        //info attachement du technicien
        using (SqlDataReader dr = ModuleData.ExecuteReader($"exec [api_sp_ReturnInfoAttachTabletSTF] {row["NACTNUM"]},{row["NCSTNUM"]}"))
        {
          if (dr.Read())
          {
            sAttach = $"DETAIL DE LA PRESTATION REALISEE :\r\n{Utils.BlankIfNull(dr["VATTACHCHAP1"])}\r\n\r\n" +
                      $"DEMANDES COMPLEMENTAIRES DU RESPONSABLE SITE :\r\n{Utils.BlankIfNull(dr["VATTACHCHAP2"])}\r\n\r\n" +
                      $"REMARQUES DU TECHNICIEN :\r\n{Utils.BlankIfNull(dr["VATTACHCHAP3"])}\r\n\r\n" +
                      $"FOURNITURES UTILISEES PRISES DANS LE STOCK DU CLIENT :\r\n{Utils.BlankIfNull(dr["VATTACHCHAP4"])}\r\n\r\n" +
                      $"FOURNITURES UTILISEES LIVREES PAR EMALEC OU FOURNIES PAR LE TECHNICIEN INTERVENANT :\r\n{Utils.BlankIfNull(dr["VATTACHCHAP5"])}\r\n \r\n" +
                      $"ETAT DE LA DEMANDE EN FIN D'INTERVENTION :\r\n{Utils.BlankIfNull(dr["VATTACHCHAP6"])}\r\n\r\n";
          }
        }

        txtWeb.Text = sAttach;
        FrameWeb.Visible = true;
        framAct.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CmdVisu_Click()
    //Dim sAttach As String
    //Dim pRS As New ADODB.Recordset
    //
    //    txtAct.Text = rsGrid("VACTDES")
    //    sAttach = ""
    //    
    //    ' info attachement du technicien
    //    pRS.Open "exec [api_sp_ReturnInfoAttachTabletSTF] " & rsGrid("NACTNUM") & "," & rsGrid("NCSTNUM"), cnx
    //    If Not pRS.EOF Then
    //      sAttach = sAttach + "DETAIL DE LA PRESTATION REALISEE:" + vbCrLf + BlankIfNull(pRS("VATTACHCHAP1")) + vbCrLf + vbCrLf
    //      sAttach = sAttach + "DEMANDES COMPLEMENTAIRES DU RESPONSABLE SITE:" + vbCrLf + BlankIfNull(pRS("VATTACHCHAP2")) + vbCrLf + vbCrLf
    //      sAttach = sAttach + "REMARQUES DU TECHNICIEN :" + vbCrLf + BlankIfNull(pRS("VATTACHCHAP3")) + vbCrLf + vbCrLf
    //      sAttach = sAttach + "FOURNITURES UTILISEES PRISES DANS LE STOCK DU CLIENT :" + vbCrLf + BlankIfNull(pRS("VATTACHCHAP4")) + vbCrLf + vbCrLf
    //      sAttach = sAttach + "FOURNITURES UTILISEES LIVREES PAR EMALEC OU FOURNIES PAR LE TECHNICIEN INTERVENANT :" + vbCrLf + BlankIfNull(pRS("VATTACHCHAP5")) + vbCrLf + vbCrLf
    //      sAttach = sAttach + "ETAT DE LA DEMANDE EN FIN D'INTERVENTION :" + vbCrLf + BlankIfNull(pRS("VATTACHCHAP6")) + vbCrLf + vbCrLf
    //    End If
    //    pRS.Close
    //
    //    txtWeb.Text = sAttach
    //    FrameWeb.Visible = True
    //    framAct.Visible = True
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitData()
    {
      apiTGrid.AddColumn(Resources.col_Contrat, "NCSTNUM", 800);
      apiTGrid.AddColumn(Resources.col_Reception, "DDATRECEPT", 2000, "Date", 2);
      apiTGrid.AddColumn(Resources.col_Tech, "TECH", 2000);
      apiTGrid.AddColumn(Resources.col_NumDI, "NDINNUM", 1500);
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid.AddColumn(Resources.col_Action, "VACTDES", 3000, "", 0, true);//AddCellTip
      apiTGrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1500);
      apiTGrid.AddColumn(Resources.col_DateArrivee, "DACTARR", 2000, "Date", 2);
      apiTGrid.AddColumn(Resources.col_DateExecution, "DACTDEX", 2000, "Date", 2);
      apiTGrid.AddColumn(Resources.col_AttRecu, "ATT", 1500, "", 2);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitData()
    //  
    //  apiTGrid.AddColumn "N° CS", "NCSTNUM", 800
    //  apiTGrid.AddColumn "Réception", "DDATRECEPT", 2000, , 2
    //  apiTGrid.AddColumn "Tech", "TECH", 2000
    //  apiTGrid.AddColumn "Di", "NDINNUM", 800
    //  apiTGrid.AddColumn "Client", "VCLINOM", 1500
    //  apiTGrid.AddColumn "Site", "VSITNOM", 1500
    //  apiTGrid.AddColumn "Act", "VACTDES", 3000
    //  apiTGrid.AddColumn "Chaf", "VDINCHAFF", 1500
    //  apiTGrid.AddColumn "Date arrivée", "DACTARR", 2000, , 2
    //  apiTGrid.AddColumn "Date exec", "DACTDEX", 2000, , 2
    //  apiTGrid.AddColumn "Attach. reçu", "ATT", 1500, , 2
    //  
    //  
    //  ' Tooltip sur des cellules
    //  apiTGrid.AddCellTip "VACTDES", &HFDF0DA
    //  
    //  apiTGrid.Init rsGrid
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  rsGrid.Close
    //  Set rsGrid = Nothing
    //  giNumActTablet = 0
    //  giNumCSTTablet = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      OnClosed(e);
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdArchives_Click(object sender, EventArgs e)
    {
      new frmListeDataTabletSTFArch().ShowDialog();
    }

    private void frmListeDataTabletSTF_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartParams.NumActTablet = 0;
      MozartParams.NumCSTTablet = 0;
      Dispose();
    }
    //Private Sub CmdArchives_Click()
    //  frmListeDataTabletSTFArch.Show vbModal
    //End Sub
    //
  }
}

