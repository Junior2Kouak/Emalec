using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
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
  public partial class frmStockArticleClientSite : Form
  {
    public string mstrStatut;
    public string mstrStatutInv;
    public int miNumClient;
    public int miNumSite;

    DataTable dt = new DataTable();
    bool bValide;

    //' feuille ouverte en création ou modification
    //Public mstrStatut As String
    //Public mstrStatutInv As String
    //Public miNumClient As Long
    //Public miNumSite As Long
    //
    //Dim adoRS As ADODB.Recordset
    //Dim bValide As Boolean

    public frmStockArticleClientSite() { InitializeComponent(); }

    private void frmStockArticleClientSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // initialisation
        bValide = true;

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select * from api_v_InfoStockArtSite where NSITNUM={miNumSite}"))
        {
          if (sdr.Read())
          {
            txtClient.Text = Utils.BlankIfNull(sdr["VCLINOM"]);
            txtInfoStock.Text = Utils.BlankIfNull(sdr["VSITINFOSTOCK"]);
            this.Text = $"{Resources.txt_gestionArticlesClient}{txtClient}";
            if (mstrStatut == "STOCK_TS")
            {
              txtSite.Text = Resources.txt_tousSites;
              txtNumSite.Text = "";
              this.Text += " sur tous les sites";
            }
            else
            {
              txtSite.Text = Utils.BlankIfNull(sdr["VSITNOM"]);
              txtNumSite.Text = Utils.BlankIfNull(sdr["NSITNUE"]);
              this.Text += " sur le site " + txtSite;
            }
          }
        }
        //initialisation de la feuille
        InitialisationListe();

        if (mstrStatut == "INV")
        {
          Frame1.Visible = false;
          lblTitre.Text = Resources.txt_saisieInvStockClientSite;
          if (mstrStatutInv == "V") cmdValider.Enabled = false;
          cmdVisu.Visible = false;
        }
        else
        {
          lblTitre.Text = Resources.txt_saisieStockTheoriqueClientSite;
          Frame1.Visible = false;
          imgInfo.Visible = lblInfo.Visible = true;
        }

        GridLocalizer.Active = new CustomGridLocalizer();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    class CustomGridLocalizer : GridLocalizer
    {
      public override string GetLocalizedString(GridStringId id)
      {
        if (id == GridStringId.CheckboxSelectorColumnCaption)
        {
          return Resources.col_auto;
        }
        return base.GetLocalizedString(id);
      }
    }

    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  ' initialisation des images
    //  InitBoutons Me, frmMenu
    //  
    //  ' initialisaion
    //  bValide = True
    //  
    //  ' recherche des infos à afficher
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select * from api_v_InfoStockArtSite where NSITNUM=" & miNumSite, cnx
    //       
    //  txtClient = BlankIfNull(adoRS("VCLINOM"))
    //  txtInfoStock = BlankIfNull(adoRS("VSITINFOSTOCK"))
    //  Me.Caption = "§Gestion des articles du client §" & txtClient
    //  If mstrStatut = "STOCK_TS" Then
    //    txtSite = "§Tous sites§"
    //    txtNumSite = ""
    //    Me.Caption = Me.Caption & " sur tous les sites"
    //  Else
    //    txtSite = BlankIfNull(adoRS("VSITNOM"))
    //    txtNumSite = BlankIfNull(adoRS("NSITNUE"))
    //    Me.Caption = Me.Caption & " sur le site " & txtSite
    //  End If
    //    
    //  ' initialisation de la feuille
    //  Call InitialisationListe
    //  
    //  If mstrStatut = "INV" Then
    //    Frame1.Visible = False
    //    lblTitre.Caption = "§Saisie d'inventaire du stock client sur site§"
    //    If mstrStatutInv = "V" Then cmdValider.Enabled = False
    //    cmdVisu.Visible = False
    //  Else
    //    lblTitre.Caption = "§Saisie des stocks théoriques du client sur site §"
    //    Frame1.Visible = False
    //    imgInfo.Visible = True
    //    lblInfo.Visible = True
    //  End If
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " Form_load dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        // confirmation
        if (mstrStatut == "STOCK_TS")
        {
          if (MessageBox.Show($"{Resources.msg_applicationModifTousSitesCli}\r\nVoulez - vous vraiment continuer ? ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.No) return;
        }
        Cursor.Current = Cursors.WaitCursor;

        // on enregistre les infos stock du site
        ModuleData.CnxExecute($"UPDATE TSIT SET VSITINFOSTOCK = '{txtInfoStock.Text.Replace("'", "''")}' WHERE NSITNUM = {miNumSite}");

        foreach (DataRow row in dt.Rows)
          enregLigne(row);

        Cursor.Current = Cursors.Default;

        // confirmation de la commande
        if (mstrStatutInv == "C" && bValide)
        {
          // affichage de la liste des articles à commander avec les fournisseurs
          // recherche des infos à afficher

          apiToolTip1.Texte = "";
          using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_ListeDesArticlesQteFournisseurs {MozartParams.NumAction}"))
          {
            apiToolTip1.AddColumn(Resources.col_Article, 8000 / 15);
            apiToolTip1.AddColumn(Resources.col_qteCdeFou, 1500 / 15);
            apiToolTip1.AddColumn(Resources.col_Fournisseur, 3000 / 15);
            apiToolTip1.AddColumn(Resources.col_prix_total, 1000 / 15);

            double somme = 0;

            while (sdr.Read())
            {
              apiToolTip1.Texte += $"{Strings.Left(Utils.BlankIfNull(sdr["VFOUMAT"]), 65)} ||{Utils.ZeroIfNull(sdr["QTE"])} ||{Strings.Left(Utils.BlankIfNull(sdr["VSTFNOM"]), 20)} || {Utils.ZeroIfNull(sdr["prix"])}\r\n";
              somme += Utils.ZeroIfNull(sdr["prix"]);
            }

            apiToolTip1.Texte += $"TOTAL : ||  || ||{ somme}\r\n"; //suppression des || car invisibles en VB6
            apiToolTip1.PrintTexte("");
            apiToolTip1.Visible = true;
            apiToolTip1.BringToFront();
          }

          if (MessageBox.Show(Resources.msg_creationActionFouretCommande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes) CreationActionEtCommande("CDE", DateTime.Now.AddDays(3).ToShortDateString());
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub cmdValider_Click()
    //Dim rsa As New ADODB.Recordset
    //
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String
    //Dim myDate As String
    //Dim Somme As Double
    //
    //  ' enregistrement avec le recordset local,
    //On Error GoTo handler
    //  
    //  ' confirmation
    //  If mstrStatut = "STOCK_TS" Then
    //   If MsgBox("§Vous allez appliquer ces modifications sur tous les sites du client.§" _
    //   & vbCrLf & "Voulez-vous vraiment continuer ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then Exit Sub
    //  End If
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  'on enregistre les info stock du site
    //  cnx.Execute "UPDATE TSIT SET VSITINFOSTOCK = '" & Replace(txtInfoStock, "'", "''") & "' WHERE NSITNUM = " & miNumSite
    //  
    //  rsarticle.MoveFirst
    //  While Not rsarticle.EOF
    //    Call enregLigne
    //    rsarticle.MoveNext
    //  Wend
    //  
    //  Screen.MousePointer = vbDefault
    // 
    //  
    //  ' confirmation de la commande
    //  If mstrStatutInv = "C" And bValide Then
    //    ' affichage de la liste des articles à commander avec le fournisseur
    //    ' recherche des infos à afficher
    //    apiToolTip1.Texte = ""
    //    Set rsa = New ADODB.Recordset
    //    rsa.Open "api_sp_ListeDesArticlesQteFournisseurs " & glNumAction, cnx
    //    apiToolTip1.AddColumn "§Article§", 8000
    //    apiToolTip1.AddColumn "§QTE Cde Fou§", 1500
    //    'apiToolTip1.AddColumn "§QTE SStock§", 1300
    //    apiToolTip1.AddColumn "§Fournisseur§", 3000
    //    apiToolTip1.AddColumn "§Prix Total§", 1000
    //    
    //    Somme = 0
    //    While Not rsa.EOF
    //    apiToolTip1.Texte = apiToolTip1.Texte & Left(rsa!VFOUMAT, 65) & " ||" & rsa!QTE & " ||" & Left(rsa!VSTFNOM, 20) & " ||" & rsa!Prix & vbCrLf
    //      Somme = Somme + rsa!Prix
    //      rsa.MoveNext
    //    Wend
    //    apiToolTip1.Texte = apiToolTip1.Texte & "TOTAL : || " & " ||" & " ||" & Somme & vbCrLf
    //    apiToolTip1.PrintTexte
    //    apiToolTip1.Visible = True
    //  
    //    
    //    
    //    ' COLIN le 23/06/21 ne plus proposer la création des commandes ou sortie de stock
    //    ' mais l'inventaire demande une action de fourniture
    //    ' version sans les commandes
    //    'CreationActionEtInventaire
    //        
    //    ' FGA le 21/12/2021
    //    
    //      If MsgBox("§Voulez-vous créer l'action de fourniture et les commandes ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //        Exit Sub
    //      Else
    //'        apiToolTip1.Visible = False
    //'        ' saisie de la date de livraison
    //'        myDate = InputBox("Saisissez la date de livraison (jj/mm/aaaa) à 3 jours minimum", "Mozaris pour " & gstrNomSociete)
    //'        If Not IsDate(myDate) Then
    //'          MsgBox "§Date invalide§", vbInformation
    //'          Exit Sub
    //'        End If
    //'
    //'        If MsgBox("§Vous avez le choix entre faire des commandes aux fournisseurs ou faire des sorties de stock magasin §" & gstrNomSociete & "." & vbCrLf & "Pour les commandes fournisseurs cliquez sur NON, pour les sorties de stock cliquez sur OUI", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //'          ' creation cmd fournisseur
    //          CreationActionEtCommandes "CDE", Date + 3
    //'          ' Sorties de stock
    //'        Else
    //'          CreationActionEtCommandes "DDE", myDate
    //'        End If
    //'
    //      End If
    //
    //
    //  End If
    //  
    //  
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " cmdValider_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string[,] TdbGlobal = { { "copie", "1/2   Original" } };

      frmBrowser f = new frmBrowser();
      f.miPlanningAn = 0;
      f.msInfosMail = $"TSIT|NSITNUM|{miNumSite}";
      f.Preview_Print($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TStockSite.rtf",
                      @"TStockSiteOut.rtf",
                      TdbGlobal,
                      $"exec api_sp_impStockSite {miNumSite}",
                      " (Visualisation )",
                      "PREVIEW");
    }

    //Private Sub CmdVisu_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //  
    //  On Error Resume Next
    //  
    //    
    //  TdbGlobal(0, 0) = "copie"
    //  TdbGlobal(0, 1) = "1/2   Original"
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.InfosMail = "TSIT|NSITNUM|" & miNumSite
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TStockSite.rtf", _
    //                           "\TStockSiteOut.rtf", _
    //                            TdbGlobal(), _
    //                            "exec api_sp_impStockSite " & miNumSite, _
    //                            " (Visualisation )", _
    //                            "PREVIEW"
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void Image2_Click(object sender, EventArgs e)
    {
      try
      {
        if (miNumSite == 0) return;

        Cursor.Current = Cursors.WaitCursor;

        // recherche des infos à afficher
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"select VSITNOM, VSITAD1, VSITCP, VSITVIL, VSITPAYS from TSIT where NSITNUM={miNumSite}"))
        {
          if (sdr.Read())
          {
            new frmBrowser()
            {
              msStartingAddress = $"https://maps.emalec.com/SiteParAdresse.asp?NOM={Utils.BlankIfNull(sdr["VSITNOM"])}&AD1={Utils.BlankIfNull(sdr["VSITAD1"])}&VILLE={Utils.BlankIfNull(sdr["VSITCP"])} {Utils.BlankIfNull(sdr["VSITVIL"])}&PAYS={Utils.BlankIfNull(sdr["VSITPAYS"])}"
            }.ShowDialog();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Image2_Click()
    //
    //Dim adoR As New ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  
    //  If miNumSite = 0 Or IsNull(miNumSite) Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' recherche des infos à afficher
    //  adoR.Open "select VSITNOM, VSITAD1, VSITCP, VSITVIL, VSITPAYS from TSIT where NSITNUM=" & miNumSite, cnx
    //  
    //  ' Modif VL 02/01/2008
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/SiteParAdresse.asp?NOM=" & BlankIfNull(adoR("VSITNOM")) & "&AD1=" & BlankIfNull(adoR("VSITAD1")) & "&VILLE=" & BlankIfNull(adoR("VSITCP")) & " " & BlankIfNull(adoR("VSITVIL")) & "&PAYS=" & BlankIfNull(adoR("VSITPAYS"))
    //  frmBrowser.Show vbModal
    //  ' Modif VL 02/01/2008
    //  
    //'  frmMapVisuCarte.mstrCPSite = BlankIfNull(adoR("VSITCP"))
    //'  frmMapVisuCarte.mstrVilleSite = BlankIfNull(adoR("VSITVIL"))
    //'  frmMapVisuCarte.mstrPaysSite = BlankIfNull(adoR("VSITPAYS"))
    //'  frmMapVisuCarte.mstrNomSite = BlankIfNull(adoR("VSITNOM"))
    //'  frmMapVisuCarte.Show vbModal
    //
    //  Screen.MousePointer = vbDefault
    //   
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitialisationListe()
    {
      try
      {
        //recherche des détails fournitures
        string sSQL = "";
        if (mstrStatut == "INV") sSQL = $"select * from api_v_StockArtSite where NQTEMAG > 0 AND NSITNUM ={miNumSite} ORDER BY VFOUMAT";
        else sSQL = $"select * from api_v_StockArtSite where NSITNUM = {miNumSite} ORDER BY VFOUMAT";

        //On charge les données dans la datatable
        dt.Columns.Add("NQTEMAG", Type.GetType("System.Int32"));
        dt.Columns.Add("NQTESTOK", Type.GetType("System.Int32"));
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGrid1.GridControl.DataSource = dt;

        InitGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitialisationListe()
    // 
    //Dim rs As ADODB.Recordset
    //
    //On Error GoTo handler
    //  
    //  
    //  ' initialisation du recordset local des articles
    //  Call InitRecordsetArticle
    //  
    //  ' recherche des détails fournitures
    //  Set rs = New ADODB.Recordset
    //  If mstrStatut = "INV" Then
    //    rs.Open "select * from api_v_StockArtSite where NQTEMAG > 0 AND NSITNUM = " & miNumSite & " ORDER BY VFOUMAT", cnx, adOpenStatic, adLockOptimistic
    //  Else
    //    rs.Open "select * from api_v_StockArtSite where NSITNUM = " & miNumSite & " ORDER BY VFOUMAT", cnx, adOpenStatic, adLockOptimistic
    //  End If
    //  
    //  
    //  ' passage des infos du recordset
    //  While Not rs.EOF
    //    AjouterEnreg rs
    //    rs.MoveNext
    //  Wend
    //  
    //  InitGrid
    //  
    //  On Error Resume Next
    //  rsarticle.MoveFirst
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitialisationListe dans " & Me.Name
    //End Sub
    //

    /*OK --------------------------------------------------------------------------------------- */
    public void InitGrid()
    {
      try
      {
        if (mstrStatut == "INV")
        {
          apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 8500);
          apiTGrid1.AddColumn(Resources.col_qteInventaire, "NQTEINV", 2000, "0", 2);

          dt.Columns["NQTEINV"].ReadOnly = false;

          apiTGrid1.DelockColumn("NQTEINV");
        }
        else
        {
          apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 4000);
          apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1500);
          apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1100);
          apiTGrid1.AddColumn(Resources.col_reference, "VFOUREF", 1500, "", 2);
          apiTGrid1.AddColumn(Resources.col_parcombien, "NFOUNBLOT", 600, "", 2);
          apiTGrid1.AddColumn(Resources.col_nbEquipSite, "NQTEMAG", 1300, "0", 2);
          apiTGrid1.AddColumn(Resources.col_nbStockerSite, "NQTESTOK", 1500, "0", 2);

          apiTGrid1.DelockColumn("NQTEMAG");
          apiTGrid1.DelockColumn("NQTESTOK");

          apiTGrid1.dgv.OptionsSelection.MultiSelect = true;
          apiTGrid1.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
          apiTGrid1.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
          apiTGrid1.dgv.OptionsSelection.CheckBoxSelectorField = "NGESTSTOCKCLISIT";
        }
        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Public Sub InitGrid()
    //  
    //On Error GoTo handler
    //   
    //    If mstrStatut = "INV" Then
    //        apiTGrid1.AddColumn "§Matériel§", "Article", 8500
    //        apiTGrid1.AddColumn "§Qté inventaire§", "Qteinv", 2000, "0", 2
    //        
    //        apiTGrid1.DelockColumn "Qteinv"
    //    Else
    //        apiTGrid1.AddColumn "§Auto§", "Gestion", 1000, , , , , True
    //        apiTGrid1.AddColumn "§Matériel§", "Article", 4000
    //        apiTGrid1.AddColumn "§Marque§", "Marque", 1500
    //        apiTGrid1.AddColumn "§Type§", "Type", 1100
    //        apiTGrid1.AddColumn "§Référence§", "Reference", 1500, , 2
    //        apiTGrid1.AddColumn "§Par combien§", "PCB", 600, , 2
    //        apiTGrid1.AddColumn "§Nbr équip sur site§", "QteMag", 1300, "0", 2
    //        apiTGrid1.AddColumn "§Nbr à stocker sur site§", "Qtestock", 1500, "0", 2
    //        
    //        apiTGrid1.AddCellTip "Gestion", &HFDF0DA, "Stock mini automatique"
    //        
    //        apiTGrid1.DelockColumn "QteMag"
    //        apiTGrid1.DelockColumn "Qtestock"
    //    End If
    //
    //    apiTGrid1.Init rsarticle
    //
    //Exit Sub
    //handler:
    //  ShowError " Initgrid dans " & Me.Name
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Public Sub InitRecordsetArticle()
    //
    //On Error GoTo handler
    //
    //' initialisation du tableau de recherche des articles
    //  Set rsarticle = New ADODB.Recordset
    //  
    //  ' ajout des champs au recordset
    //  rsarticle.Fields.Append "Article", adVarChar, 150
    //  rsarticle.Fields.Append "Marque", adVarChar, 150
    //  rsarticle.Fields.Append "Type", adVarChar, 2000
    //  rsarticle.Fields.Append "Reference", adVarChar, 150
    //  rsarticle.Fields.Append "PCB", adInteger
    //  rsarticle.Fields.Append "QteMag", adDecimal
    //  rsarticle.Fields.Append "Qtestock", adDecimal
    //  rsarticle.Fields.Append "Qteinv", adDecimal
    //  rsarticle.Fields.Append "NumArticle", adInteger
    //  rsarticle.Fields.Append "Gestion", adInteger
    //  
    //  ' ouverture
    //  rsarticle.Open , , adOpenDynamic, adLockOptimistic
    //    
    //Exit Sub
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    public void enregLigne(DataRow row)
    {
      string sSQL = "";
      // insertion dans la table des stocks site
      if (mstrStatut == "INV") sSQL = $"update TSTOCKARTCLISIT set NQTEINV = {row["NQTEINV"]}";
      else
      {
        sSQL = $"update TSTOCKARTCLISIT set NQTESTOK = {Utils.ZeroIfNull(row["NQTESTOK"])}" +
               $", NQTEMAG = {Utils.ZeroIfNull(row["NQTEMAG"])}" +
               $", NGESTSTOCKCLISIT ={row["NGESTSTOCKCLISIT"]}";
      }
      if (mstrStatut == "STOCK_TS") sSQL += $" WHERE NCLINUM = {miNumClient}"; // on applique les modifications à tous les sites
      else sSQL += $" WHERE NSITNUM = {miNumSite}";
      sSQL += $" AND NFOUNUM= {Utils.ZeroIfNull(row["NFOUNUM"])}";
      ModuleData.CnxExecute(sSQL);
    }

    //Public Sub enregLigne()
    //
    //Dim sSql As String
    //
    //    On Error Resume Next
    //
    //    ' insertion dans la table des stocks site
    //    If mstrStatut = "INV" Then
    //      sSql = "update TSTOCKARTCLISIT set NQTEINV = " & rsarticle("QteInv")
    //    Else
    //      sSql = "update TSTOCKARTCLISIT set NQTESTOK = " & rsarticle("QteStock")
    //      sSql = sSql & ", NQTEMAG = " & rsarticle("QteMag")
    //      sSql = sSql & ", NGESTSTOCKCLISIT = " & rsarticle("Gestion")
    //    End If
    //    If mstrStatut = "STOCK_TS" Then  ' on applique les modifications à tous les sites
    //      sSql = sSql & " WHERE NCLINUM = " & miNumClient
    //    Else
    //      sSql = sSql & " WHERE NSITNUM = " & miNumSite
    //    End If
    //    sSql = sSql & " AND NFOUNUM= " & rsarticle("NumArticle")
    //    cnx.Execute sSql
    //    
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub AjouterEnreg(ByVal rs As ADODB.Recordset)
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsarticle.AddNew
    //  
    //  rsarticle("Article").value = rs("VFOUMAT")
    //  rsarticle("Marque").value = BlankIfNull(rs("VFOUMAR"))
    //  rsarticle("Type").value = BlankIfNull(rs("VFOUTYP"))
    //  rsarticle("Reference").value = BlankIfNull(rs("VFOUREF"))
    //  rsarticle("PCB").value = ZeroIfNull(rs("NFOUNBLOT"))
    //  rsarticle("QteMag").value = ZeroIfNull(rs("NQTEMAG"))
    //  If mstrStatut = "STOCK_TS" Then
    //    rsarticle("QteStock").value = 0
    //  Else
    //    rsarticle("QteStock").value = ZeroIfNull(rs("NQTESTOK"))
    //  End If
    //  rsarticle("QteInv").value = ZeroIfNull(rs("NQTEINV"))
    //  rsarticle("NumArticle").value = rs("NFOUNUM")
    //  rsarticle("Gestion").value = rs("NGESTSTOCKCLISIT")
    //  
    //  rsarticle.Update
    //  
    //Exit Sub
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;

    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtdExec.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    //Private Sub Calendar1_Click()
    //
    //On Error GoTo handler
    //
    //  Me.txtdExec = Calendar1.value
    //  Calendar1.Visible = False
    //  
    //Exit Sub
    //handler:
    //  ShowError "Calendar1_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDate1_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtdExec.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, cmdDate1.Left, cmdDate1.Top, 0));
    }

    //Private Sub cmdDate1_Click()
    //  If Calendar1.Visible Then
    //      
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.value = Now
    //  End If
    //
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub CreationActionEtInventaire()
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //Dim rs As New ADODB.Recordset
    //Dim iAction As Long
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim cpt As Integer
    //Dim sMessage As String
    //  On Error GoTo handler
    //  
    //  'initialisation
    //  iAction = 0
    //
    //  cmdValider.Enabled = False
    //  cmdFermer.Enabled = False
    //  
    //  Me.SetFocus
    //  Screen.MousePointer = vbHourglass
    //  
    //           
    //'***************************************************************************************
    //' création d'une action de gestion de stock site
    //  
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "Api_sp_CreationActionFourniture"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //   
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iAction").value = glNumAction
    //  ado_cmd.Parameters("@vType").value = "INV"
    //  
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //  
    //  ' récupération du numéro crée
    //  iAction = ado_cmd.Parameters(0).value
    //    
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //
    //  ' gestion des erreurs
    //  If iAction = 0 Then
    //    MsgBox "Erreur lors de la creation de l'action d'inventaire", vbInformation
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //    
    //  '***************************************************************************************
    //  ' Enregistrement de l'inventaire dans la table TINV et TINVLIGNE
    //  cnx.Execute "exec api_sp_CreationInventaire " & iAction & "," & glNumAction
    //  
    //  
    //  '***************************************************************************************
    //  ' Remettre l'inventaire à zero
    //  cnx.Execute "update TSTOCKARTCLISIT set NQTEINV = 0 WHERE NSITNUM = " & miNumSite
    //    
    //
    //  Screen.MousePointer = vbDefault
    //  MsgBox "Inventaire enregistré", vbInformation
    //  
    //  cmdValider.Enabled = False
    //  cmdFermer.Enabled = True
    //    
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  cmdValider.Enabled = True
    //  cmdFermer.Enabled = True
    //  ShowError "CreationActionEtInventaire dans " & Me.Name
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationActionEtCommande(string sTypeCde, string sDateLivr)
    {
      try
      {
        // initialisation
        int iAction = 0;

        cmdValider.Enabled = cmdFermer.Enabled = false;

        Cursor.Current = Cursors.WaitCursor;

        //************************************************************************************
        // création d'une action de gestion de stock site
        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationActionFourniture", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@vType"].Value = "INV";

          cmd.ExecuteNonQuery();
          iAction = (int)cmd.Parameters[0].Value;
        }

        // gestion des erreurs
        if (iAction == 0)
        {
          MessageBox.Show(Resources.msg_errCreaActionFour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }
        string sMessage = Resources.msg_creaActionFour + "\r\n";

        //***************************************************************************************
        // création des commandes sur cette action
        // création des dde sur cette action
        // tout se passe dans la proc stock

        // passage du nom de la procédure stockée
        string sProcStockTemp = "api_sp_CreationDdeStock";
        if (sTypeCde == "CDE") sProcStockTemp = "api_sp_CreationCommandeStock";

        using (SqlCommand cmd = new SqlCommand(sProcStockTemp, MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iAction"].Value = iAction;
          cmd.Parameters["@dLivr"].Value = sDateLivr;

          cmd.ExecuteNonQuery();
        }

        //***************************************************************************************
        // Enregistrement de l'inventaire dans la table TINV et TINVLIGNE
        ModuleData.CnxExecute($"exec api_sp_CreationInventaire {iAction},{MozartParams.NumAction}");

        //***************************************************************************************
        // Remettre l'inventaire à zero
        ModuleData.CnxExecute($"update TSTOCKARTCLISIT set NQTEINV = 0 WHERE NSITNUM = {miNumSite}");

        sMessage += "Création du chiffrage de l'action\r\n";
        Cursor.Current = Cursors.Default;
        MessageBox.Show(sMessage, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        cmdValider.Enabled = false;
        cmdFermer.Enabled = true;
      }
      catch (Exception ex)
      {
        cmdValider.Enabled = cmdFermer.Enabled = true;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub CreationActionEtCommandes(ByVal TypeCde As String, ByVal DateLivr As String)
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //Dim rs As New ADODB.Recordset
    //Dim iAction As Long
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim cpt As Integer
    //Dim sMessage As String
    //' UPGRADE_INFO (#0501): The 'sSql' member isn't used anywhere in current application.
    //' Dim sSql As String
    //
    //  On Error GoTo handler
    //
    //  'initialisation
    //  iAction = 0
    //
    //  cmdValider.Enabled = False
    //  cmdFermer.Enabled = False
    //
    //  Me.SetFocus
    //  Screen.MousePointer = vbHourglass
    //
    //
    //'***************************************************************************************
    //' création d'une action de gestion de stock site
    //
    //  Set ado_cmd.ActiveConnection = cnx
    //
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "Api_sp_CreationActionFourniture"
    //  ado_cmd.CommandType = adCmdStoredProc
    //
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iAction").value = glNumAction
    //  ado_cmd.Parameters("@vType").value = "INV"
    //
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //
    //  ' récupération du numéro crée
    //  iAction = ado_cmd.Parameters(0).value
    //
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //
    //  ' gestion des erreurs
    //  If iAction = 0 Then
    //    MsgBox "§Erreur lors de la creation de l'action de fourniture§", vbInformation
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //
    //
    //  sMessage = "§Création d'une action de fourniture§" & vbCrLf
    //
    //'***************************************************************************************
    //' création des commandes sur cette action
    //' création des dde sur cette action
    //' tout se passe dans la proc stock
    //  Set ado_cmd.ActiveConnection = cnx
    //
    //  ' passage du nom de la procédure stockée
    //  If TypeCde = "CDE" Then
    //    ado_cmd.CommandText = "api_sp_CreationCommandeStock"
    //  Else
    //    ado_cmd.CommandText = "api_sp_CreationDdeStock"
    //  End If
    //  ado_cmd.CommandType = adCmdStoredProc
    //
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iAction").value = iAction
    //  ado_cmd.Parameters("@dLivr").value = DateLivr
    //
    //  ' exécuter la commande.
    //  ado_cmd.Execute
    //
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //
    //'***************************************************************************************
    //' création du chiffrage de l'action pour le client
    //' tous se passe dans la proc stock
    //'  If TypeCde = "CDE" Then
    //'    cnx.Execute "exec api_sp_CreationChiffrageCDE " & iAction
    //'  Else
    //'    cnx.Execute "exec api_sp_CreationChiffrageStock " & iAction
    //'  End If
    //
    //'***************************************************************************************
    //' Enregistrement de l'inventaire dans la table TINV et TINVLIGNE
    //  cnx.Execute "exec api_sp_CreationInventaire " & iAction & "," & glNumAction
    //
    //
    //'***************************************************************************************
    //' Remettre l'inventaire à zero
    //  cnx.Execute "update TSTOCKARTCLISIT set NQTEINV = 0 WHERE NSITNUM = " & miNumSite
    //
    //
    //  sMessage = sMessage & "Création du chiffrage de l'action" & vbCrLf
    //  Screen.MousePointer = vbDefault
    //  MsgBox sMessage, vbInformation
    //
    //  cmdValider.Enabled = False
    //  cmdFermer.Enabled = True
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  cmdValider.Enabled = True
    //  cmdFermer.Enabled = True
    //  ShowError "CreationActionEtCommandes dans " & Me.Name
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void imgInfo_Click(object sender, EventArgs e)
    {
      string msg = $"{Resources.msg_calculStockMiniAutoCochCaseAuto}\r\n" +
                   $"{Resources.msg_fourniturePlusGereeSite}\r\n" +
                   $"{Resources.msg_verifPresenteListe}\r\n" +
                   $"{Resources.msg_decocheCaseModifierStockmini}\r\n" +
                   $"{Resources.msg_calculautoPrisEnCompte}\r\n";

      MessageBox.Show(msg, Resources.msg_gestionAutoStockMini, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    //Private Sub imgInfo_Click()
    //Dim msg As String
    //
    //    msg = "§Pour le calcul du stock mini automatique, cocher la case Auto.§" & vbCrLf _
    //    & "§Si une fourniture n'est pas/plus gérée sur le site, décocher cette case et modifier le 'stock mini' à 0§" & vbCrLf _
    //    & "§Lors d'un inventaire, si une fourniture ne s'affiche pas, vérifier que celle-ci est présente dans la liste et a un 'stock mini' supérieur à 0.§" & vbCrLf _
    //    & "§Sinon, décocher la case et modifier le 'stock mini' à une valeur supérieure à 0§" & vbCrLf _
    //    & "
    //    "
    //
    //    MsgBox msg, vbInformation, "§Gestion automatique du stock mini§"
    //
    //End Sub
    //
    //
    //'Private Sub CreationInventaireMail(rsReappro As ADODB.Recordset)
    //'Dim ado_cmd As New ADODB.Command
    //'Dim iAction As Long
    //'Dim sSql As String
    //'Dim sMsg As String
    //'' UPGRADE_INFO (#0501): The 'sLigneMsg' member isn't used anywhere in current application.
    //'' Dim sLigneMsg As String
    //'' UPGRADE_INFO (#0501): The 'bOK' member isn't used anywhere in current application.
    //'' Dim bOK As Boolean
    //'
    //'  On Error GoTo handler
    //'
    //'  'initialisation
    //'  iAction = 0
    //'
    //'  cmdValider.Enabled = False
    //'  cmdFermer.Enabled = False
    //'
    //'  Me.SetFocus
    //'  Screen.MousePointer = vbHourglass
    //'
    //'  '***************************************************************************************
    //'' création d'une action de gestion de stock site
    //'
    //'  Set ado_cmd.ActiveConnection = cnx
    //'
    //'  ' passage du nom de la procédure stockée
    //'  ado_cmd.CommandText = "Api_sp_CreationActionFourniture"
    //'  ado_cmd.CommandType = adCmdStoredProc
    //'
    //'  ' passage des paramètres
    //'  ado_cmd.Parameters.Refresh
    //'
    //'   ' liste des paramètres
    //'  ado_cmd.Parameters("@iAction").value = glNumAction
    //'  ado_cmd.Parameters("@vType").value = "INV"
    //'
    //'  ' exécuter la commande.
    //'  ado_cmd.Execute
    //'
    //'  ' récupération du numéro crée
    //'  iAction = ado_cmd.Parameters(0).value
    //'
    //'  ' libération de la commande
    //'  Set ado_cmd = Nothing
    //'
    //'  ' gestion des erreurs
    //'  If iAction = 0 Then
    //'    MsgBox "§Erreur lors de la creation de l'action de fourniture§", vbInformation
    //'    Screen.MousePointer = vbDefault
    //'    Exit Sub
    //'  End If
    //'
    //'  '***************************************************************************************
    //'  ' Enregistrement de l'inventaire dans la table TINV et TINVLIGNE
    //'  cnx.Execute "exec api_sp_CreationInventaire " & iAction & "," & glNumAction
    //'
    //'
    //'  '***************************************************************************************
    //'  ' Remettre l'inventaire à zero
    //'  cnx.Execute "update TSTOCKARTCLISIT set NQTEINV = 0 WHERE NSITNUM = " & miNumSite
    //'
    //'  If rsReappro.RecordCount > 0 Then
    //'
    //'    ' On envoie le mail que si il y a des articles à commander
    //'    '***************************************************************************************
    //'    ' envoie d'un mail contenant les qté a commander
    //'    sMsg = "§Bonjour, §" & vbCrLf _
    //'        & "§Suite à l''inventaire du stock de fournitures le §" & CStr(Date) & "§, les matériel suivants sont à réapprovisionner par vos soins :§" & vbCrLf & vbCrLf _
    //'        & "§Qté  §" & "§Matériel§" & vbCrLf & vbCrLf
    //'
    //'    rsReappro.MoveFirst
    //'    While Not rsReappro.EOF
    //'      sMsg = sMsg & rsReappro!QTESS & String(5 - Len(rsReappro!QTESS), " ") & " " & rsReappro!VFOUMAT & vbCrLf
    //'      rsReappro.MoveNext
    //'    Wend
    //'
    //'    sMsg = sMsg & vbCrLf & "Cordialement," & vbCrLf & gstrNomSociete
    //'
    //'    sSql = "EXEC msdb..sp_send_dbmail "
    //'    sSql = sSql & "@profile_name = 'Web" & gstrNomSociete & "', "
    //'    sSql = sSql & "@recipients = 'denisbl@fr.inditex.com;vincentbi@fr.inditex.com', "
    //'    sSql = sSql & "@body = '" & sMsg & "',"
    //'    sSql = sSql & "@subject = '§Réapprovisionnement stock suite à inventaire §" & BlankIfNull(adoRS("VCLINOM")) & "/SITE : " & BlankIfNull(adoRS("NSITNUE")) & " - " & Replace(BlankIfNull(adoRS("VSITNOM")), "'", "''") & "'"
    //'    ' TB SAMSIC CITY SPEC
    //'    If gstrNomGroupe = "EMALEC" Then
    //'      sSql = sSql & ",@blind_copy_recipients = 'info@emalec.com;smendes@emalec.com' "
    //'    End If
    //'
    //'    cnx.Execute sSql
    //'  End If
    //'
    //'  ' on passe l'action de gestion de stock à NF
    //'  cnx.Execute "api_sp_PasserStatutAdminF " & iAction
    //'
    //'  Screen.MousePointer = vbDefault
    //'
    //'  cmdValider.Enabled = False
    //'  cmdFermer.Enabled = True
    //'
    //'Exit Sub
    //'Resume
    //'handler:
    //'  Screen.MousePointer = vbDefault
    //'  cmdValider.Enabled = True
    //'  cmdFermer.Enabled = True
    //'  ShowError "CreationInventaireMail dans " & Me.Name
    //'End Sub
    //'

  }
}

