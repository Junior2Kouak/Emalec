using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartControls
{
  public partial class frmGestionDroitMenuSensible : Form
  {

    DataTable dt = new DataTable();


    public frmGestionDroitMenuSensible()
    {
      InitializeComponent();
    }

    private void frmGestionMenuWeb_Load(object sender, System.EventArgs e)
    {
      try
      {

        //chargement des icones dans le listImages
        InitTreeView();

        FillTreeView();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

 
    private void InitTreeView()
    {
      // Configure le contrôle TreeView et ajoute le 1er noeud
      TreeNode newNode = new TreeNode() { Name = MozartParams.NomSociete, Text = MozartParams.NomSociete, ImageKey = "TOP", SelectedImageKey = "TOP" };
      tvwDB.Nodes.Add(newNode);
      tvwDB.SelectedNode = newNode;
    }

    private void FillTreeView()
    {
      try
      {
        //Vider le TreeView
        tvwDB.Nodes.Clear();
        InitTreeView();

        //chargement de la liste des menus principaux
        string sql = $"SELECT	NMENUNUM, VMENULIB, NMENUPARENT, CMENUSENSIBLE FROM TMENU ORDER BY NMENUPARENT, NMENUNUM";
        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sql))
        {
          //Ajoute un noeud au contrôle TreeView, et définit ses propriétés.
          while (dr.Read())
          {
            TreeNode[] nodes = tvwDB.Nodes.Find(dr["NMENUPARENT"].ToString(), true);

            int iIndex = dr["CMENUSENSIBLE"].ToString() == "O" ? 2 : 1;
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

 
    private void tvwDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Node.Name == MozartParams.NomSociete) return;

      var hitTest = tvwDB.HitTest(e.Location);
      if (hitTest.Location == TreeViewHitTestLocations.PlusMinus) return;

      string cDroit = e.Node.ImageKey == "O" ? "N" : "O";
      string cUpdate = cDroit == "O" ? "N" : "O";

      MozartDatabase.ExecuteNonQuery($"Update TMENU SET CMENUSENSIBLE = '{cUpdate}' Where NMENUNUM = {e.Node.Name}");
      e.Node.ImageKey = cDroit;
      e.Node.SelectedImageKey = cDroit;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}