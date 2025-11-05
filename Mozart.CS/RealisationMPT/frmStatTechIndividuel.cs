using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatTechIndividuel : Form
  {
    //Public typeStat As String
    public string mTypeStat;

    public frmStatTechIndividuel() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStatTechIndividuel_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        txtDateA0.Text = $"01/01/{DateTime.Now.Year}";
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        cboTech.Init(MozartDatabase.cnxMozart, "exec api_sp_ListeTechStat", "NPERNUM", "Column1", new List<string>() { Resources.col_Num, Resources.col_Nom }, 50, 500);
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

    //Public typeStat As String
    //
    //Dim iTextBoxDate As Integer
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //    InitBoutons Me, frmMenu
    //   
    //    txtDateA(0) = "01/01/" & CStr(Year(Date))
    //    txtDateA(1) = Date
    //    RemplirCombo cboTech, "api_sp_ListeTechStat"
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdValid_Click(object sender, EventArgs e)
    {
      if (cboTech.GetItemData() < 0)
      {
        MessageBox.Show(Resources.msg_selectionner_technicien, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        EntretienTech();
        AfficheCarteZoneActvite();
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
    //Private Sub CmdValid_Click()
    //
    //On Error GoTo handler
    //
    //    If cboTech.ItemData(cboTech.ListIndex) = 0 Then MsgBox ("§Il faut sélectionner un technicien§"): Exit Sub
    //    
    //    Screen.MousePointer = vbHourglass
    //    
    //    EntretienTech
    //    AfficheCarteZoneActvite
    //
    //    Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "CmdValid_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void AfficheCarteZoneActvite()
    {           
            //webView21.Navigate($"https://maps.emalec.com/SitesTechZoneActivite.asp?base=MULTI&DEB={txtDateA0.Text}&FIN={txtDateA1.Text}" +
            //               $"&NPERNUM={cboTech.GetItemData()}&VTECH={cboTech.GetItemValue()}&APP=EMALEC");

            webView21.Source = new Uri($"https://maps.emalec.com/SitesTechZoneActivite.asp?base=MULTI&DEB={txtDateA0.Text}&FIN={txtDateA1.Text}" +
                           $"&NPERNUM={cboTech.GetItemData()}&VTECH={cboTech.GetItemValue()}&APP=EMALEC");

            int[] cw = tableLayoutPanel1.GetColumnWidths();
      int[] rh = tableLayoutPanel1.GetRowHeights();
            //webView21.Size = new System.Drawing.Size(cw[1], rh[0]);
    }
    //Private Sub AfficheCarteZoneActvite()
    //  
    //    WBTechIndiv.Navigate "http://maps.emalec.com/SitesTechZoneActivite.asp?base=MULTI&DEB=" & txtDateA(0) & "&FIN=" & txtDateA(1) & "&NPERNUM=" & cboTech.ItemData(cboTech.ListIndex) & "&VTECH=" & cboTech.Text & "&APP=EMALEC"
    //        
    //End Sub
    //

    //Private Sub Calendar1_Click()
    //
    //
    //    Me.txtDateA(iTextBoxDate) = Calendar1.value
    //    Calendar1.Visible = False
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
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
    //On Error GoTo handler
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdDate1_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdDate2_Click()
    // 
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdDate2_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void EntretienTech()
    {
      int iHeureRef = RechercheHeureRef(DateTime.Parse(txtDateA0.Text), DateTime.Parse(txtDateA1.Text));

      DataTable dt = new DataTable();
      ModuleData.LoadData(dt, $"api_sp_StatistiqueEntretienTech '{txtDateA0.Text}','{txtDateA1.Text}', {cboTech.GetItemData()}");

      StringBuilder stats = new StringBuilder(1000);
      stats.AppendLine($"Statistiques du {txtDateA0.Text} au {txtDateA1.Text} de {cboTech.GetItemValue()}");
      DataRow[] rows = dt.Select("STAT = 'HEURETECH'");
      int iHeureTech = 0;
      if (rows.Length > 0)
        iHeureTech = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($"\r\n\t -  Heures : {(rows.Length == 0 ? "" : iHeureTech.ToString("# ###"))}");
      int iPourcent = 0;
      if (rows.Length > 0)
        iPourcent = ((iHeureTech - iHeureRef) * 100) / iHeureRef;
      stats.Append($" /{iHeureRef.ToString("# ###")}");
      rows = dt.Select("STAT = 'HEURECLASS'");
      int nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.AppendLine($" = {iPourcent}%, {nb}{(nb == 1 ? "er" : "ème")}");

      rows = dt.Select("STAT = 'DEVISTECH'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($"\t -  Devis Web : {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'DEVISMAX'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($" / {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'DEVISCLASS'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.AppendLine($" = {nb}{(nb == 1 ? "er" : "ème")}");

      rows = dt.Select("STAT = 'CATECH'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($"\t -  Chiffre d'affaire : {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'CAMAX'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($" / {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'CACLASS'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.AppendLine($" = {nb}{(nb == 1 ? "er" : "ème")}");

      rows = dt.Select("STAT = 'FOUTECH'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($"\t -  Fournitures : {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'FOUMAX'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($" / {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'FOUCLASS'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.AppendLine($" = {nb}{(nb == 1 ? "er" : "ème")}");

      rows = dt.Select("STAT = 'KMTECH'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($"\t -  Kms : {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'KMMAX'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.Append($" / {nb.ToString("# ###")}");
      rows = dt.Select("STAT = 'KMCLASS'");
      nb = 0;
      if (rows.Length > 0) nb = (int)Utils.ZeroIfNull(rows[0]["NB"]);
      stats.AppendLine($" = {nb}{(nb == 1 ? "er" : "ème")}");

      txtEntretien.Text = stats.ToString();
    }
    //Private Sub EntretienTech()
    //Dim rsTech As ADODB.Recordset
    //Dim sText As String
    //Dim iHeureRef As Long
    //Dim iHeureTech As Long
    //Dim iPourcent As Long
    //
    //On Error GoTo handler:
    //
    //
    //  iHeureRef = RechercheHeureRef(txtDateA(0), txtDateA(1))
    //
    //  Set rsTech = New ADODB.Recordset
    //  
    //  rsTech.Open "api_sp_StatistiqueEntretienTech '" & txtDateA(0) & "','" & txtDateA(1) & "', " & cboTech.ItemData(cboTech.ListIndex), cnx
    //
    //  sText = "Statistiques du " & txtDateA(0) & " au " & txtDateA(1) & " de " & cboTech.Text & vbCrLf & vbCrLf
    //  rsTech.Filter = "STAT = 'HEURETECH'"
    //  sText = sText & vbTab & " -  Heures : " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  iHeureTech = rsTech("NB")
    //  iPourcent = CLng((iHeureTech - iHeureRef) * 100 / (iHeureRef))
    //  rsTech.Filter = "STAT = 'HEUREMAX'"
    //  sText = sText & " / " & CStr(Format$(iHeureRef, "# ###"))
    //  rsTech.Filter = "STAT = 'HEURECLASS'"
    //  sText = sText & " = " & CStr(iPourcent) & "%, " & IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) & IIf(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) = 1, "er", "ème") & vbCrLf
    //
    //  rsTech.Filter = "STAT = 'DEVISTECH'"
    //  sText = sText & vbTab & " -  Devis Web : " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'DEVISMAX'"
    //  sText = sText & " / " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'DEVISCLASS'"
    //  sText = sText & " = " & IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) & IIf(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) = 1, "er", "ème") & vbCrLf
    //
    //  rsTech.Filter = "STAT = 'CATECH'"
    //  sText = sText & vbTab & " -  Chiffre d'affaire : " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'CAMAX'"
    //  sText = sText & " / " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'CACLASS'"
    //  sText = sText & " = " & IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) & IIf(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) = 1, "er", "ème") & vbCrLf
    //
    //  rsTech.Filter = "STAT = 'FOUTECH'"
    //  sText = sText & vbTab & " -  Fournitures : " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'FOUMAX'"
    //  sText = sText & " / " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'FOUCLASS'"
    //  sText = sText & " = " & IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) & IIf(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) = 1, "er", "ème") & vbCrLf
    //
    //  rsTech.Filter = "STAT = 'KMTECH'"
    //  sText = sText & vbTab & " -  Kms : " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'KMMAX'"
    //  sText = sText & " / " & Format$(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")), "# ###")
    //  rsTech.Filter = "STAT = 'KMCLASS'"
    //  sText = sText & " = " & IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) & IIf(IIf(rsTech.RecordCount = 0, 0, rsTech("NB")) = 1, "er", "ème") & vbCrLf
    //
    //  txtEntretien = sText
    //
    //Exit Sub
    //Resume
    //handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "EntretienTech dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private int RechercheHeureRef(DateTime debut, DateTime fin)
    {
      int heureRef = 0;
      DateTime courante = debut;
      while (courante <= fin)
      {
        //  si ce n'est pas un weekend ou un jour fériée on ajoute 8 heures
        if (courante.DayOfWeek != DayOfWeek.Saturday && courante.DayOfWeek != DayOfWeek.Sunday)
        {
          if (!ModuleMain.IsFeriee(courante))
            if (courante.DayOfWeek == DayOfWeek.Friday)
              heureRef += 7;
            else
              heureRef += 8;
        }
        courante = courante.AddDays(1);
      }
      return heureRef;
    }
    //Private Function RechercheHeureRef(ByVal DateDeb As Date, ByVal DateFin As Date) As Integer
    //
    //Dim DateCourant As Date
    // 
    //  On Error GoTo handler
    //  
    //' initialisation
    //RechercheHeureRef = 0
    //DateCourant = DateDeb
    //
    //While DateCourant <= DateFin
    //  ' si ce n'est pas un weekend ou un jour fériée on ajout 8 heures
    //  If Weekday(DateCourant) <> 1 And Weekday(DateCourant) <> 7 Then
    //    If Not IsFeriee(DateCourant) Then
    //      If Weekday(DateCourant) = 6 Then
    //        RechercheHeureRef = RechercheHeureRef + 7
    //      Else
    //        RechercheHeureRef = RechercheHeureRef + 8
    //      End If
    //    End If
    //  End If
    //  DateCourant = DateAdd("d", 1, DateCourant)
    //Wend
    //
    //Exit Function
    //Resume
    //handler:
    //  ShowError " RechercheHeureRef dans " & Me.Name
    //End Function
  }
}

