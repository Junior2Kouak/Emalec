Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestContratClient

  Dim DtListContrat As DataTable
  Dim Sqlcmd As SqlCommand

  Dim _NomClient As String
  Dim _NCLINUM As Int32

  Public Sub New(ByVal c_NCLINUM As Object, ByVal c_VCLINOM As Object)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NCLINUM = Convert.ToInt32(c_NCLINUM)
    _NomClient = c_VCLINOM.ToString
  End Sub


  Private Sub frmGestContratClient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Me.Text = String.Format("Gestion des contrats du client : {0}", _NomClient)
    LblTitre.Text = Me.Text

    LoadData()
  End Sub

  Private Sub LoadData()
    DtListContrat = New DataTable
    Sqlcmd = New SqlCommand("[api_sp_ListeContratClientAffecte]", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    Sqlcmd.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
    DtListContrat.Load(Sqlcmd.ExecuteReader)

    DtListContrat.Columns("BCONTRATAFFECTE").ReadOnly = False

    GCContrat.DataSource = DtListContrat
  End Sub

  Private Sub GVContrat_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVContrat.CustomDrawFooter
    Dim oPos As Rectangle = e.Bounds
    Dim oFormat As New StringFormat
    Dim iNbContSelected As Int32 = 0

    oPos.Location = New Point(oPos.Left + 1, oPos.Top + 4)
    oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

    oFormat.Alignment = StringAlignment.Near

    Dim dttemp As DataTable = GCContrat.DataSource

    For Each odrtemp As DataRow In dttemp.Rows
      If odrtemp.Item("BCONTRATAFFECTE") = 1 Then
        iNbContSelected += 1
      End If
    Next

    e.Appearance.DrawString(e.Cache, String.Format("Nombre de contrat(s) affecté(s) : {0} / {1}", iNbContSelected, DtListContrat.Rows.Count), oPos, oFormat)
    e.Handled = True
  End Sub

  Private Sub RepositoryItemCheckEditCHECK_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.CheckedChanged
    GVContrat.PostEditor()
    GVContrat.RefreshData()
  End Sub

  Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
    Dim Ipos As Int32 = GVContrat.FocusedRowHandle

    If DtListContrat IsNot Nothing Then
      Dim dtChange As DataTable = DtListContrat.GetChanges(DataRowState.Modified)
      Dim sqlInsert As SqlCommand

      If dtChange IsNot Nothing Then
        For Each dtRowChanged As DataRow In dtChange.Rows

          ' Console.WriteLine(String.Format("{0} {1} {2} {3} ", _NCLINUM, dtRowChanged.Item("NTYPECONTRAT"), dtRowChanged.Item("VTYPECONTRAT"), dtRowChanged.Item("BCONTRATAFFECTE")))

          sqlInsert = New SqlCommand("[api_sp_CreateContratClientAffecte]", MozartDatabase.cnxMozart)
          sqlInsert.CommandType = CommandType.StoredProcedure
          sqlInsert.Parameters.Add("@P_NCLINUM", SqlDbType.Int).Value = _NCLINUM
          sqlInsert.Parameters.Add("@P_NTYPECONTRAT", SqlDbType.Int).Value = dtRowChanged.Item("NTYPECONTRAT")
          sqlInsert.Parameters.Add("@P_BCONTRATAFFECTE", SqlDbType.Int).Value = dtRowChanged.Item("BCONTRATAFFECTE")
          sqlInsert.Parameters.Add("@P_VCODEFACT", SqlDbType.VarChar, 50).Value = dtRowChanged.Item("VCODEFACT")
          sqlInsert.Parameters.Add("@P_VCODEOPE", SqlDbType.VarChar, 3).Value = dtRowChanged.Item("VCODEOPE")
          sqlInsert.Parameters.Add("@P_VDELAIS", SqlDbType.VarChar, 50).Value = dtRowChanged.Item("VDELAIS")
          sqlInsert.Parameters.Add("@P_NMONTANTCONTRAT", SqlDbType.Decimal).Value = dtRowChanged.Item("NMONTANTCONTRAT")

          sqlInsert.ExecuteNonQuery()
        Next

        DtListContrat.AcceptChanges()
      End If
    End If

    LoadData()

    GVContrat.MakeRowVisible(Ipos)
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    SFD.Filter = "Fichiers XLSX |*.XLSX"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      GCContrat.ExportToXlsx(SFD.FileName)
    End If
  End Sub

  Private Sub frmGestContratClient_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If DtListContrat Is Nothing Then
      Exit Sub
    End If

    Dim dtChange As DataTable = DtListContrat.GetChanges()

    If dtChange IsNot Nothing AndAlso dtChange.Rows.Count > 0 Then
      If MessageBox.Show("Voulez-vous enregistrer les modifications ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then
        BtnSave.PerformClick()
        Me.Close()
      End If
    End If
  End Sub

  Private Sub BtnHelpKPI_DateContractuel_Click(sender As Object, e As EventArgs) Handles BtnHelpKPI_DateContractuel.Click
    MessageBox.Show($"Si vous mettez 'NON' dans la colonne 'Afficher pour intervention web', le contrat ne sera pas disponible en choix " +
                    $"lors de la création d'une demande sur le web client. {Environment.NewLine}{Environment.NewLine}{Environment.NewLine}" +
                    $"Si vous mettez 'OUI' dans la colonne 'Afficher sur le web le planning préventif ' le contrat sera disponible en choix " +
                    $"lors de l'affichage des plannings annuels sur le web client.",
                    "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)

  End Sub
End Class