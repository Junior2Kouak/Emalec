using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestRSF : Form
  {
    private const string PAYS_FRANCE = "FRANCE";

    // Contient le N° de la RSF passé au constructeur lors de l'ouverture de cette fenêtre
    // ATTENTION : Il faut passer par cette variable pour se positionner sur la bonne ligne car le chargement des datas modifie la variable miNumRSF !!!
    private int miInitWithNumRSF;

    private int miNumClient;
    private int miNumRSF;
    private int iNCLITYPOLOGIE;

    private DataTable dt = new DataTable();

    public frmGestRSF(int pNumClient) : this(pNumClient, 0)
    {
    }

    public frmGestRSF(int pNumClient, int pNumRSF)
    {
      InitializeComponent();

      miNumClient = pNumClient;
      miInitWithNumRSF = pNumRSF;
    }

    private void frmGestRSF_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        label20.Visible = txtTVA.Visible = false;

        AddItemCombo(cboRsfTyp, "|CHEQUE|VIREMENT|TRAITE|LCR|MANDAT|BO"); //api_sp_ComboRSFListeType
        //AddItemCombo(cboRsfNbj, "A réception|10 J|20 J|30 J|45 J|60 J|90 J|120 J"); //api_sp_ComboRSFListeNBJ

        ModuleData.RemplirCombo(cboRsfNbj, "api_sp_ComboRSFListeNBJ");
        cboRsfNbj.ValueMember = "NRSFNBJ";
        cboRsfNbj.DisplayMember = "VRSFNBJ";

        AddItemCombo(cboRsfFin, "OUI|NON"); //api_sp_ComboRSFListeFinMois

        ModuleData.RemplirCombo(cboPays, "SELECT NPAYSNUM, VPAYSNOM FROM TPAYS ORDER BY VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        RemplirComboLangues();

        string lSql = $"SELECT NIDBANQUE, VBANQUENOM "; //, BBANQUEDEFAULT";
        lSql += $" FROM TREF_BANQUE WHERE VSOCIETE='{MozartParams.NomSociete}' ORDER BY BBANQUEDEFAULT DESC";
        ModuleData.RemplirCombo(cboBanque, lSql);
        cboBanque.ValueMember = "NIDBANQUE";
        cboBanque.DisplayMember = "VBANQUENOM";

        // TODOFGB : A voir pour les droits et en attendant que le CdC se décante ...
        cboBanque.Enabled = ((MozartParams.strUID == "LEFORT") || (MozartParams.strUID == "GIRAUD-BY"));
        if (!cboBanque.Enabled)
        {
          // TODO FGB : Il faut pouvoir saisir la TVA ....
          //frameTVAIntra.Visible = false;
          //fraReglement.Left = frameTVAIntra.Left;
        }
        // TODOFGB : Fin

        ucGridTvaIntra.initComponent(MozartDatabase.cnxMozart);

        InitApigrid();

        //par défaut champ désactivés
        cmdAnnulerAjout.Visible = cmdValider.Visible = false;

        //  typologie + Nom du client
        string sSql = $"SELECT ISNULL(NCLITYPOLOGIE, 0) AS NCLITYPOLOGIE, VCLINOM FROM TCLI WITH (NOLOCK) WHERE NCLINUM = {miNumClient}";
        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSql))
        {
          if (dr.Read())
          {
            iNCLITYPOLOGIE = Convert.ToInt32(dr["NCLITYPOLOGIE"]);
            lblTitre.Text += Utils.BlankIfNull(dr["VCLINOM"]);

            dr.Close();
          }
        }

        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT distinct * FROM api_v_InfoRaisonSociale WHERE NCLINUM = {miNumClient}");
        ApiGrid.GridControl.DataSource = dt;

        // ATTENTION : On utilise miInitWithNumRSF ici car miNumRSF est modifié lors du chargement de la grille !!!
        if (miInitWithNumRSF != 0)
        {
          DataRow lRSFToSelect = dt.AsEnumerable().Where(x => x.Field<int>("NRSFNUM") == miInitWithNumRSF).First();

          ApiGrid.dgv.ClearSelection();
          // Obligé de mettre les 2 lignes ci-dessous : 1 met le focus et l'autre surligne la ligne : On peut pas le faire en 1 fois ???? GRRRRRR
          ApiGrid.dgv.FocusedRowHandle = dt.Rows.IndexOf(lRSFToSelect);
          ApiGrid.dgv.SelectRow(dt.Rows.IndexOf(lRSFToSelect));
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

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      cmdValider.Visible = cmdAnnulerAjout.Visible = Frame0.Visible = true;
      cmdValiderModifs.Visible = ApiGrid.Visible = false;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAjouter.Tag.ToString(), "SPYACTION");
      OuvertureEnCreation();

      txtNom.Focus();
    }

    private void cmdAide_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"Choix de la langue d'édition des factures", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdAnnulerAjout_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAnnulerAjout.Tag.ToString(), "SPYACTION", "NCLINUM:" + miNumClient);

      cmdValider.Visible = cmdAnnulerAjout.Visible = false;
      cmdValiderModifs.Visible = ApiGrid.Visible = true;

      ApiGrid_SelectionChanged(null, null);
    }

    private void RemplirComboLangues()
    {
      DataTable dtl = new DataTable();
      try
      {
        var dataReader = MozartDatabase.ExecuteReader("SELECT DISTINCT VLANGUEDEFAUT, VLANGUEABR FROM TPAYS ORDER BY VLANGUEDEFAUT");
        dtl.Load(dataReader);
        dataReader.Close();

        foreach (DataRow row in dtl.Rows)
        {
          cboLangue.Items.Add((string)row[0]);
          cboLangueAbrev.Items.Add((string)row[1]);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ApiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = ApiGrid.GetFocusedDataRow();
      if (null == currentRow) return;

      if (dt.Rows.Count > 0)
      {
        Frame0.Visible = true;
        OuvertureEnModification();
      }
      else
      {
        Frame0.Visible = false;
        OuvertureEnCreation();
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      // test du nom
      if (txtNom.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirNomContact);
        txtNom.Focus();
        return;
      }

      if (txtMail.Text != "" &&
          (txtMail.Text.Contains(" ") || !txtMail.Text.Contains("@") || !txtMail.Text.Contains(".")))
      {
        MessageBox.Show(Resources.msg_Adr_mail_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      //  test du pays
      if (cboPays.Text == "")
      {
        MessageBox.Show("Saisissez un pays");
        cboPays.Focus();
        return;
      }
      //  ' langue d'édition des factures
      if (cboLangue.Text == "")
      {
        MessageBox.Show("Sélectionnez une langue");
        return;
      }

      // Professionnels uniquement
      if (iNCLITYPOLOGIE == 2)
      {
        if (txtSiret.Text == "")
        {
          MessageBox.Show(Resources.msg_siret_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        if (cboPays.Text == PAYS_FRANCE)
        {
          if (!ModuleMain.VerifSIRET(txtSiret.Text))
          {
            MessageBox.Show(Resources.msg_siret_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
        }

        //  ' tva intra obligatoire (FG le 04/05/2020)
        //if (txtTVA.Text == "")
        //{
        //  MessageBox.Show(MZCtrlResources.msg_enter_TVA, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //  return;
        //}

        //if (!MZCtrlUtils.VerifTVAIntra(txtTVA.Text, cboPays.Text))
        //{
        //  MessageBox.Show(MZCtrlResources.msg_Code_TVA_intra_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //  return;
        //}
      }

      //if (ucGridTvaIntra.Count() == 0)
      //{
      //  MessageBox.Show(MZCtrlResources.msg_enter_TVA, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  return;
      //}

      if (cboRsfTyp.Text == "")
      {
        MessageBox.Show(Resources.msg_mode_reglement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (cboRsfNbj.Text == "")
      {
        MessageBox.Show(Resources.msg_Type_echeance_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (cboRsfFin.Text == "")
      {
        MessageBox.Show(Resources.msg_Type_reglement_fin_mois_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (cboBanque.GetItemData() <= 0)
      {
        MessageBox.Show(Resources.msg_choixBanque, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdValider.Tag.ToString(), "SPYACTION", "NCLINUM:" + miNumClient);
      Enregistrer();

      cmdValider.Visible = cmdAnnulerAjout.Visible = false;
      cmdValiderModifs.Visible = ApiGrid.Visible = true;
    }

    private void OuvertureEnCreation()
    {
      try
      {
        miNumRSF = 0;

        txtNom.Text = txtService.Text = txtMail.Text = txtAD1.Text = txtAD2.Text = txtCP.Text = txtRegion.Text = txtSiret.Text = txtVille.Text = "";
        //txtTVA.Text = "";

        // Banque par défaut de la filiale
        cboBanque.SelectedItem = 1;
        txtCompteCompta.Text = "";

        //  'select auto en fonction de la typologie du client
        switch (iNCLITYPOLOGIE)
        {
          case 1:
            cboRsfTyp.Text = "VIREMENT";
            cboRsfNbj.Text = "A réception";
            cboRsfFin.Text = "NON";
            txtRsfSup.Text = "";
            cboRsfTyp.Enabled = cboRsfNbj.Enabled = cboRsfFin.Enabled = txtRsfSup.Enabled = false;
            break;

          case 2:
            //professionel
            cboRsfTyp.Text = "VIREMENT";
            cboRsfNbj.Text = "30 J";
            cboRsfFin.Text = "NON";
            txtRsfSup.Text = "";
            cboRsfTyp.Enabled = cboRsfNbj.Enabled = cboRsfFin.Enabled = txtRsfSup.Enabled = true;
            break;

          default:
            cboRsfTyp.Enabled = cboRsfNbj.Enabled = cboRsfFin.Enabled = txtRsfSup.Enabled = false;
            break;
        }

        chkActif.Checked = true;
        cboVille.SelectedIndex = -1;
        cboPays.Text = PAYS_FRANCE;

        apiFilEMALEC.Checked = false;

        ucGridTvaIntra.loadTVAIntra(miNumRSF);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      try
      {
        DataRow currentRow = ApiGrid.GetFocusedDataRow();

        miNumRSF = Convert.ToInt32(currentRow["NRSFNUM"]);

        // combo du pays  (avant txtCP.Text = => evite RechercheCommune avec pays!=FRANCE)    
        cboPays.Text = Utils.BlankIfNull(currentRow["VRSFPAYS"]);
        if (cboPays.SelectedIndex == -1)
        {
          cboPays.Items.Add(Utils.BlankIfNull(currentRow["VSTFPAYS"]));
          cboPays.Text = Utils.BlankIfNull(currentRow["VSTFPAYS"]);
        }
        if (cboPays.Text == "")
          cboPays.Text = PAYS_FRANCE;

        txtNom.Text = Utils.BlankIfNull(currentRow["VRSFRSF"]);
        txtService.Text = Utils.BlankIfNull(currentRow["VRSFSER"]);

        txtAD1.Text = Utils.BlankIfNull(currentRow["VRSFAD1"]);
        txtAD2.Text = Utils.BlankIfNull(currentRow["VRSFAD2"]);
        txtCP.Text = Utils.BlankIfNull(currentRow["VRSFCP"]);
        txtVille.Text = Utils.BlankIfNull(currentRow["VRSFVIL"]);
        txtRegion.Text = Utils.BlankIfNull(currentRow["VRSFREGION"]);

        txtSiret.Text = Utils.BlankIfNull(currentRow["VRSFSIRET"]);
        //txtTVA.Text = Utils.BlankIfNull(currentRow["VRSFTVAINTRA"]);

        txtMail.Text = Utils.BlankIfNull(currentRow["VRSFMAI"]);

        if (Utils.BlankIfNull(currentRow["VRSFTYP"]) != "")
          cboRsfTyp.Text = Utils.BlankIfNull(currentRow["VRSFTYP"]);
        if (Utils.BlankIfNull(currentRow["NRSFNBJ"]) != "")
          cboRsfNbj.SelectedValue = Utils.BlankIfNull(currentRow["NRSFNBJ"]);
        if (Utils.BlankIfNull(currentRow["NRSFFIN"]) != "")
          cboRsfFin.Text = Utils.BlankIfNull(currentRow["NRSFFIN"]);
        txtRsfSup.Text = Utils.BlankIfNull(currentRow["NRSFSUP"]);

        // combo de la ville
        if (!cboVille.Items.Contains(Utils.BlankIfNull(currentRow["VRSFVIL"])))
          cboVille.Items.Add(Utils.BlankIfNull(currentRow["VRSFVIL"]));
        cboVille.SelectedItem = Utils.BlankIfNull(currentRow["VRSFVIL"]);

        //   ' combo de la langue (04/04/2016)
        cboLangueAbrev.Text = Utils.BlankIfNull(currentRow["VRSFLANGUE"]) == "" ? "FR" : Utils.BlankIfNull(currentRow["VRSFLANGUE"]);
        cboLangue.SelectedIndex = cboLangueAbrev.SelectedIndex;

        chkActif.Checked = (currentRow["CRSFETATACTIF"].ToString() == "OUI");

        txtCompteCompta.Text = Utils.BlankIfNull(currentRow["VRSFCPT8"]);
        cboBanque.SetItemData(Utils.BlankIfNull(currentRow["NIDBANQUE"]));

        cboPays_SelectedIndexChanged(null, null);

        txtCompteCompta.Enabled = ModuleMain.RechercheDroitMenu(739);

        apiFilEMALEC.Checked = Convert.ToBoolean(currentRow["BFILIALEEMALEC"]);

        ucGridTvaIntra.loadTVAIntra(miNumRSF);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Enregistrer()
    {
      try
      {
        int lNewId;

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationRSF2", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          cmd.Parameters["@nRSFNUM"].Value = miNumRSF;   // 0 si création
          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@vNomRSF"].Value = txtNom.Text.ToUpper();
          cmd.Parameters["@vService"].Value = txtService.Text;
          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCP"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = (cboPays.Text == PAYS_FRANCE) ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@cActif"].Value = chkActif.Checked ? "O" : "N";
          cmd.Parameters["@vType"].Value = cboRsfTyp.Text;
          cmd.Parameters["@vEcheance"].Value = cboRsfNbj.Text;
          cmd.Parameters["@nNbj"].Value = cboRsfNbj.SelectedValue;
          cmd.Parameters["@vFinDeMois"].Value = cboRsfFin.Text;
          cmd.Parameters["@nSup"].Value = (txtRsfSup.Text == "") ? 0 : Convert.ToInt32(txtRsfSup.Text);
          cmd.Parameters["@vSiret"].Value = txtSiret.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;
          cmd.Parameters["@vRegion"].Value = txtRegion.Text;
          cmd.Parameters["@vMail"].Value = txtMail.Text;
          //cmd.Parameters["@vRSFTvaIntra"].Value = txtTVA.Text;
          cmd.Parameters["@vRSFTvaIntra"].Value = "";
          cmd.Parameters["@vlangueabr"].Value = cboLangueAbrev.Text;
          cmd.Parameters["@vCptCompta"].Value = txtCompteCompta.Text;
          cmd.Parameters["@nIdBanque"].Value = cboBanque.GetItemData();
          cmd.Parameters["@bFilialeEMALEC"].Value = apiFilEMALEC.Checked ? 1 : 0;

          lNewId = Convert.ToInt32(cmd.ExecuteScalar());

          if (miNumRSF == 0)
          {
            MessageBox.Show(Resources.msg_oubliez_pas_RSF, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        ApiGrid.Requery(dt, MozartDatabase.cnxMozart);

        DataRow lRSFToSelect = dt.AsEnumerable().Where(x => x.Field<int>("NRSFNUM") == lNewId).First();
        ApiGrid.dgv.FocusedRowHandle = dt.Rows.IndexOf(lRSFToSelect);

        ApiGrid_SelectionChanged(null, null);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      ApiGrid.AddColumn("CliNum", "NCLINUM", 0);
      ApiGrid.AddColumn(Resources.col_Nom, "VRSFRSF", 2200);
      ApiGrid.AddColumn(Resources.col_Service, "VRSFSER", 0);
      ApiGrid.AddColumn(Resources.col_Adresse1, "VRSFAD1", 1400);
      ApiGrid.AddColumn(Resources.col_Adresse2, "VRSFAD2", 1400);
      ApiGrid.AddColumn(Resources.col_CP, "VRSFCP", 700);
      ApiGrid.AddColumn(MZCtrlResources.col_Ville, "VRSFVIL", 2000);
      ApiGrid.AddColumn(MZCtrlResources.col_Pays, "VRSFPAYS", 1200);
      ApiGrid.AddColumn("Compte comptable", "VRSFCPT8", 1000, "", 3);
      ApiGrid.AddColumn(Resources.col_Type, "VRSFTYP", 0);
      ApiGrid.AddColumn(Resources.col_Nbj, "NRSFNBJ", 0);
      ApiGrid.AddColumn(Resources.col_Fin, "NRSFFIN", 0);
      ApiGrid.AddColumn(Resources.col_Sup, "NRSFSUP", 0);
      ApiGrid.AddColumn(Resources.col_APE, "VRSFAPE", 0);
      ApiGrid.AddColumn(Resources.col_Siret, "VRSFSIRET", 0);
      ApiGrid.AddColumn(MZCtrlResources.col_Actif, "CRSFETATACTIF", 1200);
      ApiGrid.AddColumn("@ Mail", "VRSFMAI", 1200);
      ApiGrid.AddColumn("NRSFNUM", "NRSFNUM", 0);

      ApiGrid.InitColumnList();
    }

    private void AddItemCombo(ComboBox cbo, string Items)
    {
      string[] f = Items.Split('|');
      foreach (string item in f)
        cbo.Items.Add(item);
    }

    private void frmGestRSF_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.Text.Length > 1 && cboPays.Text == PAYS_FRANCE)
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
    }

    private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cboPays.Text != PAYS_FRANCE)
      {
        lblSIRET.Text = "N° d'identification";
        txtVille.Visible = true;
        cboVille.Visible = cmdRecherche.Visible = false;
      }
      else
      {
        lblSIRET.Text = "SIRET";
        txtVille.Visible = false;
        cboVille.Visible = cmdRecherche.Visible = true;
      }
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal
      {
        ControlCible1 = txtCP,
        ControlCible2 = cboVille
      }.ShowDialog();
    }

    private void cboLangue_Validated(object sender, EventArgs e)
    {
      cboLangueAbrev.SelectedIndex = cboLangue.SelectedIndex;
    }

    private void ucGridTvaIntra_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      GridView view = sender as GridView;
      string lRowPays = (string)view.GetRowCellValue(e.RowHandle, "VRSFTVAINTRAPAYS");
      if (cboPays.Text == lRowPays)
      {
        e.Appearance.BackColor = Color.Yellow;
        e.HighPriority = true;
      }
    }
  }
}