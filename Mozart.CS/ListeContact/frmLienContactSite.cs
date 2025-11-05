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
  public partial class frmLienContactSite : Form
  {
    DataTable dt = new DataTable();
    public int miNumClient = 0;
    //int NbCoche;
    //bool bModif = false;

    //Public miNumClient As Integer
    //
    //Dim NbCoche As Integer
    //Dim adoRS As ADODB.Recordset
    //
    //Dim bModif As Boolean
    public frmLienContactSite()
    {
      InitializeComponent();
    }

    private void frmLienContactSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        //initialisation des images
        ModuleMain.Initboutons(this);

        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeContactClient {miNumClient}");
        ApiGrid.GridControl.DataSource = dt;
        InitApigrid();

        //   liste des sites
        RemplirListeSites();

        CocherLesSites();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  
    //  ' initialisation des images
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "api_sp_ListeContactClient " & miNumClient, cnx, adOpenStatic, adLockOptimistic
    //  
    //  InitApigrid
    //  
    //  ' liste des sites
    //  RemplirListeSites
    //  
    //  CocherLesSites
    //    
    //End Sub

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      try
      {
        string sSQL = $"update TSIT set NSITRESPMAINT = '' WHERE NCLINUM =  {miNumClient} AND NSITRESPMAINT = {row["NCCLNUM"]}";
        ModuleData.ExecuteNonQuery(sSQL);

        //parcours du listebox et update de tsit
        foreach (var item in lstAction.CheckedItems)
        {
          sSQL = $"update TSIT set NSITRESPMAINT = {row["NCCLNUM"]} WHERE NSITNUM = {item}";
          ModuleData.ExecuteNonQuery(sSQL);
        }
        //bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    //If adoRS.EOF Then Exit Sub
    //
    //' on vide pour le contact
    //sSQL = "update TSIT set NSITRESPMAINT = ''"
    //sSQL = sSQL & " WHERE NCLINUM =  " & miNumClient
    //sSQL = sSQL & " AND NSITRESPMAINT = " & adoRS("NCCLNUM")
    //cnx.Execute (sSQL)
    //
    //'parcours du listebox et update de tsit
    //  For i = 0 To lstAction.ListCount - 1
    //    If lstAction.Selected(i) = True Then
    //      ' execution de la requête d'insert
    //      sSQL = "update TSIT set NSITRESPMAINT = " & adoRS("NCCLNUM")
    //      sSQL = sSQL & " WHERE NSITNUM =  " & lstAction.ItemData(i)
    //      cnx.Execute (sSQL)
    //    End If
    //  Next
    //
    //bModif = False
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdValider dans " & Me.Name
    //End Sub

    private void cmdCocherT_Click(object sender, EventArgs e)
    {
      try
      {
        for (int i = 0; i <= (lstAction.Items.Count - 1); i++)
        {
          lstAction.SetItemChecked(i, true);
        }
        lblNbSites.Text = lblNbSites.Tag.ToString() + CompterCoche();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdCocherT_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstAction.ListCount - 1
    //      lstAction.Selected(i) = True
    //  Next
    // 
    //  lblNbSites = lblNbSites.Tag & CompterCoche
    //Exit Sub
    //handler:
    //  ShowError " cmdCocherT_Click dans " & Me.Name
    //End Sub

    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      for (int i = 0; i <= (lstAction.Items.Count - 1); i++)
      {
        lstAction.SetItemChecked(i, false);
      }
      lblNbSites.Text = lblNbSites.Tag.ToString() + CompterCoche();
    }
    //Private Sub cmdDecocher_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstAction.ListCount - 1
    //      lstAction.Selected(i) = False
    //  Next
    //  lblNbSites = lblNbSites.Tag & CompterCoche
    //
    //Exit Sub
    //handler:
    //  ShowError " cmddécocherT_Click dans " & Me.Name
    //End Sub


    private void RemplirListeSites()
    {
      DataTable dtFou = new DataTable();
      DataRow row = ApiGrid.GetFocusedDataRow();

      try
      {

        string sSQL = $"select VSITNOM, NSITNUM from TSIT where NCLINUM = {miNumClient}  AND " +
          $"(NSITRESPMAINT = {row["NCCLNUM"]} or NSITRESPMAINT is null or NSITRESPMAINT = '')  order by VSITNOM";


        using (SqlDataReader dataReader = ModuleData.ExecuteReader(sSQL))
        {
          dtFou.Load(dataReader);
          dataReader.Close();
        }

        lstAction.DataSource = dtFou;
        lstAction.DisplayMember = "VSITNOM";
        lstAction.ValueMember = "NSITNUM";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub RemplirListeSites()
    //
    //Dim RsFou As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    //  
    //  Set RsFou = New ADODB.Recordset
    //  sSQL = "select VSITNOM, NSITNUM from TSIT where NCLINUM = " & miNumClient
    //  sSQL = sSQL & " AND (NSITRESPMAINT = " & adoRS("NCCLNUM") & " or NSITRESPMAINT is null or NSITRESPMAINT='')"
    //  sSQL = sSQL & " order by VSITNOM"
    //
    //  RsFou.Open sSQL, cnx
    //  
    //  ' vider la listeBox
    //  lstAction.Clear
    //  
    //  i = 0
    //  While Not RsFou.EOF
    //    lstAction.AddItem CStr(RsFou(0))
    //    lstAction.ItemData(i) = RsFou(1)
    //    RsFou.MoveNext
    //    i = i + 1
    //  Wend
    //  RsFou.Close
    // 
    //Exit Sub
    //handler:
    //  ShowError " RemplirListeSites dans " & Me.Name
    //End Sub
    //
    private void CocherLesSites()
    {
      DataTable dtSite = new DataTable();
      string sSQL;
      DataRow row = ApiGrid.GetFocusedDataRow();

      try
      {
        sSQL = $"select NSITNUM from TSIT where NCLINUM = {miNumClient} AND NSITRESPMAINT = {row["NCCLNUM"]}";
        dtSite.Load(ModuleData.ExecuteReader(sSQL));
        //parcours du recordset et de la listebox
        for (int i = 0; i < dtSite.Rows.Count; i++)
        {
          for (int j = 0; j < lstAction.Items.Count; j++)
          {
            if (((DataRowView)lstAction.Items[j]).Row.ItemArray[1].ToString() == ((DataRow)dtSite.Rows[i])["NSITNUM"].ToString())
              lstAction.SetItemChecked(j, true);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub CocherLesSites()
    //
    //Dim rsSite As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    //   
    //  ' recherche de la liste des sites à cocher
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "select NSITNUM from TSIT where NCLINUM = " & miNumClient
    //  sSQL = sSQL & " AND NSITRESPMAINT = " & adoRS("NCCLNUM")
    //  
    //  rsSite.Open sSQL, cnx
    //  
    //  ' parcours du recordset et de la listebox
    //  While Not rsSite.EOF
    //    i = 0
    //    For i = 0 To lstAction.ListCount - 1
    //      If lstAction.ItemData(i) = rsSite("NSITNUM") Then
    //        lstAction.Selected(i) = True
    //       End If
    //    Next
    //    rsSite.MoveNext
    //  Wend
    //  rsSite.Close
    // 
    //Exit Sub
    //handler:
    //  ShowError " CocherLesSites dans " & Me.Name
    //End Sub


    private void ApiGrid_ClickE(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (row == null)
        return;
      //liste des sites
      RemplirListeSites();
      CocherLesSites();

    }
    //Private Sub ApiGrid_Click()
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  ' liste des sites
    //  RemplirListeSites
    //  
    //  CocherLesSites
    //
    //End Sub

    //L'event click compte le nombre de checked d'avant le clic
    private void lstAction_Click(object sender, EventArgs e)
    {
      //lblNbSites.Text = lblNbSites.Tag.ToString() + CompterCoche();
    }
    private void lstAction_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      int sCount = lstAction.CheckedItems.Count;
      if (e.NewValue == CheckState.Checked) { ++sCount; }
      if (e.NewValue == CheckState.Unchecked) { --sCount; }
      lblNbSites.Text = lblNbSites.Tag.ToString() + sCount;
    }

    //Private Sub lstAction_Click()
    //  lblNbSites = lblNbSites.Tag & CompterCoche
    //End Sub

    private int CompterCoche()
    {
      int NbCoche = 0;
      try
      {
        foreach (var item in lstAction.CheckedItems)
        {
          NbCoche++;
        }
        return NbCoche;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        return NbCoche;
      }
    }
    //Private Function CompterCoche() As Integer
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  NbCoche = 0
    //  For i = 0 To lstAction.ListCount - 1
    //   If lstAction.Selected(i) = True Then
    //    NbCoche = NbCoche + 1
    //   End If
    //  Next
    //  CompterCoche = NbCoche
    //
    //Exit Function
    //handler:
    //  ShowError " CompterCoche dans " & Me.Name
    //End Function

    private void InitApigrid()
    {
      try
      {
        ApiGrid.AddColumn(Resources.col_Nom, "VCCLNOM", 1200);
        ApiGrid.AddColumn(Resources.col_Prenom, "VCCLPRE", 1000);
        ApiGrid.AddColumn(Resources.col_Fonction, "VCCLFONC", 2500);
        ApiGrid.AddColumn(Resources.col_Region, "VCCLREG", 1500);
        ApiGrid.AddColumn(Resources.col_NumContact, "VCCLNUM", 0);

        ApiGrid.InitColumnList();
        ApiGrid.DesactiveListe();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    //Sub InitApigrid()
    //  
    //  ApiGrid.AddColumn "§Nom§", 1200
    //  ApiGrid.AddColumn "§Prénom§", 1000
    //  ApiGrid.AddColumn "§Fonction§", 2500
    //  ApiGrid.AddColumn "§Region§", 1500
    //  ApiGrid.AddColumn "NumContact", 0
    //  
    //       
    //  ApiGrid.Init adoRS
    //  ApiGrid.DesactiveListe
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //


  }
}

