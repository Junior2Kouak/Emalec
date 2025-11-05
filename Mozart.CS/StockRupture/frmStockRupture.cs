using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlClient;
using MozartNet;
using MozartCS.Properties;
using MozartLib;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockRupture : Form
  {
    public int miNumSiteFournisseur;
    public string msNomSiteFournisseur;

    private DataTable dtArticleH = new DataTable();
    private DataTable dtArticleB = new DataTable();

    private int iNumCom;
    private int iCte;

    //Dim rsArt As ADODB.Recordset
    //Public miNumSiteFournisseur As Long
    //Public msNomSiteFournisseur As String
    //
    //Dim iNumCom As Long
    //Dim miCte As Integer

    public frmStockRupture() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmStockRupture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //string sSql = $"select 0, ' MAGASIN' as VPERNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = '{MozartParams.NomSociete}' " +
        //$"AND CPERTYP='TE' AND CPERACTIF = 'O' ORDER BY  VPERNOM";
        //cboTech.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, bHideFirstColumn: true);

        InitDataTableArticle();
        InitapiGridB();

        //cboTech.Text = " MAGASIN";
        InitapiGridH();

        // Pour déclencher le remplissage de la liste du haut
        remplirGrilleH();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub Form_Load()
    //
    //  InitBoutons Me, frmMenu
    //  
    //  cboTech.SizeCombo 600
    //  cboTech.Clear
    //  
    //  If UCase(gstrNomSociete) = "SCS" Then
    //    cmdSCS.Enabled = False
    //  ElseIf UCase(gstrNomSociete) = "FITELEC" Then
    //    cmdFitelec.Enabled = False
    //  Else
    //    cmdSCS.Enabled = False
    //    cmdFitelec.Enabled = False
    //  End If
    //
    //  RemplirCombo cboTech, "select 0, ' MAGASIN' as VPERNOM UNION SELECT NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = '" & gstrNomSociete & "' AND CPERTYP='TE' AND CPERACTIF = 'O' ORDER BY  VPERNOM", False
    //
    //  InitRecordsetArticle
    //  InitapiGridB
    //    
    //  cboTech.Text = " MAGASIN"
    //  InitapiGridH
    //End Sub

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCocher_Click(object sender, EventArgs e)
    {
      if (cmdCocher.Text == Resources.txt_DecocherTous)
        cmdCocher.Text = Resources.txt_CocherTous;
      else
        cmdCocher.Text = Resources.txt_DecocherTous;

      foreach (DataRow row in dtArticleH.Rows)
        row["CHECK"] = (cmdCocher.Text == Resources.txt_DecocherTous);
    }
    //Private Sub cmdCocher_Click()
    //
    //On Error GoTo handler
    //   
    //  rsArt.MoveFirst
    //  
    //  If cmdCocher.Caption = "§Décocher tous§" Then
    //    While Not rsArt.EOF
    //      rsArt.Update "CHECK", 0
    //      rsArt.MoveNext
    //    Wend
    //    cmdCocher.Caption = "§Cocher tous§"
    //  Else
    //    While Not rsArt.EOF
    //      rsArt.Update "CHECK", 1
    //      rsArt.MoveNext
    //    Wend
    //    cmdCocher.Caption = "§Décocher tous§"
    //  End If
    //  
    //  rsArt.MoveFirst
    //    
    //Exit Sub
    //handler:
    //  ShowError " cmdCocher_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdGenerer_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      CreationDesCommandes();

      Cursor.Current = Cursors.Default;

      MessageBox.Show(Resources.txt_commandes_creees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      // rafraichissement de la liste
      //InitRecordsetArticle
      //apiTGridB.Init rsarticle, True
      //cboTech.Text = " MAGASIN";
      //apiTGridH.Init rsArt, True

      cmdCommandes_Click(null, null);
      cmdAjouter.Enabled = true;
    }
    //Private Sub CmdGenerer_Click()
    //  Screen.MousePointer = vbHourglass
    //  CreationDesCommandes
    //  Screen.MousePointer = vbDefault
    //  MsgBox "§Les commandes ont été créées§"
    //   
    //  
    //  ' rafraichissement de la liste
    //  InitRecordsetArticle
    //  apiTGridB.Init rsarticle, True
    //  cboTech.Text = " MAGASIN"
    //  apiTGridH.Init rsArt, True
    //  
    //  cmdCommandes_Click
    //  cmdAjouter.Enabled = True
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdEmalec_Click(object sender, EventArgs e)
    {
      iCte = 995;

      Cursor.Current = Cursors.WaitCursor;
      CreationCommandeEmalec();

      Cursor.Current = Cursors.WaitCursor;
      CreationDiActionDDeFacture();

      Cursor.Current = Cursors.Default;

      MessageBox.Show(Resources.txt_commandes_creees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      cmdCommandes_Click(null, null);
      cmdAjouter.Enabled = true;
    }
    //Private Sub cmdEmalec_Click()
    //  miCte = 995
    //  Screen.MousePointer = vbHourglass
    //  Call CreationCommandeEmalec
    //  Screen.MousePointer = vbHourglass
    //  Call CreationDiActionDDeFacture
    //  Screen.MousePointer = vbDefault
    //  MsgBox "§Les commandes ont été créées§"
    //  cmdCommandes_Click
    //  cmdAjouter.Enabled = True
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationDiActionDDeFacture()
    {
      try
      {
        //  Création d'une DI, d'une action, d'une sortie de stock, du chiffrage et de la facture sur la base Emalec pour la commande filiale
        ModuleData.ExecuteNonQuery($"api_sp_CreationDIActionCmdEmalec {iNumCom}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub CreationDiActionDDeFacture()
    //
    //  On Error GoTo handler
    //  
    //  ' création d'une DI, d'une action, d'une sortie de stock, du chiffrage et de la facture sur la base Emalec pour la commande filiale
    //  cnx.Execute "Api_sp_CreationDIActionCmdEmalec " & iNumCom
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " cmdValider_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCommandes_Click(object sender, EventArgs e)
    {
      // "R" => commande Réappro
      new frmListeCommandesFour() { mstrStatutCom = "R" }.ShowDialog();
    }
    //Private Sub cmdCommandes_Click()
    // ' glNumAction = 99729     ' c'est le nactnum de la di de commande des réappro DI 43787
    //  frmListeCommandesFour.mstrStatutCom = "R"   ' commande Réappro
    //  'frmListeCommandesFour.miNumFO = 0
    //  frmListeCommandesFour.Show vbModal
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression de la ligne courante
        DataRow row = apiTGridB.GetFocusedDataRow();
        if (row == null) return;

        row.Delete();
        dtArticleH.AcceptChanges();

        CalculerTOTAUX();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupp_Click()
    //  On Error Resume Next
    //  If rsarticle.RecordCount > 0 Then rsarticle.Delete
    //  apiTGridB.Init rsarticle, True
    //  CalculerTOTAUX
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void remplirGrilleH()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        apiTGridH.LoadData(dtArticleH, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeStockRupture 0");
        apiTGridH.GridControl.DataSource = dtArticleH;

        // calcul du total grille haut
        double tot = 0;
        foreach (DataRow row in dtArticleH.Rows)
          tot += Convert.ToDouble(row["PRIX"]) * Convert.ToDouble(row["NB"]);

        txtTotal.Text = tot.ToString("0.00 €");

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub cboTech_Click()
    //Dim sFile As String
    //Dim tot As Double
    //  Screen.MousePointer = vbHourglass
    //  Set rsArt = New ADODB.Recordset
    //  rsArt.Open "EXEC api_sp_ListeStockRupture " & cboTech.ItemData(cboTech.ListIndex), cnx
    //  sFile = gstrCheminUtilisateur & "\mozart\ListeRupt.tmp"
    //  On Error Resume Next
    //  Kill sFile
    //  rsArt.Save sFile
    //  rsArt.Close
    //  
    //  Set rsArt = New ADODB.Recordset
    //  rsArt.Open sFile, , adOpenKeyset, adLockOptimistic
    //  apiTGridH.Init rsArt, True
    //  
    //  tot = 0
    //  ' calcul du total grille haut
    //  If rsArt.RecordCount > 0 Then
    //  rsArt.MoveFirst
    //  While Not rsArt.EOF
    //    tot = tot + (rsArt("PRIX") * rsArt("NB"))
    //    rsArt.MoveNext
    //  Wend
    //  rsArt.MoveFirst
    //  End If
    //  txtTotal = CStr(tot)
    //  
    //  Screen.MousePointer = vbDefault
    //End Sub



    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub apiTGridH_ButtonClick(ColIndex As Integer)
    //  If rsArt!Nb > 1 Then
    //  Dim rsF As New ADODB.Recordset
    //  Set rsF = cnx.Execute("EXEC api_sp_ListePrixFourniture " & rsArt!NFOUNUM)
    //  Set dbGrid.DataSource = rsF
    //  dbGrid.Columns(1).Visible = False
    //  Frame1.Top = apiTGridH.Rowtop + apiTGridH.Top
    //  Frame1.Visible = True
    //  End If
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    private void apiTGridH_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (e.Column.Name == "VSTFGRPNOM")
        {
          if (View.GetDataRow(e.RowHandle)["NB"].ToString() != "1")
            e.Appearance.BackColor = Color.White;
        }
        if (e.Column.Name == "MAXI")
        {
          if (View.GetDataRow(e.RowHandle)["MAXI"].ToString() == "")
            e.Appearance.BackColor = Color.Red;
        }
      }
    }
    //Private Sub apiTGridH_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  If DataField <> "VSTFGRPNOM" Then Exit Sub
    //  If Cols(apiTGridH.ColField("NB")).CellText(BookMark) <> "1" Then CellStyle.BackColor = &H80FF&                ' Vert pale
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        if (Verifs() == false)
          MessageBox.Show(Resources.txt_liste_avec_article_sans_quantite_maxi + "\r\nLa quantité à commander sera initialisée à la valeur du PCB", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        bool bOK = false;
        bool bSelect = false;
        List<DataRow> lstRowToDelete = new List<DataRow>();

        foreach (DataRow rowH in dtArticleH.Rows)
        {
          if (rowH["CHECK"].ToString() != "0")
          {
            bSelect = true;
            bOK = false;

            // Recherche si fournisseur pas déjà traité
            foreach (DataRow rowB in dtArticleB.Rows)
            {
              if (Convert.ToInt32(rowB["NumArticle"]) == Convert.ToInt32(rowH["NFOUNUM"]))
                bOK = true;

              if (Convert.ToInt32(rowB["NumFour"]) == Convert.ToInt32(rowH["NSTFGRPNUM"]))
              {
                bSelect = false;
                miNumSiteFournisseur = (int)rowB["NumSiteFour"];
                msNomSiteFournisseur = (string)rowB["Fournisseur"];
              }
            }

            DataTable dtSites = new DataTable();

            if (!bOK && bSelect)
            {
              miNumSiteFournisseur = 0;
              msNomSiteFournisseur = "";

              SqlDataReader dr = ModuleData.ExecuteReader($"SELECT DISTINCT NSTFNUM, VSTFNOM FROM TSTF WHERE NSTFGRPNUM = {rowH["NSTFGRPNUM"]}");
              dtSites.Load(dr);
              if (dtSites.Rows.Count > 0)
              {
                miNumSiteFournisseur = (int)dtSites.Rows[0]["NSTFNUM"];
                msNomSiteFournisseur = (string)dtSites.Rows[0]["VSTFNOM"];
              }
            }

            if (bSelect && dtSites.Rows.Count > 1)
            {
              frmSelectionSiteFour f = new frmSelectionSiteFour();
              f.miNumSiteFournisseur = miNumSiteFournisseur;
              f.msNomSiteFournisseur = msNomSiteFournisseur;
              f.miFournisseur = Convert.ToInt32(rowH["NSTFGRPNUM"]);
              f.ShowDialog();

              miNumSiteFournisseur = f.miNumSiteFournisseur;
              msNomSiteFournisseur = f.msNomSiteFournisseur;
            }

            if (miNumSiteFournisseur != 0)
            {
              AjouterEnreg(rowH);
              lstRowToDelete.Add(rowH);  // Pour ne pas modifier la collection
            }
            else
              rowH["CHECK"] = 0;
          }
        }

        foreach (var item in lstRowToDelete)
        {
          dtArticleH.Rows.Remove(item);  // Faire disparaitre de la liste du haut
          dtArticleH.AcceptChanges();
        }

        CalculerTOTAUX();
        cmdAjouter.Enabled = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdAjouter_Click()
    //Dim rsSites As ADODB.Recordset
    //
    //  If Verifs = False Then
    //    MsgBox "§La liste contient des articles pour lesquels les quantités maxi ne sont pas renseignées !§" & vbCrLf & _
    //    "La quantité à commander sera initialisée à la valeur du PCB", vbExclamation
    //  End If
    //  
    //  Dim bOK As Boolean
    //  Dim bSelect As Boolean
    //  
    //  On Error Resume Next
    //  rsArt.MoveFirst
    //  On Error GoTo handler
    //  
    //  While Not rsArt.EOF
    //    If rsArt!Check <> 0 Then
    //      
    //      ' Recherche si fournisseur pas déjà traité
    //      bSelect = True
    //      bOK = False
    //      
    //      If rsarticle.RecordCount > 0 Then
    //        rsarticle.MoveFirst
    //        While Not rsarticle.EOF
    //          If rsarticle("NumArticle") = rsArt("NFOUNUM").value Then bOK = True
    //          If rsarticle("NumFour") = rsArt("NSTFGRPNUM") Then
    //            bSelect = False
    //            miNumSiteFournisseur = rsarticle("NumSiteFour")
    //            msNomSiteFournisseur = rsarticle("Fournisseur")
    //          End If
    //          rsarticle.MoveNext
    //        Wend
    //      End If
    //      
    //      If Not bOK And bSelect Then
    //        miNumSiteFournisseur = 0
    //        Set rsSites = New ADODB.Recordset
    //        rsSites.Open "SELECT DISTINCT NSTFNUM, VSTFNOM FROM TSTF WHERE NSTFGRPNUM = " & rsArt("NSTFGRPNUM"), cnx
    //        miNumSiteFournisseur = rsSites!NSTFNUM
    //        msNomSiteFournisseur = rsSites!VSTFNOM
    //      End If
    //      
    //      If bSelect And rsSites.RecordCount > 1 Then
    //        Set frmSelectionSiteFour.frmAppelante = Me
    //        frmSelectionSiteFour.miFournisseur = rsArt("NSTFGRPNUM")
    //        frmSelectionSiteFour.Show vbModal
    //        Me.Refresh
    //      End If
    //        
    //      If miNumSiteFournisseur <> 0 Then
    //        Call AjouterEnreg
    //        rsArt.Delete      ' Faire disparaitre de la liste du haut
    //      Else
    //         rsArt!Check = 0
    //      End If
    //    End If
    //    rsArt.MoveNext
    //  Wend
    //  
    //  
    //  CalculerTOTAUX
    //  cmdAjouter.Enabled = False
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "cmdAjouter dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private bool Verifs()
    {
      bool bReturn = true;

      foreach (DataRow rowH in dtArticleH.Rows)
      {
        if (rowH["CHECK"].ToString() != "0" && Utils.ZeroIfNull(rowH["MAXI"]) < 1)
        {
          bReturn = false;
          break;
        }
      }

      return bReturn;
    }
    //Function Verifs() As Boolean
    //On Error Resume Next
    //  Verifs = True
    //  rsArt.MoveFirst
    //  While Not rsArt.EOF
    //    If rsArt!Check <> 0 And ZeroIfNull(rsArt!maxi) < 1 Then
    //      Verifs = False
    //      Exit Function
    //    End If
    //    rsArt.MoveNext
    //  Wend
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private void AjouterEnreg(DataRow rowH)
    {
      try
      {
        int aux = 0;
        DataRow newRow = dtArticleB.NewRow();
        newRow["Serie"] = rowH["VFOUSER"];
        newRow["Article"] = rowH["VFOUMAT"];
        newRow["Marque"] = Utils.BlankIfNull(rowH["VFOUMAR"]);
        newRow["Type"] = Utils.BlankIfNull(rowH["VFOUTYP"]);
        newRow["Reference"] = Utils.BlankIfNull(rowH["VFOUREF"]);
        newRow["Prix U"] = Utils.ZeroIfNull(rowH["PRIX"]);
        newRow["NumFour"] = rowH["NSTFGRPNUM"];
        newRow["NumArticle"] = rowH["NFOUNUM"];

        // quantite a commander multiple du lot
        // cas normal commande de MAXI - quantité en stock en tenant compte du PCB sinon même chose avec MINI
        int mini = (int)Utils.ZeroIfNull(rowH["MINI"]);
        int maxi = (int)Utils.ZeroIfNull(rowH["MAXI"]);
        int nbLot = (int)Utils.ZeroIfNull(rowH["NFOUNBLOT"]);
        int qte = Convert.ToInt32(rowH["QTE"]);

        if (maxi == 0)
          aux = nbLot * ((mini % nbLot == 0) ? mini / nbLot : (mini / nbLot) + 1);
        else
          aux = nbLot * (((maxi - qte) % nbLot == 0) ? (maxi - qte) / nbLot : ((maxi - qte) / nbLot) + 1);

        newRow["Quantite"] = aux;
        newRow["Prix T"] = aux * Utils.ZeroIfNull(rowH["PRIX"]);
        newRow["PCB"] = nbLot;
        newRow["NumSiteFour"] = miNumSiteFournisseur;
        newRow["Fournisseur"] = msNomSiteFournisseur;

        dtArticleB.Rows.Add(newRow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub AjouterEnreg()
    //
    //Dim aux As Long
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsarticle.AddNew
    //  
    //  rsarticle("Serie").value = rsArt("VFOUSER")
    //  rsarticle("Article").value = rsArt("VFOUMAT")
    //  rsarticle("Marque").value = BlankIfNull(rsArt("VFOUMAR"))
    //  rsarticle("Type").value = BlankIfNull(rsArt("VFOUTYP"))
    //  rsarticle("Reference").value = BlankIfNull(rsArt("VFOUREF"))
    //  rsarticle("Prix U").value = ZeroIfNull(rsArt("PRIX"))
    //  rsarticle("NumFour").value = rsArt("NSTFGRPNUM")
    //  rsarticle("NumArticle").value = rsArt("NFOUNUM")
    //  
    //  'quantite a commander multiple du lot
    //  ' cas normal commande de MAXI - quantité en stock en tenant compte du PCB sinon même chose avec MINI
    //  If IsNull(rsArt("MAXI")) Then
    //    aux = rsArt("NFOUNBLOT") * IIf(rsArt("MINI") Mod rsArt("NFOUNBLOT") = 0, rsArt("MINI") \ rsArt("NFOUNBLOT"), (rsArt("MINI") \ rsArt("NFOUNBLOT")) + 1)
    //  Else
    //    aux = rsArt("NFOUNBLOT") * IIf((rsArt("MAXI") - rsArt("QTE")) Mod rsArt("NFOUNBLOT") = 0, (rsArt("MAXI") - rsArt("QTE")) \ rsArt("NFOUNBLOT"), ((rsArt("MAXI") - rsArt("QTE")) \ rsArt("NFOUNBLOT")) + 1)
    //  End If
    //  
    //  rsarticle("Quantite").value = aux
    //  rsarticle("Prix T").value = rsarticle("Quantite").value * ZeroIfNull(rsArt("PRIX"))
    //  rsarticle("PCB").value = ZeroIfNull(rsArt("NFOUNBLOT"))
    //  rsarticle("NumSiteFour").value = miNumSiteFournisseur
    //  rsarticle("Fournisseur").value = msNomSiteFournisseur
    //  
    //  rsarticle.Update
    //  
    //  'FormatGridArticle
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitDataTableArticle()
    {
      dtArticleB.Columns.Add("Serie", typeof(string));
      dtArticleB.Columns.Add("Article", typeof(string));
      dtArticleB.Columns.Add("Marque", typeof(string));
      dtArticleB.Columns.Add("Type", typeof(string));
      dtArticleB.Columns.Add("Reference", typeof(string));
      dtArticleB.Columns.Add("PCB", typeof(int));
      dtArticleB.Columns.Add("Prix U", typeof(double));
      dtArticleB.Columns.Add("Quantite", typeof(int));
      dtArticleB.Columns.Add("Prix T", typeof(double));
      dtArticleB.Columns.Add("Fournisseur", typeof(string));
      dtArticleB.Columns.Add("NumArticle", typeof(int));
      dtArticleB.Columns.Add("NumFour", typeof(int));
      dtArticleB.Columns.Add("NumSiteFour", typeof(int));
    }
    //Public Sub InitRecordsetArticle()
    //
    //On Error GoTo handler
    //
    //' initialisation du tableau de recherche des articles
    //  Set rsarticle = New ADODB.Recordset
    //  
    //  ' ajout des champs au recordset
    //  rsarticle.Fields.Append "Serie", adVarChar, 100
    //  rsarticle.Fields.Append "Article", adVarChar, 150
    //  rsarticle.Fields.Append "Marque", adVarChar, 150
    //  rsarticle.Fields.Append "Type", adVarChar, 2000
    //  rsarticle.Fields.Append "Reference", adVarChar, 150
    //  rsarticle.Fields.Append "PCB", adInteger
    //  rsarticle.Fields.Append "Prix U", adDouble
    //  rsarticle.Fields.Append "Quantite", adInteger
    //  rsarticle.Fields.Append "Prix T", adDouble
    //  rsarticle.Fields.Append "Fournisseur", adVarChar, 150
    //  rsarticle.Fields.Append "NumArticle", adInteger
    //  rsarticle.Fields.Append "NumFour", adInteger
    //  rsarticle.Fields.Append "NumSiteFour", adInteger
    //  
    //  rsarticle.Open , , adOpenDynamic, adLockOptimistic
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitapiGridH()
    {
      apiTGridH.AddColumn("FouNum", "NFOUNUM", 0);
      apiTGridH.AddColumn("§Lieu§", "VPERNOM", 0);
      apiTGridH.AddColumn("§Lieu§", "NSTOCKLIEU", 0);
      apiTGridH.AddColumn("§Série§", "VFOUSER", 0);
      apiTGridH.AddColumn(Resources.col_Article, "VFOUMAT", 4800, "", 0, true);      // <= AddCellTip
      apiTGridH.AddColumn(Resources.col_marque, "VFOUMAR", 1200, "", 0, true);      // <= AddCellTip
      apiTGridH.AddColumn(Resources.col_Type, "VFOUTYP", 1200, "", 0, true);      // <= AddCellTip
      apiTGridH.AddColumn(Resources.col_reference, "VFOUREF", 1200, "", 0, true);      // <= AddCellTip
      apiTGridH.AddColumn(Resources.col_qte2, "Qte", 550, "", 2);
      apiTGridH.AddColumn(Resources.col_mini, "MINI", 550, "", 2);
      apiTGridH.AddColumn(Resources.col_maxi, "MAXI", 550, "", 2);
      apiTGridH.AddColumn("NumStf", "NSTFGRPNUM", 0);
      apiTGridH.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 1600, "", 0, false, true);
      apiTGridH.AddColumn(Resources.col_prixU, "PRIX", 900, "0.000", 1);
      apiTGridH.AddColumn("§NB§", "NB", 0);
      apiTGridH.AddColumn(Resources.col_Emplacement, "VFOUEMPLACEMENT", 1000);
      apiTGridH.AddColumn(Resources.col_dernier_inventaire, "DINV", 1000, "dd/mm/yyyy", 2);

      //apiTGridH.AddCellStyle "VSTFGRPNOM", "", &HCCCCCC, vbWhite 
      //apiTGridH.AddCellStyle "MAXI", "", &HCCCCCC, vbRed
      apiTGridH.InitColumnList();

      apiTGridH.dgv.OptionsSelection.MultiSelect = true;
      apiTGridH.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
      apiTGridH.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
      apiTGridH.dgv.OptionsSelection.CheckBoxSelectorField = "CHECK";
    }
    //Private Sub InitapiGridH()
    //  On Error GoTo handler
    //
    //  apiTGridH.AddColumn " ", "CHECK", 300, , , , , True
    //  apiTGridH.AddColumn "FouNum", "NFOUNUM", 0
    //  apiTGridH.AddColumn "§Lieu§", "VPERNOM", 0
    //  apiTGridH.AddColumn "§Lieu§", "NSTOCKLIEU", 0
    //  apiTGridH.AddColumn "§Série§", "VFOUSER", 0
    //  apiTGridH.AddColumn "§Article§", "VFOUMAT", 4800
    //  apiTGridH.AddColumn "§Marque§", "VFOUMAR", 1200
    //  apiTGridH.AddColumn "§Type§", "VFOUTYP", 1200
    //  apiTGridH.AddColumn "§Référence§", "VFOUREF", 1200
    //  apiTGridH.AddColumn "§Qte§", "QTE", 550, , 2
    //'apiTGridH.AddColumn "§QteA§", "QteAttendue", 550, , 2
    //  apiTGridH.AddColumn "§Mini§", "MINI", 550, , 2
    //  apiTGridH.AddColumn "§Maxi§", "MAXI", 550, , 2
    //  apiTGridH.AddColumn "NumStf", "NSTFGRPNUM", 0
    //  apiTGridH.AddColumn "§Fournisseur§", "VSTFGRPNOM", 1600, , , , True
    //  apiTGridH.AddColumn "§Prix/U§", "PRIX", 900, "0.000", 1
    //  apiTGridH.AddColumn "§NB§", "NB", 0
    //  apiTGridH.AddColumn "Emplacement", "VFOUEMPLACEMENT", 1000
    //  apiTGridH.AddColumn "§Dernier inventaire§", "DINV", 1000, "dd/mm/yy", 2
    //  
    //  apiTGridH.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiTGridH.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiTGridH.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiTGridH.AddCellTip "VFOUREF", &HFDF0DA
    //  
    //  apiTGridH.AddCellStyle "VSTFGRPNOM", "", &HCCCCCC, vbWhite
    //  apiTGridH.AddCellStyle "MAXI", "", &HCCCCCC, vbRed
    //  
    //  'apiTGridH.DelockColumn "CHECK"  ' automatique dans le cas d'une checkbox
    //  apiTGridH.Init rsArt
    //  
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApiapiTGridHH dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitapiGridB()
    {
      try
      {
        apiTGridB.AddColumn(Resources.col_Serie, "Serie", 1000);
        apiTGridB.AddColumn(Resources.col_Article, "Article", 5000);
        apiTGridB.AddColumn(Resources.col_marque, "Marque", 1200);
        apiTGridB.AddColumn(Resources.col_Type, "Type", 1200);
        apiTGridB.AddColumn(Resources.col_reference, "Reference", 1200);
        apiTGridB.AddColumn(Resources.col_pcb, "PCB", 750, "", 2);
        apiTGridB.AddColumn(Resources.col_prixU, "Prix U", 900, "0.000", 2);
        apiTGridB.AddColumn(Resources.col_qte3, "Quantite", 550, "", 2);
        apiTGridB.AddColumn(Resources.col_prixT, "Prix T", 0);
        apiTGridB.AddColumn(Resources.col_Fournisseur, "Fournisseur", 1400);
        apiTGridB.AddColumn("NumArticle", "NumArticle", 0);
        apiTGridB.AddColumn("NumFour", "NumFour", 0);
        apiTGridB.AddColumn("NumSiteFour", "NumSiteFour", 0);

        apiTGridB.DelockColumn("Quantite");

        //  apiTGridB.AddCellStyle "Quantite", "0", &HCCCCCC, vbRed

        apiTGridB.GridControl.DataSource = dtArticleB;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitapiGridB()
    //  On Error GoTo handler
    //
    //  apiTGridB.AddColumn "§Serie§", "Serie", 1000
    //  apiTGridB.AddColumn "§Article§", "Article", 5000
    //  apiTGridB.AddColumn "§Marque§", "Marque", 1200
    //  apiTGridB.AddColumn "§Type§", "Type", 1200
    //  apiTGridB.AddColumn "§Reference§", "Reference", 1200
    //  apiTGridB.AddColumn "§PCB§", "PCB", 750, , 2
    //  apiTGridB.AddColumn "§Prix U§", "Prix U", 900, "0.000", 2
    //  apiTGridB.AddColumn "§Qte§", "Quantite", 550, , 2
    //  apiTGridB.AddColumn "§Prix T§", "Prix T", 0
    //  apiTGridB.AddColumn "§Fournisseur§", "Fournisseur", 1400
    //  apiTGridB.AddColumn "§NumArticle§", "NumArticle", 0
    //  apiTGridB.AddColumn "§NumFour§", "NumFour", 0
    //  apiTGridB.AddColumn "§NumSiteFour§", "NumSiteFour", 0
    //  
    //  apiTGridB.DelockColumn "Quantite"
    //  
    //  apiTGridB.AddCellStyle "Quantite", "0", &HCCCCCC, vbRed
    //  
    //  apiTGridB.FilterBar = False
    //  apiTGridB.Init rsarticle
    //  Exit Sub
    //
    //handler:
    //  ShowError "InitApiapiTGridBH dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridB_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "Quantite")
      {
        e.Appearance.ForeColor = Color.Red;
        e.Appearance.BackColor = Color.White;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }
    //Private Sub apiTGridB_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  CellStyle.Font.Bold = True
    //  CellStyle.ForeColor = vbRed
    //  CellStyle.BackColor = vbWhite
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationDesCommandes()
    {
      try
      {
        // traitement à part des articles d'outillage
        DataView dv = new DataView(dtArticleB);
        dv.RowFilter = "serie = 'Outillage' ";
        iCte = 993;
        if (dv.Count > 0)
          CreationCommandes(dv);

        // traitement du reste des articles
        dv = new DataView(dtArticleB);
        iCte = 995;
        if (dv.Count > 0)
          CreationCommandes(dv);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CreationDesCommandes()
    //    
    //On Error GoTo handler
    //
    //  ' traitement a part des articles d' outillage
    //  rsarticle.Filter = "serie = 'Outillage' "
    //  If rsarticle.RecordCount > 0 Then miCte = 993: CreationCommandes
    //
    //'  'traitement spéciale pour les fournitures YVES ROCHER
    //'  rsarticle.Filter = "serie = 'Yves Rocher' "
    //'  'recherche du compte ana du client, si null alors pas ce création auto de commande
    //'  If rsarticle.RecordCount > 0 Then
    //'    miCte = 85
    //'    If miCte <> 0 Then CreationCommandesClient (695)
    //'  End If
    //
    //  ' traitement du reste des articles
    //  rsarticle.Filter = ""
    //  miCte = 995: CreationCommandes
    // 
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " CreationDesCommandes dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationCommandes(DataView dv)
    {
      try
      {
        dv.Sort = "NumFour";  // sort order par Fournisseur

        // initialisation des variable de rupture
        int iNumFour = 0;
        int iNumCom = 0;

        // parcours du recordset et gestion des ruptures
        foreach (DataRowView rowView in dv)
        {
          if (iNumFour == 0) // premier enregistrement
            iNumCom = enregCommande(0, rowView.Row); // création d'une nouvelle commande
          else
          {
            if (iNumFour == (int)rowView["NumFour"])   // on reste sur le même fournisseur
              iNumCom = enregCommande(iNumCom, rowView.Row);
            else  // on change de fournisseur donc nouvelle commande
            {
              TraitementDelegation(iNumCom); // traitement délégation pouvoir
              iNumCom = enregCommande(0, rowView.Row);
            }
          }

          iNumFour = (int)rowView["NumFour"];
          rowView.Delete();  // pour être certain de ne pas retraiter cette action
        }

        // traitement delegation pouvoir
        if (iNumCom != 0)
          TraitementDelegation(iNumCom);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CreationCommandes()
    //
    //Dim iNumFour As Long
    //    
    //On Error GoTo handler
    //
    //  ' sort order par Fournisseur
    //  rsarticle.Sort = "NumFour"
    //
    //  ' initialisation des variable de rupture
    //  iNumFour = 0
    //  iNumCom = 0
    //  
    //  'parcours du recordset et gestion des ruptures
    //  While Not rsarticle.EOF
    //    If iNumFour = 0 Then   ' premier enregistrement
    //      ' création d'une nouvelle commande
    //       Call enregCommande(0)
    //    Else
    //        If iNumFour = rsarticle("NumFour") Then   ' on reste sur le même fournisseur
    //           Call enregCommande(iNumCom)
    //        Else  ' on change de fournisseur donc nouvelle  commande
    //           ' mise a jour dans l'obs de TACT
    //          '   cnx.Execute "api_sp_UpdateActionCom " & iNumCom & ", 'N', ''"
    //          
    //          ' traitement delegation pouvoir
    //          TraitementDelegation (iNumCom)
    //
    //           Call enregCommande(0)
    //        End If
    //    End If
    //      
    //    iNumFour = rsarticle("NumFour")
    //    rsarticle.Delete  ' pour etre sur de ne pas retraiter cette action
    //    rsarticle.MoveNext
    //  Wend
    //  
    //  ' mise a jour dans l'obs de TACT
    //  'cnx.Execute "api_sp_UpdateActionCom " & iNumCom & ", 'N', ''"
    //  
    //  ' traitement delegation pouvoir
    //  If iNumCom <> 0 Then TraitementDelegation (iNumCom)
    //
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " CreationCommandes dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationCommandeEmalec()
    {
      try
      {
        // Initialisation variable globale
        iNumCom = 0;

        if (dtArticleB.Rows.Count == 0)
          MessageBox.Show(Resources.txt_aucun_article_liste_prepa_cde, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        List<DataRow> lstToDelete = new List<DataRow>();
        foreach (DataRow rowB in dtArticleB.Rows)
        {
          // fournisseur Emalec
          enregCommande(iNumCom, rowB, 937);
          // pour etre sur de ne pas retraiter cette action
          lstToDelete.Add(rowB);
        }

        foreach (DataRow row in lstToDelete)
          dtArticleB.Rows.Remove(row);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CreationCommandeEmalec()
    //
    //On Error GoTo handler
    //
    //  ' initialisation variable globale
    //  iNumCom = 0
    //  
    //  If rsarticle.RecordCount = 0 Then MsgBox ("§Pas d'article(s) dans la liste des articles en préparation de commande§"): Exit Sub
    //  
    //  rsarticle.MoveFirst
    //  
    //  'parcours du recordset
    //  While Not rsarticle.EOF
    //    Call enregCommande(iNumCom, 937)  ' fournisseur Emalec
    //    rsarticle.Delete                  ' pour etre sur de ne pas retraiter cette action
    //    rsarticle.MoveNext                ' article suivant
    //  Wend
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " CreationCommandeEmalec dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private int enregCommande(int numCom, DataRow dataRow, int numstf = 0)
    {
      try
      {
        int iAction = 0;

        // creation d'une DI et d'une action pour chaque commande
        if (numCom == 0)
          // c'est une nouvelle commande, donc il faut une nouvelle action
          iAction = CreationDIcmd();

        // on recherche les données de la société correspondant au nom de la base utilisée
        DataTable dtSte = new DataTable();
        ModuleData.LoadData(dtSte, "exec api_sp_GetInfosSociete " + iAction);
        if (dtSte.Rows.Count == 0)
        {
          MessageBox.Show(Resources.txt_coord_demandeur + MozartParams.NomSociete + Resources.txt_non_remontees, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return 0;
        }

        DataRow drSte = dtSte.Rows[0];

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationCommande", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          // sur la table TCOM, on enregiste le site du fournisseur et non le fournisseur

          cmd.Parameters["@iNumCommande"].Value = numCom;
          cmd.Parameters["@iNumFour"].Value = (numstf == 0) ? dataRow["NumSiteFour"] : numstf;       // on veut le site du fourniseur
          cmd.Parameters["@iAction"].Value = iAction;                                                // action de commande réappro DI 43787
          cmd.Parameters["@nPrixHT"].Value = txtHT.Text.Replace(" €", "");
          cmd.Parameters["@nPrixTVA"].Value = 20;                                                    // txtTVA  // n'est pas utilisée dans la proc stock
          cmd.Parameters["@dDateLiv"].Value = DateTime.Now.AddDays(5);                               // txtDateLiv
          cmd.Parameters["@typeL"].Value = "E";                                                      // Chr(cboType.ItemData(cboType.ListIndex))

          cmd.Parameters["@adresse1"].Value = drSte["VSITAD1"].ToString().Substring(0, Math.Min(drSte["VSITAD1"].ToString().Length, 50));        // Left(txtFields(0), 50)
          cmd.Parameters["@adresse2"].Value = drSte["VSITAD2"].ToString().Substring(0, Math.Min(drSte["VSITAD2"].ToString().Length, 50));        // Left(txtFields(1), 50)
          cmd.Parameters["@cp"].Value = drSte["VSITCP"];                                           // txtFields(2)
          cmd.Parameters["@ville"].Value = drSte["VSITVIL"];                                       // txtFields(3)
          cmd.Parameters["@aattention"].Value = drSte["VRESPSTOCK"];                               // ado_rs_Societe("VPERNOM")       // txtFields(4)
          cmd.Parameters["@lieulivr"].Value = MozartParams.NomSociete;                               // txtLivr

          cmd.Parameters["@numArticle"].Value = dataRow["NumArticle"];
          cmd.Parameters["@qte"].Value = (int)dataRow["Quantite"];

          cmd.Parameters["@pu"].Value = numstf == 0
                                      ? dataRow["Prix U"] : 1.05 * Convert.ToDouble(dataRow["Prix U"]); // coeff 1.05 pour les commandes a Emalec
          cmd.Parameters["@pt"].Value = numstf == 0
                                      ? Convert.ToDouble(dataRow["Prix U"]) * Convert.ToInt32(dataRow["Quantite"])
                                      : 1.05 * Convert.ToDouble(dataRow["Prix U"]) * Convert.ToInt32(dataRow["Quantite"]);

          cmd.Parameters["@dDatePlanif"].Value = DBNull.Value;

          cmd.ExecuteNonQuery();

          iNumCom = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return iNumCom;
    }
    //Public Sub enregCommande(ByVal numCom As Long, Optional numstf As Long)
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //Dim ado_rs_Societe As New ADODB.Recordset
    //Static iAction As Long
    //
    //On Error GoTo handler
    //
    //  ' creation d'une DI et d'une action pour chaque commande
    //  If numCom = 0 Then
    //    'c'est une nouvelle commande, donc il faut une nouvelle action
    //    iAction = CreationDIcmd
    //  End If
    //  
    //  ' on recherche les données de la société correspondant au nom de la base utilisée
    //  Set ado_rs_Societe = New ADODB.Recordset
    //  ado_rs_Societe.Open "exec api_sp_GetInfosSociete " & iAction, cnx
    //  If ado_rs_Societe.RecordCount = 0 Then
    //    MsgBox "§Les coordonnées du demandeur (§" & gstrNomSociete & "§) n'ont pas pu être remontées!§"
    //    Exit Sub
    //  End If
    //  
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_CreationCommande"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //' sur la table TCOM, on enregister le site du fournisseur et non le fournisseur
    //
    //  ' liste des paramètres
    //  ado_cmd.Parameters("@iNumCommande").value = numCom
    //  ado_cmd.Parameters("@iNumFour").value = IIf(numstf = 0, rsarticle("NumSiteFour"), numstf) ' on veut le site du fourniseur
    //  ado_cmd.Parameters("@iAction").value = iAction                        'action de commande réappro DI 43787
    //  ado_cmd.Parameters("@nPrixHT").value = txtHT
    //  ado_cmd.Parameters("@nPrixTVA").value = 20                        'txtTVA  ' n'est pas utilisée dans la proc stock
    //  ado_cmd.Parameters("@dDateLiv").value = DateAdd("d", 5, Date)       'txtDateLiv
    //  ado_cmd.Parameters("@typeL").value = "E"                            'Chr(cboType.ItemData(cboType.ListIndex))
    //
    //  ado_cmd.Parameters("@adresse1").value = Left(ado_rs_Societe("VSITAD1"), 50)        'Left(txtFields(0), 50)
    //  ado_cmd.Parameters("@adresse2").value = Left(ado_rs_Societe("VSITAD2"), 50)         'Left(txtFields(1), 50)
    //  ado_cmd.Parameters("@cp").value = ado_rs_Societe("VSITCP")                'txtFields(2)
    //  ado_cmd.Parameters("@ville").value = ado_rs_Societe("VSITVIL")            'txtFields(3)
    //  ado_cmd.Parameters("@aattention").value = ado_rs_Societe("VRESPSTOCK")               'ado_rs_Societe("VPERNOM")       'txtFields(4)
    //  ado_cmd.Parameters("@lieulivr").value = gstrNomSociete                       'txtLivr
    //
    //  ado_cmd.Parameters("@numArticle").value = rsarticle("NumArticle")
    //  ado_cmd.Parameters("@qte").value = rsarticle("Quantite")
    //  ado_cmd.Parameters("@pu").value = IIf(numstf = 0, rsarticle("Prix U"), 1.05 * rsarticle("Prix U")) ' coeff 1.05 pour les copmmandes a Emalec
    //  ado_cmd.Parameters("@pt").value = IIf(numstf = 0, rsarticle("Prix U") * rsarticle("Quantite"), 1.05 * rsarticle("Prix U") * rsarticle("Quantite"))
    //  ado_cmd.Parameters("@dDatePlanif").value = Null
    //   
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute
    //          
    //  ' récupération du numéro crée
    //  iNumCom = ado_cmd.Parameters(0).value
    //    
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //        
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "EnregCommande dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private int CreationDIcmd()
    {
      int iReturn = 0;
      try
      {
        int iSite;

        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationDIActionReapproMagasin", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          switch (MozartParams.NomSociete)
          {
            case "EMALEC": iSite = 8974; break;
            case "FITELEC": iSite = 81240; break;
            case "ALC": iSite = 210306; break;
            case "SCS": iSite = 209724; break;
            case "EQUIPAGE": iSite = 100149; break;
            case "EMALECMPM": iSite = 385434; break;
            case "EMALECFACILITEAM": iSite = 381989; break;
            default: return 0;
          }

          cmd.Parameters["@iSite"].Value = iSite;                                                   // magasin emalec ou fitelec ou..etc
          cmd.Parameters["@Demandeur"].Value = MozartParams.NomSociete;
          cmd.Parameters["@vRefClient"].Value = $"Réappro Magasin {MozartParams.NomSociete}";
          cmd.Parameters["@vCte"].Value = iCte;                                                    // 995 ou 993

          cmd.ExecuteNonQuery();
          iReturn = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return iReturn;
    }
    //Private Function CreationDIcmd() As Long
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim iSite As Long
    //
    //CreationDIcmd = 0
    //
    //'********************************************************************************************
    //' création d'une DI et d'une action de fournitures web
    //  Set ado_cmd.ActiveConnection = cnx
    //
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "Api_sp_CreationDIActionReapproMagasin"
    //  ado_cmd.CommandType = adCmdStoredProc
    //
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //  If gstrNomSociete = "EMALEC" Then
    //    iSite = 8974
    //  ElseIf gstrNomSociete = "FITELEC" Then
    //    iSite = 81240
    //  ElseIf gstrNomSociete = "ALC" Then
    //    iSite = 210306
    //  ElseIf gstrNomSociete = "SCS" Then
    //    iSite = 209724
    //  ElseIf gstrNomSociete = "EQUIPAGE" Then
    //    iSite = 100149
    //  ElseIf gstrNomSociete = "EMALECMPM" Then
    //    iSite = 385434
    //  ElseIf gstrNomSociete = "EMALECFACILITEAM" Then
    //    iSite = 381989
    //  Else
    //    CreationDIcmd = 0
    //    Exit Function
    //  End If
    //  
    //  ado_cmd.Parameters("@iSite").value = iSite ' magasin emalec ou fitelec ou..etc
    //
    //  ado_cmd.Parameters("@Demandeur").value = gstrNomSociete
    //  ado_cmd.Parameters("@vRefClient").value = "Réappro Magasin " & gstrNomSociete
    //  ado_cmd.Parameters("@vCte").value = miCte ' 995 ou 993
    //
    //  ' exécuter la commande.
    //  ado_cmd.Execute
    //
    //  ' récupération du numéro crée
    //  CreationDIcmd = ado_cmd.Parameters(0).value
    //
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //  
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridB_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow dataRow = apiTGridB.GetFocusedDataRow();
      dataRow["Prix T"] = Utils.ZeroIfNull(dataRow["Prix U"]) * Utils.ZeroIfNull(dataRow["Quantite"]);

      CalculerTOTAUX();
    }
    //Private Sub apiTGridB_AfterColUpdate(ColIndex As Integer)
    //  rsarticle("Prix T") = ZeroIfNull(rsarticle("Prix U")) * ZeroIfNull(rsarticle("Quantite"))
    //  CalculerTOTAUX
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CalculerTOTAUX()
    {
      try
      {
        int i;
        double tot = 0;
        DataRow lTmpRow;

        for (i = 0; i < apiTGridB.dgv.DataRowCount; i++)
        {
          //foreach (DataRow row in dtArticleB.Rows)
          if (apiTGridB.dgv.IsRowLoaded(i))
          {
            lTmpRow = apiTGridB.dgv.GetDataRow(i);
            tot += Utils.ZeroIfNull(lTmpRow["PRIX U"]) * Utils.ZeroIfNull(lTmpRow["Quantite"]);
          }
        }

        txtHT.Text = tot.ToString("0.00 €");
        txtTTC.Text = ((100.0 + MozartParams.TVA1) * tot / 100.0).ToString("0.00 €");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CalculerTOTAUX()
    //
    //On Error GoTo handler
    //Dim rsC
    //Dim CalculerTHT
    //
    //  ' on se replace au début du recordset
    //  If rsarticle.EOF Or rsarticle.BOF Then Exit Sub
    //  Set rsC = rsarticle.Clone
    //
    //  ' initialisation
    //  CalculerTHT = 0
    //  
    //  ' parcours du recordset
    //  rsC.MoveFirst
    //  While Not rsC.EOF
    //    CalculerTHT = CalculerTHT + ZeroIfNull(rsC("PRIX U")) * ZeroIfNull(rsC("Quantite"))
    //    rsC.MoveNext
    //  Wend
    //  rsC.Close
    //  Set rsC = Nothing
    //  
    //  txtHT = Format(CalculerTHT, "currency")
    //  txtTTC = Format(CalculerTHT * 1.196, "currency")
    //  
    //Exit Sub
    //handler:
    //  ShowError "CalculerTHT dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridB_ColumnFilterChanged(object sender, EventArgs e)
    {
      CalculerTOTAUX();
    }

    /* --------------------------------------------------------------------------------------- */
    private void TraitementDelegation(int numCom)
    {
      try
      {
        switch (MozartParams.NomSociete)
        {
          case "EMALECFACILITEAM":
          case "EMALECSUISSE":
          case "SAMSICROMANIA":
          case "EMALECDEV":
            return;
          default:
            break;
        }

        string Createur = "";
        string DateCre = "";
        string N3 = "";
        string N4 = "";

        //  recherche du total de la commande
        Double MontantCommande = (double)ModuleData.ExecuteScalarDouble("SELECT sum(NLCOPT) FROM TLCO WHERE ncomnum = " + numCom);

        //  Recherche du créateur de la commande et de la date de creation
        using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT NQUICREE, DCOMDAT FROM TCOM WHERE NCOMNUM=" + numCom))
        {
          if (dr.Read())
          {
            Createur = dr["NQUICREE"].ToString();
            DateCre = dr["DCOMDAT"].ToString();
          }
        }

        //  Recherche du montant de validation du créateur
        Double MontantValidation = (double)ModuleData.ExecuteScalarDouble($"SELECT MTVALIDATION FROM TPER WHERE NPERNUM = {Createur}");

        //  si montant supérieur, on sort sans création de délégation de dépense
        if (MontantCommande < MontantValidation)
          return;

        //  Suite si besoin
        //  CASE 1
        //  on insert une ligne dans la table de validation avec le createur de la commande en case 1
        ModuleData.ExecuteNonQuery($"INSERT INTO TCOMVALID (NCOMNUM, CTYPE, QN1, DN1) SELECT {numCom}, 'CF', {Createur}, '{DateCre}'");

        //  CASE 2
        //  Recherche du responsable du compte pour cette commande
        int Responsable = (int)ModuleData.ExecuteScalarInt($"SELECT TCAN.NPERNUM FROM TCAN WITH(NOLOCK), TACT WITH(NOLOCK), TDIN WITH(NOLOCK), TCOM WITH(NOLOCK) " +
                                                           $"WHERE TCAN.NCLINUM = TDIN.NCLINUM AND TACT.NDINNUM = TDIN.NDINNUM AND TCAN.NCANNUM = TDIN.NDINCTE " +
                                                           $"AND TACT.NACTNUM = TCOM.NACTNUM AND NCOMNUM = {numCom}");
        ModuleData.ExecuteNonQuery($"UPDATE TCOMVALID set QN2 = {Responsable} where CTYPE = 'CF' AND NCOMNUM = {numCom}");

        //  CASE 3 et 4
        //  Recherche du groupe et du service
        using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT G.NPERNUM [N3], S.NPERNUM [N4] FROM TREF_GROUPE G, TREF_SERVICE S, TPER P WHERE P.IDGROUPE=G.IDGROUPE " +
                                                           $"AND G.IDSERVICE = S.IDSERVICE AND P.NPERNUM = {Responsable}"))
        {
          if (dr.Read())
          {
            N3 = dr["N3"].ToString();
            N4 = dr["N4"].ToString();
          }
        }

        ModuleData.ExecuteNonQuery($"UPDATE TCOMVALID SET QN3 = {N3}, QN4 = {N4} where CTYPE='CF' AND NCOMNUM = {numCom}");

        //  CASE 5  direction par defaut, on enregistre personne pour le moment (uniquement à la signature)
        //  cnx.Execute "update TCOMVALID set QN5=" & 1 & " where NCOMNUM = " & numCom

        //  mise a jour du statut de la commande
        ModuleData.ExecuteNonQuery($"UPDATE TCOM set CCOMVALID = 'E' where NCOMNUM = {numCom}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    /* Inutile --------------------------------------------------------------------------------------- */
    //Public Sub CreationDiActionDDeFactureFITELEC_SCS(ByVal ste As String)
    //
    //  On Error GoTo handler
    //  
    //  ' création d'une DI , d'une action, d'une sortie de stock, du chiffrage et de la facture sur la base Emalec pour la commande Fitelec
    //  cnx.Execute "Api_sp_CreationDIActionCmd" & ste & " " & iNumCom
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " cmdValider_Click dans " & Me.Name
    //End Sub


    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub CreationCommandeFitelec()
    //
    //On Error GoTo handler
    //
    //  ' initialisation variable globale
    //  iNumCom = 0
    //  
    //  If rsarticle.RecordCount = 0 Then MsgBox ("§Pas d'article(s) dans la liste des articles en préparation de commande§"): Exit Sub
    //  
    //  rsarticle.MoveFirst
    //  
    //  'parcours du recordset
    //  While Not rsarticle.EOF
    //    Call enregCommandeSCSFitelec("SCS", GetDestCommandeSociete(9137), iNumCom, 9137)  ' fournisseur Fitelec, client SCS
    //    rsarticle.Delete                  ' pour etre sur de ne pas retraiter cette action
    //    rsarticle.MoveNext                ' article suivant
    //  Wend
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " CreationCommandeFitelec dans " & Me.Name
    //End Sub


    /* Inutile --------------------------------------------------------------------------------------- */
    //Public Sub enregCommandeSCSFitelec(ByVal sSociete As String, ByVal attention As String, ByVal numCom As Long, Optional numstf As Long)
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //Dim ado_rs_Societe As New ADODB.Recordset
    //Static iAction As Long
    //
    //On Error GoTo handler
    //
    //  ' creation d'une DI et d'une action pour chaque commande
    //  If numCom = 0 Then
    //    'c'est une nouvelle commande, donc il faut une nouvelle action
    //    iAction = CreationDIcmdSCSFitelec(sSociete)
    //'    If iAction = 0 Then iAction = 109374    ' DI 43787
    //  End If
    //  
    //  ' on recherche les donnees de la societe correspondant au nom de la base utilisée
    //  Set ado_rs_Societe = New ADODB.Recordset
    //  ado_rs_Societe.Open "exec api_sp_GetInfosSociete " & iAction, cnx
    //  If ado_rs_Societe.RecordCount = 0 Then
    //    MsgBox "§Les coordonnées du demandeur (§" & gstrNomSociete & "§) n'ont pas pu être remontées!§"
    //    Exit Sub
    //  End If
    //  
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_CreationCommande"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //' sur la table TCOM, on enregister le site du fournisseur et non le fournisseur
    //
    //  ' liste des paramètres
    //  ado_cmd.Parameters("@iNumCommande").value = numCom
    //  ado_cmd.Parameters("@iNumFour").value = IIf(numstf = 0, rsarticle("NumSiteFour"), numstf) ' on veut le site du fourniseur
    //  ado_cmd.Parameters("@iAction").value = iAction                        'action de commande réappro DI 43787
    //  ado_cmd.Parameters("@nPrixHT").value = txtHT
    //  ado_cmd.Parameters("@nPrixTVA").value = 20                        'txtTVA  ' n'est pas utilisée dans la proc stock
    //  ado_cmd.Parameters("@dDateLiv").value = DateAdd("d", 5, Date)       'txtDateLiv
    //  ado_cmd.Parameters("@typeL").value = "E"                            'Chr(cboType.ItemData(cboType.ListIndex))
    //
    //  ado_cmd.Parameters("@adresse1").value = Left(ado_rs_Societe("VSITAD1"), 50)        'Left(txtFields(0), 50)
    //  ado_cmd.Parameters("@adresse2").value = Left(ado_rs_Societe("VSITAD2"), 50)         'Left(txtFields(1), 50)
    //  ado_cmd.Parameters("@cp").value = ado_rs_Societe("VSITCP")                'txtFields(2)
    //  ado_cmd.Parameters("@ville").value = ado_rs_Societe("VSITVIL")            'txtFields(3)
    //  ado_cmd.Parameters("@aattention").value = attention                 'ado_rs_Societe("VPERNOM")       'txtFields(4)
    //  ado_cmd.Parameters("@lieulivr").value = sSociete                       'txtLivr
    //
    //  ado_cmd.Parameters("@numArticle").value = rsarticle("NumArticle")
    //  ado_cmd.Parameters("@qte").value = rsarticle("Quantite")
    //  ado_cmd.Parameters("@pu").value = rsarticle("Prix U") ' coeff 1 pour Fitelec et  SCS
    //  ado_cmd.Parameters("@pt").value = rsarticle("Prix U") * ZeroIfNull(rsarticle("Quantite"))
    //  ado_cmd.Parameters("@dDatePlanif").value = Null
    //   
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute
    //          
    //  ' récupération du numéro crée
    //  iNumCom = ado_cmd.Parameters(0).value
    //    
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //        
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "EnregCommande dans " & Me.Name
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Function CreationDIcmdSCSFitelec(ste As String) As Long
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim iSite As Long
    //
    //CreationDIcmdSCSFitelec = 0
    //
    //'********************************************************************************************
    //' création d'une DI est d'une action de fournitures web
    //  Set ado_cmd.ActiveConnection = cnx
    //
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "Api_sp_CreationDIActionReapproMagasin" & ste   ' FITELEC ou SCS
    //  ado_cmd.CommandType = adCmdStoredProc
    //
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //
    //   ' liste des paramètres
    //  ' Changer les compteurs et traiter le cas des autres sociétés
    //  If ste = "FITELEC" Then
    //    iSite = 81240
    //  ElseIf ste = "SCS" Then
    //    iSite = 209724
    //  Else
    //    CreationDIcmdSCSFitelec = 0
    //    Exit Function
    //  End If
    //  
    //  ado_cmd.Parameters("@iSite").value = iSite ' magasin emalec ou fitelec ou..etc
    //
    //  ado_cmd.Parameters("@Demandeur").value = gstrNomSociete
    //  ado_cmd.Parameters("@vRefClient").value = "Réappro Magasin " & gstrNomSociete
    //  ado_cmd.Parameters("@vCte").value = miCte ' 995 ou 993
    //
    //  ' exécuter la commande.
    //  ado_cmd.Execute
    //
    //  ' récupération du numéro crée
    //  CreationDIcmdSCSFitelec = ado_cmd.Parameters(0).value
    //
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //
    //End Function

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Command2_Click()
    //  rsArt!vStfGrpNom = dbGrid.Columns("Fournisseur").Text
    //  rsArt!Prix = Replace(dbGrid.Columns("Prix HT").Text, ",", ".")
    //  rsArt!nStfGrpNum = CInt(dbGrid.Columns("Num").Text)
    //  Frame1.Visible = Falsed
    //End Sub

    /* Inutile ------------------------------------------------------------------------------------------- */
    //'Public Sub enregCommandeCli(ByVal iAction As Long, ByVal numCom As Long, Optional ByVal numstf As Long)
    //'
    //'Dim ado_cmd As New ADODB.Command
    //'Dim ado_rs As New ADODB.Recordset
    //'Dim ado_rs_Societe As New ADODB.Recordset
    //'
    //'On Error GoTo handler
    //'
    //'  ' on recherche les donnees de la societe correspondant au nom de la base utilisée
    //'  Set ado_rs_Societe = New ADODB.Recordset
    //'  ado_rs_Societe.Open "exec api_sp_GetInfosSociete " & iAction, cnx
    //'  If ado_rs_Societe.RecordCount = 0 Then
    //'    MsgBox "§Les coordonnées du demandeur (§" & gstrNomSociete & "§) n'ont pas pu être remontées!§"
    //'    Exit Sub
    //'  End If
    //'
    //'  ' création d'une commande
    //'  Set ado_cmd.ActiveConnection = cnx
    //'
    //'  ' passage du nom de la procédure stockée
    //'  ado_cmd.CommandText = "api_sp_CreationCommande"
    //'  ado_cmd.CommandType = adCmdStoredProc
    //'
    //'  ' passage des paramètres
    //'  ado_cmd.Parameters.Refresh
    //'
    //'' sur la table TCOM, on enregister le site du fournisseur et non le fournisseur
    //'
    //'  ' liste des paramètres
    //'  ado_cmd.Parameters("@iNumCommande").value = numCom
    //'  ado_cmd.Parameters("@iNumFour").value = IIf(numstf = 0, rsarticle("NumSiteFour"), numstf) ' on veut le site du fourniseur
    //'  ado_cmd.Parameters("@iAction").value = iAction                        'action de commande réappro DI 43787
    //'  ado_cmd.Parameters("@nPrixHT").value = txtHT
    //'  ado_cmd.Parameters("@nPrixTVA").value = 20                        'txtTVA  ' n'est pas utilisée dans la proc stock
    //'  ado_cmd.Parameters("@dDateLiv").value = DateAdd("d", 5, Date)       'txtDateLiv
    //'  ado_cmd.Parameters("@typeL").value = "E"                            'Chr(cboType.ItemData(cboType.ListIndex))
    //'
    //'  ado_cmd.Parameters("@adresse1").value = ado_rs_Societe("VSITAD1")         'Left(txtFields(0), 50)
    //'  ado_cmd.Parameters("@adresse2").value = ado_rs_Societe("VSITAD2")         'Left(txtFields(1), 50)
    //'  ado_cmd.Parameters("@cp").value = ado_rs_Societe("VSITCP")                'txtFields(2)
    //'  ado_cmd.Parameters("@ville").value = ado_rs_Societe("VSITVIL")            'txtFields(3)
    //'  ado_cmd.Parameters("@aattention").value = ado_rs_Societe("VRESPSTOCK")   'ado_rs_Societe("VPERNOM")       'txtFields(4)
    //'  ado_cmd.Parameters("@lieulivr").value = gstrNomSociete                       'txtLivr
    //'
    //'  ado_cmd.Parameters("@numArticle").value = rsarticle("NumArticle")
    //'  ado_cmd.Parameters("@qte").value = rsarticle("Quantite")
    //'  ado_cmd.Parameters("@pu").value = ZeroIfNull(rsarticle("Prix U"))
    //'  ado_cmd.Parameters("@pt").value = ZeroIfNull(rsarticle("Prix U")) * ZeroIfNull(rsarticle("Quantite"))
    //'  ado_cmd.Parameters("@dDatePlanif").value = Null
    //'
    //'  ' exécuter la commande.
    //'  Set ado_rs = ado_cmd.Execute
    //'
    //'  ' récupération du numéro crée
    //'  iNumCom = ado_cmd.Parameters(0).value
    //'
    //'  ' libération de la commande
    //'  Set ado_cmd = Nothing
    //'
    //'Exit Sub
    //'Resume
    //'handler:
    //'  Screen.MousePointer = vbDefault
    //'  ShowError "EnregCommande dans " & Me.Name
    //'End Sub

    /* Inutile ------------------------------------------------------------------------------------------- */
    //'Private Sub CreationCommandesClient(ByVal iNumCli As Long)
    //''************************************************************************************************
    //''Créer les commandes pour un reappro stock client, parametre = Nom du client en question
    //''************************************************************************************************'
    //'
    //'Dim iNumFour As Long
    //'Dim inumAction As Long
    //'
    //'On Error GoTo handler
    //'
    //'  ' sort order par Fournisseur
    //'  rsarticle.Sort = "NumFour"
    //'
    //'  ' initialisation des variable de rupture
    //'  iNumFour = 0
    //'  iNumCom = 0
    //'
    //'  'on créer une DI et une action pour la gestion des commandes client
    //'  'on passe en parametres le NCLINUM et on créé la di sur le siège
    //'  ' TB SAMSIC CITY SPEC
    //'  ' Select spéfique aux numéros de clients
    //'  Select Case iNumCli
    //'    'client Yves Rocher
    //'    Case 695:
    //'      If gstrNomGroupe = "EMALEC" Then
    //'        inumAction = CreationDIcmdClient(iNumCli, 46817)
    //'      End If
    //'    Case Else
    //'      MsgBox "§Le client n'est pas géré pour la création de commande stock client§"
    //'      Exit Sub
    //'  End Select
    //'
    //'  'parcours du recordset et gestion des ruptures
    //'  While Not rsarticle.EOF
    //'    If iNumFour = 0 Then   ' premier enregistrement
    //'      'création de la premiere commande
    //'      Call enregCommandeCli(inumAction, 0)
    //'    Else
    //'      If iNumFour = rsarticle("NumFour") Then   ' on reste sur le même fournisseur
    //'           Call enregCommandeCli(inumAction, iNumCom)
    //'        Else  ' on change de fournisseur donc nouvelle  commande
    //'          Call enregCommandeCli(inumAction, 0)
    //'      End If
    //'    End If
    //'
    //'    iNumFour = rsarticle("NumFour")
    //'    rsarticle.Delete  ' pour etre sur de ne pas retraiter cette action
    //'    rsarticle.MoveNext
    //'
    //'  Wend
    //'
    //'  'création du chiffrage de l'action
    //'  cnx.Execute ("api_sp_CreationChiffrageReapproStockCli " & inumAction & "," & iNumCli)
    //'
    //'  Exit Sub
    //'  Resume
    //'
    //'handler:
    //'  Screen.MousePointer = vbDefault
    //'  ShowError " CreationCommandesClient dans " & Me.Name
    //'End Sub

    /* Inutile ------------------------------------------------------------------------------------------- */
    //'Private Function CreationDIcmdClient(ByVal iNumCli As Long, ByVal iNumsite As Long) As Long
    //''*****************************************************************************************************************************
    //''Cette fonction permet de créer une di auto selon le client(NCLINUM, NSITNUM du siège)
    //''*****************************************************************************************************************************
    //'
    //'Dim ado_cmd As New ADODB.Command
    //'
    //'CreationDIcmdClient = 0
    //'
    //''********************************************************************************************
    //'' création d'une DI est d'une action de fournitures web
    //'  Set ado_cmd.ActiveConnection = cnx
    //'
    //'  ' passage du nom de la procédure stockée
    //'  ado_cmd.CommandText = "Api_sp_CreationDIActionReapproMagasinClient"
    //'  ado_cmd.CommandType = adCmdStoredProc
    //'
    //'  ' passage des paramètres
    //'  ado_cmd.Parameters.Refresh
    //'
    //'   ' liste des paramètres
    //'  ' Changer les compteurs et traiter le cas des autres sociétés
    //'  ado_cmd.Parameters("@iNomCli").value = iNumCli
    //'  ado_cmd.Parameters("@iSite").value = iNumsite
    //'  ado_cmd.Parameters("@Demandeur").value = gstrNomSociete
    //'  ado_cmd.Parameters("@vRefClient").value = "Réappro Magasin Client " & gstrNomSociete
    //'  ado_cmd.Parameters("@vCte").value = miCte
    //'
    //'  ' exécuter la commande.
    //'  ado_cmd.Execute
    //'
    //'  ' récupération du numéro crée
    //'  CreationDIcmdClient = ado_cmd.Parameters(0).value
    //'
    //'  ' libération de la commande
    //'  Set ado_cmd = Nothing
    //'End Function
  }
}