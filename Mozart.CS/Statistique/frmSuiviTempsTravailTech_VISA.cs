using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviTempsTravailTech_VISA : Form
  {

    CTPS_RECUP_TECH oTpsRecupDetail;

    string sReturnVISA;  //ADD_VISA : on ajoute un visa ou DEL_VISA : on supprime le visa ou vide, on ne fait rien

    public string ValidVisa
    {
      get => sReturnVISA;     
    }
    public frmSuiviTempsTravailTech_VISA(object P_TpsRecupDetail)
    {
      InitializeComponent();

      oTpsRecupDetail = (CTPS_RECUP_TECH)P_TpsRecupDetail;

    }

    private void frmSuiviTempsTravailTech_VISA_Load(object sender, EventArgs e)
    {
      //init
      sReturnVISA = "";
      ModuleMain.Initboutons(this);      
      LoadData();     

    }
    private void LoadData()
    {
      Lbl_Info_VISA.Text = "";

      Lbl_Temps_Recup_Rest.Text = Format_Sec_To_HHmm(GetTotalTempsRecupRest((int)oTpsRecupDetail.NPERNUM));
      Lbl_Temps_Recup_Add.Text = Format_Sec_To_HHmm((int)oTpsRecupDetail.NSOLDE_SEC_BASE);

      Lbl_Info_VISA.Text = oTpsRecupDetail.DATE_AJOUT_VISA != null ? $"Le {oTpsRecupDetail.DATE_AJOUT_VISA} validé(e) par {oTpsRecupDetail.VQUI_AJOUT_VISA}" : "";

      BtnDelVisa.Visible = oTpsRecupDetail.DATE_AJOUT_VISA != null ? true : false;
      BtnAddVisa.Visible = !BtnDelVisa.Visible;

    }
    private int GetTotalTempsRecupRest(int P_NPERNUM)
    {
      return (int)ModuleData.ExecuteScalarInt($"SELECT ISNULL(SUM(NSOLDE_SEC_BASE), 0) AS TOT_NSOLDE_SEC_BASE FROM[DBO].[TTPS_RECUP] WITH(NOLOCK) WHERE[TTPS_RECUP].NPERNUM = {oTpsRecupDetail.NPERNUM}");
    }

    private string Format_Sec_To_HHmm(int p_tot_sec)
    {
      if (Math.Abs((int)p_tot_sec) < 3600)
      {
        return $"{GetPolarite((int)p_tot_sec)}00:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)p_tot_sec).Minutes)).ToString("00")}";
      }
      else
      {
        return $"{Math.Floor((decimal)TimeSpan.FromSeconds((int)p_tot_sec).TotalHours).ToString("00")}:{Math.Abs(Math.Floor((decimal)TimeSpan.FromSeconds((int)p_tot_sec).Minutes)).ToString("00")}";
      }
    }


    private string GetPolarite(int value) => value < 0 ? "-" : "";

    private void BtnAddVisa_Click(object sender, EventArgs e)
    {
      switch(MessageBox.Show("Voulez vous valider ce temps de récupération ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
        {
        case DialogResult.Yes:          
          oTpsRecupDetail.Save();
          oTpsRecupDetail.LoadData();
          LoadData();
          sReturnVISA = "ADD_VISA";
          Close();
          break;
        default:
          break;
      }


    }

    private void BtnDelVisa_Click(object sender, EventArgs e)
    {
      switch (MessageBox.Show("Voulez vous supprimer le VISA ce temps de récupération ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
      {
        case DialogResult.Yes:

          //on supprime la ligne dans TTPS_RECUP_SOLDE

          //on update toutes les lignes avec un recup id

          oTpsRecupDetail.Delete();
          oTpsRecupDetail.LoadData();
          LoadData();
          sReturnVISA = "DEL_VISA";
          Close();
          break;
        default:
          break;
      }
    }
  }
}
