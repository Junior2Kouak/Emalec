Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports MozartLib

Public Class frmDetailsCaseWithDetail

  Dim pMousePosition As Point

  Dim sType As String
  Dim daCur As New SqlDataAdapter
  Dim dtCur As New DataTable
  Dim DsCur As DataSet

  Dim iNIDCHANTIER As Int32

  Public Sub New(ByVal c_sType As String, ByVal c_NIDCHANTIER As Int32, ByVal c_oPosMouse As Point)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().        
    sType = c_sType
    pMousePosition = c_oPosMouse
    iNIDCHANTIER = c_NIDCHANTIER

  End Sub

  Private Sub frmDetailsCaseWithDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    ' on recherche les infos en fonction du case d'affichage         
    Dim oPosInit As New Point((pMousePosition.X - Me.Size.Width / 2), (pMousePosition.Y - Me.Size.Height / 2))

    If oPosInit.Y < 0 Or oPosInit.X < 0 Then

      oPosInit.X = pMousePosition.X
      oPosInit.Y = pMousePosition.Y

    End If

    Me.Location = oPosInit

    Dim cmd As New SqlCommand("api_sp_ChantierDetailsInfo " & iNIDCHANTIER & ",'" & sType & "'", MozartDatabase.cnxMozart)
    daCur.SelectCommand = cmd
    daCur.Fill(dtCur)

    'parametrage selon le type
    Select Case sType
      Case "RFOUCDE"

        'init
        'nom des colonnes
        GColVSTFNOM.Caption = My.Resources.Global_Fournisseur
        GColDetlNUMERO.FieldName = "NCOMNUM"
        GColDetlNUMERO.Caption = My.Resources.Global_numCommande
        GColDetlNUMERO.DisplayFormat.FormatString = "CF {0}"
        GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        LoadTableauSTF()

      Case "RINTERIM"

        'init
        'nom des colonnes
        GColVSTFNOM.Caption = My.Resources.Global_Fournisseur
        GColDetlNUMERO.FieldName = "VIDNUM"
        GColDetlNUMERO.Caption = "N°"
        GColDetlNUMERO.DisplayFormat.FormatString = "{0}"
        GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        LoadTableauSTF()

      Case "RSTT"

        GColVSTFNOM.Caption = My.Resources.Global_sousTraitant
        GColDetlNUMERO.Caption = My.Resources.Global_NumContrat
        GColDetlNUMERO.FieldName = "NCSTNUM"
        GColDetlNUMERO.DisplayFormat.FormatString = "CS {0}"
        GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        LoadTableauSTF()

      Case "RFOUSS"

        GColVSTFNOM.Caption = My.Resources.Global_FicheLibellé
        GColDetlNUMERO.Caption = My.Resources.Global_NumSortieStok
        GColDetlNUMERO.FieldName = "NDDENUM"
        GColDetlNUMERO.DisplayFormat.FormatString = "DDE {0}"
        GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        'on rend invisible la colonne facturé
        GColNVALFACSUM.Visible = False
        GColDetlNVALFAC.Visible = False

        'change fieldname
        GColVSTFNOM.FieldName = "VLIB"

        LoadTableauDDE()

      Case "RFOU"

        GColVSTFNOM.Caption = My.Resources.Global_FicheLibellé
        GColDetlNUMERO.Caption = "N°"
        GColDetlNUMERO.FieldName = "NIDNUM"
        GColDetlNUMERO.DisplayFormat.FormatString = "{0}"
        GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        'on rend invisible la colonne facturé
        GColNVALFACSUM.Visible = False
        GColDetlNVALFAC.Visible = False

        'change fieldname
        GColVSTFNOM.FieldName = "VLIB"

        LoadTableauFO()

      Case "PRORATA"

        GColVSTFNOM.Caption = My.Resources.Global_FicheLibellé
        GColDetlNUMERO.Caption = "N°"
        GColDetlNUMERO.FieldName = "NIDNUM"
        GColDetlNUMERO.DisplayFormat.FormatString = "{0}"
        GColDetlNUMERO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom

        'on rend invisible la colonne facturé
        GColNVALFACSUM.Visible = False
        GColDetlNVALFAC.Visible = False

        'change fieldname
        GColVSTFNOM.FieldName = "VLIB"

        LoadTableauFO()

    End Select

  End Sub

  Private Sub LoadTableauSTF()

    '--remplissage grille
    Dim req = From RowSum In dtCur.AsEnumerable
              Group RowSum By NSTFNUM = RowSum.Field(Of Int32)("NSTFNUM"), VSTFNOM = RowSum.Field(Of String)("VSTFNOM") Into TotalEngage = Sum((RowSum.Field(Of Decimal)("NVALENGAGE"))), TotalFac = Sum((RowSum.Field(Of Decimal)("NVALFAC")))
              Order By VSTFNOM
              Select New With {
                              Key NSTFNUM,
                              Key VSTFNOM,
                              .NVALENGAGESUM = TotalEngage,
                              .NVALFACSUM = TotalFac
                              }

    'relation entre les  grid
    GCDetailCase.LevelTree.Nodes(0).RelationName = "NSTFNUM"
    GVDetail.ChildGridLevelName = "NSTFNUM"

    DsCur = New DataSet

    Dim dr1 As New DataTable

    Dim keyColumn(1) As DataColumn

    dr1.Columns.Add("NSTFNUM", Type.GetType("System.Int32"))
    dr1.Columns.Add("VSTFNOM", Type.GetType("System.String"))
    dr1.Columns.Add("NVALENGAGESUM", Type.GetType("System.Decimal"))
    dr1.Columns.Add("NVALFACSUM", Type.GetType("System.Decimal"))

    keyColumn(0) = dr1.Columns("NSTFNUM")
    dr1.PrimaryKey = keyColumn

    For Each row In req

      Dim rownew As DataRow = dr1.NewRow

      rownew.Item("NSTFNUM") = row.NSTFNUM
      rownew.Item("VSTFNOM") = row.VSTFNOM
      rownew.Item("NVALENGAGESUM") = row.NVALENGAGESUM
      rownew.Item("NVALFACSUM") = row.NVALFACSUM

      dr1.Rows.Add(rownew)

    Next

    DsCur.Tables.Add(dr1)

    DsCur.Tables.Add(dtCur)

    DsCur.Relations.Add("NSTFNUM", DsCur.Tables(0).Columns("NSTFNUM"), DsCur.Tables(1).Columns("NSTFNUM"))

    GCDetailCase.DataSource = DsCur.Tables(0)

  End Sub

  Private Sub LoadTableauDDE()

    '--remplissage grille
    Dim req = From RowSum In dtCur.AsEnumerable
              Group RowSum By VLIB = RowSum.Field(Of String)("VLIB") Into TotalEngage = Sum((RowSum.Field(Of Decimal)("NVALENGAGE")))
              Order By VLIB
              Select New With {
                              Key VLIB,
                              .NVALENGAGESUM = TotalEngage
                              }

    'relation entre les  grid
    GCDetailCase.LevelTree.Nodes(0).RelationName = "VLIB"

    DsCur = New DataSet

    Dim dr1 As New DataTable

    dr1.Columns.Add("VLIB", Type.GetType("System.String"))
    dr1.Columns.Add("NVALENGAGESUM", Type.GetType("System.Decimal"))

    For Each row In req

      Dim rownew As DataRow = dr1.NewRow

      rownew.Item("VLIB") = row.VLIB
      rownew.Item("NVALENGAGESUM") = row.NVALENGAGESUM

      dr1.Rows.Add(rownew)

    Next

    DsCur.Tables.Add(dr1)

    DsCur.Tables.Add(dtCur)

    DsCur.Relations.Add("VLIB", DsCur.Tables(0).Columns("VLIB"), DsCur.Tables(1).Columns("VLIB"))

    GCDetailCase.DataSource = DsCur.Tables(0)

  End Sub

  Private Sub LoadTableauFO()

    '--remplissage grille
    Dim req = From RowSum In dtCur.AsEnumerable
              Group RowSum By VLIB = RowSum.Field(Of String)("VLIB") Into TotalEngage = Sum((RowSum.Field(Of Decimal)("NVALENGAGE")))
              Order By VLIB
              Select New With {
                              Key VLIB,
                              .NVALENGAGESUM = TotalEngage
                              }

    'relation entre les  grid
    GCDetailCase.LevelTree.Nodes(0).RelationName = "VLIB"

    DsCur = New DataSet

    Dim dr1 As New DataTable

    dr1.Columns.Add("VLIB", Type.GetType("System.String"))
    dr1.Columns.Add("NVALENGAGESUM", Type.GetType("System.Decimal"))

    For Each row In req

      Dim rownew As DataRow = dr1.NewRow

      rownew.Item("VLIB") = row.VLIB
      rownew.Item("NVALENGAGESUM") = row.NVALENGAGESUM

      dr1.Rows.Add(rownew)

    Next

    DsCur.Tables.Add(dr1)

    DsCur.Tables.Add(dtCur)

    DsCur.Relations.Add("VLIB", DsCur.Tables(0).Columns("VLIB"), DsCur.Tables(1).Columns("VLIB"))

    GCDetailCase.DataSource = DsCur.Tables(0)

  End Sub

  Private Sub GVDetail_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GVDetail.RowCellClick

    If e.Column.Name = "GColDetlNUMERO" Then

      Dim gc As GridView = CType(sender, GridView)
      Dim view As ColumnView = CType(gc, ColumnView)
      Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)

      If Not row Is Nothing Then

        If (row.Item("NDINNUM").ToString <> "" And row.Item("NACTNUM").ToString <> "") Then
          Shell(MozartParams.CheminProgrammeMozart & "SynchroMozart.exe " & MozartParams.NomServeur & ";" & MozartParams.NomSociete & ";" & row.Item("NDINNUM") & ";" & row.Item("NACTNUM"), vbMaximizedFocus)
        End If

      End If

    End If

  End Sub

End Class