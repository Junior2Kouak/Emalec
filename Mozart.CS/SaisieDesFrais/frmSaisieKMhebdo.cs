using MozartCS.Properties;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using MZUtils = MozartControls.Utils;
using MozartLib;

namespace MozartCS
{
  public partial class frmSaisieKMhebdo : Form
  {
    public int miNumAuto;

    DataTable dt = new DataTable();
    DataTable dtCan = new DataTable();

    bool bChangeVehicule;
    //Public miNumAuto As Integer
    //Dim adoRS As ADODB.Recordset
    //Dim tCompt() As String
    //Dim iNumVEHChange As Integer    'cette variable garde en mémoire l'ID du véhicule en cas de changement de véhicules
    //Dim bchangeVehicule As Boolean

    public frmSaisieKMhebdo()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------*/
    private void frmSaisieKMhebdo_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        bChangeVehicule = false;
        RemplirCombos();
        cboTech.SelectedIndex = cboAuto.SelectedIndex = 0;

        cboTech.SelectedIndexChanged += new EventHandler(cboTech_SelectedIndexChanged);

        Calendar1.Value = DateTime.Now.AddDays(-7);

        lblDate1.Text = Calendar1.Value.AddDays(-((int)DateTime.Now.DayOfWeek - 1)).ToShortDateString();
        lblDate2.Text = Calendar1.Value.AddDays(7 - (int)DateTime.Now.DayOfWeek).ToShortDateString();

        txtKm0.Text = lblDate2.Text;

        if (txtKm0.Text == "")
          txtKm0.Text = lblDate1.Text;

        InitApiTgrid();

        //string sSQL = $"SELECT DISTINCT NCANNUM FROM TCAN, TPER WHERE TCAN.NPERNUM = TPER.NPERNUM AND VSOCIETE = App_Name() AND NCANNUM< 1000 order by ncannum";
        string sSQL = $"select DISTINCT NCANNUM from TREF_CTEANA where VSOCIETE = App_Name()";

        ModuleData.LoadData(dtCan, sSQL);

        cboAuto.Enabled = false;

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //    
    //Dim i As Integer
    //
    //On Error GoTo Handler:
    //
    //  InitBoutons Me, frmMenu
    //  bchangeVehicule = False
    //  RemplirCombos
    //  Calendar1.value = DateAdd("d", -7, Date)
    //  
    //  Calendar1.Visible = False
    //  lblDate1 = DateAdd("d", -(Weekday(Calendar1.value) - 2), Calendar1.value)
    //  lblDate2 = DateAdd("d", 8 - Weekday(Calendar1.value), Calendar1.value)
    //  txtKM(0).Text = lblDate2
    //  
    //  If txtKM(0).Text = "" Then txtKM(0).Text = lblDate1
    //  
    //  InitApiTgrid
    //  
    //  i = 0
    //  Set adoRS = New ADODB.Recordset
    //
    //  adoRS.Open "SELECT DISTINCT NCANNUM FROM TCAN, TPER WHERE TCAN.NPERNUM = TPER.NPERNUM AND VSOCIETE = App_Name() AND NCANNUM < 1000 order by ncannum", cnx
    //
    //  While Not adoRS.EOF
    //    ReDim Preserve tCompt(i)
    //    tCompt(i) = adoRS(0)
    //    i = i + 1
    //    adoRS.MoveNext
    //  Wend
    //  adoRS.Close
    //  
    //  cboAuto.Enabled = False
    //  
    //Exit Sub
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cboAuto_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (bChangeVehicule)
        Calendar1_CloseUp(null, null);
      GestColorBtn();
    }
    //Private Sub cboAuto_Click()
    //  If bchangeVehicule Then Calendar1_Click
    //  GestColorBtn
    //End Sub

