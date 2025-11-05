using DevExpress.XtraPivotGrid;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatJourAbscence : Form
  {

    DataTable dtAbs = new DataTable();

    public frmStatJourAbscence()
    {
      InitializeComponent();
    }

    private void frmStatJourAbscence_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtDateA0.Text = $"01/{ DateTime.Now.Month}/{ DateTime.Now.Year}";
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        LodaData();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void LodaData()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        dtAbs.Clear();
        dtAbs.Load(ModuleData.ExecuteReader($"exec [api_sp_CalculJourAbscence] '{txtDateA0.Text}', '{txtDateA1.Text}'"));
        PGCHeures.DataSource = dtAbs;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      LodaData();
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


    private void BtnFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void BtnExportXLS_Click(object sender, EventArgs e)
    {
      SFD.Filter = "Fichiers XLSX |*.XLSX";
      string filename = "Export_Stat_JourAbsence_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

      SFD.FileName = filename;

      if (SFD.ShowDialog() == DialogResult.OK)
      {
        if (SFD.FileName != "")
        {
          var pivotExportOptions = new PivotXlsxExportOptions();
          pivotExportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;
          PGCHeures.ExportToXlsx(SFD.FileName, pivotExportOptions);
        }
      }
    }

  }
}

