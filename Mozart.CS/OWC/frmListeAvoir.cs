using DevExpress.XtraCharts;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeAvoir : Form
  {
    public string mstrTypeListe;

    private DataTable dt = new DataTable();

    private class donneesGraph
    {
      public string nom { get; set; }
      public decimal valeur { get; set; }
      public donneesGraph() { }
    }


    public frmListeAvoir()
    {
      InitializeComponent();
    }

    private void frmListeAvoir_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        if (mstrTypeListe == "D")
        {
          InitapiGridD();
          cmdRavel.Visible = true;
          Chartspace1.Visible = false;
        }
        else
        {
          InitapiGridM();
        }

        apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_StatListeAvoir {mstrTypeListe}");
        apigrid.GridControl.DataSource = dt;

        if (mstrTypeListe == "D")
        {
          dt.DefaultView.Sort = "VCLINOM, VSTFNOM";
          dt = dt.DefaultView.ToTable();
        }

        // graphique
        if (mstrTypeListe == "M")
        {
          List<donneesGraph> listDataSource = new List<donneesGraph>();

          int nb = Math.Min(11, dt.Rows.Count);
          for (int i = 0; i < nb; i++)
          {
            listDataSource.Add(new donneesGraph() { nom = dt.Rows[i]["VSTFNOM"].ToString(), valeur = (decimal)Utils.ZeroIfNull(dt.Rows[i]["MT"]) });
          }

          Series serie1 = Chartspace1.Series["Serie1"];
          serie1.DataSource = listDataSource;
        }

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


    /*
  Option Explicit
    
    Public mstrTypeListe As String
    
    Dim adoRS As ADODB.Recordset
    
    Private Sub Form_Load()
    
    Dim sSQL As String
    Dim i As Integer
    Dim Values, Categories
    Dim c
    
    On Error GoTo handler:
    
      InitBoutons Me, frmMenu
     
      ' ouverture du recordset
      Set adoRS = New ADODB.Recordset
      sSQL = "exec api_sp_StatListeAvoir " & mstrTypeListe
      adoRS.Open sSQL, cnx
        
      If mstrTypeListe = "D" Then
        adoRS.Sort = "[VCLINOM], [VSTFNOM]"
        InitapiGridD
        cmdRavel.Visible = True
        Chartspace1.Visible = False
      Else
        InitapiGridM
      End If
    
     If mstrTypeListe = "M" Then
      
        adoRS.MoveFirst
      
        For i = 1 To 11
          Categories = Categories & adoRS("VSTFNOM") & Chr(9)
          Values = Values & adoRS("MT").Value & Chr(9)
          adoRS.MoveNext
        Next
      
        ' Remove the leftover tab character at the end of the strings.
        Categories = Left(Categories, Len(Categories) - 1)
        Values = Left(Values, Len(Values) - 1)
      
        ' Create a chart with one series (called "Sales").
        Chartspace1.Clear
        Chartspace1.Charts.Add
        Chartspace1.Charts(0).SeriesCollection.Add
        Chartspace1.Charts(0).SeriesCollection(0).Caption = ""
      
        'Set the series categories and values using the strings created from the recordset.
        Set c = Chartspace1.Constants
        Chartspace1.Charts(0).SeriesCollection(0).SetData c.chDimCategories, c.chDataLiteral, Categories
        Chartspace1.Charts(0).SeriesCollection(0).SetData c.chDimValues, c.chDataLiteral, Values
        
        Chartspace1.HasChartSpaceTitle = True
        Chartspace1.ChartSpaceTitle.Caption = "Montant des avoirs sur 12 mois glissants"
      
      End If
      Screen.MousePointer = vbDefault
      
    Exit Sub
    Resume
    handler:
      Screen.MousePointer = vbDefault
      ShowError "Form_Load  dans " & Me.Name
    End Sub
    */

    private void cmdRavel_Click(object sender, EventArgs e)
    {
      DataRow ligne = apigrid.GetFocusedDataRow();
      if (null == ligne)
      {
        return;
      }

      System.Diagnostics.Process.Start($@"{MozartParams.CheminMozart}\SynchroRavel.exe", $"{MozartParams.NomServeur};{MozartParams.NomSociete};{ligne["nfaccde"].ToString()}");
    }
    /*
    Private Sub cmdRavel_Click()
          Shell gstrCheminMozart & "\SynchroRavel.exe " & gstrNomServeur & ";" & gstrNomSociete & ";   " & adoRS("nfaccde"), vbMaximizedFocus
    End Sub
    */

    private void InitapiGridD()
    {
      apigrid.AddColumn("Client", "vclinom", 3500);
      apigrid.AddColumn("STT", "vstfnom", 3500);
      apigrid.AddColumn("Chaff", "vdinchaff", 2000);
      apigrid.AddColumn("Date", "DFACDATE", 1500, "dd/MM/yy", 2);
      apigrid.AddColumn("Montant HT", "FHTANA", 1500, "Currency", 1);
    }
    /*
  Private Sub InitapiGridD()

  On Error GoTo handler

    apigrid.AddColumn "Client", "VCLINOM", 3500
    apigrid.AddColumn "STT", "VSTFNOM", 3500
    apigrid.AddColumn "Chaff", "VDINCHAFF", 2000
    apigrid.AddColumn "Date", "DFACDATE", 1500, "dd/mm/yy", 2
    apigrid.AddColumn "Montant HT", "FHTANA", 1500, "currency", 1

    apigrid.Init adoRS

  Exit Sub

  handler:
    ShowError "InitApigrid dans " & Me.Name
  End Sub
  */

    private void InitapiGridM()
    {
      apigrid.AddColumn("STT", "vstfnom", 4500);
      apigrid.AddColumn("Nombre ", "NB", 2300, "", 2);
      apigrid.AddColumn("Montant HT", "MT", 1500, "Currency", 1);
    }


    /*
Private Sub InitapiGridM()

On Error GoTo handler

apigrid.AddColumn "STT", "VSTFNOM", 4500
apigrid.AddColumn "Nombre ", "NB", 2300, , vbCenter
apigrid.AddColumn "Montant HT", "MT", 1500, "currency", 1

apigrid.Init adoRS

Exit Sub

handler:
ShowError "InitApigrid dans " & Me.Name
End Sub

Private Sub Form_Unload(Cancel As Integer)
Screen.MousePointer = vbDefault
End Sub

Private Sub cmdQuitter_Click()
' fermeture de la fenetre
Unload Me
End Sub

*/
  }
}

