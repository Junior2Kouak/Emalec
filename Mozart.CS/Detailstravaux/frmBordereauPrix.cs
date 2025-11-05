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
  public partial class frmBordereauPrix : Form
  {
    public int Numclient;

    DataTable dt = new DataTable();
    //Public Numclient As Long
    //
    //Dim rsD As ADODB.Recordset

    public frmBordereauPrix() { InitializeComponent(); }

    private void frmBordereauPrix_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //  InitBoutons Me, frmMenu
    //
    //  InitialiserFeuille
    //   
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCre_Click(object sender, EventArgs e)
    {
      new frmBordereauFourniture()
      {
        Numclient = Numclient,
      }.ShowDialog();

      apiTGridHaut.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdCre_Click()
    //  frmBordereauFourniture.Numclient = Numclient
    //  frmBordereauFourniture.Show vbModal
    //  rsD.Requery
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridHaut.GetFocusedDataRow();
      if (row == null)
      {
        MessageBox.Show(Resources.msg_Impression_Impossible_Enregistrer_Bordereau);
        return;
      }

      string[,] TdbGlobal = { { "Copie", "ORIGINAL" } };

      new frmBrowser()
      {
        miPlanningAn = 0,
        mstrType = "BPU",
        msInfosMail = $"TCLI|NCLINUM|{Numclient}"
      }.Preview_Print($@"{MozartParams.CheminModeles}FR\TBordereauPrix.rtf",
                                                   @"TBordereauPrixOut.rtf",
                                                   TdbGlobal,
                                                   $"exec api_sp_ImpBordereauPrix {Numclient}",
                                                   " (Visualisation contract)",
                                                   "PREVIEW"); ;
    }
    //Private Sub cmdVisu_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //' UPGRADE_INFO (#0501): The 'adoSQLVisuCST' member isn't used anywhere in current application.
    //' Dim adoSQLVisuCST As New ADODB.Recordset
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String
    //
    //
    //  On Error Resume Next
    //  
    //  If rsD.RecordCount = 0 Then
    //    MsgBox "§Impression impossible, il faut enregistrer le bordereau.§", vbInformation
    //    Exit Sub
    //  End If
    //      
    //  
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //  
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.mstrType = "BPU"
    //  frmBrowser.InfosMail = "TCLI|NCLINUM|" & Numclient
    //  frmBrowser.Preview_Print gstrCheminModeles & "FR\TBordereauPrix.rtf", _
    //                                                                  "\TBordereauPrixOut.rtf", _
    //                                                                  TdbGlobal(), _
    //                                                                  "exec api_sp_ImpBordereauPrix " & Numclient, _
    //                                                                  " (Visualisation contract)", _
    //                                                                  "PREVIEW"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitialiserFeuille()
    {
      try
      {
        //recherche liste des prestations sur les devis clients de la DI
        apiTGridHaut.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeArticlesBordereau {Numclient}");
        apiTGridHaut.GridControl.DataSource = dt;

        InitgridHaut();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitialiserFeuille()
    //
    //On Error GoTo handler
    //  
    //  ' recherche liste des prestations sur les devis client de la DI
    //  Set rsD = New ADODB.Recordset
    //  rsD.Open "exec api_sp_ListeArticlesBordereau " & Numclient, cnx
    //  
    //  InitgridHaut
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " initialiserFeuille dans " & Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitgridHaut()
    {
      apiTGridHaut.AddColumn("NFOUNUM", "NFOUNUM", 0);
      apiTGridHaut.AddColumn("Fourniture", "VFOUMAT", 8000);
      apiTGridHaut.AddColumn("Prix", "NPUHTCLI", 1800, "0.00", 1);

      apiTGridHaut.InitColumnList();
    }
    //Private Sub InitgridHaut()
    //
    //    apiTGridHaut.AddColumn "NFOUNUM", "NFOUNUM", 0
    //    apiTGridHaut.AddColumn "Fourniture", "VFOUMAT", 8000
    //    apiTGridHaut.AddColumn "Prix", "NPUHTCLI", 1800, "0.00", 1
    //
    //    apiTGridHaut.Init rsD
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

  }
}

