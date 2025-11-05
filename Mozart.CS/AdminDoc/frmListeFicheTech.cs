using Microsoft.VisualBasic;
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
  public partial class frmListeFicheTech : Form
  {
    public string mstrTypeFiche = "";
    DataTable dtFicheTech;

    //'**********************************************************************************************************************************************************
    // Form paramètrable :
    // Utilisé pour documents Normes, Fiches Techniques, Administratifs EMALEC
    //'**********************************************************************************************************************************************************


    public frmListeFicheTech()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmListeFicheTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        dtFicheTech = new DataTable();

        //   remplir combo societe (pour la copie des docs)
        ModuleData.RemplirCombo(cboSociete, "SELECT NSOCIETEID, VSOCIETENOM  FROM TSOCIETE WHERE VSOCIETEACTIF='O' and  VSOCIETENOM not in ('SAMSICROMANIA','ALC','SAMSICITALIA') ORDER BY VSOCIETENOM");
        cboSociete.ValueMember = "NSOCIETEID";
        cboSociete.DisplayMember = "VSOCIETENOM";

        LoadGrid();
        InitGrid();
        Label1.Text = this.Text;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void LoadGrid()
    {
      string sSql = "";
      switch (mstrTypeFiche)
      {
        case "N":
          this.Text = Resources.txt_fichesNomes;
          sSql = "select NID, VLIBNORME, VTITRENORME, DDATENORME, VFICNORME AS VFIC, VTECHNORME, CACTIF  From TFICHENORME " +
                 "where CACTIF = 'O' AND VSOCIETE = '" + MozartParams.NomSociete + "'  order by VLIBNORME";
          break;
        case "FQ":
          this.Text = Resources.col_fiche_secu;
          sSql = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'FP' and CACTIF = 'O' " +
                 "AND VSOCIETE = '" + MozartParams.NomSociete + "' and ID not in (59,60) ORDER BY TITRE";
          break;
        case "PR":
          this.Text = Resources.txt_fichesProceRegle;
          sSql = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'AD' and CACTIF = 'O' " +
                 "AND VSOCIETE = '" + MozartParams.NomSociete + "' ORDER BY TITRE";
          break;
        case "FT":
          this.Text = Resources.col_fiche_tech;
          sSql = "SELECT ID, TITRE, VFICTECH AS VFIC, DDATEPUB, VCLASSEMENT, CACTIF From TFICHETECH where type = 'FT' and CACTIF = 'O' " +
                 "AND VSOCIETE = '" + MozartParams.NomSociete + "' ORDER BY VCLASSEMENT, TITRE";
          break;
        default:
          break;
      }

      apiTGrid_FicheTech.LoadData(dtFicheTech, MozartDatabase.cnxMozart, sSql);
      apiTGrid_FicheTech.GridControl.DataSource = dtFicheTech;
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      switch (mstrTypeFiche)
      {
        case "N":
          frmDetailNorme f = new frmDetailNorme();
          f.mlIDNORME = 0;
          f.ShowDialog();
          break;
        case "FQ":
          frmDetailFicheTech fdft = new frmDetailFicheTech();
          fdft.miIDFICTECH = 0;
          fdft.msTypeFiche = "FP";
          fdft.ShowDialog();
          break;
        case "PR":
          frmDetailFicheTech fdft2 = new frmDetailFicheTech();
          fdft2.miIDFICTECH = 0;
          fdft2.msTypeFiche = "AD";
          fdft2.ShowDialog();
          break;
        case "FT":
          frmDetailFicheTech fdft3 = new frmDetailFicheTech();
          fdft3.miIDFICTECH = 0;
          fdft3.msTypeFiche = "FT";
          fdft3.ShowDialog();
          break;
      }
      LoadGrid();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
      if (row == null) return;

      switch (mstrTypeFiche)
      {
        case "N":
          frmDetailNorme f = new frmDetailNorme();
          f.mlIDNORME = Convert.ToInt64(row["NID"]);
          f.ShowDialog();
          break;
        case "FQ":
          frmDetailFicheTech fdft1 = new frmDetailFicheTech();
          fdft1.miIDFICTECH = Convert.ToInt64(row["ID"]);
          fdft1.msTypeFiche = "FP";
          fdft1.ShowDialog();
          break;
        case "PR":
          frmDetailFicheTech fdft2 = new frmDetailFicheTech();
          fdft2.miIDFICTECH = Convert.ToInt64(row["ID"]);
          fdft2.msTypeFiche = "AD";
          fdft2.ShowDialog();
          break;
        case "FT":
          frmDetailFicheTech fdft3 = new frmDetailFicheTech();
          fdft3.miIDFICTECH = Convert.ToInt64(row["ID"]);
          fdft3.msTypeFiche = "FT";
          fdft3.ShowDialog();
          break;
      }

      apiTGrid_FicheTech.Requery(dtFicheTech, MozartDatabase.cnxMozart);

    }

    private void cmdArch_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
      if (row == null) return;

      switch (mstrTypeFiche)
      {
        case "N":
          if (MessageBox.Show(Resources.msg_ConfirmArchFichNorm, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            ModuleData.ExecuteNonQuery("UPDATE TFICHENORME SET CACTIF='N' WHERE NID = " + row["NID"]);
          break;
        case "FQ":
        case "PR":
        case "FT":
          if (MessageBox.Show(Resources.msg_ConfirmArchFiche, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            ModuleData.ExecuteNonQuery("UPDATE TFICHETECH SET CACTIF='N' WHERE ID = " + row["ID"]);
          break;
      }
      apiTGrid_FicheTech.Requery(dtFicheTech, MozartDatabase.cnxMozart);
    }

    private void cmdCopier_Click(object sender, EventArgs e)
    {
      Frame1.Visible = true;
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
        if (row == null) return;

        string sBaseRep;

        switch (mstrTypeFiche)
        {
          case "N":
            sBaseRep = Utils.RechercheParam("REP_FICHE_NORME");
            break;
          case "FQ":
          case "PR":
          case "FT":
            sBaseRep = Utils.RechercheParam("REP_FICHETECH");
            break;

          default:
            sBaseRep = "";
            break;
        }

        frmBrowser f = new frmBrowser
        {
          //msStartingAddress = Utils.OpenFileImpersonated(sBaseRep + row["VFIC"].ToString())
          msStartingAddress = CImpersonation.OpenFileImpersonated(sBaseRep + row["VFIC"].ToString())
        };
        f.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
      if (row == null) return;

      string sSql;
      string sChemin;

      try
      {
        //   on ne peut pas copier sur la société en cours
        if (MozartParams.NomSociete == cboSociete.Text)
        {
          MessageBox.Show(Resources.msg_pasCopierSociEnCours, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  Génération d'un numéro de fichier
        string sNomFichier = cboSociete.Text + Strings.Format(DateTime.Now, "yyyyddmmhhmmss") + "." + Strings.Right(row["VFIC"].ToString(), 3);

        switch (mstrTypeFiche)
        {
          case "N":
            sSql = "INSERT INTO TFICHENORME (VTITRENORME, VLIBNORME, DDATENORME, VFICNORME, VTECHNORME, VSOCIETE) " +
                  $" SELECT  VTITRENORME, VLIBNORME, DDATENORME, '{sNomFichier}', VTECHNORME, '{cboSociete.Text}' " +
                  $" FROM TFICHENORME WHERE NID = {row["NID"]}";
            ModuleData.ExecuteNonQuery(sSql);

            //      copie du nouveau fichier
            sChemin = Utils.RechercheParam("REP_FICHE_NORME");
            CImpersonation.CopyFileImpersonated(sChemin + row["VFIC"].ToString(), sChemin + sNomFichier);
            break;

          case "FQ":
          case "PR":
          case "FT":
            sSql = "INSERT INTO TFICHETECH (TITRE, TYPE, VFORMAT, VFICTECH, DDATEPUB, VCLASSEMENT, VSOCIETE) " +
                  $" SELECT TITRE, TYPE, VFORMAT, '{sNomFichier}', DDATEPUB, VCLASSEMENT,'{cboSociete.Text}' " +
                  $" FROM TFICHETECH WHERE ID = {row["ID"]}";
            ModuleData.ExecuteNonQuery(sSql);

            //      copie du nouveau fichier
            sChemin = Utils.RechercheParam("REP_FICHETECH");
            CImpersonation.CopyFileImpersonated(sChemin + row["VFIC"].ToString(), sChemin + sNomFichier);
            break;
        }
        Frame1.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      } finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void CmdStatCliCom_Click(object sender, EventArgs e)
    {
      Frame1.Visible = false;
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      frmListeFicheTechArch f = new frmListeFicheTechArch
      {
        mstrTypeFiche = mstrTypeFiche
      };
      f.ShowDialog();
      apiTGrid_FicheTech.Requery(dtFicheTech, MozartDatabase.cnxMozart);
    }

    private void InitGrid()
    {
      switch (mstrTypeFiche)
      {
        case "N":
          apiTGrid_FicheTech.AddColumn(Resources.col_norme_reglement, "VTITRENORME", 2400, "", 0, true);
          apiTGrid_FicheTech.AddColumn(Resources.col_Technique, "VTECHNORME", 2400);
          apiTGrid_FicheTech.AddColumn(Resources.col_Lbl, "VLIBNORME", 6000, "", 0, true);
          apiTGrid_FicheTech.AddColumn(Resources.col_publication, "DDATENORME", 1500, "", 2);
          break;

        case "FQ":
        case "PR":
          apiTGrid_FicheTech.AddColumn(Resources.col_fiche_secu, "TITRE", 10800);
          apiTGrid_FicheTech.AddColumn(Resources.col_publication, "DDATEPUB", 1500, "", 2);
          break;

        case "FT":
          apiTGrid_FicheTech.AddColumn(Resources.col_Serie, "VCLASSEMENT", 2800);
          apiTGrid_FicheTech.AddColumn(Resources.col_fiche_tech, "TITRE", 8000);
          apiTGrid_FicheTech.AddColumn(Resources.col_publication, "DDATEPUB", 1500, "", 2);
          break;
      }

      apiTGrid_FicheTech.InitColumnList();
    }
  }
}