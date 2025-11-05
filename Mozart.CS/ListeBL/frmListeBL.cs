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
  public partial class frmListeBL : Form
  {
    DataTable dt = new DataTable();
    public string mstrTech;
    public string mstrSite;

    public frmListeBL()
    {
      InitializeComponent();
    }

    private void frmListeBL_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeBE where NACTNUM = {MozartParams.NumAction}");
        apiTGrid1.GridControl.DataSource = dt;
        InitTGrid();

        Cursor = Cursors.Default;
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
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from api_v_ListeBE where NACTNUM = " & glNumAction, cnx
    //
    //  InitTGrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitTGrid()
    {
      apiTGrid1.AddColumn("En prépa", "ENPREPA", 1200, "", 0, false, true, false);
      apiTGrid1.AddColumn("Num", "NBENUM", 1000);
      apiTGrid1.AddColumn(Resources.col_Date, "DBEDATE", 1200, "dd/mm/yy");
      apiTGrid1.AddColumn(Resources.col_Auteur, "VPERNOM", 1800, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_destinataire, "VBETYPDEST", 1500);
      apiTGrid1.AddColumn(Resources.col_dateLivr, "DBEDATEEXPE", 1200, "dd/mm/yy");
      apiTGrid1.AddColumn(Resources.col_Objet, "VBEOBJET", 4000, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_traite, "CBESOLDEE", 1000);

      apiTGrid1.InitColumnList();
    }
    //Sub InitTGrid()
    //  
    //  apiTGrid1.AddColumn "En prépa", "ENPREPA", 1200, , , , True, False
    //  apiTGrid1.AddColumn "Num", "NBENUM", 1000
    //  apiTGrid1.AddColumn "§Date§", "DBEDATE", 1200, "dd/mm/yy"
    //  apiTGrid1.AddColumn "§Auteur§", "VPERNOM", 1800
    //  apiTGrid1.AddColumn "§Destinataire§", "VBETYPDEST", 1500
    //  apiTGrid1.AddColumn "§Date livr§", "DBEDATEEXPE", 1200, "dd/mm/yy"
    //  apiTGrid1.AddColumn "§Objet§", "VBEOBJET", 4000
    //  apiTGrid1.AddColumn "§Traité§", "CBESOLDEE", 1000
    //    
    //  ' Tooltip sur des cellules
    //  apiTGrid1.AddCellTip "VBEOBJET", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid1.AddCellTip "VPERNOM", &HFDF0DA
    //  
    //  ' cell style
    //  apiTGrid1.AddCellStyle "ENPREPA", "", &HCCCCCC, vbWhite
    //  
    //  apiTGrid1.Init adoRS
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "ENPREPA")
      {
        if (dt.Rows.Count > 0)
        {
          if (e.CellValue != null && e.CellValue.ToString() == "OUI")
          {
            e.Appearance.ForeColor = Color.White;
            e.Appearance.BackColor = Color.Red;
            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          }

        }
      }

    }
    //Private Sub apiTGrid1_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  
    //  Select Case DataField
    //    Case "ENPREPA"
    //      If CellText = "OUI" Then
    //        CellStyle.ForeColor = vbWhite  '&HC000&
    //        CellStyle.BackColor = vbRed
    //        CellStyle.Font.Bold = True
    //      End If
    //  End Select
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      new frmSaisieStock
      {
        mstrTech = mstrTech,
        mstrSite = mstrSite,
        bModif = true,
        iNumBL = 0
      }.ShowDialog();

      Cursor = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;
    }
    //Private Sub cmdNouvelle_Click()
    //    
    //  frmSaisieStock.mstrTech = frmDetailsTravaux.txtInter.Text
    //  frmSaisieStock.mstrSite = frmDetailsTravaux.txtSite.Text
    //  frmSaisieStock.bModif = True
    //  frmSaisieStock.iNumBL = 0
    //  
    //  frmSaisieStock.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //        
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //  Screen.MousePointer = vbDefault
    //    
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (dt.Rows.Count == 0) return;

      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      new frmSaisieStock
      {
        mstrTech = mstrTech,
        mstrSite = mstrSite,
        bModif = currentRow["CBESOLDEE"].ToString() == "O" ? false : true,
        iNumBL = Convert.ToInt32(Strings.Mid(currentRow["NBENUM"].ToString(), 3))
      }.ShowDialog();

      Cursor = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //    
    //  If adoRS.EOF Then Exit Sub
    //  
    //  frmSaisieStock.mstrStatutStock = "M"
    //  frmSaisieStock.bModif = IIf(adoRS("CBESOLDEE") = "O", False, True)
    //  frmSaisieStock.mstrTech = frmDetailsTravaux.txtInter.Text
    //  frmSaisieStock.mstrSite = frmDetailsTravaux.txtSite
    //  frmSaisieStock.iNumBL = val(Mid(adoRS("NBENUM").value, 3))
    //
    //  ' affichage feuille
    //  frmSaisieStock.Show vbModal
    //        
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      //try
      //{
      //  DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      //  if (currentRow == null) return;
      //  if (dt.Rows.Count == 0) return;

      //  if (MessageBox.Show(Resources.msg_supprBL, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      //    return;
      //  else
      //    return;

      //  apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      //}
      //catch (Exception ex)
      //{
      //  MessageBox.Show(string.Format("{0}\r\n\r\n{1}{2}", ex.Message, Resources.Global_dans, MethodBase.GetCurrentMethod().Name), Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //}
    }
    //Private Sub cmdSupprimer_Click()
    //    
    //On Error GoTo handler
    //
    //  'suppression
    //  If adoRS.EOF Then Exit Sub
    //    
    //  Select Case MsgBox("§Voulez-vous vraiment supprimer ce BL ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //'      SupprimerEnreg adoRS("NUMCOUR").Value, "api_sp_SupprimerCourrier", "@iNumCourrier"
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //    
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid1_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    //Private Sub apiTGrid1_DblClick()
    //  Call cmdModifier_Click
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdArchiver_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_archiBL, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.CnxExecute($"update TBE SET CBEACTIF = 'N' where NBENUM = {Convert.ToInt32(Strings.Mid(currentRow["NBENUM"].ToString(), 3))}");
        else
          return;

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdArchiver_Click()
    //
    //On Error GoTo handler
    //
    //  If adoRS.EOF Then Exit Sub
    //    
    //  Select Case MsgBox("§Voulez-vous vraiment archiver ce BL ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      cnx.Execute "update TBE SET CBEACTIF = 'N' where NBENUM = " & val(Mid(adoRS("NBENUM").value, 3))
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  adoRS.Requery
    //    
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdArchiver_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdArchives_Click(object sender, EventArgs e)
    {
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT DISTINCT 'BL' + dbo.FormatCle(dbo.TBE.NBENUM, 5) AS NBENUM, CBESOLDEE, DBEDATE, vpernom, VBETYPDEST, VBEOBJET, NBEIDDEST, " +
                        $"NACTNUM, DBEDATEEXPE FROM  TBE INNER JOIN TPER ON dbo.TBE.NBEIDCRE = dbo.TPER.NPERNUM WHERE TBE.CBEACTIF = 'N' and NACTNUM = {MozartParams.NumAction}");
      apiTGrid1.GridControl.DataSource = dt;

      cmdArchiver.Visible = cmdNouvelle.Visible = cmdModifier.Visible = cmdArchives.Visible = false;
      cmdRestaurer.Visible = true;
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_restaurerBL, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.CnxExecute($"update TBE SET CBEACTIF = 'O' where NBENUM = {Convert.ToInt32(Strings.Mid(currentRow["NBENUM"].ToString(), 3))}");
        else
          return;

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdRestaurer_Click()
    //
    //On Error GoTo handler
    //
    //  If adoRS.EOF Then Exit Sub
    //    
    //  Select Case MsgBox("§Voulez-vous vraiment restaurer ce BL ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      cnx.Execute "update TBE SET CBEACTIF = 'O' where NBENUM = " & val(Mid(adoRS("NBENUM").value, 3))
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  adoRS.Requery
    //    
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdRestaurer_Click dans " & Me.Name
    //End Sub
  }
}