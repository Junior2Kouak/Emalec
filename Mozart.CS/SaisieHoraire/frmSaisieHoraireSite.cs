using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MozartNet;
using MozartCS.Properties;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieHoraireSite : Form
  {

    private class ListItemData
    {
      public string VSITNOM;
      public int NSITNUM;
      public override string ToString()
      {
        return this.VSITNOM;
      }
    }

    public string msType;
    public DataTable dtSite = null;
    public int miNumCli;
    public int miNumSit;

    public frmSaisieHoraireSite()
    {
      InitializeComponent();
    }

    /* Ok ---------------------------------------------------------------------*/
    private void frmSaisieHoraireSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //  recherche du nom du client
        DataTable dtClient = new DataTable();
        string sSql = $"SELECT VCLINOM FROM TCLI WHERE NCLINUM = {this.miNumCli}";
        ModuleData.LoadData(dtClient, sSql);

        if (dtClient.Rows.Count > 0)
          this.lblClient.Text = dtClient.Rows[0]["VCLINOM"].ToString();

        foreach (DataRow siteRow in dtSite.Rows)
        {
          lstSite.Items.Add(new ListItemData()
          {
            VSITNOM = siteRow["VSITNOM"].ToString(),
            NSITNUM = (int)siteRow["NSITNUM"]
          });

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //  InitBoutons Me, frmMenu
    //  InitForm
    //
    //End Sub

    //Private Sub InitForm()
    //Dim rsClient As ADODB.Recordset
    //Dim i As Integer
    //
    //  Set rsClient = New ADODB.Recordset
    //  
    //  ' recherche du nom du client
    //  rsClient.Open "SELECT VCLINOM FROM TCLI WHERE NCLINUM = " & frmSaisieHoraire.miNumCli, cnx
    //  rsClient.MoveFirst
    //  lblClient = rsClient("VCLINOM")
    //  rsClient.Close
    //
    //  If rsSite.EOF Then Exit Sub
    //  ' rssite est chargé depuis frmSaisieHoraire
    //  rsSite.MoveFirst
    //  i = 0
    //  While Not rsSite.EOF
    //    lstSite.AddItem rsSite("VSITNOM")
    //    lstSite.ItemData(i) = rsSite("NSITNUM")
    //    rsSite.MoveNext
    //    i = i + 1
    //  Wend
    //  
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      Enregistrer();
      Dispose();
    }
    //Private Sub cmdValider_Click()
    //
    //  Enregistrer
    //  Unload Me
    //
    //End Sub


    /* OK ---------------------------------------------------------------------*/
    private void Enregistrer()
    {
      if (msType == "HORAIRES")
      {
        // pour chaque site sélectionné, on supprime les enregistrements et on les re-insert
        foreach (ListItemData item in lstSite.CheckedItems)
        {
          ModuleData.ExecuteNonQuery($"DELETE THORAIRES WHERE NSITNUM = {item.NSITNUM}");
          ModuleData.ExecuteNonQuery($"INSERT INTO THORAIRES (nsitnum,vjour,ndebmatin,nfinmatin,ndebsoir,nfinsoir,nmatapint)"
                                   + $"(select {item.NSITNUM},vjour,ndebmatin,nfinmatin,ndebsoir,nfinsoir,nmatapint from THORAIRES WHERE nsitnum = {this.miNumSit})");
        }
      }
      else if (msType == "FERMETURES")
      {
        // pour chaque site sélectionné, on ajoute les éléments non-existants
        foreach (ListItemData item in lstSite.CheckedItems)
        {
          ModuleData.ExecuteNonQuery($"DELETE TFERMETURESITE WHERE NSITNUM = {item.NSITNUM}");
          ModuleData.ExecuteNonQuery($"INSERT INTO TFERMETURESITE (NSITNUM,DDATEFERM)  (SELECT {item.NSITNUM} ,DDATEFERM FROM TFERMETURESITE WHERE NSITNUM = {this.miNumSit})");
        }
      }
    }
    //Private Sub Enregistrer()
    //Dim i As Integer
    //Dim iNumSit As Long
    //Dim sSQL As String
    //  
    //On Error Resume Next
    //  
    //  If msType = "HORAIRES" Then
    //    ' pour chaque site sélectionné, on supprime les enregistrements et on les re-insert
    //    For i = 0 To lstSite.ListCount - 1
    //      If lstSite.Selected(i) Then
    //        iNumSit = lstSite.ItemData(i)
    //        
    //        sSQL = "DELETE THORAIRES WHERE NSITNUM = " & iNumSit
    //        cnx.Execute sSQL
    //        
    //        sSQL = "insert into thoraires(nsitnum,vjour,ndebmatin,nfinmatin,ndebsoir,nfinsoir,nmatapint) " _
    //              & "(select " & iNumSit & " ,vjour,ndebmatin,nfinmatin,ndebsoir,nfinsoir,nmatapint " _
    //              & " from thoraires where nsitnum = " & frmSaisieHoraire.miNumSit & ")"
    //        cnx.Execute sSQL
    //        
    //      End If
    //    Next i
    //  ElseIf msType = "FERMETURES" Then
    //    ' pour chaque site sélectionné, on ajoute les éléments non-existants
    //    For i = 0 To lstSite.ListCount - 1
    //      If lstSite.Selected(i) Then
    //        iNumSit = lstSite.ItemData(i)
    //    
    //        sSQL = "INSERT INTO TFERMETURESITE (NSITNUM,DDATEFERM) " _
    //              & "(SELECT " & iNumSit & ",DDATEFERM FROM TFERMETURESITE " _
    //              & " WHERE NSITNUM = " & frmSaisieHoraire.miNumSit & ")"
    //        cnx.Execute sSQL
    //  
    //        If Err.Number <> -2147217873 And Err.Number <> 0 Then
    //          MsgBox Me.Name & " Sub Enregistrer : " & Err.Description
    //        End If
    //      End If
    //    Next i
    //  End If
    //
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void chkCheckTout_CheckedChanged(object sender, EventArgs e)
    {
      if (chkCheckTout.Checked)
        chkCheckTout.Text = Resources.txt_DecocherTous;
      else
        chkCheckTout.Text = Resources.txt_CocherTous;

      for (int idx = 0; idx < lstSite.Items.Count; idx++)
        lstSite.SetItemChecked(idx, chkCheckTout.Checked);
    }
    //Private Sub chkCheckTout_Click()
    //Dim i As Integer
    //Dim ilistindex As Integer
    //
    //  ilistindex = lstSite.ListIndex
    //  If chkCheckTout = 1 Then
    //    chkCheckTout.Caption = "§Décocher tous§"
    //    For i = 0 To lstSite.ListCount - 1
    //      lstSite.Selected(i) = True
    //    Next i
    //  Else
    //    chkCheckTout.Caption = "§Cocher tous§"
    //    For i = 0 To lstSite.ListCount - 1
    //      lstSite.Selected(i) = False
    //    Next i
    //  End If
    //  lstSite.ListIndex = ilistindex
    //
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      if (dtSite != null)
        dtSite.Dispose();
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //Private Sub Form_Unload(Cancel As Integer)
    //  rsSite.Close
    //End Sub


  }
}