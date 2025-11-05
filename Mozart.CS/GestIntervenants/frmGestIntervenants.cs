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
  public partial class frmGestIntervenants : Form
  {
    public string mstrStatut;
    public string msNomFourn;
    public long miNumFourn;

    string msAdrMail;
    long miNumContact;
    //int miCurContact;
    DataTable dt = new DataTable();
    //Public mstrStatut As String
    //Public miNumFourn As Long
    //Public msNomFourn  As String
    //Private miNumContact As Long
    //Private miAdrMail As String
    //Dim rsInt As Recordset
    //Dim miCurContact As Integer
    public frmGestIntervenants()
    {
      InitializeComponent();
    }

    private void frmGestIntervenants_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);
        lblTitre.Text += msNomFourn;
        CmdInitEnvoiFormulaire.Visible = false;

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = {miNumFourn} AND CINTACTIF = 'Actif' ORDER BY VINTNOM ");
        apiGrid.GridControl.DataSource = dt;
        InitApigrid();

        apiGrid_SelectionChanged(null, null);

        //  Modif du 28/07/2016 : Le formulaire Web a-t-il déjà été envoyé et le STT a t'il répondu ?
        bool bFrmEnvoye = false;
        using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TREFSTTLOG INNER JOIN TINT ON TINT.NINTNUM = TREFSTTLOG.NINTNUM WHERE TINT.NSTFNUM = {miNumFourn} order by id desc"))
        {
          if (dr.Read())
          {
            // cmdMail.Enabled = False
            lblDateEnvoiFormulaire.Visible = true;
            lblDateEnvoiFormulaire.Text = Resources.txt_date_last_envoie_form_web + dr["dDate"];
            bFrmEnvoye = true;
          }
        }

        // TODO VL : Est ce vraiment utile de boucler alors qu'il ne peut y avoir qu'un seul enregistrement ?
        using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM TREF_STT WHERE NSTFNUM = " + miNumFourn))
        {
          if (dr.Read())
          {
            cmdMail.Enabled = false;
            CmdInitEnvoiFormulaire.Visible = true;
            lblDateReceptionFormulaire.Visible = true;
            lblDateReceptionFormulaire.Text = Resources.txt_Date_reception_form_web + Utils.DateBlankIfNull(dr["DateEnregDonnees"]);
          }
          else
          {
            if (bFrmEnvoye == true)
            {
              CmdInitEnvoiFormulaire.Visible = false;
              lblDateReceptionFormulaire.Text = Resources.txt_Form_web_not_returned_by_subcontractor;
              //TODO avoir la couleur pour &H40C0&
              lblDateReceptionFormulaire.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            }
          }
        }
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
    //Private Sub Form_Load()
    //
    //  On Error GoTo handler
    //  
    //  InitBoutons Me, frmMenu
    //  lblTitre = lblTitre & msNomFourn
    //  CmdInitEnvoiFormulaire.Visible = False
    //  
    //  Set rsInt = New Recordset
    //  rsInt.Open "SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = " & miNumFourn & " AND CINTACTIF = 'Actif' ORDER BY VINTNOM ", cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //  Call apiGrid_RowColChange
    //  
    //  ' Modif du 28/07/2016 : Le formulaire Web a-t-il déjà été envoyé et le STT a t'il répondu ?
    //  Dim bFrmEnvoye As Boolean
    //  bFrmEnvoye = False
    //  Dim rsTemp As Recordset
    //  Set rsTemp = New Recordset
    //  rsTemp.Open "SELECT * FROM TREFSTTLOG INNER JOIN TINT ON TINT.NINTNUM = TREFSTTLOG.NINTNUM WHERE TINT.NSTFNUM = " & miNumFourn & " order by id desc", cnx, adOpenStatic, adLockOptimistic
    //  If Not rsTemp.EOF Then
    //    'cmdMail.Enabled = False
    //    lblDateEnvoiFormulaire.Visible = True
    //    lblDateEnvoiFormulaire.Caption = "Date de dernier envoi du formulaire Web : " & rsTemp!dDate
    //    bFrmEnvoye = True
    //  End If
    //  
    //  rsTemp.Close
    //  
    //  rsTemp.Open "SELECT * FROM TREF_STT WHERE NSTFNUM = " & miNumFourn, cnx, adOpenStatic, adLockOptimistic
    //  If Not rsTemp.EOF Then
    //    cmdMail.Enabled = False
    //    CmdInitEnvoiFormulaire.Visible = True
    //    lblDateReceptionFormulaire.Visible = True
    //    lblDateReceptionFormulaire.Caption = "Date de réception du formulaire Web : " & rsTemp!DateEnregDonnees
    //    Else
    //    If bFrmEnvoye = True Then
    //      CmdInitEnvoiFormulaire.Visible = False
    //      lblDateReceptionFormulaire.Caption = "Le formulaire Web n'a pas été retourné par le sous-traitant."
    //      lblDateReceptionFormulaire.ForeColor = &H40C0&
    //    End If
    //  End If
    //  
    //  rsTemp.Close
    //  ' Fin modif du 28/07/2016
    //  
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      mstrStatut = "C";
      miNumContact = 0;
      msAdrMail = "";
      OuvertureEnCreation();
    }
    //Private Sub cmdAjouter_Click()
    //  mstrStatut = "C"
    //  miNumContact = 0
    //  miAdrMail = ""
    //  OuvertureEnCreation
    //End Sub

    private void cmdMail_Click(object sender, EventArgs e)
    {
      if (msAdrMail == "")
        MessageBox.Show(Resources.msg_Saisir_contact_email, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else
        //TODO Erreur dans frmEnvoiFormulaireSTF_Load
        new frmEnvoiFormulaireSTF(miNumContact).ShowDialog();
    }
    //Private Sub cmdMail_Click()
    //
    //  If miAdrMail = "" Then
    //    MsgBox "Le contact n'a pas d'adresse mail renseignée!", vbOKOnly
    //  Else
    //    modMain.VerifMOZARTNET
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmEnvoiFormulaireSTF" & " " & miNumContact, vbNormalFocus
    //  End If
    //End Sub

    private void CmdInitEnvoiFormulaire_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(Resources.msg_Confirm_init_form_subcontractor, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.ExecuteNonQuery($"EXEC [api_sp_InitialiseEnvoiFormulaireSTF] {miNumFourn}");
        cmdMail.Enabled = true;
        CmdInitEnvoiFormulaire.Visible = false;
      }
    }
    //Private Sub CmdInitEnvoiFormulaire_Click()
    //
    //    If MsgBox("§Voulez-vous initialiser le formulaire de ce sous-traitant ?§", vbQuestion + vbYesNoCancel) = vbYes Then
    //    
    //        'execute
    //        cnx.Execute ("EXEC [api_sp_InitialiseEnvoiFormulaireSTF] " & miNumFourn)
    //        
    //        cmdMail.Enabled = True
    //        CmdInitEnvoiFormulaire.Visible = False
    //    
    //    End If
    //    
    //End Sub

    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      try
      {
        //on archive l'intervenant
        //test du nom
        if (txtNom.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirNomContact);
          txtNom.Focus();
        }
        //on teste si contact lié a un acces web tablet st
        //reglè N° 1 : un contact = un seul accès web
        if (miNumContact > 0)
        {
          if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TSTTECH WITH (NOLOCK) WHERE NINTNUM = {miNumContact}") > 0)
          {
            MessageBox.Show(Resources.msg_Archivage_impossible_contact_has_acces_subcontractor);
            return;
          }
        }

        Enregistrer("N");

        if (dt.Rows.Count <= 0)
        {
          txtNom.Text = "";
          txtPrenom.Text = "";
          txtFonction.Text = "";
          txtTel.Text = "";
          txtFax.Text = "";
          txtMail.Text = "";
          txtPort.Text = "";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdArchiver_Click()
    //  ' on archive l'intervenant
    //  On Error GoTo handler
    //    
    //  ' test du nom
    //  If txtNom.Text = "" Then
    //    MsgBox "§Saisissez un nom de contact§"
    //    txtNom.SetFocus
    //    Exit Sub
    //  End If
    //  
    //    'on teste si contact lié a un acces web tablet st
    //    'reglè N° 1 : un contact = un seul accès web
    //    If miNumContact > 0 Then
    //    
    //        Dim adorsSTT As New ADODB.Recordset
    //        adorsSTT.Open "SELECT COUNT(*) FROM TSTTECH WITH (NOLOCK) WHERE NINTNUM = " & miNumContact, cnx, adOpenStatic, adLockReadOnly
    //        
    //        If adorsSTT(0) > 0 Then
    //            MsgBox "Archivage impossible car ce contact possède un accès tablet sous-traitant."
    //            adorsSTT.Close
    //            Exit Sub
    //        End If
    //        adorsSTT.Close
    //    
    //    End If
    //  
    //  Call Enregistrer("N")
    //  If rsInt.RecordCount > 0 Then
    //    rsInt.MoveFirst
    //  Else
    //    txtNom = ""
    //    txtprenom = ""
    //    txtFonction = ""
    //    txtTel = ""
    //    txtFax = ""
    //    txtMail = ""
    //    txtPort = ""
    //  End If
    //
    //
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        //test du nom
        if (txtNom.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirNomContact);
          txtNom.Focus();
          return;
        }
        // test du tél
        if (txtTel.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirNumTel);
          txtTel.Focus();
          return;
        }

        // test du mail
        if (txtMail.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirEmail);
        }
        else
        {
          if (txtMail.Text.Contains(" ") || !txtMail.Text.Contains("@") || !txtMail.Text.Contains("."))
          {
            MessageBox.Show(Resources.msg_adresseCourrielInvalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        Enregistrer();
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
    //  ' test du nom
    //  If txtNom.Text = "" Then
    //    MsgBox "§Saisissez un nom de contact§"
    //    txtNom.SetFocus
    //    Exit Sub
    //  End If
    //  
    //  ' test du tél
    //  If txtTel.Text = "" Then
    //    MsgBox "§Saisissez un numéro de téléphone§"
    //    txtTel.SetFocus
    //    Exit Sub
    //  End If
    //  
    //  ' test du mail
    //  If txtMail.Text = "" Then
    //    MsgBox "§Pensez à renseigner une adresse mail§"
    //    'txtMail.SetFocus
    //    'Exit Sub
    //  Else
    //    If InStr(txtMail, " ") > 0 Or InStr(txtMail, "@") = 0 Or InStr(txtMail, ".") = 0 Then
    //      MsgBox "§Adresse courriel invalide§", vbExclamation
    //      Exit Sub
    //    End If
    //  End If
    //    
    //  Call Enregistrer
    //                     
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub

    private void cmdListeArchive_Click(object sender, EventArgs e)
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = {miNumFourn } AND CINTACTIF = 'Archivé' ORDER BY VINTNOM "))
      {
        if (dr.HasRows)
        {
          new frmGestIntervenantArch()
          {
            msNomFourn = msNomFourn,
            miNumFourn = Convert.ToInt32(miNumFourn)
          }.ShowDialog();
          apiGrid.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
    }
    //Private Sub cmdListeArchive_Click()
    //Dim ado_rsArch As ADODB.Recordset
    //
    //  Set ado_rsArch = New ADODB.Recordset
    //  ado_rsArch.Open "SELECT * FROM api_v_InfoContactFournisseur WHERE NSTFNUM = " & miNumFourn & " AND CINTACTIF = 'Archivé' ORDER BY VINTNOM ", cnx
    //
    //  If ado_rsArch.RecordCount > 0 Then
    //    frmGestIntervenantArch.lblTitre = frmGestIntervenantArch.lblTitre & msNomFourn
    //    frmGestIntervenantArch.Show vbModal
    //    rsInt.Requery
    //    apigrid.MajLabel
    //    'InitApigrid
    //  End If
    //  
    //  ado_rsArch.Close
    //End Sub

    private void apiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      if (dt.Rows.Count > 0)
      {
        mstrStatut = "M";
        miNumContact = Convert.ToInt64(currentRow["NINTNUM"]);
        msAdrMail = Utils.BlankIfNull(currentRow["VINTMAIL"]);
        OuvertureEnModification();
      }
      else
      {
        mstrStatut = "C";
        miNumContact = 0;
        msAdrMail = "";
        OuvertureEnCreation();
      }
    }
    //Private Sub apiGrid_RowColChange()
    //  If rsInt.RecordCount > 0 Then
    //    mstrStatut = "M"
    //    miNumContact = rsInt!NINTNUM
    //    miAdrMail = BlankIfNull(rsInt!VINTMAIL)
    //    OuvertureEnModification
    //  Else
    //    mstrStatut = "C"
    //    miNumContact = 0
    //    miAdrMail = ""
    //    OuvertureEnCreation
    //  End If
    //End Sub

    private void OuvertureEnCreation()
    {
      try
      {
        txtNom.Text = "";
        txtPrenom.Text = "";
        txtFonction.Text = "";
        txtTel.Text = "";
        txtFax.Text = "";
        txtPort.Text = "";
        txtMail.Text = "";
        Frame1.Text = "";

        cboCiv.Enabled = true;
        //cboCiv.Text = "";
        cboCiv.SelectedIndex = -1;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnCreation()
    //
    //Dim c As Object
    //On Error GoTo handler
    //
    //  ' renseignement de la partie client
    //  For Each c In Me.Controls
    //    If TypeOf c Is TextBox Then c.Text = ""
    //  Next
    //  'chkActif.Value = 1
    //  cboCiv.ListIndex = -1
    //  
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "OuvertureEnCreation dans " & Me.Name
    //End Sub

    private void OuvertureEnModification()
    {
      try
      {
        DataRow row = apiGrid.GetFocusedDataRow();
        //  Affichage des informations à partir du recordset de l'apigrid
        txtNom.Text = Utils.BlankIfNull(row["VINTNOM"]);
        txtPrenom.Text = Utils.BlankIfNull(row["VINTPRE"]);
        txtFonction.Text = Utils.BlankIfNull(row["VINTFONC"]);

        txtTel.Text = Utils.BlankIfNull(row["VINTTEL"]);
        txtFax.Text = Utils.BlankIfNull(row["VINTFAX"]);
        txtMail.Text = Utils.BlankIfNull(row["VINTMAIL"]);
        txtPort.Text = Utils.BlankIfNull(row["VINTPOR"]);

        cboCiv.Text = Utils.BlankIfNull(row["CINTCIV"]);

        if (Utils.BlankIfNull(row["VPERNOMPRE"]) != "" && Utils.DateBlankIfNull(row["DINTCREE"]) != "")
          Frame1.Text = $"({Resources.msg_Contact_saved_by} " + Utils.BlankIfNull(row["VPERNOMPRE"]) + $" {Resources.msg_le_minuscule} " + Utils.DateBlankIfNull(row["DINTCREE"]) + ")";
        else
          Frame1.Text = "";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnModification()
    // 
    //On Error GoTo handler
    //
    //  ' Affichage des informations à partir du recordset de l'apigrid
    //  txtNom = BlankIfNull(rsInt("VINTNOM"))
    //  txtprenom = BlankIfNull(rsInt("VINTPRE"))
    //  txtFonction = BlankIfNull(rsInt("VINTFONC"))
    //
    //  txtTel = BlankIfNull(rsInt("VINTTEL"))
    //  txtFax = BlankIfNull(rsInt("VINTFAX"))
    //  txtMail = BlankIfNull(rsInt("VINTMAIL"))
    //  txtPort = BlankIfNull(rsInt("VINTPOR"))
    //  'chkActif.Value = IIf(rsInt!CINTACTIF = "Actif", 1, 0)
    //  
    //  On Error Resume Next      ' si pas de civilité, plantage dans la combo
    //  cboCiv = BlankIfNull(rsInt("CINTCIV"))
    // 
    //  'on affiche le nom du créateur avec sa date
    //  If BlankIfNull(rsInt("VPERNOMPRE")) <> "" And BlankIfNull(rsInt("DINTCREE")) <> "" Then
    //    Frame1.Caption = "(§Contact enregistré par§ " & BlankIfNull(rsInt("VPERNOMPRE")) & " §le§ " & BlankIfNull(rsInt("DINTCREE")) & ")"
    //  Else
    //    Frame1.Caption = ""
    //  End If
    // 
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    public void Enregistrer(string cActif = "O")
    {
      // pour la création ou la modification, c'est la proc stock qui gère
      using (SqlCommand cmd = new SqlCommand("api_sp_CreationContactFournisseur", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@iNum"].Value = miNumContact;   // 0 si création
        cmd.Parameters["@iFourn"].Value = miNumFourn;
        cmd.Parameters["@vNom"].Value = txtNom.Text.ToUpper();
        cmd.Parameters["@vPrenom"].Value = txtPrenom.Text;
        cmd.Parameters["@vCiv"].Value = cboCiv.Text;
        cmd.Parameters["@vFonction"].Value = txtFonction.Text;
        cmd.Parameters["@vTel"].Value = txtTel.Text;
        cmd.Parameters["@vFax"].Value = txtFax.Text;
        cmd.Parameters["@vPort"].Value = txtPort.Text;
        cmd.Parameters["@vMail"].Value = txtMail.Text;
        cmd.Parameters["@cActif"].Value = cActif;

        cmd.ExecuteNonQuery();
        miNumContact = (int)cmd.Parameters[0].Value;
      }
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Public Function Enregistrer(Optional cActif As String = "O")
    //
    //Dim cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  ' pour la création ou la modification, c'est la proc stock qui gère
    //  Set cmd.ActiveConnection = cnx
    //  cmd.CommandText = "api_sp_CreationContactFournisseur"
    //  cmd.CommandType = adCmdStoredProc
    //  cmd.Parameters.Refresh
    //
    //  cmd.Parameters("@iNum").value = miNumContact   ' 0 si création
    //  cmd.Parameters("@iFourn").value = miNumFourn
    //  cmd.Parameters("@vNom").value = Majuscule(txtNom)
    //  cmd.Parameters("@vPrenom").value = txtprenom
    //  cmd.Parameters("@vCiv").value = cboCiv.Text
    //  cmd.Parameters("@vFonction").value = txtFonction
    //  cmd.Parameters("@vTel").value = txtTel
    //  cmd.Parameters("@vFax").value = txtFax
    //  cmd.Parameters("@vPort").value = txtPort
    //  cmd.Parameters("@vMail").value = txtMail
    //  cmd.Parameters("@cActif").value = cActif
    //  
    //  Set ado_rs = cmd.Execute()
    //  
    //  miNumContact = cmd.Parameters(0).value    ' récupération du numéro crée
    //  miCurContact = rsInt.AbsolutePosition     ' garder la position courante avant requery pour se repositionner
    //    
    //  Set cmd = Nothing
    //  rsInt.Requery
    //  apigrid.MajLabel
    //  'InitApigrid
    //  'rsInt.AbsolutePosition = max((miCurContact), 1)
    //  
    //  Exit Function
    //  Resume
    //    
    //handler:
    //  ShowError "EnregistrerAction dans " & Me.Name
    //End Function
    //
    private void InitApigrid()
    {
      apiGrid.AddColumn(Resources.col_Nom, "VINTNOM", 1500);
      apiGrid.AddColumn(Resources.col_Prenom, "VINTPRE", 1200);
      apiGrid.AddColumn(Resources.col_Civ, "CINTCIV", 900);
      apiGrid.AddColumn(Resources.col_Fonction, "VINTFONC", 2200);
      apiGrid.AddColumn(Resources.col_Telephone, "VINTTEL", 1400);
      apiGrid.AddColumn(Resources.col_Fax, "VINTFAX", 1400);
      apiGrid.AddColumn(Resources.col_GSM, "VINTPOR", 1400);
      apiGrid.AddColumn(Resources.col_Email, "VINTMAIL", 2000);
      apiGrid.AddColumn(Resources.col_Statut, "CINTACTIF", 0);
      apiGrid.AddColumn("NumST", "NSTFNUM", 0);
      apiGrid.AddColumn("NumContact", "NINTNUM", 0);

      apiGrid.InitColumnList();
    }
    //Sub InitApigrid()
    //  
    //  apigrid.AddColumn "§Nom§", "VINTNOM", 1500
    //  apigrid.AddColumn "§Prénom§", "VINTPRE", 1200
    //  apigrid.AddColumn "§Civilité§", "CINTCIV", 900
    //  apigrid.AddColumn "§Fonction§", "VINTFONC", 2200
    //  apigrid.AddColumn "§Téléphone§", "VINTTEL", 1400, , vbCenter
    //  apigrid.AddColumn "§Fax§", "VINTFAX", 1400, , vbCenter
    //  apigrid.AddColumn "§GSM§", "VINTPOR", 1400, , vbCenter
    //  apigrid.AddColumn "§E-Mail§", "VINTMAIL", 2000
    //  apigrid.AddColumn "§Statut§", "CINTACTIF", 0
    //  apigrid.AddColumn "NumST", "NSTFNUM", 0
    //  apigrid.AddColumn "NumContact", "NINTNUM", 0
    //  
    //  apigrid.Init rsInt
    //End Sub
    //
    //'Private Sub txtTel_LostFocus()
    //'  txtTel = FormatTel(txtTel)
    //'End Sub

    //'Private Sub txtFax_LostFocus()
    //'  txtFax = FormatTel(txtFax)
    //'End Sub

    //'Private Sub txtPort_LostFocus()
    //'  txtPort = FormatTel(txtPort)
    //'End Sub


    private void txtMail_Leave(object sender, EventArgs e)
    {
      // TODO VL : Ne pas oublier de traduire les termes dans FormatMail...
      txtMail.Text = ModuleMain.FormatMail(txtMail).ToString();
    }
    //Private Sub txtMail_LostFocus()
    //  txtMail = FormatMail(txtMail)
    //End Sub
  }
}