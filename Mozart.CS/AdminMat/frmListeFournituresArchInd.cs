using Microsoft.VisualBasic;
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
  public partial class frmListeFournituresArchInd : Form
  {
    DataTable dt = new DataTable();
    string sSQL;

    //Dim adoRs As Recordset
    //Dim sSQL As String

    public frmListeFournituresArchInd()
    {
      InitializeComponent();
    }

    private void frmListeFournituresArchInd_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        sSQL = "select NOUTINDNUM, VOUTINDNUMERO, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTINDDETAL, VFOUCON, " +
               "(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix " +
               "FROM TOUTILLAGEIND, TFOU WHERE TOUTILLAGEIND.NFOUNUM = TFOU.NFOUNUM  " +
               "AND TOUTILLAGEIND.COUTINDACTIF='N' Order by VFOUMAT ";

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();

        txtHT.Text = CalculerTHT();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
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
    //  sSQL = "select NOUTINDNUM, VOUTINDNUMERO, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTINDDETAL, VFOUCON, "
    //  sSQL = sSQL & "(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix"
    //  sSQL = sSQL & " FROM TOUTILLAGEIND, TFOU WHERE TOUTILLAGEIND.NFOUNUM = TFOU.NFOUNUM "
    //  sSQL = sSQL & " AND TOUTILLAGEIND.COUTINDACTIF='N' Order by VFOUMAT "
    //  
    //  adoRs.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //   
    //  txtHT = CalculerTHT("prix", adoRs)
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private string CalculerTHT()
    {
      double total = 0;
      //pour toutes les lignes de la grid
      foreach (DataRow rowbis in dt.Rows)
        total += Utils.ZeroIfNull(rowbis[9]);

      return Strings.FormatNumber(total, 0) + " €";
    }

    /* OK--------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdDetail_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;
      frmDetailsOutillageInd f = new frmDetailsOutillageInd();
      f.mstrStatut = "M";
      f.miNumOut = Convert.ToInt64(currentRow["NOUTINDNUM"]);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdDetail_Click()
    //  If adoRs.EOF Then Exit Sub
    //  Screen.MousePointer = vbHourglass
    //  frmDetailsOutillageInd.mstrStatut = "M"
    //  frmDetailsOutillageInd.miNumOut = adoRs!NOUTINDNUM
    //  frmDetailsOutillageInd.Show vbModal
    //  Screen.MousePointer = vbDefault
    //  adoRs.Requery
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null)
          return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                                { "Num", "6" },
                                { "Titre", "Liste outillage individuel " + MozartParams.NomSociete },
                                { "Date", DateTime.Now.ToShortDateString() } };

        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageInd.rtf",
                        @"TListeOutillageIndOut.rtf",
                        TdbGlobal,
                        sSQL,
                        " (Impression liste outillage individuel)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
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
    //  TdbGlobal(2, 1) = "Liste outillage individuel " & gstrNomSociete
    //  TdbGlobal(3, 0) = "Date"
    //  TdbGlobal(3, 1) = Date
    //  
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TListeOutillageInd.rtf", _
    //                           "\TListeOutillageIndOut.rtf", _
    //                           TdbGlobal(), _
    //                           sSQL, _
    //                           " (Impression liste outillage individuel)", _
    //                           "PREVIEW"
    //Exit Sub
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdPrix_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;
      string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                              { "Num", "6" },
                              { "Titre", "Liste outillage Individuel " + MozartParams.NomSociete },
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
    //  TdbGlobal(2, 1) = "Liste outillage Individuel " & gstrNomSociete
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
    //Exit Sub
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdRestore_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_Confirm_restaurer_materiel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.ExecuteNonQuery($"Update TOUTILLAGEIND set COUTINDACTIF='O' WHERE NOUTINDNUM = { Convert.ToInt32(currentRow["NOUTINDNUM"])} ");

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdNouvelle_Click()
    //On Error GoTo handler
    //  If adoRs.EOF Then Exit Sub
    //  
    //  If MsgBox("§Voulez-vous vraiment restaurer ce matériel ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    cnx.Execute "Update TOUTILLAGEIND set COUTINDACTIF='O' WHERE NOUTINDNUM=" & adoRs("NOUTINDNUM").Value
    //  End If
    //  
    //  adoRs.Requery
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num_Art, "NFOUNUM", 0);
      apiTGrid1.AddColumn(Resources.col_Num, "VOUTINDNUMERO", 750);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 5000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1600, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1600, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1600, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Prix, "Prix", 1100, "Currency", 2);
      apiTGrid1.AddColumn(Resources.col_Date_Etalonnage, "DOUTDETAL", 2200, "dd/mm/yy", 2);

      apiTGrid1.InitColumnList();
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  apiTGrid1.AddColumn "NumArt", "NFOUNUM", 0
    //  apiTGrid1.AddColumn "N° ", "VOUTINDNUMERO", 750
    //  apiTGrid1.AddColumn "§Matériel§", "VFOUMAT", 5000
    //  apiTGrid1.AddColumn "§Marque§", "VFOUMAR", 1600
    //  apiTGrid1.AddColumn "§Type§", "VFOUTYP", 1600     ' equivaut a 3cm"
    //  apiTGrid1.AddColumn "§Réf§", "VFOUREF", 1600
    //  apiTGrid1.AddColumn "§Prix§", "Prix", 1100, "currency", 2
    //  apiTGrid1.AddColumn "§Date Etalonnage§", "DOUTINDDETAL", 1200, "dd/mm/yy", 2
    //
    //  apiTGrid1.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUREF", &HFDF0DA
    //
    //  apiTGrid1.Init adoRs
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApiTgrid dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void frmListeFournituresArchInd_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}