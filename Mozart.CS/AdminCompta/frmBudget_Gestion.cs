using DevExpress.DataAccess.Excel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.Data;
using MozartLib;

namespace MozartCS.AdminCompta
{
  public partial class frmBudget_Gestion : Form
  {

    private DataTable dt = new DataTable();

    public frmBudget_Gestion()
    {
      InitializeComponent();
    }

    private void frmBudget_Gestion_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
    }

    private void LoadData()
    {
      if (DateEditAnnee.EditValue != null)
      {
        ModuleData.LoadData(dt, $"EXEC [api_sp_Budget_Gestion_Liste] {((DateTime)DateEditAnnee.EditValue).Year}");
        dt.Columns["NOBJCA"].ReadOnly = false;
        dt.Columns["NOBJRESULTANA_MTT"].ReadOnly = false;
        dt.Columns["NOBJRESULTANA_PC"].ReadOnly = false;
        dt.Columns["NBUDGETCA"].ReadOnly = false;
        dt.Columns["NBUDGETRESULTANA_MTT"].ReadOnly = false;
        dt.Columns["NBUDGETRESULTANA_PC"].ReadOnly = false;
        dt.Columns["VCOMMENTAIRES"].ReadOnly = false;

        GCBudget.DataSource = dt;
      }
    }

