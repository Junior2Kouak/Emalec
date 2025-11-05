using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestionMenus2 : Form
  {
    public frmGestionMenus2() { InitializeComponent(); }

    
    private int miNumPer = 0;
    private DataTable dtPersonnes = new DataTable();
    DataTable dtSocietes = new DataTable();

    TreeNode mnCurNode; //Noeud courant
    bool bStart = true;

    List<string> ListeUtilisateur = new List<string>() { "GALOTTI", "CAVALLARO", "CHEVALIER", "HER", "LAZZAROTTO", "DALMET", "RAGARU" };
    bool bSuperUtilisateur = false;

    
    private void frmGestionMenus2_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // définition des SuperUtilisateurs
        if (ListeUtilisateur.Contains(MozartParams.strUID)) bSuperUtilisateur = true;

        // affichage des boutons que pour la direction (SuperUtilisateurs)
        cmdPetP.Visible = (bSuperUtilisateur);

        //  gestion du listview
        AfficheLVW();
        AfficheLVWSociete();
        InitTreeView();

        bStart = false;
        Cursor.Current = Cursors.Default;
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
    
    private void cmdPetP_Click(object sender, EventArgs e)
    {
      new frmCopyProfil { msType = "M", miNumClient = 0 }.ShowDialog();
    }

    private void InitTreeView()
    {
      //  Configure le contrôle TreeView et ajoute le 1er noeud
      TreeNode newNode = new TreeNode()
      {
        Text = MozartParams.NomSociete,
        Tag = "0",
        SelectedImageIndex = 0
      };
      newNode.Expand();
      tvwDB.Nodes.Add(newNode);
      tvwDB.SelectedNode = newNode;
    }

    private void FillTreeView()
    {
      try
      {
        tvwDB.Nodes.Clear();
        InitTreeView();

        // chargement de la liste des menus dans le treeview
        // affichage ou pas des menus sensibles selon les droits
        string sSQL = "";
        if (bSuperUtilisateur)
          sSQL = $"SELECT TDROIT.NMENUNUM, TMENU.VMENULIB, TDROIT.CDROITVAL, TMENU.NMENUPARENT FROM TDROIT " +
                 $"INNER JOIN TPER ON TDROIT.NPERNUM = TPER.NPERNUM INNER JOIN TMENU ON TDROIT.NMENUNUM = TMENU.NMENUNUM " +
                 $"WHERE TPER.NPERNUM = {miNumPer} AND TDROIT.VSOCIETE = APP_NAME() ORDER BY TMENU.NMENUPARENT, TDROIT.NMENUNUM ";

        else
          sSQL = $"SELECT TDROIT.NMENUNUM, TMENU.VMENULIB, TDROIT.CDROITVAL, TMENU.NMENUPARENT FROM TDROIT " +
                 $"INNER JOIN TPER ON TDROIT.NPERNUM = TPER.NPERNUM INNER JOIN TMENU ON TDROIT.NMENUNUM = TMENU.NMENUNUM " +
                 $"WHERE TPER.NPERNUM = {miNumPer} AND CMENUSENSIBLE='N' AND TDROIT.VSOCIETE = APP_NAME() ORDER BY TMENU.NMENUPARENT, TDROIT.NMENUNUM ";

        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSQL))
        {
          //Ajoute un noeud au contrôle TreeView, et définit ses propriétés.
          while (dr.Read())
          {
            TreeNode itemNode = FromTag(dr["NMENUPARENT"].ToString(), tvwDB.Nodes[0]);
            TreeNode newNode = new TreeNode(dr["VMENULIB"].ToString());
            newNode.Tag = dr["NMENUNUM"].ToString(); // + " K";
            newNode.ImageIndex = dr["CDROITVAL"].ToString() == "O" ? 1 : 2;
            if (itemNode == null)
              tvwDB.Nodes[0].Nodes.Add(newNode);
            else
              itemNode.Nodes.Add(newNode);
          }
        }
        lblPath.Text = tvwDB.SelectedNode.FullPath;
        tvwDB.Nodes[0].Expand();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public TreeNode FromTag(string itemId, TreeNode rootNode)
    {
      foreach (TreeNode node in rootNode.Nodes)
      {
        if (node.Tag.Equals(itemId)) return node;
        TreeNode next = FromTag(itemId, node);
        if (next != null) return next;
      }
      return null;
    }

    private void lvwSociete_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      if (bStart)
        return;

      //init
      string cTypeForProc;
      string cDroit;
      bool bCheckSoc = false;
      ListViewItem Item = e.Item;

      //  Basculer le droit pour ce menu
      if (Item.Checked == true)
      {
        cDroit = "O";
        cTypeForProc = "I";
      }
      else
      {
        cDroit = "N";
        cTypeForProc = "D";

        //  test si ok pour suppression droit société
        if (Item.Text == MozartParams.NomSociete && TestIfSocieteCheck())
        {
          MozartDatabase.ExecuteNonQuery($"EXEC api_sp_SuppDroitSociete {Convert.ToInt32(mnCurNode.ImageIndex)}, {Convert.ToInt32(Item.ImageIndex)}, '{Item.Text}'");
          //TODO SelectedItems.Key
          //MessageBox.Show(lvwDB.SelectedItems.Key);
          mnCurNode.ImageIndex = Item.Checked == true ? 1 : 2;
          return;
        }
        else
        {
          if (Item.Text == MozartParams.NomSociete)
            mnCurNode.ImageIndex = Item.Checked == true ? 1 : 2;
        }
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_GestionDroitSociete", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@cType"].Value = cTypeForProc;
        cmd.Parameters["@nIdMenu"].Value = Convert.ToInt32(mnCurNode.Tag);
        cmd.Parameters["@nIdPer"].Value = miNumPer;
        cmd.Parameters["@cDroit"].Value = cDroit;
        cmd.Parameters["@vSociete"].Value = Item.Text;
        cmd.Parameters["@vSocieteSrc"].Value = MozartParams.NomSociete;

        cmd.ExecuteNonQuery();
      }

      //  'test si au moins une societe est cochée
      bCheckSoc = lvwSociete.CheckedItems.Count > 0;

      mnCurNode.ImageIndex = bCheckSoc == true ? 1 : 2;

    }

    private void lvwDB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lvwDB.SelectedItems.Count == 0) return;

      miNumPer = lvwDB.SelectedItems[0].ImageIndex;
      FillTreeView();
      lvwSociete.Visible = false;
    }

    private void tvwDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      //Si on clique on veut réduire ou étendre le node on ne change pas les droits
      TreeViewHitTestInfo hit = tvwDB.HitTest(e.Location);
      if (hit.Location == TreeViewHitTestLocations.PlusMinus)
        return;

      //  'si selection racine
      if (e.Node == tvwDB.Nodes[0])
      {
        lvwSociete.Visible = false;
        return;
      }
      //bStart = true;
      // Police normale sur l'ancien node
      if (mnCurNode != null && mnCurNode.NodeFont != null)
      {
        mnCurNode.NodeFont = new Font(mnCurNode.NodeFont, FontStyle.Regular);
        mnCurNode.BackColor = Color.White;
      }

      mnCurNode = e.Node;

      mnCurNode.NodeFont = new Font(tvwDB.Font, FontStyle.Bold);
      //TODO Add ColorHFF8080 
      mnCurNode.BackColor = Color.FromArgb(224, 224, 224);
      mnCurNode.Text = mnCurNode.Text;

      //  insertion automatique sur la societe source
      InsertionAutoSocSrc(mnCurNode, miNumPer);

      //  init de listviewsociete
      lvwSociete.ItemChecked -= new ItemCheckedEventHandler(this.lvwSociete_ItemChecked);
      InitListSociete();

      //  Récupere le nom de ou des societe ou la personne possèdant des droits sur un bouton
      string sSQL = $"SELECT DISTINCT VSOCIETE,CDROITVAL FROM TDROIT WHERE NMENUNUM={Convert.ToInt32(mnCurNode.Tag)} AND NPERNUM={miNumPer}";

      using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSQL))
      {
        //Ici on coche les checkbox des sociétés ou la personne à des droits sur un bouton
        while (dr.Read())
          RechercheDroitSociete(dr["VSOCIETE"].ToString(), dr["CDROITVAL"].ToString(), lvwSociete);
      }

      lvwSociete.ItemChecked += new ItemCheckedEventHandler(this.lvwSociete_ItemChecked);
      if (bSuperUtilisateur) lvwSociete.Visible = true;
      //bStart = false;
    }

    private void AfficheLVW()
    {
      try
      {
        lvwDB.Items.Clear();
        lvwDB.Columns.Clear();

        lvwDB.Columns.Add("Personnes", 270);

        dtPersonnes.Load(MozartDatabase.ExecuteReader("SELECT NPERNUM, NOM from api_v_Msg_Destinataires ORDER BY NOM"));

        foreach (DataRow row in dtPersonnes.Rows)
          //AddListItem(row, "0");
          lvwDB.Items.Add(row["NOM"].ToString(), Convert.ToInt32(row["NPERNUM"]));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AfficheLVWSociete()
    {
      try
      {
        // init lvwSociete
        lvwSociete.Items.Clear();
        lvwSociete.Columns.Clear();
        lvwSociete.Columns.Add(Resources.col_Societe, 250);

        dtSocietes.Load(MozartDatabase.ExecuteReader("SELECT * FROM TSOCIETE WHERE VSOCIETEACTIF = 'O' ORDER BY NSOCIETENODE"));

        foreach (DataRow row in dtSocietes.Rows)
          lvwSociete.Items.Add(row["VSOCIETENOM"].ToString(), row["NSOCIETENODE"].ToString()); // + " K");

        //lvwSociete.ItemChecked += new ItemCheckedEventHandler(this.lvwSociete_ItemChecked);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitListSociete()
    {
      try
      {
        foreach (ListViewItem item in lvwSociete.Items)
          item.Checked = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }



    //'**************************************************************************************************************************
    //'Cette fonction permet de rechercher les sociétés sur lesquelles la personne a des droits
    //'**************************************************************************************************************************

    /* --------------------------------------------------------------------------------------- */
    private void RechercheDroitSociete(string sNomSociete, string sDroitSociete, ListView lstItemNom)
    {
      try
      {
        if (dtSocietes.Rows.Count > 0)
        {
          foreach (DataRow row in dtSocietes.Rows)
            lstItemNom.Items[lstItemNom.FindItemWithText(sNomSociete).Index].Checked = (sDroitSociete == "O");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //'*************************************************************************************************************
    //'Cette fonction permet de rajouter les droits en auto sur la société source
    //'*************************************************************************************************************

    private void InsertionAutoSocSrc(TreeNode node, int iNperNumAuto)
    {
      string cTypeForProc;
      string cDroit;
      //  Basculer le droit pour ce menu
      if (node.ImageIndex == 2)
      {
        cDroit = "O";
        cTypeForProc = "I";
        //TODO Node.Image
        mnCurNode.SelectedImageIndex = 1;
        mnCurNode.ImageIndex = 1;
      }
      else
      {
        cDroit = "N";
        cTypeForProc = "D";
        //TODO Node.Image
        mnCurNode.SelectedImageIndex = 2;
        mnCurNode.ImageIndex = 2;
      }

      //  ' création d'une commande
      using (SqlCommand cmd = new SqlCommand("api_sp_GestionDroitSociete", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@cType"].Value = cTypeForProc;
        cmd.Parameters["@nIdMenu"].Value = Convert.ToInt32(mnCurNode.Tag);
        cmd.Parameters["@nIdPer"].Value = miNumPer;
        cmd.Parameters["@cDroit"].Value = cDroit;
        cmd.Parameters["@vSociete"].Value = MozartParams.NomSociete;
        cmd.Parameters["@vSocieteSrc"].Value = MozartParams.NomSociete;

        cmd.ExecuteNonQuery();
      }
    }

    //'**************************************************************************************
    //'Cette fonction permet de tester si des sociétés sont encores cocher si on supprime les droit sur le MOZART SOURCE
    //'**************************************************************************************
    private bool TestIfSocieteCheck()
    {
      return lvwSociete.CheckedItems.Count > 0;
    }
  }
}