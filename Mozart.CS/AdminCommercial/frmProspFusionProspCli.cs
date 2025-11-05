using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;
using System.Data.SqlClient;

namespace MozartCS
{
  public partial class frmProspFusionProspCli : Form
  {
    private DataTable dtProspects = new DataTable();
    private DataTable dtProspectsToMerge;

    private DataTable dtClients = new DataTable();
    private DataTable dtClientsToAttach;

    private int mProsNum;

    public frmProspFusionProspCli()
    {
      InitializeComponent();

      mProsNum = -1;

      dtProspectsToMerge = null;
      dtClientsToAttach = null;
    }

    private void frmProspFusionProspCli_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        apiHelp.BringToFront();
        apiHelp.Visible = false;
        // Centrage de l'aide
        apiHelp.Location = new Point((Width - apiHelp.Width) / 2, (Height - apiHelp.Height) / 2);

        initGridProspect(apiTGridProspects);
        initGridProspect(apiTGridProspectToMerge);

        initGridClient(apiTGridClients);
        initGridClient(apiTGridClientsToAttach);

        // Multi sélection des clients
        apiTGridClients.dgv.OptionsSelection.MultiSelect = true;
        apiTGridClients.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGridClients.dgv.ClearSelection();

        // Multi sélection des clients
        apiTGridProspects.dgv.OptionsSelection.MultiSelect = true;
        apiTGridProspects.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGridProspects.dgv.ClearSelection();

        apiChkProspectTous.Checked = true;
        apiChkClientTous.Checked = true;
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

    private void initGridClient(apiTGrid grid)
    {
      grid.AddColumn(Resources.col_Nom, "VCLINOM", 1800, "", 0, true);
      grid.AddColumn(Resources.col_Creation, "DCLIDATECRE", 1000, "dd/mm/yy", 2);
      grid.AddColumn(Resources.col_CP, "VCLICP", 700);
      grid.AddColumn(MZCtrlResources.col_Ville, "VCLIVIL", 1100, "", 0, true);
      grid.AddColumn(MZCtrlResources.col_Pays, "VCLIPAYS", 1100);
      grid.AddColumn(Resources.col_Adresse1, "VCLIAD1", 1500);
      grid.AddColumn(Resources.col_Adresse2, "VCLIAD2", 1500);
      grid.AddColumn(Resources.col_Sites, "NBSITES", 700);
      grid.AddColumn(MZCtrlResources.col_Type, "VTYPECLIENT", 700);
      grid.AddColumn("Nb actions sur 24 mois", "NB_ACT_EN_C", 700);
      grid.AddColumn(Resources.col_Activite, "VCLIACTIVITE", 1500);
      grid.AddColumn(MZCtrlResources.societe, "VSOCIETE", 900);
      grid.AddColumn("NCLINUM", "NCLINUM", 0, "");
      grid.AddColumn("VCLICPCEDEX", "VCLICPCEDEX", 0, "");
      grid.AddColumn("NPROSNUM", "NPROSNUM", 0, "");

      grid.InitColumnList();
    }

    private void initGridProspect(apiTGrid grid)
    {
      grid.AddColumn(Resources.col_Nom, "VPROSNOM", 1800, "", 0, true);
      grid.AddColumn(Resources.col_Creation, "DPROSDATECRE", 1000, "dd/mm/yy", 2);
      grid.AddColumn(Resources.col_CP, "VPROSCP", 700);
      grid.AddColumn(MZCtrlResources.col_Ville, "VPROSVIL", 1100, "", 0, true);
      grid.AddColumn(MZCtrlResources.col_Pays, "VPROSPAYS", 1100);
      grid.AddColumn(Resources.col_Adresse1, "VPROSAD1", 1500);
      grid.AddColumn(Resources.col_Adresse2, "VPROSAD2", 1500);
      grid.AddColumn(Resources.col_Activite, "VPROSACT", 1500);
      grid.AddColumn(MZCtrlResources.societe, "VSOCIETE", 900);
      grid.AddColumn(Resources.col_Code_APE, "VCODEAPE", 1100);
      grid.AddColumn("NPROSNUM", "NPROSNUM", 0, "");

      grid.InitColumnList();
    }

