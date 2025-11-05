using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestWebPer : Form
  {
    public string msLibNomSoc;
    public int miNumPersonne;
    public string msTypePer;

    DataTable dtPri = new DataTable();
    DataTable dtSec = new DataTable();
    DataTable dtRS = new DataTable();

    private int miLogin;
    private long iNumSTF;


    public frmGestWebPer()
    {
      InitializeComponent();
    }

    private void frmGestWebPer_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        lblTitre.Text = lblTitre.Text + " - " + (MozartParams.NomSocieteTemp == "GROUPE" ? msLibNomSoc : MozartParams.NomSocieteTemp);

        //  Cas du technicien
        if (msTypePer == "T")
        {
          ModuleData.LoadData(dtPri, $"select VPERNOM, VPERPRE, NPERNUM from TPER where NPERNUM = {miNumPersonne}");
          ModuleData.LoadData(dtSec, $"select VUTILOG, VUTIPWD, CUTICAT, NUTINUM, NACCNUM  from TUTI where CUTICAT = 'T' and NUTINUM = {miNumPersonne}");

          panel1.Visible = false;
          Label6.Visible = false;
          lblIdentifiant.Visible = false;
                    lblIdentifiant.Tag = (dtSec.Rows.Count > 0 ? Utils.BlankIfNull(dtSec.Rows[0]["NACCNUM"]) : "");
                    LblNINTNUM.Visible = false;
          LblNINTNUM.Text = "";
                    BtnDelete.Visible = true;
          if (dtPri.Rows.Count > 0)
          {
            Label10.Text = Utils.BlankIfNull(dtPri.Rows[0]["VPERNOM"]);
            Label11.Text = Utils.BlankIfNull(dtPri.Rows[0]["VPERPRE"]);
          }
        }

        // Cas du technicien soustraitant
        else if (msTypePer == "S")
        {
          ModuleData.LoadData(dtPri, $"select VSTTNOM, VSTTPRENOM, NSTTNUM, ISNULL(NINTNUM, 0) AS NINTNUM, NSTFNUM from TSTTECH where NSTTNUM ={miNumPersonne}");
          ModuleData.LoadData(dtSec, $"select VUTILOG, VUTIPWD, CUTICAT, NUSITNUM, NACCNUM  from TUTI where CUTICAT = 'S' and NUTINUM = {miNumPersonne}");

          panel1.Visible = false;
          Label6.Visible = true;
          lblIdentifiant.Visible = true;
          LblNINTNUM.Visible = true;
                    BtnDelete.Visible = false;
          if (dtPri.Rows.Count > 0)
          {
            iNumSTF = (int)dtPri.Rows[0]["NSTFNUM"];
            LblNINTNUM.Text = dtPri.Rows[0]["NINTNUM"].ToString();
            Label10.Text = Utils.BlankIfNull(dtPri.Rows[0]["VSTTNOM"]);
            Label11.Text = Utils.BlankIfNull(dtPri.Rows[0]["VSTTPRENOM"]);
            if (dtSec.Rows.Count > 0)
            {
              lblIdentifiant.Text = $"{lblIdentifiant.Text} {dtSec.Rows[0]["NACCNUM"]}";
                            
            }
          }
        }

        //  Cas du client
        else if (msTypePer == "C")
        {
          ModuleData.LoadData(dtPri, $"select VCLINOM, VCLIAD1, NCLINUM from TCLI where NCLINUM ={miNumPersonne}");
          Label6.Visible = false;
          LblNINTNUM.Visible = false;
          lblIdentifiant.Visible = false;
          LblNINTNUM.Text = "";
                    BtnDelete.Visible = false;
                    if (dtPri.Rows.Count > 0)
          {
            Label10.Text = Utils.BlankIfNull(dtPri.Rows[0]["VCLINOM"]);
            Label11.Text = Utils.BlankIfNull(dtPri.Rows[0]["VCLIAD1"]);
          }
        }

        txtUtilisateur.Text = dtPri.Rows[0][0].ToString();
        Label12.Text = miNumPersonne.ToString();

        //  Changement de texte du cartouche
        switch (msTypePer)
        {
          case "T": Frame1.Text = "Personne"; break;
          case "C": Frame1.Text = "Client"; break;
          case "S": Frame1.Text = "Sous traitant"; break;
        }

        //  liste des utilisateurs client
        if (msTypePer == "C")
        {
          // ouverture du recordset sur la liste des utilisateurs internet
          loadDTRS();
          InitApigrid();
          panel1.Visible = true;
          Label4.Visible = true;
          cboDroit.Visible = true;
          Label5.Visible = true;
          txtDbl.Visible = true;
          Frame2.Visible = false;
          cmdValider.Visible = false;
          Command1.Visible = true;
          Command2.Visible = true;
          CmdSendAccesQCM.Visible = false;
        }
        else
        {
          if (dtSec.Rows.Count == 0)
          {
            txt_pwd.Text = "";
            miLogin = 0;
          }
          else
          {
            txt_pwd.Text = dtSec.Rows[0]["VUTIPWD"] == null ? "" : dtSec.Rows[0]["VUTIPWD"].ToString();
            miLogin = (int)dtSec.Rows[0]["NACCNUM"];
            lblIdentifiant.Visible = true;
            lblIdentifiant.Text = $"{lblIdentifiant.Text} {dtSec.Rows[0]["NACCNUM"]}";
          }
        }
        cmdAcces.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void loadDTRS()
    {
      ModuleData.LoadData(dtRS, $"api_sp_ListeLoginWeb {miNumPersonne}");
      ApiGrid.GridControl.DataSource = dtRS;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdAjouter_Click(object sender, System.EventArgs e)
    {
      //  passage du numéro de client
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAjouter.Tag.ToString(), "Entrée", $"NCLINUM: {miNumPersonne}");

      new frmGestDroitWeb()
      {
        miNumClient = miNumPersonne,
        mstrStatut = "C",
        miLogin = 0,
      }.ShowDialog();

      // rafraichissement liste
      loadDTRS();

      MessageBox.Show(Resources.msg_pasOublierCreerMenuWeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }


    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdFermer.Tag.ToString(), "Sortie");
      Cursor = Cursors.Default;
      Dispose();
    }


    private void cmdInit_Click(object sender, System.EventArgs e)
    {
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdInit.Tag.ToString(), "Modification", $"NCLINUM: {miNumPersonne}");
      InitialiserLesAcces();
    }

    private void cmdAcces_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdAcces.Tag.ToString(), "Entrée", $"NPERNUM: {miNumPersonne}, MODE: {msTypePer}");

      if (msTypePer == "S")
      {
        new frmGestionMenuWebSTT()
        {
          miNumClient = miNumPersonne,
          mstrType = msTypePer,
        }.ShowDialog();
      }
      else
      {
        new frmGestionMenuWeb()
        {
          miNumClient = miNumPersonne,
          mstrType = msTypePer,
        }.ShowDialog();
      }
      Cursor = Cursors.Default;
    }

    private void CmdDetail_Click(object sender, System.EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row) return;

      MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdDetail.Tag.ToString(), "Entrée", $"NCLINUM: {miNumPersonne}, NACCNUM: {row["NACCNUM"]}");

      new frmGestDroitWeb()
      {
        miNumClient = miNumPersonne,
        mstrStatut = "M",
        miLogin = (int)row["NACCNUM"],
      }.ShowDialog();

      //  rafraichissement liste
      loadDTRS();
    }

    private void Command1_Click(object sender, System.EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row) return; ;

      if (MessageBox.Show($"{Resources.msg_applicationProfilAccesDe} {row["VUTILOG"]}", Program.AppTitle,
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        // suppression des droits de la personne VERS
        ModuleData.CnxExecute($"delete from TDROITWEB WHERE VUTILOG='{row["VUTILOG"]}' AND CUTICAT='{row["CUTICAT"]}' AND NCLINUM={row["NUTINUM"]}");

        // insertion dans la table des droits avec copie du profil type saisie sur le client APITECH
        string sSQL = $"EXEC [api_sp_GestWebPer_CopyProfil] 0, '{row["VUTILOG"].ToString().Replace("'", "''")}', {miNumPersonne}, '{MozartParams.NomSociete.Replace("'", "''")}'";
        ModuleData.CnxExecute(sSQL);
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", Command1.Tag.ToString(), "Modification", $"NCLINUM: {miNumPersonne}");
      }
    }

    private void Command2_Click(object sender, System.EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show($"Vous allez appliquer ce profil à l'accès de : {row["VUTILOG"]}", Program.AppTitle,
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        // suppression des droits de la personne VERS
        ModuleData.CnxExecute($"delete from TDROITWEB WHERE VUTILOG= '{row["VUTILOG"]}' AND CUTICAT='{row["CUTICAT"]}' AND NCLINUM={row["NUTINUM"]}");

        // insertion dans la table des droits avec copie du profil type saisie sur le client APITECH
        string sSQL = $"EXEC [api_sp_GestWebPer_CopyProfil] 0, '{row["VUTILOG"].ToString().Replace("'", "''")}', {miNumPersonne}, '{MozartParams.NomSociete.Replace("'", "''")}'";

        ModuleData.CnxExecute(sSQL);
        MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", Command2.Tag.ToString(), "Modification", $"NCLINUM: {miNumPersonne}");
      }
    }

    private void cmdSupprimer_Click(object sender, System.EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row) return;

      try
      {
        if (MessageBox.Show(Resources.msg_supAcces, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // suppression dans TUTI et TACCESWEB avec jointure
          ModuleData.CnxExecute($"delete from TACCESWEB WHERE NACCNUM= {row["NACCNUM"]}");
          ModuleData.CnxExecute($"delete from TDROITWEB WHERE VUTILOG= '{row["VUTILOG"]}' AND CUTICAT='{row["CUTICAT"]}' AND NCLINUM={row["NUTINUM"]}");
          ModuleData.CnxExecute($"delete from DroitContratClientWeb WHERE NACCNUM= {row["NACCNUM"]}");
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdSupprimer.Tag.ToString(), "Suppression", $"NCLINUM: {miNumPersonne}, NACCNUM: {row["NACCNUM"]}");
        }

        //  rafraichissement liste
        loadDTRS();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      try
      {
        if (msTypePer == "T" || msTypePer == "S")
        {
          //MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdValider.Tag.ToString(), "Modification", $"NCLINUM: {miNumPersonne}");
          EnregTech();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregTech()
    {
      try
      {
        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationAccesWeb", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iLogin"].Value = miLogin;
          cmd.Parameters["@iClient"].Value = miNumPersonne;
          cmd.Parameters["@vNom"].Value = Label10.Text;
          cmd.Parameters["@vPwd"].Value = txt_pwd.Text;
          cmd.Parameters["@cCat"].Value = msTypePer;
          cmd.Parameters["@cDroit"].Value = "OUI";
          cmd.Parameters["@iValidation"].Value = 99999;
          cmd.Parameters["@cTyp"].Value = "T"; //double validation plus utilisé
          cmd.Parameters["@bCrt"].Value = 0;
          cmd.Parameters["@bLogin"].Value = 0;

          cmd.ExecuteNonQuery();

          // récupération du numéro créé
          miLogin = (int)cmd.Parameters[0].Value;
        }

                lblIdentifiant.Text = $"{lblIdentifiant.Text} {miLogin}";

                // on supprime toutes les infos dans la table TUTI et on réinsert
                ModuleData.CnxExecute("delete from TUTI where NACCNUM = " + miLogin);

        // execution de la requête d'insert
        string sSQL = $"exec api_sp_CreationLigneAccesweb  '{Label10.Text.Replace($"'", $"''")}','{txt_pwd.Text.Replace($"'", $"''")}','{msTypePer}',{miNumPersonne},";

        string temp = "";
        if (msTypePer == "T")
          temp = "Null";
        else
          temp = iNumSTF.ToString();

        sSQL += $"{temp}, 'OUI', 99999, 'T', {miLogin}";

        ModuleData.CnxExecute(sSQL);

        // enregistrement du password dans la table de sécurité du site web STT (base LOGIN)
        if (msTypePer == "S")
        {
          EnregistrerPasswordDansLOGIN(txt_pwd.Text);
        }
        else if (msTypePer == "T")
        {
          EnregistrerPasswordDansLOGIN(txt_pwd.Text, 1);

                    //update objectentraid dans taccesweb
                    string sMailPro = MozartDatabase.ExecuteScalarString($"EXEC [api_sp_Personnel_GetMailpro] {miNumPersonne}", MozartDatabase.cnxMozart);
                    if(sMailPro != "" & miNumPersonne > 0) UpdateEntraObjectId(sMailPro, miNumPersonne);

                }
            }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

        private async void UpdateEntraObjectId(string UserMailPro, int npernum)
        {
            try
            {
                if (UserMailPro != "")
                {
                    string baseUrl = $"https://{MozartParams.urlApiMozaris}/EntraId/GetPrincipalId";

                    var parameters = new Dictionary<string, string>
                            {
                                { "userName", UserMailPro}
                            };

                    string response = await CApiMozarisEntraID.GetFromApiWithBasicAuthAndParams(baseUrl, parameters, MozartParams.userNameApiMozaris, MozartParams.pwdApiMozaris);

                    if (response != "")
                    {
                        // If the response is a valid boolean, set the checkbox accordingly
                        //MessageBox.Show("update objectId : " + response, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand sqlCommand = new SqlCommand("[api_sp_Personnel_UpdateAccessApplications]", MozartDatabase.cnxMozart)
                        {
                            CommandType = CommandType.StoredProcedure,
                            Parameters =
                            {
                                new SqlParameter("@P_NPERNUM", npernum),
                                new SqlParameter("@P_ENTRA_ID_PRINCIPAL_ID", response)
                            }
                        };
                        sqlCommand.ExecuteNonQuery();

                    }
                    else
                    {
                        // If the response is not a valid boolean, handle the error accordingly
                        //MessageBox.Show("Erreur sur l'accès EMASSET : " + response, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void InitApigrid()
    {
      try
      {
        ApiGrid.AddColumn(Resources.col_utilisateur, "VUTILOG", 2200);
        ApiGrid.AddColumn(Resources.col_Fonction, "VFONCTYP", 2000);
        ApiGrid.AddColumn(Resources.col_password, "VUTIPWD", 2200);
        ApiGrid.AddColumn(Resources.col_droitCrea, "VUTIDROIT", 1000);
        ApiGrid.AddColumn(Resources.col_montantValidation, "NUTIMTVAL", 1000);
        ApiGrid.AddColumn("NACCNUM", "NACCNUM", 0);
        ApiGrid.AddColumn("CUTICAT", "CUTICAT", 0);
        ApiGrid.AddColumn("NUTINUM", "NUTINUM", 0);

        if (msTypePer == "C")
          ApiGrid.AddColumn(Resources.col_Site, "SITE", 1500);
        ApiGrid.FilterBar = true;

        ApiGrid.InitColumnList();
        ApiGrid.GridControl.DataSource = dtRS;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerPasswordDansLOGIN(string pwd, int itype = 0)
    {
      try
      {

        // Generate a 128-bit salt using a sequence of
        // cryptographically strong random bytes.
        const int SaltSize = 128 / 8; // 128 bits
        const int Pbkdf2SubkeyLength = 256 / 8; // 256 bits
        byte[] salt = new byte[SaltSize];
        RNGCryptoServiceProvider png = new RNGCryptoServiceProvider();
        png.GetNonZeroBytes(salt); // divide by 8 to convert bits to bytes


        Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(pwd, salt, 1000);
        byte[] lRet = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
        var outputBytes = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
        outputBytes[0] = 0x00; // format marker
        Buffer.BlockCopy(salt, 0, outputBytes, 1, SaltSize);
        Buffer.BlockCopy(lRet, 0, outputBytes, 1 + SaltSize, Pbkdf2SubkeyLength);

        string lRetStr = Convert.ToBase64String(outputBytes);

        switch (itype)
        {
          case 0:
            SqlCommand cmd = new SqlCommand("[api_sp_creationLoginSTT]", MozartDatabase.cnxMozart);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

            //  liste des paramètres
            cmd.Parameters["@NumLogin"].Value = miLogin;
            cmd.Parameters["@nsttnum"].Value = miNumPersonne;
            cmd.Parameters["@vPwd"].Value = lRetStr;

            cmd.ExecuteNonQuery();
            break;
          case 1:
            SqlCommand cmd_per = new SqlCommand("[api_sp_creationLoginPersonnel]", MozartDatabase.cnxMozart);
            cmd_per.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd_per);    // liste des paramètres

            //  liste des paramètres
            cmd_per.Parameters["@NumLogin"].Value = miLogin;
            cmd_per.Parameters["@npernum"].Value = miNumPersonne;
            cmd_per.Parameters["@vPwd"].Value = lRetStr;

            cmd_per.ExecuteNonQuery();
            break;

        };



      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserLesAcces()
    {
      try
      {
        ModuleData.CnxExecute("api_sp_InitialiserAccesWeb " + miNumPersonne);
        loadDTRS();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdMail_Click(object sender, System.EventArgs e)
    {
      string strMail = "";
      string sLangue = "FR";  // Par défaut;
      string sMsg = "";
      DataRow row = null;
      if (msTypePer == "C")
      {
        row = ApiGrid.GetFocusedDataRow();
        if (null == row) return;
      }
      try
      {
        string sql = "";
        // technicien
        if (msTypePer == "T")
        {
          sql = $"SELECT VPERMAI 'VCCLMAIL', VPERPAYS 'PAYS' FROM TPER WHERE NPERNUM = {miNumPersonne}";
        }
        // client
        else if (msTypePer == "C")
        {
          if (row["CUTITYPE"].ToString() == "R")
            sql = $"SELECT TCSIT.VCSITMAI AS VCCLMAIL, ISNULL(VSITPAYS,'FRANCE') 'PAYS' FROM TSIT, TCSIT WHERE TCSIT.NSITNUM = TSIT.NSITNUM AND TCSIT.NTYPCSITNUM = 1 AND TSIT.NSITNUM = {row["NumSite"]}";
          else
            sql = $"SELECT VCCLMAIL, ISNULL(VCCLPAYS, 'FRANCE') 'PAYS' FROM TCCL WHERE VCCLNOM = '{row["VUTILOG"]}' AND NCLINUM = {miNumPersonne}";
        }
        //sous-traiatnt
        else if (msTypePer == "S")
        {
          sql = $"select VSTTMAIL 'VCCLMAIL', ISNULL(tstf.vstfpays,'FRANCE') 'PAYS' from tsttech inner join tstf on tstf.nstfnum = tsttech.nstfnum WHERE NSTTNUM = {miNumPersonne}";
        }
        if ("" == sql) return;
        using (SqlDataReader reader = ModuleData.ExecuteReader(sql))
        {
          if (reader.Read())
          {
            strMail = Utils.BlankIfNull(reader["VCCLMAIL"]);
            sLangue = ModuleMain.CodePays(Utils.BlankIfNull(reader["PAYS"])).Substring(0, 2);
          }
        }

        strMail = Interaction.InputBox(Resources.msg_saisirAdresseMailDest, Program.AppTitle, strMail);

        if (string.IsNullOrEmpty(strMail))
          return;

        if (strMail.Contains(" ") || !strMail.Contains("@") || !strMail.Contains("."))
        {
          MessageBox.Show($"{Resources.msg_adresseCourrielInvalide}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          switch (msTypePer)
          {
            case "T":
              sMsg = ModuleMain.RechercheTrad("ACCES_WEB_TECH", sLangue);
              sMsg = sMsg.Replace("#VUTILOG#", txtUtilisateur.Text);
              sMsg = sMsg.Replace("#VUTIPWD#", txt_pwd.Text);
              break;

            case "C":
              sMsg = ModuleMain.RechercheTrad("ACCES_WEB_CLIENT", sLangue);
              sMsg = sMsg.Replace("#VUTILOG#", row["VUTILOG"].ToString());
              sMsg = sMsg.Replace("#VUTIPWD#", row["VUTIPWD"].ToString());
              break;

            case "S":
              sMsg = ModuleMain.RechercheTrad("ACCES_WEB_STTECH", sLangue);
              sMsg = sMsg.Replace("#NCLINUM#", miLogin.ToString());
              sMsg = sMsg.Replace("#VUTIPWD#", txt_pwd.Text);
              break;
          }

          string sSujet = ModuleMain.RechercheTrad("SUJET_ACCES_WEB", sLangue);
          sMsg = sMsg.Replace("#NCLINUM#", miNumPersonne.ToString());

          // mail par le serveur
          string sSQL = $"EXEC msdb..sp_send_dbmail " +
                        $"@profile_name = 'Web{MozartParams.NomSociete}', " +
                        $"@recipients   = '{strMail}', " +
                        $"@body         = '{sMsg}', " +
                        $"@subject      = '{sSujet} {MozartParams.NomSociete}' " +
                        $", @blind_copy_recipients       ='info@emalec.com', " +
                        $"@body_format  = 'HTML' ";
          ModuleData.ExecuteNonQuery(sSQL);

          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdMail.Tag.ToString(), "MAIL", $"NCLINUM: {miNumPersonne}", "TYPE PERSONNE: {sTypePer}");
          MessageBox.Show($"Courriel d'accès au Web {MozartParams.NomSociete}{Environment.NewLine} envoyé à l'adresse : {strMail}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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

    private void CmdSendAccesQCM_Click(object sender, System.EventArgs e)
    {
      if (msTypePer == "C" || msTypePer == "S")
        return;
      string strMail = "";
      string sLangue = "FR";
      string sMsg;

      try
      {
        // if (msTypePer == "T") autres cas return
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT COALESCE(VPERMAILPRO, VPERMAI) 'VCCLMAIL', VPERPAYS 'PAYS' FROM TPER WHERE NPERNUM = {miNumPersonne}"))
        {
          if (reader.Read())
          {
            strMail = Utils.BlankIfNull(reader["VCCLMAIL"]);
            sLangue = ModuleMain.CodePays(Utils.BlankIfNull(reader["PAYS"])).Substring(0, 2);
          }
        }
        if (string.IsNullOrEmpty(strMail))
          return;

        if (strMail.Contains(" ") || !strMail.Contains("@") || !strMail.Contains("."))
        {
          MessageBox.Show($"{Resources.msg_adresseCourrielInvalide}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          // Always sTypePer== "T"
          sMsg = ModuleMain.RechercheTrad("ACCES_QCM_PER_V3", sLangue);
          sMsg = sMsg.Replace("#VUTILOG#", lblIdentifiant.Tag.ToString());
          sMsg = sMsg.Replace("#VUTIPWD#", txt_pwd.Text);
          sMsg = sMsg.Replace("#VSOCIETENOM#", MozartLib.MozartParams.GetNomSociete());

                    sMsg = sMsg.Replace("'", "''");

          string sSujet = ModuleMain.RechercheTrad("SUJET_QCM_PER_V3", sLangue);
          //sMsg = sMsg.Replace("#NCLINUM#", miNumPersonne.ToString());

          // mail par le serveur
          string sSQL = $"EXEC msdb..sp_send_dbmail " +
                        $"@profile_name = 'Web{MozartParams.NomSociete}', " +
                        $"@recipients   = '{strMail}', " +
                        $"@body         = '{sMsg}', " +
                        $"@subject      = '{sSujet} {MozartParams.NomSociete}'" +
                        $", @blind_copy_recipients       ='info@emalec.com', " +
                        $"@body_format  = 'HTML'";
          ModuleData.ExecuteNonQuery(sSQL);

          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", CmdSendAccesQCM.Tag.ToString(), "MAIL", $"NCLINUM: {miNumPersonne}", "TYPE PERSONNE: {sTypePer}");
          MessageBox.Show($"Courriel d'accès au Web My emalec{Environment.NewLine} envoyé à l'adresse : {strMail}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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

    private string GetMailAndLanguage(DataTable dtMail, ref string sLangue)
    {
      string mail = "";
      if (dtMail.Rows.Count > 0)
      {
        mail = dtMail.Rows[0]["VCCLMAIL"].ToString();
        sLangue = ModuleMain.CodePays(dtMail.Rows[0]["PAYS"].ToString()).Substring(0, 2);
      }
      return Interaction.InputBox(Resources.msg_saisirAdresseMailDest, Program.AppTitle, mail);
    }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Voulez-vous vraiment supprimer cet accès web ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ModuleData.ExecuteNonQuery($"EXEC [api_sp_job_DeleteAccesWebPersonnel] {miNumPersonne}");

                txt_pwd.Text = "";
                lblIdentifiant.Text = "Nouvel Identifiant Web :";
                miLogin = 0;


            }
        }
    }
}

