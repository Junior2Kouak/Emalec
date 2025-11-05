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
  public partial class frmListeContratsST : Form
  {
    public frmListeContratsST() { InitializeComponent(); }

    public long miNumST;
    public string mstrStatutContrat;
    public string sDatePlanif;
    public bool bFacture;

    DataTable dtCst = new DataTable();

    private void frmListeContratsST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitGrid();

        txtCritSTF.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("STF"), "NSTFNUM", "VSTFNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        txtCritCreateur.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("PERSONNEL"), "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        txtCritClient.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CLIENT"), "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 350, 550);

        if (mstrStatutContrat == "CS" || mstrStatutContrat == "CSP")
        {
          cmdFind_Click(null, null);
          txtCritNumContrat.Text = "";
          fraCriteres.Visible = false;
          txtCritSTF.Visible = false;
          txtCritCreateur.Visible = false;
          cmdNouveau.Visible = true;
          cmdCST.Visible = false;
          txtCritClient.Visible = false;
          cmdDetail.Visible = false;
        }
        else if (mstrStatutContrat == "CST")
        {
          cmdFind_Click(null, null);
          txtCritNumContrat.Text = "";
          fraCriteres.Visible = false;
          txtCritSTF.Visible = false;
          txtCritCreateur.Visible = false;
          cmdNouveau.Visible = false;
          cmdCST.Visible = true;
          txtCritClient.Visible = false;
          cmdDetail.Visible = false;
        }
        else
        {
          // on vient d'un sous-traitant (affichage du bouton de détail de la DI)
          cmdNouveau.Visible = false;
          cmdCST.Visible = false;
          cmdDetail.Visible = true;
        }
        Cursor = Cursors.Default;
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

    private void cmdNouveau_Click(object sender, EventArgs e)
    {
      // si le statut n'est pas O ou P ou W on ne peut pas créer de contrat
      if (bFacture)
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      DataRow curRow = Grid.GetFocusedDataRow();
      if (curRow == null) return;

      string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
      if (sVerifDocs != "")
      {
        if (curRow["CACTTYT"].ToString() == "I")
        {
          MessageBox.Show($"Les documents suivants sont manquants ou obsolètes :{sVerifDocs.Replace("#", "\r\n . ")}\r\nVous ne pouvez pas passer de contrat!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        else if (curRow["CACTTYT"].ToString() == "S")
        {
          // pour les STT maintenance , avertissement
          MessageBox.Show($"Les documents suivants sont manquants ou obsolètes :{sVerifDocs.Replace("#", "\r\n . ")}\r\n\r\nVous devez les demander au STT!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }

      MessageBox.Show(Resources.msg_NouveauContratActionAttention, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  écran de création de la demande
      new frmContratAutoST()
      {
        msTypeContrat = curRow["CCSTTYPE"].ToString() == "CS" ? "S" : "D", // S ou D selon le type de contrat
        mNumContratST = 0,
        mbDesactive = true,
        msDatePlanif = sDatePlanif
      }.ShowDialog();

      // on repasse a l'action
      Dispose();
    }

    private void cmdCST_Click(object sender, EventArgs e)
    {
      // si la DI est facturée on ne peut pas créer de contrat
      if (bFacture)
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      DataRow currentRow = Grid.GetFocusedDataRow();
      if (currentRow == null) return;

      string sVerifDocs = DetailstravauxUtils.VerificationDocStt(MozartParams.NumAction);
      if (sVerifDocs != "")
      {
        if (currentRow["CACTTYT"].ToString() == "I")
        {
          MessageBox.Show($"Les documents suivants sont manquants ou obsolètes : {sVerifDocs.Replace("#", "\r\n . ")}\r\nVous ne pouvez pas passer de contrat!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        else if (currentRow["CACTTYT"].ToString() == "I")
        {
          //pour les STT maintenance, avertissement
          MessageBox.Show($"Les documents suivants sont manquants ou obsolètes : {sVerifDocs.Replace("#", "\r\n . ")}\r\n\r\nVous devez les demander au STT!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }

      MessageBox.Show(Resources.msg_AttNouvContratSurAction, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      //  écran de création de la demande
      if (DetailstravauxUtils.DiAsDevisClientPrest(MozartParams.NumAction))
      {
        new frmContratPrest
        {
          msTypeContrat = "P",
          miNumContratST = 0,
          msDatePlanif = sDatePlanif,
          bDesactive = true // on desactive les autres contrats de l'action
        }.ShowDialog();
      }
      else
      {
        MessageBox.Show("Il n'y a pas de devis client prestation sur la DI, donc on ne peut pas faire de contrat prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      // on repasse à l'action
      Dispose();
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = Grid.GetFocusedDataRow();
      if (currentRow == null) return;

      //passage des paramètres
      MozartParams.NumDi = (int)Utils.ZeroIfNull(currentRow["ndinnum"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);

      if (currentRow["CCSTTYPE"].ToString() == "CS")
      {
        new frmContratAutoST
        {
          msTypeContrat = "S",
          mNumContratST = (int)Utils.ZeroIfNull(currentRow["NCSTNUM"]),
          mbDesactive = false // on ne desactive pas les autres contrats de l'action
        }.ShowDialog();
      }
      else if (currentRow["CCSTTYPE"].ToString() == "CSP")
      {
        new frmContratAutoST
        {
          msTypeContrat = "D",
          mNumContratST = (int)Utils.ZeroIfNull(currentRow["NCSTNUM"]),
          mbDesactive = false // on ne desactive pas les autres contrats de l'action
        }.ShowDialog();
      }
      else
      {
        new frmContratPrest
        {
          msTypeContrat = "P",
          miNumContratST = (int)Utils.ZeroIfNull(currentRow["NCSTNUM"]),
          bDesactive = false // on ne desactive pas les autres contrats de l'action
        }.ShowDialog();
      }

      Grid.Requery(dtCst, MozartDatabase.cnxMozart);
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      //suppression de la commande selectionnee
      DataRow currentRow = Grid.GetFocusedDataRow();
      if (currentRow == null) return;

      if (MessageBox.Show(Resources.msg_desactiverContrat, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes) ModuleData.SupprimerEnreg((long)Utils.ZeroIfNull(currentRow["NCSTNUM"]), "api_sp_SupprimerContratST", "@iNumContratST");

      Grid.Requery(dtCst, MozartDatabase.cnxMozart);
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      // suppression de la commandes selectionnée
      DataRow currentRow = Grid.GetFocusedDataRow();
      if (currentRow == null) return;

      if (MessageBox.Show(Resources.msg_reactiverContrat, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes) ModuleData.CnxExecute($"update TCST set CCSTACTIF='O' WHERE NCSTNUM={Utils.ZeroIfNull(currentRow["NCSTNUM"])}");

      Grid.Requery(dtCst, MozartDatabase.cnxMozart);
    }

    private void cmddoc_Click(object sender, EventArgs e)
    {
      DataRow currentRow = Grid.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmGestDocAdminSTF
      {
        miStfGrpNnum = (long)Utils.ZeroIfNull(currentRow["NSTFGRPNUM"]),
        mstrNom = Utils.BlankIfNull(currentRow["VSTFNOM"])
      }.ShowDialog();
    }

    private void InitGrid()
    {
      try
      {
        Grid.AddColumn(Resources.col_Contrat, "NCSTNUM", 750);
        Grid.AddColumn(Resources.col_DI, "NDINNUM", 750);
        Grid.AddColumn(Resources.col_ST, "VSTFNOM", 1400, "", 0, true);
        Grid.AddColumn(Resources.col_Contact, "VINTNOM", 1200);
        Grid.AddColumn(Resources.col_Creator, "VPERNOM", 1000);
        Grid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1000);
        Grid.AddColumn(Resources.col_Date, "DCSTDAT", 900, "dd/mm/yy");
        Grid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
        Grid.AddColumn(Resources.col_Site, "VSITNOM", 1500, "", 0, true);
        Grid.AddColumn(Resources.col_Depl, "VDEPLIB", 1200);
        Grid.AddColumn("Cde HT", "NCSTFOR", 1200, "Currency", 2);
        Grid.AddColumn("€ HT", "EHT", 1200, "Currency", 2);
        Grid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1200);
        Grid.AddColumn(Resources.col_dateRe, "DCSTDEL", 900, "dd/mm/yy");
        Grid.AddColumn(Resources.col_etat, "CETACOD", 300);
        Grid.AddColumn(Resources.col_fc, "CACTSTA", 340);
        Grid.AddColumn(Resources.col_Action, "TCSTPRE", 2900, "", 0, true);
        Grid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
        Grid.AddColumn("NumST", "NSTFNUM", 0);
        Grid.AddColumn(Resources.col_Actif, "CCSTACTIF", 800, "", 2);
        Grid.AddColumn("Type", "CCSTTYPE", 800, "", 2);
        Grid.AddColumn(Resources.col_ficheFour, "VLIB", 1200, "", 2);

        Grid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      // Création de la clause SQL à partir des critères saisis
      Cursor.Current = Cursors.WaitCursor;

      try
      {
        string[] tCrit = new string[9];
        //@CCSTTYPE = 0
        //@NACTNUM = 1
        //@NCSTNUM = 2,
        //@NDINNUM = 3,
        //@DCSTDAT_DEBUT = 4,
        //@DCSTDAT_FIN = 5,
        //@VSTFNOM = 6,
        //@NCSTCREA = 7,
        //@VCLINOM = 8


        //init crit
        tCrit[0] = "";
        tCrit[1] = "";
        tCrit[2] = "";
        tCrit[3] = "";
        tCrit[4] = "";
        tCrit[5] = "";
        tCrit[6] = "";
        tCrit[7] = "";
        tCrit[8] = "";

        //  UPGRADE_INFO (#0501): The 'iAndPos' member isn't used anywhere in current application.
        // sWhere = $" AND CCSTTYPE='P' AND TACT.NACTNUM = {MozartParams.NumAction}";
        if (mstrStatutContrat == "CST")
        {
          // sWhere = $" AND CCSTTYPE='P' AND TACT.NACTNUM = {MozartParams.NumAction}";
          tCrit[0] = "P";
          tCrit[1] = (string)MozartParams.NumAction.ToString();
        }
        else
        {
          if (mstrStatutContrat == "CS")
          {
            //sWhere = $" AND CCSTTYPE='S' AND TACT.NACTNUM = {MozartParams.NumAction}";
            tCrit[0] = "S";
            tCrit[1] = (string)MozartParams.NumAction.ToString();
          }
          else
          {
            if (mstrStatutContrat == "CSP")
            {
              //sWhere = $" AND CCSTTYPE='D' AND TACT.NACTNUM = {MozartParams.NumAction}";
              tCrit[0] = "D";
              tCrit[1] = (string)MozartParams.NumAction.ToString();
            }
            else
            {
              // Récupération des critères si non vide 
              if (txtCritNumContrat.Text.Trim() != "") tCrit[2] = $"{Convert.ToInt32(txtCritNumContrat.Text)}";
              if (txtCritNumDI.Text.Trim() != "") tCrit[3] = $"{Convert.ToInt32(txtCritNumDI.Text)}";

              if (txtCritDate0.Text != "") tCrit[4] = $"{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}";
              if (txtCritDate1.Text != "") tCrit[5] = $"{Convert.ToDateTime(txtCritDate1.Text).ToShortDateString()}";

              if (txtCritSTF.GetText() != "") tCrit[6] = $"{txtCritSTF.GetText().Replace("'", "''")}";
              if (txtCritCreateur.GetText() != "") tCrit[7] = $"{txtCritCreateur.GetItemData()}";
              if (txtCritClient.GetText() != "") tCrit[8] = $"{txtCritClient.GetText().Replace("'", "''")}";

            }
          }
        }

        if (tCrit[0] == "" && tCrit[1] == "" && tCrit[2] == "" && tCrit[3] == "" && tCrit[4] == ""
            && tCrit[5] == "" && tCrit[6] == "" && tCrit[7] == "" && tCrit[8] == "")
        {
          MessageBox.Show(Resources.msg_must_type_filter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Cursor = Cursors.Default;
          return;
        }



        string sSQL = ""; //= $"exec [api_sp_ListeContratsST] {}, {}, '{txtCritMat.Text.Replace("'", "''")}', '{txtCritMarque.Text.Replace("'", "''")}', '{txtCritType.Text.Replace("'", "''")}', '{txtCritRefFab.Text}', '{txtCritRefFou.Text}', '{txtCritId.Text}', {txtCritFour.GetItemData()}"



        sSQL = $"exec [api_sp_ListeContratsST] '{(tCrit[0] == "" ? "" : (string)tCrit[0])}', " +
                    $"{(tCrit[1] == "" ? "0" : tCrit[1])}, {(tCrit[2] == "" ? "0" : tCrit[2])}, {(tCrit[3] == "" ? "0" : tCrit[3])}, " +
                    $"'{(tCrit[4] == "" ? "" : tCrit[4])}', '{(tCrit[5] == "" ? "" : tCrit[5])}', '{(tCrit[6] == "" ? "" : tCrit[6])}', {(tCrit[7] == "" ? "0" : tCrit[7])}, " +
                    $"'{(tCrit[8] == "" ? "" : tCrit[8])}'";


        Grid.LoadData(dtCst, MozartDatabase.cnxMozart, sSQL);
        Grid.GridControl.DataSource = dtCst;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
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

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = !Frame4.Visible;
    }

    private void Grid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void txtCritNumContrat_Enter(object sender, EventArgs e)
    {
      txtCritNumContrat.SelectionStart = 0;
      txtCritNumContrat.SelectionLength = 100;
    }

    private void txtCritNumDI_Enter(object sender, EventArgs e)
    {
      txtCritNumDI.SelectionStart = 0;
      txtCritNumDI.SelectionLength = 100;
    }

    private void txtCritDate_Enter(object sender, EventArgs e)
    {
      int i = Convert.ToInt32(((apiTextBox)sender).Tag);
      if (i == 0)
        txtCritDate0.SelectionStart = 0;
      else
        txtCritDate1.SelectionLength = 100;
    }

    private void frmListeContratsST_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
    }

    private void cmdDetail_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = Grid.GetFocusedDataRow();
        if (currentRow == null) return;

        MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);

        new frmAddAction()
        {
          mstrStatutDI = "M",
        }.ShowDialog();

        // on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;

        Grid.Requery(dtCst, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

  }
}

