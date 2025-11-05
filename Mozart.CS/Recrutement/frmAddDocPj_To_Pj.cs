using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static MozartCS.Utils;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAddDocPj_To_PJ : Form
  {
    //Dim rsarticle As ADODB.Recordset
    //Dim mRepertoireDoc As String
    //Dim strRepAtt As String
    //Dim strRepFacSTF As String
    //Dim strRepFacCOT As String
    //Dim LstPJSelect() As New C_PJ
    //Dim iNbFileSelect As Integer
    //Dim strFile As String

    public List<C_PJ> lstPJSelect = new List<C_PJ>();

    DataTable dtArticles = new DataTable();
    string mstrRepImage;
    string mstrRepAtt;
    string mstrRepFacSTF;
    string mstrRepFacCOT;
    string mstrFile;

    public frmAddDocPj_To_PJ()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmAddDocPj_To_PJ_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        mstrRepImage = Utils.RechercheParam("REP_PHOTOS_ACT");
        mstrRepAtt = Utils.RechercheParam("REP_ATTGAM");
        mstrRepFacSTF = Utils.RechercheParam("REP_FACTURE_STF");      //facture stt non saisie dans ravel
        mstrRepFacCOT = Utils.RechercheParam("REP_FACTURE_COTRAIT");

        LoadData();
        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //On Error GoTo handler:
    //    iNbFileSelect = 0
    //  WebBrowser1.Visible = True
    //  WebBrowser1.Navigate2 "about:blank"
    //  InitBoutons Me, frmMenu
    //  mRepertoireDoc = RechercheParam("REP_PHOTOS_ACT")
    //  strRepAtt = RechercheParam("REP_ATTGAM")
    //  strRepFacSTF = RechercheParam("REP_FACTURE_STF")      'facture stt non saisie dans ravel
    //  strRepFacCOT = RechercheParam("REP_FACTURE_COTRAIT")
    //    LoadData

    //    InitApiTgrid

    //    Exit Sub
    //    Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void LoadData()
    {
      try
      {
        apiTGrid1.InitColumnList();
        apiTGrid1.LoadData(dtArticles, MozartDatabase.cnxMozart, "exec [api_sp_ListeImgAct_for_SendPJ] " + MozartParams.NumAction);
        apiTGrid1.GridControl.DataSource = dtArticles;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub LoadData()
    //' initialisation du recordset local des articles
    //  Call InitRecordsetArticle
    //  ' recherche des détails fournitures
    //  Set rs = New ADODB.Recordset
    //  rs.Open "exec [api_sp_ListeImgAct_for_SendPJ] " & glNumAction, cnx, adOpenStatic, adLockOptimistic
    //  ' passage des infos du recordset
    //  While Not rs.EOF
    //    AjouterEnreg rs
    //    rs.MoveNext
    //  Wend
    //  On Error Resume Next
    //  rsarticle.MoveFirst
    //  apiTGrid1.Init rsarticle, True
    //    rs.Close
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      try
      {
        apiTGrid1.dgv.OptionsSelection.MultiSelect = true;
        apiTGrid1.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;

        apiTGrid1.AddColumn(Resources.col_Selectionner, "NSELECT", 50, "", 0, true, false, true);
        apiTGrid1.AddColumn(Resources.col_NumImage, "NIMAGE", 1000);
        apiTGrid1.AddColumn(Resources.col_Image, "VIMAGE", 1500);
        apiTGrid1.AddColumn(Resources.col_Fichier, "VFICHIER", 2500);
        apiTGrid1.AddColumn(Resources.col_CodeFmt, "CFORMAT", 0);
        apiTGrid1.AddColumn(Resources.col_Format, "VFORMAT", 1000);
        apiTGrid1.AddColumn(Resources.col_Commentaire, "VCOMMENT", 3500);
        apiTGrid1.AddColumn("NTYPEDOC", "NSSCNTYPEDOCATID", 0);
        apiTGrid1.AddColumn("VTYPE", "VTYPE", 0);
        apiTGrid1.AddColumn(Resources.col_NAction, "NACTNUM", 0);

        apiTGrid1.DelockColumn("NSELECT", dtArticles);
        apiTGrid1.InitColumnList();
        apiTGrid1.LoadData(dtArticles, MozartDatabase.cnxMozart, "exec [api_sp_ListeImgAct_for_SendPJ] " + MozartParams.NumAction);
        apiTGrid1.GridControl.DataSource = dtArticles;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub InitRecordsetArticle()

    //On Error GoTo handler

    //' initialisation du tableau de recherche des articles
    //  Set rsarticle = New ADODB.Recordset

    //  ' ajout des champs au recordset

    //  rsarticle.Fields.Append "NSELECT", adInteger
    //  rsarticle.Fields.Append "NIMAGE", adInteger
    //  rsarticle.Fields.Append "NACTNUM", adInteger
    //  rsarticle.Fields.Append "VIMAGE", adVarChar, 50
    //  rsarticle.Fields.Append "VFICHIER", adVarChar, 255
    //  rsarticle.Fields.Append "CFORMAT", adVarChar, 4
    //  rsarticle.Fields.Append "VFORMAT", adVarChar, 50
    //  rsarticle.Fields.Append "VCOMMENT", adVarChar, 1000
    //  rsarticle.Fields.Append "NTYPEDOC", adInteger
    //  rsarticle.Fields.Append "VTYPE", adVarChar, 40

    //  ' ouverture
    //  rsarticle.Open , , adOpenDynamic, adLockOptimistic

    //Exit Sub
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub

    //private void InitRecordsetArticle()
    //{
    //  try
    //  {    //' initialisation du tableau de recherche des articles
    //    dtArticles.Columns.Add("NSELECT", Type.GetType("System.Int32"));
    //    dtArticles.Columns.Add("NIMAGE", Type.GetType("System.Int32"));
    //    dtArticles.Columns.Add("NACTNUM", Type.GetType("System.Int32"));
    //    dtArticles.Columns.Add("VIMAGE", Type.GetType("System.String"));
    //    dtArticles.Columns.Add("VFICHIER", Type.GetType("System.String"));
    //    dtArticles.Columns.Add("CFORMAT", Type.GetType("System.String"));
    //    dtArticles.Columns.Add("VFORMAT", Type.GetType("System.String"));
    //    dtArticles.Columns.Add("VCOMMENT", Type.GetType("System.String"));
    //    dtArticles.Columns.Add("NTYPEDOC", Type.GetType("System.Int32"));
    //    dtArticles.Columns.Add("VTYPE", Type.GetType("System.String"));
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}",
    //                    Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    //  }
    //}

    //Private Sub InitApiTgrid()
    //On Error GoTo handler
    //  apiTGrid1.AddColumn "§Sélectionner§", "NSELECT", 1500, , , , , True
    //  apiTGrid1.AddColumn "§N° Image§", "NIMAGE", 1000
    //  apiTGrid1.AddColumn "§Image§", "VIMAGE", 1500
    //  apiTGrid1.AddColumn "§Fichier§", "VFICHIER", 2500
    //  apiTGrid1.AddColumn "§Code Fmt§", "CFORMAT", 0
    //  apiTGrid1.AddColumn "§Format§", "VFORMAT", 1000
    //  apiTGrid1.AddColumn "§Commentaire§", "VCOMMENT", 3500
    //  apiTGrid1.AddColumn "NTYPEDOC", "NTYPEDOC", 0
    //  apiTGrid1.AddColumn "VTYPE", "VTYPE", 0
    //  apiTGrid1.AddColumn "§N° Action§", "NACTNUM", 0
    //  apiTGrid1.DelockColumn "NSELECT"
    //  apiTGrid1.Init rsarticle
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitApiTgrid dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGrid1_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();

      switch (row["VTYPE"].ToString())
      {
        case "FACTURE":
          // facture saisie dans ravel ou pas encore saisie
          if (Convert.ToInt32(row["NIMAGE"]) > 0)
            mstrFile = row["VFICHIER"].ToString();
          else
            mstrFile = mstrRepFacSTF + row["VFICHIER"].ToString();
          break;
        case "FACTURECOT":
        case "RETCHANTIER":
          mstrFile = GenerateListeArtRetChantier(Convert.ToInt64(row["NIMAGE"]));
          break;
        default:
          mstrFile = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST") ? mstrRepAtt : mstrRepImage;
          mstrFile += row["VFICHIER"];
          break;
      }

      WebBrowser1.Navigate(mstrFile);
    }
    //Private Sub apiTGrid1_Click()

    //    If rsarticle("VTYPE") = "FACTURE" Then
    //        ' facture saisie dans ravel ou pas encore saisie
    //        If rsarticle("NIMAGE") = 0 Then
    //            strFile = rsarticle("VFICHIER")
    //        Else
    //            strFile = strRepFacSTF & rsarticle("VFICHIER")
    //        End If
    //  ElseIf rsarticle("VTYPE") = "FACTURECOT" Then
    //    strFile = strRepFacCOT & rsarticle("VFICHIER")
    //  ElseIf rsarticle("VTYPE") = "RETCHANTIER" Then
    //    strFile = GenerateListeArtRetChantier(rsarticle("NIMAGE"))
    //  Else
    //    strFile = IIf(rsarticle("VTYPE") = "ATTACH" Or rsarticle("VTYPE") = "GAMME" Or rsarticle("VTYPE") = "ATTEST", strRepAtt, mRepertoireDoc) & rsarticle("VFICHIER")
    //  End If

    //    WebBrowser1.Navigate2 "about:blank"
    //    WebBrowser1.Navigate2 strFile
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CmdAddPJ_Click(object sender, EventArgs e)
    {
      lstPJSelect.Clear();

      string strFile;

      foreach (DataRow row in dtArticles.Rows)
      {
        C_PJ PJ = new C_PJ();

        if ((bool)row["NSELECT"])
        {
          PJ.NIMAGE = Convert.ToInt64(row["NIMAGE"]);

          switch (row["VTYPE"].ToString())
          {
            //facture saisie dans Ravel ou pas encore saisie
            case "FACTURE":
              if (Convert.ToInt32(row["NIMAGE"]) == 0)
                strFile = "";
              else
                strFile = mstrRepFacSTF;
              break;
            case "FACTURECOT":
              strFile = mstrRepFacCOT;
              break;
            case "RETCHANTIER":
              strFile = "";
              break;
            default:
              strFile = (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME" || row["VTYPE"].ToString() == "ATTEST") ? mstrRepAtt : mstrRepImage;
              break;
          }
          PJ.PATH_FILE = strFile;
          PJ.VFICHIER = row["VFICHIER"].ToString();
          PJ.VIMAGE = row["VIMAGE"].ToString();
          lstPJSelect.Add(PJ);
        }
      }
      if (lstPJSelect.Count > 0)
        Close();
    }
    //Private Sub CmdAddPJ_Click()
    //    Dim strFile As String
    //    iNbFileSelect = 0
    //    If rsarticle.RecordCount > 0 Then
    //        rsarticle.MoveFirst
    //        While Not rsarticle.EOF
    //            'init
    //            strFile = ""
    //            If rsarticle("NSELECT") = -1 Then
    //                'MsgBox "Fichier sélectionné : " & rsarticle("VFICHIER")
    //                ReDim Preserve LstPJSelect(iNbFileSelect)
    //                LstPJSelect(iNbFileSelect).Init
    //                LstPJSelect(iNbFileSelect).Set_NIMAGE = rsarticle("NIMAGE")
    //                If rsarticle("VTYPE") = "FACTURE" Then
    //                    ' facture saisie dans ravel ou pas encore saisie
    //                    If rsarticle("NIMAGE") = 0 Then
    //                        strFile = ""
    //                    Else
    //                        strFile = strRepFacSTF
    //                    End If
    //                ElseIf rsarticle("VTYPE") = "FACTURECOT" Then
    //                    strFile = strRepFacCOT
    //                ElseIf rsarticle("VTYPE") = "RETCHANTIER" Then
    //                    strFile = ""
    //                Else
    //                    strFile = IIf(rsarticle("VTYPE") = "ATTACH" Or rsarticle("VTYPE") = "GAMME" Or rsarticle("VTYPE") = "ATTEST", strRepAtt, mRepertoireDoc)
    //                End If
    //                LstPJSelect(iNbFileSelect).Set_PATH_FILE = strFile
    //                LstPJSelect(iNbFileSelect).Set_VFICHIER = rsarticle("VFICHIER")
    //                LstPJSelect(iNbFileSelect).Set_VIMAGE = rsarticle("VIMAGE")
    //                iNbFileSelect = iNbFileSelect + 1
    //            End If
    //            rsarticle.MoveNext
    //        Wend
    //    End If
    //    If iNbFileSelect > 0 Then Unload Me
    //End Sub


    /* OK --------------------------------------------------------------------------------------- */
    private string GenerateListeArtRetChantier(long lNumRetourChantier)
    {
      StringBuilder strHtml = new StringBuilder();
      string sSQL;
      DataTable dtImpList = new DataTable();
      try
      {
        sSQL = "SELECT VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, FSTOCKPUHT, NSTOCKQTE FROM TSTOCK INNER JOIN TFOU ON TSTOCK.NFOUNUM = TFOU.NFOUNUM " +
          "INNER JOIN TSTOCKRETOUR ON TSTOCKRETOUR.NSTOCKNUM = TSTOCK.NSTOCKNUM WHERE TSTOCKRETOUR.NRETNUM = " + lNumRetourChantier.ToString();
        using (SqlCommand cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
        {
          SqlDataAdapter ds = new SqlDataAdapter(cmd);
          ds.Fill(dtImpList);
        }

        strHtml.Append("<html><head><title> </title></head><body>\r\n)");

        if (dtImpList.Rows.Count > 0)
        {
          //    ' titre du document
          strHtml.Append(@"<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" + MozartParams.NomSociete + " </H2></TD>");
          strHtml.Append("<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Liste des articles d'un retour chantier :</CENTER></H3></TD>");
          strHtml.Append("<TD width=15%><H3>le " + DateTime.Now.ToShortDateString() + "</H3></TD></TR></TABLE>");

          //      ' Tableau des jours du mois
          strHtml.Append("<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>\r\n");
          strHtml.Append("<td width=18% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Matériel</b></FONT></td>");
          strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Marque</b></FONT></td>");
          strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Type</b></FONT></td>");
          strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Référence</b></FONT></td>");
          strHtml.Append("<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Prix U</b></FONT></td>");
          strHtml.Append("<td width=10% bgcol);or=#B0C0CC align='center'><font face=Arial size=1><b>Quantité</b></FONT></td>");
          strHtml.Append("</tr>\r\n");
          foreach (DataRow row in dtImpList.Rows)
          {
            //' personne  et planning de cette personne);
            strHtml.Append("<tr><td bgcolor=white><font face=Arial size=1>" + row["VFOUMAT"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white><font face=Arial size=1>" + row["VFOUMAR"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white><font face=Arial size=1>" + row["VFOUTYP"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white><font face=Arial size=1>" + row["VFOUREF"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align='right'><font face=Arial size=1>" + row["FSTOCKPUHT"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align='right'><font face=Arial size=1>" + row["NSTOCKQTE"] + "</FONT></td> ");
            strHtml.Append("</tr>");
          }
          strHtml.Append("</table>\r\n");
        }

        string lRetFilePath = $"{MozartParams.CheminUtilisateurMozart}tlistretchant.html";
        File.WriteAllText(lRetFilePath, strHtml.ToString());

        return lRetFilePath;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return "";
    }
    // Ces fonctions ne sont plus utiles
    // <<<
    //Public Property Get Get_File(ByVal index As Integer) As String
    //  If index >= 0 And index <= UBound(LstPJSelect) Then
    //      Get_File = LstPJSelect(index).Get_VFICHIER
    //   End If
    //End Property

    //Public Property Get Get_PATH_FILE(ByVal index As Integer) As String
    //  If index >= 0 And index <= UBound(LstPJSelect) Then
    //      Get_PATH_FILE = LstPJSelect(index).Get_PATH_FILE
    //   End If
    //End Property

    //Public Property Get Get_NbFileSelect() As Integer
    //  Get_NbFileSelect = iNbFileSelect
    //End Property
    // >>>

    //Private Function GenerateListeArtRetChantier(ByVal lNumRetourChantier As Long) As String
    //Dim strHtml As String
    //Dim rsImpList As New ADODB.Recordset
    //Dim sSQL As String

    //On Error GoTo handler

    // 'INIT
    // GenerateListeArtRetChantier = ""

    // sSQL = "SELECT VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, FSTOCKPUHT, NSTOCKQTE " _
    //      & "FROM TSTOCK INNER JOIN TFOU ON TSTOCK.NFOUNUM = TFOU.NFOUNUM  " _
    //      & "INNER JOIN TSTOCKRETOUR ON TSTOCKRETOUR.NSTOCKNUM = TSTOCK.NSTOCKNUM " _
    //      & "WHERE TSTOCKRETOUR.NRETNUM = " & CStr(lNumRetourChantier)

    // 'Clone du recordsetlocal
    // rsImpList.Open sSQL, cnx, adOpenDynamic, adLockOptimistic

    // rsImpList.MoveFirst

    //  ccOffset = 0
    //  strHtml = ""

    //  Concat strHtml, "<html><head><title> </title></head><body>" & vbCrLf

    //  If Not rsImpList.EOF Then

    //    ' titre du document
    //    Concat strHtml, "<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & gstrNomSociete & " </H2></TD>"
    //    Concat strHtml, "<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Liste des articles d'un retour chantier :</CENTER></H3></TD>"
    //    Concat strHtml, "<TD width=15%><H3>le " & Date & "</H3></TD></TR></TABLE>"

    //    ' Tableau des jours du mois
    //    Concat strHtml, "<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>" & vbCrLf
    //    Concat strHtml, "<td width=18% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Matériel</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Marque</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Type</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Référence</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Prix U</b></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC align='center'><font face=Arial size=1><b>Quantité</b></FONT></td>"
    //    Concat strHtml, "</tr>" & vbCrLf

    //    While Not rsImpList.EOF
    //      ' personne  et planning de cette personne
    //      Concat strHtml, "<tr><td bgcolor=white><font face=Arial size=1>" & rsImpList("VFOUMAT") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rsImpList("VFOUMAR") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rsImpList("VFOUTYP") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1>" & rsImpList("VFOUREF") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align='right'><font face=Arial size=1>" & rsImpList("FSTOCKPUHT") & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align='right'><font face=Arial size=1>" & rsImpList("NSTOCKQTE") & "</FONT></td> "
    //      Concat strHtml, "</tr>"
    //      rsImpList.MoveNext
    //    Wend

    //   Concat strHtml, "</table>" & vbCrLf

    //  End If

    //  Dim fs As New Scripting.FileSystemObject
    //  Dim ts As TextStream
    //  Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\tlistretchant.html", ForWriting, True)
    //  ts.Write strHtml
    //  ts.Close

    //  GenerateListeArtRetChantier = gstrCheminUtilisateur & "\Mozart\tlistretchant.html"

    //Exit Function
    //handler:
    //  ShowError " GenerateListeArtRetChantier dans " & Me.Name
    //End Function
  }
}

