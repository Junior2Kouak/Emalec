using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFicPerso : Form
  {
    DataTable dt = new DataTable();

    public long mlDoc;
    public long mlIdPerso;
    public string msLibNomSoc = "";
    public string mstrNomPerso = "";
    public string mstrPrenomPerso = "";
    public string mstrTypePerso = "";

    string strRepDocPerso;
    string strPreviousFormat = "";

    public frmListeFicPerso()
    {
      InitializeComponent();
    }

    private void frmListeFicPerso_Load(object sender, System.EventArgs e)
    {
      try
      {
        WebBrowser1.Visible = true;

        ModuleMain.Initboutons(this);

        // traitement du bouton de changement des docs
        if (mstrTypePerso == "RECRU")
          cmdType.Visible = false;

        if (mstrTypePerso == "PERSO")
          cmdType.Text = Resources.txt_PassageEnDocSecu;

        if (mstrTypePerso == "PERSOSECU")
          cmdType.Text = Resources.txt_PassageEnDocStand;

        Text = Resources.tlt_ListeDocPersoDe + mstrNomPerso + " " + mstrPrenomPerso + " - " + msLibNomSoc;

        strRepDocPerso = ModuleData.RechercheParam("REP_DOC_PERSONNEL", msLibNomSoc);

        InitData();
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitData()
    {
      string sSQL = $"exec api_sp_ListeDocPerso {mlIdPerso}, '{mstrTypePerso}'";
      apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiGrid.GridControl.DataSource = dt;
    }

    private void cmdAjout_Click(object sender, System.EventArgs e)
    {
      try
      {
        new frmAjoutDocPerso
        {
          mstrStatut = "C",
          mlDoc = 0,
          msLibNomSoc = msLibNomSoc,
          mstrNomPerso = mstrNomPerso,
          mstrPrenomPerso = mstrPrenomPerso,
          mlIdPerso = mlIdPerso,
          mstrTypePerso = mstrTypePerso,
          mstrRepDocPerso = strRepDocPerso
        }.ShowDialog();

        // rafraichissement du recordset
        apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (currentRow["CFORMAT"].ToString().ToUpper() == "XLS")
          ModuleMain.EndAllEXCELProcess();

        new frmAjoutDocPerso
        {
          mstrStatut = "M",
          mlDoc = Convert.ToInt64(currentRow["NIDFICPERSO"]),
          msLibNomSoc = msLibNomSoc,
          mstrNomPerso = mstrNomPerso,
          mstrPrenomPerso = mstrPrenomPerso,
          mlIdPerso = mlIdPerso,
          mstrTypePerso = mstrTypePerso,
          mstrRepDocPerso = strRepDocPerso
        }.ShowDialog();

        // Rafraichissement du recordset
        apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_ConfirmDelImg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        // modification du type de doc : si secu on passe en non secu et inversement
        MozartDatabase.ExecuteNonQuery($"DELETE FROM TFICPERSO WHERE NIDFICPERSO = {currentRow["NIDFICPERSO"]}");
        if (currentRow["CFORMAT"].ToString().ToUpper() == "XLS")
          ModuleMain.EndAllEXCELProcess();

        //File.Delete(strRepDocPerso + currentRow["VFICHIER"].ToString());
        if (CImpersonation.FileExistImpersonated(strRepDocPerso + currentRow["VFICHIER"].ToString()))
        {
          CImpersonation.DeleteFileImpersonated(strRepDocPerso + currentRow["VFICHIER"].ToString());
        }

        // fermeture du fichier local
        WebBrowser1.Navigate("about:blank");

        // Rafraichissement du recordset
        apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdMax_Click(object sender, EventArgs e)
    {
      if (CmdMax.Text == Resources.txt_Maxi)
      {
        WebBrowser1.Width = this.Width - 120;
        WebBrowser1.Height = this.Height - 90;
        WebBrowser1.Top = 40;
        WebBrowser1.Left = 100;
        WebBrowser1.BringToFront();
        CmdMax.Text = Resources.txt_Mini;
      }
      else
      {
        WebBrowser1.Width = apiGrid.Width;
        WebBrowser1.Height = this.Height - apiGrid.Top + apiGrid.Height + 10;
        WebBrowser1.Top = apiGrid.Top + apiGrid.Height + 10;
        WebBrowser1.Left = apiGrid.Left;
        CmdMax.Text = Resources.txt_Maxi;
      }
    }

    private void cmdType_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_ConfirmChangeDocType, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        // modification du type de doc : si secu on passe en non secu et inversement
        string strSQL = "UPDATE TFICPERSO SET VTYPE = '" + (mstrTypePerso == "PERSO" ? "PERSOSECU" : "PERSO") + "'";
        strSQL += $", DDATEMODIF = '{DateTime.Now.ToShortDateString()}', NQUI = {MozartParams.UID}";
        strSQL += $" WHERE NIDFICPERSO = {currentRow["NIDFICPERSO"]}";
        MozartDatabase.ExecuteNonQuery(strSQL);

        // rafraichissement du recordset
        apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn("Nom du fichier", "VIMAGE", 3500);
      apiGrid.AddColumn(Resources.col_Commentaire, "VCOMMENT", 7500);
      apiGrid.AddColumn("Date de dernière modif.", "DDATEMODIF", 1500, "dd/MM/yy", 1);
      apiGrid.AddColumn(Resources.col_Format, "VFORMAT", 1500, "", 1);

      apiGrid.InitColumnList();

      cmdModifier.Enabled = cmdSupprimer.Enabled = (dt.Rows.Count > 0);
    }

    private void apiGrid_ClickE(object sender, EventArgs e)
    {
      try
      {
        if (apiGrid.GetFocusedDataRow() == null) return;

        string strFile = strRepDocPerso + apiGrid.GetFocusedDataRow()["VFICHIER"].ToString();
        if (strPreviousFormat.ToUpper() == "XLS")
          ModuleMain.EndAllEXCELProcess();

        WebBrowser1.Navigate("about:blank");
        while (WebBrowser1.ReadyState != WebBrowserReadyState.Complete)
          Application.DoEvents();

        // Version pour impersonation
        if (CImpersonation.FileExistImpersonated(strFile))
        {
          WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(strFile));
        }

        strPreviousFormat = apiGrid.GetFocusedDataRow()["CFORMAT"].ToString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
