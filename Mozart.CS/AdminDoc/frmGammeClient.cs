using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGammeClient : Form
  {
    public string mstrStatut;
    public long miNumTrame;

    private long inumGE;
    private string sFichier = "";
    private string adorsVFICHIER = "";

    //Public mstrStatut As String
    //Public miNumTrame As Long
    //
    //Dim NbCoche
    //Dim sFichier As String
    //Dim inumGE As Long
    //
    //Dim adors As ADODB.Recordset

    public frmGammeClient()
    {
      InitializeComponent();
    }

    private void frmGammeClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //   combo des clients
        apicboClient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500);
        if (mstrStatut == "V")
        {
          cmdValider.Enabled = false;
          cmdAjout.Enabled = false;
          cmdRechercher.Enabled = false;
          Label14.Text = Resources.msg_visu_trame_client;

          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeClient " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              apicboClient.SetText(dr[2].ToString());
              inumGE = Convert.ToInt64(dr["Num"]);

              txtGamme.Text = dr["GE"].ToString();
              txtAE.Text = "GE" + Strings.Format(inumGE, "000");
              txtTitre.Text = dr["VGAMTYPE"].ToString();

              chkLiaisonStock.Checked = Utils.BlankIfNull(dr["BSTOCKLIE"].ToString()) == "true";
              adorsVFICHIER = dr["VFICHIER"].ToString();

              // en mode visu => on change le type pour utiliser Text
              cboContrat.DropDownStyle = ComboBoxStyle.Simple;
              cboContrat.Text = Utils.BlankIfNull(dr["VTYPECONTRAT"]);
              cboContrat.Enabled = false;

              apicboClient.Enabled = false;

              cmdFichier.Enabled = false;

              if (Utils.BlankIfNull(dr["VFICHIER"].ToString()) != "")
                WebBrowser1.Navigate(dr["VFICHIER"].ToString());
            }
            dr.Close();
          }

          RemplirListes();            // liste des catégories
          CocherLesCat();             // cocher les catégories
          //RemplirCboTypeContrat();    // combo des types
        }
        else if (mstrStatut == "Mod")
        {
          Label14.Text = Resources.msg_modif_gamme_client;
          cmdValider.Enabled = true;
          cmdRechercher.Enabled = false;

          //    ouverture du recordset
          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeClient " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              apicboClient.SetText(dr[2].ToString());
              inumGE = Convert.ToInt64(dr["Num"]);

              txtGamme.Text = dr["GE"].ToString();
              txtAE.Text = "GE" + Strings.Format(inumGE, "000");
              txtTitre.Text = dr["VGAMTYPE"].ToString();

              chkLiaisonStock.Checked = Utils.BlankIfNull(dr["BSTOCKLIE"].ToString()) == "true";

              RemplirCboTypeContrat();    // combo des types
              cboContrat.Text = Utils.BlankIfNull(dr["VTYPECONTRAT"]);

              lstCat.TabIndex = 1;
              apicboClient.Enabled = false;

              if (Utils.BlankIfNull(dr["VFICHIER"].ToString()) != "")
              {
                cmdAjout.Enabled = false;
                sFichier = dr["VFICHIER"].ToString();
                WebBrowser1.Navigate(dr["VFICHIER"].ToString());
              }
            }
            dr.Close();
          }
          RemplirListes();            // liste des catégories
          CocherLesCat();             // cocher les catégories
          //RemplirCboTypeContrat();    // combo des types
        }
        else if (mstrStatut == "M")
        {
          //    copie de la gamme
          Label14.Text = Resources.msg_copie_gamme_client;
          cmdValider.Enabled = true;

          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeClient " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              apicboClient.Text = dr[2].ToString();
              inumGE = Convert.ToInt64(dr["Num"]);

              txtGamme.Text = dr["GE"].ToString();

              txtAE.Text = "GE" + Strings.Format(inumGE, "000");
              txtTitre.Text = dr["VGAMTYPE"].ToString();

              chkLiaisonStock.Checked = Utils.BlankIfNull(dr["BSTOCKLIE"].ToString()) == "true";

              RemplirCboTypeContrat();    // combo des types
              cboContrat.Text = Utils.BlankIfNull(dr["VTYPECONTRAT"]);

              apicboClient.Enabled = true;
              lstCat.TabIndex = 1;
            }
            dr.Close();
          }
          RemplirListes();            // liste des catégories
          CocherLesCat();             // cocher les catégories
          //RemplirCboTypeContrat();    // combo des types
        }
        else  // création
        {
          txtTitre.Text = "";
          Label14.Text = Resources.msg_create_gamme_client;
          cmdValider.Enabled = true;
          cmdAjout.Enabled = false;
        }

        //  si on selectionne une gamme fichier
        Frame1.Visible = !(inumGE == 0 && mstrStatut != "C");
        frameVisu.Visible = cmdFichier.Visible = (inumGE == 0 && mstrStatut != "C");

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  
    //  On Error GoTo handler
    //  
    //  ' initialisation des images
    //  InitBoutons Me, frmMenu
    //  
    //   ' combo des clients
    //  RemplirComboClient cboclient
    //  cboclient.SizeCombo 800
    //  
    //  If mstrStatut = "V" Then
    //    cmdValider.Enabled = False
    //    cmdAjout.Enabled = False
    //    cmdRechercher.Enabled = False
    //    Label1(4).Caption = "§Visualisation des trames de gamme d'un client§"
    //  
    //    ' combo des types
    // '   RemplirComboType "NON"
    //    
    //    ' ouverture du recordset
    //    Set adors = New ADODB.Recordset
    //    adors.Open "api_sp_InfoTramesGammeClient " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //  
    //    txtNum = adors(0)
    //    txtDate = adors(1)
    //    cboclient.Text = adors(2)
    //    inumGE = adors("Num")
    //    txtGamme = adors("GE")
    //    txtAE = "GE" & Format(inumGE, "000")
    //    txtTitre = adors("VGAMTYPE")
    //    chkLiaisonStock.value = IIf(ZeroIfNull(adors!BSTOCKLIE), 1, 0)
    //    
    //    ' liste des catégories
    //    RemplirListes
    //    ' cocher les catégories
    //    CocherLesCat
    //      
    //    ' combo des types de contrat
    //    
    //    RemplirCboTypeContrat
    //    cboContrat.Text = adors("VTYPECONTRAT")
    //    
    //    
    //     On Error GoTo handler
    //
    //    cboclient.Enabled = False
    //    cboContrat.Enabled = False
    //    cmdFichier.Enabled = False
    //    
    //    If BlankIfNull(adors("VFICHIER")) <> "" Then
    //      WebBrowser1.Navigate adors("VFICHIER")
    //    End If
    //    
    //  ElseIf mstrStatut = "Mod" Then
    //  
    //    Label1(4).Caption = "§Modification des trames de gamme d'un client§"
    //    cmdValider.Enabled = True
    //    cmdRechercher.Enabled = False
    //  
    //    ' ouverture du recordset
    //    Set adors = New ADODB.Recordset
    //    adors.Open "api_sp_InfoTramesGammeClient " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //  
    //    txtNum = adors(0)
    //    txtDate = adors(1)
    //    cboclient.Text = adors(2)
    //    inumGE = adors("Num")
    //    txtGamme = adors("GE")
    //    txtAE = "GE" & Format(inumGE, "000")
    //    txtTitre = adors("VGAMTYPE")
    //    chkLiaisonStock.value = IIf(ZeroIfNull(adors!BSTOCKLIE), 1, 0)
    //    
    //    ' liste des catégories
    //    RemplirListes
    //    ' cocher les catégories
    //    CocherLesCat
    //   
    //    ' combo des types de contrat
    //    RemplirCboTypeContrat
    //    On Error Resume Next
    //    cboContrat.Text = adors("VTYPECONTRAT")
    //    
    //    lstCat.TabIndex = 1
    //    cboclient.Enabled = False
    //    
    //    If BlankIfNull(adors("VFICHIER")) <> "" Then
    //      cmdAjout.Enabled = False
    //      sFichier = adors("VFICHIER")
    //      WebBrowser1.Navigate adors("VFICHIER")
    //    End If
    //  
    //  ElseIf mstrStatut = "M" Then
    //  
    //    ' copie de la gamme
    //    Label1(4).Caption = "§Copie de la gamme d'un client§"
    //    cmdValider.Enabled = True
    // 
    //    ' ouverture du recordset
    //    Set adors = New ADODB.Recordset
    //    adors.Open "api_sp_InfoTramesGammeClient " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //  
    //    txtNum = adors(0)
    //    txtDate = adors(1)
    //    cboclient.Text = adors(2)
    //    inumGE = adors("Num")
    //    txtGamme = adors("GE")
    //    txtAE = "GE" & Format(inumGE, "000")
    //    txtTitre = adors("VGAMTYPE")
    //    chkLiaisonStock.value = IIf(ZeroIfNull(adors!BSTOCKLIE), 1, 0)
    //    
    //    ' liste des catégories
    //    RemplirListes
    //    ' cocher les catégories
    //    CocherLesCat
    //    
    //    ' combo des types de contrat
    //    RemplirCboTypeContrat
    //    cboContrat.Text = adors("VTYPECONTRAT")
    //  
    //    cboclient.Enabled = True
    //    lstCat.TabIndex = 1
    //   
    //  Else  ' création
    //      
    //    txtTitre = ""
    //    
    //    Label1(4).Caption = "§Création des trames de gamme d'un client§"
    //    cmdValider.Enabled = True
    //    cmdAjout.Enabled = False
    //  End If
    //  
    //  'si on selectionne une gamme fichier
    //  If inumGE = 0 And mstrStatut <> "C" Then
    //    Frame1.Visible = False
    //    frameVisu.Visible = True
    //    cmdFichier.Visible = True
    //  Else
    //    Frame1.Visible = True
    //    frameVisu.Visible = False
    //    cmdFichier.Visible = False
    //  End If
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (apicboClient.GetText() == "")
      {
        MessageBox.Show(Resources.msg_select_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (txtGamme.Text == "")
      {
        MessageBox.Show(Resources.msg_select_gamme_type, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (cboContrat.Text == "")
      {
        MessageBox.Show(Resources.msg_must_select_contrat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (mstrStatut == "M") // copie ?
      {
        // confirmation
        if (MessageBox.Show(Resources.msg_confirm_creation_trame_client, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;
      }
      else if (mstrStatut == "Mod")
      {
        ModifierGamme();
        return;
      }

      // creation de la gamme
      int NumTrameClient = (int)ModuleData.ExecuteScalarInt("select max(NTRACLINUM) from TGAMCLIENT");

      //  ' dernier numéro créé
      miNumTrame = NumTrameClient + 1;

      //   cas de la gamme pdf
      if (inumGE == 0)
      {
        if (Utils.BlankIfNull(sFichier) == "")
        {
          MessageBox.Show(Resources.msg_must_select_file, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // execution de la requête d'insert
        string sSql = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE, NTYPECONTRAT, VFICHIER) ";
        sSql += "Values ( " + miNumTrame + ", ";
        sSql += apicboClient.GetItemData() + ", 0,'" + txtTitre.Text.Replace("'", "''") + "', '";
        sSql += DateTime.Now.ToShortDateString() + "', " + inumGE + ", 'O', " + (chkLiaisonStock.Checked ? "1" : "0") + "," + cboContrat.Text + ",'" + MozartParams.CheminModeles + @"GAMME\" + miNumTrame + ".pdf" + "')";
        ModuleData.ExecuteNonQuery(sSql);

        File.Copy(sFichier, MozartParams.CheminModeles + @"GAMME\" + miNumTrame + ".pdf");
      }
      else
      {
        // si aucune ligne selectionnée
        if (lstCat.CheckedItems.Count == 0)
        {
          MessageBox.Show(Resources.msg_must_select_one_gamme, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée et pour chaque site
        string sSql = "";
        foreach (DataRowView item in lstCat.CheckedItems)
        {
          // execution de la requête d'insert
          sSql = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE, NTYPECONTRAT)\r\n "
               + "Values (" + miNumTrame + ", "
               + apicboClient.GetItemData() + ", " + item.Row["NGAMTRAMENUM"].ToString() + ", '" + txtTitre.Text.Replace("'", "''") + "', '"
               + DateTime.Now.ToShortDateString() + "', " + inumGE + ", 'O', " + (chkLiaisonStock.Checked ? "1" : "0") + ", " + cboContrat.SelectedValue + ")";
          ModuleData.ExecuteNonQuery(sSql);
        }
      }

      cmdValider.Enabled = false;
      cmdAjout.Enabled = true;
      Cursor.Current = Cursors.Default;

      if (mstrStatut == "C")
        mstrStatut = "Mod";

      //Form_Load()
    }
    //Private Sub cmdValider_Click()
    //Dim fs As New FileSystemObject
    //Dim sSQL As String
    //Dim i, j As Integer
    //Dim rsSite As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  If cboclient.Text = "" Then
    //    MsgBox "§Sélectionnez un client§"
    //    Exit Sub
    //  End If
    //  
    //  If txtGamme.Text = "" Then
    //    MsgBox "§Sélectionnez un type de gamme§"
    //    Exit Sub
    //  End If
    //  
    //  If cboContrat.Text = "" Then
    //    MsgBox "§Sélectionnez un type de contrat§"
    //    Exit Sub
    //  End If
    //  
    //  If mstrStatut = "M" Then
    //    ' confirmation
    //    If MsgBox("§Vous allez créer une nouvelle trame pour ce client. Etes vous d'accord ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //        Exit Sub
    //    End If
    //  ElseIf mstrStatut = "Mod" Then
    //    ModifierGamme
    //    Exit Sub
    //  End If
    //  
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "select max(NTRACLINUM) from TGAMCLIENT "
    //  rsSite.Open sSQL, cnx
    //       
    //  ' dernier numéro créé
    //  i = ZeroIfNull(rsSite(0))
    //  miNumTrame = i + 1
    //  
    //  ' cas de la gamme pdf
    //  If inumGE = 0 Then
    //    If BlankIfNull(sFichier) = "" Then
    //      MsgBox "§Sélectionnez un fichier§"
    //      Exit Sub
    //    End If
    //      
    //      ' execution de la requête d'insert
    //    sSQL = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE, NTYPECONTRAT, VFICHIER) "
    //    sSQL = sSQL & "Values ( " & (i + 1) & ", "
    //    sSQL = sSQL & cboclient.ItemData(cboclient.ListIndex) & ", 0,'" & Replace(txtTitre, "'", "''") & "', '"
    //    sSQL = sSQL & Date & "', " & inumGE & ", 'O', " & chkLiaisonStock.value & "," & cboContrat.ItemData(cboContrat.ListIndex) & ",'" & RechercheParam("REP_MODELES") & "GAMME\" & miNumTrame & ".pdf" & "')"
    //    cnx.Execute sSQL
    //
    //    fs.CopyFile sFichier, RechercheParam("REP_MODELES") & "GAMME\" & miNumTrame & ".pdf"
    //    
    //  Else
    //    
    //    ' parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée
    //    ' et pour chaque site
    //    Dim aux
    //    aux = 0
    //    For j = 0 To lstCat.ListCount - 1
    //      If lstCat.Selected(j) = True Then
    //          aux = aux + 1
    //        ' execution de la requête d'insert
    //          sSQL = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE, NTYPECONTRAT) "
    //          sSQL = sSQL & "Values ( " & (i + 1) & ", "
    //          sSQL = sSQL & cboclient.ItemData(cboclient.ListIndex) & ",  " & lstCat.ItemData(j) & ",'" & Replace(txtTitre, "'", "''") & "', '"
    //          sSQL = sSQL & Date & "', " & inumGE & ", 'O', " & chkLiaisonStock.value & "," & cboContrat.ItemData(cboContrat.ListIndex) & ")"
    //          cnx.Execute sSQL
    //      End If
    //    Next
    //     
    //    ' si aucune ligne selectionnée
    //    If aux = 0 Then
    //      MsgBox "§Sélectionnez au moins une ligne de la gamme§"
    //      Exit Sub
    //    End If
    //
    //  End If
    //
    //  cmdValider.Enabled = False
    //  cmdAjout.Enabled = True
    //  Screen.MousePointer = vbDefault
    //
    //  If mstrStatut = "C" Then mstrStatut = "Mod"
    //
    //  Form_Load
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdValider dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdAjout_Click(object sender, EventArgs e)
    {
      if (miNumTrame == 0) return;

      frmSaisieDetailGam f = new frmSaisieDetailGam();
      f.miNumTrame = Convert.ToInt64(lstCat.SelectedValue);
      f.miClient = Convert.ToInt64(apicboClient.GetItemData());
      f.miSite = 0;
      f.miNumGamCli = miNumTrame;
      f.ShowDialog();

      // rafraichissement écran
      RemplirListes();

      CocherLesCat();
    }
    //Private Sub cmdAjout_Click()
    //  
    // frmSaisieDetailGam.miNumTrame = lstCat.ItemData(lstCat.ListIndex)
    // frmSaisieDetailGam.miClient = cboclient.ItemData(cboclient.ListIndex)
    // frmSaisieDetailGam.miSite = 0
    // frmSaisieDetailGam.miNumGamCli = miNumTrame
    // frmSaisieDetailGam.Show vbModal
    // 
    // ' rafraichissement écran
    // RemplirListes
    //
    // CocherLesCat
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdFichier_Click(object sender, EventArgs e)
    {
      CommonDialog1.Title = Resources.msg_select_image_file;
      CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      CommonDialog1.FilterIndex = 1;
      if (CommonDialog1.ShowDialog() == DialogResult.OK)
        WebBrowser1.Navigate(CommonDialog1.FileName);
    }
    //Private Sub cmdFichier_Click()
    //  On Error GoTo errHandler
    //  
    //  ' Attribue à CancelError la valeur True
    //  CommonDialog1.CancelError = True
    //  ' Définit la propriété Flags
    //  CommonDialog1.flags = cdlOFNHideReadOnly
    //  ' titre de la aboite
    //  CommonDialog1.DialogTitle = "§Choix d'un fichier image§"
    //    
    //  CommonDialog1.Filter = "Fichiers PDF (*.PDF)|*.PDF"
    //  CommonDialog1.FilterIndex = 1
    //    
    //  ' Affiche la boîte de dialogue Ouverture
    //  On Error GoTo ExitHandler
    //  CommonDialog1.ShowOpen
    //  On Error GoTo errHandler
    //  
    //  sFichier = CommonDialog1.FileName
    //  
    //  ' Afficher l'image
    //'  AfficheImg CommonDialog1.FileName
    //  WebBrowser1.Navigate "about:blank"
    //  WebBrowser1.Navigate sFichier
    //  
    //  ' Affiche le nom du fichier sélectionné
    //  'ts = Split(CommonDialog1.FileName, "\")
    //  'TextFic = ts(UBound(ts))
    //  'bModif = True
    //
    //ExitHandler:
    //  Exit Sub
    //
    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "cmdFichier_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void ModifierGamme()
    {
      if (inumGE == 0)
      {
        if (Utils.BlankIfNull(sFichier) == "")
        {
          MessageBox.Show(Resources.msg_must_select_file, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //    execution de la requête d'insert
        string sSql = "UPDATE TGAMCLIENT SET VGAMTYPE = '" + txtTitre.Text.Replace("'", "''") + "', BSTOCKLIE = '" + (chkLiaisonStock.Checked ? "1" : "0") +
               "', NTYPECONTRAT = " + cboContrat.Text + ", VFICHIER = '" + MozartParams.CheminModeles + @"GAMME\" + miNumTrame + ".pdf" +
               "' WHERE NTRACLINUM= " + miNumTrame + " AND NCLINUM = " + apicboClient.GetItemData();
        ModuleData.ExecuteNonQuery(sSql);

        if (adorsVFICHIER != sFichier)
        {
          File.Delete(adorsVFICHIER);
          File.Copy(sFichier, MozartParams.CheminModeles + @"GAMME\" + miNumTrame + ".pdf");
        }
      }
      else
      {
        DataTable dtDet = new DataTable();
        string sSql = "select NGAMTRAMENUM, VTRACLIDET from  TGAMCLIENT WHERE VTRACLIDET is not null AND NTRACLINUM= " + miNumTrame + " AND NCLINUM = " + apicboClient.GetItemData();
        dtDet.Load(ModuleData.ExecuteReader(sSql));

        sSql = "delete from  TGAMCLIENT WHERE NTRACLINUM= " + miNumTrame + " AND NCLINUM = " + apicboClient.GetItemData();
        ModuleData.ExecuteNonQuery(sSql);

        //    parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée et pour chaque site
        foreach (DataRowView item in lstCat.CheckedItems)
        {
          // execution de la requête d'insert
          sSql = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE) "
             + "Values ( " + miNumTrame + ", "
             + apicboClient.GetItemData() + ",  " + item["NGAMTRAMENUM"].ToString() + ",'" + txtTitre.Text.Replace("'", "''") + "', "
             + cboContrat.SelectedValue + ", '"
             + DateTime.Now.ToShortDateString() + "', " + inumGE + ", 'O'," + (chkLiaisonStock.Checked ? "1" : "0") + ")";

          ModuleData.ExecuteNonQuery(sSql);
        }

        //  on remet les détails existants
        for (int i = 0; i < dtDet.Rows.Count; i++)
        {
          sSql = "update TGAMCLIENT set VTRACLIDET = '" + ((DataRow)dtDet.Rows[i])["VTRACLIDET"].ToString().Replace("'", "''") + "' "
        + " WHERE NTRACLINUM= " + miNumTrame + " AND NCLINUM = " + apicboClient.GetItemData()
        + " AND NGAMTRAMENUM =  " + ((DataRow)dtDet.Rows[i])["NGAMTRAMENUM"].ToString();
          ModuleData.ExecuteNonQuery(sSql);
        }
      }
    }
    //Private Sub ModifierGamme()
    //Dim fs As New FileSystemObject
    //Dim sSQL As String
    //Dim i, j As Integer
    //Dim rsDet As ADODB.Recordset
    //
    //  On Error Resume Next
    //  
    //  ' cas de la gamme pdf
    //  If inumGE = 0 Then
    //    If BlankIfNull(sFichier) = "" Then
    //      MsgBox "§Sélectionnez un fichier§"
    //      Exit Sub
    //    End If
    //      
    //    ' execution de la requête d'insert
    //    sSQL = "UPDATE TGAMCLIENT SET VGAMTYPE = '" & Replace(txtTitre, "'", "''") & "', BSTOCKLIE = '" & chkLiaisonStock.value & _
    //           "', NTYPECONTRAT = " & cboContrat.ItemData(cboContrat.ListIndex) & ", VFICHIER = '" & RechercheParam("REP_MODELES") & "GAMME\" & miNumTrame & ".pdf" & _
    //           "' WHERE NTRACLINUM= " & miNumTrame & " AND NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    
    //    cnx.Execute sSQL
    //    
    //    If adors("VFICHIER") <> sFichier Then
    //      fs.DeleteFile adors("VFICHIER")
    //      fs.CopyFile sFichier, RechercheParam("REP_MODELES") & "GAMME\" & miNumTrame & ".pdf"
    //    End If
    //
    //  Else
    //  
    //    Set rsDet = New ADODB.Recordset
    //    sSQL = "select NGAMTRAMENUM, VTRACLIDET from  TGAMCLIENT WHERE VTRACLIDET is not null AND NTRACLINUM= " & miNumTrame & " AND NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    rsDet.Open sSQL, cnx
    //         
    //    sSQL = "delete from  TGAMCLIENT WHERE NTRACLINUM= " & miNumTrame & " AND NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    cnx.Execute sSQL
    //         
    //    ' parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée
    //    ' et pour chaque site
    //    For j = 0 To lstCat.ListCount - 1
    //      If lstCat.Selected(j) = True Then
    //        ' execution de la requête d'insert
    //          sSQL = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE) "
    //          sSQL = sSQL & "Values ( " & miNumTrame & ", "
    //          sSQL = sSQL & cboclient.ItemData(cboclient.ListIndex) & ",  " & lstCat.ItemData(j) & ",'" & Replace(txtTitre, "'", "''") & "', "
    //          sSQL = sSQL & cboContrat.ItemData(cboContrat.ListIndex) & ", '"
    //          sSQL = sSQL & Date & "', " & inumGE & ", 'O'," & chkLiaisonStock.value & ")"
    //          cnx.Execute sSQL
    //      End If
    //    Next
    //  
    //    ' on remet les détails existants
    //    While Not rsDet.EOF
    //      sSQL = "update TGAMCLIENT set VTRACLIDET = '" & Replace(rsDet("VTRACLIDET"), "'", "''") & "' "
    //      sSQL = sSQL & " WHERE NTRACLINUM= " & miNumTrame & " AND NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //      sSQL = sSQL & " AND NGAMTRAMENUM =  " & rsDet("NGAMTRAMENUM")
    //      cnx.Execute sSQL
    //      rsDet.MoveNext
    //    Wend
    //  End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void apicboClient_Leave(object sender, EventArgs e)
    {
      // si copie de gamme ne pas tout changer
      if (mstrStatut == "M")
      {
        // combo des types de contrat
        RemplirCboTypeContrat();
        return;
      }

      if (apicboClient.GetItemData() != -1)
        // combo des types de contrat
        RemplirCboTypeContrat();
      else
        cboContrat.Items.Clear();
    }
    //Private Sub cboclient_Click()
    //On Error GoTo handler
    //  ' si copie de gamme ne pas tout changer
    //  If mstrStatut = "M" Then
    //        ' combo des types de contrat
    //      RemplirCboTypeContrat
    //      Exit Sub
    //  End If
    //
    //  If cboclient.ListIndex <> 0 Then
    //    
    //    ' combo des types de contrat
    //    RemplirCboTypeContrat
    //    
    //  Else
    //    cboContrat.Clear
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cboClient_click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirCboTypeContrat()
    {
      ModuleData.RemplirCombo(cboContrat, "api_sp_TypeContratClient " + apicboClient.GetItemData());
      cboContrat.ValueMember = "NTYPECONTRAT";
      cboContrat.DisplayMember = "VCONTRAT";
    }
    //Private Sub RemplirCboTypeContrat()
    //
    //Dim i As Integer
    //Dim pRS As ADODB.Recordset
    //
    //  
    //  ' vider les combos
    //  cboContrat.Clear
    //    
    //  ' les contrats du client uniquement
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "api_sp_TypeContratClient " & cboclient.ItemData(cboclient.ListIndex), cnx
    //  
    //  cboContrat.AddItem ""
    //  cboContrat.ItemData(0) = 0
    //    
    //  i = 1
    //  While Not pRS.EOF
    //    cboContrat.AddItem CStr(pRS(0))
    //    cboContrat.ItemData(i) = pRS(1)
    //    pRS.MoveNext
    //    i = i + 1
    //  Wend
    //  cboContrat.ListIndex = 0
    //
    //  pRS.Close
    //  
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListes()
    {
      RemplirListeCategories();
      RemplirListeDetails();
    }
    //Private Sub RemplirListes()
    //  RemplirListeCategories
    //  RemplirListeDetails
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListeCategories()
    {
      DataTable dtCat = new DataTable();
      //  Liste de toutes les categories EMALEC
      string sSQL = "select VGAMPARA + ': ' + coalesce(VGAMLIB,'') [VGAMLIB], NGAMTRAMENUM from TGAMTRAMESEMALEC WHERE NTRAEMANUM = " + inumGE + " order by NGAMNUMPARA, NGAMNUMLIB";
      using (SqlDataReader dataReader = ModuleData.ExecuteReader(sSQL))
      {
        dtCat.Load(dataReader);
        dataReader.Close();
      }
      lstCat.DataSource = dtCat;
      lstCat.DisplayMember = "VGAMLIB";
      lstCat.ValueMember = "NGAMTRAMENUM";
    }
    //Private Sub RemplirListeCategories()
    //Dim rsFou As ADODB.Recordset
    //Dim i As Integer
    //On Error GoTo handler
    //  
    //  Set rsFou = New ADODB.Recordset
    //  rsFou.Open "select VGAMPARA + ': ' + coalesce(VGAMLIB,'') , NGAMTRAMENUM from TGAMTRAMESEMALEC WHERE NTRAEMANUM = " & inumGE & " order by NGAMNUMPARA, NGAMNUMLIB", cnx
    //  
    //  ' vider la listeBox
    //  lstCat.Clear
    //  
    //  i = 0
    //  While Not rsFou.EOF
    //    lstCat.AddItem rsFou(0)
    //    lstCat.ItemData(i) = rsFou(1)
    //    rsFou.MoveNext
    //    i = i + 1
    //  Wend
    //  rsFou.Close
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " RemplirListeCategories dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListeDetails()
    {
      DataTable dtFou = new DataTable();

      using (SqlDataReader dataReader = ModuleData.ExecuteReader($"EXEC api_sp_ListeDetailGammeCli " + inumGE + ", " + miNumTrame))
      {
        dtFou.Load(dataReader);
        dataReader.Close();
      }

      lstDet.DataSource = dtFou;
      lstDet.DisplayMember = "VTRASITDET";
      lstDet.ValueMember = "NGAMTRAMENUM";
    }
    //Private Sub RemplirListeDetails()
    //
    //Dim rsFou As ADODB.Recordset
    // 
    //Dim i As Integer
    //Dim sSQL As String
    //
    //On Error GoTo handler
    //  
    //  Set rsFou = New ADODB.Recordset
    //  rsFou.Open "exec api_sp_ListeDetailGammeCli " & inumGE & ", " & miNumTrame, cnx
    //  
    //  ' vider la listeBox
    //  lstDet.Clear
    //  
    //  i = 0
    //  While Not rsFou.EOF
    //    lstDet.AddItem rsFou(0)
    //    lstDet.ItemData(i) = rsFou(1)
    //    rsFou.MoveNext
    //    i = i + 1
    //  Wend
    //  rsFou.Close
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " RemplirListeDetails dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      //    Ouvrir une liste de recherche de la gamme
      frmApiRecherche f = new frmApiRecherche(MozartDatabase.cnxMozart);
      f.msType = "GAM";
      f.msSql = "select distinct NTRAEMANUM, VGAMTYPE as GAMME, 'GE' + convert(varchar(5), NTRAEMANUM) 'N°', VPAYSNOM as PAYS from TGAMTRAMESEMALEC INNER JOIN TPAYS ON TGAMTRAMESEMALEC.NPAYSNUM = TPAYS.NPAYSNUM  WHERE CTRAEMAACTIF='O' UNION SELECT 0, 'GAMME FICHIER EXTERNE', '', '' order by VGAMTYPE";
      f.ShowDialog();
      if (f.msRetour != "")
      {
        txtGamme.Text = f.msRetour;
        inumGE = f.mlItemData;
        // liste des catégories
        RemplirListes();
        // cocher les catégories
        CocherLesCat();
        txtAE.Text = "GE" + Strings.Format(f.mlItemData, "000");
        f.Dispose();
      }

      //  si on selectionne une gamme fichier
      Frame1.Visible = inumGE != 0;
      frameVisu.Visible = cmdFichier.Visible = inumGE == 0;
    }
    //Private Sub cmdRechercher_Click()
    //    
    //    ' Ouvrir une liste de recherche de la gamme
    //    frmApiRecherche.msSql = "select distinct NTRAEMANUM, VGAMTYPE as GAMME, 'GE' + convert(varchar(5), NTRAEMANUM) 'N°', VPAYSNOM as PAYS from TGAMTRAMESEMALEC INNER JOIN TPAYS ON TGAMTRAMESEMALEC.NPAYSNUM = TPAYS.NPAYSNUM  WHERE CTRAEMAACTIF='O' UNION SELECT 0, 'GAMME FICHIER EXTERNE', '', '' order by VGAMTYPE"
    //    frmApiRecherche.msType = "GAM"
    //    frmApiRecherche.Show vbModal
    //    If frmApiRecherche.msRetour <> "" Then
    //      txtGamme = frmApiRecherche.msRetour
    //      inumGE = frmApiRecherche.mlItemData
    //      ' liste des catégories
    //      RemplirListes
    //      ' cocher les catégories
    //      CocherLesCat
    //      txtAE = "GE" & Format(frmApiRecherche.mlItemData, "000")
    //    End If
    //
    //  'si on selectionne une gamme fichier
    //  If inumGE = 0 Then
    //    Frame1.Visible = False
    //    frameVisu.Visible = True
    //    cmdFichier.Visible = True
    //  Else
    //    Frame1.Visible = True
    //    frameVisu.Visible = False
    //    cmdFichier.Visible = False
    //  End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdCocherTC_Click(object sender, EventArgs e)
    {
      //  Cocher toutes les lignes
      for (int i = 0; i <= (lstCat.Items.Count - 1); i++)
        lstCat.SetItemChecked(i, true);

      lblNbSitesC.Text = lblNbSitesC.Tag + CompterCoche().ToString();
    }
    //Private Sub cmdCocherTC_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstCat.ListCount - 1
    //      lstCat.Selected(i) = True
    //  Next
    //  lblNbSitesC = lblNbSitesC.Tag & CompterCoche
    //
    //Exit Sub
    //handler:
    //  ShowError " cmdCocherTC_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdDecocherTC_Click(object sender, EventArgs e)
    {
      //  Décocher toutes les lignes
      for (int i = 0; i <= (lstCat.Items.Count - 1); i++)
        lstCat.SetItemChecked(i, false);

      lblNbSitesC.Text = lblNbSitesC.Tag + CompterCoche().ToString();
    }
    //Private Sub cmdDecocherTC_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstCat.ListCount - 1
    //      lstCat.Selected(i) = False
    //  Next
    //  lblNbSitesC = lblNbSitesC.Tag & CompterCoche
    //Exit Sub
    //handler:
    //  ShowError " cmdDecocherTC_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private int CompterCoche()
    {
      return lstCat.CheckedItems.Count;
    }
    //Private Function CompterCoche() As Integer
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  NbCoche = 0
    //  For i = 0 To lstCat.ListCount - 1
    //   If lstCat.Selected(i) = True Then
    //    NbCoche = NbCoche + 1
    //   End If
    //  Next
    //  CompterCoche = NbCoche
    //
    //Exit Function
    //handler:
    //  ShowError " CompterCoche dans " & Me.Name
    //End Function

    /* OK --------------------------------------------------------------------------*/
    private void CocherLesCat()
    {
      try
      {
        // Recherche de la liste des catégories à cocher
        string sSql = "select NGAMTRAMENUM FROM TGAMCLIENT Where NTRACLINUM = " + miNumTrame;

        DataTable dtSite = new DataTable();
        dtSite.Load(ModuleData.ExecuteReader(sSql));
        for (int i = 0; i < dtSite.Rows.Count; i++)
        {
          // Boucle sur les catégories pour rechercher le matching
          for (int j = 0; j < lstCat.Items.Count; j++)
          {
            if (((DataRowView)lstCat.Items[j]).Row.ItemArray[1].ToString() == ((DataRow)dtSite.Rows[i])["NGAMTRAMENUM"].ToString())
              lstCat.SetItemChecked(j, true);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub CocherLesCat()
    //
    //Dim rsSite As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    //   If cboclient.ListIndex = -1 Then
    //    lstCat.Clear
    //    Exit Sub
    //   End If
    //   
    //  ' recherche de la liste des catégories à cocher
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "select NGAMTRAMENUM from TGAMCLIENT where NTRACLINUM = " & miNumTrame
    //  
    //  rsSite.Open sSQL, cnx
    //  
    //  ' parcours du recordset et de la listebox
    //  While Not rsSite.EOF
    //    i = 0
    //    For i = 0 To lstCat.ListCount - 1
    //      If lstCat.ItemData(i) = rsSite("NGAMTRAMENUM") Then
    //        lstCat.Selected(i) = True
    //       End If
    //    Next
    //    rsSite.MoveNext
    //  Wend
    //  rsSite.Close
    // 
    //Exit Sub
    //handler:
    //  ShowError " CocherLesSites dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------*/
    private void lstCat_SelectedIndexChanged(object sender, EventArgs e)
    {
      lblNbSitesC.Text = lblNbSitesC.Tag.ToString() + CompterCoche();
      if (lstCat.SelectedIndex > 0)
        lstDet.SelectedIndex = lstCat.SelectedIndex;
      lstDet.TopIndex = lstCat.TopIndex;
    }

    //Private Sub lstCat_Click()
    //  lblNbSitesC = lblNbSitesC.Tag & CompterCoche
    //  lstDet.ListIndex = lstCat.ListIndex
    //  lstDet.TopIndex = lstCat.TopIndex
    //End Sub

    /* --------------------------------------------------------------------------*/
    //Private Sub lstCat_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    //lstDet.TopIndex = lstCat.TopIndex
    //End Sub

    /* --------------------------------------------------------------------------*/
    //Private Sub lstCat_Scroll()
    //lstDet.TopIndex = lstCat.TopIndex
    //End Sub
  }
}

