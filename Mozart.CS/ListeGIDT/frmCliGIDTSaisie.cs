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
  public partial class frmCliGIDTSaisie : Form
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

    public frmCliGIDTSaisie(int plNumClient, string pstrNomClient)
    {
      InitializeComponent();

      mlNumClient = plNumClient;
      mstrNomClient = pstrNomClient;
    }

    private void frmCliGIDTSaisie_Load(object sender, EventArgs e)
    {
      string sSql;

      Cursor.Current = Cursors.WaitCursor;
      ModuleMain.Initboutons(this);

      lblClient.Text += mstrNomClient;
      strRepImage = Utils.RechercheParam("REP_MEDIA");

      sSql = $"SELECT NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND NCLINUM = {mlNumClient} ORDER BY VSITNOM";
      ModuleData.RemplirCombo(cboSite, sSql, false);
      cboSite.ValueMember = "NSITNUM";
      cboSite.DisplayMember = "VSITNOM";

      sSql = $"SELECT NID, CONVERT(VARCHAR(20), NCOD) + ' - ' + VLIB AS VVALUE FROM TGIDTCLIAC WHERE NCLINUM = {mlNumClient} ORDER BY NCOD";
      ModuleData.RemplirCombo(cboAfCompt, sSql, false);
      cboAfCompt.ValueMember = "NID";
      cboAfCompt.DisplayMember = "VVALUE";

      sSql = $"SELECT NID, CONVERT(VARCHAR(20), NCOD) + ' - ' + VLIB AS VVALUE FROM TGIDTCLICR WHERE NCLINUM = {mlNumClient} ORDER BY NCOD";
      ModuleData.RemplirCombo(cboCentreRes, sSql, false);
      cboCentreRes.ValueMember = "NID";
      cboCentreRes.DisplayMember = "VVALUE";

      sSql = "SELECT NARBONUM, NCLINUM, TGIDTARBOCLI.NTYPECONTRAT, VTYPECONTRAT, VNIV1, VNIV2 FROM TGIDTARBOCLI ";
      sSql += "INNER JOIN TREF_TYPECONTRAT ON TGIDTARBOCLI.NTYPECONTRAT=TREF_TYPECONTRAT.NTYPECONTRAT ";
      sSql += $"WHERE NCLINUM = {mlNumClient} AND LANGUE = '{MozartParams.Langue}' ORDER BY VTYPECONTRAT, VNIV1";
      GridH.LoadData(dtArb, MozartDatabase.cnxMozart, sSql);
      InitGridH();

      sSql = "SELECT *, '' VSTFINTNOM, '' AS AFFCOMPT, '' AS CENTRERES FROM TGIDTOBJCLI WHERE NOBJNUM IS NULL";
      GridB.LoadData(dtObj, MozartDatabase.cnxMozart, sSql);
      InitGridB();

      Cursor.Current = Cursors.Default;
    }

    private void cmdAddMedia_Click(object sender, EventArgs e)
    {
      try
      {
        //cboSite_SelectedValueChanged(null, null);

        DataRow row = GridB.GetFocusedDataRow();
        if (row == null) return;

        Cursor.Current = Cursors.WaitCursor;
        frmMedia f = new frmMedia
        {
          mstrClient = mstrNomClient,
          mstrSite = cboSite.Text,
          miSitNum = mlNumSite,
          mstrStatut = "C",
          sType = "GIDTCLI",
          mstrObjet = row["VOBJLIB"].ToString(),
          miObjet = Convert.ToInt32(row["NOBJNUM"])
        };
        f.ShowDialog();

        lObjNum = 0;   // Pour forcer le RowColChange à faire son boulot
                       //        GridB.Requery(dtObj, MozartDatabase.cnxMozart);
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
      try
      {
        //cboSite_SelectedValueChanged(null, null);

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
          sType = "GIDTCLI",
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

        // Suppression en base (la suppression du fichier sur le disque se fait par le trigger TU_DELETE sur la table TFICOBJCLI)
        // VL -> Visiblement le trigger n'existe pas sur la table TFICOBJCLI !!!
        ModuleData.ExecuteNonQuery($"exec api_sp_SupprimerMedia {cmdShape1.Tag.ToString().Split('|')[1]}, 'GIDTCLI'");

        lObjNum = 0;
        //GridB.Requery(dtObj, MozartDatabase.cnxMozart);

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
      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Voulez-vous vraiment supprimer cet objet ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

      GridB.dgv.DeleteRow(GridB.dgv.FocusedRowHandle);
    }

    //Private Sub GridB_AfterColUpdate(ColIndex As Integer)
    //  If ColIndex = 15 Then
    //    If rsObj!BFACT = -1 Then rsObj!BFACT = 1
    //  End If
    //End Sub

    private void InitGridH()
    {
      GridH.AddColumn("NARBONUM", "NARBONUM", 0);
      GridH.AddColumn("NCLINUM", "NCLINUM", 0);
      GridH.AddColumn("NTYPECONTRAT", "NTYPECONTRAT", 0);
      GridH.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 4300, "", 0, false, false, true);
      GridH.AddColumn("Niveau 1", "VNIV1", 4300, "", 0, false, false, true);
      GridH.AddColumn("Niveau 2", "VNIV2", 4300, "", 0, false, false, true);

      GridH.dgv.OptionsView.AllowCellMerge = true;
      GridH.dgv.Columns["VNIV2"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

      GridH.InitColumnList();
      GridH.GridControl.DataSource = dtArb;
    }

    private void InitGridB()
    {
      GridB.AddColumn("ID", "NOBJNUM", 0);
      GridB.AddColumn(Resources.col_Site, "NSITNUM", 0);
      GridB.AddColumn("NARBONUM", "NARBONUM", 0);
      GridB.AddColumn("Equipement", "VOBJLIB", 1500);
      GridB.AddColumn("N° Equipement", "VOBJNUMEQUIP", 1000);
      GridB.AddColumn("Date Modif", "DDATEMODIF", 1000);
      GridB.AddColumn(Resources.col_marque, "VOBJMAR", 1500);
      GridB.AddColumn(Resources.col_Type, "VOBJTYPE", 1500);
      GridB.AddColumn(Resources.col_reference, "VOBJREF", 1500);
      GridB.AddColumn("N° Série", "VOBJNUMSERIE", 1000);
      GridB.AddColumn("Qté", "NOBJQTE", 800);
      GridB.AddColumn("Compléments", "VOBJCOMP", 1000);
      GridB.AddColumn("Repère plan", "VOBJREPPLAN", 1000);
      GridB.AddColumn("Nb/an", "NOBJNBINTER", 1000);
      GridB.AddColumn("H/inter", "NOBJDUREEINTER", 1000);
      GridB.AddColumn("€/inter", "NOBJMONTANTINTER", 1000);
      //GridB.AddColumn("Fact.", "BFACT", 500, "", 0, false, false, true);
      GridB.AddColumn("Stt", "VSTFINTNOM", 1000);
      GridB.AddColumn("Imposé", "VOBJSTFIMPOSE", 1000);
      GridB.AddColumn("Cotraitant", "VOBJSTFCOTRAITANT", 1000);
      GridB.AddColumn("Affect", "AFFCOMPT", 2800);
      GridB.AddColumn("Centre res", "CENTRERES", 2500);

      GridB.DelockColumn("VOBJLIB");
      GridB.DelockColumn("VOBJNUMEQUIP");
      GridB.DelockColumn("VOBJMAR");
      GridB.DelockColumn("VOBJTYPE");
      GridB.DelockColumn("VOBJREF");
      GridB.DelockColumn("VOBJNUMSERIE");
      GridB.DelockColumn("NOBJQTE");
      GridB.DelockColumn("VOBJCOMP");
      GridB.DelockColumn("VOBJREPPLAN");
      GridB.DelockColumn("NOBJNBINTER");
      GridB.DelockColumn("NOBJDUREEINTER");
      GridB.DelockColumn("NOBJMONTANTINTER");

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

      cmdAffectStt.Visible = (Convert.ToInt32(Utils.ZeroIfNull(row["NOBJINTNUM"])) > 0);
      cmdSupprStt.Visible = cmdAffectStt.Visible;

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

      cmdAffectStt.Visible = false;
      cmdSupprStt.Visible = cmdAffectStt.Visible;

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
      dtImg.Load(ModuleData.ExecuteReader("SELECT * from TFICOBJCLI where NOBJET = " + lObjet));

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
        sStrFichier = strRepImage + @"GIDTCLI\" + sFichier;

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
      sSql = "SELECT *, (SELECT VSTFNOM + ' - ' + VINTNOM FROM TINT INNER JOIN TSTF ON TINT.NSTFNUM = TSTF.NSTFNUM WHERE NINTNUM= TGIDTOBJCLI.NOBJINTNUM) AS VSTFINTNOM ";
      sSql += " ,(SELECT CONVERT(VARCHAR(20), NCOD) + ' - ' + VLIB FROM TGIDTCLIAC WHERE NID = NIDAFFCOMPT) AS AFFCOMPT";
      sSql += " ,(SELECT CONVERT(VARCHAR(20), NCOD) + ' - ' + VLIB FROM TGIDTCLICR WHERE NID = NIDCENTRERES) AS CENTRERES ";
      sSql += $" FROM TGIDTOBJCLI WHERE NSITNUM = {mlNumSite} AND NARBONUM = {row["NARBONUM"]}";

      daObj = new SqlDataAdapter(sSql, MozartDatabase.cnxMozart);
      dtObj.Clear();
      daObj.Fill(dtObj);
      GridB.GridControl.DataSource = dtObj;

      // Affichage de l'arborescence
      lblArbo.Text = $"Objets de : {row["VNIV1"]}  /  {row["VNIV2"]}";

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
      currentView.SetRowCellValue(e.RowHandle, "NARBONUM", currentGridHRow["NARBONUM"]);

      // Mise à jour de la date de modif
      currentView.SetRowCellValue(e.RowHandle, "DDATEMODIF", DateTime.Now.ToShortDateString());

      currentView.SetRowCellValue(e.RowHandle, "BFACT", 1);
    }

    private void GridB_ValidateRowE(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      string sSql;
      string sObjNumEquip;

      DataRow row = GridB.GetFocusedDataRow();

      if (Utils.BlankIfNull(row["VOBJLIB"]) == "")
      {
        MessageBox.Show("Libellé obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        e.Valid = false;
        return;
      }

      // Test de l'unicité du numero(selon cas de creation ou de modification)
      sObjNumEquip = Utils.BlankIfNull(row["VOBJNUMEQUIP"]);
      if (sObjNumEquip != "")
      {
        if (Convert.ToInt32(Utils.ZeroIfNull(row["NOBJNUM"])) > 0)
        {
          sSql = $"select count(VOBJNUMEQUIP) from tgidtobjcli where VOBJNUMEQUIP ='{sObjNumEquip}' AND NOBJNUM<>{Utils.BlankIfNull(row["NOBJNUM"])}";
        }
        else
        {
          sSql = $"select count(VOBJNUMEQUIP) from tgidtobjcli where VOBJNUMEQUIP ='{sObjNumEquip}'";
        }

        if (((int)ModuleData.ExecuteScalarInt(sSql)) > 0)
        {
          MessageBox.Show("Le numéro d'équipement saisi existe déjà dans la base. Ce numéro doit être unique", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
          e.Valid = false;
          return;
        }
      }
    }

    private void updateDB()
    {
      if (daObj == null) return;

      try
      {
        SqlCommandBuilder cbObj = new SqlCommandBuilder(daObj);
        daObj.InsertCommand = cbObj.GetInsertCommand();
        daObj.UpdateCommand = cbObj.GetUpdateCommand();
        daObj.DeleteCommand = cbObj.GetDeleteCommand();

        daObj.Update(dtObj);
      }
      catch (Exception)
      {
      }
    }

    private void cmdAffectStt_Click(object sender, EventArgs e)
    {
      int iSTF;
      int iINT;
      string sIMP;
      string sCOT;

      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Vous allez affecter ce STT à tous les éléments GIDT affichés !" + Environment.NewLine + "Etes-vous sûr ?",
                          Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

      iSTF = Convert.ToInt32(row["NOBJSTFNUM"]);
      iINT = Convert.ToInt32(row["NOBJINTNUM"]);
      sIMP = row["VOBJSTFIMPOSE"].ToString();
      sCOT = row["VOBJSTFCOTRAITANT"].ToString();

      foreach (DataRow lCurRow in dtObj.Rows)
      {
        lCurRow["NOBJSTFNUM"] = iSTF;
        lCurRow["NOBJINTNUM"] = iINT;
        lCurRow["VOBJSTFIMPOSE"] = sIMP;
        lCurRow["VOBJSTFCOTRAITANT"] = sCOT;
        lCurRow["VSTFINTNOM"] = txtStt.Text;
      }

      updateDB();
    }

    private void cmdSupprStt_Click(object sender, EventArgs e)
    {
      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      if (Utils.ZeroIfNull(row["NOBJINTNUM"]) == 0) return;

      row["NOBJINTNUM"] = DBNull.Value;
      row["NOBJSTFNUM"] = DBNull.Value;
      row["VOBJSTFIMPOSE"] = DBNull.Value;
      row["VSTFINTNOM"] = DBNull.Value;
      row["VOBJSTFCOTRAITANT"] = DBNull.Value;

      updateDB();
    }

    private void cmdValiderStt_Click(object sender, EventArgs e)
    {
      if (txtStt.Text == "")
      {
        frmStt.Visible = false;
      }
      else
      {
        if (cboImpose.SelectedIndex == -1)
        {
          cboImpose.Focus();
          return;
        }

        if (cboCotraitant.SelectedIndex == -1)
        {
          cboCotraitant.Focus();
          return;
        }

        DataRow row = GridB.GetFocusedDataRow();
        if (row == null) return;

        row["NOBJSTFNUM"] = cboImpose.Tag;
        row["NOBJINTNUM"] = cboCotraitant.Tag;
        row["VOBJSTFIMPOSE"] = cboImpose.Text;
        row["VSTFINTNOM"] = txtStt.Text;
        row["VOBJSTFCOTRAITANT"] = cboCotraitant.Text;

        frmStt.Visible = false;
      }
    }

    private void GridB_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      updateDB();

      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      //  ' Eviter de recharger les images si on ne change pas d'objet
      //  'On Error Resume Next
      //  If (GridB.col = 16 Or GridB.col = 17 Or GridB.col = 18) And Not frmAna.Visible And Not rsObj.EOF Then InfoStt
      switch (e.Column.Name)
      {
        case "VSTFINTNOM":
        case "VOBJSTFIMPOSE":
        case "VOBJSTFCOTRAITANT":
          if (!frmAna.Visible)
          {
            txtStt.Text = Utils.BlankIfNull(row["VSTFINTNOM"]);
            cboImpose.Tag = Utils.BlankIfNull(row["NOBJSTFNUM"]);
            cboCotraitant.Tag = Utils.BlankIfNull(row["NOBJINTNUM"]);
            cboImpose.Text = Utils.BlankIfNull(row["VOBJSTFIMPOSE"]);
            cboCotraitant.Text = Utils.BlankIfNull(row["VOBJSTFCOTRAITANT"]);

            frmStt.Visible = true;
          }
          break;

        case "AFFCOMPT":
        case "CENTRERES":
          if (cboAfCompt.Items.Count > 1)
          {
            cboAfCompt.SetItemData(Utils.ZeroIfNull(row["NIDAFFCOMPT"]).ToString());
            cboCentreRes.SetItemData(Utils.ZeroIfNull(row["NIDCENTRERES"]).ToString());

            frmAna.Visible = true;
          }
          break;
      }
      //  If (GridB.col = 19 Or GridB.col = 20) And Not frmStt.Visible And cboAfCompt.ListCount > 1 And cboCentreRes.ListCount > 1 And Not rsObj.EOF Then InfoAna
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      // affichage de l'écran de recherche du ST
      frmGIDTRechercheST lfrmGIDTRechercheST = new frmGIDTRechercheST();
      lfrmGIDTRechercheST.ShowDialog();

      txtStt.Text = $"{lfrmGIDTRechercheST.msST} - {lfrmGIDTRechercheST.msContact}";
      cboImpose.Tag = lfrmGIDTRechercheST.miSoustraitant;
      cboCotraitant.Tag = lfrmGIDTRechercheST.miContact;

      Cursor.Current = Cursors.Default;
    }

    private void cmdValiderAna_Click(object sender, EventArgs e)
    {
      if (cboAfCompt.Text == "")
      {
        cboAfCompt.Focus();
        return;
      }

      if (cboCentreRes.Text == "")
      {
        cboCentreRes.Focus();
        return;
      }

      DataRow row = GridB.GetFocusedDataRow();
      if (row == null) return;

      row["NIDAFFCOMPT"] = Convert.ToInt32(cboAfCompt.SelectedValue);
      row["NIDCENTRERES"] = Convert.ToInt32(cboCentreRes.SelectedValue);

      row["AFFCOMPT"] = cboAfCompt.Text;
      row["CENTRERES"] = cboCentreRes.Text;

      frmAna.Visible = false;
    }

    private void GridH_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle == GridH.dgv.FocusedRowHandle)
      {
        e.Appearance.BackColor = Color.LightSkyBlue;

        GridViewInfo info = GridH.dgv.GetViewInfo() as GridViewInfo;
        GridCellInfo cellInfo = info.GetGridCellInfo(e.RowHandle, GridH.dgv.Columns["VSITNOM"]);

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

    private void frmCliGIDTSaisie_FormClosed(object sender, FormClosedEventArgs e)
    {
      updateDB();
    }
  }
}
