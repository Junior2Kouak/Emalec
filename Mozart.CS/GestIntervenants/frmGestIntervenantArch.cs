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
  public partial class frmGestIntervenantArch : Form
  {
    DataTable dt = new DataTable();

    public int miNumFourn;  // Vient de frmGestIntervenants
    public string msNomFourn;
    //Public ado_rs As ADODB.Recordset

    public frmGestIntervenantArch()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  Set ado_rs = New ADODB.Recordset
    //  ado_rs.Open "SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = " & frmGestIntervenants.miNumFourn & " AND CINTACTIF = 'Archivé' ORDER BY VINTNOM ", cnx
    //  InitGrid
    //End Sub
    private void frmGestIntervenantArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        lblTitre.Text += msNomFourn;
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = {miNumFourn} AND CINTACTIF = 'Archivé' ORDER BY VINTNOM ");
        apiTGrid1.GridControl.DataSource = dt;
        InitApiGrid();
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

    //Private Sub InitGrid()
    //  apiTGrid1.AddColumn "§Nom§", "VINTNOM", 1500
    //  apiTGrid1.AddColumn "§Prénom§", "VINTPRE", 1200
    //  apiTGrid1.AddColumn "§Civilité§", "VINTCIV", 900
    //  apiTGrid1.AddColumn "§Fonction§", "VINTFONC", 2200
    //  apiTGrid1.AddColumn "§Téléphone§", "VINTTEL", 1400
    //  apiTGrid1.AddColumn "§Fax§", "VINTFAX", 1400
    //  apiTGrid1.AddColumn "§GSM§", "VINTPOR", 1400
    //  apiTGrid1.AddColumn "§E-Mail§", "VINTMAIL", 2000

    //  apiTGrid1.Init ado_rs
    //End Sub
    private void InitApiGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VINTNOM", 100);
      apiTGrid1.AddColumn(Resources.col_Prenom, "VINTPRE", 80);
      apiTGrid1.AddColumn(Resources.col_Civ, "VINTCIV", 60);
      apiTGrid1.AddColumn(Resources.col_Fonction, "VINTFONC", 150);
      apiTGrid1.AddColumn(Resources.col_Tel, "VINTTEL", 95);
      apiTGrid1.AddColumn(Resources.col_Fax, "VINTFAX", 95);
      apiTGrid1.AddColumn(Resources.col_GSM, "VINTPOR", 95);
      apiTGrid1.AddColumn(Resources.col_Email, "VINTMAIL", 140);

      apiTGrid1.InitColumnList();
    }

    //Private Sub cmdRestaurer_Click()
    //  If Not ado_rs.EOF Then
    //    cnx.Execute "UPDATE TINT SET CINTACTIF = 'O' WHERE NINTNUM = " & ado_rs("NINTNUM")
    //    ado_rs.Requery
    //    If ado_rs.RecordCount = 0 Then
    //      Unload Me
    //    End If
    //  End If
    //End Sub
    private void cmdRestaurer_Click(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleData.ExecuteNonQuery($"UPDATE TINT SET CINTACTIF = 'O' WHERE NINTNUM = {apiTGrid1.GetFocusedDataRow()["NINTNUM"]}");
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        if (dt.Rows.Count > 0)
          apiTGrid1.GridControl.DataSource = dt;
        else
          Dispose();
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

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  ado_rs.Close
    //End Sub
  }
}