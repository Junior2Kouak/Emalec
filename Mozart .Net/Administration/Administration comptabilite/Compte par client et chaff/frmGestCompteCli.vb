Imports System.Data.SqlClient
Imports MozartLib

Public Class frmGestCompteCli

  Dim iNCLINUM As Int32
  Dim sNomClient As String
  Dim dtCptClient As DataTable
  Dim iPos As Int32

  Public Sub New(ByVal c_iNCLINUM As Object, ByVal c_sNomClient As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNCLINUM = Convert.ToInt32(c_iNCLINUM)
    sNomClient = c_sNomClient.ToString

  End Sub

  Private Sub frmGestCompteCli_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    'Init
    Initboutons(Me)
    BtnRestaurer.Visible = False

    LoadData("O")

  End Sub

  Private Sub LoadData(ByVal p_cetat As String)

    dtCptClient = New DataTable

    If p_cetat = "O" Then
      LblTitre.Text = String.Format(My.Resources.Admin_frmGestCompteCli_GestionComptes, sNomClient)
    Else
      LblTitre.Text = String.Format(My.Resources.Admin_frmGestCompteCli_GestionCompteArchive, sNomClient)
    End If

    Dim sqlcmd As New SqlCommand("api_sp_InfoComptesclient", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    sqlcmd.Parameters.Add("@p_nclinum", SqlDbType.Int).Value = iNCLINUM
    sqlcmd.Parameters.Add("@p_cetat", SqlDbType.Char).Value = p_cetat

    dtCptClient.Load(sqlcmd.ExecuteReader)

    iPos = GVListCptByCli.FocusedRowHandle

    GCListCptByCli.DataSource = dtCptClient

    GVListCptByCli.FocusedRowHandle = iPos

  End Sub

  Private Sub BtnArchiver_Click(sender As System.Object, e As System.EventArgs) Handles BtnArchiver.Click

    If GVListCptByCli.FocusedRowHandle > -1 Then

      Dim drSelect As DataRow = GVListCptByCli.GetDataRow(GVListCptByCli.FocusedRowHandle)

      If MessageBox.Show(My.Resources.Admin_frmGestCompteCli_Archiver, My.Resources.Global_ConfirmerA, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        Dim sqlcmdArchive As New SqlCommand("api_sp_CompteClientArchiver", MozartDatabase.cnxMozart) With {
          .CommandType = CommandType.StoredProcedure
        }

        sqlcmdArchive.Parameters.Add("@p_nclinum", SqlDbType.Int).Value = iNCLINUM
        sqlcmdArchive.Parameters.Add("@p_nccannum", SqlDbType.Int).Value = drSelect.Item("NCANNUM")
        sqlcmdArchive.Parameters.Add("@p_npernum", SqlDbType.Int).Value = drSelect.Item("NPERNUM")

        sqlcmdArchive.ExecuteNonQuery()

        LoadData("O")

      End If

    End If

  End Sub

  Private Sub ChkArchives_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkArchives.CheckedChanged

    If ChkArchives.Checked Then
      BtnNew.Visible = False
      BtnModif.Visible = False
      BtnArchiver.Visible = False

      BtnRestaurer.Visible = RechercheDroitMenu(BtnRestaurer.Tag)

      LoadData("N")
    Else
      BtnNew.Visible = RechercheDroitMenu(BtnNew.Tag)
      BtnModif.Visible = RechercheDroitMenu(BtnModif.Tag)
      BtnArchiver.Visible = RechercheDroitMenu(BtnArchiver.Tag)

      BtnRestaurer.Visible = False

      LoadData("O")
    End If

  End Sub

  Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click

    Dim oFrmGestCompteClientDetail As New frmGestCompteCliDetail(iNCLINUM, sNomClient)
    oFrmGestCompteClientDetail.ShowDialog()
    If oFrmGestCompteClientDetail.Cancel = False Then LoadData("O")

  End Sub

  Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

    If GVListCptByCli.FocusedRowHandle > -1 Then

      Dim drSelect As DataRow = GVListCptByCli.GetDataRow(GVListCptByCli.FocusedRowHandle)

      Dim oFrmGestCompteClientDetail As New frmGestCompteCliDetail(iNCLINUM, sNomClient, drSelect)
      oFrmGestCompteClientDetail.ShowDialog()

      If oFrmGestCompteClientDetail.Cancel = False Then LoadData("O")

    End If

  End Sub

  Private Sub BtnRestaurer_Click(sender As System.Object, e As System.EventArgs) Handles BtnRestaurer.Click

    If GVListCptByCli.FocusedRowHandle > -1 Then

      Dim drSelect As DataRow = GVListCptByCli.GetDataRow(GVListCptByCli.FocusedRowHandle)

      ' on verifie la possibilité de restaurer ce compte pour ce chargé d'affaire
      ' la relation compte/chaff doit être unique
      Dim sqlVerif As New SqlCommand("SELECT COUNT(DISTINCT NPERNUM) FROM TCAN INNER JOIN TCLI ON TCLI.NCLINUM =  TCAN.NCLINUM WHERE TCAN.CCANACTIF = 'O' AND TCAN.NCANNUM = " & drSelect.Item("NCANNUM") & " AND TCAN.NPERNUM <> " & drSelect.Item("NPERNUM") & " AND TCLI.VSOCIETE='" & MozartParams.NomSociete.Replace("'", "''") & "'", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.Text
      }
      Dim iNbCompte As Int32 = sqlVerif.ExecuteScalar
      If iNbCompte > 1 Then
        MessageBox.Show(My.Resources.Admin_frmGestCompteCli_RestauImpossible, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
      End If

      If MessageBox.Show(My.Resources.Admin_frmGestCompteCli_restaurerCompte, My.Resources.Global_ConfirmerR, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        Dim sqlcmdArchive As New SqlCommand("api_sp_CompteClientRestaurer", MozartDatabase.cnxMozart)
        sqlcmdArchive.CommandType = CommandType.StoredProcedure

        sqlcmdArchive.Parameters.Add("@p_nclinum", SqlDbType.Int).Value = iNCLINUM
        sqlcmdArchive.Parameters.Add("@p_nccannum", SqlDbType.Int).Value = drSelect.Item("NCANNUM")
        sqlcmdArchive.Parameters.Add("@p_npernum", SqlDbType.Int).Value = drSelect.Item("NPERNUM")

        sqlcmdArchive.ExecuteNonQuery()

        LoadData("N")

      End If

    End If

  End Sub

  Private Sub btnLienFiliale_Click(sender As Object, e As EventArgs) Handles btnLienFiliale.Click

    Dim oFrmGestClientLie As New frmGestClientLie(iNCLINUM, sNomClient)
    oFrmGestClientLie.ShowDialog()

  End Sub

End Class
