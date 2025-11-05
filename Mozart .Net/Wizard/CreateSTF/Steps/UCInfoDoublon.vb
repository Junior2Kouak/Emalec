Imports System.Data.SqlClient
Imports MozartLib

Public Class UCInfoDoublon

  Private Sub UCInfoDoublon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



  End Sub

  Public Sub VerifDoublonSTF(ByVal p_strSTFNom As String)

    'INIT
    LblTitre.Text = "Liste des sociétés dont le nom est proche de : " & p_strSTFNom
    LstDoublon.Items.Clear()

    'TSTFGRP
    Dim Sqlcmd As New SqlCommand("SELECT VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, VSTFGRPCP, VSTFGRPVIL FROM TSTFGRP WITH (NOLOCK) WHERE VSTFGRPNOM LIKE '%" & p_strSTFNom.Replace("'", "''") & "%' ORDER BY VSTFGRPNOM", MozartDatabase.cnxMozart)
    Dim DRSQL As SqlDataReader = Sqlcmd.ExecuteReader()

        If DRSQL.HasRows Then

            While DRSQL.Read
                LstDoublon.Items.Add(String.Format("GROUPE STF : {0} {1} {2} {3} {4}", DRSQL.Item("VSTFGRPNOM"), DRSQL.Item("VSTFGRPAD1"), DRSQL.Item("VSTFGRPAD2"), DRSQL.Item("VSTFGRPCP"), DRSQL.Item("VSTFGRPVIL")))
            End While

        End If

        DRSQL.Close()

    'TSTF
    Sqlcmd = New SqlCommand("SELECT VSTFGRPNOM, VSTFNOM, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL FROM TSTF WITH (NOLOCK) INNER JOIN TSTFGRP WITH (NOLOCK) ON TSTFGRP.NSTFGRPNUM = TSTF.NSTFGRPNUM WHERE VSTFNOM LIKE '%" & p_strSTFNom.Replace("'", "''") & "%' ORDER BY VSTFNOM", MozartDatabase.cnxMozart)
    DRSQL = Sqlcmd.ExecuteReader()


        If DRSQL.HasRows Then

            While DRSQL.Read
                LstDoublon.Items.Add(String.Format("SITE STF : {0} {1} {2} {3} {4} {5}", DRSQL.Item("VSTFGRPNOM"), DRSQL.Item("VSTFNOM"), DRSQL.Item("VSTFAD1"), DRSQL.Item("VSTFAD2"), DRSQL.Item("VSTFCP"), DRSQL.Item("VSTFVIL")))
            End While

        End If

        DRSQL.Close()


        'si pas de doublon
        If LstDoublon.Items.Count = 0 Then LstDoublon.Items.Add("Aucune doublon détecté")

    End Sub

End Class
