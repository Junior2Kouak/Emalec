using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPrepaCommandePrest : Form
  {

    public string mstrTech;
    public bool mbStatValidation; //validation ou non de la commande ou de la dde
    public int miNumSiteFournisseur; //choix du site du fournisseur
    public string msNomSiteFournisseur;
    public string msTypeDevis;

    //variables pour frmDetailsAction
    public int miTypContrat;

    int iNumDevis;
    bool bModifPrix;
    string strListeFournitures;

    DataTable dt = new DataTable();
    DataTable dtF = new DataTable();

    bool premierPassage = false;

    //Datatable avec le bon nom de colonne pour l'envoie des données dans les autres formulaires
    DataTable dtArticles = new DataTable();

    public frmPrepaCommandePrest() { InitializeComponent(); }


    private void frmPrepaCommandePrest_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        bModifPrix = false;
        strListeFournitures = "";

        mbStatValidation = false;
        initDtTemp();
        InitialiserFeuille();
        ChargesArticles();
        InitapiGrid();
        MiseEnFormeDT();

        //affichage des fournitures specifiques
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT VACTFOU FROM TACT WITH (NOLOCK) WHERE  NACTNUM={MozartParams.NumAction} AND VACTFOU is not null and VACTFOU != '' "))
        {
          if (reader.Read())
          {
            apiToolTip1.Texte = $"{Utils.BlankIfNull(reader["VACTFOU"])}\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            apiToolTip1.Titre = "Demande du technicien";
            apiToolTip1.PrintTexte("");
            apiToolTip1.Visible = true;
            apiToolTip1.BringToFront();
            (apiToolTip1.Controls["txtTexte"] as TextBox).ScrollBars = ScrollBars.Vertical;
            TextBox txtBox = (apiToolTip1.Controls["txtTexte"] as TextBox);
            txtBox.BackColor = Color.LightCyan;
          }
        }
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
    //Dim adoFour As New ADODB.Recordset
    //
    //On Error GoTo Handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  bModifPrix = False
    //  strListeFournitures = ""
    //  
    //  mbStatValidation = False
    //  InitRecordsetArticle
    //  InitialiserFeuille
    //  ChargesArticles
    //  InitapiGrid
    //  
    //  ' affichage des fournitures specifiques
    //  Set adoFour = New ADODB.Recordset
    //  adoFour.Open "SELECT VACTFOU FROM TACT WITH (NOLOCK) WHERE  NACTNUM=" & glNumAction & " AND VACTFOU is not null and VACTFOU <> '' ", cnx
    //  If Not adoFour.EOF Then
    //    apiToolTip1.width = 5000
    //    apiToolTip1.TexteBox = adoFour!vactfou
    //    apiToolTip1.Titre = "Demande du technicien"
    //    apiToolTip1.PrintTexte
    //    apiToolTip1.TexteBox = apiToolTip1.TexteBox & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
    //    apiToolTip1.Visible = True
    //    adoFour.Close
    //    Set adoFour = Nothing
    //  End If
    //
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " Form_load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      //affichage de la feuille de recherche des fournitures
      new frmRechercheArticlesCom
      {
        miNumFournisseur = 0,
        m_brechercheSite = true,
        m_bSaisieQte = true,
        mstrClient = txtFields_Name.Text,
        mstrStatut = "CDE_PREST",
        m_bAfficheInfoFou = false,
        mdtArticles = dtArticles
      }.ShowDialog();
    }
    //Private Sub cmdRechercher_Click()
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' en local, on a le recordset global rs.
    //  ' on copie rs dans rsarticle
    //  Set rsarticle = rs
    //  
    //  ' affichage de la feuille  de recherche des fournitures
    //  frmRechercheArticlesCom.miNumFournisseur = 0
    //  frmRechercheArticlesCom.brechercheSite = True
    //  frmRechercheArticlesCom.bSaisieQte = True
    //  frmRechercheArticlesCom.mstrClient = txtFields(0)
    //  frmRechercheArticlesCom.mstrStatut = "CDE_PREST"
    //  frmRechercheArticlesCom.bAfficheInfoFou = False
    //
    //  frmRechercheArticlesCom.Show vbModal
    //
    //  ' on copie rsarticle dans rs
    //  Set rs = rsarticle
    //    
    //  ' remplir les montants totaux
    //'  Call RemplirTxtTotaux
    //
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        //generation de la commande si necessaire
        //recherche si des coches en commande
        if (ExistCoche("Cde"))
        {
          //si des prix de fournitures ont été modifié depuis la création du devis quantitatif, il faut le signaler au chaff
          //en effet le montant de sa commande va changer
          if (bModifPrix)
            MessageBox.Show($"Attention, certains prix de fourniture ont changé chez le fournisseur depuis la création de votre devis\r\n{strListeFournitures}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          //Clonage
          DataTable dtA = dtArticles.Clone();

          //Récupération des lignes cochés
          foreach (DataRow row in dtArticles.Rows)
            if ((bool)row["Cde"] == true && (Int64)row["NumSiteFour"] != 0)
              dtA.ImportRow(row);

          new frmCommandeFournisseur
          {
            miNumCommande = 0,
            mstrStatutCommande = "Q", //Quantitatif,
            dtArticle = dtA
          }.ShowDialog();

          //mise à jour du code d'utilisation
          if (mbStatValidation)
            ModuleData.CnxExecute($"update tdcl set CPREPACDE='O' WHERE NACTNUM= {MozartParams.NumAction}");
        }

        //generation de la sortie de stock
        if (ExistCoche("Stock"))
        {
          //Clonage
          DataTable dtA = dtArticles.Clone();

          //Récupération des lignes cochés
          foreach (DataRow row in dtArticles.Rows)
            if ((bool)row["Stock"] == true)
              dtA.ImportRow(row);

          //Modification de la structure
          dtA.Columns["Serie"].ColumnName = "VFOUSER";
          dtA.Columns["Article"].ColumnName = "VFOUMAT";
          dtA.Columns["Marque"].ColumnName = "VFOUMAR";
          dtA.Columns["Quantite"].ColumnName = "NLARTQTE";
          dtA.Columns["Prix U"].ColumnName = "PRIXU";
          dtA.Columns["NumArticle"].ColumnName = "NFOUNUM";
          dtA.Columns["Reference"].ColumnName = "VFOUREF";
          dtA.Columns["Type"].ColumnName = "VFOUTYP";
          dtA.Columns["PCB"].ColumnName = "NFOUNBLOT";

          dtA.Columns.Remove("Prix T");
          dtA.Columns.Remove("NumFour");
          dtA.Columns.Remove("NumSiteFour");
          dtA.Columns.Remove("Fournisseur");

          new frmStockDdeSortie
          {
            mstrStatutStock = "Q", //Quantitatif
            miNumDdeSortie = 0, //mode ajout
            mstrTech = mstrTech,
            mstrSite = txtFields_Site.Text,
            dtArticles = dtA,
          }.ShowDialog();

          //mise à jour du code d'utilisation
          if (mbStatValidation)
            ModuleData.CnxExecute($"update tdcl set CPREPACDE='0' WHERE NACTNUM={MozartParams.NumAction}");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      //creation
      Dispose();
    }

    //Private Sub cmdValider_Click()
    //  
    //  ' generation de la commande si necessaire
    //  ' recherche si des coches en commande
    //  If ExistCoche("cde") Then
    //    ' si des prix de fournitures ont été modifié depuis la création du devis quantitatif, il faut le signaler au chaff
    //    ' en effet le montant de sa commande va changer
    //    If bModifPrix Then MsgBox "Attention, certains prix de fourniture ont changé chez le fournisseur depuis la création de votre devis" & vbCrLf & strListeFournitures
    //    frmCommandeFournisseur.iNumCommande = 0
    //    frmCommandeFournisseur.mstrStatutCommande = "Q"     ' Quantitatif
    //    frmCommandeFournisseur.Show vbModal
    //    
    //    ' mise à jour du code d'utilisation
    //    If mbStatValidation Then cnx.Execute "update tdcl set CPREPACDE='O' WHERE NACTNUM=" & glNumAction
    //  End If
    //  
    //  ' generation de la sortie de stock
    //  If ExistCoche("stock") Then
    //    frmStockDdeSortie.mstrStatutStock = "Q"     ' Quantitatif
    //    frmStockDdeSortie.lNumDdeSortie = 0   ' mode ajout
    //    frmStockDdeSortie.mstrTech = mstrTech
    //    frmStockDdeSortie.mstrSite = txtFields(4)
    //    frmStockDdeSortie.Show vbModal
    //    
    //    ' mise à jour du code d'utilisation
    //    If mbStatValidation Then cnx.Execute "update tdcl set CPREPACDE='O' WHERE NACTNUM=" & glNumAction
    //  End If
    //
    //  ' creation
    //  Unload Me
    //  
    //End Sub
    //
    //' UPGRADE_INFO (#0501): The 'cmdCommande_Click' member isn't used anywhere in current application.
    //'Private Sub cmdCommande_Click()
    //'  frmCommandeFournisseur.iNumCommande = 0
    //'  frmCommandeFournisseur.mstrStatutCommande = "Q"
    //'  frmCommandeFournisseur.Show vbModal
    //'End Sub
    //
    //' UPGRADE_INFO (#0501): The 'cmdDdeStock_Click' member isn't used anywhere in current application.
    //'Private Sub cmdDdeStock_Click()
    //'  frmStockDdeSortie.mstrStatutStock = "Q"     ' Quantitatif
    //'  frmStockDdeSortie.Show vbModal
    //'End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitialiserFeuille()
    {
      DataColumn stock = new DataColumn("Stock");
      stock.DataType = Type.GetType("System.Boolean");
      stock.DefaultValue = false;
      dtArticles.Columns.Add(stock);

      DataColumn cde = new DataColumn("Cde");
      cde.DataType = Type.GetType("System.Boolean");
      cde.DefaultValue = false;
      dtArticles.Columns.Add(cde);

      DataColumn NomSiteFour = new DataColumn("NomSiteFour");
      NomSiteFour.DataType = Type.GetType("System.String");
      NomSiteFour.DefaultValue = "";
      dtArticles.Columns.Add(NomSiteFour);

      //recherche des info du devis ( que le devis existe ou pas )
      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_RetourInfoDevisCLPrestation {MozartParams.NumAction}"))
      {
        //les infos de la feuille
        if (dr.Read())
        {
          txtFields_Name.Text = Utils.BlankIfNull(dr["VCLINOM"]);
          txtFields_Demandeur.Text = Utils.BlankIfNull(dr["VDINNOM"]);
          txtFields_Date.Text = Utils.BlankIfNull(dr["DDCLDAT"]);
          txtFields_Compte.Text = Utils.BlankIfNull(dr["NDINCTE"]);
          txtFields_Site.Text = Utils.BlankIfNull(dr["VSITNOM"]);
          txtFields_Resp.Text = Utils.BlankIfNull(dr["VSITRES"]);
          txtFields_Adr1.Text = Utils.BlankIfNull(dr["VSITAD1"]);
          txtFields_Adr2.Text = Utils.BlankIfNull(dr["VSITAD2"]);
          txtFields_CodePostal.Text = Utils.BlankIfNull(dr["VSITCP"]);
          txtFields_Ville.Text = Utils.BlankIfNull(dr["VSITVIL"]);
          txtFields_Di.Text = Utils.BlankIfNull(dr["NDINNUM"]);
          txtFields_Num.Text = Utils.BlankIfNull(dr["NDCLNUM"]);

          iNumDevis = (int)Utils.ZeroIfBlank(Strings.Mid(Utils.BlankIfNull(dr["NDCLNUM"]), 3));
        }
      }
    }

    private void MiseEnFormeDT()
    {
      foreach (DataRow row in dtArticles.Rows)
      {
        dtArticles.Columns["PCB"].ReadOnly = false;
        dtArticles.Columns["QteStk"].ReadOnly = false;
        dtArticles.Columns["QteCmd"].ReadOnly = false;
        dtArticles.Columns["QteMag"].ReadOnly = false;

        row["PCB"] = (int)Utils.ZeroIfNull(row["PCB"]);
        row["QteStk"] = Utils.ZeroIfNull(row["QteStk"]);
        row["QteCmd"] = Utils.ZeroIfNull(row["QteCmd"]);
        row["QteMag"] = Utils.ZeroIfNull(row["QteMag"]);
      }
    }

    private void InitapiGrid()
    {
      apiTGrid.AddColumn(Resources.col_stock, "Stock", 600);
      apiTGrid.AddColumn(Resources.col_cde, "Cde", 600);
      apiTGrid.AddColumn(Resources.col_Serie, "Serie", 0);
      apiTGrid.AddColumn(Resources.col_Article, "Article", 2700);
      apiTGrid.AddColumn(Resources.col_marque, "Marque", 1000);
      apiTGrid.AddColumn(Resources.col_Type, "Type", 1000);
      apiTGrid.AddColumn(Resources.col_reference, "Reference", 1200);
      apiTGrid.AddColumn(Resources.col_pcb, "PCB", 700, "", 2);
      apiTGrid.AddColumn("Qte Mag Emalec", "QteMag", 1900, "", 2);
      apiTGrid.AddColumn(Resources.col_prixU, "Prix U", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_QteReste, "Quantite", 1200, "", 2); //car on commande uniquement ce qui n'est pas encore commandé
      apiTGrid.AddColumn(Resources.col_QteCmd, "QteCmd", 1000, "", 2);
      apiTGrid.AddColumn("Qte Sortie stk", "QteStk", 1400, "", 2);
      apiTGrid.AddColumn(Resources.col_QteDevis, "QteDevis", 1200, "", 2);
      apiTGrid.AddColumn(Resources.col_prixT, "Prix T", 700, "", 2);
      apiTGrid.AddColumn(Resources.col_Fournisseur, "Fournisseur", 1200, "", 0, false, true);
      apiTGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
      apiTGrid.AddColumn(Resources.col_num_four, "NumFour", 0);
      apiTGrid.AddColumn("NomSiteFour", "NomSiteFour", 0);
      apiTGrid.AddColumn(Resources.col_Code, "Code", 0);

      apiTGrid.FilterBar = false;
      apiTGrid.btnPrint.Visible = true;

      //Bouton sur la colonne Fournisseur
      RepositoryItemButtonEdit btnFournisseur = new RepositoryItemButtonEdit();
      btnFournisseur.Buttons.Clear();
      btnFournisseur.Buttons.Add(new EditorButton(ButtonPredefines.Combo));
      btnFournisseur.TextEditStyle = TextEditStyles.DisableTextEditor;

      btnFournisseur.ButtonClick += new ButtonPressedEventHandler(btnFournisseur_ButtonClick);
      apiTGrid.dgv.Columns["Fournisseur"].ColumnEdit = btnFournisseur;
      apiTGrid.dgv.Columns["Fournisseur"].ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell;
      apiTGrid.dgv.Columns["Fournisseur"].OptionsColumn.AllowEdit = true;

      apiTGrid.dgv.OptionsView.ColumnAutoWidth = false;

      apiTGrid.InitColumnList();
    }

    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
        if (View.GetDataRow(e.RowHandle)["Code"].ToString().ToUpper() == "O")
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
    }

    public void initDtTemp()
    {
      dtArticles.Columns.Add(new DataColumn("Serie", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("Article", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("Marque", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("Type", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("Reference", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("PCB", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("Prix U", Type.GetType("System.Double")));
      dtArticles.Columns.Add(new DataColumn("Quantite", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("Prix T", Type.GetType("System.Double")));
      dtArticles.Columns.Add(new DataColumn("Fournisseur", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("NumArticle", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("NumFour", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("NumSiteFour", Type.GetType("System.Int64")));
      //dtTemp.Columns.Add(new DataColumn("NomSiteFour", Type.GetType("System.String")));
      //dtTemp.Columns.Add(new DataColumn("Stock", Type.GetType("System.Boolean")));
      //dtTemp.Columns.Add(new DataColumn("Cde", Type.GetType("System.Boolean")));
      dtArticles.Columns.Add(new DataColumn("Nb", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
      dtArticles.Columns.Add(new DataColumn("QteCmd", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("QteStk", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("QteDevis", Type.GetType("System.Int64")));
      dtArticles.Columns.Add(new DataColumn("QteMag", Type.GetType("System.Int64")));
    }

    private void ChargesArticles()
    {
      TestFoPrixFromDevis();

      //recherche des détails fournitures
      if (msTypeDevis == "P")
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_RetourArticlesDevisPrestation {iNumDevis}");
      else
        apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_RetourArticlesDevisQuant {iNumDevis}");

      foreach (DataRow row in dt.Rows)
        AjouterEnrg(row);

      apiTGrid.GridControl.DataSource = dtArticles;
    }
    
    private void AjouterEnrg(DataRow row)
    {
      try
      {
        DataRow newRow = dtArticles.NewRow();
        newRow["Serie"] = Utils.BlankIfNull(row["Serie"]);
        newRow["Article"] = Utils.BlankIfNull(row["Article"]);
        newRow["Marque"] = Utils.BlankIfNull(row["Marque"]);
        newRow["Type"] = Utils.BlankIfNull(row["VFOUTYP"]);
        newRow["Reference"] = Utils.BlankIfNull(row["VFOUREF"]);
        newRow["PCB"] = Utils.ZeroIfNull(row["NFOUNBLOT"]);
        newRow["Prix U"] = Utils.ZeroIfNull(row["Prix U"]);
        newRow["Fournisseur"] = Utils.BlankIfNull(row["Fournisseur"]);
        newRow["Prix T"] = Utils.ZeroIfNull(row["Prix T"]);
        newRow["Quantite"] = Utils.ZeroIfNull(row["Quantite"]);
        newRow["NumFour"] = Utils.ZeroIfNull(row["NumFour"]); // fournisseur du groupe
        newRow["NumArticle"] = Utils.ZeroIfNull(row["NumArticle"]);
        newRow["NumSiteFour"] = 0;
        newRow["NomSiteFour"] = "";
        newRow["Stock"] = false;
        newRow["Cde"] = false;
        newRow["Nb"] = Utils.ZeroIfNull(row["NB"]);
        newRow["Code"] = Utils.BlankIfNull(row["CCODEG"]);
        newRow["QteCmd"] = Utils.ZeroIfNull(row["QTECMD"]);
        newRow["QteStk"] = Utils.ZeroIfNull(row["QTESTK"]);
        newRow["QteDevis"] = Utils.ZeroIfNull(row["QuantiteDevis"]);
        newRow["QteMag"] = Utils.ZeroIfNull(row["QTEMAG"]);

        // on test si modification d'un prix de fourniture
        if (Utils.ZeroIfNull(row["Prix U"]) != Utils.ZeroIfNull(row["PrixInitDev"]))
        {
          bModifPrix = true;
          strListeFournitures = $"{strListeFournitures}\r\n{row["Article"]}  (devis : {((decimal)row["PrixInitDev"]).ToString("0.##")} €)";
        }

        dtArticles.Rows.Add(newRow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    bool ExistCoche(string stype)
    {
      bool ExistCoche = false;
      int iFourCur;

      // FGA demande de Sylvie et Philippe le 28 / 03 / 22     
      //if (miTypContrat == 247)
      //{
      //  MessageBox.Show("Vous devez faire une réappro technicien sur le contrat Extinction Incendie!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  return ExistCoche;
      //}

      DataRow rowW = apiTGrid.GetFocusedDataRow();
      if (null == rowW) return ExistCoche;

      foreach (DataRow row in dtArticles.Rows)
      {
        row["NumSiteFour"] = 0;
        row["NomSiteFour"] = "";

        //recherche des coches de cdes
        if (Convert.ToBoolean(row[stype]) == true)
        {
          if (stype == "Cde") //commande fournisseur
          {
            if ((int)Utils.ZeroIfNull(row["NumSiteFour"]) == 0)
            {
              using (SqlDataReader dr = ModuleData.ExecuteReader($"select distinct NSTFNUM, VSTFNOM from TSTF WHERE NSTFGRPNUM = {(int)Utils.ZeroIfNull(row["numfour"])}"))
              {
                if (dr.Read())
                {
                  miNumSiteFournisseur = (int)Utils.ZeroIfBlank(dr["NSTFNUM"]);
                  msNomSiteFournisseur = Utils.BlankIfNull(dr["VSTFNOM"]);
                }
                if (dr.Read())
                {
                  frmSelectionSiteFour frm = new frmSelectionSiteFour
                  {
                    miFournisseur = (int)Utils.ZeroIfNull(row["NumFour"])
                  };
                  frm.ShowDialog();

                  if (frm.miNumSiteFournisseur == 0) MessageBox.Show("Vous n'avez pas sélectionner de fournisseur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                  miNumSiteFournisseur = frm.miNumSiteFournisseur;
                  msNomSiteFournisseur = frm.msNomSiteFournisseur;
                }
              }

              if (miNumSiteFournisseur != 0)
              {
                row["NumSiteFour"] = miNumSiteFournisseur;
                row["NomSiteFour"] = msNomSiteFournisseur;
                iFourCur = (int)Utils.ZeroIfBlank(row["NumFour"]);

                foreach (DataRow rowF in dtArticles.Rows)
                {
                  //Passage directe à la seconde ligne
                  if ((int)Utils.ZeroIfNull(row["NumSiteFour"]) == (int)Utils.ZeroIfNull(rowF["NumSiteFour"]))
                    continue;

                  if ((int)Utils.ZeroIfBlank(rowF["NumFour"]) == iFourCur)
                  {
                    rowF["NumSiteFour"] = miNumSiteFournisseur;
                    rowF["NomSiteFour"] = msNomSiteFournisseur;
                  }
                }
                ExistCoche = true;
              }
            }
          }
          else //sortie stock
          {
            ExistCoche = true;
            return ExistCoche;
          }
        }
      }
      return ExistCoche;
    }
    //Function ExistCoche(stype As String) As Boolean
    //Dim i As Integer
    //Dim iFourCur As Long
    //Dim rsFou As ADODB.Recordset
    //
    //  On Error Resume Next
    //  
    //  ExistCoche = False
    //  
    //  If frmDetailstravaux.iTypContrat = 247 Then MsgBox "Vous devez faire une réappro technicien sur le contrat Extinction Incendie!", vbInformation:: Exit Function
    //  
    //  If rs.State = 0 Then Exit Function
    //  
    //  rs.MoveFirst
    //  While Not rs.EOF
    //    ' recherche des coches de cdes
    //    If rs(stype) Then
    //      If stype = "cde" Then ' commande fournisseur
    //        If rs("NumSiteFour") = 0 Then
    //          Set rsFou = New ADODB.Recordset
    //          rsFou.Open "select distinct NSTFNUM, VSTFNOM from TSTF WHERE NSTFGRPNUM = " & rs("numfour"), cnx
    //            If rsFou.RecordCount > 1 Then
    //              Set frmSelectionSiteFour.frmAppelante = Me
    //              frmSelectionSiteFour.miFournisseur = rs("numfour")
    //              frmSelectionSiteFour.Show vbModal
    //            Else
    //              miNumSiteFournisseur = rsFou("NSTFNUM")
    //              msNomSiteFournisseur = rsFou("VSTFNOM")
    //            End If
    //          
    //            If miNumSiteFournisseur <> 0 Then
    //              rs("numSitefour") = miNumSiteFournisseur
    //              rs("nomSitefour") = msNomSiteFournisseur
    //              iFourCur = rs("numfour")
    //            
    //              i = rs.AbsolutePosition
    //              rs.MoveNext
    //              While Not rs.EOF
    //                If rs("numfour") = iFourCur Then
    //                  rs("numSitefour") = miNumSiteFournisseur
    //                  rs("nomSitefour") = msNomSiteFournisseur
    //                End If
    //                rs.MoveNext
    //              Wend
    //              rs.AbsolutePosition = i
    //              ExistCoche = True
    //            End If
    //        End If
    //      Else ' sortie stock
    //        ExistCoche = True
    //        Exit Function
    //      End If
    //      
    //    End If
    //    rs.MoveNext
    //  Wend
    //        Exit Function
    //  
    //End Function
    //
    /* --------------------------------------------------------------------------------------- */
    private void btnFournisseur_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;
      //dt.Columns["NB"].ReadOnly = false;
      //row["NB"] = 10;

      if ((int)Utils.ZeroIfNull(row["NB"]) > 1)
      {
        dbGrid.LoadData(dtF, MozartDatabase.cnxMozart, $"EXEC api_sp_ListePrixFourniture {row["NumArticle"]}");
        dbGrid.GridControl.DataSource = dtF;

        if (premierPassage == false)
        {
          InitDbGrid();
          premierPassage = true;
        }

        Frame1.Visible = true;
      }
    }

    private void InitDbGrid()
    {
      dbGrid.AddColumn("Fournisseur", "Fournisseur", 10);
      dbGrid.AddColumn("Prix HT", "Prix HT", 10, "#.##");
      dbGrid.AddColumn("Date du prix", "Date du prix", 10);

      dbGrid.FilterBar = false;
      dbGrid.btnPrint.Visible = false;

      dbGrid.InitColumnList();
    }
    //Private Sub apiTGrid_ButtonClick(ColIndex As Integer)
    //  
    //  If rs!Nb > 1 Then
    //    Dim rsF As New ADODB.Recordset
    //    Set rsF = cnx.Execute("EXEC api_sp_ListePrixFourniture " & rs!NumArticle)
    //    Set dbGrid.DataSource = rsF
    //    dbGrid.Columns(1).Visible = False
    //    Frame1.Top = apiTGrid.Rowtop + apiTGrid.Top
    //    Frame1.Visible = True
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Command2_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      DataRow rowGrid = dbGrid.GetFocusedDataRow();
      if (null == rowGrid) return;

      dtArticles.Columns["Fournisseur"].ReadOnly = false;
      dtArticles.Columns["Prix U"].ReadOnly = false;
      dtArticles.Columns["Prix T"].ReadOnly = false;
      dtArticles.Columns["NumFour"].ReadOnly = false;

      row["Fournisseur"] = Utils.BlankIfNull(rowGrid["Fournisseur"]);
      row["Prix U"] = Utils.ZeroIfBlank(rowGrid["Prix HT"]);
      row["Prix T"] = (int)Utils.ZeroIfNull(row["Prix U"]) * (int)Utils.ZeroIfNull(row["Quantite"]);
      row["NumFour"] = Utils.BlankIfNull(rowGrid["Num"]);

      Frame1.Visible = false;
    }

    //Private Sub Command2_Click()
    //  
    //  rs("Fournisseur").value = dbGrid.Columns("Fournisseur").Text
    //  rs("Prix U").value = Replace(dbGrid.Columns("Prix HT").Text, ",", ".")
    //  rs("Prix T").value = rs("Prix U").value * rs("Quantite").value
    //  rs("NumFour").value = CLng(dbGrid.Columns("Num").Text)
    //  
    //  Frame1.Visible = False
    //
    //End Sub
    //
    //'***********************************************************************************************
    //'Cette focntion permet de tester et de retourner sous forme de message, la liste des fournitures présente dans le devis qui n'ont plus de prix chez le fournisseur.
    //'***********************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private void TestFoPrixFromDevis()
    {
      string sMsg = "";
      using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_MsgFoWithoutPrixFromDevis {iNumDevis}"))
      {
        if (dr.Read())
          sMsg = Utils.BlankIfNull(dr["MSG"]);
      }

      if (sMsg != "")
        MessageBox.Show(sMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    //Private Sub TestFoPrixFromDevis()
    //
    //    Dim rsFO As New ADODB.Recordset
    //    Dim sMsg As String
    //    
    //    rsFO.Open "api_sp_MsgFoWithoutPrixFromDevis " & iNumDevis, cnx, adOpenStatic, adLockOptimistic
    //    
    //    sMsg = rsFO("MSG")
    //    rsFO.Close
    //    
    //    If sMsg <> "" Then MsgBox sMsg, vbExclamation
    //
    //End Sub
    //
    //
    //
    //

    private void CaseCochee(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (e.Column.Name == "Stock")
        row["Stock"] = Convert.ToBoolean(Utils.BlankIfNull(row["Stock"])) == false;
      else if (e.Column.Name == "Cde")
        row["Cde"] = Convert.ToBoolean(Utils.BlankIfNull(row["Cde"])) == false;
    }
  }
}

