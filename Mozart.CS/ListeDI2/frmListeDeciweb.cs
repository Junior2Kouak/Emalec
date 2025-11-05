using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDeciWeb : Form
  {
    DataTable dt = new DataTable();
    //Dim adoRS As ADODB.Recordset

    public frmListeDeciWeb() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeDeciWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_listeDeci_web where CWDECACTIF = 'O' order by DWDECDAT desc");
        apiTGrid1.GridControl.DataSource = dt;

        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      //écran de modification de l'action
      MozartParams.NumAction = (int)row["NACTNUM"];
      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumDeciWeb = (int)row["NWDECNUM"];

      Cursor.Current = Cursors.WaitCursor;

      new frmAddAction()
      {
        mstrStatutDI = "DécisionWeb",
      }.ShowDialog();


      MozartParams.NumDeciWeb = 0;

      //rafraichissement
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      string Mail = ModuleData.ExecuteScalarString($"select VCCLMAIL from TCCL where NCLINUM= {row["NCLINUM"]} and VCCLNOM=' {row["VUTILOG"]}'");

      if (Mail == null)
      {
        MessageBox.Show(Resources.msg_pas_de_mail_valide_contact, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      var process = Process.Start(Uri.EscapeUriString($"mailto: {Mail}"));
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("N°", "NWDECNUM", 400);
      apiTGrid1.AddColumn(Resources.col_DateArrivee, "DWDECDAT", 800, "Date");
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 700);
      apiTGrid1.AddColumn(Resources.col_Demandeur, "VUTILOG", 700);
      apiTGrid1.AddColumn(Resources.col_Chaff, "VDINCHAFF", 700);
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 500);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1000);
      apiTGrid1.AddColumn("N°", "NSITNUE", 300);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 2000);
      apiTGrid1.AddColumn(Resources.col_Intervenant, "INTER", 300);
      apiTGrid1.AddColumn(Resources.col_DecisionClient, "VWDECLIB", 1400);
      apiTGrid1.AddColumn(Resources.col_Rmq, "VWDECCOMM", 4000);
      apiTGrid1.AddColumn(Resources.col_Actif, "CWDECACTIF", 0);
      apiTGrid1.AddColumn("NACTNUM", "NACTNUM", 0);
      apiTGrid1.AddColumn(Resources.col_Qui, "QUI", 0);

      apiTGrid1.InitColumnList();
    }

    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      //' Gestion spécifique des couleurs
      if (e.RowHandle >= 0 && e.Column.Name == "NDINNUM" && ((sender as GridView).GetDataRow(e.RowHandle)["NDINNUM"].ToString() == "1"))
      {
        e.Appearance.BackColor = MozartColors.ColorHC0FFC0;
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

