using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace PictureDirect.WCF
{
  public class Service : IService
  {
    public ResponseContract GetDemandes(int numUser)
    {
      ResponseContract res = new ResponseContract();

      try
      {
        DemandesContract response = new DemandesContract();
        
        response.Demandes = Database.GetDemandes(numUser,DateTime.Now.Subtract(new TimeSpan(Properties.Settings.Default.ReturnNbLastDays,0,0,0)), DateTime.Now);

        res.Response = response;

      }
      catch (Exception ex)
      {
        res.ResultCode = 1;
        res.ResultInfo = ex.Message;
      }

      return res;
    }

    public LoginResponseContract Login(int numUser, string username, string password)
    {
      LoginResponseContract res = new LoginResponseContract();

      try
      {
        res.ResultCode = Database.VerifLogin(numUser, username, password);
        res.MaxNumberOfPictures = Properties.Settings.Default.MaxNumberOfPictures;
        res.BlockWrongVersion = Properties.Settings.Default.BlockWrongVersion;
        res.WrongVersionMessage = Properties.Settings.Default.WrongVersionMessage;
        res.WcfVersion = Properties.Settings.Default.Version;
      }
      catch (Exception ex)
      {
        res.ResultCode = 1;
        res.ResultInfo = ex.Message;
      }

      return res;
    }

    public void UploadPicture(RemoteFileInfoContract request)
    {
      try
      {
        Stream sourceStream = request.FileByteStream;
        string fileName = $"{request.NumUser}_{request.ActionId}_{request.PictureId}.jpg";
        string uploadDirectory = Database.GetFolderPath(request.NumUser);
        if (string.IsNullOrEmpty(uploadDirectory))
          throw new Exception("Invalid folder path");

        string filePath = Path.Combine(uploadDirectory, fileName);

        using (FileStream targetStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
        {
          const int bufferLen = 65000;
          byte[] buffer = new byte[bufferLen];
          int count = 0;
          while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
          {
            targetStream.Write(buffer, 0, count);
          }
          targetStream.Close();
          sourceStream.Close();
        }

        Database.AddPicture(request.NumUser, request.ActionId, fileName, request.Description);
      }
      catch (Exception ex)
      {
        throw;
      }

    }
  }
}
