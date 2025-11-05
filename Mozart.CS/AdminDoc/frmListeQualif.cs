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
  public partial class frmListeQualif : Form
  {
    DataTable dtqual = new DataTable();
    private string CheminFicQualif;

    public frmListeQualif()
    {
      InitializeComponent();
    }

    private void frmListeQualif_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //  init
        CheminFicQualif = ModuleData.RechercheParam("REP_DOC_QUALIF", MozartParams.NomSociete);

        LoadGrid();
        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadGrid()
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.LoadData(dtqual, MozartDatabase.cnxMozart, "EXEC api_sp_listeQualification '" + MozartParams.NomSociete + "', 0");
      apiTGrid1.GridControl.DataSource = dtqual;
      Cursor.Current = Cursors.Default;
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      new frmDetailQualif
      {
        miIdQualif = 0,
        CheminFicQualif = CheminFicQualif
      }.ShowDialog();

      //  mise a jour 
      apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      new frmDetailQualif
      {
        miIdQualif = (int)apiTGrid1.GetFocusedDataRow()["NQUALIFID"],
        CheminFicQualif = CheminFicQualif
      }.ShowDialog();

      apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        
        if (MessageBox.Show(Resources.msg_ConfirmSupQualif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          DataRow row = apiTGrid1.GetFocusedDataRow();
          if (CImpersonation.FileExistImpersonated(CheminFicQualif + apiTGrid1.GetFocusedDataRow()["VQUALIFNOMFIC"].ToString()))
          {
            CImpersonation.DeleteFileImpersonated(CheminFicQualif + apiTGrid1.GetFocusedDataRow()["VQUALIFNOMFIC"].ToString());
          }
          ModuleData.ExecuteNonQuery("DELETE FROM TQUALIF WHERE NQUALIFID = " + row["NQUALIFID"].ToString());
          apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
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

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("ID", "NQUALIFID", 0);
      apiTGrid1.AddColumn(Resources.col_lib_qualif, "VQUALIFLIB", 3500);
      apiTGrid1.AddColumn(Resources.col_num_certif, "VQUALIFNUMCERT", 2000);
      apiTGrid1.AddColumn(Resources.col_date_obtention, "DQUALIFOBTEN", 1500);
      apiTGrid1.AddColumn(Resources.col_date_renouvellement, "DAQUALIFRENOUV", 1500);
      apiTGrid1.AddColumn(Resources.col_nom_fich_PDF, "VQUALIFNOMFIC", 3000);
      apiTGrid1.AddColumn("Langue", "VLANGUE", 1000);
      apiTGrid1.AddColumn(Resources.col_Societe, "VSOCIETE", 0);

      apiTGrid1.InitColumnList();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGrid1.GetFocusedDataRow() == null) return;

        if (CImpersonation.FileExistImpersonated(CheminFicQualif + apiTGrid1.GetFocusedDataRow()["VQUALIFNOMFIC"].ToString()))
        {
          new frmBrowser
          {
            msStartingAddress = CImpersonation.OpenFileImpersonated(CheminFicQualif + apiTGrid1.GetFocusedDataRow()["VQUALIFNOMFIC"].ToString())
          }.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}