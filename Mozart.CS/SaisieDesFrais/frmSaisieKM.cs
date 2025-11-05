using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmSaisieKM : Form
  {
    DataTable dt = new DataTable();
    bool mbFirstTime;

    //Dim adoRS As ADODB.Recordset
    //Dim bFirstTime As Boolean
    //Dim sCal As String
    public frmSaisieKM()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------*/
    private void frmSaisieKM_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        mbFirstTime = true;
        DateTime d = Convert.ToDateTime(DateTime.Now.ToString("01/MM/yyyy"));

        txtDebPer.Text = d.ToShortDateString();
        txtFinPer.Text = d.AddMonths(1).AddDays(-1).ToShortDateString();

        if (cboType.Items.Count > 0)
          cboType.SelectedIndex = 0;
        mbFirstTime = false;

        ApiGrid.dgv.OptionsView.ColumnAutoWidth = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //    
    //On Error GoTo Handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  bFirstTime = True
    //   
    //  txtDebPer = "01/" & Month(Date) & "/" & Year(Date)
    //  txtFinPer = DateAdd("d", -1, CDate("01/" & Month(DateAdd("m", 1, Date)) & "/" & Year(DateAdd("m", 1, Date))))
    //  cboType.Text = "KM"
    //  
    //  bFirstTime = False
    // 
    //Exit Sub
    //Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /*OK --------------------------------------------------------------------------*/
    private void cmdStatClient_Click(object sender, EventArgs e)
    {
      DateTime temp;
      if (DateTime.TryParse(txtDebPer.Text, out temp) && DateTime.TryParse(txtFinPer.Text, out temp) && cboType.Text != "")
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmStatFrais("T", cboType.Text, txtDebPer.Text, txtFinPer.Text).ShowDialog();
        Cursor.Current = Cursors.Default;
      }
    }
    //Private Sub cmdStatClient_Click()
    //    
    //    If IsDate(txtDebPer) And IsDate(txtFinPer) And cboType.Text <> "" Then
    //        modMain.VerifMOZARTNET
    //        OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmStatFrais T|" & cboType.Text & "|" & txtDebPer.Text & "|" & txtFinPer.Text, vbNormalFocus
    //    End If
    //    
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT DISTINCT NCANNUM FROM TCAN, TPER WHERE TCAN.NPERNUM = TPER.NPERNUM " +
                                      $"AND VSOCIETE = '{ MozartParams.NomSociete}' AND NCANNUM < 1000 order by NCANNUM "))
        {
          ApiGrid.dgv.Columns.Clear();
          ApiGrid.dicCellsAlignment.Clear();

          ApiGrid.AddColumn(Resources.col_Personne, dt.Columns[0].ColumnName, 2000);
          ApiGrid.AddColumn(Resources.col_Total, dt.Columns[1].ColumnName, 650, "", 1);

          int i = 2;
          while (reader.Read())
            ApiGrid.AddColumn(Utils.BlankIfNull(reader["NCANNUM"]), dt.Columns[i++].ColumnName, 400, "", 1);

          ApiGrid.AddColumn("", dt.Columns[i].ColumnName, 0);

          ApiGrid.InitColumnList();
          ApiGrid.DesactiveListe();

          this.Text = Resources.txt_TableauAnalytiqueDesFrais + " (" + cboType.Text + Resources.txt_du + txtDebPer.Text + Resources.txt_au + txtFinPer.Text + ")";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo Handler
    //Dim rs As ADODB.Recordset
    //
    // 
    //  Set rs = New ADODB.Recordset
    //  rs.Open "SELECT DISTINCT NCANNUM FROM TCAN, TPER WHERE TCAN.NPERNUM = TPER.NPERNUM AND VSOCIETE = '" & gstrNomSociete & "' AND NCANNUM < 1000 order by NCANNUM ", cnx
    //
    //
    //  ApiGrid.AddColumn "§Personne§", 2500
    //  ApiGrid.AddColumn "§Total§", 650
    //  
    //  While Not rs.EOF
    //      ApiGrid.AddColumn rs("NCANNUM"), 400
    //      rs.MoveNext
    //  Wend
    //  
    //  
    //  ApiGrid.AddColumn "NPERNUM", 0
    // 
    //  ApiGrid.Init adoRS
    //  
    //  ApiGrid.DesactiveListe
    //  
    //  Me.Caption = "§Tableau analytique des frais§" & " (" & cboType.Text & " du " & txtDebPer & " au " & txtFinPer & ")"
    //   
    //Exit Sub
    //
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      ApiGrid.btnPrint_Click(null, null);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdImprimer_Click()
    //  ' impression du datagrid
    //  Screen.MousePointer = vbHourglass
    //  ApiGrid.PrintGrid Me
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void frmSaisieKM_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------*/

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Cal.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDebPer")
      {
        txtDate = txtDebPer.Text;
        Cal.Tag = 0;
      }
      else
      {
        txtDate = txtFinPer.Text;
        Cal.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }

      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Cal.Tag == 0) txtDebPer.Text = Cal.Value.ToShortDateString();
      else if ((int)Cal.Tag == 1) txtFinPer.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    //Private Sub cmdDebPer_Click()
    //  sCal = "DEB"
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtDebPer <> "", txtDebPer, Now)
    //End Sub

    //Private Sub cmdFinPer_Click()
    //  sCal = "FIN"
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtFinPer <> "", txtFinPer, Now)
    //End Sub

    //Private Sub Cal_Click()
    //  
    //  If sCal = "DEB" Then
    //    txtDebPer = Cal.value
    //  ElseIf sCal = "FIN" Then
    //    txtFinPer = Cal.value
    //  End If
    //  
    //  Cal.Visible = False
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (mbFirstTime) return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ApiGrid.GridControl.DataSource = null;
        dt.Clear();

        string sSQL = $"exec api_sp_SaisieKM '{txtDebPer.Text}', '{txtFinPer.Text}', '{cboType.Text}'";
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL, 300);

        InitApigrid();

        ApiGrid.GridControl.DataSource = dt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdValider_Click()
    //If bFirstTime Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  On Error Resume Next
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  
    //  adoRS.Open "exec api_sp_SaisieKM '" & txtDebPer & "', '" & txtFinPer & "', '" & cboType.Text & "'", cnx, adOpenDynamic, adLockOptimistic
    // 
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me
    //End Sub
  }
}