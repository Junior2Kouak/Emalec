using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockVehTech : Form
  {
    //Public iTech As Long
    //Public vTech As String

    //Dim adoRSB As ADODB.Recordset
    public long miTech;
    public string mvTech = "";

    DataTable dt = new DataTable();

    public frmStockVehTech()
    {
      InitializeComponent();
    }


    private void frmStockVehTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Label1.Text = "Liste des articles de réappro stock véhicule du technicien " + mvTech;
        this.Text = Label1.Text;

        apiGridb.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_SyntStockVehTech {miTech}");
        apiGridb.GridControl.DataSource = dt;
        InitapiGridB();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //On Error GoTo handler:
    //  InitBoutons Me, frmMenu
    //  Label1.Caption = "Liste des articles de réappro stock véhicule du technicien " & vTech
    //  Me.Caption = Label1.Caption
    //  Set adoRSB = New ADODB.Recordset
    //  adoRSB.Open "exec api_sp_SyntStockVehTech " & iTech, cnx, adOpenDynamic, adLockOptimistic
    //  InitapiGridB
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    private void InitapiGridB()
    {
      try
      {
        apiGridb.AddColumn("Matériel", "VFOUMAT", 7000);
        apiGridb.AddColumn("Marque", "VFOUMAR", 2500);
        apiGridb.AddColumn("Type", "VFOUTYP", 2500);
        apiGridb.AddColumn("Référence", "VFOUREF", 2500);
        apiGridb.AddColumn("QTE", "QTE", 600, "", 2);

        //apiGridb.AddCellStyle("QTE", "0", &HCCCCCC, vbWhite);     --> apiGridb_RowCellStyle
        apiGridb.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitapiGridB()
    //On Error GoTo handler
    //  apiGridb.AddColumn "Matériel", "VFOUMAT", 7000
    //  apiGridb.AddColumn "Marque", "VFOUMAR", 2500
    //  apiGridb.AddColumn "Type", "VFOUTYP", 2500
    //  apiGridb.AddColumn "Référence", "VFOUREF", 2500
    //  apiGridb.AddColumn "QTE", "QTE", 600, , 2
    //  apiGridb.AddCellStyle "QTE", "0", &HCCCCCC, vbWhite
    //  apiGridb.Init adoRSB
    //Exit Sub
    //handler:
    //  ShowError "InitApigridb dans " & Me.Name
    //End Sub

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub

    private void apiGridb_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "QTE")
      {
        e.Appearance.ForeColor = System.Drawing.Color.Black;
        e.Appearance.BackColor = System.Drawing.Color.White;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}

