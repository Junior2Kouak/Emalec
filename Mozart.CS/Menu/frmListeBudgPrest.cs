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
  public partial class frmListeBudgPrest : Form
  {
    public int miNumClient;
    public string msNomClient;
    //Public miNumClient As Integer
    //Public msNomClient As String

    private DataTable dt = new DataTable();
    //Dim adoRS As ADODB.Recordset
    //Dim iTextBoxDate As Integer
    //Dim sSQL As String

    public frmListeBudgPrest() { InitializeComponent(); }

    private void frmListeBudgPrest_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Affichage du client
        lblClient.Text = "  " + msNomClient;

        // combo des années
        int annee = DateTime.Now.Year;
        cboAnnee.Items.Add("");
        for (int i = 0; i < 20; i++)
          cboAnnee.Items.Add((annee--).ToString());
        cboAnnee.SelectedIndex = 0;

        InitApigrid();

        this.cboAnnee.SelectedIndexChanged += new System.EventHandler(this.cboAnnee_SelectedIndexChanged);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //  
    //
    //On Error GoTo handler
    //
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //
    //  'Affichage du client
    //  lblClient = "  " & msNomClient
    //    
    //  ' combo des années
    //  cboAnnee.Text = Year(Date)
    //  cboAnnee_Click
    //    
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtDateA0.Text.Trim() == "")
        {
          MessageBox.Show(Resources.msg_saisirDateDebutPer, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (txtDateA1.Text.Trim() == "")
        {
          MessageBox.Show(Resources.msg_saisirDateFinPer, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        EnregistrerBudget();

        cboAnnee_SelectedIndexChanged(sender, e);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }
    //Private Sub cmdAjouter_Click()
    //  
    // On Error GoTo handler
    //    
    //  If txtDateA(0) = "" Then
    //    MsgBox "§Saisissez une date de début de période§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  If txtDateA(1) = "" Then
    //    MsgBox "§Saisissez une date de fin de période§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  EnregistrerBudget
    //  
    //  cboAnnee_Click
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdAjouter_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      // select VSITNOM, PREV,CURA,IMMO,SINI,DDATEDEB,DDATEFIN from TSIT, TBUDGPREST 
      apigrid.AddColumn("NSITNUM", "NSITNUM", 0);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 2800);
      apigrid.AddColumn(Resources.col_preventif, "PREV", 1100, "### ##0", 2);
      apigrid.AddColumn(Resources.col_curatif, "CURA", 1100, "### ##0", 2);
      apigrid.AddColumn(Resources.lib_immo, "IMMO", 1100, "### ##0", 2);
      apigrid.AddColumn(Resources.col_sinistre, "SINI", 1100, "### ##0", 2);
      apigrid.AddColumn(Resources.col_date_debut, "DDATEDEB", 0, "dd/MM/yyyy");
      apigrid.AddColumn(Resources.col_date_fin, "DDATEFIN", 0, "dd/MM/yyyy");

      apigrid.DelockColumn("PREV");
      apigrid.DelockColumn("CURA");
      apigrid.DelockColumn("IMMO");
      apigrid.DelockColumn("SINI");

      apigrid.InitColumnList();

      apigrid.GridControl.DataSource = dt;
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  apigrid.AddColumn "§Site§", 2800
    //  apigrid.AddColumn "§Préventif§", 1100, "### ##0", 2
    //  apigrid.AddColumn "§Curatif§", 1100, "### ##0", 2
    //  apigrid.AddColumn "§Immo §", 1100, "### ##0", 2
    //  apigrid.AddColumn "§Sinistre §", 1100, "### ##0", 2
    //  apigrid.AddColumn "§dated§", 0
    //  apigrid.AddColumn "§datef§", 0
    //  
    //  apigrid.Init adoRS
    //   
    //  apigrid.LockColonne 0
    //  apigrid.NotDeleteNew
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboAnnee_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        dt.Rows.Clear();
        txtDateA0.Text = txtDateA1.Text = "";

        if ((string)cboAnnee.SelectedItem == "")
        {
          cmdAjouter.Visible = false;
          return;
        }

        // recherche des information pour cette année là
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"select TSIT.NSITNUM, VSITNOM, PREV,CURA,IMMO,SINI,DDATEDEB,DDATEFIN from TSIT, TBUDGPREST " +
                                             $" where TSIT.NSITNUM=TBUDGPREST.NSITNUM AND NANNEE ={cboAnnee.SelectedItem} AND TBUDGPREST.NCLINUM= {miNumClient}");

        if (dt.Rows.Count != 0)
        {
          cmdAjouter.Visible = false;
          txtDateA0.Text = Utils.DateBlankIfNull(dt.Rows[0]["DDATEDEB"]);
          txtDateA1.Text = Utils.DateBlankIfNull(dt.Rows[0]["DDATEFIN"]);
        }
        else cmdAjouter.Visible = true;
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }
    //Private Sub cboAnnee_Click()
    //
    //On Error GoTo handler
    //
    //
    //  ' recherche des information pour cette année là
    //  Set adoRS = New ADODB.Recordset
    //  sSQL = "select VSITNOM, PREV,CURA,IMMO,SINI,DDATEDEB,DDATEFIN from TSIT, TBUDGPREST "
    //  sSQL = sSQL & " where TSIT.NSITNUM=TBUDGPREST.NSITNUM AND NANNEE =" & cboAnnee.Text & " AND TBUDGPREST.NCLINUM= " & miNumClient
    //  adoRS.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //      
    //  
    //  cmdAjouter.Visible = (adoRS.EOF)
    //  InitApigrid
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  txtDateA(0) = BlankIfNull(adoRS("DDATEDEB"))
    //  txtDateA(1) = BlankIfNull(adoRS("DDATEFIN"))
    //  
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cboAnnee_Click dans " & Me.Name
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
    /* --------------------------------------------------------------------------------------- */
    private void EnregistrerBudget()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlCommand cmd = new SqlCommand("api_sp_creationBudgetPrev", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // liste des paramètres
          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@nAnnee"].Value = cboAnnee.SelectedItem;
          cmd.Parameters["@dDeb"].Value = Convert.ToDateTime(txtDateA0.Text.Trim());
          cmd.Parameters["@dFin"].Value = Convert.ToDateTime(txtDateA1.Text.Trim());

          // exécuter la commande.
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub EnregistrerBudget()
    //' UPGRADE_INFO (#0501): The 'sSQL' member isn't used anywhere in current application.
    //' Dim sSQL As String
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //    
    //  Screen.MousePointer = vbHourglass
    //
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_creationBudgetPrev"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //  ' liste des paramètres
    //  ado_cmd.Parameters("@iClient").value = miNumClient
    //  ado_cmd.Parameters("@nAnnee").value = cboAnnee.Text
    //  ado_cmd.Parameters("@dDeb").value = txtDateA(0)
    //  ado_cmd.Parameters("@dFin").value = txtDateA(1)
    //  
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //      
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //  Set ado_rs = Nothing
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "EnregistrerBudget dans " & Me.Name
    //End Sub
    //
    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //    
    /* --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
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
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    //Private Sub cmdDate1_Click()
    //    
    //On Error GoTo handler
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //      
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    //Private Sub cmdDate2_Click()
    // 
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //      
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
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

    private void apigrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      try
      {
        DataRow row = apigrid.GetFocusedDataRow();
        if (null == row) return;

        string sql = "UPDATE TBUDGPREST SET ";
        switch (e.Column.FieldName)
        {
          case "PREV":
            sql += $"PREV ={(Convert.IsDBNull(row["PREV"]) ? "null" : row["PREV"])}";
            break;
          case "CURA":
            sql += $"CURA ={(Convert.IsDBNull(row["CURA"]) ? "null" : row["CURA"])}";
            break;
          case "IMMO":
            sql += $"IMMO ={(Convert.IsDBNull(row["IMMO"]) ? "null" : row["IMMO"])}";
            break;
          case "SINI":
            sql += $"SINI ={(Convert.IsDBNull(row["SINI"]) ? "null" : row["SINI"])}";
            break;
        }

        sql += $" WHERE NSITNUM = {row["NSITNUM"]} AND NANNEE = {cboAnnee.SelectedItem} AND NCLINUM = {miNumClient}";

        ModuleData.ExecuteNonQuery(sql);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }
  }
}

