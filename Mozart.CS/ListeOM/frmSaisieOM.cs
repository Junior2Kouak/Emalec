using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieOM : Form
  {
    public string mstrStatut;
    public long miNumOM;
    public long miST;
    public long miAction;
    public bool mbFacture = false;

    int miNumClient;


    public frmSaisieOM() { InitializeComponent(); }

    private void frmSaisieOM_Load(object sender, System.EventArgs e)
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
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
        if (mbFacture)
        {
          MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (!TestValidation()) return;

        // on teste si l'on peut modifier le statut de facturation en NF
        switch (TestIfCreationOMIsOk())
        {
          case 0:
            MessageBox.Show("Création de l'ordre de mission impossible car l'action est chiffrée ou facturée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            break;
          case 1:
            MessageBox.Show("Création de l'ordre de mission impossible. Il existe déjà un contrat sous-traitant !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            break;
          case 2:
            MessageBox.Show("L'état de facturation de l'action sera automatiquement basculé en Non Facturé", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ModuleData.CnxExecute($"update TACT set CACTSTA='N' WHERE NACTNUM = {miAction}");
            break;
          default:
            break;
        }
        EnregistrerOM();

        // passage en modification
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
    //  ' si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OM
    //  If frmListeOM.bFacture Then
    //    MsgBox "§Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'§", vbOKOnly
    //    Exit Sub
    //  End If
    //
    //  If Not TestValidation Then Exit Sub
    //  
    //    'on teste si l'on peut modifier le statut de facturation en NF
    //    Select Case TestIfCreationOMIsOk()
    //        Case 0
    //            MsgBox "Création de l'ordre de mission impossible car l'action est chiffrée ou facturée", vbInformation
    //        Case 1
    //            MsgBox "Création de l'ordre de mission impossible. Il existe déjà un contrat sous-traitant !", vbInformation
    //        Case 2
    //            MsgBox "L'état de facturation de l'action sera automatiquement basculé en Non Facturé", vbInformation
    //            cnx.Execute "update TACT set CACTSTA='N' WHERE NACTNUM = " & miAction
    //    End Select
    //  
    //  Call EnregistrerOM
    //  
    //  ' passage en modification
    //  Me.mstrStatut = "M"
    //  
    //  Call InitialiserFeuille
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (miNumOM == 0)
      {
        MessageBox.Show(Resources.msg_ImprImpOrdreMission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      Cursor.Current = Cursors.WaitCursor;
      //Process.Start($@"{MozartParams.RepertoireReports}ReportEmalec.Net.exe", $"TOM;{miNumClient}|{miNumOM};TINT|NINTNUM|{txtFields4.Tag};{MozartParams.NomSociete};{Strings.Left(GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST.ToString()), 2)};PREVIEW;OM;{MozartParams.NumAction}");
      StartReport("PREVIEW");
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CmdVisu_Click()
    //  On Error Resume Next
    //  
    //  If miNumOM = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer l'ordre de mission§", vbInformation
    //    Exit Sub
    //  Else
    //      
    //                           
    //  ' cas général
    //  Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TOM;" & miNumClient & "|" & miNumOM & ";TINT|NINTNUM|" & txtFields(4).Tag & ";" & gstrNomSociete & ";" & Left(GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST), 2) & ";PREVIEW;OM;" & glNumAction & """, vbNormalFocus"
    //                           
    //  End If
    //  
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumOM == 0)
        {
          MessageBox.Show(Resources.msg_ImprImpOrdreMission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        Cursor.Current = Cursors.WaitCursor;
        //Process.Start($@"{MozartParams.RepertoireReports}ReportEmalec.Net.exe", $"TOM;{miNumClient}|{miNumOM};TINT|NINTNUM|{txtFields4.Tag};{MozartParams.NomSociete};{Strings.Left(GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST.ToString()), 2)};PREVIEW;OM;{MozartParams.NumAction}");
        StartReport("PRINT");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdImprimer_Click()
    //
    //On Error Resume Next
    //           
    //  If miNumOM = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer l'ordre de mission§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  Screen.MousePointer = vbHourglass
    //   
    //  Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TOM;" & miNumClient & "|" & miNumOM & ";TINT|NINTNUM|" & txtFields(4).Tag & ";" & gstrNomSociete & ";" & Left(GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST), 2) & ";PRINT;OM;" & glNumAction & """, vbNormalFocus"
    //           
    //  Screen.MousePointer = vbDefault
    //    
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Imprimer dans " & Me.Name
    //End Sub
    //

    private void StartReport(string option)
    {
      new frmMainReport()
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TOM",
        sIdentifiant = $"{miNumClient}|{miNumOM}",
        InfosMail = $"TINT|NINTNUM|{CotraiContact.Tag}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = Strings.Left(Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", miST.ToString()), 2),
        sOption = option,
        strType = "OM",
        numAction = MozartParams.NumAction,
      }.ShowDialog();
    }

    /* OK --------------------------------------------------------------------------*/
    private void cmdMail_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumOM == 0)
        {
          MessageBox.Show(Resources.msg_ImprImpOrdreMission, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //confirmation
        if (MessageBox.Show(Resources.msgConfirm_MailSousTrait, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
          return;

        Cursor.Current = Cursors.WaitCursor;
        //envoi du mail
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_EnvoieMailOM {miNumOM}"))
        {
          if (dr.Read())
          {
            if (Convert.ToInt32(dr[0]) == 0)
              MessageBox.Show(Resources.msg_nomail_fo_contact, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
              MessageBox.Show(Resources.msg_mail_sent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdMail_Click()
    //
    //Dim response
    //Dim RSret As ADODB.Recordset
    //On Error GoTo handler
    //
    //  If miNumOM = 0 Then
    //    MsgBox "§Impression impossible, il faut commencer par enregistrer l'ordre de mission§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //   ' confirmation
    //  response = MsgBox("§Vous allez envoyer un mail au sous traitant. Confirmez-vous cette action ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //  Select Case response
    //    Case vbYes
    //    Case vbNo
    //      Exit Sub
    //    Case vbCancel
    //      Exit Sub
    //  End Select
    //    
    //      
    //  ' envoi du mail
    //  Set RSret = New ADODB.Recordset
    //  RSret.Open "api_sp_EnvoieMailOM " & miNumOM, cnx
    //  
    //  If RSret(0) = 0 Then
    //    MsgBox "§Le contact n'a pas d'adresse mail!§", vbInformation
    //  Else
    //    MsgBox "§Le mail a été envoyé!§", vbInformation
    //  End If
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " cmdMail_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private bool TestValidation()
    {
      try
      {
        if (txtLettre.Text == "")
        {
          MessageBox.Show(Resources.msg_EntrerTxtDansZone, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtLettre.Focus();
          return false;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return true;
    }
    //Private Function TestValidation() As Boolean
    //  
    //On Error GoTo handler
    //
    // 
    //  If txtLettre = "" Then
    //    MsgBox "§ Saisissez du texte dans la zone texte§"
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

    /* OK --------------------------------------------------------------------------*/
    private void EnregistrerOM()
    {
      try
      {
        //création d'une commande 
        using (SqlCommand cmd = new SqlCommand("api_sp_creationOM", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iNumOM"].Value = miNumOM;
          cmd.Parameters["@iST"].Value = CotraiContact.Tag;
          cmd.Parameters["@iAction"].Value = miAction;
          cmd.Parameters["@corps"].Value = ModuleMain.ReplaceCharToBD(txtLettre.Text, "RTF");
          cmd.Parameters["@ddateex"].Value = Convert.ToDateTime(txtRea.Text);

          cmd.ExecuteNonQuery();

          // récupération du numéro créé
          miNumOM = (int)cmd.Parameters[0].Value;
        }

        // Si client RELAY alors Message Info : chiffrage frais de gestion du dossier
        // seulement pour la creation d'un OM
        if (miNumClient == 1751 && mstrStatut == "C" && MozartParams.NomGroupe == "EMALEC")
        {
          //int bOKAct_Chiff_auto_OM = 0;

          using (SqlCommand cmd_act_auto_om = new SqlCommand("api_sp_CreationActionChiffAutoFraisGestionOM", MozartDatabase.cnxMozart))
          {
            cmd_act_auto_om.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd_act_auto_om);    // liste des paramètres

            cmd_act_auto_om.Parameters["@p_nactnum"].Value = miAction;
            cmd_act_auto_om.Parameters["@corps"].Value = txtLettre.Text;

            cmd_act_auto_om.ExecuteNonQuery();

            if ((int)cmd_act_auto_om.Parameters[0].Value == 1)
            {
              MessageBox.Show(Resources.msg_ActChiffeeFraisGestInter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

              //on force la di en type de facturation Forfait/Devis
              //frmAddAction f = new frmAddAction();
              //f.optFact0.Checked = true;
              //f.optFact1.Checked = false;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub EnregistrerOM()
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
    //  ado_cmd.CommandText = "api_sp_creationOM"
    //  ado_cmd.CommandType = adCmdStoredProc
    //   
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //   
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iNumOM").value = miNumOM
    //  ado_cmd.Parameters("@iST").value = txtFields(4).Tag
    //  ado_cmd.Parameters("@iAction").value = miAction
    //  ado_cmd.Parameters("@corps").value = ReplaceCharToBD(txtLettre, "RTF")
    //  ado_cmd.Parameters("@ddateex").value = txtFields(6)
    //   
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //
    //  ' récupération du numéro crée
    //  miNumOM = ado_cmd.Parameters(0).value
    //
    //  'Si client RELAY alors Message Info : chiffrage frais de gestion du dossier
    //  'seulement pour la creation d'un OM
    //  
    //  'MODIF du 28/09/2016 par MC, suite a demande par mail par sylvie, réactiver la recherche si co traitant
    //  ' TB SAMSIC CITY SPEC
    //  If miNumClient = 1751 And mstrStatut = "C" And gstrNomGroupe = "EMALEC" Then   'And RechercheCotraitantAct(miAction) = True
    //    
    //    Dim bOKAct_Chiff_auto_OM As Byte
    //    bOKAct_Chiff_auto_OM = 0
    //    Dim ado_cmd_act_auto_om As New ADODB.Command
    //    Dim ado_rs_act_auto_om  As New ADODB.Recordset
    //        
    //    Set ado_cmd_act_auto_om.ActiveConnection = cnx
    //    
    //    ' passage du nom de la procédure stockée
    //    ado_cmd_act_auto_om.CommandText = "api_sp_CreationActionChiffAutoFraisGestionOM"
    //    ado_cmd_act_auto_om.CommandType = adCmdStoredProc
    //     
    //    ' passage des paramètres
    //    ado_cmd_act_auto_om.Parameters.Refresh
    //     
    //     ' liste des paramètres
    //    ado_cmd_act_auto_om.Parameters("@p_nactnum").value = miAction
    //    ado_cmd_act_auto_om.Parameters("@corps").value = txtLettre.Text
    //     
    //    ' exécuter la commande.
    //    Set ado_rs_act_auto_om = ado_cmd_act_auto_om.Execute
    //        
    //    If ado_rs_act_auto_om(0) = 1 Then
    //    
    //        MsgBox "§Une action chiffrée a été créée pour les frais de gestion de l'intervention§", vbInformation
    //        'on force la di en type de facturation Forfait/Devis
    //        frmAddAction.optFact(0).value = True
    //        frmAddAction.optFact(1).value = False
    //    End If
    //
    //    Set ado_cmd_act_auto_om = Nothing
    //
    //  End If
    //  
    //  
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //      
    //Exit Sub
    //handler:
    //  ShowError "EnregistrerOM dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void InitialiserFeuille()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // recherche des infos du contrat
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_RetourInfoOM {miNumOM},{miAction}"))
        {
          if (dr.Read())
          {
            ClientNom.Text = Utils.BlankIfNull(dr["VCLINOM"]);
            ClientSiteNum.Text = Utils.BlankIfNull(dr["NSITNUE"]);
            ClientSiteNom.Text = Utils.BlankIfNull(dr["VSITNOM"]);
            ClientResp.Text = Utils.BlankIfNull(dr["VSITRES"]);
            ClientTel.Text = Utils.BlankIfNull(dr["VSITTEL"]);

            CotraiNom.Text = Utils.BlankIfNull(dr["VSTFNOM"]);
            CotraiContact.Text = Utils.BlankIfNull(dr["VINTNOM"]);
            CotraiMail.Text = Utils.BlankIfNull(dr["VINTMAIL"]);
            CotraiTel.Text = Utils.BlankIfNull(dr["VINTTEL"]);
            CotraiFax.Text = Utils.BlankIfNull(dr["VINTFAX"]);
            CotraiPor.Text = Utils.BlankIfNull(dr["VINTPOR"]);

            txtRea.Text = Utils.DateBlankIfNull(dr["DOMDEX"]);

            //numero du contact
            CotraiContact.Tag = dr["NINTNUM"];

            // si on est en modification ou en création
            if (Convert.ToInt32(dr["NOMNUM"]) == 0)
            {
              mstrStatut = "C";
              miNumOM = 0;
              txtLettre.Text = Utils.BlankIfNull(dr["VACTDES"]);
            }
            else
            {
              mstrStatut = "M";
              miNumOM = Convert.ToInt32(dr["NOMNUM"]);
              txtLettre.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(dr["VOMCORPS"]), "RTF");
            }

            miNumClient = Convert.ToInt32(dr["NCLINUM"]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub InitialiserFeuille()
    //
    //Dim otext As TextBox
    //
    //On Error GoTo handler
    //
    //  ' recherche des info du contrat
    //  Set rsC = New ADODB.Recordset
    //  rsC.Open "api_sp_RetourInfoOM " & miNumOM & "," & miAction, cnx
    //  
    //  'les infos de la feuille
    //  For Each otext In Me.txtFields
    //    Set otext.DataSource = rsC
    //  Next
    //
    //   ' numero du contact
    //  txtFields(4).Tag = rsC("NINTNUM")
    //   
    //  ' si on est en modification ou en création
    //  If rsC("NOMNUM") = 0 Then
    //    Me.mstrStatut = "C"
    //    Me.miNumOM = 0
    //    Me.txtLettre = rsC("VACTDES")
    //  Else
    //    Me.mstrStatut = "M"
    //    Me.miNumOM = rsC("NOMNUM")
    //    Me.txtLettre = ReplaceCharFromBD(BlankIfNull(rsC("VOMCORPS")), "RTF")
    //  End If
    //  
    //   miNumClient = rsC("NCLINUM")
    //  rsC.Close
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " OuvertureEnModification dans " & Me.Name
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------*/
    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(ClientTel.Text);
            if (ClientTel.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, ClientTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto2_Click(object sender, EventArgs e)
    {
      //ApiTelAuto2.TelDial(CotraiTel.Text);
            if (CotraiTel.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, CotraiTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private async void ApiTelAuto3_Click(object sender, EventArgs e)
    {
      //ApiTelAuto3.TelDial(CotraiPor.Text);
            if (CotraiPor.Text != "")
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, CotraiPor.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    public int TestIfCreationOMIsOk()
    {
      //    0 : on interdit la creation car action facturee ou chiffree
      //    1 : on interdit car il y a des contrats ST
      //    2 : on autorise la creation pour permettre le chgnt en Non Facturé

      int iArchivageOM = 0;

      using (SqlDataReader sdr = ModuleData.ExecuteReader($"EXEC api_sp_VerifCreationOMIsOK  {MozartParams.NumAction}"))
      {
        if (sdr.Read())
        {
          if (Utils.BlankIfNull(sdr["CACTSTA"]) == "F" || Utils.BlankIfNull(sdr["CACTSTA"]) == "C")
            iArchivageOM = 0;
          else if (Convert.ToInt32(sdr["NBCSTACTIF"]) > 0)
            iArchivageOM = 1;
          else
            iArchivageOM = 2;
        }
      }
      return iArchivageOM;
    }

    //    Public Function TestIfCreationOMIsOk() As Integer
    //
    //    '0 : on interdit la creation car action facturee ou chiffree
    //    '1 : on interdit car il y a des contrats ST
    //    '2 : on autorise la creation pour permettre le chgnt en Non Facturé
    //
    //
    //    Dim iCreationOM As Integer
    //
    //
    //    Dim adoRSVerifOM As New ADODB.Recordset
    //
    //    'init
    //    iCreationOM = 0
    //    adoRSVerifOM.Open "EXEC api_sp_VerifCreationOMIsOK " & glNumAction, cnx
    //
    //    If adoRSVerifOM.RecordCount > 0 Then
    //
    //        If adoRSVerifOM("CACTSTA") = "F" Or adoRSVerifOM("CACTSTA") = "C" Then
    //            iCreationOM = 0
    //        ElseIf adoRSVerifOM("NBCSTACTIF") > 0 Then
    //            iCreationOM = 1
    //        Else
    //            iCreationOM = 2
    //        End If
    //
    //
    //    End If
    //
    //
    //    adoRSVerifOM.Close
    //    Set adoRSVerifOM = Nothing
    //
    //    TestIfCreationOMIsOk = iCreationOM
    //
    //End Function



    /*Public Function GetLanguePays(ByVal sTable As String, ByVal sChamp As String, ByVal sChampCle As String, ByVal sCle As String) As String
      Dim rs As New ADODB.Recordset
      Dim sql As String
      
      On Error GoTo errHandler
      sql = "SELECT " & sChamp & " FROM " & sTable & " WHERE " & sChampCle & " = " & sCle
      rs.Open sql, cnx
      GetLanguePays = rs(0) & "\"
      rs.Close
      Exit Function
      
      errHandler:
      GetLanguePays = "FR" & "\"
      End Function
    */
  }
}

