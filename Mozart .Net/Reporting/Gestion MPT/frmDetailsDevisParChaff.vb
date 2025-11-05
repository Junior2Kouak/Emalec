Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailsDevisParChaff

  ReadOnly CnxAux As New CGestionSQL()
  ReadOnly numChaff, numCli As Integer
  ReadOnly dateDeb, dateFin As Date
  ReadOnly transforme As Boolean


  Public Sub New(ByVal chaff As Integer, ByVal cli As Integer, ByVal debut As Date, ByVal fin As Date, ByVal trans As Boolean)

    InitializeComponent()
    numChaff = chaff
    numCli = cli
    dateDeb = debut
    dateFin = fin
    transforme = trans

  End Sub

  Private Sub frmDetailsDevisParChaff_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


    If transforme = True Then LblCreesTranformes.Text = My.Resources.Reporting_RealisationMPT_frmDetailsDevisParChaff_transformes Else LblCreesTranformes.Text = My.Resources.Reporting_RealisationMPT_frmDetailsDevisParChaff_crees
    LblDteDebut.Text = dateDeb
    LblDateFin.Text = dateFin

    Using sqlRecupName As New SqlCommand(String.Format("SELECT VPERNOM + ' ' + VPERPRE AS VPERNOM FROM TPER WITH (NOLOCK) WHERE TPER.NPERNUM = {0}", numChaff), MozartDatabase.cnxMozart) With {.CommandType = CommandType.Text}
      LblNomChaff.Text = sqlRecupName.ExecuteScalar().ToString
    End Using


    Dim ds As DataSet
    Cursor = Cursors.WaitCursor

    Try

      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = False Then
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      ds = New DataSet

      Dim cmdLoadList As New SqlCommand("api_sp_StatDetailsDevisParChaffEtClient", CnxAux.CnxSQLOpen) With {.CommandType = CommandType.StoredProcedure}
      cmdLoadList.Parameters.Add("@dateDebDevis", SqlDbType.DateTime).Value = dateDeb
      cmdLoadList.Parameters.Add("@dateFinDevis", SqlDbType.DateTime).Value = dateFin
      cmdLoadList.Parameters.Add("@numcli", SqlDbType.Int).Value = numCli
      cmdLoadList.Parameters.Add("@chaff", SqlDbType.Int).Value = numChaff
      cmdLoadList.Parameters.Add("@trans", SqlDbType.Bit).Value = transforme

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GcDevis.DataSource = ds.Tables(0)
      LblCli.Text = ds.Tables(0).Rows(0)("vclinom")


    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_Devis_frmDetailsDevisParChaff_SubDevisLoad + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    Finally
      Cursor = Cursors.Default

    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFermer.Click
    Close()
  End Sub

  Private Sub GVStat_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GVStat.CustomDrawFooterCell
    e.Handled = True
    e.Appearance.BackColor = Color.Gray
    e.Appearance.ForeColor = Color.White
    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    e.Appearance.DrawBackground(e.Cache, e.Bounds)
    e.Appearance.DrawString(e.Cache, e.Info.DisplayText, e.Bounds)
  End Sub

End Class