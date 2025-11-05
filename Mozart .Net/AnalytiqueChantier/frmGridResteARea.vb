Imports System.Data.SqlClient
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports MozartControls
Imports MozartLib
Imports MZUtils = MozartControls.Utils

Public Class frmGridResteARea

  Private sType As String
  Dim daData As SqlDataAdapter
  Dim dtData As DataTable
  Dim dtDataDetail As DataTable
  Dim cmdGrid As SqlCommand
  Dim DsGridResteARea As DataSet

  Dim iNIDCHANTIER As Integer
  Dim bReadOnly As Boolean

  Public Property SumNbAReste As Integer

  Private CustomTotalREALISE As Integer
  Private CustomTotalReste_A_REALISE As Integer
  Private CustomTotalTOT As Integer

  Public Sub New(ByVal c_sType As String, ByVal c_NIDCHANTIER As Integer, ByVal c_bReadOnly As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sType = c_sType
    iNIDCHANTIER = c_NIDCHANTIER
    bReadOnly = c_bReadOnly
    CustomTotalREALISE = 0
    CustomTotalTOT = 0
    CustomTotalReste_A_REALISE = 0

  End Sub

  Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
    Close()
  End Sub

  Private Sub frmGridResteARea_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    GVResteARea.UpdateTotalSummary()

    GVResteARea.Columns("NVALREA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
    SumNbAReste = GVResteARea.Columns("NVALREA").SummaryItem.SummaryValue + GVResteARea.Columns("NVALAJUSTE").SummaryItem.SummaryValue
  End Sub

  Private Sub initGridMO(pWindowText As String, pSqlCommand As String)
    GVResteARea.Columns("NVAL").Caption = My.Resources.Admin_frmGridResteARea_Chiffrageh
    GVResteARea.Columns("NVAL").SummaryItem.DisplayFormat = "{0:n0}"
    GVResteARea.Columns("NREAH").Caption = My.Resources.Admin_frmGridResteARea_Engagéh
    GVResteARea.Columns("NREAH").SummaryItem.DisplayFormat = "{0:n0}"
    GVResteARea.Columns("NVALREA").Caption = My.Resources.Admin_frmGridResteARea_ResteAEngagerh
    GVResteARea.Columns("NVALREA").SummaryItem.DisplayFormat = "{0:n0}"
    GVResteARea.Columns("TOT").Caption = My.Resources.Admin_frmGridResteARea_Totalh
    GVResteARea.Columns("TOT").SummaryItem.DisplayFormat = "{0:n0}"
    GVResteARea.Columns("DIF").Caption = My.Resources.Admin_frmGridResteARea_Differenceh
    GVResteARea.Columns("DIF").SummaryItem.DisplayFormat = "{0:n0}"
    GVResteARea.Columns("POURC").Caption = "%"

    GVResteARea.Columns("NVAL").DisplayFormat.FormatType = FormatType.Numeric
    GVResteARea.Columns("NVAL").DisplayFormat.FormatString = "0"

    GVResteARea.Columns("NREAH").DisplayFormat.FormatType = FormatType.Numeric
    GVResteARea.Columns("NREAH").DisplayFormat.FormatString = "0"

    GVResteARea.Columns("NVALREA").DisplayFormat.FormatType = FormatType.Numeric
    GVResteARea.Columns("NVALREA").DisplayFormat.FormatString = "0"

    GVResteARea.Columns("TOT").DisplayFormat.FormatType = FormatType.Numeric
    GVResteARea.Columns("TOT").DisplayFormat.FormatString = "0"

    GVResteARea.Columns("DIF").DisplayFormat.FormatType = FormatType.Numeric
    GVResteARea.Columns("DIF").DisplayFormat.FormatString = "0"

    GVResteARea.Columns("POURC").DisplayFormat.FormatType = FormatType.Numeric
    GVResteARea.Columns("POURC").DisplayFormat.FormatString = "p0"

    ColNVALAJUSTE.Visible = False
    ColNVALAJUSTE.DisplayFormat.FormatType = FormatType.Numeric
    ColNVALAJUSTE.DisplayFormat.FormatString = "0"

    GColDetail_NDETAILNUM.Caption = ""
    GColDetail_NDETAILNUM.Visible = False

    Text = pWindowText
    cmdGrid = New SqlCommand(pSqlCommand, MozartDatabase.cnxMozart)
  End Sub

  Private Sub initGridForMOProductive(pWindowText As String, pSqlCommand As String)
    ' Comportement différent si MO par rapport au reste
    AddHandler GVResteARea.RowCellClick, AddressOf GVResteARea_RowCellClick
    AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChangedCommentAndNValAjuste
    GVResteARea.Columns("NVALREA").OptionsColumn.AllowEdit = False
    GVResteARea.Columns("NVALREA").OptionsColumn.ReadOnly = True

    initGridMO(pWindowText, pSqlCommand)
  End Sub

  Private Sub initGridForMOOthers(pWindowText As String, pSqlCommand As String)
    ' Comportement différent si MO par rapport au reste
    AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChanged
    AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChangedCommentAndNValAjuste
    GVResteARea.Columns("NVALREA").OptionsColumn.AllowEdit = True
    GVResteARea.Columns("NVALREA").OptionsColumn.ReadOnly = False

    initGridMO(pWindowText, pSqlCommand)
  End Sub

  Private Sub frmGridResteARea_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    Try
      Select Case sType.ToUpper
        Case AnalytiqueChantierCst.TYPE_MO
          initGridForMOProductive("Heures techniciens (sauf mécaniciens, cableurs et aide technique)", $"[api_sp_ChantierInfoMOSaisie2] {iNIDCHANTIER}")

        Case AnalytiqueChantierCst.TYPE_MO_MECA
          initGridForMOProductive("Heures techniciens mécaniciens", "[api_sp_ChantierInfoMOSaisie_MECA2] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_CABL
          initGridForMOProductive("Heures techniciens cableurs", "[api_sp_ChantierInfoMOSaisie_CABL2] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_AIDETEC
          initGridForMOProductive("Heures techniciens aide technique", "[api_sp_ChantierInfoMOSaisie_AIDETEC2] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_CHAFF
          initGridForMOOthers("Heures chargé d'affaires", "[api_sp_ChantierInfoMOSaisie_CHAFF] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_BE
          initGridForMOOthers("Heures bureau d'études", "[api_sp_ChantierInfoMOSaisie_BE] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_BE_AUTO
          initGridForMOOthers("Heures bureau d'études automatisme", "[api_sp_ChantierInfoMOSaisie_BE_AUTO] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_BE_ELEC
          initGridForMOOthers("Heures bureau d'études électricité", "[api_sp_ChantierInfoMOSaisie_BE_ELEC] " & iNIDCHANTIER)

        Case AnalytiqueChantierCst.TYPE_MO_BE_MECA
          initGridForMOOthers("Heures bureau d'études mécanique", "[api_sp_ChantierInfoMOSaisie_BE_MECA] " & iNIDCHANTIER)

        Case "FO"
          ' Comportement différent si MO par rapport au reste
          AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChanged
          AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChangedCommentAndNValAjuste
          GVResteARea.Columns("NVALREA").OptionsColumn.AllowEdit = True
          GVResteARea.Columns("NVALREA").OptionsColumn.ReadOnly = False

          GVResteARea.Columns("NVAL").Caption = My.Resources.Admin_frmGridResteARea_Chiffrage
          GVResteARea.Columns("NREAH").Caption = My.Resources.Admin_frmGridResteARea_Engagé
          GVResteARea.Columns("NVALREA").Caption = My.Resources.Admin_frmGridResteARea_ResteAEngager
          GVResteARea.Columns("TOT").Caption = My.Resources.Admin_frmGridResteARea_Total
          GVResteARea.Columns("DIF").Caption = My.Resources.Admin_frmGridResteARea_Difference
          GVResteARea.Columns("POURC").Caption = "%"

          GVResteARea.Columns("NVAL").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("NVAL").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("NREAH").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("NREAH").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("NVALREA").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("NVALREA").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("TOT").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("TOT").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("DIF").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("DIF").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("POURC").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("POURC").DisplayFormat.FormatString = "p0"

          GColDetail_NDETAILNUM.Caption = My.Resources.Admin_frmGridResteARea_NumContratST
          GColDetail_NDETAILNUM.Visible = True

          Text = String.Format(Text, "Fournitures")
          cmdGrid = New SqlCommand("[api_sp_ChantierInfoFOUSaisie] " & iNIDCHANTIER, MozartDatabase.cnxMozart)

        Case "STTSAISIE"
          ' Comportement différent si MO par rapport au reste
          AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChanged
          AddHandler GVResteARea.CellValueChanged, AddressOf GVResteARea_CellValueChangedCommentAndNValAjuste
          GVResteARea.Columns("NVALREA").OptionsColumn.AllowEdit = True
          GVResteARea.Columns("NVALREA").OptionsColumn.ReadOnly = False

          GVResteARea.Columns("NVAL").Caption = My.Resources.Admin_frmGridResteARea_Chiffrage
          GVResteARea.Columns("NREAH").Caption = My.Resources.Admin_frmGridResteARea_Réalisé
          GVResteARea.Columns("NVALREA").Caption = My.Resources.Admin_frmGridResteARea_ResteARéalisé
          GVResteARea.Columns("TOT").Caption = My.Resources.Admin_frmGridResteARea_Total
          GVResteARea.Columns("DIF").Caption = My.Resources.Admin_frmGridResteARea_Difference
          GVResteARea.Columns("POURC").Caption = "%"

          GVResteARea.Columns("NVAL").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("NVAL").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("NREAH").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("NREAH").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("NVALREA").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("NVALREA").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("TOT").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("TOT").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("DIF").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("DIF").DisplayFormat.FormatString = "c0"

          GVResteARea.Columns("POURC").DisplayFormat.FormatType = FormatType.Numeric
          GVResteARea.Columns("POURC").DisplayFormat.FormatString = "p0"

          Text = String.Format(Text, My.Resources.Admin_frmGridResteARea_SousTraitance)
          cmdGrid = New SqlCommand("[api_sp_ChantierInfoSttSaisie] " & iNIDCHANTIER, MozartDatabase.cnxMozart)

        Case Else
          MessageBox.Show(My.Resources.Global_type_nonreconnu, My.Resources.Global_erreur_type, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          Close()

      End Select

      'init de gvdetail
      GColDetail_NREA.Caption = ColNREAH.Caption
      GVDetail.ViewCaption = String.Format(My.Resources.Admin_frmGridResteARea_GVDetail, ColNREAH.Caption)

      cmdGrid.CommandType = CommandType.Text

      'gestion read only
      If bReadOnly Then
        BtnValider.Visible = False
        GVResteARea.OptionsBehavior.Editable = False
        GVResteARea.OptionsBehavior.ReadOnly = True
      Else
        BtnValider.Visible = True
        GVResteARea.OptionsBehavior.Editable = True
        GVResteARea.OptionsBehavior.ReadOnly = False
      End If

      LoadData()

    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try

  End Sub

  Private Sub LoadData()
    DsGridResteARea = New DataSet

    daData = New SqlDataAdapter
    dtData = New DataTable

    daData.SelectCommand = cmdGrid
    daData.Fill(dtData)

    dtData.TableName = "TGRIDRESTEAREA"

    'table des détails
    ' La commande est positionnée dans le Select Case
    Dim sqlcmdTabDet As New SqlCommand("", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
      }

    Select Case sType

      Case AnalytiqueChantierCst.TYPE_MO
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_MECA
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_MECA]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_CABL
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_CABL]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_AIDETEC
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_AIDETEC]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_CHAFF
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_CHAFF]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_BE
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_BE]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_BE_AUTO
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_BE_AUTO]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_BE_ELEC
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_BE_ELEC]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case AnalytiqueChantierCst.TYPE_MO_BE_MECA
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoMOSaisie_DetailDI_BE_MECA]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "H"

      Case "FO"
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoFOUSaisie_DetailDI]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "F"

      Case "STTSAISIE"
        sqlcmdTabDet.CommandText = "[api_sp_ChantierInfoSTTSaisie_DetailDI]"
        sqlcmdTabDet.Parameters.Add("@p_TYPEFICHE", SqlDbType.Char).Value = "S"
    End Select

    ' Paramètre commun à toutes les PS.
    sqlcmdTabDet.Parameters.Add("@p_NIDCHANTIER", SqlDbType.Int).Value = iNIDCHANTIER

    dtDataDetail = New DataTable
    dtDataDetail.Load(sqlcmdTabDet.ExecuteReader)

    dtDataDetail.TableName = "TDETAIL"

    DsGridResteARea.Tables.Add(dtData)
    DsGridResteARea.Tables.Add(dtDataDetail)

    'crete relation
    Dim parentColumns(0) As DataColumn
    Dim childColumns(0) As DataColumn

    parentColumns(0) = DsGridResteARea.Tables("TGRIDRESTEAREA").Columns("NIDFICHE")
    childColumns(0) = DsGridResteARea.Tables("TDETAIL").Columns("NIDFICHE")

    ' Create DataRelation.
    Dim CustOrderRel As DataRelation = New DataRelation("DetailDI", parentColumns, childColumns)

    ' Add the relation to the DataSet.
    DsGridResteARea.Relations.Add(CustOrderRel)

    'relation entre les  grid
    GCResteARea.LevelTree.Nodes(0).RelationName = "DetailDI"

    GCResteARea.DataSource = DsGridResteARea.Tables(0)

    GCResteARea.MainView = GVResteARea
    GCResteARea.LevelTree.Nodes(0).LevelTemplate = GVDetail
  End Sub

  Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
    Dim iPos As Integer

    iPos = GVResteARea.FocusedRowHandle

    LoadData()

    GVResteARea.FocusedRowHandle = iPos
  End Sub

  '*******************************************************************************************************************************************************
  'Calcul du pourcentage
  '*******************************************************************************************************************************************************
  Private Sub GVResteARea_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles GVResteARea.CustomSummaryCalculate
    If e.IsTotalSummary Then

      'REALISE
      If (CType(e.Item, GridSummaryItem)).FieldName = "NREAH" Then

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
          CustomTotalREALISE = 0
        End If

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then

          Dim val? As Decimal = CType(e.FieldValue, Decimal?)

          If (val.HasValue) And IsDBNull(e.GetValue("NIDANACHAFICTYPE")) Then
            CustomTotalREALISE += val.Value
            'mis en com le 24/03/2020
          ElseIf (val.HasValue) And (Not IsDBNull(e.GetValue("NIDANACHAFICTYPE"))) Then
            CustomTotalREALISE += val.Value
          End If
          e.TotalValue = CustomTotalREALISE

        End If

      End If

      'RESTE A REALISE
      If (CType(e.Item, GridSummaryItem)).FieldName = "NVALREA" Then

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
          CustomTotalReste_A_REALISE = 0
        End If

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then

          Dim val? As Integer = CType(e.FieldValue, Integer?)

          If (val.HasValue) And IsDBNull(e.GetValue("NIDANACHAFICTYPE")) Then
            CustomTotalReste_A_REALISE += val.Value
          ElseIf (val.HasValue) And (Not IsDBNull(e.GetValue("NIDANACHAFICTYPE"))) Then
            CustomTotalReste_A_REALISE += val.Value
          End If
          e.TotalValue = CustomTotalReste_A_REALISE

        End If

      End If

      'TOTAL
      If (CType(e.Item, GridSummaryItem)).FieldName = "TOT" Then

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
          CustomTotalTOT = 0
        End If

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then

          Dim val? As Decimal = CType(e.FieldValue, Decimal?)

          If (val.HasValue) And IsDBNull(e.GetValue("NIDANACHAFICTYPE")) Then
            CustomTotalTOT += val.Value
          ElseIf (val.HasValue) And (Not IsDBNull(e.GetValue("NIDANACHAFICTYPE"))) Then
            CustomTotalTOT += val.Value
          End If
          e.TotalValue = CustomTotalTOT

        End If

      End If

      'DIF
      If (CType(e.Item, GridSummaryItem)).FieldName = "DIF" Then

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
          CustomTotalTOT = 0
        End If

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then

          Dim val? As Decimal = CType(e.FieldValue, Decimal?)

          If (val.HasValue) And IsDBNull(e.GetValue("NIDANACHAFICTYPE")) Then
            CustomTotalTOT += val.Value
          ElseIf (val.HasValue) And (Not IsDBNull(e.GetValue("NIDANACHAFICTYPE"))) Then
            CustomTotalTOT += val.Value
          End If
          e.TotalValue = CustomTotalTOT

        End If

      End If

      'POURC
      If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

        Dim otest As GridSummaryItem = TryCast(e.Item, GridSummaryItem)

        If otest.FieldName = "POURC" Then

          If ColTOT.SummaryItem.SummaryValue <> 0 Then

            e.TotalValue = String.Format("{0:p0}", If(ColNVAL.SummaryItem.SummaryValue = 0, 0, ColDIF.SummaryItem.SummaryValue / ColNVAL.SummaryItem.SummaryValue))
            e.TotalValueReady = True

          Else

            e.TotalValue = 0
            e.TotalValueReady = True

          End If

        End If

      End If

    End If

  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    SDF.FileName = ""
    SDF.Filter = "Fichiers EXCEL (*.xlsx)|*.xlsx"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      GVResteARea.OptionsPrint.ExpandAllDetails = True
      GVResteARea.OptionsPrint.PrintDetails = True
      Dim opt As New XlsxExportOptionsEx With {
        .ExportType = DevExpress.Export.ExportType.WYSIWYG
      }
      GVResteARea.ExportToXlsx(SDF.FileName, opt)

    End If

  End Sub

  Private Sub BtnExportPDF_Click(sender As Object, e As EventArgs) Handles BtnExportPDF.Click

    SDF.FileName = ""
    SDF.Filter = "Fichiers PDF (*.pdf)|*.PDF"
    SDF.ShowDialog()

    If SDF.FileName <> "" Then

      Dim View As GridView = CType(GCResteARea.MainView, GridView)
      If Not View Is Nothing Then
        View.OptionsPrint.ExpandAllDetails = True
        View.OptionsPrint.PrintDetails = True
        View.ExportToPdf(SDF.FileName)
      End If

    End If

  End Sub

  Private Function CreateExportPDF(ByVal OGCTRL As GridControl, ByVal sFileName As String) As String

    Try

      Dim ps As New PrintingSystemBase

      Dim Link As New PrintableComponentLinkBase(ps) With {
        .Component = OGCTRL
      }
      Link.Margins.Bottom = 39
      Link.Margins.Left = 59
      Link.Margins.Top = 31
      Link.Margins.Right = 40
      Link.Landscape = True

      Link.CreateDocument()

      Link.PrintingSystemBase.ExportToPdf(sFileName)

      Return sFileName

    Catch ex As Exception

      MessageBox.Show(ex.Message)
      Return ""

    End Try

  End Function

  Private Sub GVDetail_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GVDetail.RowCellClick

    If e.Column.FieldName = "VDINACT" Then

      Dim gc As GridView = CType(sender, GridView)
      Dim view As ColumnView = CType(gc, ColumnView)
      Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)

      If row IsNot Nothing Then

        If (row.Item("NDINNUM").ToString <> "" And row.Item("NACTNUM").ToString <> "") Then
          Shell(MozartParams.CheminProgrammeMozart & "SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & row.Item("NDINNUM") & ";" & row.Item("NACTNUM"), vbMaximizedFocus)
        End If

      End If

    End If
  End Sub

  Private Sub GVResteARea_ShownEditor(sender As Object, e As EventArgs) Handles GVResteARea.ShownEditor
    Dim GridView2 As GridView = sender

    If (GridView2.ActiveEditor.ToolTipController IsNot Nothing) Then
      AddHandler GridView2.ActiveEditor.ToolTipController.GetActiveObjectInfo, AddressOf ToolTipController_GetActiveObjectInfo
    End If
  End Sub


  Private Sub ToolTipController_GetActiveObjectInfo(sender As Object, e As ToolTipControllerGetActiveObjectInfoEventArgs)

    If e.SelectedControl IsNot GCResteARea Then Return

    'Get the view at the current mouse position 
    Dim view As GridView = GCResteARea.GetViewAt(e.ControlMousePosition)
    If view Is Nothing Then Return

    'Get the view's element information that resides at the current position 
    Dim hi As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)
    Dim Text As String

    If hi.InRowCell = True AndAlso hi.HitTest = GridHitTest.RowCell AndAlso hi.Column.FieldName = "NVALAJUSTE" Then
      Text = "Enregistrer dans la cellule le montant des avoirs à recevoir " & vbCrLf & "ou les écarts entre le montant commandé et le total facturé"
    Else
      Text = ""
    End If

    If Text <> "" Then
      Dim info As New ToolTipControlInfo(GCResteARea, Text)
      e.Info = info
    End If

  End Sub

  Private Sub GVResteARea_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
    Dim oDataRow As DataRow = GVResteARea.GetDataRow(e.RowHandle)

    Select Case e.Column.Name
      Case GVResteARea.Columns("NVALREA").Name
        If oDataRow.Item("NVALREA").ToString <> "" AndAlso IsNumeric(oDataRow.Item("NVALREA").ToString) = True Then
          Dim cmd As New SqlCommand("UPDATE TCHANTIERFICHE SET NVALREA = " & oDataRow.Item("NVALREA").ToString & " WHERE NIDFICHE = " & oDataRow.Item("NIDFICHE").ToString, MozartDatabase.cnxMozart)
          cmd.ExecuteNonQuery()
        End If

      Case Else

    End Select
  End Sub

  Private Sub GVResteARea_CellValueChangedCommentAndNValAjuste(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
    Dim oDataRow As DataRow = GVResteARea.GetDataRow(e.RowHandle)

    Select Case e.Column.Name

      Case GVResteARea.Columns("VCOMMENTAIRE").Name
        Dim cmd As New SqlCommand("UPDATE TCHANTIERFICHE SET VCOMMENTAIRE = '" & oDataRow.Item("VCOMMENTAIRE").ToString & "' WHERE NIDFICHE = " & oDataRow.Item("NIDFICHE").ToString, MozartDatabase.cnxMozart)
        cmd.ExecuteNonQuery()

      Case GVResteARea.Columns("NVALAJUSTE").Name
        Dim cmd As New SqlCommand("UPDATE TCHANTIERFICHE SET NVALAJUSTE = '" & oDataRow.Item("NVALAJUSTE").ToString & "' WHERE NIDFICHE = " & oDataRow.Item("NIDFICHE").ToString, MozartDatabase.cnxMozart)
        cmd.ExecuteNonQuery()

      Case Else

    End Select
  End Sub

  Private Sub GVResteARea_RowCellClick(sender As Object, e As RowCellClickEventArgs)
    If e.Column.FieldName <> "NVALREA" Then Exit Sub

    Dim idFiche As Integer = GVResteARea.GetRowCellValue(e.RowHandle, "NIDFICHE")
    If idFiche = -1 Then Exit Sub

    Dim lDifferentsTypesAvailable As String() = New String() {
      AnalytiqueChantierCst.TYPE_MO,
      AnalytiqueChantierCst.TYPE_MO_MECA,
      AnalytiqueChantierCst.TYPE_MO_CABL,
      AnalytiqueChantierCst.TYPE_MO_AIDETEC
    }

    Dim iChiffrage As Integer

    Try
      iChiffrage = GVResteARea.GetRowCellValue(e.RowHandle, "NVAL")
    Catch ex As Exception
      iChiffrage = 0
    End Try

    If lDifferentsTypesAvailable.Contains(sType) Then
      Dim lDetailsPlanDeCharge As New frmDetailsPlanDeCharge(iNIDCHANTIER, idFiche, sType, iChiffrage)
      lDetailsPlanDeCharge.ShowDialog()

      LoadData()

      GVResteARea.SelectRow(e.RowHandle)
      GVResteARea.FocusedRowHandle = e.RowHandle

    End If
  End Sub
End Class