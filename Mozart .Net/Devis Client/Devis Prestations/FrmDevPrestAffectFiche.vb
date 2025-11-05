Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmDevPrestAffectFiche

  Dim oCnxDetExtTemp As New CGestionSQL

  Dim iNumDevisCL As Int32
  Dim dtDevisPrestation As DataTable


  Public Sub New(ByVal c_iNumDevisCL As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNumDevisCL = CType(c_iNumDevisCL, Int32)

  End Sub

  Private Sub FrmDevPrestAffectFiche_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    If Not dtDevisPrestation.GetChanges() Is Nothing Then
      If MessageBox.Show(My.Resources.Devis_Client_FrmDevPrestAffectFiche_save_modif, My.Resources.Devis_Client_FrmDevPrestAffectFiche_modif_detected, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
        BtnSave.PerformClick()
      End If
    End If

    oCnxDetExtTemp.CloseConnexionSQL()

  End Sub

  Private Sub FrmDevPrestAffectFiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on charge la liste des fournitures série extincteurs
      If oCnxDetExtTemp.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        'on charge la liste des fiches chantiers 
        Dim sqlcmd As New SqlCommand(String.Format("exec api_sp_ListeComboFicheChantierWithNDCLNUM {0}, '{1}'", iNumDevisCL, "F"), oCnxDetExtTemp.CnxSQLOpen)
        Dim dtLstFicheFO As New DataTable

        dtLstFicheFO.Load(sqlcmd.ExecuteReader)

        RepItemComboFicheChantierFO.DataSource = dtLstFicheFO

        'on charge la liste des fiches chantiers 
        sqlcmd = New SqlCommand(String.Format("exec api_sp_ListeComboFicheChantierWithNDCLNUM {0}, '{1}'", iNumDevisCL, "H"), oCnxDetExtTemp.CnxSQLOpen)
        Dim dtLstFicheMO As New DataTable

        dtLstFicheMO.Load(sqlcmd.ExecuteReader)

        RepItemComboFicheChantierMO.DataSource = dtLstFicheMO

        'on charge les lignes
        LoadLigneDevisPrestations()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub LoadLigneDevisPrestations()

    'on charge les prestations du devis
    dtDevisPrestation = New DataTable
    dtDevisPrestation = ModDataGridView.LoadList(String.Format("exec api_sp_listePrestDevis {0}", iNumDevisCL), oCnxDetExtTemp.CnxSQLOpen)

    GCDevPrestAffect.DataSource = dtDevisPrestation

  End Sub

  Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

    Try

      Dim indexSelect As Int32 = 0

      If GVDevPrestAffect.RowCount > 0 Then indexSelect = GVDevPrestAffect.FocusedRowHandle

      'sauvegarde des lignes inventaires
      If dtDevisPrestation.Rows.Count > 0 Then

        For Each oRowsDevisprest As DataRow In dtDevisPrestation.Rows

          SaveLigneDevisPrestation(oRowsDevisprest)

        Next

      End If

      'on recharge les données
      LoadLigneDevisPrestations()

      If indexSelect > 0 Then GVDevPrestAffect.FocusedRowHandle = indexSelect

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub SaveLigneDevisPrestation(ByVal oRowsSavTemp As DataRow)

    Try

      Dim sqlcmdCreateLigne As New SqlCommand("api_sp_SaveDevisPrestChantierFiche", oCnxDetExtTemp.CnxSQLOpen)
      sqlcmdCreateLigne.CommandType = CommandType.StoredProcedure
      sqlcmdCreateLigne.Parameters.Add("@P_NLDCLPRESTID", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NLDCLPRESTID").Value = oRowsSavTemp.Item("NLDCLPRESTID")
      sqlcmdCreateLigne.Parameters.Add("@P_NIDFICHEFO", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NIDFICHEFO").Value = oRowsSavTemp.Item("NIDFICHEFO")
      sqlcmdCreateLigne.Parameters.Add("@P_NIDFICHEMO", SqlDbType.Int)
      sqlcmdCreateLigne.Parameters("@P_NIDFICHEMO").Value = oRowsSavTemp.Item("NIDFICHEMO")
      sqlcmdCreateLigne.Parameters.Add("@P_VLIBDECOUPMO", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VLIBDECOUPMO").Value = oRowsSavTemp.Item("VLIBDECOUPMO")
      sqlcmdCreateLigne.Parameters.Add("@P_VLIBDECOUPFO", SqlDbType.VarChar)
      sqlcmdCreateLigne.Parameters("@P_VLIBDECOUPFO").Value = oRowsSavTemp.Item("VLIBDECOUPFO")

      sqlcmdCreateLigne.ExecuteNonQuery()

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnDecoupChantier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDecoupChantier.Click

    Dim ofrmDecoupChantier As New FrmDecoupChantier(iNumDevisCL)
    ofrmDecoupChantier.ShowDialog()

  End Sub

  Private Sub BtnExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportXLS.Click

    SFD.Filter = "Fichiers EXCEL (*.xls)|*.xls"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then

      GCDevPrestAffect.ExportToXls(SFD.FileName)

    End If

  End Sub
End Class