using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockSuivi : Form
  {
    DataTable dt = new DataTable();
    string sSQL;

    public frmStockSuivi() { InitializeComponent(); }

    private void frmStockSuivi_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.AddMonths(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        apiTGrid1_AffichageDonnees();

        InitGrid();
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
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  txtDateA(0) = DateAdd("m", -1, Date)
    //  txtDateA(1) = Date
    //  
    //  InitGrid False
    //  cmdValider_Click
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 3000);
      apiTGrid1.AddColumn(Resources.col_Date, "DLOGDATE", 2000, "Date");
      apiTGrid1.AddColumn(Resources.col_utilisateur, "VPERNOMMODIF", 1500, "", 2);
      apiTGrid1.AddColumn(Resources.col_QteMvt, "NQTEMVT", 1200, "", 2);
      apiTGrid1.AddColumn(Resources.col_Prix_Unit, "PU", 1200, "Currency", 1);
      apiTGrid1.AddColumn(Resources.col_Montant, "MONTANT", 1200, "Currency", 1);
      apiTGrid1.AddColumn(Resources.col_QteAvant, "NQTEAV", 1150, "", 2);
      apiTGrid1.AddColumn(Resources.col_QteApres, "NQTEAP", 1150, "", 2);

      apiTGrid1.InitColumnList();
    }
    //Private Sub InitGrid(bvalid As Boolean)
    //
    //  If Not bvalid Then
    //    apiTGrid1.AddColumn "§Matériel§", "VFOUMAT", 3000
    //    apiTGrid1.AddColumn "§Date§", "DLOGDATE", 2000
    //    apiTGrid1.AddColumn "§Utilisateur§", "VPERNOMMODIF", 1500, , 2
    //    apiTGrid1.AddColumn "§Qté mvt§", "NQTEMVT", 1200, , 2
    //    apiTGrid1.AddColumn "§Prix unit§", "PU", 1200, "Currency", 1
    //    apiTGrid1.AddColumn "§Montant§", "MONTANT", 1200, "Currency", 1
    //    apiTGrid1.AddColumn "§Qté avant§", "NQTEAV", 1150, , 2
    //    apiTGrid1.AddColumn "§Qté après§", "NQTEAP", 1150, , 2
    //    
    //    apiTGrid1.AddCellStyle "NQTEMVT", "Couleur", vbRed, 0
    //  End If
    // 
    //  apiTGrid1.Init adoRS, bvalid
    // 
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //
    //  adoRS.Close
    //
    //  Unload Me
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // test des dates
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_start_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_end_date, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (Convert.ToDateTime(txtDateA1.Text) < Convert.ToDateTime(txtDateA0.Text)) return;

        Cursor.Current = Cursors.WaitCursor;

        apiTGrid1_AffichageDonnees();
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void apiTGrid1_AffichageDonnees()
    {
      sSQL = $"select VFOUMAT,DLOGDATE,VPERNOMMODIF,NQTEAV,NQTEAP,NQTEMVT,PU,MONTANT " +
               $"FROM api_v_ListeAjustementStock " +
               $"WHERE VSOCIETE = App_Name() " +
               $"AND DLOGDATE BETWEEN '" + txtDateA0.Text + "'AND'" + txtDateA1.Text + " 23:59:59.999' " +
               $"order by DLOGDATE desc";

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiTGrid1.GridControl.DataSource = dt;

      sSQL = $"select CONVERT(INT,SUM(MONTANT)) as TOTAL " +
             $"FROM api_v_ListeAjustementStock " +
             $"WHERE VSOCIETE = App_Name() " +
             $"AND DLOGDATE BETWEEN '" + txtDateA0.Text + "'AND'" + txtDateA1.Text + " 23:59:59.999' ";

      string total = ModuleData.ExecuteScalarString(sSQL);
      txtTotal.Text = total;
    }
    //Private Sub cmdValider_Click()
    //Dim rsTotal As ADODB.Recordset
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
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select VFOUMAT,DLOGDATE,VPERNOMMODIF,NQTEAV,NQTEAP,NQTEMVT,PU,MONTANT " _
    //        & "FROM api_v_ListeAjustementStock " _
    //        & "WHERE VSOCIETE = App_Name() " _
    //        & "AND DLOGDATE BETWEEN '" & txtDateA(0) & "' AND '" & txtDateA(1) & " 23:59:59.999' " _
    //        & "order by DLOGDATE desc", cnx
    //  
    //  Screen.MousePointer = vbDefault
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Set rsTotal = New ADODB.Recordset
    //  rsTotal.Open "select CONVERT(INT,SUM(MONTANT)) as TOTAL " _
    //        & "FROM api_v_ListeAjustementStock " _
    //        & "WHERE VSOCIETE = App_Name() " _
    //        & "AND DLOGDATE BETWEEN '" & txtDateA(0) & "' AND '" & txtDateA(1) & " 23:59:59.999' ", cnx
    //  
    //  txtTotal = rsTotal("TOTAL")
    //  
    //  InitGrid True
    //
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdDate1_Click()
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.Value = Now
    //  End If
    // 
    //End Sub
    //
    //Private Sub cmdDate2_Click()
    //  
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //      Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.Value = Now
    //  End If
    //  
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
    //Private Sub Calendar1_Click()
    //  
    //  Me.txtDateA(iTextBoxDate) = Calendar1.Value
    //  Calendar1.Visible = False
    //
    //End Sub


  }
}

