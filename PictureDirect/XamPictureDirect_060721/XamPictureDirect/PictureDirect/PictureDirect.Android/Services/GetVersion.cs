using System.IO;
using System.Threading.Tasks;
using PictureDirect.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PictureDirect.Droid.Services.GetVersion))]
namespace PictureDirect.Droid.Services
{
  public class GetVersion : IGetVersion
  {
    public string GetVersionName()
    {
      return Forms.Context.PackageManager.GetPackageInfo(Forms.Context.ApplicationContext.PackageName, 0).VersionName;
    }
  }
}