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
  public partial class frmTrameGammeClient : Form
  {
    DataTable dt = new DataTable();
    //Dim adoRS As ADODB.Recordset

    public frmTrameGammeClient()
    {
      InitializeComponent();
    }

    private void frmTrameGammeClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        LoadGrid();
        InitApigrid();
        Cursor.Current = Cursors.Default;
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
    //  adoRS.Open "api_sp_InfoTramesGammeClient 0", cnx, adOpenStatic, adLockOptimistic
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

    private void LoadGrid()
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid_FicheTech.LoadData(dt, MozartDatabase.cnxMozart, "api_sp_InfoTramesGammeClient 0");
      apiTGrid_FicheTech.GridControl.DataSource = dt;
      Cursor.Current = Cursors.Default;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      //   écran de création de la demande
      Cursor.Current = Cursors.WaitCursor;
      frmGammeClientNew f = new frmGammeClientNew();
      f.mstrStatut = "C";
      f.miNumTrame = 0;
      f.ShowDialog();

      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdNouvelle_Click()
    //    
    //  ' écran de création de la demande
    //  frmGammeClient.mstrStatut = "C"
    //  frmGammeClient.miNumTrame = 0
    //  frmGammeClient.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //        
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //    
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //   passage des infos
      frmGammeClient f = new frmGammeClient();
      f.mstrStatut = "V";
      int.TryParse(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3), out int iNumTrame);
      f.miNumTrame = iNumTrame;
      f.ShowDialog();

      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CmdVisu_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmGammeClient.mstrStatut = "V"
    //  frmGammeClient.miNumTrame = val(Mid(adoRS("NTRACLINUM"), 3))
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

    /* OK ---------------------------------------------------------------------*/
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //new frmGammeClientNew().ShowDialog();

      //passage des infos
      frmGammeClientNew f = new frmGammeClientNew();
      f.mstrStatut = "Mod";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3));
      f.ShowDialog();

      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmGammeClient.mstrStatut = "Mod"
    //  frmGammeClient.miNumTrame = val(Mid(adoRS("NTRACLINUM"), 3))
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

    /* OK ---------------------------------------------------------------------*/
    private void cmdMod_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      if ((int)apiTGrid_FicheTech.GetFocusedDataRow()["num"] == 0)
      {
        MessageBox.Show(Resources.msg_copieFichierImp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      Cursor.Current = Cursors.WaitCursor;

      //passage des infos
      frmGammeClient f = new frmGammeClient();
      f.mstrStatut = "M";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3));
      f.ShowDialog();

      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdMod_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  If adoRS("num") = 0 Then
    //    MsgBox ("Copie de gamme fichier impossible")
    //    Exit Sub
    //  End If
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmGammeClient.mstrStatut = "M"
    //  frmGammeClient.miNumTrame = val(Mid(adoRS("NTRACLINUM"), 3))
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

    /* OK ---------------------------------------------------------------------*/
    private void cmdArch_Click(object sender, EventArgs e)
    {
      if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_ConfirmArchiverGamme, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        string sSQL = "update TGAMCLIENT set CTRACLIACTIF = 'N' where NTRACLINUM="
                    + Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3); ;
        ModuleData.ExecuteNonQuery(sSQL);
      }
      else
        return;

      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdArch_Click()
    //  
    //Dim sSQL As String
    //
    //  If adoRS.EOF Then Exit Sub
    //
    //   Select Case MsgBox("§Voulez-vous vraiment archiver cette trame ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //        sSQL = "update TGAMCLIENT set CTRACLIACTIF = 'N' where NTRACLINUM=" & val(Mid(adoRS("NTRACLINUM"), 3))
    //        cnx.Execute sSQL
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //  ' mise en page du tableau
    //  InitApigrid
    //
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdListeArch_Click(object sender, EventArgs e)
    {
      //   passage des infos
      new frmGammeClientArch().ShowDialog();

      apiTGrid_FicheTech.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CmdListeArch_Click()
    //  
    //  ' passage des infos
    //  frmGammeClientArch.Show vbModal
    //  
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //  ' mise en page du tableau
    //  InitApigrid
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdEdit_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();

      if (row == null) return;

      if ((int)row["num"] == 0)
        cmdVisu_Click(null, null);
      else
      {
        string lNomReport;

        if ((bool)row["BCLIGESTNUM"] == true)
        {
          lNomReport = "TGAMMEEQUIP";
        }
        else
        {
          lNomReport = "TGAMME";
        }

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = lNomReport,
          sIdentifiant = Strings.Mid(row["NTRACLINUM"].ToString(), 3),
          InfosMail = $"TINT|NSTFNUM|1",
          sNomSociete = MozartParams.NomSociete,
          sLangue = Strings.Left(ModuleMain.CodePays(row["VPAYSNOM"].ToString()), 2),
          sOption = "PREVIEW"
        }.ShowDialog();
      }
    }
    //Private Sub CmdEdit_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  If adoRS.EOF Then Exit Sub
    //
    //  On Error Resume Next
    //
    //
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.InfosMail = "TINT|NINTNUM|1"
    //  
    //  If adoRS("num") = 0 Then
    //    Call CmdVisu_Click
    //  Else
    //    If adoRS("BCLIGESTNUM") Then
    //      frmBrowser.Preview_Print gstrCheminModeles & "FR\" & "TGammeEquip.rtf", _
    //                             "\TGamme1.rtf", _
    //                             TdbGlobal(), _
    //                             "exec api_sp_impGammeClient " & val(Mid(adoRS("NTRACLINUM"), 3)) & ", 0", _
    //                             " (Visualisation d'une gamme)", "PREVIEW"
    //    Else
    //      frmBrowser.Preview_Print gstrCheminModeles & CodePays(adoRS("VPAYSNOM")) & "\" & "TGamme.rtf", _
    //                             "\TGamme1.rtf", _
    //                             TdbGlobal(), _
    //                             "exec api_sp_impGammeClient " & val(Mid(adoRS("NTRACLINUM"), 3)) & ", 0", _
    //                             " (Visualisation d'une gamme)", "PREVIEW"
    //    End If
    //  End If
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
        apiTGrid_FicheTech.AddColumn(Resources.col_Num, "NTRACLINUM", 1000);
        apiTGrid_FicheTech.AddColumn(Resources.col_Date, "DTRACLIDAT", 1200, "dd/mm/yy");
        apiTGrid_FicheTech.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
        apiTGrid_FicheTech.AddColumn(Resources.col_Pays, "VPAYSNOM", 1500);
        apiTGrid_FicheTech.AddColumn(Resources.col_gamme, "VGAMTYPE", 3500);
        apiTGrid_FicheTech.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 2000);
        apiTGrid_FicheTech.AddColumn(Resources.col_trame + MozartParams.NomSociete, "NTRAEMANUM", 1500);
        apiTGrid_FicheTech.AddColumn(Resources.col_Num, "BCLIGESTNUM", 0);
        apiTGrid_FicheTech.AddColumn(Resources.col_Fichier, "VFICHIER", 0);

        apiTGrid_FicheTech.InitColumnList();
        apiTGrid_FicheTech.DesactiveListe();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }



    /* ---------------------------------------------------------------------*/
    //private void cmdCopierGamme_Click(object sender, EventArgs e)
    //{
    //  if (apiTGrid_FicheTech.GetFocusedDataRow() == null) return;

    //  Cursor.Current = Cursors.WaitCursor;
    //  new frmCopieGammeCli(Strings.Mid(apiTGrid_FicheTech.GetFocusedDataRow()["NTRACLINUM"].ToString(), 3)).ShowDialog();
    //  Cursor.Current = Cursors.Default;
    //}
  }
}