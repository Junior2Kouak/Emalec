using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmGammeClientArch : Form
  {

    DataTable dt = new DataTable();

    public frmGammeClientArch()
    {
      InitializeComponent();
    }

    private void frmGammeClientArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        loadGrid();
        InitApigrid();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void loadGrid()
    {
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "api_sp_InfoTramesGammeClientArch");
      apiTGrid1.GridControl.DataSource = dt;
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //  passage des infos
      frmGammeClientNew f = new frmGammeClientNew
      {
        mstrStatut = "V",
        miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid1.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3))
      };
      f.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;

      //   rafraichissement du recordset
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdVisu_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmGammeClient.mstrStatut = "V"
    //  frmGammeClient.miNumTrame = Val(Mid(adoRS("NTRACLINUM"), 3))
    //  frmGammeClient.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //     
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    private void cmdRest_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_restaurer_trame, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        string sSQL = "update TGAMCLIENT set CTRACLIACTIF = 'O' where NTRACLINUM=" + Convert.ToInt32(Strings.Mid(apiTGrid1.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3));
        ModuleData.ExecuteNonQuery(sSQL);
        //rafraichissement
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
    }

    private void CmdEdit_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();

      if (row == null) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TGAMME",
        sIdentifiant = Strings.Mid(row["NTRACLINUM"].ToString(), 3),
        InfosMail = $"TINT|NSTFNUM|1",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();
    }
    //Private Sub CmdEdit_Click()
    //
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
    //  If adoRS("num") = 0 Then
    //    Call cmdVisu_Click
    //  Else
    //    frmBrowser.bPlanningAn = 0
    //    frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & gstrLangue & "\" & "TGamme.rtf", _
    //                             "\TGamme1.rtf", _
    //                             TdbGlobal(), _
    //                             "exec api_sp_impTrameGammeClient " & Val(Mid(adoRS("NTRACLINUM"), 3)) & ", 0, 0, ''", _
    //                             " (Visualisation d'une gamme)", _
    //                             "PREVIEW"
    //  End If
    //
    //  
    //  
    //End Sub
    //

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Num, "NTRACLINUM", 1000);
        apiTGrid1.AddColumn(Resources.col_Date, "DTRACLIDAT", 1200, "dd/mm/yy");
        apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
        apiTGrid1.AddColumn(Resources.col_Pays, "VPAYSNOM", 1500);
        apiTGrid1.AddColumn(Resources.col_gamme, "VGAMTYPE", 2500);
        apiTGrid1.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1500);
        apiTGrid1.AddColumn(Resources.col_trame, "NTRAEMANUM", 1500);

        apiTGrid1.InitColumnList();
        apiTGrid1.DesactiveListe();
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
    //  ApiGrid.AddColumn "N °", 1000
    //  ApiGrid.AddColumn "§Date§", 1200, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Client§", 2500
    //  ApiGrid.AddColumn "§Pays§", 1500
    //  ApiGrid.AddColumn "§Gamme§", 2500
    //  ApiGrid.AddColumn "§Contrat§", 1500
    //  ApiGrid.AddColumn "§Trame §" & gstrNomSociete, 1500
    //  
    //  ApiGrid.Init adoRS
    //  ApiGrid.DesactiveListe
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
  }
}

