using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmListeDI2 : Form
  {
    //private DataTable dtDi = new DataTable();
    private TooltipGridTPE _tpe;

    public frmListeDI2()
    {
      InitializeComponent();
    }

    private void frmListeDI2_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // initialisation des combo
        cbCritClient.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CLIENT"), "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
        cbCritClient.NewValues = true;
        cbCritChaff.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CHAFF"), "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
        cbCritGroupe.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("GROUPE"), "IDGROUPE", "LIBGROUPE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        apiTGridListeInter1.InitTGrid();

        _tpe = new TooltipGridTPE(apiTGridListeInter1, toolTipController1);

        InfosBoutons();

        // application des préférences utilisateurs sur la liste des dI
        if (File.Exists($@"\\emalec.com\MOZART\LayoutListesMozart\ListeDI{MozartParams.UID}.xml"))
          apiTGridListeInter1.GridControl.DefaultView.RestoreLayoutFromXml($@"\\emalec.com\MOZART\LayoutListesMozart\ListeDI{MozartParams.UID}.xml");
      }
      catch (Exception ex)
      {
        Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}");
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "C",
      }.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
      apiTGridListeInter1.Requery();
      Cursor.Current = Cursors.Default;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridListeInter1.GetFocusedDataRow();
      if (null == row) return;

      MozartParams.NumDi = (int)row["NDINNUM"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "M",
        miNumClient = (int)row["NCLINUM"] //NL, le 03/05/2017, besoin du NCLINUM
      }.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      // FGA le 06/02/24 on arrête de faire la mise aà jour à chaque fois
      //GridT.Requery(dtDi, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdDIweb_Click(object sender, EventArgs e)
    {
      new frmListeDIweb().ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGridListeInter1.Requery();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDeciWeb_Click(object sender, EventArgs e)
    {
      new frmListeDeciWeb().ShowDialog();
    }

    private void cmdDIMail_Click(object sender, EventArgs e)
    {
      new frmListeDIMail().ShowDialog();
    }

    private void cmdDevWeb_Click(object sender, EventArgs e)
    {
      new frmListeDevisWeb().ShowDialog();
    }

    private void cmdDevWebST_Click(object sender, EventArgs e)
    {
      new frmListeDevisWebST().ShowDialog();
    }

    private void CmdGDM_Click(object sender, EventArgs e)
    {
      new frmDiGDM().ShowDialog();
    }

    private void cmdDiSynergee_Click(object sender, EventArgs e)
    {
      new frmDiSynergee().ShowDialog();
    }

    private void CmdTabletSTF_Click(object sender, EventArgs e)
    {
      new frmListeDataTabletSTF().ShowDialog();
    }

    private void cmdDiKimoce_Click(object sender, EventArgs e)
    {
      new frmDiGeronimmo().ShowDialog();
    }

    private void cmdSites_Click(object sender, EventArgs e)
    {
      new frmListeInfoSites().ShowDialog();
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      // Récupération des critères si non vide
      StringBuilder sWhere = new StringBuilder(1000);
      if (txtCritNumDI.Text.Trim() != "") { sWhere.Append($" AND NDINNUM = {txtCritNumDI.Text}"); }
      if (txtCritDate0.Text.Trim() != "") { sWhere.Append($" AND DDINDATHEUR = '{txtCritDate0.Text}'"); }
      if (cbCritClient.GetText().Trim() != "") { sWhere.Append($" AND VCLINOM = '{cbCritClient.GetText().Replace("'", "''")}'"); }
      if (cbCritSite.GetText().Trim() != "") { sWhere.Append($" AND VSITNOM LIKE '%{cbCritSite.GetText().Replace("'", "''")}%'"); }
      if (txtCritNumSite.Text.Trim() != "") { sWhere.Append($" AND NSITNUE LIKE '%{txtCritNumSite.Text}%'"); }
      if (txtCritObs.Text.Trim() != "") { sWhere.Append($" AND VACTOBS LIKE '%{txtCritObs.Text.Replace("'", "''")}%'"); }
      if (cbCritChaff.GetText().Trim() != "") { sWhere.Append($" AND VDINCHAFF LIKE '%{cbCritChaff.GetText().Replace("'", "''")}%'"); }
      if (txtCritEnseigne.Text.Trim() != "") { sWhere.Append($" AND VSITENSEIGNE LIKE '%{txtCritEnseigne.Text.Replace("'", "''")}%'"); }
      if (cbCritGroupe.GetText().Trim() != "") { sWhere.Append($" AND LIBGROUPE LIKE '%{cbCritGroupe.GetText().Replace("'", "''")}%'"); }

      if (sWhere.Length == 0)
      {
        MessageBox.Show("Il faut rentrer au moins un critère de filtre (dans la barre bleu)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      string sqlFilter = CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGridListeInter1.dgv.ActiveFilterCriteria);
      if (sqlFilter != "")
      {
        sWhere.Append($" AND {sqlFilter}");
      }

      // Commence par " AND ", on enlève
      string newExpression = sWhere.ToString().Substring(5);

      CriteriaOperator criterias = CriteriaOperator.Parse(newExpression);
      newExpression = " AND " + new MyDataSetWhereGenerator().Process(criterias);
      new frmlisteDIArchiv(apiTGridListeInter1.dgv, newExpression).ShowDialog();
    }

    private void cmdCdeWeb_Click(object sender, EventArgs e)
    {
      new frmlisteDICmdWeb().ShowDialog();
    }

    private void cmdRelance_Click(object sender, EventArgs e)
    {
      new frmListeDiRelance().ShowDialog();
    }

    private void Check1_CheckedChanged(object sender, EventArgs e)
    {
      if (Check1.Checked)
        apiTGridListeInter1.dgv.ActiveFilterString = "CPRECOD <> 'P'";
      else
        apiTGridListeInter1.dgv.ActiveFilterString = "";
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame1.Visible = true;
    }

    private void cmdCode_Click(object sender, EventArgs e)
    {
      Frame2.Visible = true;
    }

    private void frmListeDI2_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        CmdFind_Click(null, null);
    }

    private void cmdEtatSTT_Click(object sender, EventArgs e)
    {
      new frmEtatActionSTT().ShowDialog();
    }

    private void cmdDate0_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtCritDate0.Text, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));

    }

    DateTime _curDate = DateTime.MinValue;
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtCritDate0.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }

    private void InfosBoutons() // remplace vb6 :Timer1_Timer 
    {
      try
      {
        //Const sColorAlertJaune As Long = &H80FFFF
        //Const sColorAlertRouge As Long = &HFF

        using (SqlDataReader reader = ModuleData.ExecuteReader("api_sp_InfosBoutons"))
        {
          if (reader.Read())
          {
            // Traitement des demandes web
            //  cmdDIweb.BackColor = IIf(rsI("DIW") >= 1, sColorAlertRouge, &H8000000F)
            cmdDIweb.BackColor = Utils.ZeroIfNull(reader["DIW"]) >= 1 ? Color.Red : MozartColors.ColorH8000000F;
            //
            // Traitement des décisions web
            //  cmdDeciWeb.BackColor = IIf(rsI("WDEC") >= 1, sColorAlertRouge, &H8000000F)
            cmdDeciWeb.BackColor = Utils.ZeroIfNull(reader["WDEC"]) >= 1 ? Color.Red : MozartColors.ColorH8000000F;
            //  
            // Traitement des Devis web
            //  cmdDevWeb.BackColor = IIf(rsI("WDEVIS") >= 1, sColorAlertJaune, &H8000000F)
            cmdDevWeb.BackColor = Utils.ZeroIfNull(reader["WDEVIS"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des Devis web ST
            //  cmdDevWebST.BackColor = IIf(rsI("WDEVISSTT") >= 1, sColorAlertJaune, &H8000000F)
            cmdDevWebST.BackColor = Utils.ZeroIfNull(reader["WDEVISSTT"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des DI Mail
            //  cmdDIMail.BackColor = IIf(rsI("DIMAIL") >= 1, sColorAlertRouge, &H8000000F)
            cmdDIMail.BackColor = Utils.ZeroIfNull(reader["DIMAIL"]) >= 1 ? Color.Red : MozartColors.ColorH8000000F;
            //
            // Traitement des Infos Sites
            //  cmdSites.BackColor = IIf(rsI("INFOS") >= 1, sColorAlertJaune, &H8000000F)
            cmdSites.BackColor = Utils.ZeroIfNull(reader["INFOS"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des messages Web ST
            //  CmdMessSTF.BackColor = IIf(rsI("MSGST") >= 1, sColorAlertJaune, &H8000000F)
            CmdMessSTF.BackColor = Utils.ZeroIfNull(reader["MSGST"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des données tablet
            //  cmdTablet.BackColor = IIf(rsI("TABLET") >= 1, sColorAlertJaune, &H8000000F)
            cmdTablet.BackColor = Utils.ZeroIfNull(reader["TABLET"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des données tablet STF
            //  CmdTabletSTF.BackColor = IIf(rsI("TABLETSTF") >= 1, sColorAlertJaune, &H8000000F)
            CmdTabletSTF.BackColor = Utils.ZeroIfNull(reader["TABLETSTF"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des actiosn en retour qualité
            //  CmdListeRetQual.BackColor = IIf(rsI("RETQUAL") >= 1, sColorAlertJaune, &H8000000F)
            CmdListeRetQual.BackColor = Utils.ZeroIfNull(reader["RETQUAL"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
            //  
            // Traitement des DI GDM 17/08/2016
            //  CmdGDM.BackColor = IIf(rsI("DIGDM") >= 1, sColorAlertRouge, &H8000000F)
            CmdGDM.BackColor = Utils.ZeroIfNull(reader["DIGDM"]) >= 1 ? Color.Red : MozartColors.ColorH8000000F;
            //  
            // Traitement des DI SYNERGEE 02/02/2021
            //  cmdDiSynergee.BackColor = IIf(rsI("DISYN") >= 1, sColorAlertRouge, &H8000000F)
            cmdDiSynergee.BackColor = Utils.ZeroIfNull(reader["DISYN"]) >= 1 ? Color.Red : MozartColors.ColorH8000000F;
            //    
            // Traitement des DI Geronimmo/Kimoce 11/12/2024
            cmdDiGeronimmo.BackColor = Utils.ZeroIfNull(reader["DIKIM"]) >= 1 ? Color.Red : MozartColors.ColorH8000000F;
            //  
            // Traitement des tablettes Filiales
            //  cmdActionCopieFiliale.BackColor = IIf(rsI("ActionsTABLET") >= 1, sColorAlertJaune, &H8000000F)
            cmdActionCopieFiliale.BackColor = Utils.ZeroIfNull(reader["ActionsTABLET"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;

            // Traitement des Documents STT (pps, contrats) 
            cmdPPS.BackColor = Utils.ZeroIfNull(reader["DOC"]) >= 1 ? Color.Yellow : MozartColors.ColorH8000000F;
          }
        }
      }
      //catch (Exception ex) { MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
      catch (Exception ex)
      {
        Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}");
      }
    }

    private void GridT_DoubleClickE(object sender, EventArgs e)
    {
      apiTGridListeInter1.Enabled = false;
      cmdModifier.PerformClick();
      apiTGridListeInter1.Enabled = true;
    }

    private void CmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        StringBuilder sql = new StringBuilder(1000);

        sql.Append("SELECT * FROM api_v_ListeDI3");
        sql.Append($" WHERE CETACOD <> 'S' and not(CETACOD = 'E' and (CACTSTA = 'F' or CACTSTA = 'N'))");

        // Récupération des critères si non vide
        if (txtCritNumDI.Text.Trim() != "") sql.Append($" AND NDINNUM = {txtCritNumDI.Text}");
        if (txtCritDate0.Text.Trim() != "") sql.Append($" AND CAST(CONVERT(VARCHAR(10),HACTION,103) as DATETIME) = '{txtCritDate0.Text}'");
        //  if (cbCritClient.GetText().Trim() != "") sql.Append($" AND VCLINOM LIKE '%{cbCritClient.GetText().Replace("'", "''")}%'");
        // FGA le 12/02/24 demande de Sylvie
        
        if (cbCritClient.GetText().Trim() != "") sql.Append($" AND VCLINOM = '{cbCritClient.GetText().Replace("'", "''")}'");
        //if (cbCritClient.GetText().Trim() != "") sql.Append($" AND NCLINUM = {cbCritClient.GetItemData()}");

        if (cbCritSite.GetText().Trim() != "") sql.Append($" AND VSITNOM LIKE '%{cbCritSite.GetText().Replace("'", "''")}%'");
        if (txtCritNumSite.Text.Trim() != "") sql.Append($" AND NSITNUE LIKE '%{txtCritNumSite.Text}%'");
        if (txtCritObs.Text.Trim() != "") sql.Append($" AND VACTOBS LIKE '%{txtCritObs.Text.Replace("'", "''")}%'");
        if (cbCritChaff.GetText().Trim() != "") sql.Append($" AND VDINCHAFF LIKE '%{cbCritChaff.GetText().Replace("'", "''")}%'");
        if (txtCritEnseigne.Text.Trim() != "") sql.Append($" AND VSITENSEIGNE LIKE '%{txtCritEnseigne.Text.Replace("'", "''")}%'");
        if (cbCritGroupe.GetText().Trim() != "") sql.Append($" AND LIBGROUPE LIKE '%{cbCritGroupe.GetText().Replace("'", "''")}%'");

        sql.Append(" ORDER BY CASE WHEN CPRECOD = 'D' THEN CASE WHEN CETACOD = 'O' THEN 1 WHEN CETACOD = 'P' THEN 2 WHEN CETACOD = 'A' THEN 3 ELSE 100 END");
        sql.Append(" ELSE CASE WHEN CETACOD = 'O' THEN 4 WHEN CETACOD = 'D' THEN 5 WHEN CETACOD = 'A' THEN 6 ELSE 100 END END");

        apiTGridListeInter1.LoadWithQuery(sql.ToString());

        if (ChkReclamOnly.Checked) apiTGridListeInter1.dgv.ActiveFilterString = "CACTRECLAM = 'O'";
      }
      catch (Exception ex)
      {
        Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}");
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    // vb6 : SetTag n'est jamais appellé donc GetTag toujours vide => SetClient inutile
    private void cbCritSite_cboClick(object sender, EventArgs e)
    {
      // sélectionner le texte
      foreach (Control item in (sender as apiCombo).Controls)
      {
        if (item is TextEdit)
          (item as TextEdit).SelectAll();
      }
    }

    private void txtCritObs_Enter(object sender, EventArgs e)
    {
      txtCritObs.SelectAll();
    }

    private void txtCritNumSite_Enter(object sender, EventArgs e)
    {
      txtCritNumSite.SelectAll();
    }

    private void txtCritNumDI_Enter(object sender, EventArgs e)
    {
      txtCritNumDI.SelectAll();
    }

    private void txtCritDate0_Enter(object sender, EventArgs e)
    {
      txtCritDate0.SelectAll();
    }

    private void cbCritClient_cboClick(object sender, EventArgs e)
    {
      foreach (Control item in (sender as apiCombo).Controls)
      {
        if (item is TextEdit)
          (item as TextEdit).SelectAll();
      }
    }

    private void CmdMessSTF_Click(object sender, EventArgs e)
    {
      new frmListeMessSTF().ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Frame1.Visible = false;
    }

    private void Command3_Click(object sender, EventArgs e)
    {
      Frame2.Visible = false;
    }

    private void cmdTablet_Click(object sender, EventArgs e)
    {
      new frmListeDataTablet().ShowDialog();
    }

    private void CmdListeRetQual_Click(object sender, EventArgs e)
    {
      new frmListeActRetQualite().ShowDialog();
    }

    private void ChkReclamOnly_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkReclamOnly.Checked) apiTGridListeInter1.dgv.ActiveFilterString = "CACTRECLAM = 'O'";
      else apiTGridListeInter1.dgv.ActiveFilterString = "";
    }

    //'************************************************************************************************
    //'On génére un fichier html contenant tous les points du recordset filtre
    //'************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private void CmdCarteSiteFiltre_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGridListeInter1.dgv.DataRowCount > 300)
        {
          MessageBox.Show("Il y a trop de sites à afficher (Maxi 300 sites sur une carte)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        string sMarkerList = "";
        string sDataHTML = "";
        for (int i = 0; i < apiTGridListeInter1.dgv.DataRowCount; i++)
        {
          sDataHTML = ReturnGeoLocSiteToHTML((int)Utils.ZeroIfNull(apiTGridListeInter1.dgv.GetRowCellValue(i, "NSITNUM")));
          if (sMarkerList.IndexOf(sDataHTML) == -1) sMarkerList += sDataHTML + Environment.NewLine;
        }
        // on copie le fichier modele dans mes documents   
        string cheminIn = $"{MozartParams.CheminModeles}{ModuleMain.CodePays("FR")}TCarteSiteFiltre.html";
        string cheminOut = $@"{MozartParams.CheminUtilisateurMozart}TCarteSiteFiltre.html";
        File.Copy(cheminIn, cheminOut, true);
        string[] lignes = File.ReadAllLines(cheminIn);

        using (StreamWriter outStream = new StreamWriter(cheminOut, false))
        {
          foreach (string l in lignes)
          {
            outStream.WriteLine(l.Replace("#MARKERSLISTE#", sMarkerList));
          }
        }

        // apercu du fichier
        new frmBrowser
        {
          msStartingAddress = cheminOut
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        Utils.ShowError(ex, $"{MethodBase.GetCurrentMethod().Name} dans {this.Name}");
      }
    }

    private string ReturnGeoLocSiteToHTML(int nsitnum)
    {
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec [api_sp_ReturnGeoLocSiteCliForHTML] {nsitnum}"))
      {
        if (reader.Read()) return Utils.BlankIfNull(reader["VSITE"]);
      }
      return "";
    }

    private void cmdActionCopieFiliale_Click(object sender, EventArgs e)
    {
      new frmSuiviTabletFiliales().ShowDialog();
    }

    private void CmdCreateDevisTech_Click(object sender, EventArgs e)
    {
      new frmListeDevisTechnicien().ShowDialog();
    }

    private void cbCritClient_Leave(object sender, EventArgs e)
    {
      cbCritSite.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("SITE", cbCritClient.GetItemData()), "NSITNUM", "VSITNOM",
                      new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
      cbCritSite.NewValues = true;
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      // enregistrement des préférences de la liste des DI
      apiTGridListeInter1.GridControl.DefaultView.SaveLayoutToXml($@"\\emalec.com\MOZART\LayoutListesMozart\ListeDI{MozartParams.UID}.xml");
      Dispose();
    }

    private void frmListeDI2_FormClosing(object sender, FormClosingEventArgs e)
    {
      // enregistrement des préférences de la liste des DI
      if (null != apiTGridListeInter1.GridControl.DefaultView)
        apiTGridListeInter1.GridControl.DefaultView.SaveLayoutToXml($@"\\emalec.com\MOZART\LayoutListesMozart\ListeDI{MozartParams.UID}.xml");
    }

    private void cmdReinitColonnes_Click(object sender, EventArgs e)
    {
      // application de la liste par défaut 
      apiTGridListeInter1.GridControl.DefaultView.RestoreLayoutFromXml($@"\\emalec.com\MOZART\LayoutListesMozart\ListeDI0.xml");
    }

    private void cmdPPS_Click(object sender, EventArgs e)
    {
      new frmListeDocumentsAvalider().ShowDialog();
    }

    private void chkDep_CheckedChanged(object sender, EventArgs e)
    {
      if (chkDep.Checked) apiTGridListeInter1.dgv.ActiveFilterString = "CACTSUIVICLI = 'O'";
      else apiTGridListeInter1.dgv.ActiveFilterString = "";
    }

    private void cmdDiGeronimmo_Click(object sender, EventArgs e)
    {
      new frmDiGeronimmo().ShowDialog();
    }

    private void btnReinitFilter_Click(object sender, EventArgs e)
    {
      chkDep.Checked = false;
      ChkReclamOnly.Checked = false;
      Check1.Checked = false;

      apiTGridListeInter1.dgv.ClearColumnsFilter();
    }

		private void btnReinitColonne_Click(object sender, EventArgs e)
		{
      // application de la liste par défaut 
      apiTGridListeInter1.GridControl.DefaultView.RestoreLayoutFromXml($@"\\emalec.com\MOZART\LayoutListesMozart\ListeDI0.xml");
    }
  }
}

public class MyDataSetWhereGenerator : DataSetWhereGenerator, ICriteriaVisitor<string>
{
  string ICriteriaVisitor<string>.Visit(OperandValue theOperand)
  {
    if (theOperand.Value is DateTime)
    {
      DateTime datetimeValue = (DateTime)theOperand.Value;
      string dateTimeFormatPattern;
      if (datetimeValue.TimeOfDay == TimeSpan.Zero)
        dateTimeFormatPattern = "dd-MM-yyyy";
      else
        dateTimeFormatPattern = "dd-MM-yyyy HH:mm:ss";
      return "'" + datetimeValue.ToString(dateTimeFormatPattern, CultureInfo.InvariantCulture) + "'";
    }
    return (new DataSetWhereGenerator() as ICriteriaVisitor<string>).Visit(theOperand);
  }
}
