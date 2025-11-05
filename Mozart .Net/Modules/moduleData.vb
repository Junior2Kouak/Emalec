Imports System.Data.SqlClient
Imports System.Reflection
Imports MozartLib

Public Module ModuleData

  Public Class ListItem
    Public ItemText As String   ' what is displayed
    Public ItemData As Object   ' associated data

    Public Sub New(text As String, data As Object)
      ItemText = text
      ItemData = data
    End Sub

    Public Overrides Function ToString() As String
      Return ItemText
    End Function
  End Class

  Public Sub LoadData(dt As DataTable, sQuery As String)

    Dim CmdSql As New SqlCommand(sQuery, MozartDatabase.cnxMozart)
    dt.Rows.Clear()
    dt.Clear()
    dt.Load(CmdSql.ExecuteReader)

  End Sub

  Public Sub LoadData(dt As DataTable, sQuery As String, cnxAutre As SqlConnection)

    Dim CmdSql As New SqlCommand(sQuery, cnxAutre)
    dt.Clear()
    dt.Load(CmdSql.ExecuteReader)

  End Sub

  Public Sub CnxExecute(query As String)
    Using cmd As New SqlCommand(query, MozartDatabase.cnxMozart)
      cmd.ExecuteNonQuery()
    End Using
  End Sub

  Public Function ExecuteReader(sSql As String) As SqlDataReader
    Return MozartDatabase.ExecuteReader(sSql)
  End Function

  Public Sub ExecuteNonQuery(sSql As String)

    Using cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      cmd.CommandTimeout = 90
      cmd.ExecuteNonQuery()
    End Using

  End Sub

  Public Function ExecuteScalarObject(sSql As String) As Object
    Using cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      Return cmd.ExecuteScalar()
    End Using
  End Function

  Public Function ExecuteScalarInt(sSql As String) As Integer?
    Using cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      Dim o = cmd.ExecuteScalar()
      If Convert.IsDBNull(o) Then Return Nothing
      Return Convert.ToInt32(o)
    End Using
  End Function

  Public Function ExecuteScalarDouble(sSql As String) As Double?
    Using cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      Dim o = cmd.ExecuteScalar()
      If Convert.IsDBNull(o) Then Return Nothing
      Return Convert.ToDouble(o)
    End Using
  End Function

  Public Function ExecuteScalarString(sSql As String) As String

    Using cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
      Dim o As Object = cmd.ExecuteScalar()
      If (o Is Nothing) Then
        Return ""
      Else
        Return o.ToString()
      End If
    End Using

  End Function

  Public Sub SupprimerEnreg(lNumEnreg As Long, sProcName As String, sParam As String, Optional sSociete As String = "")

    Try
      Using cmd As New SqlCommand(sProcName, MozartDatabase.cnxMozart) With {.CommandType = CommandType.StoredProcedure}
        cmd.CommandType = CommandType.StoredProcedure
        ' Récupérer les paramètres de la procédure stockée
        SqlCommandBuilder.DeriveParameters(cmd)

        cmd.Parameters(sParam).Value = lNumEnreg
        If sSociete <> "" Then cmd.Parameters.AddWithValue("@vsociete", sSociete)

        cmd.ExecuteNonQuery()
      End Using

    Catch ex As Exception
      Cursor.Current = Cursors.Default
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & " dans " & MethodBase.GetCurrentMethod.Name, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub

  Public Sub RemplirCombo(cbo As ComboBox, sSql As String, Optional bSupprSpace As Boolean = False)

    Try
      Dim dt As New DataTable

      Dim dsOrg As New SqlDataAdapter(sSql, MozartDatabase.cnxMozart)
      dsOrg.Fill(dt)

      If (Not bSupprSpace) Then
        Dim newRow As DataRow = dt.NewRow()
        Try
          If dt.Columns(0).DataType = GetType(String) Then
            newRow.Item(0) = ""
            newRow.Item(1) = 0
          Else
            newRow.Item(0) = 0
            newRow.Item(1) = ""
          End If
          dt.Rows.InsertAt(newRow, 0)
        Catch ex As Exception
        End Try
      End If

      cbo.DataSource = dt

    Catch Ex As Exception
      MessageBox.Show(Ex.Message & vbCrLf & vbCrLf & " dans " & MethodBase.GetCurrentMethod.Name, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub

  Public Sub RemplirCombo1item(cbo As ComboBox, sSql As String)

    Try
      cbo.Items.Clear()

      Using cmd As New SqlCommand(sSql, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        While (dr.Read())
          cbo.Items.Add(dr(0))
        End While
        dr.Close()
      End Using

    Catch Ex As Exception
      MessageBox.Show(Ex.Message & vbCrLf & vbCrLf & " dans " & MethodBase.GetCurrentMethod.Name, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub

  Public Function RechercheParam(sParamTemp As String, sNomSociete As String) As String
    Return ModuleData.ExecuteScalarString($"api_sp_getPAR_By_Societe '{sParamTemp}', '{sNomSociete}'")
  End Function

  Public Sub RemplirCboFormat(cbo As ComboBox, ByRef tFormats() As String)

    Try
      Dim i As Integer
      cbo.Items.Clear()

      Using cmd As New SqlCommand("api_sp_ComboFormat", MozartDatabase.cnxMozart)
        Using dr As SqlDataReader = cmd.ExecuteReader()
          While (dr.Read())
            cbo.Items.Add(New ListItem(dr(1).ToString(), i))
            ReDim Preserve tFormats(i + 1)
            tFormats(i) = dr(1)
            If dr(0) = "JPG" Then cbo.SelectedIndex = i
            i = i + 1
          End While
          dr.Close()
        End Using
      End Using

    Catch Ex As Exception
      MessageBox.Show(Ex.Message & vbCrLf & vbCrLf & " dans " & MethodBase.GetCurrentMethod.Name, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub



  Public Function GetSqlClause(sType As String, Optional mlNumClient As Long = 0) As String

    Select Case sType
      Case "CLIENT"
        Return "SELECT NCLINUM, VCLINOM FROM TCLI WHERE VSOCIETE = '" & MozartParams.NomSociete & "' AND CCLIACTIF='O' ORDER BY VCLINOM"

      Case "SITE"
        Return "SELECT NSITNUM, VSITNOM FROM TSIT WHERE NCLINUM = " & mlNumClient & " AND CSITACTIF='O' ORDER BY VSITNOM"

      Case "PERSONNEL"
        Return "SELECT NPERNUM, VPERNOM + ' ' + VPERPRE [VPERNOM] FROM TPER WHERE VSOCIETE = '" & MozartParams.NomSociete & "'  AND CPERACTIF='O' ORDER BY VPERNOM, VPERPRE"

      Case "CHAFF"
        Return "SELECT NPERNUM, VPERNOM FROM TPER WHERE VSOCIETE = '" & MozartParams.NomSociete & "'  AND CPERTYP = 'CA' AND CPERACTIF = 'O' AND BUTILISATEUR = 0 ORDER BY VPERNOM"

      Case "FOURNISSEUR"
        Return "SELECT NSTFNUM, VSTFNOM FROM TSTF WHERE (NSTFGRPTYPFO = 1)"

      Case "FOANDSTF"
        Return "SELECT NSTFNUM, VSTFNOM FROM TSTF "

      Case "STF"
        Return "SELECT NSTFNUM, VSTFNOM FROM TSTF WHERE (NSTFGRPTYPMNT = 1 OR NSTFGRPTYPINST= 1 OR NSTFGRPTYPGAR = 1) "

      Case "GRPFOURNISSEUR"
        Return "SELECT NSTFGRPNUM, VSTFGRPNOM FROM TSTFGRP WHERE (NSTFGRPTYPFO = 1) "

      Case "IMMATRICUL"
        Return "SELECT NVEHNUM, VVEHIMAT FROM TVEHICULES WHERE VSOCIETE = '" & MozartParams.NomSociete & "'"

      Case "CPTANA_ALL"
        Return "SELECT DISTINCT TCAN.NCANNUM, RIGHT('000' + CONVERT(VARCHAR(4),TCAN.NCANNUM), 3) + ' - ' + VCANLIB AS 'Compte Analytique' FROM TCAN, TREF_CTEANA WHERE TREF_CTEANA.NCANNUM = TCAN.NCANNUM AND TREF_CTEANA.VSOCIETE = '" & MozartParams.NomSociete & "'"

      Case "CPTANA_BY_PER"
        Return "SELECT DISTINCT TCAN.NCANNUM, RIGHT('000' + CONVERT(VARCHAR(4),TCAN.NCANNUM), 3) + ' - ' + VCANLIB AS 'Compte Analytique' FROM TCAN, TREF_CTEANA WHERE TREF_CTEANA.NCANNUM = TCAN.NCANNUM AND TCAN.NPERNUM = " & MozartParams.UID & " AND TREF_CTEANA.VSOCIETE = '" & MozartParams.NomSociete & "'"

      Case "GROUPE"
        Return "SELECT DISTINCT IDGROUPE, LIBGROUPE FROM TREF_GROUPE WHERE VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY LIBGROUPE"

      Case "VSPYACTION"
        Return "Select Distinct VSPYACTION, VSPYACTION From TSPYLOG"

      Case "VSPYFCT"
        Return "Select Distinct VSPYFCT, VSPYFCT From TSPYLOG"

      Case Else
        MsgBox("§Cette valeur n'est pas actuellement implémentée  :-(§")
        Return ""
    End Select

  End Function

  Public Function GetLangueByNSFTNUM(ByVal p_NTSFNUM As Integer) As String
    Dim dr As SqlDataReader
    Dim lRetVal As String = ""

    Try
      Using cmd As New SqlCommand($"EXEC [api_sp_GetLangueByNSTFNUM] {p_NTSFNUM}", MozartDatabase.cnxMozart)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
          lRetVal = BlankIfNull(dr(0))
        Else
          lRetVal = ""
        End If

        dr.Close()
      End Using

    Catch Ex As Exception
      MessageBox.Show(Ex.Message & vbCrLf & vbCrLf & " dans " & MethodBase.GetCurrentMethod.Name, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
    Return lRetVal
  End Function

End Module