    /* OK--------------------------------------------------------------------------*/
    private void CmdConsultFicheFrais_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeFichesKMS f = new frmListeFichesKMS();
      f.msTypeFicheKMS = "CONSULT";
      f.mP_SCONDDUCTEUR = cboTech.Text;
      f.mP_SIMMAT = cboAuto.Text;
      f.mP_DATESEM = lblDate1.Text;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CmdConsultFicheFrais_Click()
    //    frmListeFichesKMS.sTypeFicheKMS = "CONSULT"
    //    frmListeFichesKMS.P_SCONDDUCTEUR = cboTech.Text
    //    frmListeFichesKMS.P_SIMMAT = cboAuto.Text
    //    frmListeFichesKMS.P_DATESEM = lblDate1.Caption
    //    frmListeFichesKMS.Show vbModal
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void CmdGestFicheFrais_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmListeFichesKMS f = new frmListeFichesKMS();
      f.msTypeFicheKMS = "ADD";
      f.mP_SCONDDUCTEUR = cboTech.Text;
      f.mP_NPERNUM = cboTech.GetItemData();
      f.mP_SIMMAT = cboAuto.Text;
      f.mP_NVEHNUM = cboAuto.GetItemData();
      f.mP_DATESEM = lblDate1.Text;
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CmdGestFicheFrais_Click()
    //    frmListeFichesKMS.sTypeFicheKMS = "ADD"
    //    frmListeFichesKMS.P_SCONDDUCTEUR = cboTech.Text
    //    frmListeFichesKMS.p_NPERNUM = cboTech.ItemData(cboTech.ListIndex)
    //    frmListeFichesKMS.P_SIMMAT = cboAuto.Text
    //    frmListeFichesKMS.P_NVEHNUM = cboAuto.ItemData(cboAuto.ListIndex)
    //    frmListeFichesKMS.P_DATESEM = lblDate1.Caption
    //    frmListeFichesKMS.Show vbModal
    //    
    //    GestColorBtn
    //    
    //End Sub

    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;

      // Pour afficher les anciennes données, il faut reprendre le véhicule qui avait été enregistré
      txtKm0.Focus();

      DateTime d = Calendar1.Value;

      if (0 == d.DayOfWeek)
      {
        lblDate1.Text = d.AddDays(-6).ToShortDateString();
        lblDate2.Text = d.ToShortDateString();
      }
      else
      {
        lblDate1.Text = d.AddDays(1 - (double)d.DayOfWeek).ToShortDateString();
        lblDate2.Text = d.AddDays(7 - (double)d.DayOfWeek).ToShortDateString();
      }

      txtKm0.Text = lblDate1.Text;

      //  Replacement sur l'auto enregistrée au moment de la saisie
      string sSQL = $"SELECT * FROM api_v_VehKm WHERE NPERNUM = {cboTech.GetItemData()} AND DVEHJOUR BETWEEN '{lblDate1.Text}' " +
                    $"and '{lblDate2.Text}' ORDER BY DVEHJOUR";
      using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
      {
        if (dr.Read())
        {
          cboAuto.SelectedValue = dr["NVEHNUM"];
          txtDerKm.Text = Utils.ZeroIfNull(dr["KMTOT"]).ToString();
        }
        else
          txtDerKm.Text = ""; //si aucun frais alors KM = 0
      }

      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiTGrid1.GridControl.DataSource = dt;
      cboAuto.Enabled = false;

