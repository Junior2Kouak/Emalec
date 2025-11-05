using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixMultiEquipements : Form
  {
    public int miNumGamme;
    public int miNumClient;
    public DataTable dtRS = new DataTable();

    DataTable dtEquipement = new DataTable();
    int nbCoche;

    //pour frmDetailsTravaux
    public bool mbAnnulerChoix;
    public char mcCboPrest;
    public string msCboGammeText;

    //  Option Explicit
    //
    //Public miNumGamme As Integer
    //Public miNumClient As Integer
    //Dim rsEquipement As ADODB.Recordset
    //
    //Dim NbCoche As Integer

    public frmChoixMultiEquipements() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmChoixMultiEquipements_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitApigrid();
        apiTGrid.SetBounds(apiTGrid.Location.X, apiTGrid.Location.Y, apiTGrid.Width - 1, apiTGrid.Height);

        Utils.InitComboBox(cboGamme, $"api_sp_ComboGamme {miNumClient} ,0", "", "", true);

        cboGamme.SelectedIndex = miNumGamme;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //  
    //  ' initialisation des images
    //  NbCoche = 0
    //  InitBoutons Me, frmMenu
    // 
    //  InitApigrid
    //  
    //  RemplirCombo cboGamme, "api_sp_ComboGamme " & miNumClient & " , 0"
    //  SelectLB cboGamme, miNumGamme
    //      
    //End Sub
    //


    /* OK --------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      mbAnnulerChoix = true;
      Dispose();
    }

    //Private Sub cmdFermer_Click()
    //   frmDetailstravaux.AnnulerChoix = True
    //   Unload Me
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        string sMsg = "";

        if (dtEquipement.Rows.Count == 0) return;

        // on recherche le montant et la duree de la prev au niveau du contrat
        if (mcCboPrest == 'P')
        {
          foreach (DataRow row in dtEquipement.Rows)
          {
            if (Utils.ZeroIfNull(row["CHECK"]) != 0)
            {
              using (SqlDataReader sdrMontantDuree = ModuleData.ExecuteReader($"SELECT NOBJMONTANTINTER,NOBJDUREEINTER FROM TGIDTOBJCLI WHERE NOBJNUM = {Utils.ZeroIfNull(row["NOBJNUM"])}"))
              {
                if (sdrMontantDuree.Read())
                {
                  if (Utils.BlankIfNull(sdrMontantDuree["NOBJMONTANTINTER"]) == "" || Utils.BlankIfNull(sdrMontantDuree["NOBJDUREEINTER"]) == "")
                    sMsg += $"   - {Utils.BlankIfNull(row["VOBJLIB"])}\r\n";
                }
                else
                  sMsg += $"   - {Utils.BlankIfNull(row["VOBJLIB"])}\r\n";
              }
            }
          }
        }

        // si on a une donnée incorrecte, on affiche un message et on quitte la fonction
        if (sMsg != "")
        {
          MessageBox.Show($"Problème sur le contrat de la DI:\r\n{Resources.msg_montantDureePrevNonRenseigne}\r\n{sMsg}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // initialisation du recordset
        InitRecordset();

        foreach (DataRow row1 in dtEquipement.Rows)
        {
          if (Convert.ToBoolean(row1["CHECK"]))
          {
            // ajout de l'enregistrement

            DataRow newrow = dtRS.NewRow();

            newrow["NomEquip"] = Utils.BlankIfNull(row1["VOBJLIB"]);
            newrow["NumEquip"] = Utils.ZeroIfNull(row1["NOBJNUM"]);
            newrow["Client"] = miNumClient;
            dtRS.Rows.Add(newrow);
          }
        }

        // choix de la gamme
        if (cboGamme.Text != "")
          msCboGammeText = cboGamme.Text;

        mbAnnulerChoix = false;

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    //Dim rsMontantDuree As ADODB.Recordset
    //Dim sMsg As String
    //Dim sSQL As String
    //
    //  On Error GoTo handler
    //  
    //  If rsEquipement.RecordCount = 0 Then Exit Sub
    //  
    //  rsEquipement.Filter = ""
    //  rsEquipement.MoveFirst
    // 
    //  ' on recherche le montant et la duree de la prev au niveau du contrat
    //  If Chr(frmDetailstravaux.cboPrest.ItemData(frmDetailstravaux.cboPrest.ListIndex)) = "P" Then
    //    
    //    While Not rsEquipement.EOF
    //      If rsEquipement("CHECK") <> 0 Then
    //
    //        Set rsMontantDuree = New ADODB.Recordset
    //
    //        sSQL = "SELECT NOBJMONTANTINTER,NOBJDUREEINTER FROM TGIDTOBJCLI WHERE NOBJNUM = " & rsEquipement("NOBJNUM")
    //        
    //        rsMontantDuree.Open sSQL, cnx
    //
    //        If Not rsMontantDuree.EOF Then
    //          If BlankIfNull(rsMontantDuree("NOBJMONTANTINTER")) = "" Or BlankIfNull(rsMontantDuree("NOBJDUREEINTER")) = "" Then
    //            sMsg = sMsg & "   - " & rsEquipement("VOBJLIB") & vbCrLf
    //          End If
    //        Else
    //          sMsg = sMsg & "   - " & rsEquipement("VOBJLIB") & vbCrLf
    //        End If
    //
    //        rsMontantDuree.Close
    //      End If
    //
    //    rsEquipement.MoveNext
    //    Wend
    //  End If
    //
    //  ' si on a une donnée incorrecte, on affiche un message et on quitte la fonction
    //  If sMsg <> "" Then
    //    MsgBox "§Contrat : §" & frmAddAction.cboTypeContrat & vbCrLf & "§Le montant ou la durée de la préventive ne sont pas renseignés : §" & vbCrLf & sMsg, vbExclamation
    //    Exit Sub
    //  End If
    //
    //  ' initialisation du recordset
    //  InitRecordset
    //
    //  rsEquipement.MoveFirst
    //  While Not rsEquipement.EOF
    //     If rsEquipement("CHECK") <> 0 Then
    //        ' ajout de l'enregistrement
    //        rs.AddNew
    //  
    //        rs("NomEquip").value = rsEquipement("VOBJLIB")
    //        rs("NumEquip").value = rsEquipement("NOBJNUM")
    //        rs("Client").value = miNumClient
    //  
    //        rs.Update
    //     End If
    //    rsEquipement.MoveNext
    //  Wend
    //
    //  ' choix de la gamme
    //  If cboGamme.Text <> "" Then frmDetailstravaux.cboGamme.Text = cboGamme.Text
    //  frmDetailstravaux.AnnulerChoix = False
    //  
    //  Unload Me
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " cmdValider_click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCocherT_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (DataRow row in dtEquipement.Rows)
          row["CHECK"] = true;

        nbCoche = dtEquipement.Rows.Count;
        lblNbEquip.Text = $"{lblNbEquip.Tag}{nbCoche}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdCocherT_Click()
    //' UPGRADE_INFO (#0501): The 'i' member isn't used anywhere in current application.
    //' Dim i As Integer
    //
    //On Error GoTo handler
    //  
    //  rsEquipement.MoveFirst
    //  While Not rsEquipement.EOF
    //    rsEquipement.Update "CHECK", -1
    //    rsEquipement.MoveNext
    //  Wend
    // 
    //  NbCoche = rsEquipement.RecordCount
    //  lblNbEquip = lblNbEquip.Tag & NbCoche
    // 
    //  
    //Exit Sub
    //handler:
    //  ShowError " cmdCocherT_Click dans " & Me.Name
    //End Sub


    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (DataRow row in dtEquipement.Rows)
        {
          row["CHECK"] = false;
        }

        nbCoche = 0;
        lblNbEquip.Text = $"{lblNbEquip.Tag}{nbCoche}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdDecocher_Click()
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  rsEquipement.MoveFirst
    //  While Not rsEquipement.EOF
    //    rsEquipement.Update "CHECK", 0
    //    rsEquipement.MoveNext
    //  Wend
    //  
    //  NbCoche = 0
    //  lblNbEquip = lblNbEquip.Tag & NbCoche
    //
    //Exit Sub
    //handler:
    //  ShowError " cmddécocherT_Click dans " & Me.Name
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Function CompterCoche() As Integer
    //
    //Dim i As Long
    //
    //On Error GoTo handler
    //   
    //  CompterCoche = 0
    //  If rsEquipement.RecordCount = 0 Then Exit Function
    //
    //  NbCoche = 0
    //  
    //  i = rsEquipement.AbsolutePosition
    //  
    //  While Not rsEquipement.EOF
    //    If rsEquipement("CHECK") <> 0 Then
    //      NbCoche = NbCoche + 1
    //    End If
    //    rsEquipement.MoveNext
    //  Wend
    //  
    //  CompterCoche = NbCoche
    //
    //Exit Function
    //handler:
    //  ShowError " CompterCoche dans " & Me.Name
    //End Function
    //

    /* OK  --------------------------------------------------------------------------------------- */
    public void InitRecordset()
    {
      // initialisation du recordset des sites
      dtRS.Columns.Add("NomEquip", Type.GetType("System.String"));
      dtRS.Columns.Add("NumEquip", Type.GetType("System.Int32"));
      dtRS.Columns.Add("Client", Type.GetType("System.Int32"));
    }

    //Public Sub InitRecordset()
    //
    //  ' initialisation du recordset des sites
    //  Set rs = New ADODB.Recordset
    //  
    //  ' ajout des champs au recordset
    //  rs.Fields.Append "NomEquip", adVarChar, 100
    //  rs.Fields.Append "NumEquip", adInteger
    //  rs.Fields.Append "Client", adInteger
    //  
    //
    //  ' ouverture
    //  rs.Open , , adOpenDynamic, adLockOptimistic
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (!Convert.ToBoolean(row["CHECK"]))
        nbCoche--;
      else
        nbCoche++;

      lblNbEquip.Text = $"{lblNbEquip.Tag}{nbCoche}";
    }

    //Private Sub apiTGrid_AfterColUpdate(ColIndex As Integer)
    //  If rsEquipement!Check = 0 Then
    //      NbCoche = NbCoche - 1
    //  Else
    //      NbCoche = NbCoche + 1
    //  End If
    //  lblNbEquip = lblNbEquip.Tag & NbCoche
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // recherche de la liste des sites
        apiTGrid.LoadData(dtEquipement, MozartDatabase.cnxMozart, $"api_sp_TousEquipements {MozartParams.NumDi}");
        apiTGrid.GridControl.DataSource = dtEquipement;

        foreach (DataRow row in dtEquipement.Rows)
          row["CHECK"] = false;

        apiTGrid.AddColumn("NumObj", "NOBJNUM", 0);
        apiTGrid.AddColumn(Resources.col_Num, "Numéro", 1200);
        apiTGrid.AddColumn(Resources.col_famille, "Famille", 3500);
        apiTGrid.AddColumn(Resources.col_Num_serie, "N° Série", 1500);
        apiTGrid.AddColumn(Resources.col_Objet, "VOBJLIB", 5500, "", 0, true);

        apiTGrid.InitColumnList();

        apiTGrid.dgv.OptionsSelection.MultiSelect = true;
        apiTGrid.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGrid.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
        apiTGrid.dgv.OptionsSelection.CheckBoxSelectorField = "CHECK";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub InitApigrid()
    //Dim sFile As String
    //On Error GoTo handler
    //  
    //  Screen.MousePointer = vbHourglass
    // 
    //  ' recherche de la liste des sites
    //  Set rsEquipement = New ADODB.Recordset
    //  rsEquipement.Open "api_sp_TousEquipements " & giNumDi, cnx
    //  sFile = gstrCheminProgramme & "\mozart\ListeEquipement.tmp"
    //  On Error Resume Next
    //  Kill sFile
    //  rsEquipement.Save sFile
    //  rsEquipement.Close
    //  
    //  Set rsEquipement = New ADODB.Recordset
    //  rsEquipement.Open sFile, , adOpenKeyset, adLockOptimistic
    // 
    //  ' decocher tous
    //  While Not rsEquipement.EOF
    //    rsEquipement.Update "CHECK", 0
    //    rsEquipement.MoveNext
    //  Wend
    //  rsEquipement.MoveFirst
    //
    //  apiTGrid.AddColumn " ", "CHECK", 300, , , , , True
    //  apiTGrid.AddColumn "NumObj", "NOBJNUM", 0
    //  apiTGrid.AddColumn "§N°§", "Numéro", 1200
    //  apiTGrid.AddColumn "§Famille§", "Famille", 3500
    //  apiTGrid.AddColumn "§N° Série§", "[N° Série]", 1500
    //  apiTGrid.AddColumn "§Objet§", "VOBJLIB", 5500
    //  
    //  apiTGrid.AddCellTip "VOBJLIB", &HFDF0DA
    //  
    //  apiTGrid.Init rsEquipement
    //  
    //  Screen.MousePointer = vbDefault
    // 
    //  Exit Sub
    //  Resume
    //handler:
    //  ShowError "InitApiapiTGridH dans " & Me.Name
    //End Sub
    //

  }
}

