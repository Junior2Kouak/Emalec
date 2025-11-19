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

using PictureDirect.WCFService;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureDirect.Helpers
{
  public class ContextHelper
  {
    protected ContextHelper()
    {
    }

    private static ContextHelper _contextHelper;

    public static ContextHelper Instance
    {
      get
      {
        if (_contextHelper == null)
        {
          _contextHelper = new ContextHelper();
        }
        return _contextHelper;
      }
    }

    public int NumUser { get; set; }

    public string Login { get; set; }

    public void Reset()
    {
      NumUser = 0;
      Login = "";
    }
  }
}
