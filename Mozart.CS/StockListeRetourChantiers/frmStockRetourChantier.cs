using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockRetourChantier : Form
  {
    public long miNumRetour;

    bool firstTime = true;
    DataTable dtArticle = new DataTable();

    //Public iNumRetour As Long

    public frmStockRetourChantier() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmStockRetourChantier_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        cboClient.Init(MozartDatabase.cnxMozart, "select * from api_v_comboClient order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Nom, MZCtrlResources.col_Client }, 500, 500, true);

        InitDatatable();

        if (miNumRetour > 0)
          InitFormVisu();

        Cursor = Cursors.Default;
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
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  cboClient.SizeCombo 600
    //
    //  ' combo des clients
    //  RemplirComboClient cboClient
    //  
    //  InitRecordsetArticle
    //  
    //  ' on est en visu sur un retour
    //  If iNumRetour > 0 Then InitFormVisu
    //  Screen.MousePointer = vbDefault
    //  
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError " Form_load dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (cboClient.GetText() == "")
        {
          MessageBox.Show(Resources.msg_selectClient, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboClient.Focus();
          return;
        }

        if (cboSite.GetText() == "")
        {
          MessageBox.Show(Resources.msg_selectSite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboSite.Focus();
          return;
        }

        if (cboAct.Text == "")
        {
          MessageBox.Show(Resources.msg_selectDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboAct.Focus();
          return;
        }

        if (cboAct.SelectedIndex == -1)
        {

          MessageBox.Show(Resources.msg_selectDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboAct.Focus();
          return;
        }


        if (txtDateRetour.Text == "")
        {
          MessageBox.Show(Resources.msg_entrerDateRetour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cmdDate_Click(null, null);
          return;
        }

        if (dtArticle.Rows.Count == 0)
        {
          MessageBox.Show(Resources.msg_EntrerArticle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        MessageBox.Show(Resources.msg_entreeStockOK, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        CreationLignesRetour();

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //On Error GoTo handler
    //
    //  If cboClient.Text = "" Then
    //    MsgBox "§Il faut sélectionner un client  !§", vbExclamation
    //    cboClient.SetFocus:     Exit Sub
    //  End If
    //  
    //  If cboSite.Text = "" Then
    //    MsgBox "§Il faut sélectionner un site !§", vbExclamation
    //    cboSite.SetFocus:     Exit Sub
    //  End If
    //  
    //  If cboAct.Text = "" Then
    //    MsgBox "§Il faut sélectionner une DI !§", vbExclamation
    //    cboAct.SetFocus:     Exit Sub
    //  End If
    //  
    //  If txtDateRetour = "" Then        ' Date obligatoire
    //    MsgBox "§Il faut entrer une date de retour !§", vbExclamation
    //cmdDate_Click:     Exit Sub
    //  End If
    //  
    //  If rsarticle.EOF And rsarticle.BOF Then
    //    MsgBox "§Il faut entrer un article !§", vbExclamation:       Exit Sub
    //  End If
    //  
    //  CreationLignesRetour
    //  
    //  MsgBox "§L'entrée en stock a bien été prise en compte !§", vbExclamation
    //  
    //  Unload Me
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError " cmdValider_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cboClient_TxtChanged(object sender, EventArgs e)
    {
      cboSite.Init(MozartDatabase.cnxMozart, $"SELECT  NSITNUM, VSITNOM + ' - ' + NSITNUE AS site FROM TSIT WHERE NCLINUM = {cboClient.GetItemData()} ORDER BY VSITNOM", "NSITNUM", "site",
                   new List<string>() { Resources.col_Num, Resources.col_Site }, 500, 500, true);
    }
    //Private Sub cboClient_Click()
    //Dim sSQL As String
    //    
    //  sSQL = "select TPER.NPERNUM, VPERNOM + ' ' + VPERPRE from TPER, TCAN where CCANACTIF='O' and CPERACTIF = 'O' and TPER.NPERNUM=TCAN.NPERNUM and NCLINUM=" & cboClient.ItemData(cboClient.ListIndex) & " order by VPERNOM"
    //  RemplirCombo cboSite, "SELECT  NSITNUM, VSITNOM + ' - ' + NSITNUE FROM TSIT WHERE NCLINUM = " & cboClient.ItemData(cboClient.ListIndex) & " ORDER BY VSITNOM"
    //  
    //End Sub

    /* TODO à tester avec frmRechercheArticlesCom qui marche --------------------------------------------------------------------------------------- */
    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        // affichage de la feuille de recherche des fournitures avec numero de fournisseur si connu
        frmRechercheArticlesCom f = new frmRechercheArticlesCom
        {
          miNumFournisseur = 0,
          m_brechercheSite = false,
          m_bSaisieQte = true,
          mstrClient = "",
          mstrStatut = "",
          m_bAfficheInfoFou = false,
          mdtArticles = dtArticle
        };
        f.ShowDialog();

        dtArticle = f.mdtArticles;

        if (firstTime)
        {
          FormatGridArticle();
          firstTime = false;
        }

        grdDataGrid.GridControl.DataSource = dtArticle;
        grdDataGrid.Requery(dtArticle, MozartDatabase.cnxMozart);

        // remplir les montants totaux
        RemplirTxtTotaux();

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdRechercher_Click()
    //
    //On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //  ' affichage de la feuille  de recherche des fournitures avec numero de fournisseur si connu
    //  frmRechercheArticlesCom.miNumFournisseur = 0
    //  frmRechercheArticlesCom.brechercheSite = False
    //  frmRechercheArticlesCom.bSaisieQte = True
    //  frmRechercheArticlesCom.mstrClient = ""
    //  frmRechercheArticlesCom.mstrStatut = ""
    //  frmRechercheArticlesCom.bAfficheInfoFou = False
    //  frmRechercheArticlesCom.Show vbModal
    //
    //  On Error Resume Next
    //  rsarticle.MoveFirst
    //  InitApigrid
    //  
    //  ' remplir les montants totaux
    //  Call RemplirTxtTotaux
    //  
    //Exit Sub
    //handler:
    //  ShowError " cmdRechercher_Click dans " & Me.Name
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub InitApigrid()
    //  
    //  On Error GoTo handler
    //  Set grdDataGrid.DataSource = rsarticle
    //  FormatGridArticle
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void CreationLignesRetour()
    {
      try
      {
        //recheche d'un nouveau numéro de retour
        int NumRet = Convert.ToInt32(ModuleData.ExecuteScalarDouble("SELECT COALESCE(MAX(NRETNUM),0) + 1 FROM TSTOCKRETOUR"));

        using (SqlCommand cmd = new SqlCommand("api_sp_CreationRetourChantier", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          foreach (DataRow row in dtArticle.Rows)
          {
            cmd.Parameters["@nRetNum"].Value = NumRet;
            cmd.Parameters["@nFouNum"].Value = Utils.ZeroIfNull(row["NumArticle"]);
            cmd.Parameters["@iQte"].Value = Utils.ZeroIfNull(row["Quantite"]);
            cmd.Parameters["@dRetour"].Value = txtDateRetour.Text;
            cmd.Parameters["@vObjet"].Value = txtObjet.Text;
            cmd.Parameters["@nchaff"].Value = txtChaff.Tag;
            cmd.Parameters["@nClient"].Value = cboClient.GetItemData();
            cmd.Parameters["@nActNum"].Value = cboAct.GetItemData();
            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CreationLignesRetour()
    //Dim c As New adodb.Command
    //Dim RSn As New adodb.Recordset
    //Dim NumRet As Long
    //
    //On Error GoTo handler
    //
    //  ' recherche d'un nouveau numero de retour
    //  Set RSn = New adodb.Recordset
    //  RSn.Open "SELECT COALESCE(MAX(NRETNUM),0) + 1 FROM TSTOCKRETOUR", cnx
    //  NumRet = RSn(0)
    //  RSn.Close
    //  Set RSn = Nothing
    //
    //  'parcours du recordset et création des lignes dans TSTOCK et dans TSTOCKRETOUR
    //  rsarticle.MoveFirst
    //  While Not rsarticle.EOF
    //    
    //    Set c.ActiveConnection = cnx
    //    c.CommandText = "api_sp_CreationRetourChantier"
    //    c.CommandType = adCmdStoredProc
    //    c.Parameters.Refresh
    //    c.Parameters("@nRetNum").value = NumRet
    //    c.Parameters("@nFouNum").value = ZeroIfNull(rsarticle!NumArticle)
    //    c.Parameters("@iQte").value = ZeroIfNull(rsarticle!Quantite)
    //    c.Parameters("@dRetour").value = txtDateRetour
    //    c.Parameters("@vObjet").value = txtObjet
    //    c.Parameters("@nchaff").value = txtChaff.Tag
    //    c.Parameters("@nClient").value = cboClient.ItemData(cboClient.ListIndex)
    //    c.Parameters("@nActNum").value = cboAct.ItemData(cboAct.ListIndex)
    //    c.Execute
    //  
    //    rsarticle.MoveNext
    //  Wend
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateRetour.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateRetour.Text, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    //Private Sub cmdDate_Click()
    //  Cal.Visible = Not Cal.Visible
    //  Cal.value = IIf(txtDateRetour <> "", txtDateRetour, Now)
    //End Sub
    //Private Sub Cal_Click()
    //  txtDateRetour = Cal.value
    //  Cal.Visible = False
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public void InitDatatable()
    {
      try
      {
        dtArticle.Columns.Add("Serie", Type.GetType("System.String"));
        dtArticle.Columns.Add("Article", Type.GetType("System.String"));
        dtArticle.Columns.Add("Marque", Type.GetType("System.String"));
        dtArticle.Columns.Add("Type", Type.GetType("System.String"));
        dtArticle.Columns.Add("Reference", Type.GetType("System.String"));
        dtArticle.Columns.Add("PCB", Type.GetType("System.Int32"));
        dtArticle.Columns.Add("Prix U", typeof(double));
        dtArticle.Columns.Add("Quantite", Type.GetType("System.Int32"));
        dtArticle.Columns.Add("Prix T", typeof(double));
        dtArticle.Columns.Add("Fournisseur", Type.GetType("System.String"));
        dtArticle.Columns.Add("NumArticle", Type.GetType("System.Int32"));
        dtArticle.Columns.Add("NumFour", Type.GetType("System.Int32"));
        dtArticle.Columns.Add("NumSiteFour", Type.GetType("System.Int32"));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub InitRecordsetArticle()
    //
    //On Error GoTo handler
    //
    //  Set rsarticle = New adodb.Recordset
    //  
    //  rsarticle.Fields.Append "Serie", adVarChar, 70
    //  rsarticle.Fields.Append "Article", adVarChar, 150
    //  rsarticle.Fields.Append "Marque", adVarChar, 100
    //  rsarticle.Fields.Append "Type", adVarChar, 2000
    //  rsarticle.Fields.Append "Reference", adVarChar, 150
    //  rsarticle.Fields.Append "PCB", adInteger
    //  rsarticle.Fields.Append "Prix U", adDouble
    //  rsarticle.Fields.Append "Quantite", adInteger
    //  rsarticle.Fields.Append "Prix T", adDouble
    //  rsarticle.Fields.Append "Fournisseur", adVarChar, 70
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
    public void FormatGridArticle()
    {
      try
      {
        grdDataGrid.AddColumn(Resources.col_Serie, "Serie", 800);
        grdDataGrid.AddColumn(Resources.col_materiel, "Article", 4900);
        grdDataGrid.AddColumn(Resources.col_marque, "Marque", 830);
        grdDataGrid.AddColumn(Resources.col_Type, "Type", 1200);
        grdDataGrid.AddColumn(Resources.col_Ref, "Reference", 800);
        grdDataGrid.AddColumn(Resources.col_pcb, "PCB", 1000, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixU, "Prix U", 900, "## ##0.00", 1);
        grdDataGrid.AddColumn(Resources.col_qte3, "Quantite", 1000, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixT, "Prix T", 0);
        grdDataGrid.AddColumn(Resources.col_four, "Fournisseur", 0);
        grdDataGrid.AddColumn(Resources.col_NumArticle, "NumArticle", 0);
        grdDataGrid.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

        grdDataGrid.DelockColumn("Quantite");

        grdDataGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub FormatGridArticle()
    //  
    //On Error GoTo handler
    //  
    //  grdDataGrid.Columns(0).Caption = "§Série§"
    //  grdDataGrid.Columns(1).Caption = "§Matériel§"
    //  grdDataGrid.Columns(2).Caption = "§Marque§"
    //  grdDataGrid.Columns(3).Caption = "§Type§"
    //  grdDataGrid.Columns(4).Caption = "Réf"
    //  grdDataGrid.Columns(5).Caption = "PCB"
    //  grdDataGrid.Columns(6).Caption = "§Prix U§"
    //  grdDataGrid.Columns(7).Caption = "Qté"
    //  grdDataGrid.Columns(8).Caption = "§Prix T§"
    //  grdDataGrid.Columns(9).Caption = "§Four§"
    //  grdDataGrid.Columns(10).Caption = "§NumFour§"
    //  grdDataGrid.Columns(11).Caption = "§NumArticle§"
    //  grdDataGrid.Columns(12).Caption = "§NumSiteFour§"
    //      
    //  grdDataGrid.Columns(0).width = 800
    //  grdDataGrid.Columns(1).width = 4900
    //  grdDataGrid.Columns(2).width = 830
    //  grdDataGrid.Columns(3).width = 1200
    //  grdDataGrid.Columns(4).width = 800
    //  grdDataGrid.Columns(5).width = 1000
    //  grdDataGrid.Columns(6).width = 900
    //  grdDataGrid.Columns(7).width = 1000
    //  grdDataGrid.Columns(8).width = 0
    //  grdDataGrid.Columns(9).width = 0
    //  grdDataGrid.Columns(10).width = 0
    //  grdDataGrid.Columns(11).width = 0
    //  grdDataGrid.Columns(12).width = 0
    //  
    //  'locked des cellules sauf la quantité
    //  grdDataGrid.Columns(0).Locked = True
    //  grdDataGrid.Columns(1).Locked = True
    //  grdDataGrid.Columns(2).Locked = True
    //  grdDataGrid.Columns(3).Locked = True
    //  grdDataGrid.Columns(4).Locked = True
    //  grdDataGrid.Columns(5).Locked = True
    //  grdDataGrid.Columns(6).Locked = True
    //  grdDataGrid.Columns(7).Locked = False
    //  grdDataGrid.Columns(9).Locked = True
    //
    //  grdDataGrid.Columns(6).Alignment = dbgRight
    //  grdDataGrid.Columns(7).Alignment = dbgCenter
    //  grdDataGrid.Columns(5).Alignment = dbgCenter
    //  
    //  grdDataGrid.Columns(6).NumberFormat = "## ##0.00"
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "FormatGrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void grdDataGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      RemplirTxtTotaux();
    }
    //Private Sub grdDataGrid_AfterColUpdate(ByVal ColIndex As Integer)
    //  ' mise a jour du total
    //  Call RemplirTxtTotaux
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void RemplirTxtTotaux()
    {

      double d_ht = 0;

      foreach (DataRow row in dtArticle.Rows)
        d_ht += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);

      txtHT.Text = Strings.Format(d_ht, "Currency");
      txtTVA.Text = Strings.Format(d_ht * MozartParams.TVA1 / 100, "Currency");
      txtTTC.Text = Strings.Format(d_ht + (d_ht * (MozartParams.TVA1 / 100)), "Currency");
    }
    //Private Sub RemplirTxtTotaux()
    //
    //Dim rsC As adodb.Recordset
    //  
    //On Error Resume Next
    //  
    //  Set rsC = rsarticle.Clone
    //  rsC.MoveFirst
    //
    //  txtHT = 0
    //    While Not rsC.EOF
    //    txtHT = txtHT + (ZeroIfNull(rsC("Prix U")) * ZeroIfNull(rsC("Quantite")))
    //    rsC.MoveNext
    //  Wend
    //
    //  txtHT = Format(txtHT, "currency")
    //  txtTVA = Format(txtHT * gdblTVA1 / 100, "currency")
    //  txtTTC = Format((txtHT + (txtHT * (gdblTVA1 / 100))), "currency")
    //  
    //Exit Sub
    //handler:
    //  ShowError "RemplirTxtTotaux dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitFormVisu()
    {
      string sSQL = $"select tref_cfo.ccfocod as vfouser, vfoumat, vfoumar, vfoutyp, vfouref, nfounblot, fstockpuht, nstockqte, " +
                    $"nchaffnum, tstockretour.nclinum, dretour, vcomment, isnull(tstockretour.nactnum,0) as nactnum, isnull(tact.nsitnum,0) as nsitnum , tper.vpernom + ' ' + tper.vperpre as chaff " +
                    $"From tstock WITH (NOLOCK) inner join tfou on tstock.nfounum = tfou.nfounum " +
                    $" inner join tstockretour WITH (NOLOCK) on tstockretour.nstocknum = tstock.nstocknum " +
                    $" inner join tref_cfo WITH (NOLOCK) on tref_cfo.ncfocod=tfou.ncfocod " +
                    $" inner join tper WITH (NOLOCK) on tper.npernum = nchaffnum " +
                    $" left outer join tact WITH (NOLOCK) on tact.nactnum = tstockretour.nactnum " +
                    $"Where tstockretour.nretnum = {miNumRetour}" +
                    $" and langue='{MozartParams.Langue}'";

      using (SqlDataReader sdr = ModuleData.ExecuteReader(sSQL))
      {
        if (sdr.Read())
        {
          cboClient.SetItemData(Convert.ToInt32(sdr["NCLINUM"]));

          //chargement combo site
          if (Convert.ToInt32(sdr["NCLINUM"]) != 0)
          {
            cboSite.Init(MozartDatabase.cnxMozart, $"SELECT  NSITNUM, VSITNOM + ' - ' + NSITNUE AS nom FROM TSIT WHERE NSITNUM = {sdr["nsitnum"]}", "NSITNUM", "nom",
                         new List<string>() { Resources.col_Num, Resources.col_Nom }, 500, 250, true);
            cboSite.SetItemData(Convert.ToInt32(sdr["NSITNUM"]));
            if (Convert.ToInt32(sdr["nactnum"]) != 0)
            {
              ModuleData.RemplirCombo(cboAct, $"SELECT NACTNUM, CONVERT(varchar(7), NDINNUM) + '/' + CONVERT(VARCHAR(4), NACTID) AS DI FROM TACT WITH(NOLOCK) WHERE NACTNUM = {sdr["nactnum"]} ");
              cboAct.ValueMember = "NACTNUM";
              cboAct.DisplayMember = "DI";

              cboAct.SetItemData(sdr["NACTNUM"].ToString());
            }
          }

          txtChaff.Tag = Utils.BlankIfNull(sdr["NCHAFFNUM"]);
          txtChaff.Text = Utils.BlankIfNull(sdr["CHAFF"]);

          txtDateRetour.Text = Utils.DateBlankIfNull(sdr["DRETOUR"]);
          txtObjet.Text = Utils.BlankIfNull(sdr["VCOMMENT"]);
        }
      }

      using (SqlDataReader sdr = ModuleData.ExecuteReader(sSQL))
      {
        while (sdr.Read())
        {
          DataRow newrow = dtArticle.NewRow();

          newrow["Serie"] = Utils.BlankIfNull(sdr["VFOUSER"]);
          newrow["Article"] = Utils.BlankIfNull(sdr["VFOUMAT"]);
          newrow["Marque"] = Utils.BlankIfNull(sdr["VFOUMAR"]);
          newrow["Type"] = Utils.BlankIfNull(sdr["VFOUTYP"]);
          newrow["Reference"] = Utils.BlankIfNull(sdr["VFOUREF"]);
          newrow["PCB"] = Utils.ZeroIfNull(sdr["NFOUNBLOT"]);
          newrow["Prix U"] = Utils.ZeroIfNull(sdr["fstockpuht"]);
          newrow["Quantite"] = Utils.ZeroIfNull(sdr["nstockqte"]); ;

          dtArticle.Rows.Add(newrow);
        }
      }

      cmdValider.Enabled = cmdDate.Enabled = cmdRechercher.Enabled = cboClient.Enabled = cboSite.Enabled = cboAct.Enabled = false;

      grdDataGrid.GridControl.DataSource = dtArticle;
      FormatGridArticle();
      RemplirTxtTotaux();
    }
    //Private Sub InitFormVisu()
    //Dim sSQL As String
    //Dim rsArtVisu As adodb.Recordset
    //  
    //  sSQL = "select tref_cfo.ccfocod as vfouser,vfoumat,vfoumar,vfoutyp,vfouref,nfounblot,fstockpuht, nstockqte, " _
    //      & "nchaffnum, tstockretour.nclinum, dretour, vcomment, isnull(tstockretour.nactnum,0) as nactnum, isnull(tact.nsitnum,0) as nsitnum , tper.vpernom + ' ' + tper.vperpre as chaff " _
    //      & "From tstock WITH (NOLOCK) inner join tfou on tstock.nfounum = tfou.nfounum " _
    //      & " inner join tstockretour WITH (NOLOCK) on tstockretour.nstocknum = tstock.nstocknum " _
    //      & " inner join tref_cfo WITH (NOLOCK) on tref_cfo.ncfocod=tfou.ncfocod " _
    //      & " inner join tper WITH (NOLOCK) on tper.npernum = nchaffnum " _
    //      & " left outer join tact WITH (NOLOCK) on tact.nactnum = tstockretour.nactnum " _
    //      & "Where tstockretour.nretnum = " & iNumRetour _
    //      & " and langue='" & gstrLangue & "'"
    //  
    //  Set rsArtVisu = New adodb.Recordset
    //  rsArtVisu.Open sSQL, cnx
    //  
    //  SelectLB cboClient, rsArtVisu("nclinum")
    //  ' charge combo site
    //  
    //  If rsArtVisu("nsitnum") <> 0 Then
    //    RemplirCombo cboSite, "SELECT  NSITNUM, VSITNOM + ' - ' + NSITNUE FROM TSIT WHERE NSITNUM = " & rsArtVisu("nsitnum")
    //    SelectLB cboSite, rsArtVisu("nsitnum")
    //    If rsArtVisu("nactnum") <> 0 Then
    //      RemplirCombo cboAct, "SELECT NACTNUM, CONVERT(varchar(6),NDINNUM) + '/' + CONVERT(VARCHAR(4),NACTID) FROM TACT WITH (NOLOCK) WHERE NACTNUM = " & rsArtVisu("nactnum")
    //      SelectLB cboAct, rsArtVisu("nactnum")
    //    End If
    //  End If
    //    
    //  txtChaff.Tag = rsArtVisu("nchaffnum")
    //  txtChaff = rsArtVisu("chaff")
    //  
    //  txtDateRetour = rsArtVisu("dretour")
    //  txtObjet = rsArtVisu("vcomment")
    //  
    //  While Not rsArtVisu.EOF
    //    rsarticle.AddNew
    //  
    //    rsarticle("Serie").value = rsArtVisu("VFOUSER")
    //    rsarticle("Article").value = rsArtVisu("VFOUMAT")
    //    rsarticle("Marque").value = BlankIfNull(rsArtVisu("VFOUMAR"))
    //    rsarticle("Type").value = BlankIfNull(rsArtVisu("VFOUTYP"))
    //    rsarticle("Reference").value = BlankIfNull(rsArtVisu("VFOUREF"))
    //    rsarticle("PCB").value = ZeroIfNull(rsArtVisu("NFOUNBLOT"))
    //    rsarticle("Prix U").value = ZeroIfNull(rsArtVisu("fstockpuht"))
    //    rsarticle("Quantite").value = rsArtVisu("nstockqte")
    //    
    //    rsarticle.Update
    //    
    //    rsArtVisu.MoveNext
    //  Wend
    //
    //  rsArtVisu.Close
    //
    //  cmdValider.Enabled = False
    //  cmdDate.Enabled = False
    //  cmdRechercher.Enabled = False
    //  cboClient.Enabled = False
    //  cboSite.Enabled = False
    //  cboAct.Enabled = False
    //  
    //  rsarticle.MoveFirst
    //  Set grdDataGrid.DataSource = rsarticle
    //  FormatGridArticle
    //  RemplirTxtTotaux
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cboSite_TxtChanged(object sender, EventArgs e)
    {
      ModuleData.RemplirCombo(cboAct, $"SELECT NACTNUM, CONVERT(varchar(7),NDINNUM) + '/' + CONVERT(VARCHAR(4),NACTID) AS SITE FROM TACT WITH (NOLOCK) WHERE NSITNUM = {cboSite.GetItemData()} ORDER BY nactnum DESC");
      cboAct.ValueMember = "NACTNUM";
      cboAct.DisplayMember = "SITE";

      cboAct.SelectedIndex = 0;
      txtChaff.Text = "";
    }
    //Private Sub cboSite_Click()
    //  RemplirCombo cboAct, "SELECT NACTNUM, CONVERT(varchar(6),NDINNUM) + '/' + CONVERT(VARCHAR(4),NACTID) FROM TACT WITH (NOLOCK) WHERE NSITNUM = " & cboSite.ItemData(cboSite.ListIndex) & " ORDER BY nactnum DESC"
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
    {
      using (SqlDataReader sdr = ModuleData.ExecuteReader($"select vpernom + ' ' + vperpre, tper.npernum from tcan WITH (NOLOCK) inner join " +
          $" tper WITH (NOLOCK) ON tcan.npernum = tper.npernum inner join " +
          $" tdin WITH (NOLOCK) ON ncannum = ndincte inner join " +
          $" tact WITH (NOLOCK) ON tdin.ndinnum = tact.ndinnum where tper.vsociete ='{MozartParams.NomSociete}'" +
          $" and tact.nactnum = {cboAct.GetItemData()} order by ccanactif desc"))
      {
        if (sdr.Read())
        {
          txtChaff.Text = Utils.BlankIfNull(sdr[0]);
          txtChaff.Tag = Utils.ZeroIfNull(sdr[1]);
        }
      }
    }
    //Private Sub cboAct_Click()
    //Dim rs As adodb.Recordset
    //  
    //  ' recherche chaff
    //  Set rs = New adodb.Recordset
    //  rs.Open "select vpernom + ' ' + vperpre, tper.npernum from tcan WITH (NOLOCK) inner join " _
    //        & " tper WITH (NOLOCK) ON tcan.npernum = tper.npernum inner join " _
    //        & " tdin WITH (NOLOCK) ON ncannum = ndincte inner join " _
    //        & " tact WITH (NOLOCK) ON tdin.ndinnum = tact.ndinnum where tper.vsociete ='" & gstrNomSociete & "'" _
    //        & " and tact.nactnum = " & cboAct.ItemData(cboAct.ListIndex) & " order by ccanactif desc", cnx
    //  
    //  If rs.RecordCount > 0 Then
    //    txtChaff = BlankIfNull(rs(0))
    //    txtChaff.Tag = rs(1)
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (dtArticle.Rows.Count > 0)
        GenereListeArtRetChantier();

      new frmBrowser
      {
        msStartingAddress = MozartParams.CheminUtilisateurMozart + @"t.html"
      }.ShowDialog();
    }
    //Private Sub cmdVisu_Click()
    //    If rsarticle.RecordCount > 0 Then GenerateListeArtRetChantier
    //    
    //    frmBrowser.StartingAddress = gstrCheminUtilisateur & "\Mozart\t.html"
    //    frmBrowser.Show vbModal
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void GenereListeArtRetChantier()
    {
      try
      {
        StringBuilder strHTML = new StringBuilder();

        strHTML.AppendLine("<html><head><title> </title></head><body>");
        strHTML.AppendLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"/>");

        if (dtArticle.Rows.Count > 0)
        {
          // titre du document
          strHTML.Append($@"<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>{MozartParams.NomSociete} </H2></TD>");
          strHTML.Append("<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Liste des articles d'un retour chantier :</CENTER></H3></TD>");
          strHTML.Append($"<TD width=15%><H3>le {DateTime.Now.ToShortDateString()}</H3></TD></TR></TABLE>");

          //tableau des jours du mois
          strHTML.AppendLine($"<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>");
          strHTML.Append($"<td width=18% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Matériel</b></FONT></td>");
          strHTML.Append($"<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Marque</b></FONT></td>");
          strHTML.Append($"<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Type</b></FONT></td>");
          strHTML.Append($"<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Référence</b></FONT></td>");
          strHTML.Append($"<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Prix U</b></FONT></td>");
          strHTML.Append($"<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Quantité</b></FONT></td>");
          strHTML.AppendLine("</tr>");
          foreach (DataRow row in dtArticle.Rows)
          {
            //personne et planning de cette personne
            strHTML.Append($"<tr><td bgcolor=white><font face=Arial size=1>{row["Article"]}</FONT></td> ");
            strHTML.Append($"<td bgcolor=white><font face=Arial size=1>{row["Marque"]}</FONT></td> ");
            strHTML.Append($"<td bgcolor=white><font face=Arial size=1>{row["Type"]}</FONT></td> ");
            strHTML.Append($"<td bgcolor=white><font face=Arial size=1>{row["Reference"]}</FONT></td> ");
            strHTML.Append($"<td bgcolor=white align='right'><font face=Arial size=1>{row["Prix U"]}</FONT></td> ");
            strHTML.Append($"<td bgcolor=white align='right'><font face=Arial size=1>{row["Quantite"]}</FONT></td> ");
          }

          strHTML.AppendLine("</table>");
        }
        strHTML.Append("</body></html>");

        // Ecriture de toutes les lignes en une seule fois
        File.WriteAllText(MozartParams.CheminUtilisateurMozart + @"t.html", strHTML.ToString());
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub GenerateListeArtRetChantier()
    //
    //Dim strHtml As String
    //Dim rsImpList As New adodb.Recordset
    //
    //On Error GoTo handler
    //
    // 'Clone du recordsetlocal
    // Set rsImpList = rsarticle.Clone
    //
    // rsImpList.MoveFirst
    //
    //  ccOffset = 0
    //  strHtml = ""
    //  
    //  Concat strHtml, "<html><head><title> </title></head><body>" & vbCrLf
    //
    //  If Not rsImpList.EOF Then
    //    
    //    ' titre du document
    //    Concat strHtml, "<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & gstrNomSociete & " </H2></TD>"
    //    Concat strHtml, "<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Liste des articles d'un retour chantier :</CENTER></H3></TD>"
    //    Concat strHtml, "<TD width=15%><H3>le " & Date & "</H3></TD></TR></TABLE>"
    // 
    //    ' Tableau des jours du mois
    //    Concat strHtml, "<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>" & vbCrLf
    //    Concat strHtml, "<td width=18% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Matériel</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Marque</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Type</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Référence</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Prix U</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Quantité</b></FONT></td>"
    //    Concat strHtml, "</tr>" & vbCrLf
    //    
    //    While Not rsImpList.EOF
    //      ' personne  et planning de cette personne
    //      Concat strHtml, "<tr><td bgcolor=white><font face=Arial size=1>" & rsImpList("Article") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rsImpList("Marque") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rsImpList("Type") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rsImpList("Reference") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align='right'><font face=Arial size=1>" & rsImpList("Prix U") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align='right'><font face=Arial size=1>" & rsImpList("Quantite") & "</FONT></td> "
    //      Concat strHtml, "</tr>"
    //      rsImpList.MoveNext
    //    Wend
    //  
    //   Concat strHtml, "</table>" & vbCrLf
    // 
    //  End If
    //  
    //  rsImpList.Close
    //
    //  Concat strHtml, "</body></html>"
    //  strHtml = Left$(strHtml, ccOffset)
    //  
    //  Dim fs As New Scripting.FileSystemObject
    //  Dim ts As TextStream
    //  Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\t.html", ForWriting, True)
    //  ts.Write strHtml
    //  ts.Close
    //
    //Exit Sub
    //handler:
    //  ShowError " GenerateListeArtRetChantier dans " & Me.Name
    //End Sub
  }
}