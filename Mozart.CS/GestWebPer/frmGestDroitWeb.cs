using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmGestDroitWeb : Form
  {
    private class ListPrestationItemData
    {
      public string VPRELIB;
      public char CPRECOD;
      public override string ToString()
      {
        return this.VPRELIB;
      }
    }

    private class ListCategorieItemData
    {
      public string VTYPECONTRAT;
      public int NTYPECONTRAT;
      public override string ToString()
      {
        return this.VTYPECONTRAT;
      }
    }

    private class ListEnseigneItemData
    {
      public string VSITENSEIGNE;
      public int index;
      public override string ToString()
      {
        return this.VSITENSEIGNE;
      }
    }

    public int miNumClient;
    public string mstrStatut;
    public int miLogin;
    private int NbCoche;
    private DataTable dtArt = new DataTable();
    private DataTable dtArtArch = new DataTable();
    private bool bModif;

    public frmGestDroitWeb()
    {
      InitializeComponent();
      GridLocalizer.Active = new CustomGridLocalizer();
    }
    class CustomGridLocalizer : GridLocalizer
    {
      public override string GetLocalizedString(GridStringId id)
      {
        if (id == GridStringId.CheckboxSelectorColumnCaption)
        {
          return " ";
        }
        return base.GetLocalizedString(id);
      }
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmGestDroitWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        //  liste des contrats
        RemplirListeCategories();
        //  si on est en creation, on coche tous les contrats
        //  sinon, selon restriction ou pas on coche tous ou seulement ce qu'il faut

        //  liste des prestations
        RemplirListePrestation();

        //  gestion des enseignes
        RemplirListeEnseignes();

        if (mstrStatut == "C")
        {
          txtUtilisateur.Text = "";
          TxtPwd.Text = "";
          txtValid.Text = "99999";
          cboDroit.Text = "OUI";
          cmdCocherTC();
          cmdArch.Enabled = false;
        }
        else
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from TACCESWEB WHERE NACCNUM={miLogin}"))
          {
            if (reader.Read())
            {
              txtUtilisateur.Text = Utils.BlankIfNull(reader["VUTILOG"]);
              TxtPwd.Text = Utils.BlankIfNull(reader["VUTIPWD"]);
              txtValid.Text = Utils.BlankIfNull(reader["NUTIMTVAL"]);
              txtMini.Text = Utils.BlankIfNull(reader["NUTIMINI"]);
              cboDroit.Text = Utils.BlankIfNull(reader["VUTIDROIT"]);
              chkContrat.Checked = Convert.ToBoolean(reader["BRESTCTR"]);
              if (!chkContrat.Checked) cmdCocherTC();
              else chkContrat_Click(null, null);
              chkLogin.Checked = Convert.ToBoolean(reader["BRESTUTI"]);
              chkType.Checked = Utils.BlankIfNull(reader["CUTITYPE"]) == "C" ? true : false;
              chkEns.Checked = Convert.ToBoolean(reader["BRESTENS"]);
              chkPresta.Checked = Convert.ToBoolean(reader["BRESTPRESTA"]);
              if (chkPresta.Checked) chkPresta_Click(null, null);
              chkPrix.Checked = Convert.ToBoolean(reader["BRESTPRIX"]);
            }
          }
        }
        //  TB SAMSIC CITY SPEC
        if (miNumClient == 664 && MozartParams.NomGroupe == "EMALEC")
          chkType.Visible = true;

        InitapiGridH();
        InitapiGridA();

        CocherLesSites();
        CocherLesSitesArch();

        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    //Private Sub Form_Load()
    //  
    //Dim rsD As New ADODB.Recordset
    //  
    //  ' initialisation des images
    //  InitBoutons Me, frmMenu
    // 
    //  ' liste des contrats
    //  RemplirListeCategories
    //  ' si on est en creation, on coche tous les contrats
    //  ' sinon, selon restriction ou pas on coche tous ou seulement ce qu'il faut
    //
    //  ' liste des prestations
    //  RemplirListePrestation
    //  
    //  ' gestion des enseignes
    //  RemplirListeEnseignes
    //
    //  If mstrStatut = "C" Then
    //    txtUtilisateur = ""
    //    TxtPwd = ""
    //    txtValid = 99999
    //    cboDroit.Text = "OUI"
    //    cmdCocherTC_Click
    //    cmdArch.Enabled = False
    //  Else
    //    Set rsD = New ADODB.Recordset
    //    rsD.Open "select * from TACCESWEB WHERE NACCNUM=" & miLogin, cnx
    //    txtUtilisateur = rsD!VUTILOG
    //    TxtPwd = BlankIfNull(rsD!VUTIPWD)
    //    txtValid = rsD!NUTIMTVAL
    //    txtMini = rsD!NUTIMINI
    //    cboDroit.Text = rsD!VUTIDROIT
    //    chkContrat.value = IIf(rsD!BRESTCTR, 1, 0)
    //    If chkContrat.value = 0 Then cmdCocherTC_Click
    //    chkLogin.value = IIf(rsD!BRESTUTI, 1, 0)
    //    chkType.value = IIf(rsD!CUTITYPE = "C", 1, 0)
    //    chkEns.value = IIf(rsD!BRESTENS, 1, 0)
    //    chkPresta.value = IIf(rsD!BRESTPRESTA, 1, 0)
    //    chkPrix.value = IIf(rsD!BRESTPRIX, 1, 0)
    //    rsD.Close
    //    Set rsD = Nothing
    //  End If
    //  
    //  ' TB SAMSIC CITY SPEC
    //  If miNumClient = 664 And gstrNomGroupe = "EMALEC" Then chkType.Visible = True
    //
    //  InitapiGridH
    //  InitapiGridA
    //  
    //  CocherLesSites
    //  CocherLesSitesArch
    //  
    //  bModif = False
    //End Sub

    private void loadGridH()
    {
      //  recherche de la liste des sites
      apiTGridH.LoadData(dtArt, MozartDatabase.cnxMozart, $"select NREGCOD , VSITNOM, VLIBTYPESITE, VSITREG, NSITNUM, C1.VCCLNOM, C2.VCCLNOM as VCCLNOM2, C3.VCCLNOM as VCCLNOM3, VSITPAYS, TSIT.VSITENSEIGNE "
                                                + $" FROM TSIT LEFT OUTER JOIN TCCL C1 ON TSIT.NSITRESPREG = C1.NCCLNUM  LEFT OUTER JOIN TCCL C2 ON TSIT.NSITRESPMAINT = C2.NCCLNUM "
                                                + $" LEFT OUTER JOIN TCCL C3 ON TSIT.NSITRESPSECT = C3.NCCLNUM INNER JOIN TREF_TYPESITE R ON TSIT.NSITTYPE = R.NTYPESITE "
                                                + $" WHERE R.LANGUE = '{MozartParams.Langue}' AND CSITACTIF='O' AND TSIT.NCLINUM = {miNumClient} order by VSITNOM");
      apiTGridH.GridControl.DataSource = dtArt;
    }

    private void loadGridA()
    {
      //  recherche de la liste des sites

      apiTGridArch.LoadData(dtArtArch, MozartDatabase.cnxMozart, $"select NREGCOD ,VSITNOM, VLIBTYPESITE, VSITREG,NSITNUM, C1.VCCLNOM, C2.VCCLNOM as VCCLNOM2, C3.VCCLNOM as VCCLNOM3, VSITPAYS, TSIT.VSITENSEIGNE "
                                                + $"FROM TSIT LEFT OUTER JOIN TCCL C1 ON TSIT.NSITRESPREG = C1.NCCLNUM  LEFT OUTER JOIN TCCL C2 ON TSIT.NSITRESPMAINT = C2.NCCLNUM "
                                                + $" LEFT OUTER JOIN TCCL C3 ON TSIT.NSITRESPSECT = C3.NCCLNUM INNER JOIN TREF_TYPESITE R ON TSIT.NSITTYPE = R.NTYPESITE "
                                                + $"WHERE R.LANGUE = '{MozartParams.Langue}' AND CSITACTIF='N' AND TSIT.NCLINUM = {miNumClient} order by VSITNOM");
      apiTGridArch.GridControl.DataSource = dtArtArch;
    }

    private void cmdAnnuler_Click(object sender, System.EventArgs e)
    {
      framArch.Visible = false;
    }

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (string.IsNullOrEmpty(txtUtilisateur.Text))
        {
          MessageBox.Show(Resources.msg_saisirUtilisateur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  test si le login n'existe pas deja, car on ne peut pas utiliser plusieurs fois le meme login pour le meme client
        DataTable dtAcces = new DataTable();
        string sSql = $"select VUTILOG from TACCESWEB where NUTINUM = {miNumClient} AND NACCNUM <> {miLogin}";
        ModuleData.LoadData(dtAcces, sSql);

        foreach (DataRow accesRow in dtAcces.Rows)
        {
          if (txtUtilisateur.Text.ToUpper() == accesRow["VUTILOG"].ToString().ToUpper())
          {
            MessageBox.Show(Resources.msg_saisirAutreUtilisateurExisteDeja, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        //  création d'une commande
        SqlCommand cmd = new SqlCommand("api_sp_creationAccesWeb", MozartDatabase.cnxMozart);
        cmd.CommandType = CommandType.StoredProcedure;

        //  liste des paramètres
        SqlCommandBuilder.DeriveParameters(cmd);
        cmd.Parameters["@iLogin"].Value = miLogin;
        cmd.Parameters["@iClient"].Value = miNumClient;
        cmd.Parameters["@vNom"].Value = txtUtilisateur.Text.Replace("'", "");
        cmd.Parameters["@vPwd"].Value = TxtPwd.Text;
        cmd.Parameters["@cCat"].Value = "C";
        cmd.Parameters["@cDroit"].Value = cboDroit.Text;
        cmd.Parameters["@iValidation"].Value = txtValid.Text == "" ? "99999" : txtValid.Text;
        cmd.Parameters["@iValidMini"].Value = txtMini.Text == "" ? "0" : txtMini.Text;
        cmd.Parameters["@cTyp"].Value = chkType.Checked ? "C" : "T";
        cmd.Parameters["@bCrt"].Value = chkContrat.Checked;
        cmd.Parameters["@bLogin"].Value = chkLogin.Checked;
        cmd.Parameters["@bEnsgn"].Value = chkEns.Checked;
        cmd.Parameters["@bPresta"].Value = chkPresta.Checked;
        cmd.Parameters["@bPrix"].Value = chkPrix.Checked;
        cmd.ExecuteNonQuery();

        //  récupération du numéro créé (lorsque miLogin = 0 en entrée)
        miLogin = Convert.ToInt32(cmd.Parameters[0].Value);

        //  on supprime toutes les infos dans la table TUTI et on réinsert pour chaque site coché
        ModuleData.ExecuteNonQuery($"delete from TUTI where NACCNUM = {miLogin}");

        // parcours du recordset et insertion d'une ligne dans la table TUTI pour chaque site coché
        foreach (DataRow dr in dtArt.Rows)
        {
          if (Convert.ToInt32(dr["NREGCOD"]) == 1)
          {
            sSql = $"EXEC api_sp_CreationLigneAccesweb  '{txtUtilisateur.Text}','{TxtPwd.Text}', 'C'," +
                  $"{miNumClient}, {dr["NSITNUM"]}, '{cboDroit.Text}'" +
                  $",{(txtValid.Text == "" ? "99999" : txtValid.Text)}, '{(chkType.Checked ? "C" : "T")}', {miLogin}";

            ModuleData.CnxExecute(sSql);
          }
        }

        //  mise a jour dans la table des contrats
        cmdValiderContrat();

        // gestion des restrictions sur enseignes
        cmdValiderEnseigne();

        // mise a jour dans la table des prestations
        cmdValiderPresta();

        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void chkContrat_Click(object sender, System.EventArgs e)
    {

      Frame2.Visible = chkContrat.Checked;
      if (chkContrat.Checked)
        CocherLesCat();
      else
        cmdCocherTC();
    }

    private void chkEns_Click(object sender, System.EventArgs e)
    {
      Frame1.Visible = chkEns.Checked;
      if (chkEns.Checked)
        CocherLesEns();
    }

    private void chkPresta_Click(object sender, System.EventArgs e)
    {
      Frame5.Visible = chkPresta.Checked;

      if (chkPresta.Checked)
        CocherLesPresta();
    }

    
    private void apiTGridH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (e.Column.Name == "NREGCOD")
      {
        NbCoche += (Convert.ToInt32(e.Value) == 1) ? 1 : -1;
        lblNbSites.Text = $"{lblNbSites.Tag}{NbCoche}";
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        // si il y a des modifications
        if (bModif)
        {
          DialogResult rc = MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
          switch (rc)
          {
            case DialogResult.Yes:
              cmdValider_Click(null, null);
              Dispose();
              break;
            case DialogResult.No:
              Dispose();
              break;
            case DialogResult.Cancel:
              break;
          }
        }
        else
        {
          Dispose();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CocherLesSites()
    {
      try
      {
        //  recherche de la liste des sites à cocher
        DataTable dtSite = new DataTable();
        string sSql = $"select distinct NUSITNUM from TUTI where NACCNUM = {miLogin}";
        ModuleData.LoadData(dtSite, sSql);
        DataRow[] foundRows;

        foreach (DataRow dr in dtSite.Rows)
        {
          foundRows = dtArt.Select($"NSITNUM = {Utils.ZeroIfNull(dr["NUSITNUM"])}");
          if (foundRows.Length > 0)
          {
            foreach (DataRow r in foundRows)
              r["NREGCOD"] = true;
          }
        }

        NbCoche = dtSite.Rows.Count;
        lblNbSites.Text = $"{lblNbSites.Tag}{NbCoche}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    
    private void CocherLesSitesArch()
    {
      try
      {
        // recherche de la liste des sites à cocher
        DataTable dtSite = new DataTable();
        string sSql = $"select distinct NUSITNUM from TUTIARCH where NACCNUM = {miLogin}";
        ModuleData.LoadData(dtSite, sSql);
        DataRow[] foundRows;

        foreach (DataRow dr in dtSite.Rows)
        {
          foundRows = dtArtArch.Select($"NSITNUM = {Utils.ZeroIfNull(dr["NUSITNUM"])}");
          if (foundRows.Length > 0)
          {
            foreach (DataRow r in foundRows)
              r["NREGCOD"] = true;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Text_Changed(object sender, System.EventArgs e)
    {
      bModif = true;
    }

    private void cmdCocherT_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (DataRow row in dtArt.Rows) row["NREGCOD"] = true;
        NbCoche = dtArt.Rows.Count;
        lblNbSites.Text = $"{lblNbSites.Tag}{NbCoche}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    
    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (DataRow row in dtArt.Rows) row["NREGCOD"] = false;
        NbCoche = 0;
        lblNbSites.Text = $"{lblNbSites.Tag}{NbCoche}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridH()
    {
      try
      {
        //apiTGridH.AddColumn(" ", "NREGCOD", 300, "", 0, false, false, false, true);
        apiTGridH.AddColumn("NumSite", "NSITNUM", 0);
        apiTGridH.AddColumn(Resources.col_Site, "VSITNOM", 3000, "", 0, true);
        apiTGridH.AddColumn("Enseigne", "VSITENSEIGNE", 3000);
        apiTGridH.AddColumn(Resources.col_Type, "VLIBTYPESITE", 1100);
        apiTGridH.AddColumn(Resources.col_Region, "VSITREG", 1200);
        apiTGridH.AddColumn("R. Comm", "VCCLNOM", 1400);
        apiTGridH.AddColumn("R. Maint", "VCCLNOM2", 1400);
        apiTGridH.AddColumn("R. Secteur", "VCCLNOM3", 1400);
        apiTGridH.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);

        apiTGridH.InitColumnList();

        apiTGridH.dgv.OptionsSelection.MultiSelect = true;
        apiTGridH.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGridH.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
        apiTGridH.dgv.OptionsSelection.CheckBoxSelectorField = "NREGCOD";

        loadGridH();

        // decocher tous
        foreach (DataRow row in dtArt.Rows)
          row["NREGCOD"] = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridA()
    {
      try
      {
        //apiTGridArch.AddColumn(" ", "NREGCOD", 300, "", 0, false, false, false, true);
        apiTGridArch.AddColumn("NumSite", "NSITNUM", 0);
        apiTGridArch.AddColumn(Resources.col_Site, "VSITNOM", 3000, "", 0, true);
        apiTGridArch.AddColumn("Enseigne", "VSITENSEIGNE", 3000);
        apiTGridArch.AddColumn(Resources.col_Type, "VLIBTYPESITE", 1100);
        apiTGridArch.AddColumn(Resources.col_Region, "VSITREG", 1200);
        apiTGridArch.AddColumn("R. Comm", "VCCLNOM", 1400);
        apiTGridArch.AddColumn("R. Maint", "VCCLNOM2", 1400);
        apiTGridArch.AddColumn("R. Secteur", "VCCLNOM3", 1400);
        apiTGridArch.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);

        apiTGridArch.InitColumnList();

        apiTGridArch.dgv.OptionsSelection.MultiSelect = true;
        apiTGridArch.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGridArch.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
        apiTGridArch.dgv.OptionsSelection.CheckBoxSelectorField = "NREGCOD";

        loadGridA();

        // decocher tous
        foreach (DataRow row in dtArtArch.Rows)
          row["NREGCOD"] = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtValid_KeyPress(object sender, KeyPressEventArgs e)
    {
      //Contrôle de numéricité
      int KeyAscii = e.KeyChar;
      if (KeyAscii == 8) return;
      if (KeyAscii < 48 || KeyAscii > 57) e.Handled = true;
    }

    private void cmdCocherTC(bool bCocher = true)
    {
      for (int idx = 0; idx < lstCat.Items.Count; idx++)
        lstCat.SetSelected(idx, bCocher);
    }


    private void CocherLesCat()
    {
      try
      {
        // recherche de la liste des comptes à cocher
        DataTable dtComptes = new DataTable();
        ModuleData.LoadData(dtComptes, $"select NTYPECONTRAT from DroitContratClientWeb WHERE NACCNUM = {miLogin}");

        // parcours du recordset et de la listebox
        foreach (DataRow compteRow in dtComptes.Rows)
        {
          for (int i = 0; i < lstCat.Items.Count; i++)
          {
            ListCategorieItemData item = (ListCategorieItemData)lstCat.Items[i];
            if (item.NTYPECONTRAT == Convert.ToInt32(compteRow["NTYPECONTRAT"]))
            {
              lstCat.SetItemChecked(i, true);
              break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CocherLesEns()
    {
      try
      {
        //  recherche de la liste des enseignes à cocher
        DataTable dtEnseignes = new DataTable();
        ModuleData.LoadData(dtEnseignes, $"select VENSEIGNE from TUTIENSEIGNE WHERE NCLINUM= {miNumClient} " +
                            $"AND VUTILOG='{txtUtilisateur.Text.Replace("'", "")}'");

        // parcours du recordset et de la listebox
        foreach (DataRow enseigneRow in dtEnseignes.Rows)
        {
          for (int i = 0; i < lstEns.Items.Count; i++)
          {
            ListEnseigneItemData item = (ListEnseigneItemData)lstEns.Items[i];
            if (item.VSITENSEIGNE == enseigneRow["VENSEIGNE"].ToString())
            {
              lstEns.SetItemChecked(i, true);
              break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CocherLesPresta()
    {
      try
      {
        DataTable dtDroitPresta = new DataTable();
        //  on coche toutes les prestations de la liste puis on décoche les interdites
        for (int i = 0; i < lstPresta.Items.Count; i++)
          lstPresta.SetItemChecked(i, true);
        ModuleData.LoadData(dtDroitPresta, $"Select CPRECOD from DroitPrestaClientWeb WHERE NACCNUM = {miLogin}");

        //  parcours du recordset et de la listebox
        foreach (DataRow droitPrestaRow in dtDroitPresta.Rows)
        {
          for (int i = 0; i < lstPresta.Items.Count; i++)
          {
            ListPrestationItemData item = (ListPrestationItemData)lstPresta.Items[i];

            if (item.CPRECOD == Convert.ToChar(droitPrestaRow["CPRECOD"].ToString().Substring(0, 1)))
            {
              lstPresta.SetItemChecked(i, false);
              break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RemplirListeCategories()
    {
      try
      {
        DataTable dtCategorie = new DataTable();
        ModuleData.LoadData(dtCategorie, $"SELECT distinct C.VTYPECONTRAT, C.NTYPECONTRAT FROM TCONTRATCLI T INNER JOIN TREF_TYPECONTRAT C ON C.NTYPECONTRAT = T.NTYPECONTRAT " +
                            $"WHERE T.NCLINUM = {miNumClient} AND C.LANGUE = 'FR' ORDER BY  VTYPECONTRAT");

        //  vider la listeBox
        lstCat.Items.Clear();

        foreach (DataRow categorieRow in dtCategorie.Rows)
        {
          lstCat.Items.Add(new ListCategorieItemData()
          {
            VTYPECONTRAT = categorieRow["VTYPECONTRAT"].ToString(),
            NTYPECONTRAT = (int)categorieRow["NTYPECONTRAT"]
          });
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RemplirListeEnseignes()
    {
      try
      {
        DataTable dtEnseigne = new DataTable();
        ModuleData.LoadData(dtEnseigne, $"Select distinct VSITENSEIGNE FROM TSIT WHERE NCLINUM ={miNumClient} and vsitenseigne is not null");

        // vider la listeBox
        lstEns.Items.Clear();

        int idx = 0;
        foreach (DataRow enseigneRow in dtEnseigne.Rows)
        {
          lstEns.Items.Add(new ListEnseigneItemData()
          {
            VSITENSEIGNE = enseigneRow["VSITENSEIGNE"].ToString(),
            index = idx++
          });
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RemplirListePrestation()
    {
      try
      {
        DataTable dtPrestation = new DataTable();
        ModuleData.LoadData(dtPrestation, $"SELECT VPRELIB, CPRECOD FROM TREF_PRE WHERE LANGUE = 'FR' ORDER BY VPRELIB");

        lstPresta.Items.Clear();

        foreach (DataRow prestationRow in dtPrestation.Rows)
        {
          lstPresta.Items.Add(new ListPrestationItemData()
          {
            VPRELIB = prestationRow["VPRELIB"].ToString(),
            CPRECOD = Convert.ToChar(prestationRow["CPRECOD"].ToString().Substring(0, 1))
          });
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValiderContrat()
    {
      if (lstCat.Items.Count == 0)
        return;

      try
      {
        //  on supprime les lignes de DroitContratClientWeb
        ModuleData.ExecuteNonQuery($"Delete from DroitContratClientWeb WHERE NACCNUM = {miLogin}");

        if (!chkContrat.Checked)
        {
          // si pas de restriction, on insert tous les contrats du client
          ModuleData.ExecuteNonQuery($"insert into DroitContratClientWeb (NCLINUM, VUTILOG, NTYPECONTRAT, NACCNUM)"
                                   + $" select {miNumClient}, '{txtUtilisateur.Text.Replace("'", "")}', NTYPECONTRAT, {miLogin}"
                                   + $" from TCONTRATCLI where NCLINUM={miNumClient}");
        }
        else
        {
          // si on a une restriction, on insert que les cochés.
          foreach (ListCategorieItemData item in lstCat.CheckedItems)
          {
            // insert des comptes cochés ( erreur si le compte est deja present)
            ModuleData.ExecuteNonQuery($"insert into DroitContratClientWeb (NCLINUM, VUTILOG, NTYPECONTRAT, NACCNUM) values("
                                     + $"{miNumClient}, '{txtUtilisateur.Text.Replace("'", "")}', {item.NTYPECONTRAT}, {miLogin})");
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValiderEnseigne()
    {
      if (lstEns.Items.Count == 0)
        return;

      try
      {
        //  on supprime les lignes de TENSEIGNE
        ModuleData.ExecuteNonQuery($"Delete from TUTIENSEIGNE WHERE NCLINUM = {miNumClient} AND VUTILOG='{txtUtilisateur.Text.Replace("'", "")}'");

        // si on a une restriction, on insert que les cochés.
        if (chkEns.Checked)
        {
          foreach (ListEnseigneItemData item in lstEns.CheckedItems)
          {
            // insert des comptes cochés ( erreur si le compte est deja present)
            ModuleData.ExecuteNonQuery($"insert into TUTIENSEIGNE (NCLINUM, VUTILOG, VENSEIGNE) values({miNumClient} , '{txtUtilisateur.Text.Replace("'", "")}','{item.VSITENSEIGNE.Replace("'", "''")}')");
          }

          //  si des enseignes sont cochées, il faut supprimer les sites qui ne sont pas sur ces enseignes dans tuti
          ModuleData.ExecuteNonQuery($"delete from tuti where CUTICAT='C' AND NUTINUM = {miNumClient} AND VUTILOG= '{txtUtilisateur.Text.Replace("'", "")}'"
                                   + $" AND nusitnum not in (select nsitnum from tsit s, TUTIENSEIGNE u where s.nclinum=u.nclinum and u.nclinum= {miNumClient}"
                                   + $" AND s.vsitenseigne=u.venseigne)");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValiderPresta()
    {
      if (lstPresta.Items.Count == 0)
        return;

      try
      {
        //  on supprime les lignes de DroitPrestaClientWeb
        ModuleData.ExecuteNonQuery($"Delete from DroitPrestaClientWeb WHERE NACCNUM = {miLogin}");

        //  si on a une restriction, on insert que les cochés (table des prestations interdites)
        //  si pas de restriction, on insert rien
        if (!chkPresta.Checked)
        {
          // on delete dans la table (c'est fait au dessus)
        }
        else
        {
          // on insert toutes les prestations et ensuite on supprime celles qui sont cochées.
          // donc on garde dans la table que les prestations interdites
          ModuleData.ExecuteNonQuery($"insert into DroitPrestaClientWeb (NCLINUM, VUTILOG, CPRECOD, NACCNUM) "
                                   + $"select {miNumClient}, '{txtUtilisateur.Text.Replace("'", "")}', CPRECOD, {miLogin} from TREF_PRE where LANGUE='FR'");

          foreach (ListPrestationItemData item in lstPresta.CheckedItems)
          {
            // insert des comptes cochés (erreur si le compte est deja present)
            ModuleData.ExecuteNonQuery($"delete from DroitPrestaClientWeb where NACCNUM = {miLogin} AND CPRECOD = '{item.CPRECOD}'");
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValiderChaff_Click(object sender, System.EventArgs e)
    {
      // on supprime toutes les infos dans la table TUTIARCH et on réinsert pour chaque site coché
      ModuleData.CnxExecute($"delete from TUTIARCH where NACCNUM = {miLogin}");

      // parcours du recordset et insertion d'une ligne dans la table TUTIARCH pour chaque site coché
      foreach (DataRow dr in dtArtArch.Rows)
      {
        if (Convert.ToInt32(dr["NREGCOD"]) == 1)
        {
          // execution de la requête d'insert
          ModuleData.CnxExecute($"insert into TUTIARCH (VUTILOG,NUTINUM,NUSITNUM,NACCNUM) " +
                                $"values ('{txtUtilisateur}',{miNumClient},{dr["NSITNUM"]},{miLogin})");
        }
      }

      framArch.Visible = false;
    }

    private void cmdArch_Click(object sender, EventArgs e)
    {
      framArch.Visible = true;
    }

  }
}