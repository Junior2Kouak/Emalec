using MZCtrlResources = MozartControls.Properties.Resources;
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

namespace MozartCS
{
  public partial class frmListeDevisWebST : Form
  {
    DataTable dt = new DataTable();

    public frmListeDevisWebST() { InitializeComponent(); }

    private void frmListeDevisWebST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeDevisWebSTT WHERE DWDEVDTRAITE is null");
        apiTGrid.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      int glNumActionOrigine;
      string sSQL;

      //test si la di est déjà prise
      if (DiBloquee((int)row["NWDEVNUM"]))
      {
        MessageBox.Show(Resources.msg_Devis_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      else ModuleData.ExecuteNonQuery($"update TWDEVISSTT set BWDEVLOCK = 1 where NWDEVNUM = {row["NWDEVNUM"]}"); //on la bloque

      //lier à la di saisie
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      //enregistrement de la date de création
      ModuleData.CnxExecute($"update TWDEVISSTT set DWDEVDTRAITE = GetDate() where NWDEVNUM = {row["NWDEVNUM"]}");

      //  plusieurs cas à gérer :
      //  Devis sous forme de scan pdf ou devis saisie sous formulaire
      //  Et Devis en réponse a demande de devis EMALEC ou devis a l'initiative du sous traitant
      //
      //  cas 1 : Devis scan sur demande Emalec   : on copie juste le scan dans l'action existante
      //  cas 2 : Devis scan du STT               : on crée une nouvelle action sur la di d'origine
      //  cas 3 : Devis formulaire du STT         : on crée une nouvelle action sur la di d'origine
      //  cas 4 : Devis formulaire sur demande Emalec : on crée une nouvelle action sur la di d'origine et on passe l'action de la demande en E,N, devis recu, attachement automatique et info dans observation
      //  cas 5 : Devis libre en scan du STT      : on crée une nouvelle DI et une nouvelle action sur le client / site

      // cas 5
      if (MozartParams.NumAction == 0)
      {
        MozartParams.NumDi = EnregistrerDiDevis((int)row["NCLINUM"], (int)row["NSITNUM"]);
        enregistrerActionDevis();
      }
      else
      {
        // cas 1
        if ((int)row["NDSTNUM"] != 0 && (string)row["VWDEVDESC"] == "Voir document joint") sSQL = "";
        // cas 2
        if ((int)row["NDSTNUM"] == 0 && (string)row["VWDEVDESC"] == "Voir document joint") enregistrerActionDevis();
        //cas 3
        if ((int)row["NDSTNUM"] == 0 && (string)row["VWDEVDESC"] != "Voir document joint") enregistrerActionDevisForm();
        //cas 4
        if ((int)row["NDSTNUM"] != 0 && (string)row["VWDEVDESC"] != "Voir document joint")
        {
          glNumActionOrigine = MozartParams.NumAction;
          enregistrerActionDevisForm();
          //traitement de l'action d'origine (test quand même si cette action n'est pas P ou E et C ou F)
          sSQL = $"update tact set CETACOD='E', CACTSTA='N', VACTATT='Automatique', DACTDEX = Getdate() " +
                 $"where cetacod <> 'E' and cetacod <> 'P' and cactsta <> 'C' and cactsta <> 'F' and nactnum= {glNumActionOrigine}";

          ModuleData.CnxExecute(sSQL);
          ModuleData.CnxExecute($"update tact set VACTOBS = 'Réception devis web STT sur nouvelle action créée.' + char(13) + char(10) + coalesce(VACTOBS, '') where nactnum = {glNumActionOrigine}");
          ModuleData.CnxExecute($"update TDST set VDSTSTA = 'Reçu', VDSTVALDEVIS = '{Utils.ZeroIfNull(row["NDEVSTTPRIX"].ToString())}' where NDSTNUM= {row["NDSTNUM"]}");
        }
      }
      //pose des photos sur l'action si elles exsitent
      EnregistrerPhotos();

      //aller sur cette action
      Cursor.Current = Cursors.WaitCursor;

      new frmDetailstravaux()
      {
        mstrDevisWeb = "OUI",
        mstrStatutAction = "M",
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_confirmation_suppression_devis, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.ExecuteNonQuery($"update TWDEVISSTT set DWDEVDTRAITE = GetDate() where NWDEVNUM =  {row["NWDEVNUM"]}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      string[,] TdbGlobal = { { "", "" } };

      //voir formulaire ou document pdf
      if ((string)row["VWDEVDESC"] == "Voir document joint")
      {
        //fichier pdf en photo 1
        string rsD = ModuleData.ExecuteScalarString($"select VWDEVPHOTO1 FROM TWDEVISPHOTO WHERE NWDEVPHONUM = {row["NDOCNUM"]}");

        if (rsD == "") return;

        new frmBrowserSimple()
        {
          StartingAddress = $"{Utils.RechercheParam("REP_PHOTOS_DEVIS")}{rsD}",
        }.ShowDialog();
      }
      else
      {
        new frmBrowser()
        {
          miPlanningAn = 0
        }.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TdevisSTTWeb.html",
                    @"TDevisSTTWeb.out.html",
                    TdbGlobal,
                    $"select * from api_v_ListeDevisWebSTT where NWDEVNUM= {row["NWDEVNUM"]}",
                    " (Visualisation devis)",
                    "PREVIEW");
      }
    }

    private void cmdListeArchives_click(object sender, EventArgs e)
    {
      new frmListeDevisWebSTArch().ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    private void InitApigrid()

    {
      apiTGrid.AddColumn("Num", "NWDEVNUM", 0);
      apiTGrid.AddColumn("N°", "VWDEVSTTREF", 1000);
      apiTGrid.AddColumn(Resources.col_SousTraitant, "VPERNOM", 1300);
      apiTGrid.AddColumn(Resources.col_DateArrivee, "DWDEVDATE", 850, "Date");
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1400);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid.AddColumn(Resources.col_Titre, "VWDEVTITRE", 1700);
      apiTGrid.AddColumn(Resources.col_Montant, "NDEVSTTPRIX", 0, "", 2);
      apiTGrid.AddColumn(Resources.col_Chaff, "CHAFF", 1000);
      apiTGrid.AddColumn(Resources.col_Description, "LIB", 2500);
      apiTGrid.AddColumn(Resources.col_fournitures, "VWDEVFOU", 0);
      apiTGrid.AddColumn("numcli", "NCLINUM", 0);
      apiTGrid.AddColumn("numsite", "NSITNUM", 0);
      apiTGrid.AddColumn(Resources.col_heure, "NHEUREJ", 0);
      apiTGrid.AddColumn(Resources.col_heuren, "NHEUREN", 0);
      apiTGrid.AddColumn(Resources.col_Tech, "NBTECH", 0);
      apiTGrid.AddColumn(Resources.col_DevTraite, "DevTraite", 0);

      apiTGrid.InitColumnList();
    }

    private bool DiBloquee(int Num)
    {
      return ModuleData.ExecuteScalarInt($"select BWDEVLOCK from TWDEVISSTT where NWDEVNUM = {Num}") == 1 ? true : false;
    }


    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void enregistrerActionDevis()
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
        {
          //passage du nom de la procédure stockée
          //passage des paramètres
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          //liste des paramètres
          cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
          cmd.Parameters["@iAction"].Value = 0;
          cmd.Parameters["@LibAction"].Value = "DEVIS WEB SOUS-TRAITANT : Voir devis du sous traitant en document interne";
          cmd.Parameters["@dDateS"].Value = DateTime.Now.ToShortDateString();
          cmd.Parameters["@iSite"].Value = row["NSITNUM"];
          cmd.Parameters["@cUrg"].Value = 1;
          cmd.Parameters["@cprest"].Value = "T";
          cmd.Parameters["@cTech"].Value = "M";
          cmd.Parameters["@cTypeAct"].Value = "A";
          cmd.Parameters["@iDuree"].Value = 0;
          cmd.Parameters["@iValeur"].Value = DBNull.Value;
          cmd.Parameters["@dDateEx"].Value = DBNull.Value;
          cmd.Parameters["@iTech"].Value = DBNull.Value;
          cmd.Parameters["@cTypeInter"].Value = "S";
          cmd.Parameters["@IST"].Value = row["NINTNUM"];
          cmd.Parameters["@cAttach"].Value = "";
          cmd.Parameters["@vObserv"].Value = $"Devis web STT de : {Utils.BlankIfNull(row["VPERNOM"])} le {Convert.ToDateTime(row["DWDEVDATE"]).ToShortDateString()}";
          cmd.Parameters["@vOutil"].Value = "";
          cmd.Parameters["@vFour"].Value = "";
          cmd.Parameters["@dDatePla"].Value = DBNull.Value;
          cmd.Parameters["@cEtat"].Value = "D";
          cmd.Parameters["@cNuit"].Value = "N";
          cmd.Parameters["@cCMD"].Value = "N";
          cmd.Parameters["@vDevis"].Value = "";
          cmd.Parameters["@mDevis"].Value = 0;
          cmd.Parameters["@vfactBudg"].Value = Utils.BlankIfNull(row["NWDEVNUM"]);//on utilise un champ existant dans tact pour mettre le numero de devis STT
          cmd.Parameters["@vRDV"].Value = "";
          cmd.Parameters["@cVueWeb"].Value = "N";
          cmd.Parameters["@nNbHPart"].Value = 0;
          cmd.Parameters["@idEquipement"].Value = Utils.BlankIfNull(row["NOBJNUM"]);

          //Exécuter la commande
          cmd.ExecuteNonQuery();

          //Récupération du numéro créé
          MozartParams.NumAction = (int)cmd.Parameters[0].Value;

          //Liaison entre l'action et le devis web
          ModuleData.ExecuteNonQuery($"Update TWDEVISSTT set NACTNUM = {MozartParams.NumAction} WHERE  NWDEVNUM= {row["NWDEVNUM"]}");
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void enregistrerActionDevisForm()
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"select TWDEVISSTT.* from TWDEVISSTT WHERE NWDEVNUM= {row["NWDEVNUM"]}"))
        {
          if (reader.Read())
          {
            string sdescription;
            //composition de la désignation
            sdescription = $"{Utils.BlankIfNull(reader["VWDEVTITRE"])}: {Utils.BlankIfNull(reader["VWDEVSUJET"])}{Environment.NewLine}CONSTAT:{Environment.NewLine}" +
                           $"{Utils.BlankIfNull(reader["VWDEVCONSTAT"])}{Environment.NewLine}PRESTATION:{Environment.NewLine}{Utils.BlankIfNull(reader["VWDEVDESC"])}";
            //création d'une commande
            using (SqlCommand cmd = new SqlCommand("api_sp_creationAction", MozartDatabase.cnxMozart))
            {
              //Passage du nom de la procédure stockée
              //Passage des paramètres
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);

              cmd.Parameters["@iDI"].Value = MozartParams.NumDi;
              cmd.Parameters["@iAction"].Value = 0;
              cmd.Parameters["@LibAction"].Value = sdescription;
              cmd.Parameters["@dDateS"].Value = DateTime.Now.ToShortDateString();
              cmd.Parameters["@iSite"].Value = row["NSITNUM"];
              cmd.Parameters["@cUrg"].Value = 1;
              cmd.Parameters["@cprest"].Value = "T";
              cmd.Parameters["@cTech"].Value = "M";
              cmd.Parameters["@cTypeAct"].Value = "A";
              cmd.Parameters["@iDuree"].Value = Utils.ZeroIfNull(reader["NWDEVHJ"]) + Utils.ZeroIfNull(reader["NWDEVHN"]) + Utils.ZeroIfNull(reader["NWDEVHH"]);
              cmd.Parameters["@iValeur"].Value = DBNull.Value;
              cmd.Parameters["@dDateEx"].Value = DBNull.Value;
              cmd.Parameters["@iTech"].Value = DBNull.Value;
              cmd.Parameters["@cTypeInter"].Value = "S";
              cmd.Parameters["@IST"].Value = row["NINTNUM"];
              cmd.Parameters["@cAttach"].Value = "";
              cmd.Parameters["@vObserv"].Value = $"Devis web STT de : {Utils.BlankIfNull(row["VPERNOM"])} le {Convert.ToDateTime(row["DWDEVDATE"]).ToShortDateString()}";
              cmd.Parameters["@vOutil"].Value = $"Durée: {Utils.BlankIfNull(reader["NWDEVHJ"])} {reader["NWDEVHN"]} {reader["NWDEVHH"]} heures";
              cmd.Parameters["@vFour"].Value = Strings.Left(Utils.BlankIfNull(reader["VWDEVFOU"]), 1000);
              cmd.Parameters["@dDatePla"].Value = DBNull.Value;
              cmd.Parameters["@cEtat"].Value = "D";

              if ((int)reader["NWDEVHH"] > 0)
                cmd.Parameters["@cNuit"].Value = "P";
              else if ((int)reader["NWDEVHN"] > 0)
                cmd.Parameters["@cNuit"].Value = "O";
              else
                cmd.Parameters["@cNuit"].Value = "N";

              cmd.Parameters["@cCMD"].Value = "N";
              cmd.Parameters["@vDevis"].Value = "";
              cmd.Parameters["@mDevis"].Value = Utils.ZeroIfNull(reader["NDEVSTTPRIX"]); //montant du devis;
              cmd.Parameters["@vfactBudg"].Value = Utils.BlankIfNull(reader["NWDEVNUM"]);//on utilise un champ existant dans tact pour mettre le numero de devis
              cmd.Parameters["@vRDV"].Value = "";
              cmd.Parameters["@cVueWeb"].Value = "N";

              if ((int)reader["NWDEVHH"] > 0)
                cmd.Parameters["@nNbHPart"].Value = (int)reader["NWDEVHH"];
              else if ((int)reader["NWDEVHN"] > 0)
                cmd.Parameters["@nNbHPart"].Value = (int)reader["NWDEVHN"];
              else
                cmd.Parameters["@nNbHPart"].Value = 0;

              //Exécuter la commande
              cmd.ExecuteNonQuery();

              //Récupération du numéro crée
              MozartParams.NumAction = (int)cmd.Parameters[0].Value;

              //Liaison entre l'action et le devis web
              ModuleData.ExecuteNonQuery($"Update TWDEVISSTT set NACTNUM = {MozartParams.NumAction} WHERE  NWDEVNUM = {row["NWDEVNUM"]}");
            }
          }
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void EnregistrerPhotos()
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        //récupération des photos
        //récupérations des images de la table des photos pour enregistrement dans la table des devis
        string sSQL = $"update TWDEVISSTT set TWDEVISSTT.VWDEVPHOTO1 = P.VWDEVPHOTO1, TWDEVISSTT.VWDEVPHOTO2 = P.VWDEVPHOTO2, TWDEVISSTT.VWDEVPHOTO3 = P.VWDEVPHOTO3," +
                      $" TWDEVISSTT.VWDEVPHOTO4 = P.VWDEVPHOTO4, TWDEVISSTT.VWDEVPHOTO5 = p.VWDEVPHOTO5" +
                      $" from  TWDEVISPHOTO P where   P.NWDEVPHONUM = {row["NDOCNUM"]} AND  P.NWDEVPHONUM = TWDEVISSTT.NDOCNUM";

        ModuleData.CnxExecute(sSQL);

        //on recherche si il y a des photos sur ce devis
        using (SqlDataReader drD = ModuleData.ExecuteReader($"select VWDEVPHOTO1, VWDEVPHOTO2, VWDEVPHOTO3, VWDEVPHOTO4, VWDEVPHOTO5 FROM TWDEVISSTT WHERE NWDEVNUM = {row["NWDEVNUM"]}"))
        {
          // On ramène le montant de débours
          if (drD.Read())
          {
            for (int i = 1; i < 6; i++)
            {
              if (Utils.BlankIfNull(drD[$"VWDEVPHOTO{i}"]) != "")
              {
                EnregDocument((string)drD[$"VWDEVPHOTO{i}"]);
              }
            }
          }
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
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

        //si photos, il faut les copier sur l'action
        //recherche du répertoire de sauvegarde des images sur le serveur
        strRepSource = Utils.RechercheParam("REP_PHOTOS_DEVIS");
        strRepDest = Utils.RechercheParam("REP_PHOTOS_ACT");

        //recherche du numéro d'image
        using (SqlCommand cmd = new SqlCommand("api_sp_GetCpt", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@cElt"].Value = "IMGACT";
          cmd.Parameters["@iCpt"].Value = 0;

          cmd.ExecuteNonQuery();

          lcount = (int)cmd.Parameters["@iCpt"].Value;
        }

        //composition du nom de l'image
        sExtension = Path.GetExtension(strNomImage).Substring(1);
        TextFic = $"{MozartParams.NumAction}_{lcount}.{sExtension}";

        //Enregistrement de l'image dans la table
        using (SqlCommand cmd = new SqlCommand("api_sp_EnregImgAct", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iNIMAGE"].Value = 0;
          cmd.Parameters["@iNACTNUM"].Value = MozartParams.NumAction;
          cmd.Parameters["@vVIMAGE"].Value = sExtension.ToLower() == "pdf" ? "Document pour devis" : "Photo pour devis";
          cmd.Parameters["@vVFICHIER"].Value = TextFic.Trim();
          cmd.Parameters["@cCFORMAT"].Value = sExtension;
          cmd.Parameters["@vVCOMMENT"].Value = "";
          cmd.Parameters["@vVTYPE"].Value = sDocType;
          cmd.Parameters["@vWEB"].Value = "N";
          cmd.Parameters["@vTypeDest"].Value = "I"; //"T" document interne
          cmd.Parameters["@nTypeDoc"].Value = 12; //type de document : divers

          cmd.ExecuteNonQuery();

          miImage = (int)cmd.Parameters["@iNIMAGE"].Value;

          //copie physique de l'image
          File.Copy(strRepSource + strNomImage, strRepDest + TextFic);
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private int EnregistrerDiDevis(int iNumcli, int iNumsite)
    {
      using (SqlCommand cmd = new SqlCommand("Api_sp_CreationDIDevisSTT", MozartDatabase.cnxMozart))
      {
        //Passage du nom de la procédure stockée
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        //Liste des paramètres
        cmd.Parameters["@iNumCli"].Value = iNumcli;
        cmd.Parameters["@iSite"].Value = iNumsite;
        cmd.Parameters["@Demandeur"].Value = MozartParams.NomSociete;
        cmd.Parameters["@vRefClient"].Value = "Devis STT";

        //Exécuter la commande
        cmd.ExecuteNonQuery();

        //Récupération du numéro crée
        return (int)cmd.Parameters[0].Value;
      }
    }

  }
}

