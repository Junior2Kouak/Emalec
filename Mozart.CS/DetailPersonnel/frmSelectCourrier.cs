using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSelectCourrier : Form
  {
    public string mstrClient = "";
    public string mstrSite = "";
    public string mstrTypeDest = "";

    int iNbSelectedDest = 0;

    DataTable dt;
    private DataTable dtLettre = new DataTable();

    public frmSelectCourrier()
    {
      InitializeComponent();
    }

    private void frmSelectCourrier_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Ne rien charger au démarrage du formulaire
        // On attend que l'utilisateur choisisse un type de destinataire

        if (MozartParams.Droit == "OUI")
        {
          lblLabels6.Visible = true;
          chkTous.Visible = true;
          ApiGrid.dgv.OptionsSelection.MultiSelect = true;
          lblLabels11.Visible = true;
          optDest5.Visible = true;
        }

        ApiGrid.dgv.Appearance.SelectedRow.BackColor =
        ApiGrid.dgv.Appearance.FocusedRow.BackColor =
        ApiGrid.dgv.Appearance.FocusedCell.BackColor = Color.DodgerBlue;
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void InitApigrid(string sType)
    {

      ApiGrid.dicCellsAlignment.Clear();
      ApiGrid.dgv.Columns.Clear();
      switch (sType)
      {
        case "CLI":
        case "ADM":
          ApiGrid.AddColumn(Resources.col_Num, "VCLINUM", 400);
          ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 800);
          ApiGrid.AddColumn(Resources.col_Contact, "VCCLNOM", 500);
          ApiGrid.AddColumn(Resources.col_Prenom, "VCCLPRE", 500);
          ApiGrid.AddColumn(Resources.col_Fonction, "VCCLFONC", 650);
          ApiGrid.AddColumn(Resources.col_Adresse1, "VCCLAD1", 700);
          ApiGrid.AddColumn(Resources.col_Adresse2, "VCCLAD2", 700);
          ApiGrid.AddColumn(Resources.col_CP, "VCCLCP", 400, "", 2);
          ApiGrid.AddColumn(Resources.col_Ville, "VCCLVIL", 600);
          ApiGrid.AddColumn(Resources.col_Observation, "VCLIOBS", 2500);
          ApiGrid.AddColumn(Resources.col_Num, "NCCLNUM", 0);
          break;

        case "ST":
        case "FO":
          ApiGrid.AddColumn(Resources.col_Num, "NSTFNUM", 400);
          ApiGrid.AddColumn(Resources.col_Nom, "VSTFNOM", 800);
          ApiGrid.AddColumn(Resources.col_Contact, "VINTNOM", 500);
          ApiGrid.AddColumn(Resources.col_Adresse1, "VSTFAD1", 700);
          ApiGrid.AddColumn(Resources.col_Adresse2, "VSTFAD2", 700);
          ApiGrid.AddColumn(Resources.col_CP, "VSTFCP", 400, "", 2);
          ApiGrid.AddColumn(Resources.col_Ville, "VSTFVIL", 600);
          ApiGrid.AddColumn(Resources.col_Observation, "VSTFOBS", 2500);
          ApiGrid.AddColumn(Resources.col_Num, "NINTNUM", 0);
          break;
        case "SIT":
          ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
          ApiGrid.AddColumn(Resources.col_Site, "VSITNOM", 1100);
          ApiGrid.AddColumn(Resources.col_Num, "NSITNUE", 500, "", 2);
          ApiGrid.AddColumn(Resources.col_responsable, "VSITRES", 700);
          ApiGrid.AddColumn(Resources.col_Adresse1, "VSITAD1", 700);
          ApiGrid.AddColumn(Resources.col_Adresse2, "VSITAD2", 700);
          ApiGrid.AddColumn(Resources.col_CP, "VSITCP", 400, "", 2);
          ApiGrid.AddColumn(Resources.col_Ville, "VSITVIL", 900);
          //ApiGrid.AddColumn(Resources.col_Tel, "VSITTEL", 0);
          //ApiGrid.AddColumn(Resources.col_Fax, "VSITFAX", 0);
          ApiGrid.AddColumn(Resources.col_Region, "VREGLIB", 2500);
          ApiGrid.AddColumn(Resources.col_Num, "NSITNUM", 0);
          break;
        case "PER":
          ApiGrid.AddColumn(Resources.col_Nom, "VPERNOM", 800);
          ApiGrid.AddColumn(Resources.col_Prenom, "VPERPRE", 800);
          ApiGrid.AddColumn(Resources.col_Type, "CPERTYP", 300);
          //ApiGrid.AddColumn(Resources.col_Adresse1, "VPERAD1", 700);
          //ApiGrid.AddColumn(Resources.col_Adresse2, "VPERAD2", 700);
          //ApiGrid.AddColumn(Resources.col_CP, "VPERCP", 400, "", 2);
          //ApiGrid.AddColumn(Resources.col_Ville, "VPERVIL", 600);
          //ApiGrid.AddColumn(Resources.col_Tel, "VPERTEL", 0);
          //ApiGrid.AddColumn(Resources.col_Portable, "VPERPOR", 0);
          //ApiGrid.AddColumn(Resources.col_Fax, "VPERFAX", 0);
          ApiGrid.AddColumn(Resources.col_Region, "VREGLIB", 500);
          ApiGrid.AddColumn(Resources.col_Service, "VSERLIB", 500);
          ApiGrid.AddColumn(Resources.col_Num, "NPERNUM", 0);
          break;
      }

      ApiGrid.InitColumnList();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitialisationFeuille(string sType)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        if (dt != null)
          dt.Dispose();
        dt = new DataTable();
        ApiGrid.GridControl.DataSource = null;
        ApiGrid.lblRowCount.Text = "";
        ApiGrid.Refresh();

        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_DestCourrier '{sType}','{MozartParams.NomSociete}'");
        ApiGrid.GridControl.DataSource = dt;

        InitApigrid(sType);

        if (MozartParams.Droit == "OUI")
        {
          lblLabels6.Visible = true;
          chkTous.Visible = true;
          ApiGrid.dgv.OptionsSelection.MultiSelect = true;
          lblLabels11.Visible = true;
          optDest5.Visible = true;
        }

        // pour une attestation, pas de multiselect
        if (optCour4.Checked)
        {
          ApiGrid.dgv.OptionsSelection.MultiSelect = false;
          lblLabels6.Visible = false;
          chkTous.Visible = false;
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub InitialisationFeuille(Sql As String)
    //  
    //On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec " & Sql, cnx
    //
    //  ' initialisation du nombre d'enregistrement
    //  miNbEnreg = adoRS.RecordCount
    //  
    //  ' on charge le contrôle
    //  On Error Resume Next
    //  Load lstView(1)
    //  If Err Then
    //    ' on décharge le controle
    //    Unload lstView(1)
    //    Load lstView(1)
    //  End If
    //  
    //  On Error GoTo handler
    //  
    //  lstView(1).Visible = True
    //  If gstrDroit = "OUI" Then
    //    lblLabels(6).Visible = True
    //    chkTous.Visible = True
    //    lstView(1).MultiSelect = True
    //    lblLabels(11).Visible = True
    //    optDest(5).Visible = True
    //  End If
    //
    //  ' pour une attestation, pas de multiselect
    //  If optCour(4) Then
    //    lstView(1).MultiSelect = False
    //    lblLabels(6).Visible = False
    //    chkTous.Visible = False
    //  End If
    //
    //  ' liaison du recordset et du datagrid
    //  FillList adoRS, lstView(1), True
    //  
    //  ' mise en page du datagrid
    //  FormatListview True
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "InitialisationFeuille dans " & Me.Name
    //End Sub
    //

    /* OK ------------------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      //  Remplir le recorset des destinataires sélectionnés
      InitRecordsetDest();

      if (!TraiterSelection())
      {
        // Cas ou il n'y a pas de contact sur le destinataire
        MessageBox.Show(Resources.msg_manqueContactDst, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (iNbSelectedDest == 0)
      {
        MessageBox.Show(Resources.msg_selectDest, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // Confirmation > 100 destinataires
      if (iNbSelectedDest > 100)
      {
        if (MessageBox.Show(Resources.msg_ConfirmSelect100Dest, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;
      }

      //  Selon le type de courrier, on envoi sur des écrans différents
      // on ne passe pas la société en paramètre car gstrnomsociete ne peut pas etre  = "GROUPE"
      // elle contiendra obligatoirement le nom d'un société
      switch (TypeCour())
      {
        case "A":
          new frmSaisieAttestation
          {
            mstrTypeDest = TypeDest(),
            mstrTypeCour = TypeCour(),
            mstrTypeAR = TypeAR(),
            miNumCourrier = 0,
            mstrStatutCourrier = "C",
            dtLettre = dtLettre
          }.ShowDialog();
          break;
        case "L":
        case "F":
        case "N":
        case "M":
        case "C":
          new frmSaisieLettre
          {
            mstrTypeDest = TypeDest(),
            mstrTypeCour = TypeCour(),
            mstrTypeAR = TypeAR(),
            iNumCourrier = 0,
            mstrStatutCourrier = "C",
            lNumAction = 0,
            msLibNomSoc = MozartParams.NomSociete,
            dtLettre = dtLettre
          }.ShowDialog();
          break;
        default:
          break;
      }
    }
    //Private Sub cmdValider_Click()
    //Dim response As String
    //  
    //On Error GoTo handler
    //
    //  ' remplir le recorset des destinataires sélectionnés
    //  InitRecordset
    //
    //  ' cas ou il n'y a pas de mail sur le destinataire
    //  If optCour(5) Then If Not TestMail Then Exit Sub
    //    
    //  
    //  If Not TraiterSelection Then
    //    ' cas ou il n'y a pas de contact sur le destinataire
    //      MsgBox "§Il manque le contact sur le destinataire§", vbInformation
    //      Exit Sub
    //  End If
    //          
    //  If iNbSelectedDest = 0 Then
    //      MsgBox "§Il faut sélectionner un destinataire§", vbInformation
    //      Exit Sub
    //  End If
    //  
    //  
    //  If iNbSelectedDest > 100 Then
    //      ' confirmation
    //      response = MsgBox("§Vous avez sélectionné plus de 100 destinataires. Confirmez-vous cette sélection ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //      Select Case response
    //        Case vbYes
    //        Case vbNo
    //          Exit Sub
    //        Case vbCancel
    //          Exit Sub
    //      End Select
    //  End If
    //  
    //  ' selon le type de courrier, on envoi sur des écrans différents
    //  Select Case TypeCour
    //    Case "A"
    //        ' passage des infos
    //        'on ne passe pas la société en paramètre car gstrnomsociete ne peut pas etre  = "GROUPE"
    //        'elle contiendra obligatoirement le nom d'un société
    //        frmSaisieAttestation.mstrTypeDest = TypeDest
    //        frmSaisieAttestation.mstrTypeCour = TypeCour
    //        frmSaisieAttestation.mstrTypeAR = TypeAR
    //        frmSaisieAttestation.iNumCourrier = 0
    //        frmSaisieAttestation.mstrStatutCourrier = "C"
    //        ' affichage feuille
    //        frmSaisieAttestation.Show vbModal
    //        
    //    Case "L", "F", "N", "M", "C"
    //        ' passage des infos
    //        'on ne passe pas la société en paramètre car gstrnomsociete ne peut pas etre  = "GROUPE"
    //        'elle contiendra obligatoirement le nom d'un société
    //        frmSaisieLettre.mstrTypeDest = TypeDest
    //        frmSaisieLettre.mstrTypeCour = TypeCour
    //        frmSaisieLettre.mstrTypeAR = TypeAR
    //        frmSaisieLettre.iNumCourrier = 0
    //        frmSaisieLettre.mstrStatutCourrier = "C"
    //        frmSaisieLettre.lNumAction = 0
    //        ' affichage feuille
    //        frmSaisieLettre.Show vbModal
    //  End Select
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub

    /* OK ------------------------------------------------------------------------------------*/
    private void chkTous_CheckedChanged(object sender, EventArgs e)
    {
      if (chkTous.Checked)
        ApiGrid.dgv.SelectAll();
      else
        ApiGrid.dgv.ClearSelection();
    }

    private void optCourAll_CheckedChanged(object sender, EventArgs e)
    {
      frameAR.Visible = false;
      switch (((RadioButton)sender).Name)
      {
        case "optCour0":      // Lettre  si lettre alors choix simple ou recommandé
          frameAR.Visible = true;
          break;
        case "optCour1":      // Télécopie
          break;
        case "optCour2":      // Bordereau livraison
          break;
        case "optCour3":      // Node de service  uniquement pour la direction
          optDest4.Checked = true;
          break;
        case "optCour4":      // Attestation LDR  alors uniquement les sites en destinataire
          if (MozartParams.Droit != "OUI")
          {
            MessageBox.Show(Resources.msg_leveeReservesAction, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            optCour0.Checked = true;
            return;
          }
          optDest3.Checked = true;
          break;
      }
    }

    private void optDestALL_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        RadioButton rb = (RadioButton)sender;
        if (rb.Checked == false) return;

        switch (rb.Name)
        {
          case "optDest0":      // Client
            if (optCour4.Checked) { optDest3.Checked = true; return; }
            else if (optCour3.Checked) { optDest4.Checked = true; return; }
            InitialisationFeuille("CLI");
            break;

          case "optDest1":      // Sous traitant
            if (optCour4.Checked) { optDest3.Checked = true; return; }
            else if (optCour3.Checked) { optDest4.Checked = true; return; }
            InitialisationFeuille("ST");
            break;

          case "optDest2":      // Fournisseur
            if (optCour4.Checked) { optDest3.Checked = true; return; }
            else if (optCour3.Checked) { optDest4.Checked = true; return; }
            InitialisationFeuille("FO");
            break;

          case "optDest3":     // Site
            if (optCour3.Checked) { optDest4.Checked = true; return; }
            InitialisationFeuille("SIT");
            break;

          case "optDest4":    // Personnel
            if (optCour4.Checked) { optDest3.Checked = true; return; }
            if (ModuleMain.RechercheDroitMenu(534))
              InitialisationFeuille("PER");
            else
            {
              MessageBox.Show(Resources.msg_DroitsAccesMenu, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              optCour0.Checked = true;// déclenche optCourAll_CheckedChanged
              optDest0.Checked = true;
            }
            break;

          case "optDest5":    // Client doc admin
            InitialisationFeuille("ADM");
            break;
        }
        // gestion de la selection
        chkTous_CheckedChanged(null, null);
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private string TypeCour()
    {
      if (optCour0.Checked) return "L";
      if (optCour1.Checked) return "F";
      if (optCour2.Checked) return "B";
      if (optCour3.Checked) return "N";
      if (optCour4.Checked) return "A";
      return "";
    }

    private string TypeDest()
    {
      if (optDest0.Checked) return "Client";
      if (optDest1.Checked) return "Sous-traitant";
      if (optDest2.Checked) return "Fournisseur";
      if (optDest3.Checked) return "Site";
      if (optDest4.Checked) return "Personnel";
      if (optDest5.Checked) return "Client";
      return "";
    }
 
    private string TypeAR()
    {
      if (optCour0.Checked)
      {
        if (optAR0.Checked) return "S";
        if (optAR1.Checked) return "R";
      }
      return "";
    }

    private bool TraiterSelection()
    {
      try
      {
        foreach (int item in ApiGrid.dgv.GetSelectedRows())
        {
          DataRow row = (DataRow)ApiGrid.dgv.GetDataRow(item);
          AjouterEnreg(TypeDest(), (int)row[row.ItemArray.Length - 1]);
        }
        iNbSelectedDest = ApiGrid.dgv.GetSelectedRows().Length;
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
        return false;
      }
      return true;
    }
    //Private Function TraiterSelection() As Boolean
    //
    //Dim olstview As ListItem
    //
    //On Error GoTo handler
    //  
    //  iNbSelectedDest = 0
    //
    //  If optDest(4).value = True Then
    //  
    //    ' parcours du listeview et recherche des lignes selectionnées
    //    For Each olstview In lstView(1).ListItems
    //      If olstview.Selected = True Then
    //            If olstview.SubItems(12) = "" Then
    //              TraiterSelection = False
    //              Exit Function
    //            Else
    //              AjouterEnreg olstview.SubItems(12), TypeDest()
    //              iNbSelectedDest = iNbSelectedDest + 1
    //            End If
    //      End If
    //    Next
    //    TraiterSelection = True
    //  
    //  ElseIf optDest(5).value = True Then
    //  
    //    ' parcours du listeview et recherche des lignes selectionnées
    //    For Each olstview In lstView(1).ListItems
    //      If olstview.Selected = True Then
    //            If olstview.SubItems(12) = "" Then
    //              TraiterSelection = False
    //              Exit Function
    //            Else
    //              AjouterEnreg olstview.SubItems(12), TypeDest()
    //              iNbSelectedDest = iNbSelectedDest + 1
    //            End If
    //      End If
    //    Next
    //    TraiterSelection = True
    //  
    //  ElseIf optDest(0).value = True Then
    //  
    //    ' parcours du listeview et recherche des lignes selectionnées
    //    For Each olstview In lstView(1).ListItems
    //      If olstview.Selected = True Then
    //            If olstview.SubItems(12) = "" Then
    //              TraiterSelection = False
    //              Exit Function
    //            Else
    //              AjouterEnreg olstview.SubItems(12), TypeDest()
    //              iNbSelectedDest = iNbSelectedDest + 1
    //            End If
    //      End If
    //    Next
    //    TraiterSelection = True
    //  
    //
    //  Else
    //  
    //    ' parcours du listeview et recherche des lignes selectionnées
    //    For Each olstview In lstView(1).ListItems
    //      If olstview.Selected = True Then
    //            If olstview.SubItems(11) = "" Then
    //              TraiterSelection = False
    //              Exit Function
    //            Else
    //              AjouterEnreg olstview.SubItems(11), TypeDest()
    //              iNbSelectedDest = iNbSelectedDest + 1
    //            End If
    //      End If
    //    Next
    //    TraiterSelection = True
    //
    //  End If
    //
    //  Exit Function
    //  
    //handler:
    //  ShowError "TraiterSelection dans " & Me.Name
    //End Function

    private void AjouterEnreg(string sTypeDest, int iNumDest)
    {
      try
      {
        DataRow row = dtLettre.NewRow();
        row["TypeDest"] = sTypeDest;
        row["IDdest"] = iNumDest;
        dtLettre.Rows.Add(row);
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void InitRecordsetDest()
    {
      try
      {
        if (dtLettre.Columns.Count == 0)
        {
          dtLettre.Columns.Add("TypeDest", typeof(string));
          dtLettre.Columns.Add("IDdest", typeof(int));
        }
        else
          dtLettre.Rows.Clear();
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }
  }
}