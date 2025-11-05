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
  public partial class frmGestSitesGaranties : Form
  {
    public string sNomSite;
    public int iNumSite;
    //Public sNomSite As String
    //Public iNumSite As Long

    DataTable dtLot = new DataTable();
    DataTable dtInstall = new DataTable();
    //Dim ado_rs_Lot As ADODB.Recordset
    //Dim ado_rs_STFInstall As ADODB.Recordset

    int iNumLot;
    //Dim iNumLot As Integer
    //Dim iIndexEnCours As Integer

    public frmGestSitesGaranties() { InitializeComponent(); }

    private void frmGestSitesGaranties_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGridLot.LoadData(dtLot, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeSitLotGarantie {iNumSite}");
        apiTGridLot.GridControl.DataSource = dtLot;

        lblSite.Text = sNomSite;

        InitApiTgrid();
        InitApiTgridSTFInstall();
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
    //    InitBoutons Me, frmMenu
    //    
    //    Set ado_rs_Lot = New ADODB.Recordset
    //    ado_rs_Lot.Open "EXEC api_sp_ListeSitLotGarantie " & iNumSite, cnx, adOpenStatic, adLockReadOnly
    //    
    //    Set ado_rs_STFInstall = New ADODB.Recordset
    //    
    //    lblSite.Caption = sNomSite
    //
    //    InitApiTgrid
    //    InitApiTgridSTFInstall
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void BtnCancel_Click(object sender, EventArgs e)
    {
      //Init les champs
      txtNomLot.Text = "";
      txtDateRecept.Text = "";
      txtDateFinGarant.Text = "";
      FrameLot.Visible = false;
    }
    //Private Sub BtnCancel_Click()
    //    'Init les champs
    //    txtNomLot.Text = ""
    //    txtDateRecept.Text = ""
    //    txtDateFinGarant.Text = ""
    //    FrameLot.Visible = False
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Cal.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "CmdDate0")
      {
        txtDate = txtDateRecept.Text;
        Cal.Tag = 0;
      }
      else
      {
        txtDate = txtDateFinGarant.Text;
        Cal.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }

      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Cal.Tag == 0) txtDateRecept.Text = Cal.Value.ToShortDateString();
      else if ((int)Cal.Tag == 1) txtDateFinGarant.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    //Private Sub Cal_Click()
    //    
    //    Select Case iIndexEnCours
    //    
    //        Case 0
    //            txtDateRecept.Text = Cal.value
    //        Case 1
    //            txtDateFinGarant.Text = Cal.value
    //    End Select
    //    
    //    Cal.Visible = False
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdClose_Click(object sender, EventArgs e)
    {
      //Init les champs
      txtNomLot.Text = "";
      txtDateRecept.Text = "";
      txtDateFinGarant.Text = "";
      FrameLot.Visible = false;
    }
    //Private Sub CmdClose_Click()
    //    'Init les champs
    //    txtNomLot.Text = ""
    //    txtDateRecept.Text = ""
    //    txtDateFinGarant.Text = ""
    //    FrameLot.Visible = False
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub CmdDate_Click(Index As Integer)
    //
    //    Select Case iIndexEnCours
    //    
    //        Case 0
    //            If txtDateRecept.Text <> "" Then
    //                Cal.value = txtDateRecept.Text
    //            Else
    //                Cal.value = Date
    //            End If
    //        Case 1
    //            If txtDateRecept.Text <> "" Then
    //                Cal.value = txtDateRecept.Text
    //            Else
    //                Cal.value = Date
    //            End If
    //    End Select
    //
    //    Cal.Visible = True
    //    iIndexEnCours = Index
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdEnregLot_Click(object sender, EventArgs e)
    {
      //test si champs saisie
      if (txtNomLot.Text == "")
      {
        MessageBox.Show(Resources.msg_Nom_Lot_Obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      EnregistrerLot(iNumLot, txtNomLot.Text, txtDateRecept.Text, txtDateFinGarant.Text);

      apiTGridLot.Requery(dtLot, MozartDatabase.cnxMozart);
      FrameLot.Visible = false;
    }
    //Private Sub CmdEnregLot_Click()
    //    
    //    'test si champs saisie
    //    If txtNomLot.Text = "" Then
    //        MsgBox "§Il faut obligatoirement un nom de lot§", vbExclamation
    //        Exit Sub
    //    End If
    //    
    //    EnregistrerLot iNumLot, txtNomLot.Text, txtDateRecept.Text, txtDateFinGarant.Text
    //       
    //    ado_rs_Lot.Requery
    //    apiTGridLot.MajLabel
    //    
    //    FrameLot.Visible = False
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdSuppDate0_Click(object sender, EventArgs e)
    {
      txtDateRecept.Text = "";
    }

    private void CmdSuppDate1_Click(object sender, EventArgs e)
    {
      txtDateFinGarant.Text = "";
    }
    //Private Sub CmdSuppDate_Click(Index As Integer)
    //    Select Case Index
    //    
    //        Case 0:
    //            txtDateRecept.Text = ""
    //        Case 1:
    //            txtDateFinGarant.Text = ""
    //            
    //    End Select
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdAjoutSTFInstall_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridLot.GetFocusedDataRow();
      if (row == null) return;

      frmRechercheST f = new frmRechercheST();

      f.mstrType = "GAR";
      f.mstrStatut = "SDR";
      f.ShowDialog();

      int miSousTraitant = f.miSousTraitant;
      int miContact = f.miContact;

      if (miSousTraitant != 0)
      {
        EnregistrerSTFInstall(0, (int)row["NSITGARLOTNUM"], miSousTraitant, miContact);
        ApiTgridSTFInstall.Requery(dtInstall, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub CmdAjoutSTFInstall_Click()
    //        
    //    If ado_rs_Lot.RecordCount = 0 Then Exit Sub
    //    
    //    frmRechercheST.mstrType = "GAR"
    //    frmRechercheST.mstrStatut = "SDR"
    //    frmRechercheST.Show vbModal
    //    
    //    miSoustraitant = frmRechercheST.miSoustraitant
    //    miContact = frmRechercheST.miContact
    //    
    //    If miSoustraitant <> 0 Then
    //    
    //        EnregistrerSTFInstall 0, ado_rs_Lot("NSITGARLOTNUM"), miSoustraitant, miContact
    //    
    //        ado_rs_STFInstall.Requery
    //    
    //    End If
    //        
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void EnregistrerSTFInstall(int P_NLOTSTFNUM, int P_NSITGARLOTNUM, int P_NSTFNUM, int P_NINTNUM)
    {
      //passage du nom de la procédure stockée
      using (SqlCommand cmd = new SqlCommand("api_sp_CreationLotSTFGarant", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        //liste des paramètres
        cmd.Parameters["@P_NLOTSTFNUM"].Value = P_NLOTSTFNUM; //0 si création
        cmd.Parameters["@P_NSITGARLOTNUM"].Value = P_NSITGARLOTNUM;
        cmd.Parameters["@p_NSTFNUM"].Value = P_NSTFNUM;
        cmd.Parameters["@p_NINTNUM"].Value = P_NINTNUM;

        //exécuter la commande
        cmd.ExecuteNonQuery();
      }
    }
    //Private Sub EnregistrerSTFInstall(ByVal P_NLOTSTFNUM As Integer, ByVal P_NSITGARLOTNUM As Integer, ByVal P_NSTFNUM As Long, ByVal P_NINTNUM As Long)
    //
    //    Dim cmd As New ADODB.Command
    //
    //    Set cmd.ActiveConnection = cnx
    //    
    //    ' passage du nom de la procédure stockée
    //    cmd.CommandText = "api_sp_CreationLotSTFGarant"
    //    cmd.CommandType = adCmdStoredProc
    //        
    //    'liste des paramètres
    //    cmd.Parameters("@P_NLOTSTFNUM").value = P_NLOTSTFNUM    ' 0 si création
    //    cmd.Parameters("@P_NSITGARLOTNUM").value = P_NSITGARLOTNUM
    //    cmd.Parameters("@p_NSTFNUM").value = P_NSTFNUM
    //    cmd.Parameters("@p_NINTNUM").value = P_NINTNUM
    //
    //    'exécuter la commande.
    //    cmd.Execute
    //        
    //    ' libération de la commande
    //    Set cmd = Nothing
    //
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdModSTFInstall_Click(object sender, EventArgs e)
    {
      DataRow rowInstall = ApiTgridSTFInstall.GetFocusedDataRow();
      DataRow rowLot = apiTGridLot.GetFocusedDataRow();
      if (rowInstall == null && rowLot == null) return;

      frmRechercheST f = new frmRechercheST();

      f.mstrType = "GAR";
      f.mstrStatut = "SDR";
      f.ShowDialog();

      int miSousTraitant = f.miSousTraitant;
      int miContact = f.miContact;

      if (miSousTraitant != 0)
      {
        EnregistrerSTFInstall((int)rowInstall["NLOTSTFNUM"], (int)rowInstall["NSITGARLOTNUM"], miSousTraitant, miContact);

        ApiTgridSTFInstall.Requery(dtInstall, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub CmdModSTFInstall_Click()
    //
    //    If ado_rs_Lot.RecordCount = 0 Then Exit Sub
    //    
    //    If ado_rs_STFInstall.RecordCount = 0 Then Exit Sub
    //    
    //    frmRechercheST.mstrType = "GAR"
    //    frmRechercheST.mstrStatut = "SDR"
    //    frmRechercheST.Show vbModal
    //    
    //    miSoustraitant = frmRechercheST.miSoustraitant
    //    miContact = frmRechercheST.miContact
    //    
    //    If miSoustraitant <> 0 Then
    //    
    //        EnregistrerSTFInstall ado_rs_STFInstall("NLOTSTFNUM"), ado_rs_STFInstall("NSITGARLOTNUM"), miSoustraitant, miContact
    //    
    //        ado_rs_STFInstall.Requery
    //    
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdSuppSTFInstall_Click(object sender, EventArgs e)
    {
      //Ouverture en modification
      DataRow row = ApiTgridSTFInstall.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_Suppr_Sous_Traitant, Resources.msg_Confirm_Suppr_Sous_Traitant_Titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.CnxExecute($"DELETE FROM TLOTSTFGAR WHERE TLOTSTFGAR.NLOTSTFNUM = {row["NLOTSTFNUM"]}");
        ApiTgridSTFInstall.Requery(dtInstall, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub CmdSuppSTFInstall_Click()
    //    
    //    
    //    If ado_rs_STFInstall.state = adStateClosed Then Exit Sub
    //    
    //    'ouverture en modification
    //    If ado_rs_STFInstall.RecordCount > 0 Then
    //    
    //        If MsgBox("§Voulez-vous vraiment supprimer ce sous-traitant ?§", vbYesNoCancel + vbQuestion, "§Confirmation suppression sous traitant du lot§") = vbYes Then
    //            
    //            cnx.Execute ("DELETE FROM TLOTSTFGAR WHERE TLOTSTFGAR.NLOTSTFNUM = " & ado_rs_STFInstall("NLOTSTFNUM"))
    //            ado_rs_STFInstall.Requery
    //        
    //        End If
    //    
    //    End If
    //
    //End Sub
    //
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      apiTGridLot.AddColumn("NSITGARLOTNUM", "NSITGARLOTNUM", 0);
      apiTGridLot.AddColumn(Resources.col_Lot_Technique, "VLOTNOM", 3500);
      apiTGridLot.AddColumn(Resources.col_Date_Reception, "DDATRECEPT", 3500);
      apiTGridLot.AddColumn(Resources.col_Date_Fin_Garantie, "DDATFINGARANT", 3500);

      apiTGridLot.InitColumnList();
    }
    //Private Sub InitApiTgrid()
    //    
    //    apiTGridLot.AddColumn "NSITGARLOTNUM", "NSITGARLOTNUM", 0
    //    apiTGridLot.AddColumn "§Lot Technique§", "VLOTNOM", 3500
    //    apiTGridLot.AddColumn "§Date réception§", "DDATRECEPT", 3500
    //    apiTGridLot.AddColumn "§Date fin garantie§", "DDATFINGARANT", 3500
    //        
    //    apiTGridLot.Init ado_rs_Lot
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApiTgridSTFInstall()
    {
      ApiTgridSTFInstall.AddColumn("NLOTSTFNUM", "NLOTSTFNUM", 0);
      ApiTgridSTFInstall.AddColumn(Resources.col_SousTraitant, "VSTFGRPNOM", 3200);
      ApiTgridSTFInstall.AddColumn(Resources.col_Site, "VSTFNOM", 2300);
      ApiTgridSTFInstall.AddColumn(Resources.col_Contact, "VINTNOM", 1800);
      ApiTgridSTFInstall.AddColumn(Resources.col_Tel, "VINTTEL", 1500);
      ApiTgridSTFInstall.AddColumn(Resources.col_Fax, "VINTFAX", 1500);
      ApiTgridSTFInstall.AddColumn(Resources.col_Port, "VINTPOR", 1500);
      ApiTgridSTFInstall.AddColumn(Resources.txt_Mail, "VINTMAIL", 1500);

      ApiTgridSTFInstall.InitColumnList();
    }
    //Private Sub InitApiTgridSTFInstall()
    //    
    //    ApiTgridSTFInstall.AddColumn "NLOTSTFNUM", "NLOTSTFNUM", 0
    //    ApiTgridSTFInstall.AddColumn "§Sous-traitant§", "VSTFGRPNOM", 3200
    //    ApiTgridSTFInstall.AddColumn "§Site§", "VSTFGRPNOM", 2300
    //    ApiTgridSTFInstall.AddColumn "§Contact§", "VINTNOM", 1800
    //    ApiTgridSTFInstall.AddColumn "§Tél§", "VINTTEL", 1500
    //    ApiTgridSTFInstall.AddColumn "§Fax§", "VINTFAX", 1500
    //    ApiTgridSTFInstall.AddColumn "§Port§", "VINTPOR", 1500
    //    ApiTgridSTFInstall.AddColumn "§Mail§", "VINTMAIL", 1500
    //     
    //    ApiTgridSTFInstall.Init ado_rs_STFInstall
    //     
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      //ouverture en modification
      DataRow row = apiTGridLot.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_Confirm_Suppr_Lot, Resources.msg_Confirm_Suppr_Lot_Titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.CnxExecute($"DELETE FROM TLOTSTFGAR WHERE TLOTSTFGAR.NSITGARLOTNUM = {row["NSITGARLOTNUM"]}");
        ApiTgridSTFInstall.Requery(dtInstall, MozartDatabase.cnxMozart);

        ModuleData.CnxExecute($"DELETE FROM TSITLOTGAR WHERE TSITLOTGAR.NSITGARLOTNUM = {row["NSITGARLOTNUM"]}");
        apiTGridLot.Requery(dtLot, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub cmdSupprimer_Click()
    //    
    //    'ouverture en modification
    //    If ado_rs_Lot.RecordCount > 0 Then
    //    
    //        If MsgBox("§Voulez-vous vraiment supprimer ce lot ?§", vbYesNoCancel + vbQuestion, "§Confirmation suppression lot§") = vbYes Then
    //            
    //            cnx.Execute ("DELETE FROM TLOTSTFGAR WHERE TLOTSTFGAR.NSITGARLOTNUM = " & ado_rs_Lot("NSITGARLOTNUM"))
    //            ado_rs_STFInstall.Requery
    //            
    //            cnx.Execute ("DELETE FROM TSITLOTGAR WHERE TSITLOTGAR.NSITGARLOTNUM = " & ado_rs_Lot("NSITGARLOTNUM"))
    //            ado_rs_Lot.Requery
    //        
    //        End If
    //    
    //    End If
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiTGridLot_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGridLot.GetFocusedDataRow();
      if (row == null) return;

      LblNomLot.Text = Utils.BlankIfNull(row["VLOTNOM"]);

      //Ouverture en modification
      LoadSTFInstall(Convert.ToString(row["NSITGARLOTNUM"]));
    }
    //Private Sub apiTGridLot_RowColChange()
    //
    //    If ado_rs_Lot.RecordCount = 0 Then Exit Sub
    //    
    //    LblNomLot.Caption = ado_rs_Lot("VLOTNOM")
    //    
    //    'Ouverture en modification
    //    LoadSTFInstall ado_rs_Lot("NSITGARLOTNUM")
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void LoadSTFInstall(string P_iNUmLot)
    {
      ApiTgridSTFInstall.LoadData(dtInstall, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeLotSTFInstall {P_iNUmLot}");
      ApiTgridSTFInstall.GridControl.DataSource = dtInstall;

      ApiTgridSTFInstall.Requery(dtInstall, MozartDatabase.cnxMozart);
    }
    //Private Sub LoadSTFInstall(ByVal P_iNUmLot As String)
    //
    //    If ado_rs_STFInstall.state = adStateOpen Then ado_rs_STFInstall.Close
    //
    //    Set ado_rs_STFInstall = New ADODB.Recordset
    //    ado_rs_STFInstall.Open "EXEC api_sp_ListeLotSTFInstall " & P_iNUmLot, cnx, adOpenStatic, adLockReadOnly
    //    
    //    ApiTgridSTFInstall.Init ado_rs_STFInstall
    //    
    //    ado_rs_STFInstall.Requery
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      iNumLot = 0;

      FrameLot.Text = $"{Resources.txt_Creation_Lot_Sous_Garantie}";

      txtNomLot.Text = "";
      txtDateRecept.Text = "";
      txtDateFinGarant.Text = "";

      FrameLot.Visible = true;
    }
    //Private Sub cmdAjouter_Click()
    //    
    //'    Dim sNewLot As String
    //'
    //'    sNewLot = InputBox("§Saisir le nom du lot à créer§", "§Nouveau lot§")
    //'
    //'    If sNewLot <> "" Then
    //'
    //'        'on enregistre le lot
    //'        EnregistrerLot 0, sNewLot
    //'
    //'        ado_rs_Lot.Requery
    //'    End If
    //
    //    iNumLot = 0
    //
    //    FrameLot.Caption = "§Création d'un lot sous garantie§"
    //
    //    txtNomLot.Text = ""
    //    txtDateRecept.Text = ""
    //    txtDateFinGarant.Text = ""
    //
    //    FrameLot.Visible = True
    //
    //   
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //
    //    Unload Me
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void EnregistrerLot(int P_iLotNum, string P_NomLot, string P_DateRecept, string P_DateFinGarant)
    {
      //passage du nom de la procédure stockée
      using (SqlCommand cmd = new SqlCommand("api_sp_CreationSitLotGarantie", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        //liste des paramètres
        cmd.Parameters["@p_nsitgarannum"].Value = P_iLotNum; //0 si création
        cmd.Parameters["@p_nsitnum"].Value = iNumSite;
        cmd.Parameters["@p_vsitgaranlot"].Value = P_NomLot;
        cmd.Parameters["@p_ddatrecept"].Value = P_DateRecept == "" ? null : P_DateRecept;
        cmd.Parameters["@p_ddatfingarant"].Value = P_DateFinGarant == "" ? null : P_DateFinGarant;

        //exécuter la commande
        cmd.ExecuteNonQuery();
      }
    }
    //Private Sub EnregistrerLot(ByVal P_iLotNum As Integer, ByVal P_NomLot As String, ByVal P_DateRecept As String, ByVal P_DateFinGarant As String)
    //
    //    Dim cmd As New ADODB.Command
    //
    //    Set cmd.ActiveConnection = cnx
    //    
    //    ' passage du nom de la procédure stockée
    //    cmd.CommandText = "api_sp_CreationSitLotGarantie"
    //    cmd.CommandType = adCmdStoredProc
    //        
    //    'liste des paramètres
    //    cmd.Parameters("@p_nsitgarannum").value = P_iLotNum    ' 0 si création
    //    cmd.Parameters("@p_nsitnum").value = iNumSite
    //    cmd.Parameters("@p_vsitgaranlot").value = P_NomLot
    //    cmd.Parameters("@p_ddatrecept").value = IIf(P_DateRecept = "", Null, P_DateRecept)
    //    cmd.Parameters("@p_ddatfingarant").value = IIf(P_DateFinGarant = "", Null, P_DateFinGarant)
    //
    //    'exécuter la commande.
    //    cmd.Execute
    //        
    //    ' libération de la commande
    //    Set cmd = Nothing
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void CmdModifLot_Click(object sender, EventArgs e)
    {
      //ouverture en modification
      DataRow row = apiTGridLot.GetFocusedDataRow();
      if (row == null) return;

      iNumLot = (int)row["NSITGARLOTNUM"];

      txtNomLot.Text = Utils.BlankIfNull(row["VLOTNOM"]);
      txtDateRecept.Text = Utils.DateBlankIfNull(row["DDATRECEPT"], "");
      txtDateFinGarant.Text = Utils.DateBlankIfNull(row["DDATFINGARANT"], "");

      FrameLot.Visible = true;

      FrameLot.Text = $"{Resources.txt_Modif_Lot_Sous_Garantie}";
    }
    //Private Sub CmdModifLot_Click()
    //    ' UPGRADE_INFO (#0501): The 'sNewLot' member isn't used anywhere in current application.
    //    ' Dim sNewLot As String
    //
    //    'ouverture en modification
    //    If ado_rs_Lot.RecordCount > 0 Then
    //    
    //        iNumLot = ado_rs_Lot("NSITGARLOTNUM")
    //    
    //        txtNomLot.Text = ado_rs_Lot("VLOTNOM")
    //        txtDateRecept.Text = BlankIfNull(ado_rs_Lot("DDATRECEPT"))
    //        txtDateFinGarant.Text = BlankIfNull(ado_rs_Lot("DDATFINGARANT"))
    //    
    //        FrameLot.Visible = True
    //    
    //        FrameLot.Caption = "§Modification d'un lot sous garantie§"
    //    
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //    If ado_rs_Lot.state = adStateOpen Then ado_rs_Lot.Close
    //    Set ado_rs_Lot = Nothing
    //
    //    If ado_rs_STFInstall.state = adStateOpen Then ado_rs_STFInstall.Close
    //    Set ado_rs_STFInstall = Nothing
    //
    //End Sub

  }
}

