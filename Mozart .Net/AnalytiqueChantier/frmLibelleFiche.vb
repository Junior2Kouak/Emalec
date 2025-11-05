Imports System.Data.SqlClient
Imports System.Reflection
Imports MozartLib
Imports MZUtils = MozartControls.Utils

Public Class frmLibelleFiche

  Private idFiche As Int32
  Private cmd As SqlCommand
  Private dr As SqlDataReader
  Private LibFicType As String
  Private iNIDCHANTIER As Int32
  Private NIDANACHAFICTYPE As Int32

  Public Sub New(ByVal c_iNIDCHANTIER As Int32, ByVal c_idFiche As Int32, ByVal c_LibFicType As String, ByVal c_NIDANACHAFICTYPE As Int32)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNIDCHANTIER = c_iNIDCHANTIER
    idFiche = c_idFiche
    LibFicType = c_LibFicType
    NIDANACHAFICTYPE = c_NIDANACHAFICTYPE

  End Sub

  Private Sub frmLibelleFiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If LibFicType = "H" Then
      lblVal.Text = "h"
    Else
      lblVal.Text = "€"
    End If

    If idFiche > 0 Then
      cmd = New SqlCommand("SELECT VLIB, NVAL FROM TCHANTIERFICHE WHERE VTYPE = '" & LibFicType & "' AND NIDFICHE = " & idFiche, MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.Text
      }
      dr = cmd.ExecuteReader
      dr.Read()
      txtLib.Text = dr("VLIB").ToString
      txtVal.Text = dr("NVAL").ToString
      dr.Close()
    Else
      txtLib.Text = ""
      txtVal.Text = "0"
    End If
  End Sub

  Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

    Try

      cmd = New SqlCommand("api_sp_ChantierCreationLibelleFiche " & idFiche & "," & iNIDCHANTIER & ",'" & Replace(txtLib.Text, "'", "''") & "'," & txtVal.EditValue.ToString &
                           ",'" & LibFicType & "', " & NIDANACHAFICTYPE, MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.Text
                           }
      cmd.ExecuteNonQuery()

      Close()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

End Class