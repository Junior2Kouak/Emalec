using System.Drawing.Printing;

namespace MozartCS
{
  public static class MyPrinter
  {

    public static string DefaultPrinterName()
    {
      string ret = "";
      PrinterSettings oPS = new PrinterSettings();
      try
      {
        ret = oPS.PrinterName;
      }
      catch (System.Exception) { }
      finally
      {
        oPS = null;
      }
      return ret;
    }

    public static bool SetDefaultPrinter(string sPrinterName)
    {
      object pname = MyPrinter.DefaultPrinterName();
      foreach (string item in PrinterSettings.InstalledPrinters)
      {
        if (item == sPrinterName)
        {
          PrinterSettings oPS = new PrinterSettings();
          oPS.DefaultPageSettings.PrinterSettings.PrinterName = sPrinterName;
          oPS.PrinterName = sPrinterName;
          return true;
        }

      }
      return false;
    }
  }
}

