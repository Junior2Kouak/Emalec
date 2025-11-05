using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSelectServTech : Form
  {
    public int miServTech_Tag = 0;
    public string msServTech = "";

    //Dim rs As ADODB.Recordset
    DataTable dt = new DataTable();

    public frmSelectServTech()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  Set rs = New ADODB.Recordset
    //  rs.Open "SELECT * FROM TSERVTECH order by VSERVTECHNOM", cnx
    //  InitApiTgrid
    //End Sub

    private void frmSelectServTech_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "SELECT * FROM TSERVTECH ORDER BY VSERVTECHNOM");
      apiTGrid.GridControl.DataSource = dt;
      InitApiGrid();
    }

    //Private Sub InitApiTgrid()
    //  apiTGrid1.AddColumn "§Nom§", "VSERVTECHNOM", 2200
    //  apiTGrid1.AddColumn "§Adresse§", "VSERVTECHAD1", 2500
    //  apiTGrid1.AddColumn "§Code Postal§", "VSERVTECHCP", 1500
    //  apiTGrid1.AddColumn "§Ville§", "VSERVTECHVIL", 1700
    //  apiTGrid1.AddColumn "Numservtech", "NSERVTECHNUM", 0
    //  apiTGrid1.Init rs
    //End Sub

    private void InitApiGrid()
    {
      apiTGrid.AddColumn(Resources.col_Nom, "VSERVTECHNOM", 2200);
      apiTGrid.AddColumn(Resources.col_Adresse, "VSERVTECHAD1", 2500);
      apiTGrid.AddColumn(Resources.col_CP, "VSERVTECHCP", 1000);
      apiTGrid.AddColumn(Resources.col_Ville, "VSERVTECHVIL", 1700);
      apiTGrid.AddColumn("Numservtech", "NSERVTECHNUM", 0);

      apiTGrid.InitColumnList();
    }

    //Private Sub cmdEnregistrer_Click()
    //  If rs.RecordCount > 0 Then
    //    frmDetailsSite.txtServTech.Tag = rs("NSERVTECHNUM")
    //    frmDetailsSite.txtServTech = rs("VSERVTECHNOM")
    //  End If
    //  rs.Close
    //  Unload Me
    //End Sub

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      miServTech_Tag = Convert.ToInt32(row["NSERVTECHNUM"]);
      msServTech = row["VSERVTECHNOM"].ToString();

      Close();
    }

    //Private Sub cmdFermer_Click()
    //  rs.Close
    //  Unload Me
    //End Sub

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
