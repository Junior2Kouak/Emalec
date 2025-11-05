using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeDataTablet : Form
  {
    DataTable dt = new DataTable();

    public frmListeDataTablet() { InitializeComponent(); }

    private void frmListeDataTablet_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeActTablet 'O'");
        apiTGrid.GridControl.DataSource = dt;

        InitData();
        InitapiGridClients();
        InitapiGridChaff();
                ColorBouton();
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

    private void ColorBouton()
    {                        
        BtnInventairesEquipement.BackColor = MozartDatabase.ExecuteScalarInt("EXEC [api_sp_InvEquip_GetNbInvEnAttenteTraitement]") > 0 ? Color.Yellow : DefaultBackColor;
    }


    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

                //vérification si di inventaire equipements
                if (MozartDatabase.ExecuteScalarInt($"EXEC [api_sp_InvEquip_GetActionInventaire] {(int)row["NACTNUM"]}") > 0)
                {
                    if(MessageBox.Show("ATTENTION : Vous êtes sur le point de traiter une tablette inventaire.\r\n\r\n" +
                        "Les tablettes d'inventaires sont à la charge du service Méthodes.\r\n" +
                        "Il faut au préalable vérifier la bonne réception de l'inventaire dans le menu dédié.\r\n" +
                        "Souhaitez-vous vraiment traiter cette tablette ?\r\n" +
                        "(Oui pour continuer / Non pour annuler)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        { return; }                    
                }

        //écran de modification de l'action
        MozartParams.NumActTablet = (int)row["NACTNUM"];
        MozartParams.NumAction = (int)row["NACTNUM"];
        MozartParams.NumDi = (int)row["NDINNUM"];

        Cursor.Current = Cursors.WaitCursor;

        new frmAddAction
        {
          mstrStatutDI = "Tablet",
        }.ShowDialog();


        //avant requery sinon perte du recordset sélectionné
        ModuleData.ExecuteNonQuery($"exec api_sp_SendMailTabletHrPrevCtrl {row["NACTNUM"]}, '{MozartParams.NomSociete}'");

        Cursor.Current = Cursors.WaitCursor;
        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdAnnule_Click(object sender, EventArgs e)
    {
      FrameWeb.Visible = false;
      framAct.Visible = false;
    }
    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Vous allez-archiver cette ligne, êtes-vous sûre?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      string sSQL = $"UPDATE TACTTABLET SET NPERNUM = 10, DDATVALIDATION = getdate() WHERE NACTNUM = {row["NACTNUM"]}";

      ModuleData.ExecuteNonQuery(sSQL);

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    private void InitapiGridClients()
    {
      DataTable dtLocal = new DataTable();

      string s1 = $"SELECT count(*) as NB, VCLINOM FROM TACTTABLET WITH (NOLOCK)INNER JOIN TPER TECH WITH (NOLOCK) ON TECH.NPERNUM = NTECHNUM INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM = TACTTABLET.NACTNUM INNER JOIN ";
      string s2 = $"TSIT WITH (NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TCLI WITH (NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM LEFT OUTER JOIN TPER UTIL WITH (NOLOCK) ON UTIL.NPERNUM = TACTTABLET.NPERNUM INNER JOIN ";
      string s3 = $"TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM WHERE DDATVALIDATION IS NULL AND (TACTTABLET.DACTARR IS NOT NULL OR TACTTABLET.DACTDEX IS NOT NULL) AND TCLI.VSOCIETE = '{MozartParams.NomSociete}' group by vclinom order by NB desc";

      apiTGridClients.LoadData(dtLocal, MozartDatabase.cnxMozart, s1 + s2 + s3);
      apiTGridClients.GridControl.DataSource = dtLocal;

      apiTGridClients.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2600);
      apiTGridClients.AddColumn(Resources.col_Nombre, "NB", 600);

      apiTGridClients.InitColumnList();
    }
    private void InitapiGridChaff()
    {
      DataTable dtLocal = new DataTable();

      string sql = $"SELECT count(*) as NB, VDINCHAFF FROM TACTTABLET WITH (NOLOCK)INNER JOIN TPER TECH WITH (NOLOCK) ON TECH.NPERNUM = NTECHNUM INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM = TACTTABLET.NACTNUM INNER JOIN " +
                  $"TSIT WITH (NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM INNER JOIN TCLI WITH (NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM LEFT OUTER JOIN TPER UTIL WITH (NOLOCK) ON UTIL.NPERNUM = TACTTABLET.NPERNUM INNER JOIN " +
                  $"TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM WHERE DDATVALIDATION IS NULL AND (TACTTABLET.DACTARR IS NOT NULL OR TACTTABLET.DACTDEX IS NOT NULL) AND TCLI.VSOCIETE = '{MozartParams.NomSociete}' group by VDINCHAFF order by NB desc";

      apiTGridChaff.LoadData(dtLocal, MozartDatabase.cnxMozart, sql);
      apiTGridChaff.GridControl.DataSource = dtLocal;

      apiTGridChaff.AddColumn(Resources.col_Chaff, "VDINCHAFF", 2600);
      apiTGridChaff.AddColumn(Resources.col_Nombre, "NB", 600);

      apiTGridChaff.InitColumnList();
    }
    
    private void CmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        txtAct.Text = (string)row["VACTDES"];
        string sAttach = "";

        //info attachement du technicien
        using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ReturnInfoAttachTablet {row["NACTNUM"]}"))
        {
          if (dr.Read())
          {
            sAttach = $"DETAIL DE LA PRESTATION REALISEE :{Environment.NewLine}{Utils.BlankIfNull(dr["VATTACHCHAP1"])}{Environment.NewLine}{Environment.NewLine}" +
                      $"DEMANDES COMPLEMENTAIRES DU RESPONSABLE SITE :{Environment.NewLine}{Utils.BlankIfNull(dr["VATTACHCHAP2"])}{Environment.NewLine}{Environment.NewLine}" +
                      $"REMARQUES DU TECHNICIEN :{Environment.NewLine}{Utils.BlankIfNull(dr["VATTACHCHAP3"])}{Environment.NewLine}{Environment.NewLine}" +
                      $"FOURNITURES UTILISEES PRISES DANS LE STOCK DU CLIENT :{Environment.NewLine}{Utils.BlankIfNull(dr["VATTACHCHAP4"])}{Environment.NewLine}{Environment.NewLine}" +
                      $"FOURNITURES UTILISEES LIVREES PAR EMALEC OU FOURNIES PAR LE TECHNICIEN INTERVENANT :{Environment.NewLine}{Utils.BlankIfNull(dr["VATTACHCHAP5"])}{Environment.NewLine}{Environment.NewLine}" +
                      $"ETAT DE LA DEMANDE EN FIN D'INTERVENTION :{Environment.NewLine}{Utils.BlankIfNull(dr["VATTACHCHAP6"])}{Environment.NewLine}{Environment.NewLine}";
          }
        }

        txtWeb.Text = sAttach;
        FrameWeb.Visible = true;
        framAct.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void InitData()
    {
      apiTGrid.AddColumn(Resources.col_Reception, "DDATRECEPT", 2000, "Date", 2);
      apiTGrid.AddColumn(Resources.col_Tech, "TECH", 2000);
      apiTGrid.AddColumn(Resources.col_NumDI, "NDINNUM", 800);
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid.AddColumn(Resources.col_Action, "VACTDES", 3000, "", 0, true);//AddCellTip
      apiTGrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1500);
      apiTGrid.AddColumn(Resources.col_DateArrivee, "DACTARR", 2000, "Date", 2);
      apiTGrid.AddColumn(Resources.col_DateExecution, "DACTDEX", 2000, "Date", 2);
      apiTGrid.AddColumn(Resources.col_AttRecu, "ATT", 1500, "", 2);


      apiTGrid.InitColumnList();
    }
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      OnClosed(e);
    }
    private void frmListeDataTablet_FormClosed(object sender, FormClosedEventArgs e)
    {
      MozartParams.NumActTablet = 0;
      Dispose();
    }

    private void CmdArchives_Click(object sender, EventArgs e)
    {
      new frmListeDataTabletArch().ShowDialog();
    }

        private void BtnInventairesEquipement_Click(object sender, EventArgs e)
        {
            new frmListeInventairesEquipementAValider().ShowDialog();

            ColorBouton();
        }
    }
}

