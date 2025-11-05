using Microsoft.VisualBasic;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmRechCodePostal : Form
  {
    //Public ControlCible1 As TextBox
    //Public ControlCible2 As ComboBox
    public TextBox ControlCible1;
    public ComboBox ControlCible2;

    public frmRechCodePostal()
    {
      InitializeComponent();
    }
    /* OK --------------------------------------------------------------------------------------- */
    private void frmRechCodePostal_Load(object sender, EventArgs e)
    {

    }
    //Private Sub Form_Load()
    //  SizeCombo cboDept, 350
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      if (txtVille.Text == "")
        return;

      cboDept.Items.Clear();

      using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT CODEPOSTAL, VILLE FROM TCOMMUNE WHERE VILLE LIKE '%"
                                              + txtVille.Text.Replace("'", "''") + "%' ORDER BY CODEPOSTAL"))
      {
        while (dr.Read())
          cboDept.Items.Add(dr["CODEPOSTAL"].ToString() + " " + dr["VILLE"].ToString());
        if (cboDept.Items.Count > 0)
          cboDept.SelectedIndex = 0;
        dr.Close();
      }
    }
    //Private Sub cmdRecherche_Click()

    //  If txtVille = "" Then Exit Sub

    //  ' Recherche des codes postaux possibles pour cette ville
    //  Dim rs As New ADODB.Recordset

    //  cboDept.Clear

    //  rs.Open "SELECT CODEPOSTAL, VILLE FROM TCOMMUNE WHERE VILLE LIKE '%" & Replace(txtVille, "'", "''") & "%' ORDER BY CODEPOSTAL", cnx
    //  While Not rs.EOF
    //    cboDept.AddItem rs!CODEPOSTAL & " " & rs!ville
    //    rs.MoveNext
    //  Wend
    //  On Error Resume Next
    //  cboDept.ListIndex = 0
    //  rs.Close
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (cboDept.SelectedIndex >= 0)
      {
        ControlCible1.Text = "";
        ControlCible1.Text = Strings.Left(cboDept.Text, 5);
        ControlCible2.Text = Strings.Mid(cboDept.Text, 7);
        Close();
      }
    }
    //Private Sub OKButton_Click()
    //  If cboDept.ListIndex >= 0 Then
    //    ControlCible1.Text = ""
    //    ControlCible1.Text = Left(cboDept, 5)
    //    ControlCible2.Text = Mid(cboDept, 7)
    //    Unload Me
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void txtVille_TextChanged(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
      txtVille.SelectionStart = 100;
    }
    //Private Sub txtVille_Change()
    //  txtVille = Majuscule(txtVille)
    //  txtVille.SelStart = 100
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCancel_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
    //Private Sub CancelButton_Click()
    //   Unload Me
    //End Sub
  }
}
