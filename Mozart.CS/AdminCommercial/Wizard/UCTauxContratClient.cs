using MozartLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  partial class UCTauxContratClient : UCWizardBase
  {
    private List<api_sp_PrixClientContrat_ListePays_Result> _ListePaysContrat;
    public List<api_sp_PrixClientContrat_ListePays_Result> ListePaysContrat
    {
      get
      {
        return _ListePaysContrat;
      }
      set
      {
        _ListePaysContrat = value;

        LoadData();
      }
    }

    private partial class TCLIPRIXTYPCONTWithVTYPECONTRAT : TCLIPRIXTYPCONT
    {
      public string VTYPECONTRAT { get; set; }
    }

    List<TCLIPRIXTYPCONTWithVTYPECONTRAT> DtListTauxContrat = new List<TCLIPRIXTYPCONTWithVTYPECONTRAT>();

    public List<TCLIPRIXTYPCONT> TCLIPRIXTYPCONTs { get; set; }

    public UCTauxContratClient() : this(null, null, null)
    {
    }

    public UCTauxContratClient(TCLI pTCliEnreg, MULTIEntities pMULTIEntities, COMMUNEntities pCOMMUNEntities) : base(pTCliEnreg, pMULTIEntities, pCOMMUNEntities)
    {
      InitializeComponent();

      ListePaysContrat = new List<api_sp_PrixClientContrat_ListePays_Result>();
    }

    public override bool VerifSaisieChamp()
    {
      TCLIPRIXTYPCONTs = new List<TCLIPRIXTYPCONT>();

      foreach (TCLIPRIXTYPCONTWithVTYPECONTRAT tCLIPRIXTYPCONT in DtListTauxContrat)
      {
        TCLIPRIXTYPCONT lCurCLIPRIXTYPCONT = new TCLIPRIXTYPCONT
        {
          NTYPECONTRAT = tCLIPRIXTYPCONT.NTYPECONTRAT,
          NCLICONTHOR = tCLIPRIXTYPCONT.NCLICONTHOR,
          NCLICONTDEP = tCLIPRIXTYPCONT.NCLICONTDEP,
          NCLICONTHORSAM = tCLIPRIXTYPCONT.NCLICONTHORSAM,
          NCLICONTHORNUIDIM = tCLIPRIXTYPCONT.NCLICONTHORNUIDIM,
          VPAYS = tCLIPRIXTYPCONT.VPAYS,
          TCLI = mTCLIEnreg
        };

        TCLIPRIXTYPCONTs.Add(lCurCLIPRIXTYPCONT);
      }

      return true;
    }

    private void LoadData()
    {
      if ((TCONTRATCLIs == null) || (TCONTRATCLIs.Count() == 0))
      {
        return;
      }

      /*
    Dim dtTauxContrat As DataTable = Nothing

    'on récupère la table des taux et prix
    If  Not oUsrCtrlTauxContratClient._DtListTauxContrat Is Nothing Then

      dtTauxContrat = oUsrCtrlTauxContratClient._DtListTauxContrat

    End If

    'on charge la table des contrats
    oUsrCtrlTauxContratClient._DtListContratSelected = oUsrCtrlContratClient._DtListContrat.Select("[BCONTRATAFFECTE] = 1").CopyToDataTable
    oUsrCtrlTauxContratClient.DtListPaysContratSelected = oUsrCtrlInfoClient.DTPaysContrat.Select("[BPAYSSELECT] = 1").CopyToDataTable

    'on charge la table des prix par contrat et par pays
    oUsrCtrlTauxContratClient.LoadDataByContratSelect()
      */

      // on charge la table des prix par contrat et par pays
      LoadDataByContratSelect();

      /*

    'si  table des prix contrat avant maj existe alors, on mets à jour ses prix
    'De meme pour les mays
    'pour ne pas resaisir le montant ou la taux déjà défini
    If Not dtTauxContrat Is Nothing Then

      Dim LstPays As List(Of String) = (From r In oUsrCtrlInfoClient.DTPaysContrat.AsEnumerable() Select r.Field(Of String)("VPAYSNOM")).ToList()

      Dim drSearch As DataRow() = Nothing

      For Each drUpdate As DataRow In oUsrCtrlTauxContratClient._DtListTauxContrat.Rows

        'on supprime le pays si non sélectionner
        If (LstPays.Contains(drUpdate.Item("VPAYS")) = False) Then

          oUsrCtrlTauxContratClient._DtListTauxContrat.Rows.Remove(drUpdate)

        Else

          drSearch = dtTauxContrat.Select(String.Format("[NTYPECONTRAT] = {0} AND [VPAYS] = '{1}'", drUpdate.Item("NTYPECONTRAT"), drUpdate.Item("VPAYS")))
          If drSearch.Count > 0 Then

            If drUpdate.Item("NCLICONTHOR") <> drSearch(0).Item("NCLICONTHOR") Then drUpdate.Item("NCLICONTHOR") = drSearch(0).Item("NCLICONTHOR")
            If drUpdate.Item("NCLICONTDEP") <> drSearch(0).Item("NCLICONTDEP") Then drUpdate.Item("NCLICONTDEP") = drSearch(0).Item("NCLICONTDEP")
            If drUpdate.Item("NCLICONTHORSAM") <> drSearch(0).Item("NCLICONTHORSAM") Then drUpdate.Item("NCLICONTHORSAM") = drSearch(0).Item("NCLICONTHORSAM")
            If drUpdate.Item("NCLICONTHORNUIDIM") <> drSearch(0).Item("NCLICONTHORNUIDIM") Then drUpdate.Item("NCLICONTHORNUIDIM") = drSearch(0).Item("NCLICONTHORNUIDIM")

          End If

        End If

      Next

      GVTauxContrat.RefreshData()

    End If
       * */

    }

    private void LoadDataByContratSelect()
    {
      DtListTauxContrat.Clear();

      // ajouter test pour chaque pays : ca forme TCLIPRIXTYPCONT
      foreach (api_sp_PrixClientContrat_ListePays_Result lTmpPays in ListePaysContrat)
      {
        foreach (TCONTRATCLI lTmpCont in TCONTRATCLIs)
        {
          TCLIPRIXTYPCONTWithVTYPECONTRAT tCLIPRIXTYPCONT = new TCLIPRIXTYPCONTWithVTYPECONTRAT
          {
            VPAYS = lTmpPays.VPAYSNOM,
            NTYPECONTRAT = lTmpCont.NTYPECONTRAT,
            VTYPECONTRAT = mCOMMUNEntities.TREF_TYPECONTRAT.First(x => x.NTYPECONTRAT == lTmpCont.NTYPECONTRAT).VTYPECONTRAT,
            NCLICONTHOR = 53,
            NCLICONTDEP = 85,
            NCLICONTHORSAM = (decimal?)2.5,
            NCLICONTHORNUIDIM = (decimal?)2.5
          };

          DtListTauxContrat.Add(tCLIPRIXTYPCONT);
        }
      }

      GCTauxContrat.DataSource = DtListTauxContrat;
    }

    private void GVTauxContrat_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
      /*
        Private Sub GVTauxContrat_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GVTauxContrat.CustomDrawCell
          If Not e.Column Is Nothing AndAlso (e.Column.FieldName = "NCLICONTHOR" Or e.Column.FieldName = "NCLICONTDEP" Or e.Column.FieldName = "NCLICONTHORSAM" Or e.Column.FieldName = "NCLICONTHORNUIDIM") Then
            If ListButtonFooter.Count > 0 Then
              If ListButtonFooter.Exists(Function(xName) xName.Name = e.Column.FieldName + "_Coef") = False Then

                Dim BtnAppliq As New Button

                BtnAppliq.Location = New Point(GCTauxContrat.Location.X + e.Bounds.Left, GCTauxContrat.Location.Y + GCTauxContrat.Size.Height)
                BtnAppliq.Size = New Size(e.Column.VisibleWidth, 40)
                BtnAppliq.Visible = True
                BtnAppliq.Text = If(e.Column.FieldName = "NCLICONTHOR" Or e.Column.FieldName = "NCLICONTDEP", My.Resources.WizardClient_UCTauxContratClient_BtnAppliq_LibeColonneMtt, My.Resources.WizardClient_UCTauxContratClient_BtnAppliq_LibeColonneCoef)
                BtnAppliq.Name = e.Column.FieldName + "_Coef"
                BtnAppliq.BackColor = Color.LightGray
                BtnAppliq.Tag = e.Column.GetTextCaption

                AddHandler BtnAppliq.Click, AddressOf Click_AppliqueCoef

                Me.Controls.Add(BtnAppliq)

                ListButtonFooter.Add(BtnAppliq)

              Else

                ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Coef").Location = New Point(GCTauxContrat.Location.X + e.Bounds.Left, GCTauxContrat.Location.Y + GCTauxContrat.Size.Height)
                ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Coef").Size = New Size(e.Column.VisibleWidth, 40)
                ListButtonFooter.Find(Function(xName) xName.Name = e.Column.FieldName + "_Coef").Visible = True

              End If

            Else

              Dim BtnAppliq As New Button

              BtnAppliq.Location = New Point(GCTauxContrat.Location.X + e.Bounds.Left, GCTauxContrat.Location.Y + GCTauxContrat.Size.Height)
              BtnAppliq.Size = New Size(e.Column.VisibleWidth, 40)
              BtnAppliq.Visible = True
              BtnAppliq.Text = If(e.Column.FieldName = "NCLICONTHOR" Or e.Column.FieldName = "NCLICONTDEP", My.Resources.WizardClient_UCTauxContratClient_BtnAppliq_LibeColonneMtt, My.Resources.WizardClient_UCTauxContratClient_BtnAppliq_LibeColonneCoef)
              BtnAppliq.Name = e.Column.FieldName + "_Coef"
              BtnAppliq.BackColor = Color.LightGray
              BtnAppliq.Tag = e.Column.GetTextCaption

              AddHandler BtnAppliq.Click, AddressOf Click_AppliqueCoef

              Me.Controls.Add(BtnAppliq)

              ListButtonFooter.Add(BtnAppliq)

            End If

            'e.Handled = True

          End If
        End Sub
          */
    }

    private void RepositoryItemTextEdit1_Enter(object sender, EventArgs e)
    {
      /*
        Private Sub RepositoryItemTextEdit1_Enter(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit1.Enter

          Dim edit As TextEdit = TryCast(sender, TextEdit)
          BeginInvoke(New MethodInvoker(Sub()
                                          edit.SelectAll()
                                        End Sub))

        End Sub
          */
    }

    private void RepositoryItemTextEdit1_MouseDown(object sender, MouseEventArgs e)
    {
      /*
        Private Sub RepositoryItemTextEdit1_MouseDown(sender As Object, e As MouseEventArgs) Handles RepositoryItemTextEdit1.MouseDown

          If e.Button = MouseButtons.Left Then

            Dim edit As TextEdit = TryCast(sender, TextEdit)
            BeginInvoke(New MethodInvoker(Sub()
                                            edit.SelectAll()
                                          End Sub))

          End If

        End Sub
          */
    }

    private void RepositoryItemTextEdit1_Click(object sender, EventArgs e)
    {
      /*
        Private Sub RepositoryItemTextEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemTextEdit1.Click

          Dim edit As TextEdit = TryCast(sender, TextEdit)
          BeginInvoke(New MethodInvoker(Sub()
                                          edit.SelectAll()
                                        End Sub))

        End Sub
      End Class
           * */
    }

    /*
      Private Sub Click_AppliqueCoef(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim RowHandlePer As String = GVTauxContrat.ActiveFilterString

        Select Case sender.name
          Case "NCLICONTHOR" + "_Coef"

            Dim sval As String = InputBox(My.Resources.WizardClient_UCTauxContratClient_MttHeures_Appliq, My.Resources.WizardClient_UCTauxContratClient_MttHeures)

            If sval = "" Then Return
            If IsNumeric(sval) = False Then MessageBox.Show(My.Resources.WizardClient_UCTauxContratClient_Erreur_Numeric, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return

            For Each drFilter As DataRow In DtListTauxContrat.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVTauxContrat.ActiveFilterCriteria))
              drFilter.Item("NCLICONTHOR") = sval
            Next

          Case "NCLICONTDEP" + "_Coef"
            Dim sval As String = InputBox(My.Resources.WizardClient_UCTauxContratClient_MttDep_Appliq, My.Resources.WizardClient_UCTauxContratClient_MttDep)

            If sval = "" Then Return
            If IsNumeric(sval) = False Then MessageBox.Show(My.Resources.WizardClient_UCTauxContratClient_Erreur_Numeric, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return

            For Each drFilter As DataRow In DtListTauxContrat.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVTauxContrat.ActiveFilterCriteria))
              drFilter.Item("NCLICONTDEP") = sval
            Next

          Case "NCLICONTHORSAM" + "_Coef"

            Dim sval As String = InputBox(My.Resources.WizardClient_UCTauxContratClient_CoefSam_Appliq)

            If sval = "" Then Return
            If IsNumeric(sval) = False Then MessageBox.Show(My.Resources.WizardClient_UCTauxContratClient_Erreur_Numeric, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return

            For Each drFilter As DataRow In DtListTauxContrat.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVTauxContrat.ActiveFilterCriteria))
              drFilter.Item("NCLICONTHORSAM") = sval
            Next


          Case "NCLICONTHORNUIDIM" + "_Coef"
            Dim sval As String = InputBox("Coefficient Heures Nuit et Dimanche")

            If sval = "" Then Return
            If IsNumeric(sval) = False Then MessageBox.Show(My.Resources.WizardClient_UCTauxContratClient_Erreur_Numeric, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return

            For Each drFilter As DataRow In DtListTauxContrat.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(GVTauxContrat.ActiveFilterCriteria))
              drFilter.Item("NCLICONTHORNUIDIM") = sval
            Next

        End Select

        GVTauxContrat.RefreshData()

      End Sub
        */
  }
}
