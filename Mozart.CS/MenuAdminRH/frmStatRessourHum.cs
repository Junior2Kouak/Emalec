using MozartCS.Properties;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatRessourHum : Form
  {
    DataTable dt = new DataTable();


    public frmStatRessourHum() { InitializeComponent(); }

    private void frmStatRessourHum_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Today.AddMonths(-3).ToString("dd/MM/yyyy");
        txtDateA1.Text = DateTime.Today.ToString("dd/MM/yyyy");

        ModuleData.LoadData(dt, $"EXEC api_sp_StatJTravailETR '{txtDateA0.Text}','{txtDateA1.Text}'");

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      ModuleData.LoadData(dt, $"EXEC api_sp_StatJTravailETR '{txtDateA0.Text}', '{txtDateA1.Text}'");
      apiGrid.GridControl.DataSource = dt;

      Cursor.Current = Cursors.Default;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    
    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn(Resources.col_ID, "NIDUNI", 0);
        apiGrid.AddColumn(Resources.col_num_secu, "VPERNUMSECU", 1800);
        apiGrid.AddColumn(Resources.col_Nom, "VPERNOM", 1200);
        apiGrid.AddColumn(Resources.col_Prenom, "VPERPRE", 1200);
        apiGrid.AddColumn(Resources.col_date_naissance, "DPERNAI", 1200);
        apiGrid.AddColumn(Resources.col_nationalité, "VPERNATIONAL", 1200);
        apiGrid.AddColumn(Resources.col_Adresse, "VPERAD", 1000);
        apiGrid.AddColumn(Resources.col_Ville, "VPERLOC", 1100);
        apiGrid.AddColumn(Resources.col_CP, "VPERCP", 800);
        apiGrid.AddColumn(Resources.col_date_entree, "DPERENT", 1200);
        apiGrid.AddColumn(Resources.col_nom_entreprise, "VNOMSIT", 1200);
        apiGrid.AddColumn(Resources.col_pays_dest, "VPAYSDEST", 1100);
        apiGrid.AddColumn(Resources.col_DateArrivee, "DACTDEB", 1100);
        apiGrid.AddColumn(Resources.col_date_depart, "DACTFIN", 1100);

        apiGrid.GridControl.DataSource = dt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdTransfert_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      Excel.Application objXl = new Excel.Application(); // Application Excel
      Excel.Workbooks objWbs; // Classeur Excel
      Excel.Worksheet objSh; // Feuille Excel

      if (MessageBox.Show(Resources.msg_transf_donnees_reg_missions_etranger, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

      Cursor.Current = Cursors.WaitCursor;

      try
      {
        // On kill tous les process EXCEL
        // ModuleMain.EndAllEXCELProcess();

        string sFolder = ModuleMain.RechercheParamByLib("REP_TRANSPEGASE");

        // Test si fichier excel vierge existe
        if (!File.Exists(sFolder + @"Base\RegistreMissions.xls"))
        {
          MessageBox.Show(Resources.msg_fichierExcelPegase, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Cursor.Current = Cursors.Default;
          return;
        }

        string sNewNameExcel = $"RegistreMissions{DateTime.Now.ToString("yyyyMMdd")}.xls";
        File.Copy(sFolder + @"Base\RegistreMissions.xls", sFolder + @"\Archives\" + sNewNameExcel);

        objWbs = objXl.Workbooks;

        // Copie du fichier modele et ouverture du fichier
        objWbs.Open(sFolder + @"Archives\" + sNewNameExcel, Missing.Value, false, Missing.Value, Missing.Value, Missing.Value, true);

        // Utilisation de l'objet feuille d'Excel
        objSh = objXl.ActiveSheet;

        int iPosCurLine = 21;

        foreach (DataRow row in dt.Rows)
        {
          objSh.Cells[iPosCurLine, "A"] = row["NIDUNI"];
          objSh.Cells[iPosCurLine, "B"] = row["VPERNUMSECU"];
          objSh.Cells[iPosCurLine, "C"] = row["VPERNOM"];
          objSh.Cells[iPosCurLine, "D"] = row["VPERPRE"];

          objSh.Cells[iPosCurLine, "E"] = "'" + row["DPERNAI"];
          objSh.Cells[iPosCurLine, "F"] = row["VPERNATIONAL"];

          objSh.Cells[iPosCurLine, "G"] = row["VPERAD"];
          objSh.Cells[iPosCurLine, "H"] = row["VPERLOC"];
          objSh.Cells[iPosCurLine, "I"] = row["VPERCP"];

          objSh.Cells[iPosCurLine, "J"] = "'" + row["DPERENT"];
          objSh.Cells[iPosCurLine, "K"] = row["VNOMSIT"];

          objSh.Cells[iPosCurLine, "L"] = row["VPAYSDEST"];
          objSh.Cells[iPosCurLine, "M"] = "'" + row["DACTDEB"];
          objSh.Cells[iPosCurLine, "N"] = "'" + row["DACTFIN"];

          iPosCurLine += 1;
        }

        objXl.DisplayAlerts = false;
        objWbs.Item[1].Saved = true;
        objWbs.Item[1].Save();
        objWbs.Item[1].Close();

        Cursor.Current = Cursors.Default;

        MessageBox.Show(Resources.msg_transfertTermine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        objSh = null;
        objWbs = null;
        objXl = null;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
  }
}