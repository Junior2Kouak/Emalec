Imports System.Data.SqlClient

Public Class frmAjoutDocSTFCondCom

    Dim oDRTmpNew As DataRow
    Dim sModeLoad As String
    Dim bModifDetect As Boolean
    Dim bSave As Boolean

    Public Sub New(ByVal c_oDTTmpNew As DataRow)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        If Not c_oDTTmpNew.Item("NIDDOCSTFCONDCOM") Is Nothing AndAlso c_oDTTmpNew.Item("NIDDOCSTFCONDCOM") > 0 Then
            sModeLoad = "M"
        Else
            sModeLoad = "C"
        End If

        oDRTmpNew = c_oDTTmpNew

    End Sub

    ReadOnly Property p_oDRTmpNew As DataRow
        Get
            Return oDRTmpNew
        End Get
    End Property

    ReadOnly Property p_Save As Boolean
        Get
            Return bSave
        End Get
    End Property


    Private Sub frmAjoutDocSTFCondCom_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If bModifDetect = True Then

            Select Case MessageBox.Show(My.Resources.Global_enregistrer_doc, My.Resources.Global_Confirmation_save_doc, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                Case DialogResult.Yes
                    BtnSave.PerformClick()
                    Me.Close()
                Case DialogResult.Cancel
                    e.Cancel = True
                Case Else
                    e.Cancel = False
            End Select

        End If

    End Sub

    Private Sub frmAjoutDocSTFCondCom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Init
        bModifDetect = False
        bSave = False

        If sModeLoad = "C" Then 'ouverture en création

            OuvertureEnCreation()


        Else 'ouverture en modifcation

            OuvertureEnModification()

        End If

    End Sub

    Private Sub OuvertureEnCreation()

        TxtLibelleDocInt.Text = ""
        TxtFileSrc.Text = ""
        Label3.Text = String.Format("{0}", My.Resources.Global_AjoutDoc)
        Me.Text = Label3.Text

    End Sub

    Private Sub OuvertureEnModification()

        TxtLibelleDocInt.Text = oDRTmpNew.Item("VTITLE")
        'If oDRTmpNew.Item("VFILENAME").ToString = "" Then
        '    TxtFileSrc.Text = gstrCheminProspDocInterne + oDRTmpNew.Item("VFILENAME")
        'Else 
        TxtFileSrc.Text = oDRTmpNew.Item("VFILE")
        'End If
        Label3.Text = String.Format("{0}", My.Resources.Global_ModifDoc)
        Me.Text = Label3.Text
        If TxtFileSrc.Text <> "" AndAlso File.Exists(gstrCheminDocSTFCondCom + TxtFileSrc.Text) Then

            WBApercu.Navigate(gstrCheminDocSTFCondCom + TxtFileSrc.Text)

        Else

            WBApercu.Navigate("about:blank")

        End If

    End Sub

    Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If TxtLibelleDocInt.Text = "" Then

            MessageBox.Show(My.Resources.Global_libellé_obligatoire, My.Resources.Global_Erreur_Champ_oblig, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show(My.Resources.Global_enregistrer_doc, My.Resources.Global_Confirmation_save_doc, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            If sModeLoad = "C" Then

                oDRTmpNew.Item("VTITLE") = TxtLibelleDocInt.Text
                oDRTmpNew.Item("VFILE") = TxtFileSrc.Text
                sModeLoad = "M"

            Else

                oDRTmpNew.Item("VTITLE") = TxtLibelleDocInt.Text
                oDRTmpNew.Item("VFILE") = TxtFileSrc.Text

            End If

            bModifDetect = False
            bSave = True

            Me.Close()
        End If

    End Sub

    Private Sub BtnParcourir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnParcourir.Click

        OFD.Filter = "Fichiers PDF (*.PDF)|*.pdf;"
        OFD.FileName = ""
        OFD.ShowDialog()

        If OFD.FileName <> "" Then

            TxtFileSrc.Text = OFD.FileName
            bModifDetect = True
            WBApercu.Navigate(TxtFileSrc.Text)

        End If

    End Sub

    Private Sub TxtLibelleDocInt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLibelleDocInt.KeyPress

        bModifDetect = True

    End Sub

End Class