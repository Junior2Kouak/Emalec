using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviTempsTravailTechSaisieManuelleIndemnite : Form
  {    
    string _fieldname;
    decimal _indemnite_compensation_MOZART;
    int _NID_SUIVI_TPS_TRAJET;
    string _sColText;
    bool _bChangeValid;

    int _num_semaine_iso;
    int _num_annee;
    int _NPERNUM;

    CSUIVI_TPS_TRAJET_MAN_INDEMNITE_COMPENSATION oCSUIVI_TPS_TRAJET_MAN_INDEMN;

    public string fieldname
    {
      get => _fieldname;
      set
      {
      _fieldname = value;       
      }
    }

    public decimal indemnite_compensation_MOZART
        {
      get => _indemnite_compensation_MOZART;
      set
      {
         _indemnite_compensation_MOZART = value;
      }
    }

    public int NID_SUIVI_TPS_TRAJET
    {
      get => _NID_SUIVI_TPS_TRAJET;
      set
      {
        _NID_SUIVI_TPS_TRAJET = value;
      }
    }          
    public string sColText
    {
      get => _sColText;
      set
      {
        _sColText = value;
      }
    }
    public bool bChangeValid
    {
      get => _bChangeValid;     
    }


    public int num_semaine_iso
    {
      get => _num_semaine_iso;
      set
      {
        _num_semaine_iso = value;
      }
    }

    public int num_annee
    {
      get => _num_annee;
      set
      {
        _num_annee = value;
      }
    }

    public int NPERNUM
    {
      get => _NPERNUM;
      set
      {
        _NPERNUM = value;
      }
    }

    public decimal MONTANT_COMPENSATION
    {
        get => (oCSUIVI_TPS_TRAJET_MAN_INDEMN == null) ? 0 : oCSUIVI_TPS_TRAJET_MAN_INDEMN.MONTANT_COMPENSATION;
    }

        public frmSuiviTempsTravailTechSaisieManuelleIndemnite()
    {
      InitializeComponent();
    }

    private void frmSuiviTempsTravailTechSaisieManuelleIndemnite_Load(object sender, EventArgs e)
    {

      //init
      ModuleMain.Initboutons(this);

      _bChangeValid = false;

      LoadData();

    }
    private void LoadData()
    {
        oCSUIVI_TPS_TRAJET_MAN_INDEMN = new CSUIVI_TPS_TRAJET_MAN_INDEMNITE_COMPENSATION(_NID_SUIVI_TPS_TRAJET, _fieldname, _indemnite_compensation_MOZART, _sColText, _num_semaine_iso, _num_annee, _NPERNUM);

        if (oCSUIVI_TPS_TRAJET_MAN_INDEMN != null)
        {
        Lbl_Montant_Indemnite_MOZARIS.Text = oCSUIVI_TPS_TRAJET_MAN_INDEMN.MONTANT_COMPENSATION_MOZARIS.ToString("c2");
        NUP_Montant_Indemn.Value = oCSUIVI_TPS_TRAJET_MAN_INDEMN.MONTANT_COMPENSATION;
        TxtHisto.Text = oCSUIVI_TPS_TRAJET_MAN_INDEMN.VHISTO;

      }

    }

    private void BtnValider_Click(object sender, EventArgs e)
    {

        //on teste si commentairte saisie
        if(TxtObs.Text == "")
        {
        MessageBox.Show("Il faut saisir une observation !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
        }

            ////on teste si heure saisie
            //if (NUP_Montant_Indemn.Value == 0)
            //{
            //    MessageBox.Show("Il faut saisir un montant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            oCSUIVI_TPS_TRAJET_MAN_INDEMN.VOBS_MAN = TxtObs.Text;
            oCSUIVI_TPS_TRAJET_MAN_INDEMN.MONTANT_COMPENSATION = NUP_Montant_Indemn.Value;

            oCSUIVI_TPS_TRAJET_MAN_INDEMN.Save();

        LoadData();

        _bChangeValid = true;

        Close();

    }
  }
}
