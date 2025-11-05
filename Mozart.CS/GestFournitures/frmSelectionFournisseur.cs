using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSelectionFournisseur : Form
  {
    //Dim adoRS As ADODB.Recordset
    //Public miFournitures As Long
    //Public mstrArticle As String
    //Public miNumClient As Long
    DataTable dt = new DataTable();
    public long mlFournitures;
    public long mlNumClient;
    public string mstrArticle;
    public frmSelectionFournisseur()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //Dim sSQL As String
    //On Error GoTo handler
    //  InitBoutons Me, frmMenu
    //  Label1 = "§Fourniture : §" & mstrArticle
    //  ' ouverture du recordset avec la liste des ST
    //  Set adoRS = New ADODB.Recordset
    //  sSQL = "select VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFCP, VSTFVIL, "
    //  sSQL = sSQL + "FPUHT,  NSTFNUM  from TSTF "
    //  sSQL = sSQL + "INNER JOIN TSTFFOU ON TSTF.NSTFGRPNUM = TSTFFOU.NSTFGRPNUM "
    //  sSQL = sSQL + "where CSTFACTIF='O' AND TSTFFOU.NFOUNUM=" & miFournitures & " ORDER BY VSTFNOM"
    //  adoRS.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  InitApigrid
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    private void frmSelectionFournisseur_Load(object sender, System.EventArgs e)
    {
      string sSQL;
      try
      {
        ModuleMain.Initboutons(this);
        Label1.Text = Resources.lbl_Fourniture + mstrArticle;
        sSQL = $"select VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFCP, VSTFVIL,FPUHT,  NSTFNUM  " +
          $"from TSTF INNER JOIN TSTFFOU ON TSTF.NSTFGRPNUM = TSTFFOU.NSTFGRPNUM where CSTFACTIF='O' " +
          $"AND TSTFFOU.NFOUNUM= {mlFournitures} ORDER BY VSTFNOM";

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Public Sub InitApigrid()
    //On Error GoTo handler
    //  ApiGrid.AddColumn "§Nom§", 2500
    //  ApiGrid.AddColumn "§Type §", 0
    //  ApiGrid.AddColumn "§Ville cible§", 1800
    //  ApiGrid.AddColumn "§Adresse 1§", 2000
    //  ApiGrid.AddColumn "§CP §", 700
    //  ApiGrid.AddColumn "§Ville§", 1700
    //  ApiGrid.AddColumn "§Prix €§", 1000, "0.00", 2
    //  ApiGrid.AddColumn "NumSTF", 0
    //  ApiGrid.Init adoRS
    //  ApiGrid.DesactiveListe
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    private void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_Nom, "VSTFNOM", 2500);
        apiTGrid.AddColumn(Resources.col_Type, "CSTFTYP", 0);
        apiTGrid.AddColumn(Resources.col_VilleCible, "VSTFVIC", 1800);
        apiTGrid.AddColumn(Resources.col_Adresse1, "VSTFAD1", 2000);
        apiTGrid.AddColumn(Resources.col_CP, "VSTFCP", 700);
        apiTGrid.AddColumn(Resources.col_Ville, "VSTFVIL", 1700);
        apiTGrid.AddColumn(Resources.col_PrixEuro, "FPUHT", 1000, "0.00", 2);
        apiTGrid.AddColumn("NumSTF", "NSTFNUM", 0);

        apiTGrid.InitColumnList();
        apiTGrid.DesactiveListe();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdSelectionner_Click()
    //On Error GoTo handler
    //  If adoRS.EOF Then Exit Sub
    //  Select Case MsgBox("§Voulez-vous vraiment modifier le fournisseur sur cette fourniture ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      cnx.Execute "update TSTOCKARTCLI SET NSTFNUM = " & adoRS("NSTFNUM").Value & " where NCLINUM = " & miNumClient & " AND NFOUNUM = " & miFournitures
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  Unload Me
    //Exit Sub
    //handler:
    //  ShowError "cmdSelectionner_Click dans " & Me.Name
    //End Sub

    //Private Sub apigrid_DblClick()
    //  Call cmdSelectionner_Click
    //End Sub

    private void cmdSelectionner_and_apigrid_DoubleClick(object sender, EventArgs e)
    {
      string sSQL;
      try
      {
        if (MessageBox.Show(Resources.msg_ConfirmModifFour, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          sSQL = $"update TSTOCKARTCLI SET NSTFNUM = {apiTGrid.GetFocusedDataRow()["NSTFNUM"] } where NCLINUM = { mlNumClient } AND NFOUNUM = { mlFournitures}";
          using (var cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
          {
            cmd.ExecuteNonQuery();
          }
          Dispose();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}

