using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDelegation : Form
  {
    bool bVisuArchives;
    DataTable dt = new DataTable();

    public frmListeDelegation()
    {
      InitializeComponent();
    }

    private void frmListeDelegation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //init
        Frame1.Visible = false;
        string sReq = $"exec api_sp_listeDelegation {MozartParams.UID}";
        bVisuArchives = false;

        // droit a la validation des dde techs
        if (ModuleMain.RechercheDroitMenu(683))
        {
          Label1.Text = "Validation des commandes FO et STT et des demandes de réappro ";
          sReq = $"exec [api_sp_ListeDelegationAndDdeReappro] {MozartParams.UID}";
        }

        int iDirect = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS NB_DIRECT FROM TDIRECTION WHERE NPERNUM = {MozartParams.UID}");
        if (iDirect > 0) Frame1.Visible = true;

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, sReq, 180);
        apigrid.GridControl.DataSource = dt;

        InitApidgrid();
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

    private void cmdDoc_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigrid.GetFocusedDataRow();
      if (currentRow == null || currentRow["CTYPE"].ToString() == "CF") return;

      // recherche des infos sur le STT
      string sSQL = $"select NSTFGRPNUM, VSTFNOM FROM TCST WITH (NOLOCK) INNER JOIN" +
                    $"  TINT WITH (NOLOCK) ON TCST.NINTNUM = TINT.NINTNUM INNER JOIN" +
                    $"  TSTF WITH (NOLOCK) ON TINT.NSTFNUM = TSTF.NSTFNUM " +
                    $"Where NCSTNUM = {currentRow["NCOMNUM"]}";

      using (SqlDataReader sdr = ModuleData.ExecuteReader(sSQL))
      {
        if (sdr.Read())
        {
          new frmGestDocAdminSTF()
          {
            miStfGrpNnum = Convert.ToInt64(Utils.ZeroIfNull(sdr["NSTFGRPNUM"])),
            mstrNom = Utils.BlankIfNull(sdr["VSTFNOM"])
          }.ShowDialog();
        }
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apigrid.GetFocusedDataRow();
        if (currentRow == null) return;

        // si on traite une commande ou un contrat d'une autre societe, on ouvre un autre Mozart
        if (currentRow["VSOCIETE"].ToString() != MozartParams.NomSociete)
        {
          string chLocalMozart = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\MOZART\MozartCS.exe";

          // Ouverture de Mozart sur la page de la commande
          Process.Start(chLocalMozart, $"{MozartParams.NomServeur};{currentRow["VSOCIETE"]};{Convert.ToInt32(currentRow["NDINNUM"])};{Convert.ToInt32(currentRow["NACTNUM"])};{currentRow["CTYPE"]};{currentRow["NCOMNUM"]};DELEGATION");

          apigrid.Requery(dt, MozartDatabase.cnxMozart);
          return;
        }

        //  traitement dans le Mozart courant
        //  passage des paramètres
        //  on enregistre la valeur en cours
        int iNumActionEncours = MozartParams.NumAction;
        MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);

        switch (currentRow["CTYPE"].ToString())
        {
          case "CF":
            new frmCommandeFournisseur()
            {
              mstrStatutCommande = "M",
              miNumCommande = (int)currentRow["NCOMNUM"],
              mstrStatutAlerte = "OUI"
            }.ShowDialog();
            break;

          case "TCMDWEBTECH_INFO":
            new frmCommandeReapproDetail(currentRow["NCOMNUM"]).ShowDialog();
            break;

          default:
            if (ContratAvecPrestation((int)currentRow["NCOMNUM"]))
            {
              new frmContratPrest()
              {
                msTypeContrat = "P",
                mstrStatutContrat = "M",
                miNumContratST = (int)currentRow["NCOMNUM"],
                mstrStatutAlerte = "OUI",
                bDesactive = false  // on ne desactive pas les autres contrats de l'action
              }.ShowDialog();
            }
            else
            {
              new frmContratAutoST()
              {
                mstrStatutContrat = "M",
                msTypeContrat = "S",
                mNumContratST = (int)currentRow["NCOMNUM"],
                mstrStatutAlerte = "OUI",
                mbDesactive = false // on ne desactive pas les autres contrats de l'action
              }.ShowDialog();
            }
            break;
        }

        apigrid.Requery(dt, MozartDatabase.cnxMozart);

        // on remet la valeur en cours
        MozartParams.NumAction = iNumActionEncours;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apigrid.GetFocusedDataRow();
        if (currentRow == null) return;

        // si on traite une commande d'une autre societe
        if (currentRow["VSOCIETE"].ToString() != MozartParams.NomSociete)
        {
          string chLocalMozart = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + @"\MOZART\MozartCS.exe";

          // Ouverture de Mozart sur la page de la DI
          Process.Start(chLocalMozart, $"{MozartParams.NomServeur};{currentRow["VSOCIETE"]};{Convert.ToInt32(currentRow["NDINNUM"])};{Convert.ToInt32(currentRow["NACTNUM"])};DELEGATION");
          return;
        }
        // passage des paramètres
        // on enregistre la valeur en cours
        int iNumActionEncours = MozartParams.NumAction;
        int iNumDIEncours = MozartParams.NumDi;

        // écran de modification de la demande
        MozartParams.NumDi = (int)Utils.ZeroIfNull(currentRow["NDINNUM"]);
        MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);

        new frmAddAction()
        {
          mstrStatutDI = "M"
        }.ShowDialog();

        apigrid.Requery(dt, MozartDatabase.cnxMozart);

        // on remet la valeur en cours
        MozartParams.NumAction = iNumActionEncours;
        MozartParams.NumDi = iNumDIEncours;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApidgrid()
    {
      try
      {
        apigrid.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 1000);
        apigrid.AddColumn(Resources.col_Creation, "DCOMDAT", 1200, "dd/mm/yyyy", 2);
        apigrid.AddColumn(Resources.col_Creator, "VCOMNUMCC", 2500);
        apigrid.AddColumn(Resources.col_ChefGroupe, "RESP_GRP", 2200);
        apigrid.AddColumn(Resources.col_Chaff, "CHAFF", 2200);
        apigrid.AddColumn(Resources.col_montantHT, "NCOMPHT", 1400, "## ###", 1);
        apigrid.AddColumn("FO ou STT", "VSTFNOM", 2500);
        apigrid.AddColumn("N°", "CTYPEALL", 1200);
        apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
        apigrid.AddColumn("Filiale", "VSOCIETE", 1500);
        apigrid.AddColumn("Observations", "VRMQ", 2500);
        apigrid.AddColumn("Type", "CTYPE", 0);
        apigrid.AddColumn("CODE", "CODE", 0);
        apigrid.AddColumn("CTYPE_SRC", "CTYPE_SRC", 0);

        apigrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apigrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && (e.Column.Name == "NDINNUM" || e.Column.Name == "DCOMDAT"))
      {
        GridView View = sender as GridView;
        switch (View.GetDataRow(e.RowHandle)["CODE"].ToString())
        {
          case "RED":
            e.Appearance.BackColor = System.Drawing.Color.Red;
            break;
          case "YELLOW":
            e.Appearance.BackColor = System.Drawing.Color.Yellow;
            break;
          case "GREEN":
            e.Appearance.BackColor = MozartColors.ColorHC0FFC0;
            break;
          case "GRAY":
            e.Appearance.BackColor = MozartColors.colorHCCCCCC;
            break;
          default:
            break;
        }
      }
    }

    private void apigrid_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {// on affiche de façon dynamique les boutons 
      DataRow currentRow = apigrid.GetFocusedDataRow();
      if (currentRow == null) return;

      switch (currentRow["CTYPE"].ToString())
      {
        case "TCMDWEBTECH_INFO":
          cmdModifier.Text = Resources.txt_detailDdeVal;

          if (bVisuArchives == false) CmdArchiver.Visible = true;
          CmdArchives.Visible = true;

          cmdDI.Visible = false;
          cmdDoc.Visible = false;
          break;

        default:
          cmdModifier.Text = Resources.txt_detailCde;

          CmdArchiver.Visible = false;
          CmdArchives.Visible = false;

          cmdDI.Visible = true;
          cmdDoc.Visible = true;
          break;
      }
    }

    private void CmdArchiver_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apigrid.GetFocusedDataRow();
      if (currentRow == null) return;

      if (MessageBox.Show(Resources.msg_archivDemandeReappro, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.CnxExecute($"EXEC [api_sp_CommandeReapproTechArchiver] {currentRow["NCOMNUM"]}");
      apigrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void CmdArchives_Click(object sender, EventArgs e)
    {
      string sReq;

      if (bVisuArchives)
      {
        bVisuArchives = false;
        CmdArchiver.Visible = true;
        CmdArchives.Text = Resources.txt_Archives;
        sReq = $"exec [api_sp_ListeDelegationAndDdeReappro] {MozartParams.UID}";
      }
      else
      {
        bVisuArchives = true;
        CmdArchiver.Visible = false;
        CmdArchives.Text = Resources.txt_actifs;
        sReq = $"exec [api_sp_CommandeReapproTech_ListeDelegation] 1";
      }

      // on affiche les archives des reappro validées ou annulées
      apigrid.LoadData(dt, MozartDatabase.cnxMozart, sReq);
    }

    private bool ContratAvecPrestation(int numContrat)
    {
      try
      {
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"Select CCSTTYPE FROM TCST WHERE NCSTNUM= {numContrat}"))
        {
          if (sdr.Read())
            return Utils.BlankIfNull(sdr["CCSTTYPE"]) == "P";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void frmListeDelegation_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (MozartParams.CodePageDemarrage == "DELEGATION")
      {
        Application.Exit();
      }
    }

    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(sender, e);
    }
  }
}