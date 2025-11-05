Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCptAnaAffectSelectSuperviseur

  Dim drTabSelect As DataRow
  Dim dtCbo As DataTable

  Dim bCancel As Boolean

  Dim dtListePerChaff As DataTable

  Public Sub New(ByVal c_drTabSelect As DataRow)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    drTabSelect = c_drTabSelect
    bCancel = False

  End Sub

  Public ReadOnly Property Cancel As Boolean
    Get
      Cancel = bCancel
    End Get
  End Property

  Private Sub frmCptAnaAffectSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Try

      LoadListePer()

    Catch ex As Exception

      MessageBox.Show("", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub LoadListePer()

    dtListePerChaff = New DataTable

    Dim sqlcmdListe As New SqlCommand("[api_sp_SuperviseurChaffProjet_Liste]", MozartDatabase.cnxMozart)
    sqlcmdListe.CommandType = CommandType.StoredProcedure
        sqlcmdListe.Parameters.Add("@NPERNUM_CHILD", SqlDbType.Int).Value = drTabSelect.Item("NPERNUM")
        sqlcmdListe.Parameters.Add("@NCANNUM", SqlDbType.Int).Value = drTabSelect.Item("NCANNUM")

        dtListePerChaff.Load(sqlcmdListe.ExecuteReader)

        dtListePerChaff.Columns("NCOCHE").ReadOnly = False

        GCListePer.DataSource = dtListePerChaff




    End Sub
    Private Sub BtnValidate_Click(sender As System.Object, e As System.EventArgs) Handles BtnValidate.Click


        If GVListePer.SelectedRowsCount = 0 Then MessageBox.Show("il faut sélectionner une personne", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return

        Dim dtChanges As DataTable = dtListePerChaff.GetChanges(DataRowState.Modified)

    Dim sqlcmd As New SqlCommand("", MozartDatabase.cnxMozart)

    If Not dtChanges Is Nothing Then

            For Each drchanges As DataRow In dtChanges.Rows

        sqlcmd = New SqlCommand("[api_sp_SuperviseurChaffProjet_Save]", MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.Add("@NPERNUM_PARENT", SqlDbType.Int).Value = drchanges.Item("NPERNUM_PARENT")
                sqlcmd.Parameters.Add("@NPERNUM_CHILD", SqlDbType.Int).Value = drTabSelect.Item("NPERNUM")
                sqlcmd.Parameters.Add("@NCANNUM", SqlDbType.Int).Value = drTabSelect.Item("NCANNUM")
                sqlcmd.Parameters.Add("@NCOCHE", SqlDbType.Int).Value = drchanges.Item("NCOCHE")
                sqlcmd.ExecuteNonQuery()

            Next

        End If

        Me.Close()

    End Sub



    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        bCancel = True
        Me.Close()
    End Sub

End Class