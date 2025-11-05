Imports System.Data.SqlClient
Imports MozartLib

Public Class frmChoixFiche

  Private iNIDCHANTIER As Int32

  Public Sub New(ByVal c_INIDCHANTIER As Int32, ByVal c_bGreenBtnFO As Boolean, ByVal c_bGreenBtnHR As Boolean, ByVal c_bGreenBtnSTT As Boolean,
                 ByVal c_bGreenBtnBE As Boolean, ByVal c_bGreenBtnCHAFF As Boolean)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    If c_bGreenBtnFO Then
      btnFO.BackColor = Color.GreenYellow
    Else
      btnFO.BackColor = Color.Transparent
    End If

    If c_bGreenBtnHR Then
      btnHeures.BackColor = Color.GreenYellow
      btnHeuresTechMeca.BackColor = Color.GreenYellow
      btnHeuresTechCabl.BackColor = Color.GreenYellow
      btnHeuresTechAideTec.BackColor = Color.GreenYellow
    Else
      btnHeures.BackColor = Color.Transparent
      btnHeuresTechMeca.BackColor = Color.Transparent
      btnHeuresTechCabl.BackColor = Color.Transparent
      btnHeuresTechAideTec.BackColor = Color.Transparent
    End If

    If c_bGreenBtnBE Then

      btnHeuresBE.BackColor = Color.GreenYellow
      btnHeuresBE_Auto.BackColor = Color.GreenYellow
      btnHeuresBE_Elec.BackColor = Color.GreenYellow
      btnHeuresBE_Meca.BackColor = Color.GreenYellow

    Else

      btnHeuresBE.BackColor = Color.Transparent
      btnHeuresBE_Auto.BackColor = Color.Transparent
      btnHeuresBE_Elec.BackColor = Color.Transparent
      btnHeuresBE_Meca.BackColor = Color.Transparent

    End If

    If c_bGreenBtnCHAFF Then
      btnHeuresChaff.BackColor = Color.GreenYellow
    Else
      btnHeuresChaff.BackColor = Color.Transparent
    End If

    If c_bGreenBtnSTT Then btnStt.BackColor = Color.GreenYellow Else btnStt.BackColor = Color.Transparent

    iNIDCHANTIER = c_INIDCHANTIER

  End Sub

  Private Sub frmChoixFiche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub btnHeures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeures.Click

    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnFO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFO.Click

    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicF")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub
  Private Sub btnStt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStt.Click

    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicS")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub BtnHeuresTechMeca_Click(sender As Object, e As EventArgs) Handles btnHeuresTechMeca.Click

    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_TEC_MECA")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresTechCabl_Click(sender As Object, e As EventArgs) Handles btnHeuresTechCabl.Click

    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_TEC_CABL")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresTechAideTec_Click(sender As Object, e As EventArgs) Handles btnHeuresTechAideTec.Click

    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_TEC_AIDETEC")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresBE_Click(sender As Object, e As EventArgs) Handles btnHeuresBE.Click
    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_BE")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresBE_Auto_Click(sender As Object, e As EventArgs) Handles btnHeuresBE_Auto.Click
    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_BE_AUTO")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresBE_Elec_Click(sender As Object, e As EventArgs) Handles btnHeuresBE_Elec.Click
    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_BE_ELEC")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresBE_Meca_Click(sender As Object, e As EventArgs) Handles btnHeuresBE_Meca.Click
    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_BE_MECA")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub btnHeuresChaff_Click(sender As Object, e As EventArgs) Handles btnHeuresChaff.Click
    Dim oFrmFiche As New frmFiche(iNIDCHANTIER, "AnaChaFicH_CHAFF")
    oFrmFiche.ShowDialog()
    StateChantier()
  End Sub

  Private Sub StateChantier()

    Dim drTemp As SqlDataReader
    Dim iFicheH As Int32

    Dim iFicheH_Chaff As Int32
    Dim iFicheH_BE As Int32

    Dim iFicheF As Int32
    Dim iFicheS As Int32
    Dim iFO As Int32
    Dim iMO As Int32

    Dim iMO_Chaff As Int32
    Dim iMO_BE As Int32

    Dim iSTT As Int32

    ' fonction permettant de déterminer l'état du chantier
    ' chiffrage OK si au moins un découpage 
    Try

      Dim cmd As SqlCommand

      If iNIDCHANTIER > 0 Then

        ' Fiches de suivi OK si les 2 fiches sont crees
        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'H' AND NIDANACHAFICTYPE IN (5, 6, 7, 8)", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.Text
        }
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheH = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'H' AND NIDANACHAFICTYPE IN (2)", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.Text
        }
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheH_Chaff = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'H' AND NIDANACHAFICTYPE IN (1, 9, 10, 11)", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.Text
        }
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheH_BE = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'F'", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.Text
        }
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheF = drTemp(0)
        drTemp.Close()

        ' Fiches de suivi OK si les 2 fiches sont crees
        cmd = New SqlCommand("SELECT ISNULL(SUM(NVAL),0) FROM TCHANTIERFICHE WHERE NIDCHANTIER = " & iNIDCHANTIER & " AND VTYPE = 'S'", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.Text
        }
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iFicheS = drTemp(0)
        drTemp.Close()

        cmd = New SqlCommand("SELECT SUM(ISNULL(NMO,0)) + SUM(ISNULL(NMO_MECA,0)) + SUM(ISNULL(NMO_CABL,0)) + SUM(ISNULL(NMO_AIDETEC,0)) AS MO, " _
                                & " SUM(ISNULL(NMOBE_AUTO,0)) + SUM(ISNULL(NMOBE_ELEC,0)) + SUM(ISNULL(NMOBE_MECA,0)) + SUM(ISNULL(NMOBE,0)) AS MO_BE, " _
                                & " SUM(ISNULL(NMOCHAF,0)) AS MO_CHAFF, " _
                                & " SUM(ISNULL(NFO,0)) FO, SUM(ISNULL(NSTT,0)) STT FROM TCHANTIERCHIFFRAGE WHERE CCHIFACTIF = 'O' AND NIDCHANTIER = " & iNIDCHANTIER, MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.Text
                                }
        drTemp = cmd.ExecuteReader
        drTemp.Read()
        iMO = drTemp("MO")
        iMO_Chaff = drTemp("MO_CHAFF")
        iMO_BE = drTemp("MO_BE")
        iFO = drTemp("FO")
        iSTT = drTemp("STT")
        drTemp.Close()
      Else
        iFicheH = 0
        iFicheH_Chaff = 0
        iFicheH_BE = 0
        iFicheF = 0
        iFicheS = 0
        iMO = -1
        iMO_Chaff = -1
        iMO_BE = -1
        iFO = -1
        iSTT = -1
      End If

      If iMO = iFicheH Then
        btnHeures.BackColor = Color.GreenYellow
        btnHeuresTechMeca.BackColor = Color.GreenYellow
        btnHeuresTechCabl.BackColor = Color.GreenYellow
        btnHeuresTechAideTec.BackColor = Color.GreenYellow
      Else
        btnHeures.BackColor = Color.Transparent
        btnHeuresTechMeca.BackColor = Color.Transparent
        btnHeuresTechCabl.BackColor = Color.Transparent
        btnHeuresTechAideTec.BackColor = Color.Transparent
      End If

      If iMO_Chaff = iFicheH_Chaff Then
        btnHeuresChaff.BackColor = Color.GreenYellow
      Else
        btnHeuresChaff.BackColor = Color.Transparent
      End If

      If iMO_BE = iFicheH_BE Then
        btnHeuresBE.BackColor = Color.GreenYellow
        btnHeuresBE_Auto.BackColor = Color.GreenYellow
        btnHeuresBE_Elec.BackColor = Color.GreenYellow
        btnHeuresBE_Meca.BackColor = Color.GreenYellow
      Else
        btnHeuresBE.BackColor = Color.Transparent
        btnHeuresBE_Auto.BackColor = Color.Transparent
        btnHeuresBE_Elec.BackColor = Color.Transparent
        btnHeuresBE_Meca.BackColor = Color.Transparent
      End If

      If iFO = iFicheF Then
        btnFO.BackColor = Color.GreenYellow
      Else
        btnFO.BackColor = Color.Transparent
      End If

      If iSTT = iFicheS Then
        btnStt.BackColor = Color.GreenYellow
      Else
        btnStt.BackColor = Color.Transparent
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Admin_frmXlisteChiffrage_State & ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

End Class
