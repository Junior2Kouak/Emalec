using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatDocAdminSTF : Form
  {
    DataTable dt = new DataTable();

    public frmStatDocAdminSTF() { InitializeComponent(); }


    private void frmStatDocAdminSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_StatDocAdminSTF");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();

        lblWebSttNbConnexion.Text = Resources.col_Web_STT_Nb_Co;
        lnlNbContrats.Text = Resources.col_Nb_Contrat;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void apiTGrid1_ColumnFilterChanged(object sender, EventArgs e)
    {
      apiTGrid1_SelectionChanged(sender, null);
    }
    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null)
      {
        cmdCourRelance.BackColor = MozartColors.ColorH8000000F;
        return;
      }
      if (dt.Rows.Count > 0)
        cmdCourRelance.BackColor = (int)row["NBRELANCE"] > 0 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
      else
        cmdCourRelance.BackColor = MozartColors.ColorH8000000F;
    }

    private void cmdCourRelance_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (dt.Rows.Count == 0) return;

      new frmListeCourrierSTT()
      {
        miStfGrpNnum = (int)row["NSTFGRPNUM"],
        mvStfGrpNom = (string)row["VSTFGRPNOM"],
      }.ShowDialog();
    }

    private void cmdModifierSTF_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (dt.Rows.Count == 0) return;

      new frmGestFournisseurs()
      {
        miNumSTF = (int)row["NSTFGRPNUM"],
        mstrNomSTF = (string)row["VSTFGRPNOM"],
      }.ShowDialog();
    }

    private void CmdAjout_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      new frmDetailDocAdminSTF()
      {
        miDocAdminSTFNum = 0,
        miSTFGRPNUM = (int)row["NSTFGRPNUM"],
        mstrNom = (string)row["VSTFGRPNOM"],
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void CmdClosedFrame_Click(object sender, EventArgs e)
    {
      FrameLegendeColor.Visible = false;
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      FrameLegendeColor.Visible = !FrameLegendeColor.Visible;
      if (FrameLegendeColor.Visible)
      {
        FrameLegendeColor.BringToFront();
      }
    }

    private void CmdDocAdminSTF_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (dt.Rows.Count == 0) return;

      new frmGestDocAdminSTF()
      {
        miStfGrpNnum = (int)row["NSTFGRPNUM"],
        mstrNom = (string)row["VSTFGRPNOM"],
      }.ShowDialog();
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApigrid()
    {
      apiTGrid1.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
      apiTGrid1.AddColumn(Resources.col_SousTraitant, "VSTFGRPNOM", 3800);
      apiTGrid1.AddColumn(Resources.col_Pays, "VSTFGRPPAYS", 1000);
      apiTGrid1.AddColumn("Statut", "VLIBSTATUT", 1000);
      apiTGrid1.AddColumn(Resources.col_Nb_Contrat, "NBCST", 1000, "", 1);
      apiTGrid1.AddColumn("€H", "NSTFMOE", 500, "", 2);
      apiTGrid1.AddColumn("€Dp", "NSTFDEP", 500, "", 2);
      apiTGrid1.AddColumn("CA du STT", "NSTFGRPCA", 1300, "# ### ##0 €", 1);
      apiTGrid1.AddColumn("CA emalec 12 mois", "NSTFGRPFA", 1300, "# ### ##0 €", 1);
      apiTGrid1.AddColumn("Dépendance %", "TAUX", 1500, "##0.##", 1);
      apiTGrid1.AddColumn("Notation", "NOTATION", 1000, "", 1);
      apiTGrid1.AddColumn("Nbre d'AT", "NBJOURAT", 1000, "", 1);
      apiTGrid1.AddColumn("Contrat", "CONTRAT", 900, "", 2);
      apiTGrid1.AddColumn(Resources.col_Web_STT_Nb_Co, "CNX", 1000, "", 1);
      apiTGrid1.AddColumn("Fac bloc", "FB", 1000, "", 1);
      apiTGrid1.AddColumn(Resources.col_Kbis, "DOC1", 1200);
      apiTGrid1.AddColumn(Resources.col_RC2, "DOC2", 1200);
      apiTGrid1.AddColumn(Resources.col_Decennale, "DOC3", 1200);
      apiTGrid1.AddColumn(Resources.col_Sociale, "DOC4", 1200);
      apiTGrid1.AddColumn(Resources.col_Fiscale, "DOC5", 1200);
      apiTGrid1.AddColumn("CGASTT", "DOC9", 1250);  // DOC13
      apiTGrid1.AddColumn(Resources.col_Attestation_Formation, "DOC10", 1200, "", 0, true);
      apiTGrid1.AddColumn("Fluides", "DOC11", 1200, "", 0, true);
      apiTGrid1.AddColumn("INTERDIT", "INTERDIT", 0);
      apiTGrid1.AddColumn("Décennale", "DECENNALE", 0);
      apiTGrid1.AddColumn("BSTFGRPDOCADM", "BSTFGRPDOCADM", 0);
      apiTGrid1.AddColumn("CSTFGRPP3M", "CSTFGRPP3M", 0);


      apiTGrid1.InitColumnList();
    }

    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      colorizeCell(sender, e.RowHandle, e.Column.Name, e.CellValue, e.Appearance);
    }

    private void colorizeCell(object sender, int pRowHandle, string pColumnName, object pCellValue, object pAppearanceObject)
    {
      if (pRowHandle < 0)
      {
        return;
      }

      AppearanceObject app = pAppearanceObject as AppearanceObject;
      //Gestion spécifique des couleurs
      GridView View = sender as GridView;

      switch (pColumnName)
      {
        case "DOC1":
        case "DOC2":
        case "DOC4":
        case "DOC5":
          if (pCellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(pCellValue) < DateTime.Now)
              app.BackColor = MozartColors.ColorH80FFFF; //Périmé
            if (Convert.ToDateTime(pCellValue) >= DateTime.Now)
              app.BackColor = MozartColors.ColorH80FF80; //OK
          }
          else
            app.BackColor = MozartColors.colorHFFC0FF; // Non conforme
          break;
        case "DOC3":
          if (View.GetDataRow(pRowHandle)["DECENNALE"].ToString() == "N")
            app.BackColor = MozartColors.colorHCCCCCC;
          else
          {
            if (pCellValue != DBNull.Value)
            {
              if (Convert.ToDateTime(pCellValue) < DateTime.Now)
                app.BackColor = MozartColors.ColorH80FFFF; //Périmé
              if (Convert.ToDateTime(pCellValue) >= DateTime.Now)
                app.BackColor = MozartColors.ColorH80FF80; //OK
            }
            else
              app.BackColor = MozartColors.colorHFFC0FF; //non conforme
          }
          break;

        case "DOC10":
          // Pas de notion de date sur ce document (si il existe c'est suffisant)
          if (pCellValue != DBNull.Value)
            app.BackColor = MozartColors.ColorH80FF80; //OK
          break;
        case "DOC11":
          // nouvelle gestion de l'attestation fluide FGA le 15/11/23
          // si STT en clim froid on test comme un doc obligatoire, sinon on fait le test simple de présence du doc
          if (View.GetDataRow(pRowHandle)["FF"].ToString() != "0")
          {
            if (pCellValue != DBNull.Value)
            {
              if (Convert.ToDateTime(pCellValue) < DateTime.Now)
                app.BackColor = MozartColors.ColorH80FFFF; //Périmé
              if (Convert.ToDateTime(pCellValue) >= DateTime.Now)
                app.BackColor = MozartColors.ColorH80FF80; //OK
            }
            else
              app.BackColor = MozartColors.colorHFFC0FF; //non conforme
          }
          //else
          //{ 
          //  if (pCellValue != DBNull.Value)
          //    app.BackColor = MozartColors.ColorH80FF80; //OK
          //}
          break;
        case "DOC9":
          break;
        default:
          if (View.GetDataRow(pRowHandle)["INTERDIT"].ToString() == "O")
          {
            app.BackColor = Color.Red;
          }

          if (View.GetDataRow(pRowHandle)["BSTFGRPDOCADM"].ToString() == "O")
          {
            app.BackColor = Color.LightCoral;
          }
          if (View.GetDataRow(pRowHandle)["CSTFGRPP3M"].ToString() == "O")
          {
            app.BackColor = Color.YellowGreen;
          }
          break;

      }
    }

    private bool IsPaire(int Nb)
    {
      return Nb % 2 == 0;
    }
  }
}

