using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmGIDTAdmin : Form
  {
    public frmGIDTAdmin()
    {
      InitializeComponent();
    }

    private void frmGIDTAdmin_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      cboclient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500);
      cboclient.SetItemIndex(0);

      //  If gintUID = 339 Then cmdSup.Visible = True Else cmdSup.Visible = False
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdGIDTListe_Click(object sender, EventArgs e)
    {
      int lCliNum = cboclient.GetItemData();
      if (lCliNum == -1) return;

      // 4031 : ARGEDIS
      if (verifTypeClientGidt(lCliNum) || (lCliNum == 4031))
      {
        if (verifArboCli(lCliNum))
        {
          new frmGIDTListe(lCliNum, cboclient.GetText(), true).ShowDialog();
        }
      }
      else
      {
        if (verifArbo(lCliNum))
        {
          new frmGIDTListe(lCliNum, cboclient.GetText(), false).ShowDialog();
        }
      }
    }

    private void cmdGIDTArbo_Click(object sender, EventArgs e)
    {
      int lCliNum = cboclient.GetItemData();
      if (lCliNum == -1) return;

      // 4031 : ARGEDIS
      if (verifTypeClientGidt(lCliNum) || (lCliNum == 4031))
      {
        new frmGIDTArbo(lCliNum, cboclient.GetText(), "OBJ").ShowDialog();
      } else
      {
        new frmGIDTArbo(lCliNum, cboclient.GetText(), "STD").ShowDialog();
      }
    }

    private void cmdGIDTSaisie_Click(object sender, EventArgs e)
    {
      int lCliNum = cboclient.GetItemData();
      if (lCliNum == -1) return;

      // 4031 : ARGEDIS
      if (verifTypeClientGidt(lCliNum) || (lCliNum == 4031))
      {
        if (verifArboCli(lCliNum))
        {
          new frmCliGIDTSaisie(lCliNum, cboclient.GetText()).ShowDialog();
        }
      }
      else
      {
        if (verifArbo(lCliNum))
        {
          new frmGIDTSaisie(lCliNum, cboclient.GetText()).ShowDialog();
        }
      }
    }

    private bool verifTypeClientGidt(int pCliNum)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT 1 FROM TCLI WHERE BCLIGESTNUM = 1 AND NCLINUM = {pCliNum}"))
      {
        if (reader.Read()) return true;
      }
      return false;
    }

    private bool verifArbo(int pCliNum)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT 1 FROM TGIDTARBO WHERE NCLINUM = {pCliNum}"))
      {
        if (reader.Read()) return true;
      }

      MessageBox.Show("Aucune arborescence n'est définie pour ce client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      return false;
    }

    private bool verifArboCli(int pCliNum)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT 1 FROM TGIDTARBOCLI WHERE NCLINUM = {pCliNum}"))
      {
        if (reader.Read()) return true;
      }

      MessageBox.Show("Aucune arborescence n'est définie pour ce client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      
      return false;
    }

    //Private Sub cmdSup_Click()
    //Dim rs As New ADODB.Recordset
    //Dim sSql As String
    //Dim fs As File
    //Dim sRep As String
    //Dim fso As New FileSystemObject

    //  Screen.MousePointer = vbHourglass

    //  If cboClient.ListIndex< 1 Then
    //    cboClient.SetFocus
    //  Else
    //    sSql = "SELECT VFICHIER FROM TFICOBJ INNER JOIN TGIDTOBJ ON NOBJET = NOBJNUM WHERE VFICHIER IS NOT NULL AND NCLINUM = " & cboClient.ItemData(cboClient.ListIndex)
    //    rs.Open sSql, cnx
    //    sRep = RechercheParam("REP_MEDIA")
    //    While Not rs.EOF
    //      If fso.FileExists(sRep & rs("VFICHIER")) Then
    //        fso.DeleteFile sRep & rs("VFICHIER")
    //      End If
    //      rs.MoveNext
    //    Wend
    //    rs.Close

    //    sSql = "DELETE TFICOBJ WHERE NOBJET IN (SELECT NOBJNUM FROM TGIDTOBJ WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & ")"
    //    cnx.Execute sSql
    //    sSql = "DELETE TGIDTOBJ WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex)
    //    cnx.Execute sSql
    //    sSql = "DELETE TGIDTARBO WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex)
    //    cnx.Execute sSql
    //  End If

    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}
