using System.IO;
using System.Threading.Tasks;
using PictureDirect.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PictureDirect.Droid.Services.DeleteFile))]
namespace PictureDirect.Droid.Services
{
  public class DeleteFile : IDeleteFile
  {
    public void Delete(string path)
    {
      File.Delete(path);
    }
  }
}