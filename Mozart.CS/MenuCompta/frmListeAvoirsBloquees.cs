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
  public partial class frmListeAvoirsBloquees : Form
  {
    //Dim adoRS As New ADODB.Recordset
    DataTable dt = new DataTable();

    /* OK --------------------------------------------------------------------------------------- */
    public frmListeAvoirsBloquees()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmListeAvoirsBloquees_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_ListeAvoirRavelEnCours");
        apiTGrid.GridControl.DataSource = dt;

        InitApigrid();

        // Evenement pour calculer le total après avoir appliqué un filtre
        apiTGrid.dgv.ColumnFilterChanged += new EventHandler(apiTGrid_ColumnFilterChanged);

        CalculTotFac(apiTGrid, TxtTotFact);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()

    //  On Error GoTo handler
    //  InitBoutons Me, frmMenu
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_ListeAvoirRavelEnCours", cnx
    //  InitTGrid
    //  'calcul des totaux
    //  TxtTotFact.Text = CalculTotFac(adoRS, apiTGrid.GetFilter)
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_ColumnFilterChanged(object sender, EventArgs e)
    {
      CalculTotFac(apiTGrid, TxtTotFact);
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiTGrid.AddColumn(Resources.col_FO_STT, "VSTFNOM", 2800);
      apiTGrid.AddColumn(Resources.col_NumCdr, "CDEMALEC", 1300);
      apiTGrid.AddColumn(Resources.col_DateCde, "DDATCDE", 1400, "dd/mm/yy", 2);
      apiTGrid.AddColumn(Resources.col_MontantCde, "MT", 1500, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_NumFacture, "VFACREF", 1500);
      apiTGrid.AddColumn(Resources.col_DateFacture, "DFACDATE", 1300, "dd/mm/yy", 2);
      apiTGrid.AddColumn(Resources.col_MontantFacture, "FFACHT", 1800, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_MontantAvoir, "NCOURNAVOIR", 1500, "Currency");
      apiTGrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 2000);
      apiTGrid.AddColumn(Resources.col_NumCompte, "NCOMPTE", 1200, "", 2);
      apiTGrid.AddColumn(Resources.col_NumCpe, "CPT", 1200, "", 2);

      apiTGrid.InitColumnList();
    }
    //Private Sub InitTGrid()
    //    apiTGrid.AddColumn "FO/STT", "VSTFNOM", 2800
    //    apiTGrid.AddColumn "N°Cde", "CDEMALEC", 1300
    //    apiTGrid.AddColumn "Date Cde", "DDATCDE", 1400, "dd/mm/yy", 2
    //    apiTGrid.AddColumn "Montant Cde", "MT", 1500, "Currency", 1
    //    apiTGrid.AddColumn "N° Facture", "VFACREF", 1500
    //    apiTGrid.AddColumn "Date Facture", "DFACDATE", 1300, "dd/mm/yy", 2
    //    apiTGrid.AddColumn "Montant Facture", "FFACHT", 1800, "Currency", 1
    //    apiTGrid.AddColumn "Montant Avoir", "NCOURNAVOIR", 1500, "Currency", 1
    //    apiTGrid.AddColumn "Chaff", "VDINCHAFF", 2000
    //    apiTGrid.AddColumn "N° compte", "NCOMPTE", 1200, , 2
    //    apiTGrid.AddColumn "N° cpt", "CPT", 1200, , 2
    //    apiTGrid.Init adoRS
    //  End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CalculTotFac(apiTGrid grid, TextBox txt)
    {
      double dTot = 0;

      for (int i = 0; i < grid.dgv.RowCount; i++)
      {
        DataRow row = grid.dgv.GetDataRow(i);
        dTot += Convert.ToDouble(row["NCOURNAVOIR"]);
      }
      txt.Text = dTot.ToString("### ### ##0.## €");
    }
    //public string CalculTotFac(DataTable dt)
    //{
    //  double iMnttTotFiltre = 0;
    //  if(dt.Rows.Count > 0)
    //  {
    //    foreach (DataRow row in dt.Rows)
    //    {
    //      iMnttTotFiltre += Convert.ToInt32(row["NCOURNAVOIR"]);
    //    }
    //  }
    //  return iMnttTotFiltre.ToString("0,0.# €");
    //}
    //Private Function CalculTotFac(ByVal p_adors As ADODB.Recordset, ByVal sFilter As String) As String

    //      Dim iMnttTot As Double
    //      Dim iMnttTotFiltre As Double

    //      'init
    //      iMnttTot = 0
    //      iMnttTotFiltre = 0
    //  '    'on calcul la somme avant filtre
    //  '    p_adors.Filter = ""
    //  '    If p_adors.RecordCount > 0 Then
    //  '        p_adors.MoveFirst
    //  '        While p_adors.EOF = False
    //  '            iMnttTot = iMnttTot + p_adors("NCOURNAVOIR")
    //  '            p_adors.MoveNext
    //  '        Wend
    //  '    End If

    //      'on applique le filtre
    //      p_adors.Filter = sFilter
    //      If p_adors.RecordCount > 0 Then
    //          p_adors.MoveFirst
    //          While p_adors.EOF = False
    //              iMnttTotFiltre = iMnttTotFiltre + ZeroIfNull(p_adors("NCOURNAVOIR"))
    //              p_adors.MoveNext
    //          Wend
    //      End If

    //      CalculTotFac = FormatCurrency(iMnttTotFiltre)
    //      'CalculTotFac = FormatCurrency(iMnttTotFiltre) & " / " & FormatCurrency(iMnttTot)

    //  End Function

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    /*Private Sub Form_Unload(Cancel As Integer)
    On Error Resume Next
    adoRS.Close: Set adoRS = Nothing
    Screen.MousePointer = vbDefault
    End Sub
    Unload Me
    */
  }
}

