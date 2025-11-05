using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public class apiTGridListeInter : apiTGrid
  {
    protected DataTable mDatatable = new DataTable();

    public apiTGridListeInter() : base()
    {
      dgv.RowCellStyle += GridT_RowCellStyle;
    }

    public void InitTGrid()
    {
      AddColumn(Resources.col_DI, "NDINNUM", 700);
      AddColumn(MZCtrlResources.date_creation + " " + Resources.col_DI, "DDIDATCRE", 0, "dd/MM/yy");
      AddColumn(MZCtrlResources.date_creation + " " + Resources.col_Action, "DDINDATHEUR", 850, "dd/MM/yy");
      AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000, "", 0, true);
      AddColumn(Resources.col_Enseigne, "VSITENSEIGNE", 800, "", 0, true);
      AddColumn(Resources.col_Site, "VSITNOM", 1350, "", 0, true);
      AddColumn(Resources.col_Num, "NSITNUE", 480);
      AddColumn(Resources.col_Chaff, "VDINCHAFF", 1000, "", 0, true);
      AddColumn(Resources.col_Cpt, "NDINCTE", 600);
      AddColumn(Resources.col_Action, "VACTDES", 4100, "", 0, true);
      AddColumn(Resources.col_Date + " intervention", "DACTDATE", 850, "dd/MM/yy");
      AddColumn(Resources.col_Technicien, "VACTINT", 800, "", 0, true);
      AddColumn(Resources.col_T_echnique, "CTECCOD", 500, "", 2);
      AddColumn(Resources.col_P_restation, "CPRECOD", 500, "", 2, true);
      AddColumn(Resources.col_E_tat, "CETACOD", 500, "", 2, true);
      AddColumn("Complément opé", "CETATCPL", 500, "", 2, true);
      AddColumn("Complément admin", "CETATADMINCPL", 500, "", 2, true);
      AddColumn(Resources.col_A_dministration, "CACTSTA", 500, "", 2);
      AddColumn(Resources.col_OBS, "VACTOBS", 2100, "", 0, true);
      AddColumn(Resources.col_OBSM, "VACTOBSM", 2100, "", 0, true);
      AddColumn(Resources.col_Date_souhaitee, "DACTDAT", 900, "dd/MM/yy");
      AddColumn("H RDV", "VACTHRRDV", 900);
      AddColumn("Date de réception devis STT", "DDSTRETOUR", 900, "dd/MM/yy");
      AddColumn(Resources.col_NbObs, "NBOBS", 600);
      AddColumn(Resources.col_Devis_euro, "NDCLHT", 900, "# ###", 1);
      AddColumn(Resources.col_Nb_H, "NACTDUR", 800, "# ##0.##");
      AddColumn(Resources.col_cde + " " + MZCtrlResources.col_Client, "DACTDCDE", 800, "dd/MM/yy");
      AddColumn(Resources.col_Contrat, "VTYPECONTRAT", 1000, "", 0, true);
      AddColumn(Resources.col_num_GMAO, "VACTNUMGMAO", 800);
      AddColumn(Resources.col_RM, "VCCLNOM", 1000, "", 0, true);
      AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);
      AddColumn("NSITNUM", "NSITNUM", 0);
      AddColumn(Resources.col_Qui, "QUI", 0);
      AddColumn(Resources.col_HorsWeb, "CACTVUEWEB", 0);
      AddColumn(Resources.col_Num_CDE, "VACTNUMCDE", 800);
      AddColumn(Resources.col_CP, "VSITCP", 800);
      AddColumn(Resources.col_Dep, "DEP", 400);
      AddColumn(Resources.col_Pays, "VSITPAYS", 600);
      AddColumn(Resources.col_Intervenant, "INTERVENANT", 900);
      AddColumn(Resources.col_Region, "REGION", 800);
      AddColumn(Resources.col_Urgence, "VURGLIB", 800);
      AddColumn(Resources.col_Facturiere, "FACTU", 1200);
      AddColumn(Resources.col_Chiffrage_euro, "NACTVAL", 900, "# ###.##", 1);
      AddColumn(Resources.col_Processus, "VLIBPROCESS", 1200);
      AddColumn(Resources.col_Creator, "VACTIDCRE", 800);
      AddColumn(Resources.col_Num_equip, "VOBJNUMEQUIP", 800, "", 0, true);
      AddColumn(Resources.col_Site_informe, "CACTINFOMAG", 900, "", 2);
      AddColumn("Nuit ou Dimanche", "CACTNUIT_DIM", 900, "", 2);
      AddColumn("HPP", "CACTHORSPRESENCEPUBLIC", 900, "", 2);
      AddColumn("NCLINUM", "NCLINUM", 0);//  NL, le 03/05/2017 : Le NCLINUM n'était pas toujours disponible sur frmAddAction, on va donc le chercher
      AddColumn("EXISTFACSTT", "EXISTFACSTT", 0);
      AddColumn(Resources.col_Nacelle, "CACTNACEL", 1200, "", 2);
      AddColumn("DEVISSTTRECU", "DEVISSTTRECU", 0);
      AddColumn(Resources.col_Devis, "NDCLNUM", 800);
      AddColumn("N° Courrier", "NCOURNUM", 800);
      AddColumn(Resources.col_D_Devis, "DDCLDAT", 800, "dd/MM/yy");
      AddColumn("Code Fact", "VCODEFACT", 1000);
      AddColumn("Période", "NUMPER", 800, "");
      AddColumn("Contrat P3", "CACTTYPCONT", 1000, "");
      AddColumn("Date suivi", "DACTMAILCLI", 800, "dd/MM/yy");
      AddColumn(Resources.col_attach, "VACTATT", 800);
      AddColumn(Resources.col_NumFacture, "NFACNUM", 1000);
      AddColumn("P5 Action", "CACTP5", 800, "");
      AddColumn("Heure Action", "HACTION", 0, "HH:mm");
      AddColumn("Heure DI", "HDI", 0, "HH:mm");
      AddColumn("Heure arrivée", "HARR", 0, "HH:mm");
      AddColumn("Heure départ", "HEXE", 0, "HH:mm");
      AddColumn("LIBGROUPE", "LIBGROUPE", 0, "");

      InitColumnList();

      dgv.OptionsView.ColumnAutoWidth = false;
      GridControl.DataSource = mDatatable;
    }

    public void LoadWithQuery(string pQuery)
    {
      LoadData(mDatatable, MozartDatabase.cnxMozart, pQuery);
      GridControl.DataSource = mDatatable;
    }

    public void Requery()
    {
      Requery(mDatatable, MozartDatabase.cnxMozart);
    }

    private void GridT_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;

      string val;
      switch (e.Column.Name)
      {
        case "CPRECOD":
          // Dépannage en rouge, orange ou jaune (spécifique ds apiTGridT)
          if (e.CellValue == null || e.CellValue.ToString() != "D") return;
          val = (sender as GridView).GetDataRow(e.RowHandle)["CETACOD"].ToString();
          if (val == "O")
            e.Appearance.BackColor = Color.Red;// D - O : Rouge
          else if (val == "P" &&
                  ((DateTime)(sender as GridView).GetDataRow(e.RowHandle)["DACTDATE"]) <= DateTime.Today)
            e.Appearance.BackColor = Color.Orange;// D - P : Orange
          else if (val == "A")
            e.Appearance.BackColor = Color.Yellow;// D - A : Jaune
          break;
        case "NDINNUM":
          // Surligner les DI de la personne loguée (spécifique ds apiTGridT)
          if (((sender as GridView).GetDataRow(e.RowHandle)["QUI"]).ToString() == "1")
            e.Appearance.BackColor = MozartColors.ColorHC0FFC0;// Vert pale
          break;
        case "VACTINT":
          // distinction entre soustraitant et technicien
          val = (sender as GridView).GetDataRow(e.RowHandle)["INTERVENANT"].ToString();
          if (val == "TECH")
            e.Appearance.BackColor = MozartColors.ColorHC0FFC0;// Vert pale
          else if (val == "STT_ENT")
            e.Appearance.BackColor = MozartColors.ColorHC0E0FF;// orange pale
          else if (val == "STT_IMP")
            e.Appearance.BackColor = MozartColors.ColorHFFC0C0;// bleu pale
          else e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          break;
        case "VACTDES":
          // Action Hors Web en gris
          if (((sender as GridView).GetDataRow(e.RowHandle)["CACTVUEWEB"]).ToString() == "N" && ((sender as GridView).GetDataRow(e.RowHandle)["CACTNUIT_DIM"]).ToString() != "OUI")
          {
            e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          }
          if (((sender as GridView).GetDataRow(e.RowHandle)["CACTVUEWEB"]).ToString() != "N" && ((sender as GridView).GetDataRow(e.RowHandle)["CACTNUIT_DIM"]).ToString() == "OUI")
          {
            e.Appearance.BackColor = Color.Red;
          }
          if (((sender as GridView).GetDataRow(e.RowHandle)["CACTVUEWEB"]).ToString() == "N" && ((sender as GridView).GetDataRow(e.RowHandle)["CACTNUIT_DIM"]).ToString() == "OUI")
          {
            e.Appearance.BackColor = MozartColors.colorHCCCCCC;
            e.Appearance.BackColor2 = Color.Red;
          }

          break;

        case "INTERVENANT":
          val = (sender as GridView).GetDataRow(e.RowHandle)["EXISTFACSTT"].ToString();
          if (val == "1")
            e.Appearance.BackColor = MozartColors.ColorHC0E0FF;
          else if (val == "2")
            e.Appearance.BackColor = MozartColors.ColorHC0E0FF;
          else if (e.CellValue == null || e.CellValue.ToString() == "") e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          break;
        case "CETACOD":
          if (e.CellValue == null || e.CellValue.ToString() != "D") return;
          if (((sender as GridView).GetDataRow(e.RowHandle)["DEVISSTTRECU"]).ToString() == "1")
            e.Appearance.BackColor = MozartColors.ColorH80FF00;
          break;
        case "VSITNOM":
          if (((sender as GridView).GetDataRow(e.RowHandle)["CACTSUIVICLI"]).ToString() == "O")
            e.Appearance.BackColor = Color.CornflowerBlue;
          break;

        default: break;
      }
    }

  }
}
