using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeFournituresExists : Form
  {
    public string msRefSearch = "";
    public string msRefCliSearch = "";
    public int miNFOUNUM;
    public string mstrStatut = "";

    public frmListeFournituresExists()
    {
      InitializeComponent();
    }

    private void frmListeFournituresExists_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        //    'init message
        MessageBox.Show($"Alerte référence identique à une référence déjà existante dans MOZART :\r\n" +
                        $"Vous allez créer une nouvelle fourniture. Les fournitures ci-dessous, déjà existantes dans MOZART ont la même référence.\r\n" +
                        $"Vérifier qu'il ne s'agit pas de la même fourniture. Dans ce cas, ne pas la recréer !s", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    ' NL le 03/10/2016, on distingue la copie de la modification
        string sql;
        if (mstrStatut == "COPIE")
          sql = $"exec [api_sp_ListeFournituresExistsByRef_SansNFOUNUM] '{msRefSearch.Replace("'", "''")}'";
        else
          sql = $"exec [api_sp_ListeFournituresExistsByRef] '{msRefSearch.Replace("'", "''")}', '{msRefCliSearch.Replace("'", "''")}', {miNFOUNUM}";

        apiTGrid1.AddColumn("ID", "NFOUNUM", 600);
        apiTGrid1.AddColumn("Réf.", "VFOUREF", 1200);
        apiTGrid1.AddColumn("Réf. Fou", "VSTFFOUREFCLI", 1200);
        apiTGrid1.AddColumn("Série", "CCFOCOD", 1800);
        apiTGrid1.AddColumn("Désignation", "VFOUMAT", 3500);
        apiTGrid1.AddColumn("Marque", "VFOUMAR", 2000);
        apiTGrid1.AddColumn("Type", "VFOUTYP", 2200);

        DataTable dt = new DataTable();
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sql);
        apiTGrid1.GridControl.DataSource = dt;
        apiTGrid1.InitColumnList();
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    //  Option Explicit
    //
    //Public sRefSearch As String
    //Public sRefCliSearch As String
    //Public NFOUNUM As Long
    //Public mstrStatut As String
    //
    //Dim adoRsFouRef As New ADODB.Recordset
    //
    //Private Sub Form_Load()
    //
    //    'init message
    //    MsgBox "Alerte référence identique à une référence déjà existante dans MOZART :" & vbCrLf _
    //                & "Vous allez créer une nouvelle fourniture. Les fournitures ci-dessous, déjà existantes dans MOZART ont la même référence." & vbCrLf _
    //                & "Vérifier qu'il ne s'agit pas de la même fourniture. Dans ce cas, ne pas la recréer !"
    //    
    //    ' NL le 03/10/2016, on distingue la copie de la modification
    //    If mstrStatut = "COPIE" Then
    //      adoRsFouRef.Open "exec [api_sp_ListeFournituresExistsByRef_SansNFOUNUM] '" & Replace(sRefSearch, "'", "''") & "'", cnx
    //    Else
    //      adoRsFouRef.Open "exec [api_sp_ListeFournituresExistsByRef] '" & Replace(sRefSearch, "'", "''") & "', '" & Replace(sRefCliSearch, "'", "''") & "', " & NFOUNUM, cnx
    //    End If
    //    
    //    InitApigrid
    //
    //End Sub
    //
    //Private Sub InitApigrid()
    //  
    //    On Error GoTo handler
    //    
    //      apiTGrid1.AddColumn "ID", "NFOUNUM", 600
    //      apiTGrid1.AddColumn "Réf.", "VFOUREF", 1200
    //      apiTGrid1.AddColumn "Réf. Fou", "VSTFFOUREFCLI", 1200
    //      apiTGrid1.AddColumn "Série", "CCFOCOD", 1800
    //      apiTGrid1.AddColumn "Désignation", "VFOUMAT", 3500
    //      apiTGrid1.AddColumn "Marque", "VFOUMAR", 2000
    //      apiTGrid1.AddColumn "Type", "VFOUTYP", 2200
    //    
    //    
    //      
    //      apiTGrid1.Init adoRsFouRef
    //      Exit Sub
    //      
    //handler:
    //      ShowError "InitApiTgrid dans " & Me.Name
    //End Sub
    //
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //
    //Private Sub Form_Unload(Cancel As Integer)
    //    
    //    If adoRsFouRef.state = adStateOpen Then adoRsFouRef.Close
    //    
    //End Sub
  }
}

