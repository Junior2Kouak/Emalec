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
  public partial class frmStatCompta : Form
  {

    private string mstype;

    private DataTable dt = new DataTable();
    private double total = 0;

    private const string PS_LISTEETATCOMPTA = "api_sp_ListeEtatCompta2";
    private const string PS_LISTEETATCOMPTA_NC = "api_sp_ListeEtatComptaNC2";

    public frmStatCompta(string psType)
    {
      InitializeComponent();

      mstype = psType;
    }

    private void frmStatCompta_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);
        txtDateA0.Text = DateTime.Now.ToShortDateString();

        //  titre selon
        if (mstype == "EMALEC")
        {
          Label3.Text = $"{Resources.txt_encoursClieDatRefRetard} {MozartParams.NomSociete}.";
          Frame1.Text = $"{Resources.txt_actionExecDatRef} {MozartParams.NomSociete}";
        }
        else
        {
          Label3.Text = Resources.txt_encoursCliDatRefRetardSousTrait;
          Frame1.Text = Resources.txt_actionExecDatRefSousTrait;
        }

        InitapiGridH();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void CmdDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridH.GetFocusedDataRow();
      if (currentRow == null) return;

      //  écran de modification de la demande
      frmAddAction f = new frmAddAction()
      {
        mstrStatutDI = "M"
      };

      MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
      MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

      f.ShowDialog();

      //  on revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }

    private void cmdVisuH_Click(object sender, EventArgs e)
    {
      try
      {
        string colTitre;
        string colLib;
        string nomFctSQL;

        Cursor = Cursors.WaitCursor;

        if (mstype == "EMALEC")
        {
          colTitre = $"ENCOURS CLIENTS au {txtDateA0.Text} , en RETARD. \\par Prestations réalisées par des techniciens {MozartParams.NomSociete}.";
          colLib = "FC-facture client; CC-chiffrage client; DCL-devis client; HD-heure et déplacement(si attachement); E-estimation";

          nomFctSQL = PS_LISTEETATCOMPTA;
        }
        else
        {
          colTitre = $"ENCOURS CLIENTS au {txtDateA0.Text} , en RETARD. \\par Prestations réalisées par des sous-traitants.";
          colLib = "FC-facture client; CC-chiffrage client; DCL-devis client; CST-contrat ST; DST-devis ST; E-estimation";

          nomFctSQL = PS_LISTEETATCOMPTA_NC;
        }

        string[,] TdbGlobal = new string[,] { { "Copie", "ORIGINAL"},
                                              { "Num",   "2"},
                                              { "Titre", colTitre },
                                              { "Date",  DateTime.Now.ToShortDateString() },
                                              { "NB",    dt.Rows.Count.ToString()},
                                              { "DateR", txtDateA0.ToString() },
                                              { "LIB",   colLib }
        };

        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TEtatComptable.rtf",
                        @"TEtatComptableOut.rtf",
                        TdbGlobal,
                        $"exec {nomFctSQL} '{txtDateA0.Text} 22:00:00'",
                        " (Impression consultation)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateA0.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateA0.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      LoadApiGrid();
      Cursor = Cursors.Default;
    }

    private void LoadApiGrid()
    {

      if (mstype == "EMALEC")
        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"{PS_LISTEETATCOMPTA} '{txtDateA0.Text} 22:00:00'");
      else
        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"{PS_LISTEETATCOMPTA_NC} '{txtDateA0.Text} 22:00:00'");

      apiTGridH.GridControl.DataSource = dt;

      total = 0;
      foreach (DataRow rowbis in dt.Rows)
      {
        total += Utils.ZeroIfNull(rowbis[9]);
      }
      lblTHTh.Text = Strings.FormatNumber(total, 0) + " €";

      Cursor = Cursors.Default;
    }

    private void InitapiGridH()
    {
      try
      {
        apiTGridH.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 750);
        apiTGridH.AddColumn(MZCtrlResources.col_Action, "NACTID", 500);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500, "", 0, true);
        apiTGridH.AddColumn(Resources.col_Cpt, "NDINCTE", 700);
        apiTGridH.AddColumn(Resources.col_Lbl, "VACTDES", 4100, "", 0, true);

        if (mstype == "EMALEC")
          apiTGridH.AddColumn(Resources.col_Tech, "VPERNOM", 1500, "", 0, true);
        else
          apiTGridH.AddColumn("STT", "VSTFNOM", 1500, "", 0, true);

        apiTGridH.AddColumn(Resources.col_Chaff, "CHAFF", 1500);
        apiTGridH.AddColumn(Resources.col_groupe, "LIBGROUPE", 1500);
        apiTGridH.AddColumn(Resources.col_exec, "DACTDEX", 1100);
        apiTGridH.AddColumn(MZCtrlResources.col_Etat, "CACTSTA", 700, "", 2);
        apiTGridH.AddColumn(Resources.col_dateCode, "DFACDAT", 1000, "dd/mm/yy");
        apiTGridH.AddColumn(Resources.col_euroHT, "NACTVAL", 1000, "0.00", 1);
        apiTGridH.AddColumn(Resources.col_Code, "SCODE", 700, "", 2);

        apiTGridH.AddColumn(Resources.col_P_restation, "CPRECOD", 700, "", 2);
        apiTGridH.AddColumn("Type de contrat", "VTYPECONTRAT", 1000, "", 2);
        //apiTGridH.AddColumn("Type de facturation", "VTREFLIB", 700, "", 2);
        //apiTGridH.AddColumn("Période", "NNUMPER", 800, "", 2);
        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = !Frame4.Visible;
    }

    private void apiTGridH_ColumnFilterChanged(object sender, EventArgs e)
    {
      double total_filtered;
      //calcul des montant filtred
      DataRow[] dt_filtered;

      DevExpress.Data.Filtering.CriteriaOperator oFilterCrit = apiTGridH.dgv.ActiveFilterCriteria;
      dt_filtered = dt.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(oFilterCrit));

      total_filtered = 0;
      foreach (DataRow rowbis in dt_filtered)
      {
        total_filtered += Utils.ZeroIfNull(rowbis[9]);
      }
      lblTHTh.Text = Strings.FormatNumber(total_filtered, 0) + " € / " + Strings.FormatNumber(total, 0) + " €";
    }
  }
}

