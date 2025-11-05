Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestDroitAnaCopy

  Dim _TypeCopy As Int16
  Dim _vsociete As String

  Dim dtSrc As DataTable
  Dim dtDest As DataTable

  Public Sub New(ByVal c_TypeCopy As Int16, ByVal c_vsociete As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _TypeCopy = c_TypeCopy
    _vsociete = c_vsociete

  End Sub

  Private Sub frmGestDroitAnaCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub
  Private Sub LoadData()

    dtSrc = New DataTable
    dtDest = New DataTable

    Select Case _TypeCopy
      Case 0
        Dim sql As String = $"SELECT NPERNUM, VPERNOM + ' ' + VPERPRE AS NOM from TPER where CPERACTIF='O'
                            AND (CPERTYP<>'TE' OR CPERTYPDETAIL='RE') AND VSOCIETE = '{_vsociete}' ORDER BY NOM"
        Dim sqlcmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
        sqlcmd.CommandType = CommandType.Text
                dtSrc.Load(sqlcmd.ExecuteReader)
                dtDest = dtSrc
                'Case 1
                '    Dim sqlcmd As New SqlCommand("SELECT TREF_CTEANA.NCANNUM, CAST(TREF_CTEANA.NCANNUM AS VARCHAR(10)) + ' - ' + TREF_CTEANA.VCANLIB AS VCANLIB, CTYPECTE FROM TREF_CTEANA WHERE TREF_CTEANA.VSOCIETE =  APP_NAME() AND TREF_CTEANA.CCTEANAACTIF = 'O' ORDER BY TREF_CTEANA.NCANNUM", cnx)
                '    sqlcmd.CommandType = CommandType.Text
                '    dtSrc.Load(sqlcmd.ExecuteReader)
                '    dtDest = dtSrc
        End Select

        GLU_Src.Properties.DataSource = dtSrc
        GLU_DEST.Properties.DataSource = dtDest

    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        If GLU_Src.EditValue.ToString = "" Then
            MessageBox.Show("Selectionnez un profil source", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        End If

        If GLU_DEST.EditValue.ToString = "" Then
            MessageBox.Show("Selectionnez un profil cible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        End If

        If GLU_Src.EditValue = GLU_DEST.EditValue Then

            MessageBox.Show("Choix impossible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub

        End If

    'ssupression des droits de la cible
    Dim sqlcmd As New SqlCommand("delete W from taut W inner join tper on tper.npernum = W.npernum where tper.vsociete = APP_NAME() AND W.NPERNUM = " & GLU_DEST.EditValue.ToString, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        sqlcmd.ExecuteNonQuery()

    'copy des droits
    sqlcmd = New SqlCommand("INSERT INTO TAUT (NCANNUM, NPERNUM) Select TAUT.NCANNUM, " & GLU_DEST.EditValue.ToString & " From TAUT INNER JOIN TREF_CTEANA On TREF_CTEANA.NCANNUM = TAUT.NCANNUM And TREF_CTEANA.VSOCIETE = APP_NAME() And TREF_CTEANA.CCTEANAACTIF = 'O' Where TAUT.npernum = " & GLU_Src.EditValue.ToString, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        sqlcmd.ExecuteNonQuery()

        MessageBox.Show("Les droits des comptes analytiques de " & GLU_DEST.Text & " ont été copiés à partir de celui de " & GLU_Src.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class