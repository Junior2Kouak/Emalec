using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.RealisationMPT
{
  public partial class frmListeMessagesTabletTechs : Form
  {

    DateTime _curDate = DateTime.MinValue;
    public frmListeMessagesTabletTechs()
    {
      InitializeComponent();
    }

    private void frmListeMessagesTabletTechs_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        txtDateA0.Text = $"01/01/{DateTime.Now.Year}";
        txtDateA1.Text = DateTime.Now.ToShortDateString();

        InitTGrid();
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

    private void InitTGrid()
    {
      apiTGrid.AddColumn("Technicien", "VTECH", 1700);
      apiTGrid.AddColumn("Client", "VCLINOM", 1700);
      apiTGrid.AddColumn("Chaff", "VCHAFF", 1700);
      apiTGrid.AddColumn("Groupe", "LIBGROUPE", 1700);
      apiTGrid.AddColumn("Ville", "VSITVIL", 1700);
      apiTGrid.AddColumn("DI", "NDINNUM", 700);
      apiTGrid.AddColumn("N° action", "NACTID", 700);
      apiTGrid.AddColumn("Date message", "VDATE_MSG", 1000, "dd/mm/yyyy");
      apiTGrid.AddColumn("Message", "VMSG", 2500);

      apiTGrid.InitColumnList();
    }

    private void LoadData()
    {
      string sql;
      sql = $"exec [api_sp_ListeMessageTabletTech] '{txtDateA0.Text}', '{txtDateA1.Text}'";

      DataTable dt = new DataTable();
      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
      apiTGrid.GridControl.DataSource = dt;
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void cmdDate1_Click(object sender, EventArgs e)
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

    private void CmdValid_Click(object sender, EventArgs e)
    {
      //test si péridoe sélectionnée
      if (txtDateA0.Text == "" || txtDateA1.Text == "")
      {
        MessageBox.Show($"Il faut sélectionner une période !", Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      LoadData();

    }

    private void BtnDetail_Click(object sender, EventArgs e)
    {

      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      try
      {
        frmMessageTechDetail f = new frmMessageTechDetail();
        f.sNomTech = row["VTECH"].ToString();
        f.sClient = row["VCLINOM"].ToString();
        f.sChaff = row["VCHAFF"].ToString();
        f.sLibGroupe = row["LIBGROUPE"].ToString();
        f.sVille = row["VSITVIL"].ToString();
        f.sDIAction = $"{row["NDINNUM"].ToString()} / {row["NACTID"].ToString()}";
        f.sDateMsg = row["VDATE_MSG"].ToString();
        f.sMessage = row["VMSG"].ToString();
        f.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message + "\r\n\r\n" + Resources.Global_dans + MethodBase.GetCurrentMethod().Name, Resources.Global_Erreur,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

    }
  }
}
