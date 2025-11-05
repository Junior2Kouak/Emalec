Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports MozartLib
Imports MozartControls

Public Class FrmGestionAccessGroup

  Dim _dtListePer As DataTable
  Dim _DtListeMenuDroit As DataTable

  Dim ListButtonFooter As New List(Of Button)

  Private Sub FrmGestionAccessGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LoadData()

  End Sub

  Private Sub LoadData()

    _dtListePer = New DataTable

    Dim sqlcmd As New SqlCommand("[api_sp_ListePersGroupe]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    _dtListePer.Load(sqlcmd.ExecuteReader)

    GCPersGroupe.DataSource = _dtListePer

  End Sub

  Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub GVPersGroupe_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GVPersGroupe.FocusedRowChanged

    If GVPersGroupe.FocusedRowHandle > -1 Then

      RefreshDataDroitMenu()

    End If

  End Sub

  Private Sub RefreshDataDroitMenu()

    'init
    For Each BtnExists As Button In ListButtonFooter
      Me.Controls.Remove(BtnExists)
    Next
    ListButtonFooter.Clear()

    'hide/view colonne par societe
    Dim dtSoc As New DataTable
    Dim sqlcmd As New SqlCommand("[api_sp_ListeSociete_By_VPERADSI]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_VPERADSI", SqlDbType.VarChar).Value = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle).Item("VPERADSI")
    dtSoc.Load(sqlcmd.ExecuteReader)

    'init
    TreeCol_CDROIT_EMALEC.Visible = False
    TreeCol_CDROIT_EMAFI.Visible = False
    TreeCol_CDROIT_ALC.Visible = False
    TreeCol_CDROIT_BELGIQUE.Visible = False
    TreeCol_CDROIT_IDF.Visible = False
    TreeCol_CDROIT_EQUIPAGE.Visible = False
    TreeCol_CDROIT_MAGESTIME.Visible = False
    TreeCol_CDROIT_EMALECESPAGNE.Visible = False
    TreeCol_CDROIT_SCS.Visible = False
    TreeCol_CDROIT_EMALECLUXEMBOURG.Visible = False
    TreeCol_CDROIT_EMALECFACILITEAM.Visible = False
    TreeCol_CDROIT_EMALECSUISSE.Visible = False
    TreeCol_CDROIT_EMALECMPM.Visible = False
    TreeCol_CDROIT_DEV.Visible = False

    For Each dr As DataRow In dtSoc.Rows

      Select Case dr.Item("VSOCIETE")
        Case "EMALEC"
          TreeCol_CDROIT_EMALEC.Visible = True
        Case "EMAFI"
          TreeCol_CDROIT_EMAFI.Visible = True
        Case "ALC"
          TreeCol_CDROIT_ALC.Visible = True
        Case "EQUIPAGE"
          TreeCol_CDROIT_EQUIPAGE.Visible = True
        Case "SCS"
          TreeCol_CDROIT_SCS.Visible = True
        Case "MAGESTIME"
          TreeCol_CDROIT_MAGESTIME.Visible = True
        Case "EMALECBELGIQUE"
          TreeCol_CDROIT_BELGIQUE.Visible = True
        Case "EMALECESPAGNE"
          TreeCol_CDROIT_EMALECESPAGNE.Visible = True
        Case "EMALECIDF"
          TreeCol_CDROIT_IDF.Visible = True
        Case "EMALECFACILITEAM"
          TreeCol_CDROIT_EMALECFACILITEAM.Visible = True
        Case "EMALECLUXEMBOURG"
          TreeCol_CDROIT_EMALECLUXEMBOURG.Visible = True
        Case "EMALECSUISSE"
          TreeCol_CDROIT_EMALECSUISSE.Visible = True
        Case "EMALECMPM"
          TreeCol_CDROIT_EMALECMPM.Visible = True
        Case "EMALECDEV"
          TreeCol_CDROIT_DEV.Visible = True

      End Select

    Next

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

    sqlcmd = New SqlCommand("[api_sp_ListeMenuDroit_By_VPERADSI]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@p_VPERADSI", SqlDbType.VarChar).Value = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle).Item("VPERADSI")
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

          'bouton profil type
          Dim BtnProfilType As New Button

          BtnProfilType.Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height + BtnReini.Height + BtnDupliq.Height)
          BtnProfilType.Size = New Size(e.Column.VisibleWidth, 30)
          BtnProfilType.Visible = True
          BtnProfilType.Text = "Appliquer profil type"
          BtnProfilType.Name = e.Column.FieldName + "_ProfilType"
          BtnProfilType.BackColor = Color.LightGray
          BtnProfilType.Tag = e.Column.GetTextCaption

          AddHandler BtnProfilType.Click, AddressOf Click_ApplyProfilType

          Me.Controls.Add(BtnProfilType)

          ListButtonFooter.Add(BtnProfilType)


        Else

          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Size = New Size(e.Column.VisibleWidth, 30)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Visible = True

          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Location.Y + ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Reinit").Size.Height)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Size = New Size(e.Column.VisibleWidth, 30)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Visible = True

          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_ProfilType").Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Location.Y + ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Dupliq").Size.Height)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_ProfilType").Size = New Size(e.Column.VisibleWidth, 30)
          ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_ProfilType").Visible = True

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

        'bouton profil type
        Dim BtnProfilType As New Button

        BtnProfilType.Location = New Point(TreeList_Menu.Location.X + e.Bounds.Left, TreeList_Menu.Location.Y + TreeList_Menu.Size.Height + BtnReini.Height + BtnDupliq.Height)
        BtnProfilType.Size = New Size(e.Column.VisibleWidth, 30)
        BtnProfilType.Visible = True
        BtnProfilType.Text = "Appliquer profil type"
        BtnProfilType.Name = e.Column.FieldName + "_ProfilType"
        BtnProfilType.BackColor = Color.LightGray
        BtnProfilType.Tag = e.Column.GetTextCaption

        AddHandler BtnProfilType.Click, AddressOf Click_ApplyProfilType

        Me.Controls.Add(BtnProfilType)

        ListButtonFooter.Add(BtnProfilType)


      End If

      e.Handled = True

    End If

  End Sub

  Private Sub Click_Reinit(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Dim RowHandlePer As Int32 = GVPersGroupe.FocusedRowHandle

    If RowHandlePer < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(RowHandlePer)

    If MessageBox.Show(String.Format("Voulez-vous vraiment réinitialiser le profil de {0} pour la société {1} ?", drSelectPer.Item("VPERNOM"), sender.Tag), "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Select Case sender.name
        Case "CDROIT_EMALEC" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALEC")
        Case "CDROIT_EMAFI" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMAFI")
        Case "CDROIT_ALC" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "ALC")
        Case "CDROIT_BELGIQUE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECBELGIQUE")
        Case "CDROIT_IDF" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECIDF")
        Case "CDROIT_MAGESTIME" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "MAGESTIME")
        Case "CDROIT_EMALECESPAGNE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECESPAGNE")
        Case "CDROIT_SCS" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "SCS")
        Case "CDROIT_EMALECLUXEMBOURG" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECLUXEMBOURG")
        Case "CDROIT_EMALECFACILITEAM" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECFACILITEAM")
        Case "CDROIT_EMALECSUISSE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECSUISSE")
        Case "CDROIT_EQUIPAGE" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EQUIPAGE")
        Case "CDROIT_EMALECMPM" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECMPM")
        Case "CDROIT_EMALECDEV" + "_Reinit" : ReinitialiserProfil(drSelectPer.Item("VPERADSI"), "EMALECDEV")

      End Select

      RefreshDataDroitMenu()

      MessageBox.Show("Réinitialisation effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub ReinitialiserProfil(ByVal P_VPERADSI As String, ByVal P_VSOCIETE As String)

    Dim sqlcmd As New SqlCommand("[api_sp_ReinitialiseProfilMozart]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = P_VPERADSI
    sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = P_VSOCIETE
    sqlcmd.ExecuteNonQuery()

  End Sub

  Private Sub Click_Duplicate(ByVal sender As System.Object, ByVal e As System.EventArgs)

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

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
    Dim oFrmSelectFilialesDuplicate As New FrmGestionAccessGroup_Liste_Filiales(drSelectPer.Item("NPERNUM"), drSelectPer.Item("VPERADSI"), sVSOCIETE_SRC, 0)
    oFrmSelectFilialesDuplicate.ShowDialog()

    If oFrmSelectFilialesDuplicate.Cancel = True Then
      Exit Sub
    End If

    For Each DrFiliale As DataRow In oFrmSelectFilialesDuplicate.DtListeFiliales.Rows

      If DrFiliale.Item("NCOCHE") = 1 Then
        DupliquerProfil(drSelectPer.Item("VPERADSI"), sVSOCIETE_SRC, DrFiliale.Item("VSOCIETE"))
      End If

    Next

    If oFrmSelectFilialesDuplicate.DtListeFiliales.Select("[NCOCHE] = 1").Count > 0 Then

      RefreshDataDroitMenu()
      MessageBox.Show("Duplication effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub

  Private Sub DupliquerProfil(ByVal P_VPERADSI As String, ByVal p_VSOCIETE_SRC As String, ByVal p_VSOCIETE_DEST As String)

    Dim sqlcmd As New SqlCommand("[api_sp_DuplicateProfilMozart_Copy]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = P_VPERADSI
    sqlcmd.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = p_VSOCIETE_SRC
    sqlcmd.Parameters.Add("@P_VSOCIETE_DEST", SqlDbType.VarChar).Value = p_VSOCIETE_DEST
    sqlcmd.ExecuteNonQuery()

  End Sub

  Private Sub Click_ApplyProfilType(ByVal sender As System.Object, ByVal e As System.EventArgs)

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

    Dim sVSOCIETE_SRC As String = ""

    Select Case sender.name
      Case "CDROIT_EMALEC" + "_ProfilType" : sVSOCIETE_SRC = "EMALEC"
      Case "CDROIT_EMAFI" + "_ProfilType" : sVSOCIETE_SRC = "EMAFI"
      Case "CDROIT_ALC" + "_ProfilType" : sVSOCIETE_SRC = "ALC"
      Case "CDROIT_BELGIQUE" + "_ProfilType" : sVSOCIETE_SRC = "EMALECBELGIQUE"
      Case "CDROIT_IDF" + "_ProfilType" : sVSOCIETE_SRC = "EMALECIDF"
      Case "CDROIT_MAGESTIME" + "_ProfilType" : sVSOCIETE_SRC = "MAGESTIME"
      Case "CDROIT_EMALECESPAGNE" + "_ProfilType" : sVSOCIETE_SRC = "EMALECESPAGNE"
      Case "CDROIT_SCS" + "_ProfilType" : sVSOCIETE_SRC = "SCS"
      Case "CDROIT_EMALECLUXEMBOURG" + "_ProfilType" : sVSOCIETE_SRC = "EMALECLUXEMBOURG"
      Case "CDROIT_EMALECFACILITEAM" + "_ProfilType" : sVSOCIETE_SRC = "EMALECFACILITEAM"
      Case "CDROIT_EMALECSUISSE" + "_ProfilType" : sVSOCIETE_SRC = "EMALECSUISSE"
      Case "CDROIT_EQUIPAGE" + "_ProfilType" : sVSOCIETE_SRC = "EQUIPAGE"
      Case "CDROIT_EMALECMPM" + "_ProfilType" : sVSOCIETE_SRC = "EMALECMPM"
      Case "CDROIT_EMALECDEV" + "_ProfilType" : sVSOCIETE_SRC = "EMALECDEV"

    End Select

    'selection de la société destinatrice
    Dim oFrmGestionAccessGroup_ListeProfilType As New FrmGestionAccessGroup_ListeProfilType(drSelectPer.Item("VPERNOM") & " (" & drSelectPer.Item("FONC") & ") - " & drSelectPer.Item("VSOCIETE"))
    oFrmGestionAccessGroup_ListeProfilType.ShowDialog()

    If oFrmGestionAccessGroup_ListeProfilType.Cancel = True Then
      Exit Sub
    End If

    'on au moins 1 case coché, alors init de tous les droit de la societe de la personne
    If oFrmGestionAccessGroup_ListeProfilType.DtListeProfil.Select("[NCOCHE] = 1").Count > 0 Then

      Dim sqlcmdInitDroit As New SqlCommand("[api_sp_DroitsInit]", MozartDatabase.cnxMozart)
      sqlcmdInitDroit.CommandType = CommandType.StoredProcedure
      sqlcmdInitDroit.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = drSelectPer.Item("VPERADSI")
      sqlcmdInitDroit.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = sVSOCIETE_SRC
      sqlcmdInitDroit.ExecuteNonQuery()

    End If

    For Each DrProfil As DataRow In oFrmGestionAccessGroup_ListeProfilType.DtListeProfil.Rows

      If DrProfil.Item("NCOCHE") = 1 Then
        SetProfilType(DrProfil.Item("ID"), DrProfil.Item("NSERNUM"), drSelectPer.Item("VPERADSI"), sVSOCIETE_SRC)
      End If

    Next

    If oFrmGestionAccessGroup_ListeProfilType.DtListeProfil.Select("[NCOCHE] = 1").Count > 0 Then

      RefreshDataDroitMenu()
      MessageBox.Show("Affectation du ou des profils sélectionnés effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End If

  End Sub
  Private Sub SetProfilType(ByVal p_NID As Int32, ByVal P_NSERNUM As Int32, ByVal P_VPERADSI As String, ByVal p_VSOCIETE As String)


    Dim sqlcmd As New SqlCommand("[api_sp_Droits_SetByProfil]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NID_REF_TYPEPERDETAIL", SqlDbType.Int).Value = p_NID
    sqlcmd.Parameters.Add("@P_NSERNUM", SqlDbType.Int).Value = P_NSERNUM
    sqlcmd.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = P_VPERADSI
    sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = p_VSOCIETE

    sqlcmd.ExecuteNonQuery()

  End Sub

  Private Sub TreeList_Menu_CustomDrawNodeButton(sender As Object, e As CustomDrawNodeButtonEventArgs) Handles TreeList_Menu.CustomDrawNodeButton
    Dim rect As Rectangle = Rectangle.Inflate(e.Bounds, 0, -2)
    ' painting background
    Dim BackBrush = e.Cache.GetGradientBrush(rect, Color.Blue, Color.LightSkyBlue,
                                             LinearGradientMode.ForwardDiagonal)
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

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

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

    Dim sql_update As New SqlCommand("[api_sp_UpdateDroitMOZART]", MozartDatabase.cnxMozart)
    sql_update.CommandType = CommandType.StoredProcedure
    sql_update.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = drSelectPer.Item("VPERADSI")
    sql_update.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = TreeList_Menu.FocusedNode.Item("NMENUNUM")
    sql_update.Parameters.Add("@P_VSOCIETE_SRC", SqlDbType.VarChar).Value = sVSOCIETE_SRC
    sql_update.Parameters.Add("@P_VALUE", SqlDbType.Char).Value = (CType(sender, CheckEdit)).EditValue.ToString

    sql_update.ExecuteNonQuery()

  End Sub

  Private Sub TreeList_Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles TreeList_Menu.MouseDown

    If e.Button = MouseButtons.Right Then

      Dim hitInfo As TreeListHitInfo = (TryCast(sender, TreeList)).CalcHitInfo(e.Location)

      If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

      Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

      Dim sVSOCIETE_SRC As String = ""

      If hitInfo.Column Is Nothing Then Exit Sub

      Select Case hitInfo.Column.FieldName
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

      Dim oFrmSelectSoc As New FrmGestionAccessGroup_Liste_Filiales(drSelectPer.Item("NPERNUM"), drSelectPer.Item("VPERADSI"), sVSOCIETE_SRC, 2, TreeList_Menu.FocusedNode.Item("NMENUNUM"))
      oFrmSelectSoc.ShowDialog()

      For Each drSoc As DataRow In oFrmSelectSoc.DtListeFiliales.Rows

        Dim sql_update As New SqlCommand("[api_sp_SetDroitMozartOnMenuMultiSoc]", MozartDatabase.cnxMozart)
        sql_update.CommandType = CommandType.StoredProcedure
        sql_update.Parameters.Add("@P_NPERNUM", SqlDbType.Int).Value = drSelectPer.Item("NPERNUM")
        sql_update.Parameters.Add("@P_NMENUNUM", SqlDbType.Int).Value = TreeList_Menu.FocusedNode.Item("NMENUNUM")
        sql_update.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = drSelectPer.Item("VPERADSI")
        sql_update.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = drSoc.Item("VSOCIETE")
        sql_update.Parameters.Add("@P_CDROITVAL", SqlDbType.Char).Value = If(drSoc.Item("NCOCHE") = 1, "O", "N")

        sql_update.ExecuteNonQuery()

      Next

    End If

  End Sub

  Private Sub BtnCopyProfil_Click(sender As Object, e As EventArgs) Handles BtnCopyProfil.Click

    Dim oFrmCopyProfil As New FrmCopyProfil("EMALEC")
    oFrmCopyProfil.ShowDialog()

    RefreshDataDroitMenu()
    LoadData()
  End Sub

  Private Sub BtnCreateProfilOnFiliale_Click(sender As Object, e As EventArgs) Handles BtnCreateProfilOnFiliale.Click

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

    Dim oFrmSelectSoc As New FrmGestionAccessGroup_Liste_Filiales(drSelectPer.Item("NPERNUM"), drSelectPer.Item("VPERADSI"), drSelectPer.Item("VSOCIETE"), 1)
    oFrmSelectSoc.ShowDialog()

    If oFrmSelectSoc.Cancel = False Then

      For Each drSoc As DataRow In oFrmSelectSoc.DtListeFiliales.Rows

        If drSoc.Item("NCOCHE") = 1 Then

          Try
            Dim sql_update As New SqlCommand("[api_sp_DuplicatePersonnel]", MozartDatabase.cnxMozart)
            sql_update.CommandType = CommandType.StoredProcedure
            sql_update.Parameters.Add("@p_npernum_origine", SqlDbType.Int).Value = drSelectPer.Item("NPERNUM")
            sql_update.Parameters.Add("@p_vsociete_dest", SqlDbType.VarChar).Value = drSoc.Item("VSOCIETE")
            sql_update.ExecuteNonQuery()

          Catch ex As Exception

            MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
          End Try



        End If

      Next

      If oFrmSelectSoc.DtListeFiliales.Select("[NCOCHE] = 1").Count > 0 Then

        RefreshDataDroitMenu()
        LoadData()
        MessageBox.Show("La création de l'utilisateur dans les filiales sélectionnées a été effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    End If
  End Sub
  Private Sub BtnDroitsParMenu_Click(sender As Object, e As EventArgs) Handles BtnDroitsParMenu.Click

    Dim oFrmGestionDroitsByMenu As New frmGestionAccessGroupByMenu()
    oFrmGestionDroitsByMenu.ShowDialog()

  End Sub

  Private Sub BtnGestionProfilType_Click(sender As Object, e As EventArgs) Handles BtnGestionProfilType.Click

    Dim oFrmGestionProfilType As New FrmGestionProfilType
    oFrmGestionProfilType.ShowDialog()

  End Sub

  Private Sub BtnCheckedAll_Click(sender As Object, e As EventArgs) Handles BtnCheckedAll.Click

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

    If MessageBox.Show("Voulez-vous vraiment affecter tous les droits à " & drSelectPer.Item("VPERNOM") & " ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sVSOCIETE_Check As String

      'pour chaque colonne afficher
      For Each Col_Trre_SOCIETE As TreeListColumn In TreeList_Menu.Columns

        If Col_Trre_SOCIETE.Visible = True Then

          Select Case Col_Trre_SOCIETE.FieldName
            Case "CDROIT_EMALEC" : sVSOCIETE_Check = "EMALEC"
            Case "CDROIT_EMAFI" : sVSOCIETE_Check = "EMAFI"
            Case "CDROIT_ALC" : sVSOCIETE_Check = "ALC"
            Case "CDROIT_BELGIQUE" : sVSOCIETE_Check = "EMALECBELGIQUE"
            Case "CDROIT_IDF" : sVSOCIETE_Check = "EMALECIDF"
            Case "CDROIT_MAGESTIME" : sVSOCIETE_Check = "MAGESTIME"
            Case "CDROIT_EMALECESPAGNE" : sVSOCIETE_Check = "EMALECESPAGNE"
            Case "CDROIT_SCS" : sVSOCIETE_Check = "SCS"
            Case "CDROIT_EMALECLUXEMBOURG" : sVSOCIETE_Check = "EMALECLUXEMBOURG"
            Case "CDROIT_EMALECFACILITEAM" : sVSOCIETE_Check = "EMALECFACILITEAM"
            Case "CDROIT_EMALECSUISSE" : sVSOCIETE_Check = "EMALECSUISSE"
            Case "CDROIT_EQUIPAGE" : sVSOCIETE_Check = "EQUIPAGE"
            Case "CDROIT_EMALECMPM" : sVSOCIETE_Check = "EMALECMPM"
            Case "CDROIT_EMALECDEV" : sVSOCIETE_Check = "EMALECDEV"
            Case Else : sVSOCIETE_Check = ""
          End Select



          Dim sql_update As New SqlCommand("[api_sp_SetDroitMozartAllCheckedOrUnchecked]", MozartDatabase.cnxMozart)
          sql_update.CommandType = CommandType.StoredProcedure
          sql_update.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = drSelectPer.Item("VPERADSI")
          sql_update.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = sVSOCIETE_Check
          sql_update.Parameters.Add("@P_CDROITVAL", SqlDbType.Char).Value = "O"

          sql_update.ExecuteNonQuery()

        End If

      Next

      RefreshDataDroitMenu()

    End If

  End Sub

  Private Sub BtnUnCheckedAll_Click(sender As Object, e As EventArgs) Handles BtnUnCheckedAll.Click

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

    If MessageBox.Show("Voulez-vous vraiment désaffecter tous les droits de " & drSelectPer.Item("VPERNOM") & " ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

      Dim sVSOCIETE_Check As String

      'pour chaque colonne afficher
      For Each Col_Trre_SOCIETE As TreeListColumn In TreeList_Menu.Columns

        If Col_Trre_SOCIETE.Visible = True Then

          Select Case Col_Trre_SOCIETE.FieldName
            Case "CDROIT_EMALEC" : sVSOCIETE_Check = "EMALEC"
            Case "CDROIT_EMAFI" : sVSOCIETE_Check = "EMAFI"
            Case "CDROIT_ALC" : sVSOCIETE_Check = "ALC"
            Case "CDROIT_BELGIQUE" : sVSOCIETE_Check = "EMALECBELGIQUE"
            Case "CDROIT_IDF" : sVSOCIETE_Check = "EMALECIDF"
            Case "CDROIT_MAGESTIME" : sVSOCIETE_Check = "MAGESTIME"
            Case "CDROIT_EMALECESPAGNE" : sVSOCIETE_Check = "EMALECESPAGNE"
            Case "CDROIT_SCS" : sVSOCIETE_Check = "SCS"
            Case "CDROIT_EMALECLUXEMBOURG" : sVSOCIETE_Check = "EMALECLUXEMBOURG"
            Case "CDROIT_EMALECFACILITEAM" : sVSOCIETE_Check = "EMALECFACILITEAM"
            Case "CDROIT_EMALECSUISSE" : sVSOCIETE_Check = "EMALECSUISSE"
            Case "CDROIT_EQUIPAGE" : sVSOCIETE_Check = "EQUIPAGE"
            Case "CDROIT_EMALECMPM" : sVSOCIETE_Check = "EMALECMPM"
            Case "CDROIT_EMALECDEV" : sVSOCIETE_Check = "EMALECDEV"
            Case Else : sVSOCIETE_Check = ""
          End Select

          Dim sql_update As New SqlCommand("[api_sp_SetDroitMozartAllCheckedOrUnchecked]", MozartDatabase.cnxMozart)
          sql_update.CommandType = CommandType.StoredProcedure
          sql_update.Parameters.Add("@P_VPERADSI", SqlDbType.VarChar).Value = drSelectPer.Item("VPERADSI")
          sql_update.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = sVSOCIETE_Check
          sql_update.Parameters.Add("@P_CDROITVAL", SqlDbType.Char).Value = "N"

          sql_update.ExecuteNonQuery()

        End If

      Next

      RefreshDataDroitMenu()

    End If

  End Sub

  Private Sub BtnDelUser_Click(sender As Object, e As EventArgs) Handles BtnDelUser.Click

    If GVPersGroupe.FocusedRowHandle < 0 Then Exit Sub

    Dim drSelectPer As DataRow = GVPersGroupe.GetDataRow(GVPersGroupe.FocusedRowHandle)

    Dim oFrmSelectSoc As New FrmGestionAccessGroup_Liste_Filiales(drSelectPer.Item("NPERNUM"), drSelectPer.Item("VPERADSI"), drSelectPer.Item("VSOCIETE"), 4)
    oFrmSelectSoc.ShowDialog()

    If oFrmSelectSoc.Cancel = False Then

      For Each drSoc As DataRow In oFrmSelectSoc.DtListeFiliales.Rows

        If drSoc.Item("NCOCHE") = 1 Then

          Dim sql_update As New SqlCommand("[api_sp_ArchiverPersonneOnFiliale]", MozartDatabase.cnxMozart)
          sql_update.CommandType = CommandType.StoredProcedure
          sql_update.Parameters.Add("@p_npernum_origine", SqlDbType.Int).Value = drSelectPer.Item("NPERNUM")
          sql_update.Parameters.Add("@p_vsociete_dest", SqlDbType.VarChar).Value = drSoc.Item("VSOCIETE")
          sql_update.ExecuteNonQuery()

        End If

      Next

      If oFrmSelectSoc.DtListeFiliales.Select("[NCOCHE] = 1").Count > 0 Then

        RefreshDataDroitMenu()
        LoadData()
        MessageBox.Show("La suppression de l'utilisateur dans les filiales sélectionnées a été effectuée avec succès", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

      End If
    End If
  End Sub

  Private Sub BtnExportXLS_Click(sender As Object, e As EventArgs) Handles BtnExportXLS.Click

    SFD.FileName = "ExportListeMenus.xlsx"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then
      TreeList_Menu.ExportToXlsx(SFD.FileName)
    End If

  End Sub

  Private Sub btnMenuSensible_Click(sender As Object, e As EventArgs) Handles btnMenuSensible.Click
    Dim frmGestionDroitMenuSensible As New frmGestionDroitMenuSensible()
    frmGestionDroitMenuSensible.ShowDialog()

  End Sub
End Class