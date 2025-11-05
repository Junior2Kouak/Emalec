using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using MozartNet;
using MozartCS.Properties;
using MozartLib;
using ReportEmalec.Net;

namespace MozartCS
{
  public partial class frmSaisieAttestation : Form
  {
    public string mstrStatutCourrier;
    public string mstrTypeCour;
    public string mstrTypeDest;
    public string mstrTypeAR;
    public long miNumCourrier;
    public long miAction;
    public int miNumCli;

    long iModif;
    bool bModif;

    public DataTable dtLettre = new DataTable();
    //Public mstrStatutCourrier As String
    //Public mstrTypeCour As String
    //Public mstrTypeDest As String
    //Public mstrTypeAR As String
    //Public iNumCourrier As Long
    //Public iAction As Long
    //Public miNumCli As Integer
    //Dim rsC As ADODB.Recordset
    //Dim iModif As Long
    //Dim bModif As Boolean

    public frmSaisieAttestation()
    {
      InitializeComponent();
    }

    /* OK -----------------------------------------------------------------------*/
    private void frmSaisieAttestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT LIBELLE FROM TREF_TYPEATTLDR WHERE LANGUE = '{MozartParams.Langue}'"))
        {
          while (sdr.Read())
            cboRef.Items.Add(sdr["LIBELLE"]);
        }

        //Récupération de l'action
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select VACTDES, DACTDEX from TACT WITH (NOLOCK) WHERE NACTNUM = {miAction}"))
        {
          if (sdr.Read())
          {
            txtAction.Text = Utils.BlankIfNull(sdr["VACTDES"]);
            txtAction.Tag = Utils.BlankIfNull(sdr["DACTDEX"]);
          }
        }
        txtAction.DeselectAll();

