using MozartNet;
using MozartUC;
using MozartLib;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmZoomText : Form
  {
    public string msChamp;
    public int NumAction;

    private string stringToPrint;
    private PrintDocument printDocument1 = new PrintDocument();
    private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

    public frmZoomText()
    {
      InitializeComponent();
    }

    private void frmZoomText_Load(object sender, EventArgs e)
    {
      if (NumAction == 0) return;

      if (msChamp == "VACTOBSM")
      {
        txtChamps.Text = ModuleData.ExecuteScalarString("select " + msChamp + " FROM TACTCOMP WITH (NOLOCK) WHERE NACTNUM = " + NumAction);
      }
      else
      {
        txtChamps.Text = ModuleData.ExecuteScalarString("select " + msChamp + " FROM TACT WITH (NOLOCK) WHERE NACTNUM = " + NumAction);
      }
    }

    private void frmZoomText_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F12)
      {
        printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        stringToPrint = txtChamps.Text;

        //printDocument1.Print();
        printPreviewDialog1.Document = printDocument1;
        printPreviewDialog1.ShowDialog();
      }
    }

    private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
    {
      int charactersOnPage = 0;
      int linesPerPage = 0;

      // Sets the value of charactersOnPage to the number of characters of stringToPrint that will fit within the bounds of the page.
      e.Graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

      // Draws the string within the bounds of the page
      e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

      // Remove the portion of the string that has been printed.
      stringToPrint = stringToPrint.Substring(charactersOnPage);

      // Check to see if more pages are to be printed.
      e.HasMorePages = (stringToPrint.Length > 0);
    }

    private void txtChamps_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
    }
  }
}
