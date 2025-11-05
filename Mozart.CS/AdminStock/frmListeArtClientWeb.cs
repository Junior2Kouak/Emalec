using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeArtClientWeb : Form
  {
    DataTable dt = new DataTable();

    public frmListeArtClientWeb() { InitializeComponent(); }

    private void frmListeArtClientWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSql = $"select distinct TCLI.NCLINUM , VCLINOM from TCLI, TARTCLIWEB WHERE TCLI.NCLINUM = TARTCLIWEB.NCLINUM AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY  VCLINOM";
        cboTech.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, bHideFirstColumn: true);
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT * FROM TFOU, TARTCLIWEB WHERE TFOU.NFOUNUM = TARTCLIWEB.NFOUNUM AND TARTCLIWEB.NCLINUM = {cboTech.GetItemData()}");
        apiTGrid.GridControl.DataSource = dt;

        InitApiTgrid();
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

    private void cmdCommandes_Click(object sender, EventArgs e)
    {
      new frmModifListeArtClientWeb
      {
        miNumClient = (int)Utils.ZeroIfNull(cboTech.GetItemData()),
      }.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cboTech_TxtChanged(object sender, EventArgs e)
    {
      apiTGrid.sSqlDataSource = $"SELECT * FROM TFOU, TARTCLIWEB WHERE TFOU.NFOUNUM = TARTCLIWEB.NFOUNUM AND TARTCLIWEB.NCLINUM = {cboTech.GetItemData()} order by vfoumat";
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApiTgrid()
    {
      apiTGrid.AddColumn(Resources.col_FouNum, "NFOUNUM", 0);
      apiTGrid.AddColumn(Resources.col_Article, "VFOUMAT", 6000, "", 0);
      apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 2000, "", 0);
      apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 2000, "", 0);
      apiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 2000, "", 0);
      apiTGrid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 700, "", 2);

      apiTGrid.InitColumnList();
    }
  }
}

