using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixCompteAna : Form
  {
    public int miNumCli;

    public frmChoixCompteAna() { InitializeComponent(); }

    private void frmChoixCompteAna_Load(object sender, EventArgs e)
    {
      string sSQL;
      try
      {
        ModuleMain.Initboutons(this);

        sSQL = "SELECT TCAN.NCANNUM, CAST(TCAN.NCANNUM AS VARCHAR) + ' - ' + VCANLIB [VCANLIB]"
              + " FROM TCAN WITH (NOLOCK) , TREF_CTEANA WITH (NOLOCK) "
              + " WHERE (NCLINUM = " + miNumCli + ") AND TCAN.NCANNUM = TREF_CTEANA.NCANNUM AND VSOCIETE = App_Name() "
              + " AND CCANACTIF = 'O' AND TCAN.NCANNUM not in (263,264,240) ORDER BY TCAN.NCANNUM ";

        ModuleData.RemplirCombo(cboCan, sSQL);

        if (frmAddAction.iNumCanMulti != 0)
          cboCan.SelectedValue = frmAddAction.iNumCanMulti;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        frmAddAction.iNumCanMulti = 0;

        if (cboCan.Text == "")
          return;

        frmAddAction.iNumCanMulti = Convert.ToInt32(cboCan.SelectedValue);

        cmdFermer.PerformClick();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
  }
}
