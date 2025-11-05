using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieCoefPrestation : Form
  {
    public string msCliNom;
    public int miNumCli;

    public frmSaisieCoefPrestation()
    {
      InitializeComponent();
    }

    private void frmSaisieCoefPrestation_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      lblTitre.Text += msCliNom;

      ModuleData.RemplirCombo(cboSerie, "SELECT NPRESTSERID, VPRESTSER FROM TPRESTSER UNION SELECT 0 , 'TOUTES' ORDER BY 2", true);
      cboSerie.SelectedValue = 0;
    }


    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(Resources.msg_ConfirmApplyCoef, Program.AppTitle, MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;

      try
      {
        string sSQL = "";
        if ((int)cboSerie.SelectedValue == 0)
        {
          sSQL = $"UPDATE TPRESTPRIXCLI SET NPRIXCLI = NPRIXCLI * CONVERT (DECIMAL(9,4),REPLACE('{ txtCoef.Text}',',','.')) WHERE NCLINUM = {miNumCli}";
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, toolTip1.GetToolTip(cmdValider), "Modification", "NCLINUM:" + miNumCli, "NPRESTSERID:ALL");
        }
        else
        {
          sSQL = $"UPDATE TPRESTPRIXCLI SET NPRIXCLI = NPRIXCLI * CONVERT (DECIMAL(9,4),REPLACE('{txtCoef.Text}',',','.')) WHERE NCLINUM = {miNumCli} AND NPRESTID IN (SELECT NPRESTID FROM TPREST WHERE NPRESTSERID = {cboSerie.SelectedValue})";
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, this.Text, toolTip1.GetToolTip(cmdValider), "Modification", "NCLINUM:" + miNumCli, $"NPRESTSERID:{cboSerie.SelectedValue}");
        }

        ModuleData.ExecuteNonQuery(sSQL);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      Dispose();
    }

    private void txtCoef_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);// pour virgule
    }

    private void txtCoef_Leave(object sender, EventArgs e)
    {
      Double value;

      NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
      string sep = nfi.NumberDecimalSeparator;

      if (Double.TryParse(txtCoef.Text.Replace(".", sep).Replace(",", sep), out value))
        txtCoef.Text = String.Format(CultureInfo.CurrentCulture, "{0:N4}", value);
      else
        txtCoef.Text = String.Empty;
    }
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
