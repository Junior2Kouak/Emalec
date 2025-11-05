using DevExpress.XtraGrid.Views.Base;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPrixClientContrat : Form
  {
    public long miNumClient;
    public string sNomClient;

    private SqlDataAdapter da = new SqlDataAdapter();
    readonly SqlCommandBuilder cb = new SqlCommandBuilder();
    DataTable dt = new DataTable();
    List<api_sp_PrixClientContrat_ListePays_Result> dtPaysReturn;

    int bModeAstrTexte; //0: pour tous les lignes séleectionnées et > 0 : pour la ligne sélectionnée uniquement

    //Public miNumClient As Long
    //Dim adoRS_Sec As ADODB.Recordset
    //Dim bModeAstrTexte As Integer  '0: pour tous les lignes séleectionnées et > 0 : pour la ligne sélectionnée uniquement

    public frmPrixClientContrat()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmPrixClientContrat_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        if (sNomClient != "") lblTitre.Text = this.Text = $"{lblTitre.Text} : {sNomClient}";

        da = new SqlDataAdapter($"EXEC api_sp_ListePrixCliTypCont {miNumClient}", MozartDatabase.cnxMozart);
        // ds = new DataSet();
        da.Fill(dt);
        apiTGrid.GridControl.DataSource = dt;

        cb.DataAdapter = da;

        // Create the UpdateCommand.
        SqlCommand command = new SqlCommand("UPDATE TCLIPRIXTYPCONT SET NCLICONTHOR = @NCLICONTHOR, NCLICONTDEP = @NCLICONTDEP, NCLICONTHORSAM = @NCLICONTHORSAM, " +
                                            "NCLICONTHORNUIDIM = @NCLICONTHORNUIDIM,  NMTTFORFAITASTR = @NMTTFORFAITASTR, VACTTEXTASTR = @VACTTEXTASTR " +
                                           $"WHERE VPAYS = @VPAYS AND NTYPECONTRAT = @NTYPECONTRAT AND NCLINUM = {miNumClient}", MozartDatabase.cnxMozart);

        // Add the parameters for the UpdateCommand.
        command.Parameters.Add("@NTYPECONTRAT", SqlDbType.Int, 4, "NTYPECONTRAT");
        command.Parameters.Add("@VPAYS", SqlDbType.NVarChar, 50, "VPAYS");
        command.Parameters.Add("@NCLICONTHOR", SqlDbType.Decimal, 5, "NCLICONTHOR");
        command.Parameters.Add("@NCLICONTDEP", SqlDbType.Decimal, 5, "NCLICONTDEP");
        command.Parameters.Add("@NCLICONTHORSAM", SqlDbType.Decimal, 5, "NCLICONTHORSAM");
        command.Parameters.Add("@NCLICONTHORNUIDIM", SqlDbType.Decimal, 5, "NCLICONTHORNUIDIM");
        command.Parameters.Add("@NMTTFORFAITASTR", SqlDbType.Decimal, 5, "NMTTFORFAITASTR");
        command.Parameters.Add("@VACTTEXTASTR", SqlDbType.NVarChar, 1000, "VACTTEXTASTR");

        da.UpdateCommand = command;

        //deletecommand
        SqlCommand cmdDelete = new SqlCommand($"DELETE FROM TCLIPRIXTYPCONT WHERE	TCLIPRIXTYPCONT.NCLINUM =  {miNumClient} AND TCLIPRIXTYPCONT.NTYPECONTRAT = @ntypecontrat AND TCLIPRIXTYPCONT.VPAYS = @VPAYSNOM", MozartDatabase.cnxMozart);

        // Add the parameters for the UpdateCommand.
        cmdDelete.Parameters.Add("@ntypecontrat", SqlDbType.Int, 12, "NTYPECONTRAT");
        cmdDelete.Parameters.Add("@VPAYSNOM", SqlDbType.VarChar, 255, "VPAYS");

        da.DeleteCommand = cmdDelete;

        //insertcommand
        SqlCommand cmdInsert = new SqlCommand($"INSERT INTO TCLIPRIXTYPCONT (NCLINUM,NTYPECONTRAT,NCLICONTHOR,NCLICONTDEP,NCLICONTHORSAM,NCLICONTHORNUIDIM,VPAYS,  NMTTFORFAITASTR, VACTTEXTASTR) " +
                                                  $" SELECT {miNumClient}, @NTYPECONTRAT, 0, 0, 0, 0, @VPAYSNOM, null, ''", MozartDatabase.cnxMozart);

        // Add the parameters for the UpdateCommand.
        cmdInsert.Parameters.Add("@NTYPECONTRAT", SqlDbType.Int, 12, "NTYPECONTRAT");
        cmdInsert.Parameters.Add("@VPAYSNOM", SqlDbType.VarChar, 255, "VPAYS");

        da.InsertCommand = cmdInsert;

        InitApiTgrid();
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

    private void cmdModifMO_Click(object sender, EventArgs e)
    {
      string rep = Interaction.InputBox("Attention, vous allez appliquer le tarif saisi ci-dessous, " +
                                        "à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?", "Modification Main d'oeuvre").Replace(".", ",");
      if (rep != "" && Double.TryParse(rep, out double dMo))
      {
        int nb = apiTGrid.dgv.DataRowCount;
        List<DataRow> rows = new List<DataRow>(nb);
        for (int i = 0; i < nb; i++)
          rows.Add(apiTGrid.dgv.GetDataRow(apiTGrid.dgv.GetVisibleRowHandle(i)));
        for (int i = 0; i < nb; i++)
          rows[i]["NCLICONTHOR"] = dMo;

        da.Update(dt);
      }
    }

    private void cmdModifDep_Click(object sender, EventArgs e)
    {
      string rep = Interaction.InputBox("Attention, vous allez appliquer le tarif saisi ci-dessous, " +
                                        "à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?", "Modification Déplacement").Replace(".", ",");
      if (rep != "" && Double.TryParse(rep, out double dDep))
      {
        int nb = apiTGrid.dgv.DataRowCount;
        List<DataRow> rows = new List<DataRow>(nb);
        for (int i = 0; i < nb; i++)
          rows.Add(apiTGrid.dgv.GetDataRow(apiTGrid.dgv.GetVisibleRowHandle(i)));
        for (int i = 0; i < nb; i++)
          rows[i]["NCLICONTDEP"] = dDep;

        da.Update(dt);
      }
    }

    private void CmdModSam_Click(object sender, EventArgs e)
    {
      string rep = Interaction.InputBox("Attention, vous allez appliquer le tarif saisi ci-dessous, " +
                                        "à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?", "Modification Main d'oeuvre Samedi").Replace(".", ",");
      if (rep != "" && Double.TryParse(rep, out double dMoSam))
      {
        int nb = apiTGrid.dgv.DataRowCount;
        List<DataRow> rows = new List<DataRow>(nb);
        for (int i = 0; i < nb; i++)
          rows.Add(apiTGrid.dgv.GetDataRow(apiTGrid.dgv.GetVisibleRowHandle(i)));
        for (int i = 0; i < nb; i++)
          rows[i]["NCLICONTHORSAM"] = dMoSam;

        da.Update(dt);
      }
    }

    private void CmdModifDimNuit_Click(object sender, EventArgs e)
    {
      string rep = Interaction.InputBox("Attention, vous allez appliquer le tarif saisi ci-dessous, " +
                                        "à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?", "Modification Main d'oeuvre Dim-Nuit").Replace(".", ",");
      if (rep != "" && Double.TryParse(rep, out double dMoDimNuit))
      {
        int nb = apiTGrid.dgv.DataRowCount;
        List<DataRow> rows = new List<DataRow>(nb);
        for (int i = 0; i < nb; i++)
          rows.Add(apiTGrid.dgv.GetDataRow(apiTGrid.dgv.GetVisibleRowHandle(i)));
        for (int i = 0; i < nb; i++)
          rows[i]["NCLICONTHORNUIDIM"] = dMoDimNuit;

        da.Update(dt);
      }
    }

    private void CmdModifMttAstr_Click(object sender, EventArgs e)
    {
      string rep = Interaction.InputBox("Attention, vous allez appliquer le tarif saisi ci-dessous, " +
                                        "à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?", "Modification Montant Action astreinte").Replace(".", ",");
      if (rep != "" && Double.TryParse(rep, out double dMoMttAstr))
      {
        int nb = apiTGrid.dgv.DataRowCount;
        List<DataRow> rows = new List<DataRow>(nb);
        for (int i = 0; i < nb; i++)
          rows.Add(apiTGrid.dgv.GetDataRow(apiTGrid.dgv.GetVisibleRowHandle(i)));
        for (int i = 0; i < nb; i++)
          rows[i]["NMTTFORFAITASTR"] = dMoMttAstr;

        da.Update(dt);
      }
    }

    private void CmdModifTexteAstr_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      bModeAstrTexte = 0;
      txtAction.Text = Utils.BlankIfNull(row["VACTTEXTASTR"]);
      Frame1.Visible = true;
    }

    private void CmdValidTexteAstr_Click(object sender, EventArgs e)
    {
      if (bModeAstrTexte == 0)
      {
        if (MessageBox.Show("Modification du texte d'une action en astreinte\r\nAttention, vous allez appliquer ce texte " +
                            "à tous les éléments affichés dans la grille !\r\nEtes-vous sûr ?", Program.AppTitle,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          int nb = apiTGrid.dgv.DataRowCount;
          List<DataRow> rows = new List<DataRow>(nb);
          for (int i = 0; i < nb; i++)
            rows.Add(apiTGrid.dgv.GetDataRow(apiTGrid.dgv.GetVisibleRowHandle(i)));
          for (int i = 0; i < nb; i++)
            rows[i]["VACTTEXTASTR"] = txtAction.Text;

          da.Update(dt);
          Frame1.Visible = false;
        }
      }
      else
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row != null)
        {
          if (MessageBox.Show("Modification du texte d'une action en astreinte\r\nEtes-vous sûr ?", Program.AppTitle,
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            row["VACTTEXTASTR"] = txtAction.Text;
            da.Update(dt);
            Frame1.Visible = false;
          }
        }
      }
    }

    private void CmdCancel_Click(object sender, EventArgs e)
    {
      Frame1.Visible = false;
      txtAction.Text = "";
    }

    private void frmPrixClientContrat_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row != null)
      {
        bModeAstrTexte = 1;
        txtAction.Text = Utils.BlankIfNull(row["VACTTEXTASTR"]);
        Frame1.Visible = true;
      }
    }

    private void InitApiTgrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_Type_contrat, "VTYPECONTRAT", 2200);
        apiTGrid.AddColumn(Resources.col_Pays, "VPAYS", 1800);
        apiTGrid.AddColumn(Resources.col_Heure_ht, "NCLICONTHOR", 1500, "", 1);
        apiTGrid.AddColumn(Resources.col_Depl_ht, "NCLICONTDEP", 1500, "", 1);
        apiTGrid.AddColumn(Resources.col_Coef_H_samedi, "NCLICONTHORSAM", 2100, "", 1);
        apiTGrid.AddColumn(Resources.col_Coef_H_Nuit_et_Dimanche, "NCLICONTHORNUIDIM", 2800, "", 1);
        apiTGrid.AddColumn(Resources.col_Montant_Forfait_Astr, "NMTTFORFAITASTR", 2800, "", 1);
        apiTGrid.AddColumn(Resources.col_Texte_Action_Astr, "VACTTEXTASTR", 2800, "", 1);
        apiTGrid.AddColumn("TypeContrat", "NTYPECONTRAT", 0);
        apiTGrid.AddColumn("NCLINUM", "NCLINUM", 0);

        apiTGrid.InitColumnList();

        apiTGrid.DelockColumn("NCLICONTHOR");
        apiTGrid.DelockColumn("NCLICONTDEP");
        apiTGrid.DelockColumn("NCLICONTHORSAM");
        apiTGrid.DelockColumn("NCLICONTHORNUIDIM");
        apiTGrid.DelockColumn("NMTTFORFAITASTR");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      try
      {
        ColumnView view = apiTGrid.GridControl.FocusedView as ColumnView;
        view.CloseEditor();
        if (view.UpdateCurrentRow())
          da.Update(dt);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void BtnHisto_Click(object sender, EventArgs e)
    {

      new frmPrixClientContratHisto() { miNumClient = miNumClient }.ShowDialog();

    }

    private void BtnGestPays_Click(object sender, EventArgs e)
    {

      bool baffichemsgnewpays = false;

      frmPrixClientContratPays_ListePays oFrm = new frmPrixClientContratPays_ListePays((int)miNumClient);
      if (dtPaysReturn != null) oFrm.DtPays = dtPaysReturn;
      oFrm.ShowDialog();

      //on supprime
      if (oFrm.DtPays == null) return;

      //var LstPays = oFrm.DtPays.AsEnumerable().Select(r => new { VPAYSNOM = r.Field("VPAYSNOM")});

      List<CPays> LstPays_NotSelected = oFrm.DtPays.AsEnumerable()
                      .Where(s => s.BPAYSSELECT == 0)
                      .Select(row => new CPays
                      {
                        VPAYSNOM = (string)row.VPAYSNOM
                      }).ToList();

      List<CPays> LstPays_Selected = oFrm.DtPays.AsEnumerable()
                      .Where(s => s.BPAYSSELECT == 1)
                      .Select(row => new CPays
                      {
                        VPAYSNOM = (string)row.VPAYSNOM
                      }).ToList();


      //on parcours la table des pays a supprimer
      foreach (CPays oItem in LstPays_NotSelected)
      {
        if (dt.Select($"[VPAYS] = '{oItem.VPAYSNOM}'").Count() > 0)
        {
          foreach (DataRow drDeleted in dt.Select($"[VPAYS] = '{oItem.VPAYSNOM}'"))
          {
            drDeleted.Delete();
          }
        }
      }

      //on parcours la table des pays à ajouter
      foreach (CPays oItem in LstPays_Selected)
      {
        //si pays n'existe pas, alors on l'ajoute
        if (dt.Select($"[VPAYS] = '{oItem.VPAYSNOM}'").Count() == 0)
        {

          if (baffichemsgnewpays == false) baffichemsgnewpays = true;

          //liste des contrats actifs du client
          List<CContratClient> LstContratClient = dt.AsEnumerable()
                      .GroupBy(grp => new { NTYPECONTRAT = grp.Field<int>("NTYPECONTRAT"), VTYPECONTRAT = grp.Field<string>("VTYPECONTRAT") })
                      .Select(row => new CContratClient
                      {
                        NTYPECONTRAT = row.Key.NTYPECONTRAT,
                        VTYPECONTRAT = row.Key.VTYPECONTRAT,
                      }).ToList();

          foreach (CContratClient itemContrat in LstContratClient)
          {

            DataRow drAdd = dt.NewRow();
            drAdd["NCLINUM"] = miNumClient;
            drAdd["VTYPECONTRAT"] = itemContrat.VTYPECONTRAT;
            drAdd["NTYPECONTRAT"] = itemContrat.NTYPECONTRAT;
            drAdd["NCLICONTHOR"] = 0;
            drAdd["NCLICONTDEP"] = 0;
            drAdd["NCLICONTHORSAM"] = 0;
            drAdd["NCLICONTHORNUIDIM"] = 0;
            drAdd["VPAYS"] = oItem.VPAYSNOM;
            drAdd["NMTTFORFAITASTR"] = DBNull.Value;
            drAdd["VACTTEXTASTR"] = "";

            dt.Rows.Add(drAdd);

          }

        }
      }

      dtPaysReturn = oFrm.DtPays;

      oFrm.Dispose();
      da.Update(dt);
      dt.AcceptChanges();

      apiTGrid.Refresh();
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      apiTGrid.dgv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
                                             new DevExpress.XtraGrid.Columns.GridColumnSortInfo(apiTGrid.dgv.Columns.ColumnByFieldName("VTYPECONTRAT"), DevExpress.Data.ColumnSortOrder.Ascending),
                                             new DevExpress.XtraGrid.Columns.GridColumnSortInfo(apiTGrid.dgv.Columns.ColumnByFieldName("VPAYS"), DevExpress.Data.ColumnSortOrder.Ascending)});


      apiTGrid.dgv.BeginDataUpdate();
      apiTGrid.dgv.EndDataUpdate();

      if (baffichemsgnewpays == true) MessageBox.Show("Pensez à aller renseigner les montants MO, DEP et Astreinte pour chaque contrat du ou des nouveau(x) pays.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    }

  }
}

public class CPays
{
  public string VPAYSNOM;
}

public class CContratClient
{
  public int NTYPECONTRAT;
  public string VTYPECONTRAT;
}