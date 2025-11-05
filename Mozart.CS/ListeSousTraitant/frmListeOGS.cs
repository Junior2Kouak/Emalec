using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeOGS : Form
  {
    public frmListeOGS() { InitializeComponent(); }

    public bool mbFacture;
    public string mstrStatut;
    DataTable dt = new DataTable();

    private void frmListeOGS_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        String sql;
        if (mstrStatut == "A")
          sql = $"select * from api_v_ListeOGS where NACTNUM = {MozartParams.NumAction}";
        else //ouverture du recordset
          sql = $"select * from api_v_ListeOGS WHERE VSOCIETE = '{MozartParams.NomSociete}' ORDER BY NOGNUM desc";

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, sql);
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  
    //  If mstrStatut = "A" Then
    //    adoRS.Open "select * from api_v_ListeOGS where NACTNUM = " & glNumAction, cnx
    //  Else
    //    ' ouverture du recordset
    //    adoRS.Open "select * from api_v_ListeOGS WHERE VSOCIETE = '" & gstrNomSociete & "' ORDER BY NOGNUM desc", cnx
    //  End If
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //    
    //End Sub
    //
    /* Ok --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiGrid.AddColumn("Num", "NOGNUM", 500);
      apiGrid.AddColumn("Date", "DOGCREE", 900, "dd/MM/yy");
      apiGrid.AddColumn("Auteur", "VAUTEUR", 1300);
      apiGrid.AddColumn("Chaff", "VDINCHAFF", 1500);
      apiGrid.AddColumn("Client", "VCLINOM", 1300);
      apiGrid.AddColumn("STT", "VSTFNOM", 1500);
      apiGrid.AddColumn("Réalisation", "DOGDEX", 1100, "dd/MM/yy");
      apiGrid.AddColumn("Action", "VOGCORPS", 4500);
      apiGrid.AddColumn("Actif", "COGACTIF", 580);
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
    //  apiGrid.AddColumn "Date", "DOGCREE", 900, "dd/mm/yy"
    //  apiGrid.AddColumn "Auteur", "VAUTEUR", 1300
    //  apiGrid.AddColumn "Chaff", "VDINCHAFF", 1500
    //  apiGrid.AddColumn "Client", "VCLINOM", 1300
    //  apiGrid.AddColumn "STT", "VSTFNOM", 1500
    //  'apiGrid.AddColumn "Mail", "VINTMAIL", 1500
    //  apiGrid.AddColumn "Réalisation", "DOGDEX", 1100, "dd/mm/yy"
    //  apiGrid.AddColumn "Action", "VOGCORPS", 4500
    //  apiGrid.AddColumn "Actif", "COGACTIF", 580
    //  apiGrid.AddColumn "Action", "VOGCORPS", 0
    //  apiGrid.AddColumn "NACTNUM", "NACTNUM", 0
    //  apiGrid.AddColumn "NINTNUM", "NINTNUM", 0
    //  apiGrid.AddColumn "NCLINUM", "NCLINUM", 0
    //  apiGrid.AddColumn "NSTFNUM", "NSTFNUM", 0
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
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      //si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OG
      if (mbFacture)
      {
        MessageBox.Show("Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      //écran de création de la demande
      new frmSaisieOGS()
      {
        miNumOG = 0,
        mstrStatut = "C",
        miAction = MozartParams.NumAction,
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdNouvelle_Click()
    //         
    //  ' si la DI n'est pas planifiée ou à planifier on ne peut pas créer d'OG
    //  If bFacture Then
    //    MsgBox "Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'", vbOKOnly
    //    Exit Sub
    //  End If
    //    
    //  ' écran de création de la demande
    //  frmSaisieOGS.miNumOG = 0
    //  frmSaisieOGS.mstrStatut = "C"
    //  frmSaisieOGS.miAction = glNumAction
    //  
    //  frmSaisieOGS.Show vbModal
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
      DataRow currRow = apiGrid.GetFocusedDataRow();
      if (currRow == null) return;

      //passage des infos
      new frmSaisieOGS()
      {
        miNumOG = (int)currRow["NOGNUM"],
        miAction = (int)currRow["NACTNUM"],
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
    //  frmSaisieOGS.miNumOG = adoRS("NOGNUM")
    //  frmSaisieOGS.miAction = adoRS("NACTNUM")
    //  frmSaisieOGS.mstrStatut = "M"
    //  
    //  frmSaisieOGS.Show vbModal
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
      string[,] TdbGlobal = { { "", "" } };
      String sModele;
      try
      {
        DataRow currRow = apiGrid.GetFocusedDataRow();
        if (currRow == null) return;

        //une copie original
        TdbGlobal[0, 0] = "copie";
        TdbGlobal[0, 1] = "Original";

        sModele = "TOGS.rtf";
        new frmBrowser()
        {
          mstrType = $"OGS{currRow["NOGNUM"].ToString()}",
          msInfosMail = $"TINT|NINTNUM|{currRow["NINTNUM"].ToString()}",
        }.Preview_Print(MozartParams.CheminModeles + Utils.GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", currRow["NSTFNUM"].ToString()) + sModele,
                        currRow["NOGNUM"] + "TOGOut.rtf",
                        TdbGlobal,
                        "exec api_sp_impOGS " + currRow["NOGNUM"].ToString(),
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
    //    sModele = "TOGS.rtf"
    //    
    //    frmBrowser.mstrType = "OGS" & adoRS("NOGNUM")
    //    frmBrowser.InfosMail = "TINT|NINTNUM|" & adoRS("NINTNUM")
    //    frmBrowser.Preview_Print gstrCheminModeles & GetLanguePays("TSTF", "VLANGUEABR", "NSTFNUM", adoRS("NSTFNUM")) & sModele, _
    //                             "\" & adoRS("NOGNUM") & "TOGOut.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impOGS " & adoRS("NOGNUM"), _
    //                           " (Visualisation OG)", _
    //                           "PREVIEW"
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdImprimer_Click dans " & Me.Name
    //End Sub
    //
    /* Ok --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        //suppression
        DataRow currRow = apiGrid.GetFocusedDataRow();
        if (currRow == null) return;

        if (MessageBox.Show("Voulez-vous vraiment archiver cet ordre de garantie ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        ModuleData.ExecuteNonQuery($"update TOGS set COGACTIF='N' WHERE NOGNUM = {currRow["NOGNUM"]}");

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
    //  If (MsgBox("Voulez-vous vraiment archiver cet ordre de garantie ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes) Then
    //      cnx.Execute "update TOGS set COGACTIF='N' WHERE NOGNUM = " & adoRS("NOGNUM").value
    //  Else
    //    Exit Sub
    //  End If
    //  
    //  adoRS.Requery
    //  apiGrid.MajLabel
    //  'InitApigrid
    //    
    //Exit Sub
    //  
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
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

    private void apiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(sender, e);
    }
    //Private Sub apigrid_DblClick()
    //  Call cmdModifier_Click
    //End Sub
    //
    //
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  bFacture = False
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
  }
}

