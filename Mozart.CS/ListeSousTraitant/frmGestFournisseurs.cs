using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmGestFournisseurs : Form
  {
    public int miNumSTF;
    public string mstrNomSTF = "";
    //Public miNumSTF As Long
    //Public mstrNomSTF As String

    DataTable dtSTFGRP = new DataTable();
    DataTable dtSTF = new DataTable();
    DataTable dtW = new DataTable();
    //Dim adoRSPri As Recordset
    //Dim adoRSSec As Recordset
    //Dim adorsW As Recordset

    bool bPrem;
    //Dim bPrem As Boolean

    public frmGestFournisseurs() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmGestFournisseurs_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        bPrem = false;
        string sSql = "";

        if (MozartParams.NomSociete == "SAMSICROMANIA")
        {
          sSql = "SELECT CSTFTYP, VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, NSTFGRPCONTRATCADRE, NSTFGRPREFENCOURS, VSTFGRPCP, VSTFGRPPAYS, VSTFGRPVIL, CSTFGRPACTIF, NSTFGRPNUM, INTERDIT, CSTFGRPP3M, BSTFGRPDOCADM"
                + " FROM api_v_ListeSTFGRP WHERE VSOCIETE = 'SAMSICROMANIA' ORDER BY VSTFGRPNOM";
        }
        else if (MozartParams.NomSociete == "SAMSICITALIA")
        {
          sSql = "SELECT CSTFTYP, VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, NSTFGRPCONTRATCADRE, NSTFGRPREFENCOURS, VSTFGRPCP, VSTFGRPPAYS, VSTFGRPVIL, CSTFGRPACTIF, NSTFGRPNUM, INTERDIT, CSTFGRPP3M, BSTFGRPDOCADM"
                + " FROM api_v_ListeSTFGRP WHERE VSOCIETE = 'SAMSICITALIA' ORDER BY VSTFGRPNOM";
        }
        else
        {
          sSql = "SELECT CSTFTYP, VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, NSTFGRPCONTRATCADRE, NSTFGRPREFENCOURS, VSTFGRPCP, VSTFGRPPAYS, VSTFGRPVIL, CSTFGRPACTIF, NSTFGRPNUM, INTERDIT, CSTFGRPP3M, BSTFGRPDOCADM"
                + " FROM api_v_ListeSTFGRP WHERE (VSOCIETE <> 'SAMSICROMANIA' and VSOCIETE <> 'SAMSICITALIA') ORDER BY VSTFGRPNOM";
        }
        apiGridStfGRP.LoadData(dtSTFGRP, MozartDatabase.cnxMozart, sSql);
        apiGridStfGRP.GridControl.DataSource = dtSTFGRP;

        InitapiGridSTFGRP();
        InitapiGridSTF();

        if (mstrNomSTF != "" && miNumSTF > 0)
          apiGridStfGRP.dgv.ActiveFilterString = $"NSTFGRPNUM = {miNumSTF}";
        else if (mstrNomSTF != "" && miNumSTF == 0)
          apiGridStfGRP.dgv.ActiveFilterString = $"VSTFGRPNOM LIKE '%{mstrNomSTF}%'";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdAjouterSTF_Click(object sender, EventArgs e)
    {
      new FrmMasterWizardSTF().ShowDialog();
    }

    private void cmdCartesSTTPartenaires_Click(object sender, EventArgs e)
    {
      new frmSTTPartenaires().ShowDialog();
    }

    private void cmdModifierSTF_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridStfGRP.GetFocusedDataRow();
      if (row == null) return;

      new frmDetailsSTF()
      {
        mstrStatut = "M",
        miNumSTF = (int)row["NSTFGRPNUM"],
        mstrNomSTF = (string)row["VSTFGRPNOM"],
      }.ShowDialog();

      apiGridStfGRP.Requery(dtSTFGRP, MozartDatabase.cnxMozart);
    }

    private void cmdFourniture_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridStfGRP.GetFocusedDataRow();
      if (row == null) return;

      //uniquement si fournisseurs (ni FO, ni FT)
      if ((string)row["CSTFTYP"] == "ST")
      {
        MessageBox.Show(Resources.msg_must_select_fournisseur, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      new frmGestFournitures()
      {
        mIdFournisseur = (int)row["NSTFGRPNUM"],
      }.ShowDialog();
    }

    private void cmdInfo_Click(object sender, EventArgs e)
    {
      //on sort si pas de sites
      DataRow row = apiGridStfGRP.GetFocusedDataRow();
      if (row == null) return;

      //Nouvelle version générique
      //ajout mc car bug (si on note un stf depuis un action, quand on revient sur cette fenetre depuis l admin->FO/ST, on a toujours le message pour noter le stf)

      new frmSaisieInfoSTT()
      {
        mstrTypeNote = "INFO_STF",
        mbNoteVisible = false,
        miCleTable = (int)row["NSTFGRPNUM"],
      }.ShowDialog();
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmGestFournisseursArch().ShowDialog();
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      DataRow row = apiGridStfGRP.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_Archiv_Entreprise, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        return;

      DataTable oDT_FO_To_DELETE = new DataTable();

      //test si des fournitures existe avec un prix que pour cette FO
      if (row["CSTFTYP"].ToString().StartsWith("F"))
      {

        if (MessageBox.Show("Attention vous allez désaffecter définitivement ce fournisseur de toutes les lignes de fournitures dans lequel il apparait", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;


        DataTable oDT_FO_UIQUE = new DataTable();
        oDT_FO_UIQUE.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Fournisseur_Authorized_Archive] {row["NSTFGRPNUM"]}, 0"));
        if (oDT_FO_UIQUE.Rows.Count > 0)
        {
          MessageBox.Show("Attention ce fournisseur est unique dans plusieurs lignes d' articles de fournitures, vous devez préalablement archiver les fournitures correspondantes ou rajouter un autre fournisseur sur l' article", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //on charge la liste des fo à supprimer car elles ont d'autres prix sur un autre fournisser
        oDT_FO_To_DELETE.Load(ModuleData.ExecuteReader($"EXEC [api_sp_Fournisseur_Authorized_Archive] {row["NSTFGRPNUM"]}, 1"));
      }

      //activation de tous les sites
      ModuleData.ExecuteNonQuery($"UPDATE TSTF SET CSTFACTIF = 'N' WHERE NSTFGRPNUM = {row["NSTFGRPNUM"]}");
      //activation du groupe
      ModuleData.ExecuteNonQuery($"UPDATE TSTFGRP SET CSTFGRPACTIF = 'N' Where NSTFGRPNUM = {row["NSTFGRPNUM"]}");

      //on supprime les lignes fo
      ModuleData.ExecuteNonQuery($"EXEC [api_sp_Fournisseur_Authorized_Archive] {row["NSTFGRPNUM"]}, 3");

      if (oDT_FO_To_DELETE.Rows.Count > 0)
      {
        MessageBox.Show($"Le prix des fournitures (représentant un total de {oDT_FO_To_DELETE.Rows.Count}) de ce founisseur {row["VSTFGRPNOM"]} ont été supprimés avec succès", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      apiGridStfGRP.Requery(dtSTFGRP, MozartDatabase.cnxMozart);
    }

    private void CmdF_Click(object sender, EventArgs e)
    {
      framWeb.Visible = false;
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      Frame1.Visible = !Frame1.Visible;
    }

    private void cmdArchSite_Click(object sender, EventArgs e)
    {
      DataRow rowStfGRP = apiGridStfGRP.GetFocusedDataRow();
      DataRow rowStf = ApiGridStf.GetFocusedDataRow();
      if (rowStfGRP == null || rowStf == null) return;

      if (cmdArchSite.Text == Resources.txt_Restaurer)
      {
        if (MessageBox.Show(Resources.msg_Confirm_restaurer_entreprise, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        ModuleData.ExecuteNonQuery($"EXEC api_sp_RestaurerSTF {rowStf["NSTFNUM"]}");
      }
      else
      {
        if (MessageBox.Show(Resources.msg_Confirm_Archiv_Entreprise, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        ModuleData.SupprimerEnreg((int)rowStf["NSTFNUM"], "api_sp_ArchiverSTF", "@iNumSTF");
      }

      apiGridStfGRP.Requery(dtSTFGRP, MozartDatabase.cnxMozart);
    }

    private void InitapiGridSTFGRP()
    {
      apiGridStfGRP.AddColumn(Resources.col_FO_ST, "CSTFTYP", 600, "");
      apiGridStfGRP.AddColumn(Resources.col_Nom, "VSTFGRPNOM", 3000);
      //apiGridStfGRP.AddColumn(Resources.col_Adresse1, "VSTFGRPAD1", 3100);
      //apiGridStfGRP.AddColumn(Resources.col_Adresse2, "VSTFGRPAD2", 2000);
      apiGridStfGRP.AddColumn(Resources.col_CP, "VSTFGRPCP", 1100);
      apiGridStfGRP.AddColumn(Resources.col_Ville, "VSTFGRPVIL", 2800);
      apiGridStfGRP.AddColumn(Resources.col_Pays, "VSTFGRPPAYS", 1800);
      apiGridStfGRP.AddColumn("Contrat cadre", "NSTFGRPCONTRATCADRE", 2000);
      apiGridStfGRP.AddColumn("Réf en cours", "NSTFGRPREFENCOURS", 2000);
      apiGridStfGRP.AddColumn(Resources.col_Actif, "CSTFGRPACTIF", 0);
      apiGridStfGRP.AddColumn("NUMSTFGRP", "NSTFGRPNUM", 0);
      apiGridStfGRP.AddColumn(Resources.col_interdit, "INTERDIT", 0);
      apiGridStfGRP.AddColumn("PRIVILEGE", "CSTFGRPP3M", 0);
      apiGridStfGRP.AddColumn("BSTFGRPDOCADM", "BSTFGRPDOCADM", 2000);

      apiGridStfGRP.InitColumnList();
    }

    private void apiGridStfGRP_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0)
      {
        return;
      }

      GridView View = sender as GridView;
      if (View.GetDataRow(e.RowHandle)["INTERDIT"].ToString() == "O")
      {
        e.Appearance.BackColor = MozartColors.ColorH8080FF;
      }
      else
      {
        if (View.GetDataRow(e.RowHandle)["CSTFGRPP3M"].ToString() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorHDDFFBB;
        }
        else
        {
          if (View.GetDataRow(e.RowHandle)["BSTFGRPDOCADM"].ToString() == "O")
          {
            e.Appearance.BackColor = MozartColors.ColorH80FFFF;
          }
        }
      }
    }

    //Sub InitapiGridSTFGRP()
    //  
    //On Error GoTo handler
    //  
    //  
    //  apiGridStfGRP.AddColumn "§FO/ST§", "CSTFTYP", 600, , vbCenter
    //  apiGridStfGRP.AddColumn "§Nom§", "VSTFGRPNOM", 3000
    //  'apiGridStfGRP.AddColumn "§Adresse 1§", "VSTFGRPAD1", 3100
    //  'apiGridStfGRP.AddColumn "§Adresse 2§", "VSTFGRPAD2", 2000
    //  apiGridStfGRP.AddColumn "§CP §", "VSTFGRPCP", 1100
    //  apiGridStfGRP.AddColumn "§Ville§", "VSTFGRPVIL", 2800
    //  apiGridStfGRP.AddColumn "§Pays§", "VSTFGRPPAYS", 1800
    //  apiGridStfGRP.AddColumn "Contrat cadre", "NSTFGRPCONTRATCADRE", 2000
    //  apiGridStfGRP.AddColumn "Réf en cours", "NSTFGRPREFENCOURS", 2000
    //  apiGridStfGRP.AddColumn "§Actif§", "CSTFGRPACTIF", 0
    //  apiGridStfGRP.AddColumn "NUMSTFGRP", "NSTFGRPNUM", 0
    //  apiGridStfGRP.AddColumn "§INTERDIT§", "INTERDIT", 0
    //  apiGridStfGRP.AddColumn "PRIVILEGE", "CSTFGRPP3M", 0
    //  apiGridStfGRP.AddColumn "BSTFGRPDOCADM", "BSTFGRPDOCADM", 2000
    //  
    //  apiGridStfGRP.AddRowStyle "INTERDIT", "INTERDIT", "O", , &H8080FF
    //  apiGridStfGRP.AddRowStyle "CSTFGRPP3M", "CSTFGRPP3M", "O", , &HDDFFBB
    //  
    //  apiGridStfGRP.AddRowStyle "BSTFGRPDOCADM", "BSTFGRPDOCADM", "O", , &H80FFFF
    //  
    //  apiGridStfGRP.Init adoRSPri
    //  
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitapiGridSTFGRP dans " & Me.Name
    //End Sub
    //
    private void InitapiGridSTF()
    {
      ApiGridStf.AddColumn(Resources.col_Nom, "VSTFNOM", 1600);
      ApiGridStf.AddColumn(Resources.col_Type, "CSTFTYP", 450, "", 2);
      ApiGridStf.AddColumn(Resources.col_VilleCible, "VSTFVIC", 1200);
      ApiGridStf.AddColumn(Resources.col_Adresse1, "VSTFAD1", 1300);
      ApiGridStf.AddColumn(Resources.col_Adresse2, "VSTFAD2", 600);
      ApiGridStf.AddColumn(Resources.col_CP, "VSTFCP", 650);
      ApiGridStf.AddColumn(Resources.col_Ville, "VSTFVIL", 1200);
      ApiGridStf.AddColumn(Resources.col_Tel_astreinte, "VSTFTEL", 1200);
      ApiGridStf.AddColumn(Resources.col_Activite, "VSTFAC1", 1500);

      if (MozartParams.NomSociete == "EMALECSUISSE")
      {
        ApiGridStf.AddColumn(Resources.col_CHF_Heure, "NSTFMOE", 650, "", 2);
        ApiGridStf.AddColumn(Resources.col_CHF_Depl, "NSTFDEP", 650, "", 2);
      }
      else
      {
        ApiGridStf.AddColumn(Resources.col_euro_heure, "NSTFMOE", 650, "", 2);
        ApiGridStf.AddColumn(Resources.col_euro_depl, "NSTFDEP", 650, "", 2);
      }

      ApiGridStf.AddColumn(Resources.col_Observation, "VSTFOBS", 0);
      ApiGridStf.AddColumn(Resources.col_Actif, "CSTFACTIF", 600);
      ApiGridStf.AddColumn(Resources.col_Pays, "VSTFPAYS", 600);
      ApiGridStf.AddColumn("NumSTF", "NSTFNUM", 0);

      ApiGridStf.InitColumnList();
    }
    private void ApiGridStf_RowStyle(object sender, RowStyleEventArgs e)
    {
    }

    private void ApiGridStf_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0)
      {
        return;
      }

      if (ApiGridStf.dgv.GetDataRow(e.RowHandle)["CSTFACTIF"].ToString().ToUpper() == "N")
      {
        e.Appearance.ForeColor = MozartColors.ColorHC0C0C0;
      }
    }

    //Sub InitapiGridSTF()
    //  
    //On Error GoTo handler
    //  
    //  ApiGridStf.AddColumn "§Nom§", "VSTFNOM", 1600
    //  ApiGridStf.AddColumn "§Type §", "CSTFTYP", 450, , 2
    //  ApiGridStf.AddColumn "§Ville cible§", "VSTFVIC", 1200
    //  ApiGridStf.AddColumn "§Adresse 1§", "VSTFAD1", 1300
    //  ApiGridStf.AddColumn "§Adresse 2§", "VSTFAD2", 600
    //  ApiGridStf.AddColumn "§CP §", "VSTFCP", 650
    //  ApiGridStf.AddColumn "§Ville§", "VSTFVIL", 1400
    //  ApiGridStf.AddColumn "§Tel astreinte§", "VSTFTEL", 1200
    //  ApiGridStf.AddColumn "§Activité§", "VSTFAC1", 1500
    //  
    //  If gstrNomSociete = "EMALECSUISSE" Then
    //    ApiGridStf.AddColumn "§CHF Heure§", "NSTFMOE", 650, , 2
    //    ApiGridStf.AddColumn "§CHF Depl§", "NSTFDEP", 650, , 2
    //  Else
    //    ApiGridStf.AddColumn "§€ Heure§", "NSTFMOE", 650, , 2
    //  ApiGridStf.AddColumn "§€ Depl§", "NSTFDEP", 650, , 2
    //  End If
    //  
    //  
    //  ApiGridStf.AddColumn "§Observations§", "VSTFOBS", 0
    //  ApiGridStf.AddColumn "§Actif§", "CSTFACTIF", 600
    //  ApiGridStf.AddColumn "§Pays§", "VSTFPAYS", 600
    //  ApiGridStf.AddColumn "NumSTF", "NSTFNUM", 0
    //  
    //  ApiGridStf.AddRowStyle "§Actif§", "CSTFACTIF", "N", &HC0C0C0
    //  
    //  ApiGridStf.Init adoRSSec
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitapiGridSTFGRP dans " & Me.Name
    //End Sub
    //

    private void InitapiGridWeb()
    {
      apiTGridW.AddColumn(Resources.col_Nom, "VSTFGRPNOM", 3100);
      apiTGridW.AddColumn(Resources.col_Connexion, "NB", 1000, "", 2);

      apiTGridW.InitColumnList();
    }
    //Sub InitapiGridWeb()
    //  
    //On Error GoTo handler
    //  
    //  apiTGridW.AddColumn "§Nom§", "VSTFGRPNOM", 3100
    //  apiTGridW.AddColumn "§Connexion§", "NB", 1000, , 2
    //   
    //  apiTGridW.Init adorsW
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitapiGridWeb dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouterSiteStf_Click(object sender, EventArgs e)
    {
      DataRow rowStfGRP = apiGridStfGRP.GetFocusedDataRow();
      DataRow rowStf = ApiGridStf.GetFocusedDataRow();
      if (rowStfGRP == null || rowStf == null) return;

      if (MessageBox.Show("Vous voulez ajouter un site sur le sous-traitant ", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      new frmDetailsSiteSTF()
      {
        mstrStatut = "C",
        miNumSTFGRP = (int)rowStfGRP["NSTFGRPNUM"],
        miNumSTF = 0,
      }.ShowDialog();

      ApiGridStf.Requery(dtSTF, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdAjouterSiteStf_Click()
    //  
    //  If adoRSPri.EOF Then Exit Sub
    //  If adoRSSec.EOF Then Exit Sub
    //  
    //  If MsgBox("Vous voulez ajouter un site sur le sous-traitant " & adoRSPri("VSTFGRPNOM") & " ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    frmDetailsSiteSTF.mstrStatut = "C"
    //    frmDetailsSiteSTF.miNumSTFGRP = adoRSPri("NSTFGRPNUM")
    //    frmDetailsSiteSTF.miNumSTF = 0
    //    frmDetailsSiteSTF.Show vbModal
    //    adoRSSec.Requery
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdModifierSiteSTF_Click(object sender, EventArgs e)
    {
      DataRow rowStfGRP = apiGridStfGRP.GetFocusedDataRow();
      DataRow rowStf = ApiGridStf.GetFocusedDataRow();
      if (rowStfGRP == null || rowStf == null) return;

      new frmDetailsSiteSTF()
      {
        mstrStatut = "M",
        miNumSTFGRP = Convert.ToInt32(rowStfGRP["NSTFGRPNUM"]),
        miNumSTF = Convert.ToInt32(rowStf["NSTFNUM"]),
        msCSTFTYP = Convert.ToString(rowStf["CSTFTYP"]),
      }.ShowDialog();

      apiGridStfGRP_SelectionChanged(null, null);
    }
    //Private Sub cmdModifierSiteSTF_Click()
    //  If adoRSPri.EOF Then Exit Sub
    //  If adoRSSec.EOF Then Exit Sub
    //  
    //  frmDetailsSiteSTF.mstrStatut = "M"
    //  frmDetailsSiteSTF.miNumSTFGRP = adoRSPri("NSTFGRPNUM")
    //  frmDetailsSiteSTF.miNumSTF = adoRSSec("NSTFNUM")
    //  frmDetailsSiteSTF.miCSTFTYP = adoRSSec("CSTFTYP")
    //  frmDetailsSiteSTF.Show vbModal
    //  Call apiGridStfGRP_rowcolchange
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdContacts_Click(object sender, EventArgs e)
    {
      DataRow rowStf = ApiGridStf.GetFocusedDataRow();
      if (rowStf == null) return;

      new frmGestIntervenants()
      {
        miNumFourn = (int)rowStf["NSTFNUM"],
        msNomFourn = (string)rowStf["VSTFNOM"],
      }.ShowDialog();
    }
    //Private Sub cmdContacts_Click()
    //  
    //  If adoRSSec.EOF Then Exit Sub
    //
    //  If gModeActiveX Then
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmGestIntervenants miNumFourn=" & adoRSSec("NSTFNUM") & "|msNomFourn=" & adoRSSec("VSTFNOM"), vbNormalFocus
    //  Else
    //    frmGestIntervenants.miNumFourn = adoRSSec("NSTFNUM")
    //    frmGestIntervenants.msNomFourn = adoRSSec("VSTFNOM")
    //    frmGestIntervenants.Show vbModal
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiGridStfGRP_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      int nStfGrpNum;
      DataRow rowStfGRP = apiGridStfGRP.GetFocusedDataRow();
      if (rowStfGRP == null)
        nStfGrpNum = 0;
      else
      {
        nStfGrpNum = (int)rowStfGRP["NSTFGRPNUM"];
        cmdFourniture.Enabled = (string)rowStfGRP["CSTFTYP"] == "ST" ? false : true;
      }
      //Synchro avec l'apigrid du dessous
      ApiGridStf.LoadData(dtSTF, MozartDatabase.cnxMozart, $"SELECT VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL, VSTFTEL, VSTFAC1, NSTFMOE, NSTFDEP, CSTFACTIF, NSTFNUM, VSTFPAYS  FROM api_v_ListeSTF WHERE NSTFGRPNUM = {nStfGrpNum} ORDER BY CSTFACTIF DESC, VSTFNOM ASC");
      ApiGridStf.GridControl.DataSource = dtSTF;

      DataRow rowStf = ApiGridStf.GetFocusedDataRow();
      if (rowStf == null) return;

      //gestion bouton archiver/restaurer
      if (Utils.ZeroIfNull(rowStf["NSTFNUM"]) != 0)
      {
        if ((string)rowStf["CSTFACTIF"] == "O")
          cmdArchSite.Text = Resources.txt_Archiver;
        else
          cmdArchSite.Text = Resources.txt_Restaurer;
      }
    }
    //Private Sub apiGridStfGRP_rowcolchange()
    //Dim nStfGrpNum  As Long
    //
    //On Error GoTo handler
    //  
    //  If adoRSPri.EOF Then
    //    nStfGrpNum = 0
    //  Else
    //    nStfGrpNum = adoRSPri("NSTFGRPNUM")
    //    cmdFourniture.Enabled = IIf(adoRSPri("CSTFTYP") = "ST", False, True)
    //  End If
    //  
    //  ' Synchro avec l'apigrid du dessous
    //  Set adoRSSec = New Recordset
    //  adoRSSec.Open "SELECT VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL, VSTFTEL, VSTFAC1, NSTFMOE, NSTFDEP, CSTFACTIF, NSTFNUM, VSTFPAYS  FROM api_v_ListeSTF WHERE NSTFGRPNUM = " & nStfGrpNum & " ORDER BY CSTFACTIF DESC, VSTFNOM ASC", cnx, adOpenStatic, adLockOptimistic
    //  ApiGridStf.Init adoRSSec
    //  
    //  If adoRSSec.RecordCount > 0 Then
    //      
    //    'gestion bouton archiver/restaurer
    //
    //    If ZeroIfNull(adoRSSec("NSTFNUM")) <> 0 Then
    //      Select Case adoRSSec("CSTFACTIF")
    //        Case "O"
    //          cmdArchSite.Caption = "§Archiver§"
    //        Case Else
    //          cmdArchSite.Caption = "§Restaurer§"
    //      End Select
    //    End If
    //  End If
    //  
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "apiGridStfGRP_RowColChange dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void ApiGridStf_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = ApiGridStf.GetFocusedDataRow();
      if (row == null) return;

      if (Utils.ZeroIfNull(row["NSTFNUM"]) != 0)
      {
        if ((string)row["CSTFACTIF"] == "O")
          cmdArchSite.Text = Resources.txt_Archiver;
        else
          cmdArchSite.Text = Resources.txt_Restaurer;
      }
    }
    //Private Sub ApiGridStf_Click()
    //
    //  If adoRSSec.RecordCount = 0 Then Exit Sub
    //
    //  If ZeroIfNull(adoRSSec("NSTFNUM")) <> 0 Then
    //    Select Case adoRSSec("CSTFACTIF")
    //      Case "O"
    //        cmdArchSite.Caption = "§Archiver§"
    //      Case Else
    //        cmdArchSite.Caption = "§Restaurer§"
    //    End Select
    //  End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdDocCa_Click(object sender, EventArgs e)
    {
      if (dtSTFGRP.Rows.Count == 0) return;

      DataRow row = apiGridStfGRP.GetFocusedDataRow();
      if (row == null || (string)row["CSTFTYP"] == "FO") return;

      new frmGestDocAdminSTF()
      {
        miStfGrpNnum = (int)row["NSTFGRPNUM"],
        mstrNom = (string)row["VSTFGRPNOM"],
      }.ShowDialog();
    }
    //Private Sub cmdDocCa_Click()
    //    If adoRSPri.RecordCount = 0 Then Exit Sub
    //    If adoRSPri("CSTFTYP") = "FO" Then Exit Sub
    //
    //    frmGestDocAdminSTF.iStfGrpNnum = adoRSPri("NSTFGRPNUM")
    //    frmGestDocAdminSTF.strNom = adoRSPri("VSTFGRPNOM")
    //    frmGestDocAdminSTF.Show vbModal
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdWeb_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (!bPrem)
        {
          //Synchro avec l'apigrid du dessous
          apiTGridW.LoadData(dtW, MozartDatabase.cnxMozart, "exec api_sp_LogWebSTT");
          apiTGridW.GridControl.DataSource = dtW;
          InitapiGridWeb();
          bPrem = true;
        }
        framWeb.Visible = true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdWeb_Click()
    //
    //  Screen.MousePointer = vbHourglass
    //
    //  If Not bPrem Then
    //  ' Synchro avec l'apigrid du dessous
    //   Set adorsW = New Recordset
    //   adorsW.Open "exec api_sp_LogWebSTT", cnx, adOpenStatic, adLockOptimistic
    //   
    //   InitapiGridWeb
    //   apiTGridW.Init adorsW
    //   bPrem = True
    //  End If
    //  framWeb.Visible = True
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCarteSTT_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      if (apiGridStfGRP.dgv.ActiveFilter.Count == 0)
      {
        MessageBox.Show("Vous devez d'abord faire un filtre pour limiter le nombre de résultats.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Cursor.Current = Cursors.Default;
        return;
      }
      if (apiGridStfGRP.dgv.RowCount == 0) return;

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        bool bPremPassage = true, bPremPassage2 = true;
        int icone = 0;
        string paysprec = "";

        DataTable dtTemp = dtSTFGRP.Clone();
        for (int i = 0; i < apiGridStfGRP.dgv.RowCount; i++)
        {
          DataRow row = apiGridStfGRP.dgv.GetDataRow(i);
          dtTemp.Rows.Add(row.ItemArray);
        }

        DataView vue2 = new DataView(dtTemp);
        vue2.Sort = "vstfgrppays ASC, vstfgrpnom ASC";
        for (int i = 0; i < vue2.Count; i++)
        {
          DataRow row = vue2[i].Row;

          string vnom = "";
          string vnum = "";
          string vstfEtrType = "";

          using (SqlDataReader sdrSTF2 = ModuleData.ExecuteReader($"select nstfnum, vstfnom, vstfpays, vstfgrppays, vstfetrtype, VListeVilles from tstf inner join tstfgrp on tstfgrp.nstfgrpnum = tstf.nstfgrpnum where tstf.cstftyp <> 'FO' and cstfactif = 'O' and tstf.nstfgrpnum = {row["NSTFGRPNUM"]} order by vstfpays"))
          {
            if (sdrSTF2.Read())
            {
              //On cherche les pays sélectionnés pour avoir des icônes de couleurs différentes sur la carte :-(
              if (paysprec != sdrSTF2["vstfgrppays"].ToString())
              {
                paysprec = sdrSTF2["vstfgrppays"].ToString();
                if (icone < 10) icone++; //10 icônes différentes au maxi, sur la google map
              }

              vnom = sdrSTF2["VSTFNOM"].ToString();
              vnum = sdrSTF2["NSTFNUM"].ToString();
              vstfEtrType = Utils.BlankIfNull(sdrSTF2["vstfetrtype"].ToString());

              // stocker les données à afficher dans la table temporaire TTMP_STTPartenaires
              ModuleData.ExecuteNonQuery($"EXEC api_sp_Initialiser_TTMP_STTPartenaires {MozartParams.UID}, {vnum}, '{vnom.Replace("'", "''")}', '{row["VSTFGRPNOM"].ToString().Replace("'", "''")}', '{vstfEtrType}', '', {(bPremPassage ? 1 : 0)}");
              bPremPassage = false;

              if (Utils.BlankIfNull(sdrSTF2["VListeVilles"]) != "")
              {
                string[] lstVilles = sdrSTF2["VListeVilles"].ToString().Split(';');
                for (int v = 0; v < lstVilles.Length; v++)
                {
                  if (lstVilles[v].ToString() == "") continue;
                  using (SqlDataReader sdrVil = ModuleData.ExecuteReader($"select pays, ville from tvilles where id = {lstVilles[v]}"))
                  {
                    if (sdrVil.Read())
                    {
                      // Stocker les données à afficher dans la table temporaire TTMP_STTPartenaires2
                      ModuleData.ExecuteNonQuery($"EXEC api_sp_Initialiser_TTMP_STTPartenaires2 {MozartParams.UID}, '{sdrVil["pays"]}', '{Utils.BlankIfNull(sdrVil["ville"]).Replace("'", "''")}', {icone},{(bPremPassage2 ? 1 : 0)}");
                      bPremPassage2 = false;
                    }
                  }
                }
              }
            }
          }
        }
        vue2.Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }

      // Affichage de la map
      // TB SAMSIC CITY SPEC
      if (MozartParams.NomGroupe == "EMALEC")
      {
        new frmBrowser()
        {
          msStartingAddress = $"https://maps.emalec.com/STT_Selectionnes.asp?BASE=MULTI&NPERNUM={MozartParams.UID}&APP={MozartParams.NomSociete}"
        }.ShowDialog();
      }
    }

    private void BtnQCM_Click(object sender, EventArgs e)
    {

      new frmQCMAffectSTF().ShowDialog();

    }

    //Private Sub cmdCarteSTT_Click()
    //  
    //  Dim rsSTF As ADODB.Recordset
    //  Dim rsSTF2 As ADODB.Recordset
    //    
    //  Screen.MousePointer = vbHourglass
    //  
    //  If apiGridStfGRP.GetFilter = "" Then
    //    MsgBox ("Vous devez d'abord faire un filtre pour limiter le nombre de résultats.")
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //  
    //  If adoRSPri.RecordCount = 0 Then Exit Sub
    //  
    //  adoRSPri.MoveFirst
    //  Dim bPremPassage, bPremPassage2 As Boolean
    //  bPremPassage = True
    //  bPremPassage2 = True
    //
    //  Set rsSTF = New ADODB.Recordset
    //  Set rsSTF2 = New ADODB.Recordset
    //
    //  Dim icone As Integer
    //  Dim paysprec As String
    //  icone = 0
    //  adoRSPri.Sort = "vstfgrppays ASC, vstfgrpnom ASC"
    //  While Not adoRSPri.EOF
    //    Dim vnom, vnum, VstfEtrType As String
    //    rsSTF2.Open "select nstfnum, vstfnom, vstfpays, vstfgrppays, vstfetrtype, VListeVilles from tstf inner join tstfgrp on tstfgrp.nstfgrpnum = tstf.nstfgrpnum where tstf.cstftyp <> 'FO' and cstfactif = 'O' and tstf.nstfgrpnum = " & adoRSPri("NSTFGRPNUM") & " order by vstfpays", cnx, adOpenStatic, adLockOptimistic
    //    
    //    While Not rsSTF2.EOF
    //    
    //      ' On cherche les pays sélectionnés pour avoir des icônes de couleurs différentes sur la carte :-(
    //      If paysprec <> rsSTF2("vstfgrppays") Then
    //        paysprec = rsSTF2("vstfgrppays")
    //        If icone < 10 Then icone = icone + 1  ' 10 icônes différentes au maxi, sur la google map
    //      End If
    //      
    //      vnom = rsSTF2("VSTFNOM")
    //      vnum = rsSTF2("NSTFNUM")
    //      VstfEtrType = BlankIfNull(rsSTF2("vstfetrtype"))
    //      
    //      ' Stocker les données à afficher dans la table temporaire TTMP_STTPartenaires
    //      If bPremPassage = True Then
    //        rsSTF.Open "EXEC api_sp_Initialiser_TTMP_STTPartenaires " & gintUID & ", " & vnum & ", '" & Replace(vnom, "'", "''") & "', '" & Replace(adoRSPri("VSTFGRPNOM"), "'", "''") & "', '" & VstfEtrType & "', '', 1", cnx, adOpenStatic, adLockOptimistic
    //        bPremPassage = False
    //      Else
    //        rsSTF.Open "EXEC api_sp_Initialiser_TTMP_STTPartenaires " & gintUID & ", " & vnum & ", '" & Replace(vnom, "'", "''") & "', '" & Replace(adoRSPri("VSTFGRPNOM"), "'", "''") & "', '" & VstfEtrType & "', '', 0", cnx, adOpenStatic, adLockOptimistic
    //      End If
    //      
    //      If BlankIfNull(rsSTF2("VListeVilles")) <> "" Then
    //        Dim LstVilles() As String
    //        Dim i As Integer
    //        
    //        LstVilles = Split(rsSTF2("VListeVilles"), ";")
    //        For i = 0 To UBound(LstVilles) - 1
    //          Dim rsVil As ADODB.Recordset
    //          Set rsVil = New ADODB.Recordset
    //          rsVil.Open "select pays, ville from tvilles where id = " & LstVilles(i), cnx, adOpenStatic, adLockOptimistic
    //          If Not rsVil.EOF Then
    //          
    //            ' Stocker les données à afficher dans la table temporaire TTMP_STTPartenaires2
    //            If bPremPassage2 = True Then
    //              rsSTF.Open "EXEC api_sp_Initialiser_TTMP_STTPartenaires2 " & gintUID & ", '" & rsVil("pays") & "', '" & Replace(rsVil("ville"), "'", "''") & "', " & icone & ", 1", cnx, adOpenStatic, adLockOptimistic
    //              bPremPassage2 = False
    //            Else
    //              rsSTF.Open "EXEC api_sp_Initialiser_TTMP_STTPartenaires2 " & gintUID & ", '" & rsVil("pays") & "', '" & Replace(rsVil("ville"), "'", "''") & "', " & icone & ", 0", cnx, adOpenStatic, adLockOptimistic
    //            End If
    //            
    //          End If
    //          
    //        Next i
    //      End If
    //    
    //      rsSTF2.MoveNext
    //    Wend
    //    
    //    rsSTF2.Close
    //    adoRSPri.MoveNext
    //  Wend
    // 
    //  Screen.MousePointer = vbDefault
    //  
    //  ' Affichage de la map
    //  ' TB SAMSIC CITY SPEC
    //  If gstrNomGroupe = "EMALEC" Then
    //    frmBrowser.StartingAddress = "http://maps.emalec.com/STT_Selectionnes.asp?BASE=MULTI&NPERNUM=" & gintUID & "&APP=" & gstrNomSociete
    //  End If ' TB SAMSIC CITY TODO -> Ajouter else pour samsic
    //  frmBrowser.Show vbModal
    //  
    //End Sub
    //

  }
}

