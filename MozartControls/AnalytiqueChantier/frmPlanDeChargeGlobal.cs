using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// NOTE AUX DEV : Cette forme est mise ici car sinon pour l'appeler depuis le projet VB.NET, il faudrait migrer toutes les forms en C# appelantes

namespace MozartControls
{
  public partial class frmPlanDeChargeGlobal : Form
  {
    private const string INTITULE_CAPA = "CAPACITE INTERNE";
    private const string INTITULE_TX_CHARGE = "TAUX DE CHARGE (%)";
    private const string INTITULE_TX_CHARGE_AN = "TAUX DE CHARGE annuel (%)";

    private const string COL_CHIFFRAGE = "NHDEVIS";
    private const string COL_NHTOT = "NHTOT";
    private const string COL_NVAL_A = "NVAL_A";
    private const string COL_FIRST_NVAL_A = "NVAL_A1_M1";

    // Width des colonnes contenant les infos par mois
    private const int COLMONTH_WIDTH = 42;

    private DataTable mDatas = new DataTable();
    // Le row pour afficher la capacité interne
    private DataRow mCapaInterne;
    private DataSet mDataSet = new DataSet();

    // Contient un tableau (max 3 éléments car 3 années différentes peuvent être affichées au max ...) du nb de mois par année chargée
    private int[] mNbMoisCharge = new int[3];

    public frmPlanDeChargeGlobal()
    {
      InitializeComponent();

      // Init du prévisionnel
      initGridPrevisionnel();
    }

    private void frmPlanDeChargeGlobal_Load(object sender, EventArgs e)
    {
      String sSQL = $"api_sp_ChantierPlanningGlobal2 'O', '{MozartParams.NomSociete}', '{DateTime.Now}'";
      using (SqlCommand CmdSql = new SqlCommand(sSQL, MozartDatabase.cnxMozart)
      {
        CommandType = CommandType.Text
      })
      {
        using (SqlDataAdapter da = new SqlDataAdapter(CmdSql))
        {
          mDataSet.Clear();
          da.Fill(mDataSet);
        }
      }

      mDatas = mDataSet.Tables[0];
      mCapaInterne = mDataSet.Tables[1].Rows[0];
      gridPlanning.DataSource = mDatas;
    }

