using Microsoft.VisualBasic;
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
  public partial class frmStockDdeReappro : Form
  {
    //' feuille ouverte en création ou modification

    public int iNumDdeSortie = 0;
    public string mstrStatutStock = "";

    private int iNumAction = 0;
    private DataTable dtArticles = new DataTable();


    public frmStockDdeReappro() { InitializeComponent(); }

    private void frmStockDdeReappro_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE AS VPERNOM from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' ORDER BY VPERNOM, VPERPRE";
        cboTech.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        cboLieu.Items[1] = cboLieu.Items[1].ToString().Replace("$ste", MozartParams.NomSociete);

        InitRecordsetArticle();

        mstrStatutStock = "C";
        iNumDdeSortie = 0;
        iNumAction = 0;
        InitApigrid();
        txtObjet.Text = Resources.txt_dde_reappro_tech;
        cboLieu.SelectedIndex = 0;

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      new frmRechercheArticlesCom
      {
        miNumFournisseur = 0,
        m_brechercheSite = false,
        m_bSaisieQte = true,
        mstrClient = "",
        mstrStatut = "",
        m_bAfficheInfoFou = false,
        mdtArticles = dtArticles
      }.ShowDialog();

      CalculerTOTAUX();
    }

    private void cmdListeReap_Click(object sender, EventArgs e)
    {
      new frmlisteReaproTech().ShowDialog();
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      //  Suppression de la ligne courante
      DataRow row = grdDataGrid.GetFocusedDataRow();
      if (row == null) return;

      dtArticles.Rows.Remove(row);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigrid()
    {
      grdDataGrid.GridControl.DataSource = dtArticles;
      FormatGridArticle();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      switch (MozartParams.NomSociete)
      {
        case "EMALECIDF":
        case "EMALECLUXEMBOURG":
        case "EMALECSUISSE":
        case "EMALECESPAGNE":
        case "MAGESTIME":
        case "EMALECDEV":
        case "EQUIPAGE":
          MessageBox.Show("Pour cette filiale, vous ne pouvez faire que des commandes à Emalec", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        default:
          // pour EMALEC, MPM, SCS, FITELEC, FACILITEAM on peut faire des sorties de stock sur le magasin local
          break;
      }

      if (cboTech.GetText() == "")
      {
        MessageBox.Show(Resources.msg_sel_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // Date obligatoire
      if (txtDateLivr.Text == "")
      {
        MessageBox.Show(Resources.txt_saisir_date_livr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        CmdDate_Click(null, null);
        return;
      }

      if (dtArticles.Rows.Count == 0)
      {
        MessageBox.Show(Resources.msg_EntrerArticle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      Cursor.Current = Cursors.WaitCursor;

      if (mstrStatutStock == "M")
        CreationDde(iNumAction);
      else
        CreationDdeSortie();

      Cursor.Current = Cursors.Default;

      if (iNumDdeSortie != 0)
      {
        mstrStatutStock = "M";
        MessageBox.Show(Resources.txt_dde_creee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void CreationDdeSortie()
    {
      try
      {
        int iSite;
        if (MozartParams.NomSociete == "EMALEC")
          iSite = 8974;
        else if (MozartParams.NomSociete == "SCS")
          iSite = 209724;
        else if (MozartParams.NomSociete == "EMALECMPM")
          iSite = 385434;
        else
          return;

        //'********************************************************************************************
        //' création d'une DI et d'une action de fournitures
        iNumAction = 0;

        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationDIActionReapproTech", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          //  ' Changer les compteurs et traiter le cas des autres sociétés
          cmd.Parameters["@iSite"].Value = iSite;
          cmd.Parameters["@iTech"].Value = cboTech.GetItemData();  // c'est en fait npernum tech
          cmd.Parameters["@Demandeur"].Value = MozartParams.NomSociete;
          cmd.Parameters["@vRefClient"].Value = "Dde réappro MOZART";

          cmd.ExecuteNonQuery();
          iNumAction = (int)cmd.Parameters[0].Value;
        }

        if (iNumAction == 0) return;

        // Création de la demande de sortie de stock au magasin sur cette action
        CreationDde(iNumAction);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }

    //''********************************************************************************************
    //'' création de la demande de sortie de stock au magasin sur cette action
    //
    //  CreationDde (lNumAction)
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationDde(int iAction)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDdeSortieStock", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iDdeNum"].Value = iNumDdeSortie;
          cmd.Parameters["@TypeDest"].Value = "Personnel";
          cmd.Parameters["@iAction"].Value = iAction;
          cmd.Parameters["@vObjet"].Value = txtObjet.Text;
          cmd.Parameters["@dLivr"].Value = txtDateLivr.Text;
          cmd.Parameters["@TypeDde"].Value = "REAPPRO";
          cmd.Parameters["@LieuLivr"].Value = cboLieu.Text;

          cmd.ExecuteNonQuery();
          iNumDdeSortie = (int)cmd.Parameters[0].Value;
        }

        CreationLigneArt();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationLigneArt()
    {
      try
      {
        //  Delete des lignes de commandes dans la tables TLART
        ModuleData.ExecuteNonQuery($"DELETE from TLART where NDDENUM = {iNumDdeSortie}");

        //  Parcours du recordset et création des lignes dans TLART
        foreach (DataRow item in dtArticles.Rows)
        {
          try
          {
            ModuleData.ExecuteNonQuery($"INSERT INTO TLART (NACTNUM, VLART, NLARTQTE, NFOUNUM, NDDENUM) values ({iNumAction}, " +
                                       $"'{item["Article"].ToString().Replace("'", "''")}', {Utils.ZeroIfNull(item["Quantite"])}, " +
                                       $"{Utils.ZeroIfNull(item["NumArticle"])}, {iNumDdeSortie})");
          }
          catch (Exception)
          {
            MessageBox.Show(Resources.txt_art_doublon, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateLivr.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    private void CmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateLivr.Text, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    public void InitRecordsetArticle()
    {
      try
      {
        // ajout des champs 
        dtArticles.Columns.Add("Serie", typeof(string));
        dtArticles.Columns.Add("Article", typeof(string));
        dtArticles.Columns.Add("Marque", typeof(string));
        dtArticles.Columns.Add("Type", typeof(string));
        dtArticles.Columns.Add("Reference", typeof(string));
        dtArticles.Columns.Add("PCB", typeof(int));
        dtArticles.Columns.Add("Prix U", typeof(double));
        dtArticles.Columns.Add("Quantite", typeof(long));
        dtArticles.Columns.Add("Prix T", typeof(double));
        dtArticles.Columns.Add("Fournisseur", typeof(string));
        dtArticles.Columns.Add("NumArticle", typeof(int));
        dtArticles.Columns.Add("NumFour", typeof(int));
        dtArticles.Columns.Add("NumSiteFour", typeof(int));

        DataColumn[] keys = new DataColumn[1];
        keys[0] = dtArticles.Columns["NumArticle"];
        dtArticles.PrimaryKey = keys;

        grdDataGrid.GridControl.DataSource = dtArticles;

        //FormatGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridArticle()
    {
      try
      {
        grdDataGrid.AddColumn(Resources.col_Serie, "Serie", 800);
        grdDataGrid.AddColumn(Resources.col_materiel, "Article", 2300);
        grdDataGrid.AddColumn(Resources.col_marque, "Marque", 1500);
        grdDataGrid.AddColumn(Resources.col_Type, "Type", 1500);
        grdDataGrid.AddColumn(Resources.col_reference, "Reference", 1200);
        grdDataGrid.AddColumn(Resources.col_pcb, "PCB", 800, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixU, "Prix U", 900, "## ##0.000", 1);
        grdDataGrid.AddColumn(Resources.col_qte2, "Quantite", 800, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixT, "Prix T", 0);
        grdDataGrid.AddColumn(Resources.col_Fournisseur, "Fournisseur", 0);
        grdDataGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
        grdDataGrid.AddColumn(Resources.col_num_four, "NumFour", 0);
        grdDataGrid.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

        grdDataGrid.DelockColumn("Quantite");
        grdDataGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /* OK -------Gestion de tous les boutons de type 'Outillage' -------------- */
    private void CmdOutillage_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmChoixArtNewTech()
      {
        mstrType = (sender as Control).Tag.ToString(),
        mstrTitre = (sender as Control).Text,
        mdtArticles = dtArticles
      }.ShowDialog();

      CalculerTOTAUX();
    }

    /* OK ------Gestion de tous les boutons de type 'Fourniture' ------------- */
    private void cmdFourniture_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmChoixArtReapproTech()
      {
        mstrType = (sender as Control).Tag.ToString(),
        mstrTitre = (sender as Control).Text,
        mdtArticles = dtArticles
      }.ShowDialog();

      CalculerTOTAUX();
    }

    private void CmdCommandeEMALEC_Click(object sender, EventArgs e)
    {
      if (cboTech.GetText() == "")
      {
        MessageBox.Show(Resources.msg_sel_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //' Date obligatoire
      if (txtDateLivr.Text == "")
      {
        MessageBox.Show(Resources.txt_saisir_date_livr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        CmdDate_Click(null, null);
        return;
      }

      if (dtArticles.Rows.Count == 0)
      {
        MessageBox.Show(Resources.msg_EntrerArticle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //  Si il y a une facture dans Ravel, on ne peut pas modifier la commande
      if (mstrStatutStock == "M")
      {
        MessageBox.Show("La facture de cette sortie de stock a été créée chez EMALEC.Vous ne pouvez plus modifier la sortie de stock", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //  Pour un technicien filiale
      if (cboLieu.Text == "Domicile")
      {
        Cursor.Current = Cursors.WaitCursor;

        DataRow row = grdDataGrid.GetFocusedDataRow();
        if (row == null) return;

        CreateReapproTechFilialeFromEMALECTo_ATHOME(cboTech.GetItemData(), txtDateLivr.Text, (double)Utils.ZeroIfNull(LblTotalHT.Text.Replace(" €", "")));

        Cursor.Current = Cursors.Default;

        MessageBox.Show(Resources.txt_dde_reappro_faite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        MessageBox.Show(Resources.txt_dde_reappro_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    //Private Sub CmdCommandeEMALEC_Click()
    //
    //On Error GoTo handler
    //
    //    If cboTech.Text = "" Then
    //      MsgBox "§Il faut sélectionner un technicien !§", vbExclamation
    //      Exit Sub
    //    End If
    //
    //  If txtDateLivr.Text = "" Then        ' Date obligatoire
    //    MsgBox "§Il faut saisir une date de livraison !§", vbExclamation
    //    cmdDate_Click
    //    Exit Sub
    //  End If
    //
    //  If rsarticle.EOF And rsarticle.BOF Then
    //    MsgBox "§Il faut entrer un article !§", vbExclamation
    //    Exit Sub
    //  End If
    //
    //  'si il y a une facture dans Ravel, on ne peut pas modifier la commande
    //  If mstrStatutStock = "M" Then
    //    MsgBox "La facture de cette sortie de stock a été créée chez EMALEC.Vous ne pouvez plus modifier la sortie de stock", vbOKOnly
    //    Exit Sub
    //  End If
    //  
    //  'pour un technicien filiale
    //  If cboLieu.List(cboLieu.ListIndex) = "Domicile" Then
    //  
    //    Screen.MousePointer = vbHourglass
    //  
    //    Dim oGestReappro As New CGESTREAPPROFILIALE
    //    oGestReappro.Init
    //    oGestReappro.NPERNUM_TECH_FILIALE = cboTech.ItemData(cboTech.ListIndex)
    //    oGestReappro.TotalHT = ZeroIfNull(LblTotalHT.Caption)
    //    oGestReappro.Date_Livr = txtDateLivr.Text
    //    
    //    Call oGestReappro.CreateReapproTechFilialeFromEMALECTo_ATHOME(rsarticle)
    //      
    //    Screen.MousePointer = vbDefault
    // 
    //    MsgBox "§La demande de réappro a été effectuée§", vbInformation
    //  Else
    //    MsgBox "§Actuellement, vous ne pouvez pas faire de demande de réappro pour le magasin§", vbInformation
    //  End If
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "CmdCommandeEMALEC_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CalculerTOTAUX()
    {
      try
      {
        double total = 0;
        //pour toutes les lignes de la grid
        foreach (DataRow row in dtArticles.Rows)
          total += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);

        LblTotalHT.Text = Strings.FormatNumber(total, 2) + " €";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void grdDataGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow currR = grdDataGrid.GetFocusedDataRow();
      currR["Prix T"] = Utils.ZeroIfNull(currR["Prix U"]) * Utils.ZeroIfNull(currR["Quantite"]);
    }


    private void CreateReapproTechFilialeFromEMALECTo_ATHOME(int nPernumTechFiliale, string DateLivr, Double dTotalHT)
    {
      try
      {
        if (nPernumTechFiliale == 0) return;
        if (DateLivr == "") return;

        if (dtArticles.Rows.Count == 0)
        {
          MessageBox.Show(Resources.txt_aucun_article_liste_prepa_cde, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //Fournisseur EMALEC
        int numSTFFournisseur = 937;
        int NumActCmdFiliale = 0;

        // on crée la commande sur mozart Filiale
        List<DataRow> lstToDelete = new List<DataRow>();
        foreach (DataRow row in dtArticles.Rows)
        {
          NumActCmdFiliale = CreateCmdOnFiliale(row, numSTFFournisseur, NumActCmdFiliale, dTotalHT);  // fournisseur Emalec
          lstToDelete.Add(row);
        }

        foreach (DataRow row in lstToDelete)
          dtArticles.Rows.Remove(row);

        // on crée une di + action + ss sur mozart EMALEC pour le technicien filiale
        int numCom_Filiale = CreateDIActionForSS_EMALEC_To_Tech_Filiale(NumActCmdFiliale, nPernumTechFiliale);

        // on enregistre la commande et la ss emalec pour etablir une liaison
        CreateLiaisonCmd_Filiale_And_EMALEC(numCom_Filiale, numSTFFournisseur);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private int CreateCmdOnFiliale(DataRow dataRow, int numStf, int numCom_Filiale, double dTotalHT)
    {
      int iNumCdeFiliale = 0;
      int iNumAction = 0;
      try
      {

        if (numCom_Filiale == 0)
          // c'est une nouvelle commande, donc il faut une nouvelle action
          iNumAction = CreationDIcmd_ReapproTechFiliale(995);

        DataTable dtSte = new DataTable();
        ModuleData.LoadData(dtSte, $"exec api_sp_GetInfosSociete {iNumAction}");
        if (dtSte.Rows.Count == 0)
        {
          MessageBox.Show(Resources.txt_coord_demandeur + MozartParams.NomSociete + Resources.txt_non_remontees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return 0;
        }

        DataRow drSte = dtSte.Rows[0];

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationCommande", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNumCommande"].Value = numCom_Filiale;
          cmd.Parameters["@iNumFour"].Value = (numStf == 0 ? dataRow["NumSiteFour"] : numStf);
          cmd.Parameters["@iAction"].Value = iNumAction;
          cmd.Parameters["@nPrixHT"].Value = Utils.ZeroIfNull(dTotalHT);
          cmd.Parameters["@nPrixTVA"].Value = 20; // txtTVA  ' n'est pas utilisée dans la proc stock
          cmd.Parameters["@dDateLiv"].Value = DateTime.Now.AddDays(5);
          cmd.Parameters["@typeL"].Value = "E";

          cmd.Parameters["@adresse1"].Value = drSte["VSITAD1"].ToString().Substring(0, Math.Min(drSte["VSITAD1"].ToString().Length, 50));        // Left(txtFields(0), 50)
          cmd.Parameters["@adresse2"].Value = drSte["VSITAD2"].ToString().Substring(0, Math.Min(drSte["VSITAD2"].ToString().Length, 50));        // Left(txtFields(1), 50)

          cmd.Parameters["@cp"].Value = drSte["VSITCP"];
          cmd.Parameters["@ville"].Value = drSte["VSITVIL"];
          cmd.Parameters["@aattention"].Value = drSte["VRESPSTOCK"];
          cmd.Parameters["@lieulivr"].Value = MozartParams.NomSociete;

          cmd.Parameters["@numArticle"].Value = dataRow["NumArticle"];
          cmd.Parameters["@qte"].Value = dataRow["Quantite"];
          cmd.Parameters["@pu"].Value = numStf == 0
                                      ? dataRow["Prix U"] : 1.05 * Convert.ToDouble(dataRow["Prix U"]); // coeff 1.05 pour les commandes a Emalec
          cmd.Parameters["@pt"].Value = numStf == 0
                                      ? Convert.ToDouble(dataRow["Prix U"]) * Convert.ToInt32(dataRow["Quantite"])
                                      : 1.05 * Convert.ToDouble(dataRow["Prix U"]) * Convert.ToInt32(dataRow["Quantite"]);
          cmd.Parameters["@dDatePlanif"].Value = DBNull.Value;

          cmd.ExecuteNonQuery();
          iNumCdeFiliale = Convert.ToInt32(cmd.Parameters[0].Value);
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return iNumCdeFiliale;
    }

    private int CreateDIActionForSS_EMALEC_To_Tech_Filiale(int numCom_Filiale, int nPernum_Tech_Filiale)
    {
      int numSS_Emalec = 0;
      try
      {
        string sSql = "Api_sp_CreationDIActionCmdEmalecToTech " + numCom_Filiale + ", " + nPernum_Tech_Filiale;
        DataTable dt = new DataTable();
        dt.Load(ModuleData.ExecuteReader(sSql));

        foreach (DataRow row in dt.Rows)
          numSS_Emalec = (int)row[0];   // N° SS MOZART EMALEC

      }
      catch (Exception ex)
      {
        // L'erreur 'NSITNUM ne peut pas être null' est normale
        if (ex.HResult != -2146232060)
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return numSS_Emalec;
    }

    private void CreateLiaisonCmd_Filiale_And_EMALEC(int numCom_Filiale, int NumStf)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreateLiaisonFilialeToEMALEC", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@p_nconum_filiale"].Value = numCom_Filiale;
          cmd.Parameters["@p_nddenum_emalec"].Value = NumStf;
          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private int CreationDIcmd_ReapproTechFiliale(int iCompte)
    {
      int iNumAction = 0;
      int iSite;
      try
      {
        if (MozartParams.NomSociete == "EMALEC")
          iSite = 8974;
        else if (MozartParams.NomSociete == "SCS")
          iSite = 209724;
        else if (MozartParams.NomSociete == "EQUIPAGE")
          iSite = 100149;
        else if (MozartParams.NomSociete == "EMALECIDF")
          iSite = 336616;
        else if (MozartParams.NomSociete == "EMALECMPM")
          iSite = 385434;
        else if (MozartParams.NomSociete == "EMALECLUXEMBOURG")
          iSite = 381990;
        else
          return 0;

        // création d'une DI est d'une action
        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationDIActionReapproTechnicien", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@Demandeur"].Value = MozartParams.NomSociete;
          cmd.Parameters["@vRefClient"].Value = "Réappro Fournisseur EMALEC directement au Technicien " + MozartParams.NomSociete;
          cmd.Parameters["@iSite"].Value = iSite;
          cmd.Parameters["@vCte"].Value = iCompte;
          cmd.Parameters["@npernum_tech_filiale"].Value = cboTech.GetItemData();
          cmd.ExecuteNonQuery();
          iNumAction = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return iNumAction;
    }
  }
}