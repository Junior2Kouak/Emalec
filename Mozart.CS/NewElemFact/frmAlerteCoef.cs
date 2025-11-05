using MozartNet;
using MozartLib;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmAlerteCoef : Form
  {
    public bool frmNewElemFactbClose = false;

    public frmAlerteCoef()
    {
      InitializeComponent();
    }

    private void frmAlerteCoef_Load(object sender, System.EventArgs e)
    {
      ModuleData.ExecuteNonQuery($"DELETE TDINMARGE WHERE NDINNUM = {MozartParams.NumDi}");

      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_CalculCoefMarge2 {MozartParams.NumDi}"))
      {
        if (dr.Read())
        {
          double coef = Utils.ZeroIfNull(dr["coef"]);
          if (coef > 1.5)
          {
            lblCoef.ForeColor = Color.Green;
            frmNewElemFactbClose = true;
          }
          else
          {
            lblCoef.ForeColor = Color.Red;
            frmNewElemFactbClose = false;
          }
          lblCoef.Text += " " + coef.ToString();
        }
      }
    }
    //Private Sub Form_Load()
    //Dim rsCoef As New ADODB.Recordset
    // On Error Resume Next
    //  ' on calcul le coefficient sur la DI et on l'affiche
    //  cnx.Execute "DELETE TDINMARGE WHERE NDINNUM = " & giNumDi
    //  rsCoef.Open "api_sp_CalculCoefMarge2 " & giNumDi, cnx
    //  If CDbl(rsCoef!coef) > 1.5 Then
    //  If CDbl(rsCoef("coef")) > 1.5 Then
    //    lblCoef.ForeColor = vbGreen
    //    frmNewElemFact.bClose = True
    //  Else
    //    lblCoef.ForeColor = vbRed
    //    frmNewElemFact.bClose = False
    //  End If
    //  lblCoef.Caption = lblCoef.Caption + CStr(rsCoef!coef)
    //  rsCoef.Close
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}
