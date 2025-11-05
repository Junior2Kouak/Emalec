using DevExpress.XtraGrid.Views.Base;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockReception : Form
  {
    public long miLivr, miNumLivr, miNbLivraison, miNumFournisseur, miNumCommande;
    public string mstrStatut;
    private bool bstatEnvoiMSG;
    private string mstrDelegation;
    public DataTable dtArt = new DataTable();
    private DataTable dtCde = new DataTable();


    public frmStockReception()
    {
      InitializeComponent();
    }

    private void frmStockReception_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);
        bstatEnvoiMSG = false;

        if (mstrStatut == "V")
          cmdValider.Visible = false;

        miNbLivraison = 0;
        miNumLivr = 0;
        //miLivr = 1;
        InitialiserFeuille();

        ModuleData.RemplirCombo(cboContact, "api_sp_comboContactST  " + miNumFournisseur);
        cboContact.ValueMember = "NINTNUM";
        cboContact.DisplayMember = "VINTNOM";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    //Private Sub Form_Load()

    //  On Error GoTo Handler

    //  InitBoutons Me, frmMenu
    //  bstatEnvoiMSG = False
    //  If mstrStatut = "V" Then cmdValider.Visible = False
    //  miNbLivraison = 0
    //  miNumLivr = 0
    //  InitialiserFeuille
    //  RemplirComboContactST cboContact, "api_sp_comboContactST  " & miNumFournisseur

    //  Screen.MousePointer = vbDefault
    //  Exit Sub

    //Handler:
    //  ShowError " Form_load dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      bool bEnvoiMsgIfNotRecept = false;
      Cursor.Current = Cursors.WaitCursor;
      try
      {
        // Pour chaque ligne du recordset local, regarder les différences avec le recordset base
        // Si qté = 0 dans base alors création livraison sinon modification livraison
        for (int i = 14; i <= 17; i++) // Les colonnes des 4 livraisons possibles
        {
          miLivr = -1;

          int r = 0;

          foreach (DataRow row in dtCde.Rows)
          {
            if ((int)row[i] != (int)dtArt.Rows[r][i])
            {
              miLivr = i - 13;
              miNumLivr = Convert.ToInt64(row[i - 4]);
            }
            r++;
          }

          miNbLivraison = miLivr;

          if (miNbLivraison >= 0)
          {
            // Vérification sur le BL
            TextBox txtBL = (TextBox)this.Controls.Find($"textBl{miNbLivraison}", true)[0];
            if (txtBL.Text == "")
            {
              txtBL.BackColor = Color.Red;
              txtBL.Focus();
              return;
            }

            ModificationReception();
            bEnvoiMsgIfNotRecept = true;
          }
        }

        //  envoi du message au chaff avec les quantites articles
        if (!bstatEnvoiMSG && bEnvoiMsgIfNotRecept)
        {
          ModuleData.CnxExecute($"api_sp_EnvoiMsgReceptionCommande {miNumLivr}, {miNumCommande}");
          bstatEnvoiMSG = true;
        }

        // Réinitialisation complète
        OuvertureEnModification(false);
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

    //Private Sub cmdValider_Click()
    //Dim i As Integer
    //Dim bEnvoiMsgIfNotRecept As Boolean

    //  On Error GoTo Handler

    //    'INIT
    //    bEnvoiMsgIfNotRecept = False

    //  ' Pour chaque ligne du recordset local
    //  ' regarder les différences avec le recordset base
    //  ' Si qté = 0 dans base alors création livraison
    //  ' Sinon modification livraison
    //  rsCde.MoveFirst
    //  rsArt.MoveFirst

    //  For i = 14 To 17    ' Les colonnes des 4 livraisons possibles
    //    miLivr = -1

    //    While Not rsCde.EOF
    //      If rsCde(i).value <> rsArt(i).value Then
    //        miLivr = i - 13
    //        miNumLivr = rsCde(i - 4)
    //      End If
    //      rsCde.MoveNext
    //      rsArt.MoveNext
    //    Wend

    //    If miLivr >= 0 Then
    //      ' Vérification sur le BL
    //      If txtBL(miLivr) = "" Then
    //        txtBL(miLivr).BackColor = vbRed
    //        txtBL(miLivr).SetFocus
    //        Beep
    //        Exit Sub
    //      End If
    //      ModificationReception
    //      bEnvoiMsgIfNotRecept = True
    //    End If

    //    miLivr = -1
    //    rsCde.MoveFirst
    //    rsArt.MoveFirst
    //  Next

    //  ' envoi du message au chaff avec les quantites articles
    //  If Not bstatEnvoiMSG And bEnvoiMsgIfNotRecept = True Then
    //    cnx.Execute "api_sp_EnvoiMsgReceptionCommande " & miNumLivr & " , " & miNumCommande
    //    bstatEnvoiMSG = True
    //  End If

    //  ' Réinitialisation complète
    //  rsCde.Close
    //  rsArt.Close
    //  OuvertureEnModification False

    //Exit Sub
    //Resume
    //Handler:
    //  ShowError " cmdValider_Click dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      // gestion delegation dépense (affichage bouton impression)
      if (mstrDelegation == "E" || mstrDelegation == "V")
      {
        MessageBox.Show("Vous ne pouvez pas éditer la commande car elle n'est pas validée pour édition", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (miNumCommande == 0) return;

      Cursor = Cursors.WaitCursor;

      new frmMainReport()
      {
        bLaunchByProcessStart = false,
        sTypeReport = PrepareReport.TCOMMANDE,
        sIdentifiant = $"{miNumCommande}",
        InfosMail = "0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
        strType = "CF"
      }.ShowDialog();

      Cursor = Cursors.Default;
    }

    private void cmdEtiquette_Click(object sender, EventArgs e)
    {
      if (miNumLivr == 0) return;

      Cursor = Cursors.WaitCursor;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TETIQRECEPT",
        sIdentifiant = $"{miNumLivr}|{miNumCommande}",
        InfosMail = "",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();

      Cursor = Cursors.Default;
    }

    private void InitialiserFeuille()
    {
      try
      {
        InfosLivraison();
        OuvertureEnModification(true);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InfosLivraison()
    {
      using (SqlDataReader sdr = ModuleData.ExecuteReader("SELECT * FROM api_v_ListeReception WHERE NCOMNUM = " + miNumCommande + " ORDER BY NLIVRNUM"))
      {
        while (sdr.Read() && miNbLivraison < 4)
        {
          miNbLivraison++;

          apiGroupBox fraReception = (apiGroupBox)this.Controls.Find($"fraReception{miNbLivraison}", true)[0];
          fraReception.Visible = true;

          TextBox txtDateLive = (TextBox)this.Controls.Find($"txtDateLive{miNbLivraison}", true)[0];
          txtDateLive.Text = (sdr["DLIVRDAT"] == null || sdr["DLIVRDAT"].ToString() == "") ? DateTime.Now.ToShortDateString() : Convert.ToDateTime(sdr["DLIVRDAT"]).ToShortDateString();

          TextBox txtBl = (TextBox)this.Controls.Find($"textBl{miNbLivraison}", true)[0];
          txtBl.Text = sdr["VLIVRBL"].ToString() + "";

          TextBox textTransporteur = (TextBox)this.Controls.Find($"textTransporteur{miNbLivraison}", true)[0];
          textTransporteur.Text = sdr["VLIVRTRANS"].ToString() + "";

          // type de livraison
          ComboBox cboTypeColis = (ComboBox)this.Controls.Find($"cboTypeColis{miNbLivraison}", true)[0];
          cboTypeColis.Text = sdr["VLIVRTYPE"].ToString() + "";

          // poids de livraison
          DevExpress.XtraEditors.TextEdit txtPoids = (DevExpress.XtraEditors.TextEdit)this.Controls.Find($"txtPoids{miNbLivraison}", true)[0];
          txtPoids.Text = sdr["NLIVRPOIDS"].ToString() + "";

          txtCommande.Text = "CF" + sdr["NCOMNUM"].ToString();
          miNumCommande = Convert.ToInt32(sdr["NCOMNUM"]);
          miNumFournisseur = (int)Utils.ZeroIfNull(sdr["NSTFNUM"]);
          miNumLivr = (int)Utils.ZeroIfNull(sdr["NLIVRNUM"]);
          mstrDelegation = sdr["CCOMVALID"].ToString();
          txtFournisseur.Text = sdr["VSTFNOM"].ToString();
          txtDateCde.Text = Convert.ToDateTime(sdr["DCOMDLI"]).ToShortDateString();
          txtCP.Text = sdr["VSTFCP"].ToString();
          txtVille.Text = sdr["VSTFVIL"].ToString();
          txtObserv.Text = sdr["VLIVROBSERV"].ToString();

          if (Utils.BlankIfNull(sdr["NLIVRNUM"]) == "")
            miNbLivraison--;
        }
        sdr.Close();
      }

      if (miNbLivraison < 4)
      {
        apiGroupBox fraReception = (apiGroupBox)Controls.Find($"fraReception{miNbLivraison + 1}", true)[0];
        fraReception.Visible = true;

        TextBox txtDateLive = (TextBox)this.Controls.Find($"txtDateLive{miNbLivraison + 1}", true)[0];
        txtDateLive.Text = DateTime.Now.ToShortDateString();

        DevExpress.XtraEditors.TextEdit txtPoids = (DevExpress.XtraEditors.TextEdit)this.Controls.Find($"txtPoids{miNbLivraison + 1}", true)[0];
        txtPoids.Text = "";

      }
    }

    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtTel.Text);
            if (txtTel.Text != "") 
            {
                string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTel.Text, Environment.MachineName);
                if (reponse != "OK")
                {
                    MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    private void cboContact_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtTel.Text = ModuleData.ExecuteScalarString($"SELECT VINTTEL from TINT where NINTNUM = {cboContact.GetItemData()}");
    }

    private void OuvertureEnModification(bool bFirstTime)
    {
      try
      {
        InitRecordsetArticle();
        dtCde.Rows.Clear();

        // recherche des infos de cette COMMANDE
        using (SqlDataReader sdr = ModuleData.ExecuteReader("api_sp_RetourArticlesCommande3 " + miNumCommande))
        {
          dtCde.Load(sdr);

          foreach (DataRow row in dtCde.Rows)
            AjouterEnreg(row);

          sdr.Close();
        }
        apiTGrid.GridControl.DataSource = dtArt;
        FormatGridCde(bFirstTime);

        UpdateApitgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void InitRecordsetArticle()
    {
      try
      {
        dtArt.Rows.Clear();

        //  ajout des champs au recordset
        //laisser tout en majuscule sinon le code ne marche pas 
        if (dtArt.Columns.Count == 0)
        {
          dtArt.Columns.Add("VFOUMAT", typeof(string));
          dtArt.Columns.Add("VFOUMAR", typeof(string));
          dtArt.Columns.Add("VFOUTYP", typeof(string));
          dtArt.Columns.Add("VFOUREF", typeof(string));
          dtArt.Columns.Add("VFOUREF_FO", typeof(string));
          dtArt.Columns.Add("VFOUCON", typeof(string));
          dtArt.Columns.Add("NLCOQTE", typeof(int));
          dtArt.Columns.Add("NQTELIVR", typeof(int));
          dtArt.Columns.Add("NFOUNUM", typeof(int));
          dtArt.Columns.Add("NSTFNUM", typeof(int));
          dtArt.Columns.Add("LIVR1", typeof(int));
          dtArt.Columns.Add("LIVR2", typeof(int));
          dtArt.Columns.Add("LIVR3", typeof(int));
          dtArt.Columns.Add("LIVR4", typeof(int));
          dtArt.Columns.Add("QTELIVR1", typeof(int));
          dtArt.Columns.Add("QTELIVR2", typeof(int));
          dtArt.Columns.Add("QTELIVR3", typeof(int));
          dtArt.Columns.Add("QTELIVR4", typeof(int));
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void FormatGridCde(bool bFirstTime)
    {
      try
      {
        if (bFirstTime)
        {
          apiTGrid.AddColumn(Resources.col_ID, "NFOUNUM", 800);
          apiTGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 4600, "", 0, true);
          apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1300, "", 0, true);
          apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1300, "", 0, true);
          apiTGrid.AddColumn(Resources.col_Ref, "VFOUREF", 1300, "", 0, true);
          apiTGrid.AddColumn(Resources.col_RefFO, "VFOUREF_FO", 800);
          apiTGrid.AddColumn(Resources.col_Condit, "VFOUCON", 0);
          apiTGrid.AddColumn(Resources.col_cde, "NLCOQTE", 750, "", 2);
          apiTGrid.AddColumn(Resources.col_Recu, "NQTELIVR", 750, "", 2);
          apiTGrid.AddColumn(Resources.col_Livr1, "QTELIVR1", 800);


          apiTGrid.DelockColumn("QTELIVR1");


          if (miNbLivraison >= 1)
          {
            apiTGrid.AddColumn(Resources.col_Livr2, "QTELIVR2", 750, "", 2);
            apiTGrid.DelockColumn("QTELIVR2");
          }

          if (miNbLivraison >= 2)
          {
            apiTGrid.AddColumn(Resources.col_Livr3, "QTELIVR3", 750, "", 2);
            apiTGrid.DelockColumn("QTELIVR3");
          }

          if (miNbLivraison >= 3)
          {
            apiTGrid.AddColumn(Resources.col_Livr4, "QTELIVR4", 750, "", 2);
            apiTGrid.DelockColumn("QTELIVR4");
          }
        }

        apiTGrid.FilterBar = false;
        apiTGrid.InitColumnList();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {

      if (e.Column.Name == "NQTELIVR")
      {
        if (Convert.ToInt32(e.CellValue) == Convert.ToInt32(apiTGrid.dgv.GetDataRow(e.RowHandle)["NLCOQTE"].ToString()))
        {
          e.Appearance.BackColor = Color.LightGray;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        else
        {
          e.Appearance.ForeColor = Color.Red;
          e.Appearance.BackColor = Color.LightBlue;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }

      if (e.Column.Name == "QTELIVR1" || e.Column.Name == "QTELIVR2" || e.Column.Name == "QTELIVR3" || e.Column.Name == "QTELIVR4")
      {
        if (Convert.ToInt32(e.CellValue) > 0)
          e.Appearance.BackColor = Color.FromArgb(200, 200, 200);

        if (Convert.ToInt32(e.CellValue) == 0)
          e.Appearance.BackColor = Color.White;
      }
    }


    private void apiTGrid_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      UpdateApitgrid();
    }


    public long EnregReception()
    {
      long lenr = 0;
      try
      {
        // Enregistrement de la réception
        // Enregistrement des lignes de la réception
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationReception", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@NumLivr"].Value = miNumLivr;
          cmd.Parameters["@FournNum"].Value = miNumFournisseur;
          cmd.Parameters["@CdeNum"].Value = miNumCommande;

          TextBox txtBL = (TextBox)Controls.Find($"textBl{miNbLivraison}", true)[0];
          TextBox txtDateLive = (TextBox)Controls.Find($"txtDateLive{miNbLivraison}", true)[0];
          TextBox txtTransporteur = (TextBox)Controls.Find($"textTransporteur{miNbLivraison}", true)[0];
          ComboBox cboTypeColis = (ComboBox)this.Controls.Find($"cboTypeColis{miNbLivraison}", true)[0];
          DevExpress.XtraEditors.TextEdit txtPoids = (DevExpress.XtraEditors.TextEdit)this.Controls.Find($"txtPoids{miNbLivraison}", true)[0];

          cmd.Parameters["@BL"].Value = txtBL.Text;
          cmd.Parameters["@LivrDate"].Value = txtDateLive.Text;
          cmd.Parameters["@Transporteur"].Value = txtTransporteur.Text;
          cmd.Parameters["@TypeLivr"].Value = cboTypeColis.Text;
          cmd.Parameters["@PoidsLivr"].Value = txtPoids.Text;

          cmd.Parameters["@Observ"].Value = txtObserv.Text;
          cmd.Parameters["@LivrNum"].Value = miNumLivr;
          cmd.ExecuteNonQuery();

          // Récupérer la valeur en retour
          lenr = Convert.ToInt64(cmd.Parameters["@LivrNum"].Value);

          //libération de la commande
          cmd.Dispose();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return lenr;
    }

    private void ModificationReception()
    {
      try
      {
        // delete des lignes de commandes dans la tables TLLIVR
        if (miNumLivr > 0)
        {
          ModuleData.CnxExecute("DELETE FROM TLLIVR where NLIVRNUM = " + miNumLivr);
          //il faut aussi supprimer les lignes dans TSTOCK car elles vont être recréées
          ModuleData.CnxExecute("DELETE FROM TSTOCK where NLIVRNUM = " + miNumLivr);
        }

        miNumLivr = EnregReception();

        // parcours du recordset et création des lignes articles
        foreach (DataRow row in dtArt.Rows)
        {
          switch (miLivr)
          {
            case 1:
              if ((int)row["QTELIVR1"] != 0)
                EnregLigneReception(miNumLivr, row);
              break;
            case 2:
              if ((int)row["QTELIVR2"] != 0)
                EnregLigneReception(miNumLivr, row);
              break;
            case 3:
              if ((int)row["QTELIVR3"] != 0)
                EnregLigneReception(miNumLivr, row);
              break;
            case 4:
              if ((int)row["QTELIVR4"] != 0)
                EnregLigneReception(miNumLivr, row);
              break;
            default:
              break;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub ModificationReception()

    //  On Error GoTo Handler

    //  ' delete des lignes de commandes dans la tables TLLIVR
    //  If miNumLivr > 0 Then
    //    cnx.Execute "DELETE FROM TLLIVR where NLIVRNUM = " & miNumLivr
    //     ' il faut aussi supprimer les lignes dans TSTOCK car elles vont être recréé
    //    cnx.Execute "DELETE FROM TSTOCK where NLIVRNUM = " & miNumLivr
    //  End If

    //  miNumLivr = EnregReception()

    //  'parcours du recordset et création des lignes articles
    //  rsArt.MoveFirst
    //  While Not rsArt.EOF
    //    If 0 <> Switch(miLivr = 1, rsArt!QTELIVR1, miLivr = 2, rsArt!QTELIVR2, miLivr = 3, rsArt!QTELIVR3, miLivr = 4, rsArt!QTELIVR4) Then
    //      EnregLigneReception miNumLivr
    //    End If
    //    rsArt.MoveNext
    //  Wend


    //Exit Sub
    //Handler:
    //  ShowError " ModificationReception dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    public void EnregLigneReception(long numReception, DataRow row)
    {
      try
      {
        // Enregistrement de la réception
        // Enregistrement des lignes de la réception
        //DataRow row = apiTGrid.GetFocusedDataRow();
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationReceptionLigne", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@LivrNum"].Value = numReception;
          cmd.Parameters["@FouNum"].Value = row["NFOUNUM"];
          cmd.Parameters["@Commande"].Value = miNumCommande;


          TextBox txtDateLive = (TextBox)this.Controls.Find($"txtDateLive{miNbLivraison}", true)[0];
          cmd.Parameters["@Date"].Value = txtDateLive.Text;
          cmd.Parameters["@Qte"].Value = row[$"QTELIVR{miNbLivraison}"];

          cmd.ExecuteNonQuery();
          cmd.Dispose();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Public Sub EnregLigneReception(NumReception As Long)
    //Dim cmd As New ADODB.Command

    //On Error GoTo Handler

    //  ' Enregistrement de la réception
    //  ' Enregistrement des lignes de la réception
    //  Set cmd.ActiveConnection = cnx
    //  cmd.CommandText = "api_sp_CreationReceptionLigne"
    //  cmd.CommandType = adCmdStoredProc

    //  cmd.Parameters.Refresh
    //  cmd.Parameters("@LivrNum").value = NumReception
    //  cmd.Parameters("@FouNum").value = rsArt!NFOUNUM
    //  cmd.Parameters("@Commande").value = miNumCommande
    //  cmd.Parameters("@Date").value = txtDateLiv(miLivr).Text
    //  cmd.Parameters("@Qte").value = Switch(miLivr = 1, rsArt!QTELIVR1, miLivr = 2, rsArt!QTELIVR2, miLivr = 3, rsArt!QTELIVR3, miLivr = 4, rsArt!QTELIVR4)
    //  cmd.Execute
    //  Set cmd = Nothing
    //  Exit Sub
    //  Resume

    //Handler:
    //  ShowError "EnregCommande dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void AjouterEnreg(DataRow drAE)
    {
      try
      {
        DataRow newRow = dtArt.NewRow();
        newRow["VFOUMAT"] = drAE["VFOUMAT"];
        newRow["VFOUMAR"] = Utils.BlankIfNull(drAE["VFOUMAR"]);
        newRow["VFOUTYP"] = Utils.BlankIfNull(drAE["VFOUTYP"]);
        newRow["VFOUREF"] = Utils.BlankIfNull(drAE["VFOUREF"]);
        newRow["VFOUREF_FO"] = Utils.BlankIfNull(drAE["VFOUREF_FO"]);
        newRow["VFOUCON"] = Utils.BlankIfNull(drAE["VFOUCON"]);
        newRow["NLCOQTE"] = drAE["NLCOQTE"];
        newRow["NQTELIVR"] = drAE["NQTELIVR"];
        newRow["NFOUNUM"] = drAE["NFOUNUM"];
        newRow["LIVR1"] = drAE["LIVR1"];
        newRow["LIVR2"] = drAE["LIVR2"];
        newRow["LIVR3"] = drAE["LIVR3"];
        newRow["LIVR4"] = drAE["LIVR4"];
        newRow["QTELIVR1"] = drAE["QTELIVR1"];
        newRow["QTELIVR2"] = drAE["QTELIVR2"];
        newRow["QTELIVR3"] = drAE["QTELIVR3"];
        newRow["QTELIVR4"] = drAE["QTELIVR4"];

        dtArt.Rows.Add(newRow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void text_leave(object sender, EventArgs e)
    {
      TextBox textBox = (TextBox)sender;
      textBox.Text = textBox.Text.ToUpper();
    }

    private void txtDateLive_Leave(object sender, EventArgs e)
    {
      (sender as TextBox).BackColor = Color.White;
    }


    DateTime _curDate = DateTime.MinValue;
    private void cmdDat_Click(object sender, EventArgs e)
    {
      TextBox textDateLive = (TextBox)this.Controls.Find($"txtDateLive{miNbLivraison + 1}", true)[0];
      DateTime d;
      if (DateTime.TryParse(textDateLive.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }


    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      TextBox textDateLive = (TextBox)this.Controls.Find($"txtDateLive{miNbLivraison + 1}", true)[0];
      textDateLive.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void UpdateApitgrid()
    {
      foreach (DataRow row in dtArt.Rows)
        row["NQTELIVR"] = (int)row["QTELIVR1"] + (int)row["QTELIVR2"] + (int)row["QTELIVR3"] + (int)row["QTELIVR4"];
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;

      new frmDetailstravaux()
      {
        mstrStatutAction = "M",
      }.ShowDialog();

      Cursor = Cursors.Default;
    }

  }
}