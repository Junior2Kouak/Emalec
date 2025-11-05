using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPrestationsDevisST : Form
  {
    public frmPrestationsDevisST() { InitializeComponent(); }

    public int miNumDevisST;
    public DataTable dtArticle;

    private DataTable dtPrest = new DataTable();

    private void frmPrestationsDevisST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        InitRecordsetPres();
        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtPrest.Rows.Count == 0) return;

        foreach (DataRow item in dtPrest.Select("COCHE = true"))
        {
          if (!DejaPresent(Convert.ToInt32(item["NLDCLPRESTID"])))
          {
            dtArticle.ImportRow(item);
            // Mettre une valeur (par défaut) à la colonne CMATFOURNI
            dtArticle.Rows[dtArticle.Rows.Count - 1]["CMATFOURNI"] = "NON";

            CalculTot();
          }
        }

        dtArticle.DefaultView.Sort = "CAT";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }

    private bool DejaPresent(long ID)
    {
      // on a le numArticle on regarde si il existe
      try
      {
        foreach (DataRow row in dtArticle.Rows)
          if (Convert.ToInt32(Utils.ZeroIfNull(row["NLDCLPRESTID"])) == ID) return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      //suppression de la ligne courante
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (row == null) return;

      row.Delete();
      dtArticle.AcceptChanges();

      CalculTot();
    }

    private void InitRecordsetPres()
    {

      apiTGridHaut.LoadData(dtPrest, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevisCL {miNumDevisST}");
      apiTGridHaut.GridControl.DataSource = dtPrest;

      // Ajouter une colonne pour la coche
      dtPrest.Columns.Add("COCHE", typeof(Boolean));

      foreach (DataRow item in dtPrest.Rows)
        item["COCHE"] = false;
    }

    private void InitialiserFeuille()
    {

      try
      {
        int numDevis = 0;
        // si il y a plusieurs devis client sur la DI, il faut faire choisir l'utilisateur (uniquement à la création)
        if (miNumDevisST == 0)
        {
          //recherche des devis prestation sur le DI
          string sSQL = $"SELECT distinct NDCLNUM from TDCL WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM=TDCL.NACTNUM " +
                        $" where ndinnum={MozartParams.NumDi} AND CDEVISTYPE = 'P' AND cdclactif='O'";
          string numDCL = "";
          int count = 0;

          using (SqlDataReader sdrA = ModuleData.ExecuteReader(sSQL))
          {
            // si plus d'un 
            while (sdrA.Read())
            {
              if (0 == count)
                numDevis = (int)Utils.ZeroIfBlank(sdrA["NDCLNUM"]);
              numDCL += "DC" + Utils.ZeroIfBlank(sdrA["NDCLNUM"]).ToString() + "-";
              count++;
            }
            if (count > 1)
            {
              numDevis = 0;
              string myValue = Interaction.InputBox($"Plusieurs devis clients existent sur la DI : \r\n{numDCL}\r\nSaisissez celui que vous voulez utiliser pour ce contrat.", "Mozaris");
              switch (myValue)
              {
                case "":
                  MessageBox.Show("Il faut choisir un devis client pour pouvoir faire un contrat de prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                default:
                  if (Strings.Left(myValue, 1).ToUpper() == "D") numDevis = Convert.ToInt32(Strings.Mid(myValue, 3));
                  else numDevis = Convert.ToInt32(myValue);
                  break;
              }
            }
          }
        }
        else
        {
          // il faut rechercher le numero de devis client que l'on a utilisé pour faire ce contrat
          // recherche des devis prestation sur la DI
          string sSQL = $"SELECT distinct NDCLNUM FROM TDSTPREST C INNER JOIN TLDCLPREST L ON L.NLDCLPRESTID = C.NLDCLPRESTID  " +
                        $" where NDSTNUM={miNumDevisST}";
          using (SqlDataReader sdrA = ModuleData.ExecuteReader(sSQL))
          {
            if (sdrA.Read())
              numDevis = (int)Utils.ZeroIfNull(sdrA["NDCLNUM"]);
          }
        }

        //  recherche liste des prestations sur les devis client de la DI
        apiTGridHaut.LoadData(dtPrest, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevisCL {numDevis}");
        apiTGridHaut.GridControl.DataSource = dtPrest;

        CalculTot();

        InitgridHaut();
        InitgridBas();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitgridHaut()
    {
      apiTGridHaut.AddColumn("ID", "NLDCLPRESTID", 0);
      apiTGridHaut.AddColumn("Choix", "COCHE", 300, "", 2, true, true, true);
      apiTGridHaut.AddColumn("Cat", "CAT", 700);
      apiTGridHaut.AddColumn("Prestation", "VPRESTLIB", 13000);
      apiTGridHaut.AddColumn("Uté", "VPRESTUNITE", 800, "", 2);
      apiTGridHaut.AddColumn("Qté", "NQTE", 800, "# ###", 2);
      apiTGridHaut.AddColumn("déboursé HT", "DEBOURSE", 1500, "Currency", 2);

      apiTGridHaut.DelockColumn("COCHE");
      foreach (DataRow item in dtPrest.Rows)
        item["COCHE"] = false;

      apiTGridHaut.InitColumnList();
    }

    private void InitgridBas()
    {
      apiTGridPrestSaisie.AddColumn("ID", "NLDCLPRESTID", 0);
      apiTGridPrestSaisie.AddColumn(Resources.col_Cat, "CAT", 700);
      apiTGridPrestSaisie.AddColumn(Resources.col_Prestation, "VPRESTLIB", 12000);
      apiTGridPrestSaisie.AddColumn(Resources.col_unite, "VPRESTUNITE", 660, "", 2);
      apiTGridPrestSaisie.AddColumn(Resources.col_qte3, "NQTE", 800, "", 2);
      apiTGridPrestSaisie.AddColumn("Mat fourni", "CMATFOURNI", 1220);
      apiTGridPrestSaisie.AddColumn("Débours unit", "DEBOURSUNIT", 1500, "Currency", 2);
      apiTGridPrestSaisie.AddColumn("déboursé HT", "DEBOURSE", 1500, "Currency", 2);

      apiTGridPrestSaisie.DelockColumn("CMATFOURNI");
      apiTGridPrestSaisie.DelockColumn("NQTE");
      apiTGridPrestSaisie.GridControl.DataSource = dtArticle;
      apiTGridPrestSaisie.InitColumnList();
    }

    private void apiTGridPrestSaisie_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      if ((e.Column.Name == "CMATFOURNI") || (e.Column.Name == "NQTE"))
      {
        e.Appearance.BackColor = Color.Orange;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private void apiTGridPrestSaisie_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (row == null) return;

      if (e.Column.Name == "CMATFOURNI")
      {
        GridView view = (GridView)sender;

        string val = e.Value.ToString().ToUpper();
        val = val == "O" ? "OUI" : "NON";

        view.SetRowCellValue(e.RowHandle, "CMATFOURNI", val);

        //  Recalcule...
        // 1er paramètre non utilisé
        using (IDataReader drD = ModuleData.ExecuteReader($"exec api_sp_calculeDeboursContratCST 0, {row["NLDCLPRESTID"]}, {val}"))
        {
          // On ramène le montant de débours
          if (drD.Read())
          {
            view.SetRowCellValue(e.RowHandle, "DEBOURSE", Utils.ZeroIfNull(drD["DEBOURSE"]));
            view.SetRowCellValue(e.RowHandle, "DEBOURSUNIT", Utils.ZeroIfNull(drD["DEBOURSEUNIT"]));
          }
        }

        CalculTot();
      }
    }

    private void apiTGridPrestSaisie_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (row == null) return;

      string nomCol = e.Column.Name;
      if (nomCol == "NQTE")
      {
        if (row["DEBOURSUNIT"].ToString() != "" && row["NQTE"].ToString() != "")
          row["DEBOURSE"] = Convert.ToDouble(row["DEBOURSUNIT"]) * Convert.ToDouble(row["NQTE"]);
        CalculTot();
      }

      if (nomCol == "CMATFOURNI")
        CalculTot();
    }

    private void CalculTot()
    {
      double totDebours = 0;
      foreach (DataRow item in dtArticle.Rows)
      {
        totDebours += Convert.ToDouble(item["DEBOURSE"]);
      }
      txtTDHT.Text = $"Total déboursé HT : {totDebours.ToString("C2")}";
    }
  }
}

