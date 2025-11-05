using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmListeDevisST : Form
  {
    public string mstrStatutDevis;
    public int mstrPPS;
    public bool bAsPrest;

    DataTable dtDev = new DataTable();

    public frmListeDevisST() { InitializeComponent(); }

    private void frmListeDevisST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitGrid();

        txtCritSTF.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("STF"), "NSTFNUM", "VSTFNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        if (mstrStatutDevis == "A")
        {
          cmdFind_Click(null, null);
          txtCritNumDevis.Text = "";
          cmdNouveau.Visible = true;
          if (bAsPrest) cmdDevPrest.Visible = true;
          cmdDetail.Visible = false;
          chkAll.Visible = false;
          fraCriteres.Visible = false;
          grid.Top = fraCriteres.Top;
          txtCritSTF.Visible = false;
        }
        else
        {
          cmdNouveau.Visible = false;
          cmdDevPrest.Visible = false;
          cmdDetail.Visible = true;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void frmListeDevisST_KeyUp(object sender, KeyEventArgs e)
    {
      if (Keys.Enter == e.KeyCode || e.KeyCode == Keys.F2) cmdFind_Click(null, null);
    }


    private void frmListeDevisST_ResizeEnd(object sender, EventArgs e)
    {
      grid.Width = this.Width - grid.Left - 45;
      grid.Height = this.Height - grid.Top - 60;
      fraCriteres.Width = grid.Width;
    }

    private void cmdNouveau_Click(object sender, EventArgs e)
    {
      // 
      MessageBox.Show(Resources.msg_AttNouvDemandeDevisSurAction, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      new frmDevisAutoST
      {
        miNumDevisST = 0,
        mstrPPS = mstrPPS,
        bDesactive = true // on desactive les autres demandes
      }.ShowDialog();

      Dispose();
    }

    private void cmdDevPrest_Click(object sender, EventArgs e)
    {
      new frmDevisSTprestation(0).ShowDialog();
      Dispose();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = grid.GetFocusedDataRow();
      if (currentRow == null) return;

      // passage des parametres
      MozartParams.NumDi = (int)Utils.ZeroIfNull(currentRow["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);

      if (currentRow["CDSTTYPE"].ToString() == "S")
      {
        new frmDevisAutoST
        {
          miNumDevisST = (int)Utils.ZeroIfNull(currentRow[0]),
          mstrPPS = mstrPPS,
          bDesactive = false // on ne desactive pas les autres demandes
        }.ShowDialog();
      }
      else
      {
        new frmDevisSTprestation((int)Utils.ZeroIfNull(currentRow[0])).ShowDialog();
      }

      grid.Requery(dtDev, MozartDatabase.cnxMozart);
    }

    private void cmdDetail_Click(object sender, EventArgs e)
    {

      try
      {
        DataRow currentRow = grid.GetFocusedDataRow();
        if (currentRow == null) return;

        MozartParams.NumDi = (int)Utils.ZeroIfNull(currentRow["NDINNUM"]);

        // ecran de modification de la demande
        new frmAddAction
        {
          mstrStatutDI = "M"
        }.ShowDialog();

        //on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;

        grid.Requery(dtDev, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      // Archivage du devis sélectionné
      DataRow currentRow = grid.GetFocusedDataRow();
      if (currentRow == null) return;

      if (MessageBox.Show(Resources.msg_archiverDevis, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.CnxExecute($"UPDATE TDST SET CDSTACTIF = 'N' WHERE NDSTNUM = {currentRow["NDSTNUM"]}");
        grid.Requery(dtDev, MozartDatabase.cnxMozart);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Cal.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate0")
      {
        txtDate = txtCritDate0.Text;
        Cal.Tag = 0;
      }
      else
      {
        txtDate = txtCritDate1.Text;
        Cal.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }

      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Cal.Tag == 0) txtCritDate0.Text = Cal.Value.ToShortDateString();
      else if ((int)Cal.Tag == 1) txtCritDate1.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }


    private void InitGrid()
    {

      try
      {
        grid.AddColumn(Resources.col_Devis, "NDSTNUM", 750);
        grid.AddColumn(Resources.col_DI, "NDINNUM", 750);
        grid.AddColumn(Resources.col_ST, "VSTFNOM", 1800, "", 0, true);
        grid.AddColumn(Resources.col_Contact, "VINTNOM", 1800);
        grid.AddColumn(Resources.col_Creator, "CREATEUR", 1800);
        grid.AddColumn(Resources.col_Date, "DDSTDAT", 1000, "dd/mm/yy");
        grid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);//5
        grid.AddColumn(Resources.col_Site, "VSITNOM", 2000, "", 0, true);
        grid.AddColumn(Resources.col_dateRe, "DDSTDRE", 1000, "dd/mm/yy");
        grid.AddColumn(Resources.col_etat, "CETACOD", 400);
        grid.AddColumn(Resources.col_Statut, "STATUT", 1000);
        grid.AddColumn(Resources.col_Action, "TDSTPRE", 3500, "", 0, true);
        grid.AddColumn("Type", "CDSTTYPE", 700);
        grid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
        grid.AddColumn("NumST", "NSTFNUM", 0);
        grid.AddColumn(Resources.col_Actif, "Actif", 400);

        grid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void grid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      // Création de la clause SQL à partir des critères saisis
      try
      {
        string sWhere = "";
        string[] tCrit = new string[4];

        Cursor.Current = Cursors.WaitCursor;

        //  UPGRADE_INFO (#0501): The 'iAndPos' member isn't used anywhere in current application.
        if (mstrStatutDevis == "A") sWhere = $" AND TACT.NACTNUM = {MozartParams.NumAction}";
        else
        {
          // Récupération des critères si non vide
          if (txtCritNumDevis.Text.Trim() != "") tCrit[0] = $"NDSTNUM = {Convert.ToInt32(txtCritNumDevis.Text)}";
          if (txtCritNumDI.Text.Trim() != "") tCrit[1] = $"TACT.NDINNUM = {Convert.ToInt32(txtCritNumDI.Text)}";
          if (txtCritDate0.Text != "")
          {
            if (txtCritDate1.Text == "") tCrit[2] = $"DDSTDAT = '{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}'";
            else tCrit[2] = $"DDSTDAT BETWEEN '{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}' AND '{Convert.ToDateTime(txtCritDate1.Text).ToShortDateString()}'";
          }
          if (txtCritSTF.GetText().Trim() != "") tCrit[3] = $"VSTFNOM LIKE '%{txtCritSTF.GetText()}%'";

          for (int i = 0; i < 4; i++)
          {
            if (tCrit[i] != null) sWhere = $" AND  {tCrit[i]} {sWhere}";
          }
        }
        if (sWhere == "")
        {
          MessageBox.Show("Il faut renseigner au moins un filtre", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        string sSQL = $"SELECT  TDST.NDSTNUM, TACT.NDINNUM, TSTF.VSTFNOM, TINT.VINTNOM, TDST.DDSTDAT," +
                      $" TCLI.VCLINOM, TSIT.VSITNOM, TDST.DDSTDRE, TACT.CETACOD," +
                      $" replace(TDST.TDSTPRE, '<BR>',' ') as TDSTPRE," +
                      $" TACT.NACTNUM, TSTF.NSTFNUM, CDSTTYPE, " +
                      $" CASE VDSTSTA WHEN 'En cours' THEN CASE WHEN DDSTDRE - GETDATE() < 0 THEN 'Relance'" +
                      $" Else 'En cours' END ELSE 'Reçu' END AS STATUT," +
                      $" CASE TDST.CDSTACTIF WHEN 'O' THEN 'Oui' ELSE 'Non' END 'Actif'" +
                      $" ,(SELECT VPERNOM + ' ' + VPERPRE FROM TPER WHERE NPERNUM = NDSTCREA) as CREATEUR" +
                      $" FROM   TPER WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON TPER.NPERNUM = TAUT.NPERNUM INNER JOIN" +
                      $" TSTF WITH (NOLOCK) INNER JOIN TINT ON TSTF.NSTFNUM = TINT.NSTFNUM INNER JOIN" +
                      $" TDST WITH (NOLOCK) INNER JOIN TACT ON TDST.NACTNUM = TACT.NACTNUM INNER JOIN" +
                      $" TSIT WITH (NOLOCK) ON TACT.NSITNUM = TSIT.NSITNUM INNER JOIN" +
                      $" TCLI WITH (NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM ON TINT.NINTNUM = TDST.NINTNUM INNER JOIN" +
                      $" TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM ON TAUT.NCANNUM = TDIN.NDINCTE" +
                      $" Where  TPER.nPerNum = {MozartParams.UID}" +
                      $" AND TCLI.VSOCIETE = '{MozartParams.NomSociete}'";   //' App_Name() "

        sSQL += sWhere;
        sSQL += "ORDER BY NDSTNUM DESC";

        grid.LoadData(dtDev, MozartDatabase.cnxMozart, sSQL);
        grid.GridControl.DataSource = dtDev;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void txtALL_Enter(object sender, EventArgs e)
    {
      ((apiTextBox)sender).SelectionStart = 0;
      ((apiTextBox)sender).SelectionLength = 100;
    }

  }
}

