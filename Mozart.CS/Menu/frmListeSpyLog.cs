using DevExpress.XtraEditors;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeSpyLog : Form
  {

    private DataTable dt = new DataTable();
    //Dim rsSpy As New ADODB.Recordset
    //Dim bNiemeFois As Boolean

    public frmListeSpyLog() { InitializeComponent(); }
    /* --------------------------------------------------------------*/
    private void frmListeSpyLog_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // ModuleMain.Initboutons(this);

        txtCritUser.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("PERSONNEL"), "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        InitTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo handler:
    //
    //  bNiemeFois = False
    //  'InitBoutons Me, frmMenu
    //  InitTGrid
    //
    //  Set rsSpy = New ADODB.Recordset
    //  'txtCritPID.Init "PID"
    //  txtCritUser.Init "PERSONNEL"
    //  'txtCritFonction.Init "VSPYFCT"
    //  'txtCritAction.Init "VSPYACTION"
    //    
    //  GridT.Init rsSpy
    //  Screen.MousePointer = vbDefault
    // 
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtCritDate.Text, out d)) _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }

    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }

    private void Cal_CloseUp(object sender, EventArgs e)
    {
      if (_curDate == DateTime.MinValue) { Cal.Visible = false; return; }
      txtCritDate.Text = Cal.Value.ToShortDateString();
      Cal.Visible = false;
    }
    //Private Sub cmdDate_Click(Index As Integer)
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtCritDate <> "", txtCritDate, Now)
    //  Cal.Tag = Index
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  On Error Resume Next
    //  rsSpy.Close
    //  Set rsSpy = Nothing
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        // Création de la clause SQL à partir des critères saisis
        if (txtCritUser.GetText() == "" && txtCritDate.Text == "")
        {
          txtCritUser.Focus();
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        StringBuilder sql = new StringBuilder("Select PID, DSPYDATE, NSPYUSERNUM, VPERNOM, VSPYACTION, VSPYFCT, TEXTE, VPERNOM + ' ' + VPERPRE [VPERNOM], " +
                                              "VSOCIETE from tspylog S Join TPER P On s.NSPYUSERNUM = P.NPERNUM WHERE 1=1 ");

        if (txtCritPID.Text.Trim() != "") sql.Append(" AND PID = " + txtCritPID.Text.Trim());
        if (txtCritDate.Text.Trim() != "") sql.Append(" AND CAST(CONVERT(VARCHAR(10),DSPYDATE,103) as DATETIME) = '" + txtCritDate.Text.Trim() + "'");
        if (txtCritUser.GetText().Trim() != "") sql.Append(" AND VPERNOM + ' ' + VPERPRE LIKE '%" + txtCritUser.GetText().Trim().Replace("'", "''") + "%'");
        if (txtCritFonction.Text.Trim() != "") sql.Append(" AND VSPYFCT LIKE '%" + txtCritFonction.Text.Trim().Replace("'", "''") + "%'");
        if (txtCritAction.Text.Trim() != "") sql.Append(" AND VSPYACTION LIKE '%" + txtCritAction.Text.Trim().Replace("'", "''") + "%'");
        if (txtCritObs.Text.Trim() != "") sql.Append(" AND TEXTE LIKE '%" + txtCritObs.Text.Trim().Replace("'", "''") + "%'");

        sql.Append(" ORDER BY NSPYLOG");

        // MAJ de la table TSPYLOG
        // on le fait également dans un job sql tous les soirs
        try
        {
          // génère une exception (timeout?)
          ModuleData.ExecuteNonQuery("Exec [api_sp_MajSpyLog]");
        }
        catch (Exception) { }

        GridT.LoadData(dt, MozartDatabase.cnxMozart, sql.ToString());
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub CmdFind_Click()
    //
    //  ' Création de la clause SQL à partir des critères saisis
    //  On Error Resume Next
    //  
    //  txtCritUser.LostFocus
    //
    //  If txtCritUser.Texte = "" And txtCritDate.Text = "" Then
    //    txtCritUser.SetFocus
    //    Exit Sub
    //  End If
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  rsSpy.Close
    //  On Error GoTo Err
    //  
    //  Dim tCrit(6) As String
    //  Dim sSql As String, sWhere As String
    //  ' UPGRADE_INFO (#0501): The 'iAndPos' member isn't used anywhere in current application.
    //  Dim i As Integer, iAndPos As Integer
    //  
    //  ' Récupération des critères si non vide
    //  If Trim(txtCritPID) <> "" Then tCrit(0) = "PID = " & CLng(txtCritPID)
    //  If Trim(txtCritDate) <> "" Then tCrit(1) = "CAST(CONVERT(VARCHAR(10),DSPYDATE,103) as DATETIME) = '" & CDate(txtCritDate) & "'"
    //  If Trim(txtCritUser.Texte) <> "" Then tCrit(2) = "VPERNOM + ' ' + VPERPRE LIKE '%" & Replace(CStr(txtCritUser.Texte), "'", "''") & "%'"
    //  If Trim(txtCritFonction) <> "" Then tCrit(3) = "VSPYFCT LIKE '%" & Replace(CStr(txtCritFonction), "'", "''") & "%'"
    //  If Trim(txtCritAction) <> "" Then tCrit(4) = "VSPYACTION LIKE '%" & Replace(CStr(txtCritAction), "'", "''") & "%'"
    //  If Trim(txtCritObs) <> "" Then tCrit(5) = "TEXTE LIKE '%" & Replace(CStr(txtCritObs), "'", "''") & "%'"
    //  
    //  For i = 0 To UBound(tCrit)
    //    If tCrit(i) <> "" Then sWhere = " AND " & tCrit(i) & sWhere
    //  Next
    //    
    //  ccOffset = 0
    //  
    //  ' Clause SQL
    //  Concat sSql, "Select PID, DSPYDATE, NSPYUSERNUM, VPERNOM, VSPYACTION, VSPYFCT, TEXTE, VPERNOM + ' ' + VPERPRE [VPERNOM], VSOCIETE from tspylog S Join TPER P On s.NSPYUSERNUM = P.NPERNUM WHERE 1=1 "
    //  Concat sSql, sWhere
    //
    //  sSql = Left(sSql, ccOffset) + " ORDER BY NSPYLOG"
    //
    //  ' MAJ de la table TSPYLOG
    //  ' on le fait également dans un job sql tous les soirs
    //  cnx.Execute "Exec [api_sp_MajSpyLog]"
    //
    //  rsSpy.Open sSql, cnx, adOpenDynamic, adLockOptimistic
    //  GridT.Init rsSpy, bNiemeFois
    //  bNiemeFois = True
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //Err:
    //  ShowError "cmdFind_Click dans " & Me.Name
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitTGrid()
    {
      GridT.AddColumn("PID", "PID", 700);
      GridT.AddColumn("Date", "DSPYDATE", 2000, "Date");
      GridT.AddColumn("Utilisateur", "VPERNOM", 1400);
      GridT.AddColumn("Société", "VSOCIETE", 1200);
      GridT.AddColumn("Action", "VSPYACTION", 1500);
      GridT.AddColumn("Fonction", "VSPYFCT", 3000);
      GridT.AddColumn("Observation", "TEXTE", 3000);
      GridT.AddColumn("NSPYLOG", "NSPYLOG", 0);

      GridT.GridControl.DataSource = dt;
      GridT.InitColumnList();
    }
    //Public Sub InitTGrid()
    //
    //  GridT.AddColumn "PID", "PID", 700
    //  GridT.AddColumn "Date", "DSPYDATE", 2000 ', "dd/mm/yy"
    //  GridT.AddColumn "Utilisateur", "VPERNOM", 1400
    //  GridT.AddColumn "Société", "VSOCIETE", 1200
    //  GridT.AddColumn "Action", "VSPYACTION", 1500
    //  GridT.AddColumn "Fonction", "VSPYFCT", 4800
    //  GridT.AddColumn "Observation", "TEXTE", 1000
    //  GridT.AddColumn "NSPYLOG", "NSPYLOG", 0
    //
    //  GridT.Init rsSpy
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txt_Enter(object sender, EventArgs e)
    {
      (sender as TextBox).SelectAll();
    }
    private void txt_MouseClic(object sender, MouseEventArgs e)
    {
      (sender as TextBox).SelectAll();
    }
    //Private Sub txtCritDate_gotfocus()
    //  txtCritDate.SelStart = 0
    //  txtCritDate.SelLength = 100
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub txtCritPID_GotFocus()
    //  txtCritPID.SelStart = 0
    //  txtCritPID.SelLength = 100
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cbo_Enter(object sender, EventArgs e)
    {
      // sélectionner le texte
      foreach (Control item in (sender as MozartUC.apiCombo).Controls)
      {
        if (item is TextEdit)
          (item as TextEdit).SelectAll();
      }
    }
    private void cbo_MouseClic(object sender, MouseEventArgs e)
    {
      // sélectionner le texte
      foreach (Control item in (sender as MozartUC.apiCombo).Controls)
      {
        if (item is TextEdit)
          (item as TextEdit).SelectAll();
      }
    }
    //Private Sub txtCritUser_GotFocus()
    //  txtCritUser.SelStart = 0
    //  txtCritUser.SelLength = 100
    //End Sub
    //
    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub txtCritUser_LostFocus()
    //  txtCritUser.LostFocus
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void frmListeSpyLog_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind.PerformClick();
    }
    //Private Sub Form_KeyUp(KeyCode As Integer, Shift As Integer)
    //  If KeyCode = vbKeyF2 Then CmdFind_Click
    //End Sub
    //
  }
}

