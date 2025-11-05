using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace MozartControls
{
  public partial class frmDetailsCaseWithDetailH : Form
  {
    private const string VISUPARMOIS = "Visu par mois";
    private const string VISUPARPERS = "Visu par personne";

    private const string TYPEVISU_TECHMOIS = "TECH/MOIS";
    private const string TYPEVISU_MOISTECH = "MOIS/TECH";

    private const string TDETAILHEURES = "DetailHeures";
    private const string TDATE = "TDATE";
    private const string TPER = "TPER";
    private const string TDETAIL = "TDETAIL";

    private const string CST_VLIB = "VLIB";
    private const string CST_NVAL = "NVAL";
    private const string CST_NBHR = "NBHR";
    private const string CST_NANNEE = "NANNEE";
    private const string CST_NMOIS = "NMOIS";
    private const string CST_NMOISANNEE = "NMOISANNEE";
    private const string CST_SUMNBHR = "SUMNBHR";

    private string sType;
    private int iNIDCHANTIER;

    private string sTypeVISU;
    private Decimal SumDtDate;

    private DataTable dtCur;
    private DataSet dsCur;

    public frmDetailsCaseWithDetailH(string c_sType, int c_NIDCHANTIER)
    {
      InitializeComponent();

      sType = c_sType;
      iNIDCHANTIER = c_NIDCHANTIER;
      sTypeVISU = TYPEVISU_TECHMOIS;
    }

    private void frmDetailsCaseWithDetailH_Load(object sender, EventArgs e)
    {
      Location = Cursor.Position;

      BtnTypeVisu.Text = VISUPARMOIS;
      GVSUM.OptionsView.ShowFooter = true;
      GVDate.OptionsView.ShowFooter = false;

      LoadTableauHeures();
    }

    private void LoadTableauHeures()
    {
      SqlCommand cmd;

      dtCur = new DataTable("TDETAIL");
      SumDtDate = 0;

      cmd = new SqlCommand($"api_sp_ChantierDetailsInfo {iNIDCHANTIER}, '{sType}'", MozartDatabase.cnxMozart)
      {
        CommandType = CommandType.Text
      };
      dtCur.Load(cmd.ExecuteReader());

      if ((sTypeVISU == TYPEVISU_TECHMOIS) && dtCur.Rows.Count > 0)
      {
        dsCur = new DataSet();

        // 1ère table : PERSONNE
        DataTable drPer = new DataTable();
        drPer.Columns.Add(CST_VLIB, Type.GetType("System.String"));
        drPer.Columns.Add(CST_NBHR, Type.GetType("System.Decimal"));

        drPer = dtCur.AsEnumerable()
          .Select(a => new
          {
            vLib = a.Field<String>(CST_VLIB),
            nVal = a.Field<Decimal>(CST_NVAL)
          })
          .GroupBy(x => new { x.vLib })
          .Select(g =>
          {
            DataRow row = drPer.NewRow();

            row[CST_VLIB] = g.Key.vLib;
            row[CST_NBHR] = g.Sum(x => x.nVal);

            return row;
          })
          .CopyToDataTable();

        // 2ième table : DATE
        DataTable drDate = new DataTable();
        drDate.Columns.Add(CST_VLIB, Type.GetType("System.String"));
        drDate.Columns.Add(CST_NANNEE, Type.GetType("System.Int32"));
        drDate.Columns.Add(CST_NMOIS, Type.GetType("System.Int32"));
        drDate.Columns.Add(CST_NMOISANNEE, Type.GetType("System.String"));
        drDate.Columns.Add(CST_SUMNBHR, Type.GetType("System.Decimal"));

        drDate = dtCur.AsEnumerable()
          .Select(a => new
          {
            vLib = a.Field<String>(CST_VLIB),
            nAnnee = a.Field<int>(CST_NANNEE),
            nMois = a.Field<int>(CST_NMOIS),
            nVal = a.Field<Decimal>(CST_NVAL)
          })
          .GroupBy(x => new { x.vLib, x.nAnnee, x.nMois })
          .Select(g =>
          {
            DataRow row = drDate.NewRow();

            row[CST_VLIB] = g.Key.vLib;
            row[CST_NANNEE] = g.Key.nAnnee;
            row[CST_NMOIS] = g.Key.nMois;
            row[CST_NMOISANNEE] = $"{g.Key.nMois:00}-{g.Key.nAnnee:0000}";
            row[CST_SUMNBHR] = g.Sum(x => x.nVal);

            SumDtDate += Convert.ToDecimal(row[CST_SUMNBHR]);

            return row;
          })
          .CopyToDataTable();

        dsCur.Tables.Add(drPer);
        dsCur.Tables.Add(drDate);
        dsCur.Tables.Add(dtCur);
        drPer.TableName = TPER; // Le tablename est perdu si on le met à la création de l'objet
        drDate.TableName = TDATE; // Le tablename est perdu si on le met à la création de l'objet

        dsCur.Relations.Add("VLIBPER", dsCur.Tables[TPER].Columns[CST_VLIB], dsCur.Tables[TDATE].Columns[CST_VLIB]);

        DataColumn[] parentColumns = new DataColumn[] {
          dsCur.Tables[TDATE].Columns[CST_VLIB],
          dsCur.Tables[TDATE].Columns[CST_NMOIS],
          dsCur.Tables[TDATE].Columns[CST_NANNEE]
        };
        DataColumn[] childColumns = new DataColumn[] {
          dsCur.Tables[TDETAIL].Columns[CST_VLIB],
          dsCur.Tables[TDETAIL].Columns[CST_NMOIS],
          dsCur.Tables[TDETAIL].Columns[CST_NANNEE]
        };

        // Create DataRelation.
        DataRelation custOrderRel = new DataRelation(TDETAILHEURES, parentColumns, childColumns);
        // Add the relation to the DataSet.
        dsCur.Relations.Add(custOrderRel);

        // Relation entre les grids
        GCDetailCase.LevelTree.Nodes[0].RelationName = "VLIBPER";
        GCDetailCase.LevelTree.Nodes[0].Nodes[0].RelationName = TDETAILHEURES;

        GCDetailCase.DataSource = dsCur.Tables[0];

        GCDetailCase.MainView = GVSUM;
        GCDetailCase.LevelTree.Nodes[0].LevelTemplate = GVDate;
      }
      else
      {
        dsCur = new DataSet();

        // 1ière table : DATE
        DataTable drDate = new DataTable();
        drDate.Columns.Add(CST_NANNEE, Type.GetType("System.Int32"));
        drDate.Columns.Add(CST_NMOIS, Type.GetType("System.Int32"));
        drDate.Columns.Add(CST_NMOISANNEE, Type.GetType("System.String"));
        drDate.Columns.Add(CST_SUMNBHR, Type.GetType("System.Decimal"));

        drDate = dtCur.AsEnumerable()
          .Select(a => new
          {
            vLib = a.Field<String>(CST_VLIB),
            nAnnee = a.Field<int>(CST_NANNEE),
            nMois = a.Field<int>(CST_NMOIS),
            nVal = a.Field<Decimal>(CST_NVAL)
          })
          .GroupBy(x => new { x.nAnnee, x.nMois })
          .Select(g =>
          {
            DataRow row = drDate.NewRow();

            row[CST_NANNEE] = g.Key.nAnnee;
            row[CST_NMOIS] = g.Key.nMois;
            row[CST_NMOISANNEE] = $"{g.Key.nMois:00}-{g.Key.nAnnee:0000}";
            row[CST_SUMNBHR] = g.Sum(x => x.nVal);

            SumDtDate += Convert.ToDecimal(row[CST_SUMNBHR]);

            return row;
          })
          .CopyToDataTable();

        // 2ième table : PERSONNE
        DataTable drPer = new DataTable();
        drPer.Columns.Add(CST_NANNEE, Type.GetType("System.Int32"));
        drPer.Columns.Add(CST_NMOIS, Type.GetType("System.Int32"));
        drPer.Columns.Add(CST_NMOISANNEE, Type.GetType("System.String"));
        drPer.Columns.Add(CST_VLIB, Type.GetType("System.String"));
        drPer.Columns.Add(CST_NBHR, Type.GetType("System.Decimal"));

        drPer = dtCur.AsEnumerable()
          .Select(a => new
          {
            vLib = a.Field<String>(CST_VLIB),
            nAnnee = a.Field<int>(CST_NANNEE),
            nMois = a.Field<int>(CST_NMOIS),
            nVal = a.Field<Decimal>(CST_NVAL)
          })
          .GroupBy(x => new { x.vLib, x.nAnnee, x.nMois })
          .Select(g =>
          {
            DataRow row = drPer.NewRow();

            row[CST_NANNEE] = g.Key.nAnnee;
            row[CST_NMOIS] = g.Key.nMois;
            row[CST_NMOISANNEE] = $"{g.Key.nMois:00}-{g.Key.nAnnee:0000}";
            row[CST_VLIB] = g.Key.vLib;
            row[CST_NBHR] = g.Sum(x => x.nVal);

            return row;
          })
          .CopyToDataTable();

        dsCur.Tables.Add(drDate);
        dsCur.Tables.Add(drPer);
        dsCur.Tables.Add(dtCur);
        drPer.TableName = TPER; // Le tablename est perdu si on le met à la création de l'objet
        drDate.TableName = TDATE; // Le tablename est perdu si on le met à la création de l'objet

        dsCur.Relations.Add("VLIBDATE", dsCur.Tables[TDATE].Columns[CST_NMOISANNEE], dsCur.Tables[TPER].Columns[CST_NMOISANNEE]);

        DataColumn[] parentColumns = new DataColumn[] {
          dsCur.Tables[TPER].Columns[CST_VLIB],
          dsCur.Tables[TPER].Columns[CST_NMOIS],
          dsCur.Tables[TPER].Columns[CST_NANNEE]
        };
        DataColumn[] childColumns = new DataColumn[] {
          dsCur.Tables[TDETAIL].Columns[CST_VLIB],
          dsCur.Tables[TDETAIL].Columns[CST_NMOIS],
          dsCur.Tables[TDETAIL].Columns[CST_NANNEE]
        };

        // Create DataRelation.
        DataRelation custOrderRel = new DataRelation(TDETAILHEURES, parentColumns, childColumns);
        // Add the relation to the DataSet.
        dsCur.Relations.Add(custOrderRel);

        // Relation entre les grids
        GCDetailCase.LevelTree.Nodes[0].RelationName = "VLIBDATE";
        GCDetailCase.LevelTree.Nodes[0].Nodes[0].RelationName = TDETAILHEURES;

        GCDetailCase.DataSource = dsCur.Tables[0];

        GCDetailCase.MainView = GVDate;
        GCDetailCase.LevelTree.Nodes[0].LevelTemplate = GVSUM;
      }
    }

    private void BtnTypeVisu_Click(object sender, EventArgs e)
    {
      if (sTypeVISU == TYPEVISU_TECHMOIS)
      {
        sTypeVISU = TYPEVISU_MOISTECH;
        BtnTypeVisu.Text = VISUPARPERS;
        GVSUM.OptionsView.ShowFooter = false;
        GVDate.OptionsView.ShowFooter = true;
      } else
      {
        sTypeVISU = TYPEVISU_TECHMOIS;
        BtnTypeVisu.Text = VISUPARMOIS;
        GVSUM.OptionsView.ShowFooter = true;
        GVDate.OptionsView.ShowFooter = false;
      }

      LoadTableauHeures();
    }

    private void GVSUM_CustomDrawFooter(object sender, RowObjectCustomDrawEventArgs e)
    {
      if (((GridView) sender).DetailLevel == 0)
      {
        BtnTypeVisu.Location = new Point(e.Bounds.X + 5, e.Bounds.Y + 2);
        BtnTypeVisu.Size = new Size((int) (e.Bounds.Width * 0.2), e.Bounds.Height - 4);
      }
    }

    private void GVDate_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
    {
      if ((e.Info.DisplayText == String.Empty) || (e.Column.FieldName != CST_SUMNBHR)) return;

      e.Graphics.FillRectangle(Brushes.White, e.Bounds);
      e.Graphics.DrawString($"{SumDtDate}", DefaultFont, Brushes.Black, e.Bounds, e.Appearance.GetStringFormat());
      e.Handled = true;
    }

    private void GVDetail_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      if (e.Column.Name == "ColDetailNDINNUM")
      {
        ColumnView view = (ColumnView)sender;
        DataRow row = view.GetDataRow(view.FocusedRowHandle);
        if (row != null)
        {
          if ((row["NDINNUM_ACT"].ToString() != "") && (row["NACTNUM"].ToString() != ""))
          {
            Process.Start(MozartParams.CheminProgrammeMozart + "MozartCS.exe", MozartParams.NomServeur + ";" + MozartParams.NomSociete + ";" + row["NDINNUM_ACT"] + ";" + row["NACTNUM"]);
          }
        }
      }
    }
  }
}
