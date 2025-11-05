Imports System.Data.SqlClient
Imports MozartLib

Public Class frmQCMNewRep

  Dim sLibQuestion As String
  Dim iQCMQuestionID As Integer
  Dim oCnxQCMNewRep As New CGestionSQL
  Dim iNQCMTYPE As Int16

  Dim iNID As Integer
  Dim iNIDQCMREPONSE As Integer
  Dim iNIDQCMREPONSEORDER As Integer
  Dim BQCMREPONSEACTIF As Boolean

  Dim DataRowRepNew As DataRow
  Dim strStatut As String

  Dim bChangeDetect As Boolean

  Public Sub New(ByVal c_iNQCMTYPE As Int16)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNQCMTYPE = c_iNQCMTYPE

  End Sub

  Public Property P_DataRowRepNew As DataRow
    Get
      Return DataRowRepNew
    End Get
    Set(ByVal value As DataRow)
      DataRowRepNew = value
    End Set
  End Property

  Public Property sLibQuestionParam As String
    Get
      Return sLibQuestion
    End Get
    Set(ByVal value As String)
      If sLibQuestion = value Then
        Return
      End If
      sLibQuestion = value
    End Set
  End Property

  Public Property p_strStatut As String
    Get
      Return strStatut
    End Get
    Set(ByVal value As String)
      If strStatut = value Then
        Return
      End If
      strStatut = value
    End Set
  End Property

  Public Property iQCMQuestionIDParam As Integer
    Get
      Return iQCMQuestionID
    End Get
    Set(ByVal value As Integer)
      If iQCMQuestionID = value Then
        Return
      End If
      iQCMQuestionID = value
    End Set
  End Property

  Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

    DataRowRepNew = Nothing
    Me.Close()

  End Sub

  Private Sub frmQCMNewRep_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oCnxQCMNewRep.CloseConnexionSQL()

  End Sub

  Private Sub frmQCMNewRep_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    If bChangeDetect = True And strStatut <> "C" Then

      Select Case MessageBox.Show(My.Resources.Global_Enregistrer_Modif, My.Resources.TestCompétance_QCMNewRep_modifier_rép, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Case DialogResult.Yes
          BtnEnregistrer.PerformClick()
          e.Cancel = False
        Case DialogResult.Cancel
          e.Cancel = True
        Case Else
          e.Cancel = False
      End Select

    End If

  End Sub

  Private Sub frmQCMNewRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'INIT
    lblQuestion.Text = sLibQuestion

    bChangeDetect = False

    If oCnxQCMNewRep.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      'on charge la combobox par oui ou non            
      Dim daCboOuiNon As New SqlDataAdapter("SELECT 0 AS ID, 'NON' AS CBOREPLIB UNION SELECT 1 AS ID, 'OUI' AS CBOREPLIB", oCnxQCMNewRep.CnxSQLOpen)
      Dim dsCboOuiNon As New DataSet

      daCboOuiNon.Fill(dsCboOuiNon)
      CboRepOblig.ValueMember = "ID"
      CboRepOblig.DisplayMember = "CBOREPLIB"
      CboRepOblig.DataSource = dsCboOuiNon.Tables(0)

      'on charge les données du datarow passé en parametre           
      If strStatut = "M" Then
        iNID = CType(DataRowRepNew.Item("ID"), Integer)
        iNIDQCMREPONSE = CType(DataRowRepNew.Item("NIDQCMREPONSE"), Integer)
        iNIDQCMREPONSEORDER = CType(DataRowRepNew.Item("NQCMREPONSEORDER"), Integer)
        BQCMREPONSEACTIF = CType(DataRowRepNew.Item("BQCMREPONSEACTIF"), Boolean)
        TxtNewReponse.Text = DataRowRepNew.Item("VQCMREPONSELIB").ToString
        CboRepOblig.SelectedValue = DataRowRepNew.Item("BQCMREPONSEVALID")
        TxtObsCorrection.Text = DataRowRepNew.Item("VQCMREPONSEOBSCORRECT")

      Else
        iNID = 0
        iNIDQCMREPONSE = 0
        iNIDQCMREPONSEORDER = 0
        BQCMREPONSEACTIF = True
        TxtNewReponse.Text = ""
        CboRepOblig.SelectedValue = 0
      End If

      ''gestion affichage de la form selon le type de qcm
      'If iNQCMTYPE = 2 then

      '    LblLeg2.Visible = False 
      '    CboRepOblig.Visible = False 

      'End If


    End If

  End Sub

  Private Sub AjouterNewRep(ByVal iIDTmp As Integer, ByVal NIDQCMREPONSE As Integer, ByVal NQCMREPONSEORDER As Integer, ByVal VQCMREPONSELIB As String, ByVal BQCMREPONSEVALID As Boolean, ByVal BQCMREPONSEACTIF As Boolean, ByVal VQCMREPONSEOBSCORRECT As String)

    Try

      'If Messagebox.Show("Voulez-vous vraiment ajouter cette réponse ?", "Confirmation création réponse", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = vbYes Then

      'Dim Cmd As New SqlCommand("api_sp_QCMCreateReponse", oCnxQCMNewRep.CnxSQLOpen)
      'Cmd.CommandType = CommandType.StoredProcedure

      'Dim P_NDIQCM As SqlParameter = Cmd.Parameters.Add("@p_nidqcmquestion", SqlDbType.Int)
      'P_NDIQCM.Value = iQCMQuestionNum
      'Dim P_VQCMREPONSELIB As SqlParameter = Cmd.Parameters.Add("@p_vqcmreponselib", SqlDbType.varchar)
      'P_VQCMREPONSELIB.Value = sQCMRepLib
      ' Dim P_BACMREPONSEVALID As SqlParameter = Cmd.Parameters.Add("@p_bacmreponsevalid", SqlDbType.Int)
      'P_BACMREPONSEVALID.Value = iQCMRepOblig

      'Cmd.ExecuteNonQuery()                 
      DataRowRepNew.Item("NIDQCMREPONSE") = NIDQCMREPONSE
      DataRowRepNew.Item("NQCMREPONSEORDER") = NQCMREPONSEORDER
      DataRowRepNew.Item("VQCMREPONSELIB") = VQCMREPONSELIB
      DataRowRepNew.Item("BQCMREPONSEVALID") = BQCMREPONSEVALID
      DataRowRepNew.Item("BQCMREPONSEACTIF") = BQCMREPONSEACTIF
      DataRowRepNew.Item("VQCMREPONSEOBSCORRECT") = VQCMREPONSEOBSCORRECT

      'End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.TestCompétance_QCMNewRep_Sub + ex.Message, My.Resources.Global_Erreur)
    End Try

  End Sub

  Private Sub BtnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnregistrer.Click

    If String.IsNullOrWhiteSpace(TxtNewReponse.Text) = False Then

      AjouterNewRep(iNID, iNIDQCMREPONSE, iNIDQCMREPONSEORDER, TxtNewReponse.Text, CType(CboRepOblig.SelectedValue, Boolean), BQCMREPONSEACTIF, TxtObsCorrection.Text)
      bChangeDetect = False
      Me.Close()

    Else

      MessageBox.Show(My.Resources.TestCompétance_QCMNewRep_Saisir_rép, My.Resources.TestCompétance_QCMNewRep_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      TxtNewReponse.Focus()
      TxtNewReponse.BackColor = Color.Yellow

    End If

  End Sub

  Private Sub TxtNewReponse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNewReponse.KeyPress

    If String.IsNullOrWhiteSpace(TxtNewReponse.Text) = False And TxtNewReponse.BackColor = Color.Yellow Then
      TxtNewReponse.BackColor = Color.White
    End If

    bChangeDetect = True

  End Sub

  Private Sub TxtNewReponse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewReponse.TextChanged

    'If String.IsNullOrWhiteSpace(TxtNewReponse.Text) = False and txtNewReponse.BackColor = Color.Yellow  Then
    '    txtNewReponse.BackColor = Color.White 
    'End If

    'bChangeDetect = True 

  End Sub

  Private Sub CboRepOblig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboRepOblig.SelectedIndexChanged
    'bChangeDetect = True 
  End Sub

End Class