      GestColorBtn();
    }
    //Private Sub Calendar1_Click()
    //
    //Dim i As Integer
    //
    //  ' pour afficher les anciennes données, il faut reprendre le véhicule qui avait ete enregistre
    //  Calendar1.Visible = False
    //  txtKM(0).SetFocus
    //  lblDate1 = DateAdd("d", -(Weekday(Calendar1.value) - 2), Calendar1.value)
    //  lblDate2 = DateAdd("d", 8 - Weekday(Calendar1.value), Calendar1.value)
    //  txtKM(0).Text = lblDate1
    //
    //  i = 0
    //  
    //  ' Remplir les données si il y en a
    //  Set adoRS = New ADODB.Recordset
    //  'ajout le 19/09/2017 par mc : le cas d un veh de loc nest a présent géré
    //  'adoRS.Open "SELECT * FROM api_v_VehKm WHERE NPERNUM = " & cboTech.ItemData(cboTech.ListIndex) & " AND (NVEHNUM = " & cboAuto.ItemData(cboAuto.ListIndex) & " OR NVEHNUM = 0) AND DVEHJOUR BETWEEN '" & lblDate1 & "' and '" & lblDate2 & "' ORDER BY DVEHJOUR", cnx
    //  
    //  adoRS.Open "SELECT * FROM api_v_VehKm WHERE NPERNUM = " & cboTech.ItemData(cboTech.ListIndex) & " AND DVEHJOUR BETWEEN '" & lblDate1 & "' and '" & lblDate2 & "' ORDER BY DVEHJOUR", cnx
    //  
    //'  adoRS.Open "SELECT * FROM api_v_VehKm WHERE NPERNUM = " & cboTech.ItemData(cboTech.ListIndex) & " AND DVEHJOUR BETWEEN '" & lblDate1 & "' and '" & lblDate2 & "' ORDER BY DVEHJOUR", cnx, adOpenDynamic, adLockOptimistic
    //  'replacement sur l'auto enregistre au moment de la saisie
    //  If adoRS.RecordCount > 0 Then
    //    If Not adoRS.EOF Then
    //      SelectLB cboAuto, adoRS("NVEHNUM")
    //    End If
    //    txtDerKm = ZeroIfNull(adoRS("KMTOT"))   ' info du kimolétrage total
    //  Else
    //    txtDerKm = ""   'si aucun frais alors km  = 0
    //  End If
    //  
    //  apiTgrid.Init adoRS
    //  
    //  cboAuto.Enabled = False
    //
    //  GestColorBtn
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdDate1_Click(object sender, EventArgs e)
    {
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    //Private Sub cmdDate1_Click()
    //  Calendar1.Visible = Not Calendar1.Visible
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      // Mise à jour du dernier km connu pour le véhicule
      if (txtDerKm.Text != "")
        ModuleData.ExecuteNonQuery($"UPDATE TVEHICULES SET NVEHDERKM = {txtDerKm.Text} WHERE NVEHNUM = {cboAuto.GetItemData()}");
    }
    //Private Sub cmdValider_Click()
    //  
    //  'update dans tvehmk si changement du véhicule
    // ' If cboAuto.ItemData(cboAuto.ListIndex) <> iNumVEHChange Then
    // '    cnx.Execute "UPDATE TVEHKM SET NVEHNUM = " & cboAuto.ItemData(cboAuto.ListIndex) & " WHERE NVEHNUM = " & iNumVEHChange & " AND NPERNUM = " & cboTech.ItemData(cboTech.ListIndex) & " AND DVEHJOUR BETWEEN '" & lblDate1.Caption & "' AND '" & lblDate2.Caption & "'"
    //     cboAuto.Enabled = False
    // ' End If
    //  
    //  ' Mise à jour du dernier km connu pour le véhicule
    //  If txtDerKm <> "" Then
    //    cnx.Execute "UPDATE TVEHICULES SET NVEHDERKM = " & txtDerKm & " WHERE NVEHNUM = " & cboAuto.ItemData(cboAuto.ListIndex)
    //  End If
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
    {
      int KeyAscii = e.KeyChar;
      TextBox txt = sender as TextBox;
      int Index = Convert.ToInt32(txt.Tag);

      if (KeyAscii == 13)    // Entrée
      {
        if (Index < 8)
        {
          TextBox txtNext = (TextBox)Controls.Find("txtKm" + (Index + 1).ToString(), false)[0];
          txtNext.Focus();
        }
      }
      if (KeyAscii == 43 && Index == 0)   // +
      {
        txt.Text = Convert.ToDateTime(txtKm0.Text).AddDays(+1).ToShortDateString();
        e.Handled = true;
      }

      if (KeyAscii == 45 && Index == 0)   // -
      {
        txt.Text = Convert.ToDateTime(txtKm0.Text).AddDays(-1).ToShortDateString();
        e.Handled = true;
      }
      if (KeyAscii == 8)    // 
        return;
      if ((KeyAscii < 47 || KeyAscii > 57) && Index < 6)
        e.Handled = true;
      else
      {
        if (KeyAscii == 46)   // .
          e.KeyChar = ',';      // ,
      }
    }
    //Private Sub txtKm_KeyPress(Index As Integer, KeyAscii As Integer)

    //  If KeyAscii = 13 Then
    //    If Index < 8 Then
    //      txtKM(Index + 1).SetFocus
    //    End If
    //  End If
    //  If KeyAscii = 43 And Index = 0 Then
    //    txtKM(Index).Text = DateAdd("d", 1, CDate(txtKM(Index).Text))
    //    KeyAscii = 0
    //  End If
    //  If KeyAscii = 45 And Index = 0 Then
    //    txtKM(Index).Text = DateAdd("d", -1, CDate(txtKM(Index).Text))
    //    KeyAscii = 0
    //  End If
    //  If KeyAscii = 8 Then Exit Sub
    //  If (KeyAscii < 47 Or KeyAscii > 57) And Index < 6 Then
    //    KeyAscii = 0
    //  Else
    //    If KeyAscii = 46 Then KeyAscii = 44
    //  End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cboTech_SelectedIndexChanged(object sender, EventArgs e)
    {
      //on se place sur le bon véhicule
      try
      {
        if (cboTech.GetItemData() < 1)
        {
          CmdAjouter.Enabled = false;
          CmdSuppDate.Enabled = false;
          cmdValider.Enabled = false;
          CmdGestFicheFrais.Enabled = false;

          return;
        }

        string VehNum = ModuleData.ExecuteScalarString($"SELECT NVEHNUM FROM TVEHICULES WHERE NPERNUM = {cboTech.GetItemData()}");
        if (VehNum == "")
          cboAuto.SelectedIndex = 0;
        else
          cboAuto.SelectedValue = VehNum;

        Calendar1_CloseUp(null, null);
        CmdAjouter.Enabled = true;
        CmdSuppDate.Enabled = true;
        cmdValider.Enabled = true;
        CmdGestFicheFrais.Enabled = true;

        GestColorBtn();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cboTech_Click()
    //
    //' on se place sur le bon véhicule
    //Dim rs As ADODB.Recordset
    //
    //   On Error Resume Next
    //
    //  If cboTech.ItemData(cboTech.ListIndex) < 1 Then
    //    cmdAjouter.Enabled = False
    //    CmdSuppDate.Enabled = False
    //    cmdValider.Enabled = False
    //    CmdGestFicheFrais.Enabled = False
    //    adoRS.Close
    //    Exit Sub
    //  End If
    //
    //  Set rs = New ADODB.Recordset
    //  rs.Open "SELECT NVEHNUM FROM TVEHICULES WHERE NPERNUM=" & cboTech.ItemData(cboTech.ListIndex), cnx
    //
    //  If rs.EOF Then
    //    cboAuto.ListIndex = 0
    //  Else
    //    SelectLB cboAuto, rs(0)
    //    rs.Close
    //  End If
    //  
    //  Calendar1_Click
    //  cmdAjouter.Enabled = True
    //  CmdSuppDate.Enabled = True
    //  cmdValider.Enabled = True
    //  CmdGestFicheFrais.Enabled = True
    //  
    //  GestColorBtn
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdAuto_Click(object sender, EventArgs e)
    {
      bChangeVehicule = true;
      cboAuto.Enabled = true;
    }
    //Private Sub cmdAuto_Click()
    //  bchangeVehicule = True
    //  cboAuto.Enabled = True
    //  iNumVEHChange = cboAuto.ItemData(cboAuto.ListIndex)
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirCombos()
    {
      try
      {
        string sSQL = "SELECT NVEHNUM, VVEHIMAT From TVEHICULES WHERE VSOCIETE = App_Name() AND (NOT (VVEHIMAT IS NULL) and VVEHIMAT<> '') and CVEHACTIF='O' ORDER BY VVEHIMAT";
        ModuleData.RemplirCombo(cboAuto, sSQL);
        cboAuto.ValueMember = "NVEHNUM";
        cboAuto.DisplayMember = "VVEHIMAT";

        sSQL = "select NPERNUM, VPERNOM + ' ' + VPERPRE [VPERNOM] from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' AND CPERTYP <> 'CA' ORDER BY VPERNOM, VPERPRE";
        ModuleData.RemplirCombo(cboTech, sSQL);
        cboTech.ValueMember = "NPERNUM";
        cboTech.DisplayMember = "VPERNOM";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub RemplirCombos()
    //
    //On Error GoTo Handler
    //
    // ' vider la combo
    //  cboTech.Clear
    //  cboAuto.Clear
    //  
    //  ' auto
    //  RemplirCombo cboAuto, "SELECT NVEHNUM, VVEHIMAT From TVEHICULES WHERE VSOCIETE = App_Name() AND (NOT (VVEHIMAT IS NULL) and VVEHIMAT<> '') and CVEHACTIF='O' ORDER BY  VVEHIMAT"
    //  ' tech
    //  RemplirCombo cboTech, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' AND CPERTYP <> 'CA' ORDER BY  VPERNOM, VPERPRE"
    //
    //Exit Sub
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "RemplirCombos dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void txtDerKm_KeyPress(object sender, KeyPressEventArgs e)
    {
      int KeyAscii = e.KeyChar;
      // Contrôle de numéricité
      if (KeyAscii == 8)
        return;
      if (KeyAscii < 48 || KeyAscii > 57)
        e.Handled = true;
    }
    //Private Sub txtDerKM_KeyPress(KeyAscii As Integer)
    //' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private bool TestCompte()
    {
      bool result = false;

      //  test si les comptes sont corrects
      //   parcours du tableau
      for (int j = 0; j < dtCan.Rows.Count; j++)
      {
        if (dtCan.Rows[j].ItemArray[0].ToString() == txtKm5.Text)
        {
          result = true;
          break;
        }
      }
      return result;
    }
    //Private Function TestCompte() As Boolean
    //Dim j As Integer
    //  
    //  TestCompte = False
    //  
    //  ' test si les comptes sont correct
    //    ' parcour du tableau
    //    For j = 0 To UBound(tCompt()) - 1
    //      TestCompte = False
    //      If tCompt(j) = txtKM(5).Text Then
    //            TestCompte = True
    //            Exit For
    //      End If
    //    Next j
    //  
    //End Function

    /* OK --------------------------------------------------------------------------*/
    private bool TestGD()
    {
      bool result = true;

      // test si les GD sont corrects
      if (Utils.ZeroIfBlank(txtKm2.Text) > 0 && Utils.ZeroIfBlank(txtKm3.Text) > 0)
        result = false;
      else
      {
        if (Utils.ZeroIfBlank(txtKm3.Text) > 0)
        {
          result = false;
          string[] array = { "85", "90", "95", "105" }; //HORS IDF = 75 IDF: 80 euros, Benelux : 95 euros, Hors Benelux : 85 euro
          if (array.Contains(txtKm4.Text)) result = true;
        }
        else
        {
          if (Utils.ZeroIfBlank(txtKm3.Text) == 0 && Utils.ZeroIfBlank(txtKm4.Text) != 0)
            result = false;
        }
      }
      return result;
    }
    //Private Function TestGD() As Boolean
    //  On Error Resume Next
    //  TestGD = True
    // 
    //  ' test si les GD sont corrects
    //  If ZeroIfNull(txtKM(2).Text) > 0 And ZeroIfNull(txtKM(3).Text) > 0 Then
    //    TestGD = False
    //  Else
    //    If ZeroIfNull(txtKM(3).Text) > 0 Then
    //    TestGD = False
    //      If txtKM(4).Text = 85 Or txtKM(4).Text = 90 Or txtKM(4).Text = 95 Or txtKM(4).Text = 105 Then  'HORS IDF = 75 IDF: 80 euros, Benelux : 95 euros, Hors Benelux : 85 euro
    //        TestGD = True
    //      End If
    //    ElseIf ZeroIfNull(txtKM(3).Text) = 0 And ZeroIfNull(txtKM(4).Text) <> 0 Then
    //      TestGD = False
    //    End If
    //  End If
    //  
    //End Function

    /* OK --------------------------------------------------------------------------*/
    private void CmdAjouter_Click(object sender, EventArgs e)
    {
      long result;

      try
      {
        if (TestCompte() == false || txtKm5.Text == "")
        {
          MessageBox.Show(Resources.msg_WarningErrorOnAccount, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        if (TestGD() == false)
        {
          MessageBox.Show(Resources.msg_WarningErrorOnTheAmountGD, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        if (DateTime.TryParse(txtKm0.Text, out DateTime temp) == false || txtKm0.Text == "")
        {
          MessageBox.Show(Resources.msg_date_invalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (Convert.ToDateTime(txtKm0.Text) < Convert.ToDateTime(lblDate1.Text) || Convert.ToDateTime(txtKm0.Text) > Convert.ToDateTime(lblDate2.Text))
        {
          MessageBox.Show(Resources.msg_DateHorsSemaine, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtKm0.Focus();
          return;
        }

        //création d'une commande
        // liste des paramètres
        using (SqlCommand cmd = new SqlCommand("api_sp_AjoutLigneFrais", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@npernum"].Value = cboTech.GetItemData();
          cmd.Parameters["@nvehnum"].Value = cboAuto.GetItemData();
          cmd.Parameters["@ddatefrais"].Value = txtKm0.Text;
          cmd.Parameters["@iNbKms"].Value = Utils.ZeroIfBlank(txtKm1.Text);
          cmd.Parameters["@iNbRepas"].Value = Utils.ZeroIfBlank(txtKm2.Text);
          cmd.Parameters["@iNbGD"].Value = Utils.ZeroIfBlank(txtKm3.Text);
          cmd.Parameters["@iValGD"].Value = Utils.ZeroIfBlank(txtKm4.Text);
          cmd.Parameters["@iNumCTE"].Value = txtKm5.Text;
          cmd.Parameters["@iNbHRSUP25"].Value = Utils.ZeroIfBlank(txtKm6.Text);
          cmd.Parameters["@iNbHRSUP50"].Value = Utils.ZeroIfBlank(txtKm7.Text);
          cmd.Parameters["@iNbHRSUP100"].Value = Utils.ZeroIfBlank(txtKm8.Text);
          //exécuter la commande.
          cmd.ExecuteNonQuery();
          result = Convert.ToInt64(cmd.Parameters[0].Value);
        }

        // retour du paramètre
        if (result == 0)
        {
          MessageBox.Show(Resources.msg_FraisExisteDejaPourJournee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

        // reinit les champs text
        txtKm1.Text = "";
        txtKm2.Text = "";
        txtKm3.Text = "";
        txtKm4.Text = "";
        txtKm5.Text = "";
        txtKm6.Text = "";
        txtKm7.Text = "";
        txtKm8.Text = "";

        txtKm0.Text = Convert.ToDateTime(txtKm0.Text).AddDays(1).ToShortDateString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdAjouter_Click()
    //
    //Dim cmd As New ADODB.Command
    //Dim i As Integer
    //
    //On Error GoTo Handler
    //
    //  If Not TestCompte Or txtKM(5).Text = "" Then
    //    MsgBox "§Attention, erreur sur un compte !§"
    //    Exit Sub
    //  End If
    //  
    //  If Not TestGD Then
    //    MsgBox "§Attention, erreur sur le montant du GD ou sur 1 repas et 1 GD le même jour!§"
    //    Exit Sub
    //  End If
    //  
    //  If Not IsDate(txtKM(0)) Or txtKM(0).Text = "" Then
    //     MsgBox "§Date invalide§", vbExclamation
    //     Exit Sub
    //  End If
    //    
    //  If CDate(txtKM(0)) < CDate(lblDate1.Caption) Or CDate(txtKM(0)) > CDate(lblDate2.Caption) Then
    //    MsgBox "§Date hors de la semaine§", vbExclamation
    //    txtKM(0).SetFocus
    //    Exit Sub
    //  End If
    //    
    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  cmd.CommandText = "api_sp_AjoutLigneFrais"
    //  cmd.CommandType = adCmdStoredProc
    //   ' passage des paramètres
    //  cmd.Parameters.Refresh
    //  cmd.Parameters("@npernum").value = cboTech.ItemData(cboTech.ListIndex)
    //  cmd.Parameters("@nvehnum").value = cboAuto.ItemData(cboAuto.ListIndex)
    //  cmd.Parameters("@ddatefrais").value = txtKM(0).Text
    //  cmd.Parameters("@iNbKms").value = ZeroIfNull(txtKM(1).Text)
    //  cmd.Parameters("@iNbRepas").value = ZeroIfNull(txtKM(2).Text)
    //  cmd.Parameters("@iNbGD").value = ZeroIfNull(txtKM(3).Text)
    //  cmd.Parameters("@iValGD").value = ZeroIfNull(txtKM(4).Text)
    //  cmd.Parameters("@iNumCTE").value = txtKM(5).Text
    //  cmd.Parameters("@iNbHRSUP25").value = ZeroIfNull(txtKM(6).Text)
    //  cmd.Parameters("@iNbHRSUP50").value = ZeroIfNull(txtKM(7).Text)
    //  cmd.Parameters("@iNbHRSUP100").value = ZeroIfNull(txtKM(8).Text)
    //  
    //  ' exécuter la commande.
    //  cmd.Execute
    //      
    //  ' retour du paramètre
    //  If cmd.Parameters(0).value = 0 Then
    //    MsgBox "§Il existe dejà des frais sur cette journée!!!§"
    //    Set cmd = Nothing
    //    Exit Sub
    //  End If
    //  
    //  ' libération de la commande
    //  Set cmd = Nothing
    //
    //  'mise à jour recordset et apitgrid
    //  adoRS.Requery
    //  
    //  'reinit les champs text
    //  For i = 1 To 8
    //    txtKM(i).Text = ""
    //  Next
    //  txtKM(0).Text = DateAdd("d", 1, CDate(txtKM(0).Text))
    //
    //  Exit Sub
    //
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdAjouter_Click de " & Me.Name
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdKMmois_Click(object sender, EventArgs e)
    {
      frmSaisieKM f = new frmSaisieKM();
      f.ShowDialog();
    }
    //Private Sub cmdKMmois_Click()
    //  frmSaisieKM.Show vbModal
    //End Sub

    /*OK--------------------------------------------------------------------------*/
    private void CmdSuppDate_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        string dJour = Convert.ToDateTime(currentRow["DVEHJOUR"]).ToShortDateString();

        if (MessageBox.Show(Resources.msg_ConfirmDelRow + dJour + "?", Program.AppTitle,
          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          string sSQL = $"DELETE FROM TVEHKM WHERE NPERNUM = {currentRow["NPERNUM"]} AND NVEHNUM = {currentRow["NVEHNUM"]} " +
            $"AND DVEHJOUR = '{dJour}' AND NVEHCTE  = {currentRow["NVEHCTE"]}";
          ModuleData.ExecuteNonQuery(sSQL);
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CmdSuppDate_Click()
    //
    //  Dim sSql As String
    //  Dim iRep As Integer
    //  
    //  On Error GoTo Handler
    //  
    //  If adoRS.State = adStateClosed Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //  
    //  If adoRS.RecordCount > 0 Then
    //  
    //    iRep = MsgBox("§Voulez vraiment supprimer cette ligne §" & adoRS("DVEHJOUR") & "?", vbYesNo)
    //    If iRep = vbYes Then
    //    
    //        sSql = "DELETE FROM TVEHKM WHERE NPERNUM = " & adoRS("NPERNUM") & " AND NVEHNUM = " & adoRS("NVEHNUM") & " AND DVEHJOUR = '" & adoRS("DVEHJOUR") & "' AND NVEHCTE  = " & adoRS("NVEHCTE")
    //        cnx.Execute sSql
    //    
    //    End If
    //  
    //    adoRS.Requery
    //    apiTgrid.MajLabel
    //  
    //  End If
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "CmdSuppDate_Click de " & Me.Name
    //
    //End Sub

    /*OK--------------------------------------------------------------------------*/
    private void InitApiTgrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Date, "DVEHJOUR", txtKm0.Width);
        apiTGrid1.AddColumn(Resources.col_Kms, "NVEHKMJ", txtKm1.Width, "", 2);
        apiTGrid1.AddColumn(Resources.col_Repas, "NVEHREPAS", txtKm2.Width, "", 2);
        apiTGrid1.AddColumn(Resources.col_GD, "NVEHGD", txtKm3.Width, "", 2);
        apiTGrid1.AddColumn(Resources.col_GD75_80_85_95, "NVEHVGD", txtKm4.Width, "", 2);
        apiTGrid1.AddColumn(Resources.col_Compte, "NVEHCTE", txtKm5.Width, "", 2);
        apiTGrid1.AddColumn("Heures déplacement", "NVEHHRSUP25", txtKm6.Width, "", 2);
        apiTGrid1.AddColumn(Resources.col_HSUP_50percent, "NVEHHRSUP50", 0);
        apiTGrid1.AddColumn(Resources.col_HSUP_100percent, "NVEHHRSUP100", 0);
        apiTGrid1.AddColumn("NPERNUM", "NPERNUM", 0);
        apiTGrid1.AddColumn("NVEHNUM", "NVEHNUM", 0);

        //apiTGrid1.DelockColumn("NVEHKMJ");
        //apiTGrid1.DelockColumn("NVEHHRSUP25");

        apiTGrid1.InitColumnList();

        apiTGrid1.FilterBar = false;

      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGridPrestSaisie_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      GridView gv = sender as GridView;
      DataRow row = gv.GetDataRow(e.RowHandle);
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();

      if (e.Column.Name == "NVEHKMJ")
      {
        if (Utils.ZeroIfNull(row["NVEHKMJ"]) == 0)
        {
          MessageBox.Show("Valeur nulle impossible", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          gv.SetFocusedValue(row["NVEHKMJ"]);
          return;
        }
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridPrestSaisie_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      GridView gv = sender as GridView;
      DataRow row = gv.GetDataRow(e.RowHandle);
      if (e.Column.Name == "NVEHKMJ")
      {

        if (Utils.ZeroIfNull(row["NVEHKMJ"]) == 0)
        {
          MessageBox.Show(Resources.msg_saisir_coef, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        else
          ModuleData.ExecuteNonQuery($"UPDATE TVEHKM SET NVEHKMJ = {row["NVEHKMJ"].ToString().Replace(",", ".")} WHERE NPERNUM = {row["NPERNUM"]} " +
            $" AND NVEHNUM={row["NVEHNUM"]}  AND DVEHJOUR='{row["DVEHJOUR"]}'  AND NVEHCTE={row["NVEHCTE"]}  ");
      }
      if (e.Column.Name == "NVEHHRSUP25")
      {
        //if (Utils.IsNumeric(row["NVEHHRSUP25"].ToString()) == false)
        //{
        //  MessageBox.Show(Resources.msg_format_coef_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //  return;
        //}
        //else
        ModuleData.ExecuteNonQuery($"UPDATE TVEHKM SET NVEHHRSUP25 = {row["NVEHHRSUP25"].ToString().Replace(",", ".")} WHERE NPERNUM = {row["NPERNUM"]} " +
          $" AND NVEHNUM={row["NVEHNUM"]}  AND DVEHJOUR='{row["DVEHJOUR"]}'  AND NVEHCTE={row["NVEHCTE"]}  ");

        //if (Utils.IsNumeric(row["COEF"].ToString()) == false)
        //{
        //  MessageBox.Show(Resources.msg_format_coef_numerique, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //  return;
        //}
        //if (Convert.ToDouble(row["COEF"].ToString()) < 1)
        //{
        //  MessageBox.Show(Resources.msg_coeff_inf_1_coef_defaut, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //  row["COEF"] = 1.7;
        //  return;
        //}

      }
    }

    //Private Sub InitApiTgrid()
    //  
    //On Error GoTo Handler
    //
    //  apiTgrid.AddColumn "§Date§", "DVEHJOUR", txtKM(0).width
    //  apiTgrid.AddColumn "§Kms§", "NVEHKMJ", txtKM(1).width
    //  apiTgrid.AddColumn "§Repas§", "NVEHREPAS", txtKM(2).width
    //  apiTgrid.AddColumn "§GD§", "NVEHGD", txtKM(3).width
    //  apiTgrid.AddColumn "§GD 75/80/85/95§", "NVEHVGD", txtKM(4).width
    //  apiTgrid.AddColumn "§Compte§", "NVEHCTE", txtKM(5).width
    //  apiTgrid.AddColumn "§HSUP 25%§", "NVEHHRSUP25", txtKM(6).width
    //  apiTgrid.AddColumn "§HSUP 50%§", "NVEHHRSUP50", txtKM(7).width
    //  apiTgrid.AddColumn "§HSUP 100%§", "NVEHHRSUP100", txtKM(8).width
    //  apiTgrid.AddColumn "NPERNUM", "NPERNUM", 0
    //  apiTgrid.AddColumn "NVEHNUM", "NVEHNUM", 0
    //  
    //  apiTgrid.FilterBar = False
    //  
    //  apiTgrid.DelockColumn ("NVEHKMJ")
    //  apiTgrid.DelockColumn ("NVEHREPAS")
    //  apiTgrid.DelockColumn ("NVEHGD")
    //  apiTgrid.DelockColumn ("NVEHVGD")
    //  apiTgrid.DelockColumn ("NVEHHRSUP25")
    //  apiTgrid.DelockColumn ("NVEHHRSUP50")
    //  apiTgrid.DelockColumn ("NVEHHRSUP100")
    //    
    //Exit Sub
    //Handler:
    //  ShowError "InitapiTGrid dans " & Me.Name
    //End Sub

    /* TODO Event BeforeColUpdate pour apiTGrid--------------------------------------------------------------------------*/
    private void apiTGrid_BeforeColUpdate(int ColIndex, /*TrueOleDBGrid80.Columns Cols, */string BookMark, bool Cancel)
    {
      //if (apiTGrid.Column)
      //{
      MessageBox.Show(Resources.msg_ValeurGDNonCorrecte, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //}
    }
    //Private Sub apiTGrid_BeforeColUpdate(ColIndex As Integer, Cols As TrueOleDBGrid80.Columns, BookMark As Variant, Cancel As Integer)
    //  
    //  If apiTgrid.Columns.Item(4).value <> 0 And apiTgrid.Columns.Item(4).value <> 70 And apiTgrid.Columns.Item(4).value <> 80 And apiTgrid.Columns.Item(4).value <> 85 And apiTgrid.Columns.Item(4).value <> 95 Then
    //  
    //    MsgBox "§La valeur GD n'est pas correcte!!§"
    //    Cancel = True
    //  
    //  End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void GestColorBtn()
    {
      long result;
      if (cboTech.Text != "" && cboAuto.Text != "" && lblDate1.Text != "")
      {
        result = (long)ModuleData.ExecuteScalarInt($"EXEC api_sp_FicheKmsExist {cboTech.GetItemData()}, {cboAuto.GetItemData()}, '{lblDate1.Text}'");
        if (result > 0)
          CmdGestFicheFrais.BackColor = Color.Yellow;
        else
          CmdGestFicheFrais.BackColor = Color.White;
      }
    }
    //Private Sub GestColorBtn()
    //
    //    If cboTech.Text <> "" And cboAuto.Text <> "" And lblDate1.Caption <> "" Then
    //
    //        Dim ado_color As New ADODB.Recordset
    //        
    //        ado_color.Open "EXEC api_sp_FicheKmsExist " & cboTech.ItemData(cboTech.ListIndex) & ", " & cboAuto.ItemData(cboAuto.ListIndex) & ", '" & lblDate1.Caption & "'", cnx, adOpenStatic, adLockReadOnly
    //        
    //        If ado_color(0).value > 0 Then
    //            CmdGestFicheFrais.BackColor = &H80FFFF
    //        Else
    //            CmdGestFicheFrais.BackColor = &H8000000F
    //        End If
    //        
    //        ado_color.Close
    //        Set ado_color = Nothing
    //    
    //    End If
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void CmdFraisTablet_Click(object sender, EventArgs e)
    {
      new frmValidationFraisKMSReceive().ShowDialog();
    }
    //Private Sub CmdFraisTablet_Click()
    //       
    //    VerifMOZARTNET
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmValidationFraisKMSReceive", vbNormalFocus
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void CmdCtrlGD_Click(object sender, EventArgs e)
    {
      new frmValidationGDReceive().ShowDialog();
    }
    //Private Sub CmdCtrlGD_Click()
    //
    //    VerifMOZARTNET
    //    OpenNetForm gstrCheminProgramme & "\mozart\MozartNet.exe " & gstrNomServeur & " " & gstrNomSociete & " frmValidationGDReceive", vbNormalFocus
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
  }
}