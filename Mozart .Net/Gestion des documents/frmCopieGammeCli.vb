Imports System.Data.SqlClient
Imports MozartLib

Public Class frmCopieGammeCli

  Dim ntraclinum As String
  Dim ntypecontrat As Integer
  Dim ngamtramenum As New List(Of Integer)
  Dim vgamtype As String
  Dim dtraclidat As String
  Dim ctracliactif As String
  Dim ntraemanum As Integer
  Dim vtraclidet As String
  Dim vtypecontrat As String
  Dim bstocklie As String
  Dim vfichier As String


  Public Sub New(ByVal _NTRACLINUM As String)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ntraclinum = _NTRACLINUM

  End Sub

  Private Sub initSociete()
    'initialisation de le combobox "Société"
    Dim i As Integer = 0

    Dim dtSoc As New DataTable

    dtSoc.Columns.Add("VSOCIETE", Type.GetType("System.String"))
    dtSoc.Columns.Add("NCLINUM", Type.GetType("System.Int32"))

    If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

      ' TB SAMSIC CITY SPEC
      Dim sqlRequest As String = ""

      If MozartParams.NomGroupe = "EMALEC" Then
        sqlRequest = "SELECT DISTINCT TDROIT.VSOCIETE, NCLINUM FROM TDROIT inner join tcli on tcli.vsociete = tdroit.vsociete where ((tcli.vclinom = 'EMALEC' AND tdroit.vsociete NOT IN ('EMALECIDF', 'EMALECFACILITEAM')) OR (tcli.vclinom = 'EMALEC - DIVERS CLIENTS CURATIFS' AND tdroit.vsociete = 'EMALECIDF') OR (tcli.vclinom = 'EMALEC France' AND tdroit.vsociete = 'EMALECFACILITEAM')) and tdroit.vsociete <> app_name() ORDER BY VSOCIETE"
      End If ' TODO_TB SAMSIC CITY -> Requête pour samsic

      Dim CmdSql As New SqlCommand(sqlRequest, MozartDatabase.cnxMozart)

      Dim dr As SqlDataReader = CmdSql.ExecuteReader
      While dr.Read() 'While données présentes, stocker les éléments en combobox
        Dim drnew As DataRow = dtSoc.NewRow
        drnew.Item("VSOCIETE") = dr("VSOCIETE")
        drnew.Item("NCLINUM") = dr("NCLINUM")

        dtSoc.Rows.Add(drnew)

        i = i + 1
      End While

      ComboBoxSociete.Properties.DataSource = dtSoc

      dr.Close()
      CmdSql.Dispose()
      dr = Nothing

    End If

  End Sub

  Private Sub frmCopieGammeCli_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    ' Load
    Label3.Text = Label3.Text.Replace("#gstrNomGroupe#", MozartParams.NomGroupe)
    initSociete()

    Try

      Me.Cursor = Cursors.WaitCursor
      'on ouvre la connexion
      If MozartDatabase.cnxMozart.State = ConnectionState.Open Then

        Dim CmdSql As New SqlCommand("select * from TGAMCLIENT where NTRACLINUM = " & ntraclinum, MozartDatabase.cnxMozart)
        Dim dr As SqlDataReader = CmdSql.ExecuteReader

        If dr.HasRows = True Then
          dr.Read()
          LabelDetailsGamme.Text = dr("VGAMTYPE").ToString
          LabelNumGamme.Text = dr("NTRACLINUM").ToString
          ntypecontrat = dr("NTYPECONTRAT")
          vgamtype = dr("VGAMTYPE").ToString
          dtraclidat = dr("DTRACLIDAT").ToString
          ctracliactif = dr("CTRACLIACTIF").ToString
          ntraemanum = dr("NTRAEMANUM")
          vtraclidet = dr("VTRACLIDET").ToString
          vtypecontrat = dr("VTYPECONTRAT").ToString
          bstocklie = dr("BSTOCKLIE").ToString
          vfichier = dr("VFICHIER").ToString
          ngamtramenum.Add(dr("NGAMTRAMENUM"))

          While (dr.Read())
            ngamtramenum.Add(dr("NGAMTRAMENUM"))
          End While
          dr.Close()
          CmdSql.Dispose()

        End If

      End If
    Catch ex As Exception
      MessageBox.Show(My.Resources.GestionDesDocument_frmCopiesGammeCli_SubLoad + ex.Message, My.Resources.Global_Erreur)
    Finally
      Me.Cursor = Cursors.Default
    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    If ComboBoxSociete.Text = "" Then Exit Sub

    ' Confirmation
    If MsgBox(My.Resources.GestionDesDocument_frmCopiesGammeCli_dupliquerGamme & ComboBoxSociete.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, My.Resources.Global_Confirmation) = vbNo Then Exit Sub

    ' Vérifier la présence du contrat dans la société EMALEC réceptrice
    Dim CmdSql As New SqlCommand("select * from TCONTRATCLI where ntypecontrat = " & ntypecontrat & " and NCLINUM = " & ComboBoxSociete.EditValue, MozartDatabase.cnxMozart)
    Dim dr As SqlDataReader = CmdSql.ExecuteReader
    Dim sSql As String

    If dr.HasRows = True Then

      dr.Close()
      Try

        Dim nvCheminfichier As String = ""

        ' Duplication
        Dim CmdSql2 As New SqlCommand("select max(NTRACLINUM) as ntraclinum from TGAMCLIENT", MozartDatabase.cnxMozart)
        Dim dr2 As SqlDataReader = CmdSql2.ExecuteReader
        dr2.Read()
        Dim index As Integer = dr2("ntraclinum")
        index = index + 1
        dr2.Close()
        CmdSql2.Dispose()

        If vfichier <> DBNull.Value.ToString Then
          Dim pathNvCheminfichier As String = ModuleData.RechercheParam("REP_MODELES", ComboBoxSociete.Text)
          nvCheminfichier = vfichier.Replace(MozartParams.CheminModeles, pathNvCheminfichier)
          nvCheminfichier = nvCheminfichier.Replace(LabelNumGamme.Text, index.ToString)

          ' Copie physique du fichier lié
          File.Copy(vfichier, nvCheminfichier, True)
        End If

        For i = 0 To ngamtramenum.Count - 1
          If vfichier <> DBNull.Value.ToString Then
            sSql = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE, NTYPECONTRAT, VFICHIER) "
          Else
            sSql = "insert into TGAMCLIENT (NTRACLINUM, NCLINUM,  NGAMTRAMENUM, VGAMTYPE, DTRACLIDAT, NTRAEMANUM, CTRACLIACTIF, BSTOCKLIE, NTYPECONTRAT) "
          End If

          sSql = sSql & "Values ( " & index & ", " & ComboBoxSociete.EditValue & ", " & ngamtramenum.ElementAt(i) & ", '" & Replace(vgamtype, "'", "''") & "', '"
          sSql = sSql & Today() & "', " & ntraemanum & ", 'O', " & IIf(bstocklie.ToLower = "false", "0", "1") & ", " & ntypecontrat
          If (nvCheminfichier <> "") Then
            sSql = sSql & ", '" & nvCheminfichier & "')"
          Else
            sSql = sSql & ")"
          End If

          Dim sqlCreate As New SqlCommand(sSql, MozartDatabase.cnxMozart)
          sqlCreate.ExecuteNonQuery()
          sqlCreate.Dispose()
        Next i

        MsgBox(My.Resources.GestionDesDocument_frmCopiesGammeCli_duplication, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "OK")
        Me.Close()
      Catch ex As Exception
        MsgBox(My.Resources.GestionDesDocument_frmCopiesGammeCli_Erreur_duplication & ex.Message)
      End Try

    Else
      ' Erreur
      dr.Close()
      MsgBox(My.Resources.GestionDesDocument_frmCopiesGammeCli_affecter_contrat.Replace("#gstrNomGroupe#", MozartParams.NomGroupe) & ComboBoxSociete.Text & ".", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, My.Resources.Global_Erreur)
    End If

  End Sub
End Class