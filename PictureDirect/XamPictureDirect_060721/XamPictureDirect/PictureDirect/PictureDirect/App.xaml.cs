using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PictureDirect.Services;
using PictureDirect.Views;
using PictureDirect.ViewModels;
using System.IO;
using System.Threading.Tasks;
using Plugin.Connectivity;
using PictureDirect.Helpers;
using PictureDirect.Models;

// Use Camera To Take Photo In Xamarin Forms
// https://xamarinhelp.com/use-camera-take-photo-xamarin-forms/
// https://www.nuget.org/packages/Xam.Plugin.Media

//  1) Propriétés du Projet Androird :
// Manifest Android : cases à cocher 'Camera', 'read external storage', 'write external storage'
//  2) Projet Gestionnaire NuGet
// Installer Xam.Plugin.Media
//  3) Emulateur téléphone
// Settings / Permissions / <mon-appli> / 'Camera'
//  4) Projet Android : 
// Initialiser le fileProvider
// - AndroidManifest.xml
// - Resources/xml/file_path.xml

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PictureDirect
{
  //----------------------------------------------------------------------------
  public partial class App : Application
  {
    //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
    //public static string AzureBackendUrl = "http://localhost:5000";
    //public static bool UseMockDataStore = true;

    //----------------------------------------------------------------------------
    public App()
    {
      InitializeComponent();

      //if (UseMockDataStore)
      //  DependencyService.Register<MockDataStore>();
      //else
      //  DependencyService.Register<AzureDataStore>();

      MainPage = new MainPage();
    }

    private static TConfig _config;

    public static TConfig Config
    {
      get
      {
        if (_config == null)
        {
          _config = Task.Run(async () => { return await SQLiteHelper.Instance.GetConfigAsync(); }).Result;
          if (_config == null)
          {
            _config = new TConfig()
            {
              //EndpointAddress = "http://192.168.1.143:59388/Service.svc",
              //DefaultNumUser = 2307,
              //DefaultLogin = "FERRANDO",
              //DefaultPassword = "RM5FT2",
              //CompressionQuality = 50,
              //PhotoSize = 0
            };
            SQLiteHelper.Instance.AddConfigAsync(_config).Wait();
          }
        }

        return _config;
      }
    }

    public static string Version
    {
      get
      {
        return DependencyService.Get<IGetVersion>().GetVersionName();
      }
    }

    //----------------------------------------------------------------------------
    protected override void OnStart()
    {
      Task.Run(async () => await SyncHelper.Instance.SyncAsync());

      CrossConnectivity.Current.ConnectivityChanged += async (sender, args) =>
      {
        if (args.IsConnected)
          await SyncHelper.Instance.SyncAsync();
      };
    }

    //----------------------------------------------------------------------------
    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    //----------------------------------------------------------------------------
    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
