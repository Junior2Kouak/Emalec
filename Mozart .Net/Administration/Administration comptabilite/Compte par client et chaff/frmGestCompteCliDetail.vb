Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestCompteCliDetail

  Dim sEtat As String
  Dim drSelect As DataRow
  Dim iNCLINUM As Int32
  Dim sVCLINOM As String

  Dim bCancel As Boolean
  Dim dtChaff As DataTable
  Dim dtCompte As DataTable
  Dim dtAss As DataTable
  Dim dtAssChaff As DataTable
  Dim dtFact As DataTable


  Public ReadOnly Property Cancel As Boolean
    Get
      Cancel = bCancel
    End Get
  End Property

  Public Sub New(ByVal c_NCLINUM As Int32, ByVal c_sVCLINOM As String, Optional ByVal c_drSelect As DataRow = Nothing)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sEtat = If(c_drSelect Is Nothing, "C", "M")
    iNCLINUM = c_NCLINUM
    drSelect = c_drSelect
    sVCLINOM = c_sVCLINOM

  End Sub

  Private Sub frmGestCompteCliDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    Dim sqlcmdCbo As SqlCommand

    'Init
    bCancel = False
    GrpDetailCompteAna.Text = String.Format("Client : {0}", sVCLINOM)

    'load des combos
    'chaff
    dtChaff = New DataTable
    sqlcmdCbo = New SqlCommand("SELECT NPERNUM, VPERNOM + ' ' + VPERPRE AS NOM FROM TPER WITH (NOLOCK) WHERE CPERACTIF = 'O' AND CPERTYP='CA' AND VSOCIETE = '" & MozartParams.NomSociete & "' ORDER BY  VPERNOM, VPERPRE", MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtChaff.Load(sqlcmdCbo.ExecuteReader())
    GlookUpChaff.Properties.DataSource = dtChaff

    'compte ana
    dtCompte = New DataTable
    sqlcmdCbo = New SqlCommand("SELECT NCANNUM, CAST(NCANNUM AS VARCHAR) + ' - ' + VCANLIB AS VCANLIB FROM TREF_CTEANA WITH (NOLOCK) WHERE VSOCIETE = '" & MozartParams.NomSociete & "' AND CCTEANAACTIF = 'O' ORDER BY NCANNUM", MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtCompte.Load(sqlcmdCbo.ExecuteReader())
    GlookUpCOMPTE.Properties.DataSource = dtCompte

    'assistant chaff
    dtAssChaff = New DataTable
    sqlcmdCbo = New SqlCommand("api_sp_ListePersonnelParType 'ASSCHAFF'", MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtAssChaff.Load(sqlcmdCbo.ExecuteReader())
    GlookUpASSCHAFF.Properties.DataSource = dtAssChaff

    'assistant
    dtAss = New DataTable
    sqlcmdCbo = New SqlCommand("api_sp_ListePersonnelParType 'ASS'", MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtAss.Load(sqlcmdCbo.ExecuteReader())
    GlookUpASS.Properties.DataSource = dtAss

    'facturiere
    dtFact = New DataTable
    sqlcmdCbo = New SqlCommand("api_sp_ListePersonnelParType 'FAC'", MozartDatabase.cnxMozart)
    sqlcmdCbo.CommandType = CommandType.Text
    dtFact.Load(sqlcmdCbo.ExecuteReader())
    GlookUpFACT.Properties.DataSource = dtFact

    GlookUpCOMPTE.Enabled = True

    If sEtat = "M" Then

      GlookUpChaff.EditValue = drSelect.Item("NPERNUM")
      GlookUpCOMPTE.EditValue = drSelect.Item("NCANNUM")
      GlookUpASSCHAFF.EditValue = drSelect.Item("NPERNUMASSCHAFF")
      GlookUpASS.EditValue = drSelect.Item("NPERNUMASS")
      GlookUpFACT.EditValue = drSelect.Item("NPERNUMFAC")
      ChkArchives.Checked = (drSelect.Item("CCANDEFWEBCLI") = "O")

      GlookUpCOMPTE.Enabled = False

    End If


  End Sub

  Private Sub BtnQuit_Click(sender As System.Object, e As System.EventArgs) Handles BtnQuit.Click
    bCancel = True
    Me.Close()
  End Sub

  Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

    ' règles des comptes clients
    ' un chaff peut avoir plusieurs comptes différents sur un client
    ' 2 chaff ne peuvent pas avoir le même compte sur le même client
    ' 


    If GlookUpChaff.EditValue.ToString = "" Then MessageBox.Show(My.Resources.Admin_frmGestCompteCliDetail_SelectionnezCA, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
    If GlookUpCOMPTE.EditValue.ToString = "" Then MessageBox.Show(My.Resources.Admin_frmGestCompteCliDetail_SelectionnezCompte, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub

    If sEtat = "C" Then

      ' interdir de créer un compte existant déjà sur le client
      Dim sqlVerif As New SqlCommand(String.Format("SELECT COUNT(*) AS NB FROM TCAN WITH(NOLOCK) WHERE NCANNUM = {0} AND NCLINUM = {1} ", GlookUpCOMPTE.EditValue, iNCLINUM), MozartDatabase.cnxMozart)
      sqlVerif.CommandType = CommandType.Text
      Dim iNbCompte As Int32 = sqlVerif.ExecuteScalar
      sqlVerif.Dispose()
      If iNbCompte > 0 Then
        MessageBox.Show($"{My.Resources.Admin_frmGestCompteCliDetail_Message_Impossible}{Environment.NewLine}(vérifier dans les comptes archivés)", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Return
      End If

      ' interdir de créer un chaff sur le compte d'un autre chaff (sauf les comptes de frais généraux)  
      If GlookUpCOMPTE.EditValue < 890 Then
        sqlVerif.CommandText = $"SELECT COUNT(*) AS NB FROM TCAN WITH(NOLOCK) INNER JOIN TPER ON TPER.NPERNUM=TCAN.NPERNUM 
        WHERE NCANNUM = {GlookUpCOMPTE.EditValue} AND TCAN.NPERNUM <> {GlookUpChaff.EditValue} AND CCANACTIF='O' AND VSOCIETE = '{MozartParams.NomSociete}'"
        sqlVerif.CommandType = CommandType.Text
        iNbCompte = sqlVerif.ExecuteScalar
        sqlVerif.Dispose()

        If iNbCompte > 0 Then
          MessageBox.Show($"Impossible de créer ce compte pour cette personne car un autre utilisateur est déjà associé à ce compte", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
          Return
        End If
      End If


      Dim sqlCreate As New SqlCommand(String.Format("INSERT INTO TCAN (NPERNUM, NCANNUM, NCLINUM, CCANACTIF, NPERNUMFAC, NPERNUMASSCHAFF, NPERNUMASS, CCANDEFWEBCLI) VALUES ({0}, {1}, {2}, 'O', {3}, {4}, {5}, '{6}')",
                GlookUpChaff.EditValue,
                GlookUpCOMPTE.EditValue,
                iNCLINUM,
                If(GlookUpFACT.EditValue.ToString = "", "NULL", GlookUpFACT.EditValue),
                If(GlookUpASSCHAFF.EditValue.ToString = "", "NULL", GlookUpASSCHAFF.EditValue),
                If(GlookUpASS.EditValue.ToString = "", "NULL", GlookUpASS.EditValue),
                If(ChkArchives.Checked, "O", "N")), MozartDatabase.cnxMozart)

      sqlCreate.ExecuteNonQuery()
      Me.Close()

    Else

      Try

        ' interdir de créer un chaff sur le compte d'un autre chaff (sauf les comptes de frais généraux)  
        If GlookUpCOMPTE.EditValue < 890 Then

          Dim sqlVerif As New SqlCommand($"SELECT COUNT(*) AS NB FROM TCAN WITH(NOLOCK) INNER JOIN TPER ON TPER.NPERNUM=TCAN.NPERNUM 
                    WHERE NCANNUM = {GlookUpCOMPTE.EditValue} AND TCAN.NPERNUM <> {GlookUpChaff.EditValue} AND CCANACTIF='O' AND VSOCIETE = '{MozartParams.NomSociete}'", MozartDatabase.cnxMozart)
          sqlVerif.CommandType = CommandType.Text
          Dim iNbCompte As Int32 = sqlVerif.ExecuteScalar
          sqlVerif.Dispose()
          ' on test la valeur 1 car si on a un seul compte paramétré, c'est celui que l'on est en train de modifier
          ' donc on a bien le droit.
          ' mais si il y a plusieurs comptes alors il ne faut pâs modifier.
          If iNbCompte > 1 Then
            MessageBox.Show($"Impossible de paramétrer ce compte pour cette personne car un autre utilisateur est déjà associé à ce compte", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            Return
          End If
        End If


        Dim SqlUpdate As New SqlCommand(String.Format("UPDATE TCAN SET NPERNUM = {0}, NCANNUM = {1}, NPERNUMASS = {2}, NPERNUMASSCHAFF = {3}, CCANDEFWEBCLI = '{8}', NPERNUMFAC = {4} WHERE NCLINUM = {5} AND NCANNUM = {6} AND NPERNUM = {7}",
                                                                        GlookUpChaff.EditValue,
                                                                        GlookUpCOMPTE.EditValue,
                                                                        If(GlookUpASS.EditValue.ToString = "", "NULL", GlookUpASS.EditValue),
                                                                        If(GlookUpASSCHAFF.EditValue.ToString = "", "NULL", GlookUpASSCHAFF.EditValue),
                                                                        If(GlookUpFACT.EditValue.ToString = "", "NULL", GlookUpFACT.EditValue),
                                                                        iNCLINUM,
                                                                        drSelect.Item("NCANNUM"),
                                                                        drSelect.Item("NPERNUM"),
                                                                        If(ChkArchives.Checked, "O", "N")), MozartDatabase.cnxMozart)

        SqlUpdate.ExecuteNonQuery()
        Me.Close()

      Catch ex As Exception
        MessageBox.Show($"Impossible de faire la modification car l’enregistrement existe déjà dans les archives{Environment.NewLine}Archivez cette ligne et restaurez celle qui est en archive.", My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

    End If


  End Sub

End Class
