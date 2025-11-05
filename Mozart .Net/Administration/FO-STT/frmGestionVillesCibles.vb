Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestionVillesCibles

  Public sNumSTT As String
  Dim sVSTFNOM, sFSTFLAT, sFSTFLON As String

  Public Sub New(ByVal c_iType As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sNumSTT = c_iType.ToString

  End Sub

  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmGestionVillesCibles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Init_Grid()

  End Sub

  Private Sub Init_Grid()
    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        ' Récupérer les infos du sous-traitant :
        Dim CmdSql As New SqlCommand("select VSTFNOM, VListeVilles, VSTFPAYS, FSTFLAT, FSTFLON from TSTF where NSTFNUM = " & sNumSTT, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = CmdSql.ExecuteReader

        If dr.Read() Then

          Dim Ligne As String = dr("VListeVilles").ToString
          LabelNomSTT.Text = dr("VSTFNOM") & " (" & dr("VSTFPAYS") & ")"
          LabelPays.Text = dr("VSTFPAYS")

          If Not dr("FSTFLAT").Equals(System.DBNull.Value) Then
            sFSTFLAT = dr("FSTFLAT")
            sFSTFLON = dr("FSTFLON")
          End If
          sVSTFNOM = dr("VSTFNOM")

          dr.Close()
          CmdSql.Dispose()

          ' Ligne contient la liste des villes :
          '   Ex : 1;4;8;9;10;11;12; où le numérique est l'ID de la table TVILLES

          ' On décompose Ligne en plusieurs lignes à afficher à l'écran
          Dim villes As String() = Ligne.ToString.Split(";")

          ' Récupérer la liste des villes
          CmdSql = New SqlCommand("select ID, REGION, VILLE from TVILLES where PAYS = '" & LabelPays.Text & "' order by REGION, VILLE", MozartDatabase.cnxMozart)
          dr = CmdSql.ExecuteReader

          Dim indexRow As Integer = 0
          Dim changeColor As Int16 = 0
          Dim ancRegion As String = ""

          While dr.Read()

            DataGridView1.Rows.Add()

            DataGridView1.Rows(indexRow).Cells("CID").Value = dr("ID")
            DataGridView1.Rows(indexRow).Cells("CRegion").Value = dr("REGION")
            DataGridView1.Rows(indexRow).Cells("CVille").Value = dr("VILLE")

            If ancRegion <> dr("Region") Then
              changeColor = changeColor + 1
              ancRegion = dr("Region")
            End If

            If changeColor Mod (2) = 0 Then
              DataGridView1.Rows(indexRow).DefaultCellStyle.BackColor = Color.LightCyan
            Else
              DataGridView1.Rows(indexRow).DefaultCellStyle.BackColor = Color.LightGray
            End If

            indexRow = indexRow + 1

          End While
          dr.Close()

          For i = 0 To villes.Count - 1
            If villes(i).Length > 0 Then

              CheckGrid(villes(i))

            End If
          Next

        End If

        CmdSql.Dispose()

      End If

      If sFSTFLAT <> "" Then
        ' TB SAMSIC CITY SPEC
        If MozartParams.NomGroupe = "EMALEC" Then
                    'WebBrowser1.Navigate("https://maps.emalec.com/Villes_cibles_v2.asp?base=MULTI&FSTFLAT=" & sFSTFLAT & "&NSTFNUM=" & sNumSTT & "&FSTFLON=" & sFSTFLON & "&VSTFNOM=" & sVSTFNOM & "&PAYS=" & LabelPays.Text & "&APP=" & MozartParams.NomSociete)
                    webView21.Source = New Uri("https://maps.emalec.com/Villes_cibles_v2.asp?base=MULTI&FSTFLAT=" & sFSTFLAT & "&NSTFNUM=" & sNumSTT & "&FSTFLON=" & sFSTFLON & "&VSTFNOM=" & sVSTFNOM & "&PAYS=" & LabelPays.Text & "&APP=" & MozartParams.NomSociete)
                End If ' TODO_TB SAMSIC CITY -> else pour samsic
      Else
        MsgBox(My.Resources.Admin_GestionVillesCibles_carte_non_affichée & vbCrLf & My.Resources.Admin_GestionVillesCibles_carte_op, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Resources.Global_Attention)
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_GestionVillesCibles_Sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub CheckGrid(ByVal idCoche As String)

    For i = 0 To DataGridView1.RowCount - 1
      Dim ligne_selectionnee As System.Windows.Forms.DataGridViewRow = DataGridView1.Rows(i)

      Dim ID As String = ligne_selectionnee.Cells(0).Value.ToString ' On récupère l'ID

      If ID = idCoche Then

        DataGridView1.Rows(i).Cells("CIntervention").Value = "1"

        Exit For

      End If
    Next

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnEnreg_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnreg.Click
    ' Enregistrement des cases à cocher, sur le même modèle que le formulaire web
    Dim sLstVilles As String = ""
    Dim sLstVillesRecherche As String = ""

    ' Enlever les filtres éventuels
    TextBox1.Text = ""
    TextBox2.Text = ""

    Recup_coches(sLstVilles, sLstVillesRecherche)

    sLstVillesRecherche = sLstVillesRecherche.Replace("'", "''")

    If sLstVilles = "" Then
      If MsgBox(My.Resources.Admin_frmGestionPrestation_Attention, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, My.Resources.Global_Attention) = vbNo Then Exit Sub
    End If

    Dim sqlcmdUpdate As SqlCommand
    sqlcmdUpdate = New SqlCommand("update TSTF set VListeVilles = '" & sLstVilles & "', VListeVillesRecherche = '" & sLstVillesRecherche & "' WHERE NSTFNUM = " & sNumSTT, MozartDatabase.cnxMozart)
    sqlcmdUpdate.ExecuteNonQuery()

    MsgBox(My.Resources.Admin_GestionVillesCibles_datasaved, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Resources.Global_enregistrement)

    ' TB SAMSIC CITY SPEC
    If MozartParams.NomGroupe = "EMALEC" Then
            'WebBrowser1.Navigate("https://maps.emalec.com/Villes_cibles_v2.asp?base=MULTI&FSTFLAT=" & sFSTFLAT & "&NSTFNUM=" & sNumSTT & "&FSTFLON=" & sFSTFLON & "&VSTFNOM=" & sVSTFNOM & "&PAYS=" & LabelPays.Text & "&APP=" & MozartParams.NomSociete)
            webView21.Source = New Uri("https://maps.emalec.com/Villes_cibles_v2.asp?base=MULTI&FSTFLAT=" & sFSTFLAT & "&NSTFNUM=" & sNumSTT & "&FSTFLON=" & sFSTFLON & "&VSTFNOM=" & sVSTFNOM & "&PAYS=" & LabelPays.Text & "&APP=" & MozartParams.NomSociete)
        End If ' TODO_TB SAMSIC CITY -> else pour samsic

    End Sub

  Protected Sub Recup_coches(ByRef sLstVilles As String, ByRef sLstVillesRecherche As String)

    For i = 0 To DataGridView1.Rows.Count - 1
      ' On ne stocke en BDD que l'ID et le type de prestation de ce qui est coché :

      If DataGridView1.Rows(i).Cells("CIntervention").Value = "1" Then
        sLstVilles = sLstVilles & DataGridView1.Rows(i).Cells("CID").Value & ";"
        sLstVillesRecherche = sLstVillesRecherche & DataGridView1.Rows(i).Cells("CVille").Value & ";"
      End If

    Next i

  End Sub

  Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
    ' Filtrer sur région

    Me.Cursor = Cursors.WaitCursor

    Dim s1 As String = TextBox1.Text.ToUpper
    Dim s2 As String = TextBox2.Text.ToUpper

    If s1 = "" And s2 = "" Then

      For i = 0 To DataGridView1.Rows.Count - 1
        DataGridView1.Rows(i).Visible = True
      Next i

    Else
      ' Filtrer
      For j = 0 To DataGridView1.Rows.Count - 1

        If DataGridView1.Rows(j).Cells("CRegion").Value.ToString.ToUpper.Contains(s1) And DataGridView1.Rows(j).Cells("CVille").Value.ToString.ToUpper.Contains(s2) Then
          DataGridView1.Rows(j).Visible = True
        Else
          DataGridView1.Rows(j).Visible = False
        End If

      Next j
    End If

    Me.Cursor = Cursors.Default

  End Sub

  Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
    ' Filtrer sur ville

    Me.Cursor = Cursors.WaitCursor

    Dim s3 As String = TextBox1.Text.ToUpper
    Dim s4 As String = TextBox2.Text.ToUpper

    If s4 = "" And s3 = "" Then

      For i = 0 To DataGridView1.Rows.Count - 1
        DataGridView1.Rows(i).Visible = True
      Next i

    Else
      ' Filtrer
      For i = 0 To DataGridView1.Rows.Count - 1

        If DataGridView1.Rows(i).Cells("CVille").Value.ToString.ToUpper.Contains(s4) And DataGridView1.Rows(i).Cells("CRegion").Value.ToString.ToUpper.Contains(s3) Then
          DataGridView1.Rows(i).Visible = True
        Else
          DataGridView1.Rows(i).Visible = False
        End If

      Next i
    End If

    Me.Cursor = Cursors.Default

  End Sub

End Class