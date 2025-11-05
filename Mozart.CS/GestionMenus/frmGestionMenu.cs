using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestionMenus : Form
  {
    public frmGestionMenus() { InitializeComponent(); }

    private TreeNode mnCurNode;
    private DataTable madoRS_lvwDB = new DataTable();

    DataTable dtSoc = new DataTable();

    int iLastPer;
    int minPerNum;

    List<string> ListeUtilisateur = new List<string>() { "GALOTTI", "CAVALLARO", "CHEVALIER", "HER", "LAZZAROTTO", "DALMET", "RAGARU", "GIRAUD-BY" };
    bool bSuperUtilisateur=false;

    private void frmGestionMenus_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // définition des SuperUtilisateurs
        if (ListeUtilisateur.Contains(MozartParams.strUID)) bSuperUtilisateur = true;

        // affichage des boutons que pour la direction (SuperUtilisateurs)
        CmdAccesGrp.Visible = cmdPetP.Visible = (bSuperUtilisateur);


        //  chargement des icones dans le listImages  
        InitTreeView();
        InitListView();

        //  affiche la liste des societes
        AfficheLVWSociete();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdPetP_Click(object sender, EventArgs e)
    {
      new frmCopyProfil
      {
        msType = "M",
        miNumClient = 0
      }.ShowDialog();
    }

    private void cmdAcces_Click(object sender, EventArgs e)
    {
      new frmGestionMenus2().ShowDialog();
    }

    private void CmdAccesGrp_Click(object sender, EventArgs e)
    {
      new FrmGestionAccessGroup().ShowDialog();
    }

    private void cmdCoche_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < lvwDB.Items.Count; i++)
      {
        lvwDB.Items[i].Checked = true;
        // Appelée automatiquement
        //lvwDB_ItemCheck(lvwDB.Items[i], null);
      }
    }

    private void cmdDecoche_Click(object sender, System.EventArgs e)
    {
      for (int i = 0; i < lvwDB.Items.Count; i++)
      {
        lvwDB.Items[i].Checked = false;
        // Appelée automatiquement
        //lvwDB_ItemCheck(lvwDB.Items[i], null);
      }
    }

    private void InitTreeView()
    {
      try
      {
        //  Configure le contrôle TreeView.
        TreeNode mainNode = new TreeNode()
        {
          Name = MozartParams.NomSociete,
          Text = MozartParams.NomSociete,
          ImageKey = "TOP",
          SelectedImageKey = "TOP",
          Tag = "|OPEN.JPG|CLOSED.JPG||||",
          StateImageKey = "OPEN.JPG"
        };
        //  ' Ajoute le premier noeud.
        tvwDB.Nodes.Add(mainNode);
        tvwDB.SelectedNode = mainNode;

        //   chargement de la liste des menus dans le treeview
        // affichage ou pas des menus sensibles selon les droits
        string sSQL = "";
        if (bSuperUtilisateur)
          sSQL = "select NMENUNUM, VMENULIB from TMENU WHERE NMENUPARENT = 0 ORDER BY NMENUNUM";
        else
          sSQL = "select NMENUNUM, VMENULIB from TMENU WHERE NMENUPARENT = 0 AND CMENUSENSIBLE='N' ORDER BY NMENUNUM";

        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSQL))
        {
          //Ajoute un noeud au contrôle TreeView, et définit ses propriétés.
          while (dr.Read())
          {
            TreeNode newNode = new TreeNode(dr["VMENULIB"].ToString());
            newNode.ImageKey = dr["NMENUNUM"].ToString(); // + " K";
            //newNode.Tag = "0|OPEN.JPG|CLOSED.JPG||||";

            TreeNode[] nodes = tvwDB.Nodes.Find(dr["NMENUNUM"].ToString(), true);
            if (nodes.Length == 0)
              tvwDB.Nodes[0].Nodes.Add(newNode);
            else
              mainNode.Nodes.Add(newNode);
          }
        }
        //  ' Développe le noeud du haut.
        tvwDB.SelectedNode = mainNode;
        mainNode.Expand();

        lblPath.Text = tvwDB.SelectedNode.FullPath;

        mnCurNode = mainNode;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private string LireTag(TreeNode aNode, string aInfo)
    {
      string[] tTag;
      string res = "";
      // Lecture des infos contenues dans le tag
      tTag = Strings.Split(aNode.Tag.ToString(), "|");

      switch (aInfo)
      {
        case "NIV":
          res = tTag[0];
          break;
        case "ICO":
          res = tTag[1];
          break;
        case "ICF":
          res = tTag[2];
          break;
        case "NBO":
          res = tTag[3];
          break;
        case "COM":
          res = tTag[4];
          break;
        case "SIT":
          res = tTag[5];
          break;
        case "TYP":
          res = tTag[6];
          break;
        default:
          break;
      }
      return res;
    }

    private void cmdFiltrer_Click(object sender, EventArgs e)
    {
      if (tvwDB.SelectedNode == tvwDB.Nodes[0])
        return;

      FiltrerListView();
    }

    private void lvwDB_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      try
      {
        if (e.Item.Checked == true)
        {
          if (Convert.ToInt32(e.Item.ImageKey) != minPerNum)
          {
            InsertDroitAutoSocSrc(e.Item.Index, Convert.ToInt32(e.Item.ImageKey));
            lvwDB_SelectedIndexChanged(e.Item, null);
          }
        
          if (bSuperUtilisateur) lvwSociete.Visible = true;
        }
        else
        {
          lvwSociete.Visible = false;
          //    'suppresion des droits dans une proc stock
          MozartDatabase.ExecuteNonQuery($"EXEC api_sp_SuppDroitSociete {Convert.ToInt32(mnCurNode.ImageKey)},{Convert.ToInt32(e.Item.ImageKey)},'{MozartParams.NomSociete}'");
        }

        minPerNum = Convert.ToInt32(e.Item.ImageKey);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void lvwDB_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lvwDB.SelectedItems.Count == 0)
        return;

      try
      {
        if (iLastPer > lvwDB.Items.Count)
          iLastPer = 0;

        // Passage de font Bold à régular
        lvwDB.Items[iLastPer].Font = new Font(lvwDB.Items[iLastPer].Font, FontStyle.Regular);
        lvwDB.Items[iLastPer].ForeColor = System.Drawing.Color.Black;

        ListViewItem Item = lvwDB.SelectedItems[0];

        Item.Font = new Font(Item.Font, FontStyle.Regular);
        Item.ForeColor = MozartColors.ColorHFF8080;
        iLastPer = Item.Index;

        // init de listviewsociete
        ClearListSociete();

        // récupère le nom de ou des societe ou la personne possède des droits
        string sSQL = $"SELECT DISTINCT VSOCIETE,CDROITVAL FROM TDROIT WHERE NMENUNUM = {Convert.ToInt32(mnCurNode.ImageKey)} AND NPERNUM = {Convert.ToInt32(Item.ImageKey)}";

        lvwSociete.ItemChecked -= new ItemCheckedEventHandler(this.lvwSociete_ItemChecked);
        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSQL))
        {
          while (dr.Read())
            RechercheDroitSociete(dr["VSOCIETE"].ToString(), dr["CDROITVAL"].ToString(), lvwSociete);
        }
        lvwSociete.ItemChecked += new ItemCheckedEventHandler(this.lvwSociete_ItemChecked);

        if (Item.Checked == true)
        {
          if (bSuperUtilisateur) lvwSociete.Visible = true;
          minPerNum = Convert.ToInt32(Item.ImageKey);
        }
        else
        {
          minPerNum = 0;
          lvwSociete.Visible = false;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void lvwSociete_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
      if (mnCurNode.ImageKey == "TOP")
        return;

      string cTypeForProc;
      string cDroit;
      // init

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

        // test si ok pour suppression droit des autres sociétés si on retire les droits sur société sources
        if (Item.Text == MozartParams.NomSociete && TestIfSocieteCheck())
        {
          MozartDatabase.ExecuteNonQuery($"EXEC api_sp_SuppDroitSociete {Convert.ToInt32(mnCurNode.ImageKey)}, {minPerNum}, '{Item.Text}'");
          Item.Checked = false;
          //lvwDB_SelectedIndexChanged(Item, null);
          return;
        }
        else
        {
          if (Item.Text == MozartParams.NomSociete)
            Item.Checked = false;
          // permet de decocher la personne si plus de droit sur la société MOZART
        }
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_GestionDroitSociete", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@cType"].Value = cTypeForProc;
        cmd.Parameters["@nIdMenu"].Value = Convert.ToInt32(mnCurNode.ImageKey);
        cmd.Parameters["@nIdPer"].Value = minPerNum;
        cmd.Parameters["@cDroit"].Value = cDroit;
        cmd.Parameters["@vSociete"].Value = Item.Text;
        cmd.Parameters["@vSocieteSrc"].Value = MozartParams.NomSociete;

        cmd.ExecuteNonQuery();
      }
    }

    private void tvwDB_AfterCollapse(object sender, TreeViewEventArgs e)
    {
      //    recherche de l'icone fermé
      //TreeNode Node = e.Node;
      //Node.ImageKey = LireTag(Node, "ICF");
      //mnCurNode = Node;

      ////    vider le listview
      //AfficheLVW(Node); ;
      //tvwDB.SelectedNode = Node;
      //lblPath.Text = tvwDB.SelectedNode.FullPath;
    }

    private void tvwDB_AfterExpand(object sender, TreeViewEventArgs e)
    {
      //TODO GM Probleme d'index
      //if (sLastNode > 0)
      //{
      //  tvwDB.Nodes.Find(sLastNode.ToString(), true);
      //  tvwDB.Nodes[sLastNode].NodeFont = new Font(tvwDB.Font, FontStyle.Regular);
      //  tvwDB.Nodes[sLastNode].BackColor = Color.White;
      //}

      //TreeNode Node = e.Node;

      //Node.NodeFont = new Font(tvwDB.Font, FontStyle.Bold);
      //Node.BackColor = Color.FromArgb(128, 128, 255);

      //sLastNode = Node.Index;
      //// si selection racine
      //if (Node.Index == 0)
      //{
      //  lvwSociete.Visible = false;
      //  return;
      //}

      ////  Noeuds développables.
      //Node.ImageKey = LireTag(Node, "ICO");
      //mnCurNode = Node;

      //AfficheLVW(Node);

      //tvwDB.SelectedNode = Node;
      //lblPath.Text = tvwDB.SelectedNode.FullPath;
    }
   
    private void tvwDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      TreeNode node = e.Node;

      if (mnCurNode == node)
        return;

      //  gestion du treeview
      RemplirTVW(node);


      if (mnCurNode != null && mnCurNode.NodeFont != null)
      {
        mnCurNode.NodeFont = new Font(mnCurNode.NodeFont, FontStyle.Regular);
        mnCurNode.BackColor = Color.White;
      }

      node.NodeFont = new Font(tvwDB.Font, FontStyle.Bold);
      //TODO Add ColorHFF8080 
      node.BackColor = Color.FromArgb(128, 128, 255);
      node.Text = node.Text;

      node.Expand();

      lblPath.Text = node.FullPath;

      //  mémorisation du noeud courant
      mnCurNode = node;

      // gestion du listview
      AfficheLVW(node);

      lvwSociete.Visible = false;
    }

    private bool RemplirTVW(TreeNode ParentNode)
    {
      try
      {
        // Vérifie que le noeud n'est pas déjà rempli. S'il l'est, alors
        // ajoute uniquement les objets ListItem à la ListView et quitte.
        if (ParentNode.Nodes.Count == 0)
        {
          AddNoeuds(ParentNode);

          return true; // retourne True (réussite)
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }


    private void AddNoeuds(TreeNode Node)
    {
      try
      {
        // Vérifie que le noeud n'est pas déjà rempli.
        if (Node.Nodes.Count != 0)
          return;

        // gestion des droits sur les menus sensibles
        string sSQL = "";
        if (bSuperUtilisateur)
          sSQL = $"select NMENUNUM, VMENULIB from TMENU WHERE NMENUPARENT = {Convert.ToInt32(Node.ImageKey)} ORDER BY NMENUNUM";
        else
          sSQL = $"select NMENUNUM, VMENULIB from TMENU WHERE CMENUSENSIBLE='N' AND NMENUPARENT = {Convert.ToInt32(Node.ImageKey)} ORDER BY NMENUNUM";

        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSQL))
        {
          while (dr.Read())
          {
            TreeNode newNode = new TreeNode();
            newNode.Text = dr["VMENULIB"].ToString();
            newNode.ImageKey = dr["NMENUNUM"].ToString(); // + " K";
            //newNode.Tag = "0|OPEN.JPG|CLOSED.JPG||||";
            AddNoeuds(newNode);

            Node.Nodes.Add(newNode);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void InitListView()
    {
      if (madoRS_lvwDB.Rows.Count == 0)
      {
        lvwDB.Columns.Add("Personnes", 243, HorizontalAlignment.Left);
        lvwDB.Columns.Add("Fonction", 160, HorizontalAlignment.Left);

        // ouverture du recordset des personnes;
        using (SqlDataReader dr = MozartDatabase.ExecuteReader("SELECT NPERNUM, NOM, FONC FROM api_v_Msg_Destinataires ORDER BY NOM"))
          madoRS_lvwDB.Load(dr);
      }
    }

    private void AfficheLVW(TreeNode Node)
    {
      try
      {
        if (Node.ImageKey == "TOP")
        {
          lvwDB.Items.Clear();
          return;
        }

        FiltrerListView();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AddListItem(DataRow dtRec, string strTypeNoeud)
    {
      try
      {
        //  Ajoute un nouveau ListItem et défini ses texte, icône et petite icône.
        ListViewItem xItem = new ListViewItem("xItem", 0);

        xItem = lvwDB.Items.Add(dtRec["NOM"].ToString(), dtRec["NPERNUM"].ToString()); // + " K");
        xItem.SubItems.Add(Strings.Trim(dtRec["FONC"].ToString()));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void InsertDroitAutoSocSrc(int iIndexlvwDB, int iNperNumAuto)
    {
      //'*********************************************************************************************************
      //'Cette fonction permet d'insérer les droits automatiquement sur la société source MOZART sur la personne sélectionée
      //'*********************************************************************************************************
      string cDroit;
      string cTypeForProc;
      // init

      //Basculer le droit pour ce menu
      if (lvwDB.Items[iIndexlvwDB].Checked == true)
      {
        cDroit = "O";
        cTypeForProc = "I";
      }
      else
      {
        cDroit = "N";
        cTypeForProc = "D";
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_GestionDroitSociete", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@cType"].Value = cTypeForProc;
        cmd.Parameters["@nIdMenu"].Value = Convert.ToInt32(mnCurNode.ImageKey);
        cmd.Parameters["@nIdPer"].Value = iNperNumAuto;
        cmd.Parameters["@cDroit"].Value = cDroit;
        cmd.Parameters["@vSociete"].Value = MozartParams.NomSociete;
        cmd.Parameters["@vSocieteSrc"].Value = MozartParams.NomSociete;

        cmd.ExecuteNonQuery();
      }
    }
    
    public void FiltrerListView()
    {
      DataTable dtFilter;
      string strFilter = "";
      try
      {
        //  Constituer la chaine de filtre
        if (txtFiltre.Text == "")
          strFilter = "";
        else
          strFilter = $"NOM like '%{txtFiltre.Text}%'";

        if (txtFiltre2.Text != "")
        {
          if (strFilter == "")
            strFilter = $"FONC like '%{txtFiltre2.Text}%'";
          else
            strFilter += $" AND FONC like '%{txtFiltre2.Text}%'";
        }
        try
        {
          dtFilter = madoRS_lvwDB.Select(strFilter).CopyToDataTable();
        }
        catch (Exception)
        {
          dtFilter = madoRS_lvwDB.Copy();
          dtFilter.Clear();
        }

        DataView dv = dtFilter.DefaultView;
        dv.Sort = "NOM ASC";
        DataTable sortedFilteredDT = dv.ToTable();
        FillList(sortedFilteredDT);

        CocherLesPersonnes(Convert.ToInt32(mnCurNode.ImageKey));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FillList(DataTable dt)
    {
      string sNiv = "";
      try
      {
        lvwDB.ItemChecked -= new ItemCheckedEventHandler(this.lvwDB_ItemChecked);
        lvwDB.Items.Clear();

        if (dt.Rows.Count == 0)
          return;

        //Parcours du RecordSet filtré.
        //ajout du  ListItem.
        foreach (DataRow row in dt.Rows)
          AddListItem(row, sNiv);
        //lvwDB.ItemChecked += new ItemCheckedEventHandler(this.lvwDB_ItemChecked);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CocherLesPersonnes(int idButton)
    {
      try
      {
        lvwDB.ItemChecked -= new ItemCheckedEventHandler(this.lvwDB_ItemChecked);

        foreach (ListViewItem item in lvwDB.Items)
          item.Checked = false;

        //FillList(madoRS_lvwDB);

        // recherche de la liste à cocher
        string sSQL = $"SELECT TPER.NPERNUM FROM TDROIT INNER JOIN TPER ON TDROIT.NPERNUM = TPER.NPERNUM  " +
          $"Where TPER.VSOCIETE = App_Name() AND TDROIT.VSOCIETE = App_Name() AND CDROITVAL = 'O' AND TDROIT.NMENUNUM = {idButton}";

        using (SqlDataReader dr = MozartDatabase.ExecuteReader(sSQL))
        {
          while (dr.Read())
          {
            foreach (ListViewItem item in lvwDB.Items)
            {
              if (Convert.ToInt32(item.ImageKey) == Convert.ToInt32(dr["NPERNUM"]))
              {
                item.Checked = true;
                break;
              }
            }
          }
        }
        lvwDB.ItemChecked += new ItemCheckedEventHandler(this.lvwDB_ItemChecked);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AfficheLVWSociete()
    {
      //'Affiche la liste des societes
      try
      {
        lvwSociete.Items.Clear();
        lvwSociete.Columns.Clear();
        lvwSociete.Columns.Add(Resources.col_Societe, 2500);
        lvwSociete.Columns.Add("", 0);

        dtSoc.Load(MozartDatabase.ExecuteReader("SELECT * FROM TSOCIETE WHERE VSOCIETEACTIF = 'O' ORDER BY NSOCIETENODE"));

        foreach (DataRow row in dtSoc.Rows)
          lvwSociete.Items.Add(row["VSOCIETENOM"].ToString(), row["NSOCIETENODE"].ToString());

        lvwSociete.ItemChecked += new ItemCheckedEventHandler(this.lvwSociete_ItemChecked);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ClearListSociete()
    {
      try
      {
        lvwSociete.ItemChecked -= new ItemCheckedEventHandler(lvwSociete_ItemChecked);
        foreach (ListViewItem item in lvwSociete.Items)
          item.Checked = false;
        lvwSociete.ItemChecked += new ItemCheckedEventHandler(lvwSociete_ItemChecked);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtFiltre_TextChanged(object sender, EventArgs e)
    {
      iLastPer = 0;
    }

    private void RechercheDroitSociete(string sNomSociete, string sDroitSociete, ListView lstItemNom)
    {
      // Rechercher les sociétés sur lesquelles la personne a des droits
      try
      {
        if (dtSoc.Rows.Count > 0)
        {
          foreach (DataRow row in dtSoc.Rows)
          {
            if (Utils.BlankIfNull(row["VSOCIETENOM"]) == sNomSociete && sDroitSociete == "O")
              lstItemNom.Items[lstItemNom.FindItemWithText(sNomSociete).Index].Checked = (sDroitSociete == "O");
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private bool TestIfSocieteCheck()
    {
      //Test si des sociétés sont encores cochées si on supprime les droit sur le MOZART SOURCE
      return lvwSociete.CheckedItems.Count > 0;
    }

    private void cmdClearFilter_Click(object sender, EventArgs e)
    {
      txtFiltre.Text = "";
      txtFiltre2.Text = "";
      cmdFiltrer_Click(null, null);
    }
  }
}