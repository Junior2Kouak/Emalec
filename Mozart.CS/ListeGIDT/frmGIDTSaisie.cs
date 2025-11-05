using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGIDTSaisie : Form
  {
    private int mlNumClient;
    private string mstrNomClient;

    private DataTable dtArb = new DataTable();
    private DataTable dtObj = new DataTable();

    private string strRepImage;

    private int mlNumSite;

    private int lObjNum = 0;
    private int NbImg = 0;
    List<PictureBox> lstImages = new List<PictureBox>();

    private SqlDataAdapter daObj;

    public frmGIDTSaisie(int plNumClient, string pstrNomClient)
    {
      InitializeComponent();

      mlNumClient = plNumClient;
      mstrNomClient = pstrNomClient;
    }

    private void frmGIDTSaisie_Load(object sender, EventArgs e)
    {
      string sSql;

      Cursor.Current = Cursors.WaitCursor;
      ModuleMain.Initboutons(this);

      lblClient.Text += " " + mstrNomClient;
      strRepImage = Utils.RechercheParam("REP_MEDIA");

      sSql = $"SELECT NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND NCLINUM = {mlNumClient} ORDER BY VSITNOM";
      ModuleData.RemplirCombo(cboSite, sSql, false);
      cboSite.ValueMember = "NSITNUM";
      cboSite.DisplayMember = "VSITNOM";

      sSql = "SELECT TGIDTARBO.*, VTYPECONTRAT FROM TGIDTARBO INNER JOIN TREF_TYPECONTRAT R ON TGIDTARBO.NTYPECONTRAT=R.NTYPECONTRAT ";
      sSql += $"WHERE NCLINUM = {mlNumClient} AND LANGUE = '{MozartParams.Langue}' ORDER BY VTYPECONTRAT, VNIV1, VNIV2";
      GridH.LoadData(dtArb, MozartDatabase.cnxMozart, sSql);
      InitGridH();

      sSql = "SELECT * FROM api_v_GIDT_ListeObjetSite WHERE NOBJNUM IS NULL";
      GridB.LoadData(dtObj, MozartDatabase.cnxMozart, sSql);
      InitGridB();

      Cursor.Current = Cursors.Default;
    }

    private void cmdAddMedia_Click(object sender, EventArgs e)
    {
      try
      {
        //ccboSite_SelectedValueChanged(null, null);

        DataRow row = GridB.GetFocusedDataRow();
        if (row == null) return;

        Cursor.Current = Cursors.WaitCursor;
        frmMedia f = new frmMedia
        {
          mstrClient = mstrNomClient,
          mstrSite = cboSite.Text,
          miSitNum = mlNumSite,
          mstrStatut = "C",
          sType = "GIDT",
          mstrObjet = row["VOBJLIB"].ToString(),
          miObjet = Convert.ToInt32(row["NOBJNUM"])
        };
        f.ShowDialog();

        lObjNum = 0;   // Pour forcer le RowColChange à faire son boulot
        //GridB.Requery(dtObj, MozartDatabase.cnxMozart);
        GridB_FocusedRowChanged(null, null);
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

    private void cmdVisuMedia_Click(object sender, EventArgs e)
    {
      //cboSite_SelectedValueChanged(null, null);

      if (cmdShape1.Tag.ToString() == "") return;

      frmxVisuImg f = new frmxVisuImg
      {
        msImage = cmdShape1.Tag.ToString().Split('|')[0]
      };
      f.ShowDialog();
    }

    private void cmdModifMedia_Click(object sender, EventArgs e)
    {
      //cboSite_SelectedValueChanged(null, null);

      try
      {
        DataRow row = GridB.GetFocusedDataRow();
        if (row == null) return;

        if (cmdShape1.Tag.ToString() == "") return;

        Cursor.Current = Cursors.WaitCursor;
        frmMedia f = new frmMedia
        {
          mstrClient = mstrNomClient,
          mstrSite = cboSite.Text,
          miSitNum = mlNumSite,
          mstrStatut = "M",
          sType = "GIDT",
          mstrObjet = lblArbo.Text,
          miImage = Convert.ToInt32(cmdShape1.Tag.ToString().Split('|')[1]),
          miObjet = Convert.ToInt32(row["NOBJNUM"])
        };
        f.ShowDialog();

        lObjNum = 0;   // Pour forcer le RowColChange à faire son boulot
        //GridB.Requery(dtObj, MozartDatabase.cnxMozart);
        GridB_FocusedRowChanged(null, null);

        //ChargerImages(Convert.ToInt32(row["NOBJNUM"]), this, NbImg, mRepertoireDoc);
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

    private void cmdDelMedia_Click(object sender, EventArgs e)
    {
      try
      {
        //cboSite_SelectedValueChanged(null, null);

        if (cmdShape1.Tag.ToString() == "") return;

        if (MessageBox.Show("Voulez-vous vraiment supprimer cette image ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

        // Suppression en base (la suppression du fichier sur le disque se fait par le trigger TU_DELETE sur la table TFICOBJ)
        ModuleData.ExecuteNonQuery($"exec api_sp_SupprimerMedia {cmdShape1.Tag.ToString().Split('|')[1]}");

        lObjNum = 0;

        File.SetAttributes(cmdShape1.Tag.ToString().Split('|')[0], FileAttributes.Normal);
        File.Delete(cmdShape1.Tag.ToString().Split('|')[0]);

        GridB_FocusedRowChanged(null, null);
        cmdShape1.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDel_Click(object sender, EventArgs e)
    {
      //cboSite_SelectedValueChanged(null, null);

      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Voulez-vous vraiment supprimer cet objet ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

      GridB.dgv.DeleteRow(GridB.dgv.FocusedRowHandle);
    }

    private void InitGridH()
    {
      GridH.AddColumn("NARBONUM", "NARBONUM", 0);
      GridH.AddColumn("NCLINUM", "NCLINUM", 0);
      GridH.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 3000, "", 0, false, false, true);
      GridH.AddColumn("Niveau 1", "VNIV1", 4300, "", 0, false, false, true);
      GridH.AddColumn("Niveau 2", "VNIV2", 4300, "", 0, false, false, true);
      GridH.AddColumn("Niveau 3", "VNIV3", 4300);

      //      GridH.dgv.OptionsView.AllowCellMerge = true;
      //      GridH.dgv.Columns["VNIV3"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

      GridH.InitColumnList();
      GridH.GridControl.DataSource = dtArb;
    }

    private void InitGridB()
    {
      GridB.AddColumn("ID", "NOBJNUM", 0);
      GridB.AddColumn("NARBONUM", "NARBONUM", 0);
      GridB.AddColumn(MZCtrlResources.col_Client, "NCLINUM", 0);
      GridB.AddColumn(Resources.col_Site, "NSITNUM", 0);
      GridB.AddColumn("Objet", "VOBJLIB", 2400);
      GridB.AddColumn("NUMERO", "VOBJNUMERO", 2400);
      GridB.AddColumn(Resources.col_marque, "VOBJMAR", 2400);
      GridB.AddColumn(Resources.col_Type, "VOBJTYPE", 2400);
      GridB.AddColumn(Resources.col_reference, "VOBJREF", 2400);
      GridB.AddColumn("Qté", "NOBJQTE", 800);
      GridB.AddColumn("Modif", "DDATEMODIF", 1200);
      GridB.AddColumn("Compléments", "VOBJCOMP", 2000);

      GridB.DelockColumn("NOBJNUM");
      GridB.DelockColumn("NCLINUM");
      GridB.DelockColumn("NARBONUM");
      GridB.DelockColumn("NSITNUM");
      GridB.DelockColumn("VOBJLIB");
      GridB.DelockColumn("VOBJNUMERO");
      GridB.DelockColumn("VOBJMAR");
      GridB.DelockColumn("VOBJTYPE");
      GridB.DelockColumn("VOBJREF");
      GridB.DelockColumn("NOBJQTE");
      GridB.DelockColumn("VOBJCOMP");

      GridB.InitColumnList();

      GridB.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
      GridB.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      GridB.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;

      GridB.GridControl.DataSource = dtObj;
    }

    private void GridB_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      //  Eviter de recharger les images si on ne change pas d'objet
      cmdShape1.Tag = "";
      cmdShape1.Visible = false;

      // Décharger toutes les images. Recherche des images et affichage en miniature
      DechargerImages(ref NbImg);

      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      lObjNum = Convert.ToInt32(Utils.ZeroIfNull(row["NOBJNUM"]));

      // Décharger toutes les images. Recherche des images et affichage en miniature
      ChargerImages(lObjNum, ref NbImg);

      // Affichage et positionnement du bouton Delete + STT
      cmdDel.Visible = (lObjNum > 0);

      // Affichage ou non des boutons liés aux images
      cmdVisuMedia.Enabled = (NbImg > 0);
      cmdModifMedia.Enabled = (NbImg > 0);
      cmdDelMedia.Enabled = (NbImg > 0);

      Cursor.Current = Cursors.Default;
    }

    private void DechargerImages(ref int iNbImg)
    {
      for (int i = 0; i < lstImages.Count; i++)
      {
        lstImages[i].Image.Dispose();
        lstImages[i].Dispose();
      }
      lstImages.Clear();

      foreach (Control item in Frame1.Controls.OfType<Control>().ToList())
        if (!item.Name.StartsWith("cmd"))
          Frame1.Controls.Remove(item);

      iNbImg = 0;

      cmdDel.Visible = false;

      // Affichage ou non des boutons liés aux images
      cmdVisuMedia.Enabled = false;
      cmdModifMedia.Enabled = false;
      cmdDelMedia.Enabled = false;
    }

    private void ChargerImages(int lObjet, ref int iNbImg)
    {
      if (lObjet < 1)
        return;

      iNbImg = 0;

      //  Recherche et affichage des images de cet objet
      DataTable dtImg = new DataTable();
      dtImg.Load(ModuleData.ExecuteReader("SELECT * from TFICOBJ where NOBJET = " + lObjet));

      iNbImg = 0;
      foreach (DataRow item in dtImg.Rows)
      {
        PictureBox pic = new PictureBox
        {
          Height = 100,
          Width = 100,
          Left = (120 * lstImages.Count) + 120
        };
        lstImages.Add(pic);
        pic.Name = $"Img_{lstImages.Count}";
        Frame1.Controls.Add(pic);
        pic.BringToFront();
        pic.DoubleClick += new System.EventHandler(this.Image1_DoubleClick);
        pic.Click += new System.EventHandler(this.Image1_Click);
        ChargementImage(lstImages[iNbImg], item["VFICHIER"].ToString(), Convert.ToInt32(item["NFICHIER"]));
        iNbImg++;
      }
    }

    private void ChargementImage(PictureBox imgCtl, string sFichier, int iFichier)
    {
      string sStrFichier;

      int w = 100;
      int h = 100;
      float ratio;

      if (sFichier.ToUpper().EndsWith(".PDF"))
      {
        imgCtl.SizeMode = PictureBoxSizeMode.Zoom;
        imgCtl.Top = 16;
        imgCtl.Image = Resources.iconePDF;
      }
      else
      {
        sStrFichier = strRepImage + sFichier;

        imgCtl.SizeMode = PictureBoxSizeMode.AutoSize;
        Image img = Image.FromFile(sStrFichier);
        imgCtl.Image = new Bitmap(img);
        img.Dispose();

        ratio = (float)((double)imgCtl.Height / imgCtl.Width);

        if (ratio <= 1)
          h = Convert.ToInt32(w * ratio);
        else
          w = Convert.ToInt32(h / ratio);

        imgCtl.Top = 16;
        imgCtl.SizeMode = PictureBoxSizeMode.StretchImage;
        imgCtl.Tag = $"{sStrFichier}|{iFichier}";
        imgCtl.Height = h;
        imgCtl.Width = w;
      }

      imgCtl.Visible = true;
    }

    private void Image1_Click(object sender, EventArgs e)
    {
      PictureBox pic = sender as PictureBox;
      cmdShape1.Top = pic.Top - 4;
      cmdShape1.Left = pic.Left - 4;
      cmdShape1.Height = pic.Height + 8;
      cmdShape1.Width = pic.Width + 8;
      cmdShape1.Visible = true;
      cmdShape1.Tag = pic.Tag;
      cmdShape1.Visible = true;
    }

    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      frmxVisuImg f = new frmxVisuImg
      {
        msImage = (sender as PictureBox).Tag.ToString().Split('|')[0]
      };
      f.ShowDialog();
    }

    private void GridH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      string sSql;

      if (mlNumSite == 0)
      {
        return;
      }

      updateDB();

      DataRow row = GridH.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      dtObj = new DataTable();
      sSql = $"SELECT * FROM api_v_GIDT_ListeObjetSite WHERE NCLINUM = {mlNumClient} AND NSITNUM = {mlNumSite} AND NARBONUM = {row["NARBONUM"]}";
      daObj = new SqlDataAdapter(sSql, MozartDatabase.cnxMozart);
      dtObj.Clear();
      daObj.Fill(dtObj);
      GridB.GridControl.DataSource = dtObj;

      // Affichage de l'arborescence
      lblArbo.Text = $"Objets de : {row["VNIV1"]}  /  {row["VNIV2"]}  /  {row["VNIV3"]}";

      GridB_FocusedRowChanged(null, null);

      Cursor.Current = Cursors.Default;
    }

    private void cboSite_SelectedValueChanged(object sender, EventArgs e)
    {
      updateDB();

      mlNumSite = cboSite.GetItemData();
      GridB.Visible = (mlNumSite > 0);

      GridH_FocusedRowChanged(null, null);
    }

    private void GridB_InitNewRowE(object sender, InitNewRowEventArgs e)
    {
      DataRow currentGridHRow = GridH.GetFocusedDataRow();
      GridView currentView = (sender as GridView);

      currentView.SetRowCellValue(e.RowHandle, "NSITNUM", mlNumSite);
      currentView.SetRowCellValue(e.RowHandle, "NCLINUM", mlNumClient);
      currentView.SetRowCellValue(e.RowHandle, "NARBONUM", currentGridHRow["NARBONUM"]);

      // Mise à jour de la date de modif
      currentView.SetRowCellValue(e.RowHandle, "DDATEMODIF", DateTime.Now.ToShortDateString());
    }

    private void GridB_ValidateRowE(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      DataRow row = GridB.GetFocusedDataRow();

      if (Utils.BlankIfNull(row["VOBJLIB"]) == "")
      {
        MessageBox.Show("Libellé obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Valid = false;
        return;
      }
    }

    private void updateDB()
    {
      if (daObj == null) return;

      SqlCommandBuilder cbObj = new SqlCommandBuilder(daObj);
      daObj.InsertCommand = cbObj.GetInsertCommand();
      daObj.UpdateCommand = cbObj.GetUpdateCommand();
      daObj.DeleteCommand = cbObj.GetDeleteCommand();

      daObj.Update(dtObj);
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
    }

    private void cmdCopier_Click(object sender, EventArgs e)
    {
      if (mlNumSite == 0)
      {
        cboSite.Focus();
        return;
      }

      new frmGIDTCopieObjets(mlNumClient, mlNumSite, cboSite.Text).ShowDialog();
    }

    private void GridH_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle == GridH.dgv.FocusedRowHandle)
      {
        e.Appearance.BackColor = Color.LightSkyBlue;

        GridViewInfo info = GridH.dgv.GetViewInfo() as GridViewInfo;
        GridCellInfo cellInfo = info.GetGridCellInfo(e.RowHandle, GridH.dgv.Columns["VTYPECONTRAT"]);

        if (cellInfo == null) return;

        if (cellInfo.IsMerged)
        {
          for (int i = 0; i < cellInfo.MergedCell.MergedCells.Count; i++)
          {
            if (cellInfo.MergedCell.MergedCells[i].RowHandle == GridH.dgv.FocusedRowHandle)
            {
              e.Appearance.BackColor = Color.LightSkyBlue;
            }
          }
        }
      }
      else
        e.Appearance.BackColor = Color.Azure;
    }

    private void frmGIDTSaisie_FormClosed(object sender, FormClosedEventArgs e)
    {
      updateDB();
    }
  }
}