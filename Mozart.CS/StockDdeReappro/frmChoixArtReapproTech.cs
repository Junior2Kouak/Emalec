using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixArtReapproTech : Form
  {
    public string mstrType = "";
    public string mstrTitre = "";
    public DataTable mdtArticles;

    private DataTable dtArtLocal = new DataTable();
    string sChampQte = "";

    //Dim adoRS As ADODB.Recordset
    //
    //Public rsArt As ADODB.Recordset
    //Public strType As String

    public frmChoixArtReapproTech() { InitializeComponent(); }

    /* OK --------------------------------------------------------------*/
    private void frmChoixArtReapproTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Text = Label1.Text += $" {mstrTitre.Replace("\r\n", " ")}";

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
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  OuvertureEnModification True
    //  
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdChoix_Click(object sender, EventArgs e)
    {
      if (dtArtLocal.Rows.Count > 0)
        ValiderSaisie();
      Dispose();
    }
    //Private Sub cmdChoix_Click()
    //  Screen.MousePointer = vbHourglass
    //  ValiderSaisie
    //  Screen.MousePointer = vbDefault
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void OuvertureEnModification()
    {
      string sSql = "";

      if (mstrType == "MULTI")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPQTE";
      }
      else if (mstrType == "DIRICKX")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPDIRICKXQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPDIRICKXQTE";
      }
      else if (mstrType == "ARGEDIS")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPARGEDISQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPARGEDISQTE";
      }
      else if (mstrType == "FAIBLE")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPFAIBLEQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPFAIBLEQTE";
      }
      else if (mstrType == "PLOMB")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPPLOMBQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPPLOMBQTE";
      }
      else if (mstrType == "FORT")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPFORTQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPFORTQTE";
      }
      else if (mstrType == "ED")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPEDQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPEDQTE";
      }
      else if (mstrType == "COUV")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPCOUVQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPCOUVQTE";
      }
      else if (mstrType == "MULTIEI")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPMULTIEIQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPMULTIEIQTE";
      }
      else if (mstrType == "VIS")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPVISQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPVISQTE";
      }
      else if (mstrType == "PHOTOVOLT")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPPHOTOVOLTQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPPHOTOVOLTQTE";
      }
      else if (mstrType == "CROWN")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPCROWNQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPCROWNQTE";
      }
      else if (mstrType == "MULTISERV_FOU")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPMULTISERVQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPMULTISERVQTE";
      }
      else
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPCLIMQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPCLIMQTE";
      }

      ModuleData.LoadData(dtArtLocal, sSql, MozartDatabase.cnxMozart);
      apiTGrid.GridControl.DataSource = dtArtLocal;

      dtArtLocal.Columns[sChampQte].ColumnName = "NQTE";
      dtArtLocal.Columns["NQTE"].ReadOnly = false;

      InitApigrid();
    }
    //Private Sub OuvertureEnModification(bFirstTime As Boolean)
    // 
    //  On Error GoTo handler
    //
    //  Set adoRS = New ADODB.Recordset
    //  
    //  If strType = "MULTI" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE  NFOUREAPQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "DIRICKX" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPDIRICKXQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "ARGEDIS" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPARGEDISQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "FAIBLE" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPFAIBLEQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "PLOMB" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPPLOMBQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "FORT" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPFORTQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "ED" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPEDQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "GUNNEBO" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPGUNNEBOQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "MULTIEI" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPMULTIEIQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "VIS" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPVISQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "PHOTOVOLT" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPPHOTOVOLTQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "CROWN" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPCROWNQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  ElseIf strType = "MULTISERV_FOU" Then
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPMULTISERVQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  Else
    //      adoRS.Open "select * from api_v_ListeArtReappro WHERE NFOUREAPCLIMQTE > 0 ORDER BY VFOUSER, VFOUMAT", cnx, adOpenDynamic, adLockOptimistic
    //  End If
    //
    //  If adoRS.EOF Then Exit Sub
    //  
    //  InitRecordsetArticle
    //    
    //  While Not adoRS.EOF
    //    AjouterEnreg adoRS
    //    adoRS.MoveNext
    //  Wend
    //  
    //  InitApigrid bFirstTime
    //
    //  rsArt.MoveFirst
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Public Sub InitRecordsetArticle()
    //
    //  On Error GoTo handler
    //
    //' initialisation du tableau de recherche des articles
    //  Set rsArt = New ADODB.Recordset
    //  
    //  ' ajout des champs au recordset
    //  rsArt.Fields.Append "VFOUSER", adVarChar, 150
    //  rsArt.Fields.Append "VFOUMAT", adVarChar, 150
    //  rsArt.Fields.Append "VFOUMAR", adVarChar, 150
    //  rsArt.Fields.Append "VFOUTYP", adVarChar, 2000
    //  rsArt.Fields.Append "VFOUREF", adVarChar, 150
    //  rsArt.Fields.Append "Qte", adInteger
    //  rsArt.Fields.Append "NFOUNUM", adInteger
    //  rsArt.Fields.Append "PrixU", adDouble
    //
    //  rsArt.Open , , adOpenDynamic, adLockOptimistic
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub AjouterEnreg(ByVal rs As ADODB.Recordset)
    //
    //  On Error GoTo handler
    // 
    //  If IsNull(rs!FPUHT) = True Then
    //      
    //      MsgBox "§Il n'y a pas de prix pour cette fourniture§ " & rs!VFOUMAT & " - §Ref§ : " & BlankIfNull(rs!VFOUREF) & vbCrLf & "§La fourniture sera exclue de la réappro§.", vbCritical
    //        Exit Sub
    //  End If
    //
    //  rsArt.AddNew
    //
    //  rsArt("VFOUSER").value = rs!VFOUSER
    //  rsArt("VFOUMAT").value = rs!VFOUMAT
    //  rsArt("VFOUMAR").value = BlankIfNull(rs!VFOUMAR)
    //  rsArt("VFOUTYP").value = BlankIfNull(rs!VFOUTYP)
    //  rsArt("VFOUREF").value = BlankIfNull(rs!VFOUREF)
    //  rsArt("NFOUNUM").value = rs!NFOUNUM
    //  If strType = "MULTI" Then
    //      rsArt("QTE").value = rs!NFOUREAPQTE
    //  ElseIf strType = "DIRICKX" Then
    //      rsArt("QTE").value = rs!NFOUREAPDIRICKXQTE
    //  ElseIf strType = "FAIBLE" Then
    //      rsArt("QTE").value = rs!NFOUREAPFAIBLEQTE
    //  ElseIf strType = "PLOMB" Then
    //      rsArt("QTE").value = rs!NFOUREAPPLOMBQTE
    //  ElseIf strType = "FORT" Then
    //      rsArt("QTE").value = rs!NFOUREAPFORTQTE
    //  ElseIf strType = "ARGEDIS" Then
    //      rsArt("QTE").value = rs!NFOUREAPARGEDISQTE
    //  ElseIf strType = "ED" Then
    //      rsArt("QTE").value = rs!NFOUREAPEDQTE
    //  ElseIf strType = "GUNNEBO" Then
    //      rsArt("QTE").value = rs!NFOUREAPGUNNEBOQTE
    //  ElseIf strType = "MULTIEI" Then
    //      rsArt("QTE").value = rs!NFOUREAPMULTIEIQTE
    //  ElseIf strType = "VIS" Then
    //      rsArt("QTE").value = rs!NFOUREAPVISQTE
    //  ElseIf strType = "PHOTOVOLT" Then
    //      rsArt("QTE").value = rs!NFOUREAPPHOTOVOLTQTE
    //  ElseIf strType = "CROWN" Then
    //      rsArt("QTE").value = rs!NFOUREAPCROWNQTE
    //  ElseIf strType = "MULTISERV_FOU" Then
    //      rsArt("QTE").value = rs!NFOUREAPMULTISERVQTE
    //  Else
    //      rsArt("QTE").value = rs!NFOUREAPCLIMQTE
    //  End If
    //    
    //  rsArt("PrixU").value = rs!FPUHT
    //
    //  
    //  rsArt.Update
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterEnreg dans  " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_Serie, "VFOUSER", 0);
        apiTGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 2300);
        apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1500);
        apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
        apiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 1200);
        apiTGrid.AddColumn("Qté", "NQTE", 800, "", 2);
        apiTGrid.AddColumn("NFOUNUM", "NFOUNUM", 0);

        apiTGrid.InitColumnList();
        apiTGrid.DelockColumn("NQTE");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub InitApigrid(bFirstTime As Boolean)
    //  
    //On Error GoTo handler
    //
    //  If bFirstTime Then
    //    apiTGrid.AddColumn "§Série§", "VFOUSER", 0
    //    apiTGrid.AddColumn "§Matériel§", "VFOUMAT", 6500
    //    apiTGrid.AddColumn "§Marque§", "VFOUMAR", 1500
    //    apiTGrid.AddColumn "§Type§", "VFOUTYP", 1500
    //    apiTGrid.AddColumn "§Référence§", "VFOUREF", 1500
    //    apiTGrid.AddColumn "founum", "NFOUNUM", 0
    //    apiTGrid.AddColumn "§Qte§", "QTE", 900
    //    apiTGrid.DelockColumn "QTE"
    //
    //    apiTGrid.AddCellTip "VFOUMAT", &HFDF0DA
    //    apiTGrid.AddCellTip "VFOUMAR", &HFDF0DA
    //    apiTGrid.AddCellTip "VFOUTYP", &HFDF0DA
    //    apiTGrid.AddCellTip "VFOUREF", &HFDF0DA
    //  End If
    //  
    //  apiTGrid.FilterBar = False
    //  apiTGrid.Init rsArt, Not bFirstTime
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  ShowError " FormatGrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void ValiderSaisie()
    {
      foreach (DataRow rowLocal in dtArtLocal.Rows)
      {
        if (rowLocal["NQTE"] != DBNull.Value && Convert.ToInt32(rowLocal["NQTE"]) > 0)
        {
          // ajout de l'enregistrement si pas deja existant
          if (RechercheDoublon(Convert.ToInt32(rowLocal["NFOUNUM"])))
            //  on supprime l'article et on recrée la ligne
            mdtArticles.Rows.Remove(mdtArticles.Select("NumArticle = " + rowLocal["NFOUNUM"])[0]);

          // Ajout de l'enregistrement
          DataRow newArt = mdtArticles.NewRow();

          newArt["Serie"] = rowLocal["VFOUSER"];
          newArt["Article"] = rowLocal["VFOUMAT"];
          newArt["Marque"] = Utils.BlankIfNull(rowLocal["VFOUMAR"]);
          newArt["Type"] = Utils.BlankIfNull(rowLocal["VFOUTYP"]);
          newArt["Reference"] = Utils.BlankIfNull(rowLocal["VFOUREF"]);
          newArt["Quantite"] = rowLocal["NQTE"];
          newArt["Prix U"] = rowLocal["FPUHT"];
          newArt["Prix T"] = 0;
          newArt["NumArticle"] = rowLocal["NFOUNUM"];

          mdtArticles.Rows.Add(newArt);
        }
      }
    }
    //Private Sub ValiderSaisie()
    //
    //On Error Resume Next
    //
    //
    //  rsArt.MoveFirst
    //  While Not rsArt.EOF
    //    If rsArt("QTE") <> 0 Then
    //        ' ajout de l'enregistrement si pas deja existant
    //        If rechercheDoublon(rsArt("NFOUNUM")) Then
    //          ' on supprime l'article est on recrée la ligne
    //          rsarticle.Find ("NumArticle = " & rsArt("NFOUNUM"))
    //          rsarticle.Delete
    //        End If
    //        rsarticle.AddNew
    //          rsarticle("Serie").value = rsArt("VFOUSER")
    //          rsarticle("Article").value = rsArt("VFOUMAT")
    //          rsarticle("Marque").value = BlankIfNull(rsArt("VFOUMAR"))
    //          rsarticle("Type").value = BlankIfNull(rsArt("VFOUTYP"))
    //          rsarticle("Reference").value = BlankIfNull(rsArt("VFOUREF"))
    //          rsarticle("Quantite").value = rsArt("QTE")
    //          rsarticle("Prix U").value = rsArt("PrixU")
    //          rsarticle("Prix T").value = 0
    //          rsarticle("NumArticle").value = rsArt("NFOUNUM")
    //        rsarticle.Update
    //    End If
    //    rsArt.MoveNext
    //  Wend
    //  
    //Exit Sub
    //handler:
    //  ShowError "ValiderSaisie dans " & Me.Name
    //End Sub

    //' recherche si l'article est present dans la liste

    /* OK --------------------------------------------------------------------------------------- */
    private bool RechercheDoublon(int numFou)
    {
      // recherche si l'article est present dans la liste
      bool bFound = false;

      foreach (DataRow row in mdtArticles.Rows)
      {
        if (Convert.ToInt32(row["NumArticle"]) == numFou)
        {
          bFound = true;
          break;
        }
      }
      return bFound;
    }
    //Private Function rechercheDoublon(ByVal numFou As Long) As Boolean
    //
    //On Error Resume Next
    //
    //  rechercheDoublon = False
    //  
    //  rsarticle.MoveFirst
    //  While Not rsarticle.EOF
    //    If rsarticle("NumArticle") = numFou Then
    //        rechercheDoublon = True
    //        Exit Function
    //    End If
    //    rsarticle.MoveNext
    //  Wend
    //  
    //Exit Function
    //handler:
    //  ShowError "rechercheDoublon dans " & Me.Name
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "NQTE")
      {
        e.Appearance.BackColor = Color.LightGray;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }
    //Private Sub apiTGrid_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  If DataField = "QTE" Then
    //      CellStyle.Font.Bold = True
    //      CellStyle.BackColor = &HEEEEEE
    //     'CellStyle.ForeColor = vbRed
    //    ' CellStyle.BackColor = &HCCCCCC
    //  End If
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
  }
}