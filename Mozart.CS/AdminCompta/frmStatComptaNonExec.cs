using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmStatComptaNonExec : Form
  {
    DataTable dt = new DataTable();

    double total = 0;

    public frmStatComptaNonExec()
    {
      InitializeComponent();
    }

    private void frmStatComptaNonExec_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);
        txtDateA0.Text = DateTime.Now.ToShortDateString();
        Label3.Text = Resources.lbl_encoursClientsDateRefAvance;
        Label5.Text = $"(Pour {MozartParams.NomSociete}, si attachement)";
        //LoadGrid();
        InitapiGridH();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    private void CmdDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridH.GetFocusedDataRow();
      if (currentRow == null) return;

      //  écran de modification de la demande
      frmAddAction f = new frmAddAction() { mstrStatutDI = "M" };

      MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

      f.ShowDialog();

      //  on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }


    private void cmdVisuH_Click(object sender, EventArgs e)
    {
      try
      {
        string[,] TdbGlobal = new string[,] { { "Copie", "ORIGINAL"},
                                              { "Num", "2"},
                                              { "Titre", $"ENCOURS CLIENTS au {txtDateA0.Text}, en AVANCE." },
                                              { "Date",  DateTime.Now.ToShortDateString() },
                                              { "NB", dt.Rows.Count.ToString()},
                                              { "DateR", txtDateA0.ToString() },
                                              { "LIB", "FC-facture client" }      };

        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TEtatComptable.rtf",
                        @"TEtatComptableOut.rtf",
                        TdbGlobal,
                        $"exec api_sp_ListeEtatComptaNonExec '{txtDateA0.Text} 22:00:00'",
                        " (Impression consultation)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateA0.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateA0.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }


    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      ExecRequete();
      Cursor = Cursors.Default;
    }

    private void ExecRequete()
    {
      apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaNonExec '{txtDateA0.Text} 22:00:00'");
      apiTGridH.GridControl.DataSource = dt;

      total = 0;

      //pour toutes les lignes de la grid
      foreach (DataRow rowbis in dt.Rows)
        total += Utils.ZeroIfNull(rowbis[9]);

      lblTHTh.Text = Strings.FormatNumber(total, 0) + " €";
    }

    private void InitapiGridH()
    {
      try
      {
        apiTGridH.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 750);
        apiTGridH.AddColumn(Resources.col_Act, "NACTID", 750);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 750, "", 0, true);
        apiTGridH.AddColumn("Cte", "NDINCTE", 250, "", 0, true);
        apiTGridH.AddColumn(Resources.col_Chaff, "CHAFF", 750);
        apiTGridH.AddColumn(MZCtrlResources.Groupe, "LIBGROUPE", 750);
        apiTGridH.AddColumn(MZCtrlResources.col_libelle, "VACTDES", 750, "", 0, true);
        apiTGridH.AddColumn(Resources.col_etat, "CACTSTA", 750, "", 2); //attention, c'est le cetacod
        apiTGridH.AddColumn(MZCtrlResources.col_Date, "DACTDEX", 750);
        apiTGridH.AddColumn(Resources.col_Facture, "DFACDAT", 750, "dd/mm/yy");
        apiTGridH.AddColumn(Resources.col_euroHT, "NACTVAL", 1000, "0.00", 1);

        apiTGridH.FilterBar = true;
        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = true;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Frame4.Visible = false;
    }

    private void apiTGridH_ColumnFilterChanged(object sender, EventArgs e)
    {
      double total_filtered = 0;
      //calcul des montant filtred
      DataRow[] dt_filtered;

      DevExpress.Data.Filtering.CriteriaOperator oFilterCrit = apiTGridH.dgv.ActiveFilterCriteria;
      dt_filtered = dt.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(oFilterCrit));

      total_filtered = 0;
      foreach (DataRow rowbis in dt_filtered)
      {
        total_filtered += Utils.ZeroIfNull(rowbis[9]);
      }
      lblTHTh.Text = Strings.FormatNumber(total_filtered, 0) + " € / " + Strings.FormatNumber(total, 0) + " €";
    }

  }
}

