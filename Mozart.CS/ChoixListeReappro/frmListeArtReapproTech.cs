using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeArtReapproTech : Form
  {
    public string msType = "";

    DataTable dtH = new DataTable();
    DataTable dtB = new DataTable();
    private int iNbLigne = 0;
    private string sChamp = "";

    public frmListeArtReapproTech() { InitializeComponent(); }

    private void frmListeArtReapproTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Label1.Text = Resources.txt_liste_art_reappro_stock_veh + " ";
        //  ' utilisation du bon champ dans la table TFOU selon le type de liste
        switch (msType)
        {
          case "CLIM":
            Label1.Text = Resources.txt_liste_art_reappro_stock_veh_clim;
            sChamp = "NFOUREAPCLIMQTE";
            break;
          case "MULTI":
            Label1.Text = Resources.txt_liste_art_reappro_stock_veh_multi;
            sChamp = "NFOUREAPQTE";
            break;
          case "FAIBLE":
            Label1.Text = Resources.txt_liste_art_reappro_stock_veh_faible;
            sChamp = "NFOUREAPFAIBLEQTE";
            break;
          case "PLOMBIER":
            Label1.Text = Resources.txt_liste_art_reappro_stock_veh_plombier;
            sChamp = "NFOUREAPPLOMBQTE";
            break;
          case "DIRICKX":
            Label1.Text += Resources.col_Extinction_incendie;
            sChamp = "NFOUREAPDIRICKXQTE";
            break;
          case "ED":
            Label1.Text = "Liste reappro tech Handyman";
            sChamp = "NFOUREAPEDQTE";
            break;
          case "FORT":
            Label1.Text = Resources.txt_liste_art_reappro_stock_veh_fort;
            sChamp = "NFOUREAPFORTQTE";
            break;
          case "COUV":  //Liste reappro tech vetement de travail
            Label1.Text += "";
            sChamp = "NFOUREAPCOUVQTE";
            break;
          case "ARGEDIS":
            Label1.Text += " ARGEDIS";
            sChamp = "NFOUREAPARGEDISQTE";
            break;
          case "LAPOSTE":
            Label1.Text += " LA POSTE";
            sChamp = "NFOUREAPGUNNEBOQTE";
            break;
          case "MULTIEI":
            Label1.Text += " Multitech/Extinction Incendie";
            sChamp = "NFOUREAPMULTIEIQTE";
            break;
          case "VIS":
            Label1.Text += " Visserie/Fixation";
            sChamp = "NFOUREAPVISQTE";
            break;
          case "PHOTOVOLT":
            Label1.Text += " Photovoltaique";
            sChamp = "NFOUREAPPHOTOVOLTQTE";
            break;
          case "CROWN":
            Label1.Text += " CROWN HEIGHTS";
            sChamp = "NFOUREAPCROWNQTE";
            break;
          case "MULTISERV_FOU":
            Label1.Text += " MULTISERVICES";
            sChamp = "NFOUREAPMULTISERVQTE";
            break;
          default:
            break;
        }

        this.Text = Label1.Text;

        string sSQL = "select VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT,  TFOUSTE.NFOUNUM, (select min(FPUHT/FPUNITE) from TSTFFOU where nfounum = TFOUSTE.NFOUNUM ) as FPUHT, ";
        sSQL += sChamp + " , TFOUSTE.VSOCIETE FROM  TFOU WITH (NOLOCK) INNER JOIN TFOUSTE WITH (NOLOCK) ON TFOU.NFOUNUM = TFOUSTE.NFOUNUM";
        sSQL += " WHERE CFOUACTIF = 'O' AND TFOUSTE.VSOCIETE = '" + MozartParams.NomSociete + "' AND " + sChamp + " >= 0 ORDER BY VFOUMAT";

        apiGridb.LoadData(dtB, MozartDatabase.cnxMozart, sSQL);
        InitapiGridB();
        apiGridb.GridControl.DataSource = dtB;
        apiGridH.dgv.OptionsSelection.MultiSelect = true;

        InitapiGridH(false);

        apiChoixFourn.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("GRPFOURNISSEUR"), "NSTFGRPNUM", "VSTFGRPNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        txtHT.Text = CalculerTHT();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        string sFindCriteres = "";

        if (txtCritMat.Text == "" && txtCritMarque.Text == "" && txtCritType.Text == "" && txtCritRef.Text == "" && apiChoixFourn.GetText() == "")
        {
          MessageBox.Show(Resources.msg_Au_moins_un_filtre_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        //  Recherche des critères de recherche
        if (txtCritMat.Text != "")
          sFindCriteres += " AND VFOUMAT like '%" + txtCritMat.Text.Replace("'", "''") + "%'";
        if (txtCritMarque.Text != "")
          sFindCriteres += " AND VFOUMAR like '%" + txtCritMarque.Text.Replace("'", "''") + "%'";
        if (txtCritType.Text != "")
          sFindCriteres += " AND VFOUTYP like '%" + txtCritType.Text.Replace("'", "''") + "%'";
        if (txtCritRef.Text != "")
          sFindCriteres += " AND VFOUREF like '%" + txtCritRef.Text.Replace("'", "''") + "%'";
        if (apiChoixFourn.GetText() != "")
          sFindCriteres += " AND VSTFGRPNOM like '%" + apiChoixFourn.GetText().Replace("'", "''") + "%'";

        string sSql = $"select * from api_v_ListeFournituresReapproHaut WHERE {sChamp} is null {sFindCriteres} ORDER BY VFOUMAT";
        apiGridH.LoadData(dtH, MozartDatabase.cnxMozart, sSql);
        apiGridH.GridControl.DataSource = dtH;

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdListe_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtB.Rows.Count == 0) return;
        string colTitre = "";

        string sSql = $"select VFOUMAT, VFOUMAR, VFOUTYP, VFOUCON, {sChamp} as QTE, {iNbLigne} as NB from TFOU, TFOUSTE  WHERE VSOCIETE = App_Name() " +
                      $"AND TFOU.NFOUNUM = TFOUSTE.NFOUNUM AND {sChamp} >= 0 ORDER BY VFOUMAT";

        switch (msType)
        {
          case "CLIM":
            colTitre = "Demande de réappro technicien chauffage climatisation";
            break;
          case "MULTI":
            colTitre = "Demande de réappro technicien multitechnique";
            break;
          case "FAIBLE":
            colTitre = "Demande de réappro technicien courant faible";
            break;
          case "PLOMBIER":
            colTitre = "Demande de réappro technicien plomberie";
            break;
          case "DIRICKX":
            colTitre = "Demande de réappro technicien extinction incendie";
            break;
          case "ED":
            colTitre = "Demande de réappro technicien Handyman";
            break;
          case "FORT":
            colTitre = "Liste outillage technicien courant fort";
            break;
          case "COUV":
            colTitre = "Demande de réappro technicien Vêtements de travail";
            break;
          case "ARGEDIS":
            colTitre = "Demande de réappro technicien ARGEDIS";
            break;
          case "LAPOSTE":
            colTitre = "Demande de réappro technicien LA POSTE";
            break;
          case "MULTIEI":
            colTitre = "Demande de réappro technicien Multitechnique / EI";
            break;
          case "VIS":
            colTitre = "Demande de réappro technicien Visserie / Fixation";
            break;
          case "PHOTOVOLT":
            colTitre = "Demande de réappro technicien PhotoVoltaique";
            break;
          case "MULTISERV_FOU":
            colTitre = "Demande de réappro technicien multiservices";
            break;
        }

        string[,] TdbGlobal = new string[,] { { "Copie", "ORIGINAL" },
                                            { "Num", "2" },
                                            { "Titre", colTitre },
                                            { "Date", DateTime.Now.ToShortDateString() } };

        //  frmBrowser f = new frmBrowser();
        //  f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageTechEd.rtf",
        //                  @"TListeOutillageTechEdOut.rtf",
        //                  TdbGlobal,
        //                  sSql,
        //                  " (Impression liste reappro)",
        //                  "PREVIEW");
        //}
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
        bool bNeedRequery = false;
        foreach (int item in apiGridH.dgv.GetSelectedRows())
        {
          bNeedRequery = true;
          DataRow row = (DataRow)apiGridH.dgv.GetDataRow(item);
          ModuleData.ExecuteNonQuery($"UPDATE TFOUSTE SET {sChamp} = 0 WHERE VSOCIETE = App_Name() AND NFOUNUM = {row["NFOUNUM"]}");
          apiGridH.dgv.UnselectRow(item);
        }
        if (bNeedRequery)
        {
          apiGridH.Requery(dtH, MozartDatabase.cnxMozart);
          apiGridb.Requery(dtB, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiGridb.GetFocusedDataRow();
        if (row == null) return;

        if (MessageBox.Show(Resources.msg_confirm_fourniture_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.CnxExecute("UPDATE TFOUSTE SET " + sChamp + " = Null WHERE VSOCIETE = App_Name() AND NFOUNUM = " + row["NFOUNUM"]);
          apiGridH.Requery(dtH, MozartDatabase.cnxMozart);
          apiGridb.Requery(dtB, MozartDatabase.cnxMozart);
          txtHT.Text = CalculerTHT();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitapiGridB()
    {
      apiGridb.AddColumn(Resources.col_materiel, "VFOUMAT", 6500);
      apiGridb.AddColumn(Resources.col_marque, "VFOUMAR", 2000);
      apiGridb.AddColumn(Resources.col_Type, "VFOUTYP", 2000);
      apiGridb.AddColumn(Resources.col_reference, "VFOUREF", 2000);
      apiGridb.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600, "", 2);
      apiGridb.AddColumn(Resources.col_prixU, "FPUHT", 1500, "Currency", 1);
      apiGridb.AddColumn(Resources.col_Qte, sChamp, 600, "", 2);
      apiGridb.AddColumn("founum", "NFOUNUM", 0);
      apiGridb.AddColumn("Societe", "VSOCIETE", 0);

      apiGridb.InitColumnList();

      apiGridb.DelockColumn(sChamp);
    }

    private void InitapiGridH(bool bStyle)
    {
      apiGridH.AddColumn(Resources.col_materiel, "VFOUMAT", 6500);
      apiGridH.AddColumn(Resources.col_marque, "VFOUMAR", 2000);
      apiGridH.AddColumn(Resources.col_Type, "VFOUTYP", 2000);
      apiGridH.AddColumn(Resources.col_reference, "VFOUREF", 2000);
      apiGridH.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600, "", 2);
      apiGridH.AddColumn("founum", "NFOUNUM", 0);
      apiGridH.AddColumn(Resources.col_four, "VSTFGRPNOM", 2500);
      apiGridH.AddColumn(Resources.col_prixU, "FPUHT", 600, "Currency", 1);
      apiGridH.AddColumn("QTE", sChamp, 0, "", 2);
      //apiGridH.AddColumn("Code", "CCODEG", 0);

      //  apiGridH.AddCellTip "VFOUMAT", &HFDF0DA
      //  apiGridH.AddCellTip "VFOUMAR", &HFDF0DA
      //  apiGridH.AddCellTip "VFOUTYP", &HFDF0DA
      //  apiGridH.AddCellTip "VFOUREF", &HFDF0DA
      //  apiGridH.AddCellTip "VSTFGRPNOM", &HFDF0DA

      apiGridH.InitColumnList();
    }

    private void apiGridH_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        if (apiGridH.dgv.GetDataRow(e.RowHandle)["CCODEG"].ToString().ToUpper() == "O")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
      }
    }

    private void apiGridb_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //On met à jour la base de données
      DataRow currentRow = apiGridb.GetFocusedDataRow();
      ModuleData.ExecuteNonQuery($"UPDATE TFOUSTE SET {sChamp} = {e.Value} WHERE NFOUNUM = {currentRow["NFOUNUM"]}");

      txtHT.Text = CalculerTHT();
    }

    private void apiGridb_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.Column.Name == sChamp)
      {
        e.Appearance.ForeColor = Color.Black;
        e.Appearance.BackColor = Color.White;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private string CalculerTHT()
    {
      double ht = 0;
      foreach (DataRow row in dtB.Rows)
        ht += Utils.ZeroIfNull(row["FPUHT"]) * Utils.ZeroIfNull(row[8]);
      return ht.ToString("0.00 €");
    }

    private void frmListeArtReapproTech_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
        cmdFind_Click(null, null);
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}