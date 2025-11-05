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
  public partial class frmStatHeureTechInspTrav : Form
  {
    DataTable dt = new DataTable();

    public frmStatHeureTechInspTrav()
    {
      InitializeComponent();
    }


    private void frmStatHeureTechInspTrav_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        DateTime dateTmp = DateTime.Now.AddDays(-((int)DateTime.Now.DayOfWeek) + 1);
        txtDateA0.Text = dateTmp.AddDays(-7).ToShortDateString();
        txtDateA1.Text = dateTmp.AddDays(-2).ToShortDateString();

        Init();

        InitApigrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub Form_Load()
    //    
    //  InitBoutons Me, frmMenu
    //   
    //  txtDateA(0) = DateAdd("d", -7, DateAdd("d", -(Weekday(Date) - 2), Date))
    //  txtDateA(1) = DateAdd("d", -2, DateAdd("d", -(Weekday(Date) - 2), Date))
    // 
    //  Init
    //
    //  Screen.MousePointer = vbDefault
    //  
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void Init()
    {
      try
      {
        //  détail pour le technicien sur tableau à coté
        //  création d'une commande
        //  écriture de la requête pour la liste des sites
        string sSQL = $"exec api_sp_StatistiqueHeureTechInspTrav '{txtDateA0.Text}' , '{txtDateA1.Text}'";

        //  exécuter la commande.
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;

        Label4.Text = txtDateA0.Text;
        Label6.Text = txtDateA1.Text;

        //  fonction de recherche des heures de références
        Label8.Text = Resources.txt_HeureRef + RechercheHeureRef(DateTime.Parse(txtDateA0.Text), DateTime.Parse(txtDateA1.Text));

      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void cmdDate1_2_Click(object sender, EventArgs e)
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

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // Test des dates
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateFin, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        Init();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Technicien, "VPERNOM", 2200);
        apiTGrid1.AddColumn(Resources.col_heure, "Heures", 1000, "### ##0", 2);
        apiTGrid1.AddColumn(Resources.col_Tech, "NPERNUM", 0);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdStatClient_Click(object sender, EventArgs e)
    {
      //DataRow row = apiTGrid1.GetFocusedDataRow();
      //if (row != null)
      //{
      //  frmStatGraphTech f = new frmStatGraphTech();
      //  f.msNomTech = row[0].ToString();
      //  f.miNumTech = (int)row[1];
      //  f.msHeureRef = Label8.Text;
      //  f.ShowDialog();
      //}
    }

    
    private int RechercheHeureRef(DateTime DateDeb, DateTime DateFin)
    {
      int heureRef = 0;
      DateTime dateCourant;

      try
      {
        dateCourant = DateDeb;

        while (dateCourant <= DateFin)
        {
          //  si ce n'est pas un weekend ou un jour fériée on ajoute 8 heures
          if (dateCourant.DayOfWeek != DayOfWeek.Saturday && dateCourant.DayOfWeek != DayOfWeek.Sunday)
          {
            if (!isFeriee(dateCourant.ToShortDateString()))
            {
              if (dateCourant.DayOfWeek == DayOfWeek.Friday)
                heureRef += 7;
              else
                heureRef += 8;
            }
          }
          dateCourant = dateCourant.AddDays(1);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return heureRef;
    }

    public bool isFeriee(string jour)
    {
      bool isFerie = false;
      try
      {
        isFerie = ModuleData.ExecuteScalarInt($"select count(*) from TFERIE where DFERDAT = '{jour}' AND VSOCIETE = APP_NAME()") == 1;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        isFerie = false;
      }

      return isFerie;
    }
  }
}

