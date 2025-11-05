Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmListeMessageWeb


  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable
  Dim sType As String
  Dim sRequete As String


  Public Sub New(ByVal c_sType As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sType = c_sType

  End Sub

  Private Sub FrmListeMessageWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      If sType = "T" Then
        initSociete()
        GLU_SOCIETE.EditValue = MozartParams.NomSociete
      End If

      ' code
      ' T tous techniciens; P contremaitres; C tous clients; A un client
      ' titre 
      Select Case sType
        Case "P"
          GrpListe.Text = My.Resources.Admin_frmDetailMessageWeb_Cont
          Me.Text = My.Resources.Admin_frmDetailMessageWeb_Cont
          GColLangue.Visible = False
          GColCli.Visible = False
        Case "T"
          GrpListe.Text = My.Resources.Admin_frmDetailMessageWeb_tech
          Me.Text = My.Resources.Admin_frmDetailMessageWeb_tech
          GColLangue.Visible = False
          GColCli.Visible = False
        Case "C"
          GrpListe.Text = My.Resources.Admin_frmDetailMessageWeb_Clients
          Me.Text = My.Resources.Admin_frmDetailMessageWeb_Clients
          GColCli.Visible = False
        Case "A"
          GrpListe.Text = My.Resources.Admin_frmDetailMessageWeb_client
          Me.Text = My.Resources.Admin_frmDetailMessageWeb_client
      End Select

      Initboutons(Me)

      Loaddata()
    End If
  End Sub

  Private Sub FrmListeMessageWeb_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oSqlConn.CloseConnexionSQL()

  End Sub

  Private Sub Loaddata()

    Try
      sRequete = String.Format("api_sp_ListeMessWeb '{0}', '{1}'", sType, GLU_SOCIETE.EditValue)
      dtListe = New DataTable
      dtListe = ModDataGridView.LoadList(sRequete, oSqlConn.CnxSQLOpen)
      GCListeFouEI.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click

    Try

      If dtListe.Rows.Count = 0 Then
        Return
      End If

      If GVlisteFouEI.FocusedRowHandle < 0 Then
        MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppresion_message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_supression_ligne, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        ' suppression dans le tableau
        Dim IDligne As Int32 = GVlisteFouEI.GetDataRow(GVlisteFouEI.GetSelectedRows(0)).Item("NWEBNUM")
        dtListe.Select("NWEBNUM=" + IDligne.ToString)(0).Delete()
        ' suppression dans la base
        Dim sqlcmdSupprLigne As New SqlCommand("delete from TINFOWEB where NWEBNUM = " & IDligne, oSqlConn.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.Text
        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

    If GVlisteFouEI.FocusedRowHandle < 0 Then

      Dim oFrmGestMessage As New FrmDetailMessageWeb(sType, 0, GLU_SOCIETE.EditValue)
      oFrmGestMessage.ShowDialog()

    Else

      Dim oFrmGestMessage As New FrmDetailMessageWeb(sType, GVlisteFouEI.GetDataRow(GVlisteFouEI.GetSelectedRows(0)).Item("NWEBNUM"), GLU_SOCIETE.EditValue)
      oFrmGestMessage.ShowDialog()

    End If

    dtListe.Clear()
    dtListe = ModDataGridView.LoadList(sRequete, oSqlConn.CnxSQLOpen)
    GCListeFouEI.DataSource = dtListe

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      Dim dtSoc As New DataTable
      Dim CmdSql As New SqlCommand("SELECT DISTINCT VSOCIETE FROM TDROIT WHERE NPERNUM = " & MozartParams.UID & " AND NMENUNUM = " & GLU_SOCIETE.Tag & " AND CDROITVAL = 'O' ORDER BY VSOCIETE", MozartDatabase.cnxMozart)
      dtSoc.Load(CmdSql.ExecuteReader)

      GLU_SOCIETE.Properties.DataSource = dtSoc

      CmdSql.Dispose()
    End If

  End Sub

  Private Sub GLU_SOCIETE_EditValueChanged(sender As Object, e As EventArgs) Handles GLU_SOCIETE.EditValueChanged
    Loaddata()
  End Sub
End Class