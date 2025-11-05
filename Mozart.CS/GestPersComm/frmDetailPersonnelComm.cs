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
  public partial class frmDetailPersonnelComm : Form
  {
    //Public mstrStatut As String
    //Public miNumPer As Long
    public string mstrStatut;
    public int miNumPer;

    //Private mstrCurDateCtrl As Control
    //Dim bPrem As Boolean
    bool bPrem = true;

    public frmDetailPersonnelComm() { InitializeComponent(); }

    private void frmDetailPersonnelComm_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        ModuleData.RemplirCombo(cboService, "select NSERNUM, VSERLIB from TSER ORDER BY VSERLIB");
        cboService.ValueMember = "NSERNUM";
        cboService.DisplayMember = "VSERLIB";
        ModuleData.RemplirCombo(cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";
        ModuleData.RemplirCombo(cboType, "select ID, VTYPELIB from TREF_TYPEPER");
        cboType.ValueMember = "ID";
        cboType.DisplayMember = "VTYPELIB";

        OuvertureEnModification();
        bPrem = false;
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

    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //On Error GoTo handler
    //  
    //  InitBoutons Me, frmMenu
    //  bPrem = True
    //
    //  RemplirCombo cboService, "select NSERNUM, VSERLIB from TSER ORDER BY VSERLIB"
    //  RemplirCombo cboPays, "select NPAYSNUM, VPAYSNOM from TPAYS order by VPAYSNOM"
    //  RemplirCombo cboType, "select ID, VTYPELIB from TREF_TYPEPER"
    //     
    //  OuvertureEnModification
    //  bPrem = False
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdCarte_Click(object sender, EventArgs e)
    {
      new frmBrowser
      {
        msStartingAddress = $"https://maps.emalec.com/SiteParAdresse.asp?NOM={txtNom.Text}&AD1={txtAD1.Text}&VILLE={txtCP.Text} {cboVille.Text}&PAYS={cboPays.Text}"
      }.ShowDialog();
    }
    //Private Sub cmdCarte_Click()
    //On Error GoTo handler
    //
    // 
    //  Screen.MousePointer = vbHourglass
    //  
    //  ' Modif VL 02/01/2008
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/SiteParAdresse.asp?NOM=" & txtNom & "&AD1=" & txtAD1 & "&VILLE=" & txtCP & " " & cboVille.Text & "&PAYS=" & cboPays.Text
    //  frmBrowser.Show vbModal
    //  ' Modif VL 02/01/2008
    //  
    //  Screen.MousePointer = vbDefault
    //   
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      //  Champs obligatoires
      if (txtNom.Text == "")
      {
        MessageBox.Show("Saisissez le nom de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtNom.Focus(); return;
      }
      if (txtprenom.Text == "")
      {
        MessageBox.Show("Saisissez le prénom de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtprenom.Focus(); return;
      }
      if (cboCiv.Text == "")
      {
        MessageBox.Show("Saisissez la civilité de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboCiv.Focus(); return;
      }
      if (cboRegion.Text == "")
      {
        MessageBox.Show("Saisissez la région de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboRegion.Focus(); return;
      }
      if (cboService.Text == "")
      {
        MessageBox.Show("Saisissez le service de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboService.Focus(); return;
      }
      if (cboType.Text == "")
      {
        MessageBox.Show("Saisissez le type de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboType.Focus(); return;
      }
      if (txtDateEntree.Text == "")
      {
        MessageBox.Show("Saisissez la date d'entrée", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtDateEntree.Focus(); return;
      }
      if (cboPays.Text == "")
      {
        MessageBox.Show("Saisissez le pays de la personne", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboPays.Focus(); return;
      }
      //  Champs date
      DateTime d;
      if (!DateTime.TryParse(txtDateNaissance.Text, out d))
      {
        MessageBox.Show("Date invalide", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtDateNaissance.Focus(); return;
      }
      if (!DateTime.TryParse(txtDateEntree.Text, out d))
      {
        MessageBox.Show("Date invalide", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtDateEntree.Focus(); return;
      }
      if (!DateTime.TryParse(txtDateSortie.Text, out d))
      {
        MessageBox.Show("Date invalide", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtDateSortie.Focus(); return;
      }

      Enregistrer();
      mstrStatut = "M";
      OuvertureEnModification();
    }
    //Private Sub cmdEnregistrer_Click()
    //
    //On Error GoTo handler
    //
    //  ' Champs obligatoires
    //  If txtNom.Text = "" Then MsgBox "Saisissez le nom de la personne":         txtNom.SetFocus:        Exit Sub
    //  If txtprenom.Text = "" Then MsgBox "Saisissez le prénom de la personne":   txtprenom.SetFocus:     Exit Sub
    //  If cboCiv.Text = "" Then MsgBox "Saisissez la civilité de la personne":    cboCiv.SetFocus:        Exit Sub
    //  If cboRegion.Text = "" Then MsgBox "Saisissez la région de la personne":   cboRegion.SetFocus:     Exit Sub
    //  If cboService.Text = "" Then MsgBox "Saisissez le service de la personne": cboService.SetFocus:    Exit Sub
    //  If cboType.Text = "" Then MsgBox "Saisissez le type de la personne":       cboType.SetFocus:       Exit Sub
    //  If txtDateEntree.Text = "" Then MsgBox "Saisissez la date d'entrée ":      txtDateEntree.SetFocus: Exit Sub
    //  If cboPays.Text = "" Then MsgBox "Saisissez le pays de la personne ":   cboPays.SetFocus: Exit Sub
    //  
    //  ' Champs date
    //  If txtDateNaissance <> "" And Not IsDate(txtDateNaissance) Then MsgBox "Date invalide": txtDateNaissance.SetFocus: Exit Sub
    //  If txtDateEntree <> "" And Not IsDate(txtDateEntree) Then MsgBox "Date invalide": txtDateEntree.SetFocus: Exit Sub
    //  If txtDateSortie <> "" And Not IsDate(txtDateSortie) Then MsgBox "Date invalide": txtDateSortie.SetFocus: Exit Sub
    //  
    //  Call Enregistrer
    //                     
    //  ' on passe la feuille en statut modifier
    //  Me.mstrStatut = "M"
    //  Call OuvertureEnModification
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal
      {
        ControlCible1 = txtCP,
        ControlCible2 = cboVille
      }.ShowDialog();
    }
    //Private Sub cmdRecherche_Click()
    //  Set frmRechCodePostal.ControlCible1 = txtCP
    //  Set frmRechCodePostal.ControlCible2 = cboVille
    //  frmRechCodePostal.Show vbModal
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void OuvertureEnModification()
    {
      // recherche des informations de l'action
      using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_InfoPersonnelComm {miNumPer}"))
      {
        if (reader.Read())
        {
          txtNom.Text = Utils.BlankIfNull(reader["VPERNOM"]);
          txtprenom.Text = Utils.BlankIfNull(reader["VPERPRE"]);
          cboCiv.Text = Utils.BlankIfNull(reader["CPERCIV"]).Trim();

          txtAD1.Text = Utils.BlankIfNull(reader["VPERAD1"]);
          txtAD2.Text = Utils.BlankIfNull(reader["VPERAD2"]);
          txtCP.Text = Utils.BlankIfNull(reader["VPERCP"]);
          txtVille.Text = Utils.BlankIfNull(reader["VPERVIL"]);

          cboService.Text = Utils.BlankIfNull(reader["VSERLIB"]);
          txtDateEntree.Text = ValToDate(Utils.BlankIfNull(reader["DPERENT"]));
          txtDateSortie.Text = ValToDate(Utils.BlankIfNull(reader["DPERSOR"]));
          txtDateNaissance.Text = ValToDate(Utils.BlankIfNull(reader["DPERNAI"]));
          txtAnciennete.Text = Utils.BlankIfNull(reader["ANC"]);
          txtAge.Text = Utils.BlankIfNull(reader["Age"]);

          //  type de personnel
          cboType.SelectedValue = Utils.BlankIfNull(reader["ID"]);

          if (-1 == cboVille.FindStringExact(Utils.BlankIfNull(reader["VPERVIL"]))) cboVille.Items.Add(Utils.BlankIfNull(reader["VPERVIL"]));
          cboVille.Text = Utils.BlankIfNull(reader["VPERVIL"]);
          if (-1 == cboPays.FindStringExact(Utils.BlankIfNull(reader["VPERPAYS"]))) cboPays.Items.Add(Utils.BlankIfNull(reader["VPERPAYS"]));
          cboPays.Text = Utils.BlankIfNull(reader["VPERPAYS"]);
          try
          {
            ModuleData.RemplirCombo(cboRegion, $"select NREGCOD, VDEPLIB from TREF_REG where npaysnum = '{cboPays.SelectedValue}' order by VDEPLIB", true);
            cboRegion.ValueMember = "NREGCOD";
            cboRegion.DisplayMember = "VDEPLIB";
            cboRegion.SelectedValue = Utils.BlankIfNull(reader["NREGCOD"]);
          }
          catch (Exception) { }
        }
      }
    }
    private string ValToDate(string val)
    {
      int index = val.IndexOf(' ');
      if (-1 == index) return val;
      return val.Substring(0, index);
    }
    //Private Sub OuvertureEnModification()
    //
    //On Error GoTo handler
    //  
    //  ' 'recherche des informations de l'action
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "exec api_sp_InfoPersonnelComm " & miNumPer, cnx
    //
    //  txtNom = BlankIfNull(pRS("VPERNOM"))
    //  txtprenom = BlankIfNull(pRS("VPERPRE"))
    //  cboCiv = Trim(BlankIfNull(pRS("CPERCIV")))
    //  
    //  txtAD1 = BlankIfNull(pRS("VPERAD1"))
    //  txtAD2 = BlankIfNull(pRS("VPERAD2"))
    //  txtCP = BlankIfNull(pRS("VPERCP"))
    //  txtVille = BlankIfNull(pRS("VPERVIL"))
    //  
    //  cboService.Text = pRS("VSERLIB")
    //  txtDateEntree = BlankIfNull(pRS("DPERENT"))
    //  txtDateSortie = BlankIfNull(pRS("DPERSOR"))
    //  txtDateNaissance = BlankIfNull(pRS("DPERNAI"))
    //  txtAnciennete = BlankIfNull(pRS("ANC"))
    //  txtAge = BlankIfNull(pRS("Age"))
    //  
    //  ' type de personnel
    //  SelectLB cboType, pRS("ID")
    //  
    //On Error Resume Next
    //
    //  cboVille.Text = pRS("VPERVIL")      ' combo de la ville
    //  If Err Then
    //    cboVille.AddItem pRS("VPERVIL")
    //    cboVille.Text = pRS("VPERVIL")
    //  End If
    //  Err.Clear
    //  
    //  cboPays.Text = pRS("VPERPAYS")      ' combo du pays
    //  If Err Then
    //    cboPays.AddItem pRS("VPERPAYS")
    //    cboPays.Text = pRS("VPERPAYS")
    //  End If
    //  Err.Clear
    //  
    //On Error GoTo handler
    //  
    //  RemplirCombo cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " & cboPays.ItemData(cboPays.ListIndex) & " order by VDEPLIB", , True
    //  SelectLB cboRegion, pRS("NREGCOD")
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void Enregistrer()
    {
      //  Création ou la modification, c'est la proc stock qui gère
      //  création d'une commande
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationPersonnelComm", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);
          cmd.Parameters["@iNum"].Value = miNumPer;//   0 si création;
          cmd.Parameters["@vNom"].Value = txtNom.Text;
          cmd.Parameters["@vPrenom"].Value = txtprenom.Text;
          cmd.Parameters["@vCiv"].Value = cboCiv.Text;

          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;

          cmd.Parameters["@vType"].Value = cboType.SelectedValue;
          cmd.Parameters["@nService"].Value = cboService.SelectedValue;
          cmd.Parameters["@nRegion"].Value = cboRegion.SelectedValue;

          cmd.Parameters["@dEntree"].Value = txtDateEntree.Text;// Champ obligatoire

          // Champs dates
          if (txtDateNaissance.Text != "") cmd.Parameters["@dNaissance"].Value = txtDateNaissance.Text;
          if (txtDateSortie.Text != "") cmd.Parameters["@dSortie"].Value = txtDateSortie.Text;

          cmd.ExecuteNonQuery();
          miNumPer = (int)Utils.ZeroIfNull(cmd.Parameters[0].Value);//    ' récupération du numéro crée
        }
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
    //Public Sub Enregistrer()
    //
    //Dim cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  ' Création ou la modification, c'est la proc stock qui gère
    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx
    //  
    //  cmd.CommandText = "api_sp_CreationPersonnelComm"
    //  cmd.CommandType = adCmdStoredProc
    //  'cmd.Parameters.Refresh
    //  
    //  cmd.Parameters("@iNum").value = miNumPer   ' 0 si création
    //  cmd.Parameters("@vNom").value = txtNom
    //  cmd.Parameters("@vPrenom").value = txtprenom
    //  cmd.Parameters("@vCiv").value = cboCiv.Text
    // 
    //  cmd.Parameters("@vAd1").value = txtAD1
    //  cmd.Parameters("@vAd2").value = txtAD2
    //  cmd.Parameters("@vCp").value = txtCP
    //  cmd.Parameters("@vVille").value = IIf(cboPays.Text = "FRANCE", cboVille.Text, txtVille.Text)
    //  cmd.Parameters("@vPays").value = Me.cboPays.Text
    //  
    //  cmd.Parameters("@vType").value = cboType.ItemData(cboType.ListIndex)
    //  cmd.Parameters("@nService").value = cboService.ItemData(cboService.ListIndex)   'Code service
    //  cmd.Parameters("@nRegion").value = cboRegion.ItemData(cboRegion.ListIndex)     ' Code région
    //  
    //  cmd.Parameters("@dEntree").value = txtDateEntree  ' Champ obligatoire
    //  
    //  ' Champs dates
    //  If txtDateNaissance <> "" Then cmd.Parameters("@dNaissance").value = txtDateNaissance
    //  If txtDateSortie <> "" Then cmd.Parameters("@dSortie").value = txtDateSortie
    //  
    //  Set ado_rs = cmd.Execute()
    //  
    //  miNumPer = cmd.Parameters(0).value    ' récupération du numéro crée
    //  
    //  Set cmd = Nothing
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "EnregistrerAction dans " & Me.Name
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      string sDep;

      if ((txtCP.Text.Length == 5) && (cboPays.Text == "FRANCE"))
      {
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);

        sDep = txtCP.Text.Substring(0, 2);
        cboRegion.SelectedValue = Convert.ToInt32(sDep);
      }
    }
    //Private Sub txtCP_Change()
    //Dim sDep As String
    //
    //    If Len(txtCP) = 5 And cboPays = "FRANCE" Then
    //        RechercheCommune txtCP.Text, cboVille
    //        
    //        sDep = Left(txtCP, 2)
    //        SelectLB cboRegion, val(sDep)
    //    End If
    //End Sub

    // FGB - 01/02/2022 : Remplacé par ModuleMain.RechercheCommune
    /* --------------------------------------------------------------------------------------- */
    //Private Sub RechercheCommune(strCp As String, cbo As ComboBox)
    //  Static rs As New ADODB.Recordset
    //  cbo.Clear
    //  rs.Open "select Ville from TCOMMUNE WHERE CodePostal like '" & strCp & "%'", cnx
    //  
    //  ' dans le cas d'un cedex avec code postal spécial, on recherche les communes du département
    //  If rs.EOF Then
    //    rs.Close
    //    rs.Open "select Ville from TCOMMUNE WHERE CodePostal like '" & Left(strCp, 2) & "%'", cnx
    //  End If
    //  While Not rs.EOF
    //    cbo.AddItem rs!ville
    //    rs.MoveNext
    //  Wend
    //  If rs.RecordCount > 0 Then cbo.ListIndex = 0
    //  rs.Close
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtVille.Visible = !(cboPays.Text == "FRANCE");
      cmdRecherche.Visible = cboVille.Visible = !txtVille.Visible;
      if (bPrem) return;
      ModuleData.RemplirCombo(cboRegion, $"select NREGCOD, VDEPLIB from TREF_REG where npaysnum = '{cboPays.SelectedValue}' order by VDEPLIB", true);
      cboRegion.ValueMember = "NREGCOD";
      cboRegion.DisplayMember = "VDEPLIB";

      if (cboPays.Text == "FRANCE" && txtCP.Text.Length == 5) cboRegion.SelectedValue = txtCP.Text.Substring(0, 2);
    }
    //Private Sub cboPays_Click()
    //  If cboPays.Text <> "FRANCE" Then
    //    cboVille.Visible = False
    //    txtVille.Visible = True
    //    cmdRecherche.Visible = False
    //  Else
    //    cboVille.Visible = True
    //    txtVille.Visible = False
    //    cmdRecherche.Visible = True
    //  End If
    //  
    //  If Not bPrem Then RemplirCombo cboRegion, "select NREGCOD, VDEPLIB from TREF_REG where npaysnum = " & cboPays.ItemData(cboPays.ListIndex) & " order by VDEPLIB", , True
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void txtNom_Leave(object sender, EventArgs e)
    {
      txtNom.Text = txtNom.Text.ToUpper();
    }
    //Private Sub txtNom_LostFocus()
    //  txtNom = Majuscule(txtNom)
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void cmdDateSupp_Click(object sender, EventArgs e)
    {
      switch ((sender as Button).Name)
      {
        case "cmdSupp22": txtDateNaissance.Text = ""; break;
        case "cmdSupp20": txtDateEntree.Text = ""; break;
        case "cmdSupp21": txtDateSortie.Text = ""; break;
      }
    }
    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      string txtDate = "";
      switch ((sender as Button).Name)
      {
        case "cmdDate22": txtDate = txtDateNaissance.Text; Calendar1.Tag = (sender as Button).Name; break;
        case "cmdDate20": txtDate = txtDateEntree.Text; Calendar1.Tag = (sender as Button).Name; break;
        case "cmdDate21": txtDate = txtDateSortie.Text; Calendar1.Tag = (sender as Button).Name; break;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      switch (Calendar1.Tag)
      {
        case "cmdDate22": txtDateNaissance.Text = Calendar1.Value.ToShortDateString(); break;
        case "cmdDate20": txtDateEntree.Text = Calendar1.Value.ToShortDateString(); break;
        case "cmdDate21": txtDateSortie.Text = Calendar1.Value.ToShortDateString(); break;
      }
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }
    //Private Sub txtVille_lostfocus()
    //  txtVille = Majuscule(txtVille)
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdDate2_Click(Index As Integer)
    //  
    //  Select Case Index
    //    Case 0:    Set mstrCurDateCtrl = txtDateEntree
    //    Case 1:    Set mstrCurDateCtrl = txtDateSortie
    //    Case 2:    Set mstrCurDateCtrl = txtDateNaissance
    //  End Select
    //  
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    If mstrCurDateCtrl <> "" Then
    //      Calendar1.value = mstrCurDateCtrl
    //    Else
    //      Calendar1.value = Now
    //    End If
    //  End If
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    //Private Sub cmdSupp2_Click(Index As Integer)
    //  Select Case Index
    //    Case 0:      txtDateEntree = ""
    //    Case 1:      txtDateSortie = ""
    //    Case 2:      txtDateNaissance = ""
    //  End Select
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Calendar1_Click()
    //  On Error GoTo handler
    //  mstrCurDateCtrl.Text = Calendar1.value
    //  Calendar1.Visible = False
    //  Exit Sub
    //handler:
    //  ShowError "Calendar1_Click dans " & Me.Name
    //End Sub
  }
}