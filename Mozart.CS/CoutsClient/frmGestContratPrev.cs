using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestContratPrev : Form
  {
    private const string TXT_OUI = "O";
    private const string TXT_NON = "N";

    private DataTable dt = new DataTable();

    private int miCliNum;
    private string mCurNumPer;

    public frmGestContratPrev(int pNCliNum)
    {
      InitializeComponent();

      miCliNum = pNCliNum;
    }

    private void frmGestContratPrev_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitTGrid();

        cboTypeFact.Init(MozartDatabase.cnxMozart, $"SELECT NTREF_TYPFACT, VTREFLIB FROM TREF_TYPFACT ORDER BY NTREF_TYPFACT",
                        "NTREF_TYPFACT", "VTREFLIB", new List<string>() { Resources.col_Num, Resources.col_Contrat }, 250, 250);
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

    private void InitTGrid()
    {
      try
      {
        ApiGrid.AddColumn("Période", "NNUMPER", 600, "", 2);
        ApiGrid.AddColumn("Date début", "DDATEDEBUT", 700, "", 1);
        ApiGrid.AddColumn("Date fin", "DDATEFIN", 700, "", 1);
        ApiGrid.AddColumn("Type de facturation", "VTYPEFACT", 1200, "", 2);
        ApiGrid.AddColumn("Total préventif seul (Saisie manuelle)", "NTOTPREV", 2200, "Currency", 1);
        ApiGrid.AddColumn("Total préventif seul (Remontée DI)", "NTOTPREVDI", 2200, "Currency", 1);
        ApiGrid.AddColumn("Total contrat \"Facturation\" (Saisie manuelle)", "NTOTFACTMAN", 2500, "Currency", 1);
        ApiGrid.AddColumn("Total contrat \"Facturation\" (Remontée DI)", "NTOTCONTFACT", 2500, "Currency", 1);

        // Colonne non rattachée au datatable : Contient la diff entre Total préventif seul (Saisie manuelle) et Total contrat "Facturation"
        GridColumn ColonneResultats = new GridColumn
        {
          Caption = "Total curatif/fourn. seul (calcul)",
          FieldName = "DIFF",
          UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
          Visible = true,
          Width = 200
        };
        ColonneResultats.DisplayFormat.FormatType = FormatType.Numeric;
        ColonneResultats.DisplayFormat.FormatString = "c2";
        ApiGrid.dgv.Columns.Add(ColonneResultats);
        ApiGrid.dgv.Columns["DIFF"].OptionsColumn.AllowEdit = false;

        // Colonne non rattachée au datatable : Contient la diff entre Total préventif seul (Saisie manuelle) et Total contrat "Facturation"
        GridColumn ColonneRATIO = new GridColumn
        {
          Caption = "Ratio (Préventif seul / Total Facturation)",
          FieldName = "RATIO",
          UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
          Visible = true,
          Width = 200
        };
        ColonneRATIO.DisplayFormat.FormatType = FormatType.Numeric;
        ColonneRATIO.DisplayFormat.FormatString = "n2";
        ApiGrid.dgv.Columns.Add(ColonneRATIO);
        ApiGrid.dgv.Columns["RATIO"].OptionsColumn.AllowEdit = false;

        ApiGrid.dgv.CustomUnboundColumnData += (sender, e) =>
        {
          GridView view = sender as GridView;
          if (view == null) return;

          int rowIndex = e.ListSourceRowIndex;
          Decimal lDbl1 = 0;
          Decimal lDbl2 = 0;

          if (e.IsGetData)
          {
            switch (e.Column.FieldName)
            {
              case "DIFF":
                try { lDbl1 = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NTOTFACTMAN")); } catch (Exception) { };
                try { lDbl2 = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NTOTPREV")); } catch (Exception) { };

                e.Value = lDbl1 - lDbl2;
                break;

              case "RATIO":
                try { lDbl1 = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NTOTPREV")); } catch (Exception) { };
                try { lDbl2 = Convert.ToDecimal(view.GetListSourceRowCellValue(rowIndex, "NTOTFACTMAN")); } catch (Exception) { };

                e.Value = (lDbl2 == 0) ? 0 : lDbl1 / lDbl2;
                break;

              default:
                break;

            }
          }
        };

        ApiGrid.AddColumn("Actif", "CCONTRATPERACTIF", 450, "", 2);
        ApiGrid.AddColumn(Resources.col_typefac, "NTYPFACT", 0);

        ApiGrid.InitColumnList();

        fillApiGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void fillApiGrid()
    {
      string sSql;

      try
      {
        sSql = $"exec [api_sp_ListePeriodeContratPrev] {miCliNum}";
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
        ApiGrid.GridControl.DataSource = dt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // MAJ datarow
    private void cmdOK_Click(object sender, EventArgs e)
    {
      DateTime dDateDebut;
      DateTime dDateFin;

      DataRow lRow = ApiGrid.GetFocusedDataRow();
      if (lRow == null) return;

      try
      {
        // Validité des valeurs renseignées
        if (dateDebut.EditValue.ToString() == "")
        {
          MessageBox.Show("La date de début de période n'est pas renseignée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          dateDebut.Select();
          return;
        }

        if (dateFin.EditValue.ToString() == "")
        {
          MessageBox.Show("La date de fin de période n'est pas renseignée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          dateFin.Select();
          return;
        }

        dDateDebut = Convert.ToDateTime(dateDebut.EditValue);
        dDateFin = Convert.ToDateTime(dateFin.EditValue);
        if (dDateDebut > dDateFin)
        {
          MessageBox.Show(Resources.msg_dateFinInfDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        if (cboTypeFact.GetItemData() == -1)
        {
          MessageBox.Show("Le type de facturation n'est pas renseigné", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          cboTypeFact.Select();
          return;
        }

        if (txtTotPrevSeul.EditValue.ToString() == "")
        {
          MessageBox.Show("Le total préventif seul n'est pas renseigné", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtTotPrevSeul.Select();
          return;
        }

        if (txtTotContFactSaisieManuelle.EditValue.ToString() == "")
        {
          MessageBox.Show("Le total contrat \"Facturation\" n'est pas renseigné", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtTotContFactSaisieManuelle.Select();
          return;
        }

        // MAJ datarow
        lRow["DDATEDEBUT"] = dDateDebut;
        lRow["DDATEFIN"] = dateFin.EditValue;
        lRow["NTYPFACT"] = cboTypeFact.GetItemData();
        lRow["VTYPEFACT"] = cboTypeFact.GetText();
        lRow["NTOTPREV"] = txtTotPrevSeul.EditValue;
        lRow["NTOTFACTMAN"] = txtTotContFactSaisieManuelle.EditValue;
        if (chkActif.Checked)
        {
          lRow["CCONTRATPERACTIF"] = TXT_OUI;
        }
        else
        {
          lRow["CCONTRATPERACTIF"] = TXT_NON;
        }

        Frame2.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow lRow = ApiGrid.GetFocusedDataRow();
      if (lRow == null) return;

      lblPeriode.Text = "Période : " + lRow["NNUMPER"];
      dateDebut.EditValue = lRow["DDATEDEBUT"];
      dateFin.EditValue = lRow["DDATEFIN"];
      cboTypeFact.SetItemData(((int)Utils.ZeroIfNull(lRow["NTYPFACT"])));
      txtTotPrevSeul.EditValue = lRow["NTOTPREV"];
      txtTotPrevDI.EditValue = lRow["NTOTPREVDI"];
      txtTotContFact.EditValue = lRow["NTOTCONTFACT"];
      txtTotCurFourSeul.EditValue = ApiGrid.dgv.GetFocusedRowCellValue("DIFF");  // DIFF
      txtTotContFactSaisieManuelle.EditValue = lRow["NTOTFACTMAN"];
      txtRatio.EditValue = ApiGrid.dgv.GetFocusedRowCellValue("RATIO");  // RATIO

      mCurNumPer = lRow["NNUMPER"].ToString();

      if (lRow["CCONTRATPERACTIF"].ToString() == TXT_OUI)
      {
        chkActif.Checked = true;
      }
      else
      {
        chkInactif.Checked = true;
      }

      Frame2.Visible = true;
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
      Frame2.Visible = false;
    }

    private void cmdCalcTotalPrevSeulRemonteeDI_Click(object sender, EventArgs e)
    {
      string sSQL;

      // Calcul Total préventif seul(Remontée DI)
      try
      {
        if ((dateDebut.EditValue.ToString() == "") || (dateFin.EditValue.ToString() == ""))
        {
          MessageBox.Show("La période n'est pas renseignée.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        sSQL = "SELECT ISNULL(SUM(NACTVAL), 0) FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM";
        sSQL += " LEFT JOIN TCONTRATPER ON TCONTRATPER.NCLINUM = TDIN.NCLINUM AND TCONTRATPER.NCONTRATPERNUM = TDIN.NCONTRATPERNUM";
        sSQL += " WHERE CPRECOD = 'P' AND TDIN.NTYPECONTRAT <> 475"; // Contrat FACTURATION
        sSQL += $" AND TDIN.NCLINUM = {miCliNum} AND TCONTRATPER.NNUMPER = {mCurNumPer}";
        /*
         * 	SET NTOTPREVDI = (SELECT ISNULL(SUM(NACTVAL), 0)
	FROM TACT INNER JOIN TDIN ON TDIN.NDINNUM = TACT.NDINNUM
		LEFT JOIN TCONTRATPER ON TCONTRATPER.NCLINUM = TDIN.NCLINUM AND TCONTRATPER.NCONTRATPERNUM = TDIN.NCONTRATPERNUM
    WHERE CPRECOD = 'P' AND TDIN.NTYPECONTRAT <> 475	-- Contrat FACTURATION
		AND TDIN.NCLINUM = @iNumCli
		AND #tableres.NNUMPER = TCONTRATPER.NNUMPER
	GROUP BY NNUMPER)

         */
        double? lVal = (double)ModuleData.ExecuteScalarDouble(sSQL);
        txtTotPrevDI.Text = (lVal == null) ? 0.ToString() : lVal.ToString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // Test de la continuité des périodes dans la grille
    private bool datesOk()
    {
      DateTime lCurDateDebut;
      DateTime lCurDateFin;
      DateTime lDateFinPrec = DateTime.MaxValue;

      // Recherche dates min et max
      foreach (DataRow item in dt.Select("NTYPFACT <> 0"))
      {
        lCurDateDebut = Convert.ToDateTime(Utils.BlankIfNull(item["DDATEDEBUT"]));
        lCurDateFin = Convert.ToDateTime(Utils.BlankIfNull(item["DDATEFIN"]));

        if (lDateFinPrec == DateTime.MaxValue) lDateFinPrec = lCurDateDebut.AddDays(-1);

        if ((lCurDateDebut.Date - lDateFinPrec.Date).Days != 1)
        {
          return false;
        }

        lDateFinPrec = lCurDateFin;
      }

      return true;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (!datesOk())
      {
        MessageBox.Show("Les périodes ne sont pas contigües.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // MAJ des périodes
        SqlCommand command = new SqlCommand("UPDATE TCONTRATPER SET DDATEDEBUT = @DDATEDEBUT, DDATEFIN = @DDATEFIN, NTYPFACT = @NTYPFACT, NTOTFACTMAN = @NTOTFACTMAN," +
                                            $"NTOTPREV = @NTOTPREV,  CCONTRATPERACTIF = @CCONTRATPERACTIF WHERE NCLINUM = {miCliNum} AND NNUMPER = @NNUMPER", MozartDatabase.cnxMozart);
        command.Parameters.Add("@DDATEDEBUT", SqlDbType.DateTime);
        command.Parameters.Add("@DDATEFIN", SqlDbType.DateTime);
        command.Parameters.Add("@NTYPFACT", SqlDbType.Int);
        command.Parameters.Add("@NTOTPREV", SqlDbType.Decimal);
        command.Parameters.Add("@CCONTRATPERACTIF", SqlDbType.VarChar);
        command.Parameters.Add("@NNUMPER", SqlDbType.Int);
        command.Parameters.Add("@NTOTFACTMAN", SqlDbType.Decimal);

        foreach (DataRow item in dt.Select("NTYPFACT <> 0"))
        {
          command.Parameters["@DDATEDEBUT"].Value = item["DDATEDEBUT"];
          command.Parameters["@DDATEFIN"].Value = item["DDATEFIN"];
          command.Parameters["@NTYPFACT"].Value = item["NTYPFACT"];
          command.Parameters["@NTOTPREV"].Value = item["NTOTPREV"];
          command.Parameters["@CCONTRATPERACTIF"].Value = item["CCONTRATPERACTIF"];
          command.Parameters["@NNUMPER"].Value = item["NNUMPER"];
          command.Parameters["@NTOTFACTMAN"].Value = item["NTOTFACTMAN"];

          command.ExecuteNonQuery();
        }
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

    private void ApiGrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if ((e.Column.FieldName == "NTOTPREV") || (e.Column.FieldName == "NTOTPREVDI"))
      {
        GridView view = sender as GridView;

        double lTotalPrev = Utils.ZeroIfNull(view.GetRowCellValue(e.RowHandle, "NTOTPREV"));
        double lTotPrevDI = Utils.ZeroIfNull(view.GetRowCellValue(e.RowHandle, "NTOTPREVDI"));
        if (lTotalPrev != lTotPrevDI)
        {
          e.Appearance.BackColor = Color.Red;
        }
      }
    }

    private void calcTotaux(object sender, EventArgs e)
    {
      double lTotFact = 0.0;
      double lTotPrev = 0.0;

      try { lTotPrev = Utils.ZeroIfNull(txtTotPrevSeul.EditValue); } catch (Exception) { };
      try { lTotFact = Utils.ZeroIfNull(txtTotContFactSaisieManuelle.EditValue); } catch (Exception) { };

      txtTotCurFourSeul.EditValue = lTotFact - lTotPrev;
      txtRatio.EditValue = (lTotFact == 0) ? 0 : lTotPrev / lTotFact;
    }
  }
}