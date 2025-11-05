Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports MozartLib

Public Class FrmDepensesAnalytique

  Dim oGestConnectSQL As New CGestionSQL

  Dim dtAnaDepDetail As DataTable
  Dim dtAnaDepModele As DataTable

  Dim DateMaxANAHISTO As Nullable(Of DateTime)

  Public Sub New(ByVal c_DateMaxANAHISTO As DateTime)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    DateMaxANAHISTO = c_DateMaxANAHISTO

  End Sub

  Private Sub FrmDepensesAnalytique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'init boutons
      Initboutons(Me)
      Dim iWitdhScrollBarVert As Int32 = SystemInformation.VerticalScrollBarWidth
      GCANADEPMODELE.Width = GCDEPANADETAIL.Width - iWitdhScrollBarVert

      'on ouvre la connexion  
      If oGestConnectSQL.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        If IsDBNull(DateMaxANAHISTO) = False Then

          TxtMois.Text = DatePart(DateInterval.Month, CType(DateMaxANAHISTO, DateTime)).ToString
          TxtAnnee.Text = DatePart(DateInterval.Year, CType(DateMaxANAHISTO, DateTime)).ToString

          'affichage auto du max date
          LoadData(DatePart(DateInterval.Month, CType(DateMaxANAHISTO, DateTime)), DatePart(DateInterval.Year, CType(DateMaxANAHISTO, DateTime)), MozartParams.NomSociete)

          'gestion des conditions affichage
          If Not dtAnaDepModele Is Nothing AndAlso dtAnaDepModele.Select("[LINEMODELE] = 1").Count > 1 Then

            MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_plusieurs_lignes, My.Resources.TabSyntheseCompta_frmdepensesanalytique_erreur)

          Else

            Dim oGetRow As DataRow = dtAnaDepModele.Select("[LINEMODELE] = 1")(0)

            For Each oColModele As Columns.GridColumn In GVDEPANADETAIL.Columns

              Select Case oColModele.FieldName

                Case "NCANNUM", "VCANLIB", "TOTAL"

                  'pour ses 3 colonnes on ne fait rien

                Case Else

                  'ajout d'une condition affichage
                  Dim oCondition As New StyleFormatCondition
                  Dim oFontModele As New Font("Arial", 8, FontStyle.Bold)
                  oCondition.Column = GVDEPANADETAIL.Columns.ColumnByFieldName(oColModele.FieldName)
                  oCondition.Appearance.ForeColor = Color.Red
                  oCondition.Appearance.Font = oFontModele
                  oCondition.Appearance.Options.UseFont = True
                  oCondition.Appearance.Options.UseForeColor = True
                  oCondition.Condition = FormatConditionEnum.GreaterOrEqual
                  oCondition.Value1 = oGetRow.Item(oColModele.FieldName)

                  GVDEPANADETAIL.FormatConditions.Add(oCondition)

              End Select

            Next

          End If

        End If

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_sub + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub LoadData(ByVal iNumMois As Integer, ByVal iNumAnnee As Integer, ByVal sNomSociete As String)

    'init
    Try

      dtAnaDepDetail = New DataTable

      dtAnaDepDetail = ModDataGridView.LoadList(String.Format("[api_sp_TableauSynthComptaDepense] {0}, {1}, '{2}'", iNumMois, iNumAnnee, sNomSociete), oGestConnectSQL.CnxSQLOpen)

      GCDEPANADETAIL.DataSource = dtAnaDepDetail

      LoadDataTableauModele()

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_sub2 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub LoadDataTableauModele()

    Try

      If dtAnaDepDetail Is Nothing Then Exit Sub

      'INIT
      dtAnaDepModele = New DataTable

      dtAnaDepModele = ModDataGridView.LoadList("[api_sp_TableauSynthComptaDepenseModele] '" + MozartParams.NomSociete + "'", oGestConnectSQL.CnxSQLOpen)

      If dtAnaDepModele Is Nothing Then
        MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_modèle_analy, My.Resources.TabSyntheseCompta_frmdepensesanalytique_modèle_erreur2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

      If dtAnaDepModele.Rows.Count = 0 Then

        MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_modèle_analy, My.Resources.TabSyntheseCompta_frmdepensesanalytique_modèle_erreur2, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub

      End If

      'on sélectionne les 30 premiers comptes analytiques
      Dim RowsTop = (From RowTop In dtAnaDepDetail
                     Order By RowTop.Field(Of Decimal)("TOTAL") Descending
                     Select RowTop).Take(30)

      Dim oRowModNew As DataRow = dtAnaDepModele.NewRow
      oRowModNew.Item("VLIBELLE") = "Moyenne 30 premiers comptes"
      oRowModNew.Item("NDEPLOCMAT") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPLOCMAT"))
      oRowModNew.Item("NDEPSTT") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPSTT"))
      oRowModNew.Item("NDEPTRANSP") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPTRANSP"))
      oRowModNew.Item("NDEPLOCVEH") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPLOCVEH"))
      oRowModNew.Item("NDEPMAT") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPMAT"))
      oRowModNew.Item("NDEPDEPL") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPDEPL"))
      oRowModNew.Item("NDEPPAN") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPPAN"))
      oRowModNew.Item("NDEPDOUANE") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPDOUANE"))
      oRowModNew.Item("NDEPHRMPT") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPHRMPT"))
      oRowModNew.Item("NDEPHRINT") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPHRINT"))
      oRowModNew.Item("NDEPKMS") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPKMS"))
      oRowModNew.Item("NDEPSTOCK") = Aggregate RowModel In RowsTop Into Average(RowModel.Field(Of Decimal)("NDEPSTOCK"))
      oRowModNew.Item("LINEMODELE") = 0

      dtAnaDepModele.Rows.Add(oRowModNew)

      GCANADEPMODELE.DataSource = dtAnaDepModele

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_modèle_sub3 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click

    'affichage auto du max date
    'LoadData(CboMois.SelectedValue, CboAnnee.SelectedValue, ModuleMain.gstrNomSociete)

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub GVDEPANAMODELE_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVDEPANAMODELE.CustomDrawCell

    'seulement la ligne modele type maximum en gras
    If GVDEPANAMODELE.GetDataRow(e.RowHandle).Item("LINEMODELE") = 1 Then

      Dim oFontModele As New Font("Arial", 8, FontStyle.Bold)

      e.Appearance.Font = oFontModele
      'e.Appearance.BackColor = Color.Azure                     

    End If

  End Sub

  Private Sub GVDEPANADETAIL_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GVDEPANADETAIL.ColumnWidthChanged

    Select Case e.Column.FieldName

      Case "NCANNUM", "VCANLIB", "TOTAL"

        GVDEPANAMODELE.Columns.ColumnByFieldName("VLIBELLE").Width = GVDEPANADETAIL.Columns.ColumnByFieldName("NCANNUM").Width _
                                                                        + GVDEPANADETAIL.Columns.ColumnByFieldName("VCANLIB").Width _
                                                                        + GVDEPANADETAIL.Columns.ColumnByFieldName("TOTAL").Width

      Case Else

        GVDEPANAMODELE.Columns.ColumnByFieldName(e.Column.FieldName).Width = e.Column.Width

    End Select

  End Sub

  Private Sub GVDEPANAMODELE_ColumnWidthChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GVDEPANAMODELE.ColumnWidthChanged

    Select Case e.Column.FieldName

      Case "VLIBELLE"

        GVDEPANADETAIL.Columns.ColumnByFieldName("VCANLIB").Width = GVDEPANAMODELE.Columns.ColumnByFieldName("VLIBELLE").Width _
                                                                        - GVDEPANADETAIL.Columns.ColumnByFieldName("NCANNUM").Width _
                                                                        - GVDEPANADETAIL.Columns.ColumnByFieldName("TOTAL").Width

      Case Else

        GVDEPANADETAIL.Columns.ColumnByFieldName(e.Column.FieldName).Width = e.Column.Width

    End Select

  End Sub

  Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

    Try

      If MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_modèle_print_tab, My.Resources.Global_impression_tableau, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        Dim link As New PrintableComponentLink(New PrintingSystem())

        Dim oGCtrl As GridControl
        oGCtrl = GCDEPANADETAIL

        link.Component = oGCtrl
        link.Landscape = True
        link.Margins.Left = 7
        link.Margins.Right = 7
        link.Margins.Top = 7
        link.Margins.Bottom = 7

        link.CreateDocument()

        'link.PrintingSystem.Document.AutoFitToPagesWidth = 1  

        link.PrintDlg()

      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_sub4 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportXLS.Click

    Try

      If MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_excel, My.Resources.Global_impression_tab_excel, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        SFD.Filter = "Fichiers EXCEL (*.xls)|*.xls"
        SFD.ShowDialog()

        If SFD.FileName <> "" Then

          Dim link As New PrintableComponentLink(New PrintingSystem())

          Dim oGCtrl As GridControl
          oGCtrl = GCDEPANADETAIL

          link.Component = oGCtrl
          link.Landscape = True
          link.Margins.Left = 7
          link.Margins.Right = 7
          link.Margins.Top = 7
          link.Margins.Bottom = 7

          link.CreateDocument()

          link.ExportToXls(SFD.FileName)

        End If



      End If

    Catch ex As Exception

      MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_sub5 + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

  Private Sub BtnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportPDF.Click

    Try

      If MessageBox.Show(My.Resources.TabSyntheseCompta_frmdepensesanalytique_pdf, My.Resources.Global_impression_tab_pdf, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

        SFD.Filter = "Fichiers PDF (*.pdf)|*.pdf"
        SFD.ShowDialog()

        If SFD.FileName <> "" Then

          Dim link As New PrintableComponentLink(New PrintingSystem())

          Dim oGCtrl As GridControl
          oGCtrl = GCDEPANADETAIL

          link.Component = oGCtrl
          link.Landscape = True
          link.Margins.Left = 7
          link.Margins.Right = 7
          link.Margins.Top = 7
          link.Margins.Bottom = 7

          link.CreateDocument()

          link.ExportToPdf(SFD.FileName)

        End If

      End If

    Catch ex As Exception

      MessageBox.Show("Sub BtnPrint_Click dans FrmDepensesAnalytique : " + ex.Message, My.Resources.Global_Erreur)

    End Try

  End Sub

End Class