using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartControls
{
  public partial class UCviewerPDF : UserControl
  {
    public UCviewerPDF()
    {
      InitializeComponent();
    }


    public void  LoadDocument(string sFile)
    {
      pdfV.LoadDocument(sFile);
    }

    public void CloseDocument()
    {
      pdfV.CloseDocument();
      pdfV.ClearSelection();
    }

  }
}
