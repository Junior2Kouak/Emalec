using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGammeClientNew : Form
  {
    public string mstrStatut;
    public long miNumTrame;

    private long inumGE;
    private string sFichier = "";
    private string adorsVFICHIER = "";

    DataTable dtTrames = new DataTable();

    public frmGammeClientNew()
    {
      InitializeComponent();
    }

    private void frmGammeClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //   combo des clients
        apicboClient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500);
        if (mstrStatut == "V")
        {
          cmdValider.Enabled = false;
          cmdRechercher.Enabled = false;
          Label14.Text = Resources.msg_visu_trame_client;

          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeClient " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              apicboClient.SetText(dr[2].ToString());
              inumGE = Convert.ToInt64(dr["Num"]);

              txtGamme.Text = dr["GE"].ToString();
              txtAE.Text = "GE" + Strings.Format(inumGE, "000");
              txtTitre.Text = dr["VGAMTYPE"].ToString();

              chkLiaisonStock.Checked = Utils.BlankIfNull(dr["BSTOCKLIE"].ToString()) == "true";
              adorsVFICHIER = dr["VFICHIER"].ToString();

              // en mode visu => on change le type pour utiliser Text
              cboContrat.DropDownStyle = ComboBoxStyle.Simple;
              cboContrat.Text = Utils.BlankIfNull(dr["VTYPECONTRAT"]);
              cboContrat.Enabled = false;

              apicboClient.Enabled = false;

              cmdFichier.Enabled = false;

              cmdCocherTC.Visible = false;
              cmdDecocherTC.Visible = false;

              GVGAMCLI.OptionsBehavior.ReadOnly = true;
              GVGAMCLI.OptionsBehavior.Editable = false;

              if (Utils.BlankIfNull(dr["VFICHIER"].ToString()) != "")
                WebBrowser1.Navigate(dr["VFICHIER"].ToString());
            }
            dr.Close();
          }

          LoadTramesEMALEC();

        }
        else if (mstrStatut == "Mod")
        {
          Label14.Text = Resources.msg_modif_gamme_client;
          cmdValider.Enabled = true;
          cmdRechercher.Enabled = false;

          //    ouverture du recordset
          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeClient " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              apicboClient.SetText(dr[2].ToString());
              inumGE = Convert.ToInt64(dr["Num"]);

              txtGamme.Text = dr["GE"].ToString();
              txtAE.Text = "GE" + Strings.Format(inumGE, "000");
              txtTitre.Text = dr["VGAMTYPE"].ToString();

              chkLiaisonStock.Checked = Utils.BlankIfNull(dr["BSTOCKLIE"].ToString()) == "true";

              RemplirCboTypeContrat();    // combo des types
              cboContrat.Text = Utils.BlankIfNull(dr["VTYPECONTRAT"]);

              apicboClient.Enabled = false;

              if (Utils.BlankIfNull(dr["VFICHIER"].ToString()) != "")
              {
                sFichier = dr["VFICHIER"].ToString();
                WebBrowser1.Navigate(dr["VFICHIER"].ToString());
              }
            }
            dr.Close();
          }
          LoadTramesEMALEC();
        }
        else if (mstrStatut == "M")
        {
          //    copie de la gamme
          Label14.Text = Resources.msg_copie_gamme_client;
          cmdValider.Enabled = true;

          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeClient " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              apicboClient.Text = dr[2].ToString();
              inumGE = Convert.ToInt64(dr["Num"]);

              txtGamme.Text = dr["GE"].ToString();

              txtAE.Text = "GE" + Strings.Format(inumGE, "000");
              txtTitre.Text = dr["VGAMTYPE"].ToString();

              chkLiaisonStock.Checked = Utils.BlankIfNull(dr["BSTOCKLIE"].ToString()) == "true";

              RemplirCboTypeContrat();    // combo des types
              cboContrat.Text = Utils.BlankIfNull(dr["VTYPECONTRAT"]);

              apicboClient.Enabled = true;
            }
            dr.Close();
          }
          LoadTramesEMALEC();
        }
        else  // création
        {
          txtTitre.Text = "";
          Label14.Text = Resources.msg_create_gamme_client;
          cmdValider.Enabled = true;
        }

        //  si on selectionne une gamme fichier      
        frameVisu.Visible = cmdFichier.Visible = (inumGE == 0 && mstrStatut != "C");

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (apicboClient.GetText() == "")
      {
        MessageBox.Show(Resources.msg_select_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (txtGamme.Text == "")
      {
        MessageBox.Show(Resources.msg_select_gamme_type, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (cboContrat.Text == "")
      {
        MessageBox.Show(Resources.msg_must_select_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (mstrStatut == "M") // copie ?
      {
        // confirmation
        if (MessageBox.Show(Resources.msg_confirm_creation_trame_client, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;
      }
      else if (mstrStatut == "Mod")
      {
        SaveGamme();
        return;
      }

      // creation de la gamme
      int NumTrameClient = (int)ModuleData.ExecuteScalarInt("select max(NTRACLINUM) from TGAMCLIENT");

      //  ' dernier numéro créé
      miNumTrame = NumTrameClient + 1;

      SaveGamme();

      cmdValider.Enabled = false;
      Cursor.Current = Cursors.Default;

      if (mstrStatut == "C")
        mstrStatut = "Mod";

      //Form_Load()
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdFichier_Click(object sender, EventArgs e)
    {
      CommonDialog1.Title = Resources.msg_select_image_file;
      CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      CommonDialog1.FilterIndex = 1;
      if (CommonDialog1.ShowDialog() == DialogResult.OK)
        WebBrowser1.Navigate(CommonDialog1.FileName);
    }

    private void SaveGamme()
    {
      if (inumGE == 0)
      {
        if (Utils.BlankIfNull(sFichier) == "")
        {
          MessageBox.Show(Resources.msg_must_select_file, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        SqlCommand sqlcmd = new SqlCommand("[api_sp_GammeCli_AddTrame]", MozartDatabase.cnxMozart);
        sqlcmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlcmd);
        sqlcmd.Parameters["@P_NCHECK"].Value = 1;
        sqlcmd.Parameters["@P_NTRACLINUM"].Value = miNumTrame;
        sqlcmd.Parameters["@P_NCLINUM"].Value = apicboClient.GetItemData();
        sqlcmd.Parameters["@P_NGAMTRAMENUM"].Value = 0;
        sqlcmd.Parameters["@P_VGAMTYPE"].Value = txtTitre.Text;
        sqlcmd.Parameters["@P_DTRACLIDAT"].Value = DateTime.Now.ToShortDateString();
        sqlcmd.Parameters["@P_NTRAEMANUM"].Value = inumGE;
        sqlcmd.Parameters["@P_CTRACLIACTIF"].Value = "O";
        sqlcmd.Parameters["@P_BSTOCKLIE"].Value = chkLiaisonStock.Checked ? true : false;
        sqlcmd.Parameters["@P_NTYPECONTRAT"].Value = cboContrat.SelectedValue;
        sqlcmd.Parameters["@P_BVALOBLIG"].Value = null;
        sqlcmd.Parameters["@P_VTRACLIDET"].Value = null;
        sqlcmd.Parameters["@P_VFICHIER"].Value = MozartParams.CheminModeles + @"GAMME\" + miNumTrame + ".pdf";

        sqlcmd.ExecuteNonQuery();

        if (adorsVFICHIER != sFichier)
        {
          File.Delete(adorsVFICHIER);
          File.Copy(sFichier, MozartParams.CheminModeles + @"GAMME\" + miNumTrame + ".pdf");
        }
      }
      else
      {

        // si aucune ligne selectionnée
        if (dtTrames.Select("[NCHECK] = 1").Length == 0)
        {
          MessageBox.Show(Resources.msg_must_select_one_gamme, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        foreach (DataRow drReader in dtTrames.Rows)
        {

          SqlCommand sqlcmd = new SqlCommand("[api_sp_GammeCli_AddTrame]", MozartDatabase.cnxMozart);
          sqlcmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(sqlcmd);
          sqlcmd.Parameters["@P_NCHECK"].Value = drReader["NCHECK"];
          sqlcmd.Parameters["@P_NTRACLINUM"].Value = miNumTrame;
          sqlcmd.Parameters["@P_NCLINUM"].Value = apicboClient.GetItemData();
          sqlcmd.Parameters["@P_NGAMTRAMENUM"].Value = drReader["NGAMTRAMENUM"];
          sqlcmd.Parameters["@P_VGAMTYPE"].Value = txtTitre.Text;
          sqlcmd.Parameters["@P_DTRACLIDAT"].Value = DateTime.Now.ToShortDateString();
          sqlcmd.Parameters["@P_NTRAEMANUM"].Value = inumGE;
          sqlcmd.Parameters["@P_CTRACLIACTIF"].Value = "O";
          sqlcmd.Parameters["@P_BSTOCKLIE"].Value = chkLiaisonStock.Checked ? true : false;
          sqlcmd.Parameters["@P_NTYPECONTRAT"].Value = cboContrat.SelectedValue;
          sqlcmd.Parameters["@P_BVALOBLIG"].Value = drReader["BVALOBLIG"];
          sqlcmd.Parameters["@P_VTRACLIDET"].Value = drReader["VTRACLIDET"];
          sqlcmd.Parameters["@P_VFICHIER"].Value = null;

          sqlcmd.ExecuteNonQuery();

        }

        //on clear les trameemalec qui n'existe plus dans TGAMTRAMESEMALEC de la TGAMCLIENT
        SqlCommand sqlcmdClr = new SqlCommand("[api_sp_GammeCli_ClearTrame]", MozartDatabase.cnxMozart);
        sqlcmdClr.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(sqlcmdClr);
        sqlcmdClr.Parameters["@P_NTRACLINUM"].Value = miNumTrame;
        sqlcmdClr.Parameters["@P_NCLINUM"].Value = apicboClient.GetItemData();
        sqlcmdClr.Parameters["@P_NTYPECONTRAT"].Value = cboContrat.SelectedValue;

        sqlcmdClr.ExecuteNonQuery();


      }
    }
    private void apicboClient_Leave(object sender, EventArgs e)
    {
      // si copie de gamme ne pas tout changer
      if (mstrStatut == "M")
      {
        // combo des types de contrat
        RemplirCboTypeContrat();
        return;
      }

      if (apicboClient.GetItemData() != -1)
        // combo des types de contrat
        RemplirCboTypeContrat();
      else
        cboContrat.Items.Clear();
    }

    private void RemplirCboTypeContrat()
    {
      ModuleData.RemplirCombo(cboContrat, "api_sp_TypeContratClient " + apicboClient.GetItemData());
      cboContrat.ValueMember = "NTYPECONTRAT";
      cboContrat.DisplayMember = "VCONTRAT";
    }

    private void LoadTramesEMALEC()
    {
      //DataTable dtTrames = new DataTable();
      //  Liste de toutes les categories EMALEC
      string sSQL = $"EXEC [api_sp_GammeCli_ListeTrame] {inumGE}, {miNumTrame}";

      using (SqlDataReader dataReader = ModuleData.ExecuteReader(sSQL))
      {
        dtTrames.Load(dataReader);
        dataReader.Close();
      }

      dtTrames.Columns["NCHECK"].ReadOnly = false;
      dtTrames.Columns["VTRACLIDET"].ReadOnly = false;
      dtTrames.Columns["BVALOBLIG"].ReadOnly = false;

      GCGAMCLI.DataSource = dtTrames;
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      //    Ouvrir une liste de recherche de la gamme
      frmApiRecherche f = new frmApiRecherche(MozartDatabase.cnxMozart);
      f.msType = "GAM";
      f.msSql = "select distinct NTRAEMANUM, VGAMTYPE as GAMME, 'GE' + dbo.FormatCle (NTRAEMANUM, 3) 'N°', VPAYSNOM as PAYS from TGAMTRAMESEMALEC INNER JOIN TPAYS ON TGAMTRAMESEMALEC.NPAYSNUM = TPAYS.NPAYSNUM  WHERE CTRAEMAACTIF='O' UNION SELECT 0, 'GAMME FICHIER EXTERNE', '', '' order by VGAMTYPE";
      f.ShowDialog();
      if (f.msRetour != "")
      {
        txtGamme.Text = f.msRetour;
        inumGE = f.mlItemData;
        // liste des catégories
        LoadTramesEMALEC();
        // cocher les catégories       
        txtAE.Text = "GE" + Strings.Format(f.mlItemData, "000");
        f.Dispose();
      }

      //  si on selectionne une gamme fichier     
      frameVisu.Visible = cmdFichier.Visible = inumGE == 0;
    }

    private void cmdCocherTC_Click(object sender, EventArgs e)
    {

      foreach (DataRow Row in dtTrames.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVGAMCLI.ActiveFilterCriteria)))
      {
        if ((Int32)Row["NCHECK"] != 1)
        {
          Row["NCHECK"] = 1;
          GVGAMCLI.PostEditor();
          GVGAMCLI.UpdateCurrentRow();
          GCGAMCLI.Refresh();
        }
      }

    }
    private void cmdDecocherTC_Click(object sender, EventArgs e)
    {
      foreach (DataRow Row in dtTrames.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(GVGAMCLI.ActiveFilterCriteria)))
      {
        if ((Int32)Row["NCHECK"] != 0)
        {
          Row["NCHECK"] = 0;
          GVGAMCLI.PostEditor();
          GVGAMCLI.UpdateCurrentRow();
          GCGAMCLI.Refresh();
        }
      }
    }

    private void GVGAMCLI_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
    {
      Rectangle oPos = e.Bounds;
      StringFormat oFormat = new StringFormat();
      oPos.Location = new Point(oPos.Left + 1, oPos.Top + 1);
      oPos.Size = new Size(oPos.Width - 2, oPos.Height - 2);
      oFormat.Alignment = StringAlignment.Center;
      DataTable DtTmp = GCGAMCLI.DataSource as DataTable;


      if (DtTmp != null)
      {
        e.Appearance.DrawString(e.Cache, $"Nb trames cochées : {DtTmp.Select("[NCHECK] = 1").Length}  / {DtTmp.Rows.Count}", oPos, oFormat);
      }

      e.Handled = true;

    }

    private void RepoNCHECK_CheckedChanged(object sender, EventArgs e)
    {

      CheckEdit edit = sender as CheckEdit;

      //si info client ou valeur obligatoire alors on les reinitialise
      if (edit.Checked == false)
      {
        GVGAMCLI.SetFocusedRowCellValue("VTRACLIDET", "");
        GVGAMCLI.SetFocusedRowCellValue("BVALOBLIG", false);
      }

      GVGAMCLI.PostEditor();
      GVGAMCLI.UpdateCurrentRow();
      GCGAMCLI.Refresh();
    }

    private void RepoBVALOBLIG_CheckedChanged(object sender, EventArgs e)
    {


      GVGAMCLI.PostEditor();
      GVGAMCLI.UpdateCurrentRow();
      GCGAMCLI.Refresh();
    }

    private void GVGAMCLI_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (GVGAMCLI.FocusedColumn.FieldName == "VTRACLIDET" && (Int32)GVGAMCLI.GetRowCellValue(GVGAMCLI.FocusedRowHandle, "NCHECK") == 0)
      {
        MessageBox.Show("Il faut sélectionner la trame pour pouvoir saisir le détail spécifique client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        return;
      }
      if (GVGAMCLI.FocusedColumn.FieldName == "BVALOBLIG" && (Int32)GVGAMCLI.GetRowCellValue(GVGAMCLI.FocusedRowHandle, "NCHECK") == 0)
      {
        MessageBox.Show("Il faut sélectionner la trame pour pouvoir cocher la valuer en obligatoire", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        return;
      }

    }
  }
}

