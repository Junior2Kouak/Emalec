Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestionPrestations

  Public sNumSTT As String

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

  Private Sub frmGestionPrestations_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    Init_Grid()
  End Sub

  Private Sub Init_Grid()
    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        ' Récupérer la liste des Prestations (Activités)
        Dim CmdSql As New SqlCommand("select ID, VCATEGORIE, VACTIVITE from TACTIVITES order by NORDREAFFICHAGE", MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = CmdSql.ExecuteReader

        Dim indexRow As Integer = 0
        Dim categoriePrec = ""
        Dim changeColor As Int16 = 0

        While dr.Read()

          DataGridView1.Rows.Add()

          DataGridView1.Rows(indexRow).Cells("CID").Value = dr("ID")
          If categoriePrec <> dr("VCATEGORIE") Then
            DataGridView1.Rows(indexRow).Cells("CCategorie").Value = dr("VCATEGORIE")
            categoriePrec = dr("VCATEGORIE")
            If changeColor = 0 Then
              changeColor = 1
            Else
              changeColor = 0
            End If
          End If
          DataGridView1.Rows(indexRow).Cells("CCategorie2").Value = dr("VCATEGORIE")
          DataGridView1.Rows(indexRow).Cells("CPrestation").Value = dr("VACTIVITE")

          If changeColor = 0 Then
            DataGridView1.Rows(indexRow).DefaultCellStyle.BackColor = Color.LightCyan
          Else
            DataGridView1.Rows(indexRow).DefaultCellStyle.BackColor = Color.LightGray
          End If

          indexRow = indexRow + 1

        End While
        dr.Close()
        CmdSql.Dispose()

        CmdSql = New SqlCommand("select VSTFNOM, VListeActivites from TSTF where NSTFNUM = " & sNumSTT, MozartDatabase.cnxMozart)
        dr = CmdSql.ExecuteReader

        If dr.Read() Then

          Dim Ligne As String = dr("VListeActivites").ToString
          LabelNomSTT.Text = dr("VSTFNOM")
          dr.Close()

          ' Ligne contient la liste des activités au format prédéfini :
          '   Ex : 1_Inst;1_Maint;1_Dep;1_Astr;15_Inst;24_Inst;24_Maint;24_Dep; où le numérique est l'ID de la table TACTIVITES et la chaine la colonne du tableau (Installation / Maintenance / Dépannage / Astreinte)

          ' On décompose Ligne en plusieurs lignes à afficher à l'écran
          Dim competences As String() = Ligne.ToString.Split(";")

          For i = 0 To competences.Count - 1
            If competences(i).Length > 0 Then
              Dim id_unique As String = competences(i).Substring(0, competences(i).IndexOf("_"))
              Dim colonne As String = competences(i).Substring(competences(i).IndexOf("_") + 1)

              CheckGrid(id_unique, colonne)

            End If
          Next

        End If

        CmdSql.Dispose()

      End If

    Catch ex As Exception
            MessageBox.Show(My.Resources.Admin_frmGestionPrestation_sub + ex.Message, My.Resources.Global_Erreur)
        Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub CheckGrid(ByVal idCoche As String, ByVal colonne As String)

    For i = 0 To DataGridView1.RowCount - 1
      Dim ligne_selectionnee As System.Windows.Forms.DataGridViewRow = DataGridView1.Rows(i)

      Dim ID As String = ligne_selectionnee.Cells(0).Value.ToString ' On récupère l'ID

      If ID = idCoche Then

        Select Case colonne
          Case "Etud"       ' Etudes
            DataGridView1.Rows(i).Cells("CEtudes").Value = "1"
          Case "Inst"       ' Installation
            DataGridView1.Rows(i).Cells("CInstallation").Value = "1"
          Case "Maint"      ' Maintenance prev
            DataGridView1.Rows(i).Cells("CMaintPrev").Value = "1"
          Case "Dep"        ' Dépannage
            DataGridView1.Rows(i).Cells("CDepannage").Value = "1"
          Case "Astr"       ' Astreintes
            DataGridView1.Rows(i).Cells("CAstreinte").Value = "1"
        End Select
        Exit For

      End If
    Next

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnEnreg_Click(sender As System.Object, e As System.EventArgs) Handles BtnEnreg.Click
    ' Enregistrement des cases à cocher, sur le même modèle que le formulaire web
    Dim sLstActivites As String = ""
    Dim sLstActivitesRecherche As String = ""
    Recup_coches(sLstActivites, sLstActivitesRecherche)

    sLstActivitesRecherche = sLstActivitesRecherche.Replace("'", "''")

    If sLstActivites = "" Then
            If MsgBox(My.Resources.Admin_frmGestionPrestation_Attention, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, My.Resources.Global_Attention) = vbNo Then Exit Sub
        End If

    Dim sqlcmdUpdate As SqlCommand
    sqlcmdUpdate = New SqlCommand("update TSTF set VListeActivites = '" & sLstActivites & "', VListeActivitesRecherche = '" & sLstActivitesRecherche & "' WHERE NSTFNUM = " & sNumSTT, MozartDatabase.cnxMozart)

    sqlcmdUpdate.ExecuteNonQuery()

        MsgBox(My.Resources.Admin_frmGestionPrestation_datasaved, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, My.Resources.Global_enregistrement)

    End Sub


  Protected Sub Recup_coches(ByRef sLstActivites As String, ByRef sLstActivitesRecherche As String)

    Dim bAjout As Boolean

    For i = 0 To DataGridView1.Rows.Count - 1
      ' On ne stocke en BDD que l'ID et le type de prestation de ce qui est coché :
      bAjout = False
      If DataGridView1.Rows(i).Cells("CEtudes").Value = "1" Then
        sLstActivites = sLstActivites & DataGridView1.Rows(i).Cells("CID").Value & "_Etud;" ' Etudes
        bAjout = True
      End If

      If DataGridView1.Rows(i).Cells("CInstallation").Value = "1" Then
        sLstActivites = sLstActivites & DataGridView1.Rows(i).Cells("CID").Value & "_Inst;" ' Installation
        bAjout = True
      End If

      If DataGridView1.Rows(i).Cells("CMaintPrev").Value = "1" Then
        sLstActivites = sLstActivites & DataGridView1.Rows(i).Cells("CID").Value & "_Maint;" ' Maintenance prev
        bAjout = True
      End If

      If DataGridView1.Rows(i).Cells("CDepannage").Value = "1" Then
        sLstActivites = sLstActivites & DataGridView1.Rows(i).Cells("CID").Value & "_Dep;" ' Dépannage
        bAjout = True
      End If

      If DataGridView1.Rows(i).Cells("CAstreinte").Value = "1" Then
        sLstActivites = sLstActivites & DataGridView1.Rows(i).Cells("CID").Value & "_Astr;" ' Astreintes
        bAjout = True
      End If

      If bAjout = True Then
        If sLstActivitesRecherche.IndexOf(DataGridView1.Rows(i).Cells("CCategorie2").Value) = -1 Then
          sLstActivitesRecherche = sLstActivitesRecherche & DataGridView1.Rows(i).Cells("CCategorie2").Value & ";"
        End If

        If sLstActivitesRecherche.IndexOf(DataGridView1.Rows(i).Cells("CPrestation").Value) = -1 Then
          sLstActivitesRecherche = sLstActivitesRecherche & DataGridView1.Rows(i).Cells("CPrestation").Value & ";"
        End If

      End If

    Next i

  End Sub
End Class