using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
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
  public partial class frmSaisieOG : Form
  {

    // feuille ouverte en création ou modification
    public string mstrStatut;
    public int miNumOG;
    public int miST;
    public int miAction;

    public frmSaisieOG() { InitializeComponent(); }

    private void frmSaisieOG_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //    On Error GoTo handler
    //    ' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //    ' Dim sSql As String
    //    
    //      InitBoutons Me, frmMenu
    //      
    //      InitialiserFeuille
    //      
    //    Exit Sub
    //handler:
    //      ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitialiserFeuille()
    {
      // recherche des info du contrat
      using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_RetourInfoOG {miNumOG}, {miAction}"))
      {
        if (reader.Read())
        {
          txtClientNom.Text = Utils.BlankIfNull(reader["VCLINOM"]);
          txtClientSiteNum.Text = Utils.BlankIfNull(reader["NSITNUE"]);
          txtClientSite.Text = Utils.BlankIfNull(reader["VSITNOM"]);
          txtClientResp.Text = Utils.BlankIfNull(reader["VSITRES"]);
          txtClientTel.Text = Utils.BlankIfNull(reader["VSITTEL"]);

          txtSTTNom.Text = Utils.BlankIfNull(reader["VSTFNOM"]);
          txtSTTContact.Text = Utils.BlankIfNull(reader["VINTNOM"]);
          txtSTTMail.Text = Utils.BlankIfNull(reader["VINTMAIL"]);
          txtSTTTel.Text = Utils.BlankIfNull(reader["VINTTEL"]);
          txtSTTFax.Text = Utils.BlankIfNull(reader["VINTFAX"]);
          txtSTTPor.Text = Utils.BlankIfNull(reader["VINTPOR"]);

          // numero du contact
          txtSTTContact.Tag = reader["NINTNUM"];
          // date envoi du mail
          txtDateEnvoi.Text = Utils.DateBlankIfNull(reader["DOGENVOI"]);

          // si on est en modification ou en création
          if (Utils.ZeroIfNull(reader["NOGNUM"]) == 0)
          {
            mstrStatut = "C";
            miNumOG = 0;
            txtLettre.Text = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                            $"{Resources.msg_avez_realise_installation_site_ci_dessous}{Environment.NewLine}" +
                            $"{Resources.msg_installation_sous_garantie}{Environment.NewLine}" +
                            $"{Resources.msg_probleme_site_garantie}{Environment.NewLine}" +
                            $"{MozartParams.NomSociete.ToUpper()} {Resources.msg_est_gestionnaire_garantie_client} {txtClientNom.Text}{Environment.NewLine}{Environment.NewLine}" +
                            $"{Resources.msg_demande_intervenir_garantie_site} :{Environment.NewLine}{Environment.NewLine}" +
                            $"- {MZCtrlResources.col_Client} : {txtClientNom.Text}{Environment.NewLine}" +
                            $"- {Resources.col_Site} : {txtClientSite.Text}{Environment.NewLine}" +
                            $"- {Resources.msg_action_concernee} :{Environment.NewLine}{reader["VACTDES"]}{Environment.NewLine}{Environment.NewLine}" +
                            $"{Resources.msg_intervention_urgente_demande_dinformer} {MozartParams.NomSociete.ToUpper()} {Resources.msg_date_passage} {RechercheNumTelByPays(Utils.BlankIfNull(reader["VSTFPAYS"]))}.{Environment.NewLine}" +
                            $"{Resources.msg_realisation_prestation_informer} {MozartParams.NomSociete.ToUpper()} {Resources.msg_constat_prestation_realisee}.";
          }
          else
          {
            mstrStatut = "M";
            miNumOG = (int)Utils.ZeroIfNull(reader["NOGNUM"]);
            txtLettre.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(reader["VOGCORPS"]), "RTF");
          }
        }
      }
    }
    //Private Sub InitialiserFeuille()
    //
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String
    //Dim otext As TextBox
    //
    //On Error GoTo handler
    //
    //  ' recherche des info du contrat
    //  Set rsC = New ADODB.Recordset
    //  rsC.Open "api_sp_RetourInfoOG " & miNumOG & "," & miAction, cnx
    //  
    //  'les infos de la feuille
    //  For Each otext In Me.txtFields
    //    Set otext.DataSource = rsC
    //  Next
    //
    //   ' numero du contact
    //  txtFields(4).Tag = rsC("NINTNUM")
    //   
    //    'date envoi du mail
    //    txtFields(6).Text = BlankIfNull(rsC("DOGENVOI"))
    //  
    //  ' si on est en modification ou en création
    //  If rsC("NOGNUM") = 0 Then
    //    Me.mstrStatut = "C"
    //    Me.miNumOG = 0
    //    Me.txtLettre = "§Bonjour,§" & vbCrLf & vbCrLf & _
    //                    "§Vous avez réalisez une installation sur le site cité ci-dessous.§" & vbCrLf & _
    //                    "§Cette installation est actuellement sous garantie.§" & vbCrLf & _
    //                    "§Nous rencontrons un problème sur ce site, relevant de votre garantie.§" & vbCrLf & _
    //                    UCase(gstrNomSociete) & " §est gestionnaire des garanties pour votre client final§ " & txtFields(0).Text & vbCrLf & vbCrLf & _
    //                    "§Dans ce cadre, nous vous demandons d’intervenir sous garantie sur le site suivant§ :" & vbCrLf & vbCrLf & _
    //                    "- §Client§ : " & txtFields(0).Text & vbCrLf & _
    //                    "- §Site§ : " & txtFields(1).Text & vbCrLf & _
    //                    "- §Action concernée§ :" & vbCrLf & rsC("VACTDES") & vbCrLf & vbCrLf & _
    //                    "§Votre intervention est urgente, nous vous demandons d'informer§ " & UCase(gstrNomSociete) & " §de la date de votre passage au§ " & RechercheNumTelByPays(rsC("VSTFPAYS")) & "." & vbCrLf & _
    //                    "§Dès réalisation de la prestation, informer§ " & UCase(gstrNomSociete) & " §de votre constat et de la prestation réalisée§."
    //           
    //  Else
    //    Me.mstrStatut = "M"
    //    Me.miNumOG = rsC("NOGNUM")
    //    Me.txtLettre = ReplaceCharFromBD(BlankIfNull(rsC("VOGCORPS")), "RTF")
    //  End If
    //  
    //   miNumClient = rsC("NCLINUM")
    //
    //  rsC.Close
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " OuvertureEnModification dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumOG == 0)
        {
          MessageBox.Show(Resources.msg_impression_impossible_enregistrer_intervention, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        string[,] TdbGlobal = { { "Copie", "Original" } };
        new frmBrowser().ImprimerFichier($"{MozartParams.CheminModeles}{Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST.ToString())}TOG.rtf",
                                         @"TOGOut.rtf",
                                         TdbGlobal,
                                         $"exec api_sp_impOG {miNumOG}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdImprimer_Click()
    //
    //' UPGRADE_INFO (#0501): The 'response' member isn't used anywhere in current application.
    //' Dim response As String
    //Dim sModele As String
    //' UPGRADE_INFO (#0501): The 'nbEnreg' member isn't used anywhere in current application.
    //' Dim nbEnreg As Long
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //On Error Resume Next
    //        
    //    TdbGlobal(0, 0) = "copie"
    //    TdbGlobal(0, 1) = "Original"
    //
    //     
    //  If miNumOG = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer l'ordre d'intervention en garantie§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //    sModele = "TOG.rtf"
    //            
    //    'ImprimerFichier gstrCheminModeles & CodePays(GetPays("TSTF", "VSTFPAYS", "NSTFNUM", miST)) & sModele,
    //    ImprimerFichier gstrCheminModeles & GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST) & sModele, _
    //                         "\TOGOut.rtf", _
    //                         TdbGlobal(), _
    //                         "exec api_sp_impOG " & miNumOG
    //  
    //           
    //  Screen.MousePointer = vbDefault
    //    
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Imprimer dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumOG == 0)
        {
          MessageBox.Show(Resources.msg_visu_impossible_enregistrer_intervention, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (txtSTTMail.Text == "")
        {
          MessageBox.Show(Resources.msg_envoi_impossible_mail_stt_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        string[,] TdbGlobal = { { "Copie", "Original" } };

        frmBrowser frm = new frmBrowser();
        frm.mstrType = "OG" + miNumOG;
        frm.msInfosMail = "TINT|NINTNUM|" + txtSTTContact.Text;
        frm.Preview_Print($"{MozartParams.CheminModeles}{Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST.ToString())}TOG.rtf",
                          $@"{miNumOG}TOGOut.rtf",
                          TdbGlobal,
                          $"exec api_sp_impOG {miNumOG}",
                          " (Visualisation OG)", "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CmdVisu_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim sModele As String
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String
    //' UPGRADE_INFO (#0501): The 'RsAux' member isn't used anywhere in current application.
    //' Dim RsAux As ADODB.Recordset
    //
    //  On Error Resume Next
    //  
    //    If miNumOG = 0 Then
    //      MsgBox "§Visulisation impossible, il faut enregistrer l'ordre d'intervention en garantie§", vbInformation
    //      Exit Sub
    //    End If
    //    
    //    If txtFields(7).Text = "" Then
    //        MsgBox "§Envoi impossible, il faut obligatoirement une adresse mail pour le sous traitant!§", vbInformation
    //        Exit Sub
    //    End If
    //    
    //
    //    TdbGlobal(0, 0) = "copie"
    //    TdbGlobal(0, 1) = "Original"
    //    
    //    sModele = "TOG.rtf"
    //   
    //    frmBrowser.mstrType = "OG" & miNumOG
    //    frmBrowser.InfosMail = "TINT|NINTNUM|" & txtFields(4).Tag
    //    'frmBrowser.Preview_Print gstrCheminModeles & CodePays(GetPays("TSTF", "VSTFPAYS", "NSTFNUM", miST)) & sModele,
    //    frmBrowser.Preview_Print gstrCheminModeles & GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST) & sModele, _
    //                             "\" & miNumOG & "TOGOut.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impOG " & miNumOG, _
    //                           " (Visualisation OG)", _
    //                           "PREVIEW"
    //
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private string RechercheNumTelByPays(string NomPays)
    {
      string code = ModuleMain.CodePays(NomPays);
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT CHAINE{Strings.Left(code, code.Length - 1)} AS NUMTEL FROM COMMUN.dbo.TLGMOZART WHERE FICHIER = '{MozartParams.NomSociete}' AND CHAINE = '$SteWoTel'"))
      {
        if (reader.Read())
          return Utils.BlankIfNull(reader["NUMTEL"]);
      }
      return "";
    }
    //Private Function RechercheNumTelByPays(ByVal sNomPays As String) As String
    //
    //    Dim adoNum As New ADODB.Recordset
    //    
    //    Dim sReq As String
    //    
    //    sReq = "SELECT CHAINE" & Left(CodePays(sNomPays), Len(CodePays(sNomPays)) - 1) & " AS NUMTEL FROM COMMUN.dbo.TLGMOZART WHERE FICHIER = '" & gstrNomSociete & "' AND CHAINE = '$SteWoTel'"
    //    
    //    adoNum.Open sReq, cnx, adOpenStatic, adLockReadOnly
    //    
    //    If adoNum.RecordCount > 0 Then
    //        RechercheNumTelByPays = adoNum("NUMTEL")
    //    Else
    //        RechercheNumTelByPays = ""
    //    End If
    //    
    //    adoNum.Close
    //    Set adoNum = Nothing
    //
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    private void EnregistrerOG()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_creationOG", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          // liste des paramètres
          cmd.Parameters["@iNumOG"].Value = miNumOG;
          cmd.Parameters["@iST"].Value = txtSTTContact.Tag;
          cmd.Parameters["@corps"].Value = txtLettre.Text;
          cmd.Parameters["@iAction"].Value = miAction;


          // exécuter la commande.
          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          miNumOG = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub EnregistrerOG()
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //On Error GoTo handler
    //  
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_creationOG"
    //  ado_cmd.CommandType = adCmdStoredProc
    //   
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //   
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iNumOG").value = miNumOG
    //  ado_cmd.Parameters("@iST").value = txtFields(4).Tag
    //  ado_cmd.Parameters("@corps").value = txtLettre 'ReplaceCharToBD(txtLettre, "RTF")
    //  ado_cmd.Parameters("@iAction").value = miAction
    //   
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //
    //  ' récupération du numéro crée
    //  miNumOG = ado_cmd.Parameters(0).value
    //
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //      
    //Exit Sub
    //handler:
    //  ShowError "EnregistrerOG dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (!TestValidation()) return;

        EnregistrerOG();

        //assage en modification
        mstrStatut = "M";

        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //On Error GoTo handler
    //
    //    If Not TestValidation Then Exit Sub
    //
    //    Call EnregistrerOG
    //  
    //    ' passage en modification
    //    Me.mstrStatut = "M"
    //    
    //    Call InitialiserFeuille
    //    Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private bool TestValidation()
    {
      if (txtLettre.Text == "")
      {
        MessageBox.Show(Resources.msg_EntrerTxtDansZone, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtLettre.Focus();
        return false;
      }
      return true;
    }

        private async void ApiTelAuto1_Click(object sender, EventArgs e)
        {
            if (txtClientTel.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtClientTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ApiTelAuto2_Click(object sender, EventArgs e)
        {
            if (txtSTTTel.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtSTTTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ApiTelAuto3_Click(object sender, EventArgs e)
        {
            if (txtSTTPor.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtSTTPor.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Private Function TestValidation() As Boolean
        //  
        //On Error GoTo handler
        // 
        //  If txtLettre = "" Then
        //    MsgBox "§Saisissez du texte dans la zone texte§"
        //    TestValidation = False
        //    txtLettre.SetFocus
        //    Exit Function
        //  End If
        // 
        //  TestValidation = True
        //  
        //Exit Function
        //handler:
        //  ShowError "TestValidation dans " & Me.Name
        //End Function
        //

    }
}

