using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSaisieLangPers : Form
  {
    //Public miNumTech As Integer
    //Dim rsLang As ADODB.Recordset
    //Dim rsLangPers As ADODB.Recordset

    public int miNumTech;
    DataTable dtLangues = new DataTable();
    DataTable dtPers = new DataTable();

    public frmSaisieLangPers()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmSaisieLangPers_Load(object sender, System.EventArgs e)
    {
      try
      {
        using (SqlDataReader dataReader = ModuleData.ExecuteReader("SELECT NLANGID, VLANGUE FROM TREF_LANG ORDER BY VLANGUE"))
        {
          dtLangues.Load(dataReader);
          lstLangue.DataSource = dtLangues;
          lstLangue.DisplayMember = "vlangue";
          lstLangue.ValueMember = "nlangid";
        }

        using (SqlDataReader readerPers = ModuleData.ExecuteReader($"SELECT nlangid FROM TPERLANG WHERE NPERNUM = {miNumTech}"))
        {
          dtPers.Load(readerPers);
        }

        InitList();
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }
    //Private Sub Form_Load()
    //Dim sSql As String
    //  sSql = "select vlangue, nlangid from tref_lang ORDER BY vlangue"
    //  Set rsLang = New ADODB.Recordset
    //  rsLang.Open sSql, cnx
    //  sSql = "SELECT nlangid FROM TPERLANG WHERE NPERNUM = " & miNumTech
    //  Set rsLangPers = New ADODB.Recordset
    //  rsLangPers.Open sSql, cnx
    //  InitList
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public void InitList()
    {
      for (int i = 0; i < lstLangue.Items.Count; i++)
      {
        int idLangue = (int)((DataRowView)lstLangue.Items[i]).Row.ItemArray[0];
        foreach (DataRow row in dtPers.Rows)
        {
          if ((int)row[0] == idLangue)
          {
            lstLangue.SetItemChecked(i, true);
            break;
          }
        }
      }
    }
    //Private Sub InitList()
    //Dim i As Integer
    //  ' on rempli la liste
    //  i = 0
    //  While Not rsLang.EOF
    //    lstLangue.AddItem (rsLang("vlangue"))
    //    lstLangue.ItemData(i) = rsLang("nlangid")
    //    If rsLangPers.RecordCount > 0 Then
    //      While Not rsLangPers.EOF
    //        ' on coche les contrat du tech
    //        If rsLang("nlangid") = rsLangPers("nlangid") Then
    //          lstLangue.Selected(lstLangue.ListCount - 1) = True
    //        End If
    //        rsLangPers.MoveNext
    //      Wend
    //      rsLangPers.MoveFirst
    //    End If
    //    i = i + 1
    //    rsLang.MoveNext
    //  Wend
    //  lstLangue.ListIndex = 0
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, System.EventArgs e)
    {
      using (var cmd = new SqlCommand($"DELETE TPERLANG WHERE NPERNUM = {miNumTech}", MozartDatabase.cnxMozart))
        cmd.ExecuteNonQuery();

      foreach (DataRowView item in lstLangue.CheckedItems)
      {
        using (var cmd = new SqlCommand($"INSERT INTO TPERLANG (NPERNUM,nlangid) VALUES({miNumTech}, {item["NLANGID"]})", MozartDatabase.cnxMozart))
          cmd.ExecuteNonQuery();
      }
    }
    //Private Sub cmdEnregistrer_Click()
    //Dim sSql As String
    //Dim i As Integer
    //  ' on supprime tous les enregitrements
    //  sSql = "DELETE TPERLANG WHERE NPERNUM = " & miNumTech
    //  cnx.Execute sSql
    //  ' on se place au début
    //  For i = 0 To lstLangue.ListCount - 1
    //    If lstLangue.Selected(i) Then
    //      cnx.Execute "INSERT INTO TPERLANG (NPERNUM,nlangid) VALUES(" & miNumTech & ", " & lstLangue.ItemData(i) & ")"
    //    End If
    //  Next i
    //  lstLangue.ListIndex = 0
    //End Sub


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()

    //  Unload Me

    //End Sub
    //Private Sub Form_Unload(Cancel As Integer)
    // rsLang.Close
    // rsLangPers.Close
    //End Sub
  }
}

