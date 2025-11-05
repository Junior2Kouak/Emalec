using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestFourniture : Form
  {
    //0: mode normal et 1 mode fournitures seulemement avec fiche produit dangereux
    public int iMode;

    bool bPrem = false;
    // sql de listage des fournitures
    string sqlFindCriteres;
    private DataTable dtFour = new DataTable();

    public frmGestFourniture()
    {
      InitializeComponent();
    }

    private void frmGestFourniture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        cmdExportBricomaint.Visible = false;

        ModuleData.RemplirCombo(cboCritSerie, $"select O.NCFOCOD,CCFOCOD from TREF_CFO O inner join TDROITSERIEARTICLE D ON O.NCFOCOD=D.NCFOCOD where O.BCFOACTIF = 1 AND DROIT='O' " +
                                              $"AND NPERNUM={MozartParams.UID} AND langue= '{MozartParams.Langue}' order by CCFOCOD");
        cboCritSerie.ValueMember = "NCFOCOD";
        cboCritSerie.DisplayMember = "CCFOCOD";
        cboCritSerie.SelectedIndex = 0;

        string lSql = "SELECT DISTINCT TSTFGRP.NSTFGRPNUM, VSTFGRPNOM FROM TSTFGRP INNER JOIN TSTFFOU ON TSTFFOU.NSTFGRPNUM = TSTFGRP.NSTFGRPNUM ";
        lSql += "INNER JOIN TFOU ON TFOU.NFOUNUM = TSTFFOU.NFOUNUM WHERE(NSTFGRPTYPFO = 1) AND TFOU.CFOUACTIF = 'O' ORDER BY VSTFGRPNOM";
        apiChoixFourn.Init(MozartDatabase.cnxMozart, lSql, "NSTFGRPNUM", "VSTFGRPNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);
        apiChoixFourn.NewValues = true;

        if (iMode == 1)
        {
          this.Text = Resources.txt_liste_produits_dangereux;
          Label1.Text = Resources.txt_liste_produits_dangereux;

          cmdFind_Click(null, null);
        }

        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void CmdConsultFOMag_Click(object sender, EventArgs e)
    {
      new FrmFournituresConsultMag().ShowDialog();
    }


    private void CmdWeb_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (!bPrem)
        {
          InitapiGridWeb();

          bPrem = true;
        }

        framUtil.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitapiGridWeb()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        apiTGridW.AddColumn("Série", "vfouser", 2500);
        apiTGridW.AddColumn("Matérial", "vfoumat", 6500);
        apiTGridW.AddColumn("Emalec", "NBEMALEC", 1000, "", 2);
        apiTGridW.AddColumn("SCS", "NBSCS", 1000, "", 2);
        apiTGridW.AddColumn("Equipage", "NBEQUIPAGE", 1000, "", 2);
        apiTGridW.AddColumn("Total", "TOTAL", 1000, "", 2);

        apiTGridW.InitColumnList();

        DataTable dtW = new DataTable();
        apiTGridW.LoadData(dtW, MozartDatabase.cnxMozart, "exec api_sp_StatUtilFourniture");
        apiTGridW.GridControl.DataSource = dtW;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdF_Click(object sender, EventArgs e)
    {
      framUtil.Visible = false;
    }

    // recharge la liste des fournitures
    private void RechageFournitures()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        if (dtFour.Columns.Count == 0) return;
        apiTGrid1.Requery(dtFour, MozartDatabase.cnxMozart);
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
        Cursor.Current = Cursors.WaitCursor;

        if (0 == cboCritSerie.SelectedIndex && txtCritMat.Text == "" && txtCritMarque.Text == "" && txtCritType.Text == "" &&
            txtCritRef.Text == "" && apiChoixFourn.GetItemValue() == "" && txtCritRefFou.Text == "" && txtCritId.Text == "" && iMode != 1)
        {
          MessageBox.Show(Resources.msg_Au_moins_un_filtre_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // recherche des critères de recherche
        string sFindCriteres = $@"'{(txtCritMat.Text == "" ? "T" : txtCritMat.Text.Replace("'", "''"))}',"
                             + $@"'{(txtCritMarque.Text == "" ? "T" : txtCritMarque.Text.Replace("'", "''"))}',"
                             + $@"'{(txtCritType.Text == "" ? "T" : txtCritType.Text.Replace("'", "''"))}',"
                             + $@"'{(txtCritRef.Text == "" ? "T" : txtCritRef.Text.Replace("'", "''"))}',"
                             + $@"'{(apiChoixFourn.GetItemValue() == "" ? "T" : apiChoixFourn.GetItemValue().Replace("'", "''"))}',"
                             + $@"'{(txtCritRefFou.Text == "" ? "T" : txtCritRefFou.Text.Replace("'", "''"))}',"
                             + $@"{cboCritSerie.GetItemData()},"
                             + $@"{(txtCritId.Text == "" ? "0" : txtCritId.Text)}";

        if (iMode == 1)
        {
          sqlFindCriteres = $"exec api_sp_ListeDesFournituresFichesDanger {sFindCriteres}, 1";
        }
        else
        {
          sqlFindCriteres = $"exec api_sp_ListeDesFournitures {MozartParams.UID}, {sFindCriteres}";
        }

        apiTGrid1.LoadData(dtFour, MozartDatabase.cnxMozart, sqlFindCriteres);
        apiTGrid1.GridControl.DataSource = dtFour;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      new frmDetailsFourniture()
      {
        mstrStatut = "C",
        miNumFour = 0
      }.ShowDialog();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      new frmDetailsFourniture()
      {
        mstrStatut = "M",
        mbStatutValidation = true,
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      RechageFournitures();
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmGestFournitureArch().ShowDialog();

      RechageFournitures();
    }

    //'**************************************************************************************************************
    //'Permet de visualier les mouvements de stock de cette fourniture
    //'**************************************************************************************************************
    private void CmdVisuMvtStock_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      int NFOUNUM = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
      int lQTEActuel = 0, lQTECde = 0;
      GetQTEStockForMvt(NFOUNUM, ref lQTEActuel, ref lQTECde);

      new frmStockMouvements()
      {
        miFouNum = (int)Utils.ZeroIfNull(row["NFOUNUM"]),
        miNumStock = 0,
        mstrType = "FOURNITURE",
        miVFOUMAT = Utils.BlankIfNull(row["VFOUMAT"]),
        miNQTEACTUEL = lQTEActuel,
        miNQTECDE = lQTECde
      }.ShowDialog();
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      int nb = apiTGrid1.dgv.SelectedRowsCount;
      if (0 == nb)
        return;

      if (MessageBox.Show(Resources.msg_desactiver_articles, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        try
        {
          int[] handleRows = apiTGrid1.dgv.GetSelectedRows();
          foreach (int hr in handleRows)
          {
            DataRow row = apiTGrid1.dgv.GetDataRow(hr);
            int numfour = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
            int iSup = Utils.bSuppOK(numfour);

            if (iSup == 1)
            {
              //'si fourniture web marchand
              string sSup = Utils.TestFouEnStockExistInStock(numfour);
              if (sSup == "OK")
              {
                Cursor.Current = Cursors.WaitCursor;
                MozartDatabase.ExecuteNonQuery($"exec api_sp_DeactiverArt {numfour}");
                // ' traitement des cas ou la fourniture est dans la liste de stock client (sans etre cochée comme gérée)
                //' on supprime de TSTOCKARTCLI et de TSTOCKARTCLISIT pour tous les clients
                MozartDatabase.ExecuteNonQuery($"delete from TSTOCKARTCLISIT where  NFOUNUM={numfour}");
                MozartDatabase.ExecuteNonQuery($"delete from TSTOCKARTCLI where  NFOUNUM={numfour}");

              }
              else
              {
                MessageBox.Show($"{Resources.msg_pas_archiver_fourniture} {Utils.BlankIfNull(row["VFOUMAT"])} {Resources.msg_nombre_diff_zero}({sSup})!!", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
            }
            else if (iSup == 2)
            {

            }
            // TODO autre cas?

            dtFour.Rows.Remove(row);
          }

          RechageFournitures();
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
        finally { Cursor.Current = Cursors.Default; }
      }
    }

    private void GestionBoutonValidation()
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (MozartDatabase.ExecuteScalarInt($"exec api_sp_NbArticleAValider {MozartParams.UID}") > 0)
        {
          cmdValidation.BackColor = Color.Red;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValidation_Click(object sender, EventArgs e)
    {
      new frmGestFournituresValidation().ShowDialog();
    }

    private void frmGestFourniture_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
        cmdFind_Click(null, null);
    }

    bool m_bStyle = false;
    private void apiTGrid1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CCODEG"].ToString() == "O")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
        if (!m_bStyle)
        {
          if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "R")
          {
            e.Appearance.ForeColor = Color.Black;
            e.Appearance.BackColor = MozartColors.colorHDBE6FD;
            e.HighPriority = true;
          }
          else if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "V")
          {
            e.Appearance.ForeColor = Color.Black;
            e.Appearance.BackColor = MozartColors.colorHEEFFE3;
            e.HighPriority = true;
          }
        }
      }
    }

    private void InitApiTgrid(bool bStyle = false)
    {
      m_bStyle = bStyle;

      apiTGrid1.AddColumn(Resources.col_ID, "NFOUNUM", 550);
      apiTGrid1.AddColumn(Resources.col_Serie, "VFOUSER", 1000);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 4000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_Prix, "FPUHT", 700, "0.00", 2);
      apiTGrid1.AddColumn(Resources.col_unite, "FPUNITE", 500, "", 2);
      apiTGrid1.AddColumn(Resources.col_unite, "VFOUUNITE", 600, "", 2);
      apiTGrid1.AddColumn("Prix Contrat Cadre", "VPRIXCONTRATCADRE", 400, "", 2);
      apiTGrid1.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1500);
      apiTGrid1.AddColumn(Resources.col_RefFO, "VSTFFOUREFCLI", 1000, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_Pays, "VPAYSNOM", 800);
      apiTGrid1.AddColumn(Resources.col_Condit, "VFOUCON", 700, "", 2, true);// celltype
      apiTGrid1.AddColumn(Resources.col_UA, "NFOUNBLOT", 500, "", 2);
      apiTGrid1.AddColumn(Resources.col_UV, "NFOUUV", 500, "", 2);
      apiTGrid1.AddColumn("12M", "NFOUNBUTIL", 550, "", 2);
      apiTGrid1.AddColumn(Resources.col_gest_stock, "CCODEG", 550, "", 2);
      apiTGrid1.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 600, "", 2);
      apiTGrid1.AddColumn(Resources.col_stk_emalec, "BGESTSTOCKEMALEC", 600, "", 2);
      apiTGrid1.AddColumn(Resources.col_recyclage, "NFOUTAR", 600, "", 2);
      apiTGrid1.AddColumn(Resources.col_fds, "VFOUFDSFILE", 0);
      apiTGrid1.AddColumn(Resources.col_Code, "CODE", 0);
      apiTGrid1.AddColumn(Resources.col_NumFourn, "NSTFGRPNUM", 0, "", 0, true);// celltype
      apiTGrid1.AddColumn(Resources.col_valid, "BFOUVALID", 0);

      //' VL Spécifique MPM
      apiTGrid1.AddColumn("TypeId", "VFOUTYPEID", 1000);
      apiTGrid1.AddColumn("N°Plan", "VFOUNUMPLAN", 1000);
      apiTGrid1.AddColumn("Ind plan", "VFOUINDICE", 400);
      apiTGrid1.AddColumn("Criticité", "VFOUCRITICITE", 600);
      apiTGrid1.AddColumn("Rechange", "VFOUPIECERECHANGE", 900);

      apiTGrid1.AddColumn("D Crea", "DFOUDCRE", 1000, "dd/MM/yy");
      apiTGrid1.AddColumn("Crea", "VFOUQUICRE", 1000);
      apiTGrid1.AddColumn(Resources.col_modif, "VFOUQUIMOD", 1000);
      apiTGrid1.AddColumn(Resources.col_dmodif, "DFOUDPR", 1000, "dd/MM/yy");
      apiTGrid1.AddColumn(Resources.col_derniere_util, "DFOULASTUSE", 1000, "dd/MM/yy");
      apiTGrid1.AddColumn("WebMarchand", "BRICOCACTIF", 0);

      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VFOUCLI", 1000);

      apiTGrid1.InitColumnList();

      apiTGrid1.dgv.OptionsView.ColumnAutoWidth = false;
    }

    private void CmdPrixCli_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      new frmGestFourniturePrixClient()
      {
        miFouNum = Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();
    }

    //'********************************************************************************************************
    //'Permet de récupérer les qte en stock de la fournitures
    //'********************************************************************************************************
    private void GetQTEStockForMvt(int nfounum, ref int lQTEActuel, ref int lQTECde)
    {
      lQTEActuel = 0;
      lQTECde = 0;
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlDataReader reader = MozartDatabase.ExecuteReader($"SELECT ISNULL(NFOUQTESTOCK,0) AS NFOUQTESTOCK, ISNULL(QTEATTENDUE,0) AS QTEATTENDUE " +
                                    $"FROM api_v_ListeFournituresStockMagasin WHERE NSTOCKLIEU = 0 AND NFOUNUM = {nfounum}"))
        {
          if (reader.Read())
          {
            lQTEActuel = (int)Utils.ZeroIfNull(reader["NFOUQTESTOCK"]);
            lQTECde = (int)Utils.ZeroIfNull(reader["QTEATTENDUE"]);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdCopieFou_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row)
        return;

      new frmDetailsFourniture()
      {
        mstrStatut = "COPIE",
        mbStatutValidation = true,
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      RechageFournitures();
    }

    private void cmdExportBricomaint_Click(object sender, EventArgs e)
    {
      //new BRICOMAINT().Sh
    }
    //Private Sub cmdExportBricomaint_Click()
    //
    //  VerifMOZARTNET
    //  
    //  OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " " & "BRICOMAINT", vbNormalFocus
    //End Sub
    //

    private void txtCritId_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar < (char)48 || e.KeyChar > (char)57)
      {
        e.Handled = true;
      }
    }

    private void CmdGestCFO_Click(object sender, EventArgs e)
    {
      new FrmGestSerieFO().ShowDialog();
    }

    private void cmdIntegrationIndustrie_Click(object sender, EventArgs e)
    {
      CommonDialog1.Filter = "Fichiers Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
      if (CommonDialog1.ShowDialog() == DialogResult.OK)
      {
        IntegrationExcel(CommonDialog1.FileName);
      }
    }

    DataTable dtImport;
    private void IntegrationExcel(string importFile)
    {
      Microsoft.Office.Interop.Excel.Application OBJxL = new Microsoft.Office.Interop.Excel.Application(); //applicaton Excel

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        //  ouverture du fichier   utilisation de l'objet feuille d'Excel
        OBJxL.Workbooks.Open(importFile, Missing.Value, true);
        Microsoft.Office.Interop.Excel.Worksheet objSh = (Microsoft.Office.Interop.Excel.Worksheet)OBJxL.ActiveSheet;

        //  Remplissage de la datatable locale avec les données du fichier Excel de forme 1 (4 colonnes simples)
        CreerRsLocalForm2(objSh);

        OBJxL.Workbooks.Item[1].Close();
        OBJxL.Quit();
        objSh = null;
        OBJxL = null;
        int iNumFou = 0;

        // Intégration des données dans la base
        foreach (DataRow row in dtImport.Rows)
        {
          //Vérfier si la fourniture existe déjà dans la série Industrie
          bool bExiste = true;
          if (row["ID"].ToString() != "0")
          {
            using (SqlDataReader reader1 = MozartDatabase.ExecuteReader($"Select Count(NFOUNUM) From TFOU Where VFOUSER = 'INDUSTRIE' AND NFOUNUM = {row["ID"].ToString()}"))
            {
              if (reader1.Read())
                bExiste = Utils.ZeroIfNull(reader1[0]) != 0;
            }
          }

          if (bExiste)
          {
            using (SqlCommand cmd = new SqlCommand("api_sp_CreationFourniture", MozartDatabase.cnxMozart))
            {
              cmd.CommandType = CommandType.StoredProcedure;
              SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

              //  liste des paramètres
              cmd.Parameters["@iNum"].Value = row["ID"];
              cmd.Parameters["@serie"].Value = row["Serie"];
              cmd.Parameters["@iserie"].Value = 53;      // INDUSTRIE
              cmd.Parameters["@mat"].Value = row["Designation"];
              cmd.Parameters["@Marque"].Value = row["Marque"];
              cmd.Parameters["@Type"].Value = "";
              cmd.Parameters["@ref"].Value = row["Reference"];
              cmd.Parameters["@poids"].Value = 0;
              cmd.Parameters["@cond"].Value = "";
              cmd.Parameters["@nsscfonum"].Value = 66;// MECANIQUE
              // VL Spécifique MPM
              cmd.Parameters["@vfoutypeid"].Value = row["TypeId"];
              cmd.Parameters["@vfounumplan"].Value = row["NumPlan"];
              cmd.Parameters["@vfouindice"].Value = row["IndicePlan"];
              cmd.Parameters["@vfoucriticite"].Value = row["Critique"];
              cmd.Parameters["@vfoupiecerechange"].Value = "NON";

              cmd.ExecuteNonQuery();
              iNumFou = Convert.ToInt32(cmd.Parameters[0].Value); ;
            }
          }

          if (!bExiste)
            row["InfoRetour"] = $"NOT EXIST:{row["InfoRetour"]}";
          else if (row["InfoRetour"].ToString() == "0" || iNumFou == 0)
            row["Designation"] = $"ERROR: {row["Designation"]}";
          else
            row["InfoRetour"] = $"NEW:{iNumFou}";

          // Création du prix ('1€') chez le fournisseur ('FICTIF BE')
          MozartDatabase.ExecuteNonQuery($"Insert into TSTFFOU (NSTFGRPNUM, NFOUNUM, FPUHT, FPUNITE, NQUICREE, DQUIMOD)" +
                                     $" Values (38373, {iNumFou}, 1, 1, {MozartParams.UID}, '{DateTime.Now}')");
        }

        // TODO : Debug.Print RecordsetToCSV(rsImport) ?
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void CreerRsLocalForm2(Microsoft.Office.Interop.Excel.Worksheet objSh)
    {
      dtImport = new DataTable();

      dtImport.Columns.Add("InfoRetour", Type.GetType("System.String"));
      dtImport.Columns.Add("ID", Type.GetType("System.String"));
      dtImport.Columns.Add("Serie", Type.GetType("System.String"));
      dtImport.Columns.Add("TypeId", Type.GetType("System.String"));
      dtImport.Columns.Add("NumPlan", Type.GetType("System.String"));
      dtImport.Columns.Add("IndicePlan", Type.GetType("System.String"));
      dtImport.Columns.Add("Qte", Type.GetType("System.Int32"));
      dtImport.Columns.Add("Critique", Type.GetType("System.String"));
      dtImport.Columns.Add("Designation", Type.GetType("System.String"));
      dtImport.Columns.Add("Marque", Type.GetType("System.String"));
      dtImport.Columns.Add("Reference", Type.GetType("System.String"));

      //  ' lecture des données
      int i = 7;
      object val;
      object val2 = (string)(objSh.Cells[i, 2] as Microsoft.Office.Interop.Excel.Range).Value;
      object val3 = (string)(objSh.Cells[i, 3] as Microsoft.Office.Interop.Excel.Range).Value;
      while (null != val2 && (string)val2 != "" &&
              null != val3 && (string)val3 != "")
      {
        DataRow newrow = dtImport.NewRow();
        newrow["InfoRetour"] = i;
        val = (objSh.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["ID"] = (null == val || "" == val.ToString()) ? "0" : val.ToString();
        newrow["Serie"] = val2;
        newrow["TypeId"] = val3;
        val = (objSh.Cells[i, 4] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["NumPlan"] = (null == val) ? "" : val.ToString();
        val = (objSh.Cells[i, 5] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["IndicePlan"] = (null == val) ? "" : val.ToString();
        val = (objSh.Cells[i, 6] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["QTE"] = (null == val || "" == val.ToString()) ? 0 : Convert.ToInt32(val.ToString());
        val = (objSh.Cells[i, 7] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["Critique"] = (null == val) ? "" : val.ToString();
        val = (objSh.Cells[i, 8] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["Designation"] = (null == val) ? "" : val.ToString();
        val = (objSh.Cells[i, 9] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["Marque"] = (null == val) ? "" : val.ToString();
        val = (objSh.Cells[i, 10] as Microsoft.Office.Interop.Excel.Range).Value;
        newrow["Reference"] = (null == val) ? "" : val.ToString();

        dtImport.Rows.Add(newrow);
        i++;
        val2 = (objSh.Cells[i, 2] as Microsoft.Office.Interop.Excel.Range).Value;
        val3 = (objSh.Cells[i, 3] as Microsoft.Office.Interop.Excel.Range).Value;
      }
    }
  }
}
