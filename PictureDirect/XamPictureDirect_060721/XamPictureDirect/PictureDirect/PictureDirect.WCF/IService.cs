using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PictureDirect.WCF
{
  [ServiceContract]
  public interface IService
  {
    [OperationContract]
    LoginResponseContract Login(int numUser, string username, string password);

    [OperationContract]
    ResponseContract GetDemandes(int numUser);

    [OperationContract]
    void UploadPicture(RemoteFileInfoContract request);
  }

  [DataContract]
  public class ResponseContract
  {
    [DataMember]
    public int ResultCode { get; set; }

    [DataMember]
    public string ResultInfo { get; set; }


    [DataMember]
    public DemandesContract Response { get; set; }
  }

  [DataContract]
  public class LoginResponseContract : ResponseContract
  {
    [DataMember]
    public int MaxNumberOfPictures { get; set; }

    [DataMember]
    public string WcfVersion{ get; set; }

    [DataMember]
    public bool BlockWrongVersion { get; set; }

    [DataMember]
    public string WrongVersionMessage { get; set; }
  }

  [DataContract]
  public class DemandesContract
  {
    [DataMember]
    public List<DemandeContract> Demandes { get; set; }
  }

  [DataContract]
  public class DemandeContract
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public List<ActionContract> Actions { get; set; }
  }

  [DataContract]
  public class ActionContract
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }
  }

  [MessageContract]
  public class RemoteFileInfoContract : IDisposable
  {
    [MessageHeader(MustUnderstand = true)]
    public int NumUser { get; set; }

    [MessageHeader(MustUnderstand = true)]
    public int ActionId { get; set; }

    [MessageHeader(MustUnderstand = true)]
    public int PictureId { get; set; }

    [MessageHeader(MustUnderstand = true)]
    public string Description { get; set; }

    [MessageHeader(MustUnderstand = true)]
    public long Length { get; set; }

    [MessageBodyMember(Order = 1)]
    public System.IO.Stream FileByteStream { get; set; }

    public void Dispose()
    {
      if (FileByteStream != null)
      {
        FileByteStream.Close();
        FileByteStream = null;
      }
    }
  }

  [MessageContract]
  public class DownloadRequestContract
  {
    [MessageBodyMember]
    public int DemandeId { get; set; }

    [MessageBodyMember]
    public int ActionId { get; set; }

    [MessageBodyMember]
    public int ImageId { get; set; }
  }
}
