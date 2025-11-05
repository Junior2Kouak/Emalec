using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmListeDIFromWeb : Form
  {
    DataTable dt = new DataTable();
    //Dim adoRS As ADODB.Recordset

    public frmListeDIFromWeb()
    {
      InitializeComponent();
    }

    private void frmListeDIFromWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_listedi_action_archive_web");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_listedi_action_archive_web", cnx
    //  InitApigrid
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load de " & Me.Name
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

    /* OK --------------------------------------------------------------------------*/
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      apiGrid.btnPrint_Click(null, null);
    }
    //Private Sub cmdImprimer_Click()
    //  If adoRS.EOF Then Exit Sub
    //  apiGrid.PrintGrid Me
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void frmListeDIFromWeb_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_DI, "NDINNUM", 650);
      apiGrid.AddColumn(Resources.col_date_c, "DDINDAT", 900, "dd/mm/yy");
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiGrid.AddColumn(Resources.col_Num, "NSITNUE", 500);
      apiGrid.AddColumn(Resources.col_Action, "VACTDES", 4000);
      apiGrid.AddColumn(Resources.col_Date, "DACTDATE", 800, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_Tech, "VACTINT", 500);
      apiGrid.AddColumn(Resources.col_etat, "CETACOD", 450);
      apiGrid.AddColumn(Resources.col_Observation, "VACTOBS", 1800);
      apiGrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiGrid.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);

      apiGrid.InitColumnList();
    }
    //Sub InitApigrid()
    //'  apiGrid.AddColumn "§DI§", 650
    //'  apiGrid.AddColumn "§Date C§", 900, "dd/mm/yy"
    //'  apiGrid.AddColumn "§Client§", 1500
    //'  apiGrid.AddColumn "§Site§", 1500
    //'  apiGrid.AddColumn "N°", 500
    //'  apiGrid.AddColumn "§Action§", 4000
    //'  apiGrid.AddColumn "§Date §", 800, "dd/mm/yy"
    //'  apiGrid.AddColumn "§Tech§", 500
    //'  apiGrid.AddColumn "§Etat§", 450
    //'  apiGrid.AddColumn "§Observation§", 1800
    //'  apiGrid.AddColumn "§NumAction§", 0
    //'  apiGrid.AddColumn "§type d'intervenant§", 0
    //
    //  apiGrid.AddColumn "§DI§", "NDINNUM", 650
    //  apiGrid.AddColumn "§Date C§", "DDINDAT", 900, "dd/mm/yy"
    //  apiGrid.AddColumn "§Client§", "VCLINOM", 1500
    //  apiGrid.AddColumn "§Site§", "VSITNOM", 1500
    //  apiGrid.AddColumn "N°", "NSITNUE", 500
    //  apiGrid.AddColumn "§Action§", "VACTDES", 4000
    //  apiGrid.AddColumn "§Date §", "DACTDATE", 800, "dd/mm/yy"
    //  apiGrid.AddColumn "§Tech§", "VACTINT", 500
    //  apiGrid.AddColumn "§Etat§", "CETACOD", 450
    //  apiGrid.AddColumn "§Observation§", "VACTOBS", 1800
    //  apiGrid.AddColumn "§NumAction§", "NACTNUM", 0
    //  apiGrid.AddColumn "§type d'intervenant§", "CACTTYT", 0
    //  apiGrid.Init adoRS
    //End Sub
  }
}