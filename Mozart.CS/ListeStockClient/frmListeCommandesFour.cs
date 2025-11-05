using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeCommandesFour : Form
  {
    public int miFouNum;
    public int miCompte;
    public string mstrStatutCom = "";
    public bool mbFacture;

    DataTable dtCom = new DataTable();

    public frmListeCommandesFour() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmListeCommandesFour_Load(object sender, System.EventArgs e)
    {
      try
      {
        string sSql = "";

        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //  Si on vient d'une action, on liste les commandes de cette action
        // laisser SELECT et TOP 1000 en majuscules
        if (mstrStatutCom == "A" || mstrStatutCom == "M")
        {
          sSql = $"SELECT * from api_v_listeCOM where NACTNUM = {MozartParams.NumAction}  order by DCOMDAT desc, NCOMNUM desc";          

                    /*sSql = $"SELECT NCOMNUM, NDINNUM, DCOMDAT, VSTFNOM, VCLINOM, VCOMLLI,  DCOMDLI, VCOMAUTEUR, " +
                        $"case " +
 $"when nclinum = 17571 and dbo.getuserid() in (612, 2881, 4695) then " +
$"case " +
           $" when exists(select* from tdcl where tdcl.cdclactif = 'O' and tdcl.nactnum = V.NACTNUM) " +
                $" and not exists(select * from TFFA inner join tact on tact.nelfnum = tffa.NELFNUM where tact.nactnum = V.NACTNUM) then  " +
                $" (SELECT SUM(DCL.NLDCLPU) " +
                   $" FROM ( " +
                            $" (select case " +
                            $" when TLDCL.NLDCLPC > 0 and TLDCL.NLDCLPC / TLDCL.NLDCLPU <= 1.45 then TLDCL.NLDCLPU " +
                            $"else " +
                        $" cast(( " +
                            $" (case when TLDCL.NLDCLPC > 0 then TLDCL.NLDCLPC else TLDCL.NLDCLPU* TLDCL.NFOUCOEFF end)" +
                                                                $" )" +
                                                                $" / 1.45 as decimal(9, 3))" +
                                                   $" end * TLCO.NLCOQTE AS NLDCLPU from tdcl inner join tldcl on tldcl.ndclnum = tdcl.ndclnum inner join " +
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
$"VCOMNUMCC, VSITNOM, VCOMTYP, NACTNUM, NSTFNUM, DCOMPLA, BCOMPRINTED, NCOMETAT,NDINCTE, " +
$"CCOMACTIF, VSTFPAYS, VSOCIETE, NPERNUM, CCOMVALID,VLIB,VCOMREM_INTERNE,NCLINUM "+
$" from api_v_listeCOM V where NACTNUM = {MozartParams.NumAction}  order by DCOMDAT desc, NCOMNUM desc";*/

                    cmdNouveau.Visible = true;
          chkAll.Visible = false;
        }
        else if (mstrStatutCom == "R")
        {
          sSql = $"SELECT * from api_v_listeCOM where (NDINCTE = 995 or NDINCTE = 993) AND VCOMLLI = '{MozartParams.NomSociete}' AND DCOMDAT > '01/01/2017' order by DCOMDAT desc, NCOMNUM desc";
          cmdNouveau.Visible = true;
          cmdDI.Visible = true;
          chkAll.Visible = false;
        }
        // on vient d'un fournisseur
        else if (mstrStatutCom == "T")
        {
          sSql = "SELECT TOP 1000 * from api_v_listeCOM order by DCOMDAT desc, NCOMNUM desc";
          cmdNouveau.Visible = false;
        }
        // on veut les commandes planifiées
        else if (mstrStatutCom == "P")
        {
          sSql = "SELECT TOP 1000 * from api_v_listeCOM WHERE DCOMPLA IS NOT NULL AND DCOMPLA > Getdate() order by DCOMPLA";
          cmdNouveau.Visible = false;
          chkAll.Visible = false;
        }
        // on veut les commandes de réappro (Stock) d'un article précis
        else if (mstrStatutCom == "S")
        {
          sSql = $"EXEC api_sp_ListeCommandesUnArticle {miFouNum}, {miCompte}";
          cmdNouveau.Visible = false;
          chkAll.Visible = false;
        }

        apiTGrid.LoadData(dtCom, MozartDatabase.cnxMozart, sSql);
        apiTGrid.GridControl.DataSource = dtCom;
        InitApiTgrid();

        if (mstrStatutCom == "R")
          apiTGrid.dgv.ActiveFilterString = "NCOMETAT = 'NON'";

        if (dtCom.Rows.Count > 0 && mstrStatutCom != "S")
          MozartParams.NumAction = Convert.ToInt32(dtCom.Rows[0]["NACTNUM"]);
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
    //On Error GoTo handler
    //  
    //  InitBoutons Me, frmMenu
    // 
    //  Set rsCom = New ADODB.Recordset
    //  ' si on vient d'une action, on liste les commandes de cette action
    //  If mstrStatutCom = "A" Or mstrStatutCom = "M" Then
    //    rsCom.Open "select * from api_v_listeCOM where NACTNUM = " & glNumAction & "  order by DCOMDAT desc, NCOMNUM desc", cnx
    //    cmdNouveau.Visible = True
    //    chkAll.Visible = False
    //  ElseIf mstrStatutCom = "R" Then
    //    rsCom.Open "select * from api_v_listeCOM where (NDINCTE = 995 or NDINCTE = 993) AND VCOMLLI = '" & gstrNomSociete & "' AND DCOMDAT > '01/01/2017' order by DCOMDAT desc, NCOMNUM desc", cnx
    //    cmdNouveau.Visible = True
    //    chkAll.Visible = False
    //    cmdDI.Visible = True
    //  ElseIf mstrStatutCom = "T" Then  'on vient d'un fournisseur
    //    rsCom.Open "select TOP 1000 * from api_v_listeCOM order by DCOMDAT desc, NCOMNUM desc", cnx
    //'    apiGrid.AddFilter "Fournisseur", mstrFiltreFO
    //    cmdNouveau.Visible = False
    //  ElseIf mstrStatutCom = "P" Then  'on veut les commandes planifiées
    //    rsCom.Open "select TOP 1000 * from api_v_listeCOM WHERE DCOMPLA IS NOT NULL AND DCOMPLA > Getdate() order by DCOMPLA", cnx
    //    cmdNouveau.Visible = False
    //    chkAll.Visible = False
    //  ElseIf mstrStatutCom = "S" Then  'on veut les commandes de réappro (Stock) d'un article précis
    //    rsCom.Open "EXEC api_sp_ListeCommandesUnArticle " & miFouNum & ", " & miCompte, cnx
    //    cmdNouveau.Visible = False
    //    chkAll.Visible = False
    //  End If
    //  
    //  InitApiTgrid
    //  If mstrStatutCom = "R" Then apiTGrid.SetFilter ("NCOMETAT = 'NON'")
    //    
    //  If Not rsCom.EOF And mstrStatutCom <> "S" Then glNumAction = rsCom("NACTNUM")
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /*--------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdNouveau_Click(object sender, EventArgs e)
    {
      //  Si la DI est facturée on ne peut pas créer de commande
      if (mbFacture)
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      new frmCommandeFournisseur
      {
        miNumCommande = 0,
        mstrStatutCommande = "C"
      }.ShowDialog();

      if (mstrStatutCom != "R")
        Dispose();
    }
    //Private Sub cmdNouveau_Click()
    //  
    //  ' si la DI est facturée on ne peut pas créer de commande
    //  If bFacture Then
    //    MsgBox "§Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'§", vbOKOnly
    //    Exit Sub
    //  End If
    //
    //  frmCommandeFournisseur.iNumCommande = 0
    //  frmCommandeFournisseur.mstrStatutCommande = "C"
    //  frmCommandeFournisseur.Show vbModal
    //  
    //  ' on repasse à l'action
    //  If mstrStatutCom <> "R" Then Unload Me
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);

      new frmCommandeFournisseur
      {
        mstrStatutCommande = "M",
        miNumCommande = Convert.ToInt32(row["NCOMNUM"])
      }.ShowDialog();

      apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdModifier_Click()
    //  
    //On Error GoTo handler
    //  
    //  If rsCom.EOF Then Exit Sub
    //    
    //  ' passage des paramètres
    //  glNumAction = val(rsCom("NACTNUM").value)
    //  frmCommandeFournisseur.mstrStatutCommande = "M"
    //  frmCommandeFournisseur.iNumCommande = rsCom!NCOMNUM
    //  frmCommandeFournisseur.Show vbModal
    //  
    //  rsCom.Requery
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdModifier_Click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (row == null) return;

        //  Suppression de la commandes selectionnée
        if (MessageBox.Show(Resources.msg_supprimerEnreg, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.SupprimerEnreg(Convert.ToInt32(row["NCOMNUM"]), "api_sp_SupprimerCommande", "@iNumCommande");
          apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
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
    //handler:
    //  ShowError "cmdSupprimer_Click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      //  Gestion delegation dépense (affichage bouton impression)
      if (row["CCOMVALID"].ToString() == "E" || row["CCOMVALID"].ToString() == "V")
      {
        MessageBox.Show("Vous ne pouvez pas éditer la commande car elle n'est pas validée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      //  Trop tard, la commande est maintenant considérée comme imprimée !
      ModuleData.ExecuteNonQuery($"UPDATE TCOM SET BCOMPRINTED = 1 WHERE NCOMNUM = {row["NCOMNUM"]}");

      //  mise a jour le l'action sur laquelle on est.
      MozartParams.NumAction = Convert.ToInt32(row["NACTNUM"]);

      //Shell gstrRepertoireReports &"ReportEmalec.Net.exe " & """TCommande;" & rsCom!NCOMNUM & ";TINT|NSTFNUM|" & rsCom("NSTFNUM") & ";" & gstrNomSociete & ";" 
      //  & GetLangueByNSTFNUM(rsCom("NSTFNUM")) & ";PREVIEW;CF;" & glNumAction & """, vbNormalFocus"

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TCOMMANDE,
        sIdentifiant = $"{row["NCOMNUM"]}",
        InfosMail = $"TINT|NSTFNUM|{row["NSTFNUM"]}",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleData.GetLangueByNSFTNUM(Convert.ToInt32(row["NSTFNUM"])),
        sOption = "PREVIEW",
        strType = "CF",
        numAction = MozartParams.NumAction
      }.ShowDialog();

      //If mstrStatutCom = "R" Then
      //  Dim bm
      //    bm = rsCom.BookMark
      //    rsCom.Requery
      //    apiTGrid.Init rsCom, True
      //    rsCom.BookMark = bm
      //  End If

    }
    //Private Sub cmdVisu_Click()
    //  
    //  If rsCom.EOF Then Exit Sub
    //  
    //  ' gestion delegation dépense (affichage bouton impression)
    //  If (rsCom("CCOMVALID") = "E" Or rsCom("CCOMVALID") = "V") Then
    //    MsgBox "Vous ne pouvez pas éditer la commande car elle n'est pas validée", vbInformation
    //    Exit Sub
    //  End If
    //
    //  ' Trop tard, la commande est maintenant considérée comme imprimée !
    //  cnx.Execute "UPDATE TCOM SET BCOMPRINTED = 1 WHERE NCOMNUM = " & rsCom!NCOMNUM
    //  
    //  ' mise a jour le l'action sur laquelle on est.
    //  glNumAction = val(rsCom("NACTNUM").value)
    //  
    //  Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "COPIE COMPTA"
    //
    //  Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TCommande;" & rsCom!NCOMNUM & ";TINT|NSTFNUM|" & rsCom("NSTFNUM") & ";" & gstrNomSociete & ";" & GetLangueByNSTFNUM(rsCom("NSTFNUM")) & ";PREVIEW;CF;" & glNumAction & """, vbNormalFocus"
    //
    //'  frmBrowser.bPlanningAn = 0
    //'  frmBrowser.InfosMail = "TINT|NSTFNUM|" & rsCom("NSTFNUM")     ' TABLE | ID    --VL 16/11/04
    //'  frmBrowser.mstrType = "CF" & rsCom!NCOMNUM
    //'  frmBrowser.Preview_Print gstrCheminModeles & CodePays(rsCom("VSTFPAYS")) & "\TCommandeFourniture.rtf", _
    //'                           "\" & rsCom("NCOMNUM") & "_TCommandeFournitureOut.rtf", _
    //'                         TdbGlobal(), _
    //'                         "exec api_sp_impCommande " & rsCom!NCOMNUM, _
    //'                         " (Prévisualisation commande)", _
    //'                         "PREVIEW"
    //  
    //  If mstrStatutCom = "R" Then
    //  Dim bm
    //    bm = rsCom.BookMark
    //    rsCom.Requery
    //    apiTGrid.Init rsCom, True
    //    rsCom.BookMark = bm
    //  End If
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdListeBL_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      new frmStockReception
      {
        mstrStatut = "M",
        miNumCommande = (int)Utils.ZeroIfBlank(row["NCOMNUM"])
      }.ShowDialog();


      apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdListeBL_Click()
    //
    //Dim BookMark
    //
    //  If rsCom.EOF Then Exit Sub
    //'  If IsNull(rsCom!NCOMETAT) Then Exit Sub
    //'  If rsCom!NCOMETAT = "NON" Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  frmStockReception.mstrStatut = "M"
    //  frmStockReception.miNumCommande = rsCom!NCOMNUM
    //  BookMark = rsCom.BookMark
    //  frmStockReception.Show vbModal
    //  rsCom.Requery
    //  On Error Resume Next
    //  rsCom.BookMark = BookMark
    //
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_restaurerEnreg, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

      ModuleData.ExecuteNonQuery($"UPDATE TCOM SET CCOMACTIF = 'O' WHERE NCOMNUM = {(int)Utils.ZeroIfBlank(row["NCOMNUM"])}");

      apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdRestaurer_Click()
    //
    //On Error GoTo handler
    //    
    //  'suppression de la commandes selectionnée
    //  If rsCom.EOF Then Exit Sub
    //   
    //  If MsgBox("§Voulez-vous vraiment restaurer l'enregistrement ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    cnx.Execute "UPDATE TCOM SET CCOMACTIF = 'O' WHERE NCOMNUM = " & rsCom!NCOMNUM
    //    rsCom.Requery
    //  End If
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdSupprimer_Click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  On Error Resume Next
    //  bFacture = False
    //  Screen.MousePointer = vbDefault
    //  rsCom.Close
    //  Set rsCom = Nothing
    //End Sub
    private void frmListeCommandesFour_FormClosed(object sender, FormClosedEventArgs e)
    {
      mbFacture = false;
    }

    /* --------------------------------------------------------------------------------------- */
    private void chkAll_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (null == apiTGrid.sSqlDataSource || "" == apiTGrid.sSqlDataSource) return;
        Cursor.Current = Cursors.WaitCursor;

        if (chkAll.Checked)
          apiTGrid.sSqlDataSource = apiTGrid.sSqlDataSource.Replace("TOP 1000 ", "");
        else
          apiTGrid.sSqlDataSource = apiTGrid.sSqlDataSource.Replace("SELECT", "SELECT TOP 1000 ");

        apiTGrid.Requery(dtCom, MozartDatabase.cnxMozart);
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
    //Private Sub chkAll_Click()
    //Dim sSQL As String
    //  
    //  Screen.MousePointer = vbHourglass
    //  If chkAll.value = 1 Then
    //    sSQL = Replace(rsCom.Source, "TOP 1000 ", "", , , vbTextCompare)
    //  Else
    //    sSQL = Replace(rsCom.Source, "SELECT ", "SELECT TOP 1000 ", , , vbTextCompare)
    //  End If
    //  rsCom.Close
    //  
    //  rsCom.Open sSQL, cnx
    //  apiTGrid.Init rsCom, True
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      apiTGrid.AddColumn("Num", "NCOMNUM", 1000);
      apiTGrid.dgv.Columns[0].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      apiTGrid.dgv.Columns[0].DisplayFormat.FormatString = @"CF{0}";
      apiTGrid.AddColumn(Resources.col_DI, "NDINNUM", 800);
      apiTGrid.dgv.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      apiTGrid.dgv.Columns[1].DisplayFormat.FormatString = @"Di{0}";
      apiTGrid.AddColumn(Resources.col_Date, "DCOMDAT", 900, "dd/mm/yy");
      apiTGrid.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 1600);
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1600); //'5
      apiTGrid.AddColumn(Resources.col_livraison, "VCOMLLI", 1600);
      apiTGrid.AddColumn(Resources.col_montantHT, "NCOMPHT", 1200, "Currency", 2);
      apiTGrid.AddColumn(Resources.col_dateL, "DCOMDLI", 900, "dd/mm/yy");
      apiTGrid.AddColumn(Resources.col_Auteur, "VCOMAUTEUR", 1100);
      apiTGrid.AddColumn(Resources.col_NumCarnet, "VCOMNUMCC", 800);
      apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 1050);
      apiTGrid.AddColumn(Resources.col_planif, "VCOMTYP", (mstrStatutCom == "P" ? 800 : 0), "dd/mm/yy");
      apiTGrid.AddColumn(Resources.col_recept, "NCOMETAT", 1100);
      apiTGrid.AddColumn(Resources.col_annulee, "CCOMACTIF", 1100);
      apiTGrid.AddColumn(Resources.col_ficheFour, "VLIB", 1300);
      apiTGrid.AddColumn(Resources.col_Remarque_Interne, "VCOMREM_INTERNE", 1300);

      if (mstrStatutCom == "R")
        this.apiTGrid.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid_RowStyle);

      apiTGrid.InitColumnList();
    }
    private void apiTGrid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        if ((sender as GridView).GetDataRow(e.RowHandle)["BCOMPRINTED"].ToString() == "False")
        {
          e.Appearance.BackColor = MozartColors.ColorHDDFFBB;
          e.HighPriority = true;
        }
      }
    }
    //Private Sub InitApiTgrid()
    //  
    //On Error GoTo handler
    //
    //  apiTGrid.AddColumn "Num", "NCOMNUM", 1000, "\CF0"
    //  apiTGrid.AddColumn "§DI§", "NDINNUM", 800, "\Di0"
    //  apiTGrid.AddColumn "§Date§", "DCOMDAT", 900, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Fournisseur§", "VSTFNOM", 1600
    //  apiTGrid.AddColumn "§Client§", "VCLINOM", 1600        '5
    //  apiTGrid.AddColumn "§Livraison§", "VCOMLLI", 1600
    //  apiTGrid.AddColumn "§Montant HT§", "NCOMPHT", 1200, "Currency", 2
    //  apiTGrid.AddColumn "§Date L§", "DCOMDLI", 900, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Auteur§", "VCOMAUTEUR", 1100
    //  apiTGrid.AddColumn "§NumCarnet§", "VCOMNUMCC", 800
    //  apiTGrid.AddColumn "§Site§", "VSITNOM", 1050
    //  apiTGrid.AddColumn "§Planif.§", "VCOMTYP", IIf(mstrStatutCom = "P", 800, 0), "dd/mm/yy"
    //  apiTGrid.AddColumn "§Recpt§", "NCOMETAT", 1100
    //  apiTGrid.AddColumn "§Annulée§", "CCOMACTIF", 1100
    //  apiTGrid.AddColumn "§Fiche fournitures§", "VLIB", 1300
    // 
    //  If mstrStatutCom = "R" Then
    //    apiTGrid.AddRowStyle "OK", "BCOMPRINTED", "Faux", vbBlack, &HDDFFBB       'Vert pale
    //  End If
    //    
    //  apiTGrid.AddCellStyle "NCOMETAT", "", &H0, &HCCCCCC      ' rouge si non reception
    //    
    //  apiTGrid.Init rsCom
    //  
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "Initapitgrid dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "NCOMETAT" && e.CellValue != null)
      {
        if (e.CellValue.ToString() == "PARTIEL")
          e.Appearance.BackColor = MozartColors.ColorH80FF00;
        else if (e.CellValue.ToString() == "OUI")
          e.Appearance.BackColor = MozartColors.ColorH80FF80;
        //else if (e.CellValue.ToString() == "NON")
        //  e.Appearance.BackColor = MozartColors.colorHCCCCCC;
      }

      GridView View = sender as GridView;
      if (e.Column.Name == "CCOMACTIF" && e.CellValue != null)
      {
        if (e.CellValue.ToString() == "OUI")
        {
          e.Appearance.BackColor = System.Drawing.Color.Orange;
        }
      }
    }
    //Private Sub apiTGrid_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //    ' Gestion spécifique des couleurs
    //    If (DataField = "NCOMETAT") Then
    //        If CellText = "PARTIEL" Then CellStyle.BackColor = &H80FF&
    //        If CellText = "OUI" Then CellStyle.BackColor = &H80FF80 '&HFF&
    //        'If CellText = "NON" Then CellStyle.BackColor = &HCCCCCC  ', &HCCCCCC pas de gestion pour le NON couleur par défaut le grid
    //    End If
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }
    //Private Sub apiTGrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdCloseFrame_Click(object sender, EventArgs e)
    {
      frameLegende.Visible = false;
    }
    //Private Sub cmdCloseFrame_Click()
    //    frameLegende.Visible = False
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdLegende_Click(object sender, EventArgs e)
    {
      frameLegende.Visible = true;
    }
    //Private Sub cmdLegende_Click()
    //    frameLegende.Visible = True
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdDI_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      MozartParams.NumAction = (int)Utils.ZeroIfBlank(row["NACTNUM"]);
      MozartParams.NumDi = (int)Utils.ZeroIfBlank(row["NDINNUM"]);

      //  écran de modification de la demande
      new frmAddAction
      {
        mstrStatutDI = "M"
      }.ShowDialog();

      MozartParams.NumAction = 0;
      MozartParams.NumDi = 0;
    }

    //Private Sub cmdDi_Click()
    //
    // 
    //  If rsCom.EOF Then Exit Sub
    //
    //  ' écran de modification de la demande
    //  frmAddAction.mstrStatutDI = "M"
    //  glNumAction = rsCom("NACTNUM")
    //  giNumDi = rsCom("NDINNUM")
    //    
    //  On Error Resume Next
    //  
    //  frmAddAction.Show vbModal
    //    
    //  glNumAction = 0
    //  giNumDi = 0
    //
    //End Sub
  }
}