    private void BtnValid_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    private void BGV_Budget_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      GridView View = sender as GridView;
      switch (e.Column.FieldName)
      {
        case "NOBJCA":
        case "NOBJRESULTANA_PC":

          DataRow DRUpdate = View.GetDataRow(e.RowHandle);

          if (DRUpdate["NOBJRESULTANA_PC"].ToString() == "" || DRUpdate["NOBJCA"].ToString() == "") return;

          decimal Val_PC = (decimal)View.GetRowCellValue(e.RowHandle, "NOBJRESULTANA_PC") / 100;
          decimal Val_Cell = Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, "NOBJCA"));
          DRUpdate["NOBJRESULTANA_MTT"] = (Val_Cell * Val_PC);
          View.UpdateCurrentRow();
          break;

        case "NBUDGETCA":
        case "NBUDGETRESULTANA_PC":
          DataRow DRUpdate2 = View.GetDataRow(e.RowHandle);

          if (DRUpdate2["NBUDGETRESULTANA_PC"].ToString() == "" || DRUpdate2["NBUDGETCA"].ToString() == "") return;

          decimal Val_PC2 = (decimal)View.GetRowCellValue(e.RowHandle, "NBUDGETRESULTANA_PC") / 100;
          decimal Val_Cell2 = Convert.ToDecimal(View.GetRowCellValue(e.RowHandle, "NBUDGETCA"));
          DRUpdate2["NBUDGETRESULTANA_MTT"] = (Val_Cell2 * Val_PC2);
          View.UpdateCurrentRow();
          break;

      }

      BGV_Budget.PostEditor();
      GCBudget.Refresh();

    }

    private void BtnSave_Click(object sender, EventArgs e)
    {

      Cursor = Cursors.WaitCursor;

      SqlCommand sqlcmd;

      foreach (DataRow DrSave in dt.Rows)
      {

        sqlcmd = new SqlCommand("[api_sp_Budget_Gestion_Save]", MozartDatabase.cnxMozart)
        {
          CommandType = CommandType.StoredProcedure
        };
        SqlCommandBuilder.DeriveParameters(sqlcmd);
        sqlcmd.Parameters["@P_NID_BUDGET_GESTION"].Value = DrSave["NID_BUDGET_GESTION"];
        sqlcmd.Parameters["@P_NANNEE"].Value = ((DateTime)DateEditAnnee.EditValue).Year;
        sqlcmd.Parameters["@P_NCANNUM"].Value = DrSave["NCANNUM"];
        sqlcmd.Parameters["@P_NOBJCA"].Value = DrSave["NOBJCA"];
        sqlcmd.Parameters["@P_NOBJRESULTANA_MTT"].Value = DrSave["NOBJRESULTANA_MTT"];
        sqlcmd.Parameters["@P_NOBJRESULTANA_PC"].Value = DrSave["NOBJRESULTANA_PC"];
        sqlcmd.Parameters["@P_NBUDGETCA"].Value = DrSave["NBUDGETCA"];
        sqlcmd.Parameters["@P_NBUDGETRESULTANA_PC"].Value = DrSave["NBUDGETRESULTANA_PC"];
        sqlcmd.Parameters["@P_NBUDGETRESULTANA_MTT"].Value = DrSave["NBUDGETRESULTANA_MTT"];
        sqlcmd.Parameters["@P_VCOMMENTAIRES"].Value = DrSave["VCOMMENTAIRES"];
        sqlcmd.Parameters["@P_VSOCIETE"].Value = DrSave["VSOCIETE"];

        sqlcmd.ExecuteNonQuery();
      }

      //reload
      LoadData();

      Cursor = Cursors.Default;

      MessageBox.Show("Enregistrement terminé avec succès", "Confimation", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnSaisonnalite_Click(object sender, EventArgs e)
    {
      new frmBudget_Saison().ShowDialog();
    }

    private void BtnImportXLS_Click(object sender, EventArgs e)
    {

      if (DateEditAnnee.EditValue == null)
      {
        MessageBox.Show("Il faut sélectionner une année", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (MessageBox.Show($"L'import du fichier va écraser les valeurs déjà saisies manuellement. Souhaitez-vous continuer ?" +
                         $"{Environment.NewLine}POUR RAPPEL :{Environment.NewLine}" +
                         $"La colonne A doit correspondre au compte analytique et la celulle A1 doit être nommée 'Compte Analytique'{Environment.NewLine}" +
                         $"La colonne B doit correspondre au compte analytique et la celulle A1 doit être nommée 'CA OBJECTIF'{Environment.NewLine}" +
                         $"La colonne C doit correspondre au compte analytique et la celulle A1 doit être nommée 'Résultat ana objectif (en %)'{Environment.NewLine}" +
                         $"La colonne D doit correspondre au compte analytique et la celulle A1 doit être nommée 'CA BUDGET'{Environment.NewLine}" +
                         $"La colonne E doit correspondre au compte analytique et la celulle A1 doit être nommée 'Résultat ana budget (en %)'", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
      {
        return;
      }

      OFD.Filter = "Fichiers XLSX | *.XLSX";
      OFD.ShowDialog();

      if (OFD.FileName != "")
      {
        ExcelDataSource source = new ExcelDataSource
        {
          FileName = OFD.FileName
        };
        var worksheetSettings = new ExcelWorksheetSettings("Feuil1", "A1:E2000");
        source.SourceOptions = new ExcelSourceOptions(worksheetSettings);
        source.Fill();
        DataTable DtImport = ExcelDataSourceExtension.ToDataTable(source);

        try
        {
          if (DtImport == null)
          {
            MessageBox.Show("Le fichier n'est pas conforme !", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          if (DtImport.Rows.Count == 0)
          {
            MessageBox.Show("Le fichier ne contient pas de lignes", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //test nom des colonnes
          Int16 i = 0;
          foreach (DataColumn Col in DtImport.Columns)
          {
            switch (i)
            {
              case 0:
                if (Col.ColumnName != "Compte Analytique")
                {
                  MessageBox.Show("Le libellé A1 ne correspond pas = 'Compte Analytique'", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                break;
              case 1:
                if (Col.ColumnName != "CA OBJECTIF")
                {
                  MessageBox.Show("Le libellé B1 ne correspond pas = 'CA OBJECTIF'", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                break;
              case 2:
                if (Col.ColumnName != "Résultat ana objectif (en %)")
                {
                  MessageBox.Show("Le libellé C1 ne correspond pas = 'Résultat ana (en %)'", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                break;
              case 3:
                if (Col.ColumnName != "CA BUDGET")
                {
                  MessageBox.Show("Le libellé D1 ne correspond pas = 'CA BUDGET'", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                break;
              case 4:
                if (Col.ColumnName != "Résultat ana budget (en %)")
                {
                  MessageBox.Show("Le libellé E1 ne correspond pas = 'Résultat ana (en %)'", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }
                break;
            }
            i += 1;
          }

          int nOut_NCANNUM;
          int nOut_CA_OBJ;
          decimal nOut_ResultAna_Obj;
          int nOut_CA_BUDG;
          decimal nOut_ResultAna_Budg;


          //on parcours la datatble
          foreach (DataRow drImport in DtImport.Rows)
          {

            //on recherche son compte analyitque
            //test si compte en numeric
            if (Int32.TryParse(drImport[0].ToString(), out nOut_NCANNUM) && Int32.TryParse(drImport[1].ToString(), out nOut_CA_OBJ) &&
                  Decimal.TryParse(drImport[2].ToString(), out nOut_ResultAna_Obj) && Int32.TryParse(drImport[3].ToString(), out nOut_CA_BUDG) &&
                  Decimal.TryParse(drImport[4].ToString(), out nOut_ResultAna_Budg))
            {
              DataRow[] tabRowToUpdate = dt.Select($"[NCANNUM] = {drImport[0]}");

              foreach (DataRow DrUpdate in tabRowToUpdate)
              {
                DrUpdate["NOBJCA"] = drImport[1];  //CA IBJ
                DrUpdate["NOBJRESULTANA_PC"] = drImport[2];  //Result anan % OBJ
                DrUpdate["NOBJRESULTANA_MTT"] = (int)DrUpdate["NOBJCA"] * ((decimal)DrUpdate["NOBJRESULTANA_PC"] / 100);
                DrUpdate["NBUDGETCA"] = drImport[3];  //CA BUDG
                DrUpdate["NOBJRESULTANA_PC"] = drImport[2];  //Result anan % OBJ
                DrUpdate["NBUDGETRESULTANA_PC"] = drImport[4];   //RESULT ANA % BUDG
                DrUpdate["NBUDGETRESULTANA_MTT"] = (int)DrUpdate["NBUDGETCA"] * ((decimal)DrUpdate["NBUDGETRESULTANA_PC"] / 100);
              }
            }

            BGV_Budget.UpdateCurrentRow();
            BGV_Budget.PostEditor();
            GCBudget.Refresh();
          }
        }
        catch
        {
          MessageBox.Show("ERREUR : Le fichier n'est pas conforme à l'importation !", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void BGV_Budget_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
    {
      double lTmpValue;

      string lItemColName = ((GridSummaryItem)e.Item).Tag.ToString();

      if (e.SummaryProcess == CustomSummaryProcess.Finalize)
      {
        switch (lItemColName)
        {
          case "NOBJRESULTANA_PC":
            lTmpValue = Convert.ToDouble(GCol_NOBJCA.SummaryItem.SummaryValue);
            if (lTmpValue == 0)
            {
              e.TotalValue = 0;

            }
            else
            {
              e.TotalValue = 100.0 * Convert.ToDouble(GCol_NOBJRESULTANA_MTT.SummaryItem.SummaryValue) / lTmpValue;
            }
            break;

          case "NBUDGETRESULTANA_PC":
            lTmpValue = Convert.ToDouble(GCol_NBUDGETCA.SummaryItem.SummaryValue);
            if (lTmpValue == 0)
            {
              e.TotalValue = 0;

            }
            else
            {
              e.TotalValue = 100.0 * Convert.ToDouble(GCol_NBUDGETRESULTANA_MTT.SummaryItem.SummaryValue) / lTmpValue;
            }
            break;
        }
      }
    }
  }
}
