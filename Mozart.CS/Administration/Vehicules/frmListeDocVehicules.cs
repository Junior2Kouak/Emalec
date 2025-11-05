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
  public partial class frmListeDocVehicules : Form
  {
    private string mRepertoireDoc = "";
    private DataTable dt = new DataTable();
		private readonly int NVEHNUM;
		private readonly string VVEHIMAT;


		public frmListeDocVehicules(int nVehnum, string vImat)
    {
			NVEHNUM = nVehnum;
			VVEHIMAT = vImat;

			InitializeComponent();
    }

    private void frmListeDoc_Load(object sender, EventArgs e)
    {
      try
      {
        mRepertoireDoc = Utils.RechercheParam("REP_DOCS_VEHICULES");

        ModuleMain.Initboutons(this);

        lblTitre.Text = $"{lblTitre.Text} {VVEHIMAT}"; 

				InitGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      new frmDetailDocVehicule(0,NVEHNUM,mRepertoireDoc).ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      new frmDetailDocVehicule((int)apiTGrid1.GetFocusedDataRow()["NID"],NVEHNUM,mRepertoireDoc).ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGrid1.GetFocusedDataRow() == null) return;

        new frmBrowser
        {
          msStartingAddress = CImpersonation.OpenFileImpersonated(mRepertoireDoc + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString())
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArch_Click(object sender, EventArgs e)
    {
      try
      {

        if (apiTGrid1.GetFocusedDataRow() == null) return;

        if (MessageBox.Show(Resources.msg_Confirm_Suppression, Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery("DELETE FROM TAUTODOC WHERE NID = " + apiTGrid1.GetFocusedDataRow()["NID"].ToString());

          // kill du fichier
          CImpersonation.DeleteFileImpersonated(mRepertoireDoc + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString());

					//System.IO.File.Delete(mRepertoireDoc + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString());
        }

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
		}

		private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NID", 800);
      apiTGrid1.AddColumn(Resources.col_Date, "DQUI", 1000, "dd/mm/yy", 2);
			apiTGrid1.AddColumn(Resources.col_Type, "VTYPE", 2000);
      apiTGrid1.AddColumn(Resources.col_Titre, "VTITRE", 2000);
			apiTGrid1.AddColumn(Resources.col_Commentaire, "VCOMMENT", 7000);

			apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM TAUTODOC WHERE NVEHNUM={NVEHNUM}");
      apiTGrid1.GridControl.DataSource = dt;
    }
  }
}