using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmListeOTM : Form
  {
    public bool mbFacture;
    public string mstrStatut;
    public string sDatePlanif;
		public int mNumContratOMT;


		DataTable dt = new DataTable();

    public frmListeOTM()
    {
      InitializeComponent();
    }

    private void frmListeOM_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        // on vient de l'action
        if (mstrStatut == "A")
        {
          cmdNouvelle.Visible = true;
          apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeOTM where NACTNUM = {MozartParams.NumAction}");
        }
        else
        {
          cmdNouvelle.Visible = false;
          apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeOTM WHERE VSOCIETE = '{MozartParams.NomSociete}'");
        }

        apiGrid.GridControl.DataSource = dt;
        InitApigrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void InitApigrid()
    {

      try
      {
				apiGrid.AddColumn(Resources.col_Contrat, "NOTMNUM", 750);
				apiGrid.AddColumn(Resources.col_DI, "NDINNUM", 750);
				apiGrid.AddColumn(Resources.col_ST, "VSTFNOM", 1400, "", 0, true);
				apiGrid.AddColumn(Resources.col_Contact, "VINTNOM", 1200);
				apiGrid.AddColumn(Resources.col_Creator, "VPERNOM", 1000);
				apiGrid.AddColumn(Resources.col_Date, "DCSTDAT", 900, "dd/mm/yy");
				apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
				apiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500, "", 0, true);
				apiGrid.AddColumn(Resources.col_DateExecution, "DCSTDEL", 900, "dd/mm/yy");
				apiGrid.AddColumn(Resources.col_Action, "TCSTPRE", 2900, "", 0, true);
				apiGrid.AddColumn(Resources.col_Actif, "CCSTACTIF", 800, "", 2);
				apiGrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
				apiGrid.AddColumn("NumST", "NSTFNUM", 0);

        apiGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      // si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
      if (mbFacture)
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      MozartParams.NumAction = Convert.ToInt32(apiGrid.GetFocusedDataRow()["NACTNUM"]);

			// écran de création de la demande
			new frmOTM
			{
				mNumContratOMT = 0,
				msTypeContrat = "M",  // Type travaux mutualisé
				msDatePlanif = sDatePlanif,
				mbFacture = mbFacture,
      }.ShowDialog();

      Cursor = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (dt.Rows.Count == 0) return;

      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

			MozartParams.NumAction = Convert.ToInt32(apiGrid.GetFocusedDataRow()["NACTNUM"]);

			// passage des infos
			frmOTM f = new frmOTM();
      f.mNumContratOMT = Convert.ToInt32(currentRow["NCSTNUM"]);
      f.ShowDialog();
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;

    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_Confirmation, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.CnxExecute($"update TCST set CCSTACTIF = 'N' WHERE NCSTNUM = {currentRow["NCSTNUM"]}");
        else
          return;

        apiGrid.Requery(dt, MozartDatabase.cnxMozart);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

		private void cmdRestaurer_Click(object sender, EventArgs e)
		{
			try
			{
				// suppression
				DataRow currentRow = apiGrid.GetFocusedDataRow();
				if (currentRow == null) return;

				if (MessageBox.Show(Resources.msg_Confirmation, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
							MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					ModuleData.CnxExecute($"update TCST set CCSTACTIF = 'O' WHERE NCSTNUM = {currentRow["NCSTNUM"]}");
				else
					return;

				apiGrid.Requery(dt, MozartDatabase.cnxMozart);

			}
			catch (Exception ex)
			{
				MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
			}
		}

		private void frmListeOM_FormClosing(object sender, FormClosingEventArgs e)
    {
      mbFacture = false;
      Cursor = Cursors.Default;
    }

    private void apiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
	}
}

