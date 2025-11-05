using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestGrpManage : Form
  {
    private const string LBL_GRP = "Gestion des membres du groupe";

    private const string LIB_MONTANT = "Validation CF/CS";
    private const string LIB_MONTANT_DEVIS = "Validation devis";

    bool bpremGlo = false;
    bool bpremSer = false;
    bool bpremDir = false;

    DataTable dt1 = new DataTable();
    DataTable dt2 = new DataTable();
    DataTable dt3 = new DataTable();
    DataTable dt4 = new DataTable();
    DataTable dt5 = new DataTable();
    DataTable dt6 = new DataTable();

    public frmGestGrpManage() { InitializeComponent(); }

    private void frmGestGrpManage_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cboMaitre.Init(MozartDatabase.cnxMozart, $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS NOMPRE from TPER where VSOCIETE = '{MozartParams.NomSociete}'  AND CPERTYP <> 'TE' AND CPERACTIF='O' AND (DPERSOR IS NULL OR DPERSOR > GETDATE()) ORDER BY  VPERNOM + ' ' + VPERPRE", "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
        cboServ.Init(MozartDatabase.cnxMozart, $"select IDSERVICE, LIBSERVICE from TREF_SERVICE where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY LIBSERVICE", "IDSERVICE", "LIBSERVICE", new List<string>() { Resources.col_ID, Resources.col_Service }, 150, 550, true);
        cboUtil.Init(MozartDatabase.cnxMozart, $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS NOMPRE from TPER where VSOCIETE = '{MozartParams.NomSociete}'  AND (CPERTYP <> 'TE' OR CPERTYPDETAIL='RE') AND CPERACTIF='O' AND (DPERSOR IS NULL OR DPERSOR > GETDATE()) ORDER BY  VPERNOM + ' ' + VPERPRE", "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
        cboGroupe.Init(MozartDatabase.cnxMozart, $"select IDGROUPE, LIBGROUPE from TREF_GROUPE where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY LIBGROUPE", "IDGROUPE", "LIBGROUPE", new List<string>() { Resources.col_ID, Resources.col_groupe }, 150, 550, true);
        cboChefService.Init(MozartDatabase.cnxMozart, $"select NPERNUM, VPERNOM + ' ' + VPERPRE AS NOMPRE from TPER where VSOCIETE = '{MozartParams.NomSociete}'  AND CPERTYP <> 'TE' AND CPERTYP <> 'AS' AND CPERTYP <> 'BE' AND CPERACTIF='O' AND (DPERSOR IS NULL OR DPERSOR > GETDATE()) ORDER BY  VPERNOM + ' ' + VPERPRE", "NPERNUM", "NOMPRE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        txtGrp.BringToFront();

        string sql = $"SELECT G.IDGROUPE, LIBGROUPE, G.NPERNUM, VPERNOM, S.IDSERVICE, LIBSERVICE FROM TREF_GROUPE G INNER JOIN " +
          $" TPER ON G.NPERNUM=TPER.NPERNUM  INNER JOIN TREF_SERVICE S ON S.IDSERVICE=G.IDSERVICE WHERE G.VSOCIETE = '{MozartParams.NomSociete}'"; // AND (DPERSOR IS NULL OR DPERSOR > GETDATE())";
        apiTGrid1.LoadData(dt1, MozartDatabase.cnxMozart, sql);
        apiTGrid1.GridControl.DataSource = dt1;

        //grille des membre sans groupe
        sql = $"SELECT VPERNOM + '  ' + VPERPRE 'VPERNOM', MTVALIDATION, MTVALIDATIONDEVIS, TPER.NPERNUM, VTYPEDETAILLIB " +
          $"FROM TPER INNER JOIN TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL " +
          $"WHERE IDGROUPE is null AND (TPER.CPERTYP <> 'TE' OR TPER.CPERTYPDETAIL='RE') AND CPERACTIF='O' AND VSOCIETE = '{MozartParams.NomSociete}' AND (DPERSOR IS NULL OR DPERSOR > GETDATE()) ORDER BY VPERNOM";
        apiTGrid3.LoadData(dt3, MozartDatabase.cnxMozart, sql);
        apiTGrid3.GridControl.DataSource = dt3;


        InitGrid3();

        Initgrid2();
        InitGrid();
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

    private void InitGrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Num, "IDGROUPE", 500);
        apiTGrid1.AddColumn(Resources.col_libGrp, "LIBGROUPE", 2800);
        apiTGrid1.AddColumn(Resources.col_ChefGroupe, "VPERNOM", 2500);

        if (MozartParams.NomGroupe == "EMALEC")
          apiTGrid1.AddColumn(Resources.col_Service, "LIBSERVICE", 2500, "", 0, true);
        else
          apiTGrid1.AddColumn(Resources.col_Service, "LIBSERVICE", 2500);

        apiTGrid1.CacherBoutonsPrintExcel();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Initgrid2()
    {
      try
      {
        apiTGrid2.AddColumn(Resources.col_libGrp, "LIBGROUPE", 0);
        apiTGrid2.AddColumn(Resources.col_utilisateur, "VPERNOM", 2800);
        apiTGrid2.AddColumn(Resources.col_Type, "VTYPEDETAILLIB", 1800);
        apiTGrid2.AddColumn(LIB_MONTANT, "MTVALIDATION", 1400, "", 2);
        apiTGrid2.AddColumn(LIB_MONTANT_DEVIS, "MTVALIDATIONDEVIS", 1400, "", 2);

        apiTGrid2.DelockColumn("MTVALIDATION");
        apiTGrid2.DelockColumn("MTVALIDATIONDEVIS");

        apiTGrid2.CacherBoutonsPrintExcel();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitGrid3()
    {
      try
      {
        apiTGrid3.AddColumn(Resources.col_utilisateur, "VPERNOM", 2800);
        apiTGrid3.AddColumn(Resources.col_Type, "VTYPEDETAILLIB", 1800);
        apiTGrid3.AddColumn(LIB_MONTANT, "MTVALIDATION", 1400, "", 2);
        apiTGrid3.AddColumn(LIB_MONTANT_DEVIS, "MTVALIDATIONDEVIS", 1400, "", 2);

        apiTGrid3.DelockColumn("MTVALIDATION");
        apiTGrid3.DelockColumn("MTVALIDATIONDEVIS");

        apiTGrid3.CacherBoutonsPrintExcel();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitGrid4()
    {
      try
      {
        apiTGrid4.AddColumn(Resources.col_Service, "LIBSERVICE", 2500);
        apiTGrid4.AddColumn(Resources.col_responsable, "VPERNOM", 2500);

        apiTGrid4.CacherBoutonsPrintExcel();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitGrid6()
    {
      try
      {
        apiTGrid6.AddColumn(Resources.col_utilisateur, "VPERNOM", 2800);
        apiTGrid6.AddColumn(LIB_MONTANT, "MTVALIDATION", 1400, "", 2);
        apiTGrid6.AddColumn(LIB_MONTANT_DEVIS, "MTVALIDATIONDEVIS", 1400, "", 2);
        apiTGrid6.AddColumn(Resources.col_groupe, "LIBGROUPE", 3000);
        apiTGrid6.AddColumn(Resources.col_Service, "LIBSERVICE", 3000);

        apiTGrid6.CacherBoutonsPrintExcel();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      //on sort si il n'y a pas d'enregistrement
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (dt1.Rows.Count == 0 || currentRow == null) return;

      txtGroupe.Text = Utils.BlankIfNull(currentRow["LIBGROUPE"]);
      Label10.Text = $"{LBL_GRP} : {txtGroupe.Text}";

      cboServ.SetItemData(Convert.ToInt32(currentRow["IDSERVICE"]));
      cboMaitre.SetItemData(Convert.ToInt32(currentRow["npernum"]));

      //grille des membres du groupe
      string sStr = $"SELECT '{ currentRow["LIBGROUPE"] }' 'LIBGROUPE', VPERNOM + '  ' + VPERPRE 'VPERNOM', MTVALIDATION, MTVALIDATIONDEVIS, TPER.NPERNUM, VTYPEDETAILLIB  " +
      $"FROM TPER INNER JOIN TREF_TYPEPERDETAIL ON TREF_TYPEPERDETAIL.CPERTYPDETAIL = TPER.CPERTYPDETAIL " +
      $"WHERE IDGROUPE = {currentRow["IDGROUPE"]} AND CPERACTIF='O' AND VSOCIETE = '{MozartParams.NomSociete}' AND (DPERSOR IS NULL OR DPERSOR > GETDATE()) ORDER BY VPERNOM";

      apiTGrid2.GridControl.DataSource = null;
      dt2.Dispose();
      dt2 = new DataTable();
      apiTGrid2.LoadData(dt2, MozartDatabase.cnxMozart, sStr);
      apiTGrid2.GridControl.DataSource = dt2;

      txtGrp.Text = Utils.BlankIfNull(currentRow["LIBGROUPE"]);
    }

    private void apiTGrid2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGrid2.GetFocusedDataRow();
      if (currentRow == null || dt2.Rows.Count == 0) return;

      txtGrp.Text = Utils.BlankIfNull(currentRow["LIBGROUPE"]);
      txtMontant.Text = Utils.BlankIfNull(currentRow["MTVALIDATION"]);
      txtMontantDevis.Text = Utils.BlankIfNull(currentRow["MTVALIDATIONDEVIS"]);

      cboUtil.SetItemData(Convert.ToInt32(currentRow["npernum"]));
    }

    private void apiTGrid2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      string lColName;

      string lVal = e.Value.ToString();

      if (lVal == "")
      {
        apiTGrid2.dgv.SetFocusedValue("0");
        return;
      }

      lColName = e.Column.FieldName;
      switch (lColName)
      {
        case "MTVALIDATION":
          txtMontant.Text = lVal;
          break;

        case "MTVALIDATIONDEVIS":
          txtMontantDevis.Text = lVal;
          break;

        default:
          // Retour si aucune de ces 2 colonnes
          return;
      }

      ModuleData.CnxExecute($"update tper set {lColName} = {lVal} where npernum = {cboUtil.GetItemData()}");
    }

    private void apiTGrid3_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGrid3.GetFocusedDataRow();
      if (currentRow == null || dt3.Rows.Count == 0) return;

      txtUtilisateur.Text = Utils.BlankIfNull(currentRow["VPERNOM"]);
      txtMont.Text = Utils.BlankIfNull(currentRow["MTVALIDATION"]);
      txtMontDevis.Text = Utils.BlankIfNull(currentRow["MTVALIDATIONDEVIS"]);
    }

    private void apiTGrid3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      string lColName;

      DataRow currentRow = apiTGrid3.GetFocusedDataRow();

      string lVal = e.Value.ToString();

      if (lVal == "")
      {
        apiTGrid3.dgv.SetFocusedValue("0");
        return;
      }

      lColName = e.Column.FieldName;
      switch (lColName)
      {
        case "MTVALIDATION":
          txtMont.Text = lVal;
          break;

        case "MTVALIDATIONDEVIS":
          txtMontDevis.Text = lVal;
          break;

        default:
          // Retour si aucune de ces 2 colonnes
          return;
      }

      ModuleData.ExecuteNonQuery($"UPDATE tper SET {lColName} = {lVal} WHERE npernum = {currentRow["npernum"]}");
    }

    private void apiTGrid4_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGrid4.GetFocusedDataRow();
      if (currentRow == null || dt4.Rows.Count == 0) return;

      txtService.Text = Utils.BlankIfNull(currentRow["LIBSERVICE"]);
      cboChefService.SetItemData(Convert.ToInt32(currentRow["npernum"]));
    }

    private void apiTGrid1_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null || dt1.Rows.Count == 0) return;

        txtGroupe.Text = Utils.BlankIfNull(currentRow["LIBGROUPE"]);

        cboServ.SetItemData(Convert.ToInt32(currentRow["IDSERVICE"]));
        cboMaitre.SetItemData(Convert.ToInt32(currentRow["npernum"]));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        string sLibelleGrp = Interaction.InputBox("Saisir le libellé du groupe :", "Nouveau groupe");

        if (sLibelleGrp != "")
        {
          ModuleData.CnxExecute($"INSERT INTO TREF_GROUPE (LIBGROUPE, NPERNUM, IDSERVICE, VSOCIETE) VALUES ('{sLibelleGrp}',1,1, '{MozartParams.NomSociete}')");
          apiTGrid1.Requery(dt1, MozartDatabase.cnxMozart);
          cboGroupe.Init(MozartDatabase.cnxMozart, $"select IDGROUPE, LIBGROUPE from TREF_GROUPE where VSOCIETE = '{MozartParams.NomSociete}' ORDER BY LIBGROUPE", "IDGROUPE", "LIBGROUPE", new List<string>() { Resources.col_ID, Resources.col_groupe }, 150, 550, true);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null || dt1.Rows.Count == 0) return;

      string sSQL = $"UPDATE TREF_GROUPE SET LIBGROUPE = '{txtGroupe.Text}', NPERNUM = {cboMaitre.GetItemData()}" +
        $",  IDSERVICE = {cboServ.GetItemData()} WHERE IDGROUPE = {currentRow["IDGROUPE"]}";
      ModuleData.CnxExecute(sSQL);

      apiTGrid1.Requery(dt1, MozartDatabase.cnxMozart);
    }

    private void cmdValidService_Click(object sender, EventArgs e)
    {
      DataRow current = apiTGrid4.GetFocusedDataRow();
      if (current == null || dt4.Rows.Count == 0) return;

      string sSQL = $"UPDATE TREF_SERVICE SET LIBSERVICE = '{txtService.Text}', NPERNUM = {cboChefService.GetItemData()}  Where IDSERVICE = {current["IDSERVICE"]}";
      ModuleData.ExecuteNonQuery(sSQL);

      apiTGrid4.Requery(dt4, MozartDatabase.cnxMozart);
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      if (txtMontant.Text == "") return;
      if (txtMontantDevis.Text == "") return;

      ModuleData.CnxExecute($"update tper set idgroupe = {currentRow["IDGROUPE"]},MTVALIDATION= {txtMontant.Text},MTVALIDATIONDEVIS= {txtMontantDevis.Text} where npernum = {cboUtil.GetItemData()}");
      apiTGrid2.Requery(dt2, MozartDatabase.cnxMozart);
      apiTGrid3.Requery(dt3, MozartDatabase.cnxMozart);
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      ModuleData.CnxExecute($"update tper set idgroupe = Null, MTVALIDATION=NULL, MTVALIDATIONDEVIS=NULL where npernum = {cboUtil.GetItemData()}");
      apiTGrid2.Requery(dt2, MozartDatabase.cnxMozart);
      apiTGrid3.Requery(dt3, MozartDatabase.cnxMozart);
    }

    private void cmdEnreg_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid3.GetFocusedDataRow();
      if (currentRow == null || dt3.Rows.Count == 0) return;

      if (cboGroupe.GetText() == "") return;
      if (txtMont.Text == "") return;
      if (txtMontDevis.Text == "") return;

      ModuleData.CnxExecute($"update tper set idgroupe = '{cboGroupe.GetItemData()}', MTVALIDATION= {txtMont.Text}, MTVALIDATIONDEVIS= {txtMontDevis.Text} where npernum = {currentRow["npernum"]}");
      apiTGrid2.Requery(dt2, MozartDatabase.cnxMozart);
      apiTGrid3.Requery(dt3, MozartDatabase.cnxMozart);
      cboGroupe.SetText("");
      txtMont.Text = "";
    }

    private void cmdSer_Click(object sender, EventArgs e)
    {
      if (!bpremSer)
      {
        string sSQL = $"SELECT S.NPERNUM, VPERNOM + '  ' + VPERPRE 'VPERNOM', LIBSERVICE, IDSERVICE FROM TPER INNER JOIN TREF_SERVICE S ON S.NPERNUM=TPER.NPERNUM WHERE S.VSOCIETE = '{MozartParams.NomSociete}'";
        apiTGrid4.LoadData(dt4, MozartDatabase.cnxMozart, sSQL);
        apiTGrid4.GridControl.DataSource = dt4;

        InitGrid4();
      }

      bpremSer = true;

      framService.Top = 200;
      framService.Left = (this.Width - framService.Width) / 2;
      framService.Visible = true;
      framService.BringToFront();
    }

    private void cmdDir_Click(object sender, EventArgs e)
    {
      if (!bpremDir)
      {
        string sSQL = "SELECT S.NPERNUM, VPERNOM, VSOCIETE, 'Direction' LIBSERVICE FROM TPER INNER JOIN TDIRECTION S ON S.NPERNUM=TPER.NPERNUM";
        apiTGrid5.LoadData(dt5, MozartDatabase.cnxMozart, sSQL);
        apiTGrid5.GridControl.DataSource = dt5;

        apiTGrid5.FilterBar = false;

        apiTGrid5.AddColumn(Resources.col_Service, "LIBSERVICE", 2200);
        apiTGrid5.AddColumn(Resources.col_responsable, "VPERNOM", 2200);
        apiTGrid5.AddColumn(Resources.col_Societe, "VSOCIETE", 2000);

        apiTGrid5.CacherBoutonsPrintExcel();
      }

      bpremDir = true;

      framDir.Top = 200;
      framDir.Left = (this.Width - framDir.Width) / 2;
      framDir.Visible = true;
      framDir.BringToFront();
    }

    private void cmdGlo_Click(object sender, EventArgs e)
    {
      if (!bpremGlo)
      {
        string sSQL = $"SELECT VPERNOM + '  ' + VPERPRE 'VPERNOM', MTVALIDATION, MTVALIDATIONDEVIS, LIBGROUPE, LIBSERVICE FROM TREF_GROUPE G " +
        $" INNER JOIN TREF_SERVICE S ON S.IDSERVICE=G.IDSERVICE RIGHT OUTER JOIN TPER ON G.IDGROUPE = TPER.IDGROUPE " +
        $" WHERE CPERTYP<>'TE' AND CPERACTIF='O' AND TPER.VSOCIETE='{MozartParams.NomSociete}' AND S.VSOCIETE='{MozartParams.NomSociete}' AND (DPERSOR IS NULL OR DPERSOR > GETDATE())";
        apiTGrid6.LoadData(dt6, MozartDatabase.cnxMozart, sSQL);
        apiTGrid6.GridControl.DataSource = dt6;

        InitGrid6();
      }
      else
        apiTGrid6.Requery(dt6, MozartDatabase.cnxMozart);

      bpremGlo = true;

      framGlo.Top = 30;
      framGlo.Left = (this.Width - framGlo.Width) / 2;
      framGlo.Visible = true;
      framGlo.BringToFront();
    }

    private void cmdCloseSer_Click(object sender, EventArgs e)
    {
      framService.Visible = false;
    }

    private void cmdCloseDir_Click(object sender, EventArgs e)
    {
      framDir.Visible = false;
    }

    private void cmdCloseGlo_Click(object sender, EventArgs e)
    {
      framGlo.Visible = false;
    }

    private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }
  }
}