Imports System.Data.SqlClient
Imports MozartLib

Public Class frmAffectationCertificatEtancheite

  Dim _NIMAGE_BSD As Int32
  Dim _NACTNUM As Int32

  Dim _dtCertEtanch As DataTable

  Public Sub New(ByVal c_NIMAGE_BSD As Object, ByVal c_NACTNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NIMAGE_BSD = c_NIMAGE_BSD
    _NACTNUM = c_NACTNUM

  End Sub

  Private Sub frmAffectationCertificatEtancheite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    _dtCertEtanch = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeCertEtanchForAffecteBSD]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NACTNUM", SqlDbType.Int).Value = _NACTNUM

        _dtCertEtanch.Load(sqlcmd.ExecuteReader)

        _dtCertEtanch.Columns("NCOCHE").ReadOnly = False

        GCListeCertifEtanch.DataSource = _dtCertEtanch

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If MessageBox.Show("Voulez-vous affecter ses certificats au BSD ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sqlcmdupdate As New SqlCommand("[api_sp_SaveCertEtanchForAffecteBSD]", MozartDatabase.cnxMozart)
      sqlcmdupdate.CommandType = CommandType.StoredProcedure
            sqlcmdupdate.Parameters.Add("@P_NIDCERTFLUIDSERVER", SqlDbType.Int).Value = 0
            sqlcmdupdate.Parameters.Add("@P_NIMAGE_BSD", SqlDbType.Int).Value = 0
            sqlcmdupdate.Parameters.Add("@P_NCOCHE", SqlDbType.Bit).Value = 0

            For Each drSave As DataRow In _dtCertEtanch.Rows

                sqlcmdupdate.Parameters("@P_NIDCERTFLUIDSERVER").Value = drSave.Item("NIDCERTFLUIDSERVER")
                sqlcmdupdate.Parameters("@P_NIMAGE_BSD").Value = _NIMAGE_BSD
                sqlcmdupdate.Parameters("@P_NCOCHE").Value = drSave.Item("NCOCHE")

                sqlcmdupdate.ExecuteNonQuery()

            Next

            LoadData()

        End If

    End Sub

End Class