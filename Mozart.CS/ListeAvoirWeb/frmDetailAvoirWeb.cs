using DevExpress.XtraEditors.Repository;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailAvoirWeb : Form
  {
    public long miNumElfAvoir;

    private string mstrStatut;

    private long miFac;
    private long miCli;

    DataTable dt = new DataTable();
    DataTable dtBas = new DataTable();

    public frmDetailAvoirWeb() { InitializeComponent(); }

    private void frmDetailAvoirWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // detail de la facture
        string sSQL = $"exec api_sp_detailFact {miNumElfAvoir}";

        using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
        {
          if (dr.Read())
          {
            txtNumFac.Text = dr["NFACNUM"].ToString();
            txtDateFac.Text = Convert.ToDateTime(Utils.DateBlankIfNull(dr["DFACDAT"])).ToShortDateString();
            txtTotalHT.Text = dr["THT"].ToString();
            txtNomClient.Text = dr["VCLINOM"].ToString();
            txtDesc.Text = dr["VACTDES"].ToString();
          }
        }

        //  ligne de la facture
        sSQL = $"exec api_sp_DetailElemFacture {miNumElfAvoir}";
        grdDataGrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        grdDataGrid.GridControl.DataSource = dt;

        // mise en page du datagrid
        FormatGrid();

        //  liste des messages
        sSQL = $"exec api_sp_www_GestionAvoirDetail {miNumElfAvoir}";
        apiTGrid1.LoadData(dtBas, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dtBas;

        InitApigrid();

        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        txtMessage.Text = "";
        miNumElfAvoir = (long)Utils.ZeroIfNull(currentRow["NELFNUM"]);
        miFac = (long)Utils.ZeroIfNull(currentRow["NFACNUM"]);
        miCli = (long)Utils.ZeroIfNull(currentRow["NCLINUM"]);
        mstrStatut = "C";

        Cursor.Current = Cursors.Default;
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

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TFACTURECLIENT,
        sIdentifiant = $"{row["NFACNUM"]}",
        InfosMail = $"TCLI|NCLINUM|{miCli}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleMain.CodePays(row["VCLIPAYS"].ToString()).Substring(0, 2),
        sOption = "PREVIEW"
      }.ShowDialog();
    }

    private void cmdAvoir_Click(object sender, EventArgs e)
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader("select distinct NFACNUM  from TFAC WHERE VSOCIETE = App_Name() AND NFACNUMFACAV = " + miFac))
        {
          if (dr.Read())
            MessageBox.Show(Resources.msg_Avoir_existe_deja_pour_facture + dr[0], Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        new frmAvoir
        {
          miNumFacture = miFac,
          miNumAvoir = 0,
          mstrStatutAvoir = "C",
          mstrStatutTransfert = ""
        }.ShowDialog();

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
        string sSQL;
        if (miNumElfAvoir == 0) return;

        if (txtMessage.Text == "")
        {
          MessageBox.Show(Resources.msg_Saisir_message, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (mstrStatut == "C")
        {
          sSQL = $"insert into TAVOIRWEB (NFACNUM,DAVDATE, NELFNUM,NCLINUM,VAVAUTEUR,VAVMESSAGE,VAVSTATUT,CAVSTATUT ) Values ({miFac}, GetDate() , " +
                 $"{miNumElfAvoir},{miCli},  dbo.GetUserName() , '{txtMessage.Text.Replace("'", "''")}' , 'Attente de réponse Nocibe' ,'N')";
          ModuleData.ExecuteNonQuery(sSQL);
        }
        else
        {
          //en  modification (uniquement le dernier message)
          sSQL = $"UPDATE TAVOIRWEB set VAVMESSAGE = '{txtMessage.Text.Replace("'", "''")}'  WHERE NAVNUM = {currentRow["NAVNUM"]}";
          try
          {
            ModuleData.ExecuteNonQuery(sSQL);
          }
          catch (Exception)
          {
            MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant);
          }
        }
        apiTGrid1.Requery(dtBas, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Facture, "NFACNUM", 900);
        apiTGrid1.AddColumn(Resources.col_Intervenant, "VAVAUTEUR", 1500);
        apiTGrid1.AddColumn(Resources.col_Date, "DAVDATE", 900, "Date");
        apiTGrid1.AddColumn(Resources.col_Message, "VAVMESSAGE", 6000, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_etat, "VAVSTATUT", 1600);
        apiTGrid1.AddColumn("E", "NAVNUM", 0);

        apiTGrid1.dgv.RowHeight = 80;

        RepositoryItemMemoEdit edit = new RepositoryItemMemoEdit();
        apiTGrid1.GridControl.RepositoryItems.Add(edit);
        apiTGrid1.dgv.Columns["VAVMESSAGE"].ColumnEdit = edit;
        apiTGrid1.dgv.Columns["VAVMESSAGE"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

        apiTGrid1.InitColumnList();
        apiTGrid1.btnExcel.Visible = apiTGrid1.btnPrint.Visible = apiTGrid1.chkColumnsList.Visible = false;
        apiTGrid1.FilterBar = apiTGrid1.FooterBar = false;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FormatGrid()
    {
      try
      {
        grdDataGrid.AddColumn(Resources.col_Site, "VSITNOM", 2300);
        grdDataGrid.AddColumn("N°", "NSITNUE", 700);
        grdDataGrid.AddColumn("DI", "NDINNUM", 800);
        grdDataGrid.AddColumn(Resources.col_ref_cli, "VDINREFCLI", 2000);
        grdDataGrid.AddColumn(Resources.col_exec, "DACTDEX", 1400);
        grdDataGrid.AddColumn(Resources.col_attach, "VACTATT", 1500);
        grdDataGrid.AddColumn("MO", "MO", 1300);
        grdDataGrid.AddColumn("FO", "NELFFOU", 1000);
        grdDataGrid.AddColumn(Resources.col_Deplt, "DEP", 1000);
        grdDataGrid.AddColumn(Resources.col_Total, "Total", 1400);
        grdDataGrid.AddColumn("VCLIPAYS", "VCLIPAYS", 0);

        grdDataGrid.InitColumnList();
        grdDataGrid.btnExcel.Visible = grdDataGrid.btnPrint.Visible = grdDataGrid.chkColumnsList.Visible = false;
        grdDataGrid.FilterBar = grdDataGrid.FooterBar = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}