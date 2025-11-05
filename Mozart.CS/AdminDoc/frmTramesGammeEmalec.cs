using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmTramesGammeEmalec : Form
  {
    DataTable dt = new DataTable();
    //Dim adors As ADODB.Recordset

    public frmTramesGammeEmalec()
    {
      InitializeComponent();
    }

    private void frmTramesGammeEmalec_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
#if APITECHTEST
        cmdIntegration.Visible = true;
#endif
        //  ouverture
        LoadGrid();
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //    
    //On Error GoTo Handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adors = New ADODB.Recordset
    //  adors.Open "api_sp_InfoTramesGammeEmalec 0", cnx, adOpenStatic, adLockOptimistic
    //
    //  InitApiTgrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //Handler:
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

    private void LoadGrid()
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid.LoadData(dt, MozartDatabase.cnxMozart, "api_sp_InfoTramesGammeEmalec 0");
      apiTGrid.GridControl.DataSource = dt;
      Cursor.Current = Cursors.Default;
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      //  écran de création de la demande
      frmListeTramesGamme f = new frmListeTramesGamme();
      f.mstrStatut = "C";
      f.miNumTrame = 0;
      f.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdNouvelle_Click()
    //  ' écran de création de la demande
    //  frmListeTramesGamme.mstrStatut = "C"
    //  frmListeTramesGamme.miNumTrame = 0
    //  frmListeTramesGamme.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //        
    //  adors.Requery
    //  apiTGrid.Init adors, True
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      if (apiTGrid.GetFocusedDataRow() == null) return;

      //  passage des infos
      frmListeTramesGamme f = new frmListeTramesGamme();
      f.mstrStatut = "V";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3));
      f.ShowDialog();
    }
    //Private Sub cmdVisu_Click()
    //  
    //  If adors.EOF Then Exit Sub
    //  
    //  ' passage des infos
    //  frmListeTramesGamme.mstrStatut = "V"
    //  frmListeTramesGamme.miNumTrame = val(Mid(adors("NTRAEMANUM"), 3))
    //  frmListeTramesGamme.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //passage des infos
      frmListeTramesGamme f = new frmListeTramesGamme();
      f.mstrStatut = "Mod";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3));
      f.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdModifier_Click()
    //
    //  If adors.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmListeTramesGamme.mstrStatut = "Mod"
    //  frmListeTramesGamme.miNumTrame = val(Mid(adors("NTRAEMANUM"), 3))
    //  frmListeTramesGamme.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //  adors.Requery
    //  apiTGrid.Init adors, True
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdMod_Click(object sender, EventArgs e)
    {
      if (apiTGrid.GetFocusedDataRow() == null) return;

      Cursor.Current = Cursors.WaitCursor;

      //passage des infos
      frmListeTramesGamme f = new frmListeTramesGamme();
      f.mstrStatut = "M";
      f.miNumTrame = Convert.ToInt32(Strings.Mid(apiTGrid.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3));
      f.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdMod_Click()
    //  
    //  If adors.EOF Then Exit Sub
    //  
    //  Screen.MousePointer = vbHourglass
    //
    //  ' passage des infos
    //  frmListeTramesGamme.mstrStatut = "M"
    //  frmListeTramesGamme.miNumTrame = val(Mid(adors("NTRAEMANUM"), 3))
    //  frmListeTramesGamme.Show vbModal
    //     
    //  Screen.MousePointer = vbHourglass
    //  adors.Requery
    //  apiTGrid.Init adors, True
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdArch_Click(object sender, EventArgs e)
    {
      if (apiTGrid.GetFocusedDataRow() == null) return;

      if (MessageBox.Show(Resources.msg_ConfirmArchivTrame, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        string sSQL = "update TGAMTRAMESEMALEC set CTRAEMAACTIF = 'N' where NTRAEMANUM=" + Convert.ToInt32(Strings.Mid(apiTGrid.GetFocusedDataRow()["NTRAEMANUM"].ToString(), 3)); ;
        ModuleData.ExecuteNonQuery(sSQL);
        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub cmdArch_Click()
    //  
    //Dim sSQL As String
    //
    //  If adors.EOF Then Exit Sub
    //
    //   Select Case MsgBox("§Voulez-vous vraiment archiver cette trame ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //        sSQL = "update TGAMTRAMESEMALEC set CTRAEMAACTIF = 'N' where NTRAEMANUM=" & val(Mid(adors("NTRAEMANUM"), 3))
    //        cnx.Execute sSQL
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  Screen.MousePointer = vbHourglass
    //  adors.Requery
    //  apiTGrid.Init adors, True
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdListeArch_Click(object sender, EventArgs e)
    {
      //  passage des infos
      frmListeTrameGammeArch f = new frmListeTrameGammeArch();
      f.ShowDialog();

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub CmdListeArch_Click()
    //  ' passage des infos
    //  frmListeTrameGammeArch.Show vbModal
    //  
    //  Screen.MousePointer = vbHourglass
    //  adors.Requery
    //  apiTGrid.Init adors, True
    //  Screen.MousePointer = vbDefault
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdEdit_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();

      if (row == null) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TGAMMEEMALEC",
        sIdentifiant = Strings.Mid(row["NTRAEMANUM"].ToString(), 3),
        InfosMail = $"TINT|NSTFNUM|1",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();
    }
    //Private Sub CmdEdit_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //  If adors.EOF Then Exit Sub
    //
    //  On Error Resume Next
    //
    //  TdbGlobal(0, 0) = "Copie"
    //  TdbGlobal(0, 1) = "ORIGINAL"
    //
    //  frmBrowser.bPlanningAn = 0
    //  frmBrowser.InfosMail = "TINT|NINTNUM|1"
    //  frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\TGamme.rtf", _
    //                           "\TGamme1.rtf", _
    //                           TdbGlobal(), _
    //                           "exec api_sp_impGammeTrameEmalec " & val(Mid(adors("NTRAEMANUM"), 3)), _
    //                           " (Visualisation d'une trame " & gstrNomSociete & ")", "PREVIEW"
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_Num, "NTRAEMANUM", 1200);
        apiTGrid.AddColumn(Resources.col_Pays, "VPAYSNOM", 1000);
        apiTGrid.AddColumn(Resources.col_Date, "DTRAEMADAT", 1100, "dd/mm/yy");
        apiTGrid.AddColumn(Resources.col_TypeGamme, "VGAMTYPE", 4200);
        apiTGrid.AddColumn(MZCtrlResources.col_Client, "CLIENTS", 4100, "", 0, true);


        apiTGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApiTgrid()
    //  
    //On Error GoTo Handler
    //
    //  apiTGrid.AddColumn "N °", "NTRAEMANUM", 1200
    //  apiTGrid.AddColumn "§Pays§", "VPAYSNOM", 1000
    //  apiTGrid.AddColumn "§Date§", "DTRAEMADAT", 1100, "dd/mm/yy"
    //  apiTGrid.AddColumn "§Type de gamme§", "VGAMTYPE", 4200
    //  apiTGrid.AddColumn "§Clients§", "CLIENTS", 4100
    //   
    //  apiTGrid.Init adors
    //  apiTGrid.AddCellTip "CLIENTS", &HFDF0DA
    //  Exit Sub
    //
    //Handler:
    //  ShowError "InitApiTGrid dans " & Me.Name
    //End Sub
    //
    //
    //' Intégration automatique d'une gamme

    /* OK ---------------------------------------------------------------------*/
    private void cmdIntegration_Click(object sender, EventArgs e)
    {
      openFileDialog1.Filter = "*.xls|";
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
        IntegrationExcel(openFileDialog1.FileName);

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

    }
    //Private Sub cmdIntegration_Click()
    //
    //Dim ImportFileName As String
    //
    //  On Error Resume Next
    //  CommonDialog1.FileName = ImportFileName
    //  CommonDialog1.Filter = "*.xls|"
    //  CommonDialog1.CancelError = True
    //  CommonDialog1.ShowOpen
    //  If Err.Number <> cdlCancel Then
    //    ImportFileName = CommonDialog1.FileName
    //    IntegrationExcel ImportFileName
    //  End If
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    public void IntegrationExcel(string importFile)
    {
      Microsoft.Office.Interop.Excel.Application OBJxL = new Microsoft.Office.Interop.Excel.Application(); //applicaton Excel

      DataTable dtImport = new DataTable();
      string sSQL = "";

      Cursor.Current = Cursors.WaitCursor;

      try
      {
        //  ouverture du fichier   utilisation de l'objet feuille d'Excel
        OBJxL.Workbooks.Open(importFile, Missing.Value, true);
        Microsoft.Office.Interop.Excel.Worksheet objSh = (Microsoft.Office.Interop.Excel.Worksheet)OBJxL.ActiveSheet;

        //  Remplissage de la datatable locale avec les données du fichier Excel de forme 1 (4 colonnes simples)
        dtImport = CreerRsLocalForm2(objSh);

        OBJxL.Workbooks.Item[1].Close();
        OBJxL.Quit();
        objSh = null;
        OBJxL = null;

        int numTrame = int.Parse(ModuleData.ExecuteScalarString("select max(NTRAEMANUM) from TGAMTRAMESEMALEC")) + 1;

        foreach (DataRow row in dtImport.Rows)
        {
          sSQL = $"insert into  TGAMTRAMESEMALEC ( NTRAEMANUM, VGAMTYPE, VGAMPARA, VGAMLIB, VGAMUNITE, " +
                 $"NGAMNUMPARA, NGAMNUMLIB, DTRAEMADAT, CTRAEMAACTIF, NPAYSNUM) " +
                 $"values ({numTrame}, '{row["VGAMTYPE"].ToString().Replace("'", "''")}', '{row["VGAMPARA"].ToString().Replace("'", "''")}'" +
                 $", '{row["VGAMLIB"].ToString().Replace("'", "''")}', '{row["VGAMUNITE"].ToString().Replace("'", "''")}'" +
                 $", {row["NGAMNUMPARA"]}, {row["NGAMNUMLIB"]}" +
                 $", '{DateTime.Now.ToShortDateString()}', 'O', 1)";

          ModuleData.ExecuteNonQuery(sSQL);
        }
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Public Sub IntegrationExcel(importFile As String)
    //
    //Dim OBJxL As Excel.Application  'application Excel
    //Dim objSh As Excel.Worksheet    'feuille Excel
    //Dim rsImport As Recordset
    //Dim sSQL As String
    //
    //  Screen.MousePointer = vbHourglass
    //  
    //  On Error Resume Next
    //  Set OBJxL = GetObject(, "Excel.Application")
    //  If Err.Number <> 0 Then
    //    Err.Clear
    //    Set OBJxL = CreateObject("Excel.Application")
    //  End If
    //  On Error GoTo Handler
    //  
    //  'ouverture du fichier   utilisation de l'objet feuille d'Excel
    //  OBJxL.Workbooks.Open FileName:=importFile, ReadOnly:=True
    //  Set objSh = OBJxL.ActiveSheet
    //   
    //  ' Remplissage du recordset local avec les données du fichier Excel de forme 1 (4 colonnes simples)
    //  Set rsImport = CreerRsLocalForm2(objSh)
    //  
    //  'On Error Resume Next
    //  
    //  OBJxL.Workbooks.Item(1).Close
    //  OBJxL.Quit
    //  Set objSh = Nothing
    //  Set OBJxL = Nothing
    //  
    //  ' Intégration des données dans la base
    //  Dim adoInfo As ADODB.Recordset
    //  'Dim sSQL As String
    //  
    //  ' recherche du numero de trame suivant
    //  Set adoInfo = New ADODB.Recordset
    //  adoInfo.Open "select max(NTRAEMANUM) from TGAMTRAMESEMALEC", cnx, adOpenStatic, adLockOptimistic
    //  
    //  rsImport.MoveFirst
    //  While Not rsImport.EOF
    //        
    //    sSQL = " insert into  TGAMTRAMESEMALEC ( NTRAEMANUM, VGAMTYPE, VGAMPARA, VGAMLIB, VGAMUNITE, "
    //    sSQL = sSQL & "NGAMNUMPARA, NGAMNUMLIB, DTRAEMADAT, CTRAEMAACTIF, NPAYSNUM) "
    //    sSQL = sSQL & " values ( " & adoInfo(0) + 1 & ", '" & Replace(rsImport!VGAMTYPE, "'", "''") & "', '" & Replace(rsImport!VGAMPARA, "'", "''") & "', '" & Replace(rsImport!VGAMLIB, "'", "''") & "', '"
    //    sSQL = sSQL & Replace(BlankIfNull(rsImport("VGAMUNITE")), "'", "''") & "', "
    //    sSQL = sSQL & rsImport("NGAMNUMPARA") & ", " & rsImport("NGAMNUMLIB")
    //    sSQL = sSQL & ", '" & Date & "', 'O'," & 5 & ")"
    //    cnx.Execute sSQL
    //        
    //    rsImport.Update
    //    rsImport.MoveNext
    //  Wend
    //          
    //  adoInfo.Close
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume
    //  
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "IntegrationExcel dans " + Me.Name
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    DataTable CreerRsLocalForm2(Microsoft.Office.Interop.Excel.Worksheet objSh)
    {
      DataTable dtImport = new DataTable();
      int i;
      bool bOnContinue;

      dtImport.Columns.Add("VGAMTYPE", Type.GetType("System.String"));
      dtImport.Columns.Add("VGAMPARA", Type.GetType("System.String"));
      dtImport.Columns.Add("VGAMLIB", Type.GetType("System.String"));
      dtImport.Columns.Add("NGAMNUMPARA", Type.GetType("System.Int32"));
      dtImport.Columns.Add("NGAMNUMLIB", Type.GetType("System.Int32"));
      dtImport.Columns.Add("VGAMUNITE", Type.GetType("System.String"));

      //lecture des données
      bOnContinue = true;
      i = 2;
      object val;

      //    Boucle pour toutes les lignes non vides
      while (bOnContinue)
      {
        string c1 = (string)(objSh.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value;
        if (c1 != null && c1 != "")
        {
          DataRow newrow = dtImport.NewRow();
          val = (objSh.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value;
          newrow["VGAMTYPE"] = (null == val) ? "" : (string)val;
          val = (objSh.Cells[i, 2] as Microsoft.Office.Interop.Excel.Range).Value;
          newrow["VGAMPARA"] = (null == val) ? "" : (string)val;
          val = (objSh.Cells[i, 3] as Microsoft.Office.Interop.Excel.Range).Value;
          newrow["VGAMLIB"] = (null == val) ? "" : (string)val;
          val = (objSh.Cells[i, 4] as Microsoft.Office.Interop.Excel.Range).Value;
          newrow["NGAMNUMPARA"] = (null == val) ? 0 : int.Parse(val.ToString());
          val = (objSh.Cells[i, 5] as Microsoft.Office.Interop.Excel.Range).Value;
          newrow["NGAMNUMLIB"] = (null == val) ? 0 : int.Parse(val.ToString());
          val = (objSh.Cells[i, 6] as Microsoft.Office.Interop.Excel.Range).Value;
          newrow["VGAMUNITE"] = (null == val) ? "" : (string)val;
          dtImport.Rows.Add(newrow);
          i++;
        }
        else bOnContinue = false;
      }
      return dtImport;
    }
    //Function CreerRsLocalForm2(objSh) As ADODB.Recordset
    //  
    //Dim rsImport As ADODB.Recordset
    //Dim i As Integer
    //Dim bOnContinue As Boolean
    //
    //  Set rsImport = New ADODB.Recordset
    //  rsImport.Fields.Append "VGAMTYPE", adVarChar, 100
    //  rsImport.Fields.Append "VGAMPARA", adVarChar, 500
    //  rsImport.Fields.Append "VGAMLIB", adVarChar, 5000
    //  rsImport.Fields.Append "NGAMNUMPARA", adInteger
    //  rsImport.Fields.Append "NGAMNUMLIB", adInteger
    //  rsImport.Fields.Append "VGAMUNITE", adVarChar, 50
    //  
    //  rsImport.Open
    //  
    //  ' lecture des données
    //  bOnContinue = True
    //  i = 2
    //  
    //  ' Boucle pour toutes les lignes non vides
    //  While bOnContinue
    //    If objSh.Cells(i, 1).value <> "" Then
    //      rsImport.AddNew
    //      rsImport!VGAMTYPE = objSh.Cells(i, 1).value
    //      rsImport!VGAMPARA = objSh.Cells(i, 2).value
    //      rsImport!VGAMLIB = objSh.Cells(i, 3).value
    //      rsImport!NGAMNUMPARA = objSh.Cells(i, 4).value
    //      rsImport!NGAMNUMLIB = objSh.Cells(i, 5).value
    //      rsImport!VGAMUNITE = objSh.Cells(i, 6).value
    //      rsImport.Update
    //      i = i + 1
    //    Else
    //      bOnContinue = False
    //    End If
    //  Wend
    //
    //  Set CreerRsLocalForm2 = rsImport
    //
    //End Function
    //

    /* Inutile ---------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
  }
}