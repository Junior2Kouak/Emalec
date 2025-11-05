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
  public partial class frmModifListeArtClientWeb : Form
  {
    private DataTable dtH = new DataTable();
    private DataTable dtB = new DataTable();
    public int miNumClient;
    //Dim adoRSB As ADODB.Recordset
    //Dim adoRSH As ADODB.Recordset
    //Public miNumClient As Long

    public frmModifListeArtClientWeb()
    {
      InitializeComponent();
    }

    /*--------------------------------------------------------------*/
    private void frmModifListeArtClientWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiGridb.LoadData(dtB, MozartDatabase.cnxMozart, $"SELECT distinct VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM, min(FPUHT)*1.5 as FPUHT FROM api_v_ListeArticleClientWeb where NCLINUM = {miNumClient} GROUP BY  VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM ORDER BY VFOUMAT");
        apiGridb.GridControl.DataSource = dtB;
        InitapiGrid(apiGridb);

        apiGridH.LoadData(dtH, MozartDatabase.cnxMozart, $"select distinct VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM, min(FPUHT) as FPUHT from api_v_ListeArticleClientWeb where nfounum not in (select nfounum from  TARTCLIWEB where NCLINUM = {miNumClient}) GROUP BY  VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM ORDER BY VFOUMAT");
        apiGridH.GridControl.DataSource = dtH;
        InitapiGrid(apiGridH);
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
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRSB = New ADODB.Recordset
    //  adoRSB.Open "SELECT distinct VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM, min(FPUHT)*1.5 as FPUHT FROM api_v_ListeArticleClientWeb where NCLINUM = " & miNumClient & " GROUP BY  VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM ORDER BY VFOUMAT", cnx, adOpenForwardOnly, adLockOptimistic
    //  InitapiGridB
    //    
    //  Set adoRSH = New ADODB.Recordset
    //  adoRSH.Open "select distinct VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM, min(FPUHT) as FPUHT from api_v_ListeArticleClientWeb where nfounum not in (select nfounum from  TARTCLIWEB where NCLINUM = " & miNumClient & ") GROUP BY  VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, NFOUNUM ORDER BY VFOUMAT", cnx
    //  InitapiGridH
    //
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */

    //Private Sub InitapiGridB()
    //  
    //On Error GoTo handler
    //
    //  apiGridb.AddColumn "§Matériel§", "VFOUMAT", 7000
    //  apiGridb.AddColumn "§Marque§", "VFOUMAR", 1200
    //  apiGridb.AddColumn "§Type§", "VFOUTYP", 1200
    //  apiGridb.AddColumn "§Référence§", "VFOUREF", 1200
    //  apiGridb.AddColumn "§PCB§", "NFOUNBLOT", 600, , 2
    //  apiGridb.AddColumn "founum", "NFOUNUM", 0
    //  apiGridb.AddColumn "§Prix/U§", "FPUHT", 1200, "Currency", 1
    //
    //  apiGridb.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiGridb.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiGridb.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiGridb.AddCellTip "VFOUREF", &HFDF0DA
    //  
    //  apiGridb.Init adoRSB
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigridb dans " & Me.Name
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */

    private void InitapiGrid(apiTGrid pApiTGrid)
    {
      pApiTGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 7000);
      pApiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1200);
      pApiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1200);
      pApiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 1200);
      pApiTGrid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600, "", 2);
      pApiTGrid.AddColumn("founum", "NFOUNUM", 0);
      pApiTGrid.AddColumn(Resources.col_prixU, "FPUHT", 1200, "Currency", 1);

      pApiTGrid.InitColumnList();
    }
    //Private Sub InitapiGridH()
    //  
    //On Error GoTo handler
    //
    //  apiGridH.AddColumn "§Matériel§", "VFOUMAT", 7000
    //  apiGridH.AddColumn "§Marque§", "VFOUMAR", 1200
    //  apiGridH.AddColumn "§Type§", "VFOUTYP", 1200
    //  apiGridH.AddColumn "§Référence§", "VFOUREF", 1200
    //  apiGridH.AddColumn "§PCB§", "NFOUNBLOT", 600, , 2
    //  apiGridH.AddColumn "founum", "NFOUNUM", 0
    //  apiGridH.AddColumn "§Prix/U§", "FPUHT", 600, "currency", 1
    //
    //  apiGridH.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiGridH.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiGridH.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiGridH.AddCellTip "VFOUREF", &HFDF0DA
    //
    //  ' Style sur la ligne entière
    //'  apiGridH.AddRowStyle "CODE3", "CCODEG", "O", , , True
    //
    //  apiGridH.Init adoRSH
    //  
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigridh dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        // Multiselect
        foreach (int item in apiGridH.dgv.GetSelectedRows())
        {
          DataRow row = apiGridH.dgv.GetDataRow(item);
          ModuleData.ExecuteNonQuery($"INSERT INTO TARTCLIWEB ( NCLINUM, NFOUNUM ) values ({ miNumClient}, {row["NFOUNUM"]})");
          apiGridH.dgv.UnselectRow(item);
        }

        apiGridH.Requery(dtH, MozartDatabase.cnxMozart);
        apiGridb.Requery(dtB, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdAjouter_Click()
    //Dim sel As TrueOleDBGrid80.SelBookmarks
    //
    //  On Error Resume Next
    //   
    //  Set sel = apiGridH.ItemsSelected
    //  
    //  ' multiselect
    //  While sel.Count <> 0
    //    adoRSH.BookMark = sel.Item(0)
    //    cnx.Execute "INSERT INTO TARTCLIWEB ( NCLINUM, NFOUNUM ) values (" & miNumClient & "," & adoRSH("NFOUNUM") & ")"
    //    sel.Remove 0
    //  Wend
    //
    //  adoRSB.Requery
    //  adoRSH.Requery
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupp_Click(object sender, EventArgs e)
    {
      //suppression
      DataRow row = apiGridb.GetFocusedDataRow();
      if (row == null) return;

      int numfour = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
      if (MessageBox.Show(Resources.msg_supp_fourniture_liste_commande_client, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.ExecuteNonQuery($"delete from TARTCLIWEB WHERE NFOUNUM = {numfour} AND NCLINUM ={miNumClient}");
      }

      apiGridb.Requery(dtB, MozartDatabase.cnxMozart);
      apiGridH.Requery(dtH, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdSupp_Click()
    //    
    //On Error GoTo handler
    //
    //  'suppression
    //  If adoRSB.EOF Then Exit Sub
    //    
    //  If MsgBox("§Voulez-vous vraiment supprimer cette fourniture de la liste de commande du client ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    cnx.Execute "delete from TARTCLIWEB WHERE NFOUNUM = " & adoRSB("NFOUNUM") & " AND NCLINUM = " & miNumClient
    //  End If
    //  
    //  adoRSB.Requery
    //  adoRSH.Requery
    //    
    //Exit Sub
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
    //

  }
}

