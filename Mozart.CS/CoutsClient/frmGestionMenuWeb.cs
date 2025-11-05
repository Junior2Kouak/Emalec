using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestionMenuWeb : Form
  {
    public string mstrType;
    public int miNumClient;
    public string mstrNumPer = "";
    DataTable dt = new DataTable();
    //Private madoRS_lvwDB As ADODB.Recordset
    //Private strNumPer As String         'id du login
    //Public strType As String         ' client ou technicien
    //Public miNumClient As Integer

    public frmGestionMenuWeb()
    {
      InitializeComponent();
    }

    private void frmGestionMenuWeb_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //gestion du listview
        AfficheLVW();

        //chargement des icones dans le listImages
        InitTreeView();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdPetP_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmCopyProfil
      {
        msType = mstrType,
        miNumClient = miNumClient
      }.ShowDialog();

      FillTreeView();
      Cursor.Current = Cursors.Default;
    }

    private void InitTreeView()
    {
      // Configure le contrôle TreeView et ajoute le 1er noeud
      TreeNode newNode = new TreeNode() { Name = MozartParams.NomSociete, Text = MozartParams.NomSociete, ImageKey = "TOP", SelectedImageKey = "TOP" };
      tvwDB.Nodes.Add(newNode);
      tvwDB.SelectedNode = newNode;
    }
    //Private Sub InitTreeView()
    //
    //Dim nNode As Node
    //
    //  ' Configure le contrôle TreeView et ajoute le 1er noeud
    //  With tvwDB
    //    .Sorted = False
    //    .LabelEdit = tvwManual
    //    .LineStyle = tvwRootLines
    //    Set nNode = .Nodes.Add()
    //    .Nodes(1).Text = gstrNomSociete
    //    .Nodes(1).Key = "0 K"
    //    .Nodes(1).Image = "HTP"
    //    .Nodes(1).Expanded = True
    //    .SelectedItem = tvwDB.Nodes(1)
    //  End With
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void FillTreeView()
    {
      try
      {
        //Vider le TreeView
        tvwDB.Nodes.Clear();
        InitTreeView();

        //chargement de la liste des menus dans le TreeView
        using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC [api_sp_LoadMenuWeb] {miNumClient}, '{mstrType}', '{mstrNumPer}'"))
        {
          //Ajoute un noeud au contrôle TreeView, et définit ses propriétés.
          while (dr.Read())
          {
            TreeNode[] nodes = tvwDB.Nodes.Find(dr["NMENUPARENT"].ToString(), true);

            int iIndex = dr["CDROITVAL"].ToString() == "O" ? 1 : 2;
            TreeNode newNode = new TreeNode(dr["VMENULIB"].ToString(), iIndex, iIndex);
            newNode.Name = dr["NMENUNUM"].ToString();

            if (nodes.Length == 0)
              tvwDB.Nodes[0].Nodes.Add(newNode);
            else
              nodes[0].Nodes.Add(newNode);
          }
        }
        tvwDB.Nodes[0].Expand();
      }
      catch (Exception ex)
      {
        foreach (var item in dt.GetErrors())
          Console.WriteLine(item.RowError);

        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub FillTreeView()
    //
    //Dim sSql As String
    //Dim adoRS_Cli As ADODB.Recordset
    //
    //On Error GoTo handler
    //  
    //  ' Vider le TreeView
    //  tvwDB.Nodes.Clear
    //  InitTreeView
    //  
    //  ' chargement de la liste des menus dans le TreeView
    //  Set adoRS_Cli = New ADODB.Recordset
    //  
    //  sSql = "EXEC [api_sp_LoadMenuWeb] " & miNumClient & ", '" & strType & "', '" & strNumPer & "'"
    //
    //  adoRS_Cli.Open sSql, cnx, adOpenStatic, adLockOptimistic
    //
    //  ' Ajoute un noeud au contrôle TreeView, et définit ses propriétés.
    //  Do While Not adoRS_Cli.EOF
    //    tvwDB.Nodes.Add adoRS_Cli!NMENUPARENT & " K", tvwChild, adoRS_Cli!NMENUNUM & " K", CStr(adoRS_Cli!VMENULIB), CStr(adoRS_Cli!CDROITVAL)
    //    adoRS_Cli.MoveNext
    //  Loop
    //           
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitTreeView dans " & Me.Name
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void lvwDB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lvwDB.SelectedItems.Count == 0) return;
      ListViewItem item = lvwDB.SelectedItems[0];
      mstrNumPer = item.Text;
      FillTreeView();
    }
    //Private Sub lvwDB_ItemClick(ByVal Item As MSComctlLib.ListItem)
    //  strNumPer = Right(Item.Key, Len(Item.Key) - 1)
    //  FillTreeView
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void AfficheLVW()
    {
      try
      {
        string sSQL = $"SELECT distinct VUTILOG From TUTI WHERE CUTICAT = '{mstrType}' AND NUTINUM = {miNumClient} ORDER BY VUTILOG";
        dt.Load(ModuleData.ExecuteReader(sSQL));

        foreach (DataRow row in dt.Rows)
          lvwDB.Items.Add(row[0].ToString());
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub AfficheLVW()
    //
    //Dim strQ As String
    //On Error GoTo handler
    //
    //  Set madoRS_lvwDB = New ADODB.Recordset
    //  
    //  ' init LVW
    //  lvwDB.ListItems.Clear
    //  lvwDB.ColumnHeaders.Clear
    //  
    //  lvwDB.ColumnHeaders.Add , , "Login", 4000
    //  ' ouverture du recordset des personnes
    //  strQ = "SELECT  distinct VUTILOG From TUTI WHERE  "
    //  strQ = strQ + " CUTICAT = '" + strType + "'"
    //  strQ = strQ + " AND NUTINUM = " & miNumClient & " ORDER BY VUTILOG"
    //          
    //  madoRS_lvwDB.Open strQ, cnx, adOpenStatic, adLockOptimistic
    //     
    //  If madoRS_lvwDB.EOF Then Exit Sub
    //  Do Until madoRS_lvwDB.EOF
    //    AddListItem madoRS_lvwDB, 0
    //    madoRS_lvwDB.MoveNext
    //  Loop
    //      
    //Exit Sub
    //handler:
    //  ShowError "AfficheLVW dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void tvwDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Node.Name == MozartParams.NomSociete) return;

      var hitTest = tvwDB.HitTest(e.Location);
      if (hitTest.Location == TreeViewHitTestLocations.PlusMinus) return;

      string cDroit = e.Node.ImageKey == "O" ? "N" : "O";
      ModuleData.ExecuteNonQuery($"Update TDROITWEB SET CDROITVAL = '{cDroit}' Where CUTICAT = '{mstrType}' and NCLINUM = {miNumClient} AND VUTILOG = '{mstrNumPer}' And NMENUNUM = {e.Node.Name}");
      e.Node.ImageKey = cDroit;
      e.Node.SelectedImageKey = cDroit;
    }
    //Public Sub tvwDB_NodeClick(ByVal Node As Node)
    //Dim cDroit As String

    //  If Node = gstrNomSociete Then Exit Sub

    //'  ' Basculer le droit pour ce menu
    //  cDroit = IIf(Node.Image = "O", "N", "O")
    //  cnx.Execute "Update TDROITWEB SET CDROITVAL = '" & cDroit & "' Where CUTICAT = '" & strType & "' and NCLINUM = " & miNumClient & " AND VUTILOG = '" & strNumPer & "' And NMENUNUM = " & val(Node.Key)

    //  Node.Image = cDroit

    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub tvwDB_BeforeLabelEdit(Cancel As Integer)
    //  Cancel = True
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub AddListItem(ByRef xRec As ADODB.Recordset, ByVal strTypeNoeud As String)
    //Dim xItem As ListItem
    //
    //On Error GoTo handler
    //  
    //  ' Ajoute un nouveau ListItem et défini ses texte, icône et petite icône.
    //  Select Case strTypeNoeud
    //  Case ""
    //    'rien
    //  Case Else
    //    Set xItem = lvwDB.ListItems.Add(Key:="K" & xRec(0), Text:=xRec(0))
    //  End Select
    //
    //Exit Sub
    //handler:
    //  ShowError "AddlistItem dans " & Me.Name
    //End Sub
  }
}