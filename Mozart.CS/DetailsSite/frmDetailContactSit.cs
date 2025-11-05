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
  public partial class frmDetailContactSit : Form
  {
    public frmDetailContactSit() { InitializeComponent(); }

    public int iNumContSit;
    public int iSitNum;
    public string mstrStatut;
    //Public iNumContSit As Long
    //Public iSitNum As Long
    //Public mstrStatut As String

    private void frmDetailContactSit_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        ModuleData.RemplirCombo(cboFonction, $"select NTYPCSITNUM, VTYPCSITLIB from TREF_TYPCSIT " +
                                      $"WHERE LANGUE = '{MozartParams.Langue}' ORDER BY VTYPCSITLIB");
        cboFonction.ValueMember = "NTYPCSITNUM";
        cboFonction.DisplayMember = "VTYPCSITLIB";

        cboFonction.SetItemData("");

        txtNom.Focus();

        if (mstrStatut != "C")
          OuvertureEnModification();
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
    //   InitBoutons Me, frmMenu
    //   
    //   Set adoDetCont = New ADODB.Recordset
    //   
    //   SizeCombo cboFonction, 600
    //   RemplirCombo cboFonction, "select NTYPCSITNUM, VTYPCSITLIB from TREF_TYPCSIT WHERE LANGUE = '" & gstrLangue & "' ORDER BY VTYPCSITLIB"
    //   
    //   If mstrStatut <> "C" Then OuvertureEnModification
    //   
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      iNumContSit = 0;
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  iNumContSit = 0
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void OuvertureEnModification()
    {
      using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT * FROM api_v_InfoContactSite WHERE NCSITNUM = {iNumContSit} AND LANGUE = '{MozartParams.Langue}'"))
      {
        if (sdr.Read())
        {
          txtNom.Text = Utils.BlankIfNull(sdr["VCSITNOM"]);
          txtprenom.Text = Utils.BlankIfNull(sdr["VCSITPRE"]);
          txtTel.Text = Utils.BlankIfNull(sdr["VCSITTEL"]);
          txtFax.Text = Utils.BlankIfNull(sdr["VCSITFAX"]);
          txtPort.Text = Utils.BlankIfNull(sdr["VCSITPOR"]);
          txtMail.Text = Utils.BlankIfNull(sdr["VCSITMAI"]);
          //combo du type de site
          cboFonction.SetItemData(Convert.ToString(sdr["NTYPCSITNUM"]));

          if ((int)sdr["NTYPCSITNUM"] == 1)
            cboFonction.Enabled = false;
          else
            cboFonction.Enabled = true;

          cboCiv.Text = Utils.BlankIfNull(sdr["VCSITCIV"]);
        }
      }
    }
    //Private Sub OuvertureEnModification()
    //
    //  If adoDetCont.state = adStateOpen Then adoDetCont.Close
    //
    //  adoDetCont.Open "SELECT * FROM api_v_InfoContactSite WHERE NCSITNUM = " & iNumContSit & " AND LANGUE = '" & gstrLangue & "'", cnx
    //  
    //  If adoDetCont.RecordCount > 0 Then
    //  
    //  txtNom.Text = BlankIfNull(adoDetCont("VCSITNOM"))
    //  txtprenom.Text = BlankIfNull(adoDetCont("VCSITPRE"))
    //  txtTel.Text = BlankIfNull(adoDetCont("VCSITTEL"))
    //  txtFax.Text = BlankIfNull(adoDetCont("VCSITFAX"))
    //  txtPort.Text = BlankIfNull(adoDetCont("VCSITPOR"))
    //  txtMail.Text = BlankIfNull(adoDetCont("VCSITMAI"))
    //  ' combo du type de site
    //  SelectLB cboFonction, ZeroIfNull(adoDetCont("NTYPCSITNUM"))
    //  
    //  If adoDetCont("NTYPCSITNUM") = 1 Then
    //    cboFonction.Enabled = False
    //  Else
    //    cboFonction.Enabled = True
    //  End If
    //
    //  On Error Resume Next
    //  cboCiv.Text = BlankIfNull(adoDetCont("VCSITCIV"))
    //  If Err Then cboCiv.Text = ""
    //  Err.Clear
    //  
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void Enregistrer()
    {
      try
      {
        //pour la création ou la modification, c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_creationContactSite", MozartDatabase.cnxMozart))
        {
          //création d'une commande
          //passage du nom de la procédure stockée
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          //passage des paramètres
          //liste des paramètres

          cmd.Parameters["@inumCsit"].Value = iNumContSit; //0 si création
          cmd.Parameters["@iSitNum"].Value = iSitNum;
          cmd.Parameters["@vNom"].Value = txtNom.Text;
          cmd.Parameters["@vPrenom"].Value = txtprenom.Text;
          cmd.Parameters["@vCiv"].Value = cboCiv.Text;
          cmd.Parameters["@nTypefonction"].Value = cboFonction.GetItemData();

          cmd.Parameters["@vTel"].Value = txtTel.Text;
          cmd.Parameters["@vFax"].Value = txtFax.Text;
          cmd.Parameters["@vPort"].Value = txtPort.Text;
          cmd.Parameters["@vMail"].Value = txtMail.Text;

          //exécuter la commande
          cmd.ExecuteNonQuery();

          //récupération du numéro crée
          iNumContSit = Convert.ToInt32(cmd.Parameters[0].Value);
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }
    //Private Sub Enregistrer()
    //
    //Dim cmd As New ADODB.Command
    //
    //On Error GoTo handler
    //
    //' pour la création ou la modification, c'est la proc stock qui gère
    //        
    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  cmd.CommandText = "api_sp_creationContactSite"
    //  cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ' cmd.Parameters.Refresh
    //  
    //   ' liste des paramètres
    //  cmd.Parameters("@inumCsit").value = iNumContSit   ' 0 si création
    //  cmd.Parameters("@iSitNum").value = iSitNum
    //  cmd.Parameters("@vNom").value = txtNom.Text
    //  cmd.Parameters("@vPrenom").value = txtprenom.Text
    //  cmd.Parameters("@vCiv").value = Me.cboCiv.Text
    //  cmd.Parameters("@nTypefonction").value = cboFonction.ItemData(cboFonction.ListIndex)
    //  
    //  cmd.Parameters("@vTel").value = txtTel.Text
    //  cmd.Parameters("@vFax").value = txtFax.Text
    //  cmd.Parameters("@vPort").value = txtPort.Text
    //  cmd.Parameters("@vMail").value = txtMail.Text
    //   
    //  ' exécuter la commande.
    //  cmd.Execute
    //  
    //  ' récupération du numéro crée
    //  iNumContSit = cmd.Parameters(0).value
    //    
    //  ' libération de la commande
    //  Set cmd = Nothing
    //  
    //Exit Sub
    //handler:
    //  If Err.Number <> 0 Then
    //    MsgBox "§Il existe déjà un §" & LCase(cboFonction.Text) & "§ pour ce site§"
    //    Err.Clear
    //  End If
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //  If adoDetCont.state = adStateOpen Then adoDetCont.Close
    //  Set adoDetCont = Nothing
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        //test de la fonction
        if (cboFonction.Text == "")
        {
          MessageBox.Show($"{Resources.msg_Selection_Fonction}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtMail.Text != "")
        {
          if (Strings.InStr(txtMail.Text, " ") > 0 || Strings.InStr(txtMail.Text, "@") == 0 || Strings.InStr(txtMail.Text, ".") == 0)
          {
            MessageBox.Show(Resources.msg_adresseCourrielInvalide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }

        //test s'il y a déjà un type de contact identique sur ce site en MODIF
        if (TestTypeContactSit() > 0 && cboFonction.GetItemData() == 1 && cboFonction.Enabled == true)
        {
          MessageBox.Show($"{Resources.msg_Existant} {cboFonction.Text.ToLower()} {Resources.msg_Pour_Site}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        Enregistrer();

        //on passe la feuille en statut modifier
        mstrStatut = "M";

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      }
    }
    //Private Sub cmdEnregistrer_Click()
    //
    //On Error GoTo handler
    //
    //  ' test du nom
    //'  If txtNom.Text = "" Then
    //'    MsgBox "§Saisissez un nom§"
    //'    txtNom.SetFocus
    //'    Exit Sub
    //'  End If
    //  
    //  ' test de la fonction
    //  If cboFonction.Text = "" Then
    //    MsgBox "§Sélectionnez une fonction§"
    //    Exit Sub
    //  End If
    //  
    //  If txtMail <> "" Then
    //    If InStr(txtMail, " ") > 0 Or InStr(txtMail, "@") = 0 Or InStr(txtMail, ".") = 0 Then
    //      MsgBox "§Adresse courriel invalide§", vbExclamation
    //      Exit Sub
    //    End If
    //  End If
    //  
    //  'test sil y a déjà un type de contact identique sur ce site en MODIF
    //  If TestTypeContactSit > 0 And cboFonction.ItemData(cboFonction.ListIndex) = 1 And cboFonction.Enabled = True Then
    //    MsgBox "§il existe déjà un §" & LCase(cboFonction.Text) & "§ pour ce site!§", vbExclamation
    //    Exit Sub
    //  End If
    //  
    //  Call Enregistrer
    //                     
    //  ' on passe la feuille en statut modifier
    //  Me.mstrStatut = "M"
    //   
    //  Call OuvertureEnModification
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private int TestTypeContactSit()
    {
      using (SqlDataReader sdr = ModuleData.ExecuteReader($"EXEC api_sp_TestTypeCSit {iSitNum}"))
      {
        if (sdr.Read())
        {
          return (int)sdr[0];
        }
        return 0;
      }
    }
    //Private Function TestTypeContactSit() As Byte
    //  
    //  Dim ado_Test As New ADODB.Recordset
    //  
    //  On Error GoTo handler
    //  
    //  ado_Test.Open "EXEC api_sp_TestTypeCSit " & iSitNum, cnx
    //  If ado_Test.RecordCount > 0 Then
    //    TestTypeContactSit = ado_Test(0)
    //    ado_Test.Close
    //  End If
    //  Set ado_Test = Nothing
    //
    //Exit Function
    //handler:
    //  ShowError "TestTypeContactSit dans " & Me.Name
    //End Function

  }
}

