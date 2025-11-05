using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

using MZUtils = MozartControls.Utils;
using MozartLib;

namespace MozartCS
{
  public partial class frmRechercheFournituresCNF : Form
  {

    public long miNumClient;
    public float mfHT = 0;        // pour le total HT
    public DataTable mdtArticle = new DataTable();

    DataTable dtGridH = new DataTable();
    private DataTable dtListeFouFac = new DataTable();
    
    // DataTable privé pour ne pas modifier directement le datatable d'origine si on ne valide pas la saisie
    private DataTable dtArticle;

    public frmRechercheFournituresCNF() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmRechercheFournituresNF_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Combo Série
        string sql = $"EXEC api_sp_SerieFo_Liste";
        cboCritSerie.Init(MozartDatabase.cnxMozart, sql, "NCFOCOD", "CCFOCOD", new List<string>() { Resources.col_Num, Resources.col_série }, 250, 550, true);
        cboCritSerie.SetColumnVisible("LANGUE", false);

        // Travailler sur une copie
        dtArticle = mdtArticle.Copy();

        apiTGridH.GridControl.DataSource = dtListeFouFac;
        //  mise en page du datagrid du haut
        FormatGridH();

        //  liaison du recordset et du datagrid
        apiTGridB.GridControl.DataSource = dtArticle;

        //  mise en page du datagrid du bas
        FormatGridArticle();

        //  initialisation du total
        RemplirTxtTotaux();

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

    private void apiTGridB_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (e.Column.ColumnHandle == 5)
      {
        if (Utils.IsNumeric(dtArticle.Rows[e.RowHandle][5].ToString()) == false)
        {
          dtArticle.Rows[e.RowHandle]["NFNFQTE"] = 0;
          MessageBox.Show(Resources.msg_quantNonNum, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
    }

    private void apiTGridB_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //recalculer total HT 
      RemplirTxtTotaux();
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
        newrow["NFNFPRIXCLIENT"] = Utils.ZeroIfNull(currentRow["NFOUTAR"]);
        newrow["NFNFQTE"] = 1;
        newrow["NFOUNUM"] = Utils.ZeroIfNull(currentRow["NFOUNUM"]);
        newrow["NACTNUM"] = 0;
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
        apiTGridH.AddColumn(Resources.col_Num, "NFOUNUM", 0);
        apiTGridH.AddColumn(Resources.col_Serie, "VFOUSER", 1100);
        apiTGridH.AddColumn(Resources.col_materiel, "VFOUMAT", 2500);
        apiTGridH.AddColumn(Resources.col_marque, "VFOUMAR", 970);
        apiTGridH.AddColumn(Resources.col_Type, "VFOUTYP", 970);
        apiTGridH.AddColumn(Resources.col_reference, "VFOUREF", 930);
        apiTGridH.AddColumn(Resources.col_Prix_Client, "NFOUTAR", 700, "", 1);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "CLIENT", 0);
        apiTGridH.AddColumn("COUL", "NCODEG", 0);
        apiTGridH.AddColumn("NACTNUM", "NACTNUM", 0);

        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFind_Click_1(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      // on regarde les filtres et si aucun filtre, on affiche un message
      if (cboCritSerie.GetItemValue() == "" && txtCritMat.Text == "" && txtCritMarque.Text == "" && txtCritType.Text == "" && txtCritRef.Text == "")
      {
        MessageBox.Show("Il faut saisir au moins 1 critère de filtre", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      string lCriMat = (txtCritMat.Text == "") ? "T$" : txtCritMat.Text;
      string lCriMarque = (txtCritMarque.Text == "") ? "T$" : txtCritMarque.Text;
      string lCriTyp = (txtCritType.Text == "") ? "T$" : txtCritType.Text;
      string lCriRef = (txtCritRef.Text == "") ? "T$" : txtCritRef.Text;

      string lSql = $"EXEC api_sp_listeFouFac {MozartParams.NumDi}, {cboCritSerie.GetItemData()}, '{lCriMat}', '{lCriMarque}', '{lCriTyp}', '{lCriRef}'";

      apiTGridH.LoadData(dtListeFouFac, MozartDatabase.cnxMozart, lSql);

      Cursor.Current = Cursors.Default;
    }


    public void FormatGridArticle()
    {
      try
      {
        apiTGridB.AddColumn(Resources.col_Serie, "CCFOCOD", 1500);
        apiTGridB.AddColumn(Resources.col_materiel, "VFOUMAT", 5500);
        apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1400);
        apiTGridB.AddColumn(Resources.col_Prix_Client, "NFNFPRIXCLIENT", 1400, "currency", 1);
        apiTGridB.AddColumn(Resources.col_Qte, "NFNFQTE", 1000);
        apiTGridB.AddColumn("NFOUNUM", "NFOUNUM", 0);
        apiTGridB.AddColumn("NACTNUM", "NACTNUM", 0);
        apiTGridB.AddColumn(Resources.col_stock, "BSTOCK", 0);

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
          mfHT += Convert.ToSingle(Utils.ZeroIfNull(dc["NFNFPRIXCLIENT"]) * Utils.ZeroIfNull(dc["NFNFQTE"]));

        txtHT.Text = Strings.Format(mfHT.ToString(), "currency");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
	}
}