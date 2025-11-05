using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatEI : Form
  {
    public frmStatEI() { InitializeComponent(); }

    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt3 = new DataTable();

    //Dim lRs1 As New ADODB.Recordset
    //Dim lRs2 As New ADODB.Recordset
    //Dim lRs3 As New ADODB.Recordset

    /* OK --------------------------------------------------------------*/
    private void frmStatEI_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitGrids();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  Screen.MousePointer = vbDefault
    //  
    //  InitGrids
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Activate()
    //On Error GoTo handler
    //
    //  cmdValider_Click
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitDt()
    {

      apiTGridDetails.LoadData(dt1, MozartDatabase.cnxMozart, $"EXEC [api_sp_StatistiqueEI] '{txtDateA0.Text}','{txtDateA1.Text}',1");
      apiTGridDetails.GridControl.DataSource = dt1;

      apiTGridTech.LoadData(dt2, MozartDatabase.cnxMozart, $"EXEC [api_sp_StatistiqueEI] '{txtDateA0.Text}','{txtDateA1.Text}',2");
      apiTGridTech.GridControl.DataSource = dt2;

      apiTGridSTT.LoadData(dt3, MozartDatabase.cnxMozart, $"EXEC [api_sp_StatistiqueEI] '{txtDateA0.Text}','{txtDateA1.Text}',3");
      apiTGridSTT.GridControl.DataSource = dt3;

      Cursor = Cursors.Default;

    }

    //Private Sub InitRs()
    //
    //  If lRs1.State = 1 Then lRs1.Close
    //  If lRs2.State = 1 Then lRs2.Close
    //  If lRs3.State = 1 Then lRs3.Close
    //  
    //
    //  lRs1.Open "EXEC [api_sp_StatistiqueEI] '" & txtDateA(0) & "','" & txtDateA(1) & "',1", cnx
    //  lRs2.Open "EXEC [api_sp_StatistiqueEI] '" & txtDateA(0) & "','" & txtDateA(1) & "',2", cnx
    //  lRs3.Open "EXEC [api_sp_StatistiqueEI] '" & txtDateA(0) & "','" & txtDateA(1) & "',3", cnx
    //
    //  apiTGridDetails.Init lRs1
    //  apiTGridTech.Init lRs2
    //  apiTGridSTT.Init lRs3
    //
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void InitGrids()
    {

      apiTGridDetails.AddColumn("Technicien", "TECH", 3500);
      apiTGridDetails.AddColumn("Client", "VCLINOM", 3500);
      apiTGridDetails.AddColumn("Date", "DDATE", 2000, "", 2);
      apiTGridDetails.AddColumn("Montant", "NELFTHT", 1000, "", 1);

      apiTGridDetails.InitColumnList();

      apiTGridTech.AddColumn("Technicien", "TECH", 4000);
      apiTGridTech.AddColumn("Montant", "TOT", 2000, "", 1);

      apiTGridTech.InitColumnList();

      apiTGridSTT.AddColumn("STT", "VSTFNOM", 3500);
      apiTGridSTT.AddColumn("Client", "VCLINOM", 3500);
      apiTGridSTT.AddColumn("Date", "DDATE", 2000, "", 2);
      apiTGridSTT.AddColumn("Montant", "NELFTHT", 1000, "", 1);

      apiTGridSTT.InitColumnList();
    }

    //Private Sub InitGrids()
    //
    //  apiTGridDetails.AddColumn "Technicien", "TECH", 3500
    //  apiTGridDetails.AddColumn "Client", "VCLINOM", 3500
    //  apiTGridDetails.AddColumn "Date", "DDATE", 2000, , 2
    //  apiTGridDetails.AddColumn "Montant", "NELFTHT", 1000, , 1
    //
    //  apiTGridDetails.Init lRs1
    //
    //  apiTGridTech.AddColumn "Technicien", "TECH", 4000
    //  apiTGridTech.AddColumn "Montant", "TOT", 2000, , 1
    //  
    //  apiTGridTech.Init lRs2
    //
    //  apiTGridSTT.AddColumn "STT", "VSTFNOM", 3500
    //  apiTGridSTT.AddColumn "Client", "VCLINOM", 3500
    //  apiTGridSTT.AddColumn "Date", "DDATE", 2000, , 2
    //  apiTGridSTT.AddColumn "Montant", "NELFTHT", 1000, , 1
    //
    //  apiTGridSTT.Init lRs3
    //
    //  
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (Utils.BlankIfNull(txtDateA0.Text) != "" && Utils.BlankIfNull(txtDateA1.Text) != "") InitDt();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    //
    //  If BlankIfNull(txtDateA(0).Text) <> "" And BlankIfNull(txtDateA(1).Text) <> "" Then InitRs
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate0")
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
    //Private Sub cmdDate_Click(Index As Integer)
    //  Calendar1.Visible = Not Calendar1.Visible
    //  Calendar1.value = IIf(BlankIfNull(txtDateA(Index)) = "", Now, txtDateA(Index))
    //  Calendar1.Tag = Index
    //End Sub
    //

    //Private Sub Calendar1_Click()
    //  Me.txtDateA(Calendar1.Tag) = Calendar1.value
    //  Calendar1.Visible = False
    //End Sub
    //
    //
    //

  }
}

