using DevExpress.XtraGrid.Views.Base;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmNewFacture : Form
  {
    public int miNumDi = 0;
    public string strStatutOuverture;

    DataTable dt = new DataTable();

    public frmNewFacture()
    {
      InitializeComponent();
    }

    private void frmNewFacture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialisationFeuille();

        if (strStatutOuverture != "N")
        {
          // vb6: parcours du listeview selection de tous
          apiTGridFacturable.dgv.SelectAll();

          cmdAjouter_Click(null, null);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      // enregistrement de la facture
      if (apiTGridAFacturer.dgv.RowCount == 0)
      {
        MessageBox.Show(Resources.msg_selectionner_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      DataTable dtFact = GetElementsFact();

      if (!VerifDesFactures(dtFact)) return;

      if (MessageBox.Show("Voulez-vous vraiment générer cette/ces facture(s) ?", Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      // enregistrement ds factures
      CreationDesFactures(dtFact);

      ModuleData.LoadData(dt, $"exec api_sp_listeActionsFacturables {miNumDi}");
      MajLibNBMontant();

      MessageBox.Show(Resources.msg_facture_generee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridFacturable.GetFocusedDataRow();
      if (null == row) return;

      MozartParams.NumDi = Convert.ToInt32(Strings.Mid(row["NDINNUM"].ToString(), 3));

      // écran de modification de la demande
      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "M"
      }.ShowDialog();

      // on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.WaitCursor;
    }

    void InitialisationFeuille()
    {
      // version unique pour InitialisationFeuille (miNumDi = 0) InitialisationSpec
      ModuleData.LoadData(dt, $"exec api_sp_listeActionsFacturables {miNumDi}");

      DataColumn col = new DataColumn("IsSelected")
      {
        DataType = Type.GetType("System.Boolean"),
        DefaultValue = false
      };
      dt.Columns.Add(col);

      apiTGridFacturable.GridControl.DataSource = dt;
      apiTGridFacturable.dgv.ActiveFilterString = "IsSelected==false";
      FormatGridFacturable();

      MajLibNBMontant();

      apiTGridAFacturer.GridControl.DataSource = dt;
      apiTGridAFacturer.dgv.ActiveFilterString = "IsSelected==true";
      FormatGridAFacturer();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // parcours de la liste des lignes selectionnées et ajout
        List<DataRow> rows = new List<DataRow>(20);
        int[] selItems = apiTGridFacturable.dgv.GetSelectedRows();
        for (int i = 0; i < selItems.Length; i++)
        {
          DataRow row = apiTGridFacturable.dgv.GetDataRow(selItems[i]);
          rows.Add(row);
        }
        foreach (DataRow row in rows)
          row["IsSelected"] = true;

        MajLibNBMontant();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // parcours du listeview et recherche des lignes selectionnées
        List<DataRow> rows = new List<DataRow>(20);
        int[] selItems = apiTGridAFacturer.dgv.GetSelectedRows();
        for (int i = 0; i < selItems.Length; i++)
        {
          DataRow row = apiTGridAFacturer.dgv.GetDataRow(selItems[i]);
          rows.Add(row);
        }
        foreach (DataRow row in rows)
          row["IsSelected"] = false;

        MajLibNBMontant();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    bool VerifDesFactures(DataTable dtFact)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        //  pour la facturation, on regroupe les elements de facturation par raison sociale
        //  une seule facture pour toutes les DI avec la même raison sociale.
        //  Vérifier que le montant n'est pas nul

        // initialisation des variables de rupture
        DataRow row = dtFact.DefaultView[0].Row;
        int iNumRaisonSoc = (int)row["NRSFNUM"];
        int iNumCompte = (int)row["NDINCTE"];
        string sTexte = $"{row["VCLINOM"]} / {row["VRSFRSF"]}";
        decimal montant = 0;
        decimal tva = (decimal)row["NELFTVA"];

        //on regarde si tva=0 avec client France
        if (tva == 0 && RecherchePays(iNumRaisonSoc) &&
            MessageBox.Show("Attention : TVA à 0 avec un client en France. Voulez vous poursuivre ?", Program.AppTitle, MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return false;

        // parcours du recordset et gestion des ruptures
        for (int i = 0; i < dtFact.DefaultView.Count; i++)
        {
          row = dtFact.DefaultView[i].Row;
          if ((string)row["CELFTYP"] == "AV" && apiTGridAFacturer.dgv.RowCount > 1)
          {
            MessageBox.Show(Resources.msg_un_seul_chiffrage_par_avancement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
          if (iNumCompte == (int)row["NDINCTE"] && iNumRaisonSoc == (int)row["NRSFNUM"])
          {
            if (tva != (decimal)row["NELFTVA"])
            {
              MessageBox.Show(Resources.msg_tva_differente, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return false;
            }
            montant += (decimal)row["NELFTHT"];
          }
          else if (montant == 0)
          {
            MessageBox.Show($"{Resources.msg_montant_facture}{sTexte}{Resources.msg_egal_0}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
          else
          {
            montant = (decimal)row["NELFTHT"];
          }
          iNumRaisonSoc = (int)row["NRSFNUM"];
          iNumCompte = (int)row["NDINCTE"];
          sTexte = $"{row["VCLINOM"]} / {row["VRSFRSF"]}";
          tva = (decimal)row["NELFTVA"];

          if (!FacturesUtils.IsRSFActif(iNumRaisonSoc))
          {
            MessageBox.Show($"{Resources.msg_raison_sociale_Num}{iNumRaisonSoc}{Resources.msg_archivee}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
        }

        if (montant == 0)
          MessageBox.Show($"{Resources.msg_montant_facture}{sTexte}{Resources.msg_archivee}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
      return false;
    }

    void CreationDesFactures(DataTable dtFact)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // pour la facturation, on regroupe les elements de facturation par raison sociale
        // une seule facture pour toutes les DI avec la même raison sociale.
        // mais pour le même client, on peut avoir des numéros de compte Emalec différents pour la même raison sociale.
        // donc il faut générer une autre facture

        int iNumRaisonSoc = 0;
        int iNumElemFact = 0;
        int iNumCompte = -1;

        for (int i = 0; i < dtFact.DefaultView.Count; i++)
        {
          DataRow row = dtFact.DefaultView[i].Row;

          if (iNumCompte != (int)row["NDINCTE"])
          {
            // on change de compte, nouvelle facture
            // mise à jour de l'enregistrement de la facture précédente dans la table TFACTURES
            EnregistreFacture(0, (int)row["NELFNUM"], (int)row["NRSFNUM"]);
          }
          else
          {
            // on reste sur le même compte
            if (iNumRaisonSoc != (int)row["NRSFNUM"])
            {
              // on change de raison sociale de facturation, donc nouvelle facture
              // mise à jour de l'enregistrement de la facture précédente dans la table TFACTURES
              EnregistreFacture(0, (int)row["NELFNUM"], (int)row["NRSFNUM"]);
            }
            else
            {
              // on reste sur la même raison sociale

              // Si elem de fact différent, on crée un enregistrement avec numéro de facture existant
              // on passe pour cela le précédent numéro d'elemnt de facturation
              // Sinon on ne fait rien car cette action est déjà traitée dans l'element de facturation précédent
              if (iNumElemFact != (int)row["NELFNUM"])
              {
                EnregistreFacture(iNumElemFact, (int)row["NELFNUM"], (int)row["NRSFNUM"]);
              }
            }
          }

          iNumElemFact = (int)row["NELFNUM"];
          iNumRaisonSoc = (int)row["NRSFNUM"];
          iNumCompte = (int)row["NDINCTE"];
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    DataTable GetElementsFact()
    {
      DataTable dtFact = dt.Clone();

      for (int i = 0; i < apiTGridAFacturer.dgv.RowCount; i++)
      {
        DataRow row = apiTGridAFacturer.dgv.GetDataRow(i);
        dtFact.Rows.Add(row.ItemArray);
      }

      // on filtre les lignes sélectionnées
      dtFact.DefaultView.RowFilter = "IsSelected=true";
      // sort order par NumCompte/NumRaisSoc/NumElemFact
      dtFact.DefaultView.Sort = "NDINCTE,NRSFNUM,NELFNUM";

      return dtFact;
    }

    void FormatGridFacturable()
    {
      apiTGridFacturable.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 850);
      apiTGridFacturable.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1100);
      apiTGridFacturable.AddColumn(Resources.col_cte, "NDINCTE", 450);
      apiTGridFacturable.AddColumn(Resources.col_Region, "VSITREG", 1050);
      apiTGridFacturable.AddColumn(Resources.col_respMaint, "MAINT", 1400);
      apiTGridFacturable.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1460);
      apiTGridFacturable.AddColumn(Resources.col_Rais_Soc, "VRSFRSF", 1350);
      apiTGridFacturable.AddColumn(MZCtrlResources.col_TVAIntra, "VRSFTVAINTRA", 1000);
      apiTGridFacturable.AddColumn(Resources.col_dateEx, "DACTDEX", 1050);
      apiTGridFacturable.AddColumn(Resources.col_Montant, "NELFTHT", 750, "### ##0.##");
      apiTGridFacturable.AddColumn(Resources.col_attach, "VACTATT", 600);
      apiTGridFacturable.AddColumn(Resources.col_cmde, "VDINNUMCDE", 700);
      apiTGridFacturable.AddColumn(MZCtrlResources.col_Action, "VACTDES", 3030);
      apiTGridFacturable.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1000);
      apiTGridFacturable.AddColumn("Code Fact", "VCODEFACT", 1000);
      apiTGridFacturable.AddColumn(Resources.col_Prest, "CPRECOD", 450);
      apiTGridFacturable.AddColumn("Tec", "CTECCOD", 450);
      apiTGridFacturable.AddColumn(Resources.col_Validation, "ST", 450);
      apiTGridFacturable.AddColumn("tva", "NELFTVA", 500, "##0.##");
      apiTGridFacturable.AddColumn("Seul", "CACTFACUN", 500);
      apiTGridFacturable.AddColumn("Date Chif", "DELFDPR", 1200);
      apiTGridFacturable.AddColumn("NumElemFact", "NELFNUM", 0);
      apiTGridFacturable.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiTGridFacturable.AddColumn(Resources.col_NumRaisSoc, "NRSFNUM", 0);
      apiTGridFacturable.AddColumn("CElfTyp", "CELFTYP", 0);
      apiTGridFacturable.AddColumn("IsSelected", "IsSelected", 0);

      apiTGridFacturable.InitColumnList();

      apiTGridFacturable.dgv.CustomColumnDisplayText += apigrid_CustomColumnDisplayText;
    }

    void FormatGridAFacturer()
    {
      apiTGridAFacturer.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 850);
      apiTGridAFacturer.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1100);
      apiTGridAFacturer.AddColumn(Resources.col_cte, "NDINCTE", 450);
      apiTGridAFacturer.AddColumn(Resources.col_Region, "VSITREG", 1050);
      apiTGridAFacturer.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1460);
      apiTGridAFacturer.AddColumn(Resources.col_Rais_Soc, "VRSFRSF", 1350);
      apiTGridAFacturer.AddColumn(Resources.col_dateEx, "DACTDEX", 1050);
      apiTGridAFacturer.AddColumn(Resources.col_Montant, "NELFTHT", 750, "### ##0.##");
      apiTGridAFacturer.AddColumn(Resources.col_attach, "VACTATT", 600);
      apiTGridAFacturer.AddColumn(Resources.col_cmde, "VDINNUMCDE", 700);
      apiTGridAFacturer.AddColumn(MZCtrlResources.col_Action, "VACTDES", 3030);
      apiTGridAFacturer.AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 0);
      apiTGridAFacturer.AddColumn(Resources.col_Prest, "CPRECOD", 0);
      apiTGridAFacturer.AddColumn("Tec", "CTECCOD", 0);
      apiTGridAFacturer.AddColumn(Resources.col_Validation, "ST", 0);
      apiTGridAFacturer.AddColumn("tva", "NELFTVA", 0, "##0.##");
      apiTGridAFacturer.AddColumn("Seul", "CACTFACUN", 0);
      apiTGridAFacturer.AddColumn("Date Chif", "DELFDPR", 0);
      apiTGridAFacturer.AddColumn("NumElemFact", "NELFNUM", 0);
      apiTGridAFacturer.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiTGridAFacturer.AddColumn(Resources.col_NumRaisSoc, "NRSFNUM", 0);
      apiTGridAFacturer.AddColumn("CElfTyp", "CELFTYP", 0);
      apiTGridAFacturer.AddColumn("IsSelected", "IsSelected", 0);

      apiTGridAFacturer.InitColumnList();

      apiTGridAFacturer.dgv.CustomColumnDisplayText += apigrid_CustomColumnDisplayText;
    }
    private void apigrid_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
    {
      if (e.Column.FieldName == "DACTDEX" && null != e.Value && !Convert.IsDBNull(e.Value))
        e.DisplayText = Strings.FormatDateTime((DateTime)e.Value, DateFormat.GeneralDate);
    }

    void EnregistreFacture(int iNumElem, int iNumElemFact, int iNumRaisonSoc)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        using (SqlCommand cmd = new SqlCommand("api_sp_creationFacture", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          cmd.Parameters["@iAncNumElemFact"].Value = iNumElem;
          cmd.Parameters["@iNumElemFact"].Value = iNumElemFact;
          cmd.Parameters["@iNumRaisSoc"].Value = iNumRaisonSoc;
          cmd.Parameters["@dDate"].Value = DateTime.Now.ToShortDateString();

          cmd.ExecuteNonQuery();
        };
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    // mise à jour libelle nombre et montant
    void MajLibNBMontant()
    {
      decimal montantTotal = 0, montantReste = 0, nb = 0;

      foreach (DataRow row in dt.Rows)
      {
        montantTotal += (decimal)Utils.ZeroIfNull(row["NELFTHT"]);
      }

      for (int i = 0; i < apiTGridFacturable.dgv.RowCount; i++)
      {
        DataRow row = apiTGridFacturable.dgv.GetDataRow(i);
        if ((bool)row["IsSelected"]) continue;
        montantReste += (decimal)Utils.ZeroIfNull(row["NELFTHT"]);
        nb++;
      }

      lblNbrEnregistrement.Text = $"{lblNbrEnregistrement.Tag} {nb} / {dt.Rows.Count}       Montant : {montantReste.ToString("### ### ##0")} / {montantTotal.ToString("### ### ##0")}";
    }

    bool RecherchePays(int iRaisonSoc)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select VRSFPAYS FROM TRSF WHERE NRSFNUM = {iRaisonSoc}"))
        {
          if (reader.Read() && Utils.BlankIfNull(reader["VRSFPAYS"]) == "FRANCE") return true;
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
      return false;
    }

    private void apiTGridFacturable_ColumnFilterChanged(object sender, EventArgs e)
    {
      // nombre d'enregistrements
      MajLibNBMontant();
    }
  }
}

