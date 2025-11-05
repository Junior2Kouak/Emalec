using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmStatPrestationNF : Form
  {
    DataTable dt = new DataTable();
    private SqlDataAdapter daAC = new SqlDataAdapter();
    private readonly SqlCommandBuilder cbAC = new SqlCommandBuilder();

    DataTable dtAC = new DataTable();

    private long miNumClient;

    public frmStatPrestationNF()
    {
      InitializeComponent();
    }

    private void frmStatFourNF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        txtDateA0.Text = DateTime.Now.AddYears(-1).ToShortDateString();
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        InitApigrid();
        InitGrids();

        apiTGridFouNF.dgv.ColumnFilterChanged += new EventHandler(apiTGridFouNF_ColumnFilterChanged);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdValid_Click(object sender, System.EventArgs e)
    {
      string sSQL = $"api_sp_StatChiffragesNF '{txtDateA0.Text}' , '{txtDateA1.Text}'";

      apiTGridFouNF.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiTGridFouNF.GridControl.DataSource = dt;

      // sélectionner une ligne
      apigrid_ClickE(null, null);

      CalcTotHT();

    }


    private void InitApigrid()
    {
      apiTGridFouNF.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
      apiTGridFouNF.AddColumn(Resources.col_Chaff, "VCHAFF", 1200);
      apiTGridFouNF.AddColumn(Resources.col_ChefGroupe, "VCHEFGRP", 1200);
      apiTGridFouNF.AddColumn(Resources.col_DI, "NDINNUM", 1000);
      apiTGridFouNF.AddColumn("Date chiffrage", "DELFNFDATCRE", 1000, "dd/mm/yyyy"); 
      apiTGridFouNF.AddColumn(MZCtrlResources.date_creation, "DDINDAT", 1000, "dd/mm/yyyy");
      apiTGridFouNF.AddColumn(Resources.col_DateExec, "DACTDEX", 1000,"dd/mm/yyyy");
      apiTGridFouNF.AddColumn(Resources.col_Compte, "NDINCTE", 1000);
      apiTGridFouNF.AddColumn(Resources.col_Site, "VSITNOM", 1400);
      apiTGridFouNF.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1700);
      apiTGridFouNF.AddColumn(Resources.col_Action, "VACTDES", 3000);
      apiTGridFouNF.AddColumn(Resources.col_Prestation, "VPRELIB", 1000);
      apiTGridFouNF.AddColumn(Resources.col_Intervenant, "VTYPEINTER", 1000);
      apiTGridFouNF.AddColumn(Resources.col_euro_heure, "NELFNFTMO", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_euro_depl, "NELFNFTDEP", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_Forfait, "NELFNFFOR", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_four, "NELFNFFOU", 1100, "currency", 1);
      apiTGridFouNF.AddColumn(Resources.col_Total, "NELFNFTHT", 1100, "currency", 1);
      apiTGridFouNF.AddColumn("DI", "NUMDI", 0);
      //apiTGridFouNF.AddColumn("NCLINUM", "NCLINUM", 0);

      apiTGridFouNF.InitColumnList();
    }

    private void InitRS()
    {
      // les budgets de prestations
      dtAC.Clear();
      daAC = new SqlDataAdapter($"SELECT * FROM TCLIBUDGET WHERE CTYPEBUDGET='P' AND NCLINUM = {miNumClient} ORDER BY NANNEE", MozartDatabase.cnxMozart);
      daAC.Fill(dtAC);
      grdAffectCompt.GridControl.DataSource = dtAC;
      cbAC.DataAdapter = daAC;

    }

    private void InitGrids()
    {
      grdAffectCompt.AddColumn(Resources.col_annee, "NANNEE", 250);
      grdAffectCompt.AddColumn(Resources.col_Montant, "NBUDGET", 400, "", 2);
      grdAffectCompt.AddColumn("NCLINUM", "NCLINUM", 0);   // Utile pour la mise à jour
      grdAffectCompt.AddColumn("CTYPEBUDGET", "CTYPEBUDGET", 0);   // Utile pour la mise à jour

      grdAffectCompt.FilterBar = false;

      grdAffectCompt.InitColumnList();

    }

    /* ----------Proc valable pour tous les boutons de type cmdDateSet ----------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }


    private void apigrid_ClickE(object sender, EventArgs e)
    {
      DataRow row = apiTGridFouNF.GetFocusedDataRow();
      if (null == row) return;

      miNumClient = Convert.ToInt32(row["NCLINUM"]);
      InitRS();
    }


    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridFouNF.GetFocusedDataRow();
      if (row == null) return;

      new frmChiffrageNF
      {
        mstrStatutElemFact = "V",
        miNumElemFact = Convert.ToInt32(row["NELFNFNUM"]),
        miNumDI = Convert.ToInt32(row["NUMDI"])
      }.ShowDialog();


    }

    private void apiTGridFouNF_ColumnFilterChanged(object sender, EventArgs e)
    {
      CalcTotHT();
    }

    private void CalcTotHT()
    {
      double dTot = 0;

      for (int i = 0; i < apiTGridFouNF.dgv.RowCount; i++)
      {
        DataRow row = apiTGridFouNF.dgv.GetDataRow(i);
        dTot += Convert.ToDouble(row["NELFNFTHT"]);
      }

      txtHT.Text = dTot.ToString("C2");
    }
  }
}

