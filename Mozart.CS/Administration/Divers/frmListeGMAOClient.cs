using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeGMAOClient : Form
  {
    private DataTable mDt = new DataTable();

    public frmListeGMAOClient()
    {
      InitializeComponent();
    }

    private void frmListeGMAOClient_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        initGrid();

        // 6 = 'Aucune' .. n'est pas modifiable
        string lQuery = "SELECT ID, LIBELLE FROM TREF_GMAO WHERE ID <> 6";
        apiTGrid1.LoadData(mDt, MozartDatabase.cnxMozart, lQuery);
        apiTGrid1.GridControl.DataSource = mDt;
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

    private void initGrid()
    {
      apiTGrid1.AddColumn(MZCtrlResources.col_No, "ID", 1800, "", 0);
      apiTGrid1.AddColumn(MZCtrlResources.col_libelle, "LIBELLE", 1000, "", 2);

      apiTGrid1.InitColumnList();
    }

    private void afficherBoiteDeSaisie(int pId, string pLibelle)
    {
      string lPrompt;

      if (pId == -1)
      {
        lPrompt = "Saisissez le nom de la GMAO à ajouter :";
      }
      else
      {
        lPrompt = "Modifier la GMAO :";
      }

      string lResult = Interaction.InputBox(lPrompt, Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title, pLibelle);
      if (!string.IsNullOrEmpty(lResult))
      {
        lResult = lResult.Trim().Replace("'", "''");
        if (!string.IsNullOrEmpty(lResult))
        {
          if (pId == -1)
          {
            MozartDatabase.ExecuteNonQuery($"INSERT INTO TREF_GMAO(LIBELLE) VALUES ('{lResult}')");
          }
          else
          {
            MozartDatabase.ExecuteNonQuery($"UPDATE TREF_GMAO SET LIBELLE = '{lResult}' WHERE ID = {pId}");
          }

          apiTGrid1.Requery(mDt, MozartDatabase.cnxMozart);
        }
      }
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      afficherBoiteDeSaisie(-1, "");
    }

    private void cmdModif_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      afficherBoiteDeSaisie(Convert.ToInt32(row["ID"]), row["LIBELLE"].ToString());
    }
  }
}
