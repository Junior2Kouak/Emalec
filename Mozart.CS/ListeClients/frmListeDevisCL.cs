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
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmListeDevisCL : Form
  {
    public int miNumCL;
    public string mstrFiltreCli;

    DataTable dtDcl = new DataTable();

    public frmListeDevisCL() { InitializeComponent(); }

    private void frmListeDevisCL_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cbCritChaff.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CHAFF"), "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
        cbCritGroupe.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("GROUPE"), "IDGROUPE", "LIBGROUPE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        Grid.FilterBar = false;
        InitGrid();

        txtCritClient.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CLIENT"), "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);
        txtCritNumDevis.Focus();
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

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Cal.Tag = btn.Tag;

      string txtDate;
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

    private void frmListeDevisCL_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
        cmdFind_Click(null, null);
    }

    private void InitGrid()
    {
      Grid.AddColumn(MZCtrlResources.col_No, "NDCLNUM", 600);
      Grid.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 600);
      Grid.AddColumn(Resources.col_Date + " " + MZCtrlResources.col_Devis, "DDCLDAT", 800, "dd/mm/yy");
      Grid.AddColumn(Resources.col_Creator, "VPERNOM", 1100);
      Grid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1100);
      Grid.AddColumn(Resources.col_ctr, "NDINCTE", 600);
      Grid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1100);
      Grid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1300);
      Grid.AddColumn(Resources.col_RC2, "VSITREG", 500);
      Grid.AddColumn(Resources.col_coutHT, "NDCLHT", 700, "", 2);
      Grid.AddColumn(MZCtrlResources.col_Etat, "CETACOD", 400, "", 2);
      Grid.AddColumn(Resources.col_Technique, "VTECLIB", 1000);
      Grid.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1000);
      Grid.AddColumn(Resources.col_Objet, "TDCLOBJ", 4500);
      Grid.AddColumn(MZCtrlResources.col_Actif, "ACTIF", 600, "", 2);
      Grid.AddColumn(MZCtrlResources.col_Type, "CDEVISTYPE", 400, "", 2);
      Grid.AddColumn("% de réussite", "NDCLREUSSITEPOURC", 1000, "", 1);
      Grid.AddColumn(Resources.col_cmde, "VACTNUMCDE", 800);
      Grid.AddColumn("GMAO", "VACTNUMGMAO", 800);
      Grid.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      Grid.AddColumn(Resources.col_Date + " " + MZCtrlResources.col_Action, "DACTDATCRE", 0);
      Grid.AddColumn(Resources.col_Date + " " + Resources.col_cmde, "DACTDCDE", 600, "dd/mm/yy");
      Grid.AddColumn(Resources.col_Date + " " + MZCtrlResources.col_DI, "DDINDATHEUR", 850, "dd/MM/yy");
      Grid.AddColumn(MZCtrlResources.col_Devis + " en Régularisation", "REGUL", 850, "", 2);
      Grid.AddColumn(Resources.col_Urgence, "VURGLIB", 0, "", 1);

      Grid.InitColumnList();
      Grid.GridControl.DataSource = dtDcl;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      // passage des paramètres
      MozartParams.NumDi = Convert.ToInt32(row["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);

      switch (row["CDEVISTYPE"].ToString())
      {
        case "F":
          // Ancien devis client
          new frmDevisClient
          {
            miNumDevis = 0,
            miNumDevisCL = Convert.ToInt32(row["NDCLNUM"]),
            miNumAction = Convert.ToInt32(row["NACTNUM"]),
            miNumDI = Convert.ToInt32(row["NDINNUM"])
          }.ShowDialog();
          break;

        case "B":
        case "G":
          // Nouveau devis client
          new frmDevisClient2
          {
            miNumDevisCL = Convert.ToInt32(row["NDCLNUM"]),
            miNumAction = Convert.ToInt32(row["NACTNUM"]),
            miNumDI = Convert.ToInt32(row["NDINNUM"])
          }.ShowDialog();
          break;

        default:
          // Devis client prestation dans les autres cas
          new frmDevisClientPrestation
          {
            miNumAction = Convert.ToInt32(row["NACTNUM"]),
          }.ShowDialog();
          break;
      }

      //  rafraichissement du recordset
      Grid.Requery(dtDcl, MozartDatabase.cnxMozart);
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = Grid.GetFocusedDataRow();
        if (row == null) return;

        if (MessageBox.Show("Voulez-vous vraiment archiver ce devis ? (l'action du devis sera passée en archive si le statut le permet)", Program.AppTitle,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // Archive auto de l action lié au devis le 07/10/2010 par MC
          MozartDatabase.ExecuteNonQuery($"exec api_sp_ArchActSuiteArchDevis {row["NACTNUM"]}, {row["NDCLNUM"]}");
          Grid.Requery(dtDcl, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Grid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      bool bCritGroupe;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        dtDcl.Clear();

        Grid.FilterBar = true;
        //  txtCritClient.LostFocus

        List<string> tCrit = new List<string>(6) { "", "", "", "", "", "" };
        string sSql = "";
        string sWhere = "";

        //  Création de la clause SQL à partir des critères saisis,
        //  Récupération des critères si non vides
        if (Strings.Trim(txtCritNumDevis.Text) != "")
          tCrit[0] = $"NDCLNUM = {txtCritNumDevis.Text}";

        if (Strings.Trim(txtCritNumDI.Text) != "")
          tCrit[1] = $"TACT.NDINNUM = {txtCritNumDI.Text}";

        if (Strings.Trim(txtCritDate0.Text) != "")
          if (Strings.Trim(txtCritDate1.Text) == "")
            tCrit[2] = $"DDCLDAT BETWEEN '{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}' AND '{Convert.ToDateTime(txtCritDate0.Text).AddDays(1).ToShortDateString()}'";
          else
            tCrit[2] = $"DDCLDAT BETWEEN '{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}' AND '{Convert.ToDateTime(txtCritDate1.Text).ToShortDateString()}'";

        if (Strings.Trim(txtCritClient.GetText()) != "")
          tCrit[3] = $"VCLINOM LIKE '%{txtCritClient.GetText().Replace("'", "''")}%'";

        if (cbCritChaff.GetItemValue() != "")
          tCrit[4] = $"(VDINCHAFF IN (select vperadsi from TPER where (VPERNOM LIKE '%{cbCritChaff.GetItemValue().Replace("'", "''")}%') AND VSOCIETE = '{MozartParams.NomSociete}'))";

        bCritGroupe = (cbCritGroupe.GetItemValue() != "");
        if (bCritGroupe)
          tCrit[5] = $"(LIBGROUPE LIKE '%{cbCritGroupe.GetItemValue().Replace("'", "''")}%')";

        foreach (string item in tCrit)
          if (item != "")
            sWhere = $" AND {item}{sWhere}";

        sSql = "SELECT TDCL.NDCLNUM, TACT.NDINNUM, TDCL.DDCLDAT, TPER_1.VPERNOM + ' ' + TPER_1.VPERPRE as VPERNOM,TDIN.NDINCTE,";
        sSql += " TCLI.VCLINOM, TSIT.VSITNOM, TSIT.VSITREG, TDCL.NDCLHT, TACT.CETACOD,VTECLIB,R.VTYPECONTRAT,";
        sSql += " replace(TACT.VACTDES,'\\par','') as TDCLOBJ, TACT.NACTNUM, TCLI.NCLINUM,";
        sSql += " CASE TDCL.CDCLACTIF WHEN 'O' THEN 'Oui' ELSE 'Non' END 'ACTIF', TDCL.CDEVISTYPE, TACT.VACTNUMCDE, VDINCHAFF, DACTDCDE, ";
        sSql += " ISNULL(NDCLREUSSITEPOURC, 0) AS NDCLREUSSITEPOURC, TDIN.DDINDATHEUR, VACTNUMGMAO, DACTDATCRE, VURGLIB,";
          
        sSql += " CASE WHEN ISNULL(CDCLVALIDITE, '') = 'R' THEN 'O' ELSE 'N' END AS REGUL ";
        sSql += " FROM TACT WITH (NOLOCK) INNER JOIN";
        sSql += " TDCL WITH (NOLOCK) ON TACT.NACTNUM = TDCL.NACTNUM INNER JOIN";
        sSql += " TSIT WITH (NOLOCK) ON TACT.NSITNUM = TSIT.NSITNUM INNER JOIN";
        sSql += " TCLI WITH (NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM INNER JOIN";
        sSql += " TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM INNER JOIN";
        sSql += " TAUT WITH (NOLOCK) ON TDIN.NDINCTE = TAUT.NCANNUM INNER JOIN";
        sSql += " TREF_TYPECONTRAT R ON TDIN.NTYPECONTRAT = R.NTYPECONTRAT INNER JOIN";
        sSql += " TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM LEFT OUTER JOIN";
        sSql += " TPER TPER_1 WITH (NOLOCK) ON TDCL.NDCLQUICRE = TPER_1.NPERNUM INNER JOIN";
        sSql += " TREF_TEC WITH (NOLOCK) ON TREF_TEC.CTECCOD = TACT.CTECCOD";
        sSql += $" LEFT OUTER JOIN TREF_URG ON TREF_URG.CURGCOD = CDCLURGENCE AND TREF_URG.LANGUE = '{MozartParams.Langue}' ";
        if (bCritGroupe)
        {
          sSql += " LEFT OUTER JOIN TCAN AS C ON C.NCANNUM = TDIN.NDINCTE AND C.NCLINUM = TDIN.NCLINUM";
          sSql += " LEFT OUTER JOIN TPER AS p ON p.NPERNUM = C.NPERNUM";
          sSql += " LEFT OUTER JOIN TREF_GROUPE AS G WITH (NOLOCK) ON G.IDGROUPE = p.IDGROUPE";
        }
        sSql += " LEFT JOIN TACTCOMP ON TACTCOMP.NACTNUM = TACT.NACTNUM ";
        sSql += $" Where TPER.nPerNum = {MozartParams.UID} AND TREF_TEC.LANGUE = '{MozartParams.Langue}'" +
                $" and TCLI.VSOCIETE = '{MozartParams.NomSociete}' AND R.LANGUE = '{MozartParams.Langue}'";
        // Droit sur les nouveaux devis
        sSql += $" AND ('O' IN (SELECT CDROITVAL FROM TDROIT WHERE NMENUNUM=705 AND NPERNUM = {MozartParams.UID} AND VSOCIETE = '{MozartParams.NomSociete}') OR CDEVISTYPE IN ('F', 'P'))";

        sSql += sWhere + " ORDER BY NDCLNUM DESC";

        Grid.LoadData(dtDcl, MozartDatabase.cnxMozart, sSql);
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

    private void txtCrit_Enter(object sender, EventArgs e)
    {
      TextBox txtB = sender as TextBox;
      txtB.SelectionStart = 0;
      txtB.SelectionLength = 100;
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = Grid.GetFocusedDataRow();
        if (row == null) return;

        MozartParams.NumDi = Convert.ToInt32(row["NDINNUM"]);
        MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);

        new frmAddAction
        {
          mstrStatutDI = "M"
        }.ShowDialog();

        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;


      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}