    private void initGridPrevisionnel()
    {
      GridBand lCurrentYearBand = null;

      bandChargePrevisionnelle.Width = 24 * COLMONTH_WIDTH;

      DateTime lStartDate = DateTime.Now;
      lStartDate = new DateTime(lStartDate.Year, lStartDate.Month, 1);
      DateTime lEndDate = lStartDate.AddMonths(24);
      int lCurrentYear = 0;

      DateTime lCurrent = lStartDate;
      int annee = 1;
      int mois = 1;
      int lCount = 0;
      int lNbMois = 0;
      while (lCurrent < lEndDate)
      {
        if (lCurrentYear != lCurrent.Year)
        {
          // Changement d'année : On recrée un nouveau bandeau
          lCurrentYearBand = createYear(lCurrent);
          lCurrentYear = lCurrent.Year;

          if (lNbMois != 0)
          {
            mNbMoisCharge[lCount] = lNbMois;
            lCount++;
            lNbMois = 0;
          }
        }

        //Console.Out.WriteLine($"{lCurrent} : {annee} - {mois}");
        BandedGridColumn lMonth = createMonth(lCurrent, annee, mois);
        lCurrentYearBand.Columns.Add(lMonth);

        lCurrent = lCurrent.AddMonths(1);
        if (mois == 12)
        {
          annee++;
          mois = 1;
        }
        else
        {
          mois++;
        }

        lNbMois++;
      }

      mNbMoisCharge[lCount] = lNbMois;

      // Fixe largeur + alignement des colonnes de charges prévisionnelles
      foreach (GridBand lCurBand in bandChargePrevisionnelle.Children)
      {
        lCurBand.Width = lCurBand.Columns.Count * COLMONTH_WIDTH;

        foreach (BandedGridColumn lcurCol in lCurBand.Columns)
        {
          lcurCol.Width = COLMONTH_WIDTH;
          lcurCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
      }
    }

    // Ajoute et retourne un bandeau année dans le prévisionnel
    private GridBand createYear(DateTime pDate)
    {
      GridBand lNewYearBand = new GridBand();
      lNewYearBand.AppearanceHeader.Options.UseTextOptions = true;
      lNewYearBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      lNewYearBand.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      lNewYearBand.Caption = pDate.Year.ToString();
      lNewYearBand.VisibleIndex = bandChargePrevisionnelle.Children.Count;

      lNewYearBand.AppearanceHeader.BackColor = bandChargePrevisionnelle.AppearanceHeader.BackColor;
      lNewYearBand.AppearanceHeader.ForeColor = bandChargePrevisionnelle.AppearanceHeader.ForeColor;
      lNewYearBand.AppearanceHeader.BorderColor = bandChargePrevisionnelle.AppearanceHeader.BorderColor;
      lNewYearBand.AppearanceHeader.Options.UseBorderColor = bandChargePrevisionnelle.AppearanceHeader.Options.UseBorderColor;
      lNewYearBand.AppearanceHeader.Options.UseBackColor = bandChargePrevisionnelle.AppearanceHeader.Options.UseBackColor;
      lNewYearBand.AppearanceHeader.Options.UseForeColor = bandChargePrevisionnelle.AppearanceHeader.Options.UseForeColor;

      bandChargePrevisionnelle.Children.Add(lNewYearBand);

      return lNewYearBand;
    }

    // Créé un bandeau pour un mois
    // annee, mois utilisé pour créer le nom du champ de BdD
    private BandedGridColumn createMonth(DateTime pDate, int annee, int mois)
    {
      string lFieldName = $"{COL_NVAL_A}{annee}_M{mois}";

      BandedGridColumn lNewMonthColumn = new BandedGridColumn
      {
        Caption = pDate.Month.ToString(),
        Visible = true,
        Width = COLMONTH_WIDTH,
        FieldName = lFieldName
      };

      lNewMonthColumn.Summary.Add(SummaryItemType.Sum, lFieldName, "{0}");  // Charge
      lNewMonthColumn.Summary.Add(SummaryItemType.Custom, lFieldName, "{0}");  // CAPACITE INTERNE
      lNewMonthColumn.Summary.Add(SummaryItemType.Custom, lFieldName, "{0}");  // TAUX DE CHARGE (%)
      lNewMonthColumn.Summary.Add(SummaryItemType.Custom, lFieldName, "{0}");  // TAUX DE CHARGE annuel (%)

      lNewMonthColumn.AppearanceHeader.BackColor = bandChargePrevisionnelle.AppearanceHeader.BackColor;
      lNewMonthColumn.AppearanceHeader.ForeColor = bandChargePrevisionnelle.AppearanceHeader.ForeColor;
      lNewMonthColumn.AppearanceHeader.BorderColor = bandChargePrevisionnelle.AppearanceHeader.BorderColor;
      lNewMonthColumn.AppearanceHeader.Options.UseBorderColor = bandChargePrevisionnelle.AppearanceHeader.Options.UseBorderColor;
      lNewMonthColumn.AppearanceHeader.Options.UseBackColor = bandChargePrevisionnelle.AppearanceHeader.Options.UseBackColor;
      lNewMonthColumn.AppearanceHeader.Options.UseForeColor = bandChargePrevisionnelle.AppearanceHeader.Options.UseForeColor;

      lNewMonthColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;

      lNewMonthColumn.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      lNewMonthColumn.OptionsFilter.AllowFilter = false;
      bandedGridView1.Columns.Add(lNewMonthColumn);

      return lNewMonthColumn;
    }

    private void BtnExportXLS_Click(object sender, EventArgs e)
    {
      SaveFileDialog SFD = new SaveFileDialog
      {
        Filter = "Fichiers XLSX |*.XLSX"
      };
      SFD.ShowDialog();

      if (SFD.FileName != "")
      {
        gridPlanning.ExportToXlsx(SFD.FileName);
      }
    }

    private void bandedGridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.Column.FieldName == COL_NHTOT)
      {
        int lChiffrage = 0;
        int lTotal = 0;

        BandedGridView view = sender as BandedGridView;

        try { lChiffrage = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, COL_CHIFFRAGE)); } catch (Exception) { };
        try { lTotal = Convert.ToInt32(e.CellValue); } catch (Exception) { };

