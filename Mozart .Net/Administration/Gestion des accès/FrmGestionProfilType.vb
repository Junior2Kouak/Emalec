Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTreeList
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors
Imports MozartLib

Public Class FrmGestionProfilType

  Dim _DtListeMenuDroit As DataTable

  Dim ListButtonFooter As New List(Of Button)

  Private Sub FrmGestionProfilType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    GCTypeProfilGroupe.DataSource = LoadListeTypePer()

  End Sub

  Private Function LoadListeTypePer() As DataTable

    Try

      Dim _dtListTypePer As New DataTable

      Dim sqlcmdLstQCM As New SqlCommand("[api_sp_ProfilTypeListe]", MozartDatabase.cnxMozart)
      sqlcmdLstQCM.CommandType = CommandType.StoredProcedure

      _dtListTypePer.Load(sqlcmdLstQCM.ExecuteReader)

      Return _dtListTypePer

    Catch ex As Exception

      MessageBox.Show("CREF_PROFIL -> LoadListeTypePer : " + ex.Message)
      Return Nothing

    End Try

  End Function

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub GVTypeProfilGroupe_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVTypeProfilGroupe.FocusedRowChanged

    If GVTypeProfilGroupe.FocusedRowHandle > -1 Then

      Label2.Text = "Liste des menus du profil " & GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle).Item("VTYPELIB") & " - " & GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle).Item("VTYPEDETAILLIB")

      RefreshDataDroitMenu()

    End If

  End Sub
  Private Sub RefreshDataDroitMenu()

    'init
    For Each BtnExists As Button In ListButtonFooter
      Me.Controls.Remove(BtnExists)
    Next
    ListButtonFooter.Clear()

    Select Case MozartParams.NomSociete
      Case "EMALEC"
        TreeCol_CDROIT_EMALEC.VisibleIndex = 1
      Case "EMAFI"
        TreeCol_CDROIT_EMAFI.VisibleIndex = 1
      Case "ALC"
        TreeCol_CDROIT_ALC.VisibleIndex = 1
      Case "EQUIPAGE"
        TreeCol_CDROIT_EQUIPAGE.VisibleIndex = 1
      Case "SCS"
        TreeCol_CDROIT_SCS.VisibleIndex = 1
      Case "MAGESTIME"
        TreeCol_CDROIT_MAGESTIME.VisibleIndex = 1
      Case "EMALECBELGIQUE"
        TreeCol_CDROIT_BELGIQUE.VisibleIndex = 1
      Case "EMALECESPAGNE"
        TreeCol_CDROIT_EMALECESPAGNE.VisibleIndex = 1
      Case "EMALECIDF"
        TreeCol_CDROIT_IDF.VisibleIndex = 1
      Case "EMALECFACILITEAM"
        TreeCol_CDROIT_EMALECFACILITEAM.VisibleIndex = 1
      Case "EMALECLUXEMBOURG"
        TreeCol_CDROIT_EMALECLUXEMBOURG.VisibleIndex = 1
      Case "EMALECSUISSE"
        TreeCol_CDROIT_EMALECSUISSE.VisibleIndex = 1
      Case "EMALECMPM"
        TreeCol_CDROIT_EMALECMPM.VisibleIndex = 1
      Case "EMALECDEV"
        TreeCol_CDROIT_DEV.VisibleIndex = 1

    End Select

    _DtListeMenuDroit = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListeMenuDroit_By_ProfilType]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_NID_REF_TYPEPERDETAIL", SqlDbType.Int).Value = GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle).Item("ID")
    sqlcmd.Parameters.Add("@p_NSERNUM", SqlDbType.Int).Value = GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle).Item("NSERNUM")
    _DtListeMenuDroit.Load(sqlcmd.ExecuteReader)

    _DtListeMenuDroit.Columns("CDROIT_EMALEC").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMAFI").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_ALC").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_BELGIQUE").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_IDF").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EQUIPAGE").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_MAGESTIME").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMALECESPAGNE").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_SCS").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMALECLUXEMBOURG").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMALECFACILITEAM").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMALECSUISSE").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMALECMPM").ReadOnly = False
    _DtListeMenuDroit.Columns("CDROIT_EMALECDEV").ReadOnly = False

    TreeList_Menu.DataSource = _DtListeMenuDroit

  End Sub

  Private Sub TreeList_Menu_CustomDrawFooterCell(sender As Object, e As CustomDrawFooterCellEventArgs) Handles TreeList_Menu.CustomDrawFooterCell

    'INIT

    If e.Column.FieldName = "CDROIT_EMALEC" Or e.Column.FieldName = "CDROIT_BELGIQUE" Or e.Column.FieldName = "CDROIT_IDF" Or e.Column.FieldName = "CDROIT_EQUIPAGE" Or e.Column.FieldName = "CDROIT_MAGESTIME" _
             Or e.Column.FieldName = "CDROIT_EMALECESPAGNE" Or e.Column.FieldName = "CDROIT_SCS" Or e.Column.FieldName = "CDROIT_EMALECLUXEMBOURG" Or e.Column.FieldName = "CDROIT_EMALECFACILITEAM" _
              Or e.Column.FieldName = "CDROIT_EMALECSUISSE" Or e.Column.FieldName = "CDROIT_EMALECMPM" Or e.Column.FieldName = "CDROIT_EMAFI" Or e.Column.FieldName = "CDROIT_ALC" Or e.Column.FieldName = "CDROIT_EMALECDEV" Then

      If ListButtonFooter.Count > 0 Then


        If ListButtonFooter.Exists(Function(xName) xName.Name = e.Column.FieldName + "_Reinit") = False Then

          Dim BtnReini As New Button

          BtnReini.Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height)
          BtnReini.Size = New Size(e.Column.VisibleWidth, 30)
          BtnReini.Visible = True
          BtnReini.Text = "Réinitialiser"
          BtnReini.Name = e.Column.FieldName + "_Reinit"
          BtnReini.BackColor = Color.LightGray
          BtnReini.Tag = e.Column.GetTextCaption

          AddHandler BtnReini.Click, AddressOf Click_Reinit

          Me.Controls.Add(BtnReini)

          ListButtonFooter.Add(BtnReini)

          Dim BtnDupliq As New Button

          BtnDupliq.Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height + BtnReini.Height)
          BtnDupliq.Size = New Size(e.Column.VisibleWidth, 30)
          BtnDupliq.Visible = True
          BtnDupliq.Text = "Copier vers"
          BtnDupliq.Name = e.Column.FieldName + "_Dupliq"
          BtnDupliq.BackColor = Color.LightGray
          BtnDupliq.Tag = e.Column.GetTextCaption

          AddHandler BtnDupliq.Click, AddressOf Click_Duplicate

          Me.Controls.Add(BtnDupliq)

          ListButtonFooter.Add(BtnDupliq)

        Else

          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Size = New Size(e.Column.VisibleWidth, 30)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Visible = True

          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Location.Y + ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Size.Height)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Size = New Size(e.Column.VisibleWidth, 30)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Visible = True

        End If

      Else

        Dim BtnReini As New Button

        BtnReini.Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height)
        BtnReini.Size = New Size(e.Column.VisibleWidth, 30)
        BtnReini.Visible = True
        BtnReini.Text = "Réinitialiser"
        BtnReini.Name = e.Column.FieldName + "_Reinit"
        BtnReini.BackColor = Color.LightGray
        BtnReini.Tag = e.Column.GetTextCaption

        AddHandler BtnReini.Click, AddressOf Click_Reinit

        Me.Controls.Add(BtnReini)

        ListButtonFooter.Add(BtnReini)

        Dim BtnDupliq As New Button

        BtnDupliq.Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height + BtnReini.Height)
        BtnDupliq.Size = New Size(e.Column.VisibleWidth, 30)
        BtnDupliq.Visible = True
        BtnDupliq.Text = "Copier vers"
        BtnDupliq.Name = e.Column.FieldName + "_Dupliq"
        BtnDupliq.BackColor = Color.LightGray
        BtnDupliq.Tag = e.Column.GetTextCaption

        AddHandler BtnDupliq.Click, AddressOf Click_Duplicate

        Me.Controls.Add(BtnDupliq)

        ListButtonFooter.Add(BtnDupliq)


      End If

      e.Handled = True

    End If

  End Sub

  Private Sub Click_Reinit(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Dim RowHandlePer As Int32 = GVTypeProfilGroupe.FocusedRowHandle

    If RowHandlePer < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVTypeProfilGroupe.GetDataRow(RowHandlePer)

    If MessageBox.Show(String.Format("Voulez-vous vraiment réinitialiser le profil de {0} pour la société {1} ?", drSelectPer.Item("VTYPEDETAILLIB"), sender.Tag), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Select Case sender.name
        Case "CDROIT_EMALEC" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALEC")
        Case "CDROIT_EMAFI" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMAFI")
        Case "CDROIT_ALC" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "ALC")
        Case "CDROIT_BELGIQUE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECBELGIQUE")
        Case "CDROIT_IDF" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECIDF")
        Case "CDROIT_MAGESTIME" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "MAGESTIME")
        Case "CDROIT_EMALECESPAGNE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECESPAGNE")
        Case "CDROIT_SCS" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "SCS")
        Case "CDROIT_EMALECLUXEMBOURG" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECLUXEMBOURG")
        Case "CDROIT_EMALECFACILITEAM" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECFACILITEAM")
        Case "CDROIT_EMALECSUISSE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECSUISSE")
        Case "CDROIT_EQUIPAGE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EQUIPAGE")
        Case "CDROIT_EMALECMPM" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECMPM")
        Case "CDROIT_EMALECDEV" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("ID"), drSelectPer.Item("NSERNUM"), "EMALECDEV")

      End Select

      RefreshDataDroitMenu()

      MessageBox.Show("Réinitialisation effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub ReinitialiserProfil(ByVal P_NID_REF_TYPEPER As Int32, ByVal P_NSERNUM As Int32, ByVal P_VSOCIETE As String)

    Dim sqlcmd As New SqlCommand("[api_sp_ProfilTypeReinit]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_NID_REF_TYPEPERDETAIL", SqlDbType.Int).Value = P_NID_REF_TYPEPER
    sqlcmd.Parameters.Add("@p_NSERNUM", SqlDbType.Int).Value = P_NSERNUM
    sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = P_VSOCIETE
    sqlcmd.ExecuteNonQuery()

  End Sub

  Private Sub Click_Duplicate(ByVal sender As System.Object, ByVal e As System.EventArgs)

    If GVTypeProfilGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectProfil As DataRow = GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle)

    Dim sVSOCIETE_SRC As String = ""

    Select Case sender.name
      Case "CDROIT_EMALEC" + "_Dupliq" : sVSOCIETE_SRC = "EMALEC"
      Case "CDROIT_EMAFI" + "_Dupliq" : sVSOCIETE_SRC = "EMAFI"
      Case "CDROIT_ALC" + "_Dupliq" : sVSOCIETE_SRC = "ALC"
      Case "CDROIT_BELGIQUE" + "_Dupliq" : sVSOCIETE_SRC = "EMALECBELGIQUE"
      Case "CDROIT_IDF" + "_Dupliq" : sVSOCIETE_SRC = "EMALECIDF"
      Case "CDROIT_MAGESTIME" + "_Dupliq" : sVSOCIETE_SRC = "MAGESTIME"
      Case "CDROIT_EMALECESPAGNE" + "_Dupliq" : sVSOCIETE_SRC = "EMALECESPAGNE"
      Case "CDROIT_SCS" + "_Dupliq" : sVSOCIETE_SRC = "SCS"
      Case "CDROIT_EMALECLUXEMBOURG" + "_Dupliq" : sVSOCIETE_SRC = "EMALECLUXEMBOURG"
      Case "CDROIT_EMALECFACILITEAM" + "_Dupliq" : sVSOCIETE_SRC = "EMALECFACILITEAM"
      Case "CDROIT_EMALECSUISSE" + "_Dupliq" : sVSOCIETE_SRC = "EMALECSUISSE"
      Case "CDROIT_EQUIPAGE" + "_Dupliq" : sVSOCIETE_SRC = "EQUIPAGE"
      Case "CDROIT_EMALECMPM" + "_Dupliq" : sVSOCIETE_SRC = "EMALECMPM"
      Case "CDROIT_EMALECDEV" + "_Dupliq" : sVSOCIETE_SRC = "EMALECDEV"

    End Select

    'selection de la société destinatrice
    Dim oFrmSelectFilialesDuplicate As New FrmGestionProfilGroup_Liste_Filiales(drSelectProfil.Item("ID"), drSelectProfil.Item("VTYPEDETAILLIB"), sVSOCIETE_SRC, 0)
    oFrmSelectFilialesDuplicate.ShowDialog()

    If oFrmSelectFilialesDuplicate.Cancel = True Then
      Exit Sub
    End If

    For Each DrFiliale As DataRow In oFrmSelectFilialesDuplicate.DtListeFiliales.Rows

      If DrFiliale.Item("NCOCHE") = 1 Then
        DupliquerProfil(drSelectProfil.Item("ID"), sVSOCIETE_SRC, DrFiliale.Item("VSOCIETE"))
      End If

    Next

    If oFrmSelectFilialesDuplicate.DtListeFiliales.Select("[NCOCHE] = 1").Count > 0 Then

      RefreshDataDroitMenu()
      MessageBox.Show("Duplication effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub DupliquerProfil(ByVal P_NIDPROFIL As String, ByVal p_VSOCIETE_SRC As String, ByVal p_VSOCIETE_DEST As String)

    Dim sqlcmd As New SqlCommand("[api_sp_ProfilTypeCopy]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NID_REF_TYPEPERDETAIL_SRC", SqlDbType.Int).Value = P_NIDPROFIL
    sqlcmd.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = p_VSOCIETE_SRC
    sqlcmd.Parameters.Add("@P_VSOCIETE_DEST", SqlDbType.VarChar).Value = p_VSOCIETE_DEST
    sqlcmd.ExecuteNonQuery()

  End Sub

  Private Sub TreeList_Menu_CustomDrawNodeButton(sender As Object, e As CustomDrawNodeButtonEventArgs) Handles TreeList_Menu.CustomDrawNodeButton
    Dim rect As Rectangle = Rectangle.Inflate(e.Bounds, 0, -2)
    ' painting background
    Dim BackBrush = e.Cache.GetGradientBrush(rect, Color.Blue, Color.LightSkyBlue, LinearGradientMode.ForwardDiagonal)
    e.Cache.FillRectangle(BackBrush, rect)
    ' painting borders
    e.Cache.DrawRectangle(e.Cache.GetPen(Color.LightGray), rect)


    ' determining the character to display
    Dim DisplayCharacter As String = "+"
    If e.Expanded Then DisplayCharacter = "-"
    ' formatting the output character
    Dim OutCharacterFormat = e.Appearance.GetStringFormat()
    OutCharacterFormat.Alignment = StringAlignment.Center
    OutCharacterFormat.LineAlignment = StringAlignment.Center

    ' painting the character
    e.Appearance.FontSizeDelta = -2
    e.Appearance.FontStyleDelta = FontStyle.Bold
    e.Cache.DrawString(DisplayCharacter, e.Appearance.Font,
                          e.Cache.GetSolidBrush(Color.White), rect, OutCharacterFormat)

    ' prohibiting default painting
    e.Handled = True
  End Sub

  Private Sub RepItemChk_CDROIT_CheckStateChanged(sender As Object, e As EventArgs) Handles RepItemChk_CDROIT.CheckStateChanged

    If GVTypeProfilGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle)

    Dim sVSOCIETE_SRC As String = ""

    Select Case TreeList_Menu.FocusedColumn.FieldName
      Case "CDROIT_EMALEC" : sVSOCIETE_SRC = "EMALEC"
      Case "CDROIT_EMAFI" : sVSOCIETE_SRC = "EMAFI"
      Case "CDROIT_ALC" : sVSOCIETE_SRC = "ALC"
      Case "CDROIT_BELGIQUE" : sVSOCIETE_SRC = "EMALECBELGIQUE"
      Case "CDROIT_IDF" : sVSOCIETE_SRC = "EMALECIDF"
      Case "CDROIT_MAGESTIME" : sVSOCIETE_SRC = "MAGESTIME"
      Case "CDROIT_EMALECESPAGNE" : sVSOCIETE_SRC = "EMALECESPAGNE"
      Case "CDROIT_SCS" : sVSOCIETE_SRC = "SCS"
      Case "CDROIT_EMALECLUXEMBOURG" : sVSOCIETE_SRC = "EMALECLUXEMBOURG"
      Case "CDROIT_EMALECFACILITEAM" : sVSOCIETE_SRC = "EMALECFACILITEAM"
      Case "CDROIT_EMALECSUISSE" : sVSOCIETE_SRC = "EMALECSUISSE"
      Case "CDROIT_EQUIPAGE" : sVSOCIETE_SRC = "EQUIPAGE"
      Case "CDROIT_EMALECMPM" : sVSOCIETE_SRC = "EMALECMPM"
      Case "CDROIT_EMALECDEV" : sVSOCIETE_SRC = "EMALECDEV"

    End Select

    If sVSOCIETE_SRC = "" Then Exit Sub

    Dim sql_update As New SqlCommand("[api_sp_ProfilTypeSaveDroit]", MozartDatabase.cnxMozart)
    sql_update.CommandType = CommandType.StoredProcedure
    sql_update.Parameters.Add("@p_NID_REF_TYPEPERDETAIL", SqlDbType.Int).Value = drSelectPer.Item("ID")
    sql_update.Parameters.Add("@p_NSERNUM", SqlDbType.Int).Value = drSelectPer.Item("NSERNUM")
    sql_update.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = TreeList_Menu.FocusedNode.Item("NMENUNUM")
    sql_update.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = sVSOCIETE_SRC
    sql_update.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = (CType(sender, CheckEdit)).EditValue.ToString

    sql_update.ExecuteNonQuery()

  End Sub

  Private Sub TreeList_Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles TreeList_Menu.MouseDown

    'If e.Button = MouseButtons.Right Then

    '    Dim hitInfo As TreeListHitInfo = (TryCast(sender, TreeList)).CalcHitInfo(e.Location)

    '    If GVTypeProfilGroupe.FocusedRowHandle < 0 Then Exit Sub

    '    Dim drSelectPer As DataRow = GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle)

    '    Console.WriteLine(hitInfo.Column.FieldName)

    '    Dim sVSOCIETE_SRC As String = ""

    '    Select Case hitInfo.Column.FieldName
    '        Case "CDROIT_EMALEC" : sVSOCIETE_SRC = "EMALEC"
    '        Case "CDROIT_FITELEC" : sVSOCIETE_SRC = "FITELEC"
    '        Case "CDROIT_ALC" : sVSOCIETE_SRC = "ALC"
    '        Case "CDROIT_BELGIQUE" : sVSOCIETE_SRC = "EMALECBELGIQUE"
    '        Case "CDROIT_IDF" : sVSOCIETE_SRC = "EMALECIDF"
    '        Case "CDROIT_MAGESTIME" : sVSOCIETE_SRC = "MAGESTIME"
    '        Case "CDROIT_EMALECESPAGNE" : sVSOCIETE_SRC = "EMALECESPAGNE"
    '        Case "CDROIT_SCS" : sVSOCIETE_SRC = "SCS"
    '        Case "CDROIT_EMALECLUXEMBOURG" : sVSOCIETE_SRC = "EMALECLUXEMBOURG"
    '        Case "CDROIT_EMALECFACILITEAM" : sVSOCIETE_SRC = "EMALECFACILITEAM"
    '        Case "CDROIT_EMALECSUISSE" : sVSOCIETE_SRC = "EMALECSUISSE"
    '        Case "CDROIT_EQUIPAGE" : sVSOCIETE_SRC = "EQUIPAGE"
    '        Case "CDROIT_EMALECMPM" : sVSOCIETE_SRC = "EMALECMPM"
    '        Case "CDROIT_EMALECDEV" : sVSOCIETE_SRC = "EMALECDEV"
    '    End Select

    '    If sVSOCIETE_SRC = "" Then Exit Sub

    '    Dim oFrmSelectSoc As New FrmGestionAccessGroup_Liste_Filiales(drSelectPer.Item("NPERNUM"), drSelectPer.Item("VPERADSI"), sVSOCIETE_SRC, 2, TreeList_Menu.FocusedNode.Item("NMENUNUM"))
    '    oFrmSelectSoc.ShowDialog()

    '    For Each drSoc As DataRow In oFrmSelectSoc.DtListeFiliales.Rows

    '        Dim sql_update As New SqlCommand("[api_sp_SetDroitMozartOnMenuMultiSoc]", cnx)
    '        sql_update.CommandType = CommandType.StoredProcedure
    '        sql_update.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = drSelectPer.Item("NPERNUM")
    '        sql_update.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = TreeList_Menu.FocusedNode.Item("NMENUNUM")
    '        sql_update.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = drSelectPer.Item("VPERADSI")
    '        sql_update.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = drSoc.Item("VSOCIETE")
    '        sql_update.Parameters.Add("@P_CDROITVAL", SqlDbType.Char).Value = If(drSoc.Item("NCOCHE") = 1, "O", "N")

    '        sql_update.ExecuteNonQuery()

    '    Next

    'End If

  End Sub

  Private Sub BtnCopyProfil_Click(sender As Object, e As EventArgs) Handles BtnCopyProfil.Click

    If GVTypeProfilGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectProfil As DataRow = GVTypeProfilGroupe.GetDataRow(GVTypeProfilGroupe.FocusedRowHandle)

    Dim sVSOCIETE_SRC As String = ""

    Select Case sender.name
      Case "CDROIT_EMALEC" : sVSOCIETE_SRC = "EMALEC"
      Case "CDROIT_EMAFI" : sVSOCIETE_SRC = "EMAFI"
      Case "CDROIT_ALC" : sVSOCIETE_SRC = "ALC"
      Case "CDROIT_BELGIQUE" : sVSOCIETE_SRC = "EMALECBELGIQUE"
      Case "CDROIT_IDF" : sVSOCIETE_SRC = "EMALECIDF"
      Case "CDROIT_MAGESTIME" : sVSOCIETE_SRC = "MAGESTIME"
      Case "CDROIT_EMALECESPAGNE" : sVSOCIETE_SRC = "EMALECESPAGNE"
      Case "CDROIT_SCS" : sVSOCIETE_SRC = "SCS"
      Case "CDROIT_EMALECLUXEMBOURG" : sVSOCIETE_SRC = "EMALECLUXEMBOURG"
      Case "CDROIT_EMALECFACILITEAM" : sVSOCIETE_SRC = "EMALECFACILITEAM"
      Case "CDROIT_EMALECSUISSE" : sVSOCIETE_SRC = "EMALECSUISSE"
      Case "CDROIT_EQUIPAGE" : sVSOCIETE_SRC = "EQUIPAGE"
      Case "CDROIT_EMALECMPM" : sVSOCIETE_SRC = "EMALECMPM"
      Case "CDROIT_EMALECDEV" : sVSOCIETE_SRC = "EMALECDEV"
    End Select

    Dim oFrmCopyProfilType As New FrmCopyProfilType(sVSOCIETE_SRC, drSelectProfil.Item("ID"))
    oFrmCopyProfilType.ShowDialog()

  End Sub

End Class