using Microsoft.VisualBasic;
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
  public partial class frmDetailIP : Form
  {
    //  Option Explicit

    public int miNumIP;
    public string sNumAct;
    //Public miNumIP As Long
    //Public sNumAct As String

    int iNumDI;
    int iNumAction;
    //Dim liNumDI As Long
    //Dim llNumAction As Long

    DataTable dt = new DataTable();
    //Dim rsAct As ADODB.Recordset

    public frmDetailIP() { InitializeComponent(); }

    private void frmDetailIP_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialiserDonnées();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  Call InitialiserDonnées
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitialiserDonnées()
    {
      try
      {
        string sSQL;

        //recherche des actions de cette IP
        //ouverture du recordset des actions
        if (miNumIP != 0)
        {
          grdDataGridAction.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_listeActionIP {miNumIP}");
        }
        else if (sNumAct != "")
        {
          sSQL = "SELECT 'Di'+ dbo.FormatCle (TACT.NDINNUM, 6) as NDINNUM,TACT.DACTDAT, TACT.VACTDES," +
                 $"convert(varchar(10), TACT.DACTDEX, 3) as DACTDEX,TACT.CETACOD,TACT.NACTDUR,TACT.CURGCOD,TACT.CPRECOD,TACT.CTECCOD,TACT.VACTOBS,TACT.NACTNUM, TACTCOMP.VACTOBSM" +
                 $" From TACT WITH (NOLOCK) INNER JOIN TACTCOMP WITH (NOLOCK) ON TACTCOMP.NACTNUM = TACT.NACTNUM WHERE TACT.NACTNUM in ({sNumAct})";

          grdDataGridAction.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        }

        //liaison du recordset et du datagrid
        grdDataGridAction.GridControl.DataSource = dt;

        //mise en page du datagrid
        FormatGridAction();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGridAction.GetFocusedDataRow();
      if (row == null) return;

      //recherche des droits sur cette DI
      int nb = (int)ModuleData.ExecuteScalarInt("SELECT count(*) FROM TDIN INNER JOIN TAUT ON  TDIN.NDINCTE = TAUT.NCANNUM " +
                                                $" INNER JOIN TPER ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = {MozartParams.UID}" +
                                                $" AND   TDIN.NDINNUM = {Strings.Mid(Utils.BlankIfNull(row["NDINNUM"]), 3)}");
      if (nb == 0)
      {
        MessageBox.Show(Resources.msg_pasDroitsAccesDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //on garde les variables globales en mémoire
      iNumDI = MozartParams.NumDi;
      iNumAction = MozartParams.NumAction;

      //écran de modification de la demande
      MozartParams.NumDi = (int)Utils.ZeroIfNull(Strings.Mid(Utils.BlankIfNull(row["NDINNUM"]), 3));
      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);

      new frmAddAction { mstrStatutDI = "M" }.ShowDialog();

      //on revient donc on réinitialise les variables globales avec anciennes valeurs
      MozartParams.NumDi = iNumDI;
      MozartParams.NumAction = iNumAction;

      //rafraichissement du recordset
      grdDataGridAction.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdModifier_Click()
    //
    //Dim rsDroit As New ADODB.Recordset
    //
    //        
    //  If rsAct.EOF Then Exit Sub
    //  
    //  ' recherche des droits sur cette DI
    //  rsDroit.Open "SELECT count(*) FROM TDIN INNER JOIN TAUT ON  TDIN.NDINCTE = TAUT.NCANNUM " & _
    //           " INNER JOIN TPER ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = " & gintUID & _
    //           " AND   TDIN.NDINNUM = " & Mid(rsAct("NDINNUM").Value, 3), cnx
    //           
    //  If rsDroit(0) = 0 Then
    //      MsgBox "§Vous n'avez pas les droits d'accès sur cette DI§"
    //      rsDroit.Close
    //      Exit Sub
    //  Else
    //  
    //    ' on garde les variables globales en mémoire
    //    liNumDI = giNumDi
    //    llNumAction = glNumAction
    //  
    //    ' écran de modification de la demande
    //    frmAddAction.mstrStatutDI = "M"
    //    giNumDi = Mid(rsAct("NDINNUM").Value, 3)
    //    glNumAction = rsAct("NACTNUM").Value
    //      
    //    On Error Resume Next
    //    
    //    frmAddAction.Show vbModal
    //    
    //      
    //    If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran et déjà chargé en arrière plan§"
    //    
    //    ' on revient donc on réinitialise les variables globales avec anciennes valeurs
    //    giNumDi = liNumDI
    //    glNumAction = llNumAction
    //  
    //  End If
    //  rsDroit.Close
    //
    //  ' rafraichissement du recordset
    //  rsAct.Requery
    //  
    //  ' mise en page du datagrid
    //  FormatGridAction
    // 
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void FormatGridAction()
    {
      grdDataGridAction.AddColumn("NumDI", "NDINNUM", 700);
      grdDataGridAction.AddColumn(Resources.col_Date_souhaitee, "DACTDAT", 800);
      grdDataGridAction.AddColumn(Resources.col_Action, "VACTDES", 3000);
      grdDataGridAction.AddColumn(Resources.col_dateEx, "DACTDEX", 700);
      grdDataGridAction.AddColumn(Resources.col_etat, "CETACOD", 600);
      grdDataGridAction.AddColumn(Resources.col_duree, "NACTDUR", 600, "0.##");
      grdDataGridAction.AddColumn(Resources.col_Urg, "CURGCOD", 550);
      grdDataGridAction.AddColumn(Resources.col_Pres, "CPRECOD", 600);
      grdDataGridAction.AddColumn(Resources.col_Tech, "CTECCOD", 600);
      grdDataGridAction.AddColumn("Obs M", "VACTOBSM", 900);
      grdDataGridAction.AddColumn("Obs", "VACTOBS", 900);
      grdDataGridAction.AddColumn(Resources.col_NumAction, "NACTNUM", 0);

      grdDataGridAction.dgv.OptionsView.ColumnAutoWidth = false;

      grdDataGridAction.InitColumnList();
    }
    //Private Sub FormatGridAction()
    //  
    //  grdDataGridAction.Columns(0).Caption = "NumDI"
    //  grdDataGridAction.Columns(1).Caption = "Date souhaitée"
    //  grdDataGridAction.Columns(2).Caption = "§Action§"
    //  grdDataGridAction.Columns(3).Caption = "§Date Ex§"
    //  grdDataGridAction.Columns(4).Caption = "§Etat§"
    //  grdDataGridAction.Columns(5).Caption = "§Durée§"
    //  grdDataGridAction.Columns(6).Caption = "Urg"
    //  grdDataGridAction.Columns(7).Caption = "§Pres§"
    //  grdDataGridAction.Columns(8).Caption = "§Tech§"
    //  grdDataGridAction.Columns(9).Caption = "Obs"
    //  grdDataGridAction.Columns(10).Caption = "§NumAction§"
    //  
    //  grdDataGridAction.Columns(0).width = 750
    //  grdDataGridAction.Columns(1).width = 900
    //  grdDataGridAction.Columns(2).width = 4200
    //  grdDataGridAction.Columns(3).width = 900
    //  grdDataGridAction.Columns(4).width = 600
    //  grdDataGridAction.Columns(5).width = 650
    //  grdDataGridAction.Columns(6).width = 500
    //  grdDataGridAction.Columns(7).width = 550
    //  grdDataGridAction.Columns(8).width = 550
    //  grdDataGridAction.Columns(9).width = 1000
    //  grdDataGridAction.Columns(10).width = 0
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub grdDataGridAction_HeadClick(ByVal ColIndex As Integer)
    //
    //Static strSortOrder As String
    //  strSortOrder = TrierDataGrid(grdDataGridAction, rsAct, ColIndex, strSortOrder)
    //End Sub
    //

  }
}

