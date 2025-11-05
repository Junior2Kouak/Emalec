using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStockMouvements : Form
  {
    public int miFouNum;
    public int miNumStock;
    public int miCompte;
    public string mstrType = "";

    public string miVFOUMAT = "";
    public int miNQTEACTUEL;
    public int miNQTECDE;

    // pour appel depuis formulaires cas mstrType != "FOURNITURE"
    public string mDateDebut, mDateFin;

    private DataTable dt = new DataTable();

    public frmStockMouvements()
    {
      InitializeComponent();
    }

    private void frmStockMouvements_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        string sql;


        if (mstrType == "FOURNITURE")
        {
          sql = $"SELECT * FROM api_v_ListeStockDetailsES WHERE NFOUNUM = {miFouNum} AND NSTOCKLIEU = {miNumStock} ORDER BY DSTOCKENTREE DESC";

          LblVFOUMAT.Text = miVFOUMAT;
          LblNQTEACTUEL.Text = miNQTEACTUEL.ToString();
          LblNQTECDE.Text = miNQTECDE.ToString();

          InitApiTgridFou();
        }
        else
        {
          sql = $"EXEC api_sp_Stat_ValorisationStockDetail {miCompte}, '{mDateDebut}', '{mDateFin} 22:00:00'";

          lblTitre.Text += $"\r\nCompte {miCompte}  du {mDateDebut} au {mDateDebut}";

          InitApiTgridCpt();
        }

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
        apiTGrid.GridControl.DataSource = dt;

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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    /*
  Option Explicit
    Public miFouNum As Long
    Public miNumStock As Long
    Public miCompte As Integer
    Public mstrType As String
    
    Public miVFOUMAT As String
    Public miNQTEACTUEL As Integer
    Public miNQTECDE As Integer
    
    Dim rsStock As ADODB.Recordset
    
    Private Sub Form_Load()
      
      InitBoutons Me, frmMenu
      
      Set rsStock = New ADODB.Recordset
      
      If mstrType = "FOURNITURE" Then
        rsStock.Open "SELECT * FROM api_v_ListeStockDetailsES WHERE NFOUNUM = " & miFouNum & " AND NSTOCKLIEU = " & miNumStock & " ORDER BY DSTOCKENTREE DESC ", cnx, adOpenForwardOnly, adLockOptimistic
        LblVFOUMAT.Caption = miVFOUMAT
        LblNQTEACTUEL.Caption = CStr(miNQTEACTUEL)
        LblNQTECDE.Caption = CStr(miNQTECDE)
        InitApiTgridFou
      Else
        rsStock.Open "EXEC api_sp_Stat_ValorisationStockDetail " & miCompte & ", '" & frmStockStatsCan.txtDateA(0) & "', '" & frmStockStatsCan.txtDateA(1) & " 22:00:00'", cnx
        InitApiTgridCpt
        lblTitre.Caption = lblTitre.Caption & vbCrLf & "Compte " & miCompte & "  du " & frmStockStatsCan.txtDateA(0) & " au " & frmStockStatsCan.txtDateA(1)
      End If
      
      Screen.MousePointer = vbDefault
    End Sub
    */

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      int NCOMNUM = (int)Utils.ZeroIfNull(Utils.BlankIfNull(row["NCOMNUM"]).Substring(2));

      //System.Diagnostics.Process.Start($@"{MozartParams.RepertoireReports}ReportEmalec.Net.exe", $"TCommande;{NCOMNUM};0|0|0;{MozartParams.NomSociete};{MozartParams.Langue};PREVIEW;CF");
      new frmMainReport()
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TCOMMANDE,
        sIdentifiant = $"{NCOMNUM}",
        InfosMail = "0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
        strType = "CF"
      }.ShowDialog();

      //frm.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TCommandeFourniture.rtf",
      //                  @"\NCOMNUM_TCommandeFournitureOut.rtf",
      //                  TdbGlobal,
      //                  $"exec api_sp_impCommande {NCOMNUM}",
      //                  " (Prévisualisation commande)",
      //                  "PREVIEW");
    }

    private void InitApiTgridFou()
    {
      apiTGrid.AddColumn(Resources.col_Date, "DSTOCKENTREE", 1100);
      apiTGrid.AddColumn(Resources.col_StockNum, "NSTOCKNUM", 0);
      apiTGrid.AddColumn(Resources.col_LivrNum, "NLIVRNUM", 0);
      apiTGrid.AddColumn(Resources.col_Type, "NLLIVRNUM", 1100);
      apiTGrid.AddColumn(Resources.col_FouNum, "NFOUNUM", 0);
      apiTGrid.AddColumn(Resources.col_Article, "VFOUMAT", 0);
      apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 0);
      apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 0);
      apiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 0);
      apiTGrid.AddColumn(Resources.col_Qui, "VQUICREE", 2500);
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
      apiTGrid.AddColumn(Resources.col_qte3, "NSTOCKQTE", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_HT, "FSTOCKPUHT", 1100, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_Lieu, "NSTOCKLIEU", 0);
    }
    /*
  Private Sub InitApiTgridFou()

  On Error GoTo handler

    apiTGrid.AddColumn "§Date§", "DSTOCKENTREE", 1100
    apiTGrid.AddColumn "StockNum", "NSTOCKNUM", 0
    apiTGrid.AddColumn "§LivrNum§", "NLIVRNUM", 0
    apiTGrid.AddColumn "§Type§", "NLLIVRNUM", 1100
    apiTGrid.AddColumn "FouNum", "NFOUNUM", 0
    apiTGrid.AddColumn "§Article§", "VFOUMAT", 0
    apiTGrid.AddColumn "§Marque§", "VFOUMAR", 0
    apiTGrid.AddColumn "§Type§", "VFOUTYP", 0
    apiTGrid.AddColumn "§Référence§", "VFOUREF", 0
    apiTGrid.AddColumn "§Qui§", "VQUICREE", 2500
    apiTGrid.AddColumn "§Client§", "VCLINOM", 2500
    apiTGrid.AddColumn "§Qte§", "NSTOCKQTE", 700, , 2
    apiTGrid.AddColumn "§HT§", "FSTOCKPUHT", 1100, "Currency", 1
    apiTGrid.AddColumn "§Lieu§", "NSTOCKLIEU", 0

    apiTGrid.Init rsStock
    Exit Sub

  handler:
    ShowError "InitApiTgridFou dans " & Me.Name
  End Sub
  */

    private void InitApiTgridCpt()
    {
      if (miCompte == 995 || miCompte == 993)
      {
        apiTGrid.AddColumn(Resources.col_Date, "DCOMDAT", 1100);
        apiTGrid.AddColumn(Resources.col_Num, "NCOMNUM", 1000, "", 2);
        apiTGrid.AddColumn(Resources.col_Fact_ravel, "FHTANA", 1500, "Currency", 1);
        apiTGrid.AddColumn(Resources.col_Cde_Mozart, "NCOMPHT", 1500, "Currency", 1);
        apiTGrid.AddColumn(Resources.col_DI, "NDINNUM", 900, "", 2);
        apiTGrid.AddColumn(Resources.col_Qui, "VCOMAUTEUR", 2500);

        cmdVisu.Visible = true;
      }
      else
      {
        apiTGrid.AddColumn(Resources.col_Date, "DDATE", 1100);
        apiTGrid.AddColumn(Resources.col_FouNum, "NFOUNUM", 0);
        apiTGrid.AddColumn(Resources.col_Article, "VFOUMAT", 2000);
        apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1400);
        apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1400);
        apiTGrid.AddColumn(Resources.col_qte3, "Qte", 700, "", 2);
        apiTGrid.AddColumn(Resources.col_HT, "PU", 1100, "Currency", 1);
        apiTGrid.AddColumn(Resources.col_BLCDE, "NUM", 900, "", 2);
        apiTGrid.AddColumn(Resources.col_DI, "NDINNUM", 900, "", 2);
        apiTGrid.AddColumn(Resources.col_Qui, "QUI", 1400);
        apiTGrid.AddColumn(Resources.col_Action, "VACTDES", 1400, "", 0, true);
      }
    }
    /*
  Private Sub InitApiTgridCpt()

  On Error GoTo handler

  If miCompte = 995 Or miCompte = 993 Then

    apiTGrid.AddColumn "§Date§", "DCOMDAT", 1100
    apiTGrid.AddColumn "Num", "NCOMNUM", 1000, , 2
    apiTGrid.AddColumn "§Fact ravel§", "FHTANA", 1500, "Currency", 1
    apiTGrid.AddColumn "§Cde Mozart§", "NCOMPHT", 1500, "Currency", 1
    apiTGrid.AddColumn "§DI§", "NDINNUM", 900, , 2
    apiTGrid.AddColumn "§Qui§", "VCOMAUTEUR", 2500

    apiTGrid.Init rsStock
    cmdVisu.Visible = True

  Else

    apiTGrid.AddColumn "§Date§", "DDATE", 1100
    apiTGrid.AddColumn "FouNum", "NFOUNUM", 0
    apiTGrid.AddColumn "§Article§", "VFOUMAT", 2000
    apiTGrid.AddColumn "§Marque§", "VFOUMAR", 1400
    apiTGrid.AddColumn "§Type§", "VFOUTYP", 1400
  '  apiTGrid.AddColumn "§Référence§", "VFOUREF", 1400
    apiTGrid.AddColumn "§Qte§", "Qte", 700, , 2
    apiTGrid.AddColumn "§HT§", "PU", 1100, "Currency", 1
    apiTGrid.AddColumn "§BL/CDE§", "NUM", 900, , 2
    apiTGrid.AddColumn "§DI§", "NDINNUM", 900, , 2
    apiTGrid.AddColumn "§Qui§", "QUI", 1400
    apiTGrid.AddColumn "§Action§", "VACTDES", 1400, , , True

    apiTGrid.AddCellTip "VFOUMAT", &HC0FFC0
    apiTGrid.AddCellTip "VACTDES", &HC0FFC0
    apiTGrid.Init rsStock

  End If

    Exit Sub

  handler:
    ShowError "InitApiTgridCpt dans " & Me.Name
  End Sub
*/
  }
}
