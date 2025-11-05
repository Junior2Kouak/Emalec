Imports System.Linq

Public Class frmChiffrageEntreeStockVehTech

    Dim oACT_FO_ENT_VEH As CACT_FO_ENT_VEH
    Dim _NDINNUM As Int32

    Public Sub New(ByVal c_NDINNUM As Object)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _NDINNUM = c_NDINNUM

    End Sub

    Private Sub frmChiffrageEntreeStockVehTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LoadData()

    End Sub

    Private Sub LoadData()

        oACT_FO_ENT_VEH = New CACT_FO_ENT_VEH()

        GCListeFoRet.DataSource = oACT_FO_ENT_VEH.ListeFoAllActions(_NDINNUM)

    End Sub


    Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

        Me.Close()

    End Sub

    Private Sub GVListeFoRet_CustomDrawFooter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GVListeFoRet.CustomDrawFooter

        Dim oPos As Rectangle = e.Bounds
        Dim oFormat As New StringFormat
        Dim iNbFouSelected As Int32 = 0

        oPos.Location = New Point(oPos.Left + 1, oPos.Top + 1)
        oPos.Size = New Size(oPos.Width - 2, oPos.Height - 2)

        oFormat.Alignment = StringAlignment.Center

        Dim dttemp As DataTable = oACT_FO_ENT_VEH.p_dtListeFoAllActions

        For Each odrtemp As DataRow In dttemp.Rows

            If odrtemp.Item("NCOCHE") = 1 Then
                iNbFouSelected = iNbFouSelected + 1
            End If

        Next

        e.Appearance.DrawString(e.Cache, String.Format(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_nbrFourniture, iNbFouSelected, oACT_FO_ENT_VEH.p_dtListeFoAllActions.Rows.Count), oPos, oFormat)
        e.Handled = True

    End Sub

    Private Sub RepItemChkNCOCHE_CheckedChanged(sender As Object, e As System.EventArgs) Handles RepositoryItemCheckEditCHECK.CheckedChanged
        Dim odtr As DataRow = GVListeFoRet.GetDataRow(GVListeFoRet.GetSelectedRows(0))

        Try

            If Not odtr Is Nothing AndAlso odtr.Item("NCOCHE") = 1 Then
                CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = False
                odtr.Item("NCOCHE") = 0
            Else
                CType(sender, DevExpress.XtraEditors.CheckEdit).Checked = True
                odtr.Item("NCOCHE") = 1
            End If

        Catch ex As Exception
            MessageBox.Show(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_Tech + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        GVListeFoRet.PostEditor()
        GCListeFoRet.Refresh()

    End Sub

    Private Sub BtnValider_Click(sender As System.Object, e As System.EventArgs) Handles BtnValider.Click

        'mouse normal
        Me.Cursor = Cursors.WaitCursor

        Try

            'on liste les ligne affecte
            'on regroupe par action
            Dim ListOnlyNACTNUM = From order In oACT_FO_ENT_VEH.p_dtListeFoAllActions.AsEnumerable()
                                    Where order.Field(Of Int32)("NCOCHE") = 1
                                    Group By NACTNUM = order.Field(Of Int32)("NACTNUM"), NPERNUM = order.Field(Of Int32)("NPERNUM") Into Group _
                                    Select New With {
                                        Key NACTNUM,
                                        Key NPERNUM
                                    }

            If ListOnlyNACTNUM.Count = 0 Then

                MessageBox.Show(My.Resources.Global_select_au_moins_une_ligne, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Cursor = Cursors.Default
                Exit Sub

            End If

            'on traite les retour chantier par action
            'verif des données saisis
            For Each rowNACTNUM In ListOnlyNACTNUM

                For Each RowFo As DataRow In oACT_FO_ENT_VEH.p_dtListeFoAllActions.Select(String.Format("NACTNUM = {0} AND NCOCHE = 1", rowNACTNUM.NACTNUM))
                    'on teste si quantité entrée en stock + quantité deja entrée en stock > quantité prévue sur inter alors message error
                    If RowFo.Item("NFOUVEH_IN") + RowFo.Item("NFOUQTESTILLENTER") > RowFo.Item("NFOUQTE") Then
                        MessageBox.Show(String.Format(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_quantite, RowFo.Item("VFOUMAT")), My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                Next

            Next

            'traitement des retour chantier
            Dim _NRETNUM As Int32 = 0
            Dim _NACTNUM_REAPPRO As Int32 = 0
            Dim _NDDENUM_REAPPRO As Int32 = 0

            For Each rowNACTNUM In ListOnlyNACTNUM

                'on creer le RETOUR CHANTIER
                _NRETNUM = oACT_FO_ENT_VEH.CreateRetourChantier

                If _NRETNUM = 0 Then
                    MessageBox.Show(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_erreur, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                For Each RowFo As DataRow In oACT_FO_ENT_VEH.p_dtListeFoAllActions.Select(String.Format("NACTNUM = {0} AND NCOCHE = 1", rowNACTNUM.NACTNUM))

                    If Not RowFo.Item("NFOUVEH_IN") = 0 Then
                        oACT_FO_ENT_VEH.CreateLigneRetourChantier(_NRETNUM, RowFo)
                    End If

                Next

                'ON CREER LA DI + ACTION REAPPRO
                _NACTNUM_REAPPRO = oACT_FO_ENT_VEH.CreateDIReapproTech(rowNACTNUM.NPERNUM)

                If _NACTNUM_REAPPRO = 0 Then
                    MessageBox.Show(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_erreur2, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                'ON CREER LA SORTIE DE STOCK           
                _NDDENUM_REAPPRO = oACT_FO_ENT_VEH.CreateDemandeSortieStockReapproTech(_NACTNUM_REAPPRO)

                If _NDDENUM_REAPPRO = 0 Then
                    MessageBox.Show(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_erreur3, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                'remplissage de la sortie e stock
                For Each RowFo As DataRow In oACT_FO_ENT_VEH.p_dtListeFoAllActions.Select(String.Format("NACTNUM = {0} AND NCOCHE = 1", rowNACTNUM.NACTNUM))

                    If Not RowFo.Item("NFOUVEH_IN") = 0 Then
                        oACT_FO_ENT_VEH.CreateLigneDemandeSortieStock(_NDDENUM_REAPPRO, _NACTNUM_REAPPRO, RowFo)
                    End If

                Next

                'on enregistre les données
                oACT_FO_ENT_VEH.CreateSuiviEntreeStockVehTech(_NRETNUM, _NDDENUM_REAPPRO, rowNACTNUM.NACTNUM)

            Next

            'refresh
            If oACT_FO_ENT_VEH.bError = False Then
                GCListeFoRet.DataSource = oACT_FO_ENT_VEH.ListeFoAllActions(_NDINNUM)
            Else
                'init le code error 
                oACT_FO_ENT_VEH.bError = False
            End If

        Catch ex As Exception

            MessageBox.Show(My.Resources.DemandeIntervention_frmChiffrageEntreeStockVehTech_btn_click + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        'mouse normal
        Me.Cursor = Cursors.Default

    End Sub
End Class