using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmIntercalaires : Form
  {
    //Public mstrType As String
    //
    //Dim NbCoche
    //
    public string mstrType = "";
    public int nbCoche;

    public frmIntercalaires()
    {
      InitializeComponent();
    }

    private void frmIntercalaires_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        ModuleData.RemplirCombo(cboClient, "select * from api_v_comboClient order by VCLINOM");
        cboClient.ValueMember = "NCLINUM";
        cboClient.DisplayMember = "VCLINOM";
        if (cboClient.Items.Count > 0)
          cboClient.SelectedIndex = 0;

        switch (mstrType)
        {
          case "INTERCALAIRES":
            lblIntercalaires.Visible = true;
            lblTitre.Text = Resources.txt_imp_intercalaires;
            break;
          case "DOSCLASSEURSECU":
            lblTitre.Text = Resources.txt_imp_dos_class_secu;
            break;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  InitBoutons Me, frmMenu
    //  RemplirComboClient cboClient
    //  
    //  Select Case mstrType
    //    
    //    Case "INTERCALAIRES"
    //      lblIntercalaires.Visible = True
    //      lblTitre.Caption = "§Impression des intercalaires§"
    //    
    //    Case "DOSCLASSEURSECU"
    //      lblTitre.Caption = "§Impression des dos de classeur sécurité§"
    //  
    //  End Select
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (lstSites.CheckedItems.Count == 0) return;

      try
      {
        frmBrowser f = new frmBrowser();

        switch (mstrType)
        {
          case "INTERCALAIRES":
            string[,] TdbGlobal = { { "SITE", ((DataRowView)lstSites.CheckedItems[0])["VSITNOM"].ToString() } };

            f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TSites.rtf",
                                  @"TSites.Out.rtf",
                                  TdbGlobal,
                                  "select * from tcpt",
                                  " (Visualisation d'un site)",
                                  "PREVIEW");

            break;

          case "DOSCLASSEURSECU":
            //Création de la clause SQL en fonction des sites cochés
            string[,] TdbGlobal2 = { { "COPIE", "COPIE" } };

            string sListeSites = string.Join(",", lstSites.CheckedItems.OfType<DataRowView>().Select(x => x.Row["NSITNUM"].ToString()));

            string sSQL = "SELECT VSITENSEIGNE VENSEIGNE, VSITAD1, VSITAD2, VSITCP, VSITVIL FROM TSIT WHERE NCLINUM = " + cboClient.SelectedValue
                 + " AND NSITNUM IN (" + sListeSites + ") ORDER BY VSITVIL";

            f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TDosClasseurSecu.rtf",
                              $@"TDosClasseurSecu.{cboClient.Text.Replace("'", "_")}.Out.rtf",
                              TdbGlobal2,
                              sSQL,
                              " (Visualisation dos de classeur)",
                              "PREVIEW");
            break;
        }
      }
      catch (Exception ex)
      {
        new frmInfoDebug(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace).ShowDialog();
      }
    }
    //Private Sub cmdVisu_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //  Select Case mstrType
    //    
    //    Case "INTERCALAIRES"
    //      TdbGlobal(0, 0) = "SITE"
    //      TdbGlobal(0, 1) = lstSites.List(lstSites.ListIndex)
    //    
    //      frmBrowser.bPlanningAn = 0
    //      frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TSites.rtf", _
    //                               "\TSites.Out.rtf", _
    //                               TdbGlobal(), _
    //                               "select * from tcpt", _
    //                               " (Visualisation d'un site)", _
    //                               "PREVIEW"
    //
    //    Case "DOSCLASSEURSECU"
    //      ' Création de la clause SQL en fonction des sites cochés
    //      Dim sSQL As String
    //      Dim sListeSites As String
    //      Dim i As Integer
    //      
    //      For i = 0 To lstSites.ListCount - 1
    //       If lstSites.Selected(i) = True Then
    //        sListeSites = lstSites.ItemData(i)
    //       End If
    //      Next
    //      
    //      sSQL = "SELECT VSITENSEIGNE VENSEIGNE, VSITAD1, VSITAD2, VSITCP, VSITVIL FROM TSIT WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & " AND NSITNUM IN (" & sListeSites & ") ORDER BY VSITVIL"
    // '     sSQL = "SELECT 'SEPHORA' VENSEIGNE, VSITNOM VSITAD1, '' VSITAD2, '' VSITCP, '' VSITVIL FROM TSIT WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & " AND NSITNUM IN (" & sListeSites & ") ORDER BY VSITVIL"
    //      
    //      frmBrowser.bPlanningAn = 0
    //      frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TDosClasseurSecu.rtf", _
    //                               "\TDosClasseurSecu." & Replace(cboClient.Text, "'", "_") & ".Out.rtf", _
    //                               TdbGlobal(), _
    //                               sSQL, _
    //                               " (Visualisation dos de classeur)", _
    //                               "PREVIEW"
    //  End Select
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdEdition_Click(object sender, EventArgs e)
    {
      if (lstSites.CheckedItems.Count == 0) return;

      if (MessageBox.Show(Resources.msg_imp_sites_choches, Program.AppTitle,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        ImprimerIntercalaires();
    }
    //Private Sub CmdEdition_Click()
    //
    //  If MsgBox("§Voulez-vous l'impression pour tous les sites cochés ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    ImprimerIntercalaires
    //  End If
    //  
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void ImprimerIntercalaires()
    {
      int i = 0;
      frmBrowser f = new frmBrowser();

      switch (mstrType)
      {
        case "INTERCALAIRES":
          foreach (DataRowView item in lstSites.CheckedItems)
          {
            string[,] TdbGlobal = { { "SITE", item.Row.ItemArray[0].ToString() } };
            new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + MozartParams.Langue + @"\TSites.rtf",
                                             $@"TSitesOut{i++}.rtf",
                                             TdbGlobal,
                                             "select * from tcpt");
          }

          break;

        case "DOSCLASSEURSECU":
          // Création de la clause SQL en fonction des sites cochés
          string sListeSites = string.Join(",", lstSites.CheckedItems.OfType<DataRowView>().Select(x => x.Row.ItemArray[1]));

          string sSQL = "SELECT VSITENSEIGNE VENSEIGNE, VSITAD1, VSITAD2, VSITCP, VSITVIL FROM TSIT WHERE NCLINUM = "
               + cboClient.SelectedValue + " AND NSITNUM IN (" + sListeSites + ") ORDER BY VSITVIL";

          string[,] TdbGlobal2 = { { "COPIE", "COPIE" } };
          new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + MozartParams.Langue + @"\TDosClasseurSecu.rtf",
                                    $@"TDosClasseurSecu.{i++}{cboClient.Text.Replace("'", "_")}.Out.rtf",
                                    TdbGlobal2,
                                    sSQL);
          break;
      }
    }
    //Private Sub ImprimerIntercalaires()
    //  
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim i As Integer
    //  
    //  On Error Resume Next
    //  
    //  Select Case mstrType
    //    
    //    Case "INTERCALAIRES"
    //      i = 0
    //      For i = 0 To lstSites.ListCount - 1
    //       If lstSites.Selected(i) = True Then
    //          TdbGlobal(0, 0) = "SITE"
    //          TdbGlobal(0, 1) = lstSites.List(i)
    //    
    //         ImprimerFichier gstrCheminModeles & gstrLangue & "\" & "TSites.rtf", _
    //                           "\TSitesOut" & i & ".rtf", _
    //                           TdbGlobal(), _
    //                           "select * from tcpt"
    //       End If
    //      Next
    //    
    //    Case "DOSCLASSEURSECU"
    //      ' Création de la clause SQL en fonction des sites cochés
    //      Dim sSQL As String
    //      Dim sListeSites As String
    //      
    //      For i = 0 To lstSites.ListCount - 1
    //       If lstSites.Selected(i) = True Then
    //        sListeSites = sListeSites & lstSites.ItemData(i) & ","
    //       End If
    //      Next
    //      sListeSites = Left(sListeSites, Len(sListeSites) - 1)   ' Enlever la dernière ,
    //      
    //'      sSQL = "SELECT 'SEPHORA' VENSEIGNE, VSITNOM VSITAD1, '' VSITAD2, '' VSITCP, '' VSITVIL FROM TSIT WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & " AND NSITNUM IN (" & sListeSites & ") ORDER BY VSITVIL"
    //      sSQL = "SELECT VSITENSEIGNE VENSEIGNE, VSITAD1, VSITAD2, VSITCP, VSITVIL FROM TSIT WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & " AND NSITNUM IN (" & sListeSites & ") ORDER BY VSITVIL"
    //      
    //      ImprimerFichier gstrCheminModeles & gstrLangue & "\" & "TDosClasseurSecu.rtf", _
    //                      "\TDosClasseurSecu." & i & Replace(cboClient.Text, "'", "_") & ".Out.rtf", _
    //                      TdbGlobal(), _
    //                      sSQL
    //  End Select
    //    
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (cboClient.SelectedValue.ToString() != "System.Data.DataRowView")
          //liste des sites
          RemplirListeSites();
        else
          // on vide la liste des sites
          lstSites.ClearSelected();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cboClient_Click()
    //On Error GoTo handler
    //
    //  If cboClient.ListIndex <> 0 Then
    //    ' liste des sites
    //    RemplirListeSites
    //  Else
    //    ' on vide la liste des sites
    //    lstSites.Clear
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cboClient_click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListeSites()
    {
      try
      {
        DataTable dtDept = new DataTable();
        string sSQL = "select VSITNOM, NSITNUM from TSIT where NCLINUM = " + cboClient.SelectedValue + " order by VSITNOM";

        using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
        {
          dtDept.Load(dr);
          dr.Close();
        }

        lstSites.DataSource = dtDept;
        lstSites.DisplayMember = "VSITNOM";
        lstSites.ValueMember = "NSITNUM";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub RemplirListeSites()
    //
    //Dim lRs As ADODB.Recordset
    // 
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    //  
    //  Set lRs = New ADODB.Recordset
    //  lRs.Open "select VSITNOM, NSITNUM from TSIT where NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & " order by VSITNOM", cnx
    //  
    //  ' vider la listeBox
    //  lstSites.Clear
    //  
    //  i = 0
    //  While Not lRs.EOF
    //    lstSites.AddItem CStr(lRs(0))
    //    lstSites.ItemData(i) = lRs(1)
    //    lRs.MoveNext
    //    i = i + 1
    //  Wend
    //  lRs.Close
    // 
    //Exit Sub
    //handler:
    //  ShowError " RemplirListeSites dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void lstSites_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      CompterAfficherCoche(e.NewValue == CheckState.Checked ? +1 : -1);
    }
    //Private Sub lstSites_Click()
    //  lblNbSitesS = lblNbSitesS.Tag & CompterCoche
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdCocherTS_Click(object sender, EventArgs e)
    {
      try
      {
        for (int i = 0; i < lstSites.Items.Count; i++)
          lstSites.SetItemChecked(i, true);

        CompterAfficherCoche();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdCocherTS_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstSites.ListCount - 1
    //      lstSites.Selected(i) = True
    //  Next
    //  lblNbSitesS = lblNbSitesS.Tag & CompterCoche
    //
    //Exit Sub
    //handler:
    //  ShowError " cmdCocherT_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdDecocherTS_Click(object sender, EventArgs e)
    {
      try
      {
        for (int i = 0; i < lstSites.Items.Count; i++)
          lstSites.SetItemChecked(i, false);

        CompterAfficherCoche();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdDecocherTS_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstSites.ListCount - 1
    //      lstSites.Selected(i) = False
    //  Next
    //  lblNbSitesS = lblNbSitesS.Tag & CompterCoche
    //
    //Exit Sub
    //handler:
    //  ShowError " cmddécocherT_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void CompterAfficherCoche(int Plus = 0)
    {
      lblNbSitesS.Text = lblNbSitesS.Tag.ToString() + " " + (lstSites.CheckedItems.Count + Plus);
    }

    //Private Function CompterCoche() As Integer
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  NbCoche = 0
    //  For i = 0 To lstSites.ListCount - 1
    //   If lstSites.Selected(i) = True Then
    //    NbCoche = NbCoche + 1
    //   End If
    //  Next
    //  CompterCoche = NbCoche
    //
    //Exit Function
    //handler:
    //  ShowError " CompterCoche dans " & Me.Name
    //End Function
  }
}