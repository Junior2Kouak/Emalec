using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFournituresInd : Form
  {

    DataTable dt = new DataTable();
    string sSQL;

    public frmListeFournituresInd()
    {
      InitializeComponent();
    }

    private void frmListeFournituresInd_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        sSQL = "select NOUTINDNUM, VOUTINDNUMERO, VOUTSERIE,DOUTGARANTIE, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTINDDETAL, VFOUCON, VOUTINDEMPL, DOUTINDPROCHETAL, " +
               "(SELECT cast(MIN(FPUHT/FPUNITE) as decimal(9,2)) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix, " +
               "ISNULL((SELECT TOP 1 VOUTINDQUI FROM TOUTILLAGELIGNEIND WHERE NOUTINDNUM = TOUTILLAGEIND.NOUTINDNUM ORDER BY NOUTINDUTINUM DESC),'') AS VLASTTECH, " +
               "ISNULL((SELECT TOP 1 VOUTINDOU FROM TOUTILLAGELIGNEIND WHERE NOUTINDNUM = TOUTILLAGEIND.NOUTINDNUM ORDER BY NOUTINDUTINUM DESC),'') AS VLASTCOM, " +
               "ISNULL((SELECT TOP 1 DOUTINDDENT FROM TOUTILLAGELIGNEIND WHERE NOUTINDNUM = TOUTILLAGEIND.NOUTINDNUM ORDER BY NOUTINDUTINUM DESC),'') AS DLASTRETOUR,   " +
               "ISNULL(BETALMAG, 0) AS BETALMAG,  ISNULL(BSTOCK, 0) AS BSTOCK, CASE WHEN ISNULL(BETALAFAIRE, 0) = 1 THEN 'OUI' ELSE 'NON' END AS BETALAFAIRE   " +
               "FROM TOUTILLAGEIND, TFOU WHERE TOUTILLAGEIND.NFOUNUM = TFOU.NFOUNUM " +
               "AND TOUTILLAGEIND.COUTINDACTIF='O' AND VSOCIETE = App_Name() Order by VFOUMAT ";

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;
        txtHT.Text = CalculerSomme();

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //
    //  Set adoRs = New Recordset
    //  sSQL = "select NOUTINDNUM, VOUTINDNUMERO, VOUTSERIE,DOUTGARANTIE, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTINDDETAL, VFOUCON, VOUTINDEMPL,DOUTINDPROCHETAL,"
    //  sSQL = sSQL & "(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix,"
    //  sSQL = sSQL & "ISNULL((SELECT TOP 1 VOUTINDQUI FROM TOUTILLAGELIGNEIND WHERE NOUTINDNUM = TOUTILLAGEIND.NOUTINDNUM ORDER BY NOUTINDUTINUM DESC),'') AS VLASTTECH,"
    //  sSQL = sSQL & "ISNULL((SELECT TOP 1 VOUTINDOU FROM TOUTILLAGELIGNEIND WHERE NOUTINDNUM = TOUTILLAGEIND.NOUTINDNUM ORDER BY NOUTINDUTINUM DESC),'') AS VLASTCOM"
    //  sSQL = sSQL & " FROM TOUTILLAGEIND, TFOU WHERE TOUTILLAGEIND.NFOUNUM = TFOU.NFOUNUM "
    //  sSQL = sSQL & " AND TOUTILLAGEIND.COUTINDACTIF='O' AND VSOCIETE = App_Name() Order by VFOUMAT "
    //
    //  
    //  adoRs.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //   
    //  ' mise à jour du total
    //  txtHT = FormatNumber(ZeroIfNull(apiTGrid1.SommeColonneName("Prix")), 0) & " €"
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub

    private string CalculerSomme()
    {
      double total = 0;
      //pour toutes les lignes de la grid
      foreach (DataRow row in dt.Rows)
        total += Utils.ZeroIfNull(row["Prix"]);

      return Strings.FormatNumber(total, 0) + " €";
    }


    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmDetailsOutillageInd f = new frmDetailsOutillageInd();
      f.mstrStatut = "C";
      f.miNumOut = 0;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }


    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      Cursor.Current = Cursors.WaitCursor;
      frmDetailsOutillageInd f = new frmDetailsOutillageInd();
      f.mstrStatut = "M";
      f.miNumOut = Convert.ToInt64(row["NOUTINDNUM"]);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                                { "Num", "6" },
                                { "Titre", "Liste outillage individuel " + MozartParams.NomSociete },
                                { "Date", DateTime.Now.ToShortDateString() } };

        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageInd.rtf",
                        @"TListeOutillageIndOut.rtf.rtf",
                        TdbGlobal,
                        sSQL,
                        " (Impression liste outillage individuel)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdVisu_Click()
    //Dim TdbGlobal(0 To 3, 0 To 1) As Variant
    //
    //  On Error GoTo handler
    //
    //  If adoRs.EOF Then Exit Sub
    //
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  TdbGlobal(1, 0) = "Num"
    //  TdbGlobal(1, 1) = 6
    //  TdbGlobal(2, 0) = "Titre"
    //  TdbGlobal(2, 1) = "Liste outillage Individuel " & gstrNomSociete
    //  TdbGlobal(3, 0) = "Date"
    //  TdbGlobal(3, 1) = Date
    //  
    //'  frmBrowser.InfosMail = "TINT|NSTFNUM|" & adoRS("NSTFNUM")     ' TABLE | ID    --VL 16/11/04
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TListeOutillageInd.rtf", _
    //                           "\TListeOutillageIndOut.rtf", _
    //                           TdbGlobal(), _
    //                           sSQL, _
    //                           " (Impression liste outillage individuel)", _
    //                           "PREVIEW"
    //  Exit Sub
    //  
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdPrix_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                                { "Num", "6" },
                                { "Titre", "Liste outillage individuel " + MozartParams.NomSociete },
                                { "Date", DateTime.Now.ToShortDateString() },
                                { "TOTAL", txtHT.Text }  };
        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageIndPrix.rtf",
                        @"TListeOutillageCollectIndOut.rtf",
                        TdbGlobal,
                        sSQL,
                        " (Impression liste outillage individuel)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdPrix_Click()
    //Dim TdbGlobal(0 To 4, 0 To 1) As Variant
    //
    //  On Error GoTo handler
    //
    //  If adoRs.EOF Then Exit Sub
    //    
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  TdbGlobal(1, 0) = "Num"
    //  TdbGlobal(1, 1) = 6
    //  TdbGlobal(2, 0) = "Titre"
    //  TdbGlobal(2, 1) = "Liste outillage individuel " & gstrNomSociete
    //  TdbGlobal(3, 0) = "Date"
    //  TdbGlobal(3, 1) = Date
    //  TdbGlobal(4, 0) = "TOTAL"
    //  TdbGlobal(4, 1) = txtHT
    //  
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TListeOutillageIndPrix.rtf", _
    //                           "\TListeOutillageCollectIndOut.rtf", _
    //                           TdbGlobal(), _
    //                           sSQL, _
    //                           " (Impression liste outillage individuel)", _
    //                           "PREVIEW"
    //  Exit Sub
    //  
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_ConfirmArchMateriel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"Update TOUTILLAGEIND set COUTINDACTIF = 'N' WHERE NOUTINDNUM = { Convert.ToInt32(currentRow["NOUTINDNUM"])} ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeFournituresArchInd().ShowDialog();
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Num_Art, "NFOUNUM", 0);
        apiTGrid1.AddColumn(Resources.col_Num, "VOUTINDNUMERO", 750);
        apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 4000, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1500, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1500, "", 0, true);     //équivaut à 3 cm
        apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1500, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_Num_serie, "VOUTSERIE", 1500);
        apiTGrid1.AddColumn(Resources.col_Emplacement, "VOUTINDEMPL", 1600);
        apiTGrid1.AddColumn(Resources.col_Prix, "Prix", 1100, "currency", 2);
        apiTGrid1.AddColumn("A étalonner", "BETALAFAIRE", 1200);
        apiTGrid1.AddColumn(Resources.col_Date_Etalonnage, "DOUTINDDETAL", 1800, "dd/mm/yy", 2);
        apiTGrid1.AddColumn(Resources.col_Date_proch_Etal, "DOUTINDPROCHETAL", 1800, "dd/mm/yy", 2);
        apiTGrid1.AddColumn(Resources.col_Date_garantie, "DOUTGARANTIE", 1700, "dd/mm/yy", 2);
        apiTGrid1.AddColumn(Resources.col_Dernier_Tech, "VLASTTECH", 1800);
        apiTGrid1.AddColumn(Resources.col_Dernier_chantier, "VLASTCOM", 1800);
        apiTGrid1.AddColumn("Date retour", "DLASTRETOUR", 1500, "dd/mm/yy", 2);
        apiTGrid1.AddColumn("STOCK", "BSTOCK", 1000);
        apiTGrid1.AddColumn("ETAL MAG", "BETALMAG", 0);


        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmListeFournituresInd_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {

      if (e.RowHandle < 0) return;
      GridView view = sender as GridView;
      bool _mark = (bool)view.GetRowCellValue(e.RowHandle, "BETALMAG");

      if (_mark == true)
      {
        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
        e.HighPriority = true;
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}