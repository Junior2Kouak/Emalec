using MZCtrlResources = MozartControls.Properties.Resources;
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
  public partial class frmListeOG : Form
  {
    public int iNumAct;
    DataTable dt = new DataTable();

    //Public p_iNumAct As Long
    //Dim adoRS As ADODB.Recordset

    public frmListeOG() { InitializeComponent(); }

    private void frmListeOG_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeOG where NACTNUM = {iNumAct}");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex) {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
	  }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //
    //    On Error GoTo handler:
    //
    //    InitBoutons Me, frmMenu
    //      
    //    Set adoRS = New ADODB.Recordset
    //      
    //    adoRS.Open "select * from api_v_ListeOG where NACTNUM = " & p_iNumAct, cnx
    //          
    //    InitApigrid
    //          
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //      
    //handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "Form_Load de " & Me.Name
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiGrid.AddColumn("Num", "NOGNUM", 500);
      apiGrid.AddColumn(Resources.col_Date, "DOGCREE", 900, "dd/MM/yy");
      apiGrid.AddColumn(Resources.col_Auteur, "VAUTEUR", 1300);
      apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1300);
      apiGrid.AddColumn(Resources.col_STInstallation, "VSTFNOM", 1500);
      apiGrid.AddColumn(Resources.col_Contact, "VINTNOM", 1500);
      apiGrid.AddColumn(Resources.txt_Mail, "VINTMAIL", 1500);
      apiGrid.AddColumn(Resources.col_dateEnvoi, "DOMDEX", 1100);
      apiGrid.AddColumn(Resources.col_Action, "VOGCORPS", 3000);
      apiGrid.AddColumn(Resources.col_Actif, "COGACTIF", 580);
      apiGrid.AddColumn("NACTNUM", "NACTNUM", 0);
      apiGrid.AddColumn("NINTNUM", "NINTNUM", 0);
      apiGrid.AddColumn("NCLINUM", "NCLINUM", 0);
      apiGrid.AddColumn("NSTFNUM", "NSTFNUM", 0);
      apiGrid.AddColumn("VSTFPAYS", "VSTFPAYS", 0);

      apiGrid.InitColumnList();
    }

    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //  
    //  apiGrid.AddColumn "Num", "NOGNUM", 500
    //  apiGrid.AddColumn "§Date§", "DOGCRE", 900, "dd/mm/yy"
    //  apiGrid.AddColumn "§Auteur§", "VAUTEUR", 1300
    //  apiGrid.AddColumn "§Client§", "VCLINOM", 1300
    //  apiGrid.AddColumn "§ST Installation§", "VSTFNOM", 1500
    //  apiGrid.AddColumn "§Contact§", "VINTNOM", 1500
    //  apiGrid.AddColumn "§Mail§", "VINTMAIL", 1500
    //  apiGrid.AddColumn "§Date envoi§", "DOGENVOI", 1100
    //  apiGrid.AddColumn "§Action§", "VOGCORPS", 3000
    //  apiGrid.AddColumn "§Actif§", "COGACTIF", 580
    //  apiGrid.AddColumn "§Action§", "VOGCORPS", 0
    //  apiGrid.AddColumn "NACTNUM", "NACTNUM", 0
    //  apiGrid.AddColumn "NINTNUM", "NINTNUM", 0
    //  apiGrid.AddColumn "NCLINUM", "NCLINUM", 0
    //  apiGrid.AddColumn "NSTFNUM", "NSTFNUM", 0
    //  
    //  apiGrid.AddColumn "VSTFPAYS", "VSTFPAYS", 0
    //  
    //  apiGrid.Init adoRS
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      // écran de création de la demande
      new frmSaisieOG()
      {
        miNumOG = 0,
        mstrStatut = "C",
        miAction = iNumAct
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    //Private Sub cmdNouvelle_Click()
    //
    //  ' si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OG
    //'  If mstrStatut = "B" Then
    //'    MsgBox "§Vous ne pouvez créer un ordre d'intervention sous garantie que sur une action 'A planifier' ou 'Planifiée'§", vbOKOnly
    //'    Exit Sub
    //'  End If
    //    
    //  ' écran de création de la demande
    //  frmSaisieOG.miNumOG = 0
    //  frmSaisieOG.mstrStatut = "C"
    //  frmSaisieOG.miAction = p_iNumAct
    //  
    //  frmSaisieOG.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //  adoRS.Requery
    //  apiGrid.MajLabel
    //  'InitApigrid
    //  Screen.MousePointer = vbDefault
    //  
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      //passage des infos
      new frmSaisieOG()
      {
        miNumOG = (int)Utils.ZeroIfNull(currentRow["NOGNUM"]),
        miAction = (int)Utils.ZeroIfNull(currentRow["NACTNUM"]),
        miST = (int)Utils.ZeroIfNull(currentRow["NSTFNUM"]),
        mstrStatut = "M"
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    //Private Sub cmdModifier_Click()
    //    
    //  If adoRS.EOF Then Exit Sub
    //
    //  ' passage des infos
    //  frmSaisieOG.miNumOG = adoRS("NOGNUM")
    //  frmSaisieOG.miAction = adoRS("NACTNUM")
    //  frmSaisieOG.mstrStatut = "M"
    //
    //  frmSaisieOG.Show vbModal
    //        
    //  Screen.MousePointer = vbHourglass
    //  adoRS.Requery
    //  apiGrid.MajLabel
    //  'InitApigrid
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        // une copie originale
        string[,] TdbGlobal = { { "copie", "Original" } };
        string sModele = "TOG.rtf";

        new frmBrowser
        {
          msInfosMail = $"TINT|NINTNUM|{Utils.ZeroIfNull(currentRow["NINTNUM"])}",
          mstrType = $"OG{Utils.ZeroIfNull(currentRow["NOGNUM"])}"
        }.Preview_Print($"{MozartParams.CheminModeles}{Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", Utils.BlankIfNull(currentRow["NSTFNUM"]))}{sModele}",
                        $@"{Utils.ZeroIfNull(currentRow["NOGNUM"])}TOGOut.rtf",
                        TdbGlobal,
                        $"exec api_sp_impOG {Utils.ZeroIfNull(currentRow["NOGNUM"])}",
                        " (Visualisation OG)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub CmdVisu_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim sModele As String
    //
    //
    //On Error GoTo handler
    //    If adoRS.EOF Then Exit Sub
    //    
    //    ' une copie original
    //    TdbGlobal(0, 0) = "copie"
    //    TdbGlobal(0, 1) = "Original"
    //
    //    sModele = "TOG.rtf"
    //   
    //    frmBrowser.mstrType = "OG" & adoRS("NOGNUM")
    //   
    //    frmBrowser.InfosMail = "TINT|NINTNUM|" & adoRS("NINTNUM")
    //    frmBrowser.Preview_Print gstrCheminModeles & GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", adoRS("NSTFNUM")) & sModele, _
    //                             "\" & adoRS("NOGNUM") & "TOGOut.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impOG " & adoRS("NOGNUM"), _
    //                           " (Visualisation OG)", _
    //                           "PREVIEW"
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdImprimer_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        //suppression
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_archiverOrdreInterGaranti, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        ModuleData.CnxExecute($"update TOG set COGACTIF ='N' WHERE NOGNUM = {Utils.ZeroIfNull(currentRow["NOGNUM"])}");

        apiGrid.Requery(dt, MozartDatabase.cnxMozart);
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
    //  'suppression
    //  If adoRS.EOF Then Exit Sub
    //    
    //  If (MsgBox("§Voulez-vous vraiment archiver cet ordre d'intervention sous garantie ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes) Then
    //      cnx.Execute "update TOG set COGACTIF ='N' WHERE NOGNUM = " & adoRS("NOGNUM").value
    //  Else
    //    Exit Sub
    //  End If
    //  
    //  adoRS.Requery
    //  apiGrid.MajLabel
    //    
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub
    //

  }
}

