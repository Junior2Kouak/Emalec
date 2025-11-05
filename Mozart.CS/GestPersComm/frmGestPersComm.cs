using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestPersComm : Form
  {
    //Dim rsPer As Recordset
    DataTable dtPer;

    public frmGestPersComm() { InitializeComponent(); }

    private void frmGestPersComm_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        dtPer = new DataTable();
        apiGrid.LoadData(dtPer, MozartDatabase.cnxMozart, "exec api_sp_ListePersonnelComm");
        InitapiGrid();
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
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //    
    //  Set rsPer = New Recordset
    //  rsPer.Open "exec api_sp_ListePersonnelComm  ", cnx, adOpenStatic, adLockOptimistic
    //
    //  InitapiGrid
    //   
    //  apiGrid.SetFilter ("CPERACTIF = 'O'")
    //  
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (null == apiGrid.GetFocusedDataRow()) return;
      new frmDetailPersonnelComm
      {
        mstrStatut = "M",
        miNumPer = (int)Utils.ZeroIfNull(apiGrid.GetFocusedDataRow()["NPERNUM"])
      }.ShowDialog();
      apiGrid.Requery(dtPer, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdModifier_Click()
    //  
    //  If rsPer.RecordCount = 0 Then Exit Sub
    //  
    //  frmDetailPersonnelComm.mstrStatut = "M"
    //  frmDetailPersonnelComm.miNumPer = rsPer!npernum
    //  frmDetailPersonnelComm.Show vbModal
    //  
    //  rsPer.Requery
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      if (null == apiGrid.GetFocusedDataRow()) return;
      ModuleData.ExecuteNonQuery($"update tpercomm set cperactif='N' where npernum={apiGrid.GetFocusedDataRow()["NPERNUM"]}");
      apiGrid.Requery(dtPer, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdSupprimer_Click()
    //      
    //On Error GoTo handler
    //
    //  If rsPer.EOF Then Exit Sub
    //  
    //  cnx.Execute "update tpercomm set cperactif='N' where npernum=" & rsPer("NPERNUM")
    //    rsPer.Requery
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      if (null == apiGrid.GetFocusedDataRow()) return;
      ModuleData.ExecuteNonQuery($"update tpercomm set cperactif='O' where npernum={apiGrid.GetFocusedDataRow()["NPERNUM"]}");
      apiGrid.Requery(dtPer, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdRestaurer_Click()
    //  If rsPer.EOF Then Exit Sub
    //  cnx.Execute "update tpercomm set cperactif='O' where npernum=" & rsPer("NPERNUM")
    //  rsPer.Requery
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdImplantation_Click(object sender, EventArgs e)
    {
      new frmBrowser
      {
        mbcmdFicheTech = false,
        mstrType = "",
        msStartingAddress = "https://maps.emalec.com/TechniciensComm.asp?BASE=MULTI&APP=EMALEC"
      }.ShowDialog();
    }
    //Private Sub cmdImplantation_Click()
    //  
    //  frmBrowser.bcmdFicheTech = False
    //  frmBrowser.mstrType = ""
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/TechniciensComm.asp?BASE=MULTI&APP=EMALEC"
    //  frmBrowser.Show vbModal
    //  frmBrowser.bcmdFicheTech = False

    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdGoogle_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start($@"{MozartParams.CheminProgramme}\mozart\WinGeocoderComm.exe", $"AUTO {MozartParams.NomServeur} MULTI EMALEC");
    }
    //Private Sub cmdGoogle_Click()
    //        Shell gstrCheminProgramme & "\mozart\WinGeocoderComm.exe" & " " & "AUTO" & " " & gstrNomServeur & " " & "MULTI" & " " & "EMALEC", vbNormalFocus
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void InitapiGrid()
    {
      apiGrid.AddColumn("Nom", "VPERNOM", 1700);//           '0
      apiGrid.AddColumn("Prenom", "VPERPRE", 1400);
      //  'apiGrid.AddColumn "Type", "VTYPELIB", 1200
      apiGrid.AddColumn("Service", "VSERLIB", 2000);
      apiGrid.AddColumn("Dep", "VDEPLIB", 2000);// '5
      apiGrid.AddColumn("Age", "Age", 600);// '0
      apiGrid.AddColumn("D entrée", "DPERENT", 1100, "dd/mm/yy");
      apiGrid.AddColumn("Adresse 1", "VPERAD1", 2500);
      apiGrid.AddColumn("Adresse 2", "VPERAD2", 2500);
      apiGrid.AddColumn("CP", "VPERCP", 800);
      apiGrid.AddColumn("Ville", "VPERVIL", 2000);
      apiGrid.AddColumn("Actif", "CPERACTIF", 1000);

      apiGrid.InitColumnList();
      apiGrid.CacherCompteur();
      apiGrid.GridControl.DataSource = dtPer;
      apiGrid.dgv.ActiveFilterString = "CPERACTIF = 'O'";
    }
    //Private Sub InitapiGrid()
    //  
    //On Error GoTo handler
    //  
    //  apiGrid.AddColumn "Nom", "VPERNOM", 1700           '0
    //  apiGrid.AddColumn "Prenom", "VPERPRE", 1400
    //  'apiGrid.AddColumn "Type", "VTYPELIB", 1200
    //  apiGrid.AddColumn "Service", "VSERLIB", 2000
    //  apiGrid.AddColumn "Dep", "VDEPLIB", 2000         '5
    //  apiGrid.AddColumn "Age", "AGE", 600            '0
    //  apiGrid.AddColumn "D entrée", "DPERENT", 1100, "dd/mm/yy"
    //  apiGrid.AddColumn "Adresse 1", "VPERAD1", 2500
    //  apiGrid.AddColumn "Adresse 2", "VPERAD2", 2500
    //  apiGrid.AddColumn "CP", "VPERCP", 800
    //  apiGrid.AddColumn "Ville", "VPERVIL", 2000
    //  apiGrid.AddColumn "Actif", "CPERACTIF", 1000
    //  
    //  apiGrid.Init rsPer
    //  apiGrid.CacherCompteur
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
  }
}