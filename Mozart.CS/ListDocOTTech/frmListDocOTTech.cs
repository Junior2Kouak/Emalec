using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListDocOTTech : Form
  {
    public string mstrClient = "";
    public string mstrSite = "";
    public string mstrNumDI = "";
    public long mlAction = 0;
    public long miImage = 0;

    private DataTable dt = new DataTable();

    private Size wbSize;
    private Point wbLocation;

    public frmListDocOTTech()
    {
      InitializeComponent();
    }

    private void frmListDocOTTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        wbLocation = WebBrowser1.Location;
        wbSize = WebBrowser1.Size;

        ModuleMain.Initboutons(this);

        txtClient.Text = mstrClient;
        txtSite.Text = mstrSite;
        txtDI.Text = mstrNumDI;

        //ouverture du recordset
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeDocTechAct {mlAction}");
        apigrid.GridControl.DataSource = dt;

        InitApigrid();
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

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      //gestion des cases cochées
      if (lstEns.Items.Count == 0 || lstEns.SelectedIndex == -1)
        return;

      foreach (var item in lstEns.CheckedItems)
      {
        string sSQL = $"INSERT INTO TIMAC (NACTNUM, VIMAGE, VFICHIER,CFORMAT, CCOMPRESS, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC) " +
                      $"select {((DataRowView)item)["NACTNUM"]}, VIMAGE, VFICHIER, CFORMAT, CCOMPRESS, VTYPE, CVUEWEB, VTYPEDEST, NTYPEDOC FROM TIMAC WHERE NIMAGE = {row["NIMAGE"]}";
        ModuleData.ExecuteNonQuery(sSQL);
      }

      Frame1.Visible = false;
    }

    private void cmdAjout_Click(object sender, EventArgs e)
    {
      try
      {
        WebBrowser1.Navigate("about:blank");

        //passage des paramètres
        new frmxActImg
        {
          mstrTypeDoc = "Technicien",
          mstrStatut = "C",
          mstrClient = txtClient.Text,
          mstrSite = txtSite.Text,
          mstrDI = txtDI.Text,
          mlAction = mlAction,
          miImage = 0
        }.ShowDialog();

        //rafraichissement du recordset
        apigrid.Requery(dt, MozartDatabase.cnxMozart);

        foreach (DataRow row in dt.Rows)
        {
          if (Convert.ToInt64(row["NIMAGE"]) == miImage)
            break;
        }

        InitApigrid();
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
        DataRow row = apigrid.GetFocusedDataRow();
        if (null == row) return;

        new frmxActImg
        {
          mstrTypeDoc = "Technicien",
          mstrStatut = "M",
          mstrClient = txtClient.Text,
          mstrSite = txtSite.Text,
          mstrDI = txtDI.Text,
          mlAction = mlAction,
          miImage = Convert.ToInt32(row["NIMAGE"])
        }.ShowDialog();

        apigrid.Requery(dt, MozartDatabase.cnxMozart);

        InitApigrid();
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
        DataRow row = apigrid.GetFocusedDataRow();
        if (null == row) return;

        if (MessageBox.Show(Resources.msg_confirm_image_deletion, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        ModuleData.ExecuteNonQuery($"DELETE FROM TIMAC WHERE NIMAGE = {row["NIMAGE"]}");
        // Pas de kill de fichier si c'est un fichier qui est sur plusieurs actions
        // (on peut avoir le cas d'un même fichier physique référencé sur plusieurs actions de la DI)
        // On a fait le delete dans timac au - dessus, donc on doit avoir count = 0 pour pouvoir supprimer le fichier physique
        if (0 == (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(VFICHIER) FROM TIMAC WHERE VFICHIER = '{row["VFICHIER"]}'"))
        {
          // Libérer le fichier PDF du webbrowser avant Delete
          WebBrowser wb = WebBrowser1.CloneControl();
          WebBrowser1.Dispose();
          WebBrowser1 = wb;
          WebBrowser1.Location = wbLocation;
          WebBrowser1.Size = wbSize;
          this.Controls.Add(WebBrowser1);
          WebBrowser1.BringToFront();

          File.Delete(MozartParams.CheminDocTechnicien + row["VFICHIER"]);
        }

        apigrid.Requery(dt, MozartDatabase.cnxMozart);

        InitApigrid();
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
        WebBrowser1.Top = Frame2.Top;
        WebBrowser1.Left = Frame2.Left;
        CmdMax.Text = Resources.txt_Mini;
      }
      else
      {
        WebBrowser1.Location = wbLocation;
        WebBrowser1.Size = wbSize;
        CmdMax.Text = Resources.txt_Maxi;
      }
    }

    private void cmdCopier_Click(object sender, EventArgs e)
    {
      if (null == apigrid.GetFocusedDataRow()) return;

      RemplirListeActions();

      Frame1.Visible = true;
    }

      private void InitApigrid()
    {
      try
      {
        if (apigrid.dgv.Columns.Count == 0)
        {
          apigrid.AddColumn(Resources.col_NumImage, "NIMAGE", 0);
          apigrid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
          apigrid.AddColumn(Resources.col_Image, "VIMAGE", 3500);
          apigrid.AddColumn(Resources.col_Fichier, "VFICHIER", 0);
          apigrid.AddColumn(Resources.col_CodeFmt, "CFORMAT", 0);
          apigrid.AddColumn(Resources.col_Format, "VFORMAT", 1500);
          apigrid.AddColumn(Resources.col_Commentaire, "VCOMMENT", 7500);
          apigrid.AddColumn(Resources.col_Vueweb, "VTYPE", 0);

          apigrid.DesactiveListe();
          apigrid.InitColumnList();
        }

        apigrid_ClickE(null, null);
        DataRow row = apigrid.GetFocusedDataRow();
        if (null != row)
          cmdModifier.Enabled = cmdSupprimer.Enabled = true;
        else
          cmdModifier.Enabled = cmdSupprimer.Enabled = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apigrid_ClickE(object sender, EventArgs e)
    {
      WebBrowser1.Navigate("about:blank");
      DataRow row = apigrid.GetFocusedDataRow();
      if (null == row) return;

      WebBrowser1.Navigate(MozartParams.CheminDocTechnicien + row["VFICHIER"].ToString());
    }

    private void RemplirListeActions()
    {
      DataTable dtAct = new DataTable();
      try
      {
        string sSQL = "Select NACTNUM, cast(NACTID as varchar) + '-' + VSITNOM + '-' + left(VACTDES,50) 'SITE' FROM TSIT " +
                      $"INNER JOIN TACT ON TSIT.NSITNUM = TACT.NSITNUM WHERE NACTNUM <> {mlAction} AND NDINNUM = {mstrNumDI} order by NACTID";

        using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
        {
          dtAct.Load(dr);
          dr.Close();
        }

        lstEns.DataSource = dtAct;
        lstEns.DisplayMember = "SITE";
        lstEns.ValueMember = "NACTNUM";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void BtnCocheTS_Click(object sender, EventArgs e)
    {
      setTSState(true);
    }

    private void BtnDeCocheTS_Click(object sender, EventArgs e)
    {
      setTSState(false);
    }

    private void setTSState(bool pBCheched)
    {
      for (int i = 0; i < lstEns.Items.Count; i++)
      {
        lstEns.SetItemChecked(i, pBCheched);
      }
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdAnnuler_Click(object sender, EventArgs e)
    {
      Frame1.Visible = false;
    }

  }
}