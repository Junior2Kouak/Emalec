using Microsoft.VisualBasic;
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
  public partial class frmSaisieKMvehPret : Form
  {
    DataTable dt = new DataTable();
    //Dim adors As ADODB.Recordset

    /*--------------------------------------------------------------*/
    public frmSaisieKMvehPret() { InitializeComponent(); }

    /* --------------------------------------------------------------------------------------- */
    private void frmSaisieKMvehPret_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        RemplirCombos();

        Calendar1.Value = DateAndTime.DateAdd("d", -7, DateTime.Now);
        Calendar1.Visible = false;

        lblDate1.Text = DateAndTime.DateAdd("d", -DateAndTime.Weekday(Calendar1.Value) + 2, Calendar1.Value).ToString();
        lblDate2.Text = DateAndTime.DateAdd("d", 8 - DateAndTime.Weekday(Calendar1.Value), Calendar1.Value).ToString();

        txtKm0.Text = Convert.ToDateTime(lblDate1.Text).ToString("dd/MM/yyyy");

        InitApiTgrid();
        cboAuto.SelectedIndex = -1;
        cboTech.SelectedIndex = -1;
        apiTGrid.chkColumnsList.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
    //Private Sub Form_Load()
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  RemplirCombos
    //  Calendar1.value = DateAdd("d", -7, Date)
    //  
    //  Calendar1.Visible = False
    //  lblDate1 = DateAdd("d", -(Weekday(Calendar1.value) - 2), Calendar1.value)
    //  lblDate2 = DateAdd("d", 8 - Weekday(Calendar1.value), Calendar1.value)
    //  txtKm(0).Text = lblDate2
    //  
    //  If txtKm(0).Text = "" Then txtKm(0).Text = lblDate1
    //  
    //  Set adors = New ADODB.Recordset
    //  adors.Open "SELECT * FROM api_v_VehKMpret WHERE NVEHNUM = " & cboAuto.ItemData(cboAuto.ListIndex) & " AND DVEHJOUR BETWEEN '" & lblDate1 & "' and '" & lblDate2 & "' ORDER BY DVEHJOUR", cnx, adOpenDynamic, adLockOptimistic
    //  
    //  InitApiTgrid
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cboAuto1_Click(object sender, EventArgs e)
    {
      txtDerKm.Text = "";
      loadDatas();
    }
    //Private Sub cboAuto_Click()
    //  txtDerKm = ""
    //  cmdv_Click
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void loadDatas()
    {
      if (cboAuto.SelectedIndex != -1)
      {
        ModuleData.LoadData(dt, $"SELECT * FROM api_v_VehKMpret WHERE NVEHNUM = {cboAuto.GetItemData()} AND DVEHJOUR BETWEEN '{lblDate1.Text.Substring(0, 10)}' " +
                                $"AND '{lblDate2.Text.Substring(0, 10)}' ORDER BY DVEHJOUR");
      }
    }
    //Private Sub cmdv_Click()  --> bouton Valider
    //  Set adors = New ADODB.Recordset
    //  adors.Open "SELECT * FROM api_v_VehKMpret WHERE NVEHNUM = " & cboAuto.ItemData(cboAuto.ListIndex) & " AND DVEHJOUR BETWEEN '" & lblDate1 & "' and '" & lblDate2 & "' ORDER BY DVEHJOUR", cnx, adOpenDynamic, adLockOptimistic
    //  apiTGrid.Init adors
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      lblDate1.Text = DateAndTime.DateAdd("d", -DateAndTime.Weekday(Calendar1.Value) + 2, Calendar1.Value).ToString();
      lblDate2.Text = DateAndTime.DateAdd("d", 8 - DateAndTime.Weekday(Calendar1.Value), Calendar1.Value).ToString();

      loadDatas();
    }
    //Private Sub Calendar1_Click()
    //  Calendar1.Visible = False
    //  lblDate1 = DateAdd("d", -(Weekday(Calendar1.value) - 2), Calendar1.value)
    //  lblDate2 = DateAdd("d", 8 - Weekday(Calendar1.value), Calendar1.value)
    //  cmdv_Click
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdDate1_Click(object sender, EventArgs e)
    {
      Calendar1.Visible = !Calendar1.Visible;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, 695, 155, 0));
    }
    //Private Sub cmdDate1_Click()
    //  Calendar1.Visible = Not Calendar1.Visible
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      // Mise à jour du dernier km connu pour le véhicule
      if (txtDerKm.Text != "")
        ModuleData.ExecuteNonQuery($"UPDATE TVEHICULES SET NVEHDERKM = {txtDerKm.Text} WHERE NVEHNUM = {cboAuto.GetItemData()}");
    }
    //Private Sub cmdValider_Click()
    //  
    //  ' Mise à jour du dernier km connu pour le véhicule
    //  If txtDerKm <> "" Then
    //    cnx.Execute "UPDATE TVEHICULES SET NVEHDERKM = " & txtDerKm.Text & " WHERE NVEHNUM = " & cboAuto.ItemData(cboAuto.ListIndex)
    //  End If
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void txtKm0_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)43)
      {
        txtKm0.Text = DateAndTime.DateAdd("d", 1, Convert.ToDateTime(txtKm0.Text)).ToString("dd/MM/yyyy");
        e.KeyChar = (char)0;
        return;
      }

      if (e.KeyChar == (char)45)
      {
        txtKm0.Text = DateAndTime.DateAdd("d", -1, Convert.ToDateTime(txtKm0.Text)).ToString("dd/MM/yyyy");
        e.KeyChar = (char)0;
        return;
      }

      if (e.KeyChar != 47)
      {
        KeyValidator.KeyPress_SaisieNombre(e);
      }
    }

    private void txtKm1_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }
    //Private Sub txtKm_KeyPress(Index As Integer, KeyAscii As Integer)
    //  If KeyAscii = 13 Then
    //    If Index < 8 Then
    //      txtKm(Index + 1).SetFocus
    //    End If
    //  End If
    //  If KeyAscii = 43 And Index = 0 Then
    //    txtKm(Index).Text = DateAdd("d", 1, CDate(txtKm(Index).Text))
    //    KeyAscii = 0
    //  End If
    //  If KeyAscii = 45 And Index = 0 Then
    //    txtKm(Index).Text = DateAdd("d", -1, CDate(txtKm(Index).Text))
    //    KeyAscii = 0
    //  End If
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 47 Or KeyAscii > 57 Then KeyAscii = 0
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void RemplirCombos()
    {
      try
      {
        // Auto
        ModuleData.RemplirCombo(cboAuto, "SELECT NVEHNUM, VVEHIMAT From TVEHICULES WHERE VSOCIETE = App_Name() AND (NOT (VVEHIMAT IS NULL) and VVEHIMAT<> '') and CVEHACTIF='O' ORDER BY  VVEHIMAT");
        cboAuto.ValueMember = "NVEHNUM";
        cboAuto.DisplayMember = "VVEHIMAT";
        // Tech
        ModuleData.RemplirCombo(cboTech, "select NPERNUM, VPERNOM + ' ' + VPERPRE as VNOM from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' ORDER BY  VPERNOM, VPERPRE");
        cboTech.ValueMember = "NPERNUM";
        cboTech.DisplayMember = "VNOM";

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub RemplirCombos()
    //
    //On Error GoTo handler
    // ' vider la combo
    //  cboTech.Clear
    //  cboAuto.Clear
    //  
    //  ' auto
    //  RemplirCombo cboAuto, "SELECT NVEHNUM, VVEHIMAT From TVEHICULES WHERE VSOCIETE = App_Name() AND (NOT (VVEHIMAT IS NULL) and VVEHIMAT<> '') and CVEHACTIF='O' ORDER BY  VVEHIMAT"
    //  ' tech
    //  RemplirCombo cboTech, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' ORDER BY  VPERNOM, VPERPRE"
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "RemplirCombos dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtKm5.Text == "")
        {
          MessageBox.Show(Resources.msg_WarningErrorOnAccount, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (!Utils.IsDate(txtKm0.Text) || txtKm0.Text == "")
        {
          MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (Convert.ToDateTime(txtKm0.Text) < Convert.ToDateTime(lblDate1.Text.Substring(0, 10)) || (Convert.ToDateTime(txtKm0.Text) > Convert.ToDateTime(lblDate2.Text)))
        {
          MessageBox.Show(Resources.msg_DateHorsSemaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtKm0.Focus();
          return;
        }

        if (cboTech.SelectedIndex <= 0)
        {
          MessageBox.Show("Il faut sélectionner un employé", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboTech.Focus();
          return;
        }

        if (cboAuto.SelectedIndex <= 0)
        {
          MessageBox.Show("Il faut sélectionner un véhicule", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboAuto.Focus();
          return;
        }

        SqlCommand cmd = new SqlCommand("api_sp_AjoutLigneFrais", MozartDatabase.cnxMozart);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@npernum"].Value = cboTech.GetItemData();
        cmd.Parameters["@nvehnum"].Value = cboAuto.GetItemData();
        cmd.Parameters["@ddatefrais"].Value = txtKm0.Text;
        cmd.Parameters["@iNbKms"].Value = Utils.ZeroIfNull(txtKm1.Text);
        cmd.Parameters["@iNbRepas"].Value = 0;
        cmd.Parameters["@iNbGD"].Value = 0;
        cmd.Parameters["@iValGD"].Value = 0;
        cmd.Parameters["@iNumCTE"].Value = Convert.ToInt16(txtKm5.Text);
        cmd.Parameters["@iNbHRSUP25"].Value = 0;
        cmd.Parameters["@iNbHRSUP50"].Value = 0;
        cmd.Parameters["@iNbHRSUP100"].Value = 0;

        cmd.ExecuteNonQuery();
        if ((Convert.ToInt16(cmd.Parameters[0].Value) == 0))
        {
          MessageBox.Show(Resources.msg_FraisExisteDejaPourJournee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
        txtKm1.Text = "";
        txtKm5.Text = "";
        txtKm0.Text = DateAndTime.DateAdd("d", 1, Convert.ToDateTime(txtKm0.Text)).ToString("dd/MM/yyyy");

        loadDatas();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdAjouter_Click()
    //
    //Dim cmd As New ADODB.Command
    //On Error GoTo handler
    //
    //  If txtKm(5).Text = "" Then
    //    MsgBox "Attention, erreur sur un compte !"
    //    Exit Sub
    //  End If
    //  
    //  If Not IsDate(txtKm(0)) Or txtKm(0).Text = "" Then
    //     MsgBox "Date invalide", vbExclamation
    //     Exit Sub
    //  End If
    //    
    //  If CDate(txtKm(0)) < CDate(lblDate1.Caption) Or CDate(txtKm(0)) > CDate(lblDate2.Caption) Then
    //    MsgBox "Date hors de la semaine", vbExclamation
    //    txtKm(0).SetFocus
    //    Exit Sub
    //  End If
    //    
    //  Set cmd.ActiveConnection = cnx
    //  cmd.CommandText = "api_sp_AjoutLigneFrais"
    //  cmd.CommandType = adCmdStoredProc

    //  cmd.Parameters.Refresh
    //  cmd.Parameters("@npernum").value = cboTech.ItemData(cboTech.ListIndex)
    //  cmd.Parameters("@nvehnum").value = cboAuto.ItemData(cboAuto.ListIndex)
    //  cmd.Parameters("@ddatefrais").value = txtKm(0).Text
    //  cmd.Parameters("@iNbKms").value = ZeroIfNull(txtKm(1).Text)
    //  cmd.Parameters("@iNbRepas").value = 0
    //  cmd.Parameters("@iNbGD").value = 0
    //  cmd.Parameters("@iValGD").value = 0
    //  cmd.Parameters("@iNumCTE").value = txtKm(5).Text
    //  cmd.Parameters("@iNbHRSUP25").value = 0
    //  cmd.Parameters("@iNbHRSUP50").value = 0
    //  cmd.Parameters("@iNbHRSUP100").value = 0
    //  
    //  cmd.Execute
    //      
    //  If cmd.Parameters(0).value = 0 Then
    //    MsgBox "Il existe dejà des frais sur cette journée!!!"
    //    Set cmd = Nothing
    //    Exit Sub
    //  End If
    //  
    //  Set cmd = Nothing
    //
    //  adors.Requery
    //  
    //  'reinit les champs text
    //  txtKm(1).Text = ""
    //  txtKm(5).Text = ""
    //  txtKm(0).Text = DateAdd("d", 1, CDate(txtKm(0).Text))
    //
    //  Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdAjouter_Click de " & Me.Name
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdSuppDate_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        if (dt.Rows.Count > 0)
        {
          if (MessageBox.Show(Resources.msg_ConfirmDelRow + "?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            ModuleData.ExecuteNonQuery($"DELETE FROM TVEHKM WHERE NPERNUM = {row["NPERNUM"]} AND NVEHNUM = {row["NVEHNUM"]} AND DVEHJOUR = '{row["DVEHJOUR"]}' AND NVEHCTE  = {row["NVEHCTE"]}");
            apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
          }
        }
        Cursor.Current = Cursors.Default;

        loadDatas();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CmdSuppDate_Click()
    //
    //  Dim sSQL As String
    //  Dim iRep As Integer
    //  
    //  On Error GoTo handler
    //  
    //  If adors.State = adStateClosed Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  If adors.RecordCount > 0 Then
    //  
    //    iRep = MsgBox("Voulez vraiment supprimer cette ligne " & adors("DVEHJOUR") & "?", vbYesNo)
    //    If iRep = vbYes Then
    //        sSQL = "DELETE FROM TVEHKM WHERE NPERNUM = " & adors("NPERNUM") & " AND NVEHNUM = " & adors("NVEHNUM") & " AND DVEHJOUR = '" & adors("DVEHJOUR") & "' AND NVEHCTE  = " & adors("NVEHCTE")
    //        cnx.Execute sSQL
    //    End If
    //  
    //    adors.Requery
    //    apiTGrid.MajLabel
    //  
    //  End If
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "CmdSuppDate_Click de " & Me.Name
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      try
      {
        apiTGrid.AddColumn(Label22.Text, "VPERNOM", cboTech.Width);
        apiTGrid.AddColumn(Label20.Text, "DVEHJOUR", txtKm0.Width);
        apiTGrid.AddColumn(Label21.Text, "NVEHKMJ", txtKm1.Width);
        apiTGrid.AddColumn(Label24.Text, "NVEHCTE", txtKm5.Width);
        apiTGrid.AddColumn("NPERNUM", "NPERNUM", 0);
        apiTGrid.AddColumn("NVEHNUM", "NVEHNUM", 0);

        apiTGrid.FilterBar = false;

        apiTGrid.DelockColumn("NVEHKMJ");
        apiTGrid.DelockColumn("NVEHCTE");

        apiTGrid.GridControl.DataSource = dt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApiTgrid()
    //  
    //On Error GoTo handler
    //
    //  apiTGrid.AddColumn "Salarié", "VPERNOM", cboTech.width
    //  apiTGrid.AddColumn "Date", "DVEHJOUR", txtKm(0).width
    //  apiTGrid.AddColumn "Kms", "NVEHKMJ", txtKm(1).width
    //  apiTGrid.AddColumn "Compte", "NVEHCTE", txtKm(5).width
    //  apiTGrid.AddColumn "NPERNUM", "NPERNUM", 0
    //  apiTGrid.AddColumn "NVEHNUM", "NVEHNUM", 0
    //  
    //  apiTGrid.FilterBar = False
    //  
    //  apiTGrid.DelockColumn ("NVEHKMJ")
    //  apiTGrid.DelockColumn ("NVEHCTE")
    //  apiTGrid.Init adors
    //
    //Exit Sub
    //handler:
    //  ShowError "InitapiTGrid dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    //Private Sub apiTGrid_BeforeColUpdate(ColIndex As Integer, Cols As TrueOleDBGrid80.Columns, BookMark As Variant, Cancel As Integer)
    // ' /!\ En commentaires 
    // '  If apiTGrid.Columns.Item(4).Value <> 0 And apiTGrid.Columns.Item(4).Value <> 65 And apiTGrid.Columns.Item(4).Value <> 70 And apiTGrid.Columns.Item(4).Value <> 75 And apiTGrid.Columns.Item(4).Value <> 85 Then
    // '    MsgBox "§La valeur GD n'est pas correcte!!§"
    // '    Cancel = True
    // '  End If
    //
    //End Sub
  }
}