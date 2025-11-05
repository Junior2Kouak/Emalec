using DevExpress.XtraCharts;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStatRavel : Form
  {
    public string sType;

    private DataTable dt = new DataTable();

    private class donneesGraph
    {
      public string nom { get; set; }
      public int valeur { get; set; }
      public donneesGraph() { }
    }

    public frmStatRavel()
    {
      InitializeComponent();
    }

    private void frmStatRavel_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string sql;

        if ("CHAFF" == sType)
        {
          Label1.Text = "Statistique Ravel chargés d'affaire";
          InitGrid();
          sql = "EXEC api_sp_StatRavelCHAFF";
        }
        else if ("AVOIR" == sType)
        {
          Label1.Text = "Suivi des demandes d'Avoirs dans Ravel";
          InitGridAvoir();
          sql = "EXEC api_sp_StatRavelAVOIR";
        }
        else
        {
          Label1.Text = "Statistique Ravel fournisseur";
          InitGrid();
          sql = "EXEC api_sp_StatRavelSTT";
        }

        this.Text = Label1.Text;

        ModuleMain.Initboutons(this);

        Grid.LoadData(dt, MozartDatabase.cnxMozart, sql);
        Grid.GridControl.DataSource = dt;

        // graphique 
        List<donneesGraph> listDataSource = new List<donneesGraph>();
        int nb = dt.Rows.Count;
        if (nb > 15) nb = 15;
        bool bAvoir = false;
        if ("AVOIR" == sType) bAvoir = true;
        for (int i = 1; i < nb; i++)
        {
          int m = 0;
          if (bAvoir)
            m = (int)Utils.ZeroIfNull(dt.Rows[i]["MTA"]);
          else
            m = (int)Utils.ZeroIfNull(dt.Rows[i]["MTECH"]);

          listDataSource.Add(new donneesGraph() { nom = Utils.BlankIfNull(dt.Rows[i]["VNOM"]), valeur = m });
        }

        Series serie1 = Chartspace1.Series["Serie1"];
        serie1.DataSource = listDataSource;

        if (bAvoir)
        {
          Chartspace1.Titles[0].Text = "Montant des avoirs sur 12 mois";
        }
        else
        {
          Chartspace1.Titles[0].Text = Resources.txt_MontantFactures;
        }

        // tri de la grid
        if (sType != "AVOIR")
        {
          dt.DefaultView.Sort = "MTT desc";
          dt = dt.DefaultView.ToTable();
        }
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

    private void CmdDetail_Click(object sender, EventArgs e)
    {
      frmListeAvoir frm = new frmListeAvoir();
      frm.mstrTypeListe = "D";
      frm.ShowDialog();
    }

    private void cmdSTT_Click(object sender, EventArgs e)
    {
      frmListeAvoir frm = new frmListeAvoir();
      frm.mstrTypeListe = "M";
      frm.ShowDialog();
    }

    private void InitGrid()
    {
      if ("CHAFF" == sType)
      {
        Grid.AddColumn(Resources.col_Chaff, "VNOM", 1500);
      }
      else
      {
        Grid.AddColumn("FO ou STT", "VNOM", 2000);
      }
      Grid.AddColumn("Nb total", "NBT", 1100, "", 2);
      Grid.AddColumn("Mt total", "MTT", 1100, "# ###", 2);
      Grid.AddColumn("Nb échéance dépassée", "NBECH", 1500, "", 2);
      Grid.AddColumn("Mt échéance dépassée", "MTECH", 1500, "# ###", 2);
      Grid.AddColumn("Nb bloquées", "NBB", 1500, "", 2);
      Grid.AddColumn("Mt bloquées", "MTB", 1500, "# ###", 2);
      Grid.AddColumn("Nb éch. dépassée non bloquées", "NBECHNONB", 2000, "", 2);
      Grid.AddColumn("Mt éch. dépassée non bloquées", "MTECHNONB", 2000, "# ###", 2);
      Grid.AddColumn("Nb de plus d’un an", "NBAN", 2000, "", 2);
      Grid.AddColumn("Mt de plus d’un an", "MTAN", 1500, "# ###", 2);
    }

    private void InitGridAvoir()
    {
      Grid.AddColumn(Resources.col_Chaff, "VNOM", 2000);
      Grid.AddColumn("Nombre d'Avoirs", "NBA", 3000, "", 2);
      Grid.AddColumn("Montant des Avoirs", "MTA", 3000, "# ###", 2);
      Grid.AddColumn("Nombre de Courriers", "NBC", 1500, "", 2);

      Grid.chkColumnsList.Visible = false;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

