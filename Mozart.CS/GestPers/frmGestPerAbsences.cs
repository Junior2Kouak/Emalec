using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestPerAbsences : Form
  {
    public string mLibNomSoc;
    public int mnIdMenuParent;

    DataTable dtAbs = new DataTable();

    //  Option Explicit
    //
    //Public sLibNomSoc As String
    //Public nIdMenuParent As Integer
    //
    //Dim cmd As New ADODB.Command
    //Dim rsAbs As New ADODB.Recordset
    //Dim iTextBoxDate As Integer

    public frmGestPerAbsences() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmGestPerAbsences_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtDateA0.Text = "01/01/" + DateTime.Now.Year.ToString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        Label1.Text = MozartParams.NomSocieteTemp;

        InitApigrid();

        Cursor = Cursors.Default;
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
    //On Error GoTo handler
    //
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //  
    //  txtDateA(0) = "01/01/" & DatePart("yyyy", Date)
    //  txtDateA(1) = Date
    //  
    //  Label1.Caption = gstrNomSocieteTemp
    //  
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {

      Cursor = Cursors.WaitCursor;

      using (SqlCommand cmd = new SqlCommand("api_sp_TableauAbsences", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandTimeout = 120;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@DateDebut"].Value = Utils.DateBlankIfNull(txtDateA0.Text);
        cmd.Parameters["@DateFin"].Value = Utils.DateBlankIfNull(txtDateA1.Text);
        cmd.Parameters["@vsociete"].Value = MozartParams.NomSocieteTemp;
        cmd.Parameters["@numMenu"].Value = mnIdMenuParent;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dtAbs);

        //on enlève la décimale si elle est égale à 0
        foreach (DataRow dr in dtAbs.Rows)
        {
          if (dr["CONGESPAYES"].ToString() != "")
          {
            string[] tabTemp = dr["CONGESPAYES"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["CONGESPAYES"] = tabTemp[0];
          }

          if (dr["AT"].ToString() != "")
          {
            string[] tabTemp = dr["AT"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["AT"] = tabTemp[0];
          }

          if (dr["MALADIE"].ToString() != "")
          {
            string[] tabTemp = dr["MALADIE"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["MALADIE"] = tabTemp[0];
          }

          if (dr["MALPROFESSIONNEL"].ToString() != "")
          {
            string[] tabTemp = dr["MALPROFESSIONNEL"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["MALPROFESSIONNEL"] = tabTemp[0];
          }

          if (dr["ABSENCE"].ToString() != "")
          {
            string[] tabTemp = dr["ABSENCE"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["ABSENCE"] = tabTemp[0];
          }

          if (dr["RC"].ToString() != "")
          {
            string[] tabTemp = dr["RC"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["RC"] = tabTemp[0];
          }

          if (dr["CGSSSOLDE"].ToString() != "")
          {
            string[] tabTemp = dr["CGSSSOLDE"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["CGSSSOLDE"] = tabTemp[0];
          }

          if (dr["CGMATPAT"].ToString() != "")
          {
            string[] tabTemp = dr["CGMATPAT"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["CGMATPAT"] = tabTemp[0];
          }

          if (dr["CGEVEPRESO"].ToString() != "")
          {
            string[] tabTemp = dr["CGEVEPRESO"].ToString().Split(',');
            if (tabTemp[1] == "0") dr["CGEVEPRESO"] = tabTemp[0];
          }
        }

        apiGrid.GridControl.DataSource = dtAbs;
      }
      Cursor = Cursors.Default;
    }
    //Private Sub cmdValider_Click()
    //
    //On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //
    //  Set cmd.ActiveConnection = cnx
    //  cmd.CommandText = "api_sp_TableauAbsences "
    //  cmd.CommandType = adCmdStoredProc
    //  cmd.CommandTimeout = 120
    //  
    //  cmd.Parameters("@DateDebut").Value = txtDateA(0)
    //  cmd.Parameters("@DateFin").Value = txtDateA(1)
    //  cmd.Parameters("@vsociete").Value = gstrNomSocieteTemp
    //  cmd.Parameters("@numMenu").Value = nIdMenuParent
    //  Set rsAbs = cmd.Execute()
    //  
    //  apiGrid.Init rsAbs, True
    // 
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub
    //

    /* inutile--------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  On Error Resume Next
    //  rsAbs.Close
    //  Set rsAbs = Nothing
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {

      try
      {
        apiGrid.AddColumn("Num", "NPERNUM", 0);
        apiGrid.AddColumn(Resources.col_Nom, "VPERNOM", 3800);

        if (MozartParams.NomSocieteTemp == "GROUPE")
          apiGrid.AddColumn(Resources.col_Societe, "VSOCIETE", 0);
        else
          apiGrid.AddColumn(Resources.col_Societe, "VSOCIETE", 1800);

        apiGrid.AddColumn(Resources.col_cgPayes, "CONGESPAYES", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_at, "AT", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_maladie, "MALADIE", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_malPro, "MALPROFESSIONNEL", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_absence, "ABSENCE", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_rc, "RC", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_cgSSSolde, "CGSSSOLDE", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_cgMatPat, "CGMATPAT", 1800, "", 2);
        apiGrid.AddColumn(Resources.col_cgEvenPerso, "CGEVEPRESO", 1800, "", 2);

        apiGrid.InitColumnList();
        apiGrid.dgv.OptionsView.ColumnAutoWidth = false;
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
    //  apiGrid.AddColumn "Num", "NPERNUM", 0
    //  apiGrid.AddColumn "§Nom§", "VPERNOM", 3800           '0
    //  apiGrid.AddColumn "§Société§", "VSOCIETE", 1800           '0
    //  apiGrid.AddColumn "§CG Payés§", "CONGESPAYES", 1800, , 2
    //  apiGrid.AddColumn "§A T§", "AT", 1800, , 2
    //  apiGrid.AddColumn "§Maladie§", "MALADIE", 1800, , 2
    //  apiGrid.AddColumn "§MAL. PRO§", "MALPROFESSIONNEL", 1800, , 2
    //  apiGrid.AddColumn "§Absence§", "ABSENCE", 1800, , 2
    //  apiGrid.AddColumn "§R C§", "RC", 1800, , 2
    //  apiGrid.AddColumn "§CG SS Solde§", "CGSSSOLDE", 1800, , 2
    //  apiGrid.AddColumn "§CG MAT/PAT§", "CGMATPAT", 1800, , 2
    //  apiGrid.AddColumn "§CG Even Perso§", "CGEVEPRESO", 1800, , 2
    //  
    //  If gstrNomSocieteTemp = "GROUPE" Then
    //    apiGrid.Columns.Item("§Société§").Visible = True
    //  Else
    //    apiGrid.Columns.Item("§Société§").Visible = False
    //  End If
    //  
    //  apiGrid.Init rsAbs
    //
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    //Private Sub cmdDate1_Click()
    //    
    //On Error GoTo handler
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.Value = Now
    //  End If
    //  Exit Sub
    //
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    //Private Sub cmdDate2_Click()
    //
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.Value = Now
    //  End If
    //  Exit Sub
    //
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
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
    //Private Sub Calendar1_Click()
    //
    //  Me.txtDateA(iTextBoxDate) = Calendar1.Value
    //  Calendar1.Visible = False
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //


  }
}

