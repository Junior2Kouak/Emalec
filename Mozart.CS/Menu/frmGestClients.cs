using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmGestClients : Form
  {
    DataTable dt = new DataTable();

    public frmGestClients() { InitializeComponent(); }

    private void frmGestClients_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "api_sp_listeClientsActifs");

        InitApigrid();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      //MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdModifier.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

      new frmDetailsClient
      {
        mstrStatut = "M",
        miNumClient = (int)row["NCLINUM"]
      }.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Vous devez passer par les prospects pour créer un nouveau client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

      //new frmWizardProspeClient().ShowDialog();
    }

    private void cmdContacts_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdContacts.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

        new frmGestContactsClient
        {
          miNumClient = (int)row["NCLINUM"],
          mstrClient = (string)row["VCLINOM"]
        }.ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void cmdRSF_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdRSF.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

        new frmGestRSF((int)row["NCLINUM"]).ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void cmdsite_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdsite.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

        new frmGestSites
        {
          miNumClient = (int)row["NCLINUM"]
        }.ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void cmdPrixCliPrest_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdPrixCliPrest.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

      new frmGestClientPrixPrestation
      {
        miNumCli = (int)row["NCLINUM"],
        msCliNom = (string)row["VCLINOM"]
      }.ShowDialog();
    }

    private void cmdCoef_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdCoef.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

        new frmGestCoeffVente
        {
          miNumClient = (int)row["NCLINUM"],
          mstrNomClient = (string)row["VCLINOM"]
        }.ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void cmdComptecli_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdComptecli.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

        new frmGestCompteCli(row["NCLINUM"], row["VCLINOM"]).ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void cmdWeb_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdWeb.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

        new frmGestWebPer
        {
          miNumPersonne = (int)row["NCLINUM"],
          msTypePer = "C"
        }.ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      // il faut ajouter une gestion de droit par chaff
      // si un chaff a les droits sur la gestion des accès web, il faut aussi vérifier qu'il ne puisse accéder qu'à ces clients
      // donc on a fait 2 boutons de droits web (1 pour la direction et un pour les chaffs)
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        int nb = (int)ModuleData.ExecuteScalarInt($"select count(*) from tcan where npernum = {MozartParams.UID} and nclinum = {row["NCLINUM"]} and ccanactif='O'");
        if (nb == 0)
        {
          MessageBox.Show("Vous ne pouvez gérer que les accès web de vos clients", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", Command2.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

          new frmGestWebPer
          {
            miNumPersonne = (int)row["NCLINUM"],
            msTypePer = "C"
          }.ShowDialog();
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }
    //Private Sub Command2_Click()
    //
    //Dim adoAux As ADODB.Recordset
    //
    //  ' il faut ajouter une gestion de droit par chaff
    //  ' si un chaff a les droits sur la gestion des accès web, il faut aussi vérifier qu'il ne puisse accéder qu'à ces clients
    //  ' donc on a fait 2 boutons de droits web (1 pour la direction et un pour les chaffs)
    //  
    //On Error GoTo handler
    //  
    //  If adors.EOF Then Exit Sub
    //  
    //  Set adoAux = New Recordset
    //  adoAux.Open "select count(*) from tcan where npernum = " & gintUID & " and nclinum = " & adors("NCLINUM") & " and ccanactif='O' ", cnx, adOpenStatic, adLockOptimistic
    //  
    //  If adoAux(0) = 0 Then
    //    MsgBox ("Vous ne pouvez gérer que les accès web de vos clients")
    //  Else
    //    SpyLog "", Command2.Tag, "Entrée", "NCLINUM:" & adors("NCLINUM")
    //    If gModeActiveX Then
    //      OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmGestWebPer msTypePer=C|miNumPersonne=" & adors("NCLINUM"), vbNormalFocus
    //    Else
    //      frmGestWebPer.miNumPersonne = adors("NCLINUM")
    //      frmGestWebPer.sTypePer = "C"
    //      frmGestWebPer.Show vbModal
    //    End If
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "Command2_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdInfo_Click(object sender, EventArgs e)
    {
      // Nouvelle version générique
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmSaisieInfos
      {
        mstrTypeNote = "INFO_CLIENT",
        miCleTable = (int)row["NCLINUM"]
      }.ShowDialog();
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        if (MessageBox.Show(Resources.msg_voulez_vous_archiver_ce_client, Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdSupprimer.Tag.ToString(), "Suppression", $"NCLINUM:{row["NCLINUM"]}");

        ModuleData.ExecuteNonQuery($"update TCLI set CCLIACTIF = 'N' where NCLINUM = {row["NCLINUM"]}");
        // suppression des prix client FO
        ModuleData.ExecuteNonQuery($"DELETE TSTOCKARTCLI where NCLINUM = {row["NCLINUM"]}");
        // suppression des prix client PRESTATION
        ModuleData.ExecuteNonQuery($"DELETE TPRESTPRIXCLI where NCLINUM = {row["NCLINUM"]}");
        // Jean le 03/01/2014
        // suppression des tech imposés/interdit de tous les sites clients
        ModuleData.ExecuteNonQuery($"DELETE TTECHSITE WHERE NSITNUM IN (SELECT NSITNUM FROM TSIT WITH (NOLOCK) where NCLINUM = {row["NCLINUM"]})");

        // archivage des comptes analytiques
        ModuleData.ExecuteNonQuery($"UPDATE TCAN SET CCANACTIF = 'N' WHERE NCLINUM = {row["NCLINUM"]}");

        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, this.toolTip1.GetToolTip(cmdSupprimer), "Suppression", "DE:" + this.Text, $"NCLINUM:{row["NCLINUM"]}");

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        //apiTGrid1.GridControl.DataSource = dt;

      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdArchive.Tag.ToString(), "ARCHIVE");

      new frmGestClientsArch().ShowDialog();

      // rafraichissement de la liste au retour
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdCont_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdCont.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

      new frmGestContratClient(row["NCLINUM"], row["VCLINOM"]).ShowDialog();
    }

    private void cmdcarte_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        Cursor.Current = Cursors.WaitCursor;

        new frmBrowser
        {
          msStartingAddress = $"https://maps.emalec.com/SiteParAdresse.asp?NOM={row["VCLINOM"]}&AD1={row["VCLIAD1"]}&VILLE={row["VCLICP"]} {row["VCLIVIL"]}&PAYS={row["VCLIPAYS"]}"
        }.ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdImpl_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/ImplantationClient.asp?APP={MozartParams.NomSociete}"
      }.ShowDialog();
    }

    private void CmdListeAtt_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      //MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", CmdListeAtt.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

      new frmListeAtt
      {
        miNumClient = (int)row["NCLINUM"],
        msNomClient = (string)row["VCLINOM"]
      }.ShowDialog();
    }

    private void cmdImplantation_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/SitesClient.asp?base=MULTI&NCLINUM={row["NCLINUM"]}&VCLINOM={row["VCLINOM"]}&APP={MozartParams.NomSociete}"
      }.ShowDialog();
    }

    private void cmdCartePays_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/SitesClientPays.asp?base=MULTI&PAYS={row["VCLIPAYS"]}&APP={MozartParams.NomSociete}"
      }.ShowDialog();

    }

    private void cmdFichierContrat_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmGestProcedure
      {
        miNumSite = 0,
        mstrType = "PreventionContrat",
        miNumClient = (int)row["NCLINUM"],
        msTitre = $" du client : {row["VCLINOM"]}"
      }.ShowDialog();
    }

    private void cmdProcCli_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmGestProcedure
      {
        miNumSite = 0,
        mstrType = "PROCEDURE",
        miNumClient = (int)row["NCLINUM"],
        msTitre = $" du client : {row["VCLINOM"]}"
      }.ShowDialog();
    }

    private void cmdCout_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdProcCli.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

      new frmListeCoutsClient { miNumClient = (int)row["NCLINUM"] }.ShowDialog();
    }


    private void Command1_Click(object sender, EventArgs e)
    {
      frmListeArticlesClient frm = new frmListeArticlesClient();
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null != row)
      {
        frm.miNumClient = (int)row["NCLINUM"];
      }
      frm.ShowDialog();
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.nom, "VCLINOM", 2800);
      apiTGrid1.AddColumn(Resources.col_Adresse1, "VCLIAD1", 2100);
      apiTGrid1.AddColumn(Resources.col_Adresse2, "VCLIAD2", 1200);
      apiTGrid1.AddColumn(Resources.col_CP, "VCLICP", 700);
      apiTGrid1.AddColumn(MZCtrlResources.col_Ville, "VCLIVIL", 1700);
      apiTGrid1.AddColumn(MZCtrlResources.col_Pays, "VCLIPAYS", 800);
      apiTGrid1.AddColumn(Resources.col_Sites, "NB", 700);
      apiTGrid1.AddColumn(MZCtrlResources.date_creation, "DCLIDATECRE", 1100, "Date");
      apiTGrid1.AddColumn("Type", "VTYPECLIENT", 700);
      apiTGrid1.AddColumn("Nb actions sur 24 mois", "NB_ACT_EN_C", 700);
      apiTGrid1.AddColumn(Resources.col_Observ, "VCLIMESS", 2900);
      apiTGrid1.AddColumn("NumCli", "NCLINUM", 0);
      apiTGrid1.AddColumn("INTERDIT", "INTERDIT", 0);
      apiTGrid1.AddColumn("BCLIRAPPORTFM", "BCLIRAPPORTFM", 0);

      apiTGrid1.InitColumnList();
      apiTGrid1.GridControl.DataSource = dt;
    }

    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView View = sender as GridView;
        if (View.GetDataRow(e.RowHandle)["INTERDIT"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH8080FF;
          e.HighPriority = true;
        }
      }
    }

    private void cmdEIExt_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdEIExt.Tag.ToString(), "Entrée", $"NCLINUM:{row["NCLINUM"]}");

      new frmStockArticleClientExtincteurs((int)row["NCLINUM"], "M").ShowDialog();
    }

    private void CmdRapportFM_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        new FrmRapportFm_ListeRapportFM(row["NCLINUM"]).ShowDialog();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
    }

    private void CmdGestCMCE_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new FrmGestTechClient("C", row["NCLINUM"]).ShowDialog();
    }


    private void CmdKPI_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmClients_GestionKPI((int)row["NCLINUM"]).ShowDialog();
    }

    private void BtnPlanPrev_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmGestProcedure
      {
        miNumSite = 0,
        mstrType = "PLANPREVCLIENT",
        miNumClient = (int)row["NCLINUM"],
        msTitre = $" du client : {row["VCLINOM"]}"
      }.ShowDialog();
    }

    private void BtnInventaires_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmInventaireEquipementClient()
      {
        nclinum = (int)row["NCLINUM"],
        vclinom = row["VCLINOM"].ToString()
      }.ShowDialog();
    }

    private void frmGestClients_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", "", "Sortie");
    }

    private void BtnStatInventaire_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmInventaireEquipementClientStatByItem()
      {
        miNumClient = (int)row["NCLINUM"],
        msNomClient = row["VCLINOM"].ToString()
      }.ShowDialog();
    }
  }
}

