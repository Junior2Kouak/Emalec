using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeSousTraitant : Form
  {
    public frmListeSousTraitant() { InitializeComponent(); }

    private DataTable dtSTF = new DataTable();
    private string sSTF = "";


    private void frmListeSousTraitant_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sql = "";
        if (MozartParams.NomSociete == "SAMSICROMANIA")
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF INNER JOIN TPER ON TPER.NPERNUM=TSTF.NSTFQUICREE WHERE (NSTFGRPTYPMNT = 1 OR NSTFGRPTYPINST = 1 OR NSTFGRPTYPGAR = 1) AND VSOCIETE='SAMSICROMANIA' ORDER BY VSTFNOM, VSTFVIL";
        else
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF WHERE (NSTFGRPTYPMNT = 1 OR NSTFGRPTYPINST = 1 OR NSTFGRPTYPGAR = 1)  ORDER BY VSTFNOM, VSTFVIL";
        txtCritSTF.Init(MozartDatabase.cnxMozart, sql, "NSTFNUM", "VSTFNOM",
                          new List<string>() { Resources.col_Num, Resources.col_Nom, Resources.col_Ville }, 500, 550, true);

        txtCritSTF.NewValues = true;

        InitPays();
        InitCategories();

        cboTypeSTT.SelectedIndex = 0;

        InitGrid();
        Cursor = Cursors.Default;

        apiTGrid1.AddColumn("Client", "vclinom", 1300);
        apiTGrid1.AddColumn("Site", "vsitnom", 1300);
        apiTGrid1.InitColumnList();

        //couleur bouton docs à valider
        CouleurBtn();
      }

      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void frmListeSousTraitant_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
    }
    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        string p_VSTFNOM = txtCritSTF.GetText() == "" ? "T$" : txtCritSTF.GetText();
        string p_VINTNOM = txtCritINTNOM.Text == "" ? "T$" : txtCritINTNOM.Text;
        string p_VSTFDEPART = txtCritSTFDEP.Text == "" ? "T$" : txtCritSTFDEP.Text;
        string p_VSTFVILLES = cboVillesCibles.Text == "" ? "T$" : cboVillesCibles.Text;
        string p_VSTFPAYS = cboPays.Text == "" ? "T$" : cboPays.Text;
        string p_VSTFACTIV = txtCritSTFACTIV.Text == "" ? "T$" : txtCritSTFACTIV.Text;
        string p_VSTFSIRET = txtCritSIRET.Text == "" ? "T$" : txtCritSIRET.Text;

        string p_NEWVSTFACTIV = "";
        if (cboCategories.Text != "")
        {
          // Une activité de sélectionnée
          if (cboPrestations.Text.ToUpper() == "TOUTES PRESTATIONS" || cboPrestations.Text.ToUpper() == "")
            p_NEWVSTFACTIV = cboCategories.Text;
          else
            p_NEWVSTFACTIV = cboPrestations.Text;
        }
        else
          p_NEWVSTFACTIV = "T$";

        if (cboTypeSTT.Text == "Tous")
          sSTF = $"EXEC api_sp_listeSTF_v3 'ST_INS', '{p_VSTFNOM}', '{p_VINTNOM}', '{p_VSTFDEPART}', '{p_VSTFVILLES.Replace("'", "''")}', '{p_VSTFPAYS}', '{p_VSTFACTIV}', '{p_NEWVSTFACTIV.Replace("'", "''")}', 0, '{p_VSTFSIRET.Replace("'", "''")}'";
        else if (cboTypeSTT.SelectedText == "Maintenance")
          sSTF = $"EXEC api_sp_listeSTF_v3 'ST', '{p_VSTFNOM}', '{p_VINTNOM}', '{p_VSTFDEPART}', '{p_VSTFVILLES.Replace("'", "''")}', '{p_VSTFPAYS}', '{p_VSTFACTIV}', '{p_NEWVSTFACTIV.Replace("'", "''")}', 0, '{p_VSTFSIRET.Replace("'", "''")}'";
        else if (cboTypeSTT.SelectedText == "Installation")
          sSTF = $"EXEC api_sp_listeSTF_v3 'INS', '{p_VSTFNOM}', '{p_VINTNOM}', '{p_VSTFDEPART}', '{p_VSTFVILLES.Replace("'", "''")}', '{p_VSTFPAYS}', '{p_VSTFACTIV}', '{p_NEWVSTFACTIV.Replace("'", "''")}', 0, '{p_VSTFSIRET.Replace("'", "''")}'";

        Grid.LoadData(dtSTF, MozartDatabase.cnxMozart, sSTF);
        Grid.GridControl.DataSource = dtSTF;

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitPays()
    {
      try
      {
        ModuleData.RemplirCombo(cboPays, "SELECT DISTINCT PAYS, MIN(ID) AS ID FROM TVILLES GROUP BY PAYS ORDER BY PAYS");
        cboPays.ValueMember = "PAYS";
        cboPays.DisplayMember = "PAYS";
        cboPays.SelectedValue = "FRANCE";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitCategories()
    {
      try
      {
        ModuleData.RemplirCombo(cboCategories, "SELECT DISTINCT VCATEGORIE, MIN(ID) AS ID FROM TACTIVITES GROUP BY VCATEGORIE ORDER BY VCATEGORIE");
        cboCategories.ValueMember = "VCATEGORIE";
        cboCategories.DisplayMember = "VCATEGORIE";
        cboCategories.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboCategories_SelectedValueChanged(object sender, EventArgs e)
    {
      if (cboCategories.Text != "")
      {
        cboPrestations.Visible = true;
        InitPrestation();
      }
      else
        cboPrestations.Visible = false;
    }

    private void InitPrestation()
    {
      try
      {
        ModuleData.RemplirCombo(cboPrestations, $"SELECT ID, VACTIVITE FROM TACTIVITES WHERE VCATEGORIE = '{cboCategories.Text}' ORDER BY VACTIVITE");
        cboPrestations.ValueMember = "ID";
        cboPrestations.DisplayMember = "VACTIVITE";
        cboPrestations.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitVillesCibles()
    {
      try
      {
        ModuleData.RemplirCombo(cboVillesCibles, $"SELECT ID, VILLE FROM TVILLES WHERE PAYS = '{cboPays.Text}' ORDER BY VILLE");
        cboVillesCibles.ValueMember = "ID";
        cboVillesCibles.DisplayMember = "VILLE";

        cboVillesCibles.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifierSiteSTF_Click(object sender, EventArgs e)
    {
      DataRow currentRow = Grid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmDetailsSiteSTF()
      {
        mstrStatut = "M",
        miNumSTFGRP = Convert.ToInt64(currentRow["NSTFGRPNUM"]),
        miNumSTF = Convert.ToInt64(currentRow["STFNUM"])
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      Grid.Requery(dtSTF, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void CmdDiSTT_Click(object sender, EventArgs e)
    {
      new frmListeDISTT().ShowDialog();
    }

    private void cmdListeDevis_Click(object sender, EventArgs e)
    {
      //affichage de la liste des devis pour ce sous traitant
      new frmListeDevisST()
      {
        mstrStatutDevis = "T"
      }.ShowDialog();

    }

    private void cmdListeContrats_Click(object sender, EventArgs e)
    {
      // affichage de la liste des contrats pour ce sous traitant
      new frmListeContratsST()
      {
        mstrStatutContrat = "T"
      }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

		private void cmdOTM_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			new frmListeOTM()
			{
				mstrStatut = "B" //affichage de tous les OTM
			}.ShowDialog();

			Cursor = Cursors.Default;
		}

		private void CmdOM_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      new frmListeOM()
      {
        mstrStatut = "B" //affichage de tous les OM
      }.ShowDialog();

      Cursor = Cursors.Default;
    }

    private void cmdOG_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmListeOGS()
      {
        mstrStatut = "B" //affichage de tous les OM
      }.ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdPlanContrat_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmPlanContratST().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdPlanDevis_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmPlanDevisST().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdDocsAverifier_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmSousTenCours().ShowDialog();
      Cursor = Cursors.Default;

      //couleur bouton docs à valider
      CouleurBtn();
    }

    private void cmdRelance_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmRelanceST().ShowDialog();
      Cursor = Cursors.Default;
    }

    public void InitGrid()
    {
      try
      {
        Grid.AddColumn("Num.", "NSTFNUM", 0);
        Grid.AddColumn("NINTNUM", "NINTNUM", 0);
        Grid.AddColumn(Resources.col_groupe, "VSTFGRPNOM", 1300);
        Grid.AddColumn(Resources.col_Site, "VSTFNOM", 1300, "", 0, true);
        Grid.AddColumn(Resources.col_Contact, "VINTNOM", 1300);
        Grid.AddColumn(Resources.col_Telephone, "VINTTEL", 1000);
        Grid.AddColumn(Resources.col_Portable, "VINTPOR", 1000);
        Grid.AddColumn(Resources.col_astreinte, "VSTFTEL", 1000);
        Grid.AddColumn(Resources.txt_Mail, "VINTMAIL", 1000);
        Grid.AddColumn("NCT", "NCT", 400);
        Grid.AddColumn("Dépendance", "TAUX", 500, "", 2);
        Grid.AddColumn("Note", "NSTFGRPNOTE", 500, "", 2);
        Grid.AddColumn("€H", "NSTFMOE", 500, "", 2);
        Grid.AddColumn("€Dp", "NSTFDEP", 500, "", 2);
        Grid.AddColumn("€Hast", "NSTFASTR", 500, "", 2);
        Grid.AddColumn("Prix Contrat Cadre", "NSTFGRPCONTRATCADRE", 400, "", 2);
        Grid.AddColumn(Resources.col_CP, "VSTFCP", 600);
        Grid.AddColumn("Villes cibles", "VListeVillesRecherche", 2100, "", 0, true);
        Grid.AddColumn(Resources.col_Observations, "VSTFOBS", 2500, "", 0, true);
        Grid.AddColumn("Activités", "VListeActivitesRecherche", 3400, "", 0, true);
        Grid.AddColumn("Date création STT", "DSTFCREE", 900, "dd/MM/yy");
        Grid.AddColumn(Resources.col_Fax, "VINTFAX", 1300);
        //Grid.AddColumn("IMPOSE", "IMPOSE", 800);
        Grid.AddColumn(Resources.col_Pays, "VSTFPAYS", 1300);
        Grid.AddColumn("Siret", "VSTFSIRET", 1300);
        Grid.AddColumn("Type STT", "VstfEtrType", 800);
        Grid.AddColumn("F", "F", 0);
        Grid.AddColumn(Resources.col_interdit, "INTERDIT", 1000);
        Grid.AddColumn("PRIVILEGE", "CSTFGRPP3M", 0);
        Grid.AddColumn("BSTFGRPDOCADM", "BSTFGRPDOCADM", 0);

        Grid.InitColumnList();
        Grid.dgv.OptionsView.ColumnAutoWidth = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Grid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CSTFGRPP3M"].ToString() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorHDDFFBB;
          e.HighPriority = true;
        }
        if (View.GetDataRow(e.RowHandle)["BSTFGRPDOCADM"].ToString() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH80FFFF;
          e.HighPriority = true;
        }
        if (View.GetDataRow(e.RowHandle)["INTERDIT"].ToString() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH8080FF;
          e.HighPriority = true;
        }
      }
    }

    private void CmdGestDocAdminSTF_Click(object sender, EventArgs e)
    {
      new frmStatDocAdminSTF().ShowDialog();
    }

    private void cboPays_SelectedValueChanged(object sender, EventArgs e)
    {
      InitVillesCibles();
    }

    private void cmdCarteSTT_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      // UPGRADE_INFO (#0501): The 'rsSTF3' member isn't used anywhere in current application.
      int nbSTF = 0;
      if (Grid.dgv.ActiveFilter.Count == 0)
      {
        MessageBox.Show("Vous devez d'abord faire un filtre pour limiter le nombre de résultats.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        Cursor = Cursors.Default;
        return;
      }

      bool bPremPassage = true;
      bool bPremPassage2 = true;

      int icone = 0;
      string paysprec = "";

      //va rechercher le nombre de lignes affichées 
      if (Grid.dgv.RowCount == 0) return;

      DataTable dtTemp = new DataTable();

      dtTemp = dtSTF.Clone();
      dtTemp.Rows.Clear();

      for (int i = 0; i < Grid.dgv.RowCount; i++)
      {
        DataRow row = Grid.dgv.GetDataRow(i);
        dtTemp.Rows.Add(row.ItemArray);
      }

      DataView dvTemp = dtTemp.DefaultView;
      dvTemp.Sort = "VSTFPAYS ASC, vstfgrpnom ASC";
      DataTable dtFinale = dvTemp.ToTable();

      foreach (DataRow dr in dtFinale.Rows)
      {
        string vnom = "";
        string vnum = "";
        string vstfEtrType = "";

        using (SqlDataReader sdrSTF2 = ModuleData.ExecuteReader($"select nstfnum, vstfnom, vstfpays, vstfgrppays, vstfetrtype, VListeVilles, NBCONTRATSST12M from tstf inner join tstfgrp on tstfgrp.nstfgrpnum = tstf.nstfgrpnum left outer join tnotes on tnotes.nnotcle = tstfgrp.nstfgrpnum where cstfactif = 'O' and tstf.nstfgrpnum = {dr["NSTFGRPNUM"]} AND ISNULL(TNOTES.CNOTINTERDIT, 'N') = 'N' order by vstfpays"))
        {

          int countSdrSTF2 = 0;

          while (sdrSTF2.Read())
          {
            countSdrSTF2++;

            // On cherche les pays sélectionnés pour aboir des icônes de couleurs différentes sur la carte
            if (paysprec != sdrSTF2["vstfgrppays"].ToString())
            {
              paysprec = sdrSTF2["vstfgrppays"].ToString();
              if (icone < 10) icone++; // 10 icones différentes au maxi, sur la google map
            }

            vnom = sdrSTF2["VSTFNOM"].ToString();
            vnum = sdrSTF2["NSTFNUM"].ToString();
            vstfEtrType = Utils.BlankIfNull(sdrSTF2["vstfetrtype"].ToString());

            int couleur;
            if (Convert.ToInt32(sdrSTF2["NBCONTRATSST12M"]) > 0) couleur = 1;
            else couleur = 0;

            // stocker les données à afficher dans la table temporaire TTMP_STTPartenaires
            if (bPremPassage)
            {
              ModuleData.ExecuteNonQuery($"EXEC api_sp_Initialiser_TTMP_STTPartenaires {MozartParams.UID}, {vnum}, '{vnom.Replace("'", "''")}', '{dr["VSTFGRPNOM"].ToString().Replace("'", "''")}', '{vstfEtrType}', {couleur}, 1");
              bPremPassage = false;
            }
            else
              ModuleData.ExecuteNonQuery($"EXEC api_sp_Initialiser_TTMP_STTPartenaires {MozartParams.UID}, {vnum}, '{vnom.Replace("'", "''")}', '{dr["VSTFGRPNOM"].ToString().Replace("'", "''")}', '{vstfEtrType}', {couleur}, 0");

            if (Utils.BlankIfNull(sdrSTF2["VListeVilles"]) != "")
            {
              string[] lstVilles = sdrSTF2["VListeVilles"].ToString().Remove(sdrSTF2["VListeVilles"].ToString().Length - 1).Split(';'); //remove le dernier ;
              for (int i = 0; i < lstVilles.Length; i++)
              {
                using (SqlDataReader sdrVil = ModuleData.ExecuteReader($"select pays, ville from tvilles where id = {lstVilles[i]}"))
                {
                  if (sdrVil.Read())
                  {
                    // Stocker les données à afficher dans la table temporaire TTMP_STTPartenaires2
                    if (bPremPassage2)
                    {
                      ModuleData.ExecuteNonQuery($"EXEC api_sp_Initialiser_TTMP_STTPartenaires2 {MozartParams.UID}, {sdrVil["pays"]}, '{sdrVil["ville"].ToString().Replace("'", "''")}', {icone}, 1");
                      bPremPassage2 = false;
                    }
                    else
                      ModuleData.ExecuteNonQuery($"EXEC api_sp_Initialiser_TTMP_STTPartenaires2 {MozartParams.UID}, {sdrVil["pays"]}, '{sdrVil["ville"].ToString().Replace("'", "''")}', {icone}, 0");
                  }
                }
              }
            }
          }
          nbSTF += countSdrSTF2;
        }
      }

      Cursor = Cursors.Default;

      // Affichage de la map
      // TB SAMSIC CITY SPEC
      if (MozartParams.NomGroupe == "EMALEC")
      {
        frmBrowser f = new frmBrowser();
        f.msStartingAddress = $"https://maps.emalec.com/STT_Selectionnes.asp?BASE=MULTI&NPERNUM={MozartParams.UID}&APP={MozartParams.NomSociete}&NBSTF={nbSTF}";
        f.ShowDialog();
      }
    }

    private void cmdLstClients_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.Visible == false)
      {
        DataRow currentRow = Grid.GetFocusedDataRow();
        if (currentRow == null) return;

        //Lister les clients pour lesquels le STT est imposé
        DataTable dtSTFCli = new DataTable();
        apiTGrid1.LoadData(dtSTFCli, MozartDatabase.cnxMozart, $"select vclinom, vsitnom from tcli inner join tsit on tsit.nclinum = tcli.nclinum inner join tcont on tcont.nsitnum = tsit.nsitnum where tcont.nstfnum = {currentRow["STFNUM"]} and tcont.nintnum = {currentRow["NINTNUM"]} group by vclinom, vsitnom order by vclinom, vsitnom");
        apiTGrid1.GridControl.DataSource = dtSTFCli;
        apiTGrid1.Visible = true;
        apiTGrid1.Focus();
      }
      else
        apiTGrid1.Visible = false;
    }

    private void apiTGrid1_Leave(object sender, EventArgs e)
    {
      apiTGrid1.Visible = false;
    }

    private void CouleurBtn()
    {
      int colorbtn = (int)ModuleData.ExecuteScalarInt("select count(NDOCSTFNUM) from TW2DOCSTF WHERE BDOCVALIDER = 0");
      if (colorbtn > 0) cmdDocsAverifier.BackColor = MozartColors.ColorH80FFFF;
    }

    private void cmdInfoSTT_Click(object sender, EventArgs e)
    {
      //on sort si pas de sites
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      //Nouvelle version générique
      //ajout mc car bug (si on note un stf depuis un action, quand on revient sur cette fenetre depuis l admin->FO/ST, on a toujours le message pour noter le stf)

      new frmSaisieInfoSTT()
      {
        mstrTypeNote = "INFO_STF",
        mbNoteVisible = false,
        miCleTable = (int)row["NSTFGRPNUM"],
      }.ShowDialog();
    }

	}
}
