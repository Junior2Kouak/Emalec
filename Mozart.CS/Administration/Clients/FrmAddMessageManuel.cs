using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS.Administration.Clients
{
  public partial class FrmAddMessageManuel : Form
  {

    public string sLblTitre;
    public string sMessage = "";
    public Boolean bCancel = false;
    public Boolean bAddUserInText = false;
    public Boolean bReadOnly = false;


    public FrmAddMessageManuel()
    {
      InitializeComponent();
    }

    private void FrmAddMessageManuel_Load(object sender, EventArgs e)
    {

      this.Text = LblTitre.Text = sLblTitre;
      MemoMsg.Text = sMessage;
      MemoMsg.ReadOnly = bReadOnly;

      if (bReadOnly == true)
      {
        BtnValider.Text = "Fermer";
        BtnCancel.Visible = false;
      }

    }

    private void BtnValider_Click(object sender, EventArgs e)
    {

      sMessage = MemoMsg.Text;
      Close();

    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
      bCancel = true;
      Close();
    }      

    private void memoEdit1_Enter(object sender, EventArgs e)
    {
      if (bAddUserInText == true)
      {
        string strLog = $"{ MozartLib.MozartParams.strUID } le { DateTime.Now.ToString("dd/MM/yyyy HH:mm")} : ";

        MemoMsg.Text = MemoMsg.Text.Insert(0, strLog + $"\r\n");
        MemoMsg.BeginInvoke(new MethodInvoker(delegate
        {
          MemoMsg.SelectionLength = 0;
          MemoMsg.SelectionStart = strLog.Length;
        }));
      }
    }
  }
}
