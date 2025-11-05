using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListePlanif : Form
  {
    DataTable dt = new DataTable();

    public frmListePlanif() { InitializeComponent(); }

    private void frmListePlanif_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //chkPrev.BackColor = chkSoc.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);
        chkSoc.Text = chkSoc.Text + MozartParams.NomSociete;

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeDIPlanif where LANGUE='{MozartParams.Langue}' order by DDINDAT desc");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void chk_CheckedChanged(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.sSqlDataSource = $"select * from api_v_ListeDIPlanif where LANGUE='{MozartParams.Langue}'{(chkPrev.Checked ? " AND CPRECOD != 'P'" : "")}" +
                    $"{(chkSoc.Checked ? $"AND VCLINOM != '{MozartParams.NomSociete}'" : "")} order by DDINDAT desc";
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void CmdPlanifAuto_Click(object sender, EventArgs e)
    {
      new frmPlanifAuto_Liste().ShowDialog();
    }

    private void cmdPlanningMPM_Click(object sender, EventArgs e)
    {
      new frmPlanningProjet().ShowDialog();
    }

    private void cmdConges_Click(object sender, EventArgs e)
    {
      new frmChoixTriPlaConges().ShowDialog();
    }

    private void cmdPlanCli_Click(object sender, EventArgs e)
    {
      new frmPlanClient().ShowDialog();
    }

    private void cmdPlanning_Click(object sender, EventArgs e)
    {
      new frmPlan()
      {
        mdSemaine = DateTime.Today,
        miNumTech = 0,
        miNumIp = 0,
        mStrStatutIP = "M",
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      //écran de modification de la demande
      MozartParams.NumDi = (int)Utils.ZeroIfNull(row["NDINNUM"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);

      new frmAddAction
      {
        mstrStatutDI = "M",
      }.ShowDialog();

      //on revient donc réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;
    }

    private void apiTGrid1_DblClick(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void cmdPlanifier_Click(object sender, EventArgs e)
    {
      string lMsg;

      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      try
      {
        // test si cette action n'a  pas déjà été prise en planification sur un autre Mozart
        // mdoif le 02/01/2017 : par mc : ajout test si personne en cours de modif
        using (SqlDataReader reader = ModuleData.ExecuteReader($"select cetacod, nlocknum, isnull(tper.vperadsi, '') as vperadsi from tact with (nolock) left outer join tper on tper.npernum = tact.nlocknum where nactnum = {row["NACTNUM"]}"))
        {
          if (!reader.Read()) return;
          if (Utils.BlankIfNull(reader["CETACOD"]) != "O")
          {
            MessageBox.Show(Resources.msg_action_deja_planifiee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          else if (Utils.ZeroIfNull(reader["NLOCKNUM"]) != 0)
          {
            lMsg = $"{Resources.msg_action_en_cours_modification}{reader["vperadsi"]}{Resources.msg_refresh_liste}";
            MessageBox.Show(lMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
        }

        //FGA le 11 / 06 / 24
        // si site des JO, on affiche un message
        DetailstravauxUtils.AffichageMessageJO2024((int)Utils.ZeroIfNull(row["NSITNUM"]));


        MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);

        // Affichage d'une nouvelle IP avec l'action sélectionnée (pas de création réelle de l'IP)
        new frmPlan
        {
          miNumIp = 0,
          miNumAction = MozartParams.NumAction,
          miNumSite = (int)Utils.ZeroIfNull(row["NSITNUM"]),
          mdSemaine = Convert.ToDateTime(row["DACTDATE"]),
          miNumTech = (int)Utils.ZeroIfNull(row["NPERNUM"]),
          miDuree = Utils.ZeroIfNull(row["NACTDUR"]),
          mStrStatutIP = "C",
          // ( client / site )
          mStrTagIP = $"{row["VCLINOM"]}{Environment.NewLine}{row["VSITNOM"]}{Environment.NewLine}"
        }.ShowDialog();

        Cursor.Current = Cursors.WaitCursor;
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdPlanifier_Click()
    //
    //Dim rs As ADODB.Recordset
    //
    //On Error GoTo Handler
    //
    //
    //    If adoRS.EOF Then Exit Sub
    //
    //    ' test si cette action n'a  pas déjà été prise en planification sur un autre Mozart
    //    'mdoif le 02/01/2017 : par mc : ajout test si personnen en vours de modif
    //      Set rs = New ADODB.Recordset
    //      rs.Open "select cetacod, nlocknum, isnull(tper.vperadsi, '') as vperadsi from tact with (nolock) left outer join tper on tper.npernum = tact.nlocknum where nactnum = " & adoRS("NACTNUM"), cnx
    //      If rs.EOF Then Exit Sub
    //      If rs("cetacod") <> "O" Then
    //        MsgBox "§Cette action a déjà été planifiée dans mozart, rafraichissez la liste§", vbInformation
    //        rs.Close
    //        Exit Sub
    //      ElseIf rs("nlocknum") <> 0 Then
    //        MsgBox "§Cette action a en cours de modification dans mozart par§" & " " & rs("vperadsi") & "§, rafraichissez la liste§", vbInformation
    //        rs.Close
    //        Exit Sub
    //      End If
    //    
    //      glNumAction = adoRS("NACTNUM")
    //      
    //      ' Affichage d'une nouvelle IP avec l'action sélectionnée (pas de création réelle de l'IP)
    //      frmPlan.miNumIP = 0
    //      frmPlan.miNumSite = adoRS("NSITNUM").value
    //      frmPlan.mdSemaine = adoRS("DACTDATE")
    //      frmPlan.miNumTech = ZeroIfNull(adoRS("NPERNUM").value)
    //      frmPlan.miDuree = adoRS("NACTDUR")
    //      frmPlan.mStrStatutIP = "C"
    //      '( client / site )
    //      frmPlan.mStrTagIP = adoRS("VCLINOM").value & vbCrLf & adoRS("VSITNOM").value & vbCrLf
    //      frmPlan.Show vbModal
    //    
    //  Screen.MousePointer = vbHourglass
    // 
    //  adoRS.Requery
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdPlanifier dans " & Me.Name
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdOT_Click(object sender, EventArgs e)
    {
      //affichage de la feuille
      Cursor.Current = Cursors.WaitCursor;
      new frmListeOT().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void CmdEdition_Click(object sender, EventArgs e)
    {
      new frmChoixPlanningA3().ShowDialog();
    }

    private void CmdPlanningsAnnuel_Click(object sender, EventArgs e)
    {
      new frmChoixPlanningAnnuel().ShowDialog();
    }

    private void cmdST_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmPlanSTT()
      {
        mdSemaine = DateTime.Today,
        miNumTech = 0,
        miNumIp = 0,
        mStrStatutIP = "M",
      }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdS3_Click(object sender, EventArgs e)
    {
      new FrmMainPlanning3S().ShowDialog();
    }

    private void InitApigTgrid()
    {
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apiTGrid1.AddColumn(Resources.col_Date, "DDINDAT", 1050);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1100);
      apiTGrid1.AddColumn("Planificatrice", "VPLA_DEP", 1100);
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1300);
      apiTGrid1.AddColumn(Resources.col_Chaff, "VDINCHAFF", 1100);
      apiTGrid1.AddColumn(Resources.col_duree, "NACTDUR", 500, "##0.##");
      apiTGrid1.AddColumn(Resources.col_CP, "VSITCP", 500);
      apiTGrid1.AddColumn(Resources.col_Ville, "VSITVIL", 1000);
      apiTGrid1.AddColumn(Resources.col_Reg, "VREGLIB", 1000);
      apiTGrid1.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 2400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Date_S, "DACTDATE", 1050);
      apiTGrid1.AddColumn(Resources.col_Pres, "CPRECOD", 500, "", 2);
      apiTGrid1.AddColumn(Resources.col_etat, "CETACOD", 500, "", 2);
      apiTGrid1.AddColumn(Resources.col_Urgence, "VURGLIB", 800, "", 2);
      apiTGrid1.AddColumn("Obs M", "VACTOBSM", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_OBS, "VACTOBS", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Bloque, "VACTPAVEBLOCK", 500);
      apiTGrid1.AddColumn(Resources.col_dateEx, "DACTDEX", 0);
      apiTGrid1.AddColumn("NumAc", "NACTNUM", 0);
      apiTGrid1.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);
      apiTGrid1.AddColumn(Resources.col_DateIP, "DIPLDAT", 0);
      apiTGrid1.AddColumn(Resources.col_Date_souhaitee, "DACTDAT", 0);
      apiTGrid1.AddColumn(Resources.col_NumTech, "NPERNUM", 0);
      apiTGrid1.AddColumn("NumSite", "NSITNUM", 0);
      apiTGrid1.AddColumn("NumIP", "NIPLNUM", 0);
      apiTGrid1.AddColumn("DMISE_EN_PLANIF", "DMISE_EN_PLANIF", 0);

      apiTGrid1.InitColumnList();
    }

    private void cmdRetourTech_Click(object sender, EventArgs e)
    {
      new frmRetourTech().ShowDialog();
    }

    private void apiTGrid1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {

      List<string> cprecod_exclude = new List<string>() { "D", "P", "R", "F" };

      if (e.RowHandle < 0) return;
      DataRow dr = (sender as GridView).GetDataRow(e.RowHandle);
      if (dr == null) return;
      switch (e.Column.Name)
      {
        case "NDINNUM":

          if (dr["DMISE_EN_PLANIF"].ToString() != "")
          {
            //rouge si date de mise en planif est supérieru à 3J
            //if (cprecod_exclude.Contains((String)dr["CPRECOD"]) == false && ((DateTime)dr["DDINDAT"]) <= DateTime.Today.AddDays(-3))
            if (cprecod_exclude.Contains((String)dr["CPRECOD"]) == false && IsDepasseDelaiHoursOuvres((DateTime)dr["DDINDAT"], DateTime.Today.AddDays(-3), 30) == true)
            {
              e.Appearance.BackColor = Color.Red;
            }
          }

          //Doivent passer en rouge(comme ci-dessus), toutes les prestations hors P, R, F lorsque les actions ne sont pas planifiées dans les délais suivants :
          //D : 10h
          //Toutes prestations(hors D, P, R, F) : 30h

          if (((String)dr["CPRECOD"]) == "D" && IsDepasseDelaiHoursOuvres((DateTime)dr["DDINDAT"], DateTime.Today, 10) == true)
          {
            e.Appearance.BackColor = Color.Red;
          }
          else
          {
            if ((cprecod_exclude.Contains((String)dr["CPRECOD"])) == false && IsDepasseDelaiHoursOuvres((DateTime)dr["DDINDAT"], DateTime.Today, 30) == true)
            {
              e.Appearance.BackColor = Color.Red;
            }
          }
          break;
      }
    }

    private bool IsDepasseDelaiHoursOuvres(DateTime DateDebut, DateTime DateFin, int nb_hours)
    {
      //base D UNE JOURNEE 8 h - 18H

      int nbhoursTotalDiff = 0;

      int hours_debut_journee = 0;
      int hours_fin_journee = 0;

      DateTime DateSelected = DateDebut;

      if (DateFin.Date > DateSelected.Date)
      {
        while (DateFin.Date >= DateSelected.Date)
        {
          //si date samedi ou dimanche ou feriee
          if (DateSelected.DayOfWeek == DayOfWeek.Sunday || DateSelected.DayOfWeek == DayOfWeek.Saturday || ModuleMain.IsFeriee(DateSelected.Date) == true)
          {
            DateSelected = DateSelected.AddDays(1); //= DateSelected.AddDays(1);
            continue;
          }
          else
          {
            //si jour du debut
            if (DateSelected.Date == DateDebut.Date)
            {
              if (DateSelected.Hour < 8)
              {
                nbhoursTotalDiff = 18 - 8;
              }
              else
              {
                if (DateSelected.Hour > 18)
                {
                  nbhoursTotalDiff = 0;
                }
                else
                {
                  nbhoursTotalDiff = 18 - DateSelected.Hour;
                }
              }
              DateSelected = DateSelected.AddDays(1); //= DateSelected.AddDays(1);
              continue;
            }

            //si jour de fin
            if (DateSelected.Date == DateFin.Date)
            {
              if (DateSelected.Hour < 8)
              {
                nbhoursTotalDiff = nbhoursTotalDiff + 0;
              }
              else
              {
                if (DateSelected.Hour > 18)
                {
                  nbhoursTotalDiff = nbhoursTotalDiff + (18 - 8);
                }
                else
                {
                  nbhoursTotalDiff = nbhoursTotalDiff + (8 + DateSelected.Hour);
                }
              }
              DateSelected = DateSelected.AddDays(1); //= DateSelected.AddDays(1);
              continue;
            }

            //+10h par jour
            nbhoursTotalDiff = nbhoursTotalDiff + (18 - 8);
          }
          DateSelected = DateSelected.AddDays(1); //= DateSelected.AddDays(1);
        }

        return (nbhoursTotalDiff > nb_hours);
      }
      else
      {

        if (DateFin.Date == DateSelected.Date)
        {
          //si date samedi ou dimanche ou feriee
          if (DateSelected.DayOfWeek == DayOfWeek.Sunday || DateSelected.DayOfWeek == DayOfWeek.Saturday || ModuleMain.IsFeriee(DateSelected.Date) == true)
          {
            return false;
          }

          switch (DateSelected.Hour)
          {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
              hours_debut_journee = 8;
              break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
              hours_debut_journee = DateSelected.Hour;
              break;
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
              hours_debut_journee = 18;
              break;
          }

          switch (DateFin.Hour)
          {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
              hours_fin_journee = 8;
              break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
              hours_fin_journee = DateFin.Hour;
              break;
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
              hours_fin_journee = 18;
              break;
          }

          //si nb heures de la journée dépasse le seuil alors true
          return ((hours_fin_journee - hours_debut_journee) > nb_hours);
        }
      }

      return false;
    }
  }
}

