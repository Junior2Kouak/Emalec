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
  public partial class frmGestRecrutement : Form
  {
    public string mstrStatut = "";

    private DataTable dt = new DataTable();

    public frmGestRecrutement()
    {
      InitializeComponent();
    }

    private void frmGestRecrutement_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        string sSQL = "exec api_sp_ListeRecru2 '" + mstrStatut + "','" + MozartParams.NomSociete + "', 0";
        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiGrid.GridControl.DataSource = dt;
        InitApigrid();

        cmdSupprimer.Visible = cmdArchive.Visible = mstrStatut == "O";
        cmdRestaurer.Visible = mstrStatut != "O";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {

      frmDetailRecru f = new frmDetailRecru();
      f.mstrStatut = "C";
      f.miNumPer = 0;
      f.msLibNomSoc = MozartParams.NomSociete;
      f.ShowDialog();

      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (apiGrid.GetFocusedDataRow() == null) return;

      frmDetailRecru f = new frmDetailRecru();
      f.mstrStatut = "M";
      f.msLibNomSoc = apiGrid.GetFocusedDataRow()["VSOCIETE"].ToString();
      f.miNumPer = Convert.ToInt32(apiGrid.GetFocusedDataRow()["NPERNUM"]);
      f.ShowDialog();

      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdImplantation_Click(object sender, EventArgs e)
    {
      if (apiGrid.GetFocusedDataRow() == null) return;

      //  TB SAMSIC CITY SPEC
      if (MozartParams.NomGroupe == "EMALEC")
      {
        frmBrowser f = new frmBrowser();
        f.msStartingAddress = "https://maps.emalec.com/Candidats.asp?BASE=MULTI&APP=" + apiGrid.GetFocusedDataRow()["VSOCIETE"].ToString();
        f.ShowDialog();
      }
      // TB SAMSIC CITY TODO -> else pour samsic

    }

    private void cmdCarteTousTechs_Click(object sender, EventArgs e)
    {
      if (apiGrid.GetFocusedDataRow() == null) return;

      //  TB SAMSIC CITY SPEC
      if (MozartParams.NomGroupe == "EMALEC")
      {
        frmBrowser f = new frmBrowser();
        f.msStartingAddress = "https://maps.emalec.com/Techniciens_et_recrutement.asp?BASE=MULTI&APP=" + apiGrid.GetFocusedDataRow()["VSOCIETE"].ToString();
        f.ShowDialog();
      }
      // TB SAMSIC CITY TODO -> else pour samsic    
    }

    private void CmdFicheContrat_Click(object sender, EventArgs e)
    {
      frmFicheTechRecru f = new frmFicheTechRecru("O");
      f.ShowDialog();
    }

    private void CmdQCMRecru_Click(object sender, EventArgs e)
    {
      frmQCMListeCandidat f = new frmQCMListeCandidat(1);
      f.ShowDialog();
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      if (apiGrid.GetFocusedDataRow() == null) return;
      try
      {
        if (MessageBox.Show(Resources.msg_ask_to_restore_this_person, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          ModuleData.CnxExecute("UPDATE TRECRU SET CPERACTIF='O' WHERE NPERNUM = " + apiGrid.GetFocusedDataRow()["NPERNUM"].ToString());
          apiGrid.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      if (apiGrid.GetFocusedDataRow() == null) return;
      try
      {
        if (MessageBox.Show(Resources.msg_ask_to_archive_this_person, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          ModuleData.CnxExecute("UPDATE TRECRU SET CPERACTIF='N' WHERE NPERNUM = " + apiGrid.GetFocusedDataRow()["NPERNUM"].ToString());
          apiGrid.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      frmGestRecrutement f = new frmGestRecrutement();
      f.mstrStatut = "N";
      f.ShowDialog();
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Nom, "VPERNOM", 1300);           //0
      apiGrid.AddColumn(Resources.col_Prenom, "VPERPRE", 1100);
      apiGrid.AddColumn(Resources.col_Civ, "CPERCIV", 700);
      apiGrid.AddColumn(Resources.col_Type, "CPERTYPDETAIL", 1200);
      apiGrid.AddColumn(Resources.col_Service, "VSERLIB", 1500);
      apiGrid.AddColumn(Resources.col_Societe, "VSOCIETE", 1100);
      apiGrid.AddColumn(Resources.col_Dep, "VDEPLIB", 1500);   //5
      apiGrid.AddColumn(Resources.col_Age, "AGE", 500); //0
      apiGrid.AddColumn(Resources.col_Anc, "ANC", 500);
      apiGrid.AddColumn(Resources.col_D_entree, "DPERENT", 1000, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_D_entree_int, "DPERENTINT", 1500, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_Adresse1, "VPERAD1", 1800);
      apiGrid.AddColumn(Resources.col_Adresse2, "VPERAD2", 1100);
      apiGrid.AddColumn(Resources.col_CP, "VPERCP", 700);
      apiGrid.AddColumn(Resources.col_Ville, "VPERVIL", 1200);
      apiGrid.AddColumn(Resources.col_Telephone, "VPERTEL", 1400);     //10
      apiGrid.AddColumn(Resources.col_Portable, "VPERPOR", 1400);
      apiGrid.AddColumn(Resources.col_Fax, "VPERFAX", 1400);
      //apiGrid.AddColumn(Resources.col_Pwd_ internet, "VPERPAS", 1300);
      apiGrid.AddColumn(Resources.col_Adresse_mail, "VPERMAI", 1800);
      apiGrid.AddColumn(Resources.col_D_naiss, "DPERNAI", 1000, "dd/mm/yy");    //15
      apiGrid.AddColumn(Resources.col_D_sortie, "DPERSOR", 1000, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRATSAL", 600);
      apiGrid.AddColumn(Resources.col_College, "VPERCOL", 800);
      apiGrid.AddColumn(Resources.col_Niv, "VPERNIV", 500, "", 2);       //20
      apiGrid.AddColumn(Resources.col_Echelon, "VPERECH", 500, "", 2);
      apiGrid.AddColumn(Resources.col_Cat, "VPERCAT", 500, "", 2);
      apiGrid.AddColumn(Resources.col_Coeff, "VPERCOE", 600);
      apiGrid.AddColumn(Resources.col_H_mois, "NPERHEU", 600);
      apiGrid.AddColumn(Resources.col_Salaire_brut, "NPERSAL", 1200, "Currency", 1); //25
      apiGrid.AddColumn(Resources.col_Cout_H, "NPERCOU", 800, "Currency", 1);
      apiGrid.AddColumn(Resources.col_Visite_medicale, "DPERVIS", 1000, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_Habilitation, "DPERHAB", 1000, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_D_avance, "DPERAVF", 1000, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_E_avance, "NPERMAV", 1100, "Currency", 1);  //30
      apiGrid.AddColumn(Resources.col_Code_std, "NPERSTD", 700, "", 2);
      apiGrid.AddColumn(Resources.col_Permis, "VPERPERMI", 700, "", 2);
      apiGrid.AddColumn(Resources.col_NumPersonne, "NPERNUM", 0);
      apiGrid.AddColumn(Resources.col_Actif, "CPERACTIF", 0);

      apiGrid.InitColumnList();
      apiGrid.dgv.Columns[5].Visible = false;

    }
  }
}

