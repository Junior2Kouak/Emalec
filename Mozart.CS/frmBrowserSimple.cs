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
  public partial class frmBrowserSimple : Form
  {
    public string StartingAddress = "";

    public frmBrowserSimple()
    {
      InitializeComponent();
    }
    
    private void frmBrowserSimple_Load(object sender, EventArgs e)
    {
      if (StartingAddress.Length > 0)
      {
        brwWebBrowser.Navigate(StartingAddress);
        brwWebBrowser.Visible = true;
      }
    }

    private void frmBrowserSimple_FormClosing(object sender, FormClosingEventArgs e)
    {
      brwWebBrowser.Navigate("");
    }
  }
}
