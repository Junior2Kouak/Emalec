using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmDiSynergee : Form
  {
    DataTable dtNew = new DataTable();
    DataTable dtEnCours = new DataTable();
    //Dim rs As ADODB.Recordset
    //Dim rs2 As ADODB.Recordset

    public frmDiSynergee() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmDiSynergee_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGridNew.LoadData(dtNew, MozartDatabase.cnxMozart, $"exec api_sp_listeDISynergeeNew");
        apiTGridNew.GridControl.DataSource = dtNew;
        InitApiTgridNew();

        apiTGridEnCours.LoadData(dtEnCours, MozartDatabase.cnxMozart, $"exec api_sp_listeDISynergeeEnCours");
        apiTGridEnCours.GridControl.DataSource = dtEnCours;
        InitApiTgridEnCours();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdCreerDi_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGridNew.GetFocusedDataRow();
        if (row == null) return;

        MozartParams.NumDi = 0;

        //recherche de correspondance du site
        int NumSite = GetNumSite((int)row["NCLINUM"], (string)row["VSYNSITE"]);

        if (NumSite == 0) return;

        //Test si la DI est déjà prise
        if (DiBloquee())
        {
          MessageBox.Show(Resources.msg_Di_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        ModuleData.ExecuteNonQuery($"update TDISYNERGEE set CSYNDILOCK = 'O' where NSYNNUM = {row["NSYNNUM"]} and NSYNCLINUM = {row["NCLINUM"]}"); //on la bloque

        MozartParams.Action = $"{ Utils.BlankIfNull(row["VSYNEQPT"])}\r\n{Utils.BlankIfNull(row["VSYNDESC"])}";
        MozartParams.DateAction = "";

        Cursor.Current = Cursors.WaitCursor;
        new frmAddAction()
        {
          mstrStatutDI = "SYNERGEE",
          miNumClient = (int)row["NCLINUM"],
          miNumSite = NumSite,
          mstrRefCli = $" DI Synergee : {row["NSYNNUM"]}",
          miNumContrat = 0,
          miNumDISynergee = (int)row["NSYNNUM"],
        }.ShowDialog();

        MozartParams.Action = "";
        MozartParams.DateAction = "";

        //test si la di est créée, on la debloque
        if (!DiTraitee())
          ModuleData.ExecuteNonQuery($"update TDISYNERGEE set CSYNDILOCK = 'N' where NSYNNUM = {row["NSYNNUM"]} and NSYNCLINUM = {row["NCLINUM"]}");

        //rafraichissement
        Cursor.Current = Cursors.WaitCursor;
        apiTGridNew.Requery(dtNew, MozartDatabase.cnxMozart);
        apiTGridEnCours.Requery(dtEnCours, MozartDatabase.cnxMozart);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void cmdSynergee_Click(object sender, EventArgs e)
    {
      //faire une interrogation manuelle des demandes sur Synergee (code 0)
      new frmMenuSynergee(0).ShowDialog();

      //rafraichissement de la liste
      Cursor.Current = Cursors.WaitCursor;
      apiTGridNew.Requery(dtNew, MozartDatabase.cnxMozart);
      apiTGridEnCours.Requery(dtEnCours, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdDetailDi_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridEnCours.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumAction = (int)row["NACTNUM"];
      MozartParams.NumDi = (int)row["NDINNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction()
      {
        mstrStatutDI = "SuiviSYNERGEE",
      }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private int GetNumSite(int NCLINUM, string nsitnue)
    {
      int NSITNUM = (int)ModuleData.ExecuteScalarInt($"select NSITNUM from TSIT where CSITACTIF = 'O' AND NCLINUM = {NCLINUM} and NSITNUE = '{nsitnue}'");
      if (NSITNUM == 0)
        MessageBox.Show($"Le site codifié '{nsitnue}' (TSIT.NSITNUE) n'a pas été trouvé.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return NSITNUM;
    }

    private bool DiBloquee()
    {
      DataRow row = apiTGridNew.GetFocusedDataRow();
      if (null == row) return true;
      return ModuleData.ExecuteScalarString($"select CSYNDILOCK from TDISYNERGEE  where NSYNNUM = {row["NSYNNUM"]} and NSYNCLINUM = {row["NCLINUM"]}") == "O" ? true : false;
    }

    private bool DiTraitee()
    {
      DataRow row = apiTGridNew.GetFocusedDataRow();
      if (null == row) return false;
      int? t = ModuleData.ExecuteScalarInt($"select NACTNUM from TDISYNERGEE where NSYNNUM = {row["NSYNNUM"]} and NSYNCLINUM = {row["NCLINUM"]}");
      return (t == null || t == 0) ? false : true;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApiTgridNew()
    {
      apiTGridNew.AddColumn("DI Syn", "NSYNNUM", 800);
      apiTGridNew.AddColumn("Date Synergee", "DSYNDAT", 1200, "Date");
      apiTGridNew.AddColumn("Client", "VCLINOM", 1000);
      apiTGridNew.AddColumn("Site", "VSYNSITE", 1900);
      apiTGridNew.AddColumn("Équipement", "VSYNEQPT", 1000);
      apiTGridNew.AddColumn("Statut", "VLIBELLE", 4500);
      apiTGridNew.AddColumn("Description", "VSYNDESC", 5000);
      apiTGridNew.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridNew.InitColumnList();
    }


    /* --------------------------------------------------------------------------------------- */
    private void InitApiTgridEnCours()
    {
      apiTGridEnCours.AddColumn("Di Syn", "NSYNNUM", 800);
      apiTGridEnCours.AddColumn("DI Emalec", "NDINNUM", 1000);
      apiTGridEnCours.AddColumn("Date créa Synergee", "DSYNDAT", 1300, "Date");
      apiTGridEnCours.AddColumn("Date mise à jour", "DSYNLASTDMOD", 1300, "Date");
      apiTGridEnCours.AddColumn("Client", "VCLINOM", 1000);
      apiTGridEnCours.AddColumn("Site", "VSITNOM", 1900);
      apiTGridEnCours.AddColumn("Équipement", "VSYNEQPT", 0);
      apiTGridEnCours.AddColumn("Statut", "VLIBELLE", 5000);
      apiTGridEnCours.AddColumn("Description", "VSYNDESC", 5000);
      apiTGridEnCours.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGridEnCours.InitColumnList();
    }

    private void bntArchiver_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridEnCours.GetFocusedDataRow();
      if (null == row) return;

      // on garde l'ancien statut en mémoire en ajoutant 99 (on le retrouve en enlevant 99)
      if (MessageBox.Show(Resources.msg_confirm_archive_demande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.ExecuteScalarInt($"Update TDISYNERGEE Set NSYNSTATUS = NSYNSTATUS + 99 where NSYNNUM = {row["NSYNNUM"]} and NACTNUM = {row["NACTNUM"]}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGridEnCours.Requery(dtEnCours, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;

    }

    private void btnArchiverNew_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridNew.GetFocusedDataRow();
      if (null == row) return;

      // on garde l'ancien statut en mémoire en ajoutant 99 (on le retrouve en enlevant 99)
      if (MessageBox.Show(Resources.msg_confirm_archive_demande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.ExecuteScalarInt($"Update TDISYNERGEE Set NSYNSTATUS = (NSYNSTATUS + 99) where NSYNNUM = {row["NSYNNUM"]} and NACTNUM = {row["NACTNUM"]}");

      Cursor.Current = Cursors.WaitCursor;
      apiTGridNew.Requery(dtNew, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;

    }

    private void btnListeArchives_Click(object sender, EventArgs e)
    {
      new frmListeSynergieeArchive().ShowDialog();

      apiTGridNew.Requery(dtNew, MozartDatabase.cnxMozart);

    }
  }
}

