
Public Class frmGTPAuditDetail      
   
    Dim iNGTPAUDILTID As Int32 
    Dim oGTPEquipement As CGTPAUDITL

    Public Sub new(Byval p_NGTPAUDITLID As int32, ByVal sTitre As String)
        
        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        iNGTPAUDILTID = p_NGTPAUDITLID     

        Me.Text = sTitre
        Label1.Text = sTitre  

    End Sub
    
    Private Sub frmGTPAuditDetail_Load(ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        oGTPEquipement = New CGTPAUDITL(iNGTPAUDILTID)

        GCInfoEquipement.DataSource = oGTPEquipement.GTPAuditEquipementDetail() 

        'chargement des combo de la liste
        RepItemGLNGTPETAGESTID.DataSource = oGTPEquipement.GTPAuditCboEtatGestBudg()
        RepItemGLEditNGTPTYPDEPID.DataSource = oGTPEquipement.GTPAuditCboTypeDepense()

        VGDAuditL.DataSource = oGTPEquipement.GTPAuditEquipementBudget()

    End Sub

    Private Sub BtnQuit_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnQuit.Click

        Me.close

    End Sub

End Class