using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestNotes : Form
  {

    DataTable dt = new DataTable();

    public frmGestNotes() { InitializeComponent(); }
    
    const string BASE_URL = "https://www.sun-api.bpce.fr/EMALEC/task";
    
    private void frmGestMessageWebSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apiTGridMess.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeNotesGeronimmo");
        apiTGridMess.GridControl.DataSource = dt;

        InitApigrid();

        txtMessage.Text = "";

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEnvoyer_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      try
      {
        DataRow currentRow = apiTGridMess.GetFocusedDataRow();
        if (currentRow == null) return;

        if (string.IsNullOrEmpty(txtMessage.Text))
        {
          MessageBox.Show($"Il faut saisir un message", MozartCS.Properties.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        string result = "";
        Uri url = new Uri($"{BASE_URL}/update/updateTask");


        // il s'agit d'une note
          // envoyer une note d'information
          Geronimmo.GERONIMMO_UPDATE INFO = new Geronimmo.GERONIMMO_UPDATE
          {
            u_number = currentRow["VGERO_Number"].ToString(),
            u_action = "INFO",
            u_external_reference = $"DI{MozartParams.NumDi}",
            u_maintainer_comment = txtMessage.Text,
            u_end_date_of_intervention = "",
            u_effective_date_of_intervention = "",
            u_planned_date = ""
          };

          // envoi de la note
          if (!Geronimmo.CallUpdateTask(url, INFO, ref result))
            throw new Exception($"{result}");

          //LogInfo($"GMAO: {txtNumTask.Text},\tEnvoi de commentaires sur une demande, Action {NACTNUM}{Environment.NewLine}{Environment.NewLine}");


      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      Cursor.Current = Cursors.Default;

    }


    private void apiTGridMess_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGridMess.GetFocusedDataRow();
      if (currentRow == null) return;

      txtFields4.Text = Utils.BlankIfNull(currentRow["VNOTE"]);
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridMess.GetFocusedDataRow();
      if (currentRow == null) return;

        ModuleData.CnxExecute($"UPDATE TGERONIMMO_NOTE SET VSTATUT = 'L' WHERE ID = {Utils.ZeroIfNull(currentRow["ID"])}");
        apiTGridMess.Requery(dt, MozartDatabase.cnxMozart);
        txtFields4.Text = "";
    }

    private void InitApigrid()
    {

      try
      {
        if (apiTGridMess.dgv.Columns.Count == 0)
        {
          apiTGridMess.AddColumn("N° geronimmo", "VGERO_Number", 1200);
          apiTGridMess.AddColumn("DI Emalec", "NDINNUM", 1400);
          apiTGridMess.AddColumn(Resources.col_Auteur, "VAUTEUR", 2000);
          apiTGridMess.AddColumn("Date Note", "DDATECREA", 1500, "dd/MM/yyyy HH:mm");
          apiTGridMess.AddColumn(Resources.col_Demandeur, "VGERO_SITE_CONTACT", 1400);
          apiTGridMess.AddColumn("Remarques", "VGERO_NOTES", 2500);
          apiTGridMess.AddColumn(Resources.col_Site, "VGERO_SITE_NOM", 2000);
          apiTGridMess.AddColumn(Resources.col_Description, "VGERO_SITE_DESCRIPTION_DEMANDE", 5600);
          apiTGridMess.AddColumn(Resources.col_Statut, "VGERO_STATE", 1200);
          apiTGridMess.AddColumn("NACTNUM", "NACTNUM", 0);
          apiTGridMess.AddColumn("Notes", "VNOTE", 0);

          apiTGridMess.DesactiveListe();
          apiTGridMess.InitColumnList();
        }

        apiTGridMess_SelectionChanged(null, null);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

