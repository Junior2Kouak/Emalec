Imports MozartLib
Imports xls = Microsoft.Office.Interop.Excel

Public Class CGestionPlanningXLS

  Dim iNIDCHIF As Int32
  Dim sFileNameDest As String

  Public Sub New(ByVal c_NIDCHIF As Int32)

    iNIDCHIF = c_NIDCHIF
    sFileNameDest = String.Format("{0}_PLANNING_CHIFFRAGE_TRAME.xls", iNIDCHIF)

  End Sub

  Public Function ExistPlanningXLS() As Boolean

    Return File.Exists(sFileNameDest)

  End Function

  Public Sub CreateFichierPlanningXLS(ByRef p_VCLINOM As String, ByRef p_Vsociete As String)

    Dim sFileNameSrc As String = "TPLANNING_CHIFFRAGE_TRAME.xls"

    If Directory.Exists(gstrCheminChantierPlanning) = False Then Directory.CreateDirectory(gstrCheminChantierPlanning)

    If File.Exists(MozartParams.CheminModeles & "FR\" & sFileNameSrc) = False Then MessageBox.Show(String.Format("Le modèle {0} n'existe pas.", MozartParams.CheminModeles & "FR\" & sFileNameSrc), "Erreur - fichier manquant", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

    If File.Exists(gstrCheminChantierPlanning & sFileNameDest) = False Then

      File.Copy(MozartParams.CheminModeles & "FR\" & sFileNameSrc, gstrCheminChantierPlanning & sFileNameDest)

      Dim ficEXCEL As New xls.Application
      Dim WBEXCEL As xls.Workbook
      Dim SheetEXCEL As xls.Worksheet

      WBEXCEL = ficEXCEL.Workbooks.Open(gstrCheminChantierPlanning & sFileNameDest)
      SheetEXCEL = WBEXCEL.ActiveSheet

      'traitement de mise ne forme de la feuille excel
      SheetEXCEL.Cells(2, 2).Value = p_Vsociete
      SheetEXCEL.Cells(3, 2).Value = p_VCLINOM
      SheetEXCEL.Cells(4, 2).Value = ""
      SheetEXCEL.Cells(5, 2).Value = Now.Date.ToShortDateString

      SheetEXCEL.Cells(55, 1).Value = p_Vsociete

      WBEXCEL.Save()
      WBEXCEL.Close()

    End If

  End Sub

  Public Sub OpenPLanningXLS()

    Dim ficxls As New xls.Application
    Dim wksxls As xls.Workbook
    Dim feuillexls As xls.Worksheet

    Try

      If File.Exists(gstrCheminChantierPlanning & sFileNameDest) = True Then

        Dim fichier As New FileInfo(gstrCheminChantierPlanning & sFileNameDest)
        wksxls = ficxls.Workbooks.Open(gstrCheminChantierPlanning & sFileNameDest)
        feuillexls = wksxls.ActiveSheet

      End If

      ficxls.Application.Visible = True

    Catch ex As Exception
      MsgBox("Erreur OpenPLanningXLS dans CGestionPlanningXLS : " & Err.Description)
    End Try

  End Sub

End Class
