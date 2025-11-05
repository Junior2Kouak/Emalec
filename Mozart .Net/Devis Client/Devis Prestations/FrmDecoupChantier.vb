Imports MozartLib

Public Class FrmDecoupChantier

  Dim oCnxDetExtTemp As New CGestionSQL

  Dim iNumDevisCL As Int32

  Public Sub New(ByVal c_iNumDevisCL As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNumDevisCL = CType(c_iNumDevisCL, Int32)

  End Sub

  Private Sub FrmDecoupChantier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oCnxDetExtTemp.CloseConnexionSQL()

  End Sub

  Private Sub FrmDecoupChantier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Try

      'on charge la liste des fournitures série extincteurs
      If oCnxDetExtTemp.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

        GCDEVIS.DataSource = LoadList(String.Format("exec api_sp_DevisCLPrestDecoup {0}, '{1}'", iNumDevisCL, "P"), oCnxDetExtTemp.CnxSQLOpen)

        GCSERIE.DataSource = LoadList(String.Format("exec api_sp_DevisCLPrestDecoup {0}, '{1}'", iNumDevisCL, "S"), oCnxDetExtTemp.CnxSQLOpen)

        LoadDataDecoupage()

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub LoadDataDecoupage()

    Try

      'on charge la table du devis qu' on va ensuite modelise selon les differents decoupage
      'cela permet de ne pas interroger 3 fois de suite la proc.
      Dim dtLinq As DataTable = LoadList(String.Format("exec api_sp_DevisCLPrestDecoup {0}, '{1}'", iNumDevisCL, "DECOUP"), oCnxDetExtTemp.CnxSQLOpen)

      Dim reqMO = From DecoupMO In dtLinq.AsEnumerable
                  Where Not DecoupMO.Field(Of String)("VLIBDECOUPMO") = String.Empty
                  Group DecoupMO By VLIBDECOUPMO = DecoupMO.Field(Of String)("VLIBDECOUPMO")
                  Into TotalMO = Sum((DecoupMO.Field(Of Decimal)("NQTE")) * (DecoupMO.Field(Of Decimal)("NPRESTQTEMO"))),
                       TotalFO = Sum((DecoupMO.Field(Of Decimal)("NQTE")) * (DecoupMO.Field(Of Decimal)("NPRESTQTEMO")) * (DecoupMO.Field(Of Decimal)("NPRESTSERMOHT"))),
                       TotalSTT = Sum(((DecoupMO.Field(Of Decimal)("NQTE")) * (DecoupMO.Field(Of Decimal)("NPRESTFOHT"))) + ((DecoupMO.Field(Of Decimal)("NQTE")) * (DecoupMO.Field(Of Decimal)("NPRESTQTEMO")) * (DecoupMO.Field(Of Decimal)("NPRESTSERMOHT"))))
                  Order By VLIBDECOUPMO
                  Select New With {
                                  Key VLIBDECOUPMO,
                                  .NBMO = TotalMO,
                                  .MTTFO = TotalFO,
                                  .MTTSTT = TotalSTT
                                  }

      GCDECOUPMO.DataSource = reqMO.ToList

      Dim reqFO = From DecoupFO In dtLinq.AsEnumerable
                  Where Not DecoupFO.Field(Of String)("VLIBDECOUPFO") = String.Empty
                  Group DecoupFO By VLIBDECOUPFO = DecoupFO.Field(Of String)("VLIBDECOUPFO")
                  Into TotalMO = Sum((DecoupFO.Field(Of Decimal)("NQTE")) * (DecoupFO.Field(Of Decimal)("NPRESTQTEMO"))),
                       TotalFO = Sum((DecoupFO.Field(Of Decimal)("NQTE")) * (DecoupFO.Field(Of Decimal)("NPRESTFOHT"))),
                       TotalSTT = Sum(((DecoupFO.Field(Of Decimal)("NQTE")) * (DecoupFO.Field(Of Decimal)("NPRESTFOHT"))) + ((DecoupFO.Field(Of Decimal)("NQTE")) * (DecoupFO.Field(Of Decimal)("NPRESTQTEMO")) * (DecoupFO.Field(Of Decimal)("NPRESTSERMOHT"))))
                  Order By VLIBDECOUPFO
                  Select New With {
                                  Key VLIBDECOUPFO,
                                  .NBMO = TotalMO,
                                  .MTTFO = TotalFO,
                                  .MTTSTT = TotalSTT
                                  }

      GCDECOUPFO.DataSource = reqFO.ToList

      '*****************************************************
      'Pour le decoupage par STT : 
      'voici la condition : le libellé du découpage MO = libellé Découpage FO
      Dim reqSTT = From DecoupSTT In dtLinq.AsEnumerable
                   Where DecoupSTT.Field(Of String)("VLIBDECOUPFO") = DecoupSTT.Field(Of String)("VLIBDECOUPMO") And Not DecoupSTT.Field(Of String)("VLIBDECOUPFO") = String.Empty
                   Group DecoupSTT By VLIBDECOUPSTT = DecoupSTT.Field(Of String)("VLIBDECOUPFO")
                   Into TotalMO = Sum((DecoupSTT.Field(Of Decimal)("NQTE")) * (DecoupSTT.Field(Of Decimal)("NPRESTQTEMO"))),
                        TotalFO = Sum((DecoupSTT.Field(Of Decimal)("NQTE")) * (DecoupSTT.Field(Of Decimal)("NPRESTFOHT"))),
                        TotalSTT = Sum(((DecoupSTT.Field(Of Decimal)("NQTE")) * (DecoupSTT.Field(Of Decimal)("NPRESTFOHT"))) + ((DecoupSTT.Field(Of Decimal)("NQTE")) * (DecoupSTT.Field(Of Decimal)("NPRESTQTEMO")) * (DecoupSTT.Field(Of Decimal)("NPRESTSERMOHT"))))
                   Order By VLIBDECOUPSTT
                   Select New With {
                                   Key VLIBDECOUPSTT,
                                   .NBMO = TotalMO,
                                   .MTTFO = TotalFO,
                                   .MTTSTT = TotalSTT
                                   }

      GCDECOUPSTT.DataSource = reqSTT.ToList


    Catch ex As Exception
      MessageBox.Show(ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnColletionExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportDevisXLS.Click, BtnExportSerieXLS.Click, BtnExportDecoupMOXLS.Click, BtnExportDecoupFOXLS.Click, BtnExportDecoupSTTXLS.Click

    SFD.Filter = "Fichiers EXCEL (*.xls)|*.xls"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then

      Select Case CType(sender, Button).Name
        Case "BtnExportDevisXLS"
          GCDEVIS.ExportToXls(SFD.FileName)
        Case "BtnExportSerieXLS"
          GCSERIE.ExportToXls(SFD.FileName)
        Case "BtnExportDecoupMOXLS"
          GCDECOUPMO.ExportToXls(SFD.FileName)
        Case "BtnExportDecoupFOXLS"
          GCDECOUPFO.ExportToXls(SFD.FileName)
        Case "BtnExportDecoupSTTXLS"
          GCDECOUPSTT.ExportToXls(SFD.FileName)
        Case Else
          MessageBox.Show(My.Resources.Devis_Client_FrmDecoupChantier_nom_bouton, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Select

    End If

  End Sub

  Private Sub BtnExportXLSTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    SFD.Filter = "Fichiers EXCEL (*.xls)|*.xls"
    SFD.ShowDialog()

    If SFD.FileName <> "" Then

      GCSERIE.ExportToXls(SFD.FileName)

    End If

  End Sub

End Class