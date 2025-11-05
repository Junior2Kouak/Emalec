using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestionAbsences : Form
  {

    public int miNumPer;
    public DateTime dDateDebut;


    public frmGestionAbsences()
    {
      InitializeComponent();
    }

    private void frmGestionAbsences_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        cboPersonnel.Init(MozartDatabase.cnxMozart, "SELECT NPERNUM, VPERNOM + ' ' + VPERPRE as VPERNOM FROM TPER WHERE CPERACTIF='O' AND VSOCIETE=App_Name() order by VPERNOM",
                        "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Type }, 150, 500, bHideFirstColumn: true);

        cboPersonnel.SetItemData(miNumPer);

        txtDate.DateTime = dDateDebut;

        cboAbs.Init(MozartDatabase.cnxMozart, "SELECT S.NSITNUM, VSITNOM FROM TSIT S INNER JOIN TLIENSITDI L ON L.NSITNUM=S.NSITNUM INNER JOIN TCLI C ON C.NCLINUM=S.NCLINUM WHERE VSOCIETE=App_Name() order by VSITNOM",
                        "NSITNUM", "VSITNOM", new List<string>() { Resources.col_Num, Resources.col_Type }, 150, 500, bHideFirstColumn: true);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private bool TestDI(long p_NSITNUM)
    {
      try
      {
        return (Convert.ToInt16(ModuleData.ExecuteScalarInt("SELECT count(*) FROM TLIENSITDI WHERE NDINNUM <> 0 AND NSITNUM = " + p_NSITNUM)) > 0);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.Default;
      Dispose();
    }

    // création des actions et des planifications
    private void CmdEnregistrer_Click(object sender, EventArgs e)
    {
      if (cboAbs.GetText() == "")
      {
        MessageBox.Show($"Il faut choisir un type d'absence !{Environment.NewLine}{Environment.NewLine}{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
                        Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (txtNbHeures.Text == "")
      {
        MessageBox.Show($"Il faut saisir une durée !{Environment.NewLine}{Environment.NewLine}{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
                        Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //Test si il existe une DI liée sur cette absence
      if (!TestDI(cboAbs.GetItemData()))
      {
        MessageBox.Show($"Il n'y a pas de DI liée sur ce type d'absence{Environment.NewLine}{Environment.NewLine}{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
                        Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      else
      {
        // appele de la procédure qui fera tout le travail
        ModuleData.ExecuteScalarInt("api_sp_CreationConges " + cboPersonnel.GetItemData() + "," + cboAbs.GetItemData() + ",'" + txtDate.Text + "'," + txtNbHeures.Text);

      }

      MessageBox.Show($"Enregistrement effectué{Environment.NewLine}{Environment.NewLine}{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
                      Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    }
  }
}