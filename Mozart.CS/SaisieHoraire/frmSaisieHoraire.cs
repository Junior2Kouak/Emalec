using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MozartNet;
using MozartCS.Properties;
using MozartUC;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmSaisieHoraire : Form
  {
    //Public miNumSit As Long
    public int miNumSit;

    //Public miNumCli As Long
    public int miNumCli;

    //Dim rsHoraireSite As ADODB.Recordset
    DataTable dtHoraireSite = new DataTable();

    //Dim rsFermetureSite As ADODB.Recordset
    DataTable dtFermetureSite = new DataTable();

    //Dim sTypeDate As String
    public string sTypeDate;

    public string mCaption;


    /* OK ---------------------------------------------------------------------*/
    public frmSaisieHoraire()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmSaisieHoraire_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        InitForm();
        this.Text += mCaption;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //    InitBoutons Me, frmMenu
    //
    //    InitForm
    //
    //End Sub


    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //
    //    Unload Me
    //
    //End Sub


    /* OK ----------Proc valable pour tous les boutons de type cmdDateSet ----------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void cmdDatesAll_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Cal.Tag = btn.Tag;

      string txt = "";
      Control[] tblDate = Controls.Find(Cal.Tag as string, true);
      if (tblDate != null && tblDate.Length > 0 && tblDate[0] is TextBox && !string.IsNullOrEmpty(((TextBox)tblDate[0]).Text))
        txt = ((TextBox)tblDate[0]).Text;

      DateTime d;
      if (DateTime.TryParse(txt, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }

      Cal.BringToFront();
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, btn.Location.X, btn.Location.Y, 0));
    }

    /* OK ---------------------------------------------------------------------*/
    private void Cal_CloseUp(object sender, System.EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      TextBox txt = (TextBox)this.Controls.Find(Cal.Tag as string, true)[0];
      txt.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }

    //Private Sub Cal_Click()
    //
    //  Select Case sTypeDate
    //    Case ""
    //      txtDateFerm = Cal.value
    //    Case "DebPer"
    //      txtDebPer = Cal.value
    //    Case "FinPer"
    //      txtFinPer = Cal.value
    //  End Select
    //
    //  Cal.Visible = False
    //End Sub


    /* OK ---------------------------------------------------------------------*/
    private void chkCoupDay_CheckedChanged(object sender, EventArgs e)
    {

      CheckBox chk = sender as CheckBox;
      switch (chk.Name)
      {
        case "chkCoupLun":
          SetCoupUnJour(chkCoupLun, new apiLabel[] { lblCoupLun0, lblCoupLun1, lblCoupLun2, lblCoupLun3 }, txtLunDebSoir, txtLunFinSoir, txtLunDebSoirMin, txtLunFinSoirMin);
          break;
        case "chkCoupMar":
          SetCoupUnJour(chkCoupMar, new apiLabel[] { lblCoupMar0, lblCoupMar1, lblCoupMar2, lblCoupMar3 }, txtMarDebSoir, txtMarFinSoir, txtMarDebSoirMin, txtMarFinSoirMin);
          break;
        case "chkCoupMer":
          SetCoupUnJour(chkCoupMer, new apiLabel[] { lblCoupMer0, lblCoupMer1, lblCoupMer2, lblCoupMer3 }, txtMerDebSoir, txtMerFinSoir, txtMerDebSoirMin, txtMerFinSoirMin);
          break;
        case "chkCoupJeu":
          SetCoupUnJour(chkCoupJeu, new apiLabel[] { lblCoupJeu0, lblCoupJeu1, lblCoupJeu2, lblCoupJeu3 }, txtJeuDebSoir, txtJeuFinSoir, txtJeuDebSoirMin, txtJeuFinSoirMin);
          break;
        case "chkCoupVen":
          SetCoupUnJour(chkCoupVen, new apiLabel[] { lblCoupVen0, lblCoupVen1, lblCoupVen2, lblCoupVen3 }, txtVenDebSoir, txtVenFinSoir, txtVenDebSoirMin, txtVenFinSoirMin);
          break;
        case "chkCoupSam":
          SetCoupUnJour(chkCoupSam, new apiLabel[] { lblCoupSam0, lblCoupSam1, lblCoupSam2, lblCoupSam3 }, txtSamDebSoir, txtSamFinSoir, txtSamDebSoirMin, txtSamFinSoirMin);
          break;
        case "chkCoupDim":
          SetCoupUnJour(chkCoupDim, new apiLabel[] { lblCoupDim0, lblCoupDim1, lblCoupDim2, lblCoupDim3 }, txtDimDebSoir, txtDimFinSoir, txtDimDebSoirMin, txtDimFinSoirMin);
          break;
      }
    }

    /* OK ---------------------------------------------------------------------*/
    private void SetCoupUnJour(apiCheckBox chkCoupDay, apiLabel[] lblCoupDay,
                                apiTextBox txtDayDebSoir, apiTextBox txtDayFinSoir,
                                apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoirMin)
    {
      bool bVisible = chkCoupDay.Checked;
      foreach (apiLabel label in lblCoupDay)
        label.Visible = bVisible;

      txtDayDebSoir.Visible = txtDayFinSoir.Visible = txtDayDebSoirMin.Visible = txtDayFinSoirMin.Visible = bVisible;

      if (!bVisible)
        txtDayDebSoir.Text = txtDayFinSoir.Text = txtDayDebSoirMin.Text = txtDayFinSoirMin.Text = "0";
    }
    #region /Private Sub chkCoup<day>_Click()
    //Private Sub chkCoupDim_Click()
    //  If chkCoupDim = 1 Then
    //    For Each lb In lblCoupDim
    //      lb.Visible = True
    //    Next
    //    txtDimDebSoir.Visible = True
    //    txtDimFinSoir.Visible = True
    //    txtDimDebSoirMin.Visible = True
    //    txtDimFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupDim
    //      lb.Visible = False
    //    Next
    //    txtDimDebSoir.Visible = False
    //    txtDimFinSoir.Visible = False
    //    txtDimDebSoirMin.Visible = False
    //    txtDimFinSoirMin.Visible = False
    //    txtDimDebSoir = 0
    //    txtDimFinSoir = 0
    //  End If
    //End Sub

    //Private Sub chkCoupJeu_Click()
    //  If chkCoupJeu = 1 Then
    //    For Each lb In lblCoupJeu
    //      lb.Visible = True
    //    Next
    //    txtJeuDebSoir.Visible = True
    //    txtJeuFinSoir.Visible = True
    //    txtJeuDebSoirMin.Visible = True
    //    txtJeuFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupJeu
    //      lb.Visible = False
    //    Next
    //    txtJeuDebSoir.Visible = False
    //    txtJeuFinSoir.Visible = False
    //    txtJeuDebSoirMin.Visible = False
    //    txtJeuFinSoirMin.Visible = False
    //    txtJeuDebSoir = 0
    //    txtJeuFinSoir = 0
    //  End If
    //End Sub

    //Private Sub chkCoupLun_Click()
    //  If chkCoupLun = 1 Then
    //    For Each lb In lblCoupLun
    //      lb.Visible = True
    //    Next
    //    txtLunDebSoir.Visible = True
    //    txtLunFinSoir.Visible = True
    //    txtLunDebSoirMin.Visible = True
    //    txtLunFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupLun
    //      lb.Visible = False
    //    Next
    //    txtLunDebSoir.Visible = False
    //    txtLunFinSoir.Visible = False
    //    txtLunDebSoirMin.Visible = False
    //    txtLunFinSoirMin.Visible = False
    //    txtLunDebSoir = 0
    //    txtLunFinSoir = 0
    //  End If
    //End Sub

    //Private Sub chkCoupMar_Click()
    //  If chkCoupMar = 1 Then
    //    For Each lb In lblCoupMar
    //      lb.Visible = True
    //    Next
    //    txtMarDebSoir.Visible = True
    //    txtMarFinSoir.Visible = True
    //    txtMarDebSoirMin.Visible = True
    //    txtMarFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupMar
    //      lb.Visible = False
    //    Next
    //    txtMarDebSoir.Visible = False
    //    txtMarFinSoir.Visible = False
    //    txtMarDebSoirMin.Visible = False
    //    txtMarFinSoirMin.Visible = False
    //    txtMarDebSoir = 0
    //    txtMarFinSoir = 0
    //  End If
    //End Sub

    //Private Sub chkCoupMer_Click()
    //  If chkCoupMer = 1 Then
    //    For Each lb In lblCoupMer
    //      lb.Visible = True
    //    Next
    //    txtMerDebSoir.Visible = True
    //    txtMerFinSoir.Visible = True
    //    txtMerDebSoirMin.Visible = True
    //    txtMerFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupMer
    //      lb.Visible = False
    //    Next
    //    txtMerDebSoir.Visible = False
    //    txtMerFinSoir.Visible = False
    //    txtMerDebSoirMin.Visible = False
    //    txtMerFinSoirMin.Visible = False
    //    txtMerDebSoir = 0
    //    txtMerFinSoir = 0
    //  End If
    //End Sub

    //Private Sub chkCoupSam_Click()
    //  If chkCoupSam = 1 Then
    //    For Each lb In lblCoupSam
    //      lb.Visible = True
    //    Next
    //    txtSamDebSoir.Visible = True
    //    txtSamFinSoir.Visible = True
    //    txtSamDebSoirMin.Visible = True
    //    txtSamFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupSam
    //      lb.Visible = False
    //    Next
    //    txtSamDebSoir.Visible = False
    //    txtSamFinSoir.Visible = False
    //    txtSamDebSoirMin.Visible = False
    //    txtSamFinSoirMin.Visible = False
    //    txtSamDebSoir = 0
    //    txtSamFinSoir = 0
    //  End If
    //End Sub

    //Private Sub chkCoupVen_Click()
    //  If chkCoupVen = 1 Then
    //    For Each lb In lblCoupVen
    //      lb.Visible = True
    //    Next
    //    txtVenDebSoir.Visible = True
    //    txtVenFinSoir.Visible = True
    //    txtVenDebSoirMin.Visible = True
    //    txtVenFinSoirMin.Visible = True
    //  Else
    //    For Each lb In lblCoupVen
    //      lb.Visible = False
    //    Next
    //    txtVenDebSoir.Visible = False
    //    txtVenFinSoir.Visible = False
    //    txtVenDebSoirMin.Visible = False
    //    txtVenFinSoirMin.Visible = False
    //    txtVenDebSoir = 0
    //    txtVenFinSoir = 0
    //  End If
    //End Sub
    #endregion


    /* OK ---------------------------------------------------------------------*/
    private void cmdAjoutDate_Click(object sender, System.EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtDateFerm.Text))
      {
        //  on ajoute la date dans la liste et on l'enregistre en base
        AjouterDateFermetureSiAbsente(txtDateFerm.Text, true /* reload */);
      }
    }
    //Private Sub cmdAjoutDate_Click()
    //Dim sSQL As String
    //
    //  ' on ajoute la date dans la liste et on l'enregistre en base
    //  If txtDateFerm <> "" Then
    //    
    //    ' on vérifie que la date ne soit pas encore saisie (VL 22/03 : ni dans la liste !)
    //    rsFermetureSite.Filter = "DDATEFERM = '" & txtDateFerm & "'"
    //    If rsFermetureSite.RecordCount = 0 Then
    //      lstDateFerm.AddItem txtDateFerm
    //  
    //      sSQL = "INSERT INTO TFERMETURESITE VALUES(" & miNumSit & ",'" & txtDateFerm & "')"
    //      cnx.Execute sSQL
    //    End If
    //    rsFermetureSite.Filter = ""
    //  End If
    //  
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdAjoutPer_Click(object sender, System.EventArgs e)
    {
      if (string.IsNullOrEmpty(txtDebPer.Text) || string.IsNullOrEmpty(txtFinPer.Text))
        return;

      if (txtDebPer.Text == txtFinPer.Text)
      {
        MessageBox.Show(Resources.msg_PeriodeAuMoins1jour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      DateTime dateDebPer = DateTime.Parse(txtDebPer.Text);
      DateTime dateFinPer = DateTime.Parse(txtFinPer.Text);

      while (dateDebPer <= dateFinPer)
      {
        AjouterDateFermetureSiAbsente(dateDebPer.ToShortDateString(), false /* no reload */);
        dateDebPer = dateDebPer.AddDays(1);
      }
      LoadData_FermetureSite();
    }
    //Private Sub cmdAjoutPer_Click()
    //Dim sDate As String
    //Dim dDate As Date
    //Dim sSQL As String
    //
    //  If txtDebPer = "" Or txtFinPer = "" Then Exit Sub
    //
    //  If txtDebPer = txtFinPer Then
    //    MsgBox "§La période doit être d'au moins 1 jour!§"
    //    Exit Sub
    //  End If
    //
    //  dDate = CDate(txtDebPer)
    //  sDate = txtDebPer
    //  While dDate <= CDate(txtFinPer)
    //    ' on vérifie que la date ne soir pas encore saisie
    //    rsFermetureSite.Filter = "DDATEFERM = '" & sDate & "'"
    //    If rsFermetureSite.RecordCount = 0 Then
    //      lstDateFerm.AddItem sDate
    //  
    //      sSQL = "INSERT INTO TFERMETURESITE VALUES(" & miNumSit & ",'" & sDate & "')"
    //      cnx.Execute sSQL
    //    End If
    //    rsFermetureSite.Filter = ""
    //    
    //    dDate = DateAdd("d", 1, dDate)
    //    sDate = CStr(dDate)
    //  Wend
    //  
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void AjouterDateFermetureSiAbsente(string sDateFermeture, bool bReload)
    {
      //  on vérifie que la date ne soit pas encore saisie 
      bool bDateExisteDeja = false;
      foreach (DataRow rowFermeture in dtFermetureSite.Rows)
      {
        if (string.IsNullOrEmpty(rowFermeture["DDATEFERM"].ToString()))
          continue;

        if (Convert.ToDateTime(rowFermeture["DDATEFERM"]).ToShortDateString() == sDateFermeture)
        {
          bDateExisteDeja = true;
          break;
        }
      }
      if (!bDateExisteDeja)
      {
        lstDateFerm.Items.Add(sDateFermeture);
        ModuleData.ExecuteNonQuery($"INSERT INTO TFERMETURESITE VALUES({miNumSit} , '{sDateFermeture}')");

        if (bReload)
          LoadData_FermetureSite();
      }
    }

    //Private Sub cmdDate_Click()
    //  sTypeDate = ""
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtDateFerm <> "", txtDateFerm, Now)
    //End Sub

    //Private Sub cmdDebPer_Click()
    //  sTypeDate = "§DebPer§"
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtDebPer <> "", txtDebPer, Now)
    //End Sub

    //Private Sub cmdFinPer_Click()
    //  sTypeDate = "§FinPer§"
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtFinPer <> "", txtFinPer, Now)
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdSite_Click(object sender, System.EventArgs e)
    {
      DataTable dtSite = LoadSitesClient();
      if (dtSite.Rows.Count > 0)
      {
        Enregistrer();

        frmSaisieHoraireSite frm = new frmSaisieHoraireSite();
        frm.msType = "HORAIRES";
        frm.miNumCli = miNumCli;
        frm.miNumSit = miNumSit;
        frm.dtSite = dtSite;
        frm.ShowDialog();
      }
      dtSite.Dispose();
    }
    //Private Sub cmdSite_Click()
    //Dim rsSite As ADODB.Recordset
    //  
    //  
    //  Set rsSite = New ADODB.Recordset
    //  
    //    ' recherche des sites client
    //  rsSite.Open "SELECT NSITNUM,VSITNOM FROM TSIT WHERE NCLINUM = " & miNumCli _
    //              & " AND NSITNUM <> " & miNumSit & " AND CSITACTIF = 'O' ORDER BY VSITNOM", cnx
    //  
    //  If rsSite.RecordCount > 0 Then
    //    Enregistrer
    //    frmSaisieHoraireSite.msType = "HORAIRES"
    //    Set frmSaisieHoraireSite.rsSite = rsSite.Clone
    //    frmSaisieHoraireSite.Show vbModal
    //  End If
    //  
    //  rsSite.Close
    //  
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdSiteFerm_Click(object sender, System.EventArgs e)
    {
      DataTable dtSite = LoadSitesClient();
      if (dtSite.Rows.Count > 0)
      {
        frmSaisieHoraireSite frm = new frmSaisieHoraireSite();
        frm.msType = "FERMETURES";
        frm.miNumCli = miNumCli;
        frm.miNumSit = miNumSit;
        frm.dtSite = dtSite;
        frm.ShowDialog();
      }
      dtSite.Dispose();
    }
    //Private Sub cmdSiteFerm_Click()
    //Dim rsSite As ADODB.Recordset
    //  
    //  
    //  Set rsSite = New ADODB.Recordset
    //  
    //    ' recherche des sites client
    //  rsSite.Open "SELECT NSITNUM,VSITNOM FROM TSIT WHERE NCLINUM = " & miNumCli _
    //              & " AND NSITNUM <> " & miNumSit & " AND CSITACTIF = 'O' ORDER BY VSITNOM", cnx
    //  
    //  If rsSite.RecordCount > 0 Then
    //    Enregistrer
    //    frmSaisieHoraireSite.msType = "FERMETURES"
    //    Set frmSaisieHoraireSite.rsSite = rsSite.Clone
    //    frmSaisieHoraireSite.Show vbModal
    //  End If
    //  
    //  rsSite.Close
    // 
    // 
    //End Sub


    /* OK ---------------------------------------------------------------------*/
    private DataTable LoadSitesClient()
    {
      DataTable dtSite = new DataTable();
      string sSql = $"SELECT NSITNUM,VSITNOM FROM TSIT WHERE NCLINUM = {miNumCli} AND NSITNUM <> {miNumSit} AND CSITACTIF = 'O' ORDER BY VSITNOM";
      ModuleData.LoadData(dtSite, sSql);
      return dtSite;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdSupDate_Click(object sender, System.EventArgs e)
    {
      if (lstDateFerm.SelectedIndex != -1)
      {
        //  on supprime l'enregistrement de la liste et de la base
        ModuleData.ExecuteNonQuery($"DELETE TFERMETURESITE WHERE NSITNUM = {miNumSit} AND DDATEFERM = '{lstDateFerm.SelectedItem}'");
        LoadData_FermetureSite();

        lstDateFerm.Items.RemoveAt(lstDateFerm.SelectedIndex);
        lstDateFerm.SelectedIndex = lstDateFerm.Items.Count - 1;
      }
    }
    //Private Sub cmdSupDate_Click()
    //Dim sSQL As String
    //  
    //  ' on supprime l'enregistrement de la liste et de la base
    //  
    //  If lstDateFerm.ListIndex <> -1 Then
    //    sSQL = "DELETE TFERMETURESITE WHERE NSITNUM = " & miNumSit _
    //          & " AND DDATEFERM = '" & lstDateFerm.List(lstDateFerm.ListIndex) & "'"
    //  
    //    cnx.Execute sSQL
    //    
    //    lstDateFerm.RemoveItem (lstDateFerm.ListIndex)
    //    lstDateFerm.ListIndex = lstDateFerm.ListCount - 1
    //    
    //    rsFermetureSite.Requery
    //  End If
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void InitForm()
    {
      string sSql = $"SELECT VJOUR, NDEBMATIN, NFINMATIN, NDEBSOIR, NFINSOIR, NDEBMATINMIN, NFINMATINMIN, NDEBSOIRMIN, NFINSOIRMIN, NMATAPINT FROM THORAIRES WHERE NSITNUM = {miNumSit}";
      ModuleData.LoadData(dtHoraireSite, sSql);
      foreach (DataRow rowHoraire in dtHoraireSite.Rows)
      {
        switch (rowHoraire["VJOUR"])
        {
          case "LUNDI":
            InitFormUnJour(rowHoraire, txtLunDebMat, txtLunFinMat, txtLunDebMatMin, txtLunFinMatMin,
                           chkCoupLun, new apiLabel[] { lblCoupLun0, lblCoupLun1, lblCoupLun2, lblCoupLun3, }, txtLunDebSoir, txtLunFinSoir,
                           txtLunDebSoirMin, txtLunFinSoirMin, chkIntLunMat, chkIntLunAp);
            break;

          case "MARDI":
            InitFormUnJour(rowHoraire, txtMarDebMat, txtMarFinMat, txtMarDebMatMin, txtMarFinMatMin,
                           chkCoupMar, new apiLabel[] { lblCoupMar0, lblCoupMar1, lblCoupMar2, lblCoupMar3, }, txtMarDebSoir, txtMarFinSoir,
                           txtMarDebSoirMin, txtMarFinSoirMin, chkIntMarMat, chkIntMarAp);
            break;

          case "MERCREDI":
            InitFormUnJour(rowHoraire, txtMerDebMat, txtMerFinMat, txtMerDebMatMin, txtMerFinMatMin,
                           chkCoupMer, new apiLabel[] { lblCoupMer0, lblCoupMer1, lblCoupMer2, lblCoupMer3, }, txtMerDebSoir, txtMerFinSoir,
                           txtMerDebSoirMin, txtMerFinSoirMin, chkIntMerMat, chkIntMerAp);
            break;

          case "JEUDI":
            InitFormUnJour(rowHoraire, txtJeuDebMat, txtJeuFinMat, txtJeuDebMatMin, txtJeuFinMatMin,
                           chkCoupJeu, new apiLabel[] { lblCoupJeu0, lblCoupJeu1, lblCoupJeu2, lblCoupJeu3, }, txtJeuDebSoir, txtJeuFinSoir,
                           txtJeuDebSoirMin, txtJeuFinSoirMin, chkIntJeuMat, chkIntJeuAp);
            break;

          case "VENDREDI":
            InitFormUnJour(rowHoraire, txtVenDebMat, txtVenFinMat, txtVenDebMatMin, txtVenFinMatMin,
                           chkCoupVen, new apiLabel[] { lblCoupVen0, lblCoupVen1, lblCoupVen2, lblCoupVen3, }, txtVenDebSoir, txtVenFinSoir,
                           txtVenDebSoirMin, txtVenFinSoirMin, chkIntVenMat, chkIntVenAp);
            break;

          case "SAMEDI":
            InitFormUnJour(rowHoraire, txtSamDebMat, txtSamFinMat, txtSamDebMatMin, txtSamFinMatMin,
                           chkCoupSam, new apiLabel[] { lblCoupSam0, lblCoupSam1, lblCoupSam2, lblCoupSam3, }, txtSamDebSoir, txtSamFinSoir,
                           txtSamDebSoirMin, txtSamFinSoirMin, chkIntSamMat, chkIntSamAp);
            break;

          case "DIMANCHE":
            InitFormUnJour(rowHoraire, txtDimDebMat, txtDimFinMat, txtDimDebMatMin, txtDimFinMatMin,
                           chkCoupDim, new apiLabel[] { lblCoupDim0, lblCoupDim1, lblCoupDim2, lblCoupDim3, }, txtDimDebSoir, txtDimFinSoir,
                           txtDimDebSoirMin, txtDimFinSoirMin, chkIntDimMat, chkIntDimAp);
            break;
        }
      }

      //  Remplir la liste des dates de fermeture
      LoadData_FermetureSite();

      foreach (DataRow rowFermeture in dtFermetureSite.Rows)
      {
        if (!string.IsNullOrEmpty(rowFermeture["DDATEFERM"].ToString()))
          lstDateFerm.Items.Add(rowFermeture["DDATEFERM"].ToString());
      }
    }

    /* OK ---------------------------------------------------------------------*/
    private void LoadData_FermetureSite()
    {
      string sSql2 = $"SELECT DDATEFERM FROM TFERMETURESITE WHERE NSITNUM = {miNumSit} ORDER BY DDATEFERM";
      ModuleData.LoadData(dtFermetureSite, sSql2);
    }

    /* OK ---------------------------------------------------------------------*/
    private void InitFormUnJour(DataRow rowHoraire, apiTextBox txtDayDebMat, apiTextBox txtDayFinMat, apiTextBox txtDayDebMatMin, apiTextBox txtDayFinMatMin,
                                apiCheckBox chkCoupDay, apiLabel[] lblCoupDay, apiTextBox txtDayDebSoir, apiTextBox txtDayFinSoir,
                                apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoirMin, apiCheckBox chkIntDayMat, apiCheckBox chkIntDayAp)
    {
      txtDayDebMat.Text = rowHoraire["NDEBMATIN"].ToString();
      txtDayFinMat.Text = rowHoraire["NFINMATIN"].ToString();
      txtDayDebMatMin.Text = rowHoraire["NDEBMATINMIN"].ToString();
      txtDayFinMatMin.Text = rowHoraire["NFINMATINMIN"].ToString();

      if ((int)rowHoraire["NDEBSOIR"] > 0)
      {
        chkCoupDay.Checked = true;
        foreach (apiLabel label in lblCoupDay)
          label.Visible = true;
        txtDayDebSoir.Visible = true;
        txtDayFinSoir.Visible = true;
        txtDayDebSoir.Text = rowHoraire["NDEBSOIR"].ToString();
        txtDayFinSoir.Text = rowHoraire["NFINSOIR"].ToString();
        txtDayDebSoirMin.Visible = true;
        txtDayFinSoirMin.Visible = true;
        txtDayDebSoirMin.Text = rowHoraire["NDEBSOIRMIN"].ToString();
        txtDayFinSoirMin.Text = rowHoraire["NFINSOIRMIN"].ToString();
      }

      // matin et apres midi interdit
      // le champ NMATAPINT = 0 --> aucune
      // le champ NMATAPINT = 1 --> matin
      // le champ NMATAPINT = 2 --> après-midi
      // le champ NMATAPINT = 3 --> les deux
      switch (rowHoraire["NMATAPINT"])
      {
        case 1:
          chkIntDayMat.Checked = true;
          break;
        case 2:
          chkIntDayAp.Checked = true;
          break;
        case 3:
          chkIntDayMat.Checked = true;
          chkIntDayAp.Checked = true;
          break;
      }

    }

    #region Private Sub InitForm()
    //
    //  ' on rempli les horaires par jour
    //  
    //  Set rsHoraireSite = New ADODB.Recordset
    //  
    //  rsHoraireSite.Open "SELECT VJOUR, NDEBMATIN, NFINMATIN, NDEBSOIR, NFINSOIR, NDEBMATINMIN, NFINMATINMIN, NDEBSOIRMIN, NFINSOIRMIN, NMATAPINT FROM THORAIRES WHERE NSITNUM = " & miNumSit, cnx
    //
    //  If rsHoraireSite.RecordCount > 0 Then
    //    rsHoraireSite.MoveFirst
    //    While Not rsHoraireSite.EOF
    //      Select Case rsHoraireSite("VJOUR")
    //        Case "LUNDI"
    //          txtLunDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtLunFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtLunDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtLunFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupLun = 1
    //            For Each lb In lblCoupLun
    //              lb.Visible = True
    //            Next
    //            txtLunDebSoir.Visible = True
    //            txtLunFinSoir.Visible = True
    //            txtLunDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtLunFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtLunDebSoirMin.Visible = True
    //            txtLunFinSoirMin.Visible = True
    //            txtLunDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtLunFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //          End If
    //          ' matin et apres midi interdit
    //          ' le champ NMATAPINT = 0 --> aucune
    //          ' le champ NMATAPINT = 1 --> matin
    //          ' le champ NMATAPINT = 2 --> après-midi
    //          ' le champ NMATAPINT = 3 --> les deux
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntLunMat = 1
    //            Case 2
    //              chkIntLunAp = 1
    //            Case 3
    //              chkIntLunMat = 1
    //              chkIntLunAp = 1
    //          End Select
    //        Case "MARDI"
    //          txtMarDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtMarFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtMarDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtMarFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupMar = 1
    //            For Each lb In lblCoupMar
    //              lb.Visible = True
    //            Next
    //            txtMarDebSoir.Visible = True
    //            txtMarFinSoir.Visible = True
    //            txtMarDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtMarFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtMarDebSoirMin.Visible = True
    //            txtMarFinSoirMin.Visible = True
    //            txtMarDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtMarFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //         End If
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntMarMat = 1
    //            Case 2
    //              chkIntMarAp = 1
    //            Case 3
    //              chkIntMarMat = 1
    //              chkIntMarAp = 1
    //          End Select
    //        Case "MERCREDI"
    //          txtMerDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtMerFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtMerDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtMerFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupMer = 1
    //            For Each lb In lblCoupMer
    //              lb.Visible = True
    //            Next
    //            txtMerDebSoir.Visible = True
    //            txtMerFinSoir.Visible = True
    //            txtMerDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtMerFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtMerDebSoirMin.Visible = True
    //            txtMerFinSoirMin.Visible = True
    //            txtMerDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtMerFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //          End If
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntMerMat = 1
    //            Case 2
    //              chkIntMerAp = 1
    //            Case 3
    //              chkIntMerMat = 1
    //              chkIntMerAp = 1
    //          End Select
    //        Case "JEUDI"
    //          txtJeuDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtJeuFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtJeuDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtJeuFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupJeu = 1
    //            For Each lb In lblCoupJeu
    //              lb.Visible = True
    //            Next
    //            txtJeuDebSoir.Visible = True
    //            txtJeuFinSoir.Visible = True
    //            txtJeuDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtJeuFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtJeuDebSoirMin.Visible = True
    //            txtJeuFinSoirMin.Visible = True
    //            txtJeuDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtJeuFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //          End If
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntJeuMat = 1
    //            Case 2
    //              chkIntJeuAp = 1
    //            Case 3
    //              chkIntJeuMat = 1
    //              chkIntJeuAp = 1
    //          End Select
    //        Case "VENDREDI"
    //          txtVenDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtVenFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtVenDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtVenFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupVen = 1
    //            For Each lb In lblCoupVen
    //              lb.Visible = True
    //            Next
    //            txtVenDebSoir.Visible = True
    //            txtVenFinSoir.Visible = True
    //            txtVenDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtVenFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtVenDebSoirMin.Visible = True
    //            txtVenFinSoirMin.Visible = True
    //            txtVenDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtVenFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //          End If
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntVenMat = 1
    //            Case 2
    //              chkIntVenAp = 1
    //            Case 3
    //              chkIntVenMat = 1
    //              chkIntVenAp = 1
    //          End Select
    //        Case "SAMEDI"
    //          txtSamDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtSamFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtSamDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtSamFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupSam = 1
    //            For Each lb In lblCoupSam
    //              lb.Visible = True
    //            Next
    //            txtSamDebSoir.Visible = True
    //            txtSamFinSoir.Visible = True
    //            txtSamDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtSamFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtSamDebSoirMin.Visible = True
    //            txtSamFinSoirMin.Visible = True
    //            txtSamDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtSamFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //          End If
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntSamMat = 1
    //            Case 2
    //              chkIntSamAp = 1
    //            Case 3
    //              chkIntSamMat = 1
    //              chkIntSamAp = 1
    //          End Select
    //        Case "DIMANCHE"
    //          txtDimDebMat = ZeroIfNull(rsHoraireSite("NDEBMATIN"))
    //          txtDimFinMat = ZeroIfNull(rsHoraireSite("NFINMATIN"))
    //          txtDimDebMatMin = ZeroIfNull(rsHoraireSite("NDEBMATINMIN"))
    //          txtDimFinMatMin = ZeroIfNull(rsHoraireSite("NFINMATINMIN"))
    //          If ZeroIfNull(rsHoraireSite("NDEBSOIR")) > 0 Then
    //            chkCoupDim = 1
    //            For Each lb In lblCoupDim
    //              lb.Visible = True
    //            Next
    //            txtDimDebSoir.Visible = True
    //            txtDimFinSoir.Visible = True
    //            txtDimDebSoir = ZeroIfNull(rsHoraireSite("NDEBSOIR"))
    //            txtDimFinSoir = ZeroIfNull(rsHoraireSite("NFINSOIR"))
    //            txtDimDebSoirMin.Visible = True
    //            txtDimFinSoirMin.Visible = True
    //            txtDimDebSoirMin = ZeroIfNull(rsHoraireSite("NDEBSOIRMIN"))
    //            txtDimFinSoirMin = ZeroIfNull(rsHoraireSite("NFINSOIRMIN"))
    //          End If
    //          Select Case ZeroIfNull(rsHoraireSite("NMATAPINT"))
    //            Case 1
    //              chkIntDimMat = 1
    //            Case 2
    //              chkIntDimAp = 1
    //            Case 3
    //              chkIntDimMat = 1
    //              chkIntDimAp = 1
    //          End Select
    //      End Select
    //      rsHoraireSite.MoveNext
    //    Wend
    //  End If
    //  
    //  ' on rempli la liste des dates de fermeture
    //  Set rsFermetureSite = New ADODB.Recordset
    //  
    //  rsFermetureSite.Open "SELECT CONVERT(varchar(10),DDATEFERM,103) as DDATEFERM FROM TFERMETURESITE WHERE NSITNUM = " & miNumSit & " ORDER BY DDATEFERM", cnx
    //  If rsFermetureSite.RecordCount > 0 Then
    //    rsFermetureSite.MoveFirst
    //    While Not rsFermetureSite.EOF
    //      lstDateFerm.AddItem rsFermetureSite("DDATEFERM")
    //      rsFermetureSite.MoveNext
    //    Wend
    //    lstDateFerm.ListIndex = 0
    //  End If
    //
    //
    #endregion //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdEnregistrer_Click(object sender, System.EventArgs e)
    {
      Enregistrer();
      Dispose();
    }
    //Private Sub cmdEnregistrer_Click()
    //
    //  Enregistrer
    //  Unload Me
    //  
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void Enregistrer()
    {

      EnregistrerUnJour("LUNDI", chkIntLunMat, chkIntLunAp, txtLunDebMat, txtLunDebMatMin, txtLunFinMat, txtLunFinMatMin, txtLunDebSoir, txtLunDebSoirMin, txtLunFinSoir, txtLunFinSoirMin);
      EnregistrerUnJour("MARDI", chkIntMarMat, chkIntMarAp, txtMarDebMat, txtMarDebMatMin, txtMarFinMat, txtMarFinMatMin, txtMarDebSoir, txtMarDebSoirMin, txtMarFinSoir, txtMarFinSoirMin);
      EnregistrerUnJour("MERCREDI", chkIntMerMat, chkIntMerAp, txtMerDebMat, txtMerDebMatMin, txtMerFinMat, txtMerFinMatMin, txtMerDebSoir, txtMerDebSoirMin, txtMerFinSoir, txtMerFinSoirMin);
      EnregistrerUnJour("JEUDI", chkIntJeuMat, chkIntJeuAp, txtJeuDebMat, txtJeuDebMatMin, txtJeuFinMat, txtJeuFinMatMin, txtJeuDebSoir, txtJeuDebSoirMin, txtJeuFinSoir, txtJeuFinSoirMin);
      EnregistrerUnJour("VENDREDI", chkIntVenMat, chkIntVenAp, txtVenDebMat, txtVenDebMatMin, txtVenFinMat, txtVenFinMatMin, txtVenDebSoir, txtVenDebSoirMin, txtVenFinSoir, txtVenFinSoirMin);
      EnregistrerUnJour("SAMEDI", chkIntSamMat, chkIntSamAp, txtSamDebMat, txtSamDebMatMin, txtSamFinMat, txtSamFinMatMin, txtSamDebSoir, txtSamDebSoirMin, txtSamFinSoir, txtSamFinSoirMin);
      EnregistrerUnJour("DIMANCHE", chkIntDimMat, chkIntDimAp, txtDimDebMat, txtDimDebMatMin, txtDimFinMat, txtDimFinMatMin, txtDimDebSoir, txtDimDebSoirMin, txtDimFinSoir, txtDimFinSoirMin);
    }

    /* OK ---------------------------------------------------------------------*/
    private void EnregistrerUnJour(string sJour, apiCheckBox chkIntDayMat, apiCheckBox chkIntDayAp, apiTextBox txtDayDebMat, apiTextBox txtDayDebMatMin, apiTextBox txtDayFinMat, apiTextBox txtDayFinMatMin,
                                   apiTextBox txtDayDebSoir, apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoir, apiTextBox txtDayFinSoirMin)
    {
      int iDemijourneeInterdite = 0;

      if (chkIntDayMat.Checked)
        iDemijourneeInterdite = 1;
      if (chkIntDayAp.Checked)
        iDemijourneeInterdite += 2;

      if (VerifierExistenceUnJour(sJour))
      {
        ModuleData.ExecuteNonQuery($"UPDATE THORAIRES SET NDEBMATIN = '{txtDayDebMat.Text}',NDEBMATINMIN = '{txtDayDebMatMin.Text}',NFINMATIN = '{txtDayFinMat.Text}',NFINMATINMIN = '{txtDayFinMatMin.Text}',"
                                  + $"NDEBSOIR = '{txtDayDebSoir.Text}',NDEBSOIRMIN = '{txtDayDebSoirMin.Text}',NFINSOIR = '{txtDayFinSoir.Text}',NFINSOIRMIN = '{txtDayFinSoirMin.Text}',NMATAPINT = {iDemijourneeInterdite}"
                                  + $"WHERE VJOUR = '{sJour}' AND NSITNUM = {miNumSit}");
      }
      else
      {
        ModuleData.ExecuteNonQuery($"INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) "
            + $"VALUES({miNumSit}, '{sJour}', '{txtDayDebMat.Text}', '{txtDayFinMat.Text}', '{txtDayDebSoir.Text}', '{txtDayFinSoir.Text}', '{txtDayDebMatMin.Text}', '{txtDayFinMatMin.Text}', '{txtDayDebSoirMin.Text}', '{txtDayFinSoirMin.Text}', {iDemijourneeInterdite})");
      }
    }
    /* OK ---------------------------------------------------------------------*/
    bool VerifierExistenceUnJour(string sJour)
    {
      bool bJourExisteDeja = false;

      foreach (DataRow rowHoraire in dtHoraireSite.Rows)
      {
        if ((string)rowHoraire["VJOUR"] == sJour)
        {
          bJourExisteDeja = true;
          break;
        }
      }
      return bJourExisteDeja;
    }
    //Private Sub Enregistrer()
    //Dim sSQL As String
    //Dim iDemijourneeInterdite As Integer
    //
    //  ' on fait un update/insert par jour
    //  rsHoraireSite.Filter = "VJOUR = 'LUNDI'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntLunMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntLunAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtLunDebMat & " ,NDEBMATINMIN = " & txtLunDebMatMin _
    //          & " ,NFINMATIN = " & txtLunFinMat & " ,NFINMATINMIN = " & txtLunFinMatMin & " ,NDEBSOIR = " & txtLunDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtLunDebSoirMin & " ,NFINSOIR = " & txtLunFinSoir & " ,NFINSOIRMIN = " & txtLunFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'LUNDI' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'LUNDI'," & txtLunDebMat & "," & txtLunFinMat & "," & txtLunDebSoir & "," & txtLunFinSoir _
    //          & "," & txtLunDebMatMin & "," & txtLunFinMatMin & "," & txtLunDebSoirMin & "," & txtLunFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //
    //  cnx.Execute sSQL
    //
    //  rsHoraireSite.Filter = "VJOUR = 'MARDI'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntMarMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntMarAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtMarDebMat & " ,NDEBMATINMIN = " & txtMarDebMatMin _
    //          & " ,NFINMATIN = " & txtMarFinMat & " ,NFINMATINMIN = " & txtMarFinMatMin & " ,NDEBSOIR = " & txtMarDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtMarDebSoirMin & " ,NFINSOIR = " & txtMarFinSoir & " ,NFINSOIRMIN = " & txtMarFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'MARDI' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'MARDI'," & txtMarDebMat & "," & txtMarFinMat & "," & txtMarDebSoir & "," & txtMarFinSoir _
    //          & "," & txtMarDebMatMin & "," & txtMarFinMatMin & "," & txtMarDebSoirMin & "," & txtMarFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //    
    //  cnx.Execute sSQL
    //  
    //  rsHoraireSite.Filter = "VJOUR = 'MERCREDI'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntMerMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntMerAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtMerDebMat & " ,NDEBMATINMIN = " & txtMerDebMatMin _
    //          & " ,NFINMATIN = " & txtMerFinMat & " ,NFINMATINMIN = " & txtMerFinMatMin & " ,NDEBSOIR = " & txtMerDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtMerDebSoirMin & " ,NFINSOIR = " & txtMerFinSoir & " ,NFINSOIRMIN = " & txtMerFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'MERCREDI' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'MERCREDI'," & txtMerDebMat & "," & txtMerFinMat & "," & txtMerDebSoir & "," & txtMerFinSoir _
    //          & "," & txtMerDebMatMin & "," & txtMerFinMatMin & "," & txtMerDebSoirMin & "," & txtMerFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //    
    //  cnx.Execute sSQL
    //  
    //  rsHoraireSite.Filter = "VJOUR = 'JEUDI'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntJeuMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntJeuAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtJeuDebMat & " ,NDEBMATINMIN = " & txtJeuDebMatMin _
    //          & " ,NFINMATIN = " & txtJeuFinMat & " ,NFINMATINMIN = " & txtJeuFinMatMin & " ,NDEBSOIR = " & txtJeuDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtJeuDebSoirMin & " ,NFINSOIR = " & txtJeuFinSoir & " ,NFINSOIRMIN = " & txtJeuFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'JEUDI' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'JEUDI'," & txtJeuDebMat & "," & txtJeuFinMat & "," & txtJeuDebSoir & "," & txtJeuFinSoir _
    //          & "," & txtJeuDebMatMin & "," & txtJeuFinMatMin & "," & txtJeuDebSoirMin & "," & txtJeuFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //    
    //  cnx.Execute sSQL
    //  
    //  rsHoraireSite.Filter = "VJOUR = 'VENDREDI'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntVenMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntVenAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtVenDebMat & " ,NDEBMATINMIN = " & txtVenDebMatMin _
    //          & " ,NFINMATIN = " & txtVenFinMat & " ,NFINMATINMIN = " & txtVenFinMatMin & " ,NDEBSOIR = " & txtVenDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtVenDebSoirMin & " ,NFINSOIR = " & txtVenFinSoir & " ,NFINSOIRMIN = " & txtVenFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'VENDREDI' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'VENDREDI'," & txtVenDebMat & "," & txtVenFinMat & "," & txtVenDebSoir & "," & txtVenFinSoir _
    //          & "," & txtVenDebMatMin & "," & txtVenFinMatMin & "," & txtVenDebSoirMin & "," & txtVenFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //    
    //  cnx.Execute sSQL
    //  
    //  rsHoraireSite.Filter = "VJOUR = 'SAMEDI'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntSamMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntSamAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtSamDebMat & " ,NDEBMATINMIN = " & txtSamDebMatMin _
    //          & " ,NFINMATIN = " & txtSamFinMat & " ,NFINMATINMIN = " & txtSamFinMatMin & " ,NDEBSOIR = " & txtSamDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtSamDebSoirMin & " ,NFINSOIR = " & txtSamFinSoir & " ,NFINSOIRMIN = " & txtSamFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'SAMEDI' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'SAMEDI'," & txtSamDebMat & "," & txtSamFinMat & "," & txtSamDebSoir & "," & txtSamFinSoir _
    //          & "," & txtSamDebMatMin & "," & txtSamFinMatMin & "," & txtSamDebSoirMin & "," & txtSamFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //    
    //  cnx.Execute sSQL
    //  
    //  rsHoraireSite.Filter = "VJOUR = 'DIMANCHE'"
    //  
    //  iDemijourneeInterdite = 0
    //  If chkIntDimMat = 1 Then iDemijourneeInterdite = 1
    //  If chkIntDimAp = 1 Then iDemijourneeInterdite = iDemijourneeInterdite + 2
    //  
    //  If rsHoraireSite.RecordCount = 1 Then
    //    sSQL = "UPDATE THORAIRES SET NDEBMATIN = " & txtDimDebMat & " ,NDEBMATINMIN = " & txtDimDebMatMin _
    //          & " ,NFINMATIN = " & txtDimFinMat & " ,NFINMATINMIN = " & txtDimFinMatMin & " ,NDEBSOIR = " & txtDimDebSoir _
    //          & " ,NDEBSOIRMIN = " & txtDimDebSoirMin & " ,NFINSOIR = " & txtDimFinSoir & " ,NFINSOIRMIN = " & txtDimFinSoirMin & ", NMATAPINT = " & iDemijourneeInterdite _
    //          & " WHERE VJOUR = 'DIMANCHE' AND NSITNUM = " & miNumSit
    //  Else
    //    sSQL = "INSERT INTO THORAIRES(NSITNUM,VJOUR,NDEBMATIN,NFINMATIN,NDEBSOIR,NFINSOIR,NDEBMATINMIN,NFINMATINMIN,NDEBSOIRMIN,NFINSOIRMIN,NMATAPINT) " _
    //          & " VALUES(" & miNumSit & ",'DIMANCHE'," & txtDimDebMat & "," & txtDimFinMat & "," & txtDimDebSoir & "," & txtDimFinSoir _
    //          & "," & txtDimDebMatMin & "," & txtDimFinMatMin & "," & txtDimDebSoirMin & "," & txtDimFinSoirMin & "," & iDemijourneeInterdite & ")"
    //  End If
    //    
    //  cnx.Execute sSQL
    //End Sub

    //Private Sub Form_Unload(Cancel As Integer)
    //
    //  rsFermetureSite.Close
    //  rsHoraireSite.Close
    //
    //End Sub

    //Private Sub txtDimDebMat_GotFocus()
    //  txtDimDebMat.SelStart = 0: txtDimDebMat.SelLength = 2
    //End Sub



    /* OK ---------------------------------------------------------------------*/
    private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
    }

    #region txt<Day><>_KeyPress(KeyAscii As Integer)
    //Private Sub txtDimDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimDebSoir_GotFocus()
    //  txtDimDebSoir.SelStart = 0: txtDimDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtDimDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimFinMat_GotFocus()
    //  txtDimFinMat.SelStart = 0: txtDimFinMat.SelLength = 2
    //End Sub

    //Private Sub txtDimFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimFinSoir_GotFocus()
    //  txtDimFinSoir.SelStart = 0: txtDimFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtDimFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimDebMatMin_GotFocus()
    //  txtDimDebMatMin.SelStart = 0: txtDimDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtDimDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimDebSoirMin_GotFocus()
    //  txtDimDebSoirMin.SelStart = 0: txtDimDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtDimDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimFinMatMin_GotFocus()
    //  txtDimFinMatMin.SelStart = 0: txtDimFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtDimFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtDimFinSoirMin_GotFocus()
    //  txtDimFinSoirMin.SelStart = 0: txtDimFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtDimFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuDebMat_GotFocus()
    //  txtJeuDebMat.SelStart = 0: txtJeuDebMat.SelLength = 2
    //End Sub

    //Private Sub txtJeuDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuDebSoir_GotFocus()
    //  txtJeuDebSoir.SelStart = 0: txtJeuDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtJeuDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuFinMat_GotFocus()
    //  txtJeuFinMat.SelStart = 0: txtJeuFinMat.SelLength = 2
    //End Sub

    //Private Sub txtJeuFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuFinSoir_GotFocus()
    //  txtJeuFinSoir.SelStart = 0: txtJeuFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtJeuFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuDebMatMin_GotFocus()
    //  txtJeuDebMatMin.SelStart = 0: txtJeuDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtJeuDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuDebSoirMin_GotFocus()
    //  txtJeuDebSoirMin.SelStart = 0: txtJeuDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtJeuDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuFinMatMin_GotFocus()
    //  txtJeuFinMatMin.SelStart = 0: txtJeuFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtJeuFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtJeuFinSoirMin_GotFocus()
    //  txtJeuFinSoirMin.SelStart = 0: txtJeuFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtJeuFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunDebMat_GotFocus()
    //  txtLunDebMat.SelStart = 0: txtLunDebMat.SelLength = 2
    //End Sub

    //Private Sub txtLunDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunDebSoir_GotFocus()
    //  txtLunDebSoir.SelStart = 0: txtLunDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtLunDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunFinMat_GotFocus()
    //  txtLunFinMat.SelStart = 0: txtLunFinMat.SelLength = 2
    //End Sub

    //Private Sub txtLunFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunFinSoir_GotFocus()
    //  txtLunFinSoir.SelStart = 0: txtLunFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtLunFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunDebMatMin_GotFocus()
    //  txtLunDebMatMin.SelStart = 0: txtLunDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtLunDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunDebSoirMin_GotFocus()
    //  txtLunDebSoirMin.SelStart = 0: txtLunDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtLunDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunFinMatMin_GotFocus()
    //  txtLunFinMatMin.SelStart = 0: txtLunFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtLunFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtLunFinSoirMin_GotFocus()
    //  txtLunFinSoirMin.SelStart = 0: txtLunFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtLunFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarDebMat_GotFocus()
    //  txtMarDebMat.SelStart = 0: txtMarDebMat.SelLength = 2
    //End Sub

    //Private Sub txtMarDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarDebSoir_GotFocus()
    //  txtMarDebSoir.SelStart = 0: txtMarDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtMarDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarFinMat_GotFocus()
    //  txtMarFinMat.SelStart = 0: txtMarFinMat.SelLength = 2
    //End Sub

    //Private Sub txtMarFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarFinSoir_GotFocus()
    //  txtMarFinSoir.SelStart = 0: txtMarFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtMarFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarDebMatMin_GotFocus()
    //  txtMarDebMatMin.SelStart = 0: txtMarDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtMarDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarDebSoirMin_GotFocus()
    //  txtMarDebSoirMin.SelStart = 0: txtMarDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtMarDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarFinMatMin_GotFocus()
    //  txtMarFinMatMin.SelStart = 0: txtMarFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtMarFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMarFinSoirMin_GotFocus()
    //  txtMarFinSoirMin.SelStart = 0: txtMarFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtMarFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerDebMat_GotFocus()
    //  txtMerDebMat.SelStart = 0: txtMerDebMat.SelLength = 2
    //End Sub

    //Private Sub txtMerDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerDebSoir_GotFocus()
    //  txtMerDebSoir.SelStart = 0: txtMerDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtMerDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerFinMat_GotFocus()
    //  txtMerFinMat.SelStart = 0: txtMerFinMat.SelLength = 2
    //End Sub

    //Private Sub txtMerFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerFinSoir_GotFocus()
    //  txtMerFinSoir.SelStart = 0: txtMerFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtMerFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerDebMatMin_GotFocus()
    //  txtMerDebMatMin.SelStart = 0: txtMerDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtMerDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerDebSoirMin_GotFocus()
    //  txtMerDebSoirMin.SelStart = 0: txtMerDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtMerDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerFinMatMin_GotFocus()
    //  txtMerFinMatMin.SelStart = 0: txtMerFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtMerFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtMerFinSoirMin_GotFocus()
    //  txtMerFinSoirMin.SelStart = 0: txtMerFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtMerFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamDebMat_GotFocus()
    //  txtSamDebMat.SelStart = 0: txtSamDebMat.SelLength = 2
    //End Sub

    //Private Sub txtSamDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamDebSoir_GotFocus()
    //  txtSamDebSoir.SelStart = 0: txtSamDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtSamDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamFinMat_GotFocus()
    //  txtSamFinMat.SelStart = 0: txtSamFinMat.SelLength = 2
    //End Sub

    //Private Sub txtSamFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamFinSoir_GotFocus()
    //  txtSamFinSoir.SelStart = 0: txtSamFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtSamFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamDebMatMin_GotFocus()
    //  txtSamDebMatMin.SelStart = 0: txtSamDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtSamDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamDebSoirMin_GotFocus()
    //  txtSamDebSoirMin.SelStart = 0: txtSamDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtSamDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamFinMatMin_GotFocus()
    //  txtSamFinMatMin.SelStart = 0: txtSamFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtSamFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtSamFinSoirMin_GotFocus()
    //  txtSamFinSoirMin.SelStart = 0: txtSamFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtSamFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenDebMat_GotFocus()
    //  txtVenDebMat.SelStart = 0: txtVenDebMat.SelLength = 2
    //End Sub

    //Private Sub txtVenDebMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenDebSoir_GotFocus()
    //  txtVenDebSoir.SelStart = 0: txtVenDebSoir.SelLength = 2
    //End Sub

    //Private Sub txtVenDebSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenFinMat_GotFocus()
    //  txtVenFinMat.SelStart = 0: txtVenFinMat.SelLength = 2
    //End Sub

    //Private Sub txtVenFinMat_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenFinSoir_GotFocus()
    //  txtVenFinSoir.SelStart = 0: txtVenFinSoir.SelLength = 2
    //End Sub

    //Private Sub txtVenFinSoir_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenDebMatMin_GotFocus()
    //  txtVenDebMatMin.SelStart = 0: txtVenDebMatMin.SelLength = 2
    //End Sub

    //Private Sub txtVenDebMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenDebSoirMin_GotFocus()
    //  txtVenDebSoirMin.SelStart = 0: txtVenDebSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtVenDebSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenFinMatMin_GotFocus()
    //  txtVenFinMatMin.SelStart = 0: txtVenFinMatMin.SelLength = 2
    //End Sub

    //Private Sub txtVenFinMatMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    //Private Sub txtVenFinSoirMin_GotFocus()
    //  txtVenFinSoirMin.SelStart = 0: txtVenFinSoirMin.SelLength = 2
    //End Sub

    //Private Sub txtVenFinSoirMin_KeyPress(KeyAscii As Integer)
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    #endregion


  }
}
