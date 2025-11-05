using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmListeMessagesWebSTT : Form
  {
    DataTable dtATraite;
    DataTable dtAtt;
    DataTable dtClot;

    public frmListeMessagesWebSTT() { InitializeComponent(); }

    private void frmListeMessagesWebSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //  A traiter
        dtATraite = new DataTable();
        apiTGridAtraite.LoadData(dtATraite, MozartDatabase.cnxMozart, "SELECT * FROM api_v_listemessfact WHERE  STATUT = 'T' ORDER BY DDATECRE DESC");
        apiTGridAtraite.GridControl.DataSource = dtATraite;
        InitApigrid(apiTGridAtraite);

        //  En attente réponse
        dtAtt = new DataTable();
        apiTGridAtt.LoadData(dtAtt, MozartDatabase.cnxMozart, "SELECT * FROM api_v_listemessfact WHERE  STATUT = 'E' ORDER BY DDATECRE DESC");
        apiTGridAtt.GridControl.DataSource = dtAtt;
        InitApigrid(apiTGridAtt);
        //  
        //  CloturéesS
        dtClot = new DataTable();
        apiTGridClot.LoadData(dtClot, MozartDatabase.cnxMozart, "SELECT * FROM api_v_listemessfact WHERE  STATUT = 'C' ORDER BY DDATECRE DESC");
        apiTGridClot.GridControl.DataSource = dtClot;
        InitApigrid(apiTGridClot);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    /*--------------------------------------------------------------*/
    //Dim adoRsATraite As ADODB.Recordset 'reponse du st
    //Dim adoRSAtt As ADODB.Recordset 'attendue
    //Dim adoRSClot As ADODB.Recordset 'cloture
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //On Error GoTo Handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  'A traiter
    //  Set adoRsATraite = New ADODB.Recordset
    //  adoRsATraite.Open "SELECT * FROM api_v_listemessfact WHERE  STATUT = 'T' ORDER BY DDATECRE DESC", cnx
    //  InitApigridATraiter
    //  
    //  'En attente réponse
    //  Set adoRSAtt = New ADODB.Recordset
    //  adoRSAtt.Open "SELECT * FROM api_v_listemessfact WHERE  STATUT = 'E' ORDER BY DDATECRE DESC", cnx
    //  InitApigridAttente
    //  
    //  'CloturéesS
    //  Set adoRSClot = New ADODB.Recordset
    //  adoRSClot.Open "SELECT * FROM api_v_listemessfact WHERE  STATUT = 'C' ORDER BY DDATECRE DESC", cnx
    //  InitApigridClot
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void InitApigrid(apiTGrid grid)
    {
      grid.AddColumn("ID", "ID", 0);
      grid.AddColumn(MZCtrlResources.date_creation, "DDATECRE", 1600, "Date");
      grid.AddColumn(Resources.col_NumDI, "NDINNUM", 800, "", 2);
      grid.AddColumn(Resources.col_Contact, "NOMSTF", 2000);
      grid.AddColumn(Resources.col_Auteur, "NOMPER", 2000);
      grid.AddColumn(Resources.col_Message, "VMESSAGE", 5000);
      grid.AddColumn(Resources.col_etat, "CSTATUT", 1000);
      grid.AddColumn(Resources.col_Type, "CTYPE", 0);

      grid.InitColumnList();
    }
    //Private Sub InitApigridATraiter()
    // 
    //On Error GoTo Handler
    //  
    //  apiTGridAtraite.AddColumn "ID", "ID", 0
    //  apiTGridAtraite.AddColumn "§Date création§", "DDATECRE", 1600
    //  apiTGridAtraite.AddColumn "§N° DI§", "NDINNUM", 800, , 2
    //  apiTGridAtraite.AddColumn "§contact§", "NOMSTF", 2000
    //  apiTGridAtraite.AddColumn "§Auteur§", "NOMPER", 2000
    //  apiTGridAtraite.AddColumn "§Message§", "VMESSAGE", 5000
    //  apiTGridAtraite.AddColumn "§Etat§", "CSTATUT", 1000
    //  apiTGridAtraite.AddColumn "§Type§", "CTYPE", 0
    //  
    //  apiTGridAtraite.AddCellTip "VMESSAGE", &HFDF0DA
    //  
    //  apiTGridAtraite.Init adoRsATraite
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    //Private Sub InitApigridAttente()
    // 
    //On Error GoTo Handler
    //  
    //  apiTGridAtt.AddColumn "ID", "ID", 0
    //  apiTGridAtt.AddColumn "§Date création§", "DDATECRE", 1600
    //  apiTGridAtt.AddColumn "§N° DI§", "NDINNUM", 800, , 2
    //  apiTGridAtt.AddColumn "§Contact§", "NOMSTF", 2000
    //  apiTGridAtt.AddColumn "§Auteur§", "NOMPER", 2000
    //  apiTGridAtt.AddColumn "§Message§", "VMESSAGE", 5000
    //  apiTGridAtt.AddColumn "§Etat§", "CSTATUT", 1000
    //  apiTGridAtt.AddColumn "§Type§", "CTYPE", 0
    //  
    //  apiTGridAtt.AddCellTip "VMESSAGE", &HFDF0DA
    //  
    //  apiTGridAtt.Init adoRSAtt
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    //Private Sub InitApigridClot()
    // 
    //On Error GoTo Handler
    //  
    //  apiTGridClot.AddColumn "ID", "ID", 0
    //  apiTGridClot.AddColumn "§Date création§", "DDATECRE", 1600
    //  apiTGridClot.AddColumn "§N° DI§", "NDINNUM", 800, , 2
    //  apiTGridClot.AddColumn "§Contact§", "NOMSTF", 2000
    //  apiTGridClot.AddColumn "§Auteur§", "NOMPER", 2000
    //  apiTGridClot.AddColumn "§Message§", "VMESSAGE", 5000
    //  apiTGridClot.AddColumn "§Etat§", "CSTATUT", 1000
    //  apiTGridClot.AddColumn "§Type§", "CTYPE", 0
    //  
    //  apiTGridClot.AddCellTip "VMESSAGE", &HFDF0DA
    //  
    //  apiTGridClot.Init adoRSClot
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifDemande_Click(object sender, EventArgs e)
    {
      DataRow row = null;
      if ((sender as Button).Name == "cmdDetailClot")
        row = apiTGridClot.GetFocusedDataRow();
      else if ((sender as Button).Name == "CmdDetailRepAtt")
        row = apiTGridAtt.GetFocusedDataRow();
      else if ((sender as Button).Name == "cmdDetailRepAtraiter")
        row = apiTGridAtraite.GetFocusedDataRow();
      if (null == row) return;

      //  écran de modification de la demande
      MozartParams.NumAction = (int)row["NACTNUM"];
      MozartParams.NumDi = (int)row["NDINNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction { mstrStatutDI = "M" }.ShowDialog();

      // on revient donc on réinitialise les variables globales
      MozartParams.NumAction = 0;
      MozartParams.NumDi = 0;

      if ((sender as Button).Name == "cmdDetailClot")
        apiTGridClot.Requery(dtClot, MozartDatabase.cnxMozart);
      else if ((sender as Button).Name == "CmdDetailRepAtt")
        apiTGridAtt.Requery(dtAtt, MozartDatabase.cnxMozart);
      else if ((sender as Button).Name == "cmdDetailRepAtraiter")
        apiTGridAtraite.Requery(dtATraite, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdDetailClot_Click()
    //
    //On Error Resume Next
    //If adoRSClot.EOF Then Exit Sub
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = adoRSClot("NDINNUM").Value
    //  glNumAction = adoRSClot("NACTNUM").Value
    //    
    //  On Error Resume Next
    //  frmAddAction.Show vbModal
    //  adoRSClot.Requery
    //
    //End Sub
    //
    //Private Sub cmdDetailRepAtraiter_Click()
    //   
    //On Error Resume Next
    //If adoRsATraite.EOF Then Exit Sub
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = adoRsATraite("NDINNUM").Value
    //  glNumAction = adoRsATraite("NACTNUM").Value
    //    
    //  On Error Resume Next
    //  frmAddAction.Show vbModal
    //  adoRsATraite.Requery
    //    
    //End Sub
    //
    //Private Sub CmdDetailRepAtt_Click()
    //
    //On Error Resume Next
    //If adoRSAtt.EOF Then Exit Sub
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = adoRSAtt("NDINNUM").Value
    //  glNumAction = adoRSAtt("NACTNUM").Value
    //    
    //  On Error Resume Next
    //  frmAddAction.Show vbModal
    //  adoRSAtt.Requery
    //
    //End Sub
    //
    //
    //

  }
}

