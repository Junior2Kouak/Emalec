using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmTransfertSalaires : Form
  {
    public frmTransfertSalaires()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmTransfertSalaires_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }



    private void cmdFile1_Click(object sender, EventArgs e)
    {
      CommonDialog1.Title = Resources.msg_ChoixFichierCompta;
      try
      {
        if (CommonDialog1.ShowDialog() == DialogResult.OK)
          txtFichier1.Text = CommonDialog1.FileName;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    DateTime _curDate = DateTime.MinValue;

    private void cmdODPaies_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtFichier1.Text == "")
        {
          MessageBox.Show(Resources.msg_verifFichierImport, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        string[] data = File.ReadAllLines(txtFichier1.Text);
        StreamWriter writer = File.CreateText($@"c:\Transfert\{MozartParams.NomSociete}\EcrOD.txt");
        for (int i = 0; i < data.Length; i++)
        {
          data[i] = data[i].Replace(".", ",");
          writer.WriteLine(CreerLigneOD(data[i].Split('\t'), i == 1 ? "1" : "0"));
        }
        writer.Flush();
        writer.Close();

        MessageBox.Show(Resources.msg_fichierPretImportCompta, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private string CreerLigneOD(string[] tCols, string sFlag)
    {
      StringBuilder sb = new StringBuilder();

      sb.Append("OD;"); //Code journan
      sb.Append("ODSalaire;"); //pièce -8
      sb.Append(tCols[2] + ";"); //Compte comptable 

      switch (tCols[2])
      {
        case "791100000":
        case "791000000":
          sb.Append("6;"); //Code TVA
          break;
        default:
          sb.Append(";"); //Code TVA
          break;
      }
      sb.Append($"{tCols[1].Substring(0, 2)}/{tCols[1].Substring(3, 2)}/{tCols[1].Substring(8, 2)};");
      sb.Append(tCols[4] + ";"); //Libelle
      sb.Append(tCols[5] + ";"); //debit
      sb.Append(tCols[6] + ";"); //credit
      sb.Append(";;"); //échéance et type règlement

      bool bAna = true;
      switch (tCols[2])
      {
        case "633500000":
        case "641000000":
        case "641400000":
        case "641410000":
        case "645400000":
        case "645800000":
          if (MozartParams.NomSociete == "EMALECDEV")
            sb.Append("906;");
          else
            sb.Append("996;");
          break;
        case "641450000":
        case "645100000":
        case "645200000":
        case "645300000":
        case "645500000":
        case "791100000":
        case "647300000":
          if (MozartParams.NomSociete == "EMALECDEV")
            sb.Append("906;");
          else
            sb.Append("996;");
          break;
        case "625100000":
        case "625000000":
          sb.Append("998;");
          break;
        case "633400000":
          sb.Append("999;");
          break;
        case "633300000":
          if (MozartParams.NomSociete == "EMALECDEV")
            sb.Append("901;");
          else
            sb.Append("991;");
          break;
        case "671210000":
          sb.Append("997;");
          break;
        default:
          sb.Append("");
          bAna = false;
          break;
      }

      if (bAna)
      {
        double col5 = 0;
        double.TryParse(tCols[5], out col5);
        sb.Append(col5 > 0 ? tCols[5] : tCols[6]);
        sb.Append(";;");
      }
      else
      {
        sb.Append(";");
      }
      return sb.ToString();
    }


  }
}

