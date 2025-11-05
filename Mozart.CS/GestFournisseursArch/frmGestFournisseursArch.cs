using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestFournisseursArch : Form
  {
    public bool bDroitAdminDocSTF;

    DataTable dtPri = new DataTable();
    DataTable dtSec = new DataTable();

    public frmGestFournisseursArch() { InitializeComponent(); }

    private void frmGestFournisseursArch_Load(object sender, System.EventArgs e)
    {
      string sSQL;
      try
      {
        ModuleMain.Initboutons(this);
        if (MozartParams.NomSociete == "SAMSICROMANIA")
          sSQL = "select CSTFTYP, VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, VSTFGRPCP, VSTFGRPVIL, CSTFGRPACTIF, NSTFGRPNUM from api_v_ListeSTFGRPArch WHERE VSOCIETE = 'SAMSICROMANIA' Order by VSTFGRPNOM";
        else if (MozartParams.NomSociete == "SAMSICITALIA")
          sSQL = "select CSTFTYP, VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, VSTFGRPCP, VSTFGRPVIL, CSTFGRPACTIF, NSTFGRPNUM from api_v_ListeSTFGRPArch WHERE VSOCIETE = 'SAMSICITALIA' Order by VSTFGRPNOM";
        else
          sSQL = "select CSTFTYP, VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, VSTFGRPCP, VSTFGRPVIL, CSTFGRPACTIF, NSTFGRPNUM from api_v_ListeSTFGRPArch WHERE (VSOCIETE <> 'SAMSICROMANIA' and VSOCIETE <> 'SAMSICITALIA') Order by VSTFGRPNOM";

        apiGridStfGRP.LoadData(dtPri, MozartDatabase.cnxMozart, sSQL);
        apiGridStfGRP.GridControl.DataSource = dtPri;
        InitapiGridSTFGRP();
        InitapiGridSTF();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdModifierSTF_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiGridStfGRP.GetFocusedDataRow();
      DataRow currentRowSec = ApiGridStf.GetFocusedDataRow();

      if (currentRowPri == null || currentRowSec == null) return;

      frmDetailsSTF f = new frmDetailsSTF();
      f.mstrStatut = "M";
      f.miNumSTF = Convert.ToInt64(currentRowPri["NSTFGRPNUM"]);
      f.mstrNomSTF = currentRowPri["VSTFGRPNOM"].ToString();
      f.mbDroitDocAdmin = bDroitAdminDocSTF;
      f.ShowDialog();

      apiGridStfGRP.Requery(dtPri, MozartDatabase.cnxMozart);
    }

    private void cmdFourniture_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiGridStfGRP.GetFocusedDataRow();
        if (row["CSTFTYP"].ToString() == "ST")
        {
          MessageBox.Show(Resources.msg_must_select_fournisseur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        frmGestFournitures f = new frmGestFournitures();
        f.mIdFournisseur = Convert.ToInt32(row["NSTFGRPNUM"]);
        Cursor.Current = Cursors.WaitCursor;
        f.ShowDialog();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiGridStfGRP.GetFocusedDataRow();
        //on sort si pas de sites
        if (row == null) return;

        Cursor.Current = Cursors.WaitCursor;
        frmSaisieInfoSTT f = new frmSaisieInfoSTT();
        f.mstrTypeNote = "INFO_STF";
        f.mbNoteVisible = false;
        f.miCleTable = Convert.ToInt32(row["NSTFGRPNUM"]);
        f.ShowDialog();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdInfo_Click()
    //On Error GoTo handler
    //
    //  ' on sort si pas de sites
    //  If adoRSPri.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' Nouvelle version générique
    //  frmSaisieInfoSTT.mstrTypeNote = "INFO_STF"
    //  frmSaisieInfoSTT.bNoteVisible = False
    //  frmSaisieInfoSTT.miCleTable = adoRSPri("NSTFGRPNUM")
    //  frmSaisieInfoSTT.Show vbModal
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdCont_Click dans " & Me.Name
    //End Sub

    private void cmdModifierSiteSTF_Click(object sender, EventArgs e)
    {
      DataRow currentRowPri = apiGridStfGRP.GetFocusedDataRow();
      DataRow currentRowSec = ApiGridStf.GetFocusedDataRow();

      if (currentRowPri == null || currentRowSec == null) return;

      frmDetailsSiteSTF f = new frmDetailsSiteSTF();
      f.mstrStatut = "M";
      f.miNumSTFGRP = Convert.ToInt64(currentRowPri["NSTFGRPNUM"]);
      f.miNumSTF = Convert.ToInt32(currentRowSec["NSTFNUM"]);
      f.ShowDialog();

      apiGridStfGRP_SelectionChanged(null, null);
    }

    private void cmdContacts_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGridStf.GetFocusedDataRow();
      if (row == null) return;

      frmGestIntervenants f = new frmGestIntervenants();
      f.miNumFourn = Convert.ToInt64(row["NSTFNUM"]);
      f.msNomFourn = row["VSTFNOM"].ToString();
      f.ShowDialog();

    }

    private void cmdArchSite_Click(object sender, EventArgs e)
    {
      DataRow rowPri = apiGridStfGRP.GetFocusedDataRow();
      DataRow rowSec = ApiGridStf.GetFocusedDataRow();

      if (rowPri == null || rowSec == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_restaurer_entreprise, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        //activation du site
        ModuleData.ExecuteNonQuery($"UPDATE TSTF SET CSTFACTIF = 'O' WHERE NSTFNUM = {rowSec["NSTFNUM"]}");
        //activation du groupe
        ModuleData.ExecuteNonQuery($"UPDATE TSTFGRP SET CSTFGRPACTIF = 'O' Where NSTFGRPNUM = {rowPri["NSTFGRPNUM"]}");
      }
      else
      {
        return;
      }
      apiGridStfGRP.Requery(dtPri, MozartDatabase.cnxMozart);
    }

    private void InitapiGridSTFGRP()
    {
      try
      {
        apiGridStfGRP.AddColumn(Resources.col_FO_ST, "CSTFTYP", 600);
        apiGridStfGRP.AddColumn(Resources.col_Nom, "VSTFGRPNOM", 2700);
        apiGridStfGRP.AddColumn(Resources.col_Adresse1, "VSTFGRPAD1", 3300);
        apiGridStfGRP.AddColumn(Resources.col_Adresse2, "VSTFGRPAD2", 2200);
        apiGridStfGRP.AddColumn(Resources.col_CP, "VSTFGRPCP", 700);
        apiGridStfGRP.AddColumn(Resources.col_Ville, "VSTFGRPVIL", 2400);
        apiGridStfGRP.AddColumn(Resources.col_Actif, "CSTFGRPACTIF", 0);
        apiGridStfGRP.AddColumn("NumSTFGRP", "NSTFGRPNUM", 0);

        apiGridStfGRP.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridSTF()
    {
      try
      {
        ApiGridStf.AddColumn(Resources.col_Nom, "VSTFNOM", 1600);
        ApiGridStf.AddColumn(Resources.col_Type, "CSTFTYP", 450, "", 2);
        ApiGridStf.AddColumn(Resources.col_VilleCible, "VSTFVIC", 1200);
        ApiGridStf.AddColumn(Resources.col_Adresse1, "VSTFAD1", 1300);
        ApiGridStf.AddColumn(Resources.col_Adresse2, "VSTFAD2", 600);
        ApiGridStf.AddColumn(Resources.col_CP, "VSTFCP", 650);
        ApiGridStf.AddColumn(Resources.col_Ville, "VSTFVIL", 1400);
        ApiGridStf.AddColumn(Resources.col_Tel_astreinte, "VSTFTEL", 1200);
        ApiGridStf.AddColumn(Resources.col_Activite, "VSTFAC1", 1500);
        ApiGridStf.AddColumn(Resources.col_euro_heure, "NSTFMOE", 650, "", 2);
        ApiGridStf.AddColumn(Resources.col_euro_depl, "NSTFDEP", 650, "", 2);
        ApiGridStf.AddColumn(Resources.col_Observations, "VSTFOBS", 1200);
        ApiGridStf.AddColumn(Resources.col_Actif, "CSTFACTIF", 600);
        ApiGridStf.AddColumn("NumSTF", "NSTFNUM", 0);

        ApiGridStf.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiGridStfGRP_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      long nStfGrpNum;
      string sSQL;
      try
      {
        DataRow rowPri = apiGridStfGRP.GetFocusedDataRow();
        DataRow rowSec = ApiGridStf.GetFocusedDataRow();

        if (rowPri == null)
          nStfGrpNum = 0;
        else
        {
          nStfGrpNum = Convert.ToInt64(rowPri["NSTFGRPNUM"]);
          cmdFourniture.Enabled = rowPri["CSTFTYP"].ToString() == "ST" ? false : true;
        }
        //Synchro avec l'apigrid du dessous
        sSQL = "SELECT VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL, VSTFTEL, VSTFAC1, NSTFMOE, NSTFDEP, VSTFOBS, CSTFACTIF, NSTFNUM  " +
              $"FROM api_v_ListeSTF WHERE NSTFGRPNUM = {nStfGrpNum} ORDER BY VSTFNOM";
        ApiGridStf.LoadData(dtSec, MozartDatabase.cnxMozart, sSQL);
        ApiGridStf.GridControl.DataSource = dtSec;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}