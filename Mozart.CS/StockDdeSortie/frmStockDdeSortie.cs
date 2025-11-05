using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockDdeSortie : Form
  {
    public string mstrSite;
    public string mstrTech;
    public int miNumDdeSortie;
    public bool mbFacture = false; // doit être mis à jour par frmStockListeDdeSortie
    public string mstrStatutStock = "";
    public DataTable dtArticles;

    public frmStockDdeSortie() { InitializeComponent(); }


    private void frmStockDdeSortie_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        if (mstrStatutStock != "Q") dtArticles = new DataTable();
        else if (dtArticles == null)
        {
          MessageBox.Show(@"/!\ Le dtArticles doit être passé en paramètre /!\");
          return;
        }

        InitialiserFeuille();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      try
      {
        new frmRechercheArticlesCom
        {
          miNumFournisseur = 0,
          m_brechercheSite = false,
          m_bSaisieQte = true,
          mstrClient = txtCli0.Text,
          mstrStatut = "",
          m_bAfficheInfoFou = true,
          mdtArticles = dtArticles
        }.ShowDialog();

        RemplirTxtTotaux();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdRechercher_Click()
    //
    //On Error GoTo Handler
    //
    //  Screen.MousePointer = vbHourglass
    //  ' affichage de la feuille  de recherche des fournitures avec numero de fournisseur si connu
    //  frmRechercheArticlesCom.miNumFournisseur = 0
    //  frmRechercheArticlesCom.brechercheSite = False
    //  frmRechercheArticlesCom.bSaisieQte = True
    //  frmRechercheArticlesCom.mstrClient = txtCli(0)
    //  frmRechercheArticlesCom.mstrStatut = ""
    //  ' on remet comme avant
    //'  frmRechercheArticles.mstrType = "DDE"
    //  frmRechercheArticlesCom.bAfficheInfoFou = True
    // 
    //  frmRechercheArticlesCom.Show vbModal
    //
    //  On Error Resume Next
    //  rsarticle.MoveFirst
    //  InitapiGrid
    //  
    //  ' remplir les montants totaux
    //  Call RemplirTxtTotaux
    //  
    //Exit Sub
    //Handler:
    //  ShowError " cmdRechercher_Click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void InitapiGrid()
    {
      grdDataGrid.GridControl.DataSource = dtArticles;
      FormatGridArticle();
    }

    private void InitialiserFeuille()
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_RetourInfoSortieStockNew {MozartParams.NumAction}, " +
                                                           $"{miNumDdeSortie}, '{MozartParams.NomSociete}'"))
        {
          if (dr.Read())
          {
            cboLieu.Items.Add("Magasin " + MozartParams.NomSociete);

            txtCli0.Text = dr["VCLINOM"].ToString();
            txtCli1.Text = dr["NDINCTE"].ToString();
            txtCli2.Text = dr["DDDEDAT"].ToString();
            txtCli3.Text = dr["NDDENUM"].ToString();

            txtObjet.Text = Utils.BlankIfNull(dr["VDDEOBJET"]);
            string strDateLivr = Utils.BlankIfNull(dr["DDDELIVR"]);
            txtDateLivr.Text = (strDateLivr == "") ? "" : Utils.DateBlankIfNull(strDateLivr);


            //  si on est en modification ou en création
            if (Convert.ToInt32(dr["NDDENUM"].ToString().ToUpper().Replace("DE", "")) == 0)
            {
              mstrStatutStock = "C";
              optDest1.Checked = true; // site par défaut
              cboLieu.Text = "Domicile";

              // gestion de libelles sis chantier
              if (Convert.ToInt32(dr["CHANTIER"]) == 0)
                FrameFicChantier.Visible = false;
              else
              {
                FrameFicChantier.Visible = true;
                // On charge la combo des libellés fiche chantier
                ModuleData.RemplirCombo(cboFicChantierFO, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN " +
                            $"ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER WHERE VTYPE = 'F' AND NCANNUM = {dr["NDINCTE"]} " +
                            $"AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TCHANTIERFICHE.NCLASS", false);               


              }
            }
            else
            {
              mstrStatutStock = "M";

              switch (dr["VDDETYPDEST"].ToString())
              {
                case "Site":
                  optDest1.Checked = true;
                  break;
                case "Personnel":
                  optDest0.Checked = true;
                  if (Utils.BlankIfNull(dr["VLIEULIVR"]) != "")
                    cboLieu.Text = dr["VLIEULIVR"].ToString();

                  cboLieu.Visible = true;
                  lblLabels0.Visible = true;
                  break;
                case "Sous-traitant":
                  optDest2.Checked = true;
                  break;
                case "Tech filiale":
                  optDest0.Checked = true;
                  if (Utils.BlankIfNull(dr["VLIEULIVR"]) != "")
                    cboLieu.Text = dr["VLIEULIVR"].ToString();

                  cboLieu.Visible = true;
                  lblLabels0.Visible = true;

                  // on ne peut pas modifier une SS en tech filiale car elles sont liées par un N° commande filiale
                  cmdValider.Visible = false;

                  MessageBox.Show(Resources.txt_sortie_stock_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  break;
                case "SCFC":
                  optDest1.Checked = true;
                  lblDest.Visible = true;
                  txtLivr.Visible = true;

                  // on ne peut pas modifier une SS en tech filiale car elles sont liées par un N° commande filiale
                  cmdValider.Visible = false;

                  MessageBox.Show(Resources.txt_sortie_stock_impossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  break;
              }

              // gestion de libelles sis chantier
              if (Convert.ToInt32(dr["CHANTIER"]) == 0)
                FrameFicChantier.Visible = false;
              else
              {
                FrameFicChantier.Visible = true;
                // On charge la combo des libellés fiche chantier
                ModuleData.RemplirCombo(cboFicChantierFO, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON " +
                              $"TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER WHERE VTYPE = 'F' AND NCANNUM = {dr["NDINCTE"]} " +
                              $"AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY VLIB", false);

                //--NIDFICHE
                cboFicChantierFO.SelectedValue = dr["NIDFICHE"];

              }
            }

            if (dtArticles.Rows.Count == 0)// > 0 cas appel avec mstrStatutStock == Q
              grdDataGrid.LoadData(dtArticles, MozartDatabase.cnxMozart, $"EXEC api_sp_RetourArticlesBL {miNumDdeSortie}");
            InitapiGrid();

            // remplir les montants totaux
            RemplirTxtTotaux();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitialiserFeuille()
    //
    //Dim otext As TextBox
    //Dim rsD As ADODB.Recordset
    //
    //On Error GoTo Handler
    //
    //  Set rsD = New ADODB.Recordset
    //  rsD.Open "api_sp_RetourInfoSortieStockNew " & glNumAction & "," & lNumDdeSortie & ",'" & gstrNomSociete & "'", cnx
    //
    //  cboLieu.AddItem "Magasin " & gstrNomSociete
    //
    //  'les infos de la feuille
    //  For Each otext In txtCli
    //    Set otext.DataSource = rsD
    //  Next
    //
    //  txtObjet = BlankIfNull(rsD!VDDEOBJET)
    //  txtDateLivr = BlankIfNull(rsD!DDDELIVR)
    //  
    //  InitapiGrid
    //  
    //  ' si on est en modification ou en création
    //  If rsD("NDDENUM") = 0 Then
    //    mstrStatutStock = "C"
    //    optDest(1).value = True ' site par défaut
    //    cboLieu.Text = "Domicile"
    //    'gestion de libelles sis chantier
    //    If rsD("CHANTIER") = 0 Then
    //        FrameFicChantier.Visible = False
    //        frameSearch.height = frameSearch.height + FrameFicChantier.height
    //        grdDataGrid.height = grdDataGrid.height + FrameFicChantier.height
    //    Else
    //        FrameFicChantier.Visible = True
    //        'On charge la combo des libellés fiche chantier
    //        RemplirCombo cboFicChantierFO, "SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER" _
    //          & " WHERE VTYPE = 'F' AND NCANNUM = " & rsD("NDINCTE") & " AND VSOCIETE = '" & gstrNomSociete & "' ORDER BY TCHANTIERFICHE.NCLASS", True
    //    End If
    //    
    //  Else
    //    mstrStatutStock = "M"
    //    
    //    Select Case rsD("VDDETYPDEST")
    //      Case "Site"
    //        optDest(1).value = True '
    //        
    //      Case "Personnel"
    //        optDest(0).value = True
    //        If BlankIfNull(rsD!VLIEULIVR) <> "" Then
    //          cboLieu.Text = rsD!VLIEULIVR
    //        End If
    //        cboLieu.Visible = True
    //        lblLabels(0).Visible = True
    //        
    //      Case "Sous-traitant"
    //        optDest(2).value = True '
    //        
    //      Case "Tech filiale"
    //        optDest(0).value = True
    //        If BlankIfNull(rsD!VLIEULIVR) <> "" Then
    //          cboLieu.Text = rsD!VLIEULIVR
    //        End If
    //        cboLieu.Visible = True
    //        lblLabels(0).Visible = True
    //        
    //        'on ne peut pas modifier une SS en tech filiale car elles sont liées par un N° commande filiale
    //        cmdValider.Visible = False
    //        
    //        MsgBox "§La modification de cette sortie de stock est impossible car elle a été générée en automatique à la suite d'une commande d'une filiale§"
    //        
    //        Case "SCFC"
    //            optDest(1).value = True
    //            'If BlankIfNull(rsD!VLIEULIVR) <> "" Then
    //              txtLivr.Text = mstrSite
    //            'End If
    //            lblDest.Visible = True
    //            txtLivr.Visible = True
    //            
    //            'on ne peut pas modifier une SS en tech filiale car elles sont liées par un N° commande filiale
    //            cmdValider.Visible = False
    //            
    //            MsgBox "§La modification de cette sortie de stock est impossible car elle a été générée en automatique à la suite d'une commande d'une filiale§"
    //        
    //    End Select
    //    
    //    'gestion de libelles sis chantier
    //    If rsD("CHANTIER") = 0 Then
    //        FrameFicChantier.Visible = False
    //        frameSearch.height = frameSearch.height + FrameFicChantier.height
    //        grdDataGrid.height = grdDataGrid.height + FrameFicChantier.height
    //    Else
    //        FrameFicChantier.Visible = True
    //        'On charge la combo des libellés fiche chantier
    //        RemplirCombo cboFicChantierFO, "SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE INNER JOIN TCHANTIERCAN ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER" _
    //          & " WHERE VTYPE = 'F' AND NCANNUM = " & rsD("NDINCTE") & " AND VSOCIETE = '" & gstrNomSociete & "' ORDER BY VLIB", True
    //    End If
    //    
    //    RemplirListeArticles
    //    ' remplir les montants totaux
    //    Call RemplirTxtTotaux
    //  End If
    //  rsD.Close
    //  Exit Sub
    //  Resume
    //  
    //Handler:
    //  ShowError " initialiserFeuille dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        //  Si la DI n'est pas planifiée ou à planifier on ne peut pas créer de sortie
        if (mbFacture)
        {
          MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateLivr.Text == "")
        { // Date obligatoire

          MessageBox.Show(Resources.msg_saisie_date_retour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cmdDate_Click(null, null);
          return;
        }

        if (dtArticles.Rows.Count == 0)
        {
          MessageBox.Show(Resources.msg_EntrerArticle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (FrameFicChantier.Visible == true && cboFicChantierFO.Text == "")
        {
          MessageBox.Show(Resources.msg_selectLibelleFicheChantierFour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //  Alerte si le montant dépasse 100 euros
        if (Convert.ToDouble(txtHT.Text.Replace(" €", "")) < 100 && cboLieu.Text != "Magasin " + MozartParams.NomSociete)
        {
          if (MessageBox.Show(Resources.txt_envoi_transport_disproportionne
                            + "\r\nConfirmez-vous cet envoi ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                   == DialogResult.No)
            return;
        }

        CreationBL();

        //   Vérif si fournitures avec produit dangereux
        if (FouProduitDangerExist("TSTOCKDDE", miNumDdeSortie) == true)
        {
          MessageBox.Show("Attention, vous allez utiliser une fourniture classée 'Produit dangereux'.\r\n"
                        + "A la validation de votre sortie de stock, vous allez recevoir par mail les fiches des produits concernés.\r\n"
                        + "Vous devez transmettre ces fiches à l'utilisateur et les intégrer dans votre dossier DOE.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          // envoi du mail avec les fiches au créateur de la sortie de stock
          ModuleData.ExecuteNonQuery($"EXEC api_sp_EnvoiMailFicheProdDanger 'TSTOCKDDE', {miNumDdeSortie}, '{MozartParams.NomSociete}'");

        }

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //On Error GoTo Handler
    //
    //  bEnvoi = False
    //
    //  ' si la DI n'est pas planifiée ou à planifier on ne peut pas créer de sortie
    //  If frmStockListeDdeSortie.bFacture Then
    //    MsgBox "§Vous ne pouvez engager une dépense que sur une action 'A planifier' ou 'Planifiée'§", vbOKOnly
    //    Exit Sub
    //  End If
    //
    //  If txtDateLivr = "" Then        ' Date obligatoire
    //    MsgBox "§Il faut entrer une date de livraison !§", vbExclamation
    //    cmdDate_Click
    //    Exit Sub
    //  End If
    //  
    //  If rsarticle.EOF And rsarticle.BOF Then
    //    MsgBox "§Il faut entrer un article !§", vbExclamation
    //    Exit Sub
    //  End If
    //  
    //  If FrameFicChantier.Visible = True And cboFicChantierFO.Text = "" Then
    //    MsgBox "§Il faut sélectionner un libellé pour la fiche chantier Fournitures !§"
    //    Exit Sub
    //  End If
    //
    //  ' alerte si le montant dépasse 100 euros
    //  If CDbl(txtHT) < 100 And cboLieu.Text <> "Magasin " & gstrNomSociete Then
    //    If MsgBox("§ATTENTION : Vous allez faire un envoi pour lequel le coût du transport est disproportionné par rapport au coût des fournitures.§" _
    //      & vbCrLf & "Confirmez-vous cet-envoi?", vbYesNo, "Alerte") = vbNo Then
    //      Exit Sub
    //    Else
    //      bEnvoi = True
    //    End If
    //  End If
    //
    //  CreationBL
    //  
    //   'vérif si fournitures avec produit dangereux
    //  If FouProduitDangerExist("TSTOCKDDE", lNumDdeSortie) = True Then
    //  
    //        MsgBox "Attention, vous allez utiliser une fourniture classée 'Produit dangereux'." & vbCrLf & _
    //                "A la validation de votre sortie de stock, vous allez recevoir par mail les fiches des produits concernés." & vbCrLf & _
    //                "Vous devez transmettre ces fiches à l'utilisateur et les intégrer dans votre dossier DOE.", vbInformation
    //  
    //        'envoi du mail avec les fiches au créateur de la sortei de stock
    //        cnx.Execute ("EXEC api_sp_EnvoiMailFicheProdDanger 'TSTOCKDDE', " & lNumDdeSortie & ", '" & gstrNomSociete & "'")
    //  
    //  End If
    //  
    //  ' mise a jour du code de validation de la prepaCmde  ??? fred 10/04/14
    //'  frmPrepaCommande.mbStatValidation = True
    //
    //  Unload Me
    //'  InitialiserFeuille
    //  
    //Exit Sub
    //Handler:
    //  ShowError " cmdValider_Click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void CreationBL()
    {

      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDdeSortieStock", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@iDdeNum"].Value = miNumDdeSortie;
          if (optDest0.Checked)
          {
            cmd.Parameters["@TypeDest"].Value = "Personnel";
            cmd.Parameters["@LieuLivr"].Value = cboLieu.Text;
          }
          else if (optDest1.Checked)
          {
            cmd.Parameters["@TypeDest"].Value = "Site";
            cmd.Parameters["@LieuLivr"].Value = "Site";
          }
          else
          {
            cmd.Parameters["@TypeDest"].Value = "Sous-traitant";
            cmd.Parameters["@LieuLivr"].Value = "Sous-traitant";
          }

          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@vObjet"].Value = txtObjet.Text;
          cmd.Parameters["@dLivr"].Value = txtDateLivr.Text;
          cmd.Parameters["@TypeDde"].Value = "COMMANDE";
          cmd.Parameters["@PrixHT"].Value = txtHT.Text.Replace(" €", "");


          if (FrameFicChantier.Visible == true)
            cmd.Parameters["@nidfiche"].Value = cboFicChantierFO.GetItemData();
          else
            cmd.Parameters["@nidfiche"].Value = DBNull.Value;

          cmd.ExecuteNonQuery();
          miNumDdeSortie = (int)cmd.Parameters[0].Value;
        }

        // création des lignes articles
        CreationLigneArt();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationLigneArt()
    {
      try
      {
        //  Delete des lignes de commandes dans la tables TLART
        ModuleData.ExecuteNonQuery($"DELETE from TLART where NDDENUM = {miNumDdeSortie}");

        //  Parcours du recordset et création des lignes dans TLART
        foreach (DataRow item in dtArticles.Rows)
        {
          try
          {
            ModuleData.ExecuteNonQuery($"INSERT INTO TLART (NACTNUM, VLART, NLARTQTE, NFOUNUM, NDDENUM) values ({MozartParams.NumAction}, " +
                                       $"'{item["Article"].ToString().Replace("'", "''")}', {Utils.ZeroIfNull(item["Quantite"])}, " +
                                       $"{Utils.ZeroIfNull(item["NumArticle"])}, {miNumDdeSortie})");
          }
          catch (Exception)
          {
            MessageBox.Show(Resources.txt_art_doublon, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void optDest_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton rb = sender as RadioButton;
      if (rb.Name == "optDest1")
        txtLivr.Text = mstrSite;
      else
        txtLivr.Text = mstrTech;

      cboLieu.Visible = lblLabels0.Visible = (rb.Name == "optDest0");
    }

    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateLivr.Text, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;

      //  Minimum 3 jours sans les week-end donc le vendredi et le jeudi, il faut faire + 5 jours
      //  FG le 6/11/17 interdir les week et Férié
      if (Cal.Value.DayOfWeek == DayOfWeek.Saturday || Cal.Value.DayOfWeek == DayOfWeek.Sunday)
      {
        MessageBox.Show("La date ne doit pas être un week-end ou un jour férié !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // vendredi et jeudi + 5
      if (DateTime.Now.DayOfWeek == DayOfWeek.Friday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
      {
        if (Cal.Value < DateTime.Now.AddDays(5))
        {
          MessageBox.Show("La date doit être supérieure à J+3 (hors weekend) !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      else
      {
        if (Cal.Value < DateTime.Now.AddDays(3))
        {
          MessageBox.Show("La date doit être supérieure à J+3 !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }

      txtDateLivr.Text = Cal.Value.ToShortDateString();
    }

    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }

    public void InitRecordsetArticle()
    {
      try
      {
        // ajout des champs 
        dtArticles.Columns.Add("Serie", typeof(string));
        dtArticles.Columns.Add("Article", typeof(string));
        dtArticles.Columns.Add("Marque", typeof(string));
        dtArticles.Columns.Add("Type", typeof(string));
        dtArticles.Columns.Add("Reference", typeof(string));
        dtArticles.Columns.Add("PCB", typeof(int));
        dtArticles.Columns.Add("Prix U", typeof(double));
        dtArticles.Columns.Add("Quantite", typeof(long));
        dtArticles.Columns.Add("Prix T", typeof(double));
        dtArticles.Columns.Add("Fournisseur", typeof(string));
        dtArticles.Columns.Add("NumArticle", typeof(int));
        dtArticles.Columns.Add("NumFour", typeof(int));
        dtArticles.Columns.Add("NumSiteFour", typeof(int));

        DataColumn[] keys = new DataColumn[1];
        keys[0] = dtArticles.Columns["NumArticle"];
        dtArticles.PrimaryKey = keys;

        grdDataGrid.GridControl.DataSource = dtArticles;

        //FormatGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridArticle()
    {
      try
      {
        grdDataGrid.AddColumn(Resources.col_Serie, "Serie", 800);
        grdDataGrid.AddColumn(Resources.col_materiel, "Article", 2300);
        grdDataGrid.AddColumn(Resources.col_marque, "Marque", 1500);
        grdDataGrid.AddColumn(Resources.col_Type, "Type", 1500);
        grdDataGrid.AddColumn(Resources.col_reference, "Reference", 1200);
        grdDataGrid.AddColumn(Resources.col_pcb, "PCB", 800, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixU, "Prix U", 900, "## ##0.00", 1);
        grdDataGrid.AddColumn(Resources.col_qte2, "Quantite", 800, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixT, "Prix T", 0);
        grdDataGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
        //grdDataGrid.AddColumn(Resources.col_Fournisseur, "Fournisseur", 1400);
        //grdDataGrid.AddColumn(Resources.col_num_four, "NumFour", 0);
        //grdDataGrid.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

        dtArticles.Columns["VFOUSER"].ColumnName = "Serie";
        dtArticles.Columns["VFOUMAT"].ColumnName = "Article";
        dtArticles.Columns["VFOUMAR"].ColumnName = "Marque";
        dtArticles.Columns["VFOUREF"].ColumnName = "Reference";
        dtArticles.Columns["VFOUTYP"].ColumnName = "Type";
        dtArticles.Columns["NLARTQTE"].ColumnName = "Quantite";
        dtArticles.Columns["NFOUNBLOT"].ColumnName = "PCB";
        dtArticles.Columns["PRIXU"].ColumnName = "Prix U";
        dtArticles.Columns["NFOUNUM"].ColumnName = "NumArticle";

        dtArticles.Columns.Add("Prix T", typeof(string));
        dtArticles.Columns.Add("NumFour", typeof(int));
        dtArticles.Columns.Add("NumSiteFour", typeof(int));
        dtArticles.Columns.Add("Fournisseur", typeof(string));

        grdDataGrid.InitColumnList();
        grdDataGrid.DelockColumn("Quantite");
        dtArticles.Columns["Quantite"].ReadOnly = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void grdDataGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      RemplirTxtTotaux();
    }

    private void RemplirTxtTotaux()
    {
      double total = 0;
      //pour toutes les lignes de la grid
      foreach (DataRow row in dtArticles.Rows)
        total += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);

      txtHT.Text = Strings.FormatNumber(total, 2) + " €";
      txtTVA.Text = Strings.FormatNumber(total * MozartParams.TVA1 / 100, 2) + " €";
      txtTTC.Text = Strings.FormatNumber(total + (total * MozartParams.TVA1 / 100), 2) + " €";
    }

    /* Inutile --------------------------------------------------------------------------------- */
    //Sub RemplirListeArticles()
    //  Dim rsArt As New ADODB.Recordset
    //  
    //  On Error Resume Next
    //  
    //  rsarticle.MoveFirst:    Err.Clear
    //  While Not rsarticle.EOF
    //    rsarticle.Delete
    //    rsarticle.MoveFirst
    //  Wend
    //  
    //  rsArt.Open "EXEC api_sp_RetourArticlesBL " & lNumDdeSortie, cnx
    //  While Not rsArt.EOF
    //    rsarticle.AddNew
    //    rsarticle!Serie = rsArt!VFOUSER
    //    rsarticle!ARTICLE = rsArt!VFOUMAT
    //    rsarticle!Marque = rsArt!VFOUMAR
    //    rsarticle!Type = rsArt!VFOUTYP
    //    rsarticle!Reference = rsArt!VFOUREF
    //    rsarticle!PCB = rsArt!NFOUNBLOT
    //    rsarticle("Prix U") = rsArt!PRIXU
    //    rsarticle!Quantite = rsArt!NLARTQTE
    //    rsarticle("Prix T") = rsArt!PRIXU * rsArt!NLARTQTE
    //    'rsarticle!Fournisseur = rsArt!
    //    rsarticle!NumArticle = rsArt!NFOUNUM
    //    'rsarticle!NumFour = rsArt!
    //    'rsarticle!NumSiteFour = rsArt!
    //    rsarticle.Update
    //    rsArt.MoveNext
    //  Wend
    //  
    //End Sub

    /* Inutile --------------------------------------------------------------------------------- */
    //Sub MajRsarticle()
    //  
    //  On Error Resume Next
    //  
    //'  rs.Filter
    //  
    //  rs.MoveFirst
    //  While Not rs.EOF
    //    If rs!stock And rs!Quantite > 0 Then
    //      rsarticle.AddNew
    //      rsarticle!Serie = rs!Serie
    //      rsarticle!ARTICLE = rs!ARTICLE
    //      rsarticle!Marque = rs!Marque
    //      rsarticle!Type = rs!Type
    //      rsarticle!Reference = rs!Reference
    //      rsarticle!PCB = rs!PCB
    //      rsarticle("Prix U") = rs("Prix U")
    //      rsarticle!Quantite = rs!Quantite
    //      rsarticle("Prix T") = rs("Prix U") * rs!Quantite
    //      'rsarticle!Fournisseur = rsArt!
    //      rsarticle!NumArticle = rs!NumArticle
    //      'rsarticle!NumFour = rsArt!
    //      'rsarticle!NumSiteFour = rsArt!
    //      rsarticle.Update
    //    End If
    //    rs.MoveNext
    //  Wend
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdListe_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      new frmChoixArtReapproTech() { mdtArticles = dtArticles }.ShowDialog();

      RemplirTxtTotaux();
    }

    /* OK ------Gestion de tous les boutons de type 'Fourniture' ------------- */
    private void cmdOutillage_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmChoixArtNewTech()
      {
        mstrType = (sender as Control).Tag.ToString(),
        mstrTitre = (sender as Control).Text,
        mdtArticles = dtArticles
      }.ShowDialog();

      RemplirTxtTotaux();
    }

    public bool FouProduitDangerExist(string sType, long lID)
    {
      switch (sType)
      {
        case "TCOM":
        case "TSTOCKDDE":
          return (int)ModuleData.ExecuteScalarInt($"EXEC api_sp_FouFicheProdDangerExist '{sType}', {lID}") > 0;
        default:
          MessageBox.Show("Mod Main: FouProduitDangerExist() - Type non reconnu", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}