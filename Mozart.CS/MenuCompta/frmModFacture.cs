using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmModFacture : Form
  {
    DataTable dtFact = new DataTable();
    DataTable dtFactD = new DataTable();

    private int miNumFacture;

    bool PremAct = false;
    bool PremFact = false;

    public frmModFacture(int iNumFacture)
    {
      InitializeComponent();

      miNumFacture = iNumFacture;
    }

    private void frmModFacture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        DataRow rowA = grdDataGridAction.GetFocusedDataRow();
        if (rowF == null || rowA == null) return;

        MozartParams.NumAction = (int)rowA[0];
        MozartParams.NumDi = Convert.ToInt32(Strings.Mid((string)rowF[1], 3));

        if ((string)rowF["CFACTRANS"] == "NON")
        {
          new frmNewElemFact()
          {
            mstrStatutElemFact = "M",
            mstrTypeFacturation = txtFact0.Visible ? "DC" : "FD",
            miNumElemFact = (int)rowF["NELFNUM"],
          }.ShowDialog();

          //mise à jour de l'enregistrement de la facture dans la table TFACTURES
          ModuleData.CnxExecute($"exec api_sp_EnregFacture {miNumFacture}");
          grdDataGrid.Requery(dtFact, MozartDatabase.cnxMozart);

          InitialiserDonnees();

          //mise en page du tableau
          FormatGrid();
        }
        else MessageBox.Show(Resources.msg_Facture_Transfert_Compta_Modif_Impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        //suppression de la ligne sélectionnée
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        if (rowF == null) return;

        //si le transfert et fait en compta, on ne peut pas modifier
        if ((string)rowF["CFACTRANS"] == "NON")
        {
          if (MessageBox.Show(Resources.msg_supprimerEnreg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            ModuleData.SupprimerEnreg((int)rowF[0], "api_sp_SupprimerElemFact", "@iNumElemFact");
            //la mise à jour dans la table TFACTURES se fait dans la proc
            InitialiserFeuille();
          }
          else
            return;
        }
        else MessageBox.Show(Resources.msg_Facture_Transfert_Compta_Modif_Impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        if (rowF == null) return;

        FacturesUtils.EditionFacture("PRINT", miNumFacture, rowF);

        //mise a jour du flag d'impression
        FacturesUtils.SetFactureEditee(miNumFacture);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        if (rowF == null) return;

        FacturesUtils.EditionFacture("PREVIEW", miNumFacture, rowF);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdPrintFacETR_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        if (rowF == null) return;

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = PrepareReport.TFACTURECLIENTETR,
          sIdentifiant = $"{miNumFacture}|{rowF["VCLITYPEFAC"]}",
          InfosMail = $"TCLI|NCLINUM|{rowF["NCLINUM"]}",
          sNomSociete = MozartParams.NomSociete,
          sLangue = (string)rowF["VRSFLANGUE"],
          sOption = "PREVIEW",
        }.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDi_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        DataRow rowA = grdDataGridAction.GetFocusedDataRow();
        if (rowF == null && rowA == null) return;

        MozartParams.NumAction = (int)Utils.ZeroIfNull(rowA[0]);
        MozartParams.NumDi = Convert.ToInt32(Strings.Mid(rowF["NDINNUM"].ToString(), 3));

        //écran de modification de la demande
        new frmAddAction
        {
          mstrStatutDI = "M",
        }.ShowDialog();

        MozartParams.NumAction = 0;
        MozartParams.NumDi = 0;

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
        //suppression de la ligne sélectionnée
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        DataRow rowA = grdDataGridAction.GetFocusedDataRow();
        if (rowF == null || rowA == null) return;

        if ((string)rowF["CELFTYP"] == "AV")
        {
          MessageBox.Show(Resources.msg_Facture_Pouvoir_Contenir_Un_Chiffrage, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
        }
        else
        {
          //Si le transfert et fait en compta, on ne peut pas modifier
          if ((string)rowF["CFACTRANS"] == "NON")
          {
            string InputValue = Interaction.InputBox(Resources.msg_Donner_Num_Chiffrage, Resources.msg_Chiffrage_Mozart);

            if (InputValue == "")
              return;
            else
            {
              //La mise à jour dans la table TFACTURES se fait dans la proc
              using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_AjouterChiffrageFacture {miNumFacture}, {InputValue}"))
              {
                if (dr.Read())
                {
                  if ((int)dr["RESULT"] != 0)
                    MessageBox.Show((string)dr["MSG"], Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              }
              InitialiserFeuille();
            }
          }
          else
            MessageBox.Show(Resources.msg_Facture_Transfert_Compta_Modif_Impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserFeuille()
    {
      //recherche des éléments de facturation de la facture selectionnée
      grdDataGrid.LoadData(dtFact, MozartDatabase.cnxMozart, $"api_sp_listeElemFacture {miNumFacture}");
      grdDataGrid.GridControl.DataSource = dtFact;

      //mise en page du datagrid
      FormatGrid();

      //si on a des enregistrements
      DataRow row = grdDataGrid.GetFocusedDataRow();
      if (row != null) InitialiserDonnees();
      else ViderDonnees();
    }

    private void ViderDonnees()
    {
      txtFact0.Text = "";
      txtFact1.Text = "";
      txtFact2.Text = "";
      txtFact3.Text = "";
      txtFact4.Text = "";
      txtFact5.Text = "";
      txtFact6.Text = "";

      optFour1.Checked = true;
      cmdDetails.Visible = false;

      //ouverture du recordset des actions
      grdDataGridAction.LoadData(dtFactD, MozartDatabase.cnxMozart, $"select null,null,null,null,null,null,null");
      grdDataGridAction.GridControl.DataSource = dtFactD;

      //mise en page du datagrid
      FormatGridAction();
    }

    private void InitialiserDonnees()
    {
      try
      {
        int DI;
        DataRow rowF = grdDataGrid.GetFocusedDataRow();
        if (rowF == null) return;

        //mise à jour des contrôles
        txtFact0.Text = Utils.BlankIfNull(rowF["NELFDEP"]);
        txtFact1.Text = $"{Utils.BlankIfNull(rowF["Total"])} €";
        txtFact2.Text = Utils.ZeroIfNull(rowF["NELFHEU"]).ToString("##0.##");
        txtFact3.Text = Utils.BlankIfNull(rowF["TELFOBS"]);
        txtFact4.Text = $"{Utils.BlankIfNull(rowF["NELFFOU"])} €";
        txtFact5.Text = $"{Utils.BlankIfNull(rowF["NELFTDE"])} €";
        txtFact6.Text = $"{Utils.BlankIfNull(rowF["NELFTHO"])} €";

        //type de facture
        if ((string)rowF["CELFTYP"] == "DC")
        {
          txtFact0.Visible = true;
          txtFact1.Visible = false;
          txtFact2.Visible = true;
          txtFact3.Visible = true;
          txtFact4.Visible = true;
          txtFact5.Visible = true;
          txtFact6.Visible = true;

          lblLabels0.Visible = true;
          lblLabels6.Visible = true;
          lblLabels7.Visible = true;
          lblLabels1.Visible = true;
          lblLabels5.Visible = false;
        }
        else
        {
          txtFact0.Visible = false;
          txtFact2.Visible = false;
          txtFact5.Visible = false;
          txtFact6.Visible = false;
          txtFact1.Visible = true;

          lblLabels0.Visible = false;
          lblLabels1.Visible = false;
          lblLabels5.Visible = true;
          lblLabels6.Visible = false;
          lblLabels7.Visible = false;
        }

        //type de fourniture
        if (rowF["CELFTFO"].ToString() == "D")
        {
          optFour0.Checked = true;
          cmdDetails.Visible = true;
        }
        else
        {
          optFour1.Checked = true;
          cmdDetails.Visible = false;
        }
        DI = Convert.ToInt32(Strings.Mid(rowF["NDINNUM"].ToString(), 3));

        //recherche des actions de cette facture
        //ouverture du recordset des actions
        grdDataGridAction.LoadData(dtFactD, MozartDatabase.cnxMozart, $"exec api_sp_listeActionElemFactDi {DI}, {rowF["NELFNUM"]}");
        grdDataGridAction.GridControl.DataSource = dtFactD;

        //mise en page du datagrid
        FormatGridAction();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDetails_Click(object sender, EventArgs e)
    {
      DataRow rowF = grdDataGrid.GetFocusedDataRow();
      if (rowF == null) return;

      //passage du NumElemFact sélectionné
      new frmFactDetFour
      {
        miNumElemFact = (int)Utils.ZeroIfNull(rowF["nelfnum"]),
      }.ShowDialog();
    }

    private void FormatGrid()
    {
      if (PremFact == false)
      {
        grdDataGrid.AddColumn("Num", "NELFNUM", 700);
        grdDataGrid.AddColumn("DI", "NDINNUM", 700);
        grdDataGrid.AddColumn(Resources.col_Date, "DELFDPR", 1000);
        grdDataGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
        grdDataGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500);
        grdDataGrid.AddColumn(Resources.col_CliRef, "VDINREFCLI", 1000); // Problème se traduit automatiquement "Ref Fou"
        grdDataGrid.AddColumn("MO", "MO", 1000, "0.##");
        grdDataGrid.AddColumn(Resources.col_four, "NELFFOU", 1000, "0.##");
        grdDataGrid.AddColumn("Dep", "DEP", 1000, "0.##");
        grdDataGrid.AddColumn(Resources.col_Total_Ou_Forfait, "Total", 1700, "");
        grdDataGrid.AddColumn("NumCli", "NCLINUM", 0);
        grdDataGrid.AddColumn("NumSit", "NSITNUM", 0);
        grdDataGrid.AddColumn("TVA", "VRSFPAYS", 700);
        grdDataGrid.AddColumn("NELFTVA", "NELFTVA", 1000, "0.##");

        grdDataGrid.InitColumnList();
        PremFact = true;
      }
    }

    private void FormatGridAction()
    {
      if (PremAct == false)
      {
        grdDataGridAction.AddColumn("NACTNUM", "NACTNUM", 0);
        grdDataGridAction.AddColumn(Resources.col_Action, "VACTDES", 5500);
        grdDataGridAction.AddColumn(Resources.col_dateEx, "DACTDEX", 1000);
        grdDataGridAction.AddColumn(Resources.col_Site, "VSITNOM", 1700);
        grdDataGridAction.AddColumn(Resources.col_Inter, "VACTINT", 500);
        grdDataGridAction.AddColumn(Resources.col_etat, "CETACOD", 500);
        grdDataGridAction.AddColumn(Resources.col_Observation, "VACTOBS", 5000);

        grdDataGridAction.InitColumnList();
        PremAct = true;
      }
    }

    private void grdDataGrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      InitialiserDonnees();
    }
  }
}