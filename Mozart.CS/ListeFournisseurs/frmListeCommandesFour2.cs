using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeCommandesFour2 : Form
  {

    //bool bNiemeFois;
    DataTable dtCom = new DataTable();

    //Dim bNiemeFois As Boolean
    //Dim rsCom As New ADODB.Recordset

    public frmListeCommandesFour2() { InitializeComponent(); }

    private void frmListeCommandesFour2_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitTGrid();

        string sql = $"SELECT NCLINUM, VCLINOM FROM TCLI WHERE VSOCIETE = '{MozartParams.NomSociete}' AND CCLIACTIF='O' ORDER BY VCLINOM";
        txtCritClient.Init(MozartDatabase.cnxMozart, sql, "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 350, 550, true);
        txtCritClient.NewValues = true;

        if (MozartParams.NomSociete == "SAMSICROMANIA")
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF INNER JOIN TPER ON TPER.NPERNUM=TSTF.NSTFQUICREE WHERE (NSTFGRPTYPFO = 1) AND VSOCIETE='SAMSICROMANIA' ORDER BY VSTFNOM, VSTFVIL";
        else if (MozartParams.NomSociete == "SAMSICITALIA")
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF INNER JOIN TPER ON TPER.NPERNUM=TSTF.NSTFQUICREE WHERE (NSTFGRPTYPFO = 1) AND VSOCIETE='SAMSICITALIA' ORDER BY VSTFNOM, VSTFVIL";
        else
          sql = "SELECT NSTFNUM, VSTFNOM, VSTFVIL FROM TSTF WHERE (NSTFGRPTYPFO = 1) ORDER BY VSTFNOM, VSTFVIL";
        txtCritFourn.Init(MozartDatabase.cnxMozart, sql, "NSTFNUM", "VSTFNOM", new List<string>() { Resources.col_Num, Resources.col_Nom, Resources.col_Ville }, 500, 550, true);
        txtCritFourn.NewValues = true;
        /* inutile
        txtCritNumCde.Text = "-1";
        cmdFind_Click(null, null);
        txtCritNumCde.Text = "";
        */
        cmdNouveau.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void frmListeCommandesFour2_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
    }

    private void cmdNouveau_Click(object sender, EventArgs e)
    {
      //selon le type de commande (standart ou tech) on redirige sur le bon écran
      new frmCommandeFournisseur
      {
        miNumCommande = 0,
        mstrStatutCommande = "C"
      }.ShowDialog();

      apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdNouveau_Click()
    //  
    //  'selon le type de commande (standard ou tech) on redirige sur le bon écran
    //  frmCommandeFournisseur.iNumCommande = 0
    //  frmCommandeFournisseur.mstrStatutCommande = "C"
    //  frmCommandeFournisseur.Show vbModal
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null || dtCom.Rows.Count == 0) return;

        // passage des paramètres
        MozartParams.NumAction = Convert.ToInt32(Utils.ZeroIfNull(currentRow["NACTNUM"]));
        new frmCommandeFournisseur
        {
          miNumCommande = (int)Utils.ZeroIfNull(currentRow["NCOMNUM"]),
          mstrStatutCommande = "M",
          mstrStatutAlerte = "NON"
        }.ShowDialog();

        apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdModifier_Click()
    //  
    //On Error GoTo Handler
    //  
    //  If rsCom.EOF Then Exit Sub
    //  
    //  ' passage des paramètres
    //  glNumAction = val(rsCom("NACTNUM").value)
    //  frmCommandeFournisseur.iNumCommande = rsCom!NCOMNUM
    //  frmCommandeFournisseur.mstrStatutCommande = "M"
    //  frmCommandeFournisseur.mstrStatutAlerte = "NON"
    //  frmCommandeFournisseur.Show vbModal
    //  
    //  rsCom.Requery
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "cmdModifier_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression de la commandes selectionnée
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_supprimerEnreg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        ModuleData.SupprimerEnreg(Convert.ToInt64(currentRow["NCOMNUM"]), "api_sp_SupprimerCommande", "@iNumCommande");
        apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupprimer_Click()
    //    
    //On Error GoTo Handler
    //    
    //  'suppression de la commandes selectionnée
    //  If rsCom.EOF Then Exit Sub
    //   
    //  If MsgBox("§Voulez-vous vraiment supprimer l'enregistrement ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    SupprimerEnreg rsCom!NCOMNUM, "api_sp_SupprimerCommande", "@iNumCommande"
    //    rsCom.Requery
    //  End If
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "cmdSupprimer_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (dtCom.Rows.Count == 0 || currentRow == null) return;

      // gestion delegation dépense (affichage bouton impression)
      if (currentRow["CCOMVALID"].ToString() == "E" || currentRow["CCOMVALID"].ToString() == "V")
      {
        MessageBox.Show("Vous ne pouvez pas éditer la commande car elle n'est pas validée pour édition", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      MozartParams.NumAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]);

      // Trop tard, la commande est maintenant considérée comme imprimée !
      ModuleData.CnxExecute($"UPDATE TCOM SET BCOMPRINTED = 1 WHERE NCOMNUM = {currentRow["NCOMNUM"]}");

      /// TODO ??? => pas d'effet
      /*frmBrowser f = new frmBrowser();
      f.miPlanningAn = 0;
      f.msInfosMail = $"TINT|NSTFNUM|{currentRow["NSTFNUM"]}";
      f.mstrType = $"CF{currentRow["NCOMNUM"]}";*/

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TCOMMANDE,
        sIdentifiant = $"{currentRow["NCOMNUM"]}",
        InfosMail = $"TINT|NSTFNUM|{currentRow["NSTFNUM"]}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleData.GetLangueByNSFTNUM((int)currentRow["NSTFNUM"]),
        sOption = "PREVIEW",
        strType = "CF",
        numAction = MozartParams.NumAction
      }.ShowDialog();
    }
    //Private Sub CmdVisu_Click()
    //  
    //  If rsCom.EOF Then Exit Sub
    //  
    //  ' gestion delegation dépense (affichage bouton impression)
    //  If (rsCom("CCOMVALID") = "E" Or rsCom("CCOMVALID") = "V") Then
    //    MsgBox "Vous ne pouvez pas éditer la commande car elle n'est pas validée pour édition", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  glNumAction = val(rsCom("NACTNUM").value)
    //  
    //  ' Trop tard, la commande est maintenant considérée comme imprimée !
    //  cnx.Execute "UPDATE TCOM SET BCOMPRINTED = 1 WHERE NCOMNUM = " & rsCom!NCOMNUM
    //  
    //  Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "COPIE COMPTA"
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.InfosMail = "TINT|NSTFNUM|" & rsCom("NSTFNUM")     ' TABLE | ID    --VL 16/11/04
    //  frmBrowser.mstrType = "CF" & rsCom!NCOMNUM
    //  
    //  Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TCommande;" & rsCom!NCOMNUM & ";TINT|NSTFNUM|" & rsCom("NSTFNUM") & ";" & gstrNomSociete & ";" & GetLangueByNSTFNUM(rsCom("NSTFNUM")) & ";PREVIEW;CF;" & glNumAction & """, vbNormalFocus"
    //                
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdListeBL_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (currentRow == null || dtCom.Rows.Count == 0) return;

      new frmStockReception
      {
        mstrStatut = "V",
        miNumCommande = Convert.ToInt64(currentRow["NCOMNUM"])
      }.ShowDialog();

      apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdListeBL_Click()
    //
    //Dim BookMark
    //
    //  If rsCom.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  frmStockReception.mstrStatut = "V"
    //  frmStockReception.miNumCommande = rsCom!NCOMNUM
    //  BookMark = rsCom.BookMark
    //  frmStockReception.Show vbModal
    //  rsCom.Requery
    //  On Error Resume Next
    //  rsCom.BookMark = BookMark
    //
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Cal.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate0")
      {
        txtDate = txtCritDate0.Text;
        Cal.Tag = 0;
      }
      else
      {
        txtDate = txtCritDate1.Text;
        Cal.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }

      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Cal.Tag == 0) txtCritDate0.Text = Cal.Value.ToShortDateString();
      else if ((int)Cal.Tag == 1) txtCritDate1.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    //Private Sub Cal_Click()
    //  txtCritDate(Cal.Tag) = Cal.value
    //  Cal.Visible = False
    //End Sub

    //Private Sub cmdDate_Click(Index As Integer)
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtCritDate(Index) <> "", txtCritDate(Index), Now)
    //  Cal.Tag = Index
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDI_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        //écran de modification de la demande
        MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
        MozartParams.NumAction = 0;
        new frmAddAction
        {
          mstrStatutDI = "M"
        }.ShowDialog();

        //on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdDi_Click()
    //  
    //On Error GoTo Handler
    //  
    //  If rsCom.EOF Then Exit Sub
    //  
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  giNumDi = rsCom("NDINNUM").value
    //  glNumAction = 0
    //  frmAddAction.Show vbModal
    //      
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "cmdDI_Click dans " & Me.Name
    //End Sub

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  On Error Resume Next
    //  bNiemeFois = False
    //  rsCom.Close: Set rsCom = Nothing
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitTGrid()
    {
      try
      {
        apiTGrid.AddColumn("Num", "NCOMNUM", 1200);
        apiTGrid.dgv.Columns[0].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
        apiTGrid.dgv.Columns[0].DisplayFormat.FormatString = @"CF{0}";
        apiTGrid.AddColumn(Resources.col_DI, "NDINNUM", 1200);
        apiTGrid.dgv.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
        apiTGrid.dgv.Columns[1].DisplayFormat.FormatString = @"Di{0}";
        apiTGrid.AddColumn(Resources.col_Date, "DCOMDAT", 1200, "dd/mm/yy");
        apiTGrid.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 2000);
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
        apiTGrid.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1200, @"\CF0");
        apiTGrid.AddColumn(Resources.col_livraison, "VCOMLLI", 1600);
        apiTGrid.AddColumn(Resources.col_montant_ht, "NCOMPHT", 1200, "Currency", 2);
        apiTGrid.AddColumn(Resources.col_dateL, "DCOMDLI", 1200, "dd/mm/yy");
        apiTGrid.AddColumn(Resources.col_Auteur, "VCOMAUTEUR", 1500);
        apiTGrid.AddColumn("Modificateur", "VCOMNUMCC", 1500);
        apiTGrid.AddColumn(Resources.col_ficheFour, "VLIB", 1300);
        apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 2500);
        apiTGrid.AddColumn(Resources.col_planif, "VCOMTYP", 0, "dd/mm/yy");
        apiTGrid.AddColumn(Resources.col_recept, "NCOMETAT", 1100, "", 2);
        apiTGrid.AddColumn(Resources.col_annulee, "CCOMACTIF", 1200, "", 2);
        apiTGrid.AddColumn("Etat action", "CETACOD", 1100, "", 2);
        apiTGrid.AddColumn(Resources.col_Remarque_Interne, "VCOMREM_INTERNE", 1100, "", 2);

        apiTGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void apiTGrid_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CCOMACTIF"].ToString().ToUpper() == "OUI")
        {
          e.Appearance.BackColor = System.Drawing.Color.Red;
          e.HighPriority = true;
        }
      }
    }

    //Private Sub InitTGrid()
    //  
    //On Error GoTo Handler
    //
    //  apiTGrid.AddColumn "Num", "NCOMNUM", 1200, "\CF0"
    //  apiTGrid.AddColumn "§DI§", "NDINNUM", 1200, "\Di0"
    //  apiTGrid.AddColumn "§Date§", "DCOMDAT", 1200, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Fournisseur§", "VSTFNOM", 2000
    //  apiTGrid.AddColumn "§Client§", "VCLINOM", 2000        '5
    //  apiTGrid.AddColumn "Chaff", "VDINCHAFF", 1600
    //  apiTGrid.AddColumn "§Livraison§", "VCOMLLI", 1600
    //  apiTGrid.AddColumn "§Montant HT§", "NCOMPHT", 1200, "Currency", 2
    //  apiTGrid.AddColumn "§Date L§", "DCOMDLI", 1200, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Auteur§", "VCOMAUTEUR", 1500
    //  apiTGrid.AddColumn "Modificateur", "VCOMNUMCC", 1500
    //  apiTGrid.AddColumn "§Fiche fournitures§", "VLIB", 1300
    //  apiTGrid.AddColumn "§Site§", "VSITNOM", 2500
    //  apiTGrid.AddColumn "§Planif.§", "VCOMTYP", 0, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Recpt§", "NCOMETAT", 1100, , 2
    //  apiTGrid.AddColumn "§Annulée§", "CCOMACTIF", 1200, , 2
    //  apiTGrid.AddColumn "Etat action", "CETACOD", 1100, , 2
    //  
    //   apiTGrid.AddRowStyle "CMD_ANULLE", "CCOMACTIF", "OUI", &H0, &HFF&           ' commande annulée  rouge mais toute la ligne et non pas que la cellule
    //  
    //  apiTGrid.AddCellStyle "NCOMETAT", "", &H0, &HCCCCCC
    //  apiTGrid.AddCellStyle "CCOMACTIF", "", &H0, &HCCCCCC
    //  Exit Sub
    //  Resume
    //  
    //Handler:
    //  ShowError "Initapitgrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "NCOMETAT")
      {
        if (e.CellValue != null)
        {
          if (e.CellValue.ToString() == "PARTIEL") e.Appearance.BackColor = System.Drawing.Color.Orange;
          if (e.CellValue.ToString() == "OUI") e.Appearance.BackColor = MozartColors.ColorH80FF80;
        }
      }
    }
    //Private Sub apiTGrid_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //      
    //    If (DataField = "CCOMACTIF" And CellText = "OUI") Then CellStyle.BackColor = &HFF&
    //    
    //    'Gestion  de la couleur selon létat de la commande MC le 05/01/12
    //    'If (DataField = "NCOMETAT" And CellText = "OUI") Then CellStyle.BackColor = &HFF&
    //    If (DataField = "NCOMETAT") Then
    //        If CellText = "PARTIEL" Then CellStyle.BackColor = &H80FF&
    //        If CellText = "OUI" Then CellStyle.BackColor = &H80FF80 '&HFF&
    //        'If CellText = "NON" Then CellStyle.BackColor = &HCCCCCC  ', &HCCCCCC pas de gestion pour le NON couleur par défaut le grid
    //    End If
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    //Private Sub apiTGrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFind_Click(object sender, EventArgs e)
    {
      // création de la clause SQL à partir des critères saisis
      Cursor = Cursors.WaitCursor;

      try
      {
        string[] tCrit = { "", "", "", "", "" };
        string sWhere = "";

        // récupération des critères si non vide
        if (txtCritNumCde.Text.Trim() != "") tCrit[0] = $"NCOMNUM = {txtCritNumCde.Text}";
        if (txtCritNumDi.Text.Trim() != "") tCrit[1] = $"NDINNUM = {txtCritNumDi.Text}";
        if (txtCritFourn.GetItemValue().Trim() != "") tCrit[2] = $"VSTFNOM LIKE '%{txtCritFourn.GetText().Replace("'", "''")}%'";
        if (txtCritClient.GetItemValue().Trim() != "") tCrit[3] = $"VCLINOM LIKE '%{txtCritClient.GetText().Replace("'", "''")}%'";

        if (txtCritDate0.Text.Trim() != "")
        {
          if (txtCritDate1.Text.Trim() == "") tCrit[4] = $"DCOMDAT = '{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}'";
          else tCrit[4] = $"DCOMDAT BETWEEN '{Convert.ToDateTime(txtCritDate0.Text).ToShortDateString()}' AND '{Convert.ToDateTime(txtCritDate1.Text).ToShortDateString()}'";
        }
        for (int i = 0; i <= 4; i++)
        {
          if (tCrit[i] != "")
          {
            if (sWhere == "")
              sWhere += $"{tCrit[i]}";
            else
              sWhere += $" AND {tCrit[i]}";
          }
        }
        if (sWhere == "")
        {
          MessageBox.Show(Resources.msg_must_type_filter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Cursor = Cursors.Default;
          return;
        }

       //         string sSQL = $"SELECT NCOMPHT, " +
       //$"NCOMPHT nclinum, DCOMDLI, VCOMAUTEUR, VCOMNUMCC, VSITNOM, VCOMTYP, NACTNUM, NSTFNUM, DCOMPLA,BCOMPRINTED, " +
       //$"NCOMETAT, NDINCTE, CCOMACTIF, VSTFPAYS, VSOCIETE, NPERNUM, CCOMVALID, VLIB, CETACOD, VDINCHAFF, VCOMREM_INTERNE, " +
       //$"NCOMNUM, NDINNUM, DCOMDAT, VSTFNOM, VCLINOM, VCOMLLI, " +
       //$"NCOMPHT, " +
       //$"DCOMDLI, VCOMAUTEUR, VCOMNUMCC, " +
       //$"VSITNOM, VCOMTYP, NACTNUM, NSTFNUM, DCOMPLA, BCOMPRINTED, NCOMETAT, NDINCTE, CCOMACTIF, VSTFPAYS, VSOCIETE,  " +
       //$"NPERNUM, CCOMVALID, VLIB, CETACOD, VDINCHAFF, VCOMREM_INTERNE" +
       //                      $" from api_v_listeCOMM WHERE {sWhere} AND VSOCIETE='{MozartParams.NomSociete}' AND NPERNUM = {MozartParams.UID} ORDER BY DCOMDAT DESC, NCOMNUM DESC";

                string sSQL = $"SELECT " +			
$"nclinum, DCOMDLI, VCOMAUTEUR, VCOMNUMCC, VSITNOM, VCOMTYP, NACTNUM, NSTFNUM, DCOMPLA,BCOMPRINTED, " +
$"NCOMETAT, NDINCTE, CCOMACTIF, VSTFPAYS, VSOCIETE, NPERNUM, CCOMVALID, VLIB, CETACOD, VDINCHAFF, VCOMREM_INTERNE, " +
$"NCOMNUM, NDINNUM, DCOMDAT, VSTFNOM, VCLINOM, VCOMLLI, " +
$"case " +
 $"when nclinum = 17571 and dbo.getuserid() in (612, 2881, 4695) then " +
$"case " +
           $" when exists(select* from tdcl where tdcl.cdclactif = 'O' and tdcl.nactnum = V.NACTNUM) " +
                $" and not exists(select * from TFFA inner join tact on tact.nelfnum = tffa.NELFNUM where tact.nactnum = V.NACTNUM) then  " +
                $" (SELECT SUM(DCL.NLDCLPU) " +
                   $" FROM ( " +
                            $" (select((tldcl.NLDCLPU * TLCO.NLCOQTE) / 1.45)  AS NLDCLPU from tdcl inner join tldcl on tldcl.ndclnum = tdcl.ndclnum inner join " +                                                                                       
$" tlco on tlco.ncomnum = v.ncomnum and tlco.nfounum = tldcl.nfounum " +
                                       $" where tdcl.cdclactif = 'O' and tdcl.nactnum = V.NACTNUM) " +
                         $" ) AS DCL)" +
            $" when not exists(select * from tdcl inner join tldcl on tldcl.ndclnum = tdcl.ndclnum where tdcl.cdclactif = 'O' and tdcl.nactnum = V.NACTNUM) " +
            $" and exists(select top 1 npuhtcli from tstockartcli inner join tlco on tlco.ncomnum = v.ncomnum and tlco.nfounum = tstockartcli.nfounum where tstockartcli.nclinum = V.nclinum )  " +
            $" and not exists(select * from TFFA inner join tact on tact.nelfnum = tffa.NELFNUM where tact.nactnum = V.NACTNUM) then " +
                $" (SELECT SUM(stockartcli.NLDCLPU) " +
                    $" FROM( " +
                           $" select top 1(npuhtcli * TLCO.NLCOQTE) / 1.45 AS NLDCLPU from tstockartcli inner join tlco on tlco.ncomnum = v.ncomnum and tlco.nfounum = tstockartcli.nfounum where tstockartcli.nclinum = V.nclinum) AS stockartcli) " +
            $"when not exists(select* from tdcl inner join tldcl on tldcl.ndclnum = tdcl.ndclnum where tdcl.cdclactif = 'O' and tdcl.nactnum = V.NACTNUM) " +
           $" and exists(select* from TFFA inner join tact on tact.nelfnum = tffa.NELFNUM where tact.nactnum = V.NACTNUM) then " +
               $"case " +
                    $"when((SELECT SUM(FFA.NFFAPU) " +
                    $"FROM( " +
                           $" SELECT TOP 1 case  " +
                                $"when CAST(TFFA.NFFAMON / tffa.NFFAQTE AS DECIMAL(9, 3)) / tlco.NLCOPU > 1.45 then CAST(TFFA.NFFAMON / tffa.NFFAQTE AS DECIMAL(9, 3)) / 1.45 " +
                                $"else tlco.NLCOPU " +
                                $"end as NFFAPU " +
                            $"FROM TFFA inner join " +
                                        $"tact on tact.NELFNUM = TFFA.NELFNUM inner join " +
                                        $"tlco on tlco.ncomnum = V.nCOMNUM and tlco.nfounum = tffa.nfounum " +
                            $"where tact.nactnum = V.NACTNUM  order by TFFA.NFFAMON / TFFA.NFFAQTE  DESC " +
                        $") AS FFA " +
                    $")		) is null then " +
                    $" NCOMPHT " +
                    $" else " +
                       $" (SELECT SUM(FFA.NFFAPU) " +
                        $"FROM( " +
                                $"SELECT TOP 1 case  " +
                                  $" when CAST(TFFA.NFFAMON / tffa.NFFAQTE AS DECIMAL(9, 3)) / tlco.NLCOPU > 1.45 then CAST(TFFA.NFFAMON / tffa.NFFAQTE AS DECIMAL(9, 3)) / 1.45 " +
                                  $"  else tlco.NLCOPU " +
                                   $" end as NFFAPU " +
                                $"FROM TFFA inner join " +
                                            $"tact on tact.NELFNUM = TFFA.NELFNUM inner join " +
                                            $"tlco on tlco.ncomnum = V.nCOMNUM and tlco.nfounum = tffa.nfounum " +
                               $" where tact.nactnum = V.NACTNUM  order by TFFA.NFFAMON / TFFA.NFFAQTE  DESC " +
                            $") AS FFA) " +
                    $"end " +
            $"else NCOMPHT " +
        $"end " +
  $"else " +
                   $" NCOMPHT " +
                   $" end AS NCOMPHT, " +
$"DCOMDLI, VCOMAUTEUR, VCOMNUMCC, " +
$"VSITNOM, VCOMTYP, NACTNUM, NSTFNUM, DCOMPLA, BCOMPRINTED, NCOMETAT, NDINCTE, CCOMACTIF, VSTFPAYS, VSOCIETE,  "+
$"NPERNUM, CCOMVALID, VLIB, CETACOD, VDINCHAFF, VCOMREM_INTERNE" +
                      $" from api_v_listeCOMM V WHERE {sWhere} AND VSOCIETE='{MozartParams.NomSociete}' AND NPERNUM = {MozartParams.UID} ORDER BY DCOMDAT DESC, NCOMNUM DESC";
        apiTGrid.LoadData(dtCom, MozartDatabase.cnxMozart, sSQL);
        apiTGrid.GridControl.DataSource = dtCom;

        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow != null) MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("{0}\r\n\r\n{1}{2}", ex.Message, Resources.Global_dans, MethodBase.GetCurrentMethod().Name), Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      finally { Cursor = Cursors.Default; }
    }
    //Private Sub CmdFind_Click()
    //
    //  ' Création de la clause SQL à aprtir des critères saisis
    //  On Error Resume Next
    //  Screen.MousePointer = vbHourglass
    //  rsCom.Close
    //  On Error GoTo Err
    //  
    //  apiTGrid.FilterBar = True
    //  txtCritFourn.LostFocus
    //  txtCritClient.LostFocus
    //  
    //  Dim tCrit(4) As String
    //  Dim sSQL As String, sWhere As String
    //  Dim i As Integer, iAndPos As Integer
    //  
    //  ' Récupération des critères si non vide
    //  If Trim(txtCritNumCde) <> "" Then tCrit(0) = "NCOMNUM = " & txtCritNumCde
    //  If Trim(txtCritNumDi) <> "" Then tCrit(1) = "NDINNUM = " & txtCritNumDi
    //  If Trim(txtCritFourn.Texte) <> "" Then tCrit(2) = "VSTFNOM LIKE '%" & CStr(Replace(txtCritFourn.Texte, "'", "''")) & "%'"
    //  If Trim(txtCritClient.Texte) <> "" Then tCrit(3) = "VCLINOM LIKE '%" & CStr(Replace(txtCritClient.Texte, "'", "''")) & "%'"
    //  
    //   If Trim(txtCritDate(0)) <> "" Then
    //      If Trim(txtCritDate(1)) = "" Then
    //        tCrit(4) = "DCOMDAT = '" & CDate(txtCritDate(0)) & "'"
    //      Else
    //        tCrit(4) = "DCOMDAT BETWEEN '" & CDate(txtCritDate(0)) & "' AND '" & CDate(txtCritDate(1)) & "'"
    //      End If
    //    End If
    //  
    //  For i = 0 To 4
    //    If tCrit(i) <> "" Then sWhere = sWhere & tCrit(i) & " AND "
    //  Next
    // 
    //  ' Enlever le AND de la fin si il existe
    //  If sWhere <> "" Then
    //    iAndPos = InStrRev(sWhere, " AND ")
    //    If iAndPos > 0 Then sWhere = Left(sWhere, iAndPos)
    //    sWhere = " WHERE " & sWhere
    //  End If
    //  
    //  If sWhere = "" Then
    //    MsgBox "Il faut renseigner au moins un filtre"
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //  
    //  sWhere = sWhere & " AND VSOCIETE='" & gstrNomSociete & "' AND NPERNUM = " & gintUID
    //  
    //  sSQL = "SELECT * from api_v_listeCOMM "
    //  sSQL = sSQL & sWhere
    //  
    //  rsCom.Open sSQL, cnx, adOpenDynamic, adLockOptimistic
    //  rsCom.Sort = "DCOMDAT DESC,  NCOMNUM DESC"
    //  apiTGrid.Init rsCom, bNiemeFois
    //  bNiemeFois = True
    //  If Not rsCom.EOF Then glNumAction = rsCom("NACTNUM")
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //Err:
    //  ShowError "cmdFind_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void txtCritNumCde_Enter(object sender, EventArgs e)
    {
      txtCritNumCde.SelectionStart = 0;
      txtCritNumCde.SelectionLength = 100;
    }

    private void txtCritNumCde_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void txtCritNumDi_Enter(object sender, EventArgs e)
    {
      txtCritNumDi.SelectionStart = 0;
      txtCritNumDi.SelectionLength = 100;
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      try
      {
        //suppression de la commande selectionée
        DataRow currentRow = apiTGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_restaurerEnreg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        ModuleData.CnxExecute($"UPDATE TCOM SET CCOMACTIF = 'O' WHERE NCOMNUM = {currentRow["NCOMNUM"]}");
        apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdCloseFrame_Click(object sender, EventArgs e)
    {
      frameLegende.Visible = false;
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      frameLegende.Visible = true;
    }

    private void txtCritNumDi_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}