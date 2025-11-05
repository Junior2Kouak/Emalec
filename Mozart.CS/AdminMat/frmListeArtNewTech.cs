using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
  public partial class frmListeArtNewTech : Form
  {
    public string msType = "";
    DataTable dtSB = new DataTable();
    DataTable dtSH = new DataTable();
    string msChamp;
    int miNbLigne;

    public frmListeArtNewTech()
    {
      InitializeComponent();
    }

    private void frmListeArtNewTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        // titre de la liste
        switch (msType)
        {
          case "CLIM":
            Label1.Text = Resources.txt_listOutillageTechChaufClim;
            // utilisation du bon champ dans la table TFOU selon le type de liste
            msChamp = "NFOUREAPNEWCLIMQTE";
            break;
          case "MULTI":
            Label1.Text = Resources.txt_listOutillageTechMulti;
            msChamp = "NFOUREAPNEWQTE";
            break;
          case "FAIBLE":
            Label1.Text = Resources.txt_listOutillageTechCourFaible;
            msChamp = "NFOUREAPNEWFAIBLEQTE";
            break;
          case "CHAUFF":
            Label1.Text = "Liste outillage Multi Emalec Academy";
            msChamp = "NFOUREAPNEWCHAUFF";
            break;
          case "PLOMBIER":
            Label1.Text = Resources.txt_listOutillageTechPlomb;
            msChamp = "NFOUREAPNEWPLOMBQTE";
            break;
          case "DIRICKX":
            Label1.Text = Resources.txt_listOutillageTechExtincIncendie;
            msChamp = "NFOUREAPNEWDIRICKXQTE";
            break;
          case "FORT":
            Label1.Text = "Liste outillage EI Emalec Academy";
            msChamp = "NFOUREAPNEWFORTQTE";
            break;
          case "COUV":
            Label1.Text = "Liste outillage EPI Emalec Academy";
            msChamp = "NFOUREAPNEWCOUVQTE";
            break;
          case "MULTIEI":
            Label1.Text = Resources.txt_listOutillageTechMultiEI;
            msChamp = "NFOUREAPNEWMULTIEIQTE";
            break;
          case "EPI":
            Label1.Text = Resources.txt_listOutillageTechEPI;
            msChamp = "NFOUREAPNEWEPIQTE";
            break;
          case "PHOTOVOLT": // SECOND OEUVRE
            Label1.Text = Resources.txt_listOutillageTech2ndOeuvre;
            msChamp = "NFOUREAPNEWPHOTOVOLTQTE";
            break;
          case "ATEX":
            Label1.Text = Resources.txt_listOutillageTechATEX;
            msChamp = "NFOUREAPNEWATEXQTE";
            break;
          case "VETEMENT":
            Label1.Text = "Liste outillage technicien Vêtements";
            msChamp = "NFOUREAPNEWVETEMENT";
            break;
        }
        this.Text = Label1.Text;

        // Pas de load au chargement
        //LoadApiGridH();
        LoadApiGridB();

        InitApiGridH();
        InitApiGridB();

        apiChoixFourn.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("GRPFOURNISSEUR"), "NSTFGRPNUM", "VSTFGRPNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        UpdateApitgrid();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadApiGridH()
    {
      string sFindCriteres = "";
      if (txtCritMat.Text != "")
        sFindCriteres += " AND VFOUMAT like  '%" + txtCritMat.Text.Replace("'", "''") + "%'";
      if (txtCritMarque.Text != "")
        sFindCriteres += " AND VFOUMAR like '%" + txtCritMarque.Text.Replace("'", "''") + "%'";
      if (txtCritType.Text != "")
        sFindCriteres += " AND VFOUTYP like '%" + txtCritType.Text.Replace("'", "''") + "%'";
      if (txtCritRef.Text != "")
        sFindCriteres += " AND VFOUREF like  '%" + txtCritRef.Text.Replace("'", "''") + "%'";
      if (apiChoixFourn.GetText() != "")
        sFindCriteres += " AND VSTFGRPNOM like '%" + apiChoixFourn.GetText().Replace("'", "''") + "%'";

      apiGridH.LoadData(dtSH, MozartDatabase.cnxMozart, $"select * from api_v_ListeFournituresReapproHaut WHERE {msChamp} is null {sFindCriteres} ORDER BY VFOUMAT");
      apiGridH.GridControl.DataSource = dtSH;


      if (apiGridH.dgv.FormatRules.Count == 0)
      {
        GridFormatRule GridFormatRule1 = new GridFormatRule();
        FormatConditionRuleValue FormatConditionRuleValue1 = new FormatConditionRuleValue();

        GridFormatRule1.ApplyToRow = true;
        GridFormatRule1.Column = apiGridH.dgv.Columns.ColumnByFieldName("CCODEG");
        GridFormatRule1.Name = "Format0";

        GridFormatRule1.Rule = FormatConditionRuleValue1;
        apiGridH.dgv.FormatRules.Add(GridFormatRule1);

        FormatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        FormatConditionRuleValue1.Appearance.Options.UseFont = true;
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
        FormatConditionRuleValue1.Expression = "[CCODEG] == 'O'";
        GridFormatRule1.Rule = FormatConditionRuleValue1;
        apiGridH.dgv.FormatRules.Add(GridFormatRule1);

      }

      UpdateApitgrid();
    }

    private void LoadApiGridB()
    {
      string sSQL = $"select VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT,  TFOUSTE.NFOUNUM, " +
                    $"(select min(FPUHT) from TSTFFOU where nfounum = TFOUSTE.NFOUNUM ) as FPUHT, { msChamp}, TFOUSTE.VSOCIETE " +
                    $"FROM  TFOU WITH (NOLOCK) INNER JOIN TFOUSTE WITH (NOLOCK) ON TFOU.NFOUNUM = TFOUSTE.NFOUNUM" +
                    $" WHERE  CFOUACTIF='O' AND TFOUSTE.VSOCIETE ='{MozartParams.NomSociete}' AND {msChamp} >= 0 ORDER BY VFOUMAT";

      apiGridb.LoadData(dtSB, MozartDatabase.cnxMozart, sSQL);
      apiGridb.GridControl.DataSource = dtSB;

      UpdateApitgrid();
    }

 

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGridH.GetFocusedDataRow();
        if (currentRow == null) return;
        ModuleData.ExecuteNonQuery($"UPDATE TFOUSTE SET {msChamp}=0 WHERE VSOCIETE='{MozartParams.NomSociete}' AND NFOUNUM={currentRow["NFOUNUM"]}");

        //LoadApiGridH();
        LoadApiGridB();

        UpdateApitgrid();
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

        if (MessageBox.Show(Resources.msg_confirm_fourniture_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.ExecuteNonQuery($"UPDATE TFOUSTE SET {msChamp}=Null WHERE VSOCIETE='{MozartParams.NomSociete}' AND NFOUNUM={row["NFOUNUM"]} ");

        LoadApiGridB();
        //LoadApiGridH();

        UpdateApitgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (txtCritMat.Text == "" && txtCritMarque.Text == "" && txtCritType.Text == "" && txtCritRef.Text == "" && apiChoixFourn.GetText() == "")
        {
          MessageBox.Show(Resources.msg_Au_moins_un_filtre_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Cursor.Current = Cursors.Default;
          return;
        }

        LoadApiGridH();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApiGridB()
    {
      try
      {
        apiGridb.AddColumn(Resources.col_materiel, "VFOUMAT", 7000, "", 0, true);
        apiGridb.AddColumn(Resources.col_marque, "VFOUMAR", 2000, "", 0, true);
        apiGridb.AddColumn(Resources.col_Type, "VFOUTYP", 2000, "", 0, true);
        apiGridb.AddColumn(Resources.col_reference, "VFOUREF", 1500, "", 0, true);
        apiGridb.AddColumn("PCB", "NFOUNBLOT", 600, "", 2);
        apiGridb.AddColumn("founum", "NFOUNUM", 0);
        apiGridb.AddColumn(Resources.col_four, "VSTFGRPNOM", 0);
        apiGridb.AddColumn(Resources.col_prixU, "FPUHT", 1500, "Currency", 1);
        apiGridb.AddColumn(Resources.col_Qte, msChamp, 600, "", 2);
        apiGridb.AddColumn(Resources.col_Societe, "VSOCIETE", 0);

        apiGridb.DelockColumn(msChamp);

        apiGridb.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApiGridH()
    {
      try
      {
        apiGridH.AddColumn(Resources.col_materiel, "VFOUMAT", 7000, "", 0, true);
        apiGridH.AddColumn(Resources.col_marque, "VFOUMAR", 2000, "", 0, true);
        apiGridH.AddColumn(Resources.col_Type, "VFOUTYP", 2000, "", 0, true);
        apiGridH.AddColumn(Resources.col_reference, "VFOUREF", 1500, "", 0, true);
        apiGridH.AddColumn("PCB", "NFOUNBLOT", 600, "", 2);
        apiGridH.AddColumn("founum", "NFOUNUM", 0);
        apiGridH.AddColumn(Resources.col_four, "VSTFGRPNOM", 2500, "", 0, true);
        apiGridH.AddColumn(Resources.col_prixU, "FPUHT", 1500, "Currency", 1);
        apiGridH.AddColumn(Resources.col_Qte, msChamp, 0, "", 2);
        apiGridH.AddColumn("CCODEG", "CCODEG", 0, "", 2);

        apiGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void UpdateApitgrid()
    {
      txtHT.Text = CalculerTHT();
    }

    private string CalculerTHT()
    {
      double total = 0;
      //pour toutes les lignes de la grid
      foreach (DataRow rowbis in dtSB.Rows)
        total += Utils.ZeroIfNull(rowbis[7]) * Utils.ZeroIfNull(rowbis[8]);

      miNbLigne = dtSB.Rows.Count;

      return Strings.FormatNumber(total, 2) + " €";
    }

    private void apiGridb_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      UpdateApitgrid();

      DataRow currentRow = apiGridb.GetFocusedDataRow();

      //On met à jour la base de donnée
      ModuleData.ExecuteNonQuery($"UPDATE TFOUSTE SET {msChamp}={e.Value} WHERE VSOCIETE='{MozartParams.NomSociete}' AND NFOUNUM={currentRow["NFOUNUM"]}");
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiGridb.GetFocusedDataRow();
        if (row == null) return;

        string sVPARVAL = ModuleData.RechercheParam(msChamp, MozartParams.NomSociete);

        string sSQL = $"select VFOUMAT, VFOUMAR, VFOUTYP, VFOUCON, {msChamp} as QTE from TFOU, TFOUSTE  " +
                      $"WHERE VSOCIETE='{MozartParams.NomSociete}' AND TFOU.NFOUNUM=TFOUSTE.NFOUNUM AND {msChamp} >= 0 and cfouactif='O' ORDER BY VFOUMAT";

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                                { "Num", "2" },
                                { "Titre", "" },
                                { "Date", Utils.BlankIfNull(sVPARVAL) } };
        switch (msType)
        {
          case "CLIM":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechChaufClim;
            break;
          case "MULTI":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechMulti;
            break;
          case "FAIBLE":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechCourFaible;
            break;
          case "CHAUFF":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechChauff;
            break;
          case "PLOMBIER":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechPlomb;
            break;
          case "DIRICKX":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechExtincIncendie;
            break;
          case "FORT":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechCourFort;
            break;
          case "COUV":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechPoste;
            break;
          case "EPI":
            TdbGlobal[2, 1] = Resources.txt_listOutillageTechEPI;
            break;
          default:
            TdbGlobal[2, 1] = Resources.txt_listOutillageTech;
            break;
        }

        //  frmBrowser f = new frmBrowser();
        //  f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageTech.rtf",
        //                  @"TListeOutillageTechOut.rtf",
        //                  TdbGlobal,
        //                  sSQL,
        //                  " (Impression consultation)",
        //                  "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridb.GetFocusedDataRow();
      if (row == null) return;

      string sTitre = "";
      switch (msType)
      {
        case "CLIM":
          sTitre = Resources.txt_listOutillageTechChaufClim;
          break;
        case "MULTI":
          sTitre = Resources.txt_listOutillageTechMulti;
          break;
        case "FAIBLE":
          sTitre = Resources.txt_listOutillageTechCourFaible;
          break;
        case "CHAUFF":
          sTitre = Resources.txt_listOutillageTechChauff;
          break;
        case "PLOMBIER":
          sTitre = Resources.txt_listOutillageTechPlomb;
          break;
        case "DIRICKX":
          sTitre = Resources.txt_listOutillageTechExtincIncendie;
          break;
        case "FORT":
          sTitre = Resources.txt_listOutillageTechCourFort;
          break;
        case "COUV":
          sTitre = Resources.txt_listOutillageTechPoste;
          break;
        case "EPI":
          sTitre = Resources.txt_listOutillageTechEPI;
          break;
        case "ATEX":
          sTitre = Resources.txt_listOutillageTechATEX;
          break;
        default:
          sTitre = Resources.txt_listOutillageTech;
          break;
      }

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                              { "Num", "2" },
                              { "Titre", sTitre } };

      string sSQL = $"select VFOUMAT, VFOUMAR, VFOUTYP, VFOUCON, {msChamp} as QTE, {miNbLigne} as NB from TFOU, TFOUSTE " +
                    $"WHERE VSOCIETE='{MozartParams.NomSociete}' AND TFOU.NFOUNUM=TFOUSTE.NFOUNUM AND {msChamp} >= 0 and CFOUACTIF='O' ORDER BY VFOUMAT";

      //frmBrowser f = new frmBrowser();
      //f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageTechEd.rtf",
      //                @"TListeOutillageTechEdOut.rtf",
      //                TdbGlobal,
      //                sSQL,
      //                " (Impression consultation)",
      //                "PREVIEW");
    }

    private void frmListeArtNewTech_KeyUp(object sender, KeyEventArgs e)
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