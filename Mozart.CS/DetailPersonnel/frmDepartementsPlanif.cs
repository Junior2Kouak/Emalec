using DevExpress.XtraEditors;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS.DetailPersonnel
{
  public partial class frmDepartementsPlanif : Form
  {
    DataTable dtListeDep;
    Int32 _NPERNUM;
    string _VPERNOM;

    public frmDepartementsPlanif(Int32 C_NPERNUM, string C_VPERNOM)
    {
      InitializeComponent();
      _NPERNUM = C_NPERNUM;
      _VPERNOM = C_VPERNOM;
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmDepartementsPlanif_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);

      LoadData();

    }

    private void LoadData()
    {

      dtListeDep = new DataTable();

      SqlCommand CmdSql = new SqlCommand("[api_sp_Liste_Departement_Planificateur]", MozartDatabase.cnxMozart);
      CmdSql.CommandType = CommandType.StoredProcedure;

      dtListeDep.Load(CmdSql.ExecuteReader());

      dtListeDep.Columns["NPERNUM"].ReadOnly = false;
      dtListeDep.Columns["VPERNOM"].ReadOnly = false;
      dtListeDep.Columns["BAFFECTE"].ReadOnly = false;

      GCListeDep.DataSource = dtListeDep;

    }

    private void RItem_BAFFECTE_CheckedChanged(object sender, EventArgs e)
    {

      //Dim odtr As DataRow = GVPers.GetDataRow(GVPers.GetSelectedRows(0))

      //  If Not odtr Is Nothing AndAlso odtr.Item("CHECK") = 1 Then

      //      'si test non démarrer, on peut toujours le desaffecter
      //      If oQCM.QCMEnCours(odtr.Item("NPERNUM"), GVListQCM.GetDataRow(GVListQCM.GetSelectedRows(0)).Item("NIDQCMNUM")) = True Then
      //          'sinon on force le check a cocher
      //          CType(sender, CheckEdit).Checked = True
      //          odtr.Item("CHECK") = 1
      //      End If

      //  End If
      //  GVPers.PostEditor()
      //  GCPers.Refresh()


      CheckEdit chk = (CheckEdit)sender;
      DataRow DrRead = GVListeDep.GetDataRow(GVListeDep.FocusedRowHandle);
      if (chk.Checked == true)
      {       
        if (DrRead != null)
        {

          //on teste si departement deja affecté à une autre personne
          if(DrRead.IsNull("NPERNUM") == false && (Int32)DrRead["NPERNUM"] != _NPERNUM)
           {        
            MessageBox.Show("Affectation interdite car il y a déjà une personne d'affecté à ce département", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            chk.Checked = false;
            return;
          }

          SqlCommand CmdSql = new SqlCommand("[api_sp_Departement_Planificateur_Save]", MozartDatabase.cnxMozart);
          CmdSql.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

          CmdSql.Parameters["@NDEPNUM"].Value = DrRead["NDEPNUM"];
          CmdSql.Parameters["@NPERNUM"].Value = _NPERNUM;

          CmdSql.ExecuteNonQuery();

          DrRead["NPERNUM"] = _NPERNUM;
          DrRead["VPERNOM"] = _VPERNOM;
          DrRead["BAFFECTE"] = 1;
          GVListeDep.PostEditor();
          GVListeDep.RefreshData();

        }

      }
      else
      {

        //si on decoche on teste si on les droits
        if (DrRead != null)
        {

          SqlCommand CmdSql = new SqlCommand("[api_sp_Departement_Planificateur_Delete]", MozartDatabase.cnxMozart);
          CmdSql.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(CmdSql);    // liste des paramètres

          CmdSql.Parameters["@NDEPNUM"].Value = DrRead["NDEPNUM"];
          CmdSql.Parameters["@NPERNUM"].Value = _NPERNUM;

          CmdSql.ExecuteNonQuery();

          DrRead["NPERNUM"] = DBNull.Value;
          DrRead["VPERNOM"] = "";
          DrRead["BAFFECTE"] = 0;
          GVListeDep.PostEditor();
          GVListeDep.RefreshData();

        }

      }

    }
  }
}
