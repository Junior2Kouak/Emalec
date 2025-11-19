using System;
using System.IO;
using System.Threading.Tasks;
using PictureDirect.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PictureDirect.Droid.Services.GetDbPath))]
namespace PictureDirect.Droid.Services
{
  public class GetDbPath : IGetDbPath
  {
    public string GetDbPathString()
    {
      return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PictureDirect.db3");
    }
  }
}