using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmGIDTArbo : Form
  {
    const string TYPECLIENT_OBJ = "OBJ";
    const string TYPECLIENT_STD = "STD";

    int mlNumClient;
    string mstrNomClient;
    string mstrTypeClient;

    private DataTable dt = new DataTable();

    public frmGIDTArbo(int plNumClient, string pstrNomClient, string pstrTypeClient)
    {
      InitializeComponent();

      mlNumClient = plNumClient;
      mstrNomClient = pstrNomClient;
      mstrTypeClient = pstrTypeClient;
    }

    private void frmGIDTArbo_Load(object sender, EventArgs e)
    {
      string sSql;

      ModuleMain.Initboutons(this);

      lblClient.Text += mstrNomClient;

      sSql = "SELECT TCONTRATCLI.NTYPECONTRAT, VTYPECONTRAT FROM TCONTRATCLI INNER JOIN ";
      sSql += "TREF_TYPECONTRAT ON TCONTRATCLI.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT ";
      sSql += $"WHERE LANGUE = '{MozartParams.Langue}' AND NCLINUM = {mlNumClient} ORDER BY VTYPECONTRAT";
      cboContrat.Init(MozartDatabase.cnxMozart, sSql, "NTYPECONTRAT", "VTYPECONTRAT", new List<string>() { Resources.col_Num, Resources.col_Contrat }, 500, 500, true);

      switch (mstrTypeClient)
      {
        case TYPECLIENT_OBJ:
          sSql = $"SELECT NARBONUM, NCLINUM, TGIDTARBOCLI.NTYPECONTRAT, (SELECT VTYPECONTRAT FROM TREF_TYPECONTRAT WHERE NTYPECONTRAT = TGIDTARBOCLI.NTYPECONTRAT AND LANGUE = '{MozartParams.Langue}') AS VTYPECONTRAT";
          sSql += $", VNIV1, VNIV2 FROM TGIDTARBOCLI WHERE NCLINUM = {mlNumClient} ORDER BY VTYPECONTRAT, VNIV1, VNIV2";
          lblNiv3.Visible = false;
          txtNiv3.Visible = false;
          break;

        case TYPECLIENT_STD:
          sSql = $"SELECT NARBONUM, NCLINUM, TGIDTARBO.NTYPECONTRAT, (SELECT VTYPECONTRAT FROM TREF_TYPECONTRAT WHERE NTYPECONTRAT = TGIDTARBO.NTYPECONTRAT AND LANGUE = '{MozartParams.Langue}') AS VTYPECONTRAT";
          sSql += $", VNIV1, VNIV2, VNIV3 FROM TGIDTARBO WHERE NCLINUM = {mlNumClient} ORDER BY VTYPECONTRAT, VNIV1, VNIV2";
          break;

        default:
          break;
      }

      Grid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      InitGrid();

      Grid_ClickE(null, null);
    }

    private void InitGrid()
    {
      Grid.AddColumn("NARBONUM", "NARBONUM", 0);
      Grid.AddColumn("NCLINUM", "NCLINUM", 0);
      Grid.AddColumn("NTYPECONTRAT", "NTYPECONTRAT", 0);
      Grid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 4600);
      Grid.AddColumn("Niveau 1", "VNIV1", 4600);
      Grid.AddColumn("Niveau 2", "VNIV2", 4600);
      if (mstrTypeClient == TYPECLIENT_STD)
      {
        Grid.AddColumn("Niveau 3", "VNIV3", 4600);
      }
      Grid.DelockColumn("NCLINUM");

//      Grid.dgv.OptionsView.AllowCellMerge = true;
//      Grid.dgv.Columns["VNIV2"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

      Grid.InitColumnList();
      Grid.GridControl.DataSource = dt;
    }

    private void cmdDel_Click(object sender, EventArgs e)
    {
      string lstrNomTableObj;
      string lstrNomTableArbo;

      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      if (mstrTypeClient == TYPECLIENT_OBJ)
      {
        lstrNomTableObj = "TGIDTOBJCLI";
        lstrNomTableArbo = "TGIDTARBOCLI";
      } else
      {
        lstrNomTableObj = "TGIDTOBJ";
        lstrNomTableArbo = "TGIDTARBO";
      }

      using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT count(*) from {lstrNomTableObj} WHERE NARBONUM = {row["NARBONUM"]}"))
      {
        reader.Read();
        if (Convert.ToInt32(reader[0]) > 0)
        {
          MessageBox.Show("Suppression impossible. Des objets liés existent pour ce client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          if (MessageBox.Show("Voulez vous vraiment supprimer cette ligne ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            ModuleData.ExecuteNonQuery($"DELETE {lstrNomTableArbo} WHERE NARBONUM = {row["NARBONUM"]}");

            Grid.Requery(dt, MozartDatabase.cnxMozart);
          }
        }
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      string sSql;

      if (cboContrat.GetItemData() == 0)
      {
        MessageBox.Show("Vous devez saisir un contrat", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (txtNiv1.Text == "")
      {
        MessageBox.Show("Vous devez saisir un niveau 1", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      switch (mstrTypeClient)
      {
        case TYPECLIENT_OBJ:
          sSql = $"exec api_sp_creationGIDTArboCli {cmdValider.Tag}, {cboContrat.GetItemData()}, '{txtNiv1.Text.Replace("'", "''")}',";
          sSql += (Utils.BlankIfNull(txtNiv2.Text) == "") ? "null" : "'" + txtNiv2.Text.Replace("'", "''") + "'";
          sSql += $",{mlNumClient}";
          break;

        case TYPECLIENT_STD:
          sSql = $"exec api_sp_creationGIDTArbo {cmdValider.Tag}, {cboContrat.GetItemData()}, '{txtNiv1.Text.Replace("'", "''")}',";
          sSql += (Utils.BlankIfNull(txtNiv2.Text) == "") ? "null" : "'" + txtNiv2.Text.Replace("'", "''") + "'";
          sSql += "," + ((Utils.BlankIfNull(txtNiv3.Text) == "") ? "null" : "'" + txtNiv3.Text.Replace("'", "''") + "'");
          sSql += $",{mlNumClient}";
          break;

        default:
          sSql = "";
          break;
      }

      cmdValider.Tag = ModuleData.ExecuteScalarInt(sSql);

      //rsArb.Requery
      //rsArb.Find "NARBONUM = " & cmdValider.Tag
      Grid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      cmdValider.Tag = 0;
      cboContrat.SetItemData(0);
      txtNiv1.Text = "";
      txtNiv2.Text = "";
      txtNiv3.Text = "";
      frmArbo.Text = " Création ";
    }

    private void Grid_ClickE(object sender, EventArgs e)
    {
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null)
      {
        cmdAdd_Click(sender, e);
      }
      else
      {
        cboContrat.SetItemData(Convert.ToInt32(row["NTYPECONTRAT"]));
        txtNiv1.Text = Utils.BlankIfNull(row["VNIV1"]);
        txtNiv2.Text = Utils.BlankIfNull(row["VNIV2"]);
        if (mstrTypeClient== TYPECLIENT_STD)
        {
          txtNiv3.Text = Utils.BlankIfNull(row["VNIV3"]);
        }
        cmdValider.Tag = Convert.ToInt32(row["NARBONUM"]);
        frmArbo.Text = " Modification (en cours) ";
      }
    }

    private void Grid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle == this.Grid.dgv.FocusedRowHandle)
      {
        e.Appearance.BackColor = Color.LightSkyBlue;

        GridViewInfo info = this.Grid.dgv.GetViewInfo() as GridViewInfo;
        GridCellInfo cellInfo = info.GetGridCellInfo(e.RowHandle, this.Grid.dgv.Columns["VTYPECONTRAT"]);

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
