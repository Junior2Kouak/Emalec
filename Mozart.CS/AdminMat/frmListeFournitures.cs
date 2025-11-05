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
  public partial class frmListeFournitures : Form
  {
    DataTable dt = new DataTable();
    private string sSQL;

    //Dim adoRs As Recordset
    //Dim sSQL As String

    public frmListeFournitures()
    {
      InitializeComponent();
    }

    private void frmListeFournitures_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        sSQL = "select NOUTNUM, VOUTNUMERO, VOUTSERIE,DOUTGARANTIE, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTDETAL, VFOUCON, VOUTEMPL, DOUTPROCHETAL" +
               ",(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix" +
               ",ISNULL((SELECT TOP 1 VOUTQUI FROM TOUTILLAGELIGNE WHERE NOUTNUM = TOUTILLAGE.NOUTNUM ORDER BY NOUTINUM DESC),'') AS VLASTTECH" +
               ", ISNULL((SELECT TOP 1 VOUTOU FROM TOUTILLAGELIGNE WHERE NOUTNUM = TOUTILLAGE.NOUTNUM ORDER BY NOUTINUM DESC),'') AS VLASTCOM, ISNULL(BETALMAG, 0) AS BETALMAG   " +
               ", CASE WHEN ISNULL(BETALAFAIRE, 0) = 1 THEN 'OUI' ELSE 'NON' END AS BETALAFAIRE " +
               "FROM TOUTILLAGE, TFOU WHERE TOUTILLAGE.NFOUNUM = TFOU.NFOUNUM  " +
               "AND TOUTILLAGE.COUTACTIF='O' AND VSOCIETE = App_Name() Order by VFOUMAT ";

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();

        txtHT.Text = CalculerSomme();

        Cursor.Current = Cursors.Default;
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
    //  sSQL = "select NOUTNUM, VOUTNUMERO, VOUTSERIE,DOUTGARANTIE, TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, DOUTDETAL, VFOUCON, VOUTEMPL,DOUTPROCHETAL,"
    //  sSQL = sSQL & "(SELECT MIN(FPUHT/FPUNITE) FROM TSTFFOU WHERE NFOUNUM = TFOU.NFOUNUM) AS Prix,"
    //  sSQL = sSQL & "ISNULL((SELECT TOP 1 VOUTQUI FROM TOUTILLAGELIGNE WHERE NOUTNUM = TOUTILLAGE.NOUTNUM ORDER BY NOUTINUM DESC),'') AS VLASTTECH,"
    //  sSQL = sSQL & "ISNULL((SELECT TOP 1 VOUTOU FROM TOUTILLAGELIGNE WHERE NOUTNUM = TOUTILLAGE.NOUTNUM ORDER BY NOUTINUM DESC),'') AS VLASTCOM"
    //  sSQL = sSQL & " FROM TOUTILLAGE, TFOU WHERE TOUTILLAGE.NFOUNUM = TFOU.NFOUNUM "
    //  sSQL = sSQL & " AND TOUTILLAGE.COUTACTIF='O' AND VSOCIETE = App_Name() Order by VFOUMAT "
    //
    //  adoRs.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //   
    //  txtHT = FormatNumber(ZeroIfNull(apiTGrid1.SommeColonneName("Prix")), 0) & " €"
    //
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
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

    /* OK--------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmDetailsOutillage f = new frmDetailsOutillage();
      f.mstrStatut = "C";
      f.miNumOut = 0;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdNouvelle_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmDetailsOutillage.mstrStatut = "C"
    //  frmDetailsOutillage.miNumOut = 0
    //  frmDetailsOutillage.Show vbModal
    //  Screen.MousePointer = vbDefault
    //  adoRs.Requery
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
    //  If adoRs.EOF Then Exit Sub
    //  Screen.MousePointer = vbHourglass
    //  frmDetailsOutillage.mstrStatut = "M"
    //  frmDetailsOutillage.miNumOut = adoRs!NOUTNUM
    //  frmDetailsOutillage.Show vbModal
    //  Screen.MousePointer = vbDefault
    //  adoRs.Requery
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

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
    //  If adoRs.EOF Then Exit Sub
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
    //  Exit Sub
    //  
    //handler:
    //  ShowError "cmdVisu_Click dans " & Me.Name
    //End Sub

    /* TODO AT erreur genEtat--------------------------------------------------------------------------*/
    private void cmdPrix_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        string[,] TdbGlobal = { { "Copie", "ORIGINAL" },
                                { "Num", "6" },
                                { "Titre", "Liste outillage collectif " + MozartParams.NomSociete },
                                { "Date", DateTime.Now.ToShortDateString() },
                                { "TOTAL", txtHT.Text }  };

        frmBrowser f = new frmBrowser();
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TListeOutillageCollectPrix.rtf",
                        @"TListeOutillageCollectPrixOut.rtf",
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
          ModuleData.ExecuteNonQuery($"Update TOUTILLAGE set COUTACTIF = 'N' WHERE NOUTNUM = {Convert.ToInt32(currentRow["NOUTNUM"])} ");
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdSupprimer_Click()
    //    
    //On Error GoTo handler
    //
    //  If adoRs.EOF Then Exit Sub
    //  
    //  If MsgBox("§Voulez-vous vraiment archiver ce matériel ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    cnx.Execute "Update TOUTILLAGE set COUTACTIF='N' WHERE NOUTNUM=" & adoRs("NOUTNUM").value
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
    private void cmdArchive_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeFournituresArch().ShowDialog();
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    //Private Sub cmdArchive_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmListeFournituresArch.Show vbModal
    //  adoRs.Requery
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK--------------------------------------------------------------------------*/

    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Num_Art, "NFOUNUM", 0);
        apiTGrid1.AddColumn(Resources.col_Num, "VOUTNUMERO", 750);
        apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 5000, "", 0, true);      // <= AddCellTip
        apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1600, "", 0, true);        // <= AddCellTip
        apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1600, "", 0, true);          // <= AddCellTip  equivaut a 3cm"
        apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1600, "", 0, true);           // <= AddCellTip
        apiTGrid1.AddColumn(Resources.col_Num_serie, "VOUTSERIE", 1600);
        apiTGrid1.AddColumn(Resources.col_Emplacement, "VOUTEMPL", 1600);
        apiTGrid1.AddColumn(Resources.col_Prix, "Prix", 1100, "Currency", 2);
        apiTGrid1.AddColumn("A étalonner", "BETALAFAIRE", 1200);
        apiTGrid1.AddColumn(Resources.col_Date_Etalonnage, "DOUTDETAL", 2200, "dd/mm/yy", 2);
        apiTGrid1.AddColumn(Resources.col_Date_proch_Etal, "DOUTPROCHETAL", 2200, "dd/mm/yy", 2);
        apiTGrid1.AddColumn(Resources.col_Date_garantie, "DOUTGARANTIE", 2200, "dd/mm/yy", 2);
        apiTGrid1.AddColumn(Resources.col_Dernier_Tech, "VLASTTECH", 1800);
        apiTGrid1.AddColumn(Resources.col_Dernier_chantier, "VLASTCOM", 1800);
        apiTGrid1.AddColumn("ETAL MAG", "BETALMAG", 0);

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
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
    //  apiTGrid1.AddColumn "N° série", "VOUTSERIE", 1600
    //  apiTGrid1.AddColumn "§Emplacement§", "VOUTEMPL", 1600
    //  apiTGrid1.AddColumn "§Prix§", "Prix", 1100, "currency", 2
    //  apiTGrid1.AddColumn "§Date Etalonnage§", "DOUTDETAL", 2200, "dd/mm/yy", 2
    //  apiTGrid1.AddColumn "§Date Proch. Etal§", "DOUTPROCHETAL", 2200, "dd/mm/yy", 2
    //  apiTGrid1.AddColumn "Date Garantie", "DOUTGARANTIE", 2200, "dd/mm/yy", 2
    //  apiTGrid1.AddColumn "§Dernier Tech§", "VLASTTECH", 1800
    //  apiTGrid1.AddColumn "§Dernier Chantier§", "VLASTCOM", 1800
    //  
    //  apiTGrid1.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiTGrid1.AddCellTip "VFOUREF", &HFDF0DA
    //
    //
    //  apiTGrid1.Init adoRs
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApiTgrid dans " & Me.Name
    //End Sub

    private void apiTGrid1_ColumnFilterChanged(object sender, EventArgs e)
    {
      txtHT.Text = CalculerSomme();
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




    //Private Sub apiTGrid1_FilterChange()
    //   
    //   ' mise à jour du total
    //   txtHT = FormatNumber(ZeroIfNull(apiTGrid1.SommeColonneName("Prix")), 0) & " €"
    //
    //End Sub
  }




}