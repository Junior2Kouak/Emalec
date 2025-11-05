using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MozartLib;
using MozartNet;
using MozartUC;

namespace MozartCS
{
  public partial class frmSaisieDepContMait : Form
  {
    //  'Permet d'attribuer des départements pour un contremaître

    public int miNumTech = 0;
    DataTable dtCont = new DataTable();
    //Public miNumTech As Integer
    //Dim adoRsDepCont As ADODB.Recordset

    // frmSaisieDepContMait est normalement appelé depuis frmDetailpersonnel
    // Dans ce cas, il faut utilsier le 2ème construceur (avec un iNumTech)
    public frmSaisieDepContMait()
    {
      InitializeComponent();
    }

    public frmSaisieDepContMait(int iNumTech)
    {
      miNumTech = iNumTech;
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmSaisieDepContMait_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NPERNUM,NREGCOD,NPAYSNUM FROM TPERCONTMAIT WHERE NPERNUM = {miNumTech} AND NPAYSNUM = 1");
        dtCont.Load(dr);
        dr.Close();

        InitListDepartement();
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }
    //Private Sub Form_Load()

    //    'init
    //    InitBoutons Me, frmMenu
    //    Set adoRsDepCont = New ADODB.Recordset

    //    'charge la liste des departements dejà affecté au contremaitre
    //    adoRsDepCont.Open "SELECT NPERNUM,NREGCOD,NPAYSNUM FROM TPERCONTMAIT WHERE NPERNUM = " & miNumTech & " AND NPAYSNUM = 1", cnx

    //    'charge la liste des départements
    //    InitListDepartement

    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitListDepartement()
    {
      DataTable dtDept = new DataTable();
      string sSQL = "SELECT NREGCOD, NPAYSNUM, VREGLIB + ' - ' + VDEPLIB + ' (' + CAST(NREGCOD as VARCHAR(3)) + ')'  AS VDEPCONMAILIB " +
                    "FROM TREF_REG WHERE NPAYSNUM = 1 ORDER BY VREGLIB, NREGCOD";
      SqlDataReader dr = ModuleData.ExecuteReader(sSQL);
      dtDept.Load(dr);
      dr.Close();

      lstDepContMai.DataSource = dtDept;
      lstDepContMai.DisplayMember = "VDEPCONMAILIB";
      lstDepContMai.ValueMember = "NREGCOD";

      for (int i = 0; i < dtDept.Rows.Count; i++)
      {
        foreach (DataRow rowCont in dtCont.Rows)
        {
          //On Coche les contrat du tech
          if (dtDept.Rows[i]["NREGCOD"].ToString() == rowCont["NREGCOD"].ToString())
            lstDepContMai.SetItemChecked(i, true);
        }
      }
    }
    //'Charge la liste des départements
    //'****************************************************************
    //Private Sub InitListDepartement()

    //  Dim adoRsDep As New ADODB.Recordset
    //  Dim i As Integer
    //  Dim sSQL As String

    //  sSQL = "SELECT NREGCOD,NPAYSNUM,VREGLIB + ' - ' + VDEPLIB + ' (' + CAST(NREGCOD as VARCHAR(3)) + ')'  AS VDEPCONMAILIB " & _
    //          "FROM TREF_REG WHERE NPAYSNUM = 1 ORDER BY VREGLIB,NREGCOD"

    //  adoRsDep.Open sSQL, cnx
    //  If adoRsDep.RecordCount = 0 Then Exit Sub

    //  ' on rempli la liste
    //  i = 0
    //  While Not adoRsDep.EOF
    //    lstDepContMai.AddItem (adoRsDep("VDEPCONMAILIB"))
    //    lstDepContMai.ItemData(i) = adoRsDep("NREGCOD")
    //    If adoRsDepCont.RecordCount > 0 Then
    //      While Not adoRsDepCont.EOF
    //        ' on coche les contrat du tech
    //        If adoRsDep("NREGCOD") = adoRsDepCont("NREGCOD") Then
    //          lstDepContMai.Selected(lstDepContMai.ListCount - 1) = True
    //        End If
    //        adoRsDepCont.MoveNext
    //      Wend
    //      adoRsDepCont.MoveFirst
    //    End If
    //    i = i + 1
    //    adoRsDep.MoveNext
    //  Wend
    //  lstDepContMai.ListIndex = 0

    //  adoRsDep.Close
    //  Set adoRsDep = Nothing

    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, System.EventArgs e)
    {
      // Enregistrement des departements pour la personne
      //on supprime tous les enregitrements
      using (var cmd = new SqlCommand($"DELETE TPERCONTMAIT WHERE NPERNUM = {miNumTech}", MozartDatabase.cnxMozart))
      {
        cmd.ExecuteNonQuery();
      }

      //on se place au début
      foreach (DataRowView row in lstDepContMai.CheckedItems)
      {
        using (var cmd = new SqlCommand($"INSERT INTO TPERCONTMAIT (NPERNUM, NREGCOD, NPAYSNUM) VALUES ({miNumTech}, {row["NREGCOD"]}, 1)", MozartDatabase.cnxMozart))
        {
          cmd.ExecuteNonQuery();
        }
      }
    }
    //Private Sub cmdEnregistrer_Click()

    //  Dim sSQL As String
    //  Dim i As Integer

    //    'Enregistrement des departements pour la personne
    //    'on supprime tous les enregitrements
    //    sSQL = "DELETE TPERCONTMAIT WHERE NPERNUM = " & miNumTech
    //    cnx.Execute sSQL

    //    ' on se place au début
    //    For i = 0 To lstDepContMai.ListCount - 1
    //      If lstDepContMai.Selected(i) Then
    //        cnx.Execute "INSERT INTO TPERCONTMAIT (NPERNUM,NREGCOD,NPAYSNUM) VALUES(" & miNumTech & ", " & lstDepContMai.ItemData(i) & ",1)"
    //      End If
    //    Next i

    //    lstDepContMai.ListIndex = 0
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //If adoRsDepCont.RecordCount > 0 Then
    //  If adoRsDepCont.State = adStateOpen Then
    //    adoRsDepCont.Close
    //  End If
    //End If
    //Set adoRsDepCont = Nothing
    //Unload Me
    //End Sub
  }
}