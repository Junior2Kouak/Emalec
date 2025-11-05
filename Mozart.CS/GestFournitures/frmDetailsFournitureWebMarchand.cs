using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailsFournitureWebMarchand : Form
  {
    public int miNumFour;

    double m_pAchat = 0;

    public frmDetailsFournitureWebMarchand()
    {
      InitializeComponent();
    }

    private void frmDetailsFournitureWebMarchand_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        OuvertureEnModification();
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //  Option Explicit
    //
    //Dim adoRS As ADODB.Recordset
    //Dim pAchat As Double
    //
    //Private Sub Form_Load()
    //
    //On Error GoTo Handler
    //
    //    InitBoutons Me, frmMenu
    //    
    //    pAchat = 0
    //    
    //    OuvertureEnModification
    //
    //
    //Exit Sub
    //Handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      //'forcer le calcul du TTC
      txtPVTTC_Leave(null, null);

      if (txtPVTTC.Text == "" || txtPVTTC.Text == "0")
      {
        MessageBox.Show("Vous devez saisir un prix unitaire!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      Enregistrer();

      cmdFermer_Click(null, null);
    }
    //Private Sub cmdEnregistrer_Click()
    // 
    //On Error GoTo Handler
    //  
    //  
    //  If BlankIfNull(txtPVTTC) = "" Then
    //    MsgBox ("Vous devez saisir un prix unitaire!")
    //    Exit Sub
    //  End If
    //  
    //  'forcer le calcul du TTC
    //  Call txtPVTTC_LostFocus
    //  
    //  Call Enregistrer
    //
    //  Unload Me
    //
    //Exit Sub
    //Handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub
    //
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //
    //

    private void OuvertureEnModification()
    {
      txtRefInterne.Text = miNumFour.ToString();

      cboFamWeb.Init(MozartDatabase.cnxMozart, "select NIDFAMILLE, VLIBFAMILLE from TBRICOREFFAMILLE ORDER BY VLIBFAMILLE",
                      "NIDFAMILLE", "VLIBFAMILLE", new List<string>() { "", Resources.col_Nom }, 200, 400, true);

      //'recherche des informatiopn de l'action
      string sql = $"select TBRICOFOU.NIDSSFAMILLE,TBRICOFOU.NIDSSFAMILLE2, ISNULL(TBRICOFOU.CACTIF,'N') CACTIF,TBRICOFOU.VDESCRIPTION, TBRICOFOU.NPV, NIDFAMILLE, VLIBWEB, NCOND, " +
                   $" convert(decimal(9,4),(SELECT AVG(FPUHT/FPUNITE) FROM TSTFFOU WITH(NOLOCK) WHERE NFOUNUM = tbricofou.NFOUNUM AND ISNULL(FPUHT,0) >0 )) AS PRIXACHAT," +
                   $" CASE WHEN ISNULL(TBRICOFOU.NPV,0) <> 0 THEN convert(decimal(9,4),TBRICOFOU.NPV/(SELECT AVG(FPUHT/FPUNITE) FROM TSTFFOU WITH(NOLOCK) WHERE NFOUNUM = tbricofou.NFOUNUM AND ISNULL(FPUHT,0) >0 )) END AS COEF, " +
                   $" CEXPORT, CEXPORTDATA, convert(varchar(10), dexport, 103) + ' ' + convert(varchar(8), dexport, 108) AS DEXPORT, VDESC, " +
                   $" VMETAMC, VMETADESC, VEAN" +
                   $" FROM TBRICOFOU WITH (NOLOCK) LEFT OUTER JOIN " +
                   $" TBRICOREFSSFAMILLE WITH (NOLOCK) ON TBRICOREFSSFAMILLE.NIDSSFAMILLE = TBRICOFOU.NIDSSFAMILLE " +
                   $" WHERE TBRICOFOU.NFOUNUM = {miNumFour}";

      using (SqlDataReader reader = ModuleData.ExecuteReader(sql))
      {
        if (reader.Read())
        {
          //      chkActifWeb = IIf(pRS!cActif = "O", 1, 0)
          chkActifWeb.Checked = Utils.BlankIfNull(reader["CACTIF"]) == "O" ? true : false;
          //      SelectLB cboFamWeb, ZeroIfNull(pRS!NIDFAMILLE)
          cboFamWeb.SetItemData((int)Utils.ZeroIfNull(reader["NIDFAMILLE"]));
          //      SelectLB cboSsFamWeb, ZeroIfNull(pRS!NIDSSFAMILLE)
          cboSsFamWeb.SetItemData((int)Utils.ZeroIfNull(reader["NIDSSFAMILLE"]));
          //      SelectLB cboSsFamWeb2, ZeroIfNull(pRS!NIDSSFAMILLE2)
          cboSsFamWeb2.SetItemData((int)Utils.ZeroIfNull(reader["NIDSSFAMILLE2"]));
          //      txtPVTTC = BlankIfNull(pRS!NPV)
          txtPVTTC.Text = Utils.BlankIfNull(reader["NPV"]);
          //      pAchat = ZeroIfNull(pRS!PRIXACHAT)
          m_pAchat = Utils.ZeroIfNull(reader["PRIXACHAT"]);
          //      txtDescWeb = BlankIfNull(pRS!VDESCRIPTION)
          txtDescWeb.Text = Utils.BlankIfNull(reader["VDESCRIPTION"]);
          //      txtLibelle = BlankIfNull(pRS!VLIBWEB)
          txtLibelle.Text = Utils.BlankIfNull(reader["VLIBWEB"]);
          //      txtCond = BlankIfNull(pRS!NCOND)
          txtCond.Text = Utils.BlankIfNull(reader["NCOND"]);
          //      chkExport = IIf(pRS!cExport = "O", 1, 0)
          chkExport.Checked = Utils.BlankIfNull(reader["CEXPORT"]) == "O" ? true : false;
          //      chkExportData = IIf(pRS!cExportData = "O", 1, 0)
          chkExportData.Checked = Utils.BlankIfNull(reader["CEXPORTDATA"]) == "O" ? true : false;
          //      lblExport = lblExport + BlankIfNull(pRS!DEXPORT)
          lblExport.Text += Utils.BlankIfNull(reader["DEXPORT"]);
          //      txtDesc = BlankIfNull(pRS!VDESC)
          txtDesc.Text = Utils.BlankIfNull(reader["VDESC"]);
          //      txtMetaMC = BlankIfNull(pRS!VMETAMC)
          txtMetaMC.Text = Utils.BlankIfNull(reader["VMETAMC"]);
          //      txtMetaDesc = BlankIfNull(pRS!VMETADESC)
          txtMetaDesc.Text = Utils.BlankIfNull(reader["VMETADESC"]);
          //      txtEAN = BlankIfNull(pRS!VEAN)
          txtEAN.Text = Utils.BlankIfNull(reader["VEAN"]);
        }
        if (txtPVTTC.Text != "0" && m_pAchat != 0)
        {
          double pvht = Convert.ToDouble(txtPVTTC.Text) / 1.2;
          txtPVHT.Text = pvht.ToString("#####.####");
          txtcoef.Text = (pvht / m_pAchat).ToString("#####.####");
        }
      }
    }
    //Private Sub OuvertureEnModification()
    // 
    //Dim pRS As ADODB.Recordset
    //
    //On Error GoTo Handler
    //
    //  cboFamWeb.Clear
    //  RemplirCombo cboFamWeb, "select NIDFAMILLE, VLIBFAMILLE from TBRICOREFFAMILLE ORDER BY VLIBFAMILLE"
    //  
    //  ' 'recherche des informatiopn de l'action
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "select TBRICOFOU.NIDSSFAMILLE,TBRICOFOU.NIDSSFAMILLE2, ISNULL(TBRICOFOU.CACTIF,'N') CACTIF,TBRICOFOU.VDESCRIPTION, TBRICOFOU.NPV, NIDFAMILLE, VLIBWEB, NCOND, " _
    //        & " convert(decimal(9,4),(SELECT AVG(FPUHT/FPUNITE) FROM TSTFFOU WITH(NOLOCK) WHERE NFOUNUM = tbricofou.NFOUNUM AND ISNULL(FPUHT,0) >0 )) AS PRIXACHAT," _
    //        & " CASE WHEN ISNULL(TBRICOFOU.NPV,0) <> 0 THEN convert(decimal(9,4),TBRICOFOU.NPV/(SELECT AVG(FPUHT/FPUNITE) FROM TSTFFOU WITH(NOLOCK) WHERE NFOUNUM = tbricofou.NFOUNUM AND ISNULL(FPUHT,0) >0 )) END AS COEF, " _
    //        & " CEXPORT, CEXPORTDATA, convert(varchar(10), dexport, 103) + ' ' + convert(varchar(8), dexport, 108) AS DEXPORT, VDESC, " _
    //        & " VMETAMC, VMETADESC, VEAN" _
    //        & " FROM TBRICOFOU WITH (NOLOCK) LEFT OUTER JOIN " _
    //        & " TBRICOREFSSFAMILLE WITH (NOLOCK) ON TBRICOREFSSFAMILLE.NIDSSFAMILLE = TBRICOFOU.NIDSSFAMILLE " _
    //        & " WHERE TBRICOFOU.NFOUNUM = " & frmDetailsFourniture.miNumFour, cnx
    //  
    //  txtRefInterne = frmDetailsFourniture.miNumFour
    //    
    //    If Not pRS.EOF Then
    //      ' gestion web marchand
    //      chkActifWeb = IIf(pRS!cActif = "O", 1, 0)
    //      SelectLB cboFamWeb, ZeroIfNull(pRS!NIDFAMILLE)
    //      SelectLB cboSsFamWeb, ZeroIfNull(pRS!NIDSSFAMILLE)
    //      SelectLB cboSsFamWeb2, ZeroIfNull(pRS!NIDSSFAMILLE2)
    //      
    //      txtPVTTC = BlankIfNull(pRS!NPV)
    //      pAchat = ZeroIfNull(pRS!PRIXACHAT)
    //      txtDescWeb = BlankIfNull(pRS!VDESCRIPTION)
    //      txtLibelle = BlankIfNull(pRS!VLIBWEB)
    //      txtCond = BlankIfNull(pRS!NCOND)
    //      chkExport = IIf(pRS!cExport = "O", 1, 0)
    //      chkExportData = IIf(pRS!cExportData = "O", 1, 0)
    //      lblExport = lblExport + BlankIfNull(pRS!DEXPORT)
    //      txtDesc = BlankIfNull(pRS!VDESC)
    //      txtMetaMC = BlankIfNull(pRS!VMETAMC)
    //      txtMetaDesc = BlankIfNull(pRS!VMETADESC)
    //      txtEAN = BlankIfNull(pRS!VEAN)
    //    Else
    //      ' gestion web marchand
    //      chkActifWeb = 0
    //      txtPVTTC = ""
    //      txtDescWeb = ""
    //      txtLibelle = ""
    //      chkExport = 0
    //      chkExportData = 0
    //      lblExport = ""
    //      txtDesc = ""
    //      txtMetaMC = ""
    //      txtMetaDesc = ""
    //      txtEAN = ""
    //    End If
    //    
    //    If Not ZeroIfNull(txtPVTTC) = 0 And Not pAchat = 0 Then
    //        txtPVHT = Format(CStr(CDbl(txtPVTTC) / 1.2), "#####.####")
    //        txtcoef = Format(CStr(CDbl(txtPVHT) / pAchat), "#####.####")
    //    End If
    //    
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub
    //

    private void Enregistrer()
    {
      using (SqlCommand cmd = new SqlCommand("api_sp_creationBricoFou", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

        //  liste des paramètres
        //cmd.Parameters["@"].Value = ;
        //  ado_cmd.Parameters("@iNumFou").Value = frmDetailsFourniture.miNumFour
        cmd.Parameters["@iNumFou"].Value = miNumFour;
        //  ado_cmd.Parameters("@cActif").Value = IIf(chkActifWeb.Value = 1, "O", "N")
        cmd.Parameters["@cActif"].Value = chkActifWeb.Checked ? "O" : "N";
        //  ado_cmd.Parameters("@iSsFamille").Value = cboSsFamWeb.ItemData(cboSsFamWeb.ListIndex)
        cmd.Parameters["@iSsFamille"].Value = cboSsFamWeb.GetItemData();
        //  ado_cmd.Parameters("@desc").Value = txtDescWeb 'Replace(txtDescWeb, "'", "''")
        cmd.Parameters["@desc"].Value = txtDescWeb.Text;
        //  ado_cmd.Parameters("@pv").Value = txtPVTTC
        cmd.Parameters["@pv"].Value = txtPVTTC.Text;
        //  ado_cmd.Parameters("@vlib").Value = BlankIfNull(txtLibelle.Text)
        cmd.Parameters["@vlib"].Value = txtLibelle.Text;
        //  ado_cmd.Parameters("@cond").Value = IIf(ZeroIfNull(txtCond) = 0, 1, txtCond)
        cmd.Parameters["@cond"].Value = txtCond.Text;
        //  ado_cmd.Parameters("@cExport").Value = IIf(chkExport.Value = 1, "O", "N")
        cmd.Parameters["@cExport"].Value = chkExport.Checked ? "O" : "N";
        //  ado_cmd.Parameters("@cExportData").Value = IIf(chkExportData.Value = 1, "O", "N")
        cmd.Parameters["@cExportData"].Value = chkExportData.Checked ? "O" : "N";
        //  ado_cmd.Parameters("@vDesc").Value = BlankIfNull(txtDesc.Text)
        cmd.Parameters["@vDesc"].Value = txtDesc.Text;
        //  ado_cmd.Parameters("@vMetaMC").Value = BlankIfNull(txtMetaMC.Text)
        cmd.Parameters["@vMetaMC"].Value = txtMetaMC.Text;
        //  ado_cmd.Parameters("@vMetaDesc").Value = BlankIfNull(txtMetaDesc.Text)
        cmd.Parameters["@vMetaDesc"].Value = txtMetaDesc.Text;
        //  ado_cmd.Parameters("@vEan").Value = BlankIfNull(txtEAN.Text)
        cmd.Parameters["@vEan"].Value = txtEAN.Text;
        //  ado_cmd.Parameters("@iSsFamille2").Value = ZeroIfNull(cboSsFamWeb2.ItemData(cboSsFamWeb2.ListIndex))
        cmd.Parameters["@iSsFamille2"].Value = cboSsFamWeb2.GetItemData();

        cmd.ExecuteNonQuery();
      }
    }
    //Public Sub Enregistrer()
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //Dim sIntervenant As String
    //
    //On Error GoTo Handler
    //
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_creationBricoFou"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //  
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iNumFou").Value = frmDetailsFourniture.miNumFour
    //  ado_cmd.Parameters("@cActif").Value = IIf(chkActifWeb.Value = 1, "O", "N")
    //  ado_cmd.Parameters("@iSsFamille").Value = cboSsFamWeb.ItemData(cboSsFamWeb.ListIndex)
    //  ado_cmd.Parameters("@desc").Value = txtDescWeb 'Replace(txtDescWeb, "'", "''")
    //  ado_cmd.Parameters("@pv").Value = txtPVTTC
    //  'Replace(ZeroIfNull(txtPV), ",", ".")
    //  ado_cmd.Parameters("@vlib").Value = BlankIfNull(txtLibelle.Text)
    //  ado_cmd.Parameters("@cond").Value = IIf(ZeroIfNull(txtCond) = 0, 1, txtCond)
    //  ado_cmd.Parameters("@cExport").Value = IIf(chkExport.Value = 1, "O", "N")
    //  ado_cmd.Parameters("@cExportData").Value = IIf(chkExportData.Value = 1, "O", "N")
    //  ado_cmd.Parameters("@vDesc").Value = BlankIfNull(txtDesc.Text)
    //  ado_cmd.Parameters("@vMetaMC").Value = BlankIfNull(txtMetaMC.Text)
    //  ado_cmd.Parameters("@vMetaDesc").Value = BlankIfNull(txtMetaDesc.Text)
    //  ado_cmd.Parameters("@vEan").Value = BlankIfNull(txtEAN.Text)
    //  ado_cmd.Parameters("@iSsFamille2").Value = ZeroIfNull(cboSsFamWeb2.ItemData(cboSsFamWeb2.ListIndex))
    //  
    //  ' exécuter la commande.
    //  Set ado_rs = ado_cmd.Execute()
    //     
    //  ' libération de la commande
    //  Set ado_cmd = Nothing
    //  
    //Exit Sub
    //Handler:
    //  ShowError "EnregistrerAction dans " & Me.Name
    //End Sub
    //

    private void cboFamWeb_TxtChanged(object sender, EventArgs e)
    {
      int code = cboFamWeb.GetItemData();
      if (-1 == code)
        return;
      cboSsFamWeb.Init(MozartDatabase.cnxMozart, $"select NIDSSFAMILLE, VLIBSSFAMILLE from TBRICOREFSSFAMILLE WHERE NIDFAMILLE = {code} ORDER BY VLIBSSFAMILLE",
                       "NIDSSFAMILLE", "VLIBSSFAMILLE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
    }
    //Private Sub cboFamWeb_Click()
    //  cboSsFamWeb.Clear
    //  RemplirCombo cboSsFamWeb, "select NIDSSFAMILLE, VLIBSSFAMILLE from TBRICOREFSSFAMILLE WHERE NIDFAMILLE = " & cboFamWeb.ItemData(cboFamWeb.ListIndex) & " ORDER BY VLIBSSFAMILLE"
    //End Sub


    private void cboSsFamWeb_TxtChanged(object sender, EventArgs e)
    {
      int code = cboSsFamWeb.GetItemData();
      if (-1 == code)
        return;
      cboSsFamWeb2.Init(MozartDatabase.cnxMozart, $"select NIDSSFAMILLE2, VLIBSSFAMILLE2 from TBRICOREFSSFAMILLE2 WHERE NIDSSFAMILLE = {code} ORDER BY VLIBSSFAMILLE2",
                        "NIDSSFAMILLE2", "VLIBSSFAMILLE2", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
    }
    //Private Sub cboSsFamWeb_Click()
    //  cboSsFamWeb2.Clear
    //  RemplirCombo cboSsFamWeb2, "select NIDSSFAMILLE2, VLIBSSFAMILLE2 from TBRICOREFSSFAMILLE2 WHERE NIDSSFAMILLE = " & cboSsFamWeb.ItemData(cboSsFamWeb.ListIndex) & " ORDER BY VLIBSSFAMILLE2"
    //End Sub
    //

    private void txtCond_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }
    //Private Sub txtCond_KeyPress(KeyAscii As Integer)
    //    If KeyAscii = 8 Then Exit Sub
    //
    //    If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //

    private void txtEAN_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }
    //Private Sub txtEAN_KeyPress(KeyAscii As Integer)
    //    If KeyAscii = 8 Then Exit Sub
    //    If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //

    private void txtPVHT_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }
    //Private Sub txtPVHT_KeyPress(KeyAscii As Integer)
    //    If KeyAscii = 8 Then Exit Sub
    //    If KeyAscii = 46 Then KeyAscii = 44
    //    If KeyAscii = 44 Then Exit Sub  'pour la virgule
    //    If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //

    private void txtPVHT_Leave(object sender, EventArgs e)
    {
      double ttc = 0;
      if (!double.TryParse(txtPVHT.Text, out ttc))
      {
        return;
      }

      txtPVTTC.Text = (ttc * 1.2).ToString("#####.####");
    }
    //Private Sub txtPVHT_LostFocus()
    //    If Not IsNumeric(txtPVHT) Then Exit Sub
    //    txtPVTTC = Format(CStr(ZeroIfNull(txtPVHT) * 1.2), "#####.####")
    //End Sub
    //

    private void txtPVTTC_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }
    //Private Sub txtPVTTC_KeyPress(KeyAscii As Integer)
    //    If KeyAscii = 8 Then Exit Sub
    //    If KeyAscii = 46 Then KeyAscii = 44
    //    If KeyAscii = 44 Then Exit Sub  'pour la virgule
    //    If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    //
    //

    private void chkExport_Click(object sender, EventArgs e)
    {
      if (chkExport.Checked)
        chkExportData.Checked = true;
    }
    //Private Sub chkExport_Click()
    //    If chkExport.Value = 1 Then chkExportData.Value = 1
    //End Sub
    //

    private void chkExportData_Click(object sender, EventArgs e)
    {
      if (chkExport.Checked)
        chkExportData.Checked = true;
    }
    //Private Sub chkExportData_Click()
    //    If chkExport.Value = 1 Then chkExportData.Value = 1
    //End Sub
    //

    private void txtPVTTC_Leave(object sender, EventArgs e)
    {
      double ttc = 0;
      if (!double.TryParse(txtPVTTC.Text, out ttc))
      {
        txtPVTTC.Text = "0";
        txtPVHT.Text = "0";
        txtcoef.Text = "0";
        return;
      }

      double pvht = (double)ttc / 1.2;
      txtPVHT.Text = pvht.ToString("#####.####");
      if (pvht != 0 && m_pAchat != 0)
        txtcoef.Text = (pvht / m_pAchat).ToString("#####.####");
    }
    //Private Sub txtPVTTC_LostFocus()
    //  
    //  If Not IsNumeric(txtPVTTC) Then
    //    txtPVTTC = 0
    //    txtPVHT = 0
    //    txtcoef = 0
    //    Exit Sub
    //  End If
    //  
    //  txtPVHT = Format(CStr(ZeroIfNull(txtPVTTC) / 1.2), "#####.####")
    //  
    //  If Not ZeroIfNull(txtPVTTC) = 0 And Not pAchat = 0 Then
    //    txtcoef = Format(CStr(CDbl(txtPVHT) / pAchat), "#####.####")
    //  End If
    //End Sub
  }
}

