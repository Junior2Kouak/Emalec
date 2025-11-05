using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeReleveCompteur : Form
  {
    public int iNumCompteur;

    DataTable dt = new DataTable();

    public frmListeReleveCompteur() { InitializeComponent(); }

    private void frmListeReleveCompteur_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSQL = "";

        //ouverture du recordset
        sSQL = $"SELECT   NID, VCOMPTNOM, VINFOLIB, S.VCOMPTNUM, NINFODATA, dinfodate, NINFOCONSO FROM TCOMPTEURDATA D INNER JOIN " +
                $"TCOMPTEURSITE S ON S.NCOMPTID = D.NCOMPTID AND S.NSITNUM = D.NSITNUM INNER JOIN TREF_INFOTECH " +
                $"R ON R.NINFONUM = S.NINFONUM Where s.ncomptid = {iNumCompteur} and langue='FR' order by DINFODATE DESC";

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apigrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      apigrid.AddColumn("ID", "NID", 0);
      apigrid.AddColumn("Nom", "VCOMPTNOM", 1500);
      apigrid.AddColumn("Compteur", "VCOMPTNUM", 1300);
      apigrid.AddColumn("Type", "VINFOLIB", 2500);
      apigrid.AddColumn(Resources.col_Date, "dinfodate", 1500, "dd/MM/yyyy", 2);
      apigrid.AddColumn("Indice compteur", "NINFODATA", 1500, "#.##", 2);
      apigrid.AddColumn("consommation", "NINFOCONSO", 1500, "#.##", 2);

      //apigrid.DelockColumn("NINFODATA");
      //apigrid.DelockColumn("dinfodate");

      apigrid.InitColumnList();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

