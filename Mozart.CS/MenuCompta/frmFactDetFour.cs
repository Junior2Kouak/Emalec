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
  public partial class frmFactDetFour : Form
  {
    public int miNumElemFact;
    //Public miNumElemFact As Long

    DataTable dt = new DataTable();
    //Dim rs As ADODB.Recordset

    public frmFactDetFour() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmFactDetFour_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //recherche des détails fournitures
        grdDataGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_RetourArticlesElemFact {miNumElemFact}");
        grdDataGrid.GridControl.DataSource = dt;

        //formatage de l'affichage du grid
        InitGrid();

        //remplir les montants totaux
        RemplirTxtTotaux();
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
    //    InitBoutons Me, frmMenu
    //    
    //    ' recherche des détails fournitures
    //    Set rs = New ADODB.Recordset
    //    rs.Open "api_sp_RetourArticlesElemFact " & miNumElemFact, cnx, adOpenStatic, adLockOptimistic
    //
    //    ' affectation du recordset au datagrid
    //    Set grdDataGrid.DataSource = rs
    //    
    //    ' formatage de l'affichage du grid
    //    FormatGrid
    //    
    //    ' remplir les montants totaux
    //    Call RemplirTxtTotaux(rs)
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
    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub cmdImprimer_Click()
    //
    //Dim Ret%
    //  
    //  On Error Resume Next
    //  If rs.EOF Then Exit Sub
    //  
    //  ' affichage curseur
    //  Me.MousePointer = vbHourglass
    //  
    //  'if Preview
    //  Ret% = PrintRS(Me, rs, grdDataGrid)
    //  
    //  
    //  If Ret% Then MsgBox Err.Description & " cmdImprimer dans " & Me.Name
    //  Me.MousePointer = vbDefault
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitGrid()
    {
      grdDataGrid.AddColumn(Resources.col_Serie, "Serie", 1500);
      grdDataGrid.AddColumn(Resources.col_materiel, "Article", 3600);
      grdDataGrid.AddColumn(Resources.col_marque, "Marque", 1500);
      grdDataGrid.AddColumn("Recycle/U", "Recyclage", 1150, "Currency");
      grdDataGrid.AddColumn("Prix client/U", "Prix", 1000, "Currency");
      grdDataGrid.AddColumn(Resources.col_Fournisseur, "Fournisseurs", 0);
      grdDataGrid.AddColumn("Qté", "Quantite", 900);
      grdDataGrid.AddColumn(Resources.col_num_four, "NumFour", 0);
      grdDataGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
      grdDataGrid.AddColumn("Num", "CoefClient", 0);
      grdDataGrid.AddColumn("Num", "NSTOCKNUM", 0);

      grdDataGrid.DelockColumn("Quantite");

      grdDataGrid.InitColumnList();
    }
    //Public Sub FormatGrid()
    //  
    //On Error GoTo handler
    //
    //  grdDataGrid.Columns(0).Caption = "§Série§"
    //  grdDataGrid.Columns(1).Caption = "§Matériel§"
    //  grdDataGrid.Columns(2).Caption = "§Marque§"
    //  grdDataGrid.Columns(3).Caption = "Recycle/U"
    //  grdDataGrid.Columns(4).Caption = "Prix client/U"
    //  grdDataGrid.Columns(5).Caption = "§Fournisseur§"
    //  grdDataGrid.Columns(6).Caption = "Qté"
    //  grdDataGrid.Columns(7).Caption = "§NumFour§"
    //  grdDataGrid.Columns(8).Caption = "§NumArticle§"
    //  grdDataGrid.Columns(9).Caption = "Num"
    //  grdDataGrid.Columns(10).Caption = "Num"
    //      
    //  
    //  grdDataGrid.Columns(0).Width = 1500
    //  grdDataGrid.Columns(1).Width = 3600
    //  grdDataGrid.Columns(2).Width = 1500
    //  grdDataGrid.Columns(3).Width = 1150
    //  grdDataGrid.Columns(4).Width = 1000
    //  grdDataGrid.Columns(5).Width = 0
    //  grdDataGrid.Columns(6).Width = 900
    //  grdDataGrid.Columns(7).Width = 0
    //  grdDataGrid.Columns(8).Width = 0
    //  grdDataGrid.Columns(9).Width = 0
    //  grdDataGrid.Columns(10).Width = 0
    //  
    //    'locked des cellules sauf la quantité
    //  grdDataGrid.Columns(0).Locked = True
    //  grdDataGrid.Columns(1).Locked = True
    //  grdDataGrid.Columns(2).Locked = True
    //  grdDataGrid.Columns(3).Locked = True
    //  grdDataGrid.Columns(4).Locked = True
    //  grdDataGrid.Columns(5).Locked = True
    //
    //  grdDataGrid.Columns(3).NumberFormat = "Currency"
    //  grdDataGrid.Columns(3).Alignment = dbgRight
    //  grdDataGrid.Columns(4).NumberFormat = "Currency"
    //  grdDataGrid.Columns(4).Alignment = dbgRight
    //  grdDataGrid.Columns(6).Alignment = dbgCenter
    //  
    //  Exit Sub
    //  
    //handler:
    //  ShowError "FormatGrid dans " & Me.Name
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void RemplirTxtTotaux()
    {
      txtHT.Text = Strings.Format(CalculerMontantHT(dt), "currency");
      txtTVA.Text = Strings.Format(double.Parse(txtHT.Text, System.Globalization.NumberStyles.Currency) * MozartParams.TVA1 / 100, "currency");
      txtTTC.Text = Strings.Format(double.Parse(txtHT.Text, System.Globalization.NumberStyles.Currency) + double.Parse(txtHT.Text, System.Globalization.NumberStyles.Currency) * MozartParams.TVA1 / 100, "currency");
    }
    //Private Sub RemplirTxtTotaux(rsarticle As ADODB.Recordset)
    //    
    // On Error GoTo handler
    //  
    //  txtHT = Format(CalculerMontantHT(rsarticle), "currency")
    // 
    //  txtTVA = Format(txtHT * gdblTVA1 / 100, "currency")
    //  txtTTC = Format((txtHT + (txtHT * (gdblTVA1 / 100))), "currency")
    //
    //Exit Sub
    //handler:
    //  ShowError "RemplirTotaux dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private double CalculerMontantHT(DataTable dt)
    {
      try
      {
        if (dt == null) return 0;

        //initialisation
        double res = 0;

        foreach (DataRow row in dt.Rows)
        {
          res += ((double)Utils.ZeroIfNull(row["Prix"]) * (double)Utils.ZeroIfNull(row["Quantite"])) + ((double)Utils.ZeroIfNull(row["Recyclage"]) * (double)Utils.ZeroIfNull(row["Quantite"]));
        }
        return res;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);

        return 0;
      }

    }
    //Private Function CalculerMontantHT(ByVal rs As ADODB.Recordset) As Double
    //
    //On Error GoTo handler
    //
    //  ' on se replace au début du recordset
    //  If rs.EOF Or rs.BOF Then
    //    ' rien
    //    Exit Function
    //  Else
    //    rs.MoveFirst
    //  End If
    //  
    //  ' initialisation
    //  CalculerMontantHT = 0
    //  
    //  While Not rs.EOF
    //    CalculerMontantHT = CalculerMontantHT + (rs("Prix") * rs("Quantite")) + (ZeroIfNull(rs("Recyclage")) * rs("Quantite"))
    //    rs.MoveNext
    //  Wend
    //
    //  
    //  rs.MoveFirst
    //  
    //  Exit Function
    //  
    //handler:
    //  ShowError "CalculerMontantHT dans " & Me.Name
    //
    //End Function

  }
}

