using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
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
  public partial class frmPrestationsContrat : Form
  {
    public long miNumContratST;
    public DataTable dtArticle;

    private DataTable dtPrest = new DataTable();
    private DataTable dtDoc = new DataTable();
    private DataTable dtHisto = new DataTable();

    //Public iNumContratST As Long
    //
    //Dim rsD As ADODB.Recordset
    //Dim rsPrest As ADODB.Recordset
    //Dim adorsHisto As ADODB.Recordset

    public frmPrestationsContrat() { InitializeComponent(); }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmPrestationsContrat_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        InitgridHistoPrest();

        InitialiserFeuille();
        InitApigridDoc();
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
    //  InitgridHistoPrest
    //  'Init
    //  Set adorsHisto = New ADODB.Recordset
    //  apiTGridPrestHisto.Init adorsHisto
    //
    //  InitRecordsetPrest
    //  InitialiserFeuille
    //  
    //  InitApigridDoc
    //   
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdValider_Click()
    //
    //'MISE EN COM le 26/03/2018 par MC suite à un mail de Piere chevalier
    //
    //'  If Not TestSelection Then
    //'    MsgBox "Si vous sélectionnez une prestation, il faut saisir un prix d'achat pour cette prestation"
    //'    Exit Sub
    //'  End If
    //  Unload Me
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void InitApigridDoc()
    {
      apiTGrid2.LoadData(dtDoc, MozartDatabase.cnxMozart, $"EXEC api_sp_StatutDocContratSTF {miNumContratST}");

      apiTGrid2.AddColumn("NSTFGRPNUM", "NSTFGRPNUM", 0);
      apiTGrid2.AddColumn("Statut", "VLIBSTATUT", 1100);
      apiTGrid2.AddColumn("Nb ctrts", "NBCST", 1000, "", 1);
      apiTGrid2.AddColumn("CA STT", "NSTFGRPCA", 1300, "# ### ##0 €", 1);
      apiTGrid2.AddColumn("CA emalec 12 mois", "NSTFGRPFA", 1300, "# ### ##0 €", 1);
      apiTGrid2.AddColumn("Dépendance %", "TAUX", 800, "#00%", 1);
      apiTGrid2.AddColumn("Kbis", "DOC1", 1100, "", 0, true);
      apiTGrid2.AddColumn("RC", "DOC2", 1100, "", 0, true);
      apiTGrid2.AddColumn("Décennale", "DOC3", 1100, "", 0, true);
      apiTGrid2.AddColumn("Sociale", "DOC4", 1100, "", 0, true);
      apiTGrid2.AddColumn("Fiscale", "DOC5", 1100, "", 0, true);
      apiTGrid2.AddColumn("Fluides", "DOC9", 1250, "", 0, true);
      apiTGrid2.AddColumn("Conf & NC", "DOC10", 1200, "", 0, true);
      apiTGrid2.AddColumn("CSTFGRPSANSDOC", "CSTFGRPSANSDOC", 0);  // pas de gestion des docs adm du STT


      apiTGrid2.btnExcel.Visible = apiTGrid2.btnPrint.Visible = apiTGrid2.chkColumnsList.Visible = false;

      apiTGrid2.GridControl.DataSource = dtDoc;
    }

    /* --------------------------------------------------------------------------------------- */
    private void apiTGrid2_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {

      // pas de gestion des couleurs si STT sans gestion des docs Admin
      if (e.RowHandle >= 0 && (sender as GridView).GetDataRow(e.RowHandle)["CSTFGRPSANSDOC"].ToString() == "O")
        return;

      //e.Appearance.ForeColor = Color.IndianRed;
      if (e.Column.Name == "DOC1" || e.Column.Name == "DOC2" || e.Column.Name == "DOC3" || e.Column.Name == "DOC4"
                || e.Column.Name == "DOC5") //|| e.Column.Name == "DOC10")
      {
        if (e.CellValue != DBNull.Value)
        {
          if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
            e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
          if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
            e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
        }
        else
          e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
      }
      // gestion spécifique pour l'attestation fluide frigo
      if (e.RowHandle >= 0 && (e.Column.Name == "DOC9"))
      {  // si stt clim, alors doc obligatoire et gestion de la couleur
        if ((sender as GridView).GetDataRow(e.RowHandle)["FF"].ToString() != "0")
        {
          if (e.CellValue != DBNull.Value)
          {
            if (Convert.ToDateTime(e.CellValue) < DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FFFF; //'Périmé
            if (Convert.ToDateTime(e.CellValue) >= DateTime.Now)
              e.Appearance.BackColor = MozartColors.ColorH80FF80; //OK
          }
          else
            e.Appearance.BackColor = MozartColors.colorHFFC0FF; // Non conforme
        }
      }

    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtPrest.Rows.Count == 0) return;

        bool bMsg = false;

        foreach (DataRow item in dtPrest.Select("COCHE = true"))
        {
          if (!DejaPresent(Convert.ToInt32(item["NLDCLPRESTID"])))
          {
            if (DejaUtiliseDansUnContrat(Convert.ToInt32(item["NLDCLPRESTID"])))
              bMsg = true;
            else
            {
              dtArticle.ImportRow(item);
              // Mettre une valeur (par défaut) à la colonne CMATFOURNI
              dtArticle.Rows[dtArticle.Rows.Count - 1]["CMATFOURNI"] = "NON";
              dtArticle.Rows[dtArticle.Rows.Count - 1]["NPUNITAIRE"] = Utils.ZeroIfNull(item["NPUNITAIRE"]);
              dtArticle.Rows[dtArticle.Rows.Count - 1]["NPACHAT"] = Utils.ZeroIfNull(item["NPUNITAIRE"]) * Utils.ZeroIfNull(item["NQTE"]);
            }
          }
        }

        dtArticle.DefaultView.Sort = "CAT";

        CalculTot();

        if (bMsg)
          MessageBox.Show("On ne peut pas sélectionner une prestation déjà utilisée dans un contrat de prestation ", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
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
    //        If DejaUtiliseDsUnContrat(rsPrest("ID").value) Then
    //          bMsg = True
    //        Else
    //          AjouterEnreg
    //        End If
    //      End If
    //    End If
    //    rsPrest.MoveNext
    //  Wend
    //  
    //  rsarticle.Sort = "CAT"
    //  CalculTot
    //
    //  If bMsg Then MsgBox "On ne peut pas sélectionner une prestation déjà utilisée dans un contrat de prestation "
    //  
    //  ' Style sur la ligne entière uniquement si prestation deja utilisee
    //'  apiTGridHaut.AddRowStyle "CODEU", "CODEU", "O", , &HC0C0FF, True
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " cmdAjouter_Click dans " & Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridHaut_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (Convert.ToInt32(View.GetDataRow(e.RowHandle)["CODE"]) != 1)
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.Appearance.BackColor = MozartColors.colorHC0C0FF;
          e.HighPriority = true;
        }
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    private Boolean DejaPresent(long ID)
    {
      return dtArticle.Select($"NLDCLPRESTID = {ID}").Length > 0;
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

    /* OK --------------------------------------------------------------------------------------- */
    private bool DejaUtiliseDansUnContrat(long ID)
    {
      return (int)ModuleData.ExecuteScalarInt($"select count(VPRESTLIB) from TCSTPREST P INNER JOIN TCST S ON P.NCSTNUM = S.NCSTNUM INNER JOIN TLDCLPREST T " +
                                              $"ON T.NLDCLPRESTID = P.NLDCLPRESTID where CCSTACTIF = 'O' and P.NLDCLPRESTID = {ID} AND S.NCSTNUM <> {miNumContratST}") > 0;
    }
    //Private Function DejaUtiliseDsUnContrat(ID As Long) As Boolean
    //  
    // Dim rsTemp As ADODB.Recordset
    // Dim strAux As String
    // 
    // DejaUtiliseDsUnContrat = False
    // 
    //   ' recherche si la prestation choisi a deja été utilisée dans un contrat
    //  Set rsTemp = New ADODB.Recordset
    //  strAux = "select count(VPRESTLIB) from TCSTPREST P INNER JOIN TCST S ON P.NCSTNUM=S.NCSTNUM INNER JOIN "
    //  strAux = strAux & "TLDCLPREST T ON T.NLDCLPRESTID = P.NLDCLPRESTID where CCSTACTIF='O' and P.NLDCLPRESTID= " & ID & " AND S.NCSTNUM<> " & iNumContratST
    //          
    //  rsTemp.Open strAux, cnx
    //  
    //  If rsTemp(0) > 0 Then DejaUtiliseDsUnContrat = True
    //  
    //  rsTemp.Close
    //  Set rsTemp = Nothing
    //  
    //Exit Function
    //Resume
    //handler:
    //  ShowError " DejaUtiliseDsUnContrat dans " & Name
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupp_Click(object sender, EventArgs e)
    {
      //int i = apiTGridPrestSaisie.dgv.FocusedRowHandle;
      //if (i >= 0)
      //{
      //  // Suppression de la ligne courante
      //  dtArticle.Rows.RemoveAt(i);
      //  apiTGridPrestSaisie.GridControl.DataSource = dtArticle;
      //  CalculTot();
      // suppression de la ligne courante
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (row == null) return;

      row.Delete();
      dtArticle.AcceptChanges();

      CalculTot();
    }
    //Private Sub CmdSupp_Click()
    //  ' suppression de la ligne courante
    //  If Not rsarticle.EOF And Not rsarticle.BOF Then rsarticle.Delete
    //  CalculTot
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    // fait dans InitialiserFeuille
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
    //  rsPrest.Fields.Append "DEBOURSE", adDouble
    //  rsPrest.Fields.Append "DEBOURSEUNIT", adDouble
    //  rsPrest.Fields.Append "CODEU", adChar, 1
    //  rsPrest.Fields.Append "NPUNITAIRE", adDouble
    //  'rsPrest.Fields.Append "CMATFOURNI", adChar
    //    
    //  rsPrest.Open , , adOpenDynamic, adLockOptimistic
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "InitRecordsetArticle dans " & Me.Name
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
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
    //  rsPrest("NPUNITAIRE").value = ZeroIfNull(rs("NPUNITAIRE"))
    //  rsPrest("DEBOURSE").value = rs("DEBOURSE")
    //  rsPrest("DEBOURSEUNIT").value = rs("DEBOURSUNIT")
    //  'rsPrest("CMATFOURNI").Value = "NON"
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

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitialiserFeuille()
    {
      try
      {
        int numDevis = 0;
        //  si il y a plusieurs devis client sur la DI, il faut faire choisir l'utilisateur (uniquement à la création)
        if (miNumContratST == 0)
        {
          // Recherche des devis prestation sur la DI        
          string sSql = $"SELECT distinct NDCLNUM from TDCL WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TACT.NACTNUM = TDCL.NACTNUM Where NDINNUM = {MozartParams.NumDi} AND CDEVISTYPE = 'P' AND CDCLACTIF = 'O'";
          using (SqlDataReader drA = ModuleData.ExecuteReader(sSql))
          {
            // si plus d'un devis
            drA.Read();
            string numDCL = $"DC{drA["NDCLNUM"]} - ";
            numDevis = Convert.ToInt32(drA["NDCLNUM"]);
            if (drA.Read())
            {
              do
              {
                numDCL += $"DC{drA["NDCLNUM"]} - ";
              } while (drA.Read());
              string sValue = Interaction.InputBox($"Plusieurs devis clients existent sur la DI :{Environment.NewLine}{numDCL}{Environment.NewLine}Saisissez celui que vous voulez utiliser pour ce contrat.", Program.AppTitle).ToUpper();
              if (sValue == "")
              {
                MessageBox.Show("Il faut choisir un devis client pour pouvoir faire un contrat de prestation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
              else
                numDevis = Convert.ToInt32(sValue.StartsWith("D") ? sValue.Substring(2) : sValue);
            }
          }
        }
        else
        {
          // Il faut rechercher le numero de devis client que l'on a utilisé pour faire ce contrat
          // Recherche des devis prestation sur la Di
          string sSql = $"SELECT distinct NDCLNUM FROM TCSTPREST C INNER JOIN TLDCLPREST L ON L.NLDCLPRESTID = C.NLDCLPRESTID where NCSTNUM = {miNumContratST}";
          numDevis = (int)ModuleData.ExecuteScalarInt(sSql);
        }

        //  Recherche liste des prestations sur les devis client de la DI
        apiTGridHaut.LoadData(dtPrest, MozartDatabase.cnxMozart, $"EXEC api_sp_listePrestDevisCL {numDevis}");
        apiTGridHaut.GridControl.DataSource = dtPrest;
        // Ajouter une colonne pour la coche
        dtPrest.Columns.Add("COCHE", typeof(Boolean));
        foreach (DataRow item in dtPrest.Rows)
          item["COCHE"] = false;

        //  Si on est en modification calcul  du total
        if (miNumContratST > 0)
          CalculTot();

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
    //  If iNumContratST = 0 Then
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
    //        Myvalue = InputBox("Plusieurs devis clients existent sur la DI : " & vbCrLf & numDCL & vbCrLf & "Saisissez celui que vous voulez utiliser pour ce contrat.", "Mozaris")
    //        Select Case Myvalue
    //         Case ""
    //            MsgBox "Il faut choisir un devis client pour pouvoir faire un contrat de prestation"
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
    //      sSql = "SELECT distinct NDCLNUM FROM TCSTPREST C INNER JOIN TLDCLPREST L ON L.NLDCLPRESTID = C.NLDCLPRESTID  "
    //      sSql = sSql & " where NCSTNUM=" & iNumContratST
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
    //  ' si on est en modification calcul  du total
    //  If iNumContratST > 0 Then CalculTot
    //
    //  InitgridHaut
    //  InitgridBas
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " initialiserFeuille dans " & Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    // Remplacé par ImportRow
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
    //  rsarticle("NPUNITAIRE").value = BlankIfNull(rsPrest("NPUNITAIRE"))
    //  rsarticle("NQTE").value = ZeroIfNull(rsPrest("NQTE"))
    //  rsarticle("DEBOURSE").value = rsPrest("DEBOURSE")
    //  rsarticle("DEBOURSUNIT").value = rsPrest("DEBOURSEUNIT")
    //  ' rsarticle("NPACHAT").Value = 0
    //  rsarticle("NPACHAT") = rsarticle("NPUNITAIRE") * rsarticle("NQTE")
    //  rsarticle("CMATFOURNI").value = "NON"
    //
    //  rsarticle.Update
    //
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitgridHaut()
    {
      apiTGridHaut.AddColumn(Resources.col_ID, "NLDCLPRESTID", 0);
      apiTGridHaut.AddColumn("Choix", "COCHE", 300, "", 2, true, true);
      apiTGridHaut.AddColumn(Resources.col_Cat, "CAT", 700);
      apiTGridHaut.AddColumn(Resources.col_Prestation, "VPRESTLIB", 2000);
      apiTGridHaut.AddColumn(Resources.col_unite, "VPRESTUNITE", 800, "", 2);
      apiTGridHaut.AddColumn(Resources.col_qte3, "NQTE", 800, "", 2);
      apiTGridHaut.AddColumn("Déboursé HT", "DEBOURSE", 1500, "Currency", 2);
      apiTGridHaut.AddColumn("NCSTNUM", "NCSTNUM", 0);

      apiTGridHaut.DelockColumn("COCHE");
      foreach (DataRow item in dtPrest.Rows)
        item["COCHE"] = false;

      apiTGridHaut.InitColumnList();
    }
    //Private Sub InitgridHaut()
    //
    //    apiTGridHaut.AddColumn "ID", "NLDCLPRESTID", 0
    //    apiTGridHaut.AddColumn "Choix", "COCHE", 700, , 2, , , True
    //    apiTGridHaut.AddColumn "Cat", "CAT", 700
    //    apiTGridHaut.AddColumn "Prestation", "VPRESTLIB", 8000
    //    apiTGridHaut.AddColumn "Uté", "VPRESTUNITE", 800, , 2
    //    apiTGridHaut.AddColumn "Qté", "NQTE", 800, , 2
    //    apiTGridHaut.AddColumn "Déboursé HT", "DEBOURSE", 1500, "Currency", 2
    //    apiTGridHaut.AddColumn "NCSTNUM", "NCSTNUM", 0
    //    
    //    ' Style sur la ligne entière uniquement si prestation deja utilisee
    //    apiTGridHaut.AddRowStyle "CODEU", "CODEU", "O", , &HC0C0FF, True
    //
    //    apiTGridHaut.Init rsPrest
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void InitgridBas()
    {
      apiTGridPrestSaisie.AddColumn("ID", "NLDCLPRESTID", 0);                             // 0
      apiTGridPrestSaisie.AddColumn(Resources.col_Cat, "CAT", 660);                         // 1
      apiTGridPrestSaisie.AddColumn(Resources.col_Prestation, "VPRESTLIB", 4500);           // 2
      apiTGridPrestSaisie.AddColumn(Resources.col_unite, "VPRESTUNITE", 660, "", 2);        // 3
      apiTGridPrestSaisie.AddColumn(Resources.col_qte3, "NQTE", 660, "", 2);                // 4
      apiTGridPrestSaisie.AddColumn("Mat fourni", "CMATFOURNI", 1220);                      // 5
      apiTGridPrestSaisie.AddColumn("Débours unit", "DEBOURSUNIT", 1420, "Currency", 2);    // 6
      apiTGridPrestSaisie.AddColumn("Achat Unit", "NPUNITAIRE", 1300, "Currency", 2);       // 7
      apiTGridPrestSaisie.AddColumn("Tot débours", "DEBOURSE", 1400, "Currency", 2);        // 8
      apiTGridPrestSaisie.AddColumn("Total achat", "NPACHAT", 1300, "Currency", 2);         // 9

      apiTGridPrestSaisie.DelockColumn("NQTE");
      apiTGridPrestSaisie.DelockColumn("NPUNITAIRE");
      apiTGridPrestSaisie.DelockColumn("CMATFOURNI");

      apiTGridPrestSaisie.GridControl.DataSource = dtArticle;
      apiTGridPrestSaisie.InitColumnList();
    }
    //Private Sub InitgridBas()
    //
    //    apiTGridPrestSaisie.AddColumn "ID", "ID", 0       ' 0
    //    apiTGridPrestSaisie.AddColumn "Cat", "CAT", 660   ' 1
    //    apiTGridPrestSaisie.AddColumn "Prestation", "VPRESTLIB", 4500   ' 2
    //    apiTGridPrestSaisie.AddColumn "Uté", "VPRESTUNITE", 660, , 2    ' 3
    //    apiTGridPrestSaisie.AddColumn "Qté", "NQTE", 660, , 2           ' 4
    //    apiTGridPrestSaisie.AddColumn "Mat fourni", "CMATFOURNI", 1220                 ' 5
    //    apiTGridPrestSaisie.AddColumn "Débours unit", "DEBOURSUNIT", 1420, "Currency", 2  ' 6
    //    apiTGridPrestSaisie.AddColumn "Achat Unit", "NPUNITAIRE", 1300, "Currency", 2   ' 7
    //    apiTGridPrestSaisie.AddColumn "Tot débours", "DEBOURSE", 1400, "Currency", 2  ' 8
    //    apiTGridPrestSaisie.AddColumn "Total achat", "NPACHAT", 1300, "Currency", 2     ' 9
    //            
    //    apiTGridPrestSaisie.AddCellStyle "NPACHAT", "", vbBlack, vbWhite ' pour passer dans FetchCellStyle
    //    apiTGridPrestSaisie.AddCellStyle "NPUNITAIRE", "", vbBlack, vbWhite ' pour passer dans FetchCellStyle
    //    apiTGridPrestSaisie.DelockColumn "NPUNITAIRE"
    //    apiTGridPrestSaisie.AddCellStyle "CMATFOURNI", "", vbBlack, vbWhite ' pour passer dans FetchCellStyle
    //    apiTGridPrestSaisie.DelockColumn "CMATFOURNI"
    //    apiTGridPrestSaisie.AddCellStyle "NQTE", "", vbBlack, vbWhite ' pour passer dans FetchCellStyle
    //    apiTGridPrestSaisie.DelockColumn "NQTE"
    //    
    //  apiTGridPrestSaisie.Init rsarticle
    //
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void apiTGridPrestSaisie_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      if (e.Column.Name == "NPACHAT")
      {
        double dprixDebourse = 1;
        foreach (DataRow row in dtArticle.Rows)
        {
          if (row["NPACHAT"].ToString() == e.CellValue.ToString())
          {
            string sPrixDebourse = Utils.BlankIfNull(row["DEBOURSE"]).ToString().Replace(" €", "");
            dprixDebourse = Convert.ToDouble(sPrixDebourse);
          }
        }
        string sPrixAchat = Utils.BlankIfNull(e.CellValue).ToString().Replace(" €", "");
        if (sPrixAchat != "")
        {
          double dPrixAchat = Convert.ToDouble(sPrixAchat);
          if (dPrixAchat <= dprixDebourse)
            e.Appearance.BackColor = Color.Lime;
          else
            e.Appearance.BackColor = Color.Red;
        }
      }

      if (e.Column.Name == "CMATFOURNI" || e.Column.Name == "NPUNITAIRE" || e.Column.Name == "NQTE")
      {
        e.Appearance.BackColor = Color.Orange;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    //Private Sub apiTGridPrestSaisie_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  If DataField = "NPACHAT" Then
    //    Dim prix_achat As String
    //    Dim prix_debourse As String
    //    Dim dblprix_achat As Double
    //    Dim dblprix_debourse As Double
    //    prix_achat = Replace(Cols(col).CellText(BookMark), " €", "")

    //    If prix_achat <> "" Then
    //      dblprix_achat = prix_achat
    //      prix_debourse = Replace(Cols(8).CellText(BookMark), " €", "")
    //      dblprix_debourse = prix_debourse
    //      If dblprix_achat <= dblprix_debourse Then
    //        CellStyle.BackColor = &HFF00&
    //      Else
    //        CellStyle.BackColor = &HFF&
    //      End If
    //    End If
    //  End If
    //
    //  If DataField = "CMATFOURNI" Then
    //    CellStyle.BackColor = &HA0FF&
    //    CellStyle.Font.Bold = True
    //  End If
    //
    //  If DataField = "NPUNITAIRE" Then
    //    CellStyle.BackColor = &HA0FF&
    //    CellStyle.Font.Bold = True
    //  End If
    //
    //  If DataField = "NQTE" Then
    //    CellStyle.BackColor = &HA0FF&
    //    CellStyle.Font.Bold = True
    //  End If
    //End Sub     

    /* --------------------------------------------------------------------------------------- */
    private void apiTGridPrestSaisie_CellValueChanged(object sender, CellValueChangedEventArgs e)
    {
      string nomCol = e.Column.Name;

      if (e.RowHandle < 0) return;

      // Mise à jour du total achat
      if (nomCol == "NQTE" || nomCol == "NPUNITAIRE") // Colonne Prix unitaire ou Qté
      {
        DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
        if (row["NPUNITAIRE"].ToString() != "" && row["NQTE"].ToString() != "")
          row["NPACHAT"] = Convert.ToDouble(row["NPUNITAIRE"]) * Convert.ToDouble(row["NQTE"]);
        CalculTot();
      }

      // Mise à jour du total débours
      nomCol = e.Column.Name;
      if (nomCol == "NQTE")
      {
        DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
        if (row["DEBOURSUNIT"].ToString() != "" && row["NQTE"].ToString() != "")
          row["DEBOURSE"] = Convert.ToDouble(row["DEBOURSUNIT"]) * Convert.ToDouble(row["NQTE"]);
        CalculTot();
      }

      if (nomCol == "CMATFOURNI")
        CalculTot();
    }
    //Private Sub apiTGridPrestSaisie_AfterColUpdate(ColIndex As Integer)
    //  ' mise a jour du total
    //  If ColIndex = 7 Or ColIndex = 4 Then ' Colonne Prix unitaire ou Qté
    //    If rsarticle("NPUNITAIRE") <> "" And rsarticle("NQTE") <> "" Then
    //        rsarticle("NPACHAT") = rsarticle("NPUNITAIRE") * rsarticle("NQTE")
    //    End If
    //    CalculTot
    //  End If
    //  
    //  If ColIndex = 5 Then
    //    CalculTot
    //  End If
    //  
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void apiTGridPrestSaisie_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
      if (row == null) return;

      if (e.Column.Name == "CMATFOURNI")
      {
        GridView view = (GridView)sender;

        string val = e.Value.ToString().ToUpper();
        val = val == "O" ? "OUI" : "NON";

        view.SetRowCellValue(e.RowHandle, "CMATFOURNI", val);

        //  Recalcule...
        // 1er paramètre non utilisé
        using (IDataReader drD = ModuleData.ExecuteReader($"exec api_sp_calculeDeboursContratCST 0, {row["NLDCLPRESTID"]}, {val}"))
        {
          // On ramène le montant de débours
          if (drD.Read())
          {
            view.SetRowCellValue(e.RowHandle, "DEBOURSE", Utils.ZeroIfNull(drD["DEBOURSE"]));
            view.SetRowCellValue(e.RowHandle, "DEBOURSEUNIT", Utils.ZeroIfNull(drD["DEBOURSEUNIT"]));
          }
        }

        CalculTot();
      }
    }
    //Private Sub apiTGridPrestSaisie_BeforeColUpdate(ColIndex As Integer, Cols As TrueOleDBGrid80.Columns, BookMark As Variant, Cancel As Integer)
    //
    //  If ColIndex = 5 Then  ' Colonne Matériel fourni
    //    Dim val As String
    //    val = Cols(ColIndex).CellText(BookMark)
    //    val = UCase(val)
    //    If val = "O" Then
    //      val = "OUI"
    //      Cols(ColIndex).value = val
    //    Else
    //      val = "NON"
    //      Cols(ColIndex).value = val
    //    End If
    //
    //    Cols(ColIndex).value = val ' Majuscule
    //    ' Recalcule...
    //    Set rsD = New ADODB.Recordset
    //    rsD.Open "exec api_sp_calculeDeboursContratCST " & iNumContratST & "," & Cols(0).value & "," & val, cnx
    //    
    //    ' on ramène le montant de débours
    //    If Not rsD.EOF Then
    //      rsD.MoveFirst
    //      Cols(8).value = rsD("DEBOURSE")  ' Colonne DEBOURSE
    //      Cols(6).value = rsD("DEBOURSEUNIT")  ' Colonne DEBOURSUNIT
    //    End If
    //    rsD.Close
    //    Set rsD = Nothing
    //  End If
    //  
    //End Sub

    /* Inutile --------------------------------------------------------------------------------------- */
    //'Private Sub apiTGridHaut_AfterColUpdate(ColIndex As Integer)
    //'  If ColIndex = 1 Then
    //'    If rsPrest!CODEU = "O" And rsPrest!COCHE = -1 Then
    //'      rsPrest!COCHE = 0
    //'    End If
    //'  End If
    //'End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void CalculTot()
    {
      double tot = 0, totDebours = 0;
      foreach (DataRow item in dtArticle.Rows)
      {
        tot += Convert.ToDouble(Utils.ZeroIfNull(item["NPACHAT"]));
        totDebours += Convert.ToDouble(item["DEBOURSE"]);
      }
      txtTHT.Text = $"Total achat HT : {tot.ToString("C2")}";
      txtTDHT.Text = $"Total déboursé HT : {totDebours.ToString("C2")}";
    }
    //Private Sub CalculTot()
    //
    //Dim tot As Double
    //Dim totDebours As Double
    //
    //On Error Resume Next
    //   
    //  ' recherche des cases cocher dans le datagrid
    //  tot = 0
    //  totDebours = 0
    //  
    //  rsarticle.MoveFirst
    //  While Not rsarticle.EOF
    //    tot = tot + rsarticle("NPACHAT")
    //    totDebours = totDebours + rsarticle("DEBOURSE")
    //    rsarticle.MoveNext
    //  Wend
    //   
    //  ' maj du total
    //  txtTHT.Caption = "Total achat HT : " & tot & " € HT"
    //  txtTDHT.Caption = "Total déboursé HT : " & totDebours & " € HT"
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdCocher_Click(object sender, EventArgs e)
    {
      foreach (DataRow item in dtPrest.Rows)
        item["COCHE"] = true;
    }
    //Private Sub cmdCocher_Click()
    //  ' Cocher toutes les lignes
    //  If rsPrest.RecordCount = 0 Then Exit Sub
    //  
    //  rsPrest.MoveFirst
    //  While Not rsPrest.EOF
    //    rsPrest("COCHE") = -1
    //    rsPrest.MoveNext
    //  Wend
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      foreach (DataRow item in dtPrest.Rows)
        item["COCHE"] = false;
    }
    //Private Sub cmdDecocher_Click()
    //  If rsPrest.RecordCount = 0 Then Exit Sub
    //  
    //  rsPrest.MoveFirst
    //  While Not rsPrest.EOF
    //    rsPrest("COCHE") = 0
    //    rsPrest.MoveNext
    //  Wend
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void InitgridHistoPrest()
    {
      apiTGridPrestHisto.AddColumn(Resources.col_Date, "DCSTDAT", 1100);
      apiTGridPrestHisto.AddColumn(Resources.col_Filiale, "VSOCIETE", 1200);
      apiTGridPrestHisto.AddColumn(Resources.col_createurE, "VPERNOM", 1800);
      apiTGridPrestHisto.AddColumn(Resources.col_NomSTT, "VSTFNOM", 1800);
      apiTGridPrestHisto.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1500);
      apiTGridPrestHisto.AddColumn(Resources.col_DI, "NDINNUM", 900);
      apiTGridPrestHisto.AddColumn(Resources.col_Qte, "NQTE", 600, "", 1);
      apiTGridPrestHisto.AddColumn("Achat unit", "NPACHAT", 1200, "Currency", 1);
      apiTGridPrestHisto.AddColumn("Mat. fourni", "CMATFOURNI", 1260);
      apiTGridPrestHisto.AddColumn("Débours unit", "DEBOURSEUNIT", 1300, "Currency", 2);
      apiTGridPrestHisto.btnExcel.Visible = apiTGridPrestHisto.btnPrint.Visible = apiTGridPrestHisto.chkColumnsList.Visible = false;
    }
    //Private Sub InitgridHistoPrest()
    //
    //  apiTGridPrestHisto.AddColumn "Date", "DCSTDAT", 1100
    //  apiTGridPrestHisto.AddColumn "Filiale", "VSOCIETE", 1200
    //  apiTGridPrestHisto.AddColumn "Créateur", "VPERNOM", 1800
    //  apiTGridPrestHisto.AddColumn "Sous-traitant", "VSTFNOM", 1800
    //  apiTGridPrestHisto.AddColumn "Client", "VCLINOM", 1500
    //  apiTGridPrestHisto.AddColumn "DI", "NDINNUM", 900
    //  apiTGridPrestHisto.AddColumn "Qte", "NQTE", 600, , 1
    //  apiTGridPrestHisto.AddColumn "Achat unit", "NPACHAT", 1200, "Currency", 1
    //  apiTGridPrestHisto.AddColumn "Mat. fourni", "CMATFOURNI", 1260
    //  apiTGridPrestHisto.AddColumn "Débours unit", "DEBOURSEUNIT", 1300, "Currency", 2
    //  
    //  apiTGridPrestHisto.AddCellStyle "NPACHAT", "", vbBlack, vbWhite ' pour passer dans FetchCellStyle
    //    
    //End Sub

    /* --------------------------------------------------------------------------------------- */
    private void apiTGridPrestHisto_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "NPACHAT")
      {
        string sPrixAchat = Utils.BlankIfNull(e.CellValue).ToString().Replace(" €", "");
        if (sPrixAchat != "")
        {
          double dPrixAchat = Convert.ToDouble(sPrixAchat);
          string sPrixDebourse = Utils.BlankIfNull(dtHisto.Rows[e.RowHandle]["DEBOURSEUNIT"]).ToString().Replace(" €", "");  // Colonne DEBOURSE UNIT
          if (sPrixDebourse != "")
          {
            double dPrixDebourse = Convert.ToDouble(sPrixDebourse);
            if (dPrixAchat <= dPrixDebourse)
              e.Appearance.BackColor = Color.Lime;
            else
              e.Appearance.BackColor = Color.Red;
          }
        }
      }
    }
    //Private Sub apiTGridPrestHisto_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //
    //  If DataField = "NPACHAT" Then
    //    Dim prix_achat As String
    //    Dim prix_debourse As String
    //    Dim dblprix_achat As Double
    //    Dim dblprix_debourse As Double
    //    prix_achat = Replace(Cols(col).CellText(BookMark), " €", "")
    //    If prix_achat <> "" Then
    //        dblprix_achat = prix_achat
    //        prix_debourse = Replace(Cols(9).CellText(BookMark), " €", "")  ' Colonne DEBOURSE UNIT
    //        If prix_debourse <> "" Then
    //            dblprix_debourse = prix_debourse
    //            If dblprix_achat <= dblprix_debourse Then
    //                CellStyle.BackColor = &HFF00&
    //              Else
    //                CellStyle.BackColor = &HFF&
    //            End If
    //        End If
    //    End If
    //  End If
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridPrestSaisie_ClickE(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGridPrestSaisie.GetFocusedDataRow();
        if (row == null) return;

        apiTGridPrestHisto.LoadData(dtHisto, MozartDatabase.cnxMozart, $"exec [api_sp_ListePrestCSTHisto] {row["NLDCLPRESTID"]}, {miNumContratST}");
        apiTGridPrestHisto.GridControl.DataSource = dtHisto;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub apiTGridPrestSaisie_Click()
    //  On Error GoTo handler
    //  If rsarticle.RecordCount > 0 Then
    //    If adorsHisto.State = adStateOpen Then adorsHisto.Close
    //  
    //    Set adorsHisto = New ADODB.Recordset
    //    adorsHisto.Open "exec [api_sp_ListePrestCSTHisto] " & rsarticle("ID") & ", " & iNumContratST, cnx
    //    apiTGridPrestHisto.Init adorsHisto
    //  End If
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "apiTGridPrestSaisie_Click dans " & Me.Name
    //End Sub
  }
}