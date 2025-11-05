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
  public partial class frmOTprestation : Form
  {
    public string mstrStatutPrest;
    public string mstrStatutAction;

    bool bModif;
    bool bInit;

    public DataTable mdtArticle = new DataTable();

    //variables pour frmDetailTravaux
    public string msClient;
    public string msSite;
    public string msNumSite;
    public string msAction;

    //' feuille ouverte en création ou modification
    //Public mstrStatutPrest As String
    //Public mstrStatutAction As String
    //
    //' UPGRADE_INFO (#0501): The 'strStatutValidationCmd' member isn't used anywhere in current application.
    //' Dim strStatutValidationCmd As String
    //' UPGRADE_INFO (#0501): The 'rsC' member isn't used anywhere in current application.
    //' Dim rsC As ADODB.Recordset
    //Dim bModif As Boolean
    //Dim bInit As Boolean
    //' UPGRADE_INFO (#0501): The 'iclient' member isn't used anywhere in current application.
    //' Dim iclient As Integer

    public frmOTprestation() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmOTprestation_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // init 
        bInit = true;

        InitialiserFeuille();

        bInit = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    // 
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  'init
    //  bInit = True
    //
    //  ' on ferme le rsarticle global (utilisé pour les prestations du contrat)
    //  On Error Resume Next
    //  rsarticle.Close
    //  Set rsarticle = Nothing
    //  
    //  On Error GoTo handler
    //  
    //  Call InitialiserFeuille
    //    
    //    'init
    //  bInit = False
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {

      try
      {
        if (mstrStatutPrest == "E")
        {
          MessageBox.Show("Impossible de modifier les prestations d'une action exécutée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // test s'il y a des prestations
        if (mdtArticle.Rows.Count == 0)
        {
          MessageBox.Show("Il faut sélectionner des prestations pour cette action", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //traitement des prestations
        EnregPrest();

        // passage en modification
        mstrStatutPrest = "M";

        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    //' UPGRADE_INFO (#0501): The 'rsContrat' member isn't used anywhere in current application.
    //' Dim rsContrat As ADODB.Recordset
    //' UPGRADE_INFO (#0501): The 'strMessage' member isn't used anywhere in current application.
    //' Dim strMessage As String
    //
    //On Error GoTo handler
    // 
    //  If mstrStatutPrest = "E" Then
    //      MsgBox "Impossible de modifier les prestations d'une action exécutée", vbCritical
    //      Exit Sub
    //  End If
    // 
    //  ''  test si il y a des prestations
    //  If rsarticle.RecordCount = 0 Then
    //      MsgBox "Il faut sélectionner des prestations pour cette action", vbCritical
    //      Exit Sub
    //  End If
    //    
    //  ' traitement des prestations
    //  EnregPrest
    //
    //  ' passage en modification
    //  Me.mstrStatutPrest = "M"
    //  
    //  bModif = False
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdBrouillon_Click(object sender, EventArgs e)
    {
      if (mstrStatutPrest == "C")
      {
        MessageBox.Show("Impression impossible, il faut enregistrer les prestations", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      //      new frmMainReport
      //      {
      //        bLaunchByProcessStart = false,
      //        sTypeReport = "TORDRETRAVAILINFOPREST_BROUILLON",
      //        sIdentifiant = $"{MozartParams.NumAction}",
      //        InfosMail = $"TPER|NPERNUM|0",
      //        sNomSociete = MozartParams.NomSociete,
      ////        sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", miNumTech.ToString())).Substring(0, 2),
      //        sLangue = "FR",
      //        sOption = "PREVIEW"
      //      }.ShowDialog();

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

      frmBrowser f = new frmBrowser
      {
        miPlanningAn = 0,
        mstrType = "PRESTBR"
      };
      f.Preview_Print($@"{MozartParams.CheminModeles}FR\TOrdreTravailPrestBrouillon.rtf",
         @"TOTOut.rtf",
         TdbGlobal,
         $"exec api_sp_OrdreDeTravailPrestBrouillon {MozartParams.NumAction}",
          " (Visualisation contract)",
          "PREVIEW");
    }

    private void cmdNBDLCP_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmPrestationsAction() { mstrStatutPrest = mstrStatutPrest, mdtArticle = this.mdtArticle }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    //Private Sub cmdNBDLCP_Click()
    //  Screen.MousePointer = vbHourglass
    //  frmPrestationsAction.mstrStatutPrest = mstrStatutPrest
    //  frmPrestationsAction.Show vbModal
    //  
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void InitialiserFeuille()
    {
      try
      {
        // recherche liste des prestations de l'action
        apiTGridPrestSaisie.LoadData(mdtArticle, MozartDatabase.cnxMozart, $"exec api_sp_listePrestAction {MozartParams.NumAction}");
        apiTGridPrestSaisie.GridControl.DataSource = mdtArticle;

        // les infos de la feuille
        txtclient.Text = msClient;
        txtsite.Text = msSite;
        txtnumsite.Text = msNumSite;
        txtaction.Text = msAction;

        // si on est en modification ou en création des prestations
        if (mdtArticle.Rows.Count == 0) mstrStatutPrest = "C";
        else mstrStatutPrest = "M";

        InitgridPrest();

        // pas de modification si action exécutée
        if (mstrStatutPrest == "E") cmdNBDLCP.Enabled = false;

        // pas encore de modification
        bModif = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitialiserFeuille()
    //
    //Dim rsD As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  ' recherche liste des prestations de l'action
    //  Set rsD = New ADODB.Recordset
    //  rsD.Open "exec api_sp_listePrestAction " & glNumAction, cnx
    //  
    //  'les infos de la feuille
    //  txtclient.Text = frmDetailstravaux.txtclient
    //  txtsite.Text = frmDetailstravaux.txtsite
    //  txtnumsite.Text = frmDetailstravaux.txtnumsite
    //  txtaction = frmDetailstravaux.txtaction
    //    
    //  InitRecordsetArticle
    //  
    //  ' si on est en modification ou en création des prestations
    //  If rsD.EOF Then
    //    Me.mstrStatutPrest = "C"
    //  Else
    //    Me.mstrStatutPrest = "M"
    //    ' on ramène les prestation de l'action
    //    While Not rsD.EOF
    //      AjouterEnreg rsD
    //      rsD.MoveNext
    //    Wend
    //  End If
    //
    //  InitgridPrest
    //  
    //  ' pas de modification si action exécutée
    //  If mstrStatutPrest = "E" Then cmdNBDLCP.Enabled = False
    //
    //  ' pas encore de modification
    //  bModif = False
    //      
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " initialiserFeuille dans " & Me.Name
    //End Sub
    //

    /* inutile  --------------------------------------------------------------------------------------- */

    //Public Sub InitRecordsetArticle()
    //
    //On Error GoTo handler
    //
    //  Set rsarticle = New ADODB.Recordset
    //  
    //  rsarticle.Fields.Append "ID", adInteger
    //  rsarticle.Fields.Append "CAT", adVarChar, 50
    //  rsarticle.Fields.Append "VPRESTLIB", adVarChar, 5000
    //  rsarticle.Fields.Append "VPRESTUNITE", adVarChar, 50
    //  rsarticle.Fields.Append "NQTE", adDouble
    //  
    //  rsarticle.Open , , adOpenDynamic, adLockOptimistic
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void InitgridPrest()
    {
      if (bInit)
      {
        apiTGridPrestSaisie.AddColumn("ID", "NLDCLPRESTID", 0);
        apiTGridPrestSaisie.AddColumn("Cat", "CAT", 500);
        apiTGridPrestSaisie.AddColumn("Prestation", "VPRESTLIB", 9500);
        apiTGridPrestSaisie.AddColumn("Uté", "VPRESTUNITE", 1500, "", 2);
        apiTGridPrestSaisie.AddColumn("Qté", "NQTE", 1500, "", 2);

        apiTGridPrestSaisie.InitColumnList();
      }

    }

    //Private Sub InitgridPrest()
    //
    //  If bInit Then
    //    apiTGridPrestSaisie.AddColumn "ID", "NLDCLPRESTID", 0
    //    apiTGridPrestSaisie.AddColumn "Cat", "CAT", 500
    //    apiTGridPrestSaisie.AddColumn "Prestation", "VPRESTLIB", 9500
    //    apiTGridPrestSaisie.AddColumn "Uté", "VPRESTUNITE", 1500, , 2
    //    apiTGridPrestSaisie.AddColumn "Qté", "NQTE", 1500, , 2
    // 
    //  End If
    //    
    //  apiTGridPrestSaisie.Init rsarticle
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridPrestSaisie_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "NPACHAT")
      {
        e.Appearance.BackColor = System.Drawing.Color.Orange;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    //Private Sub apiTGridPrestSaisie_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  If DataField = "NPACHAT" Then
    //    CellStyle.BackColor = &HA0FF&
    //    CellStyle.Font.Bold = True
    //  End If
    //End Sub
    //

    /* inutile  --------------------------------------------------------------------------------------- */

    //Private Sub AjouterEnreg(ByVal rs As ADODB.Recordset)
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsarticle.AddNew
    //  
    //  rsarticle("ID").value = rs("NLDCLPRESTID")
    //  rsarticle("CAT").value = rs("CAT")
    //  rsarticle("VPRESTLIB").value = BlankIfNull(rs("VPRESTLIB"))
    //  rsarticle("VPRESTUNITE").value = BlankIfNull(rs("VPRESTUNITE"))
    //  rsarticle("NQTE").value = ZeroIfNull(rs("NQTE"))
    //'  rsarticle("DEBOURSE").Value = rs("DEBOURSE")
    //'  rsarticle("NPACHAT").Value = rs("NPACHAT")
    //
    //  rsarticle.Update
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub
    //
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        //s'il y a des modifications
        if (bModif)
        {
          switch (MessageBox.Show("Voulez-vous enregistrer les modifications ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2))
          {
            case DialogResult.Yes:
              cmdValider_Click(null, null);
              Dispose();
              break;
            case DialogResult.No:
              Dispose();
              break;
            case DialogResult.Cancel:
              return;
            default:
              break;
          }
        }
        else
          Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdFermer_Click()
    //
    //Dim response As String
    //  
    //On Error GoTo handler
    //
    //  ' si il y a des modification
    //  If bModif Then
    //    response = MsgBox("Voulez-vous enregistrer les modifications ?", vbYesNoCancel + vbQuestion + vbDefaultButton2)
    //    Select Case response
    //      Case vbYes
    //        Call cmdValider_Click
    //        Unload Me
    //      Case vbNo
    //        Unload Me
    //      Case vbCancel
    //        Exit Sub
    //    End Select
    //  Else
    //    Unload Me
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdFermer_Click dans " & Me.Name
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void EnregPrest()
    {

      try
      {
        //delete et insert des prestations
        ModuleData.CnxExecute($"delete from TACTPREST WHERE NACTNUM= {MozartParams.NumAction}");

        foreach (DataRow row in mdtArticle.Rows)
          ModuleData.CnxExecute($"insert into TACTPREST select {MozartParams.NumAction} , {row["NLDCLPRESTID"]}, {row["NQTE"]}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub EnregPrest()
    //
    //' UPGRADE_INFO (#0501): The 'tot' member isn't used anywhere in current application.
    //' Dim tot As Double
    //' UPGRADE_INFO (#0501): The 'rsPrest' member isn't used anywhere in current application.
    //' Dim rsPrest As New ADODB.Recordset
    //
    //On Error GoTo handler
    //   
    //  ' delete et insert des prestations
    //  cnx.Execute "delete from TACTPREST WHERE NACTNUM= " & glNumAction
    //  
    //  rsarticle.MoveFirst
    //  While Not rsarticle.EOF
    //      cnx.Execute "insert into TACTPREST select " & glNumAction & " ," & rsarticle("ID") & " ," & rsarticle("NQTE")
    //    rsarticle.MoveNext
    //  Wend
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " EnregPrest dans " & Me.Name
    //End Sub
    //
    //
    //
  }
}

