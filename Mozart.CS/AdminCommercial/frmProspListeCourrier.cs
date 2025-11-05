using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmProspListeCourrier : Form
  {
    DataTable dt = new DataTable();
    public string mstrStatut = "";
    public string msLibNomSoc = "";
    public long miNumProspect;

    private void InitData()
    {
      string sSQL;
      if (mstrStatut == "F")
        sSQL = "SELECT NCOURNUM, DCOURDAT, VPERNOM, VPROSNOM, VCOURREF, VCOUROBJET, NCOURIDPROSP, VPROSPAYS  " +
               " FROM TCOURPROSP INNER JOIN TPROSP ON NCOURIDPROSP = NPROSNUM INNER JOIN" +
               " TPER ON NCOURIDCRE = NPERNUM AND NPROSNUM = " + miNumProspect +
               " ORDER BY NCOURNUM DESC ";
      else
        sSQL = "SELECT NCOURNUM, DCOURDAT, VPERNOM, VPROSNOM, VCOURREF, VCOUROBJET, NCOURIDPROSP, VPROSPAYS  " +
               " FROM TCOURPROSP INNER JOIN TPROSP ON NCOURIDPROSP = NPROSNUM INNER JOIN" +
               " TPER ON NCOURIDCRE = NPERNUM WHERE TPROSP.VSOCIETE = App_Name() ORDER BY NCOURNUM DESC ";
      ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      ApiGrid.GridControl.DataSource = dt;
    }

    public frmProspListeCourrier()
    {
      InitializeComponent();
    }

    private void frmProspListeCourrier_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Label1.Text += " " + msLibNomSoc;

        InitData();
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void InitApigrid()
    {
      ApiGrid.AddColumn(Resources.col_Num, "NCOURNUM", 800);
      ApiGrid.AddColumn(Resources.col_Date, "DCOURDAT", 900, "dd/mm/yy");
      ApiGrid.AddColumn(Resources.col_Auteur, "VPERNOM", 1500);
      ApiGrid.AddColumn(Resources.col_Prospect, "VPROSNOM", 2000);
      ApiGrid.AddColumn(Resources.col_Ref, "VCOURREF", 2500);
      ApiGrid.AddColumn(Resources.col_Objet, "VCOUROBJET", 3000);
      ApiGrid.AddColumn(Resources.col_Prosp, "NCOURIDPROSP", 0);
      ApiGrid.AddColumn(Resources.col_Pays, "VPROSPAYS", 800);

      ApiGrid.InitColumnList();
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      //  écran de création de la demande
      Cursor.Current = Cursors.WaitCursor;
      frmProspLettre f = new frmProspLettre();
      f.mstrStatut = "C";
      f.miNumProsp = miNumProspect;
      f.miNumCourrier = 0;
      f.ShowDialog();

      //  rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      ApiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //  passage des infos
      frmProspLettre f = new frmProspLettre();
      f.mstrStatut = "M";
      f.miNumCourrier = (int)row["NCOURNUM"];
      f.miNumProsp = (int)row["NCOURIDPROSP"];
      f.ShowDialog();

      //  rafraichissement du recordset
      Cursor.Current = Cursors.WaitCursor;
      ApiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (ApiGrid.GetFocusedDataRow() == null) return;

      string[,] TdbGlobal = { { "copie", "Original" } };
      string CheminModelesTemp = ModuleData.RechercheParam("REP_MODELES", msLibNomSoc);

      new frmBrowser().ImprimerFichier(CheminModelesTemp + ModuleMain.CodePays(ApiGrid.GetFocusedDataRow()["VPROSPAYS"].ToString()) + @"\TCourrierProsp.rtf",
                      @"TCourrierOut.Out.rtf",
                      TdbGlobal,
                      "EXEC api_sp_impCourrierProsp " + ApiGrid.GetFocusedDataRow()["NCOURNUM"].ToString());
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      if (ApiGrid.GetFocusedDataRow() == null) return;
      try
      {
        if (MessageBox.Show(Resources.msg_Confirm_courrier_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          Cursor.Current = Cursors.WaitCursor;
          ModuleData.ExecuteNonQuery($"DELETE from TCOURPROSP where NCOURNUM = {ApiGrid.GetFocusedDataRow()["NCOURNUM"]}");
          ApiGrid.Requery(dt, MozartDatabase.cnxMozart);

        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void ApiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

  }
}
