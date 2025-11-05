using MozartNet;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmVisuDiMail : Form
  {
    public int miNumDIMail;
    string NomFichiers;

    public frmVisuDiMail() { InitializeComponent(); }

    private void frmVisuDiMail_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        using (SqlDataReader dr = ModuleData.ExecuteReader($"select * FROM TDIMAIL WHERE NDIMNUM = {miNumDIMail}"))
        {
          if (dr.Read())
          {
            txtDate.Text = Utils.BlankIfNull(dr["DDIMCRE"]);
            txtDe.Text = Utils.BlankIfNull(dr["VDIMFROM"]);
            txtA.Text = Utils.BlankIfNull(dr["VDIMTO"]);
            txtSujet.Text = Utils.BlankIfNull(dr["VDIMSUJET"]);
            txtLibelle.Text = Utils.BlankIfNull(dr["VDIMTEXT"]);
            NomFichiers = Utils.BlankIfNull(dr["VDIMPJ"]);

            if (NomFichiers != "")
              cmdPJ.Visible = true;
          }
          dr.Close();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdPJ_Click(object sender, EventArgs e)
    {
      new frmChoixImage()
      {
        mstrDirPDFFiles = Utils.RechercheParam("REP_PJ_ACT"),
        miNumMail = miNumDIMail,
      }.ShowDialog();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

