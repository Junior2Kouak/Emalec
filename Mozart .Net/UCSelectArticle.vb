Imports System.Data.SqlClient
Imports System.Reflection
Imports MozartLib
Imports MZUtils = MozartControls.Utils

Public Class UCSelectArticle

  Public Event SearchResult(ByVal result As DataTable)

  Private mCnx As SqlConnection
  Private miNumDi As Integer

  Public Shadows Property BackColor() As Color
    Get
      Return MyBase.BackColor
    End Get
    Set(ByVal value As Color)
      MyBase.BackColor = value
    End Set
  End Property

  Public Sub init(pCnx As SqlConnection, pINumDi As Integer)
    mCnx = pCnx
    miNumDi = pINumDi

    ' Combo série
    txtCritSerie.Init(mCnx, $"EXEC api_sp_SerieFo_Liste", "NCFOCOD", "CCFOCOD",
                      New List(Of String) From {My.Resources.col_Numero, "Série"}, 250, 550, True)
    txtCritSerie.SetColumnVisible("LANGUE", False)

    ' Combo des fournisseurs
    txtCritFour.Init(mCnx, "SELECT NSTFGRPNUM, VSTFGRPNOM + ' - ' + COALESCE(VSTFGRPVIL, '') [VSTFGRPNOM]" +
                 "FROM TSTFGRP WHERE  CSTFGRPACTIF = 'O' AND (CSTFTYP = 'FO' OR CSTFTYP = 'FT') ORDER BY VSTFGRPNOM  + ' - ' + COALESCE(VSTFGRPVIL, '') ",
                 "NSTFGRPNUM", "VSTFGRPNOM", New List(Of String) From {My.Resources.col_Numero, "Nom"}, 150, 550, True)
  End Sub

  Public Sub launchSearch()
    Dim lSql As String
    Dim lNCFoCod As Integer = 0
    Dim lDt As New DataTable

    Try
      Cursor.Current = Cursors.WaitCursor

      If txtCritSerie.GetItemData() <> -1 Then
        lNCFoCod = txtCritSerie.GetItemData()
      End If

      lSql = $"exec api_sp_listeFourDevisQtifMini {miNumDi}, {lNCFoCod}, '{txtCritMat.Text.Replace("'", "''")}', '{txtCritMarque.Text.Replace("'", "''")}', '{txtCritType.Text.Replace("'", "''")}', '{txtCritRefFab.Text}', '{txtCritRefFou.Text}', '{txtCritId.Text}', {txtCritFour.GetItemData()}"
      Dim CmdSql As New SqlCommand(lSql, MozartDatabase.cnxMozart) With {
      .CommandTimeout = 120
      }

      lDt.Rows.Clear()
      lDt.Clear()
      lDt.Load(CmdSql.ExecuteReader)

    Catch ex As Exception
      'Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    Finally
      RaiseEvent SearchResult(lDt)

      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
    launchSearch()
  End Sub

End Class
