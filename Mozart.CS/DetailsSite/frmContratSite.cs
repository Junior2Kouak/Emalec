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
  public partial class frmContratSite : Form
  {
    public int miNumClient = 0;
    public int miNumSite = 0;

    public frmContratSite(int NumClient, int NumSite)
    {
      miNumClient = NumClient;
      miNumSite = NumSite;
      InitializeComponent();
    }

    public frmContratSite()
    {
      InitializeComponent();
    }

    private void frmContratSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        RemplirListeCategories();
        CocherLesCat();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()

    //  InitBoutons Me, frmMenu
    //  RemplirListeCategories
    //  CocherLesCat

    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void RemplirListeCategories()
    {
      DataTable dt = new DataTable();
      try
      {
        string sSQL = $"SELECT R.VTYPECONTRAT, R.NTYPECONTRAT From dbo.TREF_TYPECONTRAT R,TCONTRATCLI C where R.NTYPECONTRAT = C.NTYPECONTRAT " +
                      $"AND NCLINUM = {miNumClient} and langue ='{MozartParams.Langue}' ORDER BY R.VTYPECONTRAT";
        var dataReader = ModuleData.ExecuteReader(sSQL);
        dt.Load(dataReader);
        dataReader.Close();

        lstCat.DataSource = dt;
        lstCat.DisplayMember = "VTYPECONTRAT";
        lstCat.ValueMember = "NTYPECONTRAT";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub RemplirListeCategories()
    //Dim RsFou As ADODB.Recordset
    //Dim i As Integer
    //On Error GoTo handler
    //  Set RsFou = New ADODB.Recordset
    //  RsFou.Open "SELECT R.VTYPECONTRAT, R.NTYPECONTRAT From dbo.TREF_TYPECONTRAT R,TCONTRATCLI C where R.NTYPECONTRAT=C.NTYPECONTRAT and NCLINUM=" & frmDetailsSite.miNumClient & " and langue='" & gstrLangue & "' ORDER BY R.VTYPECONTRAT", cnx, adOpenStatic, adLockOptimistic
    //  ' vider la listeBox
    //  lstCat.Clear
    //  i = 0
    //  While Not RsFou.EOF
    //    lstCat.AddItem RsFou(0)
    //    lstCat.ItemData(i) = RsFou(1)
    //    RsFou.MoveNext
    //    i = i + 1
    //  Wend
    //  RsFou.Close
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "RemplirListeCategories dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CocherLesCat()
    {
      try
      {
        DataTable dtSite = new DataTable();
        //recherche de la liste des comptes à cocher
        string sSQL = $"SELECT NTYPECONTRAT From TCONT WHERE VCONTETAT = 'OUI' AND NSITNUM = {miNumSite}";

        dtSite.Load(ModuleData.ExecuteReader(sSQL));

        for (int i = 0; i < dtSite.Rows.Count; i++)
        {
          for(int j = 0; j < lstCat.Items.Count; j++)
          {

            if (((DataRowView)lstCat.Items[j]).Row.ItemArray[1].ToString() == ((DataRow)dtSite.Rows[i])["NTYPECONTRAT"].ToString())
              lstCat.SetItemChecked(j, true);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CocherLesCat()

    //Dim rsSite As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer

    //On Error GoTo handler


    //  ' recherche de la liste des comptes à cocher
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "SELECT NTYPECONTRAT From TCONT WHERE VCONTETAT = 'OUI' AND NSITNUM=" & frmDetailsSite.miNumSite

    //  rsSite.Open sSQL, cnx

    //  ' parcours du recordset et de la listebox
    //  While Not rsSite.EOF
    //    i = 0
    //    For i = 0 To lstCat.ListCount - 1
    //      If lstCat.ItemData(i) = rsSite(0) Then
    //        lstCat.Selected(i) = True
    //       End If
    //    Next
    //    rsSite.MoveNext
    //  Wend
    //  rsSite.Close

    //Exit Sub
    //handler:
    //  ShowError " CocherLesSites dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      EnregContrat();
    }
    //Private Sub cmdValider_Click()
    //  EnregContrat
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void EnregContrat()
    {
      //réinitialisation de toute les lignes pour ce site dans la table TCONT
      using (SqlCommand cmd = new SqlCommand($"update TCONT set VCONTETAT='NON' WHERE NSITNUM = {miNumSite}", MozartDatabase.cnxMozart))
      {
        cmd.ExecuteNonQuery();
      }

      foreach (DataRowView item in lstCat.CheckedItems)
      {
        //enregistrement dans la table TCONT
        ModuleData.ExecuteNonQuery($"update TCONT set VCONTETAT = 'OUI' WHERE NSITNUM = {miNumSite} AND NTYPECONTRAT = '{item["NTYPECONTRAT"]}'");
      }
    }
    //Private Sub EnregContrat()
    //Dim sSQL As String
    //Dim i As Integer
    //  ' réinitialisation de toute les lignes pour ce site dans la table TCONT
    //  cnx.Execute "update TCONT set VCONTETAT='NON' WHERE NSITNUM =" & frmDetailsSite.miNumSite
    //  ' parcours du listview  et update de TCONT en fonction des coches
    //  i = 0
    //  For i = 0 To lstCat.ListCount - 1
    //    If lstCat.Selected(i) = True Then
    //      ' enregistrement dans la table TCONT
    //      sSQL = "update TCONT set VCONTETAT='OUI'"
    //      sSQL = sSQL & " WHERE NSITNUM =" & frmDetailsSite.miNumSite
    //      sSQL = sSQL & " AND NTYPECONTRAT = '" & lstCat.ItemData(i) & "'"
    //      ' execution de la requête
    //      cnx.Execute sSQL
    //     End If
    //  Next
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
  }
}

