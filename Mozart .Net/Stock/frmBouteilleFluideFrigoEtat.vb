Imports System.Data.SqlClient
Imports DevExpress.XtraPivotGrid
Imports MozartLib

Public Class frmBouteilleFluideFrigoEtat

  Dim bSendAuto As Boolean

  Public Sub New(Optional c_bSendAuto As Object = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    If c_bSendAuto Is Nothing Then
      bSendAuto = False
    Else
      If c_bSendAuto.ToString = "SENDAUTO" Then
        bSendAuto = True
      Else
        bSendAuto = False
      End If

    End If
  End Sub

  Private Sub frmBouteilleFluideFrigoEtat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

    If bSendAuto = True Then SendMail() : Me.Close()

  End Sub

  Private Sub LoadData()
    Try

      Me.Cursor = Cursors.WaitCursor

      Dim CmdSql As New SqlCommand("[api_sp_CertFluid_TablRecapEtatBottle]", MozartDatabase.cnxMozart)
      CmdSql.CommandType = CommandType.StoredProcedure
      CmdSql.Parameters.Add("@vsociete", SqlDbType.VarChar).Value = MozartParams.NomSociete

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(CmdSql)
      Dim dtStat As New DataSet
      sqlAdpat.Fill(dtStat)

      PGC_BottleEtat.DataSource = dtStat.Tables(0)

      CmdSql.Dispose()

      LblTitre.Text = "Tableau de suivi des bouteilles de fluides frigorigènes " & MozartParams.NomSociete & My.Resources.Global_le & " " & DateTime.Now.ToString("dd/MM/yyyy")

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_EMALEC_sub + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub frmBouteilleFluideFrigoEtat_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    PGC_BottleEtat.Size = New Size(Me.Size.Width - PGC_BottleEtat.Location.X - 50, Me.Size.Height - PGC_BottleEtat.Location.Y - 50)

  End Sub

  Private Sub frmBouteilleFluideFrigoEtat_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
    PGC_BottleEtat.Size = New Size(Me.Size.Width - PGC_BottleEtat.Location.X - 50, Me.Size.Height - PGC_BottleEtat.Location.Y - 50)
  End Sub

  Private Sub PGC_BottleEtat_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles PGC_BottleEtat.CellDoubleClick

    If e.RowField Is Nothing Then
      Return 'Grand Total cell
    End If

    Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource

    If ds.RowCount = 0 Then Return

    For i = 0 To ds.RowCount - 1

      Dim row As PivotDrillDownDataRow = ds(i)

      Dim sMessage As String = String.Format(" - Quantité utilisé (en L) : {0}" & vbCrLf & " - Quantité restante (en L) : {1}" & vbCrLf & " - Quantité total bouteille (en L) : {2}" & vbCrLf & " -  % restant : {3:P2}",
                                              row("TOT"), row("RESTANT"), row("TOT_CONTENANT"), row("POURC_RESTANT") / 100)

      MessageBox.Show(sMessage, "Détail")

    Next

  End Sub

  Private Sub ButtonExporter_Click(sender As Object, e As EventArgs) Handles ButtonExporter.Click

    SFD.FileName = "TableauEtatBouteilleFluideFrigo" & Today.Year & Today.Month & Today.Day & ".xlsx"
    SFD.Filter = "Fichers EXCEL (*.xlsx) |*.xlsx"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      PGC_BottleEtat.ExportToXlsx(SFD.FileName)
    End If

  End Sub

  Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
  End Sub

  Private Sub SendMail()

    Dim fileName As String = MozartParams.CheminUtilisateur & "\TableauEtatBouteilleFluideFrigo" & Today.Year & Today.Month & Today.Day & "_" & TimeOfDay.Hour & TimeOfDay.Minute & ".html"

    If File.Exists(fileName) Then File.Delete(fileName)

    PGC_BottleEtat.ExportToHtml(fileName)

    Dim fileReader As String
    fileReader = My.Computer.FileSystem.ReadAllText(fileName)

    Dim sMessageHeader As String = "<html><head><title>Liste des interventions exécutées de la journée</title>
									<style><!-- p.TEXTE  {font-size:12.0pt;  font-family:'Verdana';} p.TITRE   {font-size:10.0pt;  font-family:'Verdana';  color:#004684;} 
									p.Norm  {font-size:8.0pt;  font-family:'Verdana';} --></style> </head><body lang=FR><br>
                                    <p class=TEXTE>Tableau de suivi des bouteilles de fluides frigorigènes du " + Now.Date.ToShortDateString + "</p><br><BR>"

    Dim sMessageFooter As String = "</body></html>"

    Dim oSender As New CSendMail
    oSender.bAfficheMsgSucces = False
    oSender.Dest = "mcavallaro@emalec.com"
    oSender.BlindCopyDest = ""
    oSender.Message = sMessageHeader + fileReader + sMessageFooter
    oSender.Subject = "Tableau de suivi des bouteilles de fluides frigorigènes du " + Now.Date.ToShortDateString
    oSender.SendMail("HTML")

  End Sub

End Class