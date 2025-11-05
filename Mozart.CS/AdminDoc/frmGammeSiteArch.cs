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
  public partial class frmGammeSiteArch : Form
  {
    DataTable dt = new DataTable();

    //Option Explicit
    //
    //Dim adoRS As ADODB.Recordset
    //
    public frmGammeSiteArch()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmGammeSiteArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apiTGrid_FicheTech.LoadData(dt, MozartDatabase.cnxMozart, "api_sp_InfoTramesGammeSiteArch");
        apiTGrid_FicheTech.GridControl.DataSource = dt;

        InitApigrid();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
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
    //  adoRS.Open "api_sp_InfoTramesGammeSiteArch", cnx, adOpenStatic, adLockOptimistic
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

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //  passage des infos
      frmGammeSite f = new frmGammeSite();
      f.mstrStatut = "V";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRASITNUM"].ToString(), 3));
      f.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdVisu_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmGammeSite.mstrStatut = "V"
    //  frmGammeSite.miNumTrame = Val(Mid(adoRS("NTRASITNUM"), 3))
    //  frmGammeSite.Show vbModal
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

    /* OK ---------------------------------------------------------------------*/
    private void cmdRest_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_restaurer_trame, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        Cursor.Current = Cursors.WaitCursor;
        string sSQL = "update TGAMSITE set CTRASITACTIF = 'O' where NTRASITNUM=" + Convert.ToInt32(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRASITNUM"].ToString(), 3));
        ModuleData.ExecuteNonQuery(sSQL);
        //rafraichissement
        apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
        Cursor.Current = Cursors.Default;
      }
    }
    //Private Sub cmdRest_Click()
    //     
    //Dim sSQL As String
    //
    //   If adoRS.EOF Then Exit Sub
    //
    //    Select Case MsgBox("§Voulez-vous vraiment restaurer cette trame ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //      Case vbYes
    //          sSQL = "update TGAMSITE set CTRASITACTIF = 'O' where NTRASITNUM=" & Val(Mid(adoRS("NTRASITNUM"), 3))
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
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void CmdEdit_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();

      if (row == null) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TGAMMESITE",
        sIdentifiant = $"{Strings.Mid(row["NTRASITNUM"].ToString(), 3)}|",
        InfosMail = $"TINT|NSTFNUM|1",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();

      // /!\ Les 2 derniers paramètres de la requête sont codés en dur et visiblement n'influent pas sur le résultat de la requête
      // /!\ Cette fonctionnalité / requête ne fonctionne pas en VB6
      // /!\ "exec api_sp_impTrameGammeSite " + ...["NTRASITNUM"] + ", 0, 0, '01/01/2000'",
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
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TGamme.rtf", _
    //                           "\TGamme1.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impTrameGammeSite " & Val(Mid(adoRS("NTRASITNUM"), 3)) & ", 0", _
    //                           " (Visualisation d'une gamme)", _
    //                           "PREVIEW"
    //
    //  
    //  
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid_FicheTech.AddColumn(Resources.col_Num, "NTRASITNUM", 1000);
        apiTGrid_FicheTech.AddColumn(Resources.col_Date, "DTRASITDAT", 1200, "dd/mm/yy");
        apiTGrid_FicheTech.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
        apiTGrid_FicheTech.AddColumn(Resources.col_Site, "VSITNOM", 2500);
        apiTGrid_FicheTech.AddColumn(Resources.col_Pays, "VPAYSNOM", 1500);
        apiTGrid_FicheTech.AddColumn(Resources.col_gamme, "VGAMTYP", 2500);
        apiTGrid_FicheTech.AddColumn(Resources.col_trame_emalec, "NTRAEMANUM", 1500);

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
    //  ApiGrid.AddColumn "N °", 1000
    //  ApiGrid.AddColumn "§Date§", 1200, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Client§", 2500
    //  ApiGrid.AddColumn "§Site§", 2500
    //  ApiGrid.AddColumn "§Pays§", 1500
    //  ApiGrid.AddColumn "§Gamme§", 2500
    //  ApiGrid.AddColumn "§Trame Eamlec§", 1500
    //  
    //  ApiGrid.Init adoRS
    //  ApiGrid.DesactiveListe
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void Form_Unload(int Cancel)
    {
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
  }
}