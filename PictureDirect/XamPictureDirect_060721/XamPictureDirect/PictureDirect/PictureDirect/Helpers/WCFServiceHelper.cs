////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.Models   
//  --------															                              
//																		                                  
//  FILE    :	  EActionModel.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition de la classe d'une Action (DataModel)
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using PictureDirect.Models;
using PictureDirect.WCFService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PictureDirect.Helpers
{
  public class WCFServiceHelper
  {
    public enum EndpointConfiguration
    {
      BasicHttpBinding_IService,
    }

    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
      return GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
    }

    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
      return GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
    }

    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
      if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
      {
        System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
        result.MaxBufferSize = int.MaxValue;
        result.MaxBufferPoolSize = int.MaxValue;
        result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
        result.MaxReceivedMessageSize = int.MaxValue;
        result.AllowCookies = true;
        result.TransferMode = System.ServiceModel.TransferMode.Streamed;
        return result;
      }
      throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
    }

    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
      if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
      {
        //return new System.ServiceModel.EndpointAddress("http://78.194.160.103:8090/PictureDirect.WCF/Service.svc");
        return new System.ServiceModel.EndpointAddress(App.Config.EndpointAddress);
      }
      throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
    }

    public static async Task<List<DemandeContract>> GetCommandesAsync()
    {
      return await Task.Run(() =>
      {
        ServiceClient client = new ServiceClient(GetDefaultBinding(), GetDefaultEndpointAddress());
        ResponseContract response = client.GetDemandes(ContextHelper.Instance.NumUser);

        if (response != null && response.ResultCode == 0 && response.Response is DemandesContract && response.Response != null)
        {
          return (response.Response as DemandesContract).Demandes;
        }
        else
        {
          throw new Exception(response?.ResultInfo ?? "Error : GetCommandesAsync");
        }
      });
    }

    public static async Task<bool> UploadPictureAsync(TPicture picture)
    {
      return await Task.Run(() =>
      {
        bool res = false;

        try
        {
          ServiceClient client = new ServiceClient(GetDefaultBinding(), GetDefaultEndpointAddress());
          using (Stream stream = File.OpenRead(picture.Path))
          {
            client.UploadPicture(picture.ActionId, picture.Description, stream.Length, ContextHelper.Instance.NumUser, picture.Id, stream);
            res = true;
          }
        }
        catch(Exception ex)
        {
          res = false;
        }

        return res;
      });
    }

    public static async Task<LoginResponseContract> LoginAsync(int numUser, string username, string password)
    {
      return await Task.Run(() =>
      {
        ServiceClient client = new ServiceClient(GetDefaultBinding(), GetDefaultEndpointAddress());
        return client.Login(numUser, username, password);
      });
    }
  }
}
