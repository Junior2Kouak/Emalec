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
  public partial class frmListeMatFact : Form
  {
    public string msMode;
    public string msNumDI;
    public DataTable mdtArticles;

    private DataTable dtDI = new DataTable();
    private DataTable dtA = new DataTable();


    public frmListeMatFact() { InitializeComponent(); }

    private void frmListeMatFact_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiTgrid.btnExcel.Visible = apiTgrid.btnPrint.Visible = apiTgrid.chkColumnsList.Visible = false;

        apiTgrid.LoadData(dtDI, MozartDatabase.cnxMozart,
                          $"SELECT 'dde' + dbo.FormatCle(NDDENUM, 5) N, 0 C, NDDENUM D from TSTOCKDDE WHERE NACTNUM = {MozartParams.NumAction} " +
                          $"UNION SELECT 'CF' + dbo.FormatCle(NCOMNUM, 5) N, NCOMNUM C, 0 D FROM TCOM WHERE NACTNUM = {MozartParams.NumAction}");
        apiTgrid.GridControl.DataSource = dtDI;
        InitTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, System.EventArgs e)
    {
      DataRow currentRow = apiTgrid.GetFocusedDataRow();
      if (null == currentRow) return;
      bool bOK = false;

      //  test si l'enregistrement n'est pas déja selectionné
      //  on a le numArticle on regarde si il existe
      //  Execution d'une requete qui donne la liste des articles avec les prix emalec ou client
      ModuleData.LoadData(dtA, $"exec api_sp_ListePrixArticleCmd {msNumDI}, {currentRow["C"]}, {currentRow["D"]}", MozartDatabase.cnxMozart);
      foreach (DataRow iA in dtA.Rows)
      {
        bOK = false;
        foreach (DataRow iArticle in mdtArticles.Rows)
        {
          if (msMode == "NF")
          {
            if ((int)iArticle["NFOUNUM"] == (int)iA["NFOUNUM"])
              bOK = true;
          }
          else
          {
            if ((int)iArticle["NumArticle"] == (int)iA["NFOUNUM"])
              bOK = true;
          }
        }

        if (!bOK)
        {
          if (msMode == "NF")
            AjouterEnregFNF(iA);
          else
            AjouterEnreg(iA);
        }
      }
      Dispose();
    }

    private void AjouterEnreg(DataRow rowA)
    {
      DataRow newRow = mdtArticles.NewRow();

      newRow["Serie"] = Utils.BlankIfNull(rowA["VFOUSER"]);
      newRow["Article"] = Utils.BlankIfNull(rowA["VFOUMAT"]);
      newRow["Marque"] = Utils.BlankIfNull(rowA["VFOUMAR"]);
      newRow["Prix"] = Utils.BlankIfNull(rowA["NFOUTAR"]);
      newRow["Fournisseurs"] = "";
      newRow["NumFour"] = 0;
      newRow["NumArticle"] = (int)Utils.ZeroIfNull(rowA["NFOUNUM"]);
      newRow["Quantite"] = (int)Utils.ZeroIfNull(rowA["QTE"]);
      newRow["CoefClient"] = Utils.ZeroIfNull(rowA["COEFF"]);
      //newRow["PrixTotal"] = Utils.ZeroIfNull(rowA["NFOUTAR"]) * Utils.ZeroIfNull(rowA["QTE"]);

      newRow["Recyclage"] = Utils.ZeroIfNull(rowA["RecyclageVente"]) == 0 ? Utils.ZeroIfNull(rowA["Recyclage"]) : Utils.ZeroIfNull(rowA["RecyclageVente"]);

      newRow["colStock"] = 0;
      newRow["colImmo"] = 0;

      mdtArticles.Rows.Add(newRow);
    }

    private void AjouterEnregFNF(DataRow rowA)
    {
      DataRow newRow = mdtArticles.NewRow();

      newRow["CCFOCOD"] = Utils.BlankIfNull(rowA["VFOUSER"]);
      newRow["VFOUMAT"] = Utils.BlankIfNull(rowA["VFOUMAT"]);
      newRow["VFOUMAR"] = Utils.BlankIfNull(rowA["VFOUMAR"]);
      newRow["NFNFPRIXCLIENT"] = Utils.ZeroIfNull(rowA["NFOUTAR"]); //== 0 ? 0 : (Utils.ZeroIfNull(rowA["NFOUTAR"]) / Utils.ZeroIfNull(rowA["COEFF"]));
      newRow["NFNFQTE"] = (int)Utils.ZeroIfNull(rowA["QTE"]);
      newRow["NACTNUM"] = 0;
      newRow["NFOUNUM"] = (int)Utils.ZeroIfNull(rowA["NFOUNUM"]);
      newRow["DFNFMODIF"] = DateTime.Now.ToShortDateString();
      newRow["BSTOCK"] = 0;

      mdtArticles.Rows.Add(newRow);
    }

    private void InitTGrid()
    {
      apiTgrid.AddColumn(Resources.col_Number, "N", 800);
      apiTgrid.InitColumnList();
      apiTgrid.FilterBar = false;
    }
  }
}