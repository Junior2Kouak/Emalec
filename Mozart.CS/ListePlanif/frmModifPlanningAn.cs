using MozartCS.Properties;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmModifPlanningAn : Form
  {
    public int miNumClient;
    public string sNomClient;
    public int iAnnee;
    public int iContrat;
    public string sTypePrest;

    DataTable dtPlanning;
    bool triAsc = true;
    char[,] planning;

    //Public miNumClient As Long
    //Public sNomClient As String
    //Public iAnnee As Integer
    //Public iContrat As Integer
    //Public sTypePrest As String

    protected partial class grillePlanning : TableLayoutPanel
    {
      public grillePlanning() : base()
      {
        DoubleBuffered = true;
      }
    }

    public frmModifPlanningAn() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmModifPlanningAn_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        dtPlanning = new DataTable();
        ModuleData.LoadData(dtPlanning, $"api_sp_PlanningAnnuel3 {miNumClient}, {iAnnee}, {iContrat}, '{sTypePrest}'");

        InitialisePlanning();

        GrillePlanning.CellPaint += GrillePlanning_CellPaint;
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
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    // InitBoutons Me, frmMenu
    //  
    // For i = 1 To 51
    //      Load lblSemaine(i)
    //      lblSemaine(i).top = lblSemaine(0).top
    //      lblSemaine(i).left = lblSemaine(i - 1).left + lblSemaine(0).width
    //      lblSemaine(i).Caption = i + 1
    //      lblSemaine(i).Visible = True
    //      lblSemaine(i).Appearance = i Mod 2
    // Next
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "api_sp_PlanningAnnuel3 " & miNumClient & ", " & iAnnee & ", " & iContrat & ", '" & sTypePrest & "'", cnx
    //  
    //  
    //  InitialiseForm
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /*--------------------------------------------------------------*/
    //
    //Dim adoRS As ADODB.Recordset
    //Dim startpos As Integer
    //Dim i As Long
    //Dim k As Long
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdTri_Click(object sender, EventArgs e)
    {
      triAsc = !triAsc;

      GrillePlanning.Refresh();
    }
    //Private Sub cmdTri_Click()
    //Dim j As Long
    //
    //Screen.MousePointer = vbHourglass
    //adoRS.MoveFirst
    //If adoRS.Sort = "[VSITNOM] desc" Then
    //  adoRS.Sort = "[VSITNOM] asc"
    //Else
    //  adoRS.Sort = "[VSITNOM] desc"
    //End If
    //
    //'  unload des controles
    //On Error Resume Next
    //For j = 1 To i
    //  Unload Image1(j)
    //Next
    //For j = 1 To k - 1
    //  Unload Label1(j)
    //Next
    //
    //InitialiseForm
    //
    //Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    private void InitialisePlanning()
    {
      int nb = dtPlanning.Rows.Count;
      planning = new char[nb, 52];

      GrillePlanning.SuspendLayout();

      Padding pad = new Padding(0);
      for (int i = 1; i < 53; i++)
      {
        GrillePlanning.Controls.Add(new Label
        {
          Text = $"{i}",
          Margin = pad,
          TextAlign = ContentAlignment.MiddleCenter,
          BackColor = (i % 2 == 0 ? Color.FromArgb(240, 240, 240) : Color.White)
        }, i, 0);
      }

      for (int l = 0; l < nb; l++)
      {
        // ajouter une ligne
        AjouteLigne();

        DataRow row = dtPlanning.Rows[l];

        // initialisation infos de la ligne
        for (int s = 6; s < 58; s++)
        {
          string val = Utils.BlankIfNull(row[s]);
          if (val == "")
          {
            planning[l, s - 6] = 'V';//idem base si rien
            continue;
          }
          planning[l, s - 6] = val[0];
        }
      }

      GrillePlanning.ResumeLayout();
    }
    void AjouteLigne()
    {
      GrillePlanning.RowCount++;
      int r = GrillePlanning.RowStyles.Add(new RowStyle(SizeType.Absolute, (GrillePlanning.RowStyles[0] as RowStyle).Height));
    }

    Font fontLib = new Font("MS Sans Serif", 8);
    private void GrillePlanning_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
      if (e.Row == 0 || e.Row > dtPlanning.Rows.Count) return;

      int index = e.Row - 1;
      if (!triAsc) index = dtPlanning.Rows.Count - 1 - index;

      if (e.Column == 0)
      {
        string lib = Utils.BlankIfNull(dtPlanning.Rows[index][1]);

        Graphics g = e.Graphics;
        g.FillRectangle(new SolidBrush(Color.Wheat),
                        e.CellBounds.Location.X + 1,
                        e.CellBounds.Location.Y + 3,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 6);

        e.Graphics.DrawString(lib, fontLib, Brushes.Black, new RectangleF(e.CellBounds.Location.X + 1, e.CellBounds.Location.Y + 5, e.CellBounds.Width - 2, 14));
      }
      else
      {
        char c = planning[index, e.Column - 1];
        SolidBrush sb;
        switch (c)
        {
          case 'X': sb = new SolidBrush(Color.Lime); break;
          case 'P': sb = new SolidBrush(Color.Blue); break;
          case 'I': sb = new SolidBrush(Color.Red); break;
          default: sb = new SolidBrush(Color.AntiqueWhite); break;
        }

        Graphics g = e.Graphics;
        int y = e.CellBounds.Location.Y + 1;

        g.FillRectangle(sb,
                        e.CellBounds.Location.X + 1,
                        y,
                        e.CellBounds.Width - 2,
                        e.CellBounds.Height - 2);
      }
    }
    //
    //Sub InitialiseForm()
    //  
    //Dim j As Long
    //  
    //On Error GoTo handler
    //  
    //  k = 1
    //  i = 0
    //  While Not adoRS.EOF
    //    Load Label1(k)
    //    Label1(k).Caption = adoRS(1)
    //    Label1(k).Visible = True
    //    Label1(k).top = Label1(0).top + ((k - 1) * Image1(i).height)
    //          
    //    For j = 6 To 57
    //      
    //      i = i + 1
    //      Load Image1(i)
    //      
    //      If i Mod 52 = 0 Then
    //        Image1(i).top = Image1(i - 1).top + Image1(i).height
    //        Image1(i).left = Image1(0).left
    //      Else
    //        Image1(i).top = Image1(i - 1).top
    //        Image1(i).left = Image1(i - 1).left + Image1(i).width
    //      End If
    //      Image1(i).Visible = True
    //      
    //      'par défaut on charge la pciture vide
    //      Image1(i).Picture = ImageRef.Picture
    //      
    //      If left$(adoRS(j), 1) = "X" Then
    //        Image1(i - 1).Picture = Image4.Picture
    //      ElseIf left$(adoRS(j), 1) = "P" Then
    //        Image1(i - 1).Picture = Image3.Picture
    //      ElseIf left$(adoRS(j), 1) = "I" Then
    //        Image1(i - 1).Picture = Image2.Picture
    //      End If
    //      Image1(i - 1).Tag = Mid$(adoRS(j), 2)
    //      
    //    Next
    //    adoRS.MoveNext
    //    k = k + 1
    //    If k > 200 Then GoTo FIN
    //  Wend
    //  
    //FIN:
    //  ' on invisibilise la derniere image qui est en trop
    //  Image1(i).Visible = False
    //  
    //  'taille de la picturebox
    //  PicBox.height = Image1(i).top + 500
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void GrillePlanning_MouseUp(object sender, MouseEventArgs e)
    {
      int l, c;
      GetLigneColonne(e.Location, out l, out c);
      if (l == 0 || c == 0) return;
      int index = l - 1;
      if (!triAsc) index = dtPlanning.Rows.Count - 1 - index;
      char car = planning[index, c - 1];

      if (car == 'P')
      {
        // si c'est une date planifiée, on va directement sur le planning hebdo
        DataRow row = dtPlanning.Rows[index];
        string tag = ((string)row[c + 5]).Substring(1);
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_Infoplanif {tag}"))
        {
          // si pas d"enregistrement courant
          if (!reader.Read()) return;
          // si pas un technicien
          if (Utils.BlankIfNull(reader["CACTTYT"]) != "T")
          {
            MessageBox.Show(Resources.msg_intervenant_pas_technicien, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          new frmPlan
          {
            mdSemaine = Convert.ToDateTime(reader["DIPLDAT"]),
            miNumTech = (int)Utils.ZeroIfNull(reader["NPERNUM"]),
            miNumIp = (int)Utils.ZeroIfNull(reader["NIPLNUM"]),
            mStrStatutIP = "M"
          }.ShowDialog();
        }
      }
    }
    //Private Sub Image1_Click(Index As Integer)
    //  
    //Dim pRS As ADODB.Recordset
    //  
    //On Error GoTo handler
    //  
    //  ' si c'est une date souhaitée, on peut la modifier
    //  If Image1(Index).Picture = Image2.Picture Then
    //    Image1(Index).Drag vbBeginDrag
    //    startpos = Index
    //  End If
    //  
    //  ' si c'est une date planifiée, on va directement sur le planning hebdo
    //  If Image1(Index).Picture = Image3.Picture Then
    //    Screen.MousePointer = vbHourglass
    //    Set pRS = New ADODB.Recordset
    //    pRS.Open "exec api_sp_Infoplanif " & Val(Image1(Index).Tag), cnx
    //    
    //    ' si pas d"enregistrement courant
    //    If pRS.EOF Then Exit Sub
    //  
    //    ' si pas un technicien
    //    If pRS("CACTTYT") <> "T" Then
    //      MsgBox "§L'intervenant n'est pas un technicien§", vbInformation
    //      Exit Sub
    //    End If
    //            
    //    ' on passe au planning avec la bonne date et le bon tech
    //    frmPlan.mdSemaine = pRS("DIPLDAT").Value
    //    frmPlan.miNumTech = pRS("NPERNUM").Value
    //    frmPlan.miNumIP = pRS("NIPLNUM").Value
    //    frmPlan.mStrStatutIP = "M"
    //    frmPlan.Show vbModal
    //  
    //    ' fermeture du recordset
    //    pRS.Close
    //    Set pRS = Nothing
    //
    //  End If
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // retrouve ligne/colonne à partir des coordonnées
    void GetLigneColonne(Point coord, out int l, out int c)
    {
      l = c = 0;
      int[] widths = GrillePlanning.GetColumnWidths();
      int w = 0;
      for (int i = 0; i < widths.Length; i++, c++)
      {
        w += widths[i];
        if (coord.X <= w) break;
      }
      int[] heights = GrillePlanning.GetRowHeights();
      int h = 0;
      for (int i = 0; i < heights.Length; i++, l++)
      {
        h += heights[i];
        if (coord.Y <= h) break;
      }
    }

    private void GrillePlanning_MouseDown(object sender, MouseEventArgs e)
    {
      int l, c;
      GetLigneColonne(e.Location, out l, out c);
      if (l == 0 || c == 0) return;
      int index = l - 1;
      if (!triAsc) index = dtPlanning.Rows.Count - 1 - index;
      char car = planning[index, c - 1];

      if (car == 'I')
        GrillePlanning.DoDragDrop($"{l}:{c}", DragDropEffects.Move);
    }

    private void GrillePlanning_DragOver(object sender, DragEventArgs e)
    {
      int l, c;
      Point client = this.PointToClient(new Point(e.X, e.Y));
      GetLigneColonne(new Point(client.X - GrillePlanning.Location.X, client.Y - GrillePlanning.Location.Y), out l, out c);
      if (l == 0 || c == 0)
      {
        e.Effect = DragDropEffects.None;
        return;
      }
      int index = l - 1;
      if (!triAsc) index = dtPlanning.Rows.Count - 1 - index;
      char car = planning[index, c - 1];

      if (car == 'I' || car == 'P' || car == 'X')
      {
        e.Effect = DragDropEffects.None;
        return;
      }

      string data = e.Data.GetData(DataFormats.Text).ToString();
      if (data == null && data == "")
      {
        e.Effect = DragDropEffects.None;
        return;
      }
      string[] coord = data.Split(':');
      if (coord.Length != 2 || !Int32.TryParse(coord[0], out int l2) || !Int32.TryParse(coord[1], out int c2) || l.ToString() != coord[0])
      {
        e.Effect = DragDropEffects.None;
        return;
      }

      e.Effect = DragDropEffects.Move;
    }

    private void GrillePlanning_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string data = e.Data.GetData(DataFormats.Text).ToString();
        if (data == null && data == "") return;
        string[] coord = data.Split(':');
        if (coord.Length != 2 ||
            !Int32.TryParse(coord[0], out int l2) || !Int32.TryParse(coord[1], out int c2)) return;

        // obtenir ligne/colonne (ligne : 1 =>14, colonne:0=>5)
        // ligne 0 : jours
        int l, c;
        Point client = this.PointToClient(new Point(e.X, e.Y));
        GetLigneColonne(new Point(client.X - GrillePlanning.Location.X, client.Y - GrillePlanning.Location.Y), out l, out c);
        if (l2 != l) return;

        int index = l - 1;
        if (!triAsc) index = dtPlanning.Rows.Count - 1 - index;

        string tag = ((string)dtPlanning.Rows[index][c2 + 5]).Substring(1);
        if (!Int32.TryParse(tag, out int numAction))
          return;

        // ModificationBase
        // recherche du lundi du numéro de semaine
        DateTime newDate = new DateTime(iAnnee, 1, 1);
        while (UtilsPlan.WeekOfDate(newDate) != c)
          newDate = newDate.AddDays(7);

        ModuleData.ExecuteNonQuery($"update tact set DACTDAT = '{newDate.ToShortDateString()}' where NACTNUM = {numAction}");

        // mise à jour locale (affichage)
        DataRow row = dtPlanning.Rows[index];
        string old = (string)row[c + 5];
        row[c + 5] = row[c2 + 5];
        row[c2 + 5] = old;

        char car = planning[index, c - 1];
        planning[index, c - 1] = planning[index, c2 - 1];
        planning[index, c2 - 1] = car;

        GrillePlanning.Refresh();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Image1_DragDrop(Index As Integer, Source As Control, X As Single, Y As Single)
    //
    //  ' on ne pose pas sur une ligne différente
    //  If Index \ 52 = startpos \ 52 Then
    //    ' on ne pose pas l'un sur l'autre
    //    If Image1(Index).Picture = 0 Then
    //      Image1(Index).Picture = Image2.Picture
    //      Image1(startpos).Picture = LoadPicture()
    //      Image1(Index).Tag = Image1(startpos).Tag
    //      Image1(startpos).Tag = ""
    //      
    //      ' Modification de la date dans la base
    //      ModificationBase Index, Val(Image1(Index).Tag)
    //      
    //    End If
    //  End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // fait dans drop
    //Public Sub ModificationBase(ByVal NumSemaine As Integer, ByVal iAction As Long)
    //
    //Dim sSQL As String
    //Dim sNewDate
    //
    //On Error GoTo handler
    //
    //  ' recherche du lundi du numéro de semaine
    //  NumSemaine = (NumSemaine Mod 52) + 1
    //  
    //  sNewDate = "01/01/" & iAnnee
    //  While Not DatePart("ww", sNewDate) = NumSemaine
    //    sNewDate = DateAdd("d", 7, sNewDate)
    //  Wend
    //  
    //
    //  sSQL = "update tact set DACTDAT = '" & sNewDate & "' where NACTNUM = " & iAction
    //  cnx.Execute sSQL
    //  
    //Exit Sub
    //handler:
    //  ShowError "ModificationBase dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => automatique
    //Private Sub AlignScrollBars()    ' Reposition the PictureBox
    //
    //Dim lScroll As Long
    //
    //    lScroll = -VScroll
    //    PicBox.top = 1.2 * lScroll
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => automatique
    //Private Sub Form_Resize()        ' Resize the scrollbars & Reposition the scrollbars
    //
    //    On Error Resume Next
    //    
    //    VScroll.height = Me.ScaleHeight - lblFiller.height
    //    VScroll.top = 0: VScroll.left = Me.ScaleWidth - VScroll.width
    //
    //    ' Redimension the scrollbar parameters
    //    VScroll.max = Abs(PicBox.height - Me.ScaleHeight)
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    // => automatique
    //Private Sub VScroll_Change()
    //    AlignScrollBars
    //End Sub
    //

  }
}

