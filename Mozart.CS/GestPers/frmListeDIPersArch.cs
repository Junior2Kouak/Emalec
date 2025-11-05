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
  public partial class frmListeDIPersArch : Form
  {
    public int miNumPer;
    public bool mbRefresh = true;

    DataTable dt = new DataTable();

    //  Option Explicit
    //Public miNumPer As Integer
    //Dim adoRS As ADODB.Recordset
    //

    public frmListeDIPersArch() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmListeDIPersArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_listeDiActionPersArch WHERE NPERNUM = {miNumPer} ORDER BY NDINNUM DESC");
        ApiGrid.GridControl.DataSource = dt;
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
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "SELECT * FROM api_v_listeDiActionPersArch WHERE NPERNUM = " & miNumPer & " ORDER BY NDINNUM DESC", cnx
    //
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
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
      DataRow currentRow = ApiGrid.GetFocusedDataRow();

      if (currentRow == null || dt.Rows.Count == 0) return;

      Cursor = Cursors.WaitCursor;

      MozartParams.NumDi = Convert.ToInt32(Utils.ZeroIfNull(currentRow["NDINNUM"]));

      //écran de modification de la demande
      frmAddAction f = new frmAddAction();
      f.mstrStatutDI = "M";
      f.ShowDialog();

      Cursor = Cursors.WaitCursor;

      //on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      //raffraichissement
      if (mbRefresh)
        ApiGrid.Requery(dt, MozartDatabase.cnxMozart);

      mbRefresh = false;
      Cursor = Cursors.Default;

    }
    //Private Sub cmdModifier_Click()
    //Dim aux
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = Val(adoRS("NDINNUM").Value)
    //  glNumAction = Val(adoRS("NACTNUM").Value)
    //  frmAddAction.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //    
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //  
    //  ' rafraichissement du recordset
    //  If gbRefresh Then
    //    On Error Resume Next
    //    aux = adoRS.AbsolutePosition
    //    adoRS.Requery
    //    adoRS.AbsolutePosition = aux
    //    InitApigrid
    //  End If
    //  
    //  gbRefresh = False
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {

      try
      {
        ApiGrid.AddColumn(Resources.col_DI, "NDINNUM", 600);
        ApiGrid.AddColumn(Resources.col_date_c, "DDINDATHEUR", 780, "dd/mm/yy");
        ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 970);
        ApiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1350);
        ApiGrid.AddColumn("N°", "NSITNUE", 480);
        ApiGrid.AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 600);
        ApiGrid.AddColumn(Resources.col_Chaff, "VPERNOM", 400);
        ApiGrid.AddColumn(Resources.col_Action, "VACTDES", 4630);
        ApiGrid.AddColumn(Resources.col_Date, "DACTDATE", 770, "dd/mm/yy");
        ApiGrid.AddColumn(Resources.col_Technicien, "VACTINT", 400);
        ApiGrid.AddColumn(Resources.col_Technique, "CTECCOD", 230);
        ApiGrid.AddColumn(Resources.col_Prestation, "CPRECOD", 230);
        ApiGrid.AddColumn(Resources.col_etat, "CETACOD", 230);
        ApiGrid.AddColumn(Resources.col_Administration, "CACTSTA", 230);
        ApiGrid.AddColumn(Resources.col_OBS, "VACTOBS", 1000);
        ApiGrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
        ApiGrid.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);
        ApiGrid.AddColumn(Resources.col_Site, "NSITNUM", 0);
        ApiGrid.AddColumn(Resources.col_Personne, "NPERNUM", 0);

        ApiGrid.InitColumnList();
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
    //  ApiGrid.AddColumn "§DI§", 600
    //  ApiGrid.AddColumn "§Date C§", 780, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Client§", 970
    //  ApiGrid.AddColumn "§Site§", 1350
    //  ApiGrid.AddColumn "N°", 480
    //  ApiGrid.AddColumn "§Enseigne§", 600
    //  ApiGrid.AddColumn "§Chaff§", 400
    //  ApiGrid.AddColumn "§Action§", 4630
    //  ApiGrid.AddColumn "§Date §", 770, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Technicien§", 400
    //  ApiGrid.AddColumn "§T echnique§", 230
    //  ApiGrid.AddColumn "§P restation§", 230
    //  ApiGrid.AddColumn "§E tat§", 230
    //  ApiGrid.AddColumn "§A dministration§", 230
    //  ApiGrid.AddColumn "§Obs§", 1000
    //  ApiGrid.AddColumn "§NumAction§", 0
    //  ApiGrid.AddColumn "§type d'intervenant§", 0
    //  ApiGrid.AddColumn "§site§", 0
    //  ApiGrid.AddColumn "§pers§", 0
    //  
    //  ApiGrid.Init adoRS
    //  Exit Sub
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
    private void ApiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    //Private Sub apigrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub


  }
}

