using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestPersArch : Form
  {
    public int mIdMenuParentPerArch;

    DataTable dt = new DataTable();

    public frmGestPersArch() { InitializeComponent(); }

    private void frmGestPersArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Label1.Text += $" {MozartParams.NomSocieteTemp}";

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListePersonnel2 '{MozartParams.NomSocieteTemp}','N',0,{mIdMenuParentPerArch}");
        apiGrid.GridControl.DataSource = dt;

        InitApigrid();

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
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //  
    //  Label1.Caption = Label1.Caption & gstrNomSocieteTemp
    //
    //   Set adors = New Recordset
    //  adors.Open "exec api_sp_ListePersonnel '" & gstrNomSocieteTemp & "','N',0," & IdMenuParentPerArch, cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "FormLoad dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dt.Rows.Count == 0 || currentRow == null) return;

      frmDetailPersonnel f = new frmDetailPersonnel();
      f.mFormParent = this.Name;
      f.mstrLibNomSoc = currentRow["VSOCIETE"].ToString();
      f.mstrStatut = "M";
      f.miNumPer = Convert.ToInt32(currentRow["npernum"]);
      f.ShowDialog();
    }
    //Private Sub cmdModifier_Click()
    //  
    //  If adors.RecordCount = 0 Then Exit Sub
    //
    //  If gModeActiveX And gMDNUserTest Then
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmDetailPersonnel mstrStatut=M|mFormParent=" _
    //                                                               & Me.Name & "|mstrLibNomSoc=" & adors("VSOCIETE") & "|miNumPer=" & adors!npernum, vbNormalFocus
    //  Else
    //    frmDetailPersonnel.sFormParent = Me.Name
    //    frmDetailPersonnel.sLibNomSoc = adors("VSOCIETE")
    //    frmDetailPersonnel.mstrStatut = "M"
    //    frmDetailPersonnel.miNumPer = adors!npernum
    //    frmDetailPersonnel.Show vbModal
    //  End If
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdRestaurer_Click(object sender, EventArgs e)
    {

      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        if (MessageBox.Show(Resources.msg_ask_to_restore_this_person, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.SupprimerEnreg(Convert.ToInt64(currentRow["NPERNUM"]), "api_sp_RestaurerPersonne", "@iNumPer");

        //rafraichissement
        apiGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdRestaurer_Click()
    //
    //On Error GoTo handler
    //
    //  If adors.EOF Then Exit Sub
    //        
    //  If MsgBox("§Voulez-vous vraiment restaurer cette personne ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    SupprimerEnreg adors("NPERNUM").value, "api_sp_RestaurerPersonne", "@iNumPer"
    //  End If
    //  
    //  ' rafraichissement du recordset
    //  adors.Requery
    //
    //  ' mise en page du tableau
    //  InitApigrid
    // 
    //Exit Sub
    //handler:
    //  ShowError "cmdRestaurer_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdComptecli_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      //si ce n'est pas un CA on sort
      if (currentRow["CPERTYP"].ToString() != "CA")
      {
        MessageBox.Show(Resources.msg_pasChargeAffaires, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      frmGestComptePer f = new frmGestComptePer();
      f.miNumPersonne = Convert.ToInt32(currentRow["NPERNUM"]);
      f.ShowDialog();
    }
    //Private Sub cmdComptecli_Click()
    //  
    //On Error GoTo handler
    //  
    //  If adors.EOF Then Exit Sub
    //  
    //  'si ce n'est pas un CA on sort
    //  If adors("CPERTYP") <> "CA" Then
    //    MsgBox "§Ce n'est pas un Chargé d'affaire§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //  frmGestComptePer.miNumPersonne = adors("NPERNUM")
    //  frmGestComptePer.Show vbModal
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdComptecli_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdWeb_Click(object sender, EventArgs e)
    {

      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        frmGestWebPer f = new frmGestWebPer();
        f.miNumPersonne = Convert.ToInt32(currentRow["NPERNUM"]);
        f.msTypePer = "T";
        f.ShowDialog();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdWeb_Click()
    // 
    //On Error GoTo handler
    //  
    //  If adors.EOF Then Exit Sub
    //
    //  If gModeActiveX And gMDNUserTest Then
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmGestWebPer msTypePer=T|miNumPersonne=" & adors("NPERNUM"), vbNormalFocus
    //  Else
    //    frmGestWebPer.miNumPersonne = adors("NPERNUM")
    //    frmGestWebPer.sTypePer = "T"
    //    frmGestWebPer.Show vbModal
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdWeb_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdListeDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null || dt.Rows.Count == 0) return;

      Cursor = Cursors.WaitCursor;
      frmListeDIPersArch f = new frmListeDIPersArch();
      f.miNumPer = Convert.ToInt32(currentRow["npernum"]);
      f.ShowDialog();
      Cursor = Cursors.Default;
    }
    //Private Sub cmdListeDI_Click()
    //  
    //  If adors.RecordCount = 0 Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  frmListeDIPersArch.miNumPer = adors!npernum
    //  frmListeDIPersArch.Show vbModal
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdDocPersoSecu_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null || Utils.ZeroIfNull(currentRow["NPERNUM"]) == 0) return;

      //gestion des documents sensibles
      frmListeFicPerso f = new frmListeFicPerso();
      f.msLibNomSoc = currentRow["VSOCIETE"].ToString();
      f.mstrNomPerso = currentRow["VPERNOM"].ToString();
      f.mstrPrenomPerso = currentRow["VPERPRE"].ToString();
      f.mlIdPerso = Convert.ToInt64(currentRow["NPERNUM"]);
      f.mstrTypePerso = "PERSOSECU";
      f.ShowDialog();
    }
    //Private Sub CmdDocPersoSecu_Click()
    //  If ZeroIfNull(adors("NPERNUM")) = 0 Then Exit Sub
    //  
    //  ' gestion des documents sensibles
    //  frmListeFicPerso.sLibNomSoc = adors("VSOCIETE")
    //  frmListeFicPerso.mstrNomPerso = adors("VPERNOM")
    //  frmListeFicPerso.mstrPrenomPerso = adors("VPERPRE")
    //  frmListeFicPerso.mlIdPerso = adors("NPERNUM")
    //  frmListeFicPerso.mstrTypePerso = "PERSOSECU"
    //  frmListeFicPerso.Show vbModal
    //  
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDocPerso_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null || Utils.ZeroIfNull(currentRow["NPERNUM"]) == 0) return;

      frmListeFicPerso f = new frmListeFicPerso();
      f.msLibNomSoc = currentRow["VSOCIETE"].ToString();
      f.mstrNomPerso = currentRow["VPERNOM"].ToString();
      f.mstrPrenomPerso = currentRow["VPERPRE"].ToString();
      f.mlIdPerso = Convert.ToInt64(currentRow["NPERNUM"]);
      f.mstrTypePerso = "PERSO";
      f.ShowDialog();
    }
    //Private Sub CmdDocPerso_Click()
    //  If ZeroIfNull(adors("NPERNUM")) = 0 Then Exit Sub
    //  
    //  frmListeFicPerso.sLibNomSoc = adors("VSOCIETE")
    //  frmListeFicPerso.mstrNomPerso = adors("VPERNOM")
    //  frmListeFicPerso.mstrPrenomPerso = adors("VPERPRE")
    //  frmListeFicPerso.mlIdPerso = adors("NPERNUM")
    //  frmListeFicPerso.mstrTypePerso = "PERSO"
    //  frmListeFicPerso.Show vbModal
    //
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdPlanning_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (dt.Rows.Count == 0 || currentRow == null) return;

      frmPlanSimple f = new frmPlanSimple();
      f.mdSemaine = DateTime.Now;
      f.miNumTech = Convert.ToInt32(currentRow["npernum"]);
      f.miNumIP = 0;
      f.mstrStatutIP = "M";
      f.ShowDialog();
    }
    //Private Sub cmdPlanning_Click()
    //  
    //  If adors.RecordCount = 0 Then Exit Sub
    //  
    //  frmPlanSimple.mdSemaine = Date
    //  frmPlanSimple.miNumTech = adors!npernum
    //  frmPlanSimple.miNumIP = 0
    //  frmPlanSimple.mStrStatutIP = "M"
    //  frmPlanSimple.Show vbModal
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      try
      {
        apiGrid.AddColumn(Resources.col_Nom, "VPERNOM", 1300);
        apiGrid.AddColumn(Resources.col_Prenom, "VPERPRE", 1100);

        if (MozartParams.NomSocieteTemp == "GROUPE")
          apiGrid.AddColumn(Resources.col_Societe, "VSOCIETE", 1000);
        else
          apiGrid.AddColumn(Resources.col_Societe, "VSOCIETE", 0);

        apiGrid.AddColumn(Resources.col_Civ, "CPERCIV", 700);
        apiGrid.AddColumn(Resources.col_Type, "CPERTYP", 1200);
        apiGrid.AddColumn(Resources.col_Service, "VSERLIB", 1500);
        apiGrid.AddColumn(Resources.col_Dep, "VDEPLIB", 1500);
        apiGrid.AddColumn(Resources.col_Age, "Age", 500);
        apiGrid.AddColumn(Resources.col_Anc, "Anc", 500);
        apiGrid.AddColumn(Resources.col_D_entree, "DPERENT", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_D_entree_int, "DPERENTINT", 1500, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_Adresse1, "VPERAD1", 1800);
        apiGrid.AddColumn(Resources.col_Adresse2, "VPERAD2", 1100);
        apiGrid.AddColumn(Resources.col_CP, "VPERCP", 700);
        apiGrid.AddColumn(Resources.col_Ville, "VPERVIL", 1200);
        apiGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOMPOSTE", 1200);
        apiGrid.AddColumn(Resources.col_Site, "VSITNOMPOSTE", 1200);
        apiGrid.AddColumn(Resources.col_Telephone, "VPERTEL", 1400);
        apiGrid.AddColumn(Resources.col_Portable, "VPERPOR", 1400);
        apiGrid.AddColumn(Resources.col_Fax, "VPERFAX", 1400);
        apiGrid.AddColumn(Resources.col_Adresse_mail, "VPERMAI", 1800);
        apiGrid.AddColumn(Resources.col_D_naiss, "DPERNAI", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_D_sortie, "DPERSOR", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_Contrat, "VTYPECONTRATSAL", 600);
        apiGrid.AddColumn(Resources.col_College, "VPERCOL", 800);
        apiGrid.AddColumn(Resources.col_Niv, "VPERNIV", 500, "", 2);
        apiGrid.AddColumn(Resources.col_echel, "VPERECH", 500, "", 2);
        apiGrid.AddColumn(Resources.col_Cat, "VPERCAT", 500, "", 2);
        apiGrid.AddColumn(Resources.col_Coeff, "VPERCOE", 600);
        apiGrid.AddColumn(Resources.col_H_mois, "NPERHEU", 600);
        apiGrid.AddColumn(Resources.col_Salaire_brut, "NPERSAL", 1200, "Currency", 1);
        apiGrid.AddColumn(Resources.col_Cout_H, "NPERCOU", 800, "Currency", 1);
        apiGrid.AddColumn(Resources.col_Visite_medicale, "DPERVIS", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_Habilitation, "DPERHAB", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_D_avance, "DPERAVF", 1000, "dd/mm/yy");
        apiGrid.AddColumn(Resources.col_E_avance, "NPERMAV", 1100, "Currency", 1);
        apiGrid.AddColumn(Resources.col_Code_std, "NPERSTD", 700, "", 2);
        apiGrid.AddColumn(Resources.col_Permis, "VPERPERMI", 700, "", 2);
        apiGrid.AddColumn(Resources.col_NumPersonne, "NPERNUM", 0);
        apiGrid.AddColumn(Resources.col_Actif, "CPERACTIF", 0);

        apiGrid.InitColumnList();
        apiGrid.dgv.OptionsView.ColumnAutoWidth = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //  
    //  apiGrid.AddColumn "§Nom§", "VPERNOM", 1300           '0
    //  apiGrid.AddColumn "§Prenom§", "VPERPRE", 1100
    //  apiGrid.AddColumn "§Société§", "VSOCIETE", 1000           '0
    //  apiGrid.AddColumn "§Civ§", "CPERCIV", 700
    //  apiGrid.AddColumn "§Type§", "CPERTYP", 1200
    //  apiGrid.AddColumn "§Service§", "VSERLIB", 1500
    //  apiGrid.AddColumn "§Dep§", "VDEPLIB", 1500         '5
    //  apiGrid.AddColumn "§Age§", "AGE", 500            '0
    //  apiGrid.AddColumn "§Anc§", "ANC", 500
    //  apiGrid.AddColumn "§D entrée§", "DPERENT", 1000, "dd/mm/yy"
    //  apiGrid.AddColumn "§D entrée int.§", "DPERENTINT", 1500, "dd/mm/yy"
    //  apiGrid.AddColumn "§Adresse 1§", "VPERAD1", 1800
    //  apiGrid.AddColumn "§Adresse 2§", "VPERAD2", 1100
    //  apiGrid.AddColumn "§CP§", "VPERCP", 700
    //  apiGrid.AddColumn "§Ville§", "VPERVIL", 1200
    //  apiGrid.AddColumn "§Client§", "VCLINOMPOSTE", 1200
    //  apiGrid.AddColumn "§Site§", "VSITNOMPOSTE", 1200
    //  apiGrid.AddColumn "§Téléphone§", "VPERTEL", 1400      '10
    //  apiGrid.AddColumn "§Portable§", "VPERPOR", 1400
    //  apiGrid.AddColumn "§Fax§", "VPERFAX", 1400
    //  'ApiGrid.AddColumn "§Pwd internet§", "VPERPAS", 1300
    //  apiGrid.AddColumn "§Adresse e-mail§", "VPERMAI", 1800
    //  apiGrid.AddColumn "§D naiss§", "DPERNAI", 1000, "dd/mm/yy"    '15
    //  apiGrid.AddColumn "§D sortie§", "DPERSOR", 1000, "dd/mm/yy"
    //  apiGrid.AddColumn "§Contrat§", "CPERTCT2", 600
    //  apiGrid.AddColumn "§Collège§", "VPERCOL", 800
    //  apiGrid.AddColumn "§Niv§", "VPERNIV", 500, , 2       '20
    //  apiGrid.AddColumn "§Echel§", "VPERECH", 500, , 2
    //  apiGrid.AddColumn "§Cat§", "VPERCAT", 500, , 2
    //  apiGrid.AddColumn "§Coeff§", "VPERCOE", 600
    //  apiGrid.AddColumn "§H/mois§", "NPERHEU", 600
    //  apiGrid.AddColumn "§Salaire brut§", "NPERSAL", 1200, "Currency", 1   '25
    //  apiGrid.AddColumn "§Coût H§", "NPERCOU", 800, "Currency", 1
    //  apiGrid.AddColumn "§Visite médicale§", "DPERVIS", 1000, "dd/mm/yy"
    //  apiGrid.AddColumn "§Habilitation§", "DPERHAB", 1000, "dd/mm/yy"
    //  apiGrid.AddColumn "§D avan.§", "DPERAVF", 1000, "dd/mm/yy"
    //  apiGrid.AddColumn "§€ avance§", "NPERMAV", 1100, "Currency", 1  '30
    //  apiGrid.AddColumn "§Code std§", "NPERSTD", 700, , 2
    //  apiGrid.AddColumn "§Permis§", "VPERPERMI", 700, , 2
    //  apiGrid.AddColumn "§NumPersonne§", "NPERNUM", 0
    //  apiGrid.AddColumn "§Actif§", "CPERACTIF", 0
    //  
    //  If gstrNomSocieteTemp = "GROUPE" Then
    //    apiGrid.Columns.Item("§Société§").Visible = True
    //  Else
    //    apiGrid.Columns.Item("§Société§").Visible = False
    //  End If
    //  
    //  'ApiGrid.DesactiveListe
    //  apiGrid.Init adors
    //
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //


  }
}

