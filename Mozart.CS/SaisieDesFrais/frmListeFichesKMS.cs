using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFichesKMS : Form
  {
    public string msTypeFicheKMS;
    public string mP_SCONDDUCTEUR;
    public string mP_SIMMAT;
    public string mP_DATESEM;
    public string mcChFicheArchi;
    public int mP_NPERNUM;
    public int mP_NVEHNUM;
    DataTable dt = new DataTable();
    //Public sTypeFicheKMS As String
    //Public P_SCONDDUCTEUR As String
    //Public P_NPERNUM As Integer
    //Public P_SIMMAT As String
    //Public P_NVEHNUM As Integer
    //Public P_DATESEM As String
    //
    //Dim ado_fickmsarchi As ADODB.Recordset
    //Dim cChFicheArchi As String

    public frmListeFichesKMS()
    {
      InitializeComponent();
    }

    /*--------------------------------------------------------------------------*/
    private void frmListeFichesKMS_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        mcChFicheArchi = Utils.RechercheParam("REP_FICHESKMS") + MozartParams.NomSociete + "\\ARCHIVES\\";

        apicboConducteur.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("PERSONNEL"), "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);
        apicboImmat.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("IMMATRICUL"), "NVEHNUM", "VVEHIMAT", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        if (msTypeFicheKMS == "ADD")
        {
          fraCriteres.Visible = false;
          apicboConducteur.Visible = false;
          apicboImmat.Visible = false;
          apicboConducteur.SetText(mP_SCONDDUCTEUR);
          apicboImmat.SetText(mP_SIMMAT);
          txtCritDate.Text = mP_DATESEM;

          DateTime dtime = Convert.ToDateTime(mP_DATESEM);

          Label1.Text = Resources.lbl_ListFicheKmsFor + mP_SCONDDUCTEUR + Resources.lbl_Immat + mP_SIMMAT + Resources.txt_du
                      + dtime.AddDays(-((int)DateTime.Now.DayOfWeek - 1)).ToShortDateString() + Resources.txt_au
                      + dtime.AddDays(7 - (int)DateTime.Now.DayOfWeek).ToShortDateString();

          cmdScanFrais.Visible = true;
          cmdFind_Click(null, null);
        }
        else
        {
          fraCriteres.Visible = true;
          apicboConducteur.Visible = true;
          apicboImmat.Visible = true;
          cmdScanFrais.Visible = false;
        }

        InitGrid();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo Handler:
    //
    //    Screen.MousePointer = vbHourglass
    //
    //    InitBoutons Me, frmMenu
    //    
    //    Set ado_fickmsarchi = New ADODB.Recordset
    //    
    //    cChFicheArchi = RechercheParam("REP_FICHESKMS") & gstrNomSociete & "\ARCHIVES\"
    //    
    //    txtCritCond.Init "PERSONNEL"
    //    txtCritImmat.Init "IMMATRICUL"
    //    
    //    If sTypeFicheKMS = "ADD" Then
    //        
    //        fraCriteres.Visible = False
    //        txtCritCond.Visible = False
    //        txtCritImmat.Visible = False
    //        txtCritCond.Texte = P_SCONDDUCTEUR
    //        txtCritImmat.Texte = P_SIMMAT
    //        txtCritDate.Text = P_DATESEM
    //        
    //        Label1.Caption = "§Liste des Fiches Kms pour §" & P_SCONDDUCTEUR & " §Immat : §" & P_SIMMAT & " §du§ " & DateAdd("d", -Weekday(P_DATESEM, vbMonday) + 1, P_DATESEM) & " §au§ " & DateAdd("d", 7 - Weekday(P_DATESEM, vbMonday), P_DATESEM)
    //                
    //        CmdScanFrais.Visible = True
    //        cmdFind_Click
    //        
    //    Else
    //        fraCriteres.Visible = True
    //        txtCritCond.Visible = True
    //        txtCritImmat.Visible = True
    //        CmdScanFrais.Visible = False
    //    End If
    //    
    //    InitGrid
    //    
    //    Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //Handler:
    //    Screen.MousePointer = vbDefault
    //    ShowError "Form_Load de " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    //Private Sub Cal_Click()
    //    txtCritDate.Text = Cal.value
    //    Cal.Visible = False
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    DateTime _curDate = DateTime.MinValue;
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtCritDate.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtCritDate.Text, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    //Private Sub cmdDate_Click()
    //    
    //    If txtCritDate.Text <> "" Then
    //        Cal.value = txtCritDate.Text
    //    Else
    //        Cal.value = Date
    //    End If
    //    Cal.Visible = True
    //    
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (apicboConducteur.GetText() == "" && apicboImmat.GetText() == "" && txtCritDate.Text == "" && msTypeFicheKMS != "ADD")
        {
          MessageBox.Show(Resources.msg_must_input_at_least_one_criteria, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Cursor.Current = Cursors.Default;
          return;
        }

        WebBrowser1.Navigate("about:blank");

        string sSQL = "SELECT NFICKMSNUM, NPERNUM, NVEHNUM, DFICKMSEM, VFICKMSPATH, VVEHIMAT, VCONDUCT FROM api_v_ListeFichesKmsArchi WHERE ";
        string sWhere = "";

        if (apicboConducteur.GetText() != "")
          sWhere += $"VCONDUCT LIKE '%{apicboConducteur.GetText()}%'";

        if (apicboImmat.GetText() != "")
        {
          if (sWhere != "")
            sWhere += " AND ";
          sWhere += $" VVEHIMAT LIKE '%{apicboImmat.GetText()}%'";
        }

        if (txtCritDate.Text != "")
        {
          if (sWhere != "")
            sWhere += " AND ";
          sWhere += $"DFICKMSEM BETWEEN DATEADD([DD], - DATEPART([DW], '{txtCritDate.Text}') + 1, '{txtCritDate.Text}') " +
                    $"AND DATEADD([DD], 7 - DATEPART([DW], '{txtCritDate.Text}'), '{txtCritDate.Text}')";
        }

        //TODO la requete sSQL + sWhere ne retourne rien
        apiTgrid.LoadData(dt, MozartDatabase.cnxMozart, sSQL + sWhere);
        apiTgrid.GridControl.DataSource = dt;

        apiTgrid.InitColumnList();

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdFind_Click()
    //
    //    Dim sReq As String
    //    Dim sWhere As String
    //    
    //    Screen.MousePointer = vbHourglass
    //
    //    If txtCritCond.Texte = "" And txtCritCond.Texte = "" And txtCritDate.Text = "" And sTypeFicheKMS <> "ADD" Then
    //        MsgBox "§Il faut au moins saisir un critère de recherche !§", vbExclamation
    //        Screen.MousePointer = vbDefault
    //        Exit Sub
    //    End If
    //    
    //    If ado_fickmsarchi.State = adStateOpen Then ado_fickmsarchi.Close
    //        
    //    ' ouverture du recordset
    //    sReq = "SELECT NFICKMSNUM, NPERNUM, NVEHNUM, DFICKMSEM, VFICKMSPATH, VVEHIMAT, VCONDUCT FROM api_v_ListeFichesKmsArchi WHERE "
    //    
    //    If txtCritCond.Texte <> "" Then sWhere = sWhere & "VCONDUCT LIKE '%" & txtCritCond.Texte & "%'"
    //    If txtCritImmat.Texte <> "" Then sWhere = IIf(sWhere = "", sWhere & " VVEHIMAT LIKE '%" & txtCritImmat.Texte & "%'", sWhere & " AND VVEHIMAT LIKE '%" & txtCritImmat.Texte & "%'")
    //    If txtCritDate.Text <> "" Then sWhere = IIf(sWhere = "", sWhere & "DFICKMSEM BETWEEN DATEADD([DD], - DATEPART([DW], '" & txtCritDate.Text & "') + 1, '" & txtCritDate.Text & "') AND DATEADD([DD], 7 - DATEPART([DW], '" & txtCritDate.Text & "'), '" & txtCritDate.Text & "')", sWhere & " AND DFICKMSEM BETWEEN DATEADD([DD], - DATEPART([DW], '" & txtCritDate.Text & "') + 1, '" & txtCritDate.Text & "') AND  DATEADD([DD], 7 - DATEPART([DW], '" & txtCritDate.Text & "'), '" & txtCritDate.Text & "')")
    //        
    //    ado_fickmsarchi.Open sReq + sWhere, cnx, adOpenStatic, adLockReadOnly
    //    
    //    apiTgrid.Init ado_fickmsarchi
    //    
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //    Resume
    //    
    //Err:
    //    ShowError "cmdFind_Click dans " & Me.Name
    //    Screen.MousePointer = vbDefault
    //End Sub

    /*--------------------------------------------------------------------------*/
    private void CmdScanFrais_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      DateTime dtime = Convert.ToDateTime(txtCritDate.Text);

      frmListeScanFichesKMS f = new frmListeScanFichesKMS();
      f.Label1.Text = f.Label1.Text.Replace("#COND#", apicboConducteur.GetText()).Replace("#IMAT#", apicboImmat.GetText());
      f.Label2.Text = f.Label2.Text.Replace("#SEM#", dtime.AddDays(-((int)DateTime.Now.DayOfWeek - 1)).ToShortDateString()
                    + Resources.txt_au + dtime.AddDays(7 - (int)DateTime.Now.DayOfWeek).ToShortDateString());
      f.mP_NPERNUM = mP_NPERNUM;
      f.mP_NVEHNUM = mP_NVEHNUM;
      f.mP_DATESEM = txtCritDate.Text;
      f.ShowDialog();

      apiTgrid.Requery(dt, MozartDatabase.cnxMozart);
    }

    //Private Sub CmdScanFrais_Click()
    //    frmListeScanFichesKMS.Label1.Caption = Replace(Replace(frmListeScanFichesKMS.Label1.Caption, "#COND#", txtCritCond.Texte), "#IMAT#", txtCritImmat.Texte)
    //    frmListeScanFichesKMS.Label2.Caption = Replace(frmListeScanFichesKMS.Label2.Caption, "#SEM#", DateAdd("d", -(Weekday(txtCritDate.Text) - 1) + 1, txtCritDate.Text) & " §au§ " & DateAdd("d", 7 - (Weekday(txtCritDate.Text) - 1), txtCritDate.Text))
    //    frmListeScanFichesKMS.P_NPERNUM = P_NPERNUM
    //    frmListeScanFichesKMS.P_NVEHNUM = P_NVEHNUM
    //    frmListeScanFichesKMS.P_DATESEM = txtCritDate.Text
    //    frmListeScanFichesKMS.Show vbModal
    //    
    //    ado_fickmsarchi.Requery
    //    
    //End Sub

    /*--------------------------------------------------------------------------*/
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTgrid.GetFocusedDataRow();
      if (row == null) return;

      try
      {
        if (MessageBox.Show(Resources.msg_ConfirmDelFiche, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          //il faut fermer le fichier avant de le supprimer
          WebBrowser1.Navigate("about:blank");
          //test fichier existe
          if (File.Exists(mcChFicheArchi + row["VFICKMSPATH"]) == true)
          {
            Thread.Sleep(1000);
            File.Delete(mcChFicheArchi + row["VFICKMSPATH"]);
            ModuleData.ExecuteNonQuery("EXEC api_sp_SuppressionFicheKMS " + row["NFICKMSNUM"]);
            apiTgrid.Requery(dt, MozartDatabase.cnxMozart);
          }
          else
            MessageBox.Show(Resources.msg_FileAlreadyUsedCannotDel, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupprimer_Click()
    //
    //On Error GoTo Handler:
    //
    //    If ado_fickmsarchi.RecordCount = 0 Then Exit Sub
    //
    //    If MsgBox("§Voulez vous vraiment supprimer cette fiche ?§", vbYesNo + vbQuestion) = vbYes Then
    //      ' il faut fermer le fichier avant de le supprimer
    //      WebBrowser1.Navigate2 "about:blank"
    //      'test fichier existe
    //      If Dir$(cChFicheArchi & ado_fickmsarchi("VFICKMSPATH")) <> "" Then
    //          Pause 1
    //          Kill cChFicheArchi & ado_fickmsarchi("VFICKMSPATH")
    //          cnx.Execute ("EXEC api_sp_SuppressionFicheKMS " & ado_fickmsarchi("NFICKMSNUM"))
    //          ado_fickmsarchi.Requery
    //      Else
    //        MsgBox "§Ce fichier est utilisé par un autre utilisateur!Impossible de supprimer§", vbCritical
    //      End If
    //    End If
    //    ado_fickmsarchi.Requery
    //    Exit Sub
    //    Resume
    //
    //Handler:
    //  If Err.Number = 70 Or Err.Number = 75 Then
    //    MsgBox "§Ce fichier est utilisé par un autre utilisateur!Impossible de supprimer§", vbCritical
    //    Err.Clear
    //    Exit Sub
    //  Else
    //    ShowError "cmdDel_Click dans " & Me.Name
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitGrid()
    {
      apiTgrid.AddColumn(Resources.col_Num, "NFICKMSNUM", 0);
      apiTgrid.AddColumn(Resources.col_conducteur, "VCONDUCT", 3500);
      apiTgrid.AddColumn(Resources.col_Immatriculation, "VVEHIMAT", 2500);
      apiTgrid.AddColumn(Resources.col_Semaine, "DFICKMSEM", 1500);
      apiTgrid.AddColumn(Resources.col_Path, "VFICKMSPATH", 0);

      apiTgrid.InitColumnList();
    }
    //Private Sub InitGrid()
    //    
    //    apiTgrid.AddColumn "N°", "NFICKMSNUM", 0
    //    apiTgrid.AddColumn "§Conducteur§", "VCONDUCT", 3500
    //    apiTgrid.AddColumn "§Immatriculation§", "VVEHIMAT", 2500
    //    apiTgrid.AddColumn "§Semaine§", "DFICKMSEM", 1500
    //    apiTgrid.AddColumn "§Path§", "VFICKMSPATH", 0
    //
    //    apiTgrid.Init ado_fickmsarchi
    //
    //End Sub


    private void CmdMax_Click(object sender, EventArgs e)
    {
      if (CmdMax.Text == Resources.txt_Maxi)
      {
        WebBrowser1.Top = 40;
        WebBrowser1.Width = Width - 140;
        WebBrowser1.Height = Height - 90;
        WebBrowser1.BringToFront();
        CmdMax.Text = Resources.txt_Mini;
      }
      else
      {
        WebBrowser1.Top = 380;
        WebBrowser1.Width = 873;
        WebBrowser1.Height = Height - WebBrowser1.Top - 50;
        CmdMax.Text = Resources.txt_Maxi;
      }
    }
    //Private Sub CmdMax_Click()
    //    If CmdMax.Caption = "§Maxi...§" Then
    //      WebBrowser1.width = Screen.width - 4000
    //      WebBrowser1.height = Screen.height - 2000
    //      WebBrowser1.Top = 700
    //      WebBrowser1.Left = 1600
    //      WebBrowser1.ZOrder 0
    //      CmdMax.Caption = "§Mini...§"
    //    Else
    //      WebBrowser1.width = 13095
    //      WebBrowser1.height = 5895
    //      WebBrowser1.Top = 4680
    //      WebBrowser1.Left = 1680
    //      CmdMax.Caption = "§Maxi...§"
    //    End If
    //End Sub


    /*OK --------------------------------------------------------------------------*/
    private void apiTgrid_ClickE(object sender, EventArgs e)
    {
      string strFile;
      DataRow row = apiTgrid.GetFocusedDataRow();
      if (row == null) return;

      strFile = mcChFicheArchi + row["VFICKMSPATH"];
      WebBrowser1.Navigate(strFile);
    }

    //Private Sub apiTgrid_Click()
    //
    //    Dim strFile As String
    //
    //    If ado_fickmsarchi.RecordCount = 0 Then Exit Sub
    //    
    //    strFile = cChFicheArchi & ado_fickmsarchi("VFICKMSPATH")
    //        
    //    WebBrowser1.Navigate2 "about:blank"
    //    WebBrowser1.Navigate2 strFile
    //
    //End Sub

    /*--------------------------------------------------------------------------*/
    private void frmListeFichesKMS_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    //
    //    If ado_fickmsarchi.State = adStateOpen Then ado_fickmsarchi.Close
    //
    //End Sub

    /*--------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdSuppDate_Click(object sender, EventArgs e)
    {
      txtCritDate.Text = "";
    }
    //Private Sub cmdQuitter_Click()
    //    Unload Me
    //End Sub
  }
}

