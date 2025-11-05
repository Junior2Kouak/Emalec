using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmComSecuFichier : Form
  {
    public int iID;
    string sSQL;
    DataTable dt = new DataTable();
    string sFichier;
    //Public iID As Integer
    //Dim sSQL As String
    //Dim rsFichier As ADODB.Recordset
    //Dim sFichier As String

    public string dDate;

    public frmComSecuFichier() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmComSecuFichier_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        sSQL = $"SELECT NIDCOMSECUFIC, VFICHIER, DDATE FROM TCOMSECUFIC WHERE NIDCOMSECU = {iID} ORDER BY DDATE DESC";
        apiTGridFichier.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiTGridFichier.GridControl.DataSource = dt;

        InitGrid();
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
    //  'Me.Caption = "§Commissions de sécurité du site :§" & " " & frmDetailsSite.txtNom
    //  
    //  sSQL = "SELECT NIDCOMSECUFIC, VFICHIER, DDATE FROM TCOMSECUFIC WHERE NIDCOMSECU = " & iID & " ORDER BY DDATE DESC"
    //  
    //  Set rsFichier = New ADODB.Recordset
    //  rsFichier.Open sSQL, cnx
    //  
    //  InitGrid
    //  AfficheFichier
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitGrid()
    {
      apiTGridFichier.AddColumn(Resources.col_Fichier, "VFICHIER", 10000);
      apiTGridFichier.AddColumn(Resources.col_Date, "DDATE", 1000, "", 2);

      apiTGridFichier.InitColumnList();
    }
    //Private Sub InitGrid()
    //
    //  apiTGridFichier.AddColumn "§Fichier§", "VFICHIER", 10000
    //  apiTGridFichier.AddColumn "§Date§", "DDATE", 1000, , 2
    //  
    //  apiTGridFichier.Init rsFichier
    //
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdAjout_Click(object sender, EventArgs e)
    {
      string sNomFic;

      if (Utils.BlankIfNull(dDate) == "")
      {
        MessageBox.Show(Resources.msg_Date_Derniere_Visite_Definie_Commission_Securite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      CommonDialog1.ReadOnlyChecked = true;
      CommonDialog1.Title = Resources.txt_Choix_Fichier;
      CommonDialog1.Filter = "Fichier PDF|*.PDF";

      if (CommonDialog1.ShowDialog() == DialogResult.OK)
      {
        //Afficher l'image
        sFichier = CommonDialog1.FileName;
        WebBrowser1.Navigate(sFichier);

        string[] ts = Strings.Split(CommonDialog1.FileName, @"\");
        sNomFic = ts[ts.Length - 1];

        File.Copy(sFichier, Utils.RechercheParam("REP_COMSECU") + sNomFic);
        sSQL = $"INSERT INTO TCOMSECUFIC VALUES({iID}, '{Utils.RechercheParam("REP_COMSECU") + sNomFic}', '{dDate}')";
        ModuleData.ExecuteNonQuery(sSQL);

        apiTGridFichier.Requery(dt, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub cmdAjout_Click()
    //Dim fs As New FileSystemObject
    //Dim ts
    //Dim sNomFic As String
    //
    //  On Error GoTo errHandler
    //
    //  If BlankIfNull(frmCommissionSec.txtDateDer) = "" Then
    //    MsgBox "§La date de dernière visite doit être définie sur la commission de sécurité!§"
    //    Exit Sub
    //  End If
    //
    //  ' Attribue à CancelError la valeur True
    //  CommonDialog1.CancelError = True
    //  ' Définit la propriété Flags
    //  CommonDialog1.Flags = cdlOFNHideReadOnly
    //  ' titre de la aboite
    //  CommonDialog1.DialogTitle = "§Choix d'un fichier§"
    //
    //  CommonDialog1.Filter = "Fichier PDF|*.PDF"
    //
    //  ' Affiche la boîte de dialogue Ouverture
    //  On Error GoTo ExitHandler
    //  CommonDialog1.ShowOpen
    //  On Error GoTo errHandler
    //
    //  ' Afficher l'image
    //  sFichier = CommonDialog1.FileName
    //
    //  WebBrowser1.Navigate "about:blank"
    //  WebBrowser1.Navigate sFichier
    //
    //  ' Affiche le nom du fichier sélectionné
    //  ts = Split(sFichier, "\")
    //  sNomFic = ts(UBound(ts))
    //  
    //  fs.CopyFile sFichier, RechercheParam("REP_COMSECU") & sNomFic
    //
    //  sSQL = "INSERT INTO TCOMSECUFIC VALUES( " & iID & ",'" & RechercheParam("REP_COMSECU") & "" & sNomFic & "','" & frmCommissionSec.txtDateDer & "')"
    //  cnx.Execute sSQL
    //
    //  rsFichier.Requery
    //
    //ExitHandler:
    //  Exit Sub
    //
    //errHandler:
    //  'L'utilisateur a cliqué sur Annuler
    //  ShowError "cmdParcourir_Click dans " & Me.Name
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  
    //  Unload Me
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void AfficheFichier()
    {
      DataRow row = apiTGridFichier.GetFocusedDataRow();
      if (null == row)
      {
        WebBrowser1.Navigate("about:blank");
        return;
      }
      else
      {
        WebBrowser1.Navigate(row["VFICHIER"].ToString());
        sFichier = row["VFICHIER"].ToString();
      }
    }
    //Private Sub AfficheFichier()
    //
    //  If rsFichier.RecordCount > 0 Then
    //    WebBrowser1.Navigate rsFichier("VFICHIER")
    //    sFichier = rsFichier("VFICHIER")
    //  Else
    //    WebBrowser1.Navigate "about:blank"
    //  End If
    //
    //End Sub
    //
    //
    /* --------------------------------------------------------------------------------------- */
    private void apiTGridFichier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridFichier.GetFocusedDataRow();
      if (null == row) return;

      if (row["VFICHIER"].ToString() != sFichier)
      {
        sFichier = row["VFICHIER"].ToString();
        WebBrowser1.Navigate(sFichier);
      }
    }
    //Private Sub apiTGridFichier_Click()
    //  
    //  If rsFichier("VFICHIER") <> sFichier Then
    //    sFichier = rsFichier("VFICHIER")
    //    WebBrowser1.Navigate sFichier
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridFichier.GetFocusedDataRow();
      if (null == row) return;

      WebBrowser1.Navigate("about:blank");

      if (MessageBox.Show(Resources.msg_Confirm_Suppression, Resources.msg_Suppression, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        File.Delete(row["VFICHIER"].ToString());

        sSQL = $"DELETE TCOMSECUFIC WHERE NIDCOMSECUFIC = {row["NIDCOMSECUFIC"]}";
        ModuleData.ExecuteNonQuery(sSQL);
      }
      apiTGridFichier.Requery(dt, MozartDatabase.cnxMozart);

      if (dt.Rows.Count > 0)
        sFichier = row["VFICHIER"].ToString();
      else
        sFichier = "";

      AfficheFichier();
    }
    //Private Sub cmdSupprimer_Click()
    //Dim fs As New FileSystemObject
    //
    //
    //  On Error Resume Next
    //  
    //  If MsgBox("§Etes-vous sûr de vouloir supprimer le fichier?§", vbYesNo, "§Suppression§") = vbYes Then
    //  
    //    fs.DeleteFile rsFichier("VFICHIER")
    //  
    //    sSQL = "DELETE TCOMSECUFIC WHERE NIDCOMSECUFIC = " & rsFichier("NIDCOMSECUFIC")
    //    cnx.Execute sSQL
    //  
    //  End If
    //
    //  rsFichier.Requery
    //  If rsFichier.RecordCount > 0 Then
    //    sFichier = rsFichier("VFICHIER")
    //  Else
    //    sFichier = ""
    //  End If
    //
    //  AfficheFichier
    //
    //End Sub

  }
}

