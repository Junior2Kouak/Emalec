using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmDiGDM_Decision : Form
  {
    DataTable dt = new DataTable();

    public frmDiGDM_Decision() { InitializeComponent(); }

    private void frmDiGDM_Decision_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from TGDM inner join TGDM_TCLI on TGDM.VCODECLIENT = TGDM_TCLI.VCODECLIENT INNER JOIN TCLI ON TCLI.NCLINUM = TGDM_TCLI.NCLINUM INNER JOIN TACT ON TACT.NACTNUM = TGDM.NACTNUM INNER JOIN TREF_ETAGDM ON TREF_ETAGDM.CSTATUT = TGDM.CSTATUT WHERE TGDM.CSTATUT = 'R' AND TCLI.VSOCIETE = '{MozartParams.NomSociete}' order by NGDMNUM desc");
        apiTGrid1.GridControl.DataSource = dt;

        InitApiTgrid();
        apiTGrid1_Click(null, null);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
 
    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("N°", "NGDMNUM", 400);
      apiTGrid1.AddColumn("N°DI", "VDIEMALEC", 1000);
      apiTGrid1.AddColumn("Client", "VCLINOM", 1200);
      apiTGrid1.AddColumn("Statut", "VLIBELLE", 1300);
      apiTGrid1.AddColumn("Type demande", "VTYPEDEMANDE", 400);
      apiTGrid1.AddColumn("Date création", "DDATECREATION", 1700, "Date");
      apiTGrid1.AddColumn("Activité GDM", "VACTIVITE", 1000);
      apiTGrid1.AddColumn("DI GDM", "VDIGDM", 1000);
      apiTGrid1.AddColumn("Site", "VNOMSITE", 1500);
      apiTGrid1.AddColumn("Description", "VDESCRIPTION", 3600);
      apiTGrid1.AddColumn("NACTNUM", "NACTNUM", 0);

      apiTGrid1.InitColumnList();
    }

    private void apiTGrid1_Click(object sender, EventArgs e)
    {
      //afficher les éléments GDM / Action EMALEC
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      txtDI.Text = (string)row["VDIEMALEC"];
      txtDtCloture.Text = Utils.DateBlankIfNull(row["DDATECLOTUREINTERV"]) == "01/01/1900" ? "" : Utils.DateBlankIfNull(row["DDATECLOTUREINTERV"]);
      txtDtFinPrev.Text = Utils.DateBlankIfNull(row["DDATEFINPREVUE"]);
      txtDtPlanif.Text = Utils.DateBlankIfNull(row["DDATEPLANIFIEE"]) == "01/01/1900" ? "" : Utils.DateBlankIfNull(row["DDATEPLANIFIEE"]);
      txtDescription.Text = (string)row["VDESCRIPTION"];

      txtDIAct.Text = row["NDINNUM"].ToString();
      txtAction.Text = row["NACTNUM"].ToString();
      txtDtClotureAct.Text = Utils.DateBlankIfNull(row["DACTDEX"]);
      txtDtFinPrevAct.Text = Utils.DateBlankIfNull(row["DACTDAT"]);
      txtDtPlanifAct.Text = Utils.DateBlankIfNull(row["DACTPLA"]);
      txtDescriptionAct.Text = (string)row["VACTDES"];
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
 
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (txtAction.Text == "") return;

      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      //Intégrer dans l'action les données potentiellement modifiées (description, date de fin prévue)
      update_TACT();

      //écran de modification de l'action
      MozartParams.NumAction = (int)row["NACTNUM"];
      MozartParams.NumDi = (int)row["NDINNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmAddAction
      {
        mstrStatutDI = "DécisionGDM",
        miNumDIGDM = Convert.ToInt32(row["VDIGDM"]),
      }.ShowDialog();

      //rafraichissement
      txtDI.Text = "";
      txtDtCloture.Text = "";
      txtDtFinPrev.Text = "";
      txtDtPlanif.Text = "";
      txtDescription.Text = "";
      txtDIAct.Text = "";
      txtAction.Text = "";
      txtDtClotureAct.Text = "";
      txtDtFinPrevAct.Text = "";
      txtDtPlanifAct.Text = "";
      txtDescriptionAct.Text = "";

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
  
    private void update_TACT()
    {
      ModuleData.ExecuteNonQuery($"UPDATE TACT SET VACTDES = '{txtDescriptionAct.Text.Replace("'", "''")}{Environment.NewLine}{Environment.NewLine}" +
                                 $"{txtDescription.Text.Replace("'", "''")}', DACTDAT = '{txtDtFinPrev.Text}' WHERE NACTNUM = {txtAction.Text}");
      //Màj Statut GDM
      ModuleData.ExecuteNonQuery($"UPDATE TGDM SET CSTATUT = 'I' WHERE NACTNUM = {txtAction.Text}");
    }
    
  }
}

