using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MozartCS.Properties;

namespace MozartCS
{
  public partial class frmInfoDebug : Form
  {
    public string msType;
    public string msInfo;
    public bool bVisible = true;

    public frmInfoDebug(Exception _ex, string _method, string stacktrace)
    {
      msType = "DEBUG";

      StackTrace t = new StackTrace();
      List<string> lstT = new List<string>();

      string[] ts = t.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
      foreach (var item in ts)
      {
        if (item.Contains("MozartCS.") && !item.Contains("frmInfoDebug") && !item.Contains("frmInfoDebug"))
        {
          string s = item.Remove(item.IndexOf('(')).Replace("à MozartCS.", "==> ");
          lstT.Add(s);
        }
      }

      msInfo = $"\r\nErreur du {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}\r\n\r\n {_ex.GetAllMessages()}\r\n\r\n{stacktrace}\r\n\r\n\r\n{String.Join("\r\n", lstT)}";

      //MessageBox.Show($"{ex.Message}\r\n\r\n{Resources.Global_dans}{MethodBase.GetCurrentMethod().Name}\r\n==> {String.Join("\r\n", lstT)}",
      //                Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      InitializeComponent();
      txtBug.Text = msInfo;
    }
    private void frmInfoDebug_Load(object sender, EventArgs e)
    {
      if (!bVisible) Dispose();
    }

    private void cmdCopier_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(txtBug.Text);
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

  }
}
