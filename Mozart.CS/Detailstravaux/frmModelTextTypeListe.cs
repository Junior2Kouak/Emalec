using DevExpress.XtraEditors.Repository;
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
  public partial class frmModelTextTypeListe : Form
  {
    DataTable dt = new DataTable();
    public string sTexteTypeReturn;
    //Dim adoRS As ADODB.Recordset
    //Public sTexteTypeReturn As String

    public frmModelTextTypeListe() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmModelTextTypeListe_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        sTexteTypeReturn = "";

        //Ouverture du recordset
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ModeleTexteListe '{MozartParams.NomSociete}'");
        apiTGrid1.GridControl.DataSource = dt;

        InitApiTgrid();
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
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  sTexteTypeReturn = ""
    //
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_ModeleTexteListe '" & gstrNomSociete & "'", cnx
    //    
    //  InitApiTgrid
    //        
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub
    //
    /*  --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("NIDMODELTEXT", "NIDMODELTEXT", 0);
      apiTGrid1.AddColumn(Resources.col_Chapitre, "VCHAPITRE", 1300, "", 2);
      apiTGrid1.AddColumn(Resources.col_Sous_Chapitre, "VSSCHAPITRE", 1900, "", 2);
      apiTGrid1.AddColumn(Resources.col_Texte_Type, "VTEXTE", 9500, "", 0, false, false, false, true);
      apiTGrid1.AddColumn(Resources.col_Date_Mod, "DDATEMOD", 0, "dd/MM/yy");

      apiTGrid1.dgv.RowHeight = 4000 / 15;
      apiTGrid1.FilterBar = false;

      RepositoryItemMemoEdit edit = new RepositoryItemMemoEdit();
      apiTGrid1.GridControl.RepositoryItems.Add(edit);
      apiTGrid1.dgv.Columns["VTEXTE"].ColumnEdit = edit;
      apiTGrid1.dgv.Columns["VTEXTE"].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

      apiTGrid1.InitColumnList();
    }
    //Private Sub InitApiTgrid()
    //  
    //  apiTGrid1.RowTaille = 4000
    //  apiTGrid1.FilterBar = False
    //  apiTGrid1.sAfficheFilterBar = "N"
    //  
    //  apiTGrid1.AddColumn "NIDMODELTEXT", "NIDMODELTEXT", 0
    //  apiTGrid1.AddColumn "§Chapitre§", "VCHAPITRE", 1300, , 2
    //  apiTGrid1.AddColumn "§Sous-chapitre§", "VSSCHAPITRE", 2100, , 2
    //  apiTGrid1.AddColumn "§Texte type§", "VTEXTE", 9500, , , , , , True
    //  apiTGrid1.AddColumn "§Date mod§", "DDATEMOD", 0, "dd/mm/yy"
    //
    //  apiTGrid1.Init adoRS
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      sTexteTypeReturn = Utils.BlankIfNull(row["VTEXTE"]);
      cmdQuitter_Click(null, null);
    }
    //Private Sub cmdValider_Click()
    //    
    //    If adoRS.EOF Then Exit Sub
    //    sTexteTypeReturn = adoRS("VTEXTE")
    //    
    //    Unload Me
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //    If adoRS.state = adStateOpen Then adoRS.Close
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void txtFilter_Change(object sender, EventArgs e)
    {
      string sFilter = "";

      if (txtFilter0.Text != "")
        sFilter = $"VCHAPITRE LIKE '%{Strings.Replace(txtFilter0.Text, "'", "''")}%'";

      if (txtFilter1.Text != "")
      {
        if (sFilter == "")
          sFilter = $"VSSCHAPITRE LIKE '%{Strings.Replace(txtFilter1.Text, "'", "''")}%'";
        else
          sFilter += $" AND VSSCHAPITRE LIKE '%{Strings.Replace(txtFilter1.Text, "'", "''")}%'";
      }

      if (txtFilter2.Text != "")
      {
        if (sFilter == "")
          sFilter = $"VTEXTE LIKE '%{Strings.Replace(txtFilter2.Text, "'", "''")}%'";
        else
          sFilter += $" AND VTEXTE LIKE '%{Strings.Replace(txtFilter2.Text, "'", "''")}%'";
      }
      apiTGrid1.dgv.ActiveFilterString = sFilter;
    }
    //Private Sub txtFilter_Change(Index As Integer)
    //
    //    Dim sFilter As String
    //    
    //    sFilter = ""
    //
    //    If txtFilter(0).Text <> "" Then sFilter = "VCHAPITRE LIKE '%" & Replace(txtFilter(0).Text, "'", "''") & "%'"
    //    
    //    If txtFilter(1).Text <> "" Then
    //        If sFilter = "" Then
    //            sFilter = "VSSCHAPITRE LIKE '%" & Replace(txtFilter(1).Text, "'", "''") & "%'"
    //        Else
    //            sFilter = sFilter & " AND VSSCHAPITRE LIKE '%" & Replace(txtFilter(1).Text, "'", "''") & "%'"
    //        End If
    //    End If
    //            
    //    If txtFilter(2).Text <> "" Then
    //        If sFilter = "" Then
    //            sFilter = "VTEXTE LIKE '%" & Replace(txtFilter(2).Text, "'", "''") & "%'"
    //        Else
    //            sFilter = sFilter & " AND VTEXTE LIKE '%" & Replace(txtFilter(2).Text, "'", "''") & "%'"
    //        End If
    //    End If
    //    
    //    adoRS.Filter = sFilter
    //    adoRS.Requery
    //    
    //End Sub

  }
}

