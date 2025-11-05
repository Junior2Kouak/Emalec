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
  public partial class frmListeTramesGamme : Form
  {
    DataTable dtArticle = new DataTable();
    public string mstrStatut = "";
    public long miNumTrame;

    List<string> sListeSup = new List<string>();
    string sListeClients = "";

    //Dim adoRS As ADODB.Recordset
    //
    //Public mstrStatut As String
    //Public miNumTrame As Long
    //
    //Dim sListeClients As String
    //Dim slisteSup As String
    //Dim tabSup

    public frmListeTramesGamme()
    {
      InitializeComponent();
    }

    private void frmListeTramesGamme_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        ModuleData.RemplirCombo(cboPays, "SELECT NPAYSNUM, VPAYSNOM FROM TPAYS ORDER BY VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        if (mstrStatut == "V")
          OuvertureEnVisu();
        else if (mstrStatut == "C")
          OuvertureEnCrea();
        else if (mstrStatut == "M" || mstrStatut == "Mod")
          OuvertureEnModif();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  RemplirCombo cboPays, "SELECT NPAYSNUM, VPAYSNOM FROM TPAYS ORDER BY VPAYSNOM", , True
    //  
    //  ' initialiser
    //  slisteSup = ""
    //  
    //  If mstrStatut = "V" Then
    //    ouvertureEnVisu
    //  ElseIf mstrStatut = "C" Then
    //    ouvertureEnCrea
    //  ElseIf mstrStatut = "M" Then
    //    ouvertureEnModif
    //  ElseIf mstrStatut = "Mod" Then
    //    ouvertureEnModif
    //  End If
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  ' fermeture de la fenetre
    //  Unload Me
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (dtArticle.Rows.Count == 0)
        return;

      if (mstrStatut == "Mod")
        ModifierTrame();
      else
      {
        if (MessageBox.Show($"{Resources.msg_CreerNouvelleTrame} {MozartParams.NomSociete}\r\n{Resources.msg_ConfirmAccord}", Program.AppTitle,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;
        EnregistrerTrame();
        mstrStatut = "Mod";

      }

      InfoEntete();
    }
    //Private Sub cmdValider_Click()
    //    
    //  ' test si il y a des lignes
    //  If rsarticle.EOF Then Exit Sub
    //  
    //  If rsarticle.RecordCount = 0 Then Exit Sub
    //  
    //  If mstrStatut = "Mod" Then
    //    ModifierTrame
    //  Else
    //      Select Case MsgBox("§Vous allez créer une nouvelle trame §" & gstrNomSociete & "§.Etes-vous d'accord ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //        Case vbYes
    //          EnregistrerTrame
    //          mstrStatut = "Mod"
    //        Case vbNo
    //          Exit Sub
    //      End Select
    //  End If
    //  InfoEntete
    //  InitRecordsetArticle
    //  ChargesArticles
    //  apiTGridArt.Init rsarticle
    //  
    //End Sub
    //

    /* ---------------------------------------------------------------------*/
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow rowGrid = apiTGridArt.GetFocusedDataRow();
      if (rowGrid == null) return;

      for (int i = 0; i < dtArticle.Rows.Count; i++)
      {
        if (dtArticle.Rows[i] == rowGrid)
        {
          sListeSup.Add(dtArticle.Rows[i]["NGAMTRAMENUM"].ToString());
          dtArticle.Rows.Remove(dtArticle.Rows[i]);
        }
      }
      dtArticle.AcceptChanges();
    }
    //Private Sub cmdSupprimer_Click()
    //Dim aux
    //
    //On Error Resume Next
    //  aux = rsarticle.AbsolutePosition
    //  rsarticle.Delete
    //  rsarticle.AbsolutePosition = aux
    //  
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void EnregistrerTrame()
    {
      string sSQL = "";
      try
      {
        //  recherche du numero de trame suivant
        int iTrameSuivant = (int)ModuleData.ExecuteScalarInt("select max(NTRAEMANUM) + 1 from TGAMTRAMESEMALEC");

        foreach (DataRow row in dtArticle.Rows)
        {
          sSQL = "Insert into TGAMTRAMESEMALEC (NTRAEMANUM, VGAMTYPE, VGAMPARA, VGAMLIB, VGAMUNITE, "
          + "NGAMNUMPARA, NGAMNUMLIB, DTRAEMADAT, CTRAEMAACTIF, NPAYSNUM) values (" + (iTrameSuivant) + ", '"
          + txtType.Text.Replace("'", "''") + "', '"
          + Utils.BlankIfNull(row["VGAMPARA"].ToString().Replace("'", "''")) + "', '"
          + Utils.BlankIfNull(row["VGAMLIB"].ToString().Replace("'", "''")) + "', '"
          + Utils.BlankIfNull(row["VGAMUNITE"].ToString().Replace("'", "''")) + "', "
          + (String.IsNullOrEmpty(row["NGAMNUMPARA"].ToString()) ? "null" : row["NGAMNUMPARA"].ToString()) + ", "
          + (row["NGAMNUMLIB"] == null || row["NGAMNUMLIB"].ToString().Trim() == "" ? "Null" : row["NGAMNUMLIB"].ToString())
          + ", '" + DateTime.Now.ToShortDateString() + "', 'O'," + ((DataRowView)cboPays.SelectedItem).Row.ItemArray[0] + ")";
          ModuleData.ExecuteNonQuery(sSQL);
        }

        miNumTrame = iTrameSuivant;

        dtArticle.AcceptChanges();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub EnregistrerTrame()
    //    
    //Dim adoInfo As ADODB.Recordset
    //Dim sSQL As String
    //
    //On Error GoTo handler:
    //
    //  
    //  ' recherche du numero de trame suivant
    //  Set adoInfo = New ADODB.Recordset
    //  adoInfo.Open "select max(NTRAEMANUM) from TGAMTRAMESEMALEC", cnx, adOpenStatic, adLockOptimistic
    //
    //  'rsarticle.MoveFirst
    //  While rsarticle.EOF = False
    //      sSQL = " insert into  TGAMTRAMESEMALEC ( NTRAEMANUM, VGAMTYPE, VGAMPARA, VGAMLIB, VGAMUNITE, "
    //      sSQL = sSQL & "NGAMNUMPARA, NGAMNUMLIB, DTRAEMADAT, CTRAEMAACTIF, NPAYSNUM) "
    //      sSQL = sSQL & " values ( " & adoInfo(0) + 1 & ", '" & Replace(txtType, "'", "''") & "', '" & Replace(BlankIfNull(rsarticle("VGAMPARA")), "'", "''") & "', '" & Replace(BlankIfNull(rsarticle("VGAMLIB")), "'", "''") & "', '"
    //      sSQL = sSQL & Replace(BlankIfNull(rsarticle("VGAMUNITE")), "'", "''") & "', "
    //      sSQL = sSQL & IIf(IsNull(rsarticle("NGAMNUMPARA")) Or IsEmpty(rsarticle("NGAMNUMPARA")), "Null", rsarticle("NGAMNUMPARA")) & ", " & IIf(IsNull(rsarticle("NGAMNUMLIB")) = True Or Trim(rsarticle("NGAMNUMLIB")) = "", "Null", rsarticle("NGAMNUMLIB"))
    //      sSQL = sSQL & ", '" & Date & "', 'O'," & cboPays.ItemData(cboPays.ListIndex) & ")"
    //    cnx.Execute sSQL
    //    rsarticle.MoveNext
    //  Wend
    //
    //  miNumTrame = adoInfo(0) + 1
    //  adoInfo.Close
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "EnregistrerTrame de " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void ModifierTrame()
    {
      string sSQL = "";
      //  ajout des lignes en plus
      try
      {
        foreach (DataRow row in dtArticle.Rows)
        {
          if (row.RowState == DataRowState.Added)
          {
            sSQL = "Insert Into  TGAMTRAMESEMALEC (NTRAEMANUM, VGAMTYPE, VGAMPARA, VGAMLIB, VGAMUNITE, "
                 + "NGAMNUMPARA, NGAMNUMLIB, DTRAEMADAT, CTRAEMAACTIF) "
                 + "Values (" + miNumTrame + ", '" + txtType.Text.Replace("'", "''") + "', '"
                 + Utils.BlankIfNull(row["VGAMPARA"]).ToString().Replace("'", "''") + "', '"
                 + Utils.BlankIfNull(row["VGAMLIB"]).ToString().Replace("'", "''") + "', '"
                 + Utils.BlankIfNull(row["VGAMUNITE"]).ToString().Replace("'", "''") + "', "
                 + (row["NGAMNUMPARA"] == null || row["NGAMNUMPARA"].ToString() == "" ? "Null" : row["NGAMNUMPARA"]) + ", "
                 + (row["NGAMNUMLIB"] == null || row["NGAMNUMLIB"].ToString() == "" ? "Null" : row["NGAMNUMLIB"]) + ", '"
                 + txtDate.Text + "', 'O')";
          }
          else if (row.RowState == DataRowState.Modified)
          {
            // Update de la ligne
            sSQL = "Update TGAMTRAMESEMALEC set VGAMPARA='" + Utils.BlankIfNull(row["VGAMPARA"].ToString().Replace("'", "''")) + "', "
                 + "VGAMLIB = '" + row["VGAMLIB"].ToString().Replace("'", "''") + "', "
                 + "NGAMNUMPARA = " + (row["NGAMNUMPARA"] == null || row["NGAMNUMPARA"].ToString() == "" ? "null" : row["NGAMNUMPARA"]) + ", "
                 + "NGAMNUMLIB = " + (row["NGAMNUMLIB"] == null || row["NGAMNUMLIB"].ToString() == "" ? "Null" : row["NGAMNUMLIB"]) + ", "
                 + "VGAMUNITE = '" + Utils.BlankIfNull(row["VGAMUNITE"].ToString().Replace("'", "''")) + "' "
                 + "WHERE NGAMTRAMENUM = " + row["NGAMTRAMENUM"];
          }
          if (sSQL != "")
            ModuleData.ExecuteNonQuery(sSQL);
          sSQL = "";
        }

        //  Modification des infos générales
        sSQL = "Update TGAMTRAMESEMALEC Set VGAMTYPE = '" + txtType.Text.Replace("'", "''") + "', "
             + "NPAYSNUM = " + ((DataRowView)cboPays.SelectedItem).Row.ItemArray[0] + ", "
             + "VLISTECLIENT = '" + sListeClients.Replace("'", "''") + "' " + "WHERE NTRAEMANUM = " + miNumTrame;
        ModuleData.ExecuteNonQuery(sSQL);

        dtArticle.AcceptChanges();

        // Suppression des lignes marquées pour suppression
        foreach (string item in sListeSup)
          ModuleData.ExecuteNonQuery(" delete from TGAMTRAMESEMALEC WHERE NGAMTRAMENUM = " + item);

        sListeSup.Clear();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub ModifierTrame()
    //    
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler:
    //  
    //  ' ajout des lignes en plus
    //  On Error Resume Next
    //  rsarticle.MoveFirst
    //  While Not rsarticle.EOF
    //    If IsNull(rsarticle("NGAMTRAMENUM")) Or rsarticle("NGAMTRAMENUM") = 0 Then
    //      sSQL = " insert into  TGAMTRAMESEMALEC ( NTRAEMANUM, VGAMTYPE, VGAMPARA, VGAMLIB, VGAMUNITE, "
    //      sSQL = sSQL & "NGAMNUMPARA, NGAMNUMLIB, DTRAEMADAT, CTRAEMAACTIF) "
    //      sSQL = sSQL & " values ( " & miNumTrame & ", '" & Replace(txtType, "'", "''") & "', '" & Replace(BlankIfNull(rsarticle("VGAMPARA")), "'", "''") & "', '" & Replace(BlankIfNull(rsarticle("VGAMLIB")), "'", "''") & "', '"
    //      sSQL = sSQL & Replace(BlankIfNull(rsarticle("VGAMUNITE")), "'", "''") & "', "
    //      sSQL = sSQL & IIf(IsNull(rsarticle("NGAMNUMPARA")) Or rsarticle("NGAMNUMPARA") = "", "Null", rsarticle("NGAMNUMPARA")) & ", " & IIf(IsNull(rsarticle("NGAMNUMLIB")) Or rsarticle("NGAMNUMLIB") = "", "Null", rsarticle("NGAMNUMLIB")) & ", '" & txtDate & "', 'O')"
    //    Else
    //      ' update de la ligne
    //      sSQL = " update  TGAMTRAMESEMALEC set VGAMPARA='" & Replace(BlankIfNull(rsarticle("VGAMPARA")), "'", "''") & "', "
    //      sSQL = sSQL & " VGAMLIB='" & Replace(rsarticle("VGAMLIB"), "'", "''") & "', "
    //      sSQL = sSQL & " NGAMNUMPARA=" & IIf(IsNull(rsarticle("NGAMNUMPARA")) Or rsarticle("NGAMNUMPARA") = "", "Null", rsarticle("NGAMNUMPARA")) & ", "
    //      sSQL = sSQL & " NGAMNUMLIB=" & IIf(IsNull(rsarticle("NGAMNUMLIB")) Or rsarticle("NGAMNUMLIB") = "", "Null", rsarticle("NGAMNUMLIB")) & ", "
    //      sSQL = sSQL & " VGAMUNITE='" & Replace(BlankIfNull(rsarticle("VGAMUNITE")), "'", "''") & "' "
    //      sSQL = sSQL & " WHERE NGAMTRAMENUM=" & rsarticle("NGAMTRAMENUM")
    //    End If
    //    cnx.Execute sSQL
    //    rsarticle.MoveNext
    //  Wend
    //  
    //  ' modification des infos générales
    //  sSQL = " update  TGAMTRAMESEMALEC set VGAMTYPE = '" & Replace(txtType, "'", "''") & "', NPAYSNUM = " & cboPays.ItemData(cboPays.ListIndex) & ", VLISTECLIENT = '" & Replace(sListeClients, "'", "''") & "'"
    //  sSQL = sSQL & " WHERE NTRAEMANUM = " & miNumTrame
    //  cnx.Execute sSQL
    //      
    //  ' modification des infos sur les gammes client existantes
    //'  FG le 02/09/08 ? ecrasement du nom de la gamme
    //'  sSQL = " update  TGAMCLIENT set VGAMTYPE = '" & Replace(txtType, "'", "''") & "'"
    //'  sSQL = sSQL & " WHERE NTRAEMANUM = " & miNumTrame
    //'  cnx.Execute sSQL
    //  
    //  ' suppression des lignes marquées pour suppression
    //  If slisteSup <> "" Then
    //    tabSup = Split(slisteSup, ";")
    //    For i = 0 To UBound(tabSup) - 1
    //      sSQL = ""
    //      sSQL = " delete from TGAMTRAMESEMALEC WHERE NGAMTRAMENUM = " & tabSup(i)
    //      cnx.Execute sSQL
    //    Next
    //  End If
    //  slisteSup = ""
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "ModifierTrame de " & Me.Name
    //End Sub
    //

    /* OK Inutile---------------------------------------------------------------------*/
    //Private Sub apiTgridArt_BeforeDelete(Cancel As Integer)
    //
    //  If slisteSup = "" Then
    //    slisteSup = rsarticle("NGAMTRAMENUM") & ";"
    //  Else
    //    slisteSup = slisteSup & rsarticle("NGAMTRAMENUM") & ";"
    //  End If
    //    
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void OuvertureEnVisu()
    {
      try
      {
        Label1.Text = Resources.txt_visuTrameGamme + MozartParams.NomSociete;

        //    ouverture
        apiTGridArt.LoadData(dtArticle, MozartDatabase.cnxMozart, "select NGAMNUMPARA,VGAMPARA, NGAMNUMLIB,VGAMLIB, VGAMUNITE from TGAMTRAMESEMALEC WHERE NTRAEMANUM = " + miNumTrame + " order by NGAMNUMPARA , NGAMNUMLIB");
        apiTGridArt.GridControl.DataSource = dtArticle;

        InfoEntete();
        InitApiTgridVisu();
        cmdValider.Enabled = false;
        cmdAjouter.Visible = false;
        cmdSupprimer.Visible = false;

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub ouvertureEnVisu()
    //
    //On Error GoTo handler:
    //
    //  Label1.Caption = "§Visualisation des trames d'une gamme §" & gstrNomSociete
    //    
    //    ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "select NGAMNUMPARA,VGAMPARA, NGAMNUMLIB,VGAMLIB, VGAMUNITE from TGAMTRAMESEMALEC WHERE NTRAEMANUM = " & miNumTrame & " order by NGAMNUMPARA , NGAMNUMLIB", cnx, adOpenStatic, adLockOptimistic
    //
    //  InfoEntete
    //  
    //  InitApiTgridVisu
    //  cmdValider.Enabled = False
    //  cmdSupprimer.Visible = False
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "ouvertureEnVisu de " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InfoEntete()
    {
      try
      {
        using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeEmalec " + miNumTrame))
        {
          if (dr.Read())
          {
            txtNum.Text = dr[0].ToString();
            txtDate.Text = Utils.DateBlankIfNull(dr[1]);
            txtType.Text = dr[2].ToString();
            cboPays.SelectedValue = dr[3].ToString();

            if (dr.FieldCount > 5)
              sListeClients = dr[5].ToString();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InfoEntete()
    //    
    //Dim adoInfo As ADODB.Recordset
    //On Error GoTo handler:
    //
    //  Set adoInfo = New ADODB.Recordset
    //  adoInfo.Open "api_sp_InfoTramesGammeEmalec " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //    
    //  txtNum = adoInfo(0)
    //  txtDate = adoInfo(1)
    //  txtType = adoInfo(2)
    //  SelectLB cboPays, adoInfo(3)
    //  
    //  
    //  If adoInfo.Fields.count > 5 Then sListeClients = adoInfo(5)
    //  
    //  
    //  adoInfo.Close
    //  Set adoInfo = Nothing
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "InfoEntete de " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void OuvertureEnModif()
    {
      try
      {
        Label1.Text = Resources.txt_modifTrameGamme + " " + MozartParams.NomSociete;

        InfoEntete();

        ChargesArticles();

        InitApiTgridArt();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub ouvertureEnModif()
    //    
    //On Error GoTo handler:
    //
    //  Label1.Caption = "§Modification des trames d'une gamme §" & gstrNomSociete
    //    
    //  InfoEntete
    //  
    //  InitRecordsetArticle
    //  ChargesArticles
    //  InitApiTgridArt
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "ouvertureEnVisu de " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void OuvertureEnCrea()
    {
      try
      {
        Label1.Text = Resources.txt_creaTrameGamme + " " + MozartParams.NomSociete;
        txtNum.Text = "";
        txtDate.Text = "";
        txtType.Text = "";
        cboPays.SelectedValue = 1;

        ChargesArticles();
        InitApiTgridArt();

        cmdSupprimer.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      Cursor.Current = Cursors.Default;
    }

    //Private Sub ouvertureEnCrea()
    //    
    //On Error GoTo handler:
    //  
    //  Label1.Caption = "§Création des trames d'une gamme §" & gstrNomSociete
    //  
    //  txtNum = ""
    //  txtDate = ""
    //  txtType = ""
    //  
    //  SelectLB cboPays, 1
    //  
    //  InitRecordsetArticle
    //  InitApiTgridArt
    //  
    //  cmdSupprimer.Visible = False
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "ouvertureEnCrea de " & Me.Name
    //End Sub
    //

    /* OK Inutile ---------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* INUTILE---------------------------------------------------------------------*/
    //Public Sub InitRecordsetArticle()
    //
    //On Error GoTo handler
    //
    //  Set rsarticle = New ADODB.Recordset
    //  
    //  rsarticle.Fields.Append "NGAMNUMPARA", adVarChar, 10
    //  rsarticle.Fields.Append "VGAMPARA", adVarChar, 500
    //  rsarticle.Fields.Append "NGAMNUMLIB", adVarChar, 10
    //  rsarticle.Fields.Append "VGAMLIB", adLongVarWChar, 8000
    //  rsarticle.Fields.Append "VGAMUNITE", adVarChar, 150
    //  rsarticle.Fields.Append "NGAMTRAMENUM", adInteger
    //  
    //  rsarticle.Open , , adOpenDynamic, adLockOptimistic
    //  Exit Sub
    //
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub
    //

    /* INUTILE--------------------------------------------------------------------*/
    //private void AjouterEnreg(SqlDataReader srd)
    //{
    //  try
    //  {
    //    //  ajout de l'enregistrement
    //    DataRow newrow = dtArticle.NewRow();

    //    newrow["NGAMNUMPARA"] = Utils.ZeroIfNull(srd["NGAMNUMPARA"]);
    //    newrow["VGAMPARA"] = Utils.ZeroIfNull(srd["VGAMPARA"]);
    //    newrow["NGAMNUMLIB"] = Utils.ZeroIfNull(srd["NGAMNUMLIB"]);
    //    newrow["VGAMLIB"] = Utils.ZeroIfNull(srd["VGAMLIB"]);
    //    newrow["VGAMUNITE"] = Utils.ZeroIfNull(srd["VGAMUNITE"]);
    //    newrow["NGAMTRAMENUM"] = Utils.ZeroIfNull(srd["NGAMTRAMENUM"]);

    //    dtArticle.Rows.Add(newrow);

    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show(string.Format("{0}\r\n\r\n{1}{2}", ex.Message, Resources.Global_dans, MethodBase.GetCurrentMethod().Name), Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //  }
    //}
    //Private Sub AjouterEnreg(ByVal rs As ADODB.Recordset)
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsarticle.AddNew
    //  
    //  rsarticle("NGAMNUMPARA").value = ZeroIfNull(rs("NGAMNUMPARA"))
    //  rsarticle("VGAMPARA").value = BlankIfNull(rs("VGAMPARA"))
    //  rsarticle("NGAMNUMLIB").value = BlankIfNull(rs("NGAMNUMLIB"))
    //  rsarticle("VGAMLIB").value = BlankIfNull(rs("VGAMLIB"))
    //  rsarticle("VGAMUNITE").value = BlankIfNull(rs("VGAMUNITE"))
    //  rsarticle("NGAMTRAMENUM").value = rs("NGAMTRAMENUM")
    //
    //  rsarticle.Update
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitApiTgridArt()
    {
      try
      {
        apiTGridArt.AddColumn(Resources.col_Num, "NGAMNUMPARA", 500);
        apiTGridArt.AddColumn(Resources.col_categorie, "VGAMPARA", 2300);
        apiTGridArt.AddColumn(Resources.col_rep, "NGAMNUMLIB", 500);
        apiTGridArt.AddColumn(Resources.col_Lbl, "VGAMLIB", 9500);
        apiTGridArt.AddColumn(Resources.col_unite, "VGAMUNITE", 1100);
        apiTGridArt.AddColumn(Resources.col_ID, "NGAMTRAMENUM", 0);

        apiTGridArt.DelockColumn("NGAMNUMPARA");
        apiTGridArt.DelockColumn("VGAMPARA");
        apiTGridArt.DelockColumn("NGAMNUMLIB");
        apiTGridArt.DelockColumn("VGAMLIB");
        apiTGridArt.DelockColumn("VGAMUNITE");

        apiTGridArt.FilterBar = false;
        apiTGridArt.InitColumnList();

        apiTGridArt.dgv.OptionsBehavior.Editable = true;
        apiTGridArt.dgv.OptionsBehavior.ReadOnly = false;
        apiTGridArt.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApiTgridArt()
    //  
    //On Error GoTo handler
    //
    //  apiTGridArt.AddColumn "N°", "NGAMNUMPARA", 500
    //  apiTGridArt.AddColumn "§Catégorie§", "VGAMPARA", 2300
    //  apiTGridArt.AddColumn "§Rep§", "NGAMNUMLIB", 500
    //  apiTGridArt.AddColumn "§Libellé§", "VGAMLIB", 9500
    //  apiTGridArt.AddColumn "§Unité§", "VGAMUNITE", 1100
    //  apiTGridArt.AddColumn "ID", "NGAMTRAMENUM", 0
    //
    //  apiTGridArt.DelockColumn "NGAMNUMPARA"
    //  apiTGridArt.DelockColumn "VGAMPARA"
    //  apiTGridArt.DelockColumn "NGAMNUMLIB"
    //  apiTGridArt.DelockColumn "VGAMLIB"
    //  apiTGridArt.DelockColumn "VGAMUNITE"
    //  
    //  apiTGridArt.AllowAddNew = True
    //  'apiTGridArt.AllowDelete = True
    //  apiTGridArt.FilterBar = False
    //  apiTGridArt.Init rsarticle
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitApiTgrid dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void ChargesArticles()
    {
      try
      {
        //  recherche des détails fournitures
        apiTGridArt.LoadData(dtArticle, MozartDatabase.cnxMozart, "select NGAMTRAMENUM, NGAMNUMPARA, VGAMPARA, NGAMNUMLIB, VGAMLIB, VGAMUNITE from TGAMTRAMESEMALEC " +
                                                        "WHERE NTRAEMANUM = " + miNumTrame + " order by NGAMNUMPARA , NGAMNUMLIB");
        apiTGridArt.GridControl.DataSource = dtArticle;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub ChargesArticles()
    //Dim rsA As ADODB.Recordset
    //Dim sSQL As String
    //
    //On Error GoTo handler
    //
    //  ' recherche des détails fournitures
    //  Set rsA = New ADODB.Recordset
    //  sSQL = "select NGAMTRAMENUM, VGAMPARA, VGAMLIB, NGAMNUMPARA, NGAMNUMLIB, VGAMUNITE  from TGAMTRAMESEMALEC WHERE NTRAEMANUM = " & miNumTrame & " ORDER BY NGAMNUMPARA, NGAMNUMLIB"
    //
    //  rsA.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //
    //  While Not rsA.EOF
    //    AjouterEnreg rsA
    //    rsA.MoveNext
    //  Wend
    //  rsA.Close
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "ChargesArticles dans " & Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitApiTgridVisu()
    {
      try
      {
        apiTGridArt.AddColumn(Resources.col_Num, "NGAMNUMPARA", 500);
        apiTGridArt.AddColumn(Resources.col_categorie, "VGAMPARA", 2300, "", 0, true);
        apiTGridArt.AddColumn(Resources.col_rep, "NGAMNUMLIB", 500);
        apiTGridArt.AddColumn(Resources.col_Lbl, "VGAMLIB", 9500, "", 0, true);
        apiTGridArt.AddColumn(Resources.col_unite, "VGAMUNITE", 1100);

        apiTGridArt.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        /*int iNumParam = (int)Utils.ZeroIfNull(dtArticle.Compute("MAX([NGAMNUMPARA])", ""));
        ModuleData.ExecuteNonQuery($"INSERT INTO TGAMTRAMESEMALEC (NTRAEMANUM, NGAMNUMPARA, DTRAEMADAT) VALUES ({miNumTrame}, {iNumParam + 1}, '{txtDate.Text}')");
        apiTGridArt.Requery(dtArticle, MozartDatabase.cnxMozart);
        */
        DataRow row = dtArticle.NewRow();
        dtArticle.Rows.Add(row);
        apiTGridArt.dgv.MoveLast();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApiTgridVisu()
    //  
    //On Error GoTo handler
    //
    //  apiTGridArt.AddColumn "N°", "NGAMNUMPARA", 500
    //  apiTGridArt.AddColumn "§Catégorie§", "VGAMPARA", 2300
    //  apiTGridArt.AddColumn "§Rep§", "NGAMNUMLIB", 500
    //  apiTGridArt.AddColumn "§Libellé§", "VGAMLIB", 9500
    //  apiTGridArt.AddColumn "§Unité§", "VGAMUNITE", 1100
    //
    //  apiTGridArt.AddCellTip "VGAMPARA", &HC0FFC0
    //  apiTGridArt.AddCellTip "VGAMLIB", &HC0FFC0
    //
    //  apiTGridArt.Init adoRS
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitApiTgrid dans " & Me.Name
    //End Sub
    //
  }
}

