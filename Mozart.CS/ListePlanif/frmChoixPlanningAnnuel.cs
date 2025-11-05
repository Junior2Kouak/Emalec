using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixPlanningAnnuel : Form
  {
    DataTable dt = new DataTable();
    int miAnnee;
    //Dim adoRS As ADODB.Recordset
    //Dim miAnnee As Integer

    int iNb_act_by_contrat_Total;
    int iNb_Realise_Total;
    int iNb_Planifie_Total;

    static readonly int[] semainesSpeciales = { 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57 };

    public frmChoixPlanningAnnuel() { InitializeComponent(); }

    private void frmChoixPlanningAnnuel_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        miAnnee = DateTime.Now.Year;

        //ouverture du recordset
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select VCLINOM, NCLINUM from TCLI WHERE VSOCIETE = '{MozartParams.NomSociete}' AND CCLIACTIF='O' ORDER BY VCLINOM");
        ApiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //    
    //  InitBoutons Me, frmMenu
    //        
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select VCLINOM, NCLINUM from TCLI WHERE VSOCIETE = '" & gstrNomSociete & "' AND CCLIACTIF='O' ORDER BY VCLINOM", cnx
    //
    //  miAnnee = Year(Date)
    //  gsCodeRetour = ""
    //
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //   
    //Exit Sub
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      //planning prèv chaff
      if (optInter2.Checked)
      {
        CreationPlanning("Chaff");
        return;
      }

      //test de la sélection d'un client
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null)
      {
        MessageBox.Show(Resources.msg_selectionner_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //type de stat (urgence technique perstation)
      if (optInter0.Checked)
        CreationPlanning("VisuClient");
      else if (optInter3.Checked)
        CreationPlanning("VisuLDR");
      else if (optInter4.Checked)
        CreationPlanning("VisuContrat");
      else if (optInter5.Checked)
        CreationPlanning("VisuContrat2ans");
      else if (optInter1.Checked)
      {
        new frmModifPlanningAn()
        {
          miNumClient = (int)row["NCLINUM"],
          sNomClient = (string)row["VCLINOM"],
          iContrat = (int)cboTypeContrat.SelectedValue,
          sTypePrest = cboPrestation.Text,
          iAnnee = Convert.ToInt32(cboAnnee.Text)
        }.ShowDialog();
      }
    }
    //Private Sub cmdValider_Click()
    //
    //  ' planning prèv chaff
    //  If optInter(2) Then
    //    CreationPlanning "CHAFF"
    //    Exit Sub
    //  End If
    //  
    // ' test de la sélection d'un client
    //  If adoRS.EOF Then
    //      MsgBox "§ il faut sélectionner un client§"
    //      Exit Sub
    //  End If
    //
    //  ' type de stat ( urgence technique perstation )
    //  If optInter(0) Then CreationPlanning "VisuClient"
    //  If optInter(3) Then CreationPlanning "VisuLDR"
    //  
    //  If optInter(4) Then CreationPlanning "VisuContrat"
    //  
    //  If optInter(5) Then CreationPlanning "VisuContrat2ans"
    //   
    //  If optInter(1) Then
    //    
    //    Screen.MousePointer = vbHourglass
    //         
    //    frmModifPlanningAn.miNumClient = adoRS("NCLINUM")
    //    frmModifPlanningAn.sNomClient = adoRS("VCLINOM")
    //    frmModifPlanningAn.icontrat = cboTypeContrat.ItemData(cboTypeContrat.ListIndex)
    //    frmModifPlanningAn.sTypePrest = cboPrestation.Text
    //    frmModifPlanningAn.iAnnee = cboAnnee.Text
    //    frmModifPlanningAn.Show vbModal
    //    
    //    Screen.MousePointer = vbDefault
    //  End If
    //
    //Exit Sub
    //Handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      ApiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3500);
      ApiGrid.AddColumn(Resources.col_NumClient, "NCLINUM", 0);

      ApiGrid.InitColumnList();
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo Handler
    //
    //  ApiGrid.AddColumn "§Client§", 3500
    //  ApiGrid.AddColumn "§NumClient§", 0
    //    
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //      
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void optInter_Click(object sender, EventArgs e)
    {
      if (optInter0.Checked)
      {
        ApiGrid.Visible = true;
        cboCHAFF.Visible = false;
        lblChaff.Visible = false;
        cboTypeContrat.Visible = false;
        lblCont.Visible = false;
        cboAnnee.Visible = false;
        lblannee.Visible = false;
        cboPrestation.Visible = false;
        lblPrest.Visible = false;
      }
      else if (optInter1.Checked)
      {
        RemplirCboTypeContrat();
        ApiGrid.Visible = true;
        cboCHAFF.Visible = false;
        lblChaff.Visible = false;
        cboTypeContrat.Visible = true;
        lblCont.Visible = true;
        cboAnnee.Visible = true;
        lblannee.Visible = true;
        cboPrestation.Visible = true;
        lblPrest.Visible = true;
      }
      else if (optInter2.Checked)
      {
        RemplirComboCHAFF();
        ApiGrid.Visible = false;
        cboCHAFF.Visible = true;
        lblChaff.Visible = true;
        cboTypeContrat.Visible = false;
        lblCont.Visible = false;
        cboAnnee.Visible = false;
        lblannee.Visible = false;
        cboPrestation.Visible = false;
        lblPrest.Visible = false;
      }
      else if (optInter3.Checked)
      {
        ApiGrid.Visible = true;
        cboCHAFF.Visible = false;
        lblChaff.Visible = false;
        cboTypeContrat.Visible = false;
        lblCont.Visible = false;
        cboAnnee.Visible = false;
        lblannee.Visible = false;
        cboPrestation.Visible = false;
        lblPrest.Visible = false;
      }
      else if (optInter4.Checked)
      {
        RemplirCboTypeContrat();
        ApiGrid.Visible = true;
        cboCHAFF.Visible = false;
        lblChaff.Visible = false;
        cboTypeContrat.Visible = true;
        lblCont.Visible = true;
        cboAnnee.Visible = true;
        lblannee.Visible = true;
        cboPrestation.Visible = false;
        lblPrest.Visible = false;
      }
      else if (optInter5.Checked)
      {
        RemplirCboTypeContrat();
        ApiGrid.Visible = true;
        cboCHAFF.Visible = false;
        lblChaff.Visible = false;
        cboTypeContrat.Visible = true;
        lblCont.Visible = true;
        cboAnnee.Visible = true;
        lblannee.Visible = true;
        cboPrestation.Visible = false;
        lblPrest.Visible = false;
      }
      miAnnee = DateTime.Now.Year;
    }
    void RemplirComboCHAFF()
    {
      ModuleData.RemplirCombo(cboCHAFF, "select * from api_v_comboCHAFF order by VPERNOM", true);
      cboCHAFF.ValueMember = "NPERNUM";
      cboCHAFF.DisplayMember = "VPERNOM";
    }
    //Private Sub optInter_Click(Index As Integer)
    //
    //Select Case Index
    //  Case 0
    //    ApiGrid.Visible = True
    //    cboCHAFF.Visible = False
    //    lblChaff.Visible = False
    //    cboTypeContrat.Visible = False
    //    lblCont.Visible = False
    //    cboAnnee.Visible = False
    //    lblannee.Visible = False
    //    cboPrestation.Visible = False
    //    lblPrest.Visible = False
    //  Case 1
    //    RemplirCboTypeContrat
    //    ApiGrid.Visible = True
    //    cboCHAFF.Visible = False
    //    lblChaff.Visible = False
    //    cboTypeContrat.Visible = True
    //    lblCont.Visible = True
    //    cboAnnee.Visible = True
    //    lblannee.Visible = True
    //    cboPrestation.Visible = True
    //    lblPrest.Visible = True
    //  Case 2
    //    RemplirComboCHAFF cboCHAFF
    //    ApiGrid.Visible = False
    //    cboCHAFF.Visible = True
    //    lblChaff.Visible = True
    //    cboTypeContrat.Visible = False
    //    lblCont.Visible = False
    //    cboAnnee.Visible = False
    //    lblannee.Visible = False
    //    cboPrestation.Visible = False
    //    lblPrest.Visible = False
    //  Case 3
    //    ApiGrid.Visible = True
    //    cboCHAFF.Visible = False
    //    lblChaff.Visible = False
    //    cboTypeContrat.Visible = False
    //    lblCont.Visible = False
    //    cboAnnee.Visible = False
    //    lblannee.Visible = False
    //    cboPrestation.Visible = False
    //    lblPrest.Visible = False
    //  Case 4
    //    RemplirCboTypeContrat
    //    ApiGrid.Visible = True
    //    cboCHAFF.Visible = False
    //    lblChaff.Visible = False
    //    cboTypeContrat.Visible = True
    //    lblCont.Visible = True
    //    cboAnnee.Visible = True
    //    lblannee.Visible = True
    //    cboPrestation.Visible = False
    //    lblPrest.Visible = False
    //  Case 5
    //    RemplirCboTypeContrat
    //    ApiGrid.Visible = True
    //    cboCHAFF.Visible = False
    //    lblChaff.Visible = False
    //    cboTypeContrat.Visible = True
    //    lblCont.Visible = True
    //    cboAnnee.Visible = True
    //    lblannee.Visible = True
    //    cboPrestation.Visible = False
    //    lblPrest.Visible = False
    //End Select
    //
    //miAnnee = Year(Date)
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void ApiGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      RemplirCboTypeContrat();
    }
    //Private Sub apigrid_RowColChange()
    //  RemplirCboTypeContrat
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CreationPlanning(string stype)
    {
      try
      {
        DataRow row = ApiGrid.GetFocusedDataRow();
        if (row == null) return;
        //affichage curseur
        Cursor.Current = Cursors.WaitCursor;

        switch (stype)
        {
          case "Chaff":
            GeneratePlanningChaff((int)cboCHAFF.SelectedValue, miAnnee);
            break;
          case "VisuClient":
            AffichePlanning("Prev");
            break;
          case "VisuLDR":
            AffichePlanning("LDR");
            break;
          case "VisuContrat":
            AffichePlanning("CONTRAT");
            break;
          case "VisuContrat2ans":
            AffichePlanning("CONTRAT2");
            break;
        }

        Cursor.Current = Cursors.Default;

        frmBrowser frm = new frmBrowser()
        {
          msInfosMail = $"TCCL|NCLINUM|{row["NCLINUM"]}",
          msStartingAddress = $@"{MozartParams.CheminUtilisateurMozart}t.html",
          miPlanningAn = 0,
          mbFleches = true
        };

        frm.ShowDialog();

        if (frm.gsCodeRetour == "S")
        {
          // année suivante
          miAnnee++;
          cmdValider_Click(null, null);
        }
        else if (frm.gsCodeRetour == "P")
        {
          // année précédente
          miAnnee--;
          cmdValider_Click(null, null);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub CreationPlanning(stype As String)
    //' UPGRADE_INFO (#0501): The 'ntri' member isn't used anywhere in current application.
    //' Dim ntri As Integer
    //
    //  On Error GoTo Handler
    //      
    //  ' affichage curseur
    //  Me.MousePointer = vbHourglass
    //    
    //  Select Case stype
    //    Case "CHAFF"
    //      GeneratePlanningChaff cboCHAFF.ItemData(cboCHAFF.ListIndex), miAnnee
    //    Case "VisuClient"
    //      AffichePlanning "Prev"
    //    Case "VisuLDR"
    //      AffichePlanning "LDR"
    //    Case "VisuContrat"
    //      AffichePlanning "CONTRAT"
    //    Case "VisuContrat2ans"
    //      AffichePlanning "CONTRAT2"
    //  End Select
    //
    //  frmBrowser.InfosMail = "TCCL|NCLINUM|" & adoRS("NCLINUM")
    //  frmBrowser.StartingAddress = gstrCheminUtilisateur & "\Mozart\t.html"
    //  frmBrowser.bPlanningAn = 0 '1
    //  frmBrowser.cmdPrec.Visible = True
    //  frmBrowser.cmdSuiv.Visible = True
    //  frmBrowser.Show vbModal
    //    
    //  Me.MousePointer = vbDefault
    //
    //  If gsCodeRetour = "S" Then
    //    ' année suivante
    //    miAnnee = miAnnee + 1
    //    cmdValider_Click
    //  ElseIf gsCodeRetour = "P" Then
    //    'année précédente
    //    miAnnee = miAnnee - 1
    //    cmdValider_Click
    //  End If
    //  frmBrowser.bPlanningAn = 0
    //
    //  
    //Exit Sub
    //Handler:
    //  ShowError "PlanningChaff dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void AffichePlanning(string stype)
    {
      try
      {

        iNb_act_by_contrat_Total = 0;
        iNb_Realise_Total = 0;
        iNb_Planifie_Total = 0;

        DataRow row = ApiGrid.GetFocusedDataRow();
        if (row == null) return;

        string sSql = "";
        string aux = "";
        StringBuilder strHtml = new StringBuilder(2000);

        //dans le cas des LDR, on ne prend que le contrat Hors contrat
        if (stype == "LDR")
        {
          //contrat du client
          sSql = "select distinct R.VTYPECONTRAT, R.NTYPECONTRAT from TACT WITH (NOLOCK), TDIN WITH (NOLOCK), TREF_TYPECONTRAT R WITH (NOLOCK) where CPRECOD='L'" +
                 $" AND R.NTYPECONTRAT=TDIN.NTYPECONTRAT AND TDIN.NCLINUM = {row["NCLINUM"]}" +
                 $" AND TDIN.NDINNUM = TACT.NDINNUM AND LANGUE='{MozartParams.Langue}'";
        }
        else if (stype == "CONTRAT" || stype == "CONTRAT2")
        {
          //contrat du client
          sSql = "select distinct R.VTYPECONTRAT, R.NTYPECONTRAT from TDIN WITH (NOLOCK), TREF_TYPECONTRAT R WITH (NOLOCK)" +
                 $" WHERE TDIN.NCLINUM = {row["NCLINUM"]}" +
                 $" AND R.NTYPECONTRAT=TDIN.NTYPECONTRAT AND R.VTYPECONTRAT = '{cboTypeContrat.Text}' AND LANGUE='{MozartParams.Langue}'";
        }
        else
        {
          //contrat du client
          sSql = "select distinct R.VTYPECONTRAT, R.NTYPECONTRAT from TACT WITH (NOLOCK), TDIN WITH (NOLOCK), TREF_TYPECONTRAT R WITH (NOLOCK) where CPRECOD='P'" +
                 $" AND R.NTYPECONTRAT=TDIN.NTYPECONTRAT AND TDIN.NCLINUM = {row["NCLINUM"]}" +
                 $" AND TDIN.NDINNUM = TACT.NDINNUM AND LANGUE='{MozartParams.Langue}'";
        }

        //recherche des différents types de contrat
        using (SqlDataReader sdr = ModuleData.ExecuteReader(sSql))
        {
          strHtml.Append("<html><head><title> Planning annuel</title></head><body>");
          strHtml.Append("<BR>");

          //entete synthese total
          strHtml.Append($"<br/><br/>");
          //légende
          strHtml.Append("<table border=1 cellpadding=4 cellspacing=0 width=60% style=margin-left:auto;margin-right:auto;>");
          strHtml.Append($"<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>TOTAL</b></td>");
          strHtml.Append("<td bgcolor=#FF0000 style='text-align:center' valign='center'><FONT FACE=arial size=2><b>#NB_PROG_ANNUEL_TOTAL#</p></td><td><FONT FACE=arial size=2>Nb Programme annuel</td>");
          strHtml.Append($"<td bgcolor=#FF9900 style='text-align:center' valign='center'><FONT FACE=arial size=2><b>#NB_PLANIFIE_TOTAL#</p></td><td><FONT FACE=arial size=2>Nb Planifiées par {MozartParams.NomSociete}</td>");
          strHtml.Append("<td bgcolor=#33CC00 style='text-align:center' valign='center'><FONT FACE=arial size=2><b>#NB_REALISE_TOTAL#</p></td><td><FONT FACE=arial size=2>Nb Réalisées</td>");
          strHtml.Append("</tr></table>");
          strHtml.Append($"<br/><br/>");

          while (sdr.Read())
          {
            if (stype == "CONTRAT2")
              aux = GeneratePlanning2ans(stype, Utils.BlankIfNull(sdr[0]), miAnnee, (int)row["NCLINUM"], 0, (int)Utils.ZeroIfNull(sdr[1]));
            else
              aux = GeneratePlanning(stype, Utils.BlankIfNull(sdr[0]), miAnnee, (int)row["NCLINUM"], 0, (int)Utils.ZeroIfNull(sdr[1]));

            strHtml.Append(aux);
            if (aux != "")
              strHtml.Append("<BR>");
          }
        }
        //si il n'y a rien
        if (!strHtml.ToString().Contains("Site"))
        {
          strHtml.Append("Aucun planning préventif");
        }
        else
        {
          //légende
          strHtml.Append("<table border=1 cellpadding=4 cellspacing=0 width=60%>");
          strHtml.Append("<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>Légende</b></td>");
          strHtml.Append("<td bgcolor=#FFFFCC><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Congés</td>");
          strHtml.Append("<td bgcolor=#FF0000><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Programme annuel</td>");
          strHtml.Append($"<td bgcolor=#FF9900><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planifié par {MozartParams.NomSociete}");
          strHtml.Append("<td bgcolor=#33CC00><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Réalisé</td>");
          strHtml.Append("</tr></table>");
        }

        strHtml.Append("</body></html>");

        //mise à jour des totaux
        strHtml.Replace("#NB_PROG_ANNUEL_TOTAL#", iNb_act_by_contrat_Total.ToString());
        strHtml.Replace("#NB_REALISE_TOTAL#", iNb_Realise_Total.ToString());
        strHtml.Replace("#NB_PLANIFIE_TOTAL#", iNb_Planifie_Total.ToString());

        File.WriteAllText($@"{MozartParams.CheminUtilisateurMozart}t.html", strHtml.ToString(), Encoding.Default);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub AffichePlanning(stype As String)
    //
    //Dim strHtml As String
    //Dim rs As New Recordset
    //Dim sSql As String
    //Dim aux As String
    //
    //  
    //  On Error GoTo Handler
    //
    //  ccOffset2 = 0
    //  strHtml = ""
    //  
    //  ' dans le cas des LDR, on ne prend que le contrat Hors contrat
    //  If stype = "LDR" Then
    //      ' contrat du client
    //      sSql = "select distinct R.VTYPECONTRAT, R.NTYPECONTRAT from TACT WITH (NOLOCK), TDIN WITH (NOLOCK), TREF_TYPECONTRAT R WITH (NOLOCK) where CPRECOD='L' "
    //      sSql = sSql + "AND R.NTYPECONTRAT=TDIN.NTYPECONTRAT AND TDIN.NCLINUM = " & adoRS("NCLINUM")
    //      sSql = sSql + " AND TDIN.NDINNUM = TACT.NDINNUM AND LANGUE='" & gstrLangue & "'"
    //  ElseIf stype = "CONTRAT" Or stype = "CONTRAT2" Then
    //      ' contrat du client
    //      sSql = "select distinct R.VTYPECONTRAT, R.NTYPECONTRAT from TDIN WITH (NOLOCK), TREF_TYPECONTRAT R WITH (NOLOCK) "
    //      sSql = sSql + "WHERE TDIN.NCLINUM = " & adoRS("NCLINUM")
    //      sSql = sSql + " AND R.NTYPECONTRAT=TDIN.NTYPECONTRAT AND R.VTYPECONTRAT = '" & cboTypeContrat.Text & "' AND LANGUE='" & gstrLangue & "'"
    //  Else
    //      ' contrat du client
    //      sSql = "select distinct R.VTYPECONTRAT, R.NTYPECONTRAT from TACT WITH (NOLOCK), TDIN WITH (NOLOCK), TREF_TYPECONTRAT R WITH (NOLOCK) where CPRECOD='P' "
    //      sSql = sSql + " AND R.NTYPECONTRAT=TDIN.NTYPECONTRAT AND TDIN.NCLINUM = " & adoRS("NCLINUM")
    //      sSql = sSql + " AND TDIN.NDINNUM = TACT.NDINNUM AND LANGUE='" & gstrLangue & "'"
    //  End If
    //  
    //    
    //    ' recherche des différents type de contrat
    //    rs.Open sSql, cnx
    //    
    //  
    //    Concat2 strHtml, "<html><head><title> Planning annuel</title></head><body>" & vbCrLf
    //    Concat2 strHtml, "<BR>"
    //    
    //    While Not rs.EOF
    //      If stype = "CONTRAT2" Then
    //        aux = GeneratePlanning2ans(stype, rs(0), miAnnee, adoRS("NCLINUM"), , rs(1))
    //      Else
    //        aux = GeneratePlanning(stype, rs(0), miAnnee, adoRS("NCLINUM"), , rs(1))
    //      End If
    //      Concat2 strHtml, aux
    //      If aux <> "" Then
    //        Concat2 strHtml, "<BR>"
    //      End If
    //      rs.MoveNext
    //    Wend
    //  
    //  ' si il n'y a rien,
    //  If InStr(1, strHtml, "SITE", vbTextCompare) = 0 Then
    //    Concat2 strHtml, "Aucun planning préventif"
    //  Else
    //  ' légende
    //   Concat2 strHtml, "<table border=1 cellpadding=4 cellspacing=0 width=60%>" & vbCrLf
    //   Concat2 strHtml, "<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>Légende</b></td>" & vbCrLf
    //   Concat2 strHtml, "<td bgcolor=#FFFFCC><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Congés</td>"
    //   Concat2 strHtml, "<td bgcolor=#FF0000><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Programme annuel</td>"
    //   Concat2 strHtml, "<td bgcolor=#FF9900><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planifié par " & gstrNomSociete & "</td>"
    //   Concat2 strHtml, "<td bgcolor=#33CC00><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Réalisé</td>"
    //   Concat2 strHtml, "</tr></table>" & vbCrLf
    //  End If
    //  
    //  
    //  Concat2 strHtml, "</body></html>"
    //  strHtml = left$(strHtml, ccOffset2)
    //
    //  
    //  Dim fs As New Scripting.FileSystemObject
    //  Dim ts As TextStream
    //  Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\t.html", ForWriting, True)
    //  ts.Write strHtml
    //  ts.Close
    //
    //Exit Sub
    //Handler:
    //  ShowError " GenenrateLesPlanning dans " & Me.Name
    //End Sub
    //

    public string GeneratePlanning2ans(string sType, string Contrat, int iAnnee, int iclient, int ntri, int icontrat)
    {

      int iNb_Realise = 0;
      int iNb_Planifie = 0;
      int iNb_act_by_contrat = 0;

      StringBuilder strHtml = new StringBuilder(2000);
      DataTable dt = new DataTable();

      if (ntri == 0) ntri = 1;
      // recherche des informations
      ModuleData.LoadData(dt, $"api_sp_PlanningAnnuelContrat2ans {iclient}, {ntri}, {iAnnee}, {icontrat}, ''");

      string debut = $"01/01/{iAnnee - 1}";
      string fin = $"31/12/{iAnnee}";

      if (dt.Rows.Count != 0)
      {
        //nom du client
        strHtml.Append($@"<TABLE width=100%><TR><TD width=15% """"style=font-face=tahoma; font-size=24pt;""""><H2> {dt.Rows[0]["VCLINOM"]} </H2></TD>");
        strHtml.Append($@"<TD width=75% ><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning 2 ans des interventions du contrat : {Contrat} : du {debut} au {fin} </CENTER></H3></TD>");
        strHtml.Append($"<TD width=10%><H3></H3></TD></TR></font></TABLE>");

        //ligne synthese
        // Tableau des numéros de semaine
        strHtml.Append($"<br/><br/>");
        //légende
        strHtml.Append("<table border=1 cellpadding=4 cellspacing=0 width=60%>");
        strHtml.Append($"<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>{Contrat}</b></td>");
        strHtml.Append("<td bgcolor=#FF0000><FONT FACE=arial size=2>#NB_PROG_ANNUEL#</td><td><FONT FACE=arial size=2>Nb Programme annuel</td>");
        strHtml.Append($"<td bgcolor=#FF9900><FONT FACE=arial size=2>#NB_PLANIFIE#</td><td><FONT FACE=arial size=2>Nb Planifiées par {MozartParams.NomSociete}");
        strHtml.Append("<td bgcolor=#33CC00><FONT FACE=arial size=2>#NB_REALISE#</td><td><FONT FACE=arial size=2>Nb Réalisées</td>");
        strHtml.Append("</tr></table>");
        strHtml.Append($"<br/><br/>");

        //Tableau des numéros de semaine
        strHtml.Append("<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>");
        strHtml.Append("<td width=17% bgcolor=#B0C0CC><FONT face=arial size=2pt;><b>Site</b></font></td>");
        strHtml.Append("<td width=4% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>N°</b></td>");
        strHtml.Append("<td width=7% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Région</b></td>");
        strHtml.Append("<td width=5% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Décalage</b></td>");

        //écriture des numéro de semaine
        for (int i = 1; i < 53; i++)
        {
          strHtml.Append($"<td bgcolor=#B0C0CC><FONT size=1> {Strings.Format(i, "00")} </td>");
        }

        strHtml.Append("<td bgcolor=black><FONT size=1>--</td>");

        int semEncours = UtilsPlan.WeekOfDate(DateTime.Today);
        for (int i = 1; i < 53; i++)
        {
          if (i == semEncours)
            strHtml.Append($"<td bgcolor=#EAEAFF><FONT size=1>{i.ToString("00")}</td>");
          else
            strHtml.Append($"<td bgcolor=#B0C0CC><FONT size=1>{i.ToString("00")}</td>");
        }

        // total
        strHtml.Append("<td bgcolor=#B0C0CC><FONT size=1>Total</td></tr>");

        for (int nb = 0; nb < dt.Rows.Count / 2; nb++)
        {
          // Site client et planning de ce site
          dt.DefaultView.RowFilter = $"ANNEE = {iAnnee - 1}";
          strHtml.Append($"<tr><td bgcolor=white><font face=Arial size=1>{Utils.BlankIfNull(dt.DefaultView[nb].Row["VSITNOM"])}</FONT></td>");
          strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{Utils.BlankIfNull(dt.DefaultView[nb].Row["NSITNUE"])}</FONT></td>");
          strHtml.Append($@"<td bgcolor=white><font face=Arial size=1>{(Utils.BlankIfNull(dt.DefaultView[nb].Row["VSITREG"]) == "" ? "&nbsp;" : dt.DefaultView[nb].Row["VSITREG"])}</FONT></td>");
          strHtml.Append($@"<td bgcolor=white align=center><font face=Arial size=1>{(Convert.IsDBNull(dt.DefaultView[nb].Row["DECALAGE"]) ? "&nbsp;" : dt.DefaultView[nb].Row["DECALAGE"])}</FONT></td>");

          for (int iVar = 0; iVar < 2; iVar++)
          {
            dt.DefaultView.RowFilter = $"ANNEE = {iAnnee - 1 + iVar}";

            if (iVar == 1) strHtml.Append("<td bgcolor=black><FONT size=1>&nbsp;</td>");

            for (int i = 6; i < 58; i++)
            {
              string sColor = "";
              char car = dt.DefaultView[nb].Row[i].ToString().ToUpper()[0];
              switch (car)
              {
                case 'V':
                  if (semainesSpeciales.Contains(i)) sColor = "#FEFFE6";
                  else sColor = "white";
                  if (i == semEncours + 5 && iVar == 1) sColor = "#EAEAFF";// pour colorer la semaine en cour
                  break;
                case 'I': sColor = "#FF0000"; break;
                case 'P': sColor = "#FF9900"; ++iNb_Planifie; ++iNb_act_by_contrat; break;
                case 'X': sColor = "#33CC00"; ++iNb_Realise; ++iNb_act_by_contrat; break;
              }

              strHtml.Append($@"<td bgcolor={sColor} onClick=""alert('DI{dt.DefaultView[nb].Row[i].ToString().ToUpper().Substring(2)}');""><font style=""CURSOR:Hand;FONT-FAMILY:Arial;FONT-SIZE:4pt;"">&nbsp;</font></td>");
            }

            if (iVar == 1)
              strHtml.Append($@"<td bgcolor=white style=""font-face=arial; font-size=7pt;""><NOBR>{dt.DefaultView[nb].Row["TOTAL"]}</NOBR></td></tr>");

            // boucle sur les 2 années
          }
        }
        strHtml.Append("</table>");

        //mise à jour des totaux
        strHtml.Replace("#NB_PROG_ANNUEL#", iNb_act_by_contrat.ToString());
        strHtml.Replace("#NB_REALISE#", iNb_Realise.ToString());
        strHtml.Replace("#NB_PLANIFIE#", iNb_Planifie.ToString());

        iNb_act_by_contrat_Total = iNb_act_by_contrat_Total + iNb_act_by_contrat;
        iNb_Realise_Total = iNb_Realise_Total + iNb_Realise;
        iNb_Planifie_Total = iNb_Planifie_Total + iNb_Planifie;
      }
      return strHtml.ToString();
    }
    //    Public Function GeneratePlanning2ans(sType As String, Contrat As String, iAnnee As Integer, iclient As Integer, Optional ntri As Integer, Optional icontrat As Integer) As String

    //Dim strHtml As String
    //Dim i, j, k As Integer
    //Dim sColor As String
    //Dim rs As New Recordset
    //Dim TRs As New Recordset
    //Dim scontrat
    //Dim TypePlanning As String
    //Dim D, F
    //Dim iVar As Integer
    //Dim iPos As Integer
    //
    //
    //  On Error GoTo handler
    //
    //
    //  ccOffset = 0
    //  strHtml = ""
    //
    //  If(IsNull(ntri) Or ntri = 0) Then ntri = 1
    //
    //  ' recherche des informations
    //
    //  rs.Open "api_sp_PlanningAnnuelContrat2ans " & iclient & ", " & ntri & ", " & iAnnee & ", " & icontrat & ", ''", cnx
    //  TypePlanning = "LDR"
    //
    //
    //  D = "01/01/" & iAnnee - 1
    //  F = "31/12/" & iAnnee
    //
    //  If Not rs.EOF Then
    //    ' nom du client
    //    Concat strHtml, "<TABLE width=100%><TR><TD width=15% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & rs("VCLINOM") & " </H2></TD>"
    //
    //    Concat strHtml, "<TD width=75% ><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning 2 ans des interventions du contrat : " & Contrat & " : du " & D & " au " & F & "</CENTER></H3></TD>"
    //
    //    Concat strHtml, "<TD width=10%><H3></H3></TD></TR></font></TABLE>"
    //
    //    ' Tableau des numéros de semaine
    //    Concat strHtml, "<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>" & vbCrLf
    //    Concat strHtml, "<td width=17% bgcolor=#B0C0CC><FONT face=arial size=2pt;><b>Site</b></font></td>"
    //    Concat strHtml, "<td width=4% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>N°</b></td>"
    //    Concat strHtml, "<td width=7% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Région</b></td>"
    //    Concat strHtml, "<td width=5% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Décalage</b></td>"
    //
    //    ' écriture des numéro de semaine
    //    For i = 1 To 52
    //      Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>"
    //    Next
    //
    //    Concat strHtml, "<td bgcolor=black><FONT size=1>--</td>"
    //
    //    For i = 1 To 52
    //      If i = DatePart("ww", Date) - 1 Then
    //        Concat strHtml, "<td bgcolor=#EAEAFF><FONT size=1>" & Format(i, "00") & "</td>"
    //      Else
    //        Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>"
    //      End If
    //    Next
    //
    //    ' total
    //    Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>Tot</td>"
    //    Concat strHtml, "</tr>" & vbCrLf
    //
    //
    //        While Not rs.EOF
    //          ' Site client et planning de ce site
    //          Concat strHtml, "<tr><td bgcolor=white ><font face=Arial size=1>" & rs("VSITNOM") & "</FONT></td> "
    //          Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("NSITNUE") & "</FONT></td> "
    //          Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & IIf(rs("VSITREG") = "" Or IsNull(rs("VSITREG")), "&nbsp;", rs("VSITREG")) & "</FONT></td> "
    //          Concat strHtml, "<td bgcolor=white align=center><font face=Arial size=1>" & IIf(rs("DECALAGE") = "" Or IsNull(rs("DECALAGE")), "&nbsp;", rs("DECALAGE")) & "</FONT></td> "
    //
    //          iVar = 0
    //
    //          While iVar< 2
    //            iPos = rs.AbsolutePosition
    //            rs.Filter = "ANNEE = " & iAnnee - 1 + iVar
    //            rs.AbsolutePosition = iPos
    //'          If iVar = 0 Then j = 57
    //'          If iVar = 1 Then j = 109
    //
    //
    //           If iVar = 1 Then Concat strHtml, "<td bgcolor=black><FONT size=1>&nbsp;</td>"
    //           For i = 6 To 57
    //
    //
    //                Select Case Left(Majuscule(rs(i)), 1)
    //                  Case "V", " "
    //                    Select Case i
    //                        Case 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57
    //                             sColor = "#FEFFE6"
    //                        Case Else
    //                             sColor = "white"
    //                    End Select
    //
    //
    //                    If(i = DatePart("ww", Date) + 4) And(iVar = 1) Then sColor = "#EAEAFF"  'pour colorer la semaine en cour '
    //                  Case "I": sColor = "#FF0000"
    //                  Case "P": sColor = "#FF9900"
    //                  Case "X": sColor = "#33CC00"
    //                End Select
    //
    //
    //              Concat strHtml, "<td bgcolor=" & sColor & " onClick=""alert('DI" & Mid(Majuscule(rs(i)), 2) & "');""><font style=""CURSOR:Hand;FONT-FAMILY:Arial;FONT-SIZE:4pt;"">&nbsp;</font></td>" & vbCrLf
    //
    //            Next
    //
    //
    //            If iVar = 1 Then
    //              Concat strHtml, "<td bgcolor=white style=""font-face=arial; font-size=7pt;""><NOBR>" & rs("TOTAL") & "</NOBR></td>" & vbCrLf
    //              Concat strHtml, "</tr>"
    //            End If
    //
    //
    //            iVar = iVar + 1
    //
    //            ' boucle sur les 2 années
    //          Wend
    //          rs.MoveNext
    //         Wend
    //
    //    Concat strHtml, "</table>" & vbCrLf
    //
    //  End If
    //
    //  rs.Close
    //
    //  ' retour résultat
    //  strHtml = Left$(strHtml, ccOffset)
    //  GeneratePlanning2ans = strHtml
    //
    //
    //Exit Function
    //Resume
    //handler:
    //  ShowError " GeneratePlanning dans modMain"
    //End Function
    /* --------------------------------------------------------------------------------------- */
    private void RemplirCboTypeContrat()
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null) return;

      //  les contrats du client uniquement
      ModuleData.RemplirCombo(cboTypeContrat, "api_sp_TypeContratClient " + row["NCLINUM"].ToString(), true);
      cboTypeContrat.ValueMember = "NTYPECONTRAT";
      cboTypeContrat.DisplayMember = "VCONTRAT";

      ////   les années
      for (int j = -1; j <= 3; j++)
        cboAnnee.Items.Add(DateTime.Now.AddYears(-j).Year);
      cboAnnee.SelectedIndex = 1;

    }
    //Private Sub RemplirCboTypeContrat()
    //
    //Dim i As Integer
    //Dim pRS As ADODB.Recordset
    //
    //  
    //  ' vider les combos
    //  cboTypeContrat.Clear
    //  cboAnnee.Clear
    //  
    //  ' test de selection
    //  If adoRS.EOF Then Exit Sub
    //  
    //  ' les années
    //  For i = -1 To 3
    //    cboAnnee.AddItem Year(DateAdd("yyyy", -i, Date))
    //  Next
    //  cboAnnee.ListIndex = 1
    //
    //  ' les contrats du client uniquement
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "api_sp_TypeContratClient " & adoRS("NCLINUM"), cnx
    //  
    //  i = 0
    //  While Not pRS.EOF
    //    cboTypeContrat.AddItem CStr(pRS(0))
    //    cboTypeContrat.ItemData(i) = pRS(1)
    //    i = i + 1
    //    pRS.MoveNext
    //  Wend
    //  cboTypeContrat.ListIndex = 0
    //
    //  pRS.Close
    //  
    //End Sub
    //

    public string GeneratePlanning(string sType, string Contrat, int iAnnee, int iclient, int ntri, int icontrat)
    {

      int iNb_Realise = 0;
      int iNb_Planifie = 0;
      int iNb_act_by_contrat = 0;

      StringBuilder strHtml = new StringBuilder(2000);

      if (ntri == 0) ntri = 1;
      string sql, typePlanning;

      //  recherche des informations
      if (sType == "P" || sType == "Prev")
      {
        sql = $"api_sp_PlanningAnnuel2 {iclient}, {ntri}, {iAnnee}, {icontrat}, 'P'";
        typePlanning = Resources.col_preventif;
      }
      else if (sType == "CONTRAT")
      {
        sql = $"api_sp_PlanningAnnuelContrat {iclient}, {ntri}, {iAnnee}, {icontrat}, ''";
        typePlanning = "CONTRAT";
      }
      else
      {
        sql = $"api_sp_PlanningAnnuelLDR {iclient}, {ntri}, {iAnnee}, {icontrat}, 'L'";
        typePlanning = "LDR";
      }

      string budgdeb, budgfin;
      using (SqlDataReader reader = ModuleData.ExecuteReader($"select distinct dbudgdeb, dbudgfin from tbudg, tsit where nbudgannee = {iAnnee} and tsit.nsitnum = tbudg.nsitnum and nclinum = {iclient}"))
      {

        if (reader.Read())
        {
          budgdeb = Utils.DateBlankIfNull(reader["dbudgdeb"]);
          budgfin = Utils.DateBlankIfNull(reader["dbudgfin"]);
        }
        else
        {
          budgdeb = $"01/01/{iAnnee}";
          budgfin = $"31/12/{iAnnee}";
        }
      }

      using (SqlDataReader readerSql = ModuleData.ExecuteReader(sql))
      {
        if (readerSql.Read())
        {
          int nbsites = 0;
          // nom du client
          strHtml.Append($@"<TABLE width=100%><TR><TD width=15% """"style=font-face=tahoma; font-size=24pt;""""><H2>{Utils.BlankIfNull(readerSql["VCLINOM"])} </H2></TD>");

          if (sType == "LDR")
          {
            strHtml.Append($@"<TD width=75%><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel {typePlanning} {Contrat} : du {budgdeb} au {budgfin}</CENTER></H3></TD>");
          }
          else if (sType == "CONTRAT")
          {
            strHtml.Append($@"<TD width=75%><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel des interventions du contrat : {Contrat} : du {budgdeb} au {budgfin}</CENTER></H3></TD>");
          }
          else
          {
            if (sType == "P" || sType == "Prev") nbsites = (int)Utils.ZeroIfNull(readerSql["NB"]);
            strHtml.Append($@"<TD width=75%><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel {typePlanning} contrat {Contrat} ({nbsites}{(nbsites > 1 ? " sites" : " site")}) : du {budgdeb} au {budgfin}</CENTER></H3></TD>");
          }
          strHtml.Append("<TD width=10%><H3></H3></TD></TR></font></TABLE>");

          //ligne synthese
          // Tableau des numéros de semaine
          strHtml.Append($"<br/><br/>");
          //légende
          strHtml.Append("<table border=1 cellpadding=4 cellspacing=0 width=60%>");
          strHtml.Append($"<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>{Contrat}</b></td>");
          strHtml.Append("<td bgcolor=#FF0000><FONT FACE=arial size=2>#NB_PROG_ANNUEL#</td><td><FONT FACE=arial size=2>Nb Programme annuel</td>");
          strHtml.Append($"<td bgcolor=#FF9900><FONT FACE=arial size=2>#NB_PLANIFIE#</td><td><FONT FACE=arial size=2>Nb Planifiées par {MozartParams.NomSociete}");
          strHtml.Append("<td bgcolor=#33CC00><FONT FACE=arial size=2>#NB_REALISE#</td><td><FONT FACE=arial size=2>Nb Réalisées</td>");
          strHtml.Append("</tr></table>");
          strHtml.Append($"<br/><br/>");


          // Tableau des numéros de semaine
          strHtml.Append($"<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>");
          if (nbsites != 0) strHtml.Append($"<td width=17% bgcolor=#B0C0CC><FONT face=arial size=2pt;><b>Site ({nbsites}{(nbsites > 1 ? " sites" : " site")})</b></font></td>");
          else strHtml.Append($"<td width=17% bgcolor=#B0C0CC><FONT face=arial size=2pt;></font></td>");
          strHtml.Append($"<td width=4% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>N°</b></td>" +
                         $"<td width=7% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Région</b></td>");

          // cas standard ou décalé
          // pb de numéro de semaine en 2005 et 2006 la fonction n'est pas bonne
          DateTime d = Convert.ToDateTime(budgdeb);
          int sem = UtilsPlan.WeekOfDate(d);
          if (sem >= 52 && d.Month == 1) sem = 1;
          int semEncours = UtilsPlan.WeekOfDate(DateTime.Today);

          // écriture des numéro de semaine
          for (int i = sem; i < 53; i++)
          {
            if (i == semEncours)
              strHtml.Append($"<td bgcolor=#EAEAFF><FONT size=1>{i.ToString("00")}</td>");
            else
              strHtml.Append($"<td bgcolor=#B0C0CC><FONT size=1>{i.ToString("00")}</td>");
          }

          // si décalage
          if (sem != 1)
          {
            for (int i = 1; i < sem; i++)
              strHtml.Append($"<td bgcolor=#B0C0CC><FONT size=1>{i.ToString("00")}</td>");
          }

          // total
          strHtml.Append("<td bgcolor=#B0C0CC><FONT size=1>Total</td>");
          strHtml.Append("</tr>");

          do
          {
            // Site client et planning de ce site
            strHtml.Append($"<tr><td bgcolor=white><font face=Arial size=1>{Utils.BlankIfNull(readerSql["VSITNOM"])}</FONT></td> ");
            strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{Utils.BlankIfNull(readerSql["NSITNUE"])}</FONT></td> ");
            strHtml.Append($@"<td bgcolor=white><font face=Arial size=1>{(Utils.BlankIfNull(readerSql["VSITREG"]) == "" ? "&nbsp;" : Utils.BlankIfNull(readerSql["VSITREG"]))}</FONT></td> ");

            for (int i = 6 + sem - 1; i < 58; i++)
            {
              string sColor = "";
              char car = readerSql[i].ToString().ToUpper()[0];
              switch (car)
              {
                case 'V':
                  if (semainesSpeciales.Contains(i)) sColor = "#FEFFE6";
                  else sColor = "white";
                  if (i == semEncours + 5) sColor = "#EAEAFF";// pour colorer la semaine en cour
                  break;
                case 'I': sColor = "#FF0000"; break;
                case 'P': sColor = "#FF9900"; ++iNb_Planifie; ++iNb_act_by_contrat; break;
                case 'X': sColor = "#33CC00"; ++iNb_Realise; ++iNb_act_by_contrat; break;
              }
              if (Utils.BlankIfNull(readerSql["VSITNOM"]) == "TOTAL")
              {
                strHtml.Append($@"<td bgcolor=#C0C0C0><font face=Arial size=3pt>{readerSql[i].ToString()}</font></td>");
              }
              else
              {
                strHtml.Append($@"<td bgcolor={sColor} onClick=""alert('DI{Utils.BlankIfNull(readerSql[i]).ToUpper().Substring(2)}');""><font style=""CURSOR:Hand;FONT-FAMILY:Arial;FONT-SIZE:4pt;"">&nbsp;</font></td>");
              }
            }

            // traitement si décalage
            if (sem != 1)
            {
              for (int i = 6; i < 6 + sem - 1; i++)
              {
                string sColor = "";
                char car = readerSql[i].ToString().ToUpper()[0];
                switch (car)
                {
                  case 'V':
                    if (semainesSpeciales.Contains(i)) sColor = "#FEFFE6";
                    else sColor = "white";
                    if (i == semEncours + 5) sColor = "#EAEAFF";// pour colorer la semaine en cour
                    break;
                  case 'I': sColor = "#FF0000"; break;
                  case 'P': sColor = "#FF9900"; ++iNb_Planifie; ++iNb_act_by_contrat; break;
                  case 'X': sColor = "#33CC00"; ++iNb_Realise; ++iNb_act_by_contrat; break;
                }
                strHtml.Append($@"<td bgcolor={sColor} onClick=""alert('DI{Utils.BlankIfNull(readerSql[i]).ToUpper().Substring(2)}');"">&nbsp;</td>");
              }
            }

            if (Utils.BlankIfNull(readerSql["VSITNOM"]) == "TOTAL")
            {
              strHtml.Append($@"<td bgcolor=#C0C0C0><font face=Arial size=3pt>{readerSql[59].ToString()}</font></td>");
            }
            else
            {
              // total
              strHtml.Append($@"<td bgcolor=white style=""font-face=arial; font-size=7pt;""><NOBR>{readerSql[59]}</NOBR></td></tr>");
            }


          } while (readerSql.Read());

          strHtml.Append("</table>");

          //mise à jour des totaux
          strHtml.Replace("#NB_PROG_ANNUEL#", iNb_act_by_contrat.ToString());
          strHtml.Replace("#NB_REALISE#", iNb_Realise.ToString());
          strHtml.Replace("#NB_PLANIFIE#", iNb_Planifie.ToString());

          iNb_act_by_contrat_Total = iNb_act_by_contrat_Total + iNb_act_by_contrat;
          iNb_Realise_Total = iNb_Realise_Total + iNb_Realise;
          iNb_Planifie_Total = iNb_Planifie_Total + iNb_Planifie;

        }
      }

      return strHtml.ToString();
    }
    //Public Function GeneratePlanning(sType As String, Contrat As String, iAnnee As Integer, iclient As Integer, Optional ntri As Integer, Optional icontrat As Integer) As String

    //  Dim strHtml As String
    //  Dim i, k As Integer
    //  Dim sColor As String
    //  Dim rs As New Recordset
    //  Dim TRs As New Recordset
    //  ' UPGRADE_INFO (#0501): The 'scontrat' member isn't used anywhere in current application.
    //  ' Dim scontrat
    //  Dim TypePlanning As String
    //  Dim D, F

    //    On Error GoTo handler

    //    ccOffset = 0
    //    strHtml = ""


    //    If (IsNull(ntri) Or ntri = 0) Then ntri = 1

    //    ' recherche des informations
    //    If sType = "P" Or sType = "Prev" Then
    //      rs.Open "api_sp_PlanningAnnuel2 " & iclient & ", " & ntri & ", " & iAnnee & ", " & icontrat & ", 'P'", cnx
    //      TypePlanning = "§préventif§"
    //    ElseIf sType = "CONTRAT" Then
    //      rs.Open "api_sp_PlanningAnnuelContrat " & iclient & ", " & ntri & ", " & iAnnee & ", " & icontrat & ", ''", cnx
    //      TypePlanning = "CONTRAT"
    //    Else
    //      rs.Open "api_sp_PlanningAnnuelLDR " & iclient & ", " & ntri & ", " & iAnnee & ", " & icontrat & ", 'L'", cnx
    //      TypePlanning = "LDR"
    //    End If


    //    TRs.Open "select distinct dbudgdeb, dbudgfin from tbudg, tsit where nbudgannee = " & iAnnee & " and tsit.nsitnum = tbudg.nsitnum and nclinum = " & iclient, cnx
    //    If TRs.EOF Then
    //      D = "01/01/" & iAnnee
    //      F = "31/12/" & iAnnee
    //    Else
    //      D = TRs(0)
    //      F = TRs(1)
    //    End If


    //    If rs.EOF Then
    //    Else
    //      ' nom du client
    //      Concat strHtml, "<TABLE width=100%><TR><TD width=15% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & rs("VCLINOM") & " </H2></TD>"

    //      If sType = "LDR" Then
    //        Concat strHtml, "<TD width=75% ><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel " & TypePlanning & " " & Contrat & " : du " & D & " au " & F & "</CENTER></H3></TD>"
    //      ElseIf sType = "CONTRAT" Then
    //        Concat strHtml, "<TD width=75% ><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel des interventions du contrat : " & Contrat & " : du " & D & " au " & F & "</CENTER></H3></TD>"
    //      Else
    //        Concat strHtml, "<TD width=75% ><font style=""FONT-FAMILY:Arial;FONT-SIZE:12pt;""><Center><B>Planning annuel " & TypePlanning & " contrat " & Contrat & " (" & rs(59) & " sites)" & " : du " & D & " au " & F & "</CENTER></H3></TD>"
    //      End If


    //      Concat strHtml, "<TD width=10%><H3></H3></TD></TR></font></TABLE>"

    //      ' Tableau des numéros de semaine
    //      Concat strHtml, "<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>" & vbCrLf
    //      Concat strHtml, "<td width=17% bgcolor=#B0C0CC><FONT face=arial size=2pt;><b>Site (" & rs(59) & " sites)" & "</b></font></td>"
    //      Concat strHtml, "<td width=4% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>N°</b></td>"
    //      Concat strHtml, "<td width=7% bgcolor=#B0C0CC style=font-face=arial; font-size=8pt;><b>Région</b></td>"

    //      ' cas standart ou décalé
    //      ' pb de numéro de semaine en 2005 et 2006 la fonction n'est pas bonne
    //      ' k = DatePart("ww", D)-1
    //      k = DatePart("ww", D)
    //      If k = 53 Or k = 0 Then k = 1


    //      ' écriture des numéro de semaine
    //      For i = k To 52
    //  '      If i = DatePart("ww", Date) - 1 Then
    //        If i = DatePart("ww", Date) Then
    //          Concat strHtml, "<td bgcolor=#EAEAFF><FONT size=1>" & Format(i, "00") & "</td>"
    //        Else
    //          Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>"
    //        End If
    //      Next

    //      ' si décalage
    //      If k<> 1 Then
    //        For i = 1 To (k - 1)
    //          Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>"
    //        Next
    //      End If

    //       ' total
    //      Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>Tot</td>"
    //      Concat strHtml, "</tr>" & vbCrLf

    //      While Not rs.EOF
    //        ' Site client et planning de ce site
    //        Concat strHtml, "<tr><td bgcolor=white ><font face=Arial size=1>" & rs("VSITNOM") & "</FONT></td> "
    //        Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("NSITNUE") & "</FONT></td> "
    //        Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & IIf(rs("VSITREG") = "" Or IsNull(rs("VSITREG")), "&nbsp;", rs("VSITREG")) & "</FONT></td> "

    //       For i = 6 + (k - 1) To 57
    //          Select Case Left(Majuscule(rs(i)), 1)
    //            Case "V", " "
    //              Select Case i
    //                  Case 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57
    //                       sColor = "#FEFFE6"
    //                  Case Else
    //                       sColor = "white"
    //              End Select
    //  ' pb de la fonction N° semaine en 2005
    //              If i = DatePart("ww", Date) + 5 Then sColor = "#EAEAFF"  'pour colorer la semaine en cour
    //  '            If i = DatePart("ww", Date) + 5 - 1 Then sColor = "#EAEAFF" 'pour colorer la semaine en cour
    //            Case "I": sColor = "#FF0000"
    //            Case "P": sColor = "#FF9900"
    //            Case "X": sColor = "#33CC00"
    //          End Select
    //          Concat strHtml, "<td bgcolor=" & sColor & " onClick=""alert('DI" & Mid(Majuscule(rs(i)), 2) & "');""><font style=""CURSOR:Hand;FONT-FAMILY:Arial;FONT-SIZE:4pt;"">&nbsp;</font></td>" & vbCrLf
    //        Next

    //        'traitement si décalage
    //        If k<> 1 Then
    //          For i = 6 To 6 + (k - 2)
    //            Select Case Left(Majuscule(rs(i)), 1)
    //              Case "V", " "
    //                Select Case i
    //                    Case 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57
    //                         sColor = "#FEFFE6"
    //                    Case Else
    //                         sColor = "white"
    //                End Select
    //                If i = DatePart("ww", Date) + 5 Then sColor = "#EAEAFF"  'pour colorer la semaine en cour
    //              Case "I": sColor = "#FF0000"
    //              Case "P": sColor = "#FF9900"
    //              Case "X": sColor = "#33CC00"
    //            End Select
    //            Concat strHtml, "<td bgcolor=" & sColor & " onClick=""alert('DI" & Mid(Majuscule(rs(i)), 2) & "');"">&nbsp;</td>" & vbCrLf
    //          Next
    //        End If

    //        ' total
    //        Concat strHtml, "<td bgcolor=white style=""font-face=arial; font-size=7pt;""><NOBR>" & rs(58) & "</NOBR></td>" & vbCrLf

    //        Concat strHtml, "</tr>"
    //        rs.MoveNext
    //      Wend
    //        Concat strHtml, "</table>" & vbCrLf

    //    End If

    //    rs.Close

    //    ' retour résultat
    //    strHtml = Left$(strHtml, ccOffset)
    //    GeneratePlanning = strHtml


    //  Exit Function
    //  Resume
    //  handler:
    //    ShowError " GeneratePlanning dans modMain"
    //  End Function

    void GeneratePlanningChaff(int iChaff, int iAnnee)
    {
      StringBuilder strHtml = new StringBuilder(2000);

      using (SqlDataReader reader = ModuleData.ExecuteReader($"select * from TREF_TYPECONTRAT where ntypecontrat != 64 and langue='{MozartParams.Langue}'"))
      {
        strHtml.Append("<html><head><title> Planning annuel</title></head><body>");
        strHtml.Append(GeneratePlanningTousSite(iChaff, iAnnee, "Multitechnique", 64));
        strHtml.Append("<BR>");

        while (reader.Read())
        {
          strHtml.Append(GeneratePlanningTousSite(iChaff, iAnnee, Utils.BlankIfNull(reader["VTYPECONTRAT"]), (int)Utils.ZeroIfNull(reader["NTYPECONTRAT"])));
          strHtml.Append("<BR>");
        }

        // légende
        strHtml.Append("<table border=1 cellpadding=4 cellspacing=0 width=60%>");
        strHtml.Append("<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>Légende</b></td>");
        strHtml.Append("<td bgcolor=#FFFFCC><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Congés</td>");
        strHtml.Append("<td bgcolor=#FF0000><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Programme annuel</td>");
        strHtml.Append($"<td bgcolor=#FF9900><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planifié par {MozartParams.NomSociete}</td>");
        strHtml.Append("<td bgcolor=#33CC00><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Réalisé</td></tr></table>");

        File.WriteAllText($@"{MozartParams.CheminUtilisateurMozart}t.html", strHtml.ToString(), Encoding.Default);
      }
    }
    //Public Sub GeneratePlanningChaff(ByVal ichaff, ByVal iAnnee)

    //  Dim strHtml As String


    //  Dim rs As New Recordset
    //  Dim sSQL As String

    //    On Error GoTo handler

    //    ccOffset2 = 0
    //    strHtml = ""

    //    ' pas multitechnique
    //    sSQL = "select * from TREF_TYPECONTRAT where ntypecontrat != 64 and langue='" & gstrLangue & "'"

    //    ' recherche des différents type de contrat
    //    rs.Open sSQL, cnx


    //    Concat2 strHtml, "<html><head><title> Planning annuel</title></head><body>" & vbCrLf
    //    Concat2 strHtml, GeneratePlanningTousSite(ichaff, iAnnee, "Multitechnique", 64)
    //    Concat2 strHtml, "<BR>"


    //    While Not rs.EOF
    //      Concat2 strHtml, GeneratePlanningTousSite(ichaff, iAnnee, rs("vtypecontrat"), rs("ntypecontrat"))
    //      Concat2 strHtml, "<BR>"


    //      rs.MoveNext
    //    Wend

    //    ' légende
    //    Concat2 strHtml, "<table border=1 cellpadding=4 cellspacing=0 width=60%>" & vbCrLf
    //    Concat2 strHtml, "<tr> <FONT FACE=arial size=2><td><FONT FACE=arial size=2><b>Légende</b></td>" & vbCrLf
    //    Concat2 strHtml, "<td bgcolor=#FFFFCC><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Congés</td>"
    //    Concat2 strHtml, "<td bgcolor=#FF0000><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Programme annuel</td>"
    //    Concat2 strHtml, "<td bgcolor=#FF9900><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Planifié par " & gstrNomSociete & "</td>"
    //    Concat2 strHtml, "<td bgcolor=#33CC00><FONT FACE=arial size=2>&nbsp;&nbsp;</td><td><FONT FACE=arial size=2>Réalisé</td>"
    //    Concat2 strHtml, "</tr></table>" & vbCrLf

    //    Concat2 strHtml, "</body></html>"
    //    strHtml = Left$(strHtml, ccOffset2)

    //    Dim fs As New Scripting.FileSystemObject
    //    Dim ts As TextStream
    //    Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\t.html", ForWriting, True)
    //    ts.Write strHtml
    //    ts.Close
    //    Exit Sub

    //  handler:
    //    ShowError " GenenratePlanning dans modMain"
    //  End Sub

    string GeneratePlanningTousSite(int ichaff, int iAnnee, string Contrat, int iContrat)
    {
      StringBuilder strHtml = new StringBuilder(2000);
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"api_sp_PlanningAnnuelSite {ichaff}, {iAnnee}, {iContrat}"))
        {
          if (reader.Read())
          {
            // nom du client
            strHtml.Append($@"<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>{MozartParams.NomSociete}</H2></TD>");
            strHtml.Append($"<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Planning annuel {iContrat}  {iAnnee}</CENTER></H3></TD>");
            strHtml.Append($"<TD width=15%><H3>{DateTime.Today.ToShortDateString()}</H3></TD></TR></TABLE>");
            // Tableau des numéros de semaine
            strHtml.Append("<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>");
            strHtml.Append("<td width=16% bgcolor=#B0C0CC><font face=Arial size=2><b>Client</b></FONT></td>");
            strHtml.Append("<td width=15% bgcolor=#B0C0CC><font face=Arial size=2><b>Site</b></FONT></td>");
            strHtml.Append("<td width=4% bgcolor=#B0C0CC><font face=Arial size=2><b>N°</b></FONT></td>");
            for (int i = 1; i < 53; i++)
              strHtml.Append($"<td bgcolor=#B0C0CC><FONT size=1>{i.ToString("00")}</td>");
            strHtml.Append("</tr>");

            do
            {
              // Site client et planning de ce site
              strHtml.Append($"<tr><td bgcolor=white><font face=Arial size=1>{reader["VCLINOM"]}</FONT>");
              strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{reader["VSITNOM"]}</FONT></td> ");
              strHtml.Append($"<td bgcolor=white><font face=Arial size=1>{reader["NSITNUE"]}</FONT></td> ");
              int semEncours = UtilsPlan.WeekOfDate(DateTime.Today);
              for (int i = 6; i < 58; i++)
              {
                string sColor = "";
                char car = reader[i].ToString().ToUpper()[0];
                switch (car)
                {
                  case 'V':
                    if (semainesSpeciales.Contains(i)) sColor = "#FFFFCC";
                    else sColor = "white";
                    break;
                  case 'I': sColor = "#FF0000"; break;
                  case 'P': sColor = "#FF9900"; break;
                  case 'X': sColor = "#33CC00"; break;
                }
                strHtml.Append($"<td bgcolor={sColor}>&nbsp;</td>");
              }
              strHtml.Append("</tr>");
            } while (reader.Read());
          }
        }
        strHtml.Append("</table>");
        return strHtml.ToString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
      return "";
    }
    //Public Function GeneratePlanningTousSite(ByVal ichaff, ByVal iAnnee, ByVal Contrat, ByVal icontrat As Integer) As String

    //  Dim strHtml As String
    //  Dim i As Integer
    //  Dim sColor As String
    //  Dim rs As New Recordset
    //  ' UPGRADE_INFO (#0501): The 'scontrat' member isn't used anywhere in current application.
    //  ' Dim scontrat

    //    On Error GoTo handler
    //    ccOffset = 0
    //    strHtml = ""
    //    rs.Open "api_sp_PlanningAnnuelSite " & ichaff & ", " & iAnnee & ", " & icontrat, cnx

    //    If rs.EOF Then
    //  '    Concat strHtml, "<H3>Planning annuel " & miAnnee & " : </H3>"
    //  '    Concat strHtml, "aucun planning préventif"
    //    Else
    //  '    strHtml = "<html><head><title> Planning annuel</title></head><body>" & vbCrLf
    //      ' nom du client
    //      Concat strHtml, "<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & gstrNomSociete & " </H2></TD>"
    //      Concat strHtml, "<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Planning annuel " & Contrat & "  " & iAnnee & "</CENTER></H3></TD>"
    //      Concat strHtml, "<TD width=15%><H3>" & Date & "</H3></TD></TR></TABLE>"

    //      ' Tableau des numéros de semaine
    //      Concat strHtml, "<table border=1 cellpadding=1 cellspacing =0 widht=100%><tr>" & vbCrLf
    //      Concat strHtml, "<td width=16% bgcolor=#B0C0CC><font face=Arial size=2><b>Client</b></FONT></td>"
    //      Concat strHtml, "<td width=15% bgcolor=#B0C0CC><font face=Arial size=2><b>Site</b></FONT></td>"
    //      Concat strHtml, "<td width=4% bgcolor=#B0C0CC><font face=Arial size=2><b>N°</b></FONT></td>"
    //      For i = 1 To 52
    //        Concat strHtml, "<td bgcolor=#B0C0CC><FONT size=1>" & Format(i, "00") & "</td>"
    //      Next
    //      Concat strHtml, "</tr>" & vbCrLf

    //      While Not rs.EOF
    //        ' Site client et planning de ce site
    //        Concat strHtml, "<tr><td bgcolor=white><font face=Arial size=1>" & rs("VCLINOM") & "</FONT></td> "
    //        Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("VSITNOM") & "</FONT></td> "
    //        Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rs("NSITNUE") & "</FONT></td> "
    //        For i = 6 To 57
    //          Select Case Majuscule(rs(i))
    //            Case "V", " "
    //              Select Case i
    //                  Case 6, 32, 33, 34, 35, 36, 37, 38, 39, 40, 57
    //                       sColor = "#FFFFCC"
    //                  Case Else
    //                       sColor = "white"
    //              End Select
    //            Case "I": sColor = "#FF0000"
    //            Case "P": sColor = "#FF9900"
    //            Case "X": sColor = "#33CC00"
    //          End Select
    //          Concat strHtml, "<td bgcolor=" & sColor & ">&nbsp;</td>" & vbCrLf
    //        Next
    //        Concat strHtml, "</tr>"
    //        rs.MoveNext
    //      Wend


    //     Concat strHtml, "</table>" & vbCrLf

    //    End If

    //    rs.Close


    //    strHtml = Left$(strHtml, ccOffset)
    //    GeneratePlanningTousSite = strHtml



    //  Exit Function
    //  handler:
    //    ShowError " GeneratePlanningTousSite dans ModMAin"
    //  End Function
  }
}

