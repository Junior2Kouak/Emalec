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
  public partial class frmRechercheFournituresNF : Form
  {

    public long miNactNum;
    public long miNumClient;
    public bool mbModif = false;  // Pour savoir si modification
    public float mfHT = 0;        // pour le total HT

    bool bCreateMod;
    public DataTable mdtArticle = new DataTable();
    DataTable dtGridH = new DataTable();

    // DataTable privé pour ne pas modifier directement le datatable d'origine si on ne valide pas la saisie
    private DataTable dtArticle = new DataTable();
    string rowTemp = "";


    public frmRechercheFournituresNF() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmRechercheFournituresNF_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Travailler sur une copie
        dtArticle = mdtArticle.Copy();

        if (dtArticle.Rows.Count == 0)
          bCreateMod = true;
        else
          bCreateMod = false;

        //charge la liste des fournitures
        //attention le prix de base est le prix du fournisseur le moins cher
        //apiTGridH.LoadData(dtGridH, MozartDatabase.cnxMozart, $"exec api_sp_listeFournituresCNF {miNumClient}");
        apiTGridH.LoadData(dtGridH, MozartDatabase.cnxMozart, $"exec api_sp_listeFourNF {miNumClient}");
        apiTGridH.GridControl.DataSource = dtGridH;

        FormatGridH();

        FormatGridArticle();

        RemplirTxtTotaux();

        Cursor = Cursors.Default;
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
    private void apiTGridB_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (e.Column.ColumnHandle == 5)
      {
        if (Utils.IsNumeric(dtArticle.Rows[e.RowHandle][5].ToString()) == false)
        {
          rowTemp = dtArticle.Rows[e.RowHandle][5].ToString();
          dtArticle.Rows[e.RowHandle]["NFNFQTE"] = 0;
          MessageBox.Show(Resources.msg_quantNonNum, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }

    private void apiTGridB_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //recalculer total HT 
      RemplirTxtTotaux();

      //test si données ont été changés sur la quantité
      if (dtArticle.Rows[e.RowHandle][5].ToString() != rowTemp || bCreateMod == true)
      {

        mbModif = true;
        bCreateMod = false;
      }
    }

    private void apiTGridH_DoubleClickE(object sender, EventArgs e)
    {
      cmdAjouter_Click(null, null);
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      mdtArticle = dtArticle.Copy();
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      bool bOK = false;

      //test si l'enregistrement n'est pas déjà selectionné
      //on a le numArticle on regarde si il existe
      DataRow currentRow = apiTGridH.GetFocusedDataRow();

      foreach (DataRow dr in dtArticle.Rows)
        if (dr["nfounum"].ToString() == currentRow["NFOUNUM"].ToString())
          bOK = true;

      if (!bOK)
      {
        AjouterEnreg();
        RemplirTxtTotaux();
      }
      else
        MessageBox.Show(Resources.msg_article_already_in_list, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //modification true
      mbModif = true;
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      //suppression de la ligne courante
      DataRow currentRow = apiTGridB.GetFocusedDataRow();
      if (currentRow == null) return;

      //ne delete pas seulement dans la gridview mais aussi dans la datatable
      for (int i = 0; i < dtArticle.Rows.Count; i++)
      {
        if (dtArticle.Rows[i] == currentRow) dtArticle.Rows.Remove(dtArticle.Rows[i]);
      }

      currentRow.Delete();
      dtArticle.AcceptChanges();

      //recalculer total HT
      RemplirTxtTotaux();

      //modification true
      mbModif = true;
    }

    private void AjouterEnreg()
    {
      try
      {
        DataRow currentRow = apiTGridH.GetFocusedDataRow();
        if (currentRow == null) return;

        DataRow newrow = dtArticle.NewRow();

        newrow["CCFOCOD"] = Utils.BlankIfNull(currentRow["VFOUSER"]);
        newrow["VFOUMAT"] = Utils.BlankIfNull(currentRow["VFOUMAT"]);
        newrow["VFOUMAR"] = Utils.BlankIfNull(currentRow["VFOUMAR"]);
        newrow["VFOUREF"] = Utils.BlankIfNull(currentRow["VFOUREF"]);
        newrow["NFNFPRIXACHAT"] = Utils.ZeroIfNull(currentRow["NFOUPRIXACHAT"]);
        newrow["NFNFQTE"] = 1;
        newrow["NFOUNUM"] = Utils.ZeroIfNull(currentRow["NFOUNUM"]);
        newrow["NACTNUM"] = Utils.ZeroIfNull(currentRow["NACTNUM"]);
        newrow["DFNFMODIF"] = DateTime.Now.ToShortDateString();
        newrow["BSTOCK"] = 0;

        dtArticle.Rows.Add(newrow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridH()
    {
      try
      {
        apiTGridH.AddColumn(Resources.col_numArt, "NFOUNUM", 0, "", 1);
        apiTGridH.AddColumn(Resources.col_Serie, "VFOUSER", 1500);
        apiTGridH.AddColumn(Resources.col_materiel, "VFOUMAT", 6000);
        apiTGridH.AddColumn(Resources.col_marque, "VFOUMAR", 1400);
        apiTGridH.AddColumn(Resources.col_Ref, "VFOUREF", 800);
        apiTGridH.AddColumn(Resources.col_PrixAchatU, "NFOUPRIXACHAT", 1400, "currency", 1);
        apiTGridH.AddColumn("NACTNUM", "NACTNUM", 0);

        apiTGridH.InitColumnList();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridArticle()
    {
      try
      {
        apiTGridB.AddColumn(Resources.col_Serie, "CCFOCOD", 1500);
        apiTGridB.AddColumn(Resources.col_materiel, "VFOUMAT", 5500);
        apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1400);
        apiTGridB.AddColumn(Resources.col_Ref, "VFOUREF", 800);
        apiTGridB.AddColumn("Prix Achat", "NFNFPRIXACHAT", 1400, "currency", 1);
        apiTGridB.AddColumn(Resources.col_Qte, "NFNFQTE", 1000);
        apiTGridB.AddColumn("NFOUNUM", "NFOUNUM", 0);
        apiTGridB.AddColumn("NACTNUM", "NACTNUM", 0);
        apiTGridB.AddColumn(Resources.col_stock, "BSTOCK", 0);
        apiTGridB.AddColumn(Resources.col_date_modif, "DFNFMODIF", 0);

        apiTGridB.FilterBar = false;
        apiTGridB.InitColumnList();

        apiTGridB.DelockColumn("NFNFQTE");

        apiTGridB.GridControl.DataSource = dtArticle;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RemplirTxtTotaux()
    {
      try
      {
        mfHT = 0;

        foreach (DataRow dc in dtArticle.Rows)
          mfHT += Convert.ToSingle(Utils.ZeroIfNull(dc["NFNFPRIXACHAT"]) * Utils.ZeroIfNull(dc["NFNFQTE"]));

        txtHT.Text = Strings.Format(mfHT.ToString(), "currency");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


  }
}