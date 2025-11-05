using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFournisseurs : Form
  {
    DataTable dtSTF = new DataTable();

    public frmListeFournisseurs() { InitializeComponent(); }

    private void frmListeFournisseurs_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitGrid();

        string sql = "";
        if (MozartParams.NomSociete == "SAMSICROMANIA")
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF INNER JOIN TPER ON TPER.NPERNUM=TSTF.NSTFQUICREE WHERE (NSTFGRPTYPFO = 1) AND VSOCIETE='SAMSICROMANIA' ORDER BY VSTFNOM, VSTFVIL";
        else if (MozartParams.NomSociete == "SAMSICITALIA")
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF INNER JOIN TPER ON TPER.NPERNUM=TSTF.NSTFQUICREE WHERE (NSTFGRPTYPFO = 1) AND VSOCIETE='SAMSICITALIA' ORDER BY VSTFNOM, VSTFVIL";
        else
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF WHERE (NSTFGRPTYPFO = 1) ORDER BY VSTFNOM, VSTFVIL";
        txtCritFourn.Init(MozartDatabase.cnxMozart, sql, "NSTFNUM", "VSTFNOM",
                          new List<string>() { Resources.col_Num, Resources.col_Nom, Resources.col_Ville }, 500, 550, true);

        txtCritFourn.NewValues = true;

        apiLabel[] labels = { Label2, Label3, Label4, Label5, Label6, label14 };
        foreach (apiLabel lbl in labels) lbl.Text = lbl.Text + " :";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        string p_VSTFNOM = txtCritFourn.GetText() == "" ? "T$" : txtCritFourn.GetText();
        string p_VINTNOM = txtCritINTNOM.Text == "" ? "T$" : txtCritINTNOM.Text;
        string p_VSTFDEPART = txtCritSTFDEP.Text == "" ? "T$" : txtCritSTFDEP.Text;
        string p_VSTFVILLES = txtCritSTFVILLES.Text == "" ? "T$" : txtCritSTFVILLES.Text;
        string p_VSTFPAYS = txtCritSTFPAYS.Text == "" ? "T$" : txtCritSTFPAYS.Text;
        string p_VSTFACTIV = txtCritSTFACTIV.Text == "" ? "T$" : txtCritSTFACTIV.Text;

        Grid.LoadData(dtSTF, MozartDatabase.cnxMozart, $"EXEC api_sp_listeSTF 'FO', '{p_VSTFNOM}', '{p_VINTNOM}', '{p_VSTFDEPART}', '{p_VSTFVILLES}', '{p_VSTFPAYS}', '{p_VSTFACTIV}'");
        Grid.GridControl.DataSource = dtSTF;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor = Cursors.Default; }
    }

    private void cmdDevis_Click(object sender, EventArgs e)
    {
      new frmListeConsult().ShowDialog();
    }

    private void cmdCommandes_Click(object sender, EventArgs e)
    {
      try
      {
        //affichage feuille
        new frmListeCommandesFour2().ShowDialog();
        Grid.Requery(dtSTF, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor = Cursors.Default; }
    }

    public void InitGrid()
    {
      Grid.AddColumn("Num.", "NSTFNUM", 850);
      Grid.AddColumn(Resources.col_groupe, "VSTFGRPNOM", 1350);
      Grid.AddColumn(Resources.col_Site, "VSTFNOM", 1350, "", 0, true);
      Grid.AddColumn(Resources.col_Contact, "VINTNOM", 1300);
      Grid.AddColumn(Resources.col_Telephone, "VINTTEL", 1300);
      Grid.AddColumn(Resources.col_Fax, "VINTFAX", 1300);
      Grid.AddColumn(Resources.col_Portable, "VINTPOR", 1300);
      Grid.AddColumn(Resources.txt_Mail, "VINTMAIL", 1200);
      Grid.AddColumn(Resources.col_CP, "VSTFCP", 550);
      Grid.AddColumn(Resources.col_VilleCible, "VSTFVIC", 1300);
      Grid.AddColumn(Resources.col_Activite, "VSTFAC1", 2100, "", 0, true);
      Grid.AddColumn(Resources.col_Observation, "VSTFOBS", 1450, "", 0, true);
      Grid.AddColumn(Resources.col_Pays, "VSTFPAYS", 1000);
      Grid.AddColumn(Resources.col_Adresse1, "VSTFAD1", 1450);
      Grid.AddColumn(Resources.col_Adresse2, "VSTFAD2", 1100);
      Grid.AddColumn("NumContact", "NINTNUM", 0);
      Grid.InitColumnList();
    }
    private void Grid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["INTERDIT"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH8080FF;
          e.HighPriority = true;
        }
      }
    }

    private void frmListeFournisseurs_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

