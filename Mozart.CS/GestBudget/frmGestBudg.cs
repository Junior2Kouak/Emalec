using DevExpress.XtraGrid.Views.Base;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestBudget : Form
  {

    public int miNumClient;
    public string msNomClient;
    public string msActif;

    
    string sSQL;

    DataTable dtPri = new DataTable();
    DataTable dtSec = new DataTable();
    DataTable dtTer = new DataTable();

    public frmGestBudget() { InitializeComponent(); }

    private void frmGestBudget_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Affichage du client
        lblClient.Text = "  " + msNomClient;

        // combo des années
        cboAnnee.SelectedText = DateTime.Now.Year.ToString();

        // recherche des information pour cette année là
        ApiGridCtr.LoadData(dtPri, MozartDatabase.cnxMozart, $"api_sp_ListeContratClient {miNumClient}");
        ApiGridCtr.GridControl.DataSource = dtPri;

        InitApigridCtr();

        DataRow currentRow = ApiGridCtr.GetFocusedDataRow();
        if (null != currentRow)
        {
          // première ligne par défaut
          sSQL = $"select TREF_TYPECONTRAT.VTYPECONTRAT, VSITNOM,  NSITNUE, NBUDGVAL, DBUDGDEB, DBUDGFIN, TSIT.NSITNUM , TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT , TREF_TYPECONTRAT" +
          $" WHERE TBUDG.NSITNUM = TSIT.NSITNUM and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT " +
          $" AND TCONT.NSITNUM = TSIT.NSITNUM AND TCONT.VCONTETAT='OUI' " +
          $" and csitactif='{msActif}' and TBUDG.NTYPECONTRAT ={currentRow["NTYPECONTRAT"]}" +
          $" and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
          $" and TBUDG.NBUDGANNEE ={cboAnnee.Text} AND NCLINUM = {miNumClient}" +
          $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}" +
          $"' ORDER BY VSITNOM";

          ApiGridSite.LoadData(dtSec, MozartDatabase.cnxMozart, sSQL);
          ApiGridSite.GridControl.DataSource = dtSec;
        }
        InitApigridSite();

        // première ligne par défaut
        if (dtSec.Rows.Count != 0)
        {
          DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
          if (null != currentRowSec)
          {
            sSQL = $"select VSITNOM, TREF_TYPECONTRAT.VTYPECONTRAT, NBUDGVAL , TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT, TREF_TYPECONTRAT " +
                   $" WHERE TBUDG.NSITNUM = TSIT.NSITNUM  and TBUDG.NSITNUM = {currentRowSec["NSITNUM"]}" +
                   $" and TBUDG.NBUDGANNEE = {cboAnnee.Text} AND NCLINUM = {miNumClient}" +
                   $" and TSIT.NSITNUM = TCONT.NSITNUM and TCONT.VCONTETAT = 'OUI'" +
                   $" and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
                   $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}' ORDER BY VTYPECONTRAT";

            ApiGridCtrGeres.LoadData(dtTer, MozartDatabase.cnxMozart, sSQL);
            ApiGridCtrGeres.GridControl.DataSource = dtTer;

            txtDateA0.Text = Utils.DateBlankIfNull(currentRowSec["DBUDGDEB"].ToString());
            txtDateA1.Text = Utils.DateBlankIfNull(currentRowSec["DBUDGFIN"].ToString());
          }
          InitApigridContratsGeres();
        }

        if (dtSec.Rows.Count == 0)
        {
          txtDateA0.Text = "";
          txtDateA1.Text = "";
          InitApigridContratsGeres();
        }

        // affichage des totaux
        AfficherSomme(lblContratSomme, dtTer, 2);
        AfficherSomme(lblSiteSomme, dtSec, 3);

        Cursor = Cursors.Default;
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
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //
    //  'Affichage du client
    //  lblClient = "  " & msNomClient
    //    
    //  ' combo des années
    //  cboAnnee.Text = Year(Date)
    //  
    //  ' recherche des information pour cette année là
    //  
    //  ' recordset primaire : liste des contrats actifs du clients
    //  Set adoRS_Pri = New ADODB.Recordset
    //  adoRS_Pri.Open "api_sp_ListeContratClient " & miNumClient, cnx
    //      
    //  ' recordset secondaire : liste des sites par contrat
    //  ' première ligne par défaut
    //  sSQL = "select TREF_TYPECONTRAT.VTYPECONTRAT, VSITNOM,  NSITNUE, NBUDGVAL, DBUDGDEB, DBUDGFIN, TSIT.NSITNUM , TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT , TREF_TYPECONTRAT"
    //  sSQL = sSQL & " WHERE TBUDG.NSITNUM = TSIT.NSITNUM and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT "
    //  sSQL = sSQL & " AND TCONT.NSITNUM = TSIT.NSITNUM AND TCONT.VCONTETAT='OUI' "
    //  sSQL = sSQL & " and csitactif='" & sActif & "' and TBUDG.NTYPECONTRAT =" & adoRS_Pri("NTYPECONTRAT")
    //  sSQL = sSQL & " and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT"
    //  sSQL = sSQL & " and TBUDG.NBUDGANNEE =" & cboAnnee.Text & " AND NCLINUM = " & miNumClient
    //  sSQL = sSQL & " AND TREF_TYPECONTRAT.LANGUE = '" & gstrLangue
    //  sSQL = sSQL & "' ORDER BY VSITNOM"
    //  
    //  Set adoRS_Sec = New ADODB.Recordset
    //  adoRS_Sec.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //          
    //  ' recordset tertiaire : liste des contrats par site
    //  ' première ligne par défaut
    //  If Not adoRS_Sec.EOF Then
    //    sSQL = "select VSITNOM, TREF_TYPECONTRAT.VTYPECONTRAT, NBUDGVAL , TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT, TREF_TYPECONTRAT "
    //    sSQL = sSQL & " WHERE TBUDG.NSITNUM = TSIT.NSITNUM  and TBUDG.NSITNUM =" & adoRS_Sec("NSITNUM")
    //    sSQL = sSQL & " and TBUDG.NBUDGANNEE =" & cboAnnee.Text & " AND NCLINUM = " & miNumClient
    //    sSQL = sSQL & " and TSIT.NSITNUM = TCONT.NSITNUM and TCONT.VCONTETAT = 'OUI' and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT"
    //    sSQL = sSQL & " and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT"
    //    sSQL = sSQL & " AND TREF_TYPECONTRAT.LANGUE = '" & gstrLangue
    //    sSQL = sSQL & "' ORDER BY VTYPECONTRAT"
    //    
    //    Set adoRS_Ter = New ADODB.Recordset
    //    adoRS_Ter.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  End If
    //  
    //  If adoRS_Sec.EOF Then
    //    txtDateA(0) = ""
    //    txtDateA(1) = ""
    //    InitApigridSite
    //    ApiGridSite.LockColonne 3
    //    InitApigrid
    //    ApiGrid.LockColonne 2
    //  Else
    //    txtDateA(0) = BlankIfNull(adoRS_Sec("DBUDGDEB"))
    //    txtDateA(1) = BlankIfNull(adoRS_Sec("DBUDGFIN"))
    //    InitApigridSite
    //    InitApigrid
    //  End If
    //  ' affichage des totaux
    //  AfficherSomme lblContratSomme, adoRS_Ter, 2
    //  AfficherSomme lblSiteSomme, adoRS_Sec, 3
    //
    //  InitApigridCtr
    //     
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigridCtr()
    {
      try
      {
        ApiGridCtr.AddColumn(Resources.col_Contrat, "CONTRAT", 2000);
        ApiGridCtr.AddColumn("NumContrat", "NTYPECONTRAT", 0);

        ApiGridCtr.btnExcel.Visible = ApiGridCtr.btnPrint.Visible = ApiGridCtr.chkColumnsList.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridSite()
    {
      try
      {
        ApiGridSite.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1300);
        ApiGridSite.AddColumn(Resources.col_Site, "VSITNOM", 2600);
        ApiGridSite.AddColumn("N°", "NSITNUE", 600, "", 2);
        ApiGridSite.AddColumn(Resources.col_montant_ht, "NBUDGVAL", 1200, "### ##0", 2);
        ApiGridSite.AddColumn(Resources.col_debut, "DBUDGDEB", 0);
        ApiGridSite.AddColumn(Resources.col_Fin, "DBUDGFIN", 0);
        ApiGridSite.AddColumn("Num", "NSITNUM", 0);
        ApiGridSite.AddColumn("NumContrat", "NTYPECONTRAT", 0);

        ApiGridSite.DelockColumn("NBUDGVAL");
        ApiGridSite.btnExcel.Visible = ApiGridSite.btnPrint.Visible = ApiGridSite.chkColumnsList.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigridContratsGeres()
    {
      try
      {
        ApiGridCtrGeres.AddColumn(Resources.col_Site, "VSITNOM", 1800);
        ApiGridCtrGeres.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1900);
        ApiGridCtrGeres.AddColumn(Resources.col_montant_ht, "NBUDGVAL", 1200, "### ##0", 2);
        ApiGridCtrGeres.AddColumn("NumContrat", "NTYPECONTRAT", 0);

        ApiGridCtrGeres.DelockColumn("NBUDGVAL");
        ApiGridCtrGeres.btnExcel.Visible = ApiGridCtrGeres.btnPrint.Visible = ApiGridCtrGeres.chkColumnsList.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void ApiGridCtr_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtPri.Rows.Count == 0) return;

        DataRow currentRow = ApiGridCtr.GetFocusedDataRow();
        DataRow currentRowSec = null;
        dtSec.Clear();
        dtTer.Clear();
        if (null != currentRow)
        {
          sSQL = $"select TREF_TYPECONTRAT.VTYPECONTRAT, VSITNOM,  NSITNUE, NBUDGVAL, DBUDGDEB, DBUDGFIN, TSIT.NSITNUM, TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT, TREF_TYPECONTRAT " +
                $" WHERE TBUDG.NSITNUM = TSIT.NSITNUM and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT " +
                $" AND TCONT.NSITNUM = TSIT.NSITNUM AND TCONT.VCONTETAT='OUI' " +
                $" and csitactif='{msActif}' and TBUDG.NTYPECONTRAT ={currentRow["NTYPECONTRAT"]}" +
                $" and TBUDG.NBUDGANNEE ={cboAnnee.Text} AND NCLINUM ={miNumClient}" +
                $" and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
                $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}" +
                $"' ORDER BY VSITNOM";

          ApiGridSite.LoadData(dtSec, MozartDatabase.cnxMozart, sSQL);
          ApiGridSite.GridControl.DataSource = dtSec;

          currentRowSec = ApiGridSite.GetFocusedDataRow();
          if (null != currentRowSec)
          {
            // première ligne par défaut
            sSQL = $"select VSITNOM, TREF_TYPECONTRAT.VTYPECONTRAT, NBUDGVAL, TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT , TCONT, TREF_TYPECONTRAT " +
                  $"WHERE TBUDG.NSITNUM = TSIT.NSITNUM  and TBUDG.NSITNUM ={currentRowSec["NSITNUM"]}" +
                  $" and TBUDG.NBUDGANNEE ={cboAnnee.Text} AND NCLINUM = {miNumClient}" +
                  $" and TSIT.NSITNUM = TCONT.NSITNUM and TCONT.VCONTETAT = 'OUI' and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT" +
                  $" and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
                  $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}" +
                  $"' ORDER BY VTYPECONTRAT";

            ApiGridCtrGeres.LoadData(dtTer, MozartDatabase.cnxMozart, sSQL);
            ApiGridCtrGeres.GridControl.DataSource = dtTer;
          }
        }

        if (null != currentRowSec && dtSec.Rows.Count != 0)
        {
          txtDateA0.Text = Utils.DateBlankIfNull(currentRowSec["DBUDGDEB"].ToString());
          txtDateA1.Text = Utils.DateBlankIfNull(currentRowSec["DBUDGFIN"].ToString());
        }
        else
        {
          txtDateA0.Text = "";
          txtDateA1.Text = "";
        }

        // affichage des totaux
        AfficherSomme(lblContratSomme, dtTer, 2);
        AfficherSomme(lblSiteSomme, dtSec, 3);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ApiGridSite_Click(object sender, EventArgs e)
    {
      try
      {
        // on sort si il n'y a pas d'enregistrement maitre
        if (dtSec.Rows.Count == 0) return;
        dtTer.Clear();
        DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
        if (null != currentRowSec)
        {
          // première ligne par défaut
          sSQL = $"select VSITNOM, TREF_TYPECONTRAT.VTYPECONTRAT, NBUDGVAL, TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT , TCONT, TREF_TYPECONTRAT " +
          $"WHERE TBUDG.NSITNUM = TSIT.NSITNUM  and TBUDG.NSITNUM ={currentRowSec["NSITNUM"]}" +
          $" and TBUDG.NBUDGANNEE ={cboAnnee.Text} AND NCLINUM = {miNumClient}" +
          $" and TSIT.NSITNUM = TCONT.NSITNUM and TCONT.VCONTETAT = 'OUI' and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT" +
          $" and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
          $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}" +
          $"' ORDER BY VTYPECONTRAT";

          ApiGridCtrGeres.LoadData(dtTer, MozartDatabase.cnxMozart, sSQL);
          ApiGridCtrGeres.GridControl.DataSource = dtTer;
        }

        // affichage des totaux
        AfficherSomme(lblContratSomme, dtTer, 2);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cboAnnee_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRowPri = ApiGridCtr.GetFocusedDataRow();
        DataRow currentRowSec = null;
        dtSec.Clear();
        dtTer.Clear();
        if (null != currentRowPri)
        {
          //première ligne par défaut
          sSQL = $"select TREF_TYPECONTRAT.VTYPECONTRAT, VSITNOM,  NSITNUE, NBUDGVAL, DBUDGDEB, DBUDGFIN, TSIT.NSITNUM, TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT,TREF_TYPECONTRAT " +
          $"WHERE TBUDG.NSITNUM = TSIT.NSITNUM and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT " +
          $" AND TCONT.NSITNUM = TSIT.NSITNUM AND TCONT.VCONTETAT='OUI' " +
          $" and csitactif='{msActif}' and TBUDG.NTYPECONTRAT ={currentRowPri["NTYPECONTRAT"]}" +
          $" and TBUDG.NBUDGANNEE ={cboAnnee.Text} AND NCLINUM = { miNumClient}" +
          $" and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
          $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}" +
          $"' ORDER BY VSITNOM";

          ApiGridSite.LoadData(dtSec, MozartDatabase.cnxMozart, sSQL);
          ApiGridSite.GridControl.DataSource = dtSec;
          //première ligne par défaut

          currentRowSec = ApiGridSite.GetFocusedDataRow();
          if (currentRowSec != null)
          {
            sSQL = $"select VSITNOM, TREF_TYPECONTRAT.VTYPECONTRAT, NBUDGVAL, TREF_TYPECONTRAT.NTYPECONTRAT from TBUDG, TSIT, TCONT, TREF_TYPECONTRAT " +
            $"WHERE TBUDG.NSITNUM = TSIT.NSITNUM  and TBUDG.NSITNUM ={currentRowSec["NSITNUM"]}" +
            $" and TBUDG.NBUDGANNEE ={cboAnnee.Text} AND NCLINUM = {miNumClient}" +
            $" and TSIT.NSITNUM = TCONT.NSITNUM and TCONT.VCONTETAT = 'OUI' and TCONT.NTYPECONTRAT=TBUDG.NTYPECONTRAT" +
            $" and TCONT.NTYPECONTRAT = TREF_TYPECONTRAT.NTYPECONTRAT" +
            $" AND TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}" +
            $"' ORDER BY VTYPECONTRAT";

            ApiGridCtrGeres.LoadData(dtTer, MozartDatabase.cnxMozart, sSQL);
            ApiGridCtrGeres.GridControl.DataSource = dtTer;
          }
        }

        if (null != currentRowSec && dtSec.Rows.Count != 0)
        {
          txtDateA0.Text = Utils.DateBlankIfNull(currentRowSec["DBUDGDEB"].ToString());
          txtDateA1.Text = Utils.DateBlankIfNull(currentRowSec["DBUDGFIN"].ToString());
        }
        else
        {
          txtDateA0.Text = "";
          txtDateA1.Text = "";
        }

        // affichage des totaux
        AfficherSomme(lblContratSomme, dtTer, 2);
        AfficherSomme(lblSiteSomme, dtSec, 3);
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
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_saisirDateDebutPer, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_saisirDateFinPer, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        EnregistrerLigne();
        ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void EnregistrerLigne()
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_creationBudget", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iClient"].Value = miNumClient;
          cmd.Parameters["@nAnnee"].Value = cboAnnee.Text;
          cmd.Parameters["@dDeb"].Value = txtDateA0.Text;
          cmd.Parameters["@dFin"].Value = txtDateA1.Text;

          cmd.ExecuteNonQuery();
        }

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
 
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
 
    public void AfficherSomme(Label lbl, DataTable dt, int indice)
    {
      try
      {
        double iSomme = 0;
        if (dt.Rows.Count != 0)
        {
          foreach (DataRow row in dt.Rows)
            iSomme += Convert.ToDouble(row[indice]);
        }

        lbl.Text = $"Total : {Strings.FormatNumber(iSomme, 2, TriState.True)} €";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
 
    private void ApiGridSite_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      if (null == currentRowSec) return;

      ModuleData.ExecuteNonQuery($"UPDATE TBUDG SET NBUDGVAL = {e.Value} WHERE TBUDG.NSITNUM = {currentRowSec["NSITNUM"]} " +
                                 $"and TBUDG.NBUDGANNEE = {cboAnnee.Text} and NTYPECONTRAT = {currentRowSec["NTYPECONTRAT"]}");

      AfficherSomme(lblSiteSomme, dtSec, 3);
      ApiGridSite_Click(null, null);
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void ApiGrid_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      DataRow currentRowSec = ApiGridSite.GetFocusedDataRow();
      if (null == currentRowSec) return;

      ModuleData.ExecuteNonQuery($"UPDATE TBUDG SET NBUDGVAL = {e.Value} WHERE TBUDG.NSITNUM = {currentRowSec["NSITNUM"]} " +
                                 $"and TBUDG.NBUDGANNEE = {cboAnnee.Text} and NTYPECONTRAT = {currentRowSec["NTYPECONTRAT"]}");

      ApiGridSite.Requery(dtSec, MozartDatabase.cnxMozart);

      AfficherSomme(lblSiteSomme, dtSec, 3);
      AfficherSomme(lblContratSomme, dtTer, 2);
    }
  }
}