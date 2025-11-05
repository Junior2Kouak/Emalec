using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestAstr : Form
  {

    int nb;
    DataTable dtArt = new DataTable();

    //Public rsArt As ADODB.Recordset
    //
    //Dim rsCde As ADODB.Recordset
    //Dim Nb As Integer

    public frmGestAstr() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmGestAstr_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        RemplirCombos();
        InitDataTable();
        OuvertureEnModification(true);
        FormatGridCde();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //  On Error GoTo Handler
    //
    //  InitBoutons Me, frmMenu
    //  RemplirCombos
    //  OuvertureEnModification True
    //
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //
    //Handler:
    //  ShowError " Form_load dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Screen.MousePointer = vbHourglass
    //  Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void OuvertureEnModification(bool bFirstTime)
    {
      try
      {
        // recherche des infos d'astreinte de la semaine choisie
        string sSQL = "";
        if (bFirstTime)
        {
          sSQL = $"api_sp_Astreinte {DateTime.Now.Month},{DateTime.Now.Year},'CA'";
          cboAnnee.SelectedItem = DateTime.Today.Year;
          cboMois.SelectedItem = Utils.Mois(DateTime.Today.Month);
        }
        else sSQL = $"api_sp_Astreinte {cboMois.SelectedIndex + 1},{cboAnnee.Text},'CA'";

        using (SqlDataReader sdrCde = ModuleData.ExecuteReader(sSQL))
        {
          dtArt.Rows.Clear();
          while (sdrCde.Read()) AjouterEnrg(sdrCde);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub OuvertureEnModification(bFirstTime As Boolean)
    //
    //  On Error GoTo Handler
    //
    //  ' recherche des infos d'astreinte de la semaine choisie
    //  Set rsCde = New ADODB.Recordset
    //  
    //  If bFirstTime = True Then
    //  
    //    rsCde.Open "api_sp_Astreinte " & Month(Date) & "," & Year(Date) & ",'CA'", cnx, adOpenStatic, adLockOptimistic
    //    SelectLB cboMois, Month(Date)
    //    SelectLB cboAnnee, Year(Date)
    //    
    //  Else
    //  
    //    rsCde.Open "api_sp_Astreinte " & cboMois.ItemData(cboMois.ListIndex) & "," & cboAnnee.Text & ",'CA'", cnx, adOpenStatic, adLockOptimistic
    //  
    //  End If
    //
    //  InitRecordsetArticle
    //
    //  While Not rsCde.EOF
    //    AjouterEnreg rsCde
    //    rsCde.MoveNext
    //  Wend
    //
    //  FormatGridCde bFirstTime
    //
    //  rsArt.MoveFirst
    //  Exit Sub
    //  Resume
    //
    //Handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub
    //
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      OuvertureEnModification(false);
    }
    //Private Sub cmdValider_Click()
    //    OuvertureEnModification (False)
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    public void InitDataTable()
    {
      try
      {
        nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(DISTINCT NPERNUM) FROM TPER where VSOCIETE = '{MozartParams.NomSociete}' AND cperactif='O' and cpertyp='CA' and npernum not in (1,3,30,376,200)");

        // ajout des champs dans la datatable de la datatable
        dtArt.Columns.Add("JOUR", Type.GetType("System.String"));
        for (int i = 1; i <= nb; i++)
          dtArt.Columns.Add("CODE" + i, Type.GetType("System.Char"));

        apiTGrid.GridControl.DataSource = dtArt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub InitRecordsetArticle()
    //Dim rs As ADODB.Recordset
    //Dim i
    //
    //  On Error GoTo Handler
    //
    //  Set rs = New ADODB.Recordset
    //  rs.Open "SELECT count(DISTINCT NPERNUM) FROM TPER where VSOCIETE = '" & gstrNomSociete & "' AND cperactif='O' and cpertyp='CA' and npernum not in (1,3,30,376,200)", cnx
    //  Nb = rs(0)
    //  rs.Close
    //  Set rs = Nothing
    //
    //  ' initialisation du recordset
    //  Set rsArt = New ADODB.Recordset
    //
    //  ' ajout des champs au recordset
    //  rsArt.Fields.Append "JOUR", adVarChar, 150
    //  For i = 1 To Nb
    //    rsArt.Fields.Append "CODE" & i, adChar, 1
    //  Next
    //  
    //  rsArt.Open , , adOpenDynamic, adLockOptimistic
    //  Exit Sub
    //  Resume
    //
    //Handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void AjouterEnrg(SqlDataReader sdr)
    {
      try
      {
        DataRow newRow = dtArt.NewRow();
        newRow["JOUR"] = Utils.BlankIfNull(sdr["JOUR"]);
        for (int i = 1; i < nb; i++)
          newRow["CODE" + i] = sdr["code" + i];
        dtArt.Rows.Add(newRow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub AjouterEnreg(ByVal rs As ADODB.Recordset)
    //Dim i
    //
    //  On Error GoTo Handler
    //
    //  rsArt.AddNew
    //
    //  rsArt("JOUR").Value = rs!Jour
    //  For i = 1 To Nb
    //    rsArt("CODE" & i).Value = rs("Code" & i)
    //  Next
    //
    //  rsArt.Update
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "AjouterEnreg dans  " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    public void FormatGridCde()
    {
      apiTGrid.AddColumn(Resources.col_Jour, "JOUR", 2100);
      for (int i = 1; i < nb; i++)
        apiTGrid.AddColumn("CODE" + i, "CODE" + i, 1000, "", 2);

      apiTGrid.InitColumnList();
    }

    //Public Sub FormatGridCde(bFirstTime As Boolean)
    //
    //On Error GoTo Handler
    //
    //  If bFirstTime = True Then
    //
    //    Dim rs As ADODB.Recordset
    //    Dim i
    //    
    //      Set rs = New ADODB.Recordset
    //      rs.Open "SELECT DISTINCT CPERINI, NPERNUM, VPERNOM FROM TPER where VSOCIETE = '" & gstrNomSociete & "' AND cperactif='O' and cpertyp='CA' and npernum not in (1,3,30,376,200) order by VPERNOM ", cnx
    //      
    //      apiTGrid.AddColumn "§Jour§", "JOUR", 2100
    //    
    //      i = 1
    //      While Not rs.EOF
    //        apiTGrid.AddColumn BlankIfNull(rs("CPERINI")), "CODE" & i, 1000, , 2
    //        i = i + 1
    //        rs.MoveNext
    //      Wend
    //
    //  End If
    //
    //  apiTGrid.Init rsArt, Not bFirstTime
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError " FormatGrid dans " & Me.Name
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void RemplirCombos()
    {
      for (int i = 0; i <= 11; i++)
        cboMois.Items.Add(Utils.Mois(i + 1));

      for (int i = 0; i <= 4; i++)
        cboAnnee.Items.Add(DateTime.Today.AddYears(-i).Year);

      cboAnnee.SelectedItem = DateTime.Today.Year;
      cboMois.SelectedItem = Utils.Mois(DateTime.Today.Month);
    }
    //Private Sub RemplirCombos()
    //
    //Dim i As Integer
    //
    // ' vider la combo
    //  cboMois.Clear
    //  cboAnnee.Clear
    //  
    //  i = 0
    //  For i = 0 To 11
    //    cboMois.AddItem Mois(i + 1)
    //    cboMois.ItemData(i) = i + 1
    //  Next
    //  For i = 0 To 4
    //    cboAnnee.AddItem Year(DateAdd("yyyy", -i, Date))
    //  Next
    //  cboAnnee.ListIndex = 0
    //  cboMois.ListIndex = Month(Date) - 1
    //
    //End Sub
    //
    //

  }
}

