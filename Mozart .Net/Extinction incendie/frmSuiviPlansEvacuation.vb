Imports System.Data.SqlClient
Imports MozartLib

Public Class frmSuiviPlansEvacuation

  Dim lNACTNUM As String
  Dim calendar_open As String = ""
  Dim DDEMANDE_initiale As String = ""

  Public Sub New(ByVal NACTNUM As Object)

    InitializeComponent()

    lNACTNUM = NACTNUM

  End Sub

  Private Sub frmSuiviPlansEvacuation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Dim dr As SqlDataReader
    Dim CmdSql

    ' TB SAMSIC CITY RES
    Label20.Text = Label20.Text.Replace("#gstrNomGroupe", MozartParams.NomGroupe)

    Try

      Me.Cursor = Cursors.WaitCursor

      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        CmdSql = New SqlCommand("select * from TACT left outer join TACTSUIVIPLANEVAC_EI on TACT.NACTNUM = TACTSUIVIPLANEVAC_EI.NACTNUM where TACT.NACTNUM = " & lNACTNUM, MozartDatabase.cnxMozart)

        dr = CmdSql.ExecuteReader

        If dr.HasRows = True Then
          dr.Read()
          LabelTitre.Text = My.Resources.ExtinctionIncendie_frmSuiviPlansEvacuation_suivi & dr("NACTNUM").ToString & " (DI " & dr("NDINNUM").ToString & ")"
          DDEMANDE_initiale = dr("DDEMANDE").ToString
          TextBox1.Text = getValue(dr("DDEMANDE").ToString)
          TextBox2.Text = getValue(dr("DCONSTATSITE").ToString)
          TextBox3.Text = getValue(dr("DINTERVENTION").ToString)
          TextBox4.Text = getValue(dr("DRELEVE").ToString)
          TextBox5.Text = getValue(dr("DTRANSFERTRELEVE1").ToString)
          TextBox6.Text = getValue(dr("DRETOUR1").ToString)
          TextBox7.Text = getValue(dr("DTRANSFERTTECH1").ToString)
          TextBox8.Text = getValue(dr("DRETOURTECH1").ToString)
          TextBox9.Text = getValue(dr("DTRANSFERTRELEVE2").ToString)
          TextBox10.Text = getValue(dr("DRETOUR2").ToString)
          TextBox11.Text = getValue(dr("DTRANSFERTTECH2").ToString)
          TextBox12.Text = getValue(dr("DRETOURTECH2").ToString)
          TextBox13.Text = getValue(dr("DTRANSFERTTECH3").ToString)
          TextBox14.Text = getValue(dr("DRETOUR3").ToString)
          TextBox15.Text = getValue(dr("DTRANSFERTRELEVEFINAL").ToString)
          TextBox16.Text = getValue(dr("DRETOURTECHFINAL").ToString)
          TextBox17.Text = getValue(dr("DTRANSFERTREALISATIONPLAN").ToString)
          TextBox18.Text = getValue(dr("DRECEPTIONPLAN").ToString)
          TextBox19.Text = getValue(dr("DENVOIPLAN").ToString)

          dr.Close()
          CmdSql.Dispose()

        End If

      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.ExtinctionIncendie_frmSuiviPlansEvacuation_load + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
      dr = Nothing
      CmdSql = Nothing
    End Try

  End Sub

  Private Function getValue(champ As String) As String
    Dim newChamp As String

    If champ = "" Then
      newChamp = DBNull.Value.ToString
    Else
      newChamp = champ.ToString.Substring(0, 10)
    End If

    getValue = newChamp
  End Function

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

    Select Case calendar_open
      Case "TextBox1"
        TextBox1.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox2"
        TextBox2.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox3"
        TextBox3.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox4"
        TextBox4.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox5"
        TextBox5.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox6"
        TextBox6.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox7"
        TextBox7.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox8"
        TextBox8.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox9"
        TextBox9.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox10"
        TextBox10.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox11"
        TextBox11.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox12"
        TextBox12.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox13"
        TextBox13.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox14"
        TextBox14.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox15"
        TextBox15.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox16"
        TextBox16.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox17"
        TextBox17.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox18"
        TextBox18.Text = MonthCalendar1.SelectionStart.Date
      Case "TextBox19"
        TextBox19.Text = MonthCalendar1.SelectionStart.Date
    End Select

    MonthCalendar1.Visible = False

  End Sub

  Private Sub TextBox1_Click(sender As Object, e As System.EventArgs) Handles TextBox1.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox1"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox2_Click(sender As Object, e As System.EventArgs) Handles TextBox2.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox2"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox3_Click(sender As Object, e As System.EventArgs) Handles TextBox3.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox3"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox4_Click(sender As Object, e As System.EventArgs) Handles TextBox4.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox4"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox5_Click(sender As Object, e As System.EventArgs) Handles TextBox5.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox5"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox6_Click(sender As Object, e As System.EventArgs) Handles TextBox6.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox6"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox7_Click(sender As Object, e As System.EventArgs) Handles TextBox7.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox7"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox8_Click(sender As Object, e As System.EventArgs) Handles TextBox8.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox8"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox9_Click(sender As Object, e As System.EventArgs) Handles TextBox9.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox9"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox10_Click(sender As Object, e As System.EventArgs) Handles TextBox10.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox10"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox11_Click(sender As Object, e As System.EventArgs) Handles TextBox11.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox11"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox12_Click(sender As Object, e As System.EventArgs) Handles TextBox12.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox12"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox13_Click(sender As Object, e As System.EventArgs) Handles TextBox13.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox13"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox14_Click(sender As Object, e As System.EventArgs) Handles TextBox14.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox14"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox15_Click(sender As Object, e As System.EventArgs) Handles TextBox15.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox15"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox16_Click(sender As Object, e As System.EventArgs) Handles TextBox16.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox16"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox17_Click(sender As Object, e As System.EventArgs) Handles TextBox17.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox17"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox18_Click(sender As Object, e As System.EventArgs) Handles TextBox18.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox18"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub TextBox19_Click(sender As Object, e As System.EventArgs) Handles TextBox19.Click
    If MonthCalendar1.Visible Then
      calendar_open = ""
      MonthCalendar1.Visible = False
    Else
      calendar_open = "TextBox19"
      MonthCalendar1.Visible = True
    End If
  End Sub

  Private Sub But1_Click(sender As System.Object, e As System.EventArgs) Handles But1.Click
    TextBox1.Text = ""
  End Sub

  Private Sub But2_Click(sender As System.Object, e As System.EventArgs) Handles But2.Click
    TextBox2.Text = ""
  End Sub

  Private Sub But3_Click(sender As System.Object, e As System.EventArgs) Handles But3.Click
    TextBox3.Text = ""
  End Sub

  Private Sub But4_Click(sender As System.Object, e As System.EventArgs) Handles But4.Click
    TextBox4.Text = ""
  End Sub

  Private Sub But5_Click(sender As System.Object, e As System.EventArgs) Handles But5.Click
    TextBox5.Text = ""
  End Sub

  Private Sub But6_Click(sender As System.Object, e As System.EventArgs) Handles But6.Click
    TextBox6.Text = ""
  End Sub

  Private Sub But7_Click(sender As System.Object, e As System.EventArgs) Handles But7.Click
    TextBox7.Text = ""
  End Sub

  Private Sub But8_Click(sender As System.Object, e As System.EventArgs) Handles But8.Click
    TextBox8.Text = ""
  End Sub

  Private Sub But9_Click(sender As System.Object, e As System.EventArgs) Handles But9.Click
    TextBox9.Text = ""
  End Sub

  Private Sub But10_Click(sender As System.Object, e As System.EventArgs) Handles But10.Click
    TextBox10.Text = ""
  End Sub

  Private Sub But11_Click(sender As System.Object, e As System.EventArgs) Handles But11.Click
    TextBox11.Text = ""
  End Sub

  Private Sub But12_Click(sender As System.Object, e As System.EventArgs) Handles But12.Click
    TextBox12.Text = ""
  End Sub

  Private Sub But13_Click(sender As System.Object, e As System.EventArgs) Handles But13.Click
    TextBox13.Text = ""
  End Sub

  Private Sub But14_Click(sender As System.Object, e As System.EventArgs) Handles But14.Click
    TextBox14.Text = ""
  End Sub

  Private Sub But15_Click(sender As System.Object, e As System.EventArgs) Handles But15.Click
    TextBox15.Text = ""
  End Sub

  Private Sub But16_Click(sender As System.Object, e As System.EventArgs) Handles But16.Click
    TextBox16.Text = ""
  End Sub

  Private Sub But17_Click(sender As System.Object, e As System.EventArgs) Handles But17.Click
    TextBox17.Text = ""
  End Sub

  Private Sub But18_Click(sender As System.Object, e As System.EventArgs) Handles But18.Click
    TextBox18.Text = ""
  End Sub

  Private Sub But19_Click(sender As System.Object, e As System.EventArgs) Handles But19.Click
    TextBox19.Text = ""
  End Sub

  Private Sub BtnEnreg_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnreg.Click

    Dim o_sql As String

    If TextBox1.Text = "" Then
      MsgBox(My.Resources.ExtinctionIncendie_frmSuiviPlansEvacuation_date_obli, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_enregistrement_annulé)
      Exit Sub
    End If

    If DDEMANDE_initiale = "" Then
      ' Création
      o_sql = "INSERT INTO TACTSUIVIPLANEVAC_EI (NACTNUM, DDEMANDE, DCONSTATSITE, DINTERVENTION, DRELEVE, DTRANSFERTRELEVE1, DRETOUR1, DTRANSFERTTECH1, DRETOURTECH1, DTRANSFERTRELEVE2, DRETOUR2, "
      o_sql = o_sql & "DTRANSFERTTECH2, DRETOURTECH2, DTRANSFERTTECH3, DRETOUR3, DTRANSFERTRELEVEFINAL, DRETOURTECHFINAL, DTRANSFERTREALISATIONPLAN, DRECEPTIONPLAN, DENVOIPLAN) "
      o_sql = o_sql & "VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19})"
      Dim SqlInsert As New SqlCommand(String.Format(o_sql,
                                        lNACTNUM,
                                        TextBox1.Text,
                                        If(TextBox2.Text = "", "NULL", "'" & TextBox2.Text & "'"),
                                        If(TextBox3.Text = "", "NULL", "'" & TextBox3.Text & "'"),
                                        If(TextBox4.Text = "", "NULL", "'" & TextBox4.Text & "'"),
                                        If(TextBox5.Text = "", "NULL", "'" & TextBox5.Text & "'"),
                                        If(TextBox6.Text = "", "NULL", "'" & TextBox6.Text & "'"),
                                        If(TextBox7.Text = "", "NULL", "'" & TextBox7.Text & "'"),
                                        If(TextBox8.Text = "", "NULL", "'" & TextBox8.Text & "'"),
                                        If(TextBox9.Text = "", "NULL", "'" & TextBox9.Text & "'"),
                                        If(TextBox10.Text = "", "NULL", "'" & TextBox10.Text & "'"),
                                        If(TextBox11.Text = "", "NULL", "'" & TextBox11.Text & "'"),
                                        If(TextBox12.Text = "", "NULL", "'" & TextBox12.Text & "'"),
                                        If(TextBox13.Text = "", "NULL", "'" & TextBox13.Text & "'"),
                                        If(TextBox14.Text = "", "NULL", "'" & TextBox14.Text & "'"),
                                        If(TextBox15.Text = "", "NULL", "'" & TextBox15.Text & "'"),
                                        If(TextBox16.Text = "", "NULL", "'" & TextBox16.Text & "'"),
                                        If(TextBox17.Text = "", "NULL", "'" & TextBox17.Text & "'"),
                                        If(TextBox18.Text = "", "NULL", "'" & TextBox18.Text & "'"),
                                        If(TextBox19.Text = "", "NULL", "'" & TextBox19.Text & "'")), MozartDatabase.cnxMozart)

      SqlInsert.ExecuteNonQuery()

    Else
      ' Mise à jour
      o_sql = "UPDATE TACTSUIVIPLANEVAC_EI SET DDEMANDE = '{0}', DCONSTATSITE = {1}, DINTERVENTION = {2}, DRELEVE = {3}, DTRANSFERTRELEVE1 = {4}, DRETOUR1 = {5}, DTRANSFERTTECH1 = {6}, DRETOURTECH1 = {7}, "
      o_sql = o_sql & "DTRANSFERTRELEVE2 = {8}, DRETOUR2 = {9}, DTRANSFERTTECH2 = {10}, DRETOURTECH2 = {11}, DTRANSFERTTECH3 = {12}, DRETOUR3 = {13}, DTRANSFERTRELEVEFINAL = {14}, DRETOURTECHFINAL = {15}, "
      o_sql = o_sql & "DTRANSFERTREALISATIONPLAN = {16}, DRECEPTIONPLAN = {17}, DENVOIPLAN = {18} WHERE NACTNUM = " & lNACTNUM
      Dim SqlUpdate As New SqlCommand(String.Format(o_sql,
                                        TextBox1.Text,
                                        If(TextBox2.Text = "", "NULL", "'" & TextBox2.Text & "'"),
                                        If(TextBox3.Text = "", "NULL", "'" & TextBox3.Text & "'"),
                                        If(TextBox4.Text = "", "NULL", "'" & TextBox4.Text & "'"),
                                        If(TextBox5.Text = "", "NULL", "'" & TextBox5.Text & "'"),
                                        If(TextBox6.Text = "", "NULL", "'" & TextBox6.Text & "'"),
                                        If(TextBox7.Text = "", "NULL", "'" & TextBox7.Text & "'"),
                                        If(TextBox8.Text = "", "NULL", "'" & TextBox8.Text & "'"),
                                        If(TextBox9.Text = "", "NULL", "'" & TextBox9.Text & "'"),
                                        If(TextBox10.Text = "", "NULL", "'" & TextBox10.Text & "'"),
                                        If(TextBox11.Text = "", "NULL", "'" & TextBox11.Text & "'"),
                                        If(TextBox12.Text = "", "NULL", "'" & TextBox12.Text & "'"),
                                        If(TextBox13.Text = "", "NULL", "'" & TextBox13.Text & "'"),
                                        If(TextBox14.Text = "", "NULL", "'" & TextBox14.Text & "'"),
                                        If(TextBox15.Text = "", "NULL", "'" & TextBox15.Text & "'"),
                                        If(TextBox16.Text = "", "NULL", "'" & TextBox16.Text & "'"),
                                        If(TextBox17.Text = "", "NULL", "'" & TextBox17.Text & "'"),
                                        If(TextBox18.Text = "", "NULL", "'" & TextBox18.Text & "'"),
                                        If(TextBox19.Text = "", "NULL", "'" & TextBox19.Text & "'")), MozartDatabase.cnxMozart)

      SqlUpdate.ExecuteNonQuery()

    End If
  End Sub
End Class