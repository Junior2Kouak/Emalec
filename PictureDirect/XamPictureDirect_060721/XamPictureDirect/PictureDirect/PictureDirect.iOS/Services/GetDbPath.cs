using System;
using System.IO;
using System.Threading.Tasks;
using PictureDirect.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PictureDirect.iOS.Services.GetDbPath))]
namespace PictureDirect.iOS.Services
{
  public class GetDbPath : IGetDbPath
  {
    public string GetDbPathString()
    {
      var sqliteFilename = "PictureDirect.db3";

      string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
      string path = Path.Combine(libFolder, sqliteFilename);

      return path;
    }
  }
}