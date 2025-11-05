using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  /* Form de base pour les forms frmPlanContratST et frmPlanDevisST 
   * Implémente l'affichage et la gestion du planning
   * les aspects spécifiques sont implémentés dans les forms spécialisées  
     */
  public partial class frmPlanSTBase : Form
  {
    public DateTime mdSemaine;

    protected DateTime DebutSemaine;
    protected DataSet dsJours;
    protected SqlDataAdapter daJours;
    protected static readonly string[] libJours = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };
    // numéro de page pour faire défiler les éléments (contrats/devis)
    int PageNum;
    // nombre maximum d'élément pour un jour de la semaine en cours (sert pour le calcul des pages)
    int ElemJourMax;

    //int inumContrat; //affecté mais inutilisé

    protected class ElementRdv
    {
      public object Tag;
      public Color BackColor;
      public string Ligne1;
      public string Ligne2;
      public string Ligne3;
      public bool Visible = false;

      readonly int hLigne = 14;

      public void DrawElement(TableLayoutCellPaintEventArgs e, Font f)
      {
        if (!Visible) return;

        Graphics g = e.Graphics;
        int y = e.CellBounds.Location.Y + 1;

        g.FillRectangle(new SolidBrush(BackColor),
                        e.CellBounds.Location.X + 1,
                        y,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 2);

        if (Ligne1 != null)
        {
          e.Graphics.DrawString(Ligne1, f, Brushes.Black, new RectangleF(e.CellBounds.Location.X + 1, y, e.CellBounds.Width - 2, hLigne));
          y += hLigne;
        }
        if (Ligne2 != null)
        {
          e.Graphics.DrawString(Ligne2, f, Brushes.Black, new RectangleF(e.CellBounds.Location.X + 1, y, e.CellBounds.Width - 2, hLigne));
          y += hLigne;
        }
        if (Ligne3 != null)
        {
          e.Graphics.DrawString(Ligne3, f, Brushes.Black, new RectangleF(e.CellBounds.Location.X + 1, y, e.CellBounds.Width - 2, hLigne));
          y += hLigne;
        }
      }
    }

    protected Font fontRdv = new Font("MS Sans Serif", 8);
    protected ElementRdv[,] elementsRdv;

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

    public frmPlanSTBase() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmPlanSTBase_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        //ModuleMain.Initboutons(this);//appel dans les forms spécialisées

        elementsRdv = new ElementRdv[tablePlanning.RowCount - 2, libJours.Length];
        for (int c = 0; c < tablePlanning.ColumnCount; c++)
        {
          for (int l = 0; l < tablePlanning.RowCount - 2; l++)
            elementsRdv[l, c] = new ElementRdv();
        }

        // initialisation date
        mdSemaine = DateTime.Today;

        // ouverture des recordsets => donnees
        dsJours = new DataSet("plannings");
        daJours = new SqlDataAdapter();
        daJours.SelectCommand = new SqlCommand();
        daJours.SelectCommand.Connection = MozartDatabase.cnxMozart;

        GetContrats();

        tablePlanning.CellPaint += tablePlanning_CellPaint;

        InitialiserPlanningsTous();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    ElementRdv GetElementFromTable(int ligne, int colonne)
    {
      if (ligne <= 0 || ligne >= tablePlanning.RowCount - 1 || colonne < 0 || colonne > tablePlanning.ColumnCount - 1) return null;
      return elementsRdv[ligne - 1, colonne];
    }

    private void tablePlanning_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
      if (null == elementsRdv || e.Row == 0 || e.Row == tablePlanning.RowCount - 1) return;

      GetElementFromTable(e.Row, e.Column)?.DrawElement(e, fontRdv);
    }
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

    // à redéfinir dans les forms dérivées
    protected virtual void InitSqlDataAdapter(DateTime jour) { }

    /* --------------------------------------------------------------------------------------- */
    // implémenté dans les forms spécialisées
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
    protected void GetContrats()
    {
      DebutSemaine = mdSemaine.AddDays(mdSemaine.DayOfWeek == DayOfWeek.Sunday ? -6 : 1 - (int)mdSemaine.DayOfWeek);//DayOfWeek.Monday=>1
      // recherche du numéro de semaine
      lblSemaine.Text = ModuleMain.WeekNumber(DebutSemaine).ToString();
      // affichage des jours de la semaine ( prise en compte des congés )
      Label[] labelsJours = { Label10, Label11, Label12, Label13, Label14, Label15 };
      for (int i = 0; i < labelsJours.Length; i++)
      {
        labelsJours[i].Text = DebutSemaine.AddDays(i).ToString("dddd d MMM", CultureInfo.CurrentUICulture);
        if (ModuleMain.IsFeriee(DebutSemaine.AddDays(i)))
          labelsJours[i].BackColor = Color.Red;
        else
          labelsJours[i].BackColor = MozartColors.ColorH8000000F;
      }

      // liste des interventions par sous traitant pour la semaine en cours
      ElemJourMax = 0;
      dsJours.Clear();
      for (int i = 0; i < libJours.Length; i++)
      {
        InitSqlDataAdapter(DebutSemaine.AddDays(i));
        daJours.Fill(dsJours, libJours[i]);
        ElemJourMax = Math.Max(ElemJourMax, dsJours.Tables[libJours[i]].Rows.Count);
      }

      PageNum = 0;
    }
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
    //  RSlun.Open "api_sp_listePlanningcontratST  '" & DebutSemaine & "'", cnx
    //  RSmar.Open "api_sp_listePlanningcontratST  '" & Format(DateAdd("d", 1, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSmer.Open "api_sp_listePlanningcontratST  '" & Format(DateAdd("d", 2, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSjeu.Open "api_sp_listePlanningcontratST  '" & Format(DateAdd("d", 3, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSven.Open "api_sp_listePlanningcontratST  '" & Format(DateAdd("d", 4, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSsam.Open "api_sp_listePlanningcontratST  '" & Format(DateAdd("d", 5, DebutSemaine), "dd/mm/yyyy") & "'", cnx
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
    // tous les plannings
    protected void InitialiserPlanningsTous()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        for (int c = 0; c < tablePlanning.ColumnCount; c++)
          for (int l = 0; l < tablePlanning.RowCount - 2; l++)
            elementsRdv[l, c].Visible = false;

        for (int i = 0; i < libJours.Length; i++)
          InitialiserPlanning(i, dsJours.Tables[libJours[i]]);

        SetBoutonElemPrecEnable(0 != PageNum);
        SetBoutonElemSuivEnable(!((PageNum + 1) * (tablePlanning.RowCount - 2) > ElemJourMax));
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    // planning d'un jour
    protected void InitialiserPlanning(int indexJour, DataTable dt)
    {
      int nbparpage = tablePlanning.RowCount - 2;
      int debut = PageNum * nbparpage;
      int fin = Math.Min(debut + nbparpage, dt.Rows.Count);
      int l = 0;
      while (debut < fin)
      {
        ElementRdv rdv = elementsRdv[l, indexJour];
        if (null == rdv)
        {
          debut++;
          l++;
          continue;
        }
        rdv.Visible = true;
        InitElementRdv(ref rdv, dt.Rows[debut]);
        debut++;
        l++;
      }
    }

    // version spécifique au type de planning à définir dans la classe spécialisée
    protected virtual void InitElementRdv(ref ElementRdv elem, DataRow row) { }
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
    //      pic(k).Left = lJour(Weekday(rs("DCSTDEL")) - 2).X1
    //      pic(k).Top = lHeure(j - 1).Y1 + 25
    //       
    //      ' constitution du tag d'une IP ( NumContrat, DI, NumAction, numST, Date)
    //      pic(k).Tag = rs("NCSTNUM") & "#" & rs("NDINNUM") & "#" & rs("NACTNUM") & "#" & rs("NINTNUM") & "#" & rs("DCSTDEL")
    //      
    //      'couleur standart = bleu clair
    //      pic(k).BackColor = &HFFFFC0
    //            
    //      ' si c'est la nuit :  rouge
    //      If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&
    //      
    //      ' si date d'execution : orange
    //      If Not IsNull(rs("DACTDEX")) Then pic(k).BackColor = RGB(255, 193, 125)
    //            
    //      ' si attachement : Vert
    //      If (Not IsNull(rs("DACTDEX"))) And (Not IsNull(rs("VACTATT")) And rs("VACTATT") <> "") Then pic(k).BackColor = &HC0FFC0
    //      
    //      ' si tous alors : blanc
    //      If (Not IsNull(rs("VACTATT")) And rs("VACTATT") <> "") And Not IsNull(rs("DACTDEX")) And (rs("CACTSTA") = "F" Or rs("CACTSTA") = "N") Then pic(k).BackColor = &HFFFFFF
    //      
    //      ' affichage des informations dans l'image
    //      inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & Left(rs("VSTFNOM"), 14) & "    1" & rs("CPRECOD")
    //       
    //      ' si facture : code
    //      If rs("CACTSTA") = "F" Or rs("CACTSTA") = "N" Then inter = inter & "    €"
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
    private void tablePlanning_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left) return;
      try
      {
        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        GetLigneColonne(e.Location, out l, out c);
        if (0 == l || l == tablePlanning.RowCount - 1) return;
        // test si element visible
        if (!GetElementFromTable(l, c).Visible) return;
        tablePlanning.DoDragDrop($"{l}:{c}", DragDropEffects.Move);
      }
      catch (Exception) { }
    }
    // retrouve ligne/colonne à partir des coordonnées
    void GetLigneColonne(Point coord, out int l, out int c)
    {
      l = c = 0;
      int[] widths = tablePlanning.GetColumnWidths();
      int w = 0;
      for (int i = 0; i < widths.Length; i++, c++)
      {
        w += widths[i];
        if (coord.X <= w) break;
      }
      int[] heights = tablePlanning.GetRowHeights();
      int h = 0;
      for (int i = 0; i < heights.Length; i++, l++)
      {
        h += heights[i];
        if (coord.Y <= h) break;
      }
    }
    private void tablePlanning_DragEnter(object sender, DragEventArgs e)
    {
      try
      {
        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        Point client = this.PointToClient(new Point(e.X, e.Y));
        GetLigneColonne(new Point(client.X - tablePlanning.Location.X, client.Y - tablePlanning.Location.Y), out l, out c);
        ElementRdv elem = GetElementFromTable(l, c);
        if (l != tablePlanning.RowCount - 1 &&
            (null == elem || elem.Visible || (e.AllowedEffect & DragDropEffects.Move) != DragDropEffects.Move))
        {
          e.Effect = DragDropEffects.None;
          return;
        }
        // si jour identique => pas de déplacement
        string data = e.Data.GetData(DataFormats.Text).ToString();
        if (data == null && data == "")
        {
          e.Effect = DragDropEffects.None;
          return;
        }
        string[] coord = data.Split(':');
        if (coord.Length != 2 || !Int32.TryParse(coord[0], out int l2) || !Int32.TryParse(coord[1], out int c2) || c.ToString() == coord[1])
        {
          e.Effect = DragDropEffects.None;
          return;
        }

        e.Effect = DragDropEffects.Move;
      }
      catch (Exception) { }
    }

    private void tablePlanning_DragOver(object sender, DragEventArgs e)
    {
      try
      {
        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        Point client = this.PointToClient(new Point(e.X, e.Y));
        GetLigneColonne(new Point(client.X - tablePlanning.Location.X, client.Y - tablePlanning.Location.Y), out l, out c);
        ElementRdv elem = GetElementFromTable(l, c);
        if (l != tablePlanning.RowCount - 1 &&
            (null == elem || elem.Visible || (e.AllowedEffect & DragDropEffects.Move) != DragDropEffects.Move))
        {
          e.Effect = DragDropEffects.None;
          return;
        }
        // si jour identique => pas de déplacement
        string data = e.Data.GetData(DataFormats.Text).ToString();
        if (data == null && data == "")
        {
          e.Effect = DragDropEffects.None;
          return;
        }
        string[] coord = data.Split(':');
        if (coord.Length != 2 || !Int32.TryParse(coord[0], out int l2) || !Int32.TryParse(coord[1], out int c2) || c.ToString() == coord[1])
        {
          e.Effect = DragDropEffects.None;
          return;
        }

        e.Effect = DragDropEffects.Move;
      }
      catch (Exception) { }
    }

    private void tablePlanning_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string data = e.Data.GetData(DataFormats.Text).ToString();
        if (data == null && data == "") return;
        string[] coord = data.Split(':');
        if (coord.Length != 2) return;

        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        Point client = this.PointToClient(new Point(e.X, e.Y));
        GetLigneColonne(new Point(client.X - tablePlanning.Location.X, client.Y - tablePlanning.Location.Y), out l, out c);
        // si jour identique => pas de déplacement
        if (c.ToString() == coord[1]) return;

        // recherche des info dans le tag de l'image
        if (!Int32.TryParse(coord[0], out int l2) || !Int32.TryParse(coord[1], out int c2))
          return;
        ElementRdv rdv = GetElementFromTable(l2, c2);
        string[] rdvTag = rdv.Tag.ToString().Split('#');

        // lors du déplacement d'un contrat, on change la date sur l'action et sur le contrat
        DateTime newDate = DebutSemaine.AddDays(c);
        DeplaceElement(rdv, newDate);

        // réinitialisation de l'affichage
        GetContrats();
        InitialiserPlanningsTous();

        this.Refresh();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    protected virtual void DeplaceElement(ElementRdv rdv, DateTime newDate) { }
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
    // ' lors du déplacement d'un contrat, on change la date sur l'action et sur le contrat
    //  strQ = "update TCST set DCSTDEL = '" & datepla & "' where ncstnum = " & MyTab(0)
    //  cnx.Execute strQ
    //
    //  If MyTab(2) <> "" Then
    //    strQ = "update TACT set DACTPLA = '" & datepla & "' where nactnum = " & MyTab(2)
    //    cnx.Execute strQ
    //  End If
    //  
    //  ' réinitialisation de l'affichage
    //  GetContrats True, "S"
    //
    //End Sub
    //
    //' passage a la page suivante
    /* --------------------------------------------------------------------------------------- */
    // appel depuis bouton Contrat/Devis suivant dans la form spécialisée
    protected void ElementsSuivants()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if ((PageNum + 1) * (tablePlanning.RowCount - 2) > ElemJourMax) return;
        PageNum++;

        InitialiserPlanningsTous();

        tablePlanning.Refresh();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    protected virtual void SetBoutonElemSuivEnable(bool bEnable) { }
    //Private Sub cmdTechS_Click()
    //
    //  GetContrats False, "S"
    //
    //End Sub
    //
    //' passage au technicien précédent
    /* --------------------------------------------------------------------------------------- */
    // appel depuis bouton Contrat/Devis précédent dans la form spécialisée
    protected void ElementsPrecedants()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (0 == PageNum) return;
        PageNum--;

        InitialiserPlanningsTous();

        tablePlanning.Refresh();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    protected virtual void SetBoutonElemPrecEnable(bool bEnable) { }
    //Private Sub cmdTechP_Click()
    //  
    //  ' ouverture des recordsets
    //  GetContrats False, "P"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // appel depuis bouton semaine précédente dans la form spécialisée
    protected void SemainePrecedante()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        mdSemaine = DebutSemaine.AddDays(-7);

        GetContrats();

        InitialiserPlanningsTous();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdPrec_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", -7, DebutSemaine)
    //  GetContrats True, "S"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // appel depuis bouton semaine suivante dans la form spécialisée
    protected void SemaineSuivante()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        mdSemaine = DebutSemaine.AddDays(7);

        GetContrats();

        InitialiserPlanningsTous();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdSuiv_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", 7, DebutSemaine)
    //  GetContrats True, "S"
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void tablePlanning_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right) return;
      try
      {
        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        GetLigneColonne(e.Location, out l, out c);
        if (l == tablePlanning.RowCount - 1) return;
        // test si element visible
        if (!GetElementFromTable(l, c).Visible) return;

        string[] rdvTag = GetElementFromTable(l, c).Tag.ToString().Split('#');
        MozartParams.NumAction = Convert.ToInt32(rdvTag[2]);
        MozartParams.NumDi = Convert.ToInt32(rdvTag[1]);
        //inumContrat = Convert.ToInt32(rdvTag[0]); //inutilisé

        menuAffichage.Show(Cursor.Position);
      }
      catch (Exception) { }
    }
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
    private void mnuDetails_Click(object sender, EventArgs e)
    {
      // si on est pas sur une IP on sort
      if (MozartParams.NumDi == 0) return;
      try
      {
        // écran de modification de l' action
        Cursor.Current = Cursors.WaitCursor;
        new frmDetailstravaux()
        {
          mstrStatutAction = "M"
        }.ShowDialog();
      }
      catch (Exception)
      {
        MessageBox.Show(Resources.msg_affich_impossible_ecran_charge, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
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
  }
}

