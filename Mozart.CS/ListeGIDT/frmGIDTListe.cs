using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmGIDTListe : Form
  {
    private int mlNumClient;
    private string mstrNomClient;
    private bool mbIsCli;

    private DataTable dtObj = new DataTable();

    private TooltipGridTPE _tpe;

    private string mstrRepImage;

    public frmGIDTListe(int plNumClient, string pstrNomClient, bool pIsCli)
    {
      InitializeComponent();

      mlNumClient = plNumClient;
      mstrNomClient = pstrNomClient;
      mbIsCli = pIsCli;
    }

    private void frmGIDTListe_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      this.Text += mstrNomClient;

      Cursor.Current = Cursors.WaitCursor;

      string sSql;

      mstrRepImage = ModuleData.RechercheParam("REP_MEDIA", MozartParams.NomSociete);

      if (mbIsCli)
      {
        sSql = "SELECT * FROM api_v_GIDTCLI_ListeObjet WHERE NCLINUM = " + mlNumClient + " ORDER BY VSITNOM, VNIV1, VNIV2";

        mstrRepImage += @"GIDTCLI\";
      }
      else
      {
        sSql = "SELECT * FROM api_v_GIDT_ListeObjet WHERE NCLINUM = " + mlNumClient + " ORDER BY VSITNOM, VNIV1, VNIV2, VNIV3";
      }
      Grid.LoadData(dtObj, MozartDatabase.cnxMozart, sSql);
      InitGrid();

      _tpe = new TooltipGridTPE(Grid, toolTipController1);

      Cursor.Current = Cursors.Default;
    }

    private void InitGrid()
    {
      if (mbIsCli)
      {
        Grid.AddColumn("NOBJNUM", "NOBJNUM", 0);
        Grid.AddColumn("NCLINUM", "NCLINUM", 0);
        Grid.AddColumn(Resources.col_Site, "VSITNOM", 1800);
        Grid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1800);
        Grid.AddColumn("Niveau 1", "VNIV1", 1800, "", 0, false, false, true);
        Grid.AddColumn("Niveau 2", "VNIV2", 1800, "", 0, false, false, true);
        Grid.AddColumn("N° Equipement", "VOBJNUMEQUIP", 2000);
        Grid.AddColumn(Resources.col_Objet, "VOBJLIB", 1900);
        Grid.AddColumn(Resources.col_marque, "VOBJMAR", 1700);
        Grid.AddColumn(Resources.col_Type, "VOBJTYPE", 1300);
        Grid.AddColumn(Resources.col_reference, "VOBJREF", 1300);
        Grid.AddColumn("N° Série", "VOBJNUMSERIE", 1000);
        Grid.AddColumn(Resources.col_Qte, "NOBJQTE", 800, "", 2);
        Grid.AddColumn("D Crea/Modif", "DDATECREAMODIF", 900, "dd/MM/yy");
        Grid.AddColumn("Compl", "VOBJCOMP", 2000, "", 0, true);
        Grid.AddColumn("Repère plan", "VOBJREPPLAN", 1000);
        Grid.AddColumn("Nb inter/an", "NOBJNBINTER", 1000);
        Grid.AddColumn(Resources.col_duree, "NOBJDUREEINTER", 1000);
        Grid.AddColumn(Resources.col_duree, "NOBJMONTANTINTER", 1000);
        Grid.AddColumn("Stt", "VSTFNOM", 1000);
        Grid.AddColumn("Imposé", "VOBJSTFIMPOSE", 1000);
        Grid.AddColumn("Cotraitant", "VOBJSTFCOTRAITANT", 1000);
        Grid.AddColumn("Affect comptable", "AFFCOMPT", 1000);
        Grid.AddColumn("Centre résultat", "CENTRERES", 1000);

        Grid.dgv.OptionsView.AllowCellMerge = true;

        Grid.dgv.Columns["VOBJNUMEQUIP"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJLIB"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJMAR"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJTYPE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJREF"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJNUMSERIE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["NOBJQTE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["DDATECREAMODIF"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJCOMP"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJREPPLAN"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["NOBJNBINTER"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["NOBJDUREEINTER"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["NOBJMONTANTINTER"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VSTFNOM"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJSTFIMPOSE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJSTFCOTRAITANT"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["AFFCOMPT"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["CENTRERES"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      }
      else
      {
        Grid.AddColumn("NOBJNUM", "NOBJNUM", 0);
        Grid.AddColumn("NCLINUM", "NCLINUM", 0);
        Grid.AddColumn(Resources.col_Site, "VSITNOM", 1800);
        Grid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1800);
        Grid.AddColumn("Niveau 1", "VNIV1", 1800, "", 0, false, false, true);
        Grid.AddColumn("Niveau 2", "VNIV2", 1800, "", 0, false, false, true);
        Grid.AddColumn("Niveau 3", "VNIV3", 1800);
        Grid.AddColumn("Numéro", "VOBJNUMERO", 2000);
        Grid.AddColumn(Resources.col_Objet, "VOBJLIB", 1900);
        Grid.AddColumn(Resources.col_marque, "VOBJMAR", 1700);
        Grid.AddColumn(Resources.col_Type, "VOBJTYPE", 1300);
        Grid.AddColumn(Resources.col_reference, "VOBJREF", 1300);
        Grid.AddColumn(Resources.col_Qte, "NOBJQTE", 800, "", 2);
        Grid.AddColumn("D Crea/Modif", "DDATECREAMODIF", 900, "dd/MM/yy");
        Grid.AddColumn("Compl", "VOBJCOMP", 2000, "", 0, true);

        Grid.dgv.OptionsView.AllowCellMerge = true;


        Grid.dgv.Columns["VTYPECONTRAT"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VNIV1"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VNIV2"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VNIV3"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJNUMERO"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJLIB"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJMAR"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJTYPE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJREF"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["NOBJQTE"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["DDATECREAMODIF"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        Grid.dgv.Columns["VOBJCOMP"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
      }

      Grid.InitColumnList();
      Grid.GridControl.DataSource = dtObj;
    }

    // Evènements communs pour les picture box
    private void pictureBox_DoubleClick(object sender, EventArgs e)
    {
      frmxVisuImg lFrmxVisuImg = new frmxVisuImg
      {
        msImage = ((PictureBox)sender).Tag.ToString()
      };
      lFrmxVisuImg.ShowDialog();
    }

    private void chargementImage(string sFichier, PictureBox pPicture)
    {
      if (Path.GetExtension(sFichier).Substring(1).ToUpper() == "PDF")
      {
        pPicture.Image = Resources.iconePDF;
      }
      else
      {
        pPicture.Load(sFichier);

      }
      pPicture.Tag = sFichier;
      pPicture.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void Grid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;

      string sSql;
      int lObj = Convert.ToInt32(row["NOBJNUM"]);

      // Supprime toutes les images contenues dans le panel
      for (int i = flowLayoutPanel1.Controls.Count; i > 0; i--)
      {
        flowLayoutPanel1.Controls.RemoveAt(0);
      }

      if (mbIsCli)
      {
        sSql = $"SELECT * from TFICOBJCLI where NOBJET = {lObj}";
      }
      else
      {
        sSql = $"SELECT * from TFICOBJ where NOBJET = {lObj}";
      }

      using (SqlDataReader reader = ModuleData.ExecuteReader(sSql))
      {
        while (reader.Read())
        {
          PictureBox lCur = new PictureBox
          {
            Size = new Size(flowLayoutPanel1.Height, flowLayoutPanel1.Height - 6),
            BackColor = Color.Black
          };
          chargementImage(mstrRepImage + reader["VFICHIER"], lCur);
          lCur.MouseDoubleClick += pictureBox_DoubleClick;
          flowLayoutPanel1.Controls.Add(lCur);
        }
      }

      Cursor.Current = Cursors.Default;
    }

    private void Grid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle == this.Grid.dgv.FocusedRowHandle)
      {
        e.Appearance.BackColor = Color.LightSkyBlue;
        
        GridViewInfo info = this.Grid.dgv.GetViewInfo() as GridViewInfo;
        GridCellInfo cellInfo = info.GetGridCellInfo(e.RowHandle, this.Grid.dgv.Columns["VSITNOM"]);

        if (cellInfo == null) return;

        if (cellInfo.IsMerged)
        {
          for (int i = 0; i < cellInfo.MergedCell.MergedCells.Count; i++)
          {
            if (cellInfo.MergedCell.MergedCells[i].RowHandle == this.Grid.dgv.FocusedRowHandle)
            {
              e.Appearance.BackColor = Color.LightSkyBlue;
            }
          }
        }
      }
      else
        e.Appearance.BackColor = Color.Azure;
    }
  }
}
