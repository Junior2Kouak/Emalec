using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixDate : Form
  {
    public frmChoixDate()
    {
      InitializeComponent();
    }
    /* OK -------------------------------------------------------------------------------------*/
    private void frmChoixDate_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        cboClient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient ORDER BY VCLINOM", "", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, false);

        txtDateA0.Text = "01/01/" + DateTime.Now.Year;
        txtDateA1.Text = DateTime.Now.ToShortDateString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    // 
    //On Error GoTo Handler
    // 
    //  InitBoutons Me, frmMenu
    // 
    //  If cnxRep.state = adStateOpen Then cnxRep.Close
    //  
    //  
    //  ' TB SAMSIC CITY BASE
    //  cnxRep.Open gstrConnexion
    //  ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
    //  cnxRep.CommandTimeout = 150
    // 
    //  RemplirComboClient cboclient
    //   
    //  txtDateA(0) = "01/01/" & Year(Date)
    //  txtDateA(1) = Date
    //  Exit Sub
    //  
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      try
      {
        //test de la sélection d'un client
        if (cboClient.GetText() == "")
        {
          MessageBox.Show(Resources.msg_select_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //test des dates
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateFin, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        Cursor = Cursors.WaitCursor;

        //case du détail par site et du global
        if (!chkSite.Checked)
        {
          //type de stat ( urgence technique prestation)
          frmResultatStat f = new frmResultatStat();
          f.mstrCboClient = cboClient.GetText();
          f.mstrTxtDate0 = txtDateA0.Text;
          f.mstrTextDate1 = txtDateA1.Text;

          frmStatContratClient fContratClient = new frmStatContratClient();

          if (optInter0.Checked) f.mstrTypeStat = "U";
          if (optInter1.Checked) f.mstrTypeStat = "P";
          if (optInter2.Checked) f.mstrTypeStat = "T";
          if (optInter3.Checked)
          {
            fContratClient.msNomClient = cboClient.GetText();
            fContratClient.miNumClient = cboClient.GetItemData().ToString();
            fContratClient.dateFrom = Convert.ToDateTime(txtDateA0.Text);
            fContratClient.dateTo = Convert.ToDateTime(txtDateA1.Text);
            fContratClient.Show();
            return;
          }

          //type de sortie (nombre ou montant)
          if (optInfo0.Checked)
          {
            f.mstrInfoRetour = "N";
            f.miNumClient = cboClient.GetItemData();
            f.ShowDialog();
          }
          else
          {
            f.mstrInfoRetour = "F";
            f.miNumClient = cboClient.GetItemData();
            f.ShowDialog();
          }
        }
        else
        { //par site

          //type de stat (urgence technique prestation contrat)
          frmStatNbParSite f = new frmStatNbParSite();
          f.mstrClient = cboClient.GetText();
          f.mstrTxtDate0 = txtDateA0.Text;
          f.mstrTxtDate1 = txtDateA1.Text;

          if (optInter0.Checked) f.mstrTypeStat = "U";
          if (optInter1.Checked) f.mstrTypeStat = "P";
          if (optInter2.Checked) f.mstrTypeStat = "T";
          if (optInter3.Checked) f.mstrTypeStat = "C";

          // type de sortie (nombre ou montant(F))
          if (optInfo0.Checked)
          {
            f.mstrInfoRetour = "N";
            f.miNumClient = cboClient.GetItemData();
            f.ShowDialog();
          }
          else
          {
            f.mstrInfoRetour = "F";
            f.miNumClient = cboClient.GetItemData();
            f.ShowDialog();
          }
        }

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub cmdValider_Click()
    //
    //
    // ' test de la sélection d'un client
    //  If Not cboclient.Text <> "" Then
    //    MsgBox "§Sélectionnez un client§"
    //    Exit Sub
    //  End If
    //
    //  ' test des dates
    //  If txtDateA(0) = "" Then
    //    MsgBox "§il faut saisir une date de début§"
    //    Exit Sub
    //  End If
    //  
    //  If txtDateA(1) = "" Then
    //    MsgBox "§il faut saisir une date de fin§"
    //    Exit Sub
    //  End If
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' cas du détail par site et du global
    //  If chkSite.value = 0 Then
    //  
    //    ' type de stat ( urgence technique perstation )
    //    If optInter(0) Then frmResultatStat.mstrTypeStat = "U"
    //    If optInter(1) Then frmResultatStat.mstrTypeStat = "P"
    //    If optInter(2) Then frmResultatStat.mstrTypeStat = "T"
    //    If optInter(3) Then
    //      frmStatContratClient.mstrNomClient = cboclient.Text
    //      frmStatContratClient.miNumClient = cboclient.ItemData(cboclient.ListIndex)
    //      frmStatContratClient.Show vbModal
    //      Exit Sub
    //    End If
    //    
    //    ' type de sortie ( nombre ou montant )
    //    If optInfo(0) Then
    //      frmResultatStat.mstrInfoRetour = "N"
    //      frmResultatStat.miNumClient = Me.cboclient.ItemData(cboclient.ListIndex)
    //      frmResultatStat.Show vbModal
    //    Else
    //      frmResultatStat.mstrInfoRetour = "F"
    //      frmResultatStat.miNumClient = Me.cboclient.ItemData(cboclient.ListIndex)
    //      frmResultatStat.Show vbModal
    //    End If
    //  
    //  Else  'par site
    //  
    //    ' type de stat ( urgence technique prestation contrat)
    //    If optInter(0) Then frmStatNbParSite.mstrTypeStat = "U"
    //    If optInter(1) Then frmStatNbParSite.mstrTypeStat = "P"
    //    If optInter(2) Then frmStatNbParSite.mstrTypeStat = "T"
    //    If optInter(3) Then frmStatNbParSite.mstrTypeStat = "C"
    //    
    //    ' type de sortie ( nombre ou montant(F) )
    //    If optInfo(0) Then
    //      frmStatNbParSite.mstrInfoRetour = "N"
    //      frmStatNbParSite.miNumClient = Me.cboclient.ItemData(cboclient.ListIndex)
    //      frmStatNbParSite.Show vbModal
    //    Else
    //      frmStatNbParSite.mstrInfoRetour = "F"
    //      frmStatNbParSite.miNumClient = Me.cboclient.ItemData(cboclient.ListIndex)
    //      frmStatNbParSite.Show vbModal
    //    End If
    //      
    //  End If
    //  Screen.MousePointer = vbDefault
    //
    //
    //Exit Sub
    //Resume
    //Handler:
    //  If Err.Number = -2147467259 Then
    //    cnxRep.Close
    //    ' cnxRep.Open gstrConnexionStringReplique
    //    
    //    ' TB SAMSIC CITY BASE
    //    cnxRep.Open gstrConnexion
    //    ' cnxRep.Open "PROVIDER=SQLOLEDB.1;Initial Catalog=MULTI;Data Source=" & gstrNomServeur & ";trusted_connection=yes;App=" & gstrNomSociete & ";"
    //    
    //    cnxRep.CommandTimeout = 150
    //    cmdValider_Click
    //  Else
    //    Screen.MousePointer = vbDefault
    //    ShowError "Valide_click dans " & Me.Name
    //  End If
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    //Private Sub cmdDate1_Click()
    //    
    //On Error GoTo Handler
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //      
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    //Private Sub cmdDate2_Click()
    // 
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //      
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    //Private Sub Calendar1_Click()
    //
    //  Me.txtDateA(iTextBoxDate) = Calendar1.value
    //  Calendar1.Visible = False
    //  
    //Exit Sub
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* inutile -------------------------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //    If cnxRep.state = adStateOpen Then cnxRep.Close
    //End Sub

  }
}