Imports System.Data.SqlClient
Imports MozartLib
Imports System.Reflection
Imports MZUtils = MozartControls.Utils

Public Class frmFiche

  Private iNIDANACHAFICTYPE As Int32

  Private vTyp As String
  Dim Codetype As String
  Dim cmd As New SqlCommand("", MozartDatabase.cnxMozart)
  Dim cmdGrid As New SqlCommand("", MozartDatabase.cnxMozart)
  Dim drGrid As New SqlDataAdapter
  Dim dr As SqlDataReader
  Public dsGrid As New DataSet

  Private iNIDCHANTIER As Int32

  Public Sub New(ByVal c_iNIDCHANTIER As Int32, ByVal pCdeType As String)
    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNIDCHANTIER = c_iNIDCHANTIER
    Codetype = pCdeType
  End Sub

  Private Sub frmFiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Init()
    Totalsaisie()
  End Sub

  Private Sub Init()

    Dim sReqSelect As String = ""

    Select Case Codetype
      Case "AnaChaFicH"
        vTyp = "H"
        iNIDANACHAFICTYPE = 5
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND (ISNULL(NIDANACHAFICTYPE, 0) = 0 OR ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & ")  ORDER BY NCLASS"

      Case "AnaChaFicH_TEC_MECA"
        vTyp = "H"
        iNIDANACHAFICTYPE = 6
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & " ORDER BY NCLASS"
      Case "AnaChaFicH_TEC_CABL"
        vTyp = "H"
        iNIDANACHAFICTYPE = 7
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & " ORDER BY NCLASS"
      Case "AnaChaFicH_TEC_AIDETEC"
        vTyp = "H"
        iNIDANACHAFICTYPE = 8
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & " ORDER BY NCLASS"

      Case "AnaChaFicF"
        vTyp = "F"
        iNIDANACHAFICTYPE = Nothing
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = 0 ORDER BY NCLASS"
      Case "AnaChaFicS"
        vTyp = "S"
        iNIDANACHAFICTYPE = Nothing
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = 0 ORDER BY NCLASS"

      Case "AnaChaFicH_BE"
        vTyp = "H"
        iNIDANACHAFICTYPE = 1
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND (ISNULL(NIDANACHAFICTYPE, 0) = 0 OR ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & ")  ORDER BY NCLASS"

      Case "AnaChaFicH_BE_AUTO"
        vTyp = "H"
        iNIDANACHAFICTYPE = 9
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND (ISNULL(NIDANACHAFICTYPE, 0) = 0 OR ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & ")  ORDER BY NCLASS"
      Case "AnaChaFicH_BE_ELEC"
        vTyp = "H"
        iNIDANACHAFICTYPE = 10
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND (ISNULL(NIDANACHAFICTYPE, 0) = 0 OR ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & ")  ORDER BY NCLASS"
      Case "AnaChaFicH_BE_MECA"
        vTyp = "H"
        iNIDANACHAFICTYPE = 11
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND (ISNULL(NIDANACHAFICTYPE, 0) = 0 OR ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & ")  ORDER BY NCLASS"

      Case "AnaChaFicH_CHAFF"
        vTyp = "H"
        iNIDANACHAFICTYPE = 2
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND (ISNULL(NIDANACHAFICTYPE, 0) = 0 OR ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE & ")  ORDER BY NCLASS"

      Case Else
        vTyp = ""
        sReqSelect = "SELECT NIDFICHE,NCLASS, VLIB, NVAL, DDEB, DFIN, NVALOBJ, NIDANACHAFICTYPE FROM TCHANTIERFICHE WITH (NOLOCK)  WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = 0 ORDER BY NCLASS"
    End Select

    dsGrid.Clear()

    ' remplissage grid
    cmdGrid.CommandText = sReqSelect
    drGrid.SelectCommand = cmdGrid
    drGrid.Fill(dsGrid)
    grdFiche.DataSource = dsGrid.Tables(0)

    'recherche total
    If Codetype = "AnaChaFicH" Then
      grpBox.Text = My.Resources.Global_FicheHeures
      cmd.CommandText = "SELECT SUM(ISNULL(NMO,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_TEC_MECA" Then
      grpBox.Text = "Fiches Heures technicien mécanicien"
      cmd.CommandText = "SELECT SUM(ISNULL(NMO_MECA,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_TEC_CABL" Then
      grpBox.Text = "Fiches Heures technicien cableur"
      cmd.CommandText = "SELECT SUM(ISNULL(NMO_CABL,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_TEC_AIDETEC" Then
      grpBox.Text = "Fiches Heures technicien aide technicien"
      cmd.CommandText = "SELECT SUM(ISNULL(NMO_AIDETEC,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée

    ElseIf Codetype = "AnaChaFicH_BE" Then
      grpBox.Text = "Fiches Heures Bureau d'études"
      cmd.CommandText = "SELECT SUM(ISNULL(NMOBE,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_BE_AUTO" Then
      grpBox.Text = "Fiches Heures Bureau d'études automaticien"
      cmd.CommandText = "SELECT SUM(ISNULL(NMOBE_AUTO,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_BE_ELEC" Then
      grpBox.Text = "Fiches Heures Bureau d'études électricien"
      cmd.CommandText = "SELECT SUM(ISNULL(NMOBE_ELEC,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_BE_MECA" Then
      grpBox.Text = "Fiches Heures Bureau d'études mécanicien"
      cmd.CommandText = "SELECT SUM(ISNULL(NMOBE_MECA,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée
    ElseIf Codetype = "AnaChaFicH_CHAFF" Then
      grpBox.Text = "Fiches Heures chargé d'affaires"
      cmd.CommandText = "SELECT SUM(ISNULL(NMOCHAF,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "h"
      lblchif.Text = "h"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_edition_chantier
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_heure_chiffrée


    ElseIf Codetype = "AnaChaFicF" Then
      grpBox.Text = My.Resources.admin_frmFiche_FicheFournitures
      cmd.CommandText = "SELECT SUM(ISNULL(NFO,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "€"
      lblchif.Text = "€"
      cmdVisu.Visible = True
      cmdVisu.Text = My.Resources.admin_frmFiche_FicheConsultation
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_Fournitures
    ElseIf Codetype = "AnaChaFicS" Then
      grpBox.Text = My.Resources.admin_frmFiche_Fiche_sousTraitance
      cmd.CommandText = "SELECT SUM(ISNULL(NSTT,0)) AS TOT FROM TCHANTIERCHIFFRAGE WITH (NOLOCK) WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER
      lblVal.Text = "€"
      lblchif.Text = "€"
      cmdVisu.Visible = False
      grdFiche.Columns(3).HeaderText = My.Resources.admin_frmFiche_Sous_traitance
    End If

    dr = cmd.ExecuteReader
    dr.Read()

    txtTotalChif.Text = CLng(dr("TOT")).ToString("### ### ###")

    dr.Close()

  End Sub

  Private Sub Totalsaisie()
    If dsGrid.Tables(0).Rows.Count = 0 Then
      txtTotalSaisie.Text = "0"
    Else
      cmd.CommandText = "SELECT SUM(ISNULL(NVAL, 0))  AS TOT, SUM(ISNULL(NVALOBJ, 0)) AS TOTOBJ FROM TCHANTIERFICHE WITH (NOLOCK) WHERE VTYPE = '" & vTyp & "' AND NIDCHANTIER = " & iNIDCHANTIER & " AND ISNULL(NIDANACHAFICTYPE, 0) = " & iNIDANACHAFICTYPE
      dr = cmd.ExecuteReader
      dr.Read()
      txtTotalSaisie.Text = CLng(dr("TOT")).ToString("### ### ###")
      txtTotObj.Text = CLng(dr("TOTOBJ")).ToString("### ### ###")

      TxtDiffHeures.Text = (CLng(dr("TOT")) - CLng(dr("TOTOBJ"))).ToString("### ### ###")
      txtPourc.Text = String.Format("{0:p1}", If(CLng(dr("TOT")) = 0, 0, CLng(dr("TOTOBJ")) / CLng(dr("TOT"))))

      dr.Close()
    End If
  End Sub

  Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click

    Dim oLibelleFiche As New frmLibelleFiche(iNIDCHANTIER, 0, vTyp, iNIDANACHAFICTYPE)
    oLibelleFiche.ShowDialog()

    dsGrid.Clear()
    drGrid.Fill(dsGrid)

    Totalsaisie()
  End Sub

  Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

    'on test si les fiches BE et chaff existe sur ce chantier.        
    'Fiche BE
    'If TestFiche(1) = False Then createFicheBE(1)
    'Fiche CHAFF
    'If TestFiche(2) = False Then createFicheBE(2)
    'Fiche Compte prorata Fourniture
    If TestFiche(3) = False And MozartParams.NomSociete <> "EMALECMPM" Then createFicheBE(3)
    'Fiche Compte prorata Sous traitant
    If TestFiche(4) = False And MozartParams.NomSociete <> "EMALECMPM" Then createFicheBE(4)

    If txtTotalChif.Text <> "" AndAlso txtTotalChif.Text <> txtTotalSaisie.Text Then
      MessageBox.Show(My.Resources.admin_frmFiche_total_chiffré, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Exit Sub
    End If

    Close()
  End Sub

  Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
    Dim lNb As Int32
    Dim lIdFiche As String
    Dim lCmd As String

    Try
      lIdFiche = grdFiche.CurrentRow.Cells(1).Value.ToString()

      ' Traitement spécifique pour les MO Productives
      If iNIDANACHAFICTYPE >= 5 And iNIDANACHAFICTYPE <= 8 Then
        lCmd = $"SELECT COUNT(*) FROM TCHANTIERRESTEAENGAGER WHERE NVAL > 0 AND NIDFICHE = {lIdFiche}"
      Else
        lCmd = $"SELECT COUNT(*) FROM TCHANTIERFICHE WITH (NOLOCK) WHERE NVALREA > 0 AND NIDFICHE = {lIdFiche}"
      End If

      cmd.CommandText = lCmd
      dr = cmd.ExecuteReader
      dr.Read()
      lNb = dr(0)
      dr.Close()

      If lNb > 0 Then
        MessageBox.Show(My.Resources.admin_frmFiche_supprimer_libellé, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Exit Sub
      End If

      If MessageBox.Show(My.Resources.admin_frmFiche_supprimer, My.Resources.Global_suppression, MessageBoxButtons.YesNo) = DialogResult.Yes Then
        cmd.CommandText = "DELETE TCHANTIERFICHE WHERE NIDFICHE = " & lIdFiche
        cmd.ExecuteNonQuery()

        ' Traitement spécifique pour les MO Productives
        If iNIDANACHAFICTYPE >= 5 And iNIDANACHAFICTYPE <= 8 Then
          cmd.CommandText = $"DELETE TCHANTIERRESTEAENGAGER WHERE NIDFICHE = {lIdFiche}"
          cmd.ExecuteNonQuery()
        End If

        dsGrid.Clear()
        drGrid.Fill(dsGrid)

        Totalsaisie()
      End If
    Catch ex As Exception
      MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex)
    End Try
  End Sub

  Private Sub cmdVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisu.Click

    Dim p_collectIDFICHE As String = ""

    'on lit les lignes de la datagrid et on récupère l'idfiche si sélectionner pour la passé en paramètres après

    For Each oRowChkForPrint As DataGridViewRow In grdFiche.Rows

      If CType(oRowChkForPrint.Cells(0).Value, Boolean) = True Then

        If String.IsNullOrEmpty(p_collectIDFICHE) Then
          p_collectIDFICHE = oRowChkForPrint.Cells(1).Value.ToString
        Else
          p_collectIDFICHE = p_collectIDFICHE + "," + oRowChkForPrint.Cells(1).Value.ToString
        End If

      End If

    Next

    Dim sRequeteSQL As String

    Select Case Codetype
      Case "AnaChaFicH", "AnaChaFicH_TEC_MECA", "AnaChaFicH_TEC_CABL", "AnaChaFicH_TEC_AIDETEC", "AnaChaFicH_BE", "AnaChaFicH_BE_AUTO", "AnaChaFicH_BE_ELEC", "AnaChaFicH_BE_MECA", "AnaChaFicH_CHAFF"
        sRequeteSQL = "exec api_sp_ChantierImpFicheHeure " & iNIDCHANTIER.ToString & ", '" & p_collectIDFICHE & "'"
      Case Else
        sRequeteSQL = "exec api_sp_ChantierImpFicheFOU " & iNIDCHANTIER.ToString & ", '" & p_collectIDFICHE & "'"
    End Select

    Dim oDoc As New CGenDoc(Codetype, sRequeteSQL)
    If oDoc.p_ERROR = "" Then
      Dim ofrmVisuFic As New frmVisuDoc(oDoc.p_PathFileName)
      ofrmVisuFic.ShowDialog()
    End If

  End Sub

  Private Sub cmdMonter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMonter.Click
    ' get the index of selected row
    Dim rowIndex = grdFiche.SelectedCells(0).OwningRow.Index

    If rowIndex = 0 Then Return

    'get NCLASS précédent
    Dim NCLASS_PREC As Int32 = Int32.Parse(grdFiche.Rows(rowIndex - 1).Cells(2).Value.ToString())
    Dim NCLASS_TO_MOVE As Int32 = Int32.Parse(grdFiche.Rows(rowIndex).Cells(2).Value.ToString())

    'create a new row
    Dim row As DataRow
    row = dsGrid.Tables(0).NewRow()

    ' add data to the row 
    row(0) = Int32.Parse(grdFiche.Rows(rowIndex).Cells(1).Value.ToString())     'NIDFICHE
    row(1) = NCLASS_PREC
    row(2) = grdFiche.Rows(rowIndex).Cells(3).Value.ToString() 'VLIB
    row(3) = If(grdFiche.Rows(rowIndex).Cells(4).Value.ToString() = "", DBNull.Value, Int32.Parse(grdFiche.Rows(rowIndex).Cells(4).Value.ToString())) 'NVAL
    row(4) = If(grdFiche.Rows(rowIndex).Cells(5).Value.ToString() = "", DBNull.Value, grdFiche.Rows(rowIndex).Cells(5).Value.ToString()) 'DDEB
    row(5) = If(grdFiche.Rows(rowIndex).Cells(6).Value.ToString() = "", DBNull.Value, grdFiche.Rows(rowIndex).Cells(6).Value.ToString()) 'DFIN
    row(6) = If(grdFiche.Rows(rowIndex).Cells(7).Value.ToString() = "", DBNull.Value, Int32.Parse(grdFiche.Rows(rowIndex).Cells(7).Value.ToString())) 'NVALOBJ
    row(7) = If(grdFiche.Rows(rowIndex).Cells(8).Value.ToString() = "", DBNull.Value, Int32.Parse(grdFiche.Rows(rowIndex).Cells(8).Value.ToString())) 'NIDANACHAFICTYPE

    grdFiche.Rows(rowIndex - 1).Cells(2).Value = NCLASS_TO_MOVE

    If rowIndex > 0 Then
      ' remove the selected row
      dsGrid.Tables(0).Rows.RemoveAt(rowIndex)

      ' insert the new row at a new position
      dsGrid.Tables(0).Rows.InsertAt(row, rowIndex - 1)

      'update dans la table
      Dim iTemp As Int32 = row(1)

      cmd.CommandText = "UPDATE TCHANTIERFICHE SET NCLASS = " & NCLASS_TO_MOVE.ToString & " WHERE NCLASS = " & NCLASS_PREC.ToString & " AND NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = '" & vTyp & "' AND ISNULL(NIDANACHAFICTYPE, 0 ) = " & iNIDANACHAFICTYPE
      cmd.ExecuteNonQuery()
      cmd.CommandText = "UPDATE TCHANTIERFICHE Set NCLASS = " & NCLASS_PREC.ToString & " WHERE NIDFICHE = " & row(0).ToString
      cmd.ExecuteNonQuery()

      dsGrid.AcceptChanges()
      grdFiche.ClearSelection()

      grdFiche.Rows(rowIndex - 1).Selected = True

    End If

  End Sub

  Private Sub cmdDescendre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDescendre.Click
    ' get the index of selected row
    Dim rowIndex = grdFiche.SelectedCells(0).OwningRow.Index

    If rowIndex + 1 >= grdFiche.RowCount Then Return

    'get NCLASS suivant
    Dim NCLASS_NEXT As Int32 = Int32.Parse(grdFiche.Rows(rowIndex + 1).Cells(2).Value.ToString())
    Dim NCLASS_TO_MOVE As Int32 = Int32.Parse(grdFiche.Rows(rowIndex).Cells(2).Value.ToString())

    'create a new row
    Dim row As DataRow
    row = dsGrid.Tables(0).NewRow()

    ' add data to the row 
    row(0) = Int32.Parse(grdFiche.Rows(rowIndex).Cells(1).Value.ToString())     'NIDFICHE
    row(1) = NCLASS_NEXT 'NCLASS
    row(2) = grdFiche.Rows(rowIndex).Cells(3).Value.ToString() 'VLIB
    row(3) = If(grdFiche.Rows(rowIndex).Cells(4).Value.ToString() = "", DBNull.Value, Int32.Parse(grdFiche.Rows(rowIndex).Cells(4).Value.ToString())) 'NVAL
    row(4) = If(grdFiche.Rows(rowIndex).Cells(5).Value.ToString() = "", DBNull.Value, grdFiche.Rows(rowIndex).Cells(5).Value.ToString()) 'DDEB
    row(5) = If(grdFiche.Rows(rowIndex).Cells(6).Value.ToString() = "", DBNull.Value, grdFiche.Rows(rowIndex).Cells(6).Value.ToString()) 'DFIN
    row(6) = If(grdFiche.Rows(rowIndex).Cells(7).Value.ToString() = "", DBNull.Value, Int32.Parse(grdFiche.Rows(rowIndex).Cells(7).Value.ToString())) 'NVALOBJ
    row(7) = If(grdFiche.Rows(rowIndex).Cells(8).Value.ToString() = "", DBNull.Value, Int32.Parse(grdFiche.Rows(rowIndex).Cells(8).Value.ToString())) 'NIDANACHAFICTYPE

    grdFiche.Rows(rowIndex + 1).Cells(2).Value = NCLASS_TO_MOVE

    If rowIndex > 0 Then
      ' remove the selected row
      dsGrid.Tables(0).Rows.RemoveAt(rowIndex)

      ' insert the new row at a new position
      dsGrid.Tables(0).Rows.InsertAt(row, rowIndex + 1)

      'update dans la table
      Dim iTemp As Int32 = row(1)

      cmd.CommandText = "UPDATE TCHANTIERFICHE SET NCLASS = " & NCLASS_TO_MOVE.ToString & " WHERE NCLASS = " & NCLASS_NEXT.ToString & " AND NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = '" & vTyp & "' AND ISNULL(NIDANACHAFICTYPE, 0 ) = " & iNIDANACHAFICTYPE
      cmd.ExecuteNonQuery()
      cmd.CommandText = "UPDATE TCHANTIERFICHE Set NCLASS = " & NCLASS_NEXT.ToString & " WHERE NIDFICHE = " & row(0).ToString
      cmd.ExecuteNonQuery()

      dsGrid.AcceptChanges()
      grdFiche.ClearSelection()

      grdFiche.Rows(rowIndex + 1).Selected = True

    End If

  End Sub

  Private Sub grdFiche_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFiche.CellEndEdit
    Try

      Select Case grdFiche.Columns(e.ColumnIndex).DataPropertyName
        Case "VLIB"
          cmd.CommandText = "UPDATE TCHANTIERFICHE SET VLIB = '" & Replace(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString(), "'", "''") & "' WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
          cmd.ExecuteNonQuery()
        Case "NVAL"
          If IsNumeric(Replace(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString(), " ", "")) Then
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET NVAL = " & Replace(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString(), " ", "") & " WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          End If
        Case "DDEB"
          If IsDate(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value) Then
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET DDEB = '" & CStr(CDate(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString())) & "' WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          Else
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET DDEB = null  WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          End If
        Case "DFIN"
          If IsDate(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString()) Then
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET DFIN = '" & CStr(CDate(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString())) & "' WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          Else
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET DFIN = null WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          End If
        Case "NVALOBJ"
          If IsNumeric(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString()) Then
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET NVALOBJ = '" & Replace(grdFiche.CurrentRow.Cells(grdFiche.Columns(e.ColumnIndex).Name).Value.ToString(), " ", "") & "' WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          Else
            cmd.CommandText = "UPDATE TCHANTIERFICHE SET NVALOBJ = null WHERE NIDFICHE = " & grdFiche.CurrentRow.Cells(grdFiche.Columns("NIDFICHE").Name).Value.ToString()
            cmd.ExecuteNonQuery()
          End If

      End Select

      Totalsaisie()
    Catch ex As Exception
      MessageBox.Show("Erreur de saisie!", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub grdFiche_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdFiche.DataError
    MessageBox.Show(My.Resources.Global_Erreur_saisie, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
  End Sub

  Private Sub BtnChkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChkAll.Click
    setCheckState(True)
  End Sub

  Private Sub BtnUnchkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnchkAll.Click
    setCheckState(False)
  End Sub

  ' bSetCheckAll à true pour tout checker, false pour tout dé-checker
  Private Sub setCheckState(bSetCheckAll As Boolean)
    For Each oRowChkForCheck As DataGridViewRow In grdFiche.Rows
      If CType(oRowChkForCheck.Cells(0).Value, Boolean) = Not bSetCheckAll Then
        oRowChkForCheck.Cells(0).Value = bSetCheckAll
      End If
    Next
  End Sub

  '************************************************************************************************************************************
  'Permet de tester si fiche BE existe dans le chantier
  '************************************************************************************************************************************
  Private Function TestFiche(ByVal P_NIDANACHA_FICTYPE As Int32) As Boolean

    Dim sqlcmd As New SqlCommand("[api_sp_ChantierTestFiche]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NIDCHANTIER", SqlDbType.Int).Value = iNIDCHANTIER
    sqlcmd.Parameters.Add("@P_NIDANACHA_FICTYPE", SqlDbType.Int).Value = P_NIDANACHA_FICTYPE

    Select Case Convert.ToInt32(sqlcmd.ExecuteScalar)

      Case Is > 0
        Return True
      Case Else
        Return False

    End Select

  End Function

  Private Sub createFicheBE(ByVal P_NIDANACHA_FICTYPE As Int32)

    Dim sqlcmd As New SqlCommand("[api_sp_ChantierCreateFiche]", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
    sqlcmd.Parameters.Add("@P_NIDCHANTIER", SqlDbType.Int).Value = iNIDCHANTIER
    sqlcmd.Parameters.Add("@P_NIDANACHA_FICTYPE", SqlDbType.Int).Value = P_NIDANACHA_FICTYPE

    sqlcmd.ExecuteNonQuery()

  End Sub

End Class