using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmMenuEmPlus : Form
  {
    private int NACTNUM;

    private string API_TOKEN = "";
    private string API_SECRET = "";
    private string TENANT = "";
    private string BASE_URL = "";

    private const string STATUT_ATTENTE_RAPPORT = "Intervention effectuée - Attente rapport d'intervention";
    private const string STATUT_ATTENTE_DEVIS = "Intervention effectuée – Attente du devis de régularisation";
    private const string STATUT_ATTENTE_PDV = "Intervention effectuée – Attente évaluation PDV";
    private const string STATUT_ATTENTE_PDV_DEVIS = "Intervention effectuée – Attente évaluation PDV (Devis)";



    public string strObservation = "";
    public string strRepImage = "";
    public string strRepAtt = "";


    List<List<string>> ListePJ;

    private frmMenuEmPlus()
    {
      InitializeComponent();
    }

    public frmMenuEmPlus(int numAction, string numGMAO, string dateCreation, string datePlanification, string dateIntervention, string Qui) : this()
    {
      NACTNUM = numAction;

      txtNumTask.Text = numGMAO;
      txtDateCreation.Text = dateCreation;
      txtDatePlanification.Text = datePlanification;
      txtDateIntervention.Text = dateIntervention;
      txtQuiInforme.Text = Qui;
    }

    private void frmMenuEmPlus_Load(object sender, EventArgs e)
    {
      ListePJ = new List<List<string>>();
      GetInfoConnexionEmPlus();
      strObservation = "";
      txtEmplusResponse.Text = "";
    }

    // -------------------------------------------------------------------------
    private void btnCreateDi_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      try
      {
        checkCommonParameters();

        if (string.IsNullOrEmpty(txtDateCreation.Text))
          throw new Exception("Invalid DateCreation");

        string result = "";
        string Note = $"Date de prise en compte le {txtDateCreation.Text}";
        if (!DiEmPlus.AddNote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.AddNoteBody() { Note = Note }, ref result))
          throw new Exception($"{result}");

        // 
        //string sql = $@"INSERT INTO TDIEMPLUS (NACTNUM, VGMAO) VALUES ({NACTNUM},'{txtNumTask.Text}')";
        //using (var cmd = new SqlCommand(sql, MozartDatabase.cnxMozart))
        //{
        //    cmd.ExecuteNonQuery();
        //}

        LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la date de création ({txtDateCreation.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Envoi de la date de création de l'action";
        strObservation = $"{strObservation}\r\nEnvoi de la date de création ({txtDateCreation.Text}) vers EM+";

      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;
    }

    // -------------------------------------------------------------------------
    private void btnSendDatePlanification_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();

        if (string.IsNullOrEmpty(txtDatePlanification.Text))
          throw new Exception("Date de planification non valide");

        string result = "";
        string Note = $"Date de planification: {txtDatePlanification.Text} / Personne informée: {txtQuiInforme.Text}";
        if (!DiEmPlus.AddNote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.AddNoteBody() { Note = Note }, ref result))
          throw new Exception($"{result}");

        //txtEmplusResponse.Text = result;
        LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la date de planification ({txtDatePlanification.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Envoi de la date de planification de l'action";
        strObservation = $"{strObservation}\r\nEnvoi de la date de planification ({txtDatePlanification.Text}) vers EM+";
      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        // MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //               MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;
    }

    // -------------------------------------------------------------------------
    private void btnSendDateIntervention_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();

        if (string.IsNullOrEmpty(txtDateIntervention.Text))
          throw new Exception("Date d'exécution non valide");

        // confirmation utilisateur
        string msg = $"L’envoi d’une date d’exécution changera définitivement le statut de la DI sur la GMAO client.\r\n" +
          $"Êtes-vous certain qu’il n’y aura pas de suite à cette intervention ?";
        if (MessageBox.Show(msg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        string result = "";
        string Note = $"Date d'exécution: {txtDateIntervention.Text}";
        // envoie de la date d'exécution
        if (!DiEmPlus.AddNote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.AddNoteBody() { Note = Note }, ref result))
          throw new Exception($"{result}");

        // garder le résultat de l'envoi de la date d'exécution
        string resultat1 = $"OK - Envoi de la date d'exécution ({txtDateIntervention.Text}){Environment.NewLine}{Environment.NewLine}";
        LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la date d'exécution ({txtDateIntervention.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        strObservation = $"Envoi de la date d'exécution ({txtDateIntervention.Text}) vers EM+";

        // changement du statut
        if (!DiEmPlus.ChangeStatus(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.ChangeStatusBody() { StatusName = STATUT_ATTENTE_RAPPORT, StatusChangeDateTimeUtc = DateTime.UtcNow.ToString("s") }, ref result))
          throw new Exception($"{resultat1}{Environment.NewLine}{Environment.NewLine}{result}");


        LogInfo($"GMAO: {txtNumTask.Text},\tChangement de statut de l'action : {STATUT_ATTENTE_RAPPORT}, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Envoi de la date d'exécution et changement du statut de l'action";
        strObservation = $"{strObservation}\r\nEnvoi de la date d'exécution ({txtDateIntervention.Text}) et changement du statut ({STATUT_ATTENTE_RAPPORT}) dans EM+";
      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;
    }


    // -------------------------------------------------------------------------
    private void btnSendPieceJointe_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();

        FileInfo fileInfo = GetAttachment();

        if (fileInfo == null)
          throw new Exception("Pas d'attachement sur l'action");

        byte[] fileContent = File.ReadAllBytes(fileInfo.FullName);

        if (!string.IsNullOrEmpty(txtNumTask.Text))
        {

          // envoi de l'attachement
          string result = "";
          if (!DiEmPlus.UploadDocument(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, fileInfo, fileContent, "application/pdf", ref result))
            throw new Exception($"{result}");

          // garder le résultat de Result de l'upload du fichier
          string resultat1 = "";
          if (result == "")
          {
            // envoi correct
            resultat1 = "OK - Envoi de l'attachement";
            strObservation = $"{strObservation}{Environment.NewLine}Envoi de l'attachement dans EM+";
            LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de l'attachement, Action : {NACTNUM}, Attachement {fileInfo.FullName}{Environment.NewLine}{Environment.NewLine}");
          }
          else
          {
            // erreur de copie car fichier existe déjà 
            resultat1 = result;
          }

          // Ajout d'une Note
          string Note = $"Envoi de l'attachement dans EM+";
          String resa = "";
          // Note d'information sur l'envoi de l'attachement
          if (!DiEmPlus.AddNote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.AddNoteBody() { Note = Note }, ref resa))
            throw new Exception($"{resa}");

          // changement du statut
          if (!DiEmPlus.ChangeStatus(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.ChangeStatusBody() { StatusName = STATUT_ATTENTE_DEVIS, StatusChangeDateTimeUtc = DateTime.UtcNow.ToString("s") }, ref result))
            throw new Exception($"{resultat1}{Environment.NewLine}{Environment.NewLine}{result}");
        }

        LogInfo($"GMAO: {txtNumTask.Text},\tChangement de statut de l'action : {STATUT_ATTENTE_DEVIS},  Action : {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Envoi de l'attachement et changement de statut";
        strObservation = $"{strObservation}{Environment.NewLine}Envoi de l'attachement et changement de statut ({STATUT_ATTENTE_DEVIS}) dans EM+ ";

      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;
    }


    // -------------------------------------------------------------------------
    private void btnSendDevis_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();

        decimal amount = 0;
        FileInfo fileInfo = GetDevis(ref amount);

        if (fileInfo == null)
          throw new Exception("Pas de devis sur l'action");

        byte[] fileContent = File.ReadAllBytes(fileInfo.FullName);

        string result = "";
        if (!DiEmPlus.AddQuote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, amount, fileInfo, fileContent, "application/pdf", ref result))
          throw new Exception($"{result}");


        LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi du devis,  Action : {NACTNUM}, Devis {fileInfo.FullName}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Envoi du devis";
        strObservation = $"{strObservation}\r\nEnvoi du devis vers EM+";

      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;
    }

    private void cmdValide_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      try
      {
        checkCommonParameters();

        if (string.IsNullOrEmpty(txtNote.Text))
        {
          MessageBox.Show($"Il faut saisir une Note", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        string result = "";
        if (!DiEmPlus.AddNote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.AddNoteBody() { Note = txtNote.Text }, ref result))
          throw new Exception($"{result}");

        LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de la Note ({txtNote.Text}), Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Envoi de la Note";
        strObservation = $"{strObservation}\r\nEnvoi d'une Note vers EM+ : {txtNote.Text}";

        FrameNote.Visible = false;

      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;

    }

    private void btnChangeStatut_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();

        // changement du statut
        string result = "";
        if (!DiEmPlus.ChangeStatus(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.ChangeStatusBody() { StatusName = STATUT_ATTENTE_PDV, StatusChangeDateTimeUtc = DateTime.UtcNow.ToString("s") }, ref result))
          throw new Exception($"'\r\n{result}");

        LogInfo($"GMAO: {txtNumTask.Text},\tChangement de statut de l'action : : {STATUT_ATTENTE_PDV},  Action : {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Changement de statut";
        strObservation = $"{strObservation}\r\nChangement de statut ({STATUT_ATTENTE_PDV}) dans EM+ ";

      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;
    }


    // -------------------------------------------------------------------------
    private void LogInfo(string message)
    {
      //txtEmplusResponse.Text = message;

      ModuleData.ExecuteNonQuery($"Insert into TEMPLUS_LOG (VLOGMSG) Values ('{message.Replace("'", "''")}')");
    }


    // -------------------------------------------------------------------------
    private void GetInfoConnexionEmPlus()
    {
      try
      {
        // recherche des codes du client pour accés EmPlus
        string sql =  $"select URL, API_TOKEN, API_SECRET, TENANT from TACT A inner join TDIN D ON A.NDINNUM=D.NDINNUM " +
                      $"  INNER JOIN TEMPLUS_TCLI S On D.NCLINUM = S.NCLINUM where A.NACTNUM = {NACTNUM}";

        SqlCommand cmd = new SqlCommand(sql, MozartDatabase.cnxMozart);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
          BASE_URL = dr["URL"].ToString();
          API_TOKEN = dr["API_TOKEN"].ToString();
          API_SECRET = dr["API_SECRET"].ToString();
          TENANT = dr["TENANT"].ToString();
        }
        dr.Close();

        //sql = $"SELECT STATUS_ID, STATUS FROM TEMPLUS_STATUS";
        //cmd = new SqlCommand(sql, MozartDatabase.cnxMozart);
        //dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{

        //  switch (dr["STATUS_ID"].ToString())
        //  {
        //    case ENVOI_DEVIS_STATUS:
        //      txtStatusEnvoiDevis.Text = dr["STATUS"].ToString();
        //      break;

        //    case DATE_INTERVENTION_STATUS:
        //      txtStatusDateIntervention.Text = dr["STATUS"].ToString();
        //      break;
        //  }
        //}
        //dr.Close();
      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // -------------------------------------------------------------------------
    private FileInfo GetAttachment()
    {
      try
      {
        string sFile = "";
        string sRep = "";

        SqlCommand cmd = new SqlCommand($"Exec api_sp_GetFileAttachementByAction {NACTNUM}", MozartDatabase.cnxMozart);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
          sFile = dr["VFICHIER"].ToString();

          if (dr["VTYPE"].ToString() == "IMAGE")
          {
            sRep = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_PHOTOS_ACT' AND VSOCIETE = '{MozartParams.NomSociete}'");
          }
          else
          {
            sRep = ModuleData.ExecuteScalarString($"SELECT VPARVAL FROM TPAR WHERE VPARLIB = 'REP_ATTGAM' AND VSOCIETE = '{MozartParams.NomSociete}'");
          }


        }
        dr.Close();


        if (!string.IsNullOrEmpty(sFile))
        {

          LogInfo($"GMAO: {txtNumTask.Text}, \tSendFile Action: {NACTNUM}, Attachement: {sRep + sFile}");
          if (!File.Exists(sRep + sFile))
          {
            LogInfo($"GMAO: {txtNumTask.Text}, Error : Attachement {sFile} introuvable !");
            return null;
          }
          else
          {
            return new FileInfo(sRep + sFile);
          }
        }
      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return null;
    }

    // -------------------------------------------------------------------------
    private FileInfo GetDevis(ref decimal montant)
    {
      try
      {
        int numDCL = 0;
        string dPrice = "";
        string typeDevis = "";
        string typeModele = "";
        // FGA le 10/10/23 pas besoin de faire référence à la table EMPLUS car on peut envoyer devis meme si rien dans la table
        //                string sql = @"select NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TDIEMPLUS E INNER JOIN TACT A on A.NACTNUM = E.NACTNUM INNER JOIN TDCL D ON D.NACTNUM = A.NACTNUM WHERE E.NACTNUM = " + NACTNUM;
        string sql = @"select NDCLNUM, CDEVISTYPE, CTYPEMODELE, NDCLHT, DDCLDAT from TACT A INNER JOIN TDCL D ON D.NACTNUM = A.NACTNUM WHERE A.NACTNUM = " + NACTNUM;
        using (var cmd = new SqlCommand(sql, MozartDatabase.cnxMozart))
        {
          SqlDataReader dr = cmd.ExecuteReader();
          if (dr.Read())
          {
            numDCL = Convert.ToInt32(dr["NDCLNUM"]);
            typeDevis = dr["CDEVISTYPE"]?.ToString();
            typeModele = dr["CTYPEMODELE"]?.ToString();
            dPrice = dr["NDCLHT"]?.ToString();

            if (!string.IsNullOrEmpty(dPrice))
              montant = decimal.Parse(dPrice);
          }
        }

        if (numDCL == 0)
        {
          LogInfo($"GMAO: {txtNumTask.Text}, Aucun devis disponible sur cette action (Action: {NACTNUM})");
          return null;
        }

        // Génération du fichier PDF du devis
        string sNomReport = DetailstravauxUtils.RechercheModeleDevis(typeDevis, typeModele);
        var lFrmMainReport = new frmMainReport()
        {
          bLaunchByProcessStart = false,
          sTypeReport = sNomReport,
          sIdentifiant = numDCL.ToString(),
          InfosMail = "TCCL|NCCLCODE|000",
          sNomSociete = MozartParams.NomSociete,
          sLangue = "FR",
          sOption = "PDF",
          strType = "DC",
          numAction = NACTNUM
        };
        lFrmMainReport.ShowDialog();

        string sFichierDevis = MozartParams.CheminUtilisateurMozart + @"PDF\" + numDCL + ".pdf";

        LogInfo($"GMAO: {txtNumTask.Text}, \tGénération du devis Action: {NACTNUM}, Devis: {sFichierDevis}");

        if (File.Exists(sFichierDevis))
          return new FileInfo(sFichierDevis);
      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return null;
    }

    // -------------------------------------------------------------------------
    private void checkCommonParameters()
    {
      if (string.IsNullOrEmpty(txtNumTask.Text))
        throw new Exception("Invalid GMAO");

      if (string.IsNullOrEmpty(BASE_URL))
        throw new Exception("Invalid BASE_URL");

      if (string.IsNullOrEmpty(API_TOKEN))
        throw new Exception("Invalid API_TOKEN");

      if (string.IsNullOrEmpty(TENANT))
        throw new Exception("Invalid TENANT");
    }

    // -------------------------------------------------------------------------


    private void btnSendNote_Click(object sender, EventArgs e)
    {
      FrameNote.Visible = true;
    }

    private void cmdAnnule_Click(object sender, EventArgs e)
    {
      txtNote.Text = "";
      FrameNote.Visible = false;

    }

    // -------------------------------------------------------------------------
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      Frame3.Visible = false;
    }

    private void btnSendDoc_Click(object sender, EventArgs e)
    {
      InitListeBox();
      Frame3.Visible = true;
    }

    private void apiButton2_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();
        strObservation = "";

        foreach (string item in lstDoc.CheckedItems)
        {
          FileInfo fileInfo = new FileInfo(RechercheFile(item.ToString()));
          SendDocument(fileInfo);
          txtEmplusResponse.Text = $"{txtEmplusResponse.Text}\r\nEnvoi du document ({item}) dans EM+ ";
          strObservation = $"{strObservation}\r\nEnvoi du document ({item}) dans EM+ ";
        }

        Frame3.Visible = false;

      }
      catch (Exception ex)
      {
        txtEmplusResponse.Text = ex.Message;
      }

      Cursor.Current = Cursors.Default;
    }

    private void SendDocument(FileInfo fileInfo)
    {
      Cursor.Current = Cursors.WaitCursor;

      try
      {

        if (fileInfo == null)
          throw new Exception("Pas de document valide");

        byte[] fileContent = File.ReadAllBytes(fileInfo.FullName);

        if (!string.IsNullOrEmpty(txtNumTask.Text))
        {

          // envoi du document
          string result = "";
          if (!DiEmPlus.UploadDocument(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, fileInfo, fileContent, "application/pdf", ref result))
            throw new Exception($"{result}");

          if (result == "")
          {
            // envoi correct
            LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi d'un document, Action : {NACTNUM}, Document {fileInfo.FullName}{Environment.NewLine}{Environment.NewLine}");

            // Ajout d'une Note
            string Note = $"Envoi d'un document dans EM+";
            String resa = "";
            // Note d'information sur l'envoi de l'attachement
            if (!DiEmPlus.AddNote(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.AddNoteBody() { Note = Note }, ref resa))
              throw new Exception($"{resa}");

            // changement du statut
            if (!DiEmPlus.ChangeStatus(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.ChangeStatusBody() { StatusName = STATUT_ATTENTE_DEVIS, StatusChangeDateTimeUtc = DateTime.UtcNow.ToString("s") }, ref result))
              throw new Exception($"\r\n{result}");

          }
          else
          {
            // erreur de copie car fichier existe déjà (normalement impossible car on passe un nom de fichier unique)
            // on envoie pas la note
            txtEmplusResponse.Text = $"ERREUR - {result}";
          }

        }
      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
      }

      Cursor.Current = Cursors.Default;

    }

    private void InitListeBox()
    {

      try
      {

        lstDoc.Items.Clear();
        ListePJ.Clear();

        // initialisation      
        SqlDataReader mRs = ModuleData.ExecuteReader($"EXEC api_sp_ListeDocClientForPJ {MozartParams.NumAction}");

        while (mRs.Read())
        {
          List<string> elem = new List<string>();
          lstDoc.Items.Add(mRs["VIMAGE"]);
          elem.Add(mRs["VIMAGE"].ToString());
          elem.Add(mRs["VFILE"].ToString());
          ListePJ.Add(elem);
        }

        mRs.Close();
      }

      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private string RechercheFile(string Nom)
    {
      // Cette fonction permet de rechercher le fichiher avec son nom
      string sFile = "";
      foreach (List<string> l in ListePJ)
      {
        if (l[0] == Nom)
          sFile = l[1];
      }

      return sFile;
    }

		private void btnChangeStatut2_Click(object sender, EventArgs e)
		{
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        checkCommonParameters();

        // changement du statut
        string result = "";
        if (!DiEmPlus.ChangeStatus(API_TOKEN, API_SECRET, BASE_URL, txtNumTask.Text, TENANT, new DiEmPlus.ChangeStatusBody() { StatusName = STATUT_ATTENTE_PDV_DEVIS, StatusChangeDateTimeUtc = DateTime.UtcNow.ToString("s") }, ref result))
          throw new Exception($"'\r\n{result}");

        LogInfo($"GMAO: {txtNumTask.Text},\tChangement de statut de l'action : : {STATUT_ATTENTE_PDV_DEVIS},  Action : {NACTNUM}{Environment.NewLine}{Environment.NewLine}");
        txtEmplusResponse.Text = "OK - Changement de statut";
        strObservation = $"{strObservation}\r\nChangement de statut ({STATUT_ATTENTE_PDV_DEVIS}) dans EM+ ";

      }
      catch (Exception ex)
      {
        LogInfo($"GMAO: {txtNumTask.Text},\tError: {ex.Message}{Environment.NewLine}{Environment.NewLine}{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}");
        txtEmplusResponse.Text = ex.Message;
        //MessageBox.Show($"{ex.Message}\r\n\r\n{MozartCS.Properties.Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
        //              MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      Cursor.Current = Cursors.Default;

    }
  }
}
