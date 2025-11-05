using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixFournisseurs : Form
  {
    public string mstrStatut;
    public int miNumConsult;
    public string mstrDateRetour;
    public int miNumAction = 0;

    DataTable dtFou = new DataTable();
    DataTable dtFouTemp = new DataTable();
    DataTable dtFouLoad = new DataTable();

    private int NumConsultation;

    public frmChoixFournisseurs() { InitializeComponent(); }


    private void frmChoixFournisseurs_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        NumConsultation = 0;

        ModuleData.LoadData(dtFouTemp, "select * from api_v_fournisseursConsult order by VSTFNOM");

        // Si modification alors on charge la liste de fournisseurs
        if (mstrStatut == "M")
          ModuleData.LoadData(dtFouLoad, $"SELECT DISTINCT NSTFNUM FROM TCONSULT WHERE NCONSULTNUM = {miNumConsult}");

        InitRecordsetFou();
        InitGrid();
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

    public void InitRecordsetFou()
    {
      try
      {
        // Ajout des champs au recordset
        dtFou.Columns.Add("NSTFNUM", Type.GetType("System.Int32"));
        dtFou.Columns.Add("VSTFNOM", Type.GetType("System.String"));
        dtFou.Columns.Add("CHK", Type.GetType("System.Boolean"));

        foreach (DataRow row in dtFouTemp.Rows)
        {
          DataRow newrow = dtFou.NewRow();

          newrow["NSTFNUM"] = row["NSTFNUM"];
          newrow["VSTFNOM"] = row["VSTFNOM"];

          if (mstrStatut == "M")
          {
            DataView dv = new DataView(dtFouLoad);
            dv.RowFilter = $"NSTFNUM = {row["NSTFNUM"]}";

            if (dv.Count == 0)
              newrow["CHK"] = false;
            else
              newrow["CHK"] = true;
          }
          dtFou.Rows.Add(newrow);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitGrid()
    {
      apiGrid.AddColumn("NSTFNUM", "NSTFNUM", 0);
      apiGrid.AddColumn(" ", "CHK", 200, "");
      apiGrid.AddColumn("Fournisseur", "VSTFNOM", 1800);
      apiGrid.GridControl.DataSource = dtFou;
      apiGrid.DelockColumn("CHK");
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      // Insertion des lignes dans TCONSULT pour chaque sous traitant
      // Insertion des lignes Articles dans TCONSULTART
      if (mstrStatut == "M")
      {
        NumConsultation = miNumConsult;
        // Efface les données demande de prix

        ModuleData.ExecuteNonQuery($"DELETE FROM TCONSULTFOU WHERE NCONSULTNUM = {NumConsultation}");
        ModuleData.ExecuteNonQuery($"DELETE FROM TCONSULT WHERE NCONSULTNUM = {NumConsultation}");
      }
      else
        // Dernier numéro créé
        NumConsultation = NumConsultation == 0 ? Convert.ToInt32(ModuleData.ExecuteScalarInt("select max(NCONSULTNUM) from TCONSULT")) + 1 : NumConsultation;

      DataView dv = new DataView(dtFou);
      dv.RowFilter = "CHK = true";

      string sSql;
      foreach (DataRowView row in dv)
      {
        // Execution de la requête d'insert dans TCONSULT
        sSql = $"insert into TCONSULT (NCONSULTNUM, NSTFNUM,  DCONSULTDAT, NQUICRE, DQUICRE, NACTNUM) Values ( {NumConsultation}, {row["NSTFNUM"]}, '{mstrDateRetour}', " +
               $"'{MozartParams.UID}', '{DateTime.Now.ToShortDateString()}', {(miNumAction == 0 ? "Null" : miNumAction.ToString())})";
        ModuleData.ExecuteNonQuery(sSql);

        // Execution de la requête d'insert dans TCONSULTFOU
        sSql = $"insert into TCONSULTFOU (NCONSULTNUM, NSTFNUM,  NFOUNUM, NFOUQTE) (select {NumConsultation}, {row["NSTFNUM"]}, NFOUNUM, NFOUQTE from TART WHERE VQUICRE = '{MozartParams.strUID}')";
        ModuleData.ExecuteNonQuery(sSql);
      }

      mstrStatut = "M";
      miNumConsult = NumConsultation;
      cmdVisu.Enabled = true;
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        // On visualise la premiere et c'est tout
        DataView dv = new DataView(dtFou);
        dv.RowFilter = "CHK = True";
        VisualiserLaConsultation(Convert.ToInt32(dv[0]["NSTFNUM"]));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    
    private void VisualiserLaConsultation(int NumFournisseur)
    {
      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };
      frmBrowser f = new frmBrowser();
      f.msInfosMail = $"TINT|NSTFNUM|{NumFournisseur}";    // TABLE | ID    --VL 16/11/04
      f.Preview_Print($"{MozartParams.CheminModeles}{Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", NumFournisseur.ToString())}TConsultationFourniture.rtf",
                      @"TConsultationFournitureOut.rtf",
                      TdbGlobal,
                      $"exec api_sp_impConsultation {miNumConsult}, {NumFournisseur}",
                      " (Impression consultation)",
                      "PREVIEW");
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}