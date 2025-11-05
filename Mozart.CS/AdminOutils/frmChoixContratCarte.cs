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
  public partial class frmChoixContratCarte : Form
  {
    DataTable dt = new DataTable();

    public frmChoixContratCarte()
    {
      InitializeComponent();
    }

    private void frmChoixContratCarte_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "select VCLINOM, NCLINUM from TCLI WHERE VSOCIETE = App_Name() AND CCLIACTIF='O' ORDER BY VCLINOM");
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //    
    //  InitBoutons Me, frmMenu
    //        
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //#If MULTI Then
    //  adoRS.Open "select VCLINOM, NCLINUM from TCLI WHERE VSOCIETE = App_Name() AND CCLIACTIF='O' ORDER BY VCLINOM", cnx
    //#Else
    //  adoRS.Open "select VCLINOM, NCLINUM from TCLI WHERE CCLIACTIF='O' ORDER BY VCLINOM", cnx
    //#End If
    //
    //  miAnnee = Year(Date)
    //  gsCodeRetour = ""
    //
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //   
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currRow = apiTGrid1.GetFocusedDataRow();
        if (currRow == null) return;

        frmBrowser f = new frmBrowser();
        f.msStartingAddress = "https://maps.emalec.com/SitesContratClient.asp?BASE=MULTI&APP=" + MozartParams.NomSociete
                            + "&NOM=" + currRow["VCLINOM"].ToString() + "&NUM="
                            + currRow["nclinum"].ToString() + "&Contrat="
                            + cboTypeContrat.SelectedValue
                            + "&vContrat=" + cboTypeContrat.Text;
        f.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/SitesContratClient.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NOM=" & adoRS("VCLINOM") & "&NUM=" & adoRS!nclinum & "&Contrat=" & cboTypeContrat.ItemData(cboTypeContrat.ListIndex) & "&vContrat=" & cboTypeContrat.Text
    //  frmBrowser.Show vbModal
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3500);
        apiTGrid1.AddColumn(Resources.col_NumCLI, "nclinum", 0);
        //  ApiGrid.AddColumn "§Client§", 3500
        //  ApiGrid.AddColumn "§NumClient§", 0

        apiTGrid1.InitColumnList();
        //  ApiGrid.Init adoRS
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
    //  ApiGrid.AddColumn "§Client§", 3500
    //  ApiGrid.AddColumn "§NumClient§", 0
    //    
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //      
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void apiTGrid1_ClickE(object sender, EventArgs e)
    {
      RemplirCboTypeContrat();
    }
    //Private Sub apigrid_RowColChange()
    //  RemplirCboTypeContrat
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void RemplirCboTypeContrat()
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      //  les contrats du client uniquement
      ModuleData.RemplirCombo(cboTypeContrat, "api_sp_TypeContratClient " + apiTGrid1.GetFocusedDataRow()["NCLINUM"].ToString());
      cboTypeContrat.ValueMember = "NTYPECONTRAT";
      cboTypeContrat.DisplayMember = "VCONTRAT";

      if (cboTypeContrat.Items.Count > 0)
        cboTypeContrat.SelectedIndex = 0;

      ////   vider les combos
      //cboAnnee.Items.Clear();

      ////   les années
      //for (int j = -1; j <= 3; j++)
      //  cboAnnee.Items.Add(DateTime.Now.AddYears(-j).Year);
      //cboAnnee.SelectedIndex = 1;
    }
    //Private Sub RemplirCboTypeContrat()
    //
    //Dim i As Integer
    //Dim pRS As ADODB.Recordset
    //
    //  
    //  ' vider les combos
    //  cboTypeContrat.Clear
    //  cboAnnee.Clear
    //  
    //  ' test de selection
    //  If adoRS.EOF Then Exit Sub
    //  
    //  ' les années
    //  For i = -1 To 3
    //    cboAnnee.AddItem Year(DateAdd("yyyy", -i, Date))
    //  Next
    //  cboAnnee.ListIndex = 1
    //
    //  ' les contrats du client uniquement
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "api_sp_TypeContratClient " & adoRS("NCLINUM"), cnx
    //  
    //  i = 0
    //  While Not pRS.EOF
    //    cboTypeContrat.AddItem CStr(pRS(0))
    //    cboTypeContrat.ItemData(i) = pRS(1)
    //    i = i + 1
    //    pRS.MoveNext
    //  Wend
    //  cboTypeContrat.ListIndex = 0
    //
    //  pRS.Close
    //  
    //End Sub
    //
    //
  }
}