Imports System.Data.SqlClient
Imports MozartLib

Public Class frmListeFacturesErrorForTransfert

  Dim dtListe As DataTable

  Private Sub frmListeFacturesErrorForTransfert_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    dtListe = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeFactureErrorForTransfert]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure

    dtListe.Load(sqlcmd.ExecuteReader)

    GCListeFOUFAC.DataSource = dtListe

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnMailInfo_Click(sender As System.Object, e As System.EventArgs) Handles BtnMailInfo.Click

    If dtListe.Rows.Count > 0 Then

      Dim oSendMail As New CSendMail
      ' TB SAMSIC CITY SPEC
      If MozartParams.NomGroupe = "EMALEC" Then
        oSendMail.Dest = "mcavallaro@emalec.com"
      End If ' TODO_TB SAMSIC CITY -> else pour samsic
      oSendMail.Subject = My.Resources.admin_frmListeFacturesErrorForTransfert_liste
      oSendMail.Message = Message()
      oSendMail.SendMail()

    End If

  End Sub

  Private Function Message() As String

    Dim sMessage As String = ""

    For Each drListe As DataRow In dtListe.Rows

      sMessage = sMessage + String.Format("REF FACTURE : {0} | MTT TTC : {1} | DATE FACTURE : {2}" & vbCrLf & "SELECT * FROM TFOUFAC WHERE NFOUFACNUM = {3}",
                                                  drListe.Item("VFACREF"),
                                                  drListe.Item("FFACTTC"),
                                                  drListe.Item("DFACDATE"),
                                                  drListe.Item("NFOUFACNUM")
                                                  ) & vbCrLf & vbCrLf

    Next

    Return sMessage

  End Function

End Class