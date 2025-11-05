using MozartCS.Properties;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmCopyProfil : Form
  {
    public int miNumClient;
    public string msType;     // client web(C), tech web(T) , personnel mozart(M)

    public frmCopyProfil()
    {
      InitializeComponent();
    }

    private void frmCopyProfil_Load(object sender, EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        string sSql;
        if (msType == "C")
        {
          sSql = $"SELECT distinct 0 ID, VUTILOG From TUTI WHERE (CUTICAT = 'C') AND NUTINUM = {miNumClient} ORDER BY VUTILOG";
          ModuleData.RemplirCombo(cboTech1, sSql);
          cboTech1.ValueMember = "ID";
          cboTech1.DisplayMember = "VUTILOG";
          ModuleData.RemplirCombo(cboTech2, sSql);
          cboTech2.ValueMember = "ID";
          cboTech2.DisplayMember = "VUTILOG";
        }
        else if (msType == "M")
        {
          sSql = "SELECT NPERNUM, NOM from [api_v_Msg_Destinataires_all] ORDER BY NOM";
          ModuleData.RemplirCombo(cboTech1, sSql);
          cboTech1.ValueMember = "NPERNUM";
          cboTech1.DisplayMember = "NOM";
          ModuleData.RemplirCombo(cboTech2, sSql);
          cboTech2.ValueMember = "NPERNUM";
          cboTech2.DisplayMember = "NOM";
        }
        else //if (msType == "T")
        {
          sSql = "select NPERNUM, VPERNOM from TPER where (CPERTYP='TE' or CPERTYP='CA') AND CPERACTIF='O' AND VSOCIETE = App_Name() ORDER BY  VPERNOM";
          ModuleData.RemplirCombo(cboTech1, sSql);
          cboTech1.ValueMember = "NPERNUM";
          cboTech1.DisplayMember = "VPERNOM";
          ModuleData.RemplirCombo(cboTech2, sSql);
          cboTech2.ValueMember = "NPERNUM";
          cboTech2.DisplayMember = "VPERNOM";
        }
        Cursor.Current = Cursors.Default;
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
        if (cboTech1.Text == cboTech2.Text)
        {
          MessageBox.Show(Resources.msg_ChoixImpossible);
          return;
        }

        if (cboTech1.Text == "")
        {
          MessageBox.Show(Resources.msg_SelectProfilSrc);
          return;
        }

        if (cboTech2.Text == "")
        {
          MessageBox.Show(Resources.msg_SelectProfilCible);
          return;
        }

        string sSQL = "";
        int iPersonne1 = (int)cboTech1.SelectedValue;
        int iPersonne2 = (int)cboTech2.SelectedValue;

        if (msType == "M")
        {
          ModuleData.ExecuteNonQuery($"DELETE FROM TDROIT WHERE NPERNUM = {iPersonne2}");
          sSQL = "INSERT INTO TDROIT (npernum, nmenunum, cdroitval, vsociete) " +
                 $"SELECT {iPersonne2}, nmenunum, cdroitval,vsociete FROM TDROIT WHERE npernum = {iPersonne1} AND vsociete = APP_NAME()";
        }
        else if (msType == "C")
        {
          ModuleData.ExecuteNonQuery($"delete from tdroitweb where vutilog = '{cboTech2.Text}' AND CUTICAT='C' AND NCLINUM = {miNumClient}");
          sSQL = $"INSERT INTO TDROITWEB (vutilog, CUTICAT, NCLINUM, nmenunum, cdroitval ) " +
                 $"SELECT '{cboTech2.Text}', CUTICAT, NCLINUM, nmenunum, cdroitval FROM TDROITWEB where vutilog = '{cboTech1.Text}' AND CUTICAT='C' AND NCLINUM = {miNumClient}";
        }
        else if (msType == "T")
        {
          ModuleData.ExecuteNonQuery($"delete from tdroitweb where vutilog = '{cboTech2.Text.Replace("'","''")}' AND CUTICAT='T' AND NCLINUM = {iPersonne2}");
          sSQL = $"INSERT INTO TDROITWEB (vutilog, CUTICAT, NCLINUM, nmenunum, cdroitval ) " +
                 $"SELECT '{cboTech2.Text.Replace("'", "''")}', CUTICAT,{iPersonne2}, nmenunum, cdroitval FROM TDROITWEB where vutilog = '{cboTech1.Text}' AND CUTICAT='T' AND NCLINUM = {iPersonne1}";
        }

        if (sSQL != "")
        {
          ModuleData.ExecuteNonQuery(sSQL);
          MessageBox.Show(Resources.msg_ProfilDe + cboTech2.Text + Resources.msg_CreeAPartirDe + cboTech1.Text, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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