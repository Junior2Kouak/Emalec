Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports MozartLib

Public Class frmChantierListeActionErreur_Heures

  Dim oActionsError As CActionsInError

  Public Sub New(ByVal c_ActError As CActionsInError)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    oActionsError = c_ActError

  End Sub

  Private Sub frmChantierListeActionErreur_Heures_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    grdActions.DataSource = oActionsError.dtActions

  End Sub

  Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
    Me.Close()
  End Sub

  Private Sub grdVAction_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles grdVAction.CustomDrawCell

    If e.Column.FieldName = "NREA_CHANTIERVAL" Then

      If IsDBNull(e.CellValue) Then

        e.DisplayText = "Pas de fiche"

      End If

    End If

  End Sub

  Private Sub RepositoryItemHyperLinkEdit1_OpenLink(sender As Object, e As OpenLinkEventArgs) Handles RepositoryItemHyperLinkEdit1.OpenLink

    If grdVAction.FocusedRowHandle > -1 Then

      Dim drSelect As DataRow = grdVAction.GetDataRow(grdVAction.FocusedRowHandle)
      If (drSelect.Item("NDINNUM").ToString <> "" And drSelect.Item("NACTNUM").ToString <> "") Then
        Shell(MozartParams.CheminProgrammeMozart & "SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & drSelect.Item("NDINNUM") & ";" & drSelect.Item("NACTNUM"), vbMaximizedFocus)
      End If

    End If

  End Sub
End Class