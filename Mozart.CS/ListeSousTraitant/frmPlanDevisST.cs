using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmPlanDevisST : frmPlanSTBase
  {
    public frmPlanDevisST() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmPlanDevisST_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    protected override void InitSqlDataAdapter(DateTime jour)
    {
      daJours.SelectCommand.CommandText = $"api_sp_listePlanningDevisST '{jour.ToShortDateString()}'";
    }

    protected override void InitElementRdv(ref ElementRdv elem, DataRow row)
    {
      // constitution du tag d'une IP ( NumContrat, DI, NumAction, numST, Date)
      elem.Tag = $"{row["NDSTNUM"]}#{row["NDINNUM"]}#{row["NACTNUM"]}#{row["NINTNUM"]}#{Convert.ToDateTime(row["DDSTDRE"]).ToShortDateString()}";
      // couleur standart = bleu clair (HFFFFC0)
      elem.BackColor = MozartColors.ColorHFFFFC0;
      // si recu
      if (row["VDSTSTA"].ToString() == "Reçu") elem.BackColor = MozartColors.ColorHC0FFC0;
      // affichage des informations dans l'image
      elem.Ligne1 = $"{row["VCLINOM"]}";
      elem.Ligne2 = $"{row["VSITNOM"]}";
      elem.Ligne3 = $"{row["VSTFNOM"].ToString().Substring(0, Math.Min(14, row["VSTFNOM"].ToString().Length))}    1{row["CPRECOD"]}";
    }

    //Public mdSemaine As Date
    //
    //Dim inumContrat As Long
    //
    //Dim RSlun As New ADODB.Recordset
    //Dim RSmar As New ADODB.Recordset
    //Dim RSmer As New ADODB.Recordset
    //Dim RSjeu As New ADODB.Recordset
    //Dim RSven As New ADODB.Recordset
    //Dim RSsam As New ADODB.Recordset
    //
    //Dim DebutSemaine As Date
    //
    //' nombre d'images chargées dans le planning
    //Dim iNbrImage As Integer
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //  
    //  
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  iNbrImage = 0
    //  
    //  ' initialisation date
    //  mdSemaine = Date
    //    
    //  ' ouverture des recordsets
    //  GetContrats True, "S"
    //    
    //  pic(0).Visible = False
    //    
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor = Cursors.Default;
    }
    //Private Sub cmdImprimer_Click()
    //  
    //  ' fonction d'impression écran
    //  Screen.MousePointer = vbHourglass
    //  ImprimerDansWord
    //  Screen.MousePointer = vbDefault
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
    //' fermeture du recordset
    //On Error Resume Next
    //
    //  RSlun.Close
    //  RSmar.Close
    //  RSmer.Close
    //  RSjeu.Close
    //  RSven.Close
    //  RSsam.Close
    //  
    //Unload Me
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // voir frmPlanSTBase
    //Private Sub GetContrats(bPremierFois As Boolean, sDirection As String)
    //
    //Dim i As Integer
    //' UPGRADE_INFO (#0501): The 'k' member isn't used anywhere in current application.
    //' Dim k As Integer
    //
    //On Error GoTo handler
    //
    //'fonction qui donne le premier jour de la semaine (lundi)
    //DebutSemaine = Format(DateAdd("d", -(Weekday(mdSemaine) - 2), mdSemaine), "dd/mm/yyyy")
    //
    //' recherche du numéro de semaine
    //lblSemaine.Caption = ISO_WEEK(DebutSemaine) 'DatePart("ww", DebutSemaine)
    //
    //' affichage des jours de la semaine ( prise en compte des congés )
    //For i = 0 To 5
    //  Label1(i).Caption = Format(DateAdd("d", i, DebutSemaine), "dddd d mmm")
    //  If IsFeriee(DateAdd("d", i, DebutSemaine)) Then
    //        Label1(i).BackColor = &HFF&
    //  Else
    //        Label1(i).BackColor = &H8000000F
    //  End If
    //  
    //Next
    //
    //' liste des interventions
    //If bPremierFois Then
    //  ' liste des interventions par sous traitant pour la semaine en cours
    //  Set RSlun = New ADODB.Recordset
    //  Set RSmar = New ADODB.Recordset
    //  Set RSmer = New ADODB.Recordset
    //  Set RSjeu = New ADODB.Recordset
    //  Set RSven = New ADODB.Recordset
    //  Set RSsam = New ADODB.Recordset
    //
    //  RSlun.Open "api_sp_listePlanningDevisST  '" & DebutSemaine & "'", cnx
    //  RSmar.Open "api_sp_listePlanningDevisST  '" & Format(DateAdd("d", 1, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSmer.Open "api_sp_listePlanningDevisST  '" & Format(DateAdd("d", 2, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSjeu.Open "api_sp_listePlanningDevisST  '" & Format(DateAdd("d", 3, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSven.Open "api_sp_listePlanningDevisST  '" & Format(DateAdd("d", 4, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSsam.Open "api_sp_listePlanningDevisST  '" & Format(DateAdd("d", 5, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //
    //Else
    //  ' traitement des cas suivant et précédent
    //  If sDirection = "S" Then
    //    'rien car on est déja bien placé
    //    ' a moins que l'on soit eof, alors on sort
    //    'If rst.EOF Then Exit Sub
    //  Else
    //    'on remonte
    //    If Not RSlun.BOF Then RSlun.MoveFirst
    //    If Not RSmar.BOF Then RSmar.MoveFirst
    //    If Not RSmer.BOF Then RSmer.MoveFirst
    //    If Not RSjeu.BOF Then RSjeu.MoveFirst
    //    If Not RSven.BOF Then RSven.MoveFirst
    //    If Not RSsam.BOF Then RSsam.MoveFirst
    //  End If
    //End If
    //
    //' on décharge les images
    //For i = 1 To iNbrImage
    //  Unload pic(i)
    //Next
    //
    //iNbrImage = 0
    //
    //InitialiserPlanning RSlun
    //InitialiserPlanning RSmar
    //InitialiserPlanning RSmer
    //InitialiserPlanning RSjeu
    //InitialiserPlanning RSven
    //InitialiserPlanning RSsam
    //
    //Exit Sub
    //handler:
    //  ShowError "GetContrat dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // voir frmPlanSTBase
    //Private Sub InitialiserPlanning(ByVal rs As ADODB.Recordset)
    //
    //Dim k As Integer
    //Dim j As Integer
    //Dim inter As String
    //  
    //
    //On Error GoTo handler
    //
    //' placement des interventions
    //k = iNbrImage
    //j = 0
    //
    //  ' parcours des interventions par sous traitant pour la semaine en cours
    //    While (Not rs.EOF) And j < 13
    //      
    //      k = k + 1
    //      j = j + 1
    //      
    //      ' création d'une image
    //      Load pic(k)
    //      
    //      
    //      ' coordonnées de l'image
    //      pic(k).Left = lJour(Weekday(rs("DDSTDRE")) - 2).X1
    //      pic(k).Top = lHeure(j - 1).Y1 + 25
    //       
    //      ' constitution du tag d'une IP ( NumContrat, DI, NumAction, numST, Date)
    //      pic(k).Tag = rs("NDSTNUM") & "#" & rs("NDINNUM") & "#" & rs("NACTNUM") & "#" & rs("NINTNUM") & "#" & rs("DDSTDRE")
    //      
    //      'couleur standart = bleu clair
    //      pic(k).BackColor = &HFFFFC0
    //              
    //      ' si recu
    //      If rs("VDSTSTA") = "Reçu" Then pic(k).BackColor = &HC0FFC0
    //       
    //      ' affichage des informations dans l'image
    //      inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & Left(rs("VSTFNOM"), 14) & "    1" & rs("CPRECOD")
    //            
    //      pic(k).Print inter
    //      
    //      pic(k).Visible = True
    //            
    //      ' enregistrement suivant
    //      rs.MoveNext
    //      
    //    Wend
    //    
    //'  RS.Close
    //
    //' nombre d'images chargées
    //iNbrImage = iNbrImage + j
    //  
    //
    //Exit Sub
    //handler:
    //  ShowError "InitialiserPlanning dans " & Me.Name
    //End Sub
    //
    //'***************************************************************************************************
    //'***************************************************************************************************
    //
    /* --------------------------------------------------------------------------------------- */
    protected override void DeplaceElement(ElementRdv rdv, DateTime newDate)
    {
      string[] rdvTag = rdv.Tag.ToString().Split('#');
      ModuleData.ExecuteNonQuery($"update TDST set DDSTDRE = '{newDate.ToShortDateString()}' where ndstnum = {rdvTag[0]}");
    }
    // voir frmPlanSTBase
    //Private Sub Form_DragDrop(Source As Control, X As Single, Y As Single)
    //
    //' UPGRADE_INFO (#0501): The 'ado_cmd' member isn't used anywhere in current application.
    //' Dim ado_cmd As New ADODB.Command
    //
    //Dim j As Integer
    //' UPGRADE_INFO (#0501): The 'indice' member isn't used anywhere in current application.
    //' Dim indice As Integer
    //' UPGRADE_INFO (#0501): The 'iTech' member isn't used anywhere in current application.
    //' Dim iTech As Integer
    //Dim datepla As String
    //' UPGRADE_INFO (#0501): The 'strSQL' member isn't used anywhere in current application.
    //' Dim strSQL As String
    //Dim MyTab
    //Dim Out As Boolean
    //' UPGRADE_INFO (#0501): The 'h' member isn't used anywhere in current application.
    //' Dim h As Integer
    //
    //  ' initialisation
    //  Out = True
    //
    //  ' recherche des info dans le tag de l'image
    //  MyTab = Split(Source.Tag, "#")
    //
    //  ' test pour empecher de sortir du planning
    //  If X > lJour(6).X1 Then Exit Sub
    //  If X < lJour(0).X1 Then Exit Sub
    //  If Y > lHeure(14).Y1 Then Exit Sub
    //  If Y < lHeure(0).Y1 Then Exit Sub
    //  
    //    
    //  ' definition du jour ou on pose
    //  For j = 5 To 0 Step -1
    //    If X > lJour(j).X1 Then
    //      datepla = DateAdd("d", j, DebutSemaine)
    //      Source.Left = lJour(j).X1
    //      Exit For
    //    End If
    //  Next
    //
    //  On Error Resume Next
    //  Dim strQ As String
    //  
    //  strQ = "update TDST set DDSTDRE = '" & datepla & "' where ndstnum = " & MyTab(0)
    //  cnx.Execute strQ
    //
    //'  If Mytab(2) <> "" Then
    //'    strQ = "update TACT set DACTPLA = '" & datepla & "' where nactnum = " & Mytab(2)
    //'    cnx.Execute strQ
    //'  End If
    //  
    //  ' réinitialisation de l'affichage
    //  GetContrats True, "S"
    //
    //End Sub
    //
    //' passage a la page suivante
    /* --------------------------------------------------------------------------------------- */
    private void cmdTechS_Click(object sender, EventArgs e)
    {
      ElementsSuivants();
    }
    //Private Sub cmdTechS_Click()
    //
    //  GetContrats False, "S"
    //
    //End Sub
    //
    //' passage au technicien précédent
    /* --------------------------------------------------------------------------------------- */
    private void cmdTechP_Click(object sender, EventArgs e)
    {
      ElementsPrecedants();
    }
    //Private Sub cmdTechP_Click()
    //  
    //  ' ouverture des recordsets
    //  GetContrats False, "P"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdPrec_Click(object sender, EventArgs e)
    {
      SemainePrecedante();
    }
    //Private Sub cmdPrec_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", -7, DebutSemaine)
    //  GetContrats True, "S"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSuiv_Click(object sender, EventArgs e)
    {
      SemaineSuivante();
    }
    //Private Sub cmdSuiv_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", 7, DebutSemaine)
    //  GetContrats True, "S"
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // voir frmPlanSTBase
    //Private Sub pic_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    //
    //Dim MyTabPic
    //
    //  ' recherche de l'IP dans le tag de l'image
    //  MyTabPic = Split(pic(Index).Tag, "#")
    //  glNumAction = MyTabPic(2)
    //  giNumDi = MyTabPic(1)
    //  inumContrat = MyTabPic(0)
    //  
    // If Button = 2 Then
    //      PopupMenu mnuAffichage
    //  End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // voir frmPlanSTBase
    //Private Sub mnuDetails_Click()
    //
    //  ' si on est pas sur une IP on sort
    //  If giNumDi = 0 Then Exit Sub
    //    
    //  ' écran de modification de l' action
    //  frmDetailstravaux.mstrStatutAction = "M"
    //  
    //  On Error Resume Next
    //  
    //  frmDetailstravaux.Show vbModal
    //    
    //  If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran et déjà chargé en arrière plan§"
    //    
    //  
    //End Sub
    //
    protected override void SetBoutonElemSuivEnable(bool bEnable) { cmdTechS.Enabled = bEnable; }
    protected override void SetBoutonElemPrecEnable(bool bEnable) { cmdTechP.Enabled = bEnable; }
  }
}

