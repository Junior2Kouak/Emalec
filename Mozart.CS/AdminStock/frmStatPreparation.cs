using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatPreparation : Form
  {
    //Dim ado_rs As ADODB.Recordset
    //Dim iTextBoxDate As Integer

    DataTable dt;

    public frmStatPreparation() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStatPreparation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        dt = new DataTable();
        txtDateA0.Text = DateTime.Today.AddMonths(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Today.ToShortDateString();
        InitTGrid();
        cmdValider_Click(null, null);
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
    //  
    //  Set ado_rs = New ADODB.Recordset
    //  
    //  InitBoutons Me, frmMenu
    //  txtDateA(0) = DateAdd("m", -1, Date)
    //  txtDateA(1) = Date
    //  InitTGrid False
    //  cmdValider_Click
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        //  test des dates
        DateTime d;
        if (!DateTime.TryParse(txtDateA0.Text, out d))
        {
          MessageBox.Show(Resources.msg_must_select_start_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (!DateTime.TryParse(txtDateA1.Text, out d))
        {
          MessageBox.Show(Resources.msg_must_select_end_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        Cursor.Current = Cursors.WaitCursor;
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_StatistiquePreparation '{txtDateA0.Text}', '{txtDateA1.Text}'");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdValider_Click()
    //' UPGRADE_INFO (#0501): The 'i' member isn't used anywhere in current application.
    //' Dim i As Integer
    //
    //  ' test des dates
    //  If txtDateA(0) = "" Then
    //    MsgBox "§il faut saisir une date de début§"
    //    Exit Sub
    //  End If
    //  
    //  If txtDateA(1) = "" Then
    //    MsgBox "§il faut saisir une date de fin§"
    //    Exit Sub
    //  End If
    //  
    //  On Error GoTo handler:
    //  Screen.MousePointer = vbHourglass
    //  Set ado_rs = New ADODB.Recordset
    //  ado_rs.Open "exec api_sp_StatistiquePreparation '" & txtDateA(0) & "', '" & txtDateA(1) & "'", cnx
    //  
    //  Screen.MousePointer = vbDefault
    //  If ado_rs.EOF Then Exit Sub
    //  
    //  InitTGrid True
    //
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    /* OK --------------------------------------------------------------------------------------- */
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    //Private Sub cmdDate1_Click()
    //    
    //On Error GoTo handler
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdDate2_Click()
    // 
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //      Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Calendar1_Click()
    //
    //  Me.txtDateA(iTextBoxDate) = Calendar1.value
    //  Calendar1.Visible = False
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitTGrid()
    {
      apiTGrid.AddColumn(Resources.col_Date, "DBLDATE", 1200, "dd/mm/yy");
      apiTGrid.AddColumn(Resources.col_operateur, "VBLCREATEUR", 2500);
      apiTGrid.AddColumn(Resources.col_qte2, "NB", 1200);
      apiTGrid.InitColumnList();
      apiTGrid.GridControl.DataSource = dt;
    }
    //Private Sub InitTGrid(bvalid As Boolean)
    //  
    //If Not bvalid Then
    //  apiTGrid.AddColumn "§Date§", "DBLDATE", 1200, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Opérateur§", "VBLCREATEUR", 2500
    //  apiTGrid.AddColumn "§Qté§", "NB", 1200
    //End If
    //
    //apiTGrid.Init ado_rs, bvalid
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
  }
}

