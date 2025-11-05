using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieInfoPaie : Form
  {
    private DataTable dt = new DataTable();

    public frmSaisieInfoPaie() { InitializeComponent(); }

    private void frmSaisieInfoPaie_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        DateEdit_Fin.EditValue = DateTime.Now;
        DateEdit_Debut.EditValue = DateTime.Now.AddMonths(-1);

        InitApiTgrid();

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

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {

      dt.Clear();
      using (SqlCommand cmd = new SqlCommand($"api_sp_ListeAbsencePersonnel", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@p_datedebut"].Value = DateEdit_Debut.Text;
        cmd.Parameters["@p_datefin"].Value = DateEdit_Fin.Text;


        // chargement de la datatable
        dt.Load(cmd.ExecuteReader());
        apiTGrid.GridControl.DataSource = dt;
      }
    }

    private void InitApiTgrid()
    {
      apiTGrid.AddColumn("Matricule", "NPERNUM", 800);
      apiTGrid.AddColumn("Nom", "VPERNOM", 1800);
      apiTGrid.AddColumn("Prénom", "VPERPRE", 1500);
      apiTGrid.AddColumn("Code opération", "NSITNUE", 900);
      apiTGrid.AddColumn("Début", "DDEBUT", 900, "dd/mm/yyyy");
      apiTGrid.AddColumn("Fin", "DFIN", 900, "dd/mm/yyyy");
      apiTGrid.AddColumn("Valeur", "VALEUR", 900);
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}