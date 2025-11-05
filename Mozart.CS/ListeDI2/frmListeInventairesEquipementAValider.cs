using MozartCS.Inventaire_Equipement;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeInventairesEquipementAValider : Form
  {
    DataTable dt = new DataTable();
        bool bArchives;

    public frmListeInventairesEquipementAValider() { InitializeComponent(); }

    private void frmListeInventairesEquipementAValider_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
                bArchives = false;

                LoadData();

        InitApigrid();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    public void LoadData()
        {
            apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC [api_sp_InvEquip_ListeAValider] {!bArchives}");
            apigrid.GridControl.DataSource = dt;
        }

    public void InitApigrid()
    {
      apigrid.AddColumn("Réception", "DDATESYNCHRO", 750);
      apigrid.AddColumn("Technicien", "VTECHNOM", 1000);
      apigrid.AddColumn("N° DI", "NDINNUM", 850);
      apigrid.AddColumn("Client", "VCLINOM", 1200);
      apigrid.AddColumn("Site", "VSITNOM", 1400);
      apigrid.AddColumn("Action", "VACTDES", 1000);
      apigrid.AddColumn("Chaff", "VCHAFF", 1000);
      apigrid.AddColumn("Date inventaire terminé", "DDATEFIN", 850);
      apigrid.AddColumn("Nombre d'équipements inventoriés", "NB_EQUIP", 1200);

      apigrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apigrid.AddColumn(Resources.col_Site, "NACT_INV_ID", 0);
    
      apigrid.InitColumnList();

    }
            
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
          

        private void cmdArchives_Click(object sender, EventArgs e)
        {
            bArchives = !bArchives;

            if(bArchives)
            {
                this.Text = Label1.Text = "Liste des inventaires équipements traités ou archivés";
                cmdArchives.Text = "En attente de traitement";
            }
            else
            {
                this.Text = Label1.Text = "Liste des inventaires équipements à valider";
                cmdArchives.Text = "Archives";
            }
            cmdArchiver.Visible = !bArchives;
            LoadData();

        }

        private void cmdArchiver_Click(object sender, EventArgs e)
        {
            DataRow row = apigrid.GetFocusedDataRow();
            if (row == null) return;

            if (MessageBox.Show("Vous allez-archiver cette inventaire, êtes-vous sûre?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            string sSQL = $"EXEC [api_sp_InvEquip_Archiver] {row["NACT_INV_ID"]}";

            MozartDatabase.ExecuteNonQuery(sSQL);

            Cursor.Current = Cursors.WaitCursor;
            LoadData();
            Cursor.Current = Cursors.Default;
        }

        private void cmdinventaireEquipDetail_Click_1(object sender, EventArgs e)
        {
            DataRow row = apigrid.GetFocusedDataRow();
            if (row == null) return;

            new frmInventaireEquipementReceiveToValid()
            {
                nactinvid = (int)row["NACT_INV_ID"]

            }.ShowDialog();

            LoadData();
        }
    }
}

