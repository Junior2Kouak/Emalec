using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDISTT : Form
  {
    DataTable dt = new DataTable();

    TooltipGridTPE _tpe;

    public frmListeDISTT() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeDISTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtCritSTF.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("STF"), "NSTFNUM", "VSTFNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 55, true);

        InitApigrid();

        _tpe = new TooltipGridTPE(apiGrid, toolTipController1);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //On Error GoTo Handler:
    //
    //    InitBoutons Me, frmMenu
    //    
    //    txtCritSTF.Init "STF"
    //    
    //    Set rsDI = New ADODB.Recordset
    //    
    //    InitApigrid
    //    
    //    Screen.MousePointer = vbDefault
    //    
    //Exit Sub
    //Resume
    //Handler:
    //      Screen.MousePointer = vbDefault
    //      ShowError "Form_Load de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void frmListeDISTT_KeyUp(object sender, KeyEventArgs e)
    {
      if (Keys.Enter == e.KeyCode || e.KeyCode == Keys.F2) cmdFind_Click(null, null);
    }
    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtCritSTF.GetText() == "")
        {
          MessageBox.Show("Il faut selectionner un sous-traitant", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtCritSTF.Focus();
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        string sSql = $"EXEC api_sp_listeDI_ACTION_STT 0,'','', '{(txtCritSTF.GetText().Trim() != "" ? txtCritSTF.GetText().Replace("'", "''") : "T@$")}'";

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
        apiGrid.GridControl.DataSource = dt;

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdFind_Click()
    //
    //    On Error GoTo Handler:
    //
    //    Dim sSql As String
    //        
    //    If txtCritSTF.Texte = "" Then
    //      MsgBox "Il faut selectionner un sous-traitant", vbInformation
    //      txtCritSTF.SetFocus
    //      Exit Sub
    //    End If
    //    If rsDI.State = adStateOpen Then rsDI.Close
    //
    //    Screen.MousePointer = vbHourglass
    //
    //    sSql = "EXEC api_sp_listeDI_ACTION_STT 0,'',''," & "'" & IIf(Trim(txtCritSTF.Texte) <> "", Replace(CStr(txtCritSTF.Texte), "'", "''"), "T@$") & "'"
    //
    //    
    //'    sSql = "EXEC api_sp_listeDI_ACTION_STT " & IIf(Trim(txtCritNumDI.Text) <> "", CLng(ZeroIfNull(txtCritNumDI.Text)), "-1") & ", "
    //'    sSql = sSql & "'" & IIf(Trim(txtCritClient.Texte) <> "", Replace(CStr(txtCritClient.Texte), "'", "''"), "T@$") & "', "
    //'    sSql = sSql & "'" & IIf(Trim(txtCritSite.Texte) <> "", Replace(CStr(txtCritSite.Texte), "'", "''"), "T@$") & "', "
    //'    sSql = sSql & "'" & IIf(Trim(txtCritSTF.Texte) <> "", Replace(CStr(txtCritSTF.Texte), "'", "''"), "T@$") & "', "
    //'    sSql = sSql & "'" & IIf(Trim(txtCritNumSite.Text) <> "", Replace(CStr(txtCritNumSite.Text), "'", "''"), "T@$") & "'"
    //           
    //           
    //    rsDI.Open sSql, cnx, adOpenDynamic, adLockOptimistic
    //    apiGrid.Init rsDI
    //    rsDI.Requery
    //    Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //Handler:
    //      Screen.MousePointer = vbDefault
    //      ShowError "cmdFind_Click de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      //écran de modification de la demande
      new frmAddAction()
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apiGrid.AddColumn(Resources.col_date_c, "DDINDATHEUR", 850, "dd/MM/yy");
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000);
      apiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1350);
      apiGrid.AddColumn("N°", "NSITNUE", 480);
      apiGrid.AddColumn(Resources.col_Action, "VACTDES", 4000, "", 0, true);
      apiGrid.AddColumn(Resources.col_Date, "DACTDATE", 850, "dd/MM/yy");
      apiGrid.AddColumn(Resources.col_Technicien, "VACTINT", 800);
      apiGrid.AddColumn(Resources.col_T_echnique, "CTECCOD", 230, "", 2);
      apiGrid.AddColumn(Resources.col_P_restation, "CPRECOD", 230, "", 2);
      apiGrid.AddColumn(Resources.col_E_tat, "CETACOD", 230, "", 2);
      apiGrid.AddColumn(Resources.col_A_dministration, "CACTSTA", 250, "", 2);
      apiGrid.AddColumn(Resources.col_OBS, "VACTOBS", 3000, "", 0, true);
      apiGrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiGrid.AddColumn(Resources.col_F_Ravel, "CFACRAVEL", 800);

      apiGrid.InitColumnList();
    }

  }
}