        if (mstrStatutCourrier == "C")
        {
          InitialiserFeuilleVide();
          // pour le premier enregistrement du courrier il faut faire des insert de ligne
          iModif = 1;
        }
        else
        {
          //modification
          dtLettre.Columns.Add("TypeDest", typeof(string));
          dtLettre.Columns.Add("IDdest", typeof(int));
          InitialiserFeuille();
          // pour les modifications globales de toutes les lignes
          iModif = 0;
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub Form_Load()
    // 
    // Dim rsa As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //    
    //  Set rsa = New ADODB.Recordset
    //  rsa.Open "SELECT LIBELLE FROM TREF_TYPEATTLDR WHERE LANGUE = '" & gstrLangue & "'", cnx
    //  While Not rsa.EOF
    //      cboRef.AddItem rsa("LIBELLE")
    //      rsa.MoveNext
    //  Wend
    //  rsa.Close
    // 
    //  
    //  ' récupération de l'action
    //  Set rsC = New ADODB.Recordset
    //  rsC.Open "select VACTDES, DACTDEX from TACT WITH (NOLOCK) WHERE NACTNUM = " & iAction, cnx
    //  If Not rsC.EOF Then
    //    txtAction = BlankIfNull(rsC("VACTDES"))
    //    txtAction.Tag = BlankIfNull(rsC("DACTDEX"))
    //    rsC.Close
    //    Set rsC = Nothing
    //  End If
    //  
    //  If mstrStatutCourrier = "C" Then
    //    Call InitialiserFeuilleVide
    //    ' pour le premier enregistrement du courrier il faut faire des insert de ligne
    //    iModif = 1
    //  Else  ' on est en modification
    //    Call InitialiserFeuille
    //    ' pour les modifications globale de toutes les lignes
    //    iModif = 0
    //  End If
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    //

    /* OK -----------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        //si il y a des modifications
        if (bModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
          {
            case DialogResult.Yes:
              EnregistrerCourrier(0);
              Dispose();
              break;
            case DialogResult.No:
              Dispose();
              break;
            case DialogResult.Cancel:
              return;
          }
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub cmdFermer_Click()
    //
    //Dim response As String
    //  
    //On Error GoTo handler
    //
    //  ' si il y a des modification
    //  If bModif Then
    //    response = MsgBox("§Voulez-vous enregistrer les modifications ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //    Select Case response
    //      Case vbYes
    //        Call EnregistrerCourrier(0)
    //        Unload Me
    //      Case vbNo
    //        Unload Me
    //      Case vbCancel
    //        Exit Sub
    //    End Select
    //  Else
    //    Unload Me
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdFermer_Click dans " & Me.Name
    //End Sub
    //

    /* OK -----------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        EnregistrerCourrier(iModif);

        //passage en modification
        mstrStatutCourrier = "M";
        //mise à jour de l'affichage
        InitialiserFeuille();
        bModif = false;
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub cmdValider_Click()
    //  
    //  On Error GoTo handler
    //  
    //  Call EnregistrerCourrier(iModif)
    //  ' passage en modification
    //  Me.mstrStatutCourrier = "M"
    //  ' mise a jour de l'affichage
    //  Call InitialiserFeuille
    //  bModif = False
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //

    /* OK -----------------------------------------------------------------------*/
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumCourrier == 0)
        {
          MessageBox.Show(Resources.msg_ImpresImp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // une copie client (siege)
        //string[,] TdbGlobal = { { "copie", "2/2  Client" } };

        //frmBrowser f = new frmBrowser();
        //f.ImprimerFichier($"{MozartParams.CheminModeles}{ModuleMain.CodePays(Utils.GetPaysCourrier(miNumCourrier))}{ModuleMain.RechercheModele(mstrTypeCour)}",
        //                    @"\TAttestationOut2.rtf",
        //                    TdbGlobal,
        //                    $"exec api_sp_impAttestation 'CLIENT', {miNumCourrier}");
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TATTESTATION",
          sIdentifiant = $"CLIENT|{miNumCourrier}|2/2  Client",
          InfosMail = $"TCCL|NCLINUM|{miNumCli}",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PRINT",
        }.ShowDialog();
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub cmdImprimer_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error GoTo handler
    //   
    //  If iNumCourrier = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer le courrier§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  ' une copie original
    //  TdbGlobal(0, 0) = "copie"
    //  TdbGlobal(0, 1) = "1/2    Site"
    //  
    //  ImprimerFichier gstrCheminModeles & _
    //                        CodePays(GetPaysCourrier(iNumCourrier)) & RechercheModele(mstrTypeCour), _
    //                       "\TAttestationOut1.rtf", _
    //                       TdbGlobal(), _
    //                       "exec api_sp_impAttestation SITE," & iNumCourrier
    //  
    //  ' une copie client (siege)
    //  TdbGlobal(0, 1) = "2/2  Client"
    //  ImprimerFichier gstrCheminModeles & _
    //                        CodePays(GetPaysCourrier(iNumCourrier)) & RechercheModele(mstrTypeCour), _
    //                       "\TAttestationOut2.rtf", _
    //                       TdbGlobal(), _
    //                       "exec api_sp_impAttestation CLIENT," & iNumCourrier
    //      
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Imprimer dans " & Me.Name
    //End Sub
    //

    /* OK -----------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (miNumCourrier == 0)
      {
        MessageBox.Show(Resources.msg_ImpresImp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      //string[,] TdbGlobal = { { "copie", "1/2    Site" } };

      //frmBrowser f = new frmBrowser();
      //f.mstrType = "ATT" + txtNum.Text;
      //f.msInfosMail = "TCCL|NCLINUM|" + miNumCli;

      //f.Preview_Print($"{MozartParams.CheminModeles}{ModuleMain.CodePays(Utils.GetPaysCourrier(miNumCourrier))}{ModuleMain.RechercheModele(mstrTypeCour)}",
      //                    $@"\{miNumCourrier}_TCourrierOut.rtf",
      //                    TdbGlobal,
      //                    $"exec api_sp_impAttestation SITE, {miNumCourrier}",
      //                    " (Visualisation Attestation)",
      //                    "PREVIEW");
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TATTESTATION",
        sIdentifiant = $"SITE|{miNumCourrier}|1/2  Site",
        InfosMail = $"TCCL|NCLINUM|{miNumCli}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
        strType="ATT",
        numAction = (int) miAction
      }.ShowDialog();
    }

    //Private Sub cmdVisu_Click()
    //  
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //  If iNumCourrier = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer le courrier§", vbInformation
    //    Exit Sub
    //  Else
    //    TdbGlobal(0, 0) = "copie"
    //    TdbGlobal(0, 1) = "1/2     Site"
    //
    //    frmBrowser.bPlanningAn = 0
    //    frmBrowser.mstrType = "ATT" & txtNum
    //    frmBrowser.InfosMail = "TCCL|NCLINUM|" & miNumCli
    //
    //    frmBrowser.Preview_Print gstrCheminModeles & _
    //                              CodePays(GetPaysCourrier(iNumCourrier)) & RechercheModele(mstrTypeCour), _
    //                            "\" & iNumCourrier & "_TCourrierOut.rtf", _
    //                            TdbGlobal(), _
    //                            "exec api_sp_impAttestation SITE," & iNumCourrier, _
    //                            " (Visualisation Attestation)", _
    //                            "PREVIEW"
    //  End If
    //End Sub

    /* OK -----------------------------------------------------------------------*/
    private void frmSaisieAttestation_KeyUp(object sender, KeyEventArgs e)
    {
      bModif = true;
    }
    //Private Sub Form_KeyPress(KeyAscii As Integer)
    //  bModif = True
    //End Sub

    /* OK -----------------------------------------------------------------------*/
    private void EnregistrerCourrier(long Modif)
    {
      try
      {
        // il faut créer un enregistrement pour chaque destinataire
        foreach (DataRow dr in dtLettre.Rows)
          EnregistrerLigne(Convert.ToInt64(dr["IDdest"]), Modif);
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub EnregistrerCourrier(iModif As Long)
    //
    // 
    //On Error GoTo handler
    //  
    //  ' il faut créer un enregistrement pour chaque destinataire
    //  If adoRecordsetLettre.RecordCount > 0 Then adoRecordsetLettre.MoveFirst
    //  
    //  While Not adoRecordsetLettre.EOF
    //    EnregistrerLigne adoRecordsetLettre("IDdest"), iModif
    //    adoRecordsetLettre.MoveNext
    //  Wend
    //         
    //Exit Sub
    //handler:
    //  ShowError "EnregistrerCourrier dans " & Me.Name
    //End Sub

    /* OK -----------------------------------------------------------------------*/
    private void EnregistrerLigne(long iNumDest, long iTypeModif)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_creationAttestation", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iCourrier"].Value = miNumCourrier;
          cmd.Parameters["@Ref"].Value = cboRef.Text;
          cmd.Parameters["@obj"].Value = "Levée de réserves";
          cmd.Parameters["@TypeDest"].Value = mstrTypeDest;
          cmd.Parameters["@TypeCour"].Value = mstrTypeCour;
          cmd.Parameters["@TypeAR"].Value = mstrTypeAR;
          cmd.Parameters["@sCompte"].Value = txtCompte.Text;
          cmd.Parameters["@iDest"].Value = iNumDest;
          cmd.Parameters["@iModif"].Value = iTypeModif;
          cmd.Parameters["@dDate"].Value = DateTime.Now;
          cmd.Parameters["@dDateExec"].Value = txtAction.Tag.ToString() == "" ? DBNull.Value : txtAction.Tag;
          cmd.Parameters["@nbResTot"].Value = txtNbResTot.Text;
          cmd.Parameters["@nbResL"].Value = txtNbResL.Text;
          cmd.Parameters["@nbResAL"].Value = txtNbResAL.Text;
          cmd.Parameters["@nbResALautre"].Value = txtNbResALautre.Text;
          cmd.Parameters["@RMQ"].Value = ModuleMain.ReplaceCharFromBD(txtRMQ.Text, "RTF");
          cmd.Parameters["@iaction"].Value = miAction;
          cmd.Parameters["@cSAS"].Value = "";
          cmd.Parameters["@vsociete"].Value = MozartParams.NomSociete;

          cmd.ExecuteNonQuery();

          miNumCourrier = Convert.ToInt64(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub EnregistrerLigne(iNumDest As Long, iTypeModif As Long)
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
    //  ado_cmd.CommandText = "api_sp_creationAttestation"
    //  ado_cmd.CommandType = adCmdStoredProc
    //   
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //   
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iCourrier").value = iNumCourrier
    //  ado_cmd.Parameters("@Ref").value = cboRef.Text
    //  ado_cmd.Parameters("@obj").value = "Levée de réserves"
    //  ado_cmd.Parameters("@TypeDest").value = mstrTypeDest
    //  ado_cmd.Parameters("@TypeCour").value = mstrTypeCour
    //  ado_cmd.Parameters("@TypeAR").value = mstrTypeAR
    //  ado_cmd.Parameters("@sCompte").value = txtCompte
    //  ado_cmd.Parameters("@iDest").value = iNumDest
    //  ado_cmd.Parameters("@iModif").value = iTypeModif
    //  ado_cmd.Parameters("@dDate").value = Date
    //  ado_cmd.Parameters("@dDateExec").value = IIf(txtAction.Tag = "", Null, txtAction.Tag)
    //  ado_cmd.Parameters("@nbResTot").value = txtNbResTot
    //  ado_cmd.Parameters("@nbResL").value = txtNbResL
    //  ado_cmd.Parameters("@nbResAL").value = txtNbResAL
    //  ado_cmd.Parameters("@nbResALautre").value = txtNbResALautre
    //  ado_cmd.Parameters("@RMQ").value = ReplaceCharToBD(txtRMQ, "RTF")
    //  ado_cmd.Parameters("@iaction").value = iAction
    //  ado_cmd.Parameters("@cSAS").value = "" 'IIf(bSas, "S", "")
    //  ado_cmd.Parameters("@vsociete").value = gstrNomSociete  'Temp = "GROUPE", sLibNomSoc, gstrNomSocieteTemp)
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //
    //  ' récupération du numéro crée
    //  iNumCourrier = ado_cmd.Parameters(0).value
    //  
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //      
    //Exit Sub
    //handler:
    //  ShowError "EnregistrerLigne dans " & Me.Name
    //End Sub
    //

    /* OK -----------------------------------------------------------------------*/
    private void InitialiserFeuille()
    {
      try
      {
        // recherche des infos du contrat
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_RetourInfoCourrier {miNumCourrier}, 0, '{MozartParams.NomSociete}'"))
        {
          if (sdr.Read())
          {
            txtCompte.Text = Utils.BlankIfNull(sdr["NCOURCTE"]);
            txtNum.Text = Utils.BlankIfNull(sdr["NCOURNUM"]);
            txtNbResTot.Text = Utils.BlankIfNull(sdr["VCOURNBRESTOT"]);
            txtNbResAL.Text = Utils.BlankIfNull(sdr["VCOURNBRESAL"]);
            txtNbResALautre.Text = Utils.BlankIfNull(sdr["VCOURNBRESALAUTRE"]);
            txtNbResL.Text = Utils.BlankIfNull(sdr["VCOURNBRESL"]);
            txtRMQ.Text = ModuleMain.ReplaceCharFromBD(Utils.BlankIfNull(sdr["VCOURRMQ"]), "RTF");

            cboRef.Text = Utils.BlankIfNull(sdr["VCOURREF"]);
            if (cboRef.SelectedIndex == -1)
            {
              // ajouter ce contact à la combo
              cboRef.Items.Add(Utils.BlankIfNull(sdr["VCOURREF"]));
              cboRef.Text = Utils.BlankIfNull(sdr["VCOURREF"]);
            }

            //  info sur le site
            using (SqlDataReader sdrInfo = ModuleData.ExecuteReader($"exec api_sp_InfoSiteAttestation {sdr["NCOURIDDEST"]}"))
            {
              if (sdrInfo.Read())
              {
                txtCli.Text = Utils.BlankIfNull(sdrInfo["VCLINOM"]);
                txtContactCli.Text = Utils.BlankIfNull(sdrInfo["VCCLNOM"]);
                txtSite.Text = Utils.BlankIfNull(sdrInfo["VSITNOM"]);
                txtRespSite.Text = Utils.BlankIfNull(sdrInfo["VSITRES"]);
                miNumCli = Convert.ToInt32(sdrInfo["NCLINUM"]);
              }
            }

            AjouterEnreg(Convert.ToInt64(sdr["NCOURIDDEST"]), mstrTypeDest);

            while (sdr.Read())
              AjouterEnreg(Convert.ToInt64(sdr["NCOURIDDEST"]), mstrTypeDest);
          }
          Cursor = Cursors.Default;

          // pas encore de modification
          bModif = false;
          iModif = 0;
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub InitialiserFeuille()
    //
    //Dim rsInfo As ADODB.Recordset
    //On Error GoTo handler
    //
    //  ' recherche des info du contrat
    //  Set rsC = New ADODB.Recordset
    //  rsC.Open "api_sp_RetourInfoCourrier " & iNumCourrier & " , 0, '" & gstrNomSociete & "'", cnx
    //  
    //  'les infos de la feuille
    //  txtCompte = BlankIfNull(rsC("NCOURCTE"))
    //  txtNum = rsC("NCOURNUM")
    //  txtNbResTot = BlankIfNull(rsC("VCOURNBRESTOT"))
    //  txtNbResAL = BlankIfNull(rsC("VCOURNBRESAL"))
    //  txtNbResALautre = BlankIfNull(rsC("VCOURNBRESALAUTRE"))
    //  txtNbResL = BlankIfNull(rsC("VCOURNBRESL"))
    //  txtRMQ = ReplaceCharFromBD(BlankIfNull(rsC("VCOURRMQ")), "RTF")
    //  
    //  ' cbo ref
    //  On Error Resume Next
    //  cboRef.Text = BlankIfNull(rsC("VCOURREF"))
    //  If Err Then
    //    ' ajouter ce contrat a la combo
    //    cboRef.AddItem BlankIfNull(rsC("VCOURREF"))
    //    cboRef.Text = BlankIfNull(rsC("VCOURREF"))
    //    Err.Clear
    //  End If
    //  Err.Clear
    //  
    //  ' info sur le site
    //  ' ouverture du recordset
    //  Set rsInfo = New ADODB.Recordset
    //  rsInfo.Open "exec api_sp_InfoSiteAttestation " & rsC("NCOURIDDEST"), cnx
    //
    //  txtCli = BlankIfNull(rsInfo("VCLINOM"))
    //  txtContactCli = BlankIfNull(rsInfo("VCCLNOM"))
    //  txtSite = BlankIfNull(rsInfo("VSITNOM"))
    //  txtRespSite = BlankIfNull(rsInfo("VSITRES"))
    //  miNumCli = rsInfo("NCLINUM")
    //  
    //  rsInfo.Close
    //  
    //  ' remplir le recordset des destinataires
    //  InitRecordset
    //  While Not rsC.EOF
    //    AjouterEnreg rsC("NCOURIDDEST"), mstrTypeDest
    //    rsC.MoveNext
    //  Wend
    //  
    //  rsC.Close
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //  ' pas encore de modification
    //  bModif = False
    //  iModif = 0
    //  
    // 
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " initialiserFeuille dans " & Me.Name
    //End Sub

    /* OK -----------------------------------------------------------------------*/
    private void InitialiserFeuilleVide()
    {
      //numéro de courrier
      txtNum.Text = "0";

      using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec api_sp_InfoSiteAttestation {dtLettre.Rows[0]["IDdest"]}"))
      {
        if (sdr.Read())
        {
          txtCli.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
          txtContactCli.Text = Utils.BlankIfNull(sdr["VCCLNOM"]);
          txtSite.Text = Utils.BlankIfNull(sdr["VSITNOM"]);
          txtRespSite.Text = Utils.BlankIfNull(sdr["VSITRES"]);
          miNumCli = Convert.ToInt32(sdr["NCLINUM"]);
        }
      }

      //pas encore de modification
      bModif = false;
    }

    //Private Sub InitialiserFeuilleVide()
    // 
    //On Error GoTo handler
    //  
    //  ' numéro de courrier
    //  txtNum = 0
    //  
    //  adoRecordsetLettre.MoveFirst
    //  
    //  ' ouverture du recordset
    //  Set rsInfo = New ADODB.Recordset
    //  rsInfo.Open "exec api_sp_InfoSiteAttestation " & adoRecordsetLettre("IDDEST"), cnx
    //
    //  txtCli = BlankIfNull(rsInfo("VCLINOM"))
    //  txtContactCli = BlankIfNull(rsInfo("VCCLNOM"))
    //  txtSite = BlankIfNull(rsInfo("VSITNOM"))
    //  txtRespSite = BlankIfNull(rsInfo("VSITRES"))
    //  miNumCli = rsInfo("NCLINUM")
    //  
    //  rsInfo.Close
    //  
    //  ' pas encore de modification
    //  bModif = False
    //  
    //  
    //Exit Sub
    //handler:
    //  ShowError " initialiserFeuilleVide dans " & Me.Name
    //End Sub

    /* OK -----------------------------------------------------------------------*/
    /*
    public void InitRecordset()
    {
      try
      {
        if (firstTimeRS)
        {
          dtLettre.Columns.Add("TypeDest", typeof(string));
          dtLettre.Columns.Add("IDdest", typeof(int));

          firstTimeRS = false;
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }*/
    // voir load
    //Public Sub InitRecordset()
    //
    //On Error GoTo handler
    //
    //  ' initialisation du tableau de recherche des articles
    //  Set adoRecordsetLettre = New ADODB.Recordset
    //  
    //  ' ajout des champs au recordset
    //  adoRecordsetLettre.Fields.Append "IDdest", adBigInt
    //  adoRecordsetLettre.Fields.Append "TypeDest", adVarChar, 50
    //  
    //  ' ouverture
    //  adoRecordsetLettre.Open , , adOpenDynamic, adLockOptimistic
    //    
    //Exit Sub
    //handler:
    //  ShowError "InitRecordset dans " & Me.Name
    //End Sub
    //

    /* OK -----------------------------------------------------------------------*/
    private void AjouterEnreg(long iNumDest, string sTypeDest)
    {
      try
      {
        DataRow newrow = dtLettre.NewRow();
        newrow["TypeDest"] = sTypeDest;
        newrow["IDdest"] = iNumDest;

        dtLettre.Rows.Add(newrow);
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    //Private Sub AjouterEnreg(iNumDest As Long, sTypeDest As String)
    //
    //On Error GoTo handler
    //    adoRecordsetLettre.AddNew
    //    adoRecordsetLettre("TypeDest").value = sTypeDest
    //    adoRecordsetLettre("IDdest").value = iNumDest
    //    
    //    adoRecordsetLettre.Update
    //Exit Sub
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    /* OK -----------------------------------------------------------------------*/
    private void txtAll_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    //Private Sub txtcompte_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtNbResAL_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtNbResL_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtNbResTot_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
  }
}