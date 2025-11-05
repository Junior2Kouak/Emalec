using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmListeDevisWeb : Form
  {
    private DataTable dt = new DataTable();

    public frmListeDevisWeb()
    {
      InitializeComponent();
    }

    private void frmListeDevisWeb_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeDevisWebTech WHERE DWDEVDTRAITE is null order by DWDEVDATE desc");
        apiTGrid.GridControl.DataSource = dt;

        InitApigrid();
        InitapiGridClients();
        InitapiGridChaff();
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

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      ModuleData.RemplirCombo(cboDI, $"select distinct TDIN.NDINNUM, TDIN.NDINNUM FROM TACT WITH (NOLOCK) INNER JOIN TDIN ON TDIN.NDINNUM=TACT.NDINNUM WHERE DDINDAT > DateAdd(Month, -18, Getdate()) AND TACT.NSITNUM= {row["NSITNUM"]} ORDER BY TDIN.NDINNUM DESC ", true);
      cboDI.ValueMember = "NDINNUM";
      cboDI.DisplayMember = "NDINNUM";
      DataTable dt = cboDI.DataSource as DataTable;
      DataRow vide = dt.NewRow();
      dt.Rows.InsertAt(vide, 0);
      cboDI.SelectedIndex = 0;

      FrameWeb.Visible = true;
    }

    private void cmdValide_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (cboDI.Text == "")
      {
        MessageBox.Show(Resources.msg_ChoisirDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (DiBloquee((int)row["NWDEVNUM"]))
      {
        MessageBox.Show(Resources.msg_Devis_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      MozartDatabase.ExecuteNonQuery($"update TWDEVIS set BWDEVLOCK = 1 where NWDEVNUM = {row["NWDEVNUM"]}");

      MozartParams.NumDi = Convert.ToInt32(cboDI.Text);

      //Enregistrement de la date de création
      MozartDatabase.ExecuteNonQuery($"update TWDEVIS set DWDEVDTRAITE = GetDate(), NQUIARCHIVE = {MozartParams.UID} where NWDEVNUM = {row["NWDEVNUM"]}");
      //Enregistrement de l'action
      enregistrerActionDevis();
      //Pose des photos sur l'action si elles existent
      EnregistrerPhotos();

      Cursor.Current = Cursors.WaitCursor;

      {
        new frmDetailstravaux()
        {
          mstrStatutAction = "M",
          mstrDevisWeb = "OUI"
        }.ShowDialog();
      }

      FrameWeb.Visible = false;

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdForm_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      new frmCorrectionDevisSTT
      {
        NumDevis = (int)row["NWDEVNUM"]
      }.ShowDialog();
    }

    private void cmdAnnule_Click(object sender, EventArgs e)
    {
      FrameWeb.Visible = false;

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumDi = 0;

      if (DiBloquee((int)row["NWDEVNUM"]))
      {
        MessageBox.Show(Resources.msg_Devis_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      MozartDatabase.ExecuteNonQuery($"update TWDEVIS set BWDEVLOCK = 1 where NWDEVNUM = {row["NWDEVNUM"]}");

      new frmAddAction()
      {
        BrowseText = row["LIB"].ToString().Replace("\r\n", "<BR>").Replace(";", " ").Replace("=", " "),
        miNumClient = (int)row["NCLINUM"],
        miNumSite = (int)row["NSITNUM"],
        miNumDevisWeb = (int)row["NWDEVNUM"],
        dDevisWebDate = (DateTime)row["DWDEVDSAISIE"],
        sChaff = Utils.BlankIfNull(row["CHAFF"]),
        mstrStatutDI = "DevWeb"
      }.ShowDialog();

      if (!DiTraitee((int)row["NWDEVNUM"]))
      {
        MozartDatabase.ExecuteNonQuery($"update TWDEVIS set BWDEVLOCK = 0 where NWDEVNUM = {row["NWDEVNUM"]}");
      }

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_confirmation_suppression_devis, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      MozartDatabase.ExecuteNonQuery($"update TWDEVIS set DWDEVDTRAITE = getdate(), NACTNUM=1, NQUIARCHIVE = {MozartParams.UID} where NWDEVNUM = {row["NWDEVNUM"]}");
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      string[,] TdbGlobal = { { "", "" } };

      new frmVisuDevisWebTech().Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TDevisTechWeb.html",
                                              $@"TDevisTechWeb.out.html",
                                              TdbGlobal,
                                              $"select * from api_v_ListeDevisWebTech where NWDEVNUM={row["NWDEVNUM"]}",
                                              " (Visualisation devis)",
                                              "PREVIEW");
    }

    private void CmdListeDevisArchTech_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      new frmListeDevisWebArch(apiTGrid.dgv.ActiveFilterCriteria).ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }


    private void InitapiGridClients()
    {
      DataTable dtLocal = new DataTable();

      apiTGridClients.LoadData(dtLocal, MozartDatabase.cnxMozart, $"SELECT count(distinct TWDEVIS.NWDEVNUM) as NB, TCLI.VCLINOM FROM TCLI INNER JOIN TWDEVIS ON TCLI.NCLINUM = TWDEVIS.NCLINUM WHERE TWDEVIS.CDEVTYPE = 'TEC' AND TCLI.VSOCIETE = '" + MozartParams.NomSociete + "' and DWDEVDTRAITE is null group by TCLI.VCLINOM order by NB DESC");
      apiTGridClients.GridControl.DataSource = dtLocal;

      apiTGridClients.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2700);
      apiTGridClients.AddColumn("Nombre", "NB", 700);

      apiTGridClients.InitColumnList();
    }

    private void InitapiGridChaff()
    {
      DataTable dtLocal = new DataTable();

      apiTGridChaff.LoadData(dtLocal, MozartDatabase.cnxMozart, $"Exec api_sp_ListeNbDevisWebChaff");
      apiTGridChaff.GridControl.DataSource = dtLocal;

      apiTGridChaff.AddColumn("Chargé d'affaire", "CHAFF", 2700);
      apiTGridChaff.AddColumn("Nombre", "NB", 700);

      apiTGridChaff.InitColumnList();
    }

    private void InitApigrid()
    {
      apiTGrid.AddColumn("Num", "NWDEVNUM", 600);
      apiTGrid.AddColumn(Resources.col_Technicien, "VPERNOM", 1400);
      apiTGrid.AddColumn(MZCtrlResources.col_DateArr, "DWDEVDATE", 850, "Date");
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apiTGrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1500);
      apiTGrid.AddColumn(Resources.col_Titre, "VWDEVTITRE", 1700);
      apiTGrid.AddColumn(Resources.col_Chaff, "CHAFF", 1400);
      apiTGrid.AddColumn(Resources.col_RM, "VCCLNOM", 1000, "", 0, true);
      apiTGrid.AddColumn(Resources.col_Description, "LIB", 2800);
      apiTGrid.AddColumn(Resources.col_fournitures, "VWDEVFOU", 2500);
      apiTGrid.AddColumn("Photos", "WPHOTO", 900);
      apiTGrid.AddColumn("Ancienneté", "Anc", 800);
      apiTGrid.AddColumn("numcli", "NCLINUM", 0);
      apiTGrid.AddColumn("numsite", "NSITENUM", 0);
      apiTGrid.AddColumn(Resources.col_heure, "NHEUREJ", 0);
      apiTGrid.AddColumn(Resources.col_heuren, "NHEUREN", 0);
      apiTGrid.AddColumn(Resources.col_Tech, "NBTECH", 0);

      apiTGrid.InitColumnList();
      apiTGrid.dgv.OptionsView.ColumnAutoWidth = false;
    }

    private bool DiBloquee(int Num)
    {
      return (MozartDatabase.ExecuteScalarInt($"select BWDEVLOCK from TWDEVIS where NWDEVNUM = " + Num) != 0);
    }

    private bool DiTraitee(int Num)
    {
      return (Utils.BlankIfNull(ModuleData.ExecuteScalarString($"select DWDEVDTRAITE from TWDEVIS where NWDEVNUM = " + Num)) != "");
    }

    private void enregistrerActionDevis()
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        string sdescription;
        //Composition de la désignation
        sdescription = $"{Utils.BlankIfNull(row["VWDEVTITRE"])}: {Utils.BlankIfNull(row["VWDEVSUJET"])}{Environment.NewLine}CONSTAT:{Environment.NewLine}" +
                       $"{Utils.BlankIfNull(row["VWDEVCONSTAT"])}{Environment.NewLine}PRESTATION:{Environment.NewLine}{Utils.BlankIfNull(row["VWDEVDESC"])}";
        //Création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
        {
          //Passage du nom de la procédure stockée
          //Passage des paramètres
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          //Liste des paramètres
          cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
          cmd.Parameters["@iAction"].Value = 0;
          cmd.Parameters["@LibAction"].Value = sdescription;
          cmd.Parameters["@dDateS"].Value = DateTime.Now.ToShortDateString();
          cmd.Parameters["@iSite"].Value = row["NSITNUM"];
          cmd.Parameters["@cUrg"].Value = 1;
          cmd.Parameters["@cprest"].Value = "T";
          cmd.Parameters["@cTech"].Value = "M";
          cmd.Parameters["@cTypeAct"].Value = "A";
          cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(row["NWDEVHJ"]) + Utils.ZeroIfNull(row["NWDEVHN"]) + Utils.ZeroIfNull(row["NWDEVHH"]);
          cmd.Parameters["@iValeur"].Value = DBNull.Value;
          cmd.Parameters["@dDateEx"].Value = DBNull.Value;
          cmd.Parameters["@iTech"].Value = DBNull.Value;
          cmd.Parameters["@cTypeInter"].Value = "T";
          cmd.Parameters["@IST"].Value = DBNull.Value;
          cmd.Parameters["@cAttach"].Value = "";
          cmd.Parameters["@vObserv"].Value = $"Devis web de : {Utils.BlankIfNull(row["VPERNOM"])} le {Convert.ToDateTime(row["DWDEVDATE"]).ToShortDateString()}{Environment.NewLine}" +
                                             $"{(((int)row["NWDEVTECH"] == 1) ? "1 technicien" : "2 techniciens")}.{((Utils.ZeroIfNull(row["NWDEVHN"]) > 0) ? Utils.ZeroIfNull(row["NWDEVHN"]).ToString() + " heures hors ouverture" : "")}";
          cmd.Parameters["@vOutil"].Value = Utils.BlankIfNull(row["VWDEV_SECU"]);  //VACTOUT
          cmd.Parameters["@vFour"].Value = Strings.Left(Utils.BlankIfNull(row["VWDEVFOU"]), 5000);
          cmd.Parameters["@dDatePla"].Value = DBNull.Value;
          cmd.Parameters["@cEtat"].Value = "D";

          if ((int)row["NWDEVHH"] > 0)
            cmd.Parameters["@cNuit"].Value = "P";
          else if ((int)row["NWDEVHN"] > 0)
            cmd.Parameters["@cNuit"].Value = "O";
          else
            cmd.Parameters["@cNuit"].Value = "N";

          cmd.Parameters["@cCMD"].Value = "N";
          cmd.Parameters["@vDevis"].Value = "";
          cmd.Parameters["@mDevis"].Value = 0;
          cmd.Parameters["@vfactBudg"].Value = Utils.BlankIfNull(row["NWDEVNUM"]);//on utilise un champ existant dans tact pour mettre le numero de devis STT
          cmd.Parameters["@vRDV"].Value = "";
          cmd.Parameters["@cVueWeb"].Value = "N";

          if ((int)row["NWDEVHH"] > 0)
            cmd.Parameters["@nNbHPart"].Value = (int)row["NWDEVHH"];
          else if ((int)row["NWDEVHN"] > 0)
            cmd.Parameters["@nNbHPart"].Value = (int)row["NWDEVHN"];
          else
            cmd.Parameters["@nNbHPart"].Value = 0;

          //Exécuter la commande
          cmd.ExecuteNonQuery();

          //Récupération du numéro créé
          MozartParams.NumAction = (int)cmd.Parameters[0].Value;

          //Liaison entre l'action et le devis web
          MozartDatabase.ExecuteNonQuery($"Update TWDEVIS set NACTNUM = {MozartParams.NumAction} WHERE  NWDEVNUM = {row["NWDEVNUM"]}");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerPhotos()
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        //On recherche s'il y a des photos sur ce devis
        MozartDatabase.ExecuteNonQuery($"select VWDEVPHOTO1, VWDEVPHOTO2, VWDEVPHOTO3, VWDEVPHOTO4, VWDEVPHOTO5 FROM TWDEVIS WHERE NWDEVNUM = {row["NWDEVNUM"]}");

        for (int i = 1; i < 6; i++)
        {
          if (Utils.BlankIfNull(row[$"VWDEVPHOTO{i}"]) != "")
            EnregDocument((string)row[$"VWDEVPHOTO{i}"]);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregDocument(string strNomImage, string sDocType = "IMAGE")
    {
      try
      {
        int lcount;
        string TextFic;
        int miImage;
        string strRepSource;
        string strRepDest;
        string sExtension;

        //Si photos, il faut les copier sur l'action
        //Recherche du répertoire de sauvegarde des images sur le serveur
        strRepSource = Utils.RechercheParam("REP_PHOTOS_DEVIS");
        strRepDest = Utils.RechercheParam("REP_PHOTOS_ACT");

        //Recherche du numéro d'image
        using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@cElt"].Value = "IMGACT";
          cmd.Parameters["@iCpt"].Value = 0;

          cmd.ExecuteNonQuery();

          lcount = (int)cmd.Parameters["@iCpt"].Value;
        }

        //Composition du nom de l'image
        sExtension = Strings.Right(strNomImage, 4);
        if (Strings.InStr(sExtension, ".") != 0)
          sExtension = Strings.Right(strNomImage, 3);

        TextFic = $"{MozartParams.NumAction}_{lcount}.{sExtension}";

        //Enregistrement de l'image dans la table
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNIMAGE"].Value = 0;
          cmd.Parameters["@iNACTNUM"].Value = MozartParams.NumAction;
          cmd.Parameters["@vVIMAGE"].Value = "Photo pour devis";
          cmd.Parameters["@vVFICHIER"].Value = TextFic.Trim();
          cmd.Parameters["@cCFORMAT"].Value = sExtension;
          cmd.Parameters["@vVCOMMENT"].Value = "";
          cmd.Parameters["@vVTYPE"].Value = sDocType;
          cmd.Parameters["@vWEB"].Value = "N";
          cmd.Parameters["@vTypeDest"].Value = "I";
          cmd.Parameters["@nTypeDoc"].Value = 12;

          cmd.ExecuteNonQuery();

          miImage = (int)cmd.Parameters["@iNIMAGE"].Value;

          //Copie physique de l'image
          File.Copy(strRepSource + strNomImage, strRepDest + TextFic);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void BtnDevisAttente_Click(object sender, EventArgs e)
    {
      new frmListeRappelDevisWebAttente().ShowDialog();
    }
  }
}
