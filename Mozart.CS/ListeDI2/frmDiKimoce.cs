using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDiKimoce : Form
  {
    DataTable dtNew = new DataTable();
    DataTable dtEnCours = new DataTable();

    public frmDiKimoce() { InitializeComponent(); }

    private void frmDiKimoce_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridHaut.LoadData(dtNew, MozartDatabase.cnxMozart, "exec api_sp_listeDIKimoceNew");
        apiTGridHaut.GridControl.DataSource = dtNew;
        InitApiTgridHaut();

        apiTGridBas.LoadData(dtEnCours, MozartDatabase.cnxMozart, "exec api_sp_listeDIKimoceEnCours");
        apiTGridBas.GridControl.DataSource = dtEnCours;
        InitApiTgridBas();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdCreerDi_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridHaut.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumDi = 0;

      //  Recherche de correspondance du site
      int NumSite = GetNumSite(Convert.ToInt32(row["NCLINUM"]), row["VKIMSITE"].ToString());
      if (NumSite == 0) return;

      //  Test si la DI est déjà prise
      if (DiBloquee(row))
      {
        MessageBox.Show("§Cette DI est en cours de traitement§", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      else // on la bloque
        ModuleData.ExecuteNonQuery($"UPDATE TDIKIMOCE set CKIMDILOCK = 'O' where NKIMNUM = {row["NKIMNUM"]}");


      Cursor.Current = Cursors.WaitCursor;
      frmAddAction f = new frmAddAction();
      f.mstrStatutDI = "KIMOCE";
      f.miNumClient = Convert.ToInt32(row["NCLINUM"]);
      f.miNumSite = NumSite;
      f.mstrRefCli = " DI Kimoce : " + row["NKIMNUM"].ToString();
      f.miNumContrat = 0;
      f.msNumDIKimoce = row["NKIMNUM"].ToString();
      f.mTypeDemandeGDM = "Maintenance";
      MozartParams.Action = $"{Utils.BlankIfNull(row["VKIMLIB_OBJET"])}\r\n{Utils.BlankIfNull(row["VKIMDESC"])}";
      MozartParams.DateAction = "";

      f.ShowDialog();

      MozartParams.Action = "";
      MozartParams.DateAction = "";

      //  Test si la DI est créée, on la debloque
      if (!DiTraitee(row))
        ModuleData.ExecuteNonQuery($"UPDATE TDIKIMOCE set CKIMDILOCK = 'N' where NKIMNUM = {row["NKIMNUM"]}");
      else
        // On marque la DI pour envoi de la prise en charge (PEC)
        // a corriger avec les 4 statuts
        ModuleData.ExecuteNonQuery($"UPDATE TDIKIMOCE SET BSTATUSNEW = 1 WHERE NACTNUM = 0 AND NKIMNUM = {row["NKIMNUM"]}");

      //  Rafraichissement
      apiTGridHaut.Requery(dtNew, MozartDatabase.cnxMozart);
      apiTGridBas.Requery(dtEnCours, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdDetailDi_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridBas.GetFocusedDataRow();
      if (row == null) return;
      Cursor.Current = Cursors.WaitCursor;

      Cursor.Current = Cursors.WaitCursor;
      frmAddAction f = new frmAddAction();
      f.mstrStatutDI = "SuiviKIMOCE";
      MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);
      MozartParams.NumDi = Convert.ToInt32(row["NDINNUM"]);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private int GetNumSite(int NCLINUM, string nsitnue)
    {
      int NSITNUM = (int)ModuleData.ExecuteScalarInt($"select NSITNUM from TSIT where CSITACTIF = 'O' AND NCLINUM = {NCLINUM} and NSITNUE = '{nsitnue}'");
      if (NSITNUM == 0)
        MessageBox.Show($"Le site codifié '{nsitnue}' (TSIT.NSITNUE) n'a pas été trouvé.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return NSITNUM;
    }

    private bool DiBloquee(DataRow row)
    {
      return ModuleData.ExecuteScalarString($"select CKIMDILOCK from TDIKIMOCE where NKIMNUM = {row["NKIMNUM"]}") == "N" ? false : true;
    }

    private bool DiTraitee(DataRow row)
    {
      return ModuleData.ExecuteScalarInt($"select IsNull(NACTNUM, 0) from TDIKIMOCE where NKIMNUM = {row["NKIMNUM"]}") == 0 ? false : true;
    }

    private void InitApiTgridHaut()
    {
      apiTGridHaut.AddColumn("DI KIM", "NKIMNUM", 1200);
      apiTGridHaut.AddColumn("Date Kimoce", "DKIMDATE_DDE", 2000, "dd/MM/yyyy HH:mm:ss");
      apiTGridHaut.AddColumn("Statut", "VKIMCODE_PBM", 1200);
      apiTGridHaut.AddColumn("Équipement", "VKIMLIB_OBJET", 1400);
      apiTGridHaut.AddColumn("Demandeur", "VKIMCONTACT", 1400);
      apiTGridHaut.AddColumn("Site", "VSITNOM", 2000);
      apiTGridHaut.AddColumn("Code Site", "VKIMSITE", 2000);
      apiTGridHaut.AddColumn("Description", "VKIMDESC", 5600);
      apiTGridHaut.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridHaut.InitColumnList();
    }

    private void InitApiTgridBas()
    {
      apiTGridBas.AddColumn("Di KIM", "NKIMNUM", 1200);
      apiTGridBas.AddColumn("DI Emalec", "NDINNUM", 1400);
      apiTGridBas.AddColumn("Date Kimoce", "DKIMDATE_DDE", 2000, "dd/MM/yyyy HH:mm:ss");
      apiTGridBas.AddColumn("Statut", "VKIMCODE_PBM", 1200);
      apiTGridBas.AddColumn("Demandeur", "VKIMCONTACT", 1400);
      apiTGridBas.AddColumn("Équipement", "VKIMLIB_OBJET", 0);
      apiTGridBas.AddColumn("Site", "VSITNOM", 2400);
      apiTGridBas.AddColumn("Description", "VKIMDESC", 5600);
      apiTGridBas.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridBas.InitColumnList();
    }
  }
}