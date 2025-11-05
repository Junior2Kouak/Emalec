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
  public partial class frmDetailsSite : Form
  {
    public string mstrStatut = "";
    public int miNumSite;
    public int miNumClient;

    DataTable dtContSit = new DataTable();

    public frmDetailsSite() { InitializeComponent(); }

    private void frmDetailsSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // chargement de toutes les combos
        ModuleData.RemplirCombo(cboRespReg, $"select NCCLNUM, VCCLNOM from TCCL where   TCCL.NCLINUM = {miNumClient} order by VCCLNOM");
        cboRespReg.ValueMember = "NCCLNUM";
        cboRespReg.DisplayMember = "VCCLNOM";
        ModuleData.RemplirCombo(cboRespMaint, $"select NCCLNUM, VCCLNOM from TCCL where   TCCL.NCLINUM = {miNumClient} order by VCCLNOM");
        cboRespMaint.ValueMember = "NCCLNUM";
        cboRespMaint.DisplayMember = "VCCLNOM";
        ModuleData.RemplirCombo(CboRespSect, $"select NCCLNUM, VCCLNOM from TCCL where   TCCL.NCLINUM = {miNumClient} order by VCCLNOM");
        CboRespSect.ValueMember = "NCCLNUM";
        CboRespSect.DisplayMember = "VCCLNOM";

        ModuleData.RemplirCombo(cboFact, $"select NRSFNUM, VRSFRSF from TRSF where  NCLINUM = {miNumClient} and (NRSFSITNUM = {miNumSite} OR NRSFSITNUM is null) and CRSFACTIF='O' order by VRSFRSF");
        cboFact.ValueMember = "NRSFNUM";
        cboFact.DisplayMember = "VRSFRSF";
        ModuleData.RemplirCombo(cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";
        ModuleData.RemplirCombo(cboType, $"select NTYPESITE, VLIBTYPESITE from TREF_TYPESITE WHERE LANGUE='{MozartParams.Langue}' order by VLIBTYPESITE");
        cboType.ValueMember = "NTYPESITE";
        cboType.DisplayMember = "VLIBTYPESITE";

        RemplirComboTech();

        // traitement du cas de modification ou de création
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
          OuvertureEnModification();

        // code pour le client MediaPost
        // TB SAMSIC CITY SPEC
        FrameMediaPoste.Visible = (miNumClient == 12015 && MozartParams.NomGroupe == "EMALEC");

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    void RemplirComboTech()
    {
      ModuleData.RemplirCombo(cboTech, $"select npernum, vpernom + ' ' + vperpre AS PERNOM from tper where cperactif = 'O' and cpertyp in ('TE', 'CA', 'AS', 'AA', 'CO', 'BE', 'CT') " +
                                 $"AND VSOCIETE = App_Name() and npernum not in (select npernum from ttechsite where nsitnum = {miNumSite})  order by vpernom + ' ' + VPERPRE", true);
      cboTech.ValueMember = "npernum";
      cboTech.DisplayMember = "PERNOM";
    }

    /*--------------------------------------------------------------*/
    //Dim adoRSContSit As ADODB.Recordset
    //' UPGRADE_INFO (#0501): The 'iNumChefCuis' member isn't used anywhere in current application.
    //' Dim iNumChefCuis As Long
    //Dim iCal As Integer
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //  On Error GoTo handler
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  ' chargement de toutes les combos
    //  RemplirCombo cboRespReg, "select NCCLNUM, VCCLNOM from TCCL where   TCCL.NCLINUM = " & miNumClient & " order by VCCLNOM"
    //  RemplirCombo cboRespMaint, "select NCCLNUM, VCCLNOM from TCCL where  TCCL.NCLINUM = " & miNumClient & " order by VCCLNOM"
    //  RemplirCombo CboRespSect, "select NCCLNUM, VCCLNOM from TCCL where  TCCL.NCLINUM = " & miNumClient & " order by VCCLNOM"
    //  RemplirCombo cboFact, "select TRSF.NRSFNUM, VRSFRSF from TRSF where  TRSF.NCLINUM = " & miNumClient & " and (NRSFSITNUM = " & miNumSite & " OR NRSFSITNUM is null) and CRSFACTIF='O'  order by VRSFRSF"
    //  RemplirCombo cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM"
    //  RemplirCombo cboType, "select NTYPESITE, VLIBTYPESITE from TREF_TYPESITE WHERE LANGUE='" & gstrLangue & "' order by VLIBTYPESITE"
    //  
    //  RemplirCombo cboTech, "select npernum, vpernom + ' ' + vperpre from tper where cperactif = 'O' and cpertyp in ('TE', 'CA', 'AS', 'AA', 'CO', 'BE', 'CT') AND VSOCIETE = App_Name() and npernum not in (select npernum from ttechsite where nsitnum = " & miNumSite & ")  order by vpernom + ' ' + VPERPRE", , True
    //   
    //  'remplissage de la liste des contact du site
    //  Set adoRSContSit = New ADODB.Recordset
    //    
    //  ' traitement du cas de modification ou de création
    //  If Me.mstrStatut = "C" Then
    //    OuvertureEnCreation
    //  Else
    //    OuvertureEnModification
    //  End If
    //  
    //  ' code pour le client MediaPost
    //  ' TB SAMSIC CITY SPEC
    //  If miNumClient = 12015 And gstrNomGroupe = "EMALEC" Then
    //    FrameMediaPoste.Visible = True
    //  Else
    //    FrameMediaPoste.Visible = False
    //  End If
    //  
    //  InitApigrid
    //   
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void InitVillesCibles()
    {
      ModuleData.RemplirCombo(cboVillesCibles, $"SELECT ID, VILLE FROM TVILLES WHERE PAYS = '{cboPays.Text}' ORDER BY VILLE");
      cboVillesCibles.ValueMember = "ID";
      cboVillesCibles.DisplayMember = "VILLE";
    }
    //Private Sub InitVillesCibles()
    //  
    //  Dim adoRs As Recordset
    //  Set adoRs = New Recordset
    //  
    //  On Error GoTo handler
    //  
    //  cboVillesCibles.Clear
    //  cboVillesCibles.AddItem ""
    //  cboVillesCibles.ItemData(0) = "0"
    //  
    //  adoRs.Open "SELECT ID, VILLE FROM TVILLES WHERE PAYS = '" & cboPays.Text & "' ORDER BY VILLE", cnx, adOpenStatic, adLockOptimistic
    //  If adoRs.EOF Then Exit Sub
    //  
    //  Dim i As Integer
    //  i = 1
    //  While Not adoRs.EOF
    //    cboVillesCibles.AddItem adoRs!ville
    //    cboVillesCibles.ItemData(i) = adoRs!ID
    //    adoRs.MoveNext
    //    i = i + 1
    //  Wend
    //  adoRs.Close
    //  cboVillesCibles.ListIndex = 0
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitVillesCibles"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboPays_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (cboPays.Text.ToUpper() != "FRANCE")
        InitVillesCibles();
      Image1.Visible = cboVillesCibles.Visible = LabelVilleCible.Visible = (cboPays.Text.ToUpper() != "FRANCE");
    }
    //Private Sub cboPays_Validate(Cancel As Boolean)
    //  If UCase(cboPays.Text) <> "FRANCE" Then
    //    InitVillesCibles
    //    LabelVilleCible.Visible = True
    //    cboVillesCibles.Visible = True
    //    Image1.Visible = True
    //  Else
    //    LabelVilleCible.Visible = False
    //    cboVillesCibles.Visible = False
    //    Image1.Visible = False
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdGaran_Click(object sender, EventArgs e)
    {
      new frmGestSitesGaranties { iNumSite = miNumSite, sNomSite = txtNom.Text }.ShowDialog();
    }
    //Private Sub CmdGaran_Click()
    //    frmGestSitesGaranties.iNumsite = miNumSite
    //    frmGestSitesGaranties.sNomSite = txtNom.Text
    //    frmGestSitesGaranties.Show vbModal
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        // test du nom
        if (txtNom.Text == "")
        {
          MessageBox.Show(Resources.msg_Saisir_nom_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNom.Focus();
          return;
        }
        // recherche si le nom du site n'est pas un doublon ( uniquement sur la création )
        if (mstrStatut == "C" && NomExist(txtNom.Text.Replace("'", "''")))
        {
          MessageBox.Show(Resources.msg_saisir_autre_nom_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNom.Focus();
          return;
        }
        // test du numéro
        if (txtNum.Text == "")
        {
          MessageBox.Show(Resources.saisir_numero_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtNum.Focus();
          return;
        }
        // test du type de site
        if (cboType.Text == "")
        {
          MessageBox.Show(Resources.msg_select_type_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // test de la sélection d'un pays
        if (cboPays.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_pays, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (cboPays.Text == "FRANCE")
        {
          // test de la sélection d'une ville
          if (cboVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          // region emalec
          if (cboRegEma.Text == "")
          {
            MessageBox.Show(Resources.msg_select_departement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        else
        {
          if (cboVillesCibles.Text == "")
          {
            MessageBox.Show("Sélectionnez une ville cible", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          if (txtVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        // facturation
        if (cboFact.Text == "")
        {
          MessageBox.Show(Resources.msg_select_raison_sociale_facturation, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        // responsable maintenance
        if (cboRespMaint.Text == "")
        {
          MessageBox.Show(Resources.msg_select_responsable_maintenance, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (chkGestPrevExtinct.Checked && (txtExtinctDate.Text == "" || txtExtinctCertif.Text == ""))
        {
          MessageBox.Show("Le numéro et la date du certificat sont obligatoires!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          FrameExtinct.Visible = true;
          return;
        }

        Enregistrer();

        // on passe la feuille en statut modifier
        mstrStatut = "M";

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdEnregistrer_Click()
    // 
    //On Error GoTo handler
    //
    //  ' test du nom
    //  If txtNom.Text = "" Then
    //    MsgBox "§Saisissez un nom de site§"
    //    txtNom.SetFocus
    //    Exit Sub
    //  End If
    //  
    //    ' recherche si le nom du site n'est pas un doublon ( uniquement sur la création )
    //  If NomExist(Replace(txtNom.Text, "'", "''")) And mstrStatut = "C" Then
    //    MsgBox "§Saisissez un autre nom de site car celui-là existe déjà.§"
    //    txtNom.SetFocus
    //    Exit Sub
    //  End If
    //
    //  ' test du numéro
    //  If txtNum.Text = "" Then
    //    MsgBox "§Saisissez un numéro de site§"
    //    txtNum.SetFocus
    //    Exit Sub
    //  End If
    //  
    //  ' test du type de site
    //  If cboType.Text = "" Then
    //    MsgBox "§Sélectionnez un type de site§"
    //    Exit Sub
    //  End If
    //  
    //  
    //  ' test de la sélection d'un pays
    //  If cboPays.Text = "" Then
    //    MsgBox "§Sélectionnez un pays§"
    //    Exit Sub
    //  End If
    //  
    //  
    //  If cboPays.Text = "FRANCE" Then
    //    ' test de la sélection d'une ville
    //    If cboVille.Text = "" Then
    //      MsgBox "§Sélectionnez une ville§"
    //      Exit Sub
    //    End If
    //    ' region emalec
    //    If cboRegEma.Text = "" Then
    //      MsgBox "§Sélectionnez un département§"
    //      Exit Sub
    //    End If
    //
    //  Else
    //    If cboVillesCibles.Text = "" Then
    //      MsgBox "Sélectionnez une ville cible"
    //      Exit Sub
    //    End If
    //    
    //    If txtVille.Text = "" Then
    //      MsgBox "§Sélectionnez une ville§"
    //      Exit Sub
    //    End If
    //  End If
    //  
    //  ' facturation
    //  If cboFact.Text = "" Then
    //      MsgBox "§Sélectionnez une raison sociale de facturation§"
    //      Exit Sub
    //  End If
    //    
    //  ' responsable maintenance
    //  If cboRespMaint.Text = "" Then
    //      MsgBox "§Sélectionnez un responsable de maintenance§"
    //      Exit Sub
    //  End If
    //  
    //'  If txtMail <> "" Then
    //'    If InStr(txtMail, " ") > 0 Or InStr(txtMail, "@") = 0 Or InStr(txtMail, ".") = 0 Then
    //'      MsgBox "§Adresse courriel invalide§", vbExclamation
    //'      Exit Sub
    //'    End If
    //'  End If
    //
    //    If chkGestPrevExtinct.value = Checked Then
    //        If BlankIfNull(txtExtinctDate) = "" Or BlankIfNull(txtExtinctCertif) = "" Then
    //            MsgBox "Le numéro et la date du certificat sont obligatoires!", vbExclamation
    //            FrameExtinct.Visible = True
    //            Exit Sub
    //        End If
    //    End If
    //    
    //  Call Enregistrer
    //                     
    //  ' on passe la feuille en statut modifier
    //  Me.mstrStatut = "M"
    //   
    //  Call OuvertureEnModification
    //  
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCopieSite_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0) return;
      new frmGestSiteLie(miNumSite).ShowDialog();
    }
    //Private Sub cmdCopieSite_Click()
    //    If miNumSite = 0 Then Exit Sub
    //    
    //    VerifMOZARTNET
    //  
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmGestSiteLie" & " " & miNumSite, vbNormalFocus
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCompteurs_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0) return;
      new frmListeCompteursSite(miNumSite).ShowDialog();
    }
    //Private Sub cmdCompteurs_Click()
    //   If miNumSite = 0 Then Exit Sub
    //    
    //    VerifMOZARTNET
    //  
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "frmListeCompteursSite" & " " & miNumSite, vbNormalFocus
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdExtinctInc_Click(object sender, EventArgs e)
    {
      FrameExtinct.Visible = true;
      FrameExtinct.BringToFront();
    }
    //Private Sub CmdExtinctInc_Click()
    //    FrameExtinct.Visible = True
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdValidExtinct_Click(object sender, EventArgs e)
    {
      if (VerifChampExtinct()) FrameExtinct.Visible = false;
    }
    //Private Sub CmdValidExtinct_Click()
    //    If VerifChampExtinct = True Then FrameExtinct.Visible = False
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdCloseFrameExtinct_Click(object sender, EventArgs e)
    {
      if (VerifChampExtinct()) FrameExtinct.Visible = false;
    }
    //Private Sub CmdCloseFrameExtinct_Click()
    //    If VerifChampExtinct = True Then FrameExtinct.Visible = False
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    bool VerifChampExtinct()
    {
      if (txtExtinctDate.Text != "" && !DateTime.TryParse(txtExtinctDate.Text, out DateTime d))
      {
        MessageBox.Show(Resources.msg_format_date_Certificat_Extincteur_incorrect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      return true;
    }
    //Private Function VerifChampExtinct() As Boolean
    //
    //    If txtExtinctDate.Text <> "" Then
    //        If IsDate(txtExtinctDate.Text) = False Then
    //            MsgBox "§le format de date du Certificat Extincteur n'est pas correcte !§"
    //            VerifChampExtinct = False
    //        Else
    //            VerifChampExtinct = True
    //        End If
    //    
    //    Else
    //        VerifChampExtinct = True
    //    End If
    //
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    // => CmdDate_Click
    //Private Sub CmdAddDateExtinct_Click()
    //  iCal = 1
    //  If CalExtinct.Visible Then
    //    CalExtinct.Visible = False
    //  Else
    //    CalExtinct.Visible = True
    //    CalExtinct.value = Now
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdSuppDateExtinct_Click(object sender, EventArgs e)
    {
      txtExtinctDate.Text = "";
    }
    //Private Sub CmdSuppDateExtinct_Click()
    //    txtExtinctDate.Text = ""
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => CmdDate_Click
    //Private Sub CmdAddDateDer_Click()
    //  iCal = 2
    //  If CalExtinct.Visible Then
    //    CalExtinct.Visible = False
    //  Else
    //    CalExtinct.Visible = True
    //    CalExtinct.value = Now
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdSuppDateDer_Click(object sender, EventArgs e)
    {
      txtDerVisite.Text = "";
    }
    //Private Sub CmdSuppDateDer_Click()
    //    txtExtinctDate.Text = ""
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      CalExtinct.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "CmdAddDateExtinct")
      {
        txtDate = txtExtinctDate.Text;
        CalExtinct.Tag = 0;
      }
      else
      {
        txtDate = txtDerVisite.Text;
        CalExtinct.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = CalExtinct.Value = d;
      else { _curDate = DateTime.MinValue; CalExtinct.Value = DateTime.Now; }

      CalExtinct.Visible = true;
      CalExtinct.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void CalExtinct_CloseUp(object sender, EventArgs e)
    {
      CalExtinct.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)CalExtinct.Tag == 0) txtExtinctDate.Text = CalExtinct.Value.ToShortDateString();
      else if ((int)CalExtinct.Tag == 1) txtDerVisite.Text = CalExtinct.Value.ToShortDateString();
    }
    private void CalExtinct_ValueChanged(object sender, EventArgs e)
    {
      if (CalExtinct.Visible) _curDate = CalExtinct.Value;
    }
    //Private Sub CalExtinct_Click()
    //    If iCal = 1 Then txtExtinctDate.Text = CalExtinct.value
    //    If iCal = 2 Then txtDerVisite.Text = CalExtinct.value
    //    
    //    CalExtinct.Visible = False
    //End Sub
    /* --------------------------------------------------------------------------------------- */
    private void frmDetailsSite_FormClosed(object sender, FormClosedEventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal { ControlCible1 = txtCP, ControlCible2 = cboVille }.ShowDialog();
    }
    //Private Sub cmdRecherche_Click()
    //  Set frmRechCodePostal.ControlCible1 = txtCP
    //  Set frmRechCodePostal.ControlCible2 = cboVille
    //  frmRechCodePostal.Show vbModal
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateCre.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateCre.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    //Private Sub cmdDate1_Click()
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDateCre.Text = "";
    }
    //Private Sub cmdSupp1_Click()
    //  Me.txtDateCre = ""
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Calendar1_Click()
    //  Me.txtDateCre = Calendar1.value
    //  Calendar1.Visible = False
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    void OuvertureEnCreation()
    {
      try
      {
        // renseignement de la partie client => inutile ici
        cboPays.Text = "FRANCE";
        InitVillesCibles();

        cboPays_SelectedValueChanged(null, null);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub OuvertureEnCreation()
    //
    //Dim c As Object
    //
    //On Error GoTo handler
    //
    //  ' renseignement de la partie client
    //  For Each c In Me.Controls
    //    If TypeOf c Is TextBox Then c.Text = ""
    //  Next
    //  
    //  cboPays.Text = "FRANCE"
    //  InitVillesCibles
    //'  cboCiv.Text = "M."
    //'  cboCivCC.Text = "M."
    //  
    //Exit Sub
    //handler:
    //  ShowError "OuvertureEnCreation dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void OuvertureEnModification()
    {
      try
      {
        // recherche des informations de l'action
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from api_v_InfoSite where NSITNUM = {miNumSite}"))
        {
          if (!reader.Read()) return;

          txtNom.Text = Utils.BlankIfNull(reader["VSITNOM"]);
          txtNum.Text = Utils.BlankIfNull(reader["NSITNUE"]);
          txtEnseigne.Text = Utils.BlankIfNull(reader["VSITENSEIGNE"]);

          txtAD1.Text = Utils.BlankIfNull(reader["VSITAD1"]);
          txtAD2.Text = Utils.BlankIfNull(reader["VSITAD2"]);
          txtCP.Text = Utils.BlankIfNull(reader["VSITCP"]);
          txtVille.Text = Utils.BlankIfNull(reader["VSITVIL"]);
          txtCPCedex.Text = Utils.BlankIfNull(reader["VSITCPCEDEX"]);
          txtCedex.Text = Utils.BlankIfNull(reader["VSITCEDEX"]);

          // num site spéciaux (médiaposte)
          txtMS.Text = Utils.BlankIfNull(reader["VNUMCODEMS"]);
          txtMF.Text = Utils.BlankIfNull(reader["VNUMCODEMF"]);
          txtMC.Text = Utils.BlankIfNull(reader["VNUMCODEMC"]);
          txtMM.Text = Utils.BlankIfNull(reader["VNUMCODEMM"]);
          TxtML.Text = Utils.BlankIfNull(reader["VNUMCODEML"]);

          txtRegCli.Text = Utils.BlankIfNull(reader["VSITREG"]);

          txtConcept.Text = Utils.BlankIfNull(reader["VSITCONCEPT"]);
          txtHoraires.Text = Utils.BlankIfNull(reader["VSITHOR"]).Replace("\n", "\r\n");

          txtNbNiveau.Text = ((int)Utils.ZeroIfNull(reader["NSITNBNIVO"])).ToString();
          txtSurf.Text = ((int)Utils.ZeroIfNull(reader["NSITSFV"])).ToString();
          txtDateCre.Text = Utils.DateBlankIfNull(reader["DSITDCREMAG"]);
          optPart0.Checked = Utils.BlankIfNull(reader["CSITPART"]) == "O";
          optJur0.Checked = Utils.BlankIfNull(reader["CSITSTATJUR"]) == "L";
          optJur1.Checked = Utils.BlankIfNull(reader["CSITSTATJUR"]) == "P";

          txtServTech.Tag = (int)Utils.ZeroIfNull(reader["NSERVTECHNUM"]);
          txtServTech.Text = Utils.BlankIfNull(reader["VSERVTECHNOM"]);
          txtNbOcup.Text = ((int)Utils.ZeroIfNull(reader["NSITNBOCUP"])).ToString();

          txtNbSSSites.Text = ((int)Utils.ZeroIfNull(reader["NSITSFR"])).ToString();

          //txtNbCouvert.Text = ((int)Utils.ZeroIfNull(reader["NSITNBCOUVERT"])).ToString();
          txtNbChambre.Text = ((int)Utils.ZeroIfNull(reader["NSITNBCHAMBRE"])).ToString();

          txtCodImpl.Text = Utils.BlankIfNull(reader["VCODIMPL"]);

          if (Utils.ZeroIfNull(reader["COMSECU"]) > 0)
            cmdComSec.BackColor = MozartColors.ColorH80FFFF;
          else
            cmdComSec.BackColor = MozartColors.ColorH8000000F;

          // combo du type de site
          cboType.SelectedValue = (int)Utils.ZeroIfNull(reader["NSITTYPE"]);

          // combo de la ville
          string ville = Utils.BlankIfNull(reader["VSITVIL"]);
          cboVille.Text = ville;
          if (cboVille.SelectedIndex == -1)
          {
            cboVille.Items.Add(ville);
            cboVille.Text = ville;
          }

          // combo du pays
          string pays = Utils.BlankIfNull(reader["VSITPAYS"]);
          cboPays.Text = pays;
          if (cboPays.SelectedIndex == -1)
          {
            cboPays.Items.Add(pays);
            cboPays.Text = pays;
          }

          // Combo ville cible NL 19/04/2016
          InitVillesCibles();
          cboVillesCibles.SelectedValue = (int)Utils.ZeroIfNull(reader["NVILLECIBLE"]);
          if (cboPays.Text != "FRANCE")
            Image1.Visible = cboVillesCibles.Visible = LabelVilleCible.Visible = true;

          ModuleData.RemplirCombo(cboRegEma, $"select NREGCOD, VDEPLIB from TREF_REG, tpays where TREF_REG.npaysnum = tpays.npaysnum and tpays.vpaysnom ='{reader["VSITPAYS"]}' order by VDEPLIB");
          cboRegEma.ValueMember = "NREGCOD";
          cboRegEma.DisplayMember = "VDEPLIB";

          // combo de la region emalec
          cboRegEma.SelectedValue = (int)Utils.ZeroIfNull(reader["NREGCOD"]);
          // combo de la facturation
          cboFact.SelectedValue = (int)Utils.ZeroIfNull(reader["NRSFNUM"]);
          // combo du responsable régionale
          cboRespReg.SelectedValue = (int)Utils.ZeroIfNull(reader["NSITRESPREG"]);
          // combo du responsable maintenance
          cboRespMaint.SelectedValue = (int)Utils.ZeroIfNull(reader["NSITRESPMAINT"]);
          // combo du responsable secteur
          CboRespSect.SelectedValue = (int)Utils.ZeroIfNull(reader["NSITRESPSECT"]);

          // combo de la duree de garantie
          cboGarantie.Text = ((int)Utils.ZeroIfNull(reader["NSITGARANTIE"])).ToString();

          chkSitPrio.Checked = Utils.ZeroIfNull(reader["NSITPRIO"]) == 1;
          chkSiteJO.Checked = Utils.ZeroIfNull(reader["NSITNBCOUVERT"]) == 1;

          // extincteur
          txtExtinctCertif.Text = Utils.BlankIfNull(reader["VSITEXTCERT"]);
          txtExtinctDate.Text = Utils.BlankIfNull(reader["DSITEXTCERT"]);
          txtDerVisite.Text = Utils.BlankIfNull(reader["DSITEXTDERVIS"]);
          txtExtCaracteristique.Text = Utils.BlankIfNull(reader["VSITEXTCARACT"]);
          txtExtParticularite.Text = Utils.BlankIfNull(reader["VSITEXTPART"]);
          chkGestPrevExtinct.Checked = !(Utils.BlankIfNull(reader["CCLIGESTPEXTINCT"]) == "" || Utils.BlankIfNull(reader["CCLIGESTPEXTINCT"]) == "N");

          ChkPerPoste.Checked = Utils.ZeroIfNull(reader["BSITPERPOSTE"]) == 1;

          TxtSecteur.Text = Utils.BlankIfNull(reader["VSITSECTEUR"]);

          // gestion couleur bouton
          if (DocInterneExist()) CmdDocInt.BackColor = MozartColors.ColorH80FFFF;

          InitListeImp();
          InitListeInt();

          apiTGridContSit.LoadData(dtContSit, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeContactSite {miNumSite}");
          apiTGridContSit.GridControl.DataSource = dtContSit;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    void Enregistrer()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // pour la création ou la modification, c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationSite", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          cmd.Parameters["@iNum"].Value = miNumSite;   // 0 si création
          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@vNom"].Value = txtNom.Text;
          cmd.Parameters["@vNum"].Value = txtNum.Text;
          cmd.Parameters["@nTypeSite"].Value = cboType.SelectedValue;
          cmd.Parameters["@vEnseigne"].Value = txtEnseigne.Text;

          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;
          cmd.Parameters["@vCpCedex"].Value = txtCPCedex.Text == "" ? DBNull.Value : (object)txtCPCedex.Text;
          cmd.Parameters["@vCedex"].Value = txtCedex.Text == "" ? DBNull.Value : (object)txtCedex.Text;

          cmd.Parameters["@vRegCli"].Value = txtRegCli.Text;
          cmd.Parameters["@iRegEma"].Value = (cboRegEma.SelectedValue == null) ? 0 : cboRegEma.SelectedValue;
          cmd.Parameters["@cPart"].Value = optPart0.Checked ? "O" : "N";
          cmd.Parameters["@cJur"].Value = optJur0.Checked ? "L" : optJur1.Checked ? (object)"P" : DBNull.Value;

          cmd.Parameters["@iRespReg"].Value = (int)cboRespReg.SelectedValue == 0 ? DBNull.Value : cboRespReg.SelectedValue;
          cmd.Parameters["@iRespMaint"].Value = (int)cboRespMaint.SelectedValue == 0 ? DBNull.Value : cboRespMaint.SelectedValue;
          cmd.Parameters["@iRespSect"].Value = (int)CboRespSect.SelectedValue == 0 ? DBNull.Value : CboRespSect.SelectedValue;

          cmd.Parameters["@iFact"].Value = cboFact.SelectedValue;

          cmd.Parameters["@nSurface"].Value = txtSurf.Text == "" ? 0 : Convert.ToInt32(txtSurf.Text);
          cmd.Parameters["@dDatecre"].Value = (txtDateCre.Text != "") ? (object)Convert.ToDateTime(txtDateCre.Text) : DBNull.Value;

          cmd.Parameters["@vConcept"].Value = txtConcept.Text == "" ? DBNull.Value : (object)txtConcept.Text;
          cmd.Parameters["@vHoraires"].Value = txtHoraires.Text == "" ? DBNull.Value : (object)txtHoraires.Text;

          cmd.Parameters["@nServTechNum"].Value = txtServTech.Text == "" ? DBNull.Value : txtServTech.Tag;
          cmd.Parameters["@nNbOcup"].Value = txtNbOcup.Text == "" ? 0 : Convert.ToInt32(txtNbOcup.Text);
          cmd.Parameters["@nGarantie"].Value = cboGarantie.Text == "" ? 1 : Convert.ToInt32(cboGarantie.Text);

          cmd.Parameters["@nNbSSSites"].Value = txtNbSSSites.Text == "" ? 0 : Convert.ToInt32(txtNbSSSites.Text);
          cmd.Parameters["@nNbNivo"].Value = txtNbNiveau.Text == "" ? 0 : Convert.ToInt32(txtNbNiveau.Text);

          cmd.Parameters["@vNumCodeMS"].Value = txtMS.Text;
          cmd.Parameters["@vNumCodeMF"].Value = txtMF.Text;
          cmd.Parameters["@vNumCodeMC"].Value = txtMC.Text;
          cmd.Parameters["@vNumCodeMM"].Value = txtMM.Text;
          cmd.Parameters["@vNumCodeML"].Value = TxtML.Text;

//          cmd.Parameters["@nBCouvert"].Value = txtNbCouvert.Text == "" ? 0 : Convert.ToInt32(txtNbCouvert.Text);
          cmd.Parameters["@nBCouvert"].Value = chkSiteJO.Checked ? 1 : 0;
          cmd.Parameters["@nBChambre"].Value = txtNbChambre.Text == "" ? 0 : Convert.ToInt32(txtNbChambre.Text);
          cmd.Parameters["@vCodImpl"].Value = txtCodImpl.Text == "" ? DBNull.Value : (object)txtCodImpl.Text;
          cmd.Parameters["@nSitPrio"].Value = chkSitPrio.Checked ? 1 : 0;

          cmd.Parameters["@vSitExtinctCertif"].Value = txtExtinctCertif.Text == "" ? DBNull.Value : (object)txtExtinctCertif.Text;
          cmd.Parameters["@dSitExtinctDate"].Value = (txtExtinctDate.Text != "") ? (object)Convert.ToDateTime(txtExtinctDate.Text) : DBNull.Value;
          cmd.Parameters["@dSitExtDerVis"].Value = (txtDerVisite.Text != "") ? (object)Convert.ToDateTime(txtDerVisite.Text) : DBNull.Value;
          cmd.Parameters["@cSitExtinctPrev"].Value = chkGestPrevExtinct.Checked ? "O" : "N";
          cmd.Parameters["@vSitExtCaract"].Value = txtExtCaracteristique.Text == "" ? DBNull.Value : (object)txtExtCaracteristique.Text;
          cmd.Parameters["@vSitExtPart"].Value = txtExtParticularite.Text == "" ? DBNull.Value : (object)txtExtParticularite.Text;
          cmd.Parameters["@villeCible"].Value = cboPays.Text == "FRANCE" ? DBNull.Value : cboVillesCibles.SelectedValue;

          cmd.Parameters["@bperposte"].Value = ChkPerPoste.Checked ? 1 : 0;
          cmd.Parameters["@VSITSECTEUR"].Value = TxtSecteur.Text == "" ? DBNull.Value : (object)TxtSecteur.Text;

          cmd.ExecuteNonQuery();

          // récupération du numéro crée
          miNumSite = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (SqlException)
      {
        MessageBox.Show(Resources.msg_nom_site_existe_deja + " !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cboPays_SelectedValueChanged(object sender, EventArgs e)
    {
      if (cboPays.Text == "ESPAGNE")
      {
        cmdRecherche.Visible = cboVille.Visible = false;
        txtVille.Visible = true;
        ModuleData.RemplirCombo(cboRegEma, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = 3 order by VDEPLIB");
        cboRegEma.ValueMember = "NREGCOD";
        cboRegEma.DisplayMember = "VDEPLIB";
      }
      else if (cboPays.Text != "FRANCE")
      {
        cmdRecherche.Visible = cboVille.Visible = false;
        txtVille.Visible = true;
        cboRegEma.DataSource = null;
      }
      else
      {
        cmdRecherche.Visible = cboVille.Visible = true;
        txtVille.Visible = false;
        ModuleData.RemplirCombo(cboRegEma, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = 1 order by VDEPLIB");
        cboRegEma.ValueMember = "NREGCOD";
        cboRegEma.DisplayMember = "VDEPLIB";
      }
    }
    //Private Sub cboPays_Click()
    //  
    //  If cboPays.Text = "ESPAGNE" Then
    //    cboVille.Visible = False
    //    txtVille.Visible = True
    //    cmdRecherche.Visible = False
    //    RemplirCombo cboRegEma, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = 3 order by VDEPLIB"
    //  ElseIf cboPays.Text <> "FRANCE" Then
    //    cboVille.Visible = False
    //    txtVille.Visible = True
    //    cmdRecherche.Visible = False
    //
    //  Else
    //    cboVille.Visible = True
    //    txtVille.Visible = False
    //    cmdRecherche.Visible = True
    //    RemplirCombo cboRegEma, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = 1 order by VDEPLIB"
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void frmDetailsSite_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (dtContSit.Rows.Count == 0 && miNumSite != 0)
      {
        MessageBox.Show(Resources.msg_responsable_site_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        e.Cancel = true;
      }
    }
    //Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    //
    //    If adoRSContSit.State = adStateOpen Then
    //
    //        If adoRSContSit.RecordCount = 0 And miNumSite <> 0 Then
    //          MsgBox "§Il faut OBLIGATOIREMENT un responsable site!!§", vbInformation
    //          Cancel = True
    //        End If
    //    End If
    //  
    //  'remplissage de la liste des contact du site
    //  If adoRSContSit.State = adStateOpen Then
    //    adoRSContSit.Close
    //    Set adoRSContSit = Nothing
    //  End If
    //
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void Image1_Click(object sender, EventArgs e)
    {
      if (txtNom.Text == "" || txtAD1.Text == "" || cboPays.Text == "")
      {
        MessageBox.Show("Renseignez d'abord le nom et l'adresse du site...", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      string StartingAddress;
      if (cboPays.Text != "FRANCE")
      {
        // on recherche la lat et long
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT TVILLES.ID FROM TVILLES WITH (NOLOCK) WHERE FVILLAT IS NOT NULL AND FVILLON IS NOT NULL AND ID = {cboVillesCibles.SelectedValue}"))
        {
          if (reader.Read())
            StartingAddress = $"https://maps.emalec.com/Site_ParAdresse_Et_Villes_cibles.asp?BASE=MULTI&APP={MozartParams.NomSociete}" +
                              $"&ID={cboVillesCibles.SelectedValue}&NOM={txtNom.Text}&AD1={txtAD1.Text}&VILLE={txtVille.Text}&PAYS={cboPays.Text}";
          else
            StartingAddress = $"https://maps.emalec.com/Site_ParLatLon_Villes_cibles.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NOM={txtNom.Text}" +
                              $"&AD1={txtAD1.Text}&VILLE={txtVille.Text}&PAYS={cboPays.Text}";
        }
      }
      else
        StartingAddress = $"https://maps.emalec.com/Site_ParAdresse_Et_Villes_cibles.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NOM={txtNom.Text}" +
                              $"&AD1={txtAD1.Text}&VILLE={cboVille.Text}&PAYS={cboPays.Text}";

      new frmBrowser { msStartingAddress = StartingAddress }.ShowDialog();
    }
    //Private Sub Image1_Click()
    //
    //  If txtNom.Text = "" Or txtAD1.Text = "" Or cboPays.Text = "" Then
    //    MsgBox "Renseignez d'abord le nom et l'adresse du site..."
    //    Exit Sub
    //  End If
    //  If cboPays.Text <> "FRANCE" Then
    //  
    //    'cboVillesCibles.ItemData(cboVillesCibles.ListIndex)
    //    'on recherche la lat et long
    //    Dim adoLatLon As New ADODB.Recordset
    //    ' UPGRADE_INFO (#0501): The 'FVILLAT' member isn't used anywhere in current application.
    //    ' UPGRADE_INFO (#0501): The 'FVILLON' member isn't used anywhere in current application.
    //    ' Dim FVILLAT, FVILLON As Double
    //    adoLatLon.Open "SELECT TVILLES.ID FROM TVILLES WITH (NOLOCK) WHERE FVILLAT IS NOT NULL AND FVILLON IS NOT NULL AND ID = " & cboVillesCibles.ItemData(cboVillesCibles.ListIndex), cnx, adOpenStatic, adLockReadOnly
    //    
    //    If adoLatLon.RecordCount > 0 Then
    //        frmBrowser.StartingAddress = "http://maps.emalec.com/Site_ParLatLon_Villes_cibles.asp?BASE=MULTI&APP=" & gstrNomSociete & "&ID=" & cboVillesCibles.ItemData(cboVillesCibles.ListIndex) & "&NOM=" & txtNom.Text & "&AD1=" & txtAD1.Text & "&VILLE=" & txtVille.Text & "&PAYS=" & cboPays.Text
    //    Else
    //        frmBrowser.StartingAddress = "http://maps.emalec.com/Site_ParAdresse_Et_Villes_cibles.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NOM=" & txtNom.Text & "&AD1=" & txtAD1.Text & "&VILLE=" & txtVille.Text & "&PAYS=" & cboPays.Text
    //    End If
    //    adoLatLon.Close
    //    
    //  Else
    //    frmBrowser.StartingAddress = "http://maps.emalec.com/Site_ParAdresse_Et_Villes_cibles.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NOM=" & txtNom.Text & "&AD1=" & txtAD1.Text & "&VILLE=" & cboVille.Text & "&PAYS=" & cboPays.Text
    //  End If
    //  frmBrowser.Show vbModal
    //  
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.TextLength == 5)
      {
        if (cboPays.Text == "FRANCE")
        {
          RechercheCommune(txtCP.Text, cboVille);
          string sDep = Strings.Left(txtCP.Text, 2);
          cboRegEma.SelectedValue = sDep;
        }
        else if (cboPays.Text == "ESPAGNE")
        {
          string sDep = Strings.Left(txtCP.Text, 2);
          cboRegEma.SelectedValue = sDep;
        }
      }
    }
    //Private Sub txtCP_Change()
    //Dim sDep As String
    //
    //    If Len(txtCP) = 5 And cboPays = "FRANCE" Then
    //        RechercheCommune txtCP.Text, cboVille
    //        
    //        sDep = Left(txtCP, 2)
    //        SelectLB cboRegEma, val(sDep)
    //    ElseIf Len(txtCP) = 5 And cboPays = "ESPAGNE" Then
    //        sDep = Left(txtCP, 2)
    //        SelectLB cboRegEma, val(sDep)
    //    End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtCP_Leave(object sender, EventArgs e)
    {
      if (txtCPCedex.Text != "" && txtCedex.Text == "") txtCedex.Text = "CEDEX ";
    }
    //Private Sub txtCPCedex_LostFocus()
    //  If txtCPCedex <> "" And txtCedex = "" Then txtCedex = "CEDEX "
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtCedex_Leave(object sender, EventArgs e)
    {
      txtCedex.Text = txtCedex.Text.ToUpper();
    }
    //Private Sub txtCedex_LostFocus()
    //  txtCedex = Majuscule(txtCedex)
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => ControlNumericite
    //Private Sub txtNbChambre_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => ControlNumericite
    //Private Sub txtNbCouvert_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => ControlNumericite
    //Private Sub txtNbNiveau_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => ControlNumericite
    //Private Sub txtNbOcup_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => ControlNumericite
    //Private Sub txtNbSSSites_KeyPress(KeyAscii As Integer)
    //' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    void ControlNumericite(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    /* --------------------------------------------------------------------------------------- */
    private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)42) return;
    }
    //Private Sub txtNom_KeyPress(KeyAscii As Integer)
    //
    //     If KeyAscii = 42 Then KeyAscii = 0: Exit Sub
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }
    //Private Sub txtVille_lostfocus()
    //  txtVille = Majuscule(txtVille)
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void RechercheCommune(string strCp, ComboBox cbo)
    {
      ModuleMain.RechercheCommune(txtCP.Text, cboVille);
    }
    //Private Sub RechercheCommune(strCp As String, cbo As ComboBox)
    //  Static rs As New ADODB.Recordset
    //  cbo.Clear
    //  rs.Open "select Ville from TCOMMUNE WHERE CodePostal = '" & strCp & "'", cnx
    //  While Not rs.EOF
    //    cbo.AddItem rs!ville
    //    rs.MoveNext
    //  Wend
    //  If rs.RecordCount > 0 Then cbo.ListIndex = 0
    //  rs.Close
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    bool NomExist(string nom)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select count(*) from TSIT WHERE NCLINUM = {miNumClient} AND upper(VSITNOM) =  '{nom.ToUpper()}'"))
      {
        if (reader.Read() && Utils.ZeroIfNull(reader[0]) > 0) return true;
      }
      return false;
    }
    //Private Function NomExist(ByVal nom As String) As Boolean
    // 
    //Dim pRS As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  NomExist = False
    //  
    //  ' 'recherche des informatiopn de l'action
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "select count(*) from TSIT WHERE NCLINUM = " & miNumClient & " AND upper(VSITNOM) =  '" & Majuscule(nom) & "'", cnx
    //
    //  If pRS.EOF Then Exit Function
    //  If pRS(0) > 0 Then NomExist = True
    //  
    //Exit Function
    //handler:
    //  ShowError "NomExist dans " & Me.Name
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    // => ControlNumericite
    //Private Sub txtSurf_KeyPress(KeyAscii As Integer)
    //  ' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void InitListeImp()
    {
      DataTable dtImp = new DataTable();
      ModuleData.LoadData(dtImp, $"SELECT TPER.NPERNUM, VPERNOM + ' ' + VPERPRE AS TECH FROM TPER, TTECHSITE" +
                                $" WHERE TPER.NPERNUM = TTECHSITE.NPERNUM" +
                                $" AND TTECHSITE.CTYPE = 'O' AND TPER.CPERACTIF = 'O'" +
                                $" AND TTECHSITE.NSITNUM = {miNumSite}" +
                                $" ORDER BY VPERNOM", MozartDatabase.cnxMozart);
      lstImp.DataSource = dtImp;
      lstImp.ValueMember = "NPERNUM";
      lstImp.DisplayMember = "TECH";
      if (dtImp.Rows.Count > 0) lstImp.SelectedIndex = 0;
      cmdAjoutImp.Enabled = true;
      cmdSupImp.Enabled = true;
    }
    //Private Sub InitListeImp()
    //Dim rsTech As ADODB.Recordset
    //Dim sSQL As String
    //
    //  sSQL = "SELECT TPER.NPERNUM, VPERNOM + ' ' + VPERPRE AS TECH FROM TPER, TTECHSITE " _
    //        & "WHERE TPER.NPERNUM = TTECHSITE.NPERNUM " _
    //        & "AND TTECHSITE.CTYPE = 'O' " _
    //        & "AND TPER.CPERACTIF = 'O' " _
    //        & "AND TTECHSITE.NSITNUM = " & miNumSite & " " _
    //        & "ORDER BY VPERNOM"
    //        
    //  Set rsTech = New ADODB.Recordset
    //  rsTech.Open sSQL, cnx
    //
    //  lstImp.Clear
    //
    //  While Not rsTech.EOF
    //    lstImp.AddItem rsTech("TECH")
    //    lstImp.ItemData(lstImp.ListCount - 1) = rsTech("NPERNUM")
    //    rsTech.MoveNext
    //  Wend
    //  If lstImp.ListCount > 0 Then lstImp.ListIndex = 0
    //
    //  rsTech.Close
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void InitListeInt()
    {
      DataTable dtInt = new DataTable();
      ModuleData.LoadData(dtInt, $"SELECT TPER.NPERNUM, VPERNOM + ' ' + VPERPRE AS TECH FROM TPER, TTECHSITE" +
                                $" WHERE TPER.NPERNUM = TTECHSITE.NPERNUM" +
                                $" AND TTECHSITE.CTYPE = 'I' AND TPER.CPERACTIF = 'O'" +
                                $" AND TTECHSITE.NSITNUM = {miNumSite}" +
                                $" ORDER BY VPERNOM", MozartDatabase.cnxMozart);
      lstInt.DataSource = dtInt;
      lstInt.ValueMember = "NPERNUM";
      lstInt.DisplayMember = "TECH";
      if (dtInt.Rows.Count > 0) lstInt.SelectedIndex = 0;
      cmdAjoutInt.Enabled = true;
      cmdSupInt.Enabled = true;
    }
    //Private Sub InitListeInt()
    //Dim rsTech As ADODB.Recordset
    //Dim sSQL As String
    //
    //  sSQL = "SELECT TPER.NPERNUM, VPERNOM + ' ' + VPERPRE AS TECH FROM TPER, TTECHSITE " _
    //        & "WHERE TPER.NPERNUM = TTECHSITE.NPERNUM " _
    //        & "AND TTECHSITE.CTYPE = 'I' " _
    //        & "AND TPER.CPERACTIF = 'O' " _
    //        & "AND TTECHSITE.NSITNUM = " & miNumSite & " " _
    //        & "ORDER BY VPERNOM"
    //        
    //  Set rsTech = New ADODB.Recordset
    //  rsTech.Open sSQL, cnx
    //  
    //  lstInt.Clear
    //
    //  While Not rsTech.EOF
    //    lstInt.AddItem rsTech("TECH")
    //    lstInt.ItemData(lstInt.ListCount - 1) = rsTech("NPERNUM")
    //    rsTech.MoveNext
    //  Wend
    //  If lstInt.ListCount > 0 Then lstInt.ListIndex = 0
    //
    //  rsTech.Close
    //
    //End Sub
    //

    private void cmdAjoutImp_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleData.ExecuteNonQuery($"INSERT INTO TTECHSITE VALUES({cboTech.GetItemData()},{miNumSite},'O')");

        RemplirComboTech();

        InitListeImp();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdAjoutImp_Click()
    //  
    //  cnx.Execute "INSERT INTO TTECHSITE VALUES(" & cboTech.ItemData(cboTech.ListIndex) & "," & miNumSite & ",'O')"
    //  cboTech.Clear
    //
    //  RemplirCombo cboTech, "select npernum, vpernom + ' ' + vperpre from tper where cperactif = 'O' and cpertyp in ('TE', 'CA', 'AS', 'AA', 'CO', 'BE') AND VSOCIETE = App_Name() and npernum not in (select npernum from ttechsite where nsitnum = " & miNumSite & ")  order by vpernom + ' ' + VPERPRE", , True
    //
    //  lstImp.Clear
    //  InitListeImp
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjoutInt_Click(object sender, EventArgs e)
    {
      try
      {
        // insertion du technicien interdit dans TTECHSITE
        Cursor.Current = Cursors.WaitCursor;

        ModuleData.ExecuteNonQuery($"INSERT INTO TTECHSITE VALUES({cboTech.GetItemData()},{miNumSite},'I')");

        RemplirComboTech();
        InitListeInt();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdAjoutInt_Click()
    //  
    //  ' insertion du technicien interdit dans TTECHSITE
    //  cnx.Execute "INSERT INTO TTECHSITE VALUES(" & cboTech.ItemData(cboTech.ListIndex) & "," & miNumSite & ",'I')"
    //  cboTech.Clear
    //
    //  RemplirCombo cboTech, "select npernum, vpernom + ' ' + vperpre from tper where cperactif = 'O' and cpertyp in ('TE', 'CA', 'AS', 'AA', 'CO', 'BE') AND VSOCIETE = App_Name() and npernum not in (select npernum from ttechsite where nsitnum = " & miNumSite & ")  order by vpernom + ' ' + VPERPRE", , True
    //    
    //  lstInt.Clear
    //  InitListeInt
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void cmdRechercheServtech_Click(object sender, EventArgs e)
    {
      frmSelectServTech frm = new frmSelectServTech();
      frm.ShowDialog();
      txtServTech.Tag = frm.miServTech_Tag;
      txtServTech.Text = frm.msServTech;
    }
    //Private Sub cmdRechercheServtech_Click()
    //    
    //    frmSelectServTech.Show vbModal
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupImp_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (lstImp.SelectedIndex != -1)
        {
          // on supprime l'enregistrement de la table TTECHSITE
          // dans la requete on ne test pas le ctype car le tech ne peut être qu'une fois dans la table pour un site
          ModuleData.ExecuteNonQuery($"DELETE TTECHSITE WHERE NSITNUM = {miNumSite} AND NPERNUM = {lstImp.SelectedValue}");

          InitListeImp();
          RemplirComboTech();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdSupImp_Click()
    //Dim sSQL As String
    //  
    //  If lstImp.ListIndex <> -1 Then
    //    ' on supprime l'enregistrement de la table TTECHSITE
    //    ' dans la requete on ne test pas le ctype car le tech ne peut être qu'une fois dans la table pour un site
    //    sSQL = "DELETE TTECHSITE WHERE NSITNUM = " & miNumSite & " AND NPERNUM = " & lstImp.ItemData(lstImp.ListIndex)
    //    cnx.Execute sSQL
    //  
    //    lstImp.Clear
    //    InitListeImp
    //    
    //    cboTech.Clear
    //
    //    RemplirCombo cboTech, "select npernum, vpernom + ' ' + vperpre from tper where cperactif = 'O' and cpertyp in ('TE', 'CA', 'AS', 'AA', 'CO', 'BE') AND VSOCIETE = App_Name() and npernum not in (select npernum from ttechsite where nsitnum = " & miNumSite & ")  order by vpernom + ' ' + VPERPRE", , True
    //    
    //End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupInt_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (lstInt.SelectedIndex != -1)
        {
          // on supprime l'enregistrement de la table TTECHSITE
          // dans la requete on ne test pas le ctype car le tech ne peut être qu'une fois dans la table pour un site
          ModuleData.ExecuteNonQuery($"DELETE TTECHSITE WHERE NSITNUM = {miNumSite} AND NPERNUM = {lstInt.SelectedValue}");

          InitListeInt();
          RemplirComboTech();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdSupprServtech_Click(object sender, EventArgs e)
    {
      txtServTech.Tag = 0;
      txtServTech.Text = "";
    }

    private void cmdSSSites_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // on crée autant de sous-sites que le nombre l'indique
        // fonction créee pour SEMCODA dans le but de créer les appartements
        if (MessageBox.Show($"{Resources.msg_attention_allez_creer}{txtNbSSSites.Text}{Resources.msg_sites_etes_vous_sure}", Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        cmdEnregistrer_Click(null, null);

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationSite", MozartDatabase.cnxMozart))
        {
          // pour la création ou la modification, c'est la proc stock qui gère
          // création d'une commande
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          int nb = Convert.ToInt16(txtNbSSSites.Text);
          for (int i = 0; i < nb; i++)
          {
            cmd.Parameters["@iNum"].Value = 0; // 0 si création
            cmd.Parameters["@iClient"].Value = miNumClient;
            cmd.Parameters["@vNom"].Value = $"{Strings.Left(txtNom.Text, (txtNom.Text.ToLower().IndexOf(", communs") == -1) ? txtNom.Text.Length : txtNom.Text.ToLower().IndexOf(", communs"))} Appt {i}".Replace("communs", "");
            cmd.Parameters["@vNum"].Value = txtNum.Text;
            cmd.Parameters["@nTypeSite"].Value = cboType.SelectedValue;
            cmd.Parameters["@vEnseigne"].Value = "Logement";
            cmd.Parameters["@vAd1"].Value = txtAD1.Text;
            cmd.Parameters["@vAd2"].Value = txtAD2.Text;
            cmd.Parameters["@vCp"].Value = txtCP.Text;
            cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
            cmd.Parameters["@vPays"].Value = cboPays.Text;
            cmd.Parameters["@vCpCedex"].Value = txtCPCedex.Text == "" ? DBNull.Value : (object)txtCPCedex.Text;
            cmd.Parameters["@vCedex"].Value = txtCedex.Text == "" ? DBNull.Value : (object)txtCedex.Text;
            cmd.Parameters["@vRegCli"].Value = txtRegCli.Text;
            cmd.Parameters["@iRegEma"].Value = cboRegEma.SelectedValue;
            cmd.Parameters["@cPart"].Value = optPart0.Checked ? "O" : "N";
            cmd.Parameters["@iRespReg"].Value = (int)cboRespReg.SelectedValue == 0 ? DBNull.Value : cboRespReg.SelectedValue;
            cmd.Parameters["@iRespMaint"].Value = (int)cboRespMaint.SelectedValue == 0 ? DBNull.Value : cboRespMaint.SelectedValue;
            cmd.Parameters["@iFact"].Value = cboFact.SelectedValue;
            cmd.Parameters["@nSurface"].Value = 0;
            cmd.Parameters["@dDatecre"].Value = txtDateCre.Text == "" ? DBNull.Value : (object)txtDateCre.Text;
            cmd.Parameters["@vConcept"].Value = DBNull.Value;
            cmd.Parameters["@vHoraires"].Value = DBNull.Value;
            cmd.Parameters["@nServTechNum"].Value = DBNull.Value;
            cmd.Parameters["@nNbOcup"].Value = txtNbOcup.Text == "" ? 0 : Convert.ToInt32(txtNbOcup.Text);
            cmd.Parameters["@nGarantie"].Value = cboGarantie.Text == "" ? 1 : Convert.ToInt32(cboGarantie.Text);
            cmd.Parameters["@nNbSSSites"].Value = 0;
            cmd.Parameters["@CreaRSF"].Value = "N";
            cmd.Parameters["@cJur"].Value = optJur0.Checked ? "L" : optJur1.Checked ? (object)"P" : DBNull.Value;

            cmd.ExecuteNonQuery();
          }
        }

        MessageBox.Show(Resources.msg_tous_sites_crees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdComSec_Click(object sender, EventArgs e)
    {
      new frmCommissionSec { iNumsite = miNumSite }.ShowDialog();
    }

    private void cmdContratSite_Click(object sender, EventArgs e)
    {
      new frmContratSite { miNumClient = this.miNumClient, miNumSite = this.miNumSite }.ShowDialog();
    }

    void InitApigrid()
    {
      apiTGridContSit.AddColumn(Resources.col_Nom, "VCSITNOM", 1100);
      apiTGridContSit.AddColumn(Resources.col_Fonction, "VTYPCSITLIB", 1100);
      apiTGridContSit.AddColumn(Resources.col_Tel, "VCSITTEL", 800);
      apiTGridContSit.AddColumn(Resources.txt_Mail, "VCSITMAI", 1100);
      apiTGridContSit.AddColumn(Resources.col_Fax, "VCSITFAX", 800);
      apiTGridContSit.AddColumn(Resources.col_Port, "VCSITPOR", 800);

      apiTGridContSit.InitColumnList();
      apiTGridContSit.CacherBoutonsPrintExcel();

    }

    private void CmdAddContact_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0) return;

      new frmDetailContactSit
      {
        iNumContSit = 0,
        mstrStatut = "C",
        iSitNum = miNumSite
      }.ShowDialog();

      apiTGridContSit.Requery(dtContSit, MozartDatabase.cnxMozart);
    }

    private void CmdDelContact_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0) return;
      DataRow row = apiTGridContSit.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show(Resources.msg_confirm_contact_deletion, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      // Test si le contact que l'on veut supprimer est un responsable car si c'est la cas, alors suppression impossible
      if ((int)row["NTYPCSITNUM"] == 1)
      {
        MessageBox.Show(Resources.msg_suppression_impossible_responsable_site_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      ModuleData.ExecuteNonQuery($"DELETE TCSIT WHERE NCSITNUM = {row["NCSITNUM"]}");

      apiTGridContSit.Requery(dtContSit, MozartDatabase.cnxMozart);
    }

    private void CmdDetailContact_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0) return;
      DataRow row = apiTGridContSit.GetFocusedDataRow();
      if (null == row) return;

      new frmDetailContactSit
      {
        iNumContSit = (int)Utils.ZeroIfNull(row["NCSITNUM"]),
        iSitNum = miNumSite,
        mstrStatut = "M"
      }.ShowDialog();

      apiTGridContSit.Requery(dtContSit, MozartDatabase.cnxMozart);
    }

    private void CmdDocInt_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0) return;
      new frmSiteGestionDocInterne(miNumSite.ToString()).ShowDialog();
    }

    bool DocInterneExist()
    {
      return ModuleData.ExecuteScalarInt($"select count(NSITDOCID) from TSITDOC WHERE NSITNUM = {miNumSite}") > 0;
    }

    private void CmdAffectTechImpose_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0 || lstImp.Items.Count == 0) return;
      int npernum = (int)lstImp.SelectedValue;
      new frmSelectSiteTech(miNumClient, "IMPOSE", npernum).ShowDialog();
      InitListeImp();
    }
    
    private void CmdAffectTechInterdit_Click(object sender, EventArgs e)
    {
      if (miNumSite == 0 || lstInt.Items.Count == 0) return;
      int npernum = (int)lstInt.SelectedValue;
      new frmSelectSiteTech(miNumClient, "INTERDIT", npernum).ShowDialog();
      InitListeInt();
    }

  }
}

