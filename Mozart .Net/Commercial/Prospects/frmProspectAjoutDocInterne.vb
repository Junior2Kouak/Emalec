Public Class frmProspectAjoutDocInterne

    Dim oDRTmpNew As DataRow 
    Dim sModeLoad As String
    Dim dtProspDocInterneTmp As DataTable 
    Dim bModifDetect As Boolean 

    Public Sub new(ByVal c_oDTTmpNew As Datarow, Optional ByVal c_dtProspDocInterne As Datatable = nothing)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        If Not c_dtProspDocInterne Is Nothing Then

            dtProspDocInterneTmp = c_dtProspDocInterne
            sModeLoad = "C"
        Else
            sModeLoad = "M"
        End If

        oDRTmpNew = c_oDTTmpNew

    End Sub

    Private Sub frmProspectAjoutDocInterne_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

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

    Private Sub frmProspectAjoutDocInterne_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        'Init
        bModifDetect = false

        If sModeLoad = "C" Then 'ouverture en création
            
            OuvertureEnCreation
            

        Else 'ouverture en modifcation

            OuvertureEnModification
            
        End If

    End Sub

    Private Sub OuvertureEnCreation()

        TxtLibelleDocInt.Text = ""
        TxtFileSrc.Text = ""
        Label3.Text = String.Format("{0}", My.Resources.Commercial_fromProspectAjoutDocInterne_ajout)
        Me.Text = Label3.Text

    End Sub

    Private Sub OuvertureEnModification()

        TxtLibelleDocInt.Text = oDRTmpNew.Item("VLIBDOC")
        'If oDRTmpNew.Item("VFILENAME").ToString = "" Then
        '    TxtFileSrc.Text = gstrCheminProspDocInterne + oDRTmpNew.Item("VFILENAME")
        'Else 
        TxtFileSrc.Text = oDRTmpNew.Item("VFILENAME")
        'End If
        Label3.Text = String.Format("{0}", My.Resources.Global_DocInterne_modif)
        Me.Text = Label3.Text
        If TxtFileSrc.Text <> "" AndAlso File.Exists(TxtFileSrc.Text) Then
            
            WBApercu.Navigate(TxtFileSrc.Text)

        Else

            WBApercu.Navigate("about:blank")

        End If
        
    End Sub
    
    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.Close

    End Sub

    Private Sub BtnSave_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnSave.Click

        If TxtLibelleDocInt.Text = "" Then

            MessageBox.Show(My.Resources.Global_libellé_obligatoire, My.Resources.Global_Erreur_Champ_oblig, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit sub
        End If

        'oGestProspDocInt.CreateDocInterne(oDataRowDocInterne, TxtLibelleDocInt.Text, TxtFileSrc.Text)

        'If MessageBox.Show("Voulez-vous enregistrer ce document ?", "Confirmation enregistrement document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then

            If sModeLoad = "C" Then

                oDRTmpNew.Item("VLIBDOC") = TxtLibelleDocInt.Text 
                oDRTmpNew.Item("VFILENAME") = TxtFileSrc.Text 

                dtProspDocInterneTmp.Rows.Add(oDRTmpNew) 
                sModeLoad = "M"

            Else

                oDRTmpNew.Item("VLIBDOC") = TxtLibelleDocInt.Text 
                oDRTmpNew.Item("VFILENAME") = TxtFileSrc.Text 

            end if   
                           
            'oDTTmpNew.Rows.Add(oDataRowTmpNew)

            'MessageBox.Show("Le document a été créé avec succès !", "Création équipement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Close             

            bModifDetect = false 

        'End If

    End Sub
    
    Private Sub BtnParcourir_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnParcourir.Click

        OFD.Filter = "Fichiers PDF (*.PDF)|*.pdf;" 
        OFD.FileName = ""
        OFD.ShowDialog
        
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