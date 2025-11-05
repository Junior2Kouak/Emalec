using DevExpress.XtraEditors;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmPlanClient : Form
  {
    public DateTime mdSemaine;

    DataSet dsTech;
    SqlDataAdapter daTechJours;
    // nombre maximum d'éléments TECH pour un jour de la semaine en cours (sert pour le calcul des pages)
    int TechJourMax;
    // numéro de page pour faire défiler les éléments TECH
    int PageTechNum;

    DataSet dsSTT;
    SqlDataAdapter daSTTJours;
    // nombre maximum d'élément STT pour un jour de la semaine en cours (sert pour le calcul des pages)
    int STTJourMax;
    // numéro de page pour faire défiler les éléments STT
    int PageSTTNum;

    static readonly string[] libJours = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

    DateTime DebutSemaine;
    // repositionnement sur le dernier item selectionné dans la liste client
    int iItem = 0;

    // pour affichage de la DI correspondante
    int iIp;
    int iDi;
    int iAct;


    //Public mdSemaine As Date
    //' UPGRADE_INFO (#0501): The 'inumContrat' member isn't used anywhere in current application.
    //' Dim inumContrat As Integer
    //
    //Dim RSlunTech As New ADODB.Recordset
    //Dim RSmarTech As New ADODB.Recordset
    //Dim RSmerTech As New ADODB.Recordset
    //Dim RSjeuTech As New ADODB.Recordset
    //Dim RSvenTech As New ADODB.Recordset
    //Dim RSsamTech As New ADODB.Recordset
    //Dim RSdimTech As New ADODB.Recordset
    //Dim RSlunSTT As New ADODB.Recordset
    //Dim RSmarSTT As New ADODB.Recordset
    //Dim RSmerSTT As New ADODB.Recordset
    //Dim RSjeuSTT As New ADODB.Recordset
    //Dim RSvenSTT As New ADODB.Recordset
    //Dim RSsamSTT As New ADODB.Recordset
    //Dim RSdimSTT As New ADODB.Recordset
    //
    //Dim DebutSemaine As Date
    //
    //' pour affichage de la DI correspondante
    //Dim iIp As Long
    //Dim iDi As Long
    //Dim iAct As Long
    //
    //' nombre d'images chargées dans le planning
    //Dim iNbrImageTECH As Integer
    //Dim iNbrImageSTT As Integer
    //
    //' repositionnement sur le dernier item selectionné dans la liste client
    //Dim iItem As Integer
    //
    //' Initialisation de la liste client
    //Dim bInit As Boolean

    protected partial class grillePlanning : TableLayoutPanel
    {
      public grillePlanning() : base()
      {
        DoubleBuffered = true;
      }
    }

    protected class ElementPlan
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

    protected Font fontPlan = new Font("MS Sans Serif", 8);
    protected ElementPlan[,] elementsTech;
    protected ElementPlan[,] elementsSTT;


    public frmPlanClient() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmPlanClient_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // initialisation date
        if (DateTime.MinValue == mdSemaine) mdSemaine = DateTime.Today;

        elementsTech = new ElementPlan[grilleUITech.RowCount - 2, libJours.Length];
        for (int c = 0; c < grilleUITech.ColumnCount; c++)
        {
          for (int l = 0; l < grilleUITech.RowCount - 2; l++)
            elementsTech[l, c] = new ElementPlan();
        }
        elementsSTT = new ElementPlan[grilleUISTT.RowCount - 1, libJours.Length];
        for (int c = 0; c < grilleUISTT.ColumnCount; c++)
        {
          for (int l = 0; l < grilleUISTT.RowCount - 1; l++)
            elementsSTT[l, c] = new ElementPlan();
        }

        dsTech = new DataSet("planningsTech");
        daTechJours = new SqlDataAdapter();
        daTechJours.SelectCommand = new SqlCommand();
        daTechJours.SelectCommand.Connection = MozartDatabase.cnxMozart;

        dsSTT = new DataSet("planningsSTT");
        daSTTJours = new SqlDataAdapter();
        daSTTJours.SelectCommand = new SqlCommand();
        daSTTJours.SelectCommand.Connection = MozartDatabase.cnxMozart;

        // combo des clients
        cboclient.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CLIENT"), "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);

        // affichage des jours de la semaine ( prise en compte des congés )
        AffichageJours();

        grilleUITech.CellPaint += new TableLayoutCellPaintEventHandler(this.tableTech_CellPaint);
        grilleUISTT.CellPaint += new TableLayoutCellPaintEventHandler(this.tableSTT_CellPaint);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //
    //    InitBoutons Me, frmMenu
    //
    //    ' initialisation date
    //     mdSemaine = Date
    //     iNbrImageSTT = 0
    //     iNbrImageTECH = 0
    //     bInit = True
    //    
    //    ' combo des clients
    //    RemplirComboClient cboclient
    //    If cboclient.ListCount > 1 Then
    //      cboclient.ListIndex = 1
    //      iItem = cboclient.ListIndex
    //    End If
    //    
    //    GetContrats True, "S", "TOUS"
    //    
    //    bInit = False
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cboclient_cboClick(object sender, EventArgs e)
    {
      foreach (Control item in (sender as apiCombo).Controls)
      {
        if (item is TextEdit)
          (item as TextEdit).SelectAll();
      }
    }
    private void cboclient_Leave(object sender, EventArgs e)
    {
      if (cboclient.GetItemData() <= 0)
      {
        MessageBox.Show("Vous devez obligatoirement saisir un client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        cboclient.SetItemData(iItem);
        return;
      }

      iItem = cboclient.GetItemData();

      GetContrats();
      InitialiserPlanningTech();
      InitialiserPlanningSTT();
    }
    //Private Sub cboClient_Click()
    //
    //    If cboclient.ItemData(cboclient.ListIndex) = 0 And Not bInit Then
    //        MsgBox ("Vous devez obligatoirement saisir un client")
    //        cboclient.ListIndex = iItem
    //    Else
    //        iItem = cboclient.ListIndex
    //        GetContrats True, "S", "TOUS"
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdRefresh_Click(object sender, EventArgs e)
    {
      if (cboclient.GetItemData() <= 0)
      {
        MessageBox.Show("Vous devez obligatoirement saisir un client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      GetContrats();
      InitialiserPlanningTech();
      InitialiserPlanningSTT();
    }
    //Private Sub cmdRefresh_Click()
    //    GetContrats True, "S", "TOUS"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void frmPlanClient_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F5)
        cmdRefresh_Click(null, null);
    }
    //Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    //  ' Touche F5 pour rafraichir l'affichage
    //  If KeyCode = 116 Then GetContrats True, "S", "TOUS"
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdContP_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (0 == PageSTTNum) return;
        PageSTTNum--;

        InitialiserPlanningSTT();

        grilleUISTT.Refresh();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdContP_Click()
    //  
    //  GetContrats False, "P", "STT"
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdContS_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if ((PageSTTNum + 1) * (grilleUISTT.RowCount - 2) > STTJourMax) return;
        PageSTTNum++;

        InitialiserPlanningSTT();

        grilleUISTT.Refresh();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdContS_Click()
    //  
    //  GetContrats False, "S", "STT"
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //' fermeture du recordset
    //On Error Resume Next
    //
    //  RSlunTech.Close
    //  RSmarTech.Close
    //  RSmerTech.Close
    //  RSjeuTech.Close
    //  RSvenTech.Close
    //  RSsamTech.Close
    //  
    //  RSlunSTT.Close
    //  RSmarSTT.Close
    //  RSmerSTT.Close
    //  RSjeuSTT.Close
    //  RSvenSTT.Close
    //  RSsamSTT.Close
    //  
    //Unload Me
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdLegende_Click(object sender, EventArgs e)
    {
      new frmLegende().ShowDialog();
    }
    //Private Sub cmdLegende_Click()
    //  frmLegende.Show vbModal
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSemPrec_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        mdSemaine = DebutSemaine.AddDays(-7);

        GetContrats();

        InitialiserPlanningTech();
        InitialiserPlanningSTT();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdSemPrec_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", -7, DebutSemaine)
    //  GetContrats True, "S", "TOUS"
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSemSuiv_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        mdSemaine = DebutSemaine.AddDays(7);

        GetContrats();

        InitialiserPlanningTech();
        InitialiserPlanningSTT();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdSemSuiv_Click()
    //  
    //  Me.mdSemaine = DateAdd("d", 7, DebutSemaine)
    //  GetContrats True, "S", "TOUS"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdTechP_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (0 == PageTechNum) return;
        PageTechNum--;

        InitialiserPlanningTech();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdTechP_Click()
    //
    //    GetContrats False, "P", "TECH"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdTechS_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if ((PageTechNum + 1) * (grilleUITech.RowCount - 2) > TechJourMax) return;
        PageTechNum++;

        InitialiserPlanningTech();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdTechS_Click()
    //
    //    GetContrats False, "S", "TECH"
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // affichage des jours de la semaine ( prise en compte des congés )
    void AffichageJours()
    {
      DebutSemaine = mdSemaine.AddDays(mdSemaine.DayOfWeek == DayOfWeek.Sunday ? -6 : 1 - (int)mdSemaine.DayOfWeek);//DayOfWeek.Monday=>1

      lblSemaine.Text = ModuleMain.WeekNumber(DebutSemaine).ToString();

      Label[] labelsJours = { lblLundi, lblMardi, lblMercredi, lblJeudi, lblVendredi, lblSamedi, lblDimanche };
      for (int i = 0; i < labelsJours.Length; i++)
      {
        labelsJours[i].Text = DebutSemaine.AddDays(i).ToString("dddd d MMM", CultureInfo.CurrentUICulture);
        if (ModuleMain.IsFeriee(DebutSemaine.AddDays(i)))
          labelsJours[i].BackColor = Color.Red;
        else
          labelsJours[i].BackColor = MozartColors.ColorH8000000F;
      }
    }
    // GetContrats : uniquement pour charger les données
    void GetContrats()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // affichage des jours de la semaine ( prise en compte des congés )
        AffichageJours();

        // liste des interventions par techniciens pour la semaine en cours
        TechJourMax = 0;
        dsTech.Clear();
        if (0 < cboclient.GetItemData())
        {
          for (int i = 0; i < libJours.Length; i++)
          {
            daTechJours.SelectCommand.CommandText = $"api_sp_listeInterventionsjour '{DebutSemaine.AddDays(i).ToShortDateString()}',{cboclient.GetItemData()}";
            daTechJours.Fill(dsTech, libJours[i]);
            TechJourMax = Math.Max(TechJourMax, dsTech.Tables[libJours[i]].Rows.Count);
          }
        }
        PageTechNum = 0;

        // liste des interventions par sous traitant pour la semaine en cours
        STTJourMax = 0;
        dsSTT.Clear();
        if (0 < cboclient.GetItemData())
        {
          for (int i = 0; i < libJours.Length; i++)
          {
            daSTTJours.SelectCommand.CommandText = $"api_sp_listePlanningcontratSTClient '{DebutSemaine.AddDays(i).ToShortDateString()}'";
            daSTTJours.Fill(dsSTT, libJours[i]);
            dsSTT.Tables[libJours[i]].DefaultView.RowFilter = $"NCLINUM = {cboclient.GetItemData()}";
            STTJourMax = Math.Max(STTJourMax, dsSTT.Tables[libJours[i]].DefaultView.Count);
          }
        }
        PageSTTNum = 0;
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub GetContrats(bPremierFois As Boolean, sDirection As String, sType As String)
    //
    //Dim i As Integer
    //' UPGRADE_INFO (#0501): The 'k' member isn't used anywhere in current application.
    //' Dim k As Integer
    //' UPGRADE_INFO (#0501): The 'indice' member isn't used anywhere in current application.
    //' Dim indice As Integer
    //' UPGRADE_INFO (#0501): The 'indiceMax' member isn't used anywhere in current application.
    //' Dim indiceMax As Integer
    //
    //On Error GoTo handler
    //
    //Screen.MousePointer = vbHourglass
    //
    //'fonction qui donne le premier jour de la semaine (lundi)
    //DebutSemaine = Format(DateAdd("d", -(Weekday(mdSemaine) - 2), mdSemaine), "dd/mm/yyyy")
    //
    //' recherche du numéro de semaine
    //lblSemaine.Caption = ISO_WEEK(DebutSemaine)  'DatePart("ww", DebutSemaine)
    //
    //' affichage des jours de la semaine ( prise en compte des congés )
    //For i = 0 To 6
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
    //  ' liste des interventions par techniciens pour la semaine en cours
    //  Set RSlunTech = New ADODB.Recordset
    //  Set RSmarTech = New ADODB.Recordset
    //  Set RSmerTech = New ADODB.Recordset
    //  Set RSjeuTech = New ADODB.Recordset
    //  Set RSvenTech = New ADODB.Recordset
    //  Set RSsamTech = New ADODB.Recordset
    //  Set RSdimTech = New ADODB.Recordset
    //  
    //  ' liste des interventions par sous traitant pour la semaine en cours
    //  Set RSlunSTT = New ADODB.Recordset
    //  Set RSmarSTT = New ADODB.Recordset
    //  Set RSmerSTT = New ADODB.Recordset
    //  Set RSjeuSTT = New ADODB.Recordset
    //  Set RSvenSTT = New ADODB.Recordset
    //  Set RSsamSTT = New ADODB.Recordset
    //  Set RSdimSTT = New ADODB.Recordset
    //
    //  RSlunSTT.Open "api_sp_listePlanningcontratSTClient  '" & DebutSemaine & "'", cnx
    //  RSmarSTT.Open "api_sp_listePlanningcontratSTClient  '" & Format(DateAdd("d", 1, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSmerSTT.Open "api_sp_listePlanningcontratSTClient  '" & Format(DateAdd("d", 2, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSjeuSTT.Open "api_sp_listePlanningcontratSTClient  '" & Format(DateAdd("d", 3, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSvenSTT.Open "api_sp_listePlanningcontratSTClient  '" & Format(DateAdd("d", 4, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSsamSTT.Open "api_sp_listePlanningcontratSTClient  '" & Format(DateAdd("d", 5, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //  RSdimSTT.Open "api_sp_listePlanningcontratSTClient  '" & Format(DateAdd("d", 6, DebutSemaine), "dd/mm/yyyy") & "'", cnx
    //
    //  RSlunTech.Open "api_sp_listeInterventionsjour  '" & DebutSemaine & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //  RSmarTech.Open "api_sp_listeInterventionsjour  '" & Format(DateAdd("d", 1, DebutSemaine), "dd/mm/yyyy") & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //  RSmerTech.Open "api_sp_listeInterventionsjour  '" & Format(DateAdd("d", 2, DebutSemaine), "dd/mm/yyyy") & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //  RSjeuTech.Open "api_sp_listeInterventionsjour  '" & Format(DateAdd("d", 3, DebutSemaine), "dd/mm/yyyy") & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //  RSvenTech.Open "api_sp_listeInterventionsjour  '" & Format(DateAdd("d", 4, DebutSemaine), "dd/mm/yyyy") & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //  RSsamTech.Open "api_sp_listeInterventionsjour  '" & Format(DateAdd("d", 5, DebutSemaine), "dd/mm/yyyy") & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //  RSdimTech.Open "api_sp_listeInterventionsjour  '" & Format(DateAdd("d", 6, DebutSemaine), "dd/mm/yyyy") & "'," & CStr(cboclient.ItemData(cboclient.ListIndex)), cnx
    //    
    //    ' Filtre par client car jointure trop lente dans la requête
    //    RSlunSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    RSmarSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    RSmerSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    RSjeuSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    RSvenSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    RSsamSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //    RSdimSTT.Filter = "NCLINUM = " & cboclient.ItemData(cboclient.ListIndex)
    //
    //
    //Else
    //
    //  ' traitement des cas suivant et précédent
    //  If sDirection = "S" Then
    //    'rien car on est déja bien placé
    //    ' a moins que l'on soit eof, alors on sort
    //'        If RSlunTech.EOF Then Exit Sub
    //
    //  Else
    //    'on remonte
    //    If sType = "STT" Or sType = "TOUS" Then
    //        If Not RSlunSTT.BOF Then RSlunSTT.MoveFirst
    //        If Not RSmarSTT.BOF Then RSmarSTT.MoveFirst
    //        If Not RSmerSTT.BOF Then RSmerSTT.MoveFirst
    //        If Not RSjeuSTT.BOF Then RSjeuSTT.MoveFirst
    //        If Not RSvenSTT.BOF Then RSvenSTT.MoveFirst
    //        If Not RSsamSTT.BOF Then RSsamSTT.MoveFirst
    //        If Not RSdimSTT.BOF Then RSdimSTT.MoveFirst
    //    End If
    //    
    //    If sType = "TECH" Or sType = "TOUS" Then
    //        If Not RSlunTech.BOF Then RSlunTech.MoveFirst
    //        If Not RSmarTech.BOF Then RSmarTech.MoveFirst
    //        If Not RSmerTech.BOF Then RSmerTech.MoveFirst
    //        If Not RSjeuTech.BOF Then RSjeuTech.MoveFirst
    //        If Not RSvenTech.BOF Then RSvenTech.MoveFirst
    //        If Not RSsamTech.BOF Then RSsamTech.MoveFirst
    //        If Not RSdimTech.BOF Then RSdimTech.MoveFirst
    //    End If
    //  End If
    //End If
    //
    //    If sType = "TECH" Or sType = "TOUS" Then
    //        ' on décharge les images
    //        For i = 1 To iNbrImageTECH
    //            Unload pic(i)
    //        Next
    //
    //        iNbrImageTECH = 0
    //        InitialiserPlanning RSlunTech, "TECH"
    //        InitialiserPlanning RSmarTech, "TECH"
    //        InitialiserPlanning RSmerTech, "TECH"
    //        InitialiserPlanning RSjeuTech, "TECH"
    //        InitialiserPlanning RSvenTech, "TECH"
    //        InitialiserPlanning RSsamTech, "TECH"
    //        InitialiserPlanning RSdimTech, "TECH"
    //    End If
    //    If sType = "STT" Or sType = "TOUS" Then
    //        ' on décharge les images
    //        For i = 51 To iNbrImageSTT
    //            Unload pic(i)
    //        Next
    //
    //        iNbrImageSTT = 50
    //                
    //        InitialiserPlanning RSlunSTT, "STT"
    //        InitialiserPlanning RSmarSTT, "STT"
    //        InitialiserPlanning RSmerSTT, "STT"
    //        InitialiserPlanning RSjeuSTT, "STT"
    //        InitialiserPlanning RSvenSTT, "STT"
    //        InitialiserPlanning RSsamSTT, "STT"
    //        InitialiserPlanning RSdimSTT, "STT"
    //    End If
    //
    //Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  ShowError "GetContrat dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    void InitialiserPlanningTech()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        for (int c = 0; c < grilleUITech.ColumnCount; c++)
          for (int l = 0; l < grilleUITech.RowCount - 2; l++)
            elementsTech[l, c].Visible = false;

        if (dsTech.Tables.Count != 0)
        {
          for (int i = 0; i < libJours.Length; i++)
          {
            int nbparpage = grilleUITech.RowCount - 2;
            int debut = PageTechNum * nbparpage;
            DataTable dt = dsTech.Tables[libJours[i]];
            int fin = Math.Min(debut + nbparpage, dt.Rows.Count);
            int l = 0;
            while (debut < fin)
            {
              ElementPlan elem = elementsTech[l, i];
              if (null == elem)
              {
                debut++;
                l++;
                continue;
              }
              InitElementTech(ref elem, dt.Rows[debut]);
              debut++;
              l++;
            }
          }
        }

        grilleUITech.Refresh();

        cmdTechP.Enabled = (0 != PageTechNum);
        cmdTechS.Enabled = (!((PageTechNum + 1) * (grilleUITech.RowCount - 2) > TechJourMax));
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    void InitElementTech(ref ElementPlan elem, DataRow row)
    {
      elem.Tag = $"IPL#{row["NIPLNUM"]}";
      if (Utils.GetMozart_Soc_By_Site(Convert.ToInt32(row["NSITNUM"])) > 0)
      {
        //pour les sites emalec spéciaux couleur : jaune
        elem.BackColor = Color.Yellow;
      }
      else
      {
        // couleur standart = bleu clair
        elem.BackColor = MozartColors.ColorHFFFFC0;
        //si multi-jour : bleu foncé
        if ((string)row["CIPLMULT"] == "O") elem.BackColor = MozartColors.ColorHFFFF00;
        // si c'est la nuit :  rouge
        if ((string)row["CACTNUIT"] == "O") elem.BackColor = Color.Red;
        // si c'est hors présence public :  rouge claire
        if ((string)row["CACTNUIT"] == "P") elem.BackColor = MozartColors.colorHC0C0FF;
        //si date d'execution : orange
        // si attachement (et exécution): Vert
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_ControleDateExec_Attach {row["NIPLNUM"]}"))
        {
          if (reader.Read())
          {
            if (!Convert.IsDBNull(reader[0]) && Convert.ToInt32(reader[0]) == 0) elem.BackColor = Color.FromArgb(255, 193, 125);
            if (!Convert.IsDBNull(reader[1]) && Convert.ToInt32(reader[1]) == 0) elem.BackColor = MozartColors.ColorHC0FFC0;
          }
        }
        // si facture, et exec, et attach : blanc
        if (Utils.ZeroIfNull(row["nbfact"]) > 0 && elem.BackColor == MozartColors.ColorHC0FFC0) elem.BackColor = Color.White;
      }
      // affichage des informations dans l'image
      elem.Ligne1 = $"{row["VCLINOM"]}";
      elem.Ligne2 = $"{row["VSITNOM"]}";
      elem.Ligne3 = $"{row["VPERNOM"]} {row["NIPLDURJ"]}h {row["sCODE"]}";
      if (Utils.ZeroIfNull(row["nbfact"]) > 0) elem.Ligne1 += "  €";
      if (Utils.ZeroIfNull(row["PrevMag"]) > 0) elem.Ligne1 += "  #";

      elem.Visible = true;
    }
    void InitialiserPlanningSTT()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        for (int c = 0; c < grilleUISTT.ColumnCount; c++)
          for (int l = 0; l < grilleUISTT.RowCount - 1; l++)
            elementsSTT[l, c].Visible = false;

        if (dsSTT.Tables.Count != 0)
        {
          // Filtre par client car jointure trop lente dans la requête => vue
          for (int i = 0; i < libJours.Length; i++)
          {
            DataTable dt = dsSTT.Tables[libJours[i]];
            //dt.DefaultView.RowFilter = $"NCLINUM = {cboclient.GetItemData()}";
            int nbparpage = grilleUISTT.RowCount - 1;
            int debut = PageSTTNum * nbparpage;
            int fin = Math.Min(debut + nbparpage, dt.DefaultView.Count);
            int l = 0;
            while (debut < fin)
            {
              ElementPlan elem = elementsSTT[l, i];
              if (null == elem)
              {
                debut++;
                l++;
                continue;
              }
              InitElementSTT(ref elem, dt.DefaultView[debut].Row);
              debut++;
              l++;
            }
          }
        }

        grilleUISTT.Refresh();

        cmdContP.Enabled = (0 != PageSTTNum);
        cmdContS.Enabled = (!((PageSTTNum + 1) * (grilleUISTT.RowCount - 1) > STTJourMax));
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }
    void InitElementSTT(ref ElementPlan elem, DataRow row)
    {
      elem.Tag = $"DIN#{row["NDINNUM"]}#{row["NACTNUM"]}";

      // couleur standart = bleu clair
      elem.BackColor = MozartColors.ColorHFFFFC0;
      // si c'est la nuit :  rouge
      if (Utils.BlankIfNull(row["CACTNUIT"]) == "O") elem.BackColor = Color.Red;
      // si c'est hors présence public :  rouge claire
      if (Utils.BlankIfNull(row["CACTNUIT"]) == "P") elem.BackColor = MozartColors.colorHC0C0FF;
      //si date d'execution : orange
      if (!Convert.IsDBNull(row["DACTDEX"])) elem.BackColor = Color.Orange;
      // si attachement (et exécution): Vert
      if (!Convert.IsDBNull(row["DACTDEX"]) && Utils.BlankIfNull(row["VACTATT"]) != "") elem.BackColor = MozartColors.ColorHC0FFC0;
      // si tous alors: blanc
      if (Utils.BlankIfNull(row["VACTATT"]) != "" && !Convert.IsDBNull(row["DACTDEX"]) &&
          (Utils.BlankIfNull(row["CACTSTA"]) == "F" || Utils.BlankIfNull(row["CACTSTA"]) == "N")) elem.BackColor = Color.White;

      // affichage des informations dans l'image
      elem.Ligne1 = $"{row["VCLINOM"]}";
      elem.Ligne2 = $"{row["VSITNOM"]}";
      elem.Ligne3 = $"{((string)row["VSTFNOM"]).Substring(0, Math.Min(14, ((string)row["VSTFNOM"]).Length))}    1{row["CPRECOD"]}";
      // si facture : code
      if (Utils.BlankIfNull(row["CACTSTA"]) == "F" || Utils.BlankIfNull(row["CACTSTA"]) == "N") elem.Ligne1 += "    €";

      elem.Visible = true;
    }

    private void tableTech_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
      if (null == elementsTech || e.Row == 0 || e.Row == grilleUITech.RowCount - 1) return;
      GetElementFromTableTech(e.Row, e.Column)?.DrawElement(e, fontPlan);
    }

    ElementPlan GetElementFromTableTech(int ligne, int colonne)
    {
      if (ligne <= 0 || ligne - 1 >= elementsTech.GetLength(0) || colonne < 0 || colonne >= elementsTech.GetLength(1)) return null;
      return elementsTech[ligne - 1, colonne];
    }

    private void tableSTT_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
      if (null == elementsSTT || e.Row < 0 || e.Row == grilleUISTT.RowCount - 1) return;
      GetElementFromTableSTT(e.Row, e.Column)?.DrawElement(e, fontPlan);
    }

    ElementPlan GetElementFromTableSTT(int ligne, int colonne)
    {
      if (ligne < 0 || ligne >= elementsSTT.GetLength(0) || colonne < 0 || colonne >= elementsSTT.GetLength(1)) return null;
      return elementsSTT[ligne, colonne];
    }


    //Private Sub InitialiserPlanning(ByVal rs As ADODB.Recordset, tableau As String)
    //
    //Dim k As Integer
    //Dim j As Integer
    //Dim inter As String
    //Dim rsCode As ADODB.Recordset
    //' UPGRADE_INFO (#0501): The 'apisTag' member isn't used anywhere in current application.
    //' Dim apisTag As New ApiString
    //
    //On Error GoTo handler
    //
    //    If tableau = "TECH" Then
    //        k = iNbrImageTECH
    //        ' parcours des interventions par technicien pour la semaine en cours
    //        While (Not rs.EOF) And j < 6
    //            k = k + 1
    //            j = j + 1
    //            
    //            ' création d'une image
    //            Load pic(k)
    //            ' coordonnées de l'image ( pb avec le dimanche car son weekday = 1)
    //            pic(k).Left = lJour(IIf(Weekday(rs("DIPLDATJ")) = 1, 8, Weekday(rs("DIPLDATJ"))) - 2).X1
    //            pic(k).Top = lHeure(j - 1).Y1 + 25
    //
    //            pic(k).Tag = "IPL#" & rs("NIPLNUM")
    //
    //            ' pour les sites emalec spéciaux couleur : jaune
    //            If GetMozart_Soc_By_Site(rs("NSITNUM")) > 0 Then
    //                pic(k).BackColor = &HFFFF&
    //            Else
    //                'couleur standart = bleu clair
    //                pic(k).BackColor = &HFFFFC0
    //
    //                ' si multi-jour : bleu foncé
    //                If rs("CIPLMULT") = "O" Then pic(k).BackColor = &HFFFF00
    //          
    //                ' si c'est la nuit :  rouge
    //                If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&
    //                    
    //                ' si c'est hors présence public :  rouge claire
    //                If rs("CACTNUIT") = "P" Then pic(k).BackColor = &HC0C0FF
    //          
    //                ' si date d'execution : orange
    //                ' si attachement (et exécution): Vert
    //                Set rsCode = New ADODB.Recordset
    //                rsCode.Open "exec api_sp_ControleDateExec_Attach " & rs("NIPLNUM"), cnx
    //                If rsCode(0) = 0 Then pic(k).BackColor = RGB(255, 193, 125)
    //                If rsCode(1) = 0 Then pic(k).BackColor = &HC0FFC0
    //                rsCode.Close
    //          
    //                ' si facture, et exec, et attach : blanc
    //                If rs("nbfact") > 0 And (pic(k).BackColor = &HC0FFC0) Then pic(k).BackColor = &HFFFFFF
    //          
    //            End If
    //    
    //            ' affichage des informations dans l'image
    //            inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & rs("VPERNOM") & " " & rs("NIPLDURJ") & "h  " & rs("sCODE")
    //            
    //            If rs("nbfact") > 0 Then inter = inter & "  €"
    //            If rs("PrevMag") > 0 Then inter = inter & "  #"
    //        
    //            pic(k).Print inter
    //            pic(k).Visible = True
    //            
    //            iNbrImageTECH = iNbrImageTECH + 1
    //            
    //        ' enregistrement suivant
    //        rs.MoveNext
    //      
    //        Wend
    //        
    //    ElseIf tableau = "STT" Then
    //        k = iNbrImageSTT
    //        j = 7
    //        ' parcours des interventions par sous traitant pour la semaine en cours
    //        While (Not rs.EOF) And j < 13
    //            
    //            k = k + 1
    //            j = j + 1
    //      
    //            ' création d'une image
    //            Load pic(k)
    //
    //            ' coordonnées de l'image
    //            pic(k).Left = lJour(IIf(Weekday(rs("DCSTDEL")) = 1, 8, Weekday(rs("DCSTDEL"))) - 2).X1
    //            pic(k).Top = lHeure(j - 1).Y1 + 25
    //      
    //            ' constitution du tag d'une DI
    //            pic(k).Tag = "DIN#" & rs("NDINNUM") & "#" & rs("NACTNUM")
    //      
    //            'couleur standart = bleu clair
    //            pic(k).BackColor = &HFFFFC0
    //            
    //            ' si c'est la nuit :  rouge
    //            If rs("CACTNUIT") = "O" Then pic(k).BackColor = &HFF&
    //          
    //            ' si c'est hors présence public :  rouge claire
    //            If rs("CACTNUIT") = "P" Then pic(k).BackColor = &HC0C0FF
    //      
    //            ' si date d'execution : orange
    //            If Not IsNull(rs("DACTDEX")) Then pic(k).BackColor = RGB(255, 193, 125)
    //            
    //            ' si attachement : Vert
    //            If (Not IsNull(rs("DACTDEX"))) And (Not IsNull(rs("VACTATT")) And rs("VACTATT") <> "") Then pic(k).BackColor = &HC0FFC0
    //      
    //            ' si tous alors : blanc
    //            If (Not IsNull(rs("VACTATT")) And rs("VACTATT") <> "") And Not IsNull(rs("DACTDEX")) And (rs("CACTSTA") = "F" Or rs("CACTSTA") = "N") Then pic(k).BackColor = &HFFFFFF
    //      
    //            ' affichage des informations dans l'image
    //            inter = rs("VCLINOM") & vbCrLf & rs("VSITNOM") & vbCrLf & Left(rs("VSTFNOM"), 14) & "    1" & rs("CPRECOD")
    //       
    //            ' si facture : code
    //            If rs("CACTSTA") = "F" Or rs("CACTSTA") = "N" Then inter = inter & "    €"
    //       
    //            pic(k).Print inter
    //            pic(k).Visible = True
    //            
    //            iNbrImageSTT = iNbrImageSTT + 1
    //            
    //        ' enregistrement suivant
    //        rs.MoveNext
    //      
    //        Wend
    //    End If
    //
    //Exit Sub
    //handler:
    //  ShowError "InitialiserPlanning dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void mnuDetails_Click(object sender, EventArgs e)
    {
      // si on est pas sur une IP on sort
      if (iIp != 0)
      {
        // affichage d'une fenetre avec detail de l'IP
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select count(*) from TACT WITH (NOLOCK) where NIPLNUM = {iIp}"))
        {
          reader.Read();
          if (Utils.ZeroIfNull(reader[0]) > 1)
          {
            reader.Close();
            new frmDetailIP
            {
              miNumIP = iIp
            }.ShowDialog();
          }
          else
          {
            reader.Close();
            // on garde les variables globales en mémoire
            using (SqlDataReader reader2 = ModuleData.ExecuteReader($"select NACTNUM, NDINNUM from TACT WITH (NOLOCK) where NIPLNUM ={iIp}"))
            {
              reader2.Read();
              // recherche des droits sur cette DI
              using (SqlDataReader reader3 = ModuleData.ExecuteReader($"SELECT count(*) FROM TDIN INNER JOIN TAUT ON  TDIN.NDINCTE = TAUT.NCANNUM " +
                                   $" INNER JOIN TPER ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = {MozartParams.UID}" +
                                   $" AND TDIN.NDINNUM = {reader2["NDINNUM"]}"))
              {
                reader3.Read();
                if (Utils.ZeroIfNull(reader3[0]) == 0)
                {
                  reader3.Close();
                  MessageBox.Show(Resources.msg_pasDroitsAccesDI, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
                }
                else
                {
                  reader3.Close();
                  // écran de modification de la demande
                  MozartParams.NumDi = (int)Utils.ZeroIfNull(reader2["NDINNUM"]);
                  MozartParams.NumAction = (int)Utils.ZeroIfNull(reader2["NACTNUM"]);
                  reader2.Close();
                  try
                  {
                    new frmAddAction { mstrStatutDI = "M" }.ShowDialog();
                  }
                  catch (Exception)
                  {
                    MessageBox.Show(Resources.msg_affich_impossible_ecran_charge, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  finally { Cursor.Current = Cursors.Default; }
                }
              }
            }
          }
        }
      }
      else if (iDi != 0)
      {
        // écran de modification de la demande
        MozartParams.NumDi = iDi;
        MozartParams.NumAction = iAct;
        new frmAddAction { mstrStatutDI = "M" }.ShowDialog();
      }
    }
    //Private Sub mnuDetails_Click()
    //
    //Dim rsD As New ADODB.Recordset
    //Dim rsa As New ADODB.Recordset
    //Dim rsDroit As New ADODB.Recordset
    //' UPGRADE_INFO (#0501): The 'liNumDI' member isn't used anywhere in current application.
    //' UPGRADE_INFO (#0501): The 'llNumAction' member isn't used anywhere in current application.
    //' Dim liNumDI, llNumAction
    //
    //    ' si on est pas sur une IP on sort
    //    If iIp <> 0 Then
    //        ' affichage d'une fenetre avec detail de l'IP
    //        rsD.Open "select count(*) from TACT WITH (NOLOCK) where NIPLNUM = " & iIp, cnx
    //      
    //        If rsD(0) > 1 Then
    //            frmDetailIP.miNumIP = iIp
    //            frmDetailIP.Show vbModal
    //        Else
    //            ' on garde les variables globales en mémoire
    //            rsa.Open "select NACTNUM, NDINNUM from TACT WITH (NOLOCK) where NIPLNUM = " & iIp, cnx
    //  
    //            ' recherche des droits sur cette DI
    //            rsDroit.Open "SELECT count(*) FROM TDIN INNER JOIN TAUT ON  TDIN.NDINCTE = TAUT.NCANNUM " & _
    //             " INNER JOIN TPER ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = " & gintUID & _
    //             " AND   TDIN.NDINNUM = " & rsa("NDINNUM"), cnx
    //             
    //            If rsDroit(0) = 0 Then
    //                MsgBox "§Vous n'avez pas les droits d'accès sur cette DI§"
    //                rsDroit.Close
    //                Exit Sub
    //            Else
    //                ' écran de modification de la demande
    //                frmAddAction.mstrStatutDI = "M"
    //                giNumDi = rsa("NDINNUM").value
    //                glNumAction = rsa("NACTNUM").value
    //        
    //                On Error Resume Next
    //      
    //                frmAddAction.Show vbModal
    //              
    //                If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran et déjà chargé en arrière plan§"
    //                
    //                rsDroit.Close
    //                rsa.Close
    //            End If
    //        End If
    //        rsD.Close
    //    ElseIf iDi <> 0 Then
    //        ' écran de modification de la demande
    //        frmAddAction.mstrStatutDI = "M"
    //        giNumDi = iDi
    //        glNumAction = iAct
    //        frmAddAction.Show vbModal
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void table_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right) return;
      try
      {
        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        ElementPlan elemPlan;
        if ((sender as TableLayoutPanel).Name == "grilleUISTT")
        {
          GetLigneColonne(e.Location, grilleUISTT, out l, out c);
          elemPlan = GetElementFromTableSTT(l, c);
        }
        else if ((sender as TableLayoutPanel).Name == "grilleUITech")
        {
          GetLigneColonne(e.Location, grilleUITech, out l, out c);
          elemPlan = GetElementFromTableTech(l, c);
        }
        else return;

        // test si element visible
        if (!elemPlan.Visible) return;

        string[] infos = elemPlan.Tag.ToString().Split('#');
        if (infos[0] == "IPL")
        {
          iIp = Convert.ToInt32(infos[1]);
          iDi = 0;
          iAct = 0;
        }
        else if (infos[0] == "DIN")
        {
          iIp = 0;
          iDi = Convert.ToInt32(infos[1]);
          iAct = Convert.ToInt32(infos[2]);
        }

        menuAffichage.Show(Cursor.Position);
      }
      catch (Exception) { }
    }

    // retrouve ligne/colonne à partir des coordonnées
    void GetLigneColonne(Point coord, TableLayoutPanel table, out int l, out int c)
    {
      l = c = 0;
      int[] widths = table.GetColumnWidths();
      int w = 0;
      for (int i = 0; i < widths.Length; i++, c++)
      {
        w += widths[i];
        if (coord.X <= w) break;
      }
      int[] heights = table.GetRowHeights();
      int h = 0;
      for (int i = 0; i < heights.Length; i++, l++)
      {
        h += heights[i];
        if (coord.Y <= h) break;
      }
    }
    //Private Sub pic_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    //Dim MyTabPic
    //
    //    ' recherche de l'IP ou de la di dans le tag de l'image
    //    MyTabPic = Split(pic(Index).Tag, "#")
    //    If MyTabPic(0) = "IPL" Then
    //        iIp = MyTabPic(1)
    //        iDi = 0
    //        iAct = 0
    //    ElseIf MyTabPic(0) = "DIN" Then
    //        iDi = MyTabPic(1)
    //        iAct = MyTabPic(2)
    //        iIp = 0
    //    End If
    //    
    //    If Button = 2 Then
    //        PopupMenu mnuAffichage
    //    End If
    //
    //End Sub

  }
}

