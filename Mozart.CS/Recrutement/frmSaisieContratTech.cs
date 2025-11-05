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
  public partial class frmSaisieContratTech : Form
  {

    public int miNumTech;
    public string mstrType = "";
    DataTable dtContrat = new DataTable();
    DataTable dtContratTech = new DataTable();


    public frmSaisieContratTech()
    {
      InitializeComponent();
    }


    private void frmSaisieContratTech_Load(object sender, System.EventArgs e)
    {
      string sSQL;
      try
      {
        ModuleMain.Initboutons(this);
        sSQL = $"select left(vtypecontrat, 30) as CONTRAT, ntypecontrat from tref_typecontrat " +
          $"where VCONTRATCOUR <> 'Hors C' AND CACTIF = 'O' and langue='{MozartParams.Langue}' ORDER BY CONTRAT";
        SqlDataReader dataReaderContrat = ModuleData.ExecuteReader(sSQL);
        dtContrat.Load(dataReaderContrat);
        dataReaderContrat.Close();
        lstContrat.DataSource = dtContrat;

        sSQL = $"SELECT NTYPECONTRAT FROM {(mstrType == "PER" ? "TPERTYPECONTRAT" : "TRECRUTYPECONTRAT")} WHERE NPERNUM = {miNumTech}";

        SqlDataReader dataReaderContratTech = ModuleData.ExecuteReader(sSQL);
        dtContratTech.Load(dataReaderContratTech);
        dataReaderContratTech.Close();

        InitList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitList()
    {
      lstContrat.DisplayMember = "CONTRAT";
      lstContrat.ValueMember = "NTYPECONTRAT";

      if (dtContratTech.Rows.Count == 0)
        return;

      // on coche les contrat du tech
      for (int i = 0; i < dtContrat.Rows.Count; i++)
      {
        {
          foreach (DataRow rowContratTech in dtContratTech.Rows)
          {
            if (dtContrat.Rows[i]["ntypecontrat"].ToString() == rowContratTech["ntypecontrat"].ToString())
              lstContrat.SetItemChecked(i, true);
          }
        }
      }
    }


    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdEnregistrer_Click()
    //Dim sSql As String
    //Dim i As Integer
    //  ' on supprime tous les enregitrements
    //  If mstrType = "PER" Then
    //    sSql = "DELETE TPERTYPECONTRAT WHERE NPERNUM = " & miNumTech
    //  Else
    //    sSql = "DELETE TRECRUTYPECONTRAT WHERE NPERNUM = " & miNumTech
    //  End If
    //  cnx.Execute sSql
    //  ' on se place au début
    //  For i = 0 To lstContrat.ListCount - 1
    //    If lstContrat.Selected(i) Then
    //      If mstrType = "PER" Then
    //        cnx.Execute "INSERT INTO TPERTYPECONTRAT (NPERNUM,NTYPECONTRAT) VALUES(" & miNumTech & ", " & lstContrat.ItemData(i) & ")"
    //      Else
    //        cnx.Execute "INSERT INTO TRECRUTYPECONTRAT (NPERNUM,NTYPECONTRAT) VALUES(" & miNumTech & ", " & lstContrat.ItemData(i) & ")"
    //      End If
    //    End If
    //  Next i
    //  lstContrat.ListIndex = 0
    //End Sub

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      string sSQL;

      //on supprime tous les enregitrements
      sSQL = $"DELETE {(mstrType == "PER" ? "TPERTYPECONTRAT" : "TRECRUTYPECONTRAT")} WHERE NPERNUM = {miNumTech}";

      using (var cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
        cmd.ExecuteNonQuery();

      //on se place au début
      foreach (var contrat in lstContrat.CheckedItems)
      {
        sSQL = $"INSERT INTO {(mstrType == "PER" ? "TPERTYPECONTRAT" : "TRECRUTYPECONTRAT")} (NPERNUM,NTYPECONTRAT) " +
          $"VALUES({miNumTech}, {((DataRowView)contrat)["NTYPECONTRAT"]})";
        using (var cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
          cmd.ExecuteNonQuery();
      }
    }

   
  }
}

