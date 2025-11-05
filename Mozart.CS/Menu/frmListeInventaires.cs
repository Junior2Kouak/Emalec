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
  public partial class frmListeInventaires : Form
  {
    public int miNumClient;

    DataTable dtRS = new DataTable();

    //Dim adoRS As ADODB.Recordset
    //Public miNumClient As Long

    public frmListeInventaires() { InitializeComponent(); }

    /* OK--------------------------------------------------------------*/
    private void frmListeInventaires_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apigrid.LoadData(dtRS, MozartDatabase.cnxMozart, $"select * from api_v_ListeInventaires where NCLINUM = {miNumClient} order by VSITNOM asc, DDATECRE desc");
        apigrid.GridControl.DataSource = dtRS;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from api_v_ListeInventaires where NCLINUM = " & miNumClient & " order by VSITNOM asc, DDATECRE desc", cnx
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //    
    //End Sub
    //


    /* OK --------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigrid.GetFocusedDataRow();
      if (currentRow == null) return;

      // écran de modification de l'action
      MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);
      MozartParams.NumDi = (int)Utils.ZeroIfNull(currentRow["NDINNUM"]);
      new frmDetailstravaux
      {
        mstrStatutAction = "M"
      }.ShowDialog();

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //    
    //  If adoRS.EOF Then Exit Sub
    //  
    //  ' écran de modification de l' action
    //  frmDetailsTravaux.mstrStatutAction = "M"
    //  glNumAction = adoRS("NACTNUM").Value
    //  giNumDi = adoRS("NDINNUM").Value
    //  
    //  frmDetailsTravaux.Show vbModal
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdQTE_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigrid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmStockInventaireDetail
      {
        miNumInv = (int)Utils.ZeroIfNull(currentRow["NINVNUM"])
      }.ShowDialog();
    }
    //Private Sub cmdQTE_Click()
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  FrmStockInventaireDetail.miNumInv = adoRS("NINVNUM")
    //  FrmStockInventaireDetail.Show vbModal
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      try
      {
        apigrid.AddColumn(Resources.col_dateInv, "DDATECRE", 1600, "dd/MM/yy");
        apigrid.AddColumn(Resources.col_Site, "VSITNOM", 3500);
        apigrid.AddColumn(Resources.col_commandeHT, "Expr1", 1400, "0.###");
        apigrid.AddColumn(Resources.col_factHT, "NELFTHT", 1400, "0.###");
        apigrid.AddColumn(Resources.col_inv, "NINVNUM", 0);
        apigrid.AddColumn(Resources.col_cli, "NCLINUM", 0);
        apigrid.AddColumn("actnum", "NACTNUM", 0);
        apigrid.AddColumn(Resources.col_dinnum, "NDINNUM", 0);

        apigrid.InitColumnList();
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
    //  ApiGrid.AddColumn "§Date inv§", 1600, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Site§", 3500
    //  ApiGrid.AddColumn "§Commande HT§", 1400
    //  ApiGrid.AddColumn "§Facturation HT§", 1400
    //  ApiGrid.AddColumn "§Inv§", 0
    //  ApiGrid.AddColumn "§Cli§", 0
    //  ApiGrid.AddColumn "actnum", 0
    //  ApiGrid.AddColumn "§dinnum§", 0
    //  
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apigrid_DoubleClick(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    //Private Sub apigrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub
    //

  }
}

