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
  public partial class frmRechercheST : Form
  {
    DataTable dt = new DataTable();
    //Dim rsSTF As ADODB.Recordset
    //Attribute rsSTF.VB_VarHelpID = -1

    public string msST = "";
    public string msContact = "";
    internal int miContact;
    internal int miSousTraitant;
    public string mstrTel = "";
    public string mstrPor = "";
    public string mstrTelAstr = "";
    public int miNumSiteSTGAR;
    public string mstrPays = "";
    //Public msST As String
    //Public msContact As String
    //Public miContact As Long
    //Public miSoustraitant As Long
    //Public mstrTel As String
    //Public mstrPor As String
    //Public mstrTelAstr As String
    //Public miNumSiteSTGAR As Long
    //Public mstrPays As String

    public string mstrStatut = "";
    public string mstrType = ""; //permet d'afficher la liste des sous traitant selon le type
    //Public mstrStatut As String
    //Public mstrType As String 'permet d'afficher la liste des sous traitant selon le type


    public frmRechercheST() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmRechercheST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //modification du titre
        if (mstrType == "INS")
          Label1.Text = Resources.txt_Selection_ST_Installation;
        else if (mstrType == "GAR")
          Label1.Text = Resources.txt_Selection_ST_Installateur_Garantie_Client;

        if (mstrPays == "")
          mstrPays = "FRANCE";

        cmdFind.Focus();

        InitPays();
        InitCategories();
        InitVillesCibles();

        InitGrid();
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
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  'modification du titre
    //  If mstrType = "INS" Then
    //    Label1.Caption = "§Sélection d'un sous-traitant installation§"
    //  ElseIf mstrType = "GAR" Then
    //    Label1.Caption = "§Sélection d'un sous-traitant installateur en garantie client§"
    //  End If
    //  
    //  ' ouverture du recordset avec la liste des ST
    //  Set rsSTF = New ADODB.Recordset
    //  
    //  If mstrPays = "" Then
    //    mstrPays = "FRANCE"
    //  End If
    //  
    //  InitPays
    //  InitCategories
    //  InitVillesCibles
    //  
    //  InitGrid
    //
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  On Error Resume Next
    //  Screen.MousePointer = vbDefault
    //  rsSTF.Close
    //  Set rsSTF = Nothing
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      miSousTraitant = 0; //passage d'aucun id
      miContact = 0;
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  miSoustraitant = 0    ' passage d'aucune id
    //  miContact = 0
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFind_Click(object sender, System.EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        string p_VSTFNOM = txtCritSTFNOM.Text == "" ? "T$" : txtCritSTFNOM.Text;
        string p_VINTNOM = txtCritINTNOM.Text == "" ? "T$" : txtCritINTNOM.Text;
        string p_VSTFDEPART = txtCritSTFDEP.Text == "" ? "T$" : txtCritSTFDEP.Text;
        string p_VSTFVILLES = cboVillesCibles.Text == "" ? "T$" : cboVillesCibles.Text;
        string p_VSTFPAYS = cboPays.Text == "" ? "T$" : cboPays.Text;
        string p_VSTFACTIV = txtCritSTFACTIV.Text == "" ? "T$" : txtCritSTFACTIV.Text;

        string p_NEWVSTFACTIV = "";

        if (cboCategories.Text != "")
        {
          //Une activité de sélectionnée
          if (cboPrestations.Text.ToUpper() == "TOUTES PRESTATIONS")
            p_NEWVSTFACTIV = cboCategories.Text;
          else
            p_NEWVSTFACTIV = cboPrestations.Text;
        }
        else
          p_NEWVSTFACTIV = "T$";

        string sSQL = $"EXEC api_sp_listeSTF_v3 '{mstrType}', '{p_VSTFNOM}', '{p_VINTNOM}', '{p_VSTFDEPART}', '{p_VSTFVILLES.Replace("'", "''")}', '{p_VSTFPAYS}', '{p_VSTFACTIV}', " +
                      $"'{p_NEWVSTFACTIV.Replace("'", "''")}', {miNumSiteSTGAR}";

        Grid.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        Grid.GridControl.DataSource = dt;

        cmdGerer.Enabled = true;

        if (miContact != 0)
        {
          DataRow[] rowT = dt.Select($"NINTNUM = {miContact}");
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      { Cursor = Cursors.Default; }
    }

    //Gestion de l'appui sur la touche F2
    private void cmdFind_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
      {
        cmdFind_Click(null, null);
      }
    }
    //Private Sub CmdFind_Click()
    //    
    //    Dim p_VSTFNOM As String
    //    Dim p_VINTNOM As String
    //    Dim p_VSTFDEPART As String
    //    Dim p_VSTFVILLES As String
    //    Dim p_VSTFPAYS As String
    //    Dim p_VSTFACTIV As String
    //    Dim p_NEWVSTFACTIV As String
    //        
    //On Error GoTo handler
    //    
    //    Screen.MousePointer = vbHourglass
    //       
    //    If rsSTF.State = adStateOpen Then rsSTF.Close
    //    
    //    Set rsSTF = New ADODB.Recordset
    //    
    //    p_VSTFNOM = IIf(txtCritSTFNOM.Text = "", "T$", txtCritSTFNOM.Text)
    //    p_VINTNOM = IIf(txtCritINTNOM.Text = "", "T$", txtCritINTNOM.Text)
    //    p_VSTFDEPART = IIf(txtCritSTFDEP.Text = "", "T$", txtCritSTFDEP.Text)
    //    p_VSTFVILLES = IIf(cboVillesCibles.Text = "", "T$", cboVillesCibles.Text)
    //    p_VSTFPAYS = IIf(cboPays.Text = "", "T$", cboPays.Text)
    //    p_VSTFACTIV = IIf(txtCritSTFACTIV.Text = "", "T$", txtCritSTFACTIV.Text)
    //    
    //    If cboCategories.Text <> "" Then
    //      ' Une activité de sélectionnée
    //      If UCase(cboPrestations.Text) = "TOUTES PRESTATIONS" Then
    //        p_NEWVSTFACTIV = cboCategories.Text
    //      Else
    //        p_NEWVSTFACTIV = cboPrestations.Text
    //      End If
    //    Else
    //      p_NEWVSTFACTIV = "T$"
    //    End If
    //    
    //    rsSTF.Open "EXEC api_sp_listeSTF_v3 '" & mstrType & "', '" & p_VSTFNOM & "', '" & p_VINTNOM & "', '" & p_VSTFDEPART & "', '" & Replace(p_VSTFVILLES, "'", "''") & "', '" & p_VSTFPAYS & "', '" & p_VSTFACTIV & "', '" & Replace(p_NEWVSTFACTIV, "'", "''") & "', " & miNumSiteSTGAR, cnx, adOpenStatic, adLockOptimistic
    //        
    //    'Mis en commentaire par MC le 27/03/12 car ce filtre n'est jamais fonctionner.
    //'    If mstrStatut = "PREV" Then
    //'      rsSTF.Filter = "CSTFPREV='O'"
    //'    End If
    //    
    //    Grid.Init rsSTF
    //    
    //    cmdGerer.Enabled = True
    //    
    //    If miContact <> 0 Then
    //      rsSTF.Find "NINTNUM = " & miContact
    //    End If
    //    
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  
    //handler:
    //  ShowError "cmdFind_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitPays()
    {
      cboPays.Items.Clear();
      int indexPays = 0;

      using (SqlDataReader sdr = ModuleData.ExecuteReader("SELECT DISTINCT PAYS FROM TVILLES ORDER BY PAYS"))
      {
        int i = 0;
        while (sdr.Read())
        {
          cboPays.Items.Add(sdr["PAYS"].ToString());
          if (sdr["PAYS"].ToString().ToUpper() == mstrPays) indexPays = i;
          i++;
        }
      }
      cboPays.SelectedIndex = indexPays;
    }
    //Private Sub InitPays()
    //  
    //  Dim adoRs As Recordset
    //  Set adoRs = New Recordset
    //  
    //  On Error GoTo handler
    //  
    //  cboPays.Clear
    //  cboPays.AddItem ""
    //  cboPays.ItemData(0) = "0"
    //  
    //  adoRs.Open "SELECT DISTINCT PAYS FROM TVILLES ORDER BY PAYS", cnx, adOpenStatic, adLockOptimistic
    //  If adoRs.EOF Then Exit Sub
    //
    //  Dim i As Integer
    //  Dim indexPays As Integer
    //  indexPays = 0
    //  i = 1
    //  While Not adoRs.EOF
    //    cboPays.AddItem adoRs!PAYS
    //    If UCase(adoRs!PAYS) = mstrPays Then indexPays = i
    //    'cboPays.ItemData(i) = adoRS!ID
    //    adoRs.MoveNext
    //    i = i + 1
    //  Wend
    //  adoRs.Close
    //  cboPays.ListIndex = indexPays
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitPays"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitCategories()
    {
      cboCategories.Items.Clear();
      cboCategories.Items.Add("");

      using (SqlDataReader sdrCat = ModuleData.ExecuteReader("SELECT DISTINCT VCATEGORIE FROM TACTIVITES ORDER BY VCATEGORIE"))
      {
        while (sdrCat.Read())
        {
          cboCategories.Items.Add(sdrCat["VCategorie"].ToString());
        }
      }
      cboCategories.SelectedIndex = 0;

      cboPrestations.Visible = false;
    }
    //Private Sub InitCategories()
    //
    //  Dim adoRSCat As Recordset
    //  Set adoRSCat = New Recordset
    //  
    //  On Error GoTo handler
    //  
    //  adoRSCat.Open "SELECT DISTINCT VCATEGORIE FROM TACTIVITES ORDER BY VCATEGORIE", cnx, adOpenStatic, adLockOptimistic
    //  If adoRSCat.EOF Then Exit Sub
    //  
    //  cboCategories.Clear
    //  cboCategories.AddItem ""
    //  'cboCategories.ItemData(0) = "0"
    //
    //  Dim i As Integer
    //  i = 1
    //  While Not adoRSCat.EOF
    //    cboCategories.AddItem adoRSCat!VCategorie
    //    'cboCategories.ItemData(i) = adoRSCat!VCATEGORIE
    //    adoRSCat.MoveNext
    //    i = i + 1
    //  Wend
    //  adoRSCat.Close
    //  cboCategories.ListIndex = 0
    //  
    //  cboPrestations.Visible = False
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitCategories"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cboCategories.SelectedIndex == 0)
        cboPrestations.Visible = false;
      else
      {
        InitPrestations();
        cboPrestations.Visible = true;
      }
    }
    //Private Sub cboCategories_Click()
    //  If cboCategories.Text <> "" Then
    //    cboPrestations.Visible = True
    //    InitPrestations
    //  Else
    //    cboPrestations.Visible = False
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitPrestations()
    {
      try
      {
        cboPrestations.Items.Add("Toutes prestations");

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT ID, VACTIVITE FROM TACTIVITES WHERE VCATEGORIE = '{cboCategories.Text}' ORDER BY VACTIVITE"))
        {
          while (sdr.Read())
          {
            cboPrestations.Items.Add(sdr["VACTIVITE"].ToString());
          }
        }
        cboPrestations.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitPrestations()
    //
    //  Dim adoRs As Recordset
    //  Set adoRs = New Recordset
    //  
    //  On Error GoTo handler
    //  
    //  adoRs.Open "SELECT ID, VACTIVITE FROM TACTIVITES WHERE VCATEGORIE = '" & cboCategories.Text & "' ORDER BY VACTIVITE", cnx, adOpenStatic, adLockOptimistic
    //  If adoRs.EOF Then Exit Sub
    //  
    //  cboPrestations.Clear
    //  cboPrestations.AddItem "Toutes prestations"
    //  cboPrestations.ItemData(0) = "0"
    //
    //  Dim i As Integer
    //  i = 1
    //  While Not adoRs.EOF
    //    cboPrestations.AddItem adoRs!VActivite
    //    cboPrestations.ItemData(i) = adoRs!ID
    //    adoRs.MoveNext
    //    i = i + 1
    //  Wend
    //  adoRs.Close
    //  cboPrestations.ListIndex = 0
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitPrestations"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitVillesCibles()
    {
      try
      {
        ModuleData.RemplirCombo(cboVillesCibles, $"SELECT ID, VILLE FROM TVILLES WHERE PAYS = '{cboPays.Text}' ORDER BY VILLE");
        cboVillesCibles.ValueMember = "ID";
        cboVillesCibles.DisplayMember = "VILLE";

        cboVillesCibles.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitVillesCibles()
    //  
    //  Dim adoRs As Recordset
    //  Set adoRs = New Recordset
    //  
    //  On Error GoTo handler
    //  
    //  cboVillesCibles.Clear
    //  cboVillesCibles.AddItem ""
    //  cboVillesCibles.ItemData(0) = "0"
    //  
    //  adoRs.Open "SELECT ID, VILLE FROM TVILLES WHERE PAYS = '" & cboPays.Text & "' ORDER BY VILLE", cnx, adOpenStatic, adLockOptimistic
    //  If adoRs.EOF Then Exit Sub
    //  
    //
    //  Dim i As Integer
    //  i = 1
    //  While Not adoRs.EOF
    //    cboVillesCibles.AddItem adoRs!ville
    //    cboVillesCibles.ItemData(i) = adoRs!ID
    //    adoRs.MoveNext
    //    i = i + 1
    //  Wend
    //  adoRs.Close
    //  cboVillesCibles.ListIndex = 0
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitVillesCibles"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSelectionner_Click(object sender, EventArgs e)
    {
      try
      {
        string infoSTF;

        DataRow row = Grid.GetFocusedDataRow();
        if (row == null) return;

        //information sur le st interdit ou pas
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT CNOTINTERDIT, VNOTMESS FROM TNOTES WHERE VNOTTYPE='INFO_STF' AND NNOTCLE = '{row["NSTFGRPNUM"]}'"))
        {
          if (sdr.Read())
          {
            if ((string)sdr[0] == "O")
            {
              MessageBox.Show($"{Resources.msg_ST_Interdit}\r\n{sdr["VNOTMESS"]}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
            else
            {
              //ouverture d'une fenetre d'information
              //FG le 30/11/11  on utilise vnotmess a la place de vstfobs
              infoSTF = Utils.BlankIfNull(sdr["VNOTMESS"]);

              if (infoSTF != "")
              {
                new frmInfosClient
                {
                  msStatut = "O", // sous-traitant
                  msInfo = infoSTF,
                }.ShowDialog();
              }
            }
          }

          if (Utils.BlankIfNull(row["VINTMAIL"]) == "" && mstrType == "GAR")
          {
            MessageBox.Show(Resources.msg_Mail_Obligatoire_Pour_ST_Garantie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //test taux de dependance, si taux de dependance => 30 % alors message + exit
          if (ModuleMain.IsOKTauxDependanceSTF(Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["NSTFNUM"]), 3)), MozartParams.NumAction, MozartParams.UID, MozartParams.NomSociete) == false)
            return;

          //test so doc adm coché avec kbis + rc manquant
          if (IsDocAdmSTFValid((int)row["NSTFGRPNUM"]) == false)
            return;

          if (Utils.BlankIfNull(row["NINTNUM"]) == "")
          {
            MessageBox.Show(Resources.msg_Obligation_Contact_ST, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
          else
          {
            msST = Utils.BlankIfNull(row["VSTFNOM"]);
            msContact = Utils.BlankIfNull(row["VINTNOM"]);

            //passage de l'id du soustraitant sélectionné
            miSousTraitant = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["NSTFNUM"]), 3));
            miContact = (int)row["NINTNUM"];
            mstrTel = Utils.BlankIfNull(row["VINTTEL"]);
            mstrPor = Utils.BlankIfNull(row["VINTPOR"]);
            mstrTelAstr = Utils.BlankIfNull(row["VSTFTEL"]);

            Close();
          }

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSelectionner_Click()
    //Dim infoSTF As String
    //Dim lRs As ADODB.Recordset
    //     
    //On Error GoTo handler
    //  
    //  If rsSTF.State = adStateClosed Then Exit Sub
    //  
    //  If rsSTF.EOF Then Exit Sub
    //  
    //  ' information sur le st interdit ou pas
    //  Set lRs = New ADODB.Recordset
    //  lRs.Open "SELECT CNOTINTERDIT, VNOTMESS FROM TNOTES WHERE VNOTTYPE='INFO_STF' AND NNOTCLE = " & rsSTF("NSTFGRPNUM"), cnx
    //  If lRs.EOF Then
    //    'rien
    //  Else
    //    If lRs(0) = "O" Then
    //      MsgBox "§Sous traitant interdit : §" & vbCrLf & lRs!VNOTMESS, vbInformation
    //      Exit Sub
    //    End If
    //    ' ouverture d'une fenetre d'information
    //    ' FG le 30/11/11  on utilise vnotmess a la place de vstfobs
    //    ' infoSTF = RechercheObsSTF(Mid(rsSTF("NSTFNUM").Value, 3))
    //    infoSTF = BlankIfNull(lRs!VNOTMESS)
    //  End If
    //  
    //  Dim frmObs As New frmInfosClient
    //  If infoSTF <> "" Then
    //    frmObs.strStatut = "O"  ' sous-traitant
    //    frmObs.strInfo = infoSTF
    //    frmObs.Show vbModal
    //  End If
    //  
    //  If BlankIfNull(rsSTF("VINTMAIL")) = "" And mstrType = "GAR" Then
    //    MsgBox "§Pour un sous-traitant en garantie, il faut obligatoirement une adresse mail sur ce contact !§", vbExclamation
    //    Exit Sub
    //  End If
    //  
    //  'test taux de dependance, si taux de dependance => 30 % alors message + exit
    //  If IsOKTauxDependanceSTF(Mid(rsSTF("NSTFNUM").value, 3), glNumAction, gintUID, gstrNomSociete) = False Then Exit Sub
    //  
    //  'test si doc adm coché avec kbis + rc manquant
    //  If IsDocAdmSTFValid(rsSTF("NSTFGRPNUM").value) = False Then
    //    Exit Sub
    //  End If
    //  
    //  
    //  
    //  
    //  If IsNull(rsSTF("NINTNUM")) Then
    //    MsgBox "§Il faut mettre un contact sur ce sous traitant§", vbInformation
    //    Exit Sub
    //  Else
    //    msST = rsSTF("VSTFNOM")
    //    msContact = rsSTF("VINTNOM")
    //
    //    ' passage de l'id du soustraitant sélectionné
    //    miSoustraitant = Mid(rsSTF("NSTFNUM").value, 3)
    //    miContact = rsSTF("NINTNUM").value
    //    mstrTel = BlankIfNull(rsSTF("VINTTEL").value)
    //    mstrPor = BlankIfNull(rsSTF("VINTPOR").value)
    //    mstrTelAstr = BlankIfNull(rsSTF("VSTFTEL").value)
    //  End If
    //  
    //  Unload Me
    //  Exit Sub
    //  
    //handler:
    //  ShowError "cmdSelectionner_Click dans " & Me.Name
    //End Sub
    //  
    /* --------------------------------------------------------------------------------------- */
    private void InitGrid()
    {

      Grid.AddColumn("Num.", "NSTFNUM", 0);
      //gestion colonne si stf garantie
      if (mstrType == "GAR")
      {
        Grid.AddColumn(Resources.col_Lot_Technique, "VLOTNOM", 1400);
        Grid.AddColumn(Resources.col_Date_Reception, "DDATRECEPT", 1400);
        Grid.AddColumn(Resources.col_Date_Fin_Garantie, "DDATFINGARANT", 1400);
      }
      Grid.AddColumn(Resources.col_Societe, "VSTFNOM", 1600);
      Grid.AddColumn(Resources.col_Contact, "VINTNOM", 1400);
      Grid.AddColumn(Resources.col_Telephone, "VINTTEL", 1200);
      Grid.AddColumn(Resources.col_Fax, "VINTFAX", 1200);
      Grid.AddColumn(Resources.col_Portable, "VINTPOR", 1200);
      Grid.AddColumn(Resources.col_astreinte, "VSTFTEL", 1100);
      Grid.AddColumn("MO", "NSTFMOE", 400, "", 2);
      Grid.AddColumn("Dep", "NSTFDEP", 400, "", 2);
      Grid.AddColumn("Ast", "NSTFASTR", 400, "", 2);
      Grid.AddColumn("NCT", "NCT", 400);
      Grid.AddColumn("Notation", "NSTFGRPNOTE", 900, "", 2);
      Grid.AddColumn("Dépendance %", "TAUX", 900, "", 2);
      Grid.AddColumn(Resources.col_CP, "VSTFCP", 550);
      //Grid.AddColumn(Resources.col_Anc_Villes_Cibles, "VSTFVIC", 1400);
      Grid.AddColumn("Villes cibles", "VListeVillesRecherche", 1400);
      Grid.AddColumn(Resources.col_Pays, "VSTFPAYS", 1000);
      //Grid.AddColumn(Resources.col_Anciennes_Activites, "VSTFAC1", 1800);
      Grid.AddColumn("Activités", "VListeActivitesRecherche", 1800);
      Grid.AddColumn(Resources.col_Observations, "VSTFOBS", 2000);
      Grid.AddColumn("Type STT", "VstfEtrType", 250);
      Grid.AddColumn("F", "F", 0);
      Grid.AddColumn(Resources.col_interdit, "INTERDIT", 0);
      Grid.AddColumn("PRIVILEGE", "CSTFGRPP3M", 0);
      Grid.AddColumn("BSTFGRPDOCADM", "BSTFGRPDOCADM", 0);
      //Grid.AddColumn("EQUIPETABLET", "EQUIPETABLET", 0); NL le 19/09/2016, commenté car prend trop de ressource
      //gestion colonne si stf garantie
      if (mstrType == "GAR")
        Grid.AddColumn("CCODCOULGARANT", "CCODCOULGARANT", 0);

      Grid.InitColumnList();
    }

    private void Grid_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["INTERDIT"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH8080FF;
          e.HighPriority = true;
        }

        if (View.GetDataRow(e.RowHandle)["CSTFGRPP3M"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorHDDFFBB;
          e.HighPriority = true;
        }
        if (View.GetDataRow(e.RowHandle)["BSTFGRPDOCADM"].ToString().ToUpper() == "O")
        {
          e.Appearance.BackColor = MozartColors.ColorH80FFFF;
          e.HighPriority = true;
        }

        //Gestion couleur si date garantie dépassé
        if (mstrType == "GAR")
        {
          if (View.GetDataRow(e.RowHandle)["CCODCOULGARANT"].ToString().ToUpper() == "R")
          {
            e.Appearance.BackColor = System.Drawing.Color.Red;
            e.HighPriority = true;
          }
        }
      }
    }
    //Public Sub InitGrid()
    //  
    //On Error GoTo handler
    //
    //  Grid.AddColumn "Num.", "NSTFNUM", 0
    //  'gestion colonne si stf garantie
    //  If mstrType = "GAR" Then
    //    Grid.AddColumn "§Lot Technique§", "VLOTNOM", 1400
    //    Grid.AddColumn "§Date réception§", "DDATRECEPT", 1400
    //    Grid.AddColumn "§Date fin garantie§", "DDATFINGARANT", 1400
    //  End If
    //  Grid.AddColumn "§Société§", "VSTFNOM", 1400
    //  Grid.AddColumn "§Contact§", "VINTNOM", 1400
    //  Grid.AddColumn "§Téléphone§", "VINTTEL", 1400
    //  Grid.AddColumn "§Fax§", "VINTFAX", 1400
    //  Grid.AddColumn "§Portable§", "VINTPOR", 1400
    //  Grid.AddColumn "§Astreinte§", "VSTFTEL", 1000
    //  Grid.AddColumn "MO", "NSTFMOE", 600, , 2
    //  Grid.AddColumn "Dep", "NSTFDEP", 600, , 2
    //  Grid.AddColumn "Ast", "NSTFASTR", 600, , 2
    //  Grid.AddColumn "NCT", "NCT", 500
    //  Grid.AddColumn "Notation", "NSTFGRPNOTE", 900, , 2
    //  Grid.AddColumn "Dépendance %", "TAUX", 900, , 2
    //  Grid.AddColumn "§CP§", "VSTFCP", 550
    //  'grid.AddColumn "§Anc Villes cibles§", "VSTFVIC", 1400
    //  Grid.AddColumn "Villes cibles", "VListeVillesRecherche", 1400
    //  Grid.AddColumn "§Pays§", "VSTFPAYS", 1000
    //  'grid.AddColumn "§Anciennes activités§", "VSTFAC1", 1800
    //  Grid.AddColumn "Activités", "VListeActivitesRecherche", 1800
    //  Grid.AddColumn "§Observations§", "VSTFOBS", 2000
    //  Grid.AddColumn "Type STT", "VstfEtrType", 250
    //  Grid.AddColumn "F", "F", 0
    //  Grid.AddColumn "§INTERDIT§", "INTERDIT", 0
    //  Grid.AddColumn "PRIVILEGE", "CSTFGRPP3M", 0
    //  Grid.AddColumn "BSTFGRPDOCADM", "BSTFGRPDOCADM", 0
    //  'Grid.AddColumn "EQUIPETABLET", "EQUIPETABLET", 0 ' NL le 19/09/2016, commenté car prend trop de ressource
    //  'gestion colonne si stf garantie
    //  If mstrType = "GAR" Then
    //    Grid.AddColumn "CCODCOULGARANT", "CCODCOULGARANT", 0
    //  End If
    //  
    //  Grid.AddCellTip "VSTFNOM", &HFDF0DA
    //  Grid.AddCellTip "VListeActivitesRecherche", &HFDF0DA
    //  Grid.AddCellTip "VListeVillesRecherche", &HFDF0DA
    //  'grid.AddCellTip "VSTFAC1", &HFDF0DA
    //  Grid.AddCellTip "VSTFOBS", &HFDF0DA
    //  
    //  Grid.AddRowStyle "Interdit", "INTERDIT", "O", , &H8080FF
    //  Grid.AddRowStyle "CSTFGRPP3M", "CSTFGRPP3M", "O", , &HDDFFBB
    //  Grid.AddRowStyle "BSTFGRPDOCADM", "BSTFGRPDOCADM", "O", , &H80FFFF
    //  
    //  ' Grid.AddRowStyle "EQUIPETABLET", "EQUIPETABLET", "O", , vbGreen  ' NL le 19/09/2016, commenté
    //  
    //  'gestion couleur si date garantie dépassé
    //  If mstrType = "GAR" Then
    //    Grid.AddRowStyle "GestGarant", "CCODCOULGARANT", "R", , vbRed
    //  End If
    //  
    //  Grid.Init rsSTF
    //  Exit Sub
    //  
    //handler:
    //  ShowError "InitGrid dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Grid_DblClick(object sender, EventArgs e)
    {
      cmdSelectionner_Click(null, null);
    }
    //Private Sub Grid_DblClick()
    //  Call cmdSelectionner_Click
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboPays_SelectedValueChanged(object sender, EventArgs e)
    {
      InitVillesCibles();
    }
    //Private Sub cboPays_Validate(Cancel As Boolean)
    //InitVillesCibles
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdGerer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = Grid.GetFocusedDataRow();
        if (row == null) return;

        string txtInter = Strings.Mid(Utils.BlankIfNull(row["NSTFNUM"]), 3);

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT F.NSTFGRPNUM, VSTFGRPNOM from TSTF F INNER JOIN TSTFGRP G ON F.NSTFGRPNUM=G.NSTFGRPNUM WHERE NSTFNUM = {txtInter}"))
        {
          if (sdr.Read())
          {
            frmGestFournisseurs f = new frmGestFournisseurs();

            f.miNumSTF = (int)Utils.ZeroIfBlank(sdr["NSTFGRPNUM"]);
            f.mstrNomSTF = Utils.BlankIfNull(sdr["VSTFGRPNOM"]);
            f.cmdAjouterSTF.Enabled = false;
            f.cmdModifierSTF.Enabled = false;
            f.cmdFourniture.Enabled = false;
            f.CmdWeb.Enabled = false;
            f.cmdCarteSTT.Enabled = false;
            f.cmdArchive.Enabled = false;
            f.Command1.Enabled = false;
            f.cmdCarteSTTPartenaires.Enabled = false;
            f.ShowDialog();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdGerer_Click()
    //    
    //    Dim pRST As ADODB.Recordset
    //    
    //    On Error GoTo handler
    //    
    //    Dim txtInter As String
    //    txtInter = Mid(rsSTF("NSTFNUM").value, 3)
    //    
    //     If txtInter = "" Then Exit Sub
    //     
    //     Set pRST = New ADODB.Recordset
    //     pRST.Open "SELECT F.NSTFGRPNUM, VSTFGRPNOM from TSTF F INNER JOIN TSTFGRP G ON F.NSTFGRPNUM=G.NSTFGRPNUM WHERE NSTFNUM = " & txtInter, cnx
    //     If pRST.EOF Then Exit Sub
    //       
    //     Dim oGestFoDetail As New frmGestFournisseurs
    //     
    //     oGestFoDetail.miNumSTF = pRST("NSTFGRPNUM")
    //     oGestFoDetail.mstrNomSTF = pRST("VSTFGRPNOM")
    //     oGestFoDetail.cmdAjouterSTF.Enabled = False
    //     oGestFoDetail.cmdModifierSTF.Enabled = False
    //     oGestFoDetail.cmdFourniture.Enabled = False
    //     oGestFoDetail.CmdWeb.Enabled = False
    //     oGestFoDetail.cmdCarteSTT.Enabled = False
    //     oGestFoDetail.cmdArchive.Enabled = False
    //     oGestFoDetail.Command1.Enabled = False
    //     oGestFoDetail.cmdCarteSTTPartenaires.Enabled = False
    //     oGestFoDetail.Show vbModal
    //        
    //     Set oGestFoDetail = Nothing
    //    
    //     pRST.Close
    //
    //Exit Sub
    //Resume
    //handler:
    //  MsgBox "Pas de STT sélectionné..."
    //End Sub
    /* --------------------------------------------------------------------------------------- */
    public bool IsDocAdmSTFValid(int p_NSTFGRPNUM)
    {
      //si filiale exit sans test
      if (p_NSTFGRPNUM == 35576 || p_NSTFGRPNUM == 36375 || p_NSTFGRPNUM == 39392)
        return true;

      //recherche du taux de dep
      using (SqlDataReader sdr = ModuleData.ExecuteReader($"exec [api_sp_TestDocAdmSTFValid] {p_NSTFGRPNUM}"))
      {
        if (sdr.Read())
        {
          if ((int)sdr["DOC_OK"] == 0)
          {
            string msg = "Vous ne pouvez pas sélectionner ce prestataire car malgré les nombreuses relances, ses documents Kbis et assurances RC ne sont pas reçus ou non à jour.\r\n" +
              "Merci d'obtenir ces documents auprès du sst.\r\nLes transférer au service achats pour saisie dans Mozaris.\r\n" +
              "Après cette saisie, vous pourrez demander à votre chef de groupe ou au service achats d'autoriser les contrats vers ce prestataire.";

            MessageBox.Show(msg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
        }
        return true;
      }
    }
    //  '********************************************************************************************************
    //
    //' Cette fonction est utilisée pour verifier si le st est coché en adm kbis + rc et qu'il ny a pas de document
    //
    //' si le taux est supérieur à 30 % alors on envoi un mail
    //
    //' exclure les filiales pour ne pas avoir des messages identiques , récurrents et inutiles
    //
    //'********************************************************************************************************'
    //
    //Public Function IsDocAdmSTFValid(ByVal p_NSTFGRPNUM As Long) As Boolean
    //
    //
    //    Dim adoVerif As New ADODB.Recordset
    //
    //   
    //
    //    'Init
    //
    //    IsDocAdmSTFValid = True
    //
    //   
    //
    //    ' si filiale exit sans test
    //
    //    If(p_NSTFGRPNUM = 35576 Or p_NSTFGRPNUM = 36375 Or p_NSTFGRPNUM = 39392) Then Exit Function
    //
    //
    //
    //    ' recherche du taux de dep
    //
    //    adoVerif.Open "exec [api_sp_TestDocAdmSTFValid] " & p_NSTFGRPNUM, cnx, adOpenStatic, adLockReadOnly
    //
    //
    //
    //    While adoVerif.EOF = False
    //
    //
    //
    //        If adoVerif("DOC_OK") = 0 Then
    //
    //            MsgBox("Vous ne pouvez pas sélectionner ce prestataire car malgré les nombreuses relances, ses documents Kbis et assurances RC ne sont pas reçus ou non à jour." & vbCrLf & _
    //
    //                    "Merci d'obtenir ces documents auprès du sst." & vbCrLf & _
    //
    //                    "Les transférer au service achats pour saisie dans Mozaris." & vbCrLf & _
    //
    //                    "Après cette saisie, vous pourrez demander à votre chef de groupe ou au service ahcats d'autoriser les contrats vers ce prestataire.")
    //
    //
    //
    //
    //             IsDocAdmSTFValid = False
    //
    //
    //
    //        End If
    //
    //
    //
    //        adoVerif.MoveNext
    //
    //
    //
    //
    //    Wend
    //
    //
    //
    //    adoVerif.Close
    //
    //
    //
    //End Function
  }
}

