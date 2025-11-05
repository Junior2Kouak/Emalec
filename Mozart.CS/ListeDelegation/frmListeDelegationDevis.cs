using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDelegationDevis : Form
  {
    DataTable dt = new DataTable();

    public frmListeDelegationDevis()
    {
      InitializeComponent();
    }

    private void frmListeDelegationDevis_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        //  couleur et nom de la société
        BackColor = ModuleMain.Couleur(MozartParams.NomSociete);
        ModuleMain.Initboutons(this);

        //init
        Frame1.Visible = false;
        string sReq = $"exec api_sp_listeDelegationDevis {MozartParams.UID}";

        int iDirect = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS NB_DIRECT FROM TDIRECTION WHERE NPERNUM = {MozartParams.UID}");
        cmdLegende.Visible = (iDirect > 0);

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, sReq, 180);
        apigrid.GridControl.DataSource = dt;

        InitApidgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApidgrid()
    {
      try
      {
        apigrid.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 1000, "", 2);
        apigrid.AddColumn("N° GMAO", "VACTNUMGMAO", 1000, "", 2);
        apigrid.AddColumn(Resources.col_Creation, "DDCLDAT", 1200, "dd/mm/yyyy", 2);
        apigrid.AddColumn(Resources.col_Creator, "VDCLCC", 2500);
        apigrid.AddColumn(Resources.col_ChefGroupe, "RESP_GRP", 2200);
        apigrid.AddColumn(Resources.col_Chaff, "CHAFF", 2200);
        apigrid.AddColumn(Resources.col_montantHT, "NDCLHT", 1400, "## ###", 1);
        apigrid.AddColumn(MZCtrlResources.col_Devis, "NDCLNUM", 1200, "", 2);
        apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500);
        apigrid.AddColumn(MZCtrlResources.col_Site, "VSITNOM", 1500);
        apigrid.AddColumn(MZCtrlResources.col_Type, "CDEVISTYPE", 700, "", 2);
        apigrid.AddColumn(MZCtrlResources.col_Filiale, "VSOCIETE", 1500);
        //apigrid.AddColumn("Type", "CTYPE", 0);
        apigrid.AddColumn("CODE", "CODE", 0);
        apigrid.AddColumn("NACTNUM", "NACTNUM", 0);
        //apigrid.AddColumn("CTYPE_SRC", "CTYPE_SRC", 0);
        apigrid.AddColumn(MZCtrlResources.col_Remarque, "VRMQ", 2500);

        apigrid.InitColumnList();
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
          string chLocalMozart = MozartParams.CheminProgrammeMozart + @"MozartCS.exe";

          // Ouverture de Mozart sur la page de la DI
          Process.Start(chLocalMozart, $"{MozartParams.NomServeur};{currentRow["VSOCIETE"]};{Convert.ToInt32(currentRow["NDINNUM"])};{Convert.ToInt32(currentRow["NACTNUM"])};DELEGATIONDEVIS");
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

    private void apigrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && (e.Column.Name == "NDINNUM" || e.Column.Name == "DDCLDAT"))
      {
        GridView View = sender as GridView;
        if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "RED") e.Appearance.BackColor = System.Drawing.Color.Red;
        if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "YELLOW") e.Appearance.BackColor = System.Drawing.Color.Yellow;
        if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "GREEN") e.Appearance.BackColor = MozartColors.ColorHC0FFC0;
        if (View.GetDataRow(e.RowHandle)["CODE"].ToString() == "GRAY") e.Appearance.BackColor = MozartColors.colorHCCCCCC;
      }
    }

    private void frmListeDelegationDevis_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (MozartParams.CodePageDemarrage == "DELEGATIONDEVIS")
      {
        Application.Exit();
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

          string chLocalMozart = MozartParams.CheminProgrammeMozart + @"MozartCS.exe";
          string lParams = $"{MozartParams.NomServeur};{currentRow["VSOCIETE"]};{currentRow["NDINNUM"]};{currentRow["NACTNUM"]};{currentRow["CDEVISTYPE"]};{currentRow["NDCLNUM"]}";

          // Ouverture de Mozart sur la page du devis
          Process.Start(chLocalMozart, lParams);

          apigrid.Requery(dt, MozartDatabase.cnxMozart);
          return;
        }

        //  *************************************************************************************************************
        //  traitement dans le Mozart courant
        //  passage des paramètres
        //  on enregistre la valeur en cours
        int iNumActionEncours = MozartParams.NumAction;
        MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);
        int iNumDIEncours = MozartParams.NumDi;
        MozartParams.NumDi = (int)Utils.ZeroIfNull(currentRow["NDINNUM"]);

        switch (currentRow["CDEVISTYPE"].ToString())
        {
          //case "B":
          case "G":
            //  Nouveaux devis : B(rouillon) ou G (Validé)
            new frmDevisClient2
            {
              miNumDI = MozartParams.NumDi,
              miNumAction = MozartParams.NumAction,
              mstrStatutAlerte = "OUI"
            }.ShowDialog();
            break;

          case "F":
            // Anciens devis (type 'F')
            new frmDevisClient
            {
              miNumDI = MozartParams.NumDi,
              miNumAction = MozartParams.NumAction
            }.ShowDialog();
            break;

          case "P":
            // Devis de prestation (type 'P')
            new frmDevisClientPrestation
            {
              miNumAction = MozartParams.NumAction,
              mstrStatutAlerte = "OUI"
            }.ShowDialog();
            break;

          default:
            break;
        }

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

    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(sender, e);
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame1.Visible = !Frame1.Visible;
    }
  }
}
