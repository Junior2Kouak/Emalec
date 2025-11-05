using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MozartCS
{
  static class Program
  {
    public static string AppTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      MozartCsUtils.InitVariablesMozart();

      MozartCsUtils.InitMozartApp();

      string[] args = Environment.GetCommandLineArgs();

      if (4 > args.Length)
      {
        // cas appel alertedelegation / DELEGATION
        if (2 == args.Length && !args[1].Contains(";ALERTE") && !args[1].EndsWith(";DELEGATION") && !args[1].EndsWith(";DELEGATIONDEVIS")
            && 4 < MozartCsUtils.NbProcessForCurrentUser() && !ModuleMain.RechercheDroitMenu(595))
        {
          MessageBox.Show(Resources.msg_nb_maxi_app, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        // appel MozartCS avec SERVEUR;SOCIETE[;form;params] ou aucun (=> paramètres par défaut)
        // Non pas aucun ! Ca bypasse le test ci-dessus
        if (1 != args.Length)
        {
          Application.Run(new frmMenu());
        }
      }
    }
  }
}
