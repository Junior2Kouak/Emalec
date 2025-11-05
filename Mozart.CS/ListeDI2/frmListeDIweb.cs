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
  public partial class frmListeDIweb : Form
  {
    DataTable dt = new DataTable();
    //Dim adoRS As adodb.Recordset

    public frmListeDIweb() { InitializeComponent(); }

    private void frmListeDIweb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listedi_web WHERE NDINNUM is null order by NDIWNUM desc");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn("Num", "NDIWNUM", 600);
      apiGrid.AddColumn(Resources.col_DateArrivee, "DDIWDAT", 1700, "Date");
      apiGrid.AddColumn(Resources.col_Demandeur, "VDINNOM", 1300);
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apiGrid.AddColumn("Chaff", "CHAFF", 1400);
      apiGrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1500);
      apiGrid.AddColumn("N°", "NSITNUE", 500);
      apiGrid.AddColumn(Resources.col_Description, "TDIWDES", 4500);
      apiGrid.AddColumn(Resources.col_NumDI, "NDINNUM", 0);
      apiGrid.AddColumn("NumCli", "NCLINUM", 0);
      apiGrid.AddColumn("NumSit", "NSITNUM", 0);
      apiGrid.AddColumn("DACTDAT", "DACTDAT", 0);
      apiGrid.AddColumn("typecontrat", "NTYPECONTRAT", 0);
      apiGrid.AddColumn("nobjnum", "NOBJNUM", 0);
      apiGrid.AddColumn(Resources.col_reference_client, "VDIWREFCLI", 1300);

      apiGrid.InitColumnList();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (row == null) return;

      //écran de creation de la DI
      MozartParams.NumDi = 0;

      //test si la di est déjà prise
      if (DiBloquee())
      {
        MessageBox.Show(Resources.msg_Di_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      else ModuleData.ExecuteNonQuery($"update TDIW set CDIWLOCK = 'O' where NDIWNUM = {row["NDIWNUM"]}"); //on la bloque

      MozartParams.Action = Utils.BlankIfNull(row["TDIWDES"]);
      MozartParams.DateAction = Utils.DateBlankIfNull(row["DACTDAT"]);

      //écran de création de la demande sur internet
      Cursor.Current = Cursors.WaitCursor;

      new frmAddAction()
      {
        mstrStatutDI = "I",
        miNumClient = (int)row["NCLINUM"],
        miNumSite = (int)row["NSITNUM"],
        miNumDIWeb = (int)row["NDIWNUM"],
        mstrDemandeur = (string)row["VDINNOM"],
        mstrRefCli = (string)row["VDIWREFCLI"],
        //contrat et objet si client auchan
        miNumContrat = (int)Utils.ZeroIfNull(row["NTYPECONTRAT"]),
        miNumOBJgidt = (int)Utils.ZeroIfNull(row["NOBJNUM"]),
      }.ShowDialog();


      MozartParams.Action = "";
      MozartParams.DateAction = "";

      //test si la di est crée
      if (!DiTraitee())
        ModuleData.ExecuteNonQuery($"update TDIW set CDIWLOCK = 'N' where NDIWNUM = {row["NDIWNUM"]}");

      //rafraichissement
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (row == null) return;

      string[,] TdbGlobal = { { "", "" } };

      new frmBrowser()
      {
        miPlanningAn = 0
      }.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TDiWeb.html",
                    @"TDiWeb.out.html",
                    TdbGlobal,
                    $"select * from api_v_listedi_web where NDIWNUM = {row["NDIWNUM"]}",
                    " (Visualisation devis)",
                    "PREVIEW");
    }

    /* --------------------------------------------------------------------------------------- */
    private bool DiBloquee()
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (null == row) return true;
      return ModuleData.ExecuteScalarString($"select CDIWLOCK from TDIW where NDIWNUM = {row["NDIWNUM"]}") == "O" ? true : false;
    }
    //Private Function DiBloquee() As Boolean
    //    
    //Dim rs As adodb.Recordset
    //On Error GoTo Handler:
    //  
    //  DiBloquee = False
    //  
    //  ' ouverture du recordset
    //  Set rs = New adodb.Recordset
    //  rs.Open "select CDIWLOCK from TDIW  where NDIWNUM = " & adoRS("NDIWNUM"), cnx
    //  
    //  If rs.EOF Then Exit Function
    //  If rs(0) = "O" Then
    //    DiBloquee = True
    //  Else
    //    DiBloquee = False
    //  End If
    //  
    //Exit Function
    //Handler:
    //  ShowError "DiBloquee de " & Me.Name
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    private bool DiTraitee()
    {
      DataRow row = apiGrid.GetFocusedDataRow();
      if (null == row) return false;
      return ModuleData.ExecuteScalarInt($"select NDINNUM from TDIW  where NDIWNUM = {row["NDIWNUM"]}") == null ? false : true;
    }
    //Private Function DiTraitee() As Boolean
    //    
    //Dim rs As adodb.Recordset
    //On Error GoTo Handler:
    //  
    //  DiTraitee = False
    //  
    //  ' ouverture du recordset
    //  Set rs = New adodb.Recordset
    //  rs.Open "select NDINNUM from TDIW  where NDIWNUM = " & adoRS("NDIWNUM"), cnx
    //  
    //  If rs.EOF Then Exit Function
    //  If IsNull(rs(0)) Or rs(0) = "" Then
    //    DiTraitee = False
    //  Else
    //    DiTraitee = True
    //  End If
    //  
    //Exit Function
    //Handler:
    //  ShowError "DiTraitee de " & Me.Name
    //End Function
    //
    //' UPGRADE_INFO (#0501): The 'cmdImprimer_Click' member isn't used anywhere in current application.
    //'Private Sub cmdImprimer_Click()
    //'  Screen.MousePointer = vbHourglass
    //'  apiGrid.PrintGrid Me
    //'  Screen.MousePointer = vbDefault
    //'End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


  }
}

