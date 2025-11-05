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
  public partial class frmStatHeureDevisTech : Form
  {
    //Public sTypeStat As String  'Client ou technicien
    public string mTypeStat;

    public frmStatHeureDevisTech() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStatHeureDevisTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        if (mTypeStat == "Client")
        {
          lblTitre.Text = "Fiabilité des heures de devis estimées par les techniciens / par DI";
        }
        else
        {
          lblTitre.Text = "Fiabilité des heures de devis estimées par les techniciens / par technicien";
          cmdModifier.Visible = false;
        }
        lblinfo.Text = "Période : 12 mois glissants\r\n" +
                      "Sur DI terminées(toutes actions terminées)\r\n" +
                      "Les actions de sous-traitance, les préventives et les multisites sont excluent\r\n" +
                      "Calcul du % : (Heures devis - heures réalisées) / heures réalisées";

        InitTGrid();
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
    //On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  Set ado_rs = New ADODB.Recordset
    // 
    //  InitBoutons Me, frmMenu
    //  Set ado_rs = New ADODB.Recordset
    //  
    //  If sTypeStat = "Client" Then
    //    lblTitre.Caption = "Fiabilité des heures de devis estimées par les techniciens / par DI"
    //    ado_rs.Open "exec api_sp_StatHeuresDevisTech 'Client'", cnx
    //  Else
    //    lblTitre.Caption = "Fiabilité des heures de devis estimées par les techniciens / par technicien"
    //    ado_rs.Open "exec api_sp_StatHeuresDevisTech 'Tech'", cnx
    //    cmdModifier.Visible = False
    //  End If
    //  
    //  lblinfo.Caption = "Période : 12 mois glissants" & vbCrLf & "Sur DI terminées (toutes actions terminées)"
    //  lblinfo.Caption = lblinfo.Caption & vbCrLf & "Les actions de sous-traitance, les préventives et les multisites sont excluent"
    //  lblinfo.Caption = lblinfo.Caption & vbCrLf & "Calcul du % : (Heures devis - heures réalisées) / heures réalisées"
    //  
    //  InitTGrid
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitTGrid()
    {
      apiTGrid.AddColumn(Resources.col_Technicien, "vpernom", 2500);
      if (mTypeStat == "Client")
      {
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "vclinom", 3500);
        apiTGrid.AddColumn("N°DI", "ndinnum", 1700, "", 2);
        apiTGrid.AddColumn("Heures préparation", "hr", 2400, "", 2);
        apiTGrid.AddColumn("Heures réalisées", "hract", 2400, "", 2);
      }
      else
      {
        apiTGrid.AddColumn("Heures préparation", "HR", 2400, "", 2);
        apiTGrid.AddColumn("Heures réalisées", "HRACT", 2400, "", 2);
      }
      apiTGrid.AddColumn("Différence", "DIFF", 1500, "", 2);
      apiTGrid.AddColumn("Différence %", "RATIO", 1500, "0.00", 2);

      apiTGrid.InitColumnList();

      string sql;
      if (mTypeStat == "Client")
        sql = "exec api_sp_StatHeuresDevisTech 'Client'";
      else
        sql = "exec api_sp_StatHeuresDevisTech 'Tech'";

      DataTable dt = new DataTable();
      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
      apiTGrid.GridControl.DataSource = dt;
    }
    //Private Sub InitTGrid()
    //  
    //  apiTGrid.AddColumn "Technicien", "VPERNOM", 2500
    //  If sTypeStat = "Client" Then apiTGrid.AddColumn "Client", "VCLINOM", 3500
    //  If sTypeStat = "Client" Then apiTGrid.AddColumn "N°DI", "NDINNUM", 1700, , 2
    //  apiTGrid.AddColumn "Heures préparation", "HR", 2400, , 2
    //  apiTGrid.AddColumn "Heures réalisées", "HRACT", 2400, , 2
    //  apiTGrid.AddColumn "Différence", "DIFF", 1500, , 2
    //  apiTGrid.AddColumn "Différence %", "RATIO", 1500, "00.00", 2
    //
    //  apiTGrid.Init ado_rs
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;
      MozartParams.NumDi = (int)Utils.ZeroIfNull(row["NDINNUM"]);
      new frmAddAction()
      {
        mstrStatutDI = "M"
      }.ShowDialog();
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }
    //Private Sub cmdModifier_Click()
    //' UPGRADE_INFO (#0501): The 'aux' member isn't used anywhere in current application.
    //' Dim aux
    //  
    //  If ado_rs.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = val(ado_rs("NDINNUM").value)
    //  frmAddAction.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //    
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //  
    //  Screen.MousePointer = vbDefault
    //
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
  }
}

