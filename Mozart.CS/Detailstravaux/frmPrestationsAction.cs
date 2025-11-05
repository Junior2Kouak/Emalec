using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPrestationsAction : Form
  {
    public string mstrStatutPrest;
    public DataTable mdtArticle = new DataTable();

    DataTable dtPrest = new DataTable();

    //  Option Explicit
    //
    //Public mstrStatutPrest As String
    //
    //' UPGRADE_INFO (#0501): The 'adoPrestSaisie' member isn't used anywhere in current application.
    //' Dim adoPrestSaisie As ADODB.Recordset
    //Dim rsD As ADODB.Recordset
    //Dim rsPrest As ADODB.Recordset
    //
    // 
    //
    //

    public frmPrestationsAction() { InitializeComponent(); }

    private void frmPrestationsAction_Load(object sender, System.EventArgs e)
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridHaut.GetFocusedDataRow();

      if (dtPrest.Rows.Count == 0 || currentRow == null) return;
      foreach (DataRow row in dtPrest.Rows)
      {
        if (DejaPresent(Convert.ToInt32(currentRow["NLDCLPRESTID"]))) return;
        if (Utils.ZeroIfNull(row["COCHE"]) != 0) AjouterEnreg(row);
      }
      mdtArticle.DefaultView.Sort = "CAT";
    }

    //Private Sub cmdAjouter_Click()
    //  
    //Dim bMsg As Boolean
    //On Error GoTo handler
    //  
    //  If rsPrest.RecordCount = 0 Then Exit Sub
    //  
    //  bMsg = False
    //  
    //  rsPrest.MoveFirst
    //  While Not rsPrest.EOF
    //    If rsPrest("COCHE") = -1 Then
    //      If Not DejaPresent(rsPrest("ID").value) Then
    //      End If
    //    End If
    //    rsPrest.MoveNext
    //  Wend
    //  
    //  rsarticle.Sort = "CAT"
    //
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " cmdAjouter_Click dans " & Name
    //End Sub
    //

    /* inutile  --------------------------------------------------------------------------------------- */
    private bool DejaPresent(int ID)
    {
      try
      {
        foreach (DataRow row in mdtArticle.Rows)
          if (Convert.ToInt32(row["NLDCLPRESTID"]) == ID) return true;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    //Private Function DejaPresent(ID As Long) As Boolean
    //  
    //  ' on a le numArticle on regarde si il existe
    //  DejaPresent = False
    //  
    //On Error Resume Next
    //  rsarticle.MoveFirst
    //  
    //On Error GoTo handler
    //  
    //  While Not rsarticle.EOF
    //    If rsarticle("ID") = ID Then DejaPresent = True
    //    rsarticle.MoveNext
    //  Wend
    //  
    //Exit Function
    //Resume
    //handler:
    //  ShowError " DejaPresent dans " & Name
    //End Function
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridPrestSaisie.GetFocusedDataRow();
      if (currentRow == null) return;

      mdtArticle.Rows.Remove(currentRow);

      apiTGridPrestSaisie.Requery(mdtArticle, MozartDatabase.cnxMozart);
    }

    //Private Sub CmdSupp_Click()
    //  ' suppression de la ligne courante
    //  If Not rsarticle.EOF And Not rsarticle.BOF Then rsarticle.Delete
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Public Sub InitRecordsetPrest()
    //
    //On Error GoTo handler
    //
    //  Set rsPrest = New ADODB.Recordset
    //  
    //  rsPrest.Fields.Append "COCHE", adInteger
    //  rsPrest.Fields.Append "ID", adInteger
    //  rsPrest.Fields.Append "CAT", adVarChar, 50
    //  rsPrest.Fields.Append "VPRESTLIB", adVarChar, 5000
    //  rsPrest.Fields.Append "VPRESTUNITE", adVarChar, 50
    //  rsPrest.Fields.Append "NQTE", adInteger
    //  rsPrest.Fields.Append "CODEU", adChar, 1
    //  
    //  rsPrest.Open , , adOpenDynamic, adLockOptimistic
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub AjouterLigne(ByVal rs As ADODB.Recordset)
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsPrest.AddNew
    //  
    //  rsPrest("ID").value = rs("NLDCLPRESTID")
    //  rsPrest("CAT").value = BlankIfNull(rs("CAT"))
    //  rsPrest("VPRESTLIB").value = BlankIfNull(rs("VPRESTLIB"))
    //  rsPrest("VPRESTUNITE").value = BlankIfNull(rs("VPRESTUNITE"))
    //  rsPrest("NQTE").value = ZeroIfNull(rs("NQTE"))
    //  rsPrest("CODEU").value = IIf(rs("CODE") = 1, "N", "O")
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

    /* OK --------------------------------------------------------------------------------------- */
    private void InitialiserFeuille()
    {
      try
      {
        string sSQL = "";
        string numDCL = "";
        string myValue = "";

        int numDevis = 0;

        // s'il y a plusieur devis client sur la DI, il faut faire choisir l'utilisateur (uniquement à la création)
        if (mstrStatutPrest == "C")
        {
          // recherche des devis prestation sur la DI
          sSQL = $"SELECT distinct NDCLNUM from TDCL WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM=TDCL.NACTNUM " +
            $" where ndinnum={MozartParams.NumDi} AND CDEVISTYPE = 'P' AND cdclactif='O'";

          using (SqlDataReader drA = ModuleData.ExecuteReader(sSQL))
          {
            if (drA.Read())
            {
              // si plus d'un devis
              numDCL = $"DC {drA["NDCLNUM"]} - ";
              while (drA.Read())
              {
                numDCL += $"DC {drA["NDCLNUM"]} - ";
              }

              myValue = Interaction.InputBox($"Plusieurs devis clients existent sur la DI : \r\n {numDCL}\r\n Saisissez celui que vous voulez utiliser pour cette action.", Program.AppTitle);

              if (myValue == "")
              {
                MessageBox.Show("Il faut choisir un devis client pour pouvoir faire une action de prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              else
              {
                if (Strings.Left(myValue, 1).ToUpper() == "D") numDevis = Convert.ToInt32(Strings.Mid(myValue, 3));
                else numDevis = Convert.ToInt32(myValue);
              }
            }
            else
            {
              if (drA.Read())
                numDevis = (int)Utils.ZeroIfNull(drA["NDCLNUM"]);
            }
          }
        }
        else
        {
          //il faut rechercher le numero de devis client que l'on a utilisé pour faire ce contrat
          //recherche des devis prestation sur le DI
          sSQL = $"SELECT distinct NDCLNUM FROM TACTPREST C INNER JOIN TLDCLPREST L ON L.NLDCLPRESTID = C.NLDCLPRESTID  " +
            $" where NACTNUM={MozartParams.NumAction}";
          using (SqlDataReader drA = ModuleData.ExecuteReader(sSQL))
          {
            if (drA.Read()) numDevis = (int)Utils.ZeroIfNull(drA["NDCLNUM"]);
          }
        }


        // recherche liste des prestations sur les devis client de la DI
        apiTGridHaut.LoadData(dtPrest, MozartDatabase.cnxMozart, $"exec api_sp_listePrestDevisCL {numDevis}");
        apiTGridHaut.GridControl.DataSource = dtPrest;

        apiTGridPrestSaisie.GridControl.DataSource = mdtArticle;

        InitgridHaut();
        InitgridBas();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitialiserFeuille()
    //
    //Dim rsA As ADODB.Recordset
    //Dim numDevis As Long
    //Dim Myvalue, numDCL, sSql
    //
    //On Error GoTo handler
    //
    //  ' si il y a plusieurs devis client sur la DI, il faut faire choisir l'utilisateur (uniquement à la création)
    //  If mstrStatutPrest = "C" Then
    //      ' recherche des devis prestation sur la Di
    //      sSql = "SELECT distinct NDCLNUM from TDCL WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM=TDCL.NACTNUM "
    //      sSql = sSql & " where ndinnum=" & giNumDi & " AND CDEVISTYPE = 'P' AND cdclactif='O'"
    //      Set rsA = New ADODB.Recordset
    //      rsA.Open sSql, cnx
    //      
    //      numDCL = ""
    //      ' si plus d'un
    //      If rsA.RecordCount > 1 Then
    //        While Not rsA.EOF
    //          numDCL = numDCL & "DC" & rsA("NDCLNUM") & " - "
    //          rsA.MoveNext
    //        Wend
    //
    //        Myvalue = InputBox("Plusieurs devis clients existent sur la DI : " & vbCrLf & numDCL & vbCrLf & "Saisissez celui que vous voulez utiliser pour cette action.", "Mozaris")
    //        Select Case Myvalue
    //         Case ""
    //            MsgBox "Il faut choisir un devis client pour pouvoir faire une action de prestation"
    //            Exit Sub
    //         Case Else
    //            If UCase(Left(Myvalue, 1)) = "D" Then
    //              numDevis = val(Mid(Myvalue, 3))
    //            Else
    //              numDevis = Myvalue
    //            End If
    //        End Select
    //      Else
    //        numDevis = rsA("NDCLNUM")
    //      End If
    //  
    //  Else
    //    ' il faut rechercher le numero de devis client que l'on a utilisé pour faire ce contrat
    //      ' recherche des devis prestation sur la Di
    //      sSql = "SELECT distinct NDCLNUM FROM TACTPREST C INNER JOIN TLDCLPREST L ON L.NLDCLPRESTID = C.NLDCLPRESTID  "
    //      sSql = sSql & " where NACTNUM=" & glNumAction
    //      Set rsA = New ADODB.Recordset
    //      rsA.Open sSql, cnx
    //      
    //      If Not rsA.EOF Then numDevis = rsA("NDCLNUM")
    //  End If
    //  
    //  ' recherche liste des prestations sur les devis client de la DI
    //  Set rsD = New ADODB.Recordset
    //  rsD.Open "exec api_sp_listePrestDevisCL " & numDevis, cnx
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
    //  InitgridBas
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " initialiserFeuille dans " & Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void AjouterEnreg(DataRow row)
    {
      DataRow r = mdtArticle.NewRow();
      r["NLDCLPRESTID"] = Utils.BlankIfNull(row["NLDCLPRESTID"]);
      r["CAT"] = Utils.BlankIfNull(row["CAT"]);
      r["VPRESTLIB"] = Utils.BlankIfNull(row["VPRESTLIB"]);
      r["VPRESTUNITE"] = Utils.BlankIfNull(row["VPRESTUNITE"]);
      r["NQTE"] = (int)Utils.ZeroIfNull(row["NQTE"]);
      mdtArticle.Rows.Add(r);
    }

    //Private Sub AjouterEnreg()
    //
    //On Error GoTo handler
    //
    //  ' ajout de l'enregistrement
    //  rsarticle.AddNew
    //  
    //  rsarticle("ID").value = rsPrest("ID")
    //  rsarticle("CAT").value = BlankIfNull(rsPrest("CAT"))
    //  rsarticle("VPRESTLIB").value = BlankIfNull(rsPrest("VPRESTLIB"))
    //  rsarticle("VPRESTUNITE").value = BlankIfNull(rsPrest("VPRESTUNITE"))
    //  rsarticle("NQTE").value = ZeroIfNull(rsPrest("NQTE"))
    //'  rsarticle("DEBOURSE").Value = rsPrest("DEBOURSE")
    //'  rsarticle("NPACHAT").Value = 0
    //
    //  rsarticle.Update
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitgridHaut()
    {
      dtPrest.Columns.Add("COCHE", Type.GetType("System.Boolean"));

      foreach (DataRow row in dtPrest.Rows)
        row["COCHE"] = false;

      apiTGridHaut.AddColumn("ID", "NLDCLPRESTID", 0);
      apiTGridHaut.AddColumn("Cat", "CAT", 700);
      apiTGridHaut.AddColumn("Prestation", "VPRESTLIB", 13000);
      apiTGridHaut.AddColumn("Uté", "VPRESTUNITE", 1800, "", 2);
      apiTGridHaut.AddColumn("Qté", "NQTE", 800, "0.##", 2);

      apiTGridHaut.dgv.OptionsSelection.MultiSelect = true;
      apiTGridHaut.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
      apiTGridHaut.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
      apiTGridHaut.dgv.OptionsSelection.CheckBoxSelectorField = "COCHE";

      apiTGridHaut.InitColumnList();
    }

    //Private Sub InitgridHaut()
    //
    //    apiTGridHaut.AddColumn "ID", "NLDCLPRESTID", 0
    //    apiTGridHaut.AddColumn "Choix", "COCHE", 700, , 2, , , True
    //    apiTGridHaut.AddColumn "Cat", "CAT", 700
    //    apiTGridHaut.AddColumn "Prestation", "VPRESTLIB", 13000
    //    apiTGridHaut.AddColumn "Uté", "VPRESTUNITE", 1800, , 2
    //    apiTGridHaut.AddColumn "Qté", "NQTE", 800, , 2
    //    
    //    ' Style sur la ligne entière uniquement si prestation deja utilisee
    //    apiTGridHaut.AddRowStyle "CODEU", "CODEU", "O", , &HC0C0FF, True
    //
    //    apiTGridHaut.Init rsPrest
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitgridBas()
    {
      apiTGridPrestSaisie.AddColumn("ID", "NLDCLPRESTID", 0);
      apiTGridPrestSaisie.AddColumn("Cat", "CAT", 700);
      apiTGridPrestSaisie.AddColumn("Prestation", "VPRESTLIB", 12000);
      apiTGridPrestSaisie.AddColumn("Uté", "VPRESTUNITE", 1800, "", 2);
      apiTGridPrestSaisie.AddColumn("Qté", "NQTE", 800, "0.##", 2);

      apiTGridPrestSaisie.DelockColumn("NQTE");

      apiTGridPrestSaisie.InitColumnList();
    }

    //Private Sub InitgridBas()
    //
    //    apiTGridPrestSaisie.AddColumn "ID", "NLDCLPRESTID", 0
    //    apiTGridPrestSaisie.AddColumn "Cat", "CAT", 700
    //    apiTGridPrestSaisie.AddColumn "Prestation", "VPRESTLIB", 12000
    //    apiTGridPrestSaisie.AddColumn "Uté", "VPRESTUNITE", 1800, , 2
    //    apiTGridPrestSaisie.AddColumn "Qté", "NQTE", 800, , 2
    //    
    //    apiTGridPrestSaisie.DelockColumn "NQTE"
    //
    //    
    //  apiTGridPrestSaisie.Init rsarticle
    //
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub apiTGridPrestSaisie_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  If DataField = "NPACHAT" Then
    //    CellStyle.BackColor = &HA0FF&
    //    CellStyle.Font.Bold = True
    //  End If
    //End Sub
    //
    //

  }
}

