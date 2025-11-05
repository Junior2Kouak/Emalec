using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeTrameGammeArch : Form
  {
    DataTable dt = new DataTable();

    //Dim adoRS As ADODB.Recordset

    public frmListeTrameGammeArch()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmListeTrameGammeArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        LoadGrid();
        InitApigrid();
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "api_sp_InfoTramesGammeEmalecArch", cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me
    //End Sub
    //

    private void LoadGrid()
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid_FicheTech.LoadData(dt, MozartDatabase.cnxMozart, "api_sp_InfoTramesGammeEmalecArch");
      apiTGrid_FicheTech.GridControl.DataSource = dt;
      Cursor.Current = Cursors.Default;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //  passage des infos
      frmListeTramesGamme f = new frmListeTramesGamme();
      f.mstrStatut = "V";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3));
      f.ShowDialog();

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdVisu_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmListeTramesGamme.mstrStatut = "V"
    //  frmListeTramesGamme.miNumTrame = Val(Mid(adoRS("NTRAEMANUM"), 3))
    //  frmListeTramesGamme.Show vbModal
    //    
    //  Screen.MousePointer = vbDefault
    //     
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdRest_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_restaurer_trame, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        string sSQL = "update TGAMTRAMESEMALEC set CTRAEMAACTIF = 'O' where NTRAEMANUM=" + Convert.ToInt32(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3));
        ModuleData.ExecuteNonQuery(sSQL);
      }
      else
        return;

      //rafraichissement
      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdRest_Click()
    //     
    //Dim sSQL As String
    //
    //   If adoRS.EOF Then Exit Sub
    //
    //    Select Case MsgBox("§Voulez-vous vraiment restaurer cette trame ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //      Case vbYes
    //          sSQL = "update TGAMTRAMESEMALEC set CTRAEMAACTIF = 'O' where NTRAEMANUM=" & Val(Mid(adoRS("NTRAEMANUM"), 3))
    //          cnx.Execute sSQL
    //      Case vbNo
    //        Exit Sub
    //    End Select
    //    
    //    ' rafraichissement du recordset
    //    adoRS.Requery
    //  
    //    ' mise en page du tableau
    //    InitApigrid
    //
    //End Su

    /* OK ---------------------------------------------------------------------*/
    private void CmdEdit_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();

      if (row == null) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TGAMMEEMALEC",
        sIdentifiant = Strings.Mid(row["NTRAEMANUM"].ToString(), 3),
        InfosMail = $"TINT|NSTFNUM|1",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();

      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TGamme.rtf",
                      @"TAudit1.rtf",
                      TdbGlobal,
                      "exec api_sp_impGammeTrameEmalec " + Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3),
                      " (Visualisation d'une trame " + MozartParams.NomSociete + ")", "PREVIEW");

    }
    //Private Sub CmdEdit_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //  If adoRS.EOF Then Exit Sub
    //
    //  On Error Resume Next
    //  
    //
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TAudit.rtf", _
    //                           "\TAudit1.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impGammeTrameEmalec " & Val(Mid(adoRS("NTRAEMANUM"), 3)), _
    //                           " (Visualisation d'une trame " & gstrNomSociete & ")", "PREVIEW"
    //
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid_FicheTech.AddColumn(Resources.col_Num, "NTRAEMANUM", 1200);
        apiTGrid_FicheTech.AddColumn(Resources.col_Date, "DTRAEMADAT", 1400, "dd/mm/yy");
        apiTGrid_FicheTech.AddColumn(Resources.col_Type, "VGAMTYPE", 3500);

        apiTGrid_FicheTech.InitColumnList();
        apiTGrid_FicheTech.DesactiveListe();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  ApiGrid.AddColumn "N °", 1200
    //  ApiGrid.AddColumn "§Date§", 1400, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Type d'audit§", 3500
    //   
    //  ApiGrid.Init adoRS
    //  ApiGrid.DesactiveListe
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void Form_Unload(int cancel)
    {
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //



  }
}

