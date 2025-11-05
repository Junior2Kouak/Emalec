using Microsoft.VisualBasic;
using MozartCS.Properties;
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
  public partial class frmChiffrageNF : Form
  {
    public string mstrStatutElemFact;
    public long miNumElemFact;
    public bool mbClose = true;
    public long miNumDI;


    private long miNumSite;
    private int miNumClient;
    private DataTable dtArticles = new DataTable();
    private DataTable dtActions = new DataTable();


    public frmChiffrageNF() { InitializeComponent(); }


    private void frmChiffrageNF_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        // initialisation du tableau de recherche des articles
        FormatGridAction();
        FormatApiTGrid();

        if (mstrStatutElemFact == "C")
        {
          OuvertureEnCreation();
        }
        else
        {
          OuvertureEnModification();
        }

        // dans le cas du reporting, on est juste en visu sans pouvoir faire de modifications
        if (mstrStatutElemFact == "V") cmdEnregistrer.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void OuvertureEnCreation()
    {
      try
      {
        //  affectation du recordset à la listbox
        //  recherche de toutes les actions non chiffrées NF
        ModuleData.LoadData(dtActions, $"api_sp_ListeActionsChiffrablesNF {miNumDI}", MozartDatabase.cnxMozart);
        apiTGridActions.GridControl.DataSource = dtActions;

        // si une seule ligne, la sélectionner automatiquement
        apigrid_ClickE(null, null);

        // initialisation de la liste des articles 
        ModuleData.LoadData(dtArticles, $"api_sp_ListeFournituresNF 0, 1", MozartDatabase.cnxMozart);
        apiTGridB.GridControl.DataSource = dtArticles;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apigrid_ClickE(object sender, EventArgs e)
    {

      if (mstrStatutElemFact != "C") return;

      DataRow row = apiTGridActions.GetFocusedDataRow();
      if (null == row) return;

      miNumSite = Convert.ToInt32(row["NSITNUM"]);

      //  Lier les textbox avec le recordset
      using (SqlDataReader dr = MozartDatabase.ExecuteReader($"exec api_sp_DetailFacturationDI {miNumDI}, {miNumSite}"))
      {
        if (dr.Read())
        {
          miNumClient = Convert.ToInt32(dr["NCLINUM"]);
          txtTauxDep.EditValue = dr["NCLICONTDEP"].ToString();
          txtTauxHeures.EditValue = dr["NCLICONTHOR"].ToString();
        }
      }
    }



    private void OuvertureEnModification()
    {
      try
      {
        ModuleData.LoadData(dtActions, $"api_sp_InfoActionChiffreeNF {miNumElemFact}", MozartDatabase.cnxMozart);
        apiTGridActions.GridControl.DataSource = dtActions;

        foreach (DataRow item in dtActions.Rows)
        {
          // mise à jour des contrôles
          txtNbrDep.EditValue = Utils.BlankIfNull(item["NELFNFDEP"]);
          txtNbrHeures.EditValue = Utils.BlankIfNull(item["NELFNFHEU"]);
          txtTauxDep.EditValue = Utils.BlankIfNull(item["NELFNFTDEP"]);
          txtTauxHeures.EditValue = Utils.BlankIfNull(item["NELFNFTHEU"]);
          txtObserv.Text = Utils.BlankIfNull(item["TELFNFOBS"]);
          txtFour.EditValue = Utils.BlankIfNull(item["NELFNFFOU"]);
          txtForfait.EditValue = Utils.BlankIfNull(item["NELFNFFOR"]);
          miNumClient = Convert.ToInt32(item["NCLINUM"]);

          // type de fourniture
          if (item["CELFNFTFO"].ToString() == "D")
          {
            optFour0.Checked = true;

            lblEuro.Visible = txtFour.Visible = false;
            frameSearch.Visible = true;
          }
          else
          {
            optFour1.Checked = lblEuro.Visible = txtFour.Visible = true;
            frameSearch.Visible = false;
          }

          ModuleData.LoadData(dtArticles, $"api_sp_ListeFournituresNF {Convert.ToInt32(item["NACTNUM"])}, 1", MozartDatabase.cnxMozart);
          apiTGridB.GridControl.DataSource = dtArticles;

          // remplir les montants totaux
          RemplirTxtTotaux();

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGridB_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      // si modification de la quantité
      if (e.Column.ColumnHandle == 6)
        RemplirTxtTotaux();
    }



    private void optFournitures_Forfait_Click(object sender, EventArgs e)
    {
      if ((sender as Control).Name == "optFour0")
      {
        frameSearch.Visible = true;
        lblEuro.Visible = txtFour.Visible = false;
      }
      else
      {
        frameSearch.Visible = false;
        lblEuro.Visible = txtFour.Visible = true;
      }
    }

    private void EnregistrerElemFact(int NACTNUM)
    {
      using (SqlCommand cmd = new SqlCommand("api_sp_creationElemFactNF", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        cmd.Parameters["@iNumElemFact"].Value = miNumElemFact;
        cmd.Parameters["@iDI"].Value = miNumDI;
        cmd.Parameters["@iNACTNUM"].Value = NACTNUM;
        cmd.Parameters["@nDepl"].Value = txtNbrDep.Text; 
        cmd.Parameters["@iHeures"].Value = txtNbrHeures.Text; 
        cmd.Parameters["@TauxDepl"].Value = txtTauxDep.Text; 
        cmd.Parameters["@TauxHeures"].Value = txtTauxHeures.Text; 
        cmd.Parameters["@vObserv"].Value = txtObserv.Text == "" ? DBNull.Value : (object)txtObserv.Text;
        cmd.Parameters["@cTypeFour"].Value = optFour0.Checked ? "D" : "F";
        cmd.Parameters["@nForfait"].Value = txtForfait.Text; 

        if (optFour1.Checked)
          cmd.Parameters["@nFour"].Value = txtFour.Text;
        else
          cmd.Parameters["@nFour"].Value = txtHT.Text; 


        cmd.ExecuteNonQuery();
        miNumElemFact = (int)cmd.Parameters[0].Value;

        //  traitement des articles sélectionnés - on supprime tous les articles de la table TFNF
        // un trigger de delete supprime dans TSTOCK
        MozartDatabase.ExecuteNonQuery($"Delete from TFNF where BTYPEP3=1 AND NACTNUM = {NACTNUM}");
        if (optFour0.Checked)
        {
          // on parcourt le recordset des articles si il y en a
          foreach (DataRow row in dtArticles.Rows)
            EnregistrerArticle(row, NACTNUM);
        }

        mstrStatutElemFact = "M";
      }
    }


    private void EnregistrerArticle(DataRow rowArt, int NACTNUM)
    {
      using (SqlCommand cmd = new SqlCommand("api_sp_creationLigneFouNF", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        cmd.Parameters["@iNACTNUM"].Value = NACTNUM;
        cmd.Parameters["@iNFouNum"].Value = Utils.ZeroIfNull(Convert.ToInt32(rowArt["NFOUNUM"]));
        cmd.Parameters["@nFouPrixBase"].Value = 0;
        cmd.Parameters["@nFouPrixClient"].Value = Utils.BlankIfNull(rowArt["NFNFPRIXCLIENT"].ToString());
        cmd.Parameters["@nValQTE"].Value = Utils.BlankIfNull(rowArt["NFNFQTE"].ToString());
        cmd.Parameters["@nFouPrixAchat"].Value = 0; 
        cmd.Parameters["@bstock"].Value = Utils.BlankIfNull(rowArt["BSTOCK"].ToString());
        cmd.Parameters["@bTypeP3"].Value = 1;

        cmd.ExecuteNonQuery();
      }
    }


    public void FormatApiTGrid()
    {
      try
      {
        apiTGridB.AddColumn(Resources.col_stock, "BSTOCK", 900, "", 2, false, false, true);
        apiTGridB.AddColumn(Resources.col_Serie, "CCFOCOD", 1200);
        apiTGridB.AddColumn(Resources.col_materiel, "VFOUMAT", 3000);
        apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1000);
        apiTGridB.AddColumn(Resources.col_prixU, "NFNFPRIXCLIENT", 1400, "Currency", 1);
        apiTGridB.AddColumn(Resources.col_Qte, "NFNFQTE", 1000, "", 2);
        apiTGridB.AddColumn("NACTNUM", "NACTNUM", 0);
        apiTGridB.AddColumn("NFOUNUM", "NFOUNUM", 0);

        apiTGridB.DelockColumn("NFNFQTE");
        apiTGridB.DelockColumn("BSTOCK");

        apiTGridB.FilterBar = false;
        apiTGridB.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    public void FormatGridAction()
    {
      apiTGridActions.AddColumn(Resources.col_NAction, "NACTID", 500);
      apiTGridActions.AddColumn(Resources.col_Site, "VSITNOM", 1200);
      apiTGridActions.AddColumn(Resources.col_Action, "VACTDES", 3000);
      apiTGridActions.AddColumn(Resources.col_Prestation, "CPRECOD", 500, "", 2);
      apiTGridActions.AddColumn(Resources.col_Pays, "VSITPAYS", 700, "", 2);
      apiTGridActions.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridActions.FilterBar = true;
      apiTGridActions.InitColumnList();
    }


    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridActions.GetFocusedDataRow();
      if (row == null)
      {
        MessageBox.Show(Resources.msg_Must_select_line, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      EnregistrerElemFact(Convert.ToInt32(row["NACTNUM"]));

      Dispose();
    }


    private void cmdRechercher_Click(object sender, EventArgs e)
    {
    
      //Cursor.Current = Cursors.WaitCursor;
      frmRechercheFournituresCNF f = new frmRechercheFournituresCNF
			{
				miNumClient = miNumClient,
				mdtArticle = dtArticles
			};
			f.ShowDialog();

			// récupération des articles au retour de la form
			dtArticles = f.mdtArticle;
			apiTGridB.GridControl.DataSource = dtArticles;

			RemplirTxtTotaux();
			Cursor.Current = Cursors.Default;
		}

    private void cmdcmd_Click(object sender, EventArgs e)
    {
      // on passe le dtarticles qui est mis à jour directement
      new frmListeMatFact { msMode = "NF", mdtArticles = dtArticles, msNumDI = Convert.ToString(miNumDI) }.ShowDialog();

      // remplir les montants totaux
      RemplirTxtTotaux();
    }

    private void RemplirTxtTotaux()
    {
      float HT = 0;

      foreach (DataRow dr in dtArticles.Rows)
        HT += Convert.ToSingle(Utils.ZeroIfNull(dr["NFNFPRIXCLIENT"]) * Utils.ZeroIfNull(dr["NFNFQTE"]));

      txtHT.EditValue = HT;

    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      // dans le cas du reporting, on est juste en visu sans pouvoir faire de modifications
      if (mstrStatutElemFact == "V")
      {
        Dispose();
        return;
      }
    }
  }
}