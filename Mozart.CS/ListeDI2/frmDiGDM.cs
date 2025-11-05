using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDiGDM : Form
  {
    DataTable dt = new DataTable();

    public frmDiGDM() { InitializeComponent(); }

    private void frmDiGDM_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from TGDM inner join TGDM_TCLI on TGDM.VCODECLIENT = TGDM_TCLI.VCODECLIENT INNER JOIN TCLI ON TCLI.NCLINUM = TGDM_TCLI.NCLINUM INNER JOIN TREF_ETAGDM ON TREF_ETAGDM.CSTATUT = TGDM.CSTATUT WHERE TGDM.CSTATUT = 'N' AND TCLI.VSOCIETE = '{MozartParams.NomSociete}' AND NACTNUM is null order by NGDMNUM desc");
        apiTGrid1.GridControl.DataSource = dt;

        InitApiTgrid();

        //Couleur bouton des décisions GDM (rouge si quelque chose)
        cmdDecisionGDM.BackColor = GetDecisionGDM() >= 1 ? Color.Red : MozartColors.ColorH8000000F;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumDi = 0;

      //Test si la DI est déjà prise
      if (DiBloquee())
      {
        MessageBox.Show(Resources.msg_Di_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      ModuleData.ExecuteNonQuery($"update TGDM set CGDMDILOCK = 'O' where NGDMNUM = {row["NGDMNUM"]}");

      if ((string)row["VTYPEDEMANDE"] == "DI")
        MozartParams.Action = Utils.BlankIfNull(row["VACTIVITE"]) + "\r\n" + Utils.BlankIfNull(row["VDESCRIPTION"]);
      else if ((string)row["VTYPEDEMANDE"] == "DD")
        MozartParams.Action = "\r\n" + "ATTENTION : CECI EST UNE DEMANDE DE DEVIS" + "\r\n\r\n" + Utils.BlankIfNull(row["VACTIVITE"]) + "\r\n" + Utils.BlankIfNull(row["VDESCRIPTION"]);

      MozartParams.DateAction = Convert.ToString(row["DDATEFINPREVUE"]);

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "GDM",
        miNumClient = (int)(row["NCLINUM"]),
        miNumSite = GetNSITNUM((int)row["NCLINUM"], (string)row["VCODESITE"]),
        miNumDIGDM = (int)(row["NGDMNUM"]),
        mstrRefCli = (string)row["VDIGDM"],
        miNumContrat = 0,
        mTypeDemandeGDM = (string)row["VTYPEDEMANDE"],
      }.ShowDialog();

      MozartParams.Action = "";
      MozartParams.DateAction = "";

      //test si la di est créee, on la débloque
      if (!DiTraitee())
        ModuleData.ExecuteNonQuery($"update TGDM set CGDMDILOCK = 'N' where NGDMNUM = {row["NGDMNUM"]}");

      //rafraichissement
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_confirm_archive_demande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      //archiver
      ModuleData.ExecuteNonQuery($"update TGDM set CSTATUT = 'T' where NGDMNUM ={row["NGDMNUM"]}");
      //rafraichissement
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private int GetNSITNUM(int NCLINUM, string nsitnue)
    {
      int NSITNUM = (int)ModuleData.ExecuteScalarInt($"select NSITNUM from TSIT  where CSITACTIF = 'O' AND NCLINUM = {NCLINUM} and nsitnue = '{nsitnue}'");
      if (NSITNUM == 0)
        MessageBox.Show($"Le site codifié '{nsitnue}' (TSIT.NSITNUE) n'a pas été trouvé.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return NSITNUM;
    }

    private int GetDecisionGDM()
    {
      return (int)ModuleData.ExecuteScalarInt("select count(NGDMNUM) FROM TGDM inner join TGDM_TCLI on TGDM.VCODECLIENT = TGDM_TCLI.VCODECLIENT INNER JOIN TCLI ON TCLI.NCLINUM = TGDM_TCLI.NCLINUM where TGDM.CSTATUT = 'R' and tcli.vsociete = App_Name()");
    }

    private bool DiBloquee()
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return true;
      return ModuleData.ExecuteScalarString($"select CGDMDILOCK from TGDM  where NGDMNUM = {row["NGDMNUM"]}") == "O" ? true : false;
    }

    private bool DiTraitee()
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return false;
      return ModuleData.ExecuteScalarInt($"select NACTNUM from TGDM  where NGDMNUM = {row["NGDMNUM"]}") == null ? false : true;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("N°", "NGDMNUM", 400);
      apiTGrid1.AddColumn("Client", "VCLINOM", 1200);
      apiTGrid1.AddColumn("Statut", "VLIBELLE", 1000);
      apiTGrid1.AddColumn("Type demande", "VTYPEDEMANDE", 400);
      apiTGrid1.AddColumn("Date création", "DDATECREATION", 1700, "Date");
      apiTGrid1.AddColumn("Activité GDM", "VACTIVITE", 1800);
      apiTGrid1.AddColumn("DI GDM", "VDIGDM", 1000);
      apiTGrid1.AddColumn("Site", "VNOMSITE", 1500);
      apiTGrid1.AddColumn("Description", "VDESCRIPTION", 3600);
      apiTGrid1.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGrid1.InitColumnList();
    }

    private void cmdDecisionGDM_Click(object sender, EventArgs e)
    {
      new frmDiGDM_Decision().ShowDialog();
    }
  }
}

