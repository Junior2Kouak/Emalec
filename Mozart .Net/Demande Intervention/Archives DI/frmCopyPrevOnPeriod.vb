Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCopyPrevOnPeriod

  '  Dim dtPrev As DataTable

  Dim _NDINNUM As Int32 = 0

  Dim _sDate_Debut As Date
  Dim _sDate_Fin As Date

  Public Sub New(ByVal c_NDINNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    _NDINNUM = c_NDINNUM

  End Sub

  Private Sub frmCopyPrevOnPeriod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    If _NDINNUM = 0 Then Me.Close()

    SetDateMinMaxOnDI()

    DTP_Debut.Value = _sDate_Debut
    DTP_Fin.Value = _sDate_Fin

  End Sub


  Private Sub SetDateMinMaxOnDI()

    'init
    Dim sqlcmdLoad As New SqlCommand("[api_sp_GetDateMinMaxPlaOnDI]", MozartDatabase.cnxMozart)
    sqlcmdLoad.CommandType = CommandType.StoredProcedure
    sqlcmdLoad.Parameters.Add("@P_NDINNUM", SqlDbType.Int).Value = _NDINNUM
    Dim DrDate As SqlDataReader = sqlcmdLoad.ExecuteReader

    If DrDate.HasRows Then
      While DrDate.Read

        _sDate_Debut = DrDate("DATE_MIN")
        _sDate_Fin = DrDate("DATE_MAX")

      End While
    Else
      _sDate_Debut = Now.Date
      _sDate_Fin = Now.Date

    End If
    DrDate.Close()

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

    Dim NbPrevForCopy As Int32 = 0
    Dim DI As Int32 = 0

    'on recherche le nb de prev qui seront copié a N+1
    Dim sqlcmd As New SqlCommand("[api_sp_GetCountPrevOnPeriod]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NDINNUM", SqlDbType.Int).Value = _NDINNUM
    sqlcmd.Parameters.Add("@P_DATEDEBUT", SqlDbType.DateTime).Value = DTP_Debut.Value
    sqlcmd.Parameters.Add("@P_DATEFIN", SqlDbType.DateTime).Value = DTP_Fin.Value
    Dim dr As SqlDataReader = sqlcmd.ExecuteReader

    If dr.HasRows Then
      While dr.Read
        NbPrevForCopy = dr("NB")
      End While
    End If
    dr.Close()

    If NbPrevForCopy = 0 Then MessageBox.Show("Il n'y pas de préventives à copier à N+1 sur cette période", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    If MessageBox.Show(String.Format("Vous allez créer {0} préventives à N+1 sur une nouvelle DI. Voulez-vous continuer ?", NbPrevForCopy), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      Dim sqlcmdCreate As New SqlCommand("[api_sp_CopyPrevOnDiN+1]", MozartDatabase.cnxMozart)
      sqlcmdCreate.CommandType = CommandType.StoredProcedure
      sqlcmdCreate.Parameters.Add("@P_NDINNUM", SqlDbType.Int).Value = _NDINNUM
      sqlcmdCreate.Parameters.Add("@P_DATEDEBUT", SqlDbType.DateTime).Value = DTP_Debut.Value
      sqlcmdCreate.Parameters.Add("@P_DATEFIN", SqlDbType.DateTime).Value = DTP_Fin.Value
      Dim drd As SqlDataReader = sqlcmdCreate.ExecuteReader

      If drd.HasRows Then
        While drd.Read
          DI = drd("DI")
        End While
      End If
      drd.Close()

      MessageBox.Show($"Les {NbPrevForCopy} préventives à N+1 ont été créées avec succès. {vbCrLf}{vbCrLf}               DI{DI}", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub
End Class