using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmStatComptaCharge : Form
  {
    public string mstype;
    DataTable dt = new DataTable();
    double total = 0;

    public frmStatComptaCharge()
    {
      InitializeComponent();
    }


    private void frmStatComptaCharge_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.ToShortDateString();

        if (mstype == "ST")
        {
          Label3.Text = Resources.txt_encoursSousTraitantsDatRefRetard;
          Frame1.Text = Resources.txt_lstActionsExecDatRefSansFactureSousTraitant;
        }
        else
        {
          Label3.Text = Resources.txt_encoursFournDatRefRetard;
          Frame1.Text = Resources.txt_listActionExecDatRefSansFactFourn;
        }
        InitapiGridH();
        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
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

    //Private Sub cmdDI_Click()
    //
    //  If rsH.State = adStateClosed Then Exit Sub
    //
    //  If rsH.EOF Then Exit Sub
    //  
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = val(rsH("NDINNUM").value)
    //  glNumAction = val(rsH("NACTNUM").value)
    //  frmAddAction.Show vbModal
    //  
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //
    //
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisuH_Click(object sender, EventArgs e)
    {

      try
      {
        string colTitre, colLib = "";

        if (mstype == "ST")
        {
          colTitre = "ENCOURS SOUS-TRAITANTS au " + txtDateA0.Text + ", en RETARD.";
          colLib = "FR-facture ravel ;CST-contrat sous traitant ;DST-devis sous traitant ;FFC-fonction de facture client ;E-estimation";
        }
        else
        {
          colTitre = "ENCOURS FOURNISSEURS au " + txtDateA0.Text + ", en RETARD.";
          colLib = "FR-facture ravel ;COM-commande fournisseur";
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

        if (mstype == "ST")
        {
          f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TEtatComptable.rtf",
                          @"TEtatComptableOut.rtf",
                          TdbGlobal,
                          $"exec api_sp_ListeEtatComptaChargeSTT '{txtDateA0.Text} 22:00:00'",
                          " (Impression consultation)",
                          "PREVIEW");
        }
        else
        {
          f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TEtatComptable.rtf",
                          @"TEtatComptableOut.rtf",
                          TdbGlobal,
                          $"exec api_sp_ListeEtatComptaChargeFOU '{txtDateA0.Text} 22:00:00'",
                          " (Impression consultation)",
                          "PREVIEW");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdVisuH_Click()
    //
    //Dim TdbGlobal(0 To 6, 0 To 1) As Variant
    //
    //  On Error GoTo handler
    //
    //  If rsH.EOF Then Exit Sub
    //  
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  TdbGlobal(1, 0) = "Num"
    //  TdbGlobal(1, 1) = 2
    //  TdbGlobal(2, 0) = "Titre"
    //  If sType = "ST" Then
    //    TdbGlobal(2, 1) = "ENCOURS SOUS-TRAITANTS au " & txtDateA(0) & ", en RETARD."
    //  Else
    //    TdbGlobal(2, 1) = "ENCOURS FOURNISSEURS au " & txtDateA(0) & ", en RETARD."
    //  End If
    //  TdbGlobal(3, 0) = "Date"
    //  TdbGlobal(3, 1) = Date
    //  TdbGlobal(4, 0) = "NB"
    //  TdbGlobal(4, 1) = rsH.RecordCount
    //  TdbGlobal(5, 0) = "DateR"
    //  TdbGlobal(5, 1) = txtDateA(0)
    //  TdbGlobal(6, 0) = "LIB"
    //  If sType = "ST" Then
    //    TdbGlobal(6, 1) = "FR-facture ravel ;CST-contrat sous traitant ;DST-devis sous traitant ;FFC-fonction de facture client ;E-estimation"
    //  Else
    //    TdbGlobal(6, 1) = "FR-facture ravel ;COM-commande fournisseur"
    //  End If
    //  
    //  
    //  frmBrowser.bPlanningAn = 0
    //  If sType = "ST" Then
    //      frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TEtatComptable.rtf", _
    //                               "\TEtatComptableOut.rtf", _
    //                               TdbGlobal(), _
    //                               "exec api_sp_ListeEtatComptaChargeSTT '" & txtDateA(0) & " 22:00:00'", _
    //                               " (Impression consultation)", _
    //                               "PREVIEW", cnx, True
    //  Else
    //      frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TEtatComptable.rtf", _
    //                               "\TEtatComptableOut.rtf", _
    //                               TdbGlobal(), _
    //                               "exec api_sp_ListeEtatComptaChargeFOU '" & txtDateA(0) & " 22:00:00'", _
    //                               " (Impression consultation)", _
    //                               "PREVIEW", cnx, True
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdVisuH_Click dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
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
    //Private Sub Calendar1_Click()
    //
    //  Me.txtDateA(0) = Calendar1.value
    //  Calendar1.Visible = False
    //  Exit Sub
    //  
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateA0.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    //Private Sub cmdDate1_Click()
    //    
    //On Error GoTo handler
    //
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //  Exit Sub
    //
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      LoadGrid();
      Cursor = Cursors.Default;
    }

    
    private void LoadGrid()
    {
      if (mstype == "ST")
        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaChargeSTT '{txtDateA0.Text} 22:00:00'");
      else
        apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_ListeEtatComptaChargeFOU '{txtDateA0.Text} 22:00:00'");

      apiTGridH.GridControl.DataSource = dt;

      total = 0;
      DataRow rowBis = apiTGridH.GetFocusedDataRow();
      if (rowBis != null)
      {
        total = rowBis.Field<int>("TOTAL");
        lblTHTh.Text = Strings.FormatNumber(total, 0) + " €";
      }

    }

    private void InitapiGridH()
    {

      try
      {
        apiTGridH.AddColumn(MZCtrlResources.col_DI, "NDINNUM", 1000);
        apiTGridH.AddColumn(MZCtrlResources.col_Action, "NACTID", 500);
        apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1800);
        apiTGridH.AddColumn(Resources.col_Chaff, "CHAFF", 1800);
        apiTGridH.AddColumn(Resources.col_groupe, "LIBGROUPE", 1500);

        if (mstype == "ST")
        {
          apiTGridH.AddColumn("Cte", "NDINCTE", 700);
          apiTGridH.AddColumn(MZCtrlResources.col_libelle, "VACTDES", 4000);
          apiTGridH.AddColumn("SST", "VSTFNOM", 1400);
          apiTGridH.AddColumn("CTR", "NCSTNUM", 1000);
          apiTGridH.AddColumn(Resources.col_exec, "DACTDEX", 1000);
          apiTGridH.AddColumn("Facturé client", "NELFVAL", 2000, "Currency", 1);
          apiTGridH.AddColumn(Resources.col_Facture, "DFACDAT", 1200);
          apiTGridH.AddColumn("Encours(FNP)", "NACTVAL", 1600, "0.00", 1);
          apiTGridH.AddColumn(Resources.col_Code, "SCODE", 700);
        }
        else
        {
          apiTGridH.AddColumn(Resources.col_cmde, "NCDENUM", 1000);
          apiTGridH.AddColumn("Cte", "NDINCTE", 600);
          apiTGridH.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 3500, "", 0, true);
          apiTGridH.AddColumn(Resources.col_exec, "DACTDEX", 1200);
          apiTGridH.AddColumn("Encours(FNP)", "NACTVAL", 1600, "0.00", 1);
          apiTGridH.AddColumn(Resources.col_Code, "SCODE", 700);
        }

        apiTGridH.FilterBar = true;
        apiTGridH.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame4.Visible = true;
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      Frame4.Visible = false;
    }

    private void apiTGridH_ColumnFilterChanged(object sender, EventArgs e)
    {
      double total_filtered = 0;
      //calcul des montant filtred
      DataRow[] dt_filtered;

      DevExpress.Data.Filtering.CriteriaOperator oFilterCrit = apiTGridH.dgv.ActiveFilterCriteria;
      dt_filtered = dt.Select(DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(oFilterCrit));

      total_filtered = 0;
      foreach (DataRow rowbis in dt_filtered)
      {
        total_filtered += Utils.ZeroIfNull(rowbis.Field<decimal>("NACTVAL"));
      }
      lblTHTh.Text = Strings.FormatNumber(total_filtered, 0) + " € / " + Strings.FormatNumber(total, 0) + " €";
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }

}

