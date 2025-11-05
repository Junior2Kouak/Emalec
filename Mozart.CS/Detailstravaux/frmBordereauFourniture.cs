using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmBordereauFourniture : Form
  {
    public int Numclient;

    DataTable dt = new DataTable();
    DataTable dtPrest = new DataTable();

    //Public Numclient As Integer
    //
    //Dim rsD As ADODB.Recordset
    //Dim rsPrest As ADODB.Recordset

    public frmBordereauFourniture() { InitializeComponent(); }

    private void frmBordereauFourniture_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitialiserFeuille();
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
    //  InitBoutons Me, frmMenu
    //
    //  InitRecordsetPrest
    //  InitialiserFeuille
    //   
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      if (dtPrest.Rows.Count == 0) return;

      ModuleData.ExecuteNonQuery($"DELETE FROM TCLIBOR WHERE NCLINUM={Numclient}");

      foreach (DataRow item in dtPrest.Select("COCHE2 = true"))
      {
        ModuleData.ExecuteNonQuery($"INSERT INTO TCLIBOR SELECT {Numclient},{item["NFOUNUM"]}, {MozartParams.UID}, Getdate()");
      }

      cmdFermer_Click(null, null);
    }
    //Private Sub cmdValider_Click()
    //  
    //On Error GoTo handler
    //  
    //  If rsPrest.RecordCount = 0 Then Exit Sub
    //  
    //  ' delete des fournitures
    //  cnx.Execute ("DELETE FROM TCLIBOR WHERE NCLINUM=" & Numclient)
    //  
    //  rsPrest.MoveFirst
    //  While Not rsPrest.EOF
    //    If (rsPrest("COCHE") = -1 Or rsPrest("COCHE") = 1) Then
    //        cnx.Execute ("INSERT INTO TCLIBOR SELECT " & Numclient & "," & rsPrest("nfounum") & "," & gintUID & ", Getdate() ")
    //    End If
    //    rsPrest.MoveNext
    //  Wend
    //  
    //  Unload Me
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " cmdAjouter_Click dans " & Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdCocher_Click(object sender, EventArgs e)
    {
      foreach (DataRow item in dtPrest.Rows)
        item["COCHE2"] = true;
    }
    //Private Sub cmdCocher_Click()
    //  rsPrest.MoveFirst
    //  While Not rsPrest.EOF
    //    rsPrest("COCHE") = 1
    //    rsPrest.MoveNext
    //  Wend
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitialiserFeuille()
    {
      //recherche liste des fournitures du client
      apiTGridHaut.LoadData(dtPrest, MozartDatabase.cnxMozart, $"exec api_sp_ListeArticlesEI {Numclient}");
      apiTGridHaut.GridControl.DataSource = dtPrest;

      //on ramène les prestations des devis client prestation
      dtPrest.Columns.Add("COCHE2", typeof(Boolean));
      foreach (DataRow item in dtPrest.Rows)
      {
        if ((int)Utils.ZeroIfBlank(item["COCHE"]) == 0)
          item["COCHE2"] = false;
        else
          item["COCHE2"] = true;
      }

      InitgridHaut();
    }
    //Private Sub InitialiserFeuille()
    //
    //On Error GoTo handler
    //
    //  ' recherche liste des fournitures du client
    //  Set rsD = New ADODB.Recordset
    //  rsD.Open "exec api_sp_ListeArticlesEI " & Numclient, cnx
    //  
    //  ' on ramène les prestations des devis client prestation
    //  While Not rsD.EOF
    //     AjouterLigne rsD
    //     rsD.MoveNext
    //  Wend
    //  
    //  rsD.Close
    //  Set rsD = Nothing
    //  
    //  InitgridHaut
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " initialiserFeuille dans " & Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Fait dans initialiser feuille
    //Public Sub InitRecordsetPrest()
    //
    //On Error GoTo handler
    //
    //  Set rsPrest = New ADODB.Recordset
    //  
    //  rsPrest.Fields.Append "COCHE", adInteger
    //  rsPrest.Fields.Append "NFOUNUM", adInteger
    //  rsPrest.Fields.Append "VFOUMAT", adVarChar, 5000
    //  rsPrest.Fields.Append "NPUHTCLI", adDouble
    //  
    //  
    //  rsPrest.Open , , adOpenDynamic, adLockOptimistic
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Inutile
    //Private Sub AjouterLigne(ByVal rs As ADODB.Recordset)
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsPrest.AddNew
    //  
    //  rsPrest("NFOUNUM").value = rs("NFOUNUM")
    //  rsPrest("VFOUMAT").value = BlankIfNull(rs("VFOUMAT"))
    //  rsPrest("NPUHTCLI").value = ZeroIfNull(rs("NPUHTCLI"))
    //  rsPrest("COCHE").value = IIf(rs("COCHE") = 0, 0, 1)
    //  
    //  rsPrest.Update
    //
    //  On Error Resume Next
    //  rsPrest.MoveFirst
    //  
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterLigne dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitgridHaut()
    {
      apiTGridHaut.AddColumn("NFOUNUM", "NFOUNUM", 0);
      apiTGridHaut.AddColumn("Choix", "COCHE2", 900, "", 2, false, false, true);
      apiTGridHaut.AddColumn("Fourniture", "VFOUMAT", 8000);
      apiTGridHaut.AddColumn("Prix", "NPUHTCLI", 1800, "0.00", 1);

      apiTGridHaut.DelockColumn("COCHE2");

      apiTGridHaut.InitColumnList();
      //Bug avec case coché
    }
    //Private Sub InitgridHaut()
    //
    //    apiTGridHaut.AddColumn "NFOUNUM", "NFOUNUM", 0
    //    apiTGridHaut.AddColumn "Choix", "COCHE", 900, , 2, , , True
    //    apiTGridHaut.AddColumn "Fourniture", "VFOUMAT", 8000
    //    apiTGridHaut.AddColumn "Prix", "NPUHTCLI", 1800, "0.00", 1
    //
    //    apiTGridHaut.Init rsPrest
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

  }
}

