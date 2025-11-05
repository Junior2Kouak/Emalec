using System;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using MozartNet;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using System.Collections.Generic;
using System.Data;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieKMMensuelChaff : Form
  {
    public int miPerNumChaff;
    public int miNumVeh;

    DateTime dDate;
    List<Control> lstApiCombo = new List<Control>();
    List<Control> lstTxtKm = new List<Control>();
    List<Control> lstText1 = new List<Control>();

    public frmSaisieKMMensuelChaff() { InitializeComponent(); }


    private void frmSaisieKMMensuelChaff_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lblDate.Text = DateTime.Now.AddMonths(-1).ToString("MMM yyyy");

        // on positionne la date au premier jour du mois saisie
        string temp = $"{DateTime.Now.AddMonths(-1).Month}/{DateTime.Now.AddMonths(-1).Year}";
        dDate = Convert.ToDateTime(temp);

        //récupération de tous les apicombo, txtKm et Text1 du formulaire
        for (int i = 0; i <= 10; i++)
        {
          lstApiCombo.Add(this.Controls.Find("apiCombo1" + i.ToString(), false)[0]);
          lstTxtKm.Add(Frame1.Controls.Find("txtKm" + i.ToString(), false)[0]);
          lstText1.Add(Frame1.Controls.Find("Text1" + i.ToString(), false)[0]);
        }

        InitCombo();

        InitFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void apiComboALL_TxtChanged(object sender, EventArgs e)
    {
      apiCombo aC = (apiCombo)sender;
      int index = Convert.ToInt32(aC.Tag);
      apiTextBox aTBK = (apiTextBox)lstTxtKm[index];

      if (aC.GetItemData() != 0)
        aTBK.Text = "0";
      else
        aTBK.Text = "";
    }

    private void cmdCalcul_Click(object sender, EventArgs e)
    {
      double iTemp = 0;

      for (int i = 0; i <= 10; i++)
      {
        apiTextBox aTBKM = (apiTextBox)lstTxtKm[i];
        apiTextBox aTBT1 = (apiTextBox)lstText1[i];

        iTemp += Convert.ToInt32(Utils.ZeroIfNull(aTBKM.Text) - Utils.ZeroIfNull(aTBT1.Text));
        aTBT1.Text = aTBKM.Text;
      }

      txtDerNbKm.Text = (Utils.ZeroIfNull(txtDerNbKm.Text) + iTemp).ToString();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      //on vérifie si il n'y a pas de doublons
      for (int i = 0; i <= 10; i++)
      {
        for (int j = i + 1; j <= 10; j++)
        {
          apiCombo aC = (apiCombo)lstApiCombo[i];
          apiCombo aC2 = (apiCombo)lstApiCombo[j];

          if (aC.GetItemData() == aC2.GetItemData() && (aC.GetItemData() != -1 || aC2.GetItemData() != -1) && (aC.GetItemData() != 0))
          {
            MessageBox.Show(Resources.msg_DoublonsValidImp, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
      }

      // test si un compte est bien saisi
      for (int i = 0; i <= 10; i++)
      {
        apiCombo aC = (apiCombo)lstApiCombo[i];
        apiTextBox aTBK = (apiTextBox)lstTxtKm[i];

        if ((aC.GetItemData() == 0 || aC.GetItemData() == -1) && (Convert.ToInt32(Utils.ZeroIfBlank(aTBK.Text)) > 0))
        {
          MessageBox.Show("Un compte analytique est obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }

      // test valeur limite < 10000
      for (int i = 0; i <= 10; i++)
      {
        apiTextBox aTBK = (apiTextBox)lstTxtKm[i];

        if (Convert.ToInt32(Utils.ZeroIfBlank(aTBK.Text)) > 10000)
        {
          MessageBox.Show("Il faut saisir une valeur inférieure à 10 000", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }

      //Mettre à jour la base, delete all datas de la semaine  en cours
      ModuleData.CnxExecute($"DELETE FROM TVEHKM WHERE NPERNUM = {miPerNumChaff} AND  NVEHNUM = {miNumVeh} AND DVEHJOUR = '{dDate.ToShortDateString()}'");

      for (int i = 0; i <= 10; i++)
      {
        apiCombo aC = (apiCombo)lstApiCombo[i];
        apiTextBox aTBK = (apiTextBox)lstTxtKm[i];

        if (Convert.ToInt32(Utils.ZeroIfBlank(aTBK.Text)) > 0)
        {
          ModuleData.CnxExecute($"exec api_sp_SaisieKMs {miPerNumChaff}, {miNumVeh}, '{dDate.ToShortDateString()}', {aTBK.Text}, 0, 0, 0, {aC.GetItemData()}");
        }
      }

      // mise à jour du dernier kilomètrage du véhicule
      cmdCalcul_Click(null, null);

      ModuleData.CnxExecute($"UPDATE TVEHICULES SET NVEHDERKM = {txtDerNbKm.Text} WHERE NVEHNUM = {miNumVeh}");

      Dispose();
    }

    private void txtKmALL_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void InitCombo()
    {

      DataTable dt = new DataTable();
      using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC [api_sp_ListeCompteAnaSaisieKmsChaff] '{MozartParams.NomSociete}'"))
        dt.Load(dr);

      for (int j = 0; j < lstApiCombo.Count; j++)
      {
        apiCombo aC = (apiCombo)lstApiCombo[j];
        aC.Init(dt, $"EXEC [api_sp_ListeCompteAnaSaisieKmsChaff] '{MozartParams.NomSociete}'", "NCANNUM", "LIBELLE", new List<string>() { Resources.col_Num, "" }, 500, 250, true);
      }

    }

    private void InitFeuille()
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NVEHDERKM, VVEHIMAT FROM TVEHICULES WHERE NVEHNUM = {miNumVeh}"))
      {
        if (dr.Read())
        {
          this.Text += $" (véhicule : {dr["VVEHIMAT"]})";
          txtDerNbKm.Text = Utils.ZeroIfNull(dr["NVEHDERKM"]).ToString();
        }
      }

      DataTable dt = new DataTable();
      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NVEHCTE, NVEHKMJ FROM TVEHKM WHERE NPERNUM = {miPerNumChaff}" +
                                                         $" AND NVEHNUM = {miNumVeh} AND DVEHJOUR = '{dDate.ToShortDateString()}'"))
      {
        dt.Load(dr);
      }

      int j = 10;
      if (dt.Rows.Count < 11) j = dt.Rows.Count - 1;

      for (int i = 0; i <= j; i++)
      {
        apiCombo aC = (apiCombo)lstApiCombo[i];
        apiTextBox aTBK = (apiTextBox)lstTxtKm[i];
        apiTextBox aTBT1 = (apiTextBox)lstText1[i];

        aC.SetItemData(Convert.ToInt32(dt.Rows[i]["NVEHCTE"]));
        aTBK.Text = Utils.ZeroIfNull(dt.Rows[i]["NVEHKMJ"]).ToString();
        aTBT1.Text = Utils.ZeroIfNull(dt.Rows[i]["NVEHKMJ"]).ToString();
      }
    }
  }
}