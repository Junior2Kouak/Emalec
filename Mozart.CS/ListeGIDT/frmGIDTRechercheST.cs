using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmGIDTRechercheST : Form
  {
    public string msST;
    public string msContact;
    public int miContact;
    public int miSoustraitant;

    private DataTable dtSTF = new DataTable();

    public frmGIDTRechercheST()
    {
      InitializeComponent();
    }

    private void frmGIDTRechercheST_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      InitGrid();

      //  If miContact <> 0 Then
      //    rsSTF.Find "NINTNUM = " & miContact
      //  End If

      //  Screen.MousePointer = vbDefault
    }

    private void cmdSelectionner_Click(object sender, EventArgs e)
    {
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      if (row["NINTNUM"] == null)
      {
        MessageBox.Show("Il faut mettre un contact sur ce sous traitant", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      msST = row["VSTFNOM"].ToString();
      msContact = row["VINTNOM"].ToString();
      miSoustraitant = Convert.ToInt32(row["NSTFNUM"]);
      miContact = Convert.ToInt32(row["NINTNUM"]);

      DialogResult = DialogResult.OK;
      Close();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      ////  miSoustraitant = 0    ' passage d'aucune id
      miSoustraitant = 0;
      ////  miContact = 0
      miContact = 0;
      ////  Unload Me
      //Close();
    }

    private void InitGrid()
    {
      Grid.LoadData(dtSTF, MozartDatabase.cnxMozart, "EXEC api_sp_listeSTF_GIDT ");

      Grid.AddColumn("Contact", "NINTNUM", 0);
      Grid.AddColumn("STT", "NSTFNUM", 0);
      Grid.AddColumn("Société", "VSTFNOM", 1400);
      Grid.AddColumn("Contact", "VINTNOM", 1400);
      Grid.AddColumn("Téléphone", "VINTTEL", 1400);
      Grid.AddColumn("Portable", "VINTPOR", 1400);
      Grid.AddColumn("Activité", "VSTFAC1", 1800);
      Grid.AddColumn("CP", "VSTFCP", 550);
      Grid.AddColumn("Ville", "VSTFVIL", 1400);
      Grid.AddColumn("Pays", "VSTFPAYS", 1000);
      Grid.AddColumn("Ville cible", "VSTFVIC", 1400);

      Grid.InitColumnList();
      Grid.GridControl.DataSource = dtSTF;
    }

    private void Grid_DoubleClickE(object sender, EventArgs e)
    {
      cmdSelectionner_Click(sender, e);
    }
  }
}
