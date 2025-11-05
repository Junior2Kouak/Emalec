using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.AdminCompta
{
  public partial class frmStatEncoursDesactive : Form
  {

    int bMODE;
    DataTable dt = new DataTable();

    public frmStatEncoursDesactive(int c_bmode)
    {
      InitializeComponent();
      bMODE = c_bmode;
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void frmStatEncoursDesactive_Load(object sender, EventArgs e)
    {

      try
      {
        ModuleMain.Initboutons(this);
        Calendar1.Value = DateTime.Now.Date;
        switch (bMODE)
        {
          case 1:
            lbl_titre.Text = "Encours STT désactivé à la date de référence à ce jour";
            this.Text = "Encours STT désactivé à la date de référence à ce jour";
            break;
          case 2:
            lbl_titre.Text = "Encours fournisseurs désactivé à la date de référence à ce jour";
            this.Text = "Encours fournisseurs désactivé à la date de référence à ce jour";
            break;

          default:
            break;
        }

        InitApigrid();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }


    }

    private void InitApigrid()
    {
      try
      {

        switch (bMODE)
        {
          case 1:
            apiTGrid1.AddColumn("N° CS", "NCSTNUM", 690);
            apiTGrid1.AddColumn("Date du contrat", "DCSTDAT", 690);
            apiTGrid1.AddColumn("STT", "VSTFNOM", 1400);
            apiTGrid1.AddColumn("Nom client", "VCLINOM", 900);
            apiTGrid1.AddColumn("Site", "VSITNOM", 1600);
            apiTGrid1.AddColumn("N° compte analytique", "NDINCTE", 900);
            apiTGrid1.AddColumn("Chaff", "VDINCHAFF", 900);
            apiTGrid1.AddColumn("Date execution", "DACTDEX", 900);
            apiTGrid1.AddColumn("Montant du CS", "NCSTFOR", 900);
            apiTGrid1.AddColumn("N° DI", "NDINNUM", 900);
            apiTGrid1.AddColumn("Action", "VACTDES", 900);
            break;
          case 2:
            apiTGrid1.AddColumn("N° CF", "NCOMNUM", 690);
            apiTGrid1.AddColumn("Date commande", "DCOMDAT", 690);
            apiTGrid1.AddColumn("Fournisseur", "VSTFNOM", 1400);
            apiTGrid1.AddColumn("Nom client", "VCLINOM", 900);
            apiTGrid1.AddColumn("Site", "VSITNOM", 1600);
            apiTGrid1.AddColumn("N° compte analytique", "NDINCTE", 900);
            apiTGrid1.AddColumn("Chaff", "VDINCHAFF", 900);
            apiTGrid1.AddColumn("Date execution", "DACTDEX", 900);
            apiTGrid1.AddColumn("Montant du CF", "NCOMPHT", 900);
            apiTGrid1.AddColumn("N° DI", "NDINNUM", 900);
            apiTGrid1.AddColumn("Action", "VACTDES", 900);
            break;

          default:
            break;
        }

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    private void loadDatatable()
    {
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "exec [api_sp_ListeEncoursSansFactureRAVEL] '" + Calendar1.Text + "', " + bMODE.ToString());
      apiTGrid1.GridControl.DataSource = dt;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      loadDatatable();
    }

    private void frmStatEncoursDesactive_Resize(object sender, EventArgs e)
    {
      try
      {
        apiTGrid1.Width = this.ClientSize.Width - apiTGrid1.Location.X - 30;
        apiTGrid1.Height = this.ClientSize.Height - apiTGrid1.Location.Y - 110;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}