    private void btnSelectPrincProspe_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridProspects.GetFocusedDataRow();
      if (row == null) return;

      txtPrincipalProspect.Text = (string)row["VPROSNOM"];
      mProsNum = (int)row["NPROSNUM"];

      dtProspectsToMerge.Clear();
      //dtClientsToAttach.Clear();
    }

    private void btnProspToRight_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridProspects.GetFocusedDataRow();
      if (row == null) return;

      if (Convert.ToInt32(row["NPROSNUM"]) == mProsNum) {
        string lMsg = $"Ce prospect est déjà désigné en tant que prospect principal." + Environment.NewLine;
        lMsg += "Vous ne pouvez pas le désigner aussi en tant que prospect à fusionner";
        MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

        return;
      }

      dtProspectsToMerge.ImportRow(row);
      dtProspects.Rows.Remove(row);
    }

    private void btnProspeToLeft_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridProspectToMerge.GetFocusedDataRow();
      if (row == null) return;

      dtProspects.ImportRow(row);
      dtProspectsToMerge.Rows.Remove(row);
    }

    private void btnClientToRight_Click(object sender, EventArgs e)
    {
      Int32[] selectedRowHandles = apiTGridClients.dgv.GetSelectedRows();
      if (selectedRowHandles.Length == 0) return;

      ArrayList rows = new ArrayList();
      foreach (int gridRowHandle in selectedRowHandles)
      {
        rows.Add(apiTGridClients.dgv.GetDataRow(gridRowHandle));
      }

      foreach (DataRow row in rows)
      {
        dtClientsToAttach.ImportRow(row);
        dtClients.Rows.Remove(row);
      }

      apiTGridClients.dgv.ClearSelection();
    }

    private void btnClientToLeft_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridClientsToAttach.GetFocusedDataRow();
      if (row == null) return;

      dtClients.ImportRow(row);
      dtClientsToAttach.Rows.Remove(row);
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      apiHelp.Visible = !apiHelp.Visible;
    }

    private void btnArchiverProspe_Click(object sender, EventArgs e)
    {
      try
      {
        Int32[] selectedRowHandles = apiTGridProspects.dgv.GetSelectedRows();
        if (selectedRowHandles.Length == 0) return;

        string lMsg = "Attention, vous allez archiver un ou plusieurs prospects." + Environment.NewLine + Environment.NewLine;
        lMsg += "Souhaitez-vous continuer ?";
        if (MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          Cursor.Current = Cursors.WaitCursor;

          string lListIDs = "";
          foreach (int gridRowHandle in selectedRowHandles)
          {
            if (lListIDs != "")
            {
              lListIDs += ",";
            }

            DataRow lRow = apiTGridProspects.dgv.GetDataRow(gridRowHandle);
            lListIDs += lRow["NPROSNUM"];
          }

          MozartDatabase.ExecuteNonQuery($"UPDATE TPROSP set CPROSACTIF = 'N' where NPROSNUM IN ({lListIDs})");
        }

        apiTGridProspects.Requery(dtProspects, MozartDatabase.cnxMozart);
        apiTGridProspects.dgv.ClearSelection();
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

    private void btnDetail_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridProspects.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;
      new frmProspGestDetails(Convert.ToInt32(row["NPROSNUM"])).ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void btnFusionner_Click(object sender, EventArgs e)
    {
      if (txtPrincipalProspect.Text == "")
      {
        MessageBox.Show("Sélectionnez un prospect principal.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        return;
      }

      if (dtProspectsToMerge.Rows.Count == 0)
      {
        MessageBox.Show("Sélectionnez un ou plusieurs prospect(s) à fusionner.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        return;
      }

      string lMsg = "Attention, cette opération est irréversible." + Environment.NewLine + Environment.NewLine;
      lMsg += "Souhaitez-vous continuer ?";
      if (MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
      {
        return;
      }

      // TPROSPSUIV   : NPROSNUM - NSUIVNUM
      // TPROSPFOU    : NPROSNUM - NFOUNUM
      // TPROSPDOC    : NPROSNUM - NPROSDOCID
      // TPROSPCCL    : NPROSNUM - NIDPROSPCCLNUM
      // TPROSP       : NPROSNUM

      // Liste des prospects à fusionner
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string lIdListProspectToMerge = string.Join(",", dtProspectsToMerge.AsEnumerable().Select(r => r["NPROSNUM"].ToString()));
        MozartDatabase.ExecuteNonQuery($"exec api_sp_ProspMergeProsp {mProsNum}, '{lIdListProspectToMerge}'");

        Cursor.Current = Cursors.Default;

        MessageBox.Show($"Le(s) prospect(s) a(ont) été fusionné(s) sur le prospect \"{txtPrincipalProspect.Text}\".", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtPrincipalProspect.Text = "";
        dtProspectsToMerge.Clear();

        apiTGridProspects.Requery(dtProspects, MozartDatabase.cnxMozart);
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

    private void btnRattacherClients_Click(object sender, EventArgs e)
    {
      try
      {
        string lMsg;

        if (txtPrincipalProspect.Text == "")
        {
          MessageBox.Show("Sélectionnez un prospect principal.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

          return;
        }

        if (dtClientsToAttach.Rows.Count == 0)
        {
          MessageBox.Show("Sélectionnez un ou plusieurs client(s) à rattacher.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

          return;
        }

        lMsg = "Attention, cette opération est irréversible." + Environment.NewLine + Environment.NewLine;
        lMsg += "Souhaitez-vous continuer ?";
        if (MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        // TPROSP_CLI : NPROSNUM - NCLINUM
        string lListClientAttaches = "";
        bool bExistCliAlreadyAttached = false;
        bool bFirst = true;
        string lSql = "INSERT INTO TPROSP_CLI(NPROSNUM, NCLINUM) VALUES";
        foreach (DataRow item in dtClientsToAttach.Rows)
        {
          if (Convert.IsDBNull(item["NPROSNUM"]))
          {
            if (!bFirst)
            {
              lSql += ",";
            }
            else
            {
              bFirst = false;
            }

            lSql += $"({mProsNum}, {item["NCLINUM"]})";
          } else
          {
            bExistCliAlreadyAttached = true;
            if (lListClientAttaches != "")
            {
              lListClientAttaches += Environment.NewLine;
            }
            lListClientAttaches += item["VCLINOM"];
          }
        }

        if (!bFirst)
        {
          MozartDatabase.ExecuteNonQuery(lSql);

          lMsg = $"Un ou plusieurs clients ont été rattachés au prospect \"{txtPrincipalProspect.Text}\".";
          if (bExistCliAlreadyAttached)
          {
            // Au moins 1 client rattaché : On rajoute un message d'info
            lMsg += $"{Environment.NewLine}{Environment.NewLine}";
            lMsg += "Certains clients sont déjà rattachés à un prospect : Ils n'ont pas été rattachés.";
            lMsg += $"{Environment.NewLine}{Environment.NewLine}";
            lMsg += lListClientAttaches;
          }
          MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        } else
        {
          // Pas de client : Ils sont déjà tous rattachés
          lMsg = "Un ou plusieurs clients sont déjà rattachés à un prospect : Ils n'ont pas été rattachés :";
          lMsg += $"{Environment.NewLine}{Environment.NewLine}";
          lMsg += lListClientAttaches;

          MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        txtPrincipalProspect.Text = "";
        dtClientsToAttach.Clear();

        apiTGridProspects.Requery(dtProspects, MozartDatabase.cnxMozart);
        apiTGridClients.Requery(dtClients, MozartDatabase.cnxMozart);
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

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        Int32[] selectedRowHandles = apiTGridClients.dgv.GetSelectedRows();
        if (selectedRowHandles.Length == 0) return;

        string lMsg = "Attention, vous allez archiver un ou plusieurs clients." + Environment.NewLine + Environment.NewLine;
        lMsg += "Souhaitez-vous continuer ?";
        if (MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        Cursor.Current = Cursors.WaitCursor;

        ArrayList rows = new ArrayList();
        foreach (int gridRowHandle in selectedRowHandles)
        {
          rows.Add(apiTGridClients.dgv.GetDataRow(gridRowHandle));
        }

        foreach (DataRow row in rows)
        {
          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, "", cmdSupprimer.Tag.ToString(), "Suppression", $"NCLINUM:{row["NCLINUM"]}");

          MozartDatabase.ExecuteNonQuery($"update TCLI set CCLIACTIF = 'N' where NCLINUM = {row["NCLINUM"]}");
          // suppression des prix client FO
          MozartDatabase.ExecuteNonQuery($"DELETE TSTOCKARTCLI where NCLINUM = {row["NCLINUM"]}");
          // suppression des prix client PRESTATION
          MozartDatabase.ExecuteNonQuery($"DELETE TPRESTPRIXCLI where NCLINUM = {row["NCLINUM"]}");
          // Jean le 03/01/2014
          // suppression des tech imposés/interdit de tous les sites clients
          MozartDatabase.ExecuteNonQuery($"DELETE TTECHSITE WHERE NSITNUM IN (SELECT NSITNUM FROM TSIT WITH (NOLOCK) where NCLINUM = {row["NCLINUM"]})");

          // archivage des comptes analytiques
          MozartDatabase.ExecuteNonQuery($"UPDATE TCAN SET CCANACTIF = 'N' WHERE NCLINUM = {row["NCLINUM"]}");

          MozartUcUtils.SpyLog(MozartDatabase.cnxMozart, Text, Name, "Suppression", "DE:" + this.Text, $"NCLINUM:{row["NCLINUM"]}");
        }

        apiTGridClients.Requery(dtClients, MozartDatabase.cnxMozart);
        apiTGridClients.dgv.ClearSelection();
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

    private void cmdCreateProspect_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmProspGestDetails(0).ShowDialog();

        apiTGridProspects.Requery(dtProspects, MozartDatabase.cnxMozart);
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

    private void btnCreateProspectFromClient_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow lFirstRow = apiTGridClients.GetFocusedDataRow();
        if (lFirstRow == null) return;

        Cursor.Current = Cursors.WaitCursor;

        int lRet = ProspectExist(lFirstRow["VCLINOM"].ToString(), lFirstRow["VSOCIETE"].ToString());
        switch (lRet)
        {
          case 1:
            // Existe et Actif
            MessageBox.Show($"Un prospect avec le même nom existe déjà pour le client '{lFirstRow["VCLINOM"]}'.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

          case 2:
            // Existe et Archivé
            MessageBox.Show($"Un prospect archivé avec le même nom existe déjà pour le client '{lFirstRow["VCLINOM"]}'.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string lMsg = $"Attention, vous allez créer un prospect à partir du client '{lFirstRow["VCLINOM"]}'." + Environment.NewLine + Environment.NewLine;
        lMsg += "Souhaitez-vous continuer ?";
        if (MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        Enregistrer(lFirstRow);

        apiTGridClients.Requery(dtClients, MozartDatabase.cnxMozart);
        apiTGridClients.dgv.ClearSelection();

        apiTGridProspects.Requery(dtProspects, MozartDatabase.cnxMozart);
        apiTGridProspects.dgv.ClearSelection();
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

    // Créer un prospect à partir de la datarow d'un client
    private void Enregistrer(DataRow pClientRow)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_creationProspectV3", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iprosp"].Value = 0;
          cmd.Parameters["@vEnseigne"].Value = pClientRow["VCLINOM"];

          cmd.Parameters["@vPROSAd1"].Value = pClientRow["VCLIAD1"];
          cmd.Parameters["@vPROSAd2"].Value = pClientRow["VCLIAD2"];
          cmd.Parameters["@vPROSCp"].Value = pClientRow["VCLICP"];
          cmd.Parameters["@vPROSVil"].Value = pClientRow["VCLIVIL"];
          cmd.Parameters["@vPROSPays"].Value = pClientRow["VCLIPAYS"];

          cmd.Parameters["@vTel"].Value = "";
          cmd.Parameters["@vFax"].Value = "";
          cmd.Parameters["@vPort"].Value = "";
          cmd.Parameters["@vMail"].Value = "";

          cmd.Parameters["@vRens"].Value = "";
          cmd.Parameters["@nSuc"].Value = 0;
          cmd.Parameters["@iAct"].Value = 201;  // Autre à redéfinir par les commerciaux
          cmd.Parameters["@iChaff"].Value = 0;
          cmd.Parameters["@iNIDPROSORICONT"].Value = 31;  // Prospection directe

          cmd.Parameters["@vCedex"].Value = pClientRow["VCLICPCEDEX"];
          cmd.Parameters["@vsociete"].Value = pClientRow["VSOCIETE"];
          cmd.Parameters["@urgence"].Value = 2;

          cmd.ExecuteNonQuery();
          int iNumProspect = (int)cmd.Parameters[0].Value;

          MozartDatabase.ExecuteNonQuery($"INSERT INTO TPROSP_CLI(NPROSNUM, NCLINUM) VALUES({iNumProspect}, {pClientRow["NCLINUM"]})");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    // Vérifie qu'un prospect n'existe pas avec le nom passé en paramètre
    // Renvoie 1 si oui et actif
    // Renvoie 2 si oui et archivé
    // 0 Sinon
    private int ProspectExist(string pNom, string pSociete)
    {
      int Nb = MozartDatabase.ExecuteScalarInt($"select count(*) from TPROSP WHERE VSOCIETE = '{pSociete}' AND CPROSACTIF = 'O' AND upper(VPROSNOM) = '{pNom.ToUpper().Replace("'", "''")}'");
      if (Nb > 0)
      {
        return 1;
      }

      Nb = MozartDatabase.ExecuteScalarInt($"select count(*) from TPROSP WHERE VSOCIETE = '{pSociete}' AND CPROSACTIF = 'N' AND upper(VPROSNOM) = '{pNom.ToUpper().Replace("'", "''")}'");
      return (Nb > 0) ? 2 : 0;
    }

    private void apiChkProspect_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int filtre = 0;
        if (apiChkProspectTous.Checked)
        {
          filtre = 0;
        }
        if (apiChkProspectWithClient.Checked)
        {
          filtre = 1;
        }
        if (apiChkProspectWithoutClient.Checked)
        {
          filtre = 2;
        }

        apiTGridProspects.LoadData(dtProspects, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeProspectFusion {filtre}");
        apiTGridProspects.GridControl.DataSource = dtProspects;

        if (dtProspectsToMerge == null)
        {
          dtProspectsToMerge = dtProspects.Clone();
        }
        apiTGridProspectToMerge.GridControl.DataSource = dtProspectsToMerge;

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

    private void apiChkClient_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int filtre = 0;
        if (apiChkClientTous.Checked)
        {
          filtre = 0;
        }
        if (apiChkWithProspect.Checked)
        {
          filtre = 1;
        }
        if (apiChkWithoutProspect.Checked)
        {
          filtre = 2;
        }

        apiTGridClients.LoadData(dtClients, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeClientsFusion {filtre}");
        apiTGridClients.GridControl.DataSource = dtClients;

        if (dtClientsToAttach == null)
        {
          dtClientsToAttach = dtClients.Clone();
        }
        apiTGridClientsToAttach.GridControl.DataSource = dtClientsToAttach;

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
  }
}
