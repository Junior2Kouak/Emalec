using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace PictureDirect.Droid
{
  [Activity(Label = "PictureDirect", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
  {
    protected override void OnCreate(Bundle savedInstanceState)
    {
      try
      {
        TabLayoutResource = Resource.Layout.Tabbar;
        ToolbarResource = Resource.Layout.Toolbar;

        base.OnCreate(savedInstanceState);
        global::Xamarin.Forms.Forms.Init(this, savedInstanceState);



        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "PictureDirect.db3");

        if (!File.Exists(dbPath))
        {
          using (var br = new BinaryReader(Application.Context.Assets.Open("PictureDirect.db3")))
          {
            using (var bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
            {
              byte[] buffer = new byte[2048];
              int length = 0;
              while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
              {
                bw.Write(buffer, 0, length);
              }
            }
          }
        }

        LoadApplication(new App());
        
        Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);
      }
      catch (Exception ex)
      {
        System.Diagnostics.Debug.WriteLine("MainActivity.OnCreate " + ex.Message);
      }
    }

    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
      Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
      base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
  }
}