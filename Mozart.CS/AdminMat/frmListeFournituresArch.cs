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
  public partial class frmListeFournituresArch : Form
  {
    DataTable dt = new DataTable();
    string sSQL;

    //Dim adoRS As Recordset
    //Dim sSQL As String

    public frmListeFournituresArch()
    {
      InitializeComponent();
    }

    /* OK--------------------------------------------------------------------------*/
    private void frmListeFournituresArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        sSQL = "SELECT NOUTNUM, VOUTNUMERO, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTDETAL, VFOUCON, " +
               "(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix " +
               "FROM TOUTILLAGE, TFOU WHERE TOUTILLAGE.NFOUNUM = TFOU.NFOUNUM " +
               "AND TOUTILLAGE.COUTACTIF='N' Order by VFOUMAT ";

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
    //  Set adoRS = New Recordset
    //  sSQL = "select NOUTNUM, VOUTNUMERO, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTDETAL, VFOUCON, "
    //  sSQL = sSQL & "(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix"
    //  sSQL = sSQL & " FROM TOUTILLAGE, TFOU WHERE TOUTILLAGE.NFOUNUM = TFOU.NFOUNUM "
    //  sSQL = sSQL & " AND TOUTILLAGE.COUTACTIF='N' Order by VFOUMAT "
    //  
    //  adoRS.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //   
    //  txtHT = CalculerTHT("prix", adoRS)
    //  
    //  Screen.MousePointer = vbDefault
    //  
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
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      frmDetailsOutillage f = new frmDetailsOutillage();
      f.mstrStatut = "M";
      f.miNumOut = Convert.ToInt64(row["NOUTNUM"]);
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdDetail_Click()
    //  If adoRS.EOF Then Exit Sub
    //  Screen.MousePointer = vbHourglass
    //  frmDetailsOutillage.mstrStatut = "M"
    //  frmDetailsOutillage.miNumOut = adoRS!NOUTNUM
    //  frmDetailsOutillage.Show vbModal
    //  Screen.MousePointer = vbDefault
    //  adoRS.Requery
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                                { "Num", "6" },
                                { "Titre", "Liste outillage collectif " + MozartParams.NomSociete },
                                { "Date", DateTime.Now.ToShortDateString() } };

        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageCollect.rtf",
                        @"TListeOutillageCollectOut.rtf",
                        TdbGlobal,
                        sSQL,
                        " (Impression liste outillage)",
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
    //  If adoRS.EOF Then Exit Sub
    //
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  TdbGlobal(1, 0) = "Num"
    //  TdbGlobal(1, 1) = 6
    //  TdbGlobal(2, 0) = "Titre"
    //  TdbGlobal(2, 1) = "Liste outillage collectif " & gstrNomSociete
    //  TdbGlobal(3, 0) = "Date"
    //  TdbGlobal(3, 1) = Date
    //  
    //'  frmBrowser.InfosMail = "TINT|NSTFNUM|" & adoRS("NSTFNUM")     ' TABLE | ID    --VL 16/11/04
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TListeOutillageCollect.rtf", _
    //                           "\TListeOutillageCollectOut.rtf", _
    //                           TdbGlobal(), _
    //                           sSQL, _
    //                           " (Impression liste outillage)", _
    //                           "PREVIEW"
    //Exit Sub
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub

    /* TODO AT erreur GenEtat --------------------------------------------------------------------------*/
    private void cmdPrix_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                              { "Num", "6" },
                              { "Titre", "Liste outillage collectif " + MozartParams.NomSociete },
                              { "Date", DateTime.Now.ToShortDateString() },{ "TOTAL", txtHT.Text }  };

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageCollectPrix.rtf",
                        @"TListeOutillageCollectPrixOut.rtf",
                        TdbGlobal,
                        sSQL,
                        " (Impression liste outillage)",
                        "PREVIEW");
    }
    //Private Sub cmdPrix_Click()
    //Dim TdbGlobal(0 To 4, 0 To 1) As Variant
    //
    //  On Error GoTo handler
    //  If adoRS.EOF Then Exit Sub
    //
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  TdbGlobal(1, 0) = "Num"
    //  TdbGlobal(1, 1) = 6
    //  TdbGlobal(2, 0) = "Titre"
    //  TdbGlobal(2, 1) = "Liste outillage collectif " & gstrNomSociete
    //  TdbGlobal(3, 0) = "Date"
    //  TdbGlobal(3, 1) = Date
    //  TdbGlobal(4, 0) = "TOTAL"
    //  TdbGlobal(4, 1) = txtHT
    //  
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TListeOutillageCollectPrix.rtf", _
    //                           "\TListeOutillageCollectPrixOut.rtf", _
    //                           TdbGlobal(), _
    //                           sSQL, _
    //                           " (Impression liste outillage)", _
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
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row == null) return;

        if (MessageBox.Show(Resources.msg_Confirm_restaurer_materiel, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"Update TOUTILLAGE set COUTACTIF='O' WHERE NOUTNUM= { Convert.ToInt32(row["NOUTNUM"])} ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdNouvelle_Click()
    //    
    //On Error GoTo handler
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  If MsgBox("§Voulez-vous vraiment restaurer ce matériel ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    cnx.Execute "Update TOUTILLAGE set COUTACTIF='O' WHERE NOUTNUM=" & adoRS("NOUTNUM").Value
    //  End If
    //  
    //  adoRS.Requery
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
      apiTGrid1.AddColumn(Resources.col_Num, "VOUTNUMERO", 750);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 5000, "", 0, true);      // <= AddCellTip
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1600, "", 0, true);        // <= AddCellTip
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1600, "", 0, true);          // <= AddCellTip  equivaut a 3cm"
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1600, "", 0, true);           // <= AddCellTip
      apiTGrid1.AddColumn(Resources.col_Prix, "Prix", 1100, "Currency", 2);
      apiTGrid1.AddColumn(Resources.col_Date_Etalonnage, "DOUTDETAL", 2200, "dd/mm/yy", 2);

      apiTGrid1.InitColumnList();
    }

    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  apiTGrid1.AddColumn "NumArt", "NFOUNUM", 0
    //  apiTGrid1.AddColumn "N° ", "VOUTNUMERO", 750
    //  apiTGrid1.AddColumn "§Matériel§", "VFOUMAT", 5000
    //  apiTGrid1.AddColumn "§Marque§", "VFOUMAR", 1600
    //  apiTGrid1.AddColumn "§Type§", "VFOUTYP", 1600     ' equivaut a 3cm"
    //  apiTGrid1.AddColumn "§Réf§", "VFOUREF", 1600
    //  apiTGrid1.AddColumn "§Prix§", "Prix", 1100, "currency", 2
    //  apiTGrid1.AddColumn "§Date Etalonnage§", "DOUTDETAL", 1200, "dd/mm/yy", 2
    //
    //  apiTGrid1.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUREF", &HFDF0DA
    //
    //  apiTGrid1.Init adoRS
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApiTgrid dans " & Me.Name
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void frmListeFournituresArch_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor = Cursors.Default;
    }

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
  }
}