using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStatGeolocalisation : Form
  {
    //Option Explicit
    //
    //Public npernum As Integer
    //Public vpernom As String
    //Public ddatejour As Date
    //
    //Dim rslocallstInt As adodb.Recordset
    //Dim rsarticle As adodb.Recordset
    //
    //Dim iDistKmsTotJ As Integer

    public int miPernum;
    public string mstrPernom;
    public DateTime mdDateJour;

    DataTable rsarticle = new DataTable();

    int iDistKmTotJ;

    public frmStatGeolocalisation()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------*/
    private void frmStatGeolocalisation_Load(object sender, System.EventArgs e)
    {
      try
      {
        //    Fonctionnement :
        //    On charge un recordset contenant les depart et arrivée du véhicule dans la journée du technicien
        //    On clone ce recodset dans un recordset local
        //    On lie le recordset local avec l'apigrid
        //    Pour sauvegarder les données :
        //    On clone le recordset local dans un autre recordset et je sauve celui ci.
        //    Cela permet de pas perdre la focus de la ligne de l'Apigrid

        string sRequete = "";

        ModuleMain.Initboutons(this);

        //    nom du tech
        Label7.Text = Label7.Text + mstrPernom + " " + Resources.txt_journee_du + " " + mdDateJour.ToShortDateString(); ;

        iDistKmTotJ = 0;

        //    on charge la liste des interventions du technicien dans sa journéee
        sRequete = "SELECT DISTINCT TIPL.NIPLNUM, cast(TIPL.NIPLNUM as varchar(10)) + ' - ' + VSITNOM AS LIBNOM, VCLINOM, NIPLIND, VSITAD1, VSITCP FROM TIPL WITH(NOLOCK) INNER JOIN " +
                    "TACT WITH(NOLOCK) ON TACT.NIPLNUM = TIPL.NIPLNUM INNER JOIN " +
                    "TSIT WITH(NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM INNER JOIN " +
                    "TCLI WITH(NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM " +
                    "WHERE TACT.NPERNUM = " + miPernum.ToString() + " AND DIPLDATJ = '" + mdDateJour.ToShortDateString() + "' ORDER BY NIPLIND";

        DataTable rslocallstInt = new DataTable();
        apiTGrid2.LoadData(rslocallstInt, MozartDatabase.cnxMozart, sRequete);
        apiTGrid2.GridControl.DataSource = rslocallstInt;

        apiTGrid1.LoadData(rsarticle, MozartDatabase.cnxMozart, "exec api_sp_ListeDeplaceTech " + miPernum + ",'" + mdDateJour.ToShortDateString() + "'");
        apiTGrid1.GridControl.DataSource = rsarticle;

        InitTGrid();
        InitTGridLstInt();

        foreach (DataRow row in rsarticle.Rows)
          iDistKmTotJ += Convert.ToInt32(row["FTM8KMS"]);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //    'Fonctionnement :
    //    'On charge un recordset contenant les depart et arrivée du véhicule dans la journée du technicien
    //    'On clone ce recodset dans un recordset local
    //    'On lie le recordset local avec l'apigrid
    //    '
    //    'Pour sauvegarder les données :
    //    'On clone le recordset local dans un autre recordset et je sauve celui ci.
    //    'Cela permet de pas perdre la focus de la ligne de l'Apigrid
    //        
    //    Dim rslocalGeo As adodb.Recordset
    //    Dim sRequete As String
    //
    //    InitBoutons Me, frmMenu
    //        
    //    Set rslocallstInt = New adodb.Recordset
    //    Set rslocalGeo = New adodb.Recordset
    //    
    //    'nom du tech
    //    Label7.Caption = Label7.Caption & vpernom & " §pour la journée du §" & ddatejour
    //    
    //    iDistKmsTotJ = 0
    //    InitRecordsetArticle
    //    
    //    'on charge la liste des interventions du technicien dans sa journéee
    //    sRequete = "SELECT DISTINCT TIPL.NIPLNUM, cast(TIPL.NIPLNUM as varchar(10)) + ' - ' + VSITNOM AS LIBNOM, VCLINOM, NIPLIND, VSITAD1, VSITCP FROM TIPL WITH(NOLOCK) INNER JOIN " & _
    //                "TACT WITH(NOLOCK) ON TACT.NIPLNUM = TIPL.NIPLNUM INNER JOIN " & _
    //                "TSIT WITH(NOLOCK) ON TSIT.NSITNUM = TACT.NSITNUM INNER JOIN " & _
    //                "TCLI WITH(NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM " & _
    //                "WHERE TACT.NPERNUM = " & CStr(npernum) & " AND DIPLDATJ = '" & ddatejour & "' ORDER BY NIPLIND"
    //    
    //    rslocallstInt.Open sRequete, cnx, adOpenStatic, adLockReadOnly
    //    rslocalGeo.Open "exec api_sp_ListeDeplaceTech " & CStr(npernum) & ",'" & ddatejour & "'", cnx, adOpenStatic, adLockOptimistic
    //    
    //    While rslocalGeo.EOF = False
    //        Call AjouterEnreg(rslocalGeo)
    //        rslocalGeo.MoveNext
    //    Wend
    //    
    //    rslocalGeo.Close
    //    Set rslocalGeo = Nothing
    //    
    //    InitTGrid
    //    InitTGridLstInt
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      //    insert dans tdepl
      DataTable adoRsSave = new DataTable();

      adoRsSave = rsarticle.Copy();
      foreach (DataRow rowCont in adoRsSave.Rows)
      {
        ModuleData.ExecuteNonQuery("exec api_sp_CreationDeplaceTech " + rowCont["NTM8"] + "," + rowCont["NIPLNUM"]);
      }

      adoRsSave = null;
    }
    //Private Sub cmdValider_Click()
    //
    //    Dim adoRsSave As adodb.Recordset
    //
    //    'insert dans tdepl
    //    If rsarticle.RecordCount = 0 Then Exit Sub
    //    
    //    Set adoRsSave = rsarticle.Clone
    //    
    //    adoRsSave.MoveFirst
    //    While adoRsSave.EOF = False
    //        cnx.Execute ("exec api_sp_CreationDeplaceTech " & adoRsSave("NTM8") & "," & adoRsSave("NIPLNUM"))
    //        adoRsSave.MoveNext
    //    Wend
    //    adoRsSave.Close
    //    Set adoRsSave = Nothing
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void CmdVisu_Click(object sender, EventArgs e)
    {
      GenerateStatsDeplTech();
      frmBrowser f = new frmBrowser();
      f.msStartingAddress = MozartParams.CheminUtilisateurMozart + @"tgeoloc.html";
      f.ShowDialog();
    }
    //Private Sub CmdVisu_Click()
    //
    //    GenerateStatsDeplTech
    //    
    //    frmBrowser.StartingAddress = gstrCheminUtilisateur & "\Mozart\tgeoloc.html"
    //    frmBrowser.Show vbModal
    //
    //End Sub

    /* Inutile --------------------------------------------------------------------------*/
    private void InitRecordsetArticle()
    {

    }
    //Private Sub InitRecordsetArticle()
    //
    //On Error GoTo Handler
    //
    //' initialisation du tableau de recherche des articles
    //  Set rsarticle = New adodb.Recordset
    //  
    //  ' ajout des champs au recordset
    //  rsarticle.Fields.Append "NTM8", adBigInt
    //  rsarticle.Fields.Append "VTM8TYPE", adVarChar, 160
    //  rsarticle.Fields.Append "DTM8HORO", adDate
    //  rsarticle.Fields.Append "VTM8VILLE", adVarChar, 160
    //  rsarticle.Fields.Append "FTM8KMS", adDouble
    //  rsarticle.Fields.Append "NIPLNUM", adBigInt
    //  
    //  ' ouverture
    //  rsarticle.Open , , adOpenDynamic, adLockOptimistic
    //   
    //  Exit Sub
    //  
    //Handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //  
    //End Sub

    /* OK INUTILE--------------------------------------------------------------------------*/
    private void AjouterEnreg(DataRow rs)
    {
      //  ajout de l'enregistrement
      DataRow newrow = rsarticle.NewRow();

      newrow["NTM8"] = Utils.ZeroIfNull(rs["NTM8"]);
      newrow["VTM8TYPE"] = Utils.BlankIfNull(rs["VTM8TYPE"]);
      newrow["DTM8HORO"] = Utils.BlankIfNull(rs["DTM8HORO"]);
      newrow["VTM8VILLE"] = Utils.BlankIfNull(rs["VTM8VILLE"]);
      newrow["FTM8KMS"] = Utils.ZeroIfNull(rs["FTM8KMS"]);
      iDistKmTotJ += (int)Utils.ZeroIfNull(rs["FTM8KMS"]);
      newrow["NIPLNUM"] = Utils.ZeroIfNull(rs["NIPLNUM"]);
      rsarticle.Rows.Add(newrow);
    }
    //Private Sub AjouterEnreg(ByVal rs As adodb.Recordset)
    //
    //On Error GoTo Handler
    //
    //  ' ajout de l'enregistrement
    //  rsarticle.AddNew
    //  
    //  rsarticle("NTM8").value = ZeroIfNull(rs("NTM8"))
    //  rsarticle("VTM8TYPE").value = BlankIfNull(rs("VTM8TYPE"))
    //  rsarticle("DTM8HORO").value = ZeroIfNull(rs("DTM8HORO"))
    //  rsarticle("VTM8VILLE").value = BlankIfNull(rs("VTM8VILLE"))
    //  rsarticle("FTM8KMS").value = ZeroIfNull(rs("FTM8KMS"))
    //  iDistKmsTotJ = iDistKmsTotJ + ZeroIfNull(rs("FTM8KMS"))
    //  rsarticle("NIPLNUM").value = ZeroIfNull(rs("NIPLNUM"))
    //  
    //  rsarticle.Update
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    /* Inutile ------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //    If rslocallstInt.State = adStateOpen Then rslocallstInt.Close
    //    If rsarticle.State = adStateOpen Then rsarticle.Close
    //    Set rslocallstInt = Nothing
    //    Set rsarticle = Nothing
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitTGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Num, "NTM8", 0);
      apiTGrid1.AddColumn(Resources.col_Type, "VTM8TYPE", 1100);
      apiTGrid1.AddColumn(Resources.col_date_heure, "DTM8HORO", 2000);
      apiTGrid1.AddColumn(Resources.col_Ville, "VTM8VILLE", 2800);
      apiTGrid1.AddColumn(Resources.col_dist_km, "FTM8KMS", 900);

      apiTGrid1.InitColumnList();
    }
    //Private Sub InitTGrid()
    //  
    //  Dim sRequete As String
    //  
    //  ApiGrid1.AddColumn "NTM8", 0
    //  ApiGrid1.AddColumn "VTM8TYPE", 1100
    //  ApiGrid1.AddColumn "DTM8HORO", 2000
    //  ApiGrid1.AddColumn "§Ville§", 2800
    //  ApiGrid1.AddColumn "§Km§", 900
    //     
    //  'Requete pour remplir la combo
    //  sRequete = "SELECT 0 AS NIPLNUM UNION SELECT TIPL.NIPLNUM FROM TIPL WITH (NOLOCK) INNER JOIN " & _
    //                "TACT WITH (NOLOCK) ON TACT.NIPLNUM = TIPL.NIPLNUM " & _
    //                "WHERE NPERNUM = " & CStr(npernum) & " AND DIPLDATJ = '" & ddatejour & "' " & _
    //                "ORDER BY NIPLNUM"
    //  ApiGrid1.AddCombo cnx, sRequete, 5, 0
    //
    //  ApiGrid1.LockColonne 0
    //  ApiGrid1.LockColonne 1
    //  ApiGrid1.LockColonne 2
    //  ApiGrid1.LockColonne 3
    //  ApiGrid1.LockColonne 4
    //  ApiGrid1.LockColonne 5
    //
    //  ApiGrid1.NotDelete
    //  ApiGrid1.NotDeleteNew
    //  ApiGrid1.NotDeleteUpdate
    //
    //  ApiGrid1.Init rsarticle
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitTGridLstInt()
    {
      apiTGrid2.AddColumn("ID", "NIPLNUM", 0);
      apiTGrid2.AddColumn(Resources.col_Lbl, "LIBNOM", 4500);
      apiTGrid2.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 3000);
      apiTGrid2.AddColumn(Resources.col_Adresse, "VSITAD1", 4500);
      apiTGrid2.AddColumn(Resources.col_CP, "VSITCP", 2000);

      apiTGrid2.InitColumnList();
    }
    //Private Sub InitTGridLstInt()
    //  
    //  apiTGrid2.AddColumn "ID", "NIPLNUM", 0
    //  apiTGrid2.AddColumn "§Libellé§", "LIBNOM", 4500
    //  apiTGrid2.AddColumn "§Client§", "VCLINOM", 3000
    //  apiTGrid2.AddColumn "§Adresse§", "VSITAD1", 4500
    //  apiTGrid2.AddColumn "§CP§", "VSITCP", 2000
    //  apiTGrid2.Init rslocallstInt
    //   
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void GenerateStatsDeplTech()
    {
      StringBuilder strHtml = new StringBuilder();
      DataTable rs = new DataTable();

      int iTotTpsPrevu; //total en minutes du temps prévu sur site
      int iTotTpsReste; //total en minutes du temps resté sur site

      string dHRFirstJ = "";
      string dHRLastJ = "";

      try
      {
        //    INIT
        iTotTpsPrevu = 0;
        iTotTpsReste = 0;

        strHtml.Append("<html><head><title>" + Resources.txt_stat_deplacement_tech + "</title></head><body>");

        string sSQL = "exec api_sp_StatDeplaceTech " + miPernum.ToString() + ", '" + mdDateJour.ToShortDateString() + "'";
        using (SqlCommand cmd = new SqlCommand(sSQL, MozartDatabase.cnxMozart))
        {
          SqlDataAdapter ds = new SqlDataAdapter(cmd);
          ds.Fill(rs);
        }

        if (rs.Rows.Count > 0)
        {

          //    titre du document
          strHtml.Append(@"<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" + MozartParams.NomSociete + " </H2></TD>");
          strHtml.Append(@"<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>" + Resources.txt_stat_deplacement_tech + "<font color=#FF9933> " + mstrPernom + "</font> dans la journée du <font color=#FF9933>" + mdDateJour.ToShortDateString() + " </font></CENTER></H3></TD>");
          strHtml.Append(@"<TD width=15%><H3>le " + DateTime.Now.ToShortDateString() + "</H3></TD></TR></TABLE>");

          //     Tableau des jours du mois
          strHtml.Append(@"<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>");
          strHtml.Append(@"<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + MZCtrlResources.col_Client + "</b></center></FONT></td>");
          strHtml.Append("<td width=18% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.col_Enseigne + "</b></center></FONT></td>");
          strHtml.Append("<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.col_Site + "</b></center></FONT></td>");
          strHtml.Append("<td width=6% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_date_heure_arrivee + "</b></center></FONT></td>");
          strHtml.Append("<td width=6% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_date_heure_depart + "</b></center></FONT></td>");
          strHtml.Append("<td width=6% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_heure_validation + "</b></center></FONT></td>");
          strHtml.Append("<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_diff_tmp_validation + "</b></center></FONT></td>");
          strHtml.Append("<td width=12% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_taches + "</b></FONT></center></td>");
          strHtml.Append("<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_tmp_prevu + "</b></center></FONT></td>");
          strHtml.Append("<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_temps_reste_sur_site + "</b></center></FONT></td>");
          strHtml.Append("<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_diff_tmp_reste_sur_site + "</b></center></FONT></td>");
          strHtml.Append("<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><center><b>" + Resources.txt_assistant_validant + "</b></center></FONT></td>");
          strHtml.Append("</tr>");

          //on récupére les dates de 1 ere journée et fin de journée
          dHRFirstJ = rs.Rows[0]["HRFIRSTJ"].ToString();
          dHRLastJ = rs.Rows[0]["HRLASTJ"].ToString();

          foreach (DataRow row in rs.Rows)
          {
            // personne  et planning de cette personne);
            strHtml.Append("<tr><td bgcolor=white align=center><font face=Arial size=1 color=#0000FF>" + row["VCLINOM"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=center><font face=Arial size=1 color=#0000FF>" + row["VSITENSEIGNE"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=center><font face=Arial size=1 color=#0000FF>" + row["VSITNOM"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + row["HRARR"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + row["HRDEP"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + row["HRVALID"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + ConvertMinInHrMn((long)Utils.ZeroIfNull(row["DIFFHR"])) + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white><font face=Arial size=1 color=#0000FF>" + row["VACTDES"] + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + ConvertMinInHrMn((long)Utils.ZeroIfNull(row["NACTDUREE"])) + "</FONT></td> ");
            strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + ConvertMinInHrMn((long)Utils.ZeroIfNull(row["NTPSRESTSIT"])) + "</FONT></td> ");

            if ((int)Utils.ZeroIfNull(row["DIFFTPS"]) >= 30) strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1 color=#FF3366>" + ConvertMinInHrMn((long)Utils.ZeroIfNull(row["DIFFTPS"])) + "</FONT></td> ");
            else strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1 color=black>" + ConvertMinInHrMn((long)Utils.ZeroIfNull(row["DIFFTPS"])) + "</FONT></td> ");

            strHtml.Append("<td bgcolor=white align=center><font face=Arial size=1>" + row["VPERNOM"] + "</FONT></td> ");
            strHtml.Append("</tr>");
            iTotTpsPrevu += (int)Utils.ZeroIfNull(row["NACTDUREE"]);
            iTotTpsReste += (int)Utils.ZeroIfNull(row["NTPSRESTSIT"]);

          }
          strHtml.Append("<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>TOTAL</FONT></td> ");
          strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + ConvertMinInHrMn(iTotTpsPrevu) + "</FONT></td> ");
          strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + ConvertMinInHrMn(iTotTpsReste) + "</FONT></td> ");
          strHtml.Append("<td bgcolor=white align=right><font face=Arial size=1>" + ConvertMinInHrMn(iTotTpsPrevu - iTotTpsReste) + "</FONT></td> ");

          strHtml.Append("</tr>");
          strHtml.Append("<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>" + Resources.txt_NbKmParcourusDansJour + "</FONT></td> ");
          strHtml.Append("<td bgcolor=white colspan=2 align=right><font face=Arial size=1>" + iDistKmTotJ.ToString() + "</FONT></td> ");
          strHtml.Append("</tr>");

          strHtml.Append("<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>" + Resources.txt_FirstHourDepJour + "</FONT></td> ");
          strHtml.Append("<td bgcolor=white colspan=2 align=right><font face=Arial size=1>" + dHRFirstJ + "</FONT></td> ");
          strHtml.Append("</tr>");

          strHtml.Append("<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>" + Resources.txt_LastHourArrJour + "</FONT></td> ");
          strHtml.Append("<td bgcolor=white colspan=2 align=right><font face=Arial size=1>" + dHRLastJ + "</FONT></td> ");
          strHtml.Append("</tr>");

          strHtml.Append("</table> \r\n");
        }
        strHtml.Append("</body></html>");

        File.WriteAllText(MozartParams.CheminUtilisateurMozart + @"tgeoloc.html", strHtml.ToString(), Encoding.UTF8);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub GenerateStatsDeplTech()
    //
    //Dim strHtml As String
    //Dim rs As New Recordset
    //
    //Dim iTotTpsPrevu As Integer  'total en minutes du temps prévu sur site
    //Dim iTotTpsReste As Integer   'total en minutes du temps resté sur site
    //
    //Dim dHRFirstJ As String
    //Dim dHRLastJ As String
    //
    //  On Error GoTo Handler
    //
    //    'INIT
    //    strHtml = ""
    //    iTotTpsPrevu = 0
    //    iTotTpsReste = 0
    //      
    //  Concat strHtml, "<html><head><title> Statistiques Déplacements technicien</title></head><body>" & vbCrLf
    //    
    //  rs.Open "exec api_sp_StatDeplaceTech " & CStr(npernum) & ", '" & ddatejour & "'", cnx, adOpenStatic, adLockReadOnly
    //
    //  If Not rs.EOF Then
    //    
    //    ' titre du document
    //    Concat strHtml, "<TABLE width=100%><TR><TD width=20% """"style=font-face=tahoma; font-size=24pt;""""><H2>" & gstrNomSociete & " </H2></TD>"
    //    Concat strHtml, "<TD width=65% style=font-face=arial; font-size=18pt;><H3><Center>Statistiques des déplacements du technicien <font color=#FF9933>" & vpernom & "</font> dans la journée du <font color=#FF9933>" & ddatejour & " </font></CENTER></H3></TD>"
    //    Concat strHtml, "<TD width=15%><H3>le " & Date & "</H3></TD></TR></TABLE>"
    // 
    //    ' Tableau des jours du mois
    //    Concat strHtml, "<table border=1 cellpadding=0 cellspacing =0 widht=100%><tr>" & vbCrLf
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Client</b></center></FONT></td>"
    //    Concat strHtml, "<td width=18% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Enseigne</b></center></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Site</b></center></FONT></td>"
    //    Concat strHtml, "<td width=6% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Date/Heure arrivée</b></center></FONT></td>"
    //    Concat strHtml, "<td width=6% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Date/Heure départ</b></center></FONT></td>"
    //    Concat strHtml, "<td width=6% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Heure validation</b></center></FONT></td>"
    //    Concat strHtml, "<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Différence temps de validation</b></center></FONT></td>"
    //    Concat strHtml, "<td width=12% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Tâches</b></FONT></center></td>"
    //    Concat strHtml, "<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Temps prévu</b></center></FONT></td>"
    //    Concat strHtml, "<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Temps resté sur site</b></center></FONT></td>"
    //    Concat strHtml, "<td width=5% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Différence temps resté sur site</b></center></FONT></td>"
    //    Concat strHtml, "<td width=10% bgcolor=#B0C0CC><font face=Arial size=1><center><b>Assistant(e) validant</b></center></FONT></td>"
    //    Concat strHtml, "</tr>" & vbCrLf
    //    
    //    'on récupére les dates de 1 ere journée et fin de journée
    //    rs.MoveFirst
    //    dHRFirstJ = rs("HRFIRSTJ")
    //    dHRLastJ = rs("HRLASTJ")
    //    
    //    While Not rs.EOF
    //      ' personne  et planning de cette personne
    //      Concat strHtml, "<tr><td bgcolor=white align=center><font face=Arial size=1 color=#0000FF>" & BlankIfNull(rs("VCLINOM")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=center><font face=Arial size=1 color=#0000FF>" & BlankIfNull(rs("VSITENSEIGNE")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=center><font face=Arial size=1 color=#0000FF>" & BlankIfNull(rs("VSITNOM")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & BlankIfNull(rs("HRARR")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & BlankIfNull(rs("HRDEP")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & BlankIfNull(rs("HRVALID")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & ConvertMinInHrMn(ZeroIfNull(rs("DIFFHR"))) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white><font face=Arial size=1 color=#0000FF>" & BlankIfNull(rs("VACTDES")) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & ConvertMinInHrMn(ZeroIfNull(rs("NACTDUREE"))) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & ConvertMinInHrMn(ZeroIfNull(rs("NTPSRESTSIT"))) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1 color=" & IIf(Abs(ZeroIfNull(rs("DIFFTPS"))) >= 30, "#FF3366", "black") & ">" & ConvertMinInHrMn(ZeroIfNull(rs("DIFFTPS"))) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=center><font face=Arial size=1>" & BlankIfNull(rs("VPERNOM")) & "</FONT></td> "
    //
    //      Concat strHtml, "</tr>"
    //      
    //      iTotTpsPrevu = iTotTpsPrevu + ZeroIfNull(rs("NACTDUREE"))
    //      iTotTpsReste = iTotTpsReste + ZeroIfNull(rs("NTPSRESTSIT"))
    //      
    //      rs.MoveNext
    //    Wend
    //    
    //      Concat strHtml, "<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>TOTAL</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & ConvertMinInHrMn(CStr(iTotTpsPrevu)) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & ConvertMinInHrMn(CStr(iTotTpsReste)) & "</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white align=right><font face=Arial size=1>" & ConvertMinInHrMn(CStr(iTotTpsPrevu - iTotTpsReste)) & "</FONT></td> "
    //
    //      Concat strHtml, "</tr>"
    //      Concat strHtml, "<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>Nb de kms parcourus dans la journée</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white colspan=2 align=right><font face=Arial size=1>" & CStr(iDistKmsTotJ) & "</FONT></td> "
    //      Concat strHtml, "</tr>"
    //      
    //      Concat strHtml, "<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>1ère Heure de départ de la journée</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white colspan=2 align=right><font face=Arial size=1>" & dHRFirstJ & "</FONT></td> "
    //      Concat strHtml, "</tr>"
    //      
    //      Concat strHtml, "<tr><td bgcolor=#99FFFF colspan=8 align=right><font face=Arial size=1>Dernière Heure d' arrivée de la journée</FONT></td> "
    //      Concat strHtml, "<td bgcolor=white colspan=2 align=right><font face=Arial size=1>" & dHRLastJ & "</FONT></td> "
    //      Concat strHtml, "</tr>"
    //  
    //      Concat strHtml, "</table>" & vbCrLf
    // 
    //  End If
    //  
    //  rs.Close
    //
    //  Concat strHtml, "</body></html>"
    //  strHtml = Left$(strHtml, ccOffset)
    //  
    //  Dim fs As New Scripting.FileSystemObject
    //  Dim ts As TextStream
    //  Set ts = fs.OpenTextFile(gstrCheminUtilisateur & "\Mozart\tgeoloc.html", ForWriting, True)
    //  ts.Write strHtml
    //  ts.Close
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError " GenerateStatsDeplTech dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private string ConvertMinInHrMn(long totmin)
    {

      string sH = "", sM = "", signe = "";

      if (totmin < 0)
      {
        totmin *= -1;
        signe = "-";
      }

      sH = totmin < 60 ? "0" : (totmin / 60).ToString();
      sM = (totmin % 60).ToString();
      return $"{signe} {sH}H {sM}M";
    }
    //Private Function ConvertMinInHrMn(ByVal totmin As Long) As String
    //
    //    Dim sH As String
    //    Dim sM As String
    //    Dim symbole As String
    //    
    //    If totmin < 0 Then
    //        totmin = totmin * (-1)
    //        symbole = "-"
    //    End If
    //    
    //    sH = Str(Int(IIf(totmin < 60, 0, totmin / 60)))
    //    sM = Format$(totmin Mod 60, "00")
    //    ConvertMinInHrMn = symbole & " " & sH & "H " & sM & "M"
    //
    //End Function
  }
}

