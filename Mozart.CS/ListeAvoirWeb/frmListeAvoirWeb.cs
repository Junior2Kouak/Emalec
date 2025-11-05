using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmListeAvoirWeb : Form
  {
    public frmListeAvoirWeb() { InitializeComponent(); }
    DataTable dtHaut = new DataTable();
    DataTable dtBas = new DataTable();

    private void frmListeAvoirWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridH.LoadData(dtHaut, MozartDatabase.cnxMozart, "exec api_sp_ListeDemAvoir 'O'");
        apiTGridH.GridControl.DataSource = dtHaut;

        InitApigridH();

        apiTGridB.LoadData(dtBas, MozartDatabase.cnxMozart, "exec api_sp_ListeDemAvoir 'C'");
        apiTGridB.GridControl.DataSource = dtBas;

        InitApigridB();

        Cursor.Current = Cursors.Default;
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
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_ListeDemAvoir 'O'", cnx
    //
    //  InitApigrid
    //  
    //  ' pour les demande cloturer
    //  Set adoRS2 = New ADODB.Recordset
    //  adoRS2.Open "exec api_sp_ListeDemAvoir 'C'", cnx
    //
    //  InitApigrid2
    //
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridH.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;
      //  ' écran de modification de la demande
      new frmDetailAvoirWeb { miNumElfAvoir = Convert.ToInt64(currentRow["NELFNUM"]) }.ShowDialog();

      apiTGridH.Requery(dtHaut, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdEnregistrer_Click()
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmDetailAvoirWeb.miNumElfAvoir = adoRS("NELFNUM")
    //  frmDetailAvoirWeb.Show vbModal
    //      
    //  adoRS.Requery
    // 
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDet_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridB.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;
      //  ' écran de modification de la demande
      new frmDetailAvoirWeb { miNumElfAvoir = Convert.ToInt64(currentRow["NELFNUM"]) }.ShowDialog();

      apiTGridB.Requery(dtBas, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdDet_Click()
    //  
    //  If adoRS2.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmDetailAvoirWeb.miNumElfAvoir = adoRS2("NELFNUM")
    //  frmDetailAvoirWeb.Show vbModal
    //      
    //  adoRS2.Requery
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigridH()
    {
      apiTGridH.AddColumn(Resources.col_Facture, "NFACNUM", 700);
      apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apiTGridH.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGridH.AddColumn(Resources.col_Num, "NSITNUE", 700, "", 2);
      apiTGridH.AddColumn(Resources.col_Date, "DAVDATE", 800, "Date", 0, true);          //AddCellTip
      apiTGridH.AddColumn(Resources.col_Action, "VACTDES", 4000, "", 0, true);        //AddCellTip
      apiTGridH.AddColumn(Resources.col_Montant, "NELFTHT", 1100, "", 2);
      apiTGridH.AddColumn(Resources.col_etat, "VAVSTATUT", 1600, "", 0, true);        //AddCellTip
      apiTGridH.AddColumn("NELFNUM", "NELFNUM", 0);

      apiTGridH.InitColumnList();
    }
    //Private Sub InitApigrid()
    // 
    //On Error GoTo handler
    //  
    //  apiTGrid1.AddColumn "§Facture§", "NFACNUM", 900
    //  apiTGrid1.AddColumn "§Client§", "VCLINOM", 1400
    //  apiTGrid1.AddColumn "§Site§", "VSITNOM", 1500
    //  apiTGrid1.AddColumn "N°", "NSITNUE", 700, , 2
    //  apiTGrid1.AddColumn "§Date§", "DAVDATE", 1400
    //  apiTGrid1.AddColumn "§Action§", "VACTDES", 8000
    //  apiTGrid1.AddColumn "§Montant§", "NELFTHT", 1100, , 2
    //  apiTGrid1.AddColumn "§Etat§", "VAVSTATUT", 1200
    //  apiTGrid1.AddColumn "NELFNUM", "NELFNUM", 0
    //  
    //  ' Tooltip sur des cellules
    //  apiTGrid1.AddCellTip "DAVDATE", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid1.AddCellTip "VACTDES", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid1.AddCellTip "VAVSTATUT", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //    
    //  apiTGrid1.Init adoRS
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigridB()
    {
      apiTGridB.AddColumn(Resources.col_Facture, "NFACNUM", 700);
      apiTGridB.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apiTGridB.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGridB.AddColumn(Resources.col_Num, "NSITNUE", 700, "", 2);
      apiTGridB.AddColumn(Resources.col_Date, "DAVDATE", 800, "Date", 0, true);        //AddCellTip
      apiTGridB.AddColumn(Resources.col_Action, "VACTDES", 4000, "", 0, true);      //AddCellTip
      apiTGridB.AddColumn(Resources.col_Montant, "NELFTHT", 1100, "", 2);
      apiTGridB.AddColumn(Resources.col_etat, "VAVSTATUT", 1600);
      apiTGridB.AddColumn("NELFNUM", "NELFNUM", 0);

      apiTGridB.InitColumnList();
    }
    //Private Sub InitApigrid2()
    // 
    //On Error GoTo handler
    //  
    //  apiTGrid2.AddColumn "§Facture§", "NFACNUM", 900
    //  apiTGrid2.AddColumn "§Client§", "VCLINOM", 1400
    //  apiTGrid2.AddColumn "§Site§", "VSITNOM", 1500
    //  apiTGrid2.AddColumn "N°", "NSITNUE", 700, , 2
    //  apiTGrid2.AddColumn "§Date§", "DAVDATE", 1400
    //  apiTGrid2.AddColumn "§Action§", "VACTDES", 8000
    //  apiTGrid2.AddColumn "§Montant§", "NELFTHT", 1100, , 2
    //  apiTGrid2.AddColumn "§Etat§", "VAVSTATUT", 1250
    //  apiTGrid2.AddColumn "NELFNUM", "NELFNUM", 0
    //  
    //  ' Tooltip sur des cellules
    //  apiTGrid2.AddCellTip "DAVDATE", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid2.AddCellTip "VACTDES", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //    
    //  apiTGrid2.Init adoRS2
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid2 dans " & Me.Name
    //End Sub

    /* Inutile ---------------------------------------------------------------------------------- */
    //Private Sub Form_Resize()
    //  apiTGrid1.Width = Me.Width - apiTGrid1.Left - 1800
    //  Frame2.Width = Me.Width - Frame2.Left - 200
    //
    //  apiTGrid2.Width = Me.Width - apiTGrid2.Left - 1800
    //  Frame1.Width = Me.Width - Frame1.Left - 200
    //End Sub
  }
}