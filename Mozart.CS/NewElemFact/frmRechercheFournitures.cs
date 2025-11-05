using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmRechercheFournitures : Form
  {
    public int miNumClient;
    public string msNumClient;
    public DataTable mdtArticle;

    private DataTable dtListeFouFac = new DataTable();
    // DataTable privé pour ne pas modifier directement le datatable d'origine si on ne valide pas la saisie
    private DataTable dtArticle = new DataTable();


    public frmRechercheFournitures() { InitializeComponent(); }

    private void frmRechercheFournitures_Load(object sender, System.EventArgs e)
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
        FormatGridArticleB();

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


    private void cmdValider_Click(object sender, EventArgs e)
    {
      mdtArticle = dtArticle.Copy();
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      bool bOK = false;
      // test si l'enregistrement n'est pas déja selectionné
      // on a le numArticle on regarde si il existe

      DataRow rowH = apiTGridH.GetFocusedDataRow();
      if (rowH == null) return;

      try
      {
        foreach (DataRow itemArticle in dtArticle.Rows)
        {
          if (Convert.ToInt32(itemArticle["NumArticle"]) == Convert.ToInt32(rowH["NFOUNUM"]))
          {
            bOK = true;
            break;
          }
        }
        if (!bOK)
          AjouterEnreg(rowH);
        else
          MessageBox.Show(Resources.msg_article_already_in_list, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        RemplirTxtTotaux();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AjouterEnreg(DataRow row)
    {
      try
      {
        //  recherche du coefficient client à appliquer
        double dbCoefClient = RechercheCoef(MozartParams.NumDi, row["VFOUSER"].ToString());

        DataRow newrow = dtArticle.NewRow();

        newrow["Serie"] = Utils.BlankIfNull(row["VFOUSER"]);
        newrow["Article"] = Utils.BlankIfNull(row["VFOUMAT"]);
        newrow["Marque"] = Utils.BlankIfNull(row["VFOUMAR"]);
        newrow["Prix"] = row["NFOUTAR"];


        ////  Modif du 13/05/2016 : on recherche le prix max payé sur les 2 derniers mois et on le prend s'il n'y a pas de prix client fixe
        //object dPrixVente = ModuleData.ExecuteScalarObject($"api_sp_TrouvePrixVenteFouCli {miNumClient}, {row["NFOUNUM"]}");
        //if (dPrixVente != null)
        //{
        //  if (Convert.ToDouble(dPrixVente) > Convert.ToDouble(row["NFOUTAR"]) && row["PrixClient"].ToString() == "N")
        //  {
        //    newrow["Prix"] = dPrixVente; //  On substitue le prix...
        //    //newrow["Remarque"] = "Utilisation prix vente 2 derniers mois";  // On met un commentaire pour l'indiquer à l'utilisateur...
        //  }
        //}

        //  pas pour le client H&M  FG le 4/12/14
        //        if (row["CLIENT"].ToString() == "H&M")
        //         newrow["Recyclage"] = Utils.ZeroIfNull(row["Recyclage"]);
        //       else
        newrow["Recyclage"] = Utils.ZeroIfNull(row["RecyclageVente"]) == 0 ? Utils.ZeroIfNull(row["Recyclage"]) : Utils.ZeroIfNull(row["RecyclageVente"]);
        newrow["oldPrix"] = newrow["Prix"];
        newrow["Fournisseurs"] = "";
        newrow["NumFour"] = 0;
        newrow["NumArticle"] = row["NFOUNUM"];
        newrow["Quantite"] = 1;
        newrow["CoefClient"] = dbCoefClient;
        newrow["colImmo"] = false;
        newrow["colStock"] = false;

        dtArticle.Rows.Add(newrow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private double RechercheCoef(long iNumDi, string sCodeCat)
    {
      double dCoef = 3;
      object o = ModuleData.ExecuteScalarObject($"exec api_sp_RetourCoefClient {MozartParams.NumDi}, '{sCodeCat}'");
      if (o == null)
        MessageBox.Show(Resources.msg_client_has_no_coef_vente + "\r\n" + Resources.msg_apply_coef_3);
      else
        dCoef = Convert.ToDouble(o);

      return dCoef;
    }

    private void CmdLegende_Click(object sender, EventArgs e)
    {
      Frame3.Visible = !Frame3.Visible;
    }

    private void CmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression de la ligne courante
        DataRow row = apiTGridB.GetFocusedDataRow();
        if (row == null) return;

        row.Delete();
        dtArticle.AcceptChanges();

        RemplirTxtTotaux();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridH()
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

      apiTGridH.InitColumnList();

    }

    private void apiTGridH_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView View = sender as GridView;

        if (View.GetDataRow(e.RowHandle)["CODE"].ToString().ToUpper() == "O")
          e.Appearance.BackColor = MozartColors.colorHDBE6FD;

        if (View.GetDataRow(e.RowHandle)["NCODEG"].ToString() == "1")
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

        if (View.GetDataRow(e.RowHandle)["NCODEG"].ToString() == "2")
          e.Appearance.ForeColor = Color.Red;

        if (View.GetDataRow(e.RowHandle)["NCODEG"].ToString() == "3")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.Appearance.ForeColor = Color.Red;
        }

        e.HighPriority = true;
      }
    }

    private void FormatGridArticleB()
    {
      apiTGridB.AddColumn(Resources.col_Article, "Article", 3000);
      apiTGridB.AddColumn(Resources.col_marque, "Marque", 1400);
      apiTGridB.AddColumn(Resources.col_Prix_Client, "Prix", 700, "", 1);
      apiTGridB.AddColumn(Resources.col_Qte, "Quantite", 500, "", 1);

      apiTGridB.DelockColumn("Prix");
      apiTGridB.DelockColumn("Quantite");

      // Champ calculé dans la procstock dont ReadOnly, d'ou forcage
      dtArticle.Columns["Prix"].ReadOnly = false;

      // Modifier le prix pour éviter les 10 chiffres après la virgule

      //foreach (DataRow item in dtArticle.Rows)
      //{ item["Prix"] = Convert.ToDouble(Strings.Format(item["Prix"], "Currency").Replace(" €", "")); }

      apiTGridB.InitColumnList();
    }

    private void apiTGridH_DoubleClickE(object sender, EventArgs e)
    {
      cmdAjouter_Click(sender, e);
    }

    private void apiTGridB_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      RemplirTxtTotaux();
    }

    private void apiTGridB_ValidateRowE(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      GridColumn inPrixCol = apiTGridB.dgv.Columns["Prix"];
      double indPrix = Convert.ToDouble(apiTGridB.dgv.GetRowCellValue(e.RowHandle, inPrixCol));
      GridColumn inOldPrixCol = apiTGridB.dgv.Columns["oldPrix"];
      if (apiTGridB.dgv.GetRowCellValue(e.RowHandle, inOldPrixCol) != DBNull.Value)
      {
        double indOldPrix = Convert.ToDouble(apiTGridB.dgv.GetRowCellValue(e.RowHandle, inOldPrixCol));
        if (indOldPrix > indPrix)
        {
          e.Valid = false;
          apiTGridB.dgv.SetColumnError(inPrixCol, "Impossible de diminuer le prix !");
        }
      }
    }

    private void cmdFind_Click(object sender, EventArgs e)
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

    private void frmRechercheFournitures_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)  //|| e.KeyCode == Keys.Enter mis en com le 03/08/22
        cmdFind_Click(null, null);
    }

    private void RemplirTxtTotaux()
    {
      double dTotal = 0;

      foreach (DataRow item in dtArticle.Rows)
        dTotal += Utils.ZeroIfNull(item["Prix"]) * Utils.ZeroIfNull(item["Quantite"]);

      txtHT.Text = Strings.Format(dTotal, "currency");
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}