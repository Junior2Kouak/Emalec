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
  public partial class frmSaisieContratST : Form
  {
    public long mlNumSTF;
    DataTable dtContrat = new DataTable();
    DataTable dtContratSTF = new DataTable();
    //Public miNumSTF As Long
    //Dim rsContrat As ADODB.Recordset
    //Dim rsContratSTF As ADODB.Recordset

    public frmSaisieContratST()
    {
      InitializeComponent();
    }

    private void frmSaisieContratST_Load(object sender, System.EventArgs e)
    {
      try
      {
        string sSQL = $"SELECT LEFT(VTYPECONTRAT, 30) AS CONTRAT, NTYPECONTRAT FROM TREF_TYPECONTRAT " +
                      $"WHERE VCONTRATCOUR <> 'Hors C' AND CACTIF = 'O' AND LANGUE = '{MozartParams.Langue}' ORDER BY CONTRAT";
        SqlDataReader drContrat = ModuleData.ExecuteReader(sSQL);
        dtContrat.Load(drContrat);
        drContrat.Close();

        lstContrat.DataSource = dtContrat;
        lstContrat.DisplayMember = "CONTRAT";
        lstContrat.ValueMember = "NTYPECONTRAT";

        SqlDataReader drSTF = ModuleData.ExecuteReader($"SELECT NTYPECONTRAT FROM TSTFTYPECONTRAT WHERE NSTFNUM = {mlNumSTF}");
        dtContratSTF.Load(drSTF);
        drSTF.Close();

        InitList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //Dim ssql As String
    //  ssql = "select left(vtypecontrat, 30) as CONTRAT, ntypecontrat from tref_typecontrat where VCONTRATCOUR <> 'Hors C' AND CACTIF = 'O' and langue='" & gstrLangue & "' ORDER BY CONTRAT"
    //  Set rsContrat = New ADODB.Recordset
    //  rsContrat.Open ssql, cnx
    //  ssql = "SELECT NTYPECONTRAT FROM TSTFTYPECONTRAT WHERE NSTFNUM = " & miNumSTF
    //  Set rsContratSTF = New ADODB.Recordset
    //  rsContratSTF.Open ssql, cnx
    //  InitList
    //End Sub

    private void InitList()
    {
      if (dtContratSTF.Rows.Count == 0)
        return;

      for (int i = 0; i < lstContrat.Items.Count; i++)
      {
        foreach (DataRow rowSTF in dtContratSTF.Rows)
        {
          //on coche les contrat du tech
          if (Convert.ToInt32(((DataRowView)lstContrat.Items[i]).Row.ItemArray[1]) == Convert.ToInt32(rowSTF["NTYPECONTRAT"]))
            lstContrat.SetItemChecked(i, true);
        }
      }
      lstContrat.SelectedItem = null;
    }
    //Private Sub InitList()
    //Dim i As Integer
    //  ' on rempli la liste
    //  i = 0
    //  While Not rsContrat.EOF
    //    lstContrat.AddItem (rsContrat("CONTRAT"))
    //    lstContrat.ItemData(i) = rsContrat("NTYPECONTRAT")
    //    If rsContratSTF.RecordCount > 0 Then
    //      While Not rsContratSTF.EOF
    //        ' on coche les contrat du tech
    //        If rsContrat("NTYPECONTRAT") = rsContratSTF("NTYPECONTRAT") Then
    //          lstContrat.Selected(lstContrat.ListCount - 1) = True
    //        End If
    //        rsContratSTF.MoveNext
    //      Wend
    //      rsContratSTF.MoveFirst
    //    End If
    //    i = i + 1
    //    rsContrat.MoveNext
    //  Wend
    //  lstContrat.ListIndex = 0
    //End Sub

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      //on supprime tous les enregistrements
      using (var cmd = new SqlCommand($"DELETE TSTFTYPECONTRAT WHERE NSTFNUM = {mlNumSTF}", MozartDatabase.cnxMozart))
        cmd.ExecuteNonQuery();

      //on se place au début
      foreach (DataRowView item in lstContrat.CheckedItems)
      {
        using (var cmd = new SqlCommand($"INSERT INTO TSTFTYPECONTRAT (NSTFNUM, NTYPECONTRAT) VALUES ({mlNumSTF}, {item["NTYPECONTRAT"]})", MozartDatabase.cnxMozart))
          cmd.ExecuteNonQuery();
      }
    }
    //Private Sub cmdEnregistrer_Click()
    //Dim ssql As String
    //Dim i As Integer
    //  ' on supprime tous les enregitrements
    //  ssql = "DELETE TSTFTYPECONTRAT WHERE NSTFNUM = " & miNumSTF
    //  cnx.Execute ssql
    //  ' on se place au début
    //  For i = 0 To lstContrat.ListCount - 1
    //    If lstContrat.Selected(i) Then
    //        cnx.Execute "INSERT INTO TSTFTYPECONTRAT (NSTFNUM,NTYPECONTRAT) VALUES(" & miNumSTF & ", " & lstContrat.ItemData(i) & ")"
    //    End If
    //  Next i
    //  lstContrat.ListIndex = 0
    //End Sub

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //  End Sub

    //Private Sub Form_Unload(Cancel As Integer)
    //  rsContrat.Close
    //  rsContratSTF.Close
    //End Sub
  }
}