Imports System.Data.SqlClient
Imports MozartLib

Public Class frmPlanifAuto_ListeActions


  Friend dtListeActions As DataTable
  Dim _oCPLAAUTO As CPLAAUTO
  Dim _ReadOnly As Boolean

  Public Sub New(ByVal c_oPlaAutoNew As CPLAAUTO, ByVal c_ReadOnly As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _oCPLAAUTO = c_oPlaAutoNew
    _ReadOnly = c_ReadOnly

  End Sub

  Private Sub frmPlanifAuto_ListeActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Initboutons(Me)

    LoadData()

    'on teste les actions selectionnées, si elles sont toutes executées ou planifiées, on le signale.


    'en mode read only
    If _ReadOnly = True Or (_oCPLAAUTO.CPLA_AUTO_ETAT <> "A") Then

      Me.Text = Me.Text & " (Lecture seule)"
      dtListeActions.Columns("NCOCHE").ReadOnly = True
      GVListeActions.OptionsBehavior.ReadOnly = True
      BtnCocheTS.Visible = False
      BtnDecocheTS.Visible = False

    End If


  End Sub

  Private Sub LoadData()

    dtListeActions = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_Planif_Auto_ListeActionsAPlanif]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NPLA_AUTO_ID", SqlDbType.Int).Value = _oCPLAAUTO.NPLA_AUTO_ID
        sqlcmd.Parameters.Add("@P_CPLA_AUTO_ETAT", SqlDbType.VarChar).Value = _oCPLAAUTO.CPLA_AUTO_ETAT

        dtListeActions.Load(sqlcmd.ExecuteReader)

        dtListeActions.Columns("NCOCHE").ReadOnly = False

        GCListeActions.DataSource = dtListeActions

    End Sub

    Private Sub BtnCocheTS_Click(sender As Object, e As EventArgs) Handles BtnCocheTS.Click

        If dtListeActions Is Nothing Then Return

        CocherAllFilterTous_Or_DecocheAllFilter(dtListeActions, "NCOCHE", GVListeActions.ActiveFilterCriteria, True)
        GVListeActions.RefreshData()

    End Sub

    Private Sub BtnDecocheTS_Click(sender As Object, e As EventArgs) Handles BtnDecocheTS.Click

        If dtListeActions Is Nothing Then Return

        CocherAllFilterTous_Or_DecocheAllFilter(dtListeActions, "NCOCHE", GVListeActions.ActiveFilterCriteria, False)
        GVListeActions.RefreshData()

    End Sub

    Private Sub GVListeActions_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVListeActions.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbPActSelected As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        Dim dttemp As DataTable = dtListeActions

        For Each odrtemp As DataRow In dttemp.Rows

            If odrtemp.Item("NCOCHE") = 1 Then
                iNbPActSelected = iNbPActSelected + 1
            End If

        Next

        e.Appearance.DrawString(e.Cache, String.Format("{0} / {1}", iNbPActSelected, dtListeActions.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

    Private Sub RepItemChkNCOCHE_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.CheckedChanged
        Dim odtr As DataRow = GVListeActions.GetDataRow(GVListeActions.GetSelectedRows(0))

        If odtr Is Nothing Then Return

        Try


            If Not odtr Is Nothing AndAlso odtr.Item("NCOCHE") = 1 Then
                CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = False
                odtr.Item("NCOCHE") = 0
            Else
                CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = True
                odtr.Item("NCOCHE") = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        GVListeActions.PostEditor()
        GCListeActions.Refresh()

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnValid_Click(sender As Object, e As EventArgs) Handles BtnValid.Click

        If dtListeActions IsNot Nothing Then
            If dtListeActions.Select("[NCOCHE] = 1").Count > 0 Then

                Using oFrmPlanifAutoCreate As New frmPlanifAuto_Creation(_oCPLAAUTO, _ReadOnly)
                    oFrmPlanifAutoCreate.dtListesActionsCoche = dtListeActions.Select("[NCOCHE] = 1").CopyToDataTable
                    oFrmPlanifAutoCreate.ShowDialog()
                End Using
                Me.Close()
            Else
                MessageBox.Show("Il faut obligatoirement sélectionner une action !", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub
End Class