using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmRegoupRegPlan : Form
  {
    //Dim rs As ADODB.Recordset
    //Dim nbtxtbox As Integer

    List<apiTextBox> lstTxtRegion = new List<apiTextBox>();
    List<apiTextBox> lstTxtRegroup = new List<apiTextBox>();

    public frmRegoupRegPlan()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //      InitBoutons Me, frmMenu
    //      Set rs = New ADODB.Recordset
    //      rs.Open "select distinct vreglib, nregroupreg from tref_reg where npaysnum = 1", cnx
    //      InitForm
    //  End Sub

    private void frmRegoupRegPlan_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);
      Label2.BackColor = MozartColors.ColorH8000000F;
      InitForm();
    }

    //Private Sub InitForm()
    //  Dim i As Integer
    //      rs.MoveFirst
    //      txtRegion(0).Text = BlankIfNull(rs("vreglib").Value)
    //      txtRegroup(0).Text = BlankIfNull(rs("nregroupreg").Value)
    //      txtRegion(0).Enabled = False
    //      rs.MoveNext
    //      For i = 1 To (rs.RecordCount - 1)
    //          Load txtRegion(i)
    //          Load txtRegroup(i)
    //          txtRegion(i).Top = txtRegion(i - 1).Top + 285
    //          txtRegroup(i).Top = txtRegroup(i - 1).Top + 285
    //          txtRegion(i).Text = BlankIfNull(rs("vreglib").Value)
    //          txtRegroup(i).Text = BlankIfNull(rs("nregroupreg").Value)
    //          txtRegion(i).Visible = True
    //          txtRegroup(i).Visible = True
    //          rs.MoveNext
    //      Next i
    //      nbtxtbox = i
    //  End Sub

    private void InitForm()
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT DISTINCT VREGLIB, NREGROUPREG FROM TREF_REG WHERE NPAYSNUM = 1"))
      {
        while (dr.Read())
        {
          apiTextBox txtRegion = txtRegion0.CloneControl();
          apiTextBox txtRegroup = txtRegroup0.CloneControl();

          txtRegion.Left = txtRegion0.Left;
          txtRegion.Top = txtRegion0.Top + (21 * lstTxtRegion.Count);
          txtRegroup.Left = txtRegroup0.Left;
          txtRegroup.Top = txtRegroup0.Top + (21 * lstTxtRegion.Count);

          txtRegion.Text = dr["VREGLIB"].ToString();
          txtRegroup.Text = dr["NREGROUPREG"].ToString();
          txtRegion.Visible = true;
          txtRegroup.Visible = true;

          lstTxtRegion.Add(txtRegion);
          lstTxtRegroup.Add(txtRegroup);

          this.Controls.Add(txtRegion);
          this.Controls.Add(txtRegroup);
        }
        dr.Close();
      }
    }

    //  Private Sub cmdEnregistrer_Click()
    //    Enregistrer
    //  End Sub
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        string sSQL = "";
        for (int i = 0; i < lstTxtRegion.Count; i++)
        {
          if (lstTxtRegroup[i].Text == "")
            sSQL = $"UPDATE TREF_REG SET NREGROUPREG = NULL WHERE VREGLIB = '{lstTxtRegion[i].Text}'";

          if (int.TryParse(lstTxtRegroup[i].Text, out int result))
            sSQL = $"UPDATE TREF_REG SET NREGROUPREG = {lstTxtRegroup[i].Text} WHERE VREGLIB = '{lstTxtRegion[i].Text}'";

          using (var cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
            cmd.ExecuteNonQuery();
        }

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Enregistrer()
    //Dim i As Integer
    //Dim sSql As String
    //    For i = 0 To nbtxtbox - 1
    //        If txtRegroup(i).Text = "" Then
    //            sSql = "UPDATE TREF_REG SET NREGROUPREG = NULL " & txtRegroup(i).Text _
    //                & " WHERE VREGLIB = '" & txtRegion(i).Text & "'"
    //        End If
    //        If IsNumeric(txtRegroup(i).Text) Then
    //            sSql = "UPDATE TREF_REG SET NREGROUPREG = " & txtRegroup(i).Text _
    //                & " WHERE VREGLIB = '" & txtRegion(i).Text & "'"
    //        End If
    //        cnx.Execute (sSql)
    //    Next i
    //    rs.Close
    //    Unload Me
    //End Sub

    //Private Sub cmdQuitter_Click()
    //rs.Close
    //Unload Me
    //End Sub

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}

