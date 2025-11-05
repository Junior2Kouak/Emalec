using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmCopyStock : Form
  {
    public frmCopyStock()
    {
      InitializeComponent();
    }

    private void frmCopyStock_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        string sSql = $"SELECT DISTINCT TCLI.NCLINUM, VCLINOM From TCLI, TSTOCKARTCLI Where VSOCIETE = '{MozartParams.NomSociete}' AND TCLI.nClinum = TSTOCKARTCLI.nClinum ORDER BY VCLINOM";
        apicboClient1.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, MZCtrlResources.col_Client }, 400, 300);

        sSql = $"SELECT DISTINCT TCLI.NCLINUM, VCLINOM From TCLI Where CCLIACTIF = 'O' AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY VCLINOM";
        apicboClient2.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, MZCtrlResources.col_Client }, 400, 300);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      int iClient1;
      int iClient2;

      string sSql;
      try
      {

        // test de cohérence de choix
        if (apicboClient1.GetText() == apicboClient2.GetText())
        {
          MessageBox.Show(Resources.msg_ChoixImpossible);
          return;
        }

        if (apicboClient1.GetText() == "")
        {
          MessageBox.Show(Resources.msg_SelectClientSrc);
          return;
        }

        if (apicboClient2.GetText() == "")
        {
          MessageBox.Show(Resources.msg_SelectClientCible);
          return;
        }

        iClient1 = apicboClient1.GetItemData();
        iClient2 = apicboClient2.GetItemData();

        // Vérification qu'un stock client n'existe pas déjà pour le client VERS
        int nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TSTOCKARTCLI WHERE NCLINUM = {iClient2}");
        if (nb > 0)
        {
          MessageBox.Show(Resources.msg_LeClient + apicboClient2.Text + Resources.msg_AlreadyOwnsStock, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // Insertion dans la table des stocks client avec copie sur la personne DE
        sSql = $"INSERT INTO TSTOCKARTCLI  SELECT {iClient2}, NFOUNUM, NSTFNUM, NPUHTCLI, 'O', NGESTSTOCKCLI FROM TSTOCKARTCLI WHERE NCLINUM = {iClient1}";
        ModuleData.ExecuteNonQuery(sSql);

        // insertion dans la table des stocks site
        sSql = $"INSERT INTO TSTOCKARTCLISIT (NCLINUM, NFOUNUM, NSITNUM) select {iClient2}, NFOUNUM, NSITNUM FROM TSIT CROSS JOIN TSTOCKARTCLI " +
               $"WHERE TSIT.NCLINUM = {iClient2} AND TSTOCKARTCLI.NCLINUM= {iClient1}";
        ModuleData.ExecuteNonQuery(sSql);

        // Information sur résultat
        MessageBox.Show(Resources.msg_StockClientDe + apicboClient2.GetText() + Resources.msg_CreeAPartirDe + apicboClient1.GetText(), Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
