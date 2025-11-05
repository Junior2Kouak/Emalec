using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixPlanningA3 : Form
  {
    DateTime dtDate = DateTime.Now;
    //Dim dtDate As Date

    string gsCodeRetour;

    public frmChoixPlanningA3() { InitializeComponent(); }

    private void frmChoixPlanningA3_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        gsCodeRetour = "";

        //combo des clients
        ModuleData.RemplirCombo(cboTech, "select NPERNUM, VPERNOM+' '+VPERPRE AS DPMEMBER from TPER where VSOCIETE = 'Emalec' AND CPERACTIF = 'O' ORDER BY DPMEMBER;");
        cboTech.ValueMember = "NPERNUM";
        cboTech.DisplayMember = "DPMEMBER";
        cboTech.SelectedIndex = 0;

        ModuleData.RemplirCombo(cboRegion, "select TREF_REG.NREGCOD, VDEPLIB from TREF_REG, TPER WHERE TREF_REG.NREGCOD=TPER.NREGCOD and npaysnum = 1 UNION SELECT 0,'Toutes régions'  ORDER BY  VDEPLIB");
        cboRegion.ValueMember = "VDEPLIB";
        cboRegion.DisplayMember = "TREF_REG.NREGCOD";
        cboRegion.SelectedIndex = 0;

        ModuleData.RemplirCombo(cboService, "SELECT NSERNUM, VSERLIB FROM  TSER WHERE NSERACTIF = 1 UNION SELECT 0,'Tous services' ORDER BY  VSERLIB");
        cboService.ValueMember = "NSERNUM";
        cboService.DisplayMember = "VSERLIB";
        cboService.SelectedIndex = 0;

        //Ajout des nombre de la semaine dans la cbo.semaine
        for (int nbr = 1; nbr < 53; nbr++)
        {
          cbosemaine.Items.Add(nbr);
        }
        DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
        cbosemaine.SelectedItem = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dtDate, dfi.CalendarWeekRule, DayOfWeek.Monday);//semaine en cours

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    // 
    //
    //On Error GoTo handler
    // 
    //  InitBoutons Me, frmMenu
    // 
    //  gsCodeRetour = ""
    //  dtDate = Date
    //
    //  ' taille des combos
    //  ' combo des clients
    //  SizeCombo cboTech, 400
    //  SizeCombo cboRegion, 400
    //  SizeCombo cboService, 400
    //  SizeCombo cbosemaine, 400
    //  
    //  
    //  ' combo des clients
    //  RemplirCombo cboTech, "select NPERNUM, VPERNOM+ ' '+VPERPRE from TPER where VSOCIETE = App_Name() AND CPERACTIF = 'O' ORDER BY  VPERNOM+ ' '+VPERPRE"
    //  
    //  RemplirCombo cboRegion, "select TREF_REG.NREGCOD, VDEPLIB from TREF_REG, TPER WHERE TREF_REG.NREGCOD=TPER.NREGCOD and npaysnum = 1 UNION SELECT 0,'Toutes régions'  ORDER BY  VDEPLIB"
    //  RemplirCombo cboService, "SELECT NSERNUM, VSERLIB FROM  TSER WHERE NSERACTIF = 1 UNION SELECT 0,'Tous services' ORDER BY  VSERLIB"
    // 
    //  optInter_Click (0)
    //  
    //  ' semaine en cours
    //  cbosemaine.Text = ISO_WEEK(Date) 'DatePart("ww", Date)
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        string[,] TdbGlobal = { { "", "" } };

        //type de sortie
        if (optInter0.Checked)
        {
          //test de la sélection d'un tech
          if (cboTech.Text == "")
          {
            MessageBox.Show(Resources.msg_selection_technicien, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
          }
          new frmBrowser()
          {
            miPlanningAn = 0,
            mbFleches = true,
            //SelectImprimante
            msInfosMail = "TPER|NPERNUM|" + cboTech.GetItemData(), // TABLE | ID    --VL 16/11/04
          }.Preview_Print($"{MozartParams.CheminModeles}{MozartParams.Langue}/TPlanningMoisTechA3.rtf",
                $"TPlanningMoisTechA3out.rtf",
                TdbGlobal,
                $"exec api_sp_impPlanningTechMois {cboTech.GetItemData()}, '{dtDate}'",
                " (Imprimer planning A3 dans frmPlan)",
                "PREVIEW");
        }
        else
        {
          //test de la sélection
          if (cboService.Text == "")
          {
            MessageBox.Show(Resources.msg_selection_service, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
          }

          if (cboRegion.Text == "")
          {
            MessageBox.Show(Resources.msg_selection_region, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
          }
          new frmBrowser()
          {
            miPlanningAn = 0,
            mbFleches = true,
          }.Preview_Print($"{MozartParams.CheminModeles}{MozartParams.Langue}/TPlanningSemaineA3.rtf",
                $"TPlanningSemaineA3out.rtf",
                TdbGlobal,
                $"exec api_sp_impPlanningTechsSemaine {cboService.GetItemData()}, {cboRegion.GetItemData()}, {cbosemaine.SelectedItem}, '{dtDate}'",
                " (Imprimer planning A3 dans frmPlan)",
                "PREVIEW");

        }
        Cursor.Current = Cursors.Default;

        if (gsCodeRetour == "S")
        {
          if (optInter0.Checked)
            dtDate = DateAndTime.DateAdd("m", 1, dtDate);//mois suivant
          else
          {
            dtDate = DateAndTime.DateAdd("d", 7, dtDate);//semaine suivante
            cbosemaine.SelectedItem = ModuleMain.WeekNumber(dtDate);
          }
          cmdValider_Click(null, null);
        }
        else if (gsCodeRetour == "P")
        {
          if (optInter0.Checked)
            dtDate = DateAndTime.DateAdd("m", -1, dtDate);//mois précédent
          else
          {
            dtDate = DateAndTime.DateAdd("d", -7, dtDate);//semaine précédent
            cbosemaine.SelectedItem = ModuleMain.WeekNumber(dtDate);
          }
          cmdValider_Click(null, null);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    // 
    //  
    //  frmBrowser.bPlanningAn = 0 '1
    //  frmBrowser.bFleches = True
    //  
    //  ' type de sortie
    //  If optInter(0) Then
    //        ' test de la sélection d'un tech
    //        If Not cboTech.Text <> "" Then
    //            MsgBox "§Sélectionnez un technicien§"
    //            Exit Sub
    //        End If
    //
    //        'SelectImprimante
    //        frmBrowser.InfosMail = "TPER|NPERNUM|" & cboTech.ItemData(cboTech.ListIndex)     ' TABLE | ID    --VL 16/11/04
    //        frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TPlanningMoisTechA3.rtf", _
    //                                     "\TPlanningMoisTechA3out.rtf", _
    //                                     TdbGlobal(), _
    //                                     "exec api_sp_impPlanningTechMois " & cboTech.ItemData(cboTech.ListIndex) & ", '" & dtDate & "'", _
    //                                     " (Imprimer planning A3 dans frmPlan)", _
    //                                     "PREVIEW"
    //  Else
    //    
    //        ' test de la sélection
    //        If Not cboService.Text <> "" Then
    //            MsgBox "§Sélectionnez un service§"
    //            Exit Sub
    //        End If
    //        
    //        If Not cboRegion.Text <> "" Then
    //            MsgBox "§Sélectionnez une région§"
    //            Exit Sub
    //        End If
    //        
    //        frmBrowser.Preview_Print gstrCheminModeles & gstrLangue & "\" & "TPlanningSemaineA3.rtf", _
    //                                     "\TPlanningSemaineA3out.rtf", _
    //                                     TdbGlobal(), _
    //                                     "exec api_sp_impPlanningTechsSemaine " & cboService.ItemData(cboService.ListIndex) & ", " & cboRegion.ItemData(cboRegion.ListIndex) & ", " & cbosemaine & ", '" & dtDate & "'", _
    //                                     " (Imprimer planning A3 dans frmPlan)", _
    //                                     "PREVIEW"
    // End If
    //
    //
    //    
    //  Me.MousePointer = vbDefault
    //
    //  If gsCodeRetour = "S" Then
    //    If optInter(0) Then
    //      ' mois suivante
    //      dtDate = DateAdd("m", 1, dtDate)
    //    Else
    //      ' semaine suivante
    //      dtDate = DateAdd("d", 7, dtDate)
    //    cbosemaine.Text = ISO_WEEK(dtDate) 'DatePart("ww", dtDate)
    //    End If
    //    cmdValider_Click
    //  ElseIf gsCodeRetour = "P" Then
    //    If optInter(0) Then
    //      'mois précédente
    //      dtDate = DateAdd("m", -1, dtDate)
    //    Else
    //      ' semaine precedente
    //      dtDate = DateAdd("d", -7, dtDate)
    //      cbosemaine.Text = ISO_WEEK(dtDate) 'DatePart("ww", dtDate)
    //    End If
    //    cmdValider_Click
    //  End If
    //  frmBrowser.bPlanningAn = 0
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void optInter_Click(object sender, EventArgs e)
    {
      if (optInter0.Checked)
      {
        cboService.Visible = false;
        cboRegion.Visible = false;
        cbosemaine.Visible = false;
        cboTech.Visible = true;
        lblLabels0.Visible = false;
        lblLabels1.Visible = false;
        lblLabels3.Visible = false;
        lblLabels2.Visible = true;
      }
      else
      {
        cboService.Visible = true;
        cboRegion.Visible = true;
        cbosemaine.Visible = true;
        cboTech.Visible = false;
        lblLabels0.Visible = true;
        lblLabels1.Visible = true;
        lblLabels2.Visible = false;
        lblLabels3.Visible = true;
      }
    }
    //Private Sub optInter_Click(Index As Integer)
    //
    //  If Index = 0 Then
    //    cboService.Visible = False
    //    cboRegion.Visible = False
    //    cbosemaine.Visible = False
    //    cboTech.Visible = True
    //    lblLabels(0).Visible = False
    //    lblLabels(1).Visible = False
    //    lblLabels(3).Visible = False
    //    lblLabels(2).Visible = True
    //  Else
    //    cboService.Visible = True
    //    cboRegion.Visible = True
    //    cbosemaine.Visible = True
    //    cboTech.Visible = False
    //    lblLabels(0).Visible = True
    //    lblLabels(1).Visible = True
    //    lblLabels(2).Visible = False
    //    lblLabels(3).Visible = True
    //  End If
    //End Sub

  }
}

