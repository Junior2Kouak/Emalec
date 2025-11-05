using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmContremaitre : Form
  {
    DataTable dtSec = new DataTable();
    DataTable dtRegMait = new DataTable();

    //Dim adoRS_Sec As ADODB.Recordset
    //Dim adoRS_RegMait As ADODB.Recordset
    //Dim sSQL As String

    public frmContremaitre() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmContremaitre_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        ModuleData.RemplirCombo(cboTech, "select NPERNUM, VPERNOM + ' ' + VPERPRE as NOMPRE from TPER where VSOCIETE = App_Name() AND CPERTYP='TE' AND CPERACTIF = 'O' ORDER BY  VPERNOM");
        cboTech.ValueMember = "NPERNUM";
        cboTech.DisplayMember = "NOMPRE";

        string sSql = "select A.VPERNOM + ' ' + A.VPERPRE as TECH, B.VPERNOM + ' ' + B.VPERPRE as MAITRE, S.VSERLIB,A.NPERNUM as itech, B.NPERNUM as imaitre " +
                      "from TPER A, TPER B,  TSER S WHERE A.VSOCIETE = App_Name() AND B.VSOCIETE = App_Name() AND A.NPERCONTREMAITRE = B.NPERNUM AND A.NSERNUM = S.NSERNUM " +
                      "AND A.CPERTYP = 'TE' and A.CPERACTIF = 'O' ORDER BY B.VPERNOM, A.VPERNOM";
        apiTGrid.LoadData(dtSec, MozartDatabase.cnxMozart, sSql);

        sSql = "SELECT VREGLIB + ' - ' + VDEPLIB + '(' + CAST(TREF_REG.NREGCOD AS VARCHAR(5)) +')' AS VLIBREGDEP, VPERNOM + ' ' + VPERPRE AS VNOMMAIT FROM TREF_REG " +
               "LEFT OUTER JOIN TPERCONTMAIT ON TPERCONTMAIT.NPAYSNUM = TREF_REG.NPAYSNUM AND TPERCONTMAIT.NREGCOD = TREF_REG.NREGCOD INNER JOIN TPER ON TPER.NPERNUM = TPERCONTMAIT.NPERNUM " +
               "WHERE TREF_REG.NPAYSNUM = 1 AND CPERACTIF='O'  ORDER BY VREGLIB,TREF_REG.NREGCOD";
        apitgridRegMait.LoadData(dtRegMait, MozartDatabase.cnxMozart, sSql);

        InitApiTgrid();
        InitApiTgridRegMait();
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
    //On Error GoTo handler
    //
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //
    //  cboTech.SizeCombo 600
    //  cboTech.Clear
    //  
    //  RemplirCombo cboTech, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = App_Name() AND CPERTYP='TE' AND CPERACTIF = 'O' ORDER BY  VPERNOM"
    //  
    //  sSQL = "select A.VPERNOM + ' ' + A.VPERPRE as TECH, B.VPERNOM + ' ' + B.VPERPRE as MAITRE, S.VSERLIB,A.NPERNUM as itech, B.NPERNUM as imaitre from TPER A, TPER B, "
    //  sSQL = sSQL & " TSER S WHERE A.VSOCIETE = App_Name() AND B.VSOCIETE = App_Name() AND A.NPERCONTREMAITRE = B.NPERNUM AND A.NSERNUM=S.NSERNUM AND A.CPERTYP='TE' and A.CPERACTIF='O' ORDER BY B.VPERNOM, A.VPERNOM"
    //  
    //  Set adoRS_Sec = New ADODB.Recordset
    //  Set adoRS_RegMait = New ADODB.Recordset
    //  
    //  adoRS_RegMait.Open "SELECT VREGLIB + ' - ' + VDEPLIB + '(' + CAST(TREF_REG.NREGCOD AS VARCHAR(5)) +')' AS VLIBREGDEP, VPERNOM + ' ' + VPERPRE AS VNOMMAIT FROM TREF_REG LEFT OUTER JOIN" _
    //                      & " TPERCONTMAIT ON TPERCONTMAIT.NPAYSNUM = TREF_REG.NPAYSNUM AND TPERCONTMAIT.NREGCOD = TREF_REG.NREGCOD INNER JOIN" _
    //                      & " TPER ON TPER.NPERNUM = TPERCONTMAIT.NPERNUM" _
    //                      & " WHERE TREF_REG.NPAYSNUM = 1 AND CPERACTIF='O' " _
    //                      & " ORDER BY VREGLIB,TREF_REG.NREGCOD", cnx
    //                        
    //  adoRS_Sec.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  
    //  InitApiTgrid
    //  InitApiTgridRegMait
    //
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      // On sort si il n'y a pas d'enregistrement maitre
      if (dtSec.Rows.Count == 0) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      ModuleData.ExecuteNonQuery($"UPDATE TPER SET NPERCONTREMAITRE = {cboMaitre.GetItemData()} WHERE NPERNUM = {row["iTech"]}");

      apiTGrid.Requery(dtSec, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdValider_Click()
    //  ' on sort si il n'y a pas d'enregistrement maitre
    //  If adoRS_Sec.EOF Then Exit Sub
    //  
    //  cnx.Execute "update tper set  npercontremaitre=" & cboMaitre.ItemData(cboMaitre.ListIndex) & " where npernum=" & adoRS_Sec!iTech
    //  
    //  adoRS_Sec.Requery
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_contremaitre, "MAITRE", 2300);
        apiTGrid.AddColumn(Resources.col_Tech, "TECH", 2500);
        apiTGrid.AddColumn(Resources.col_serv, "VSERLIB", 1500);

        apiTGrid.GridControl.DataSource = dtSec;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApiTgrid()
    //  
    //On Error GoTo handler
    //
    //  apiTGrid.AddColumn "§Contremaître§", "MAITRE", 2300
    //  apiTGrid.AddColumn "§Tech§", "TECH", 2500
    //  apiTGrid.AddColumn "§Serv§", "VSERLIB", 1500
    //  
    //  apiTGrid.Init adoRS_Sec
    //  apiTGrid.AllowDelete = False
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Initapitgrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApiTgridRegMait()
    {
      try
      {
        apitgridRegMait.AddColumn(Resources.col_Region, "VLIBREGDEP", 3400);
        apitgridRegMait.AddColumn(Resources.col_Tech, "VNOMMAIT", 1500);

        apitgridRegMait.GridControl.DataSource = dtRegMait;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApiTgridRegMait()
    //  
    //On Error GoTo handler
    //
    //  apitgridRegMait.AddColumn "§Région§", "VLIBREGDEP", 3400
    //  apitgridRegMait.AddColumn "§Tech§", "VNOMMAIT", 1500
    //  
    //  apitgridRegMait.Init adoRS_RegMait
    //  apitgridRegMait.AllowDelete = False
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Initapitgrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      // On sort si il n'y a pas d'enregistrement maitre
      if (dtSec.Rows.Count == 0) return;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //#If MULTI Then
      ModuleData.RemplirCombo(cboMaitre, $"select NPERNUM, VPERNOM + ' ' + VPERPRE as NOMPRE from TPER where VSOCIETE = App_Name() AND npernum in (select distinct npercontremaitre from" +
                                         $" tper union select {row["iTech"]} ) ORDER BY  VPERNOM + ' ' + VPERPRE  ");
      cboMaitre.ValueMember = "NPERNUM";
      cboMaitre.DisplayMember = "NOMPRE";
      //#Else
      //  RemplirCombo cboMaitre, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where npernum in (select distinct npercontremaitre from tper union select " & adoRS_Sec!iTech & " ) ORDER BY  VPERNOM + ' ' + VPERPRE  "
      //#End If

      cboTech.SetItemData(row["iTech"].ToString());
      cboMaitre.SetItemData(row["imaitre"].ToString());
      Cursor.Current = Cursors.Default;
    }
    //Private Sub apiTGrid_RowColChange()
    //
    //  ' on sort si il n'y a pas d'enregistrement maitre
    //  If adoRS_Sec.EOF Then Exit Sub
    //  
    //#If MULTI Then
    //  RemplirCombo cboMaitre, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = App_Name() AND npernum in (select distinct npercontremaitre from tper union select " & adoRS_Sec!iTech & " ) ORDER BY  VPERNOM + ' ' + VPERPRE  "
    //#Else
    //  RemplirCombo cboMaitre, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where npernum in (select distinct npercontremaitre from tper union select " & adoRS_Sec!iTech & " ) ORDER BY  VPERNOM + ' ' + VPERPRE  "
    //#End If
    //  
    //  SelectLB cboTech, adoRS_Sec!iTech
    //  SelectLB cboMaitre, adoRS_Sec!imaitre
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}