        e.Appearance.ForeColor = (lTotal > lChiffrage) ? Color.Red : Color.ForestGreen;
      }
    }

    private void bandedGridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
    {
      BandedGridView view = sender as BandedGridView;
      GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;

      // Une cellule vide veut dire qu'il ne faut pas l'afficher :)
      if (e.Info.SummaryItem.DisplayFormat == "")
      {
        e.Handled = true;
        return;
      }

      // Draw les intitulés des capa + taux de charge
      if (e.Info.DisplayText.StartsWith(INTITULE_CAPA) || e.Info.DisplayText.StartsWith(INTITULE_TX_CHARGE) || e.Info.DisplayText.StartsWith(INTITULE_TX_CHARGE_AN))
      {
        GridColumnInfoArgs columnInfo = viewInfo.ColumnsInfo[e.Column];
        BandedGridColumn lChifColumn = view.Columns[COL_CHIFFRAGE];
        GridColumnInfoArgs chiffrageColumnInfo = viewInfo.ColumnsInfo[lChifColumn];

        if (columnInfo != null)
        {
          // 4 = 4 Colonnes d'heures de taille identique
          e.Info.Bounds = new Rectangle(chiffrageColumnInfo.Bounds.X + 1, e.Info.Bounds.Y, 4 * columnInfo.Bounds.Width - 3, e.Info.Bounds.Height);
          e.DefaultDraw();
          e.Handled = true;
          return;
        }
      }

      // Calcul des charges
      if (e.Column.FieldName == COL_NHTOT)
      {
        // Couleur pour le taux de charge (%)
        try
        {
          e.Appearance.ForeColor = (Convert.ToInt32(e.Info.DisplayText) < 100) ? Color.Red : Color.ForestGreen;
        }
        catch (Exception)
        {
        }

        e.DefaultDraw();
        e.Handled = true;
      }

      if (e.Column.FieldName.StartsWith(COL_NVAL_A))
      {
        switch (e.Info.SummaryItem.Index)
        {
          case 1:
            //e.Info.DisplayText = mCapaInterne[e.Column.FieldName].ToString();
            break;

          case 2:
            try
            {
              e.Appearance.ForeColor = (Convert.ToInt32(e.Info.DisplayText) < 100) ? Color.Red : Color.ForestGreen;
            }
            catch (Exception)
            {
            }
            break;

          case 3:
            GridColumnInfoArgs lColumnInfo = viewInfo.ColumnsInfo.Find(c => (c.Column != null) && (c.Column.FieldName == COL_FIRST_NVAL_A));
            int lIndex1stCol = viewInfo.ColumnsInfo.IndexOf(lColumnInfo);

            GridColumnInfoArgs columnInfo = viewInfo.ColumnsInfo[e.Column];
            int lIndex = viewInfo.ColumnsInfo.IndexOf(columnInfo);

            int lStartIndex;

            for (int i = 0; i < mNbMoisCharge.Length; i++)
            {
              // Selon l'année recherchée, on doit ajouter à l'index de la 1ère colonne les index des années précédentes
              switch (i)
              {
                case 1:
                  lStartIndex = lIndex1stCol + mNbMoisCharge[0];
                  break;

                case 2:
                  lStartIndex = lIndex1stCol + mNbMoisCharge[0] + mNbMoisCharge[1];
                  break;

                default:
                  // Index 0 et par défaut
                  lStartIndex = lIndex1stCol;
                  break;
              }

              if ((lIndex - lStartIndex + 1) == mNbMoisCharge[i])
              {
                // On est sur la colonne du dernier mois de l'année recherchée
                GridColumnInfoArgs l1stCol = viewInfo.ColumnsInfo.ElementAt(lStartIndex);
                //Console.WriteLine(lIndex - mNbMoisCharge[i] + 1);

                e.Appearance.ForeColor = (Convert.ToInt32(e.Info.DisplayText) < 100) ? Color.Red : Color.ForestGreen;
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                e.Info.Bounds = new Rectangle(l1stCol.Bounds.X + 1, e.Info.Bounds.Y, mNbMoisCharge[i] * columnInfo.Bounds.Width - 3, e.Info.Bounds.Height);
                e.DefaultDraw();
                e.Handled = true;
              }
            }

            break;
        }
      }
    }

    private void bandedGridView1_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
    {
      BandedGridView view = sender as BandedGridView;
      GridSummaryItem item = e.Item as GridSummaryItem;
      BandedGridColumn lCurColumn;
      GridColumnSummaryItem lItem;

      if (e.IsTotalSummary && item.FieldName.StartsWith(COL_NVAL_A))
      {
        switch (e.SummaryProcess)
        {
          case CustomSummaryProcess.Start:
            break;

          case CustomSummaryProcess.Calculate:
            break;

          case CustomSummaryProcess.Finalize:
            switch (item.Index)
            {
              case 1:
                e.TotalValue = mCapaInterne[item.FieldName];
                break;

              case 2:
                lCurColumn = view.Columns[item.FieldName];
                lItem = lCurColumn.Summary[0];

                int lCharge = Convert.ToInt32(lItem.SummaryValue);
                int lCapaInterne = Convert.ToInt32(mCapaInterne[item.FieldName]);

                e.TotalValue = (lCapaInterne == 0) ? 0 : (int)(100.00 * lCharge / lCapaInterne);
                break;

              case 3:
                int lIndex1stCol = view.Columns.IndexOf(view.Columns.ColumnByFieldName(COL_FIRST_NVAL_A));

                int lIndex = view.Columns.IndexOf(view.Columns[item.FieldName]);
                int lStartIndex;

                for (int i = 0; i < mNbMoisCharge.Length; i++)
                {
                  // Selon l'année recherchée, on doit ajouter à l'index de la 1ère colonne les index des années précédentes
                  switch (i)
                  {
                    case 1:
                      lStartIndex = lIndex1stCol + mNbMoisCharge[0];
                      break;

                    case 2:
                      lStartIndex = lIndex1stCol + mNbMoisCharge[0] + mNbMoisCharge[1];
                      break;

                    default:
                      // Index 0 et par défaut
                      lStartIndex = lIndex1stCol;
                      break;
                  }

                  if ((lIndex - lStartIndex + 1) == mNbMoisCharge[i])
                  {
                    // Calcul de la moyenne
                    int lMoy = 0;
                    for (int j = 0; j < mNbMoisCharge[i]; j++)
                    {
                      lCurColumn = (BandedGridColumn)view.Columns.ElementAt(lIndex - j);
                      lItem = lCurColumn.Summary[2];

                      //Console.WriteLine($"{i} : {lIndex - j} " + lItem.FieldName + $" : {lItem.SummaryValue}");

                      lMoy += Convert.ToInt32(lItem.SummaryValue);
                      //Console.WriteLine(lMoy);
                    }

                    e.TotalValue = (mNbMoisCharge[i] != 0) ? (lMoy / mNbMoisCharge[i]) : 0;
                  }
                }

                break;

              default:
                break;
            }
            break;
        }
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
