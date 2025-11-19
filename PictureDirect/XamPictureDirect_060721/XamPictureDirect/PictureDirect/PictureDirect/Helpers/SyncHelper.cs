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
using PictureDirect.Services;
using PictureDirect.ViewModels;
using PictureDirect.WCFService;
using SQLite;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PictureDirect.Helpers
{
  public class SyncHelper
  {
    protected SyncHelper()
    {
      SyncPhotoViewModels = new ConcurrentDictionary<int, EPhotoViewModel>();
    }

    private static SyncHelper _syncHelper;

    public static SyncHelper Instance
    {
      get
      {
        if (_syncHelper == null)
        {
          _syncHelper = new SyncHelper();
        }
        return _syncHelper;
      }
    }

    public bool SyncRunning { get; set; }

    public int TotalItems { get; set; }

    public ConcurrentDictionary<int, EPhotoViewModel> SyncPhotoViewModels { get; set; }

    public async Task SyncAsync()
    {
      if (SyncRunning)
        return;

      await Task.Run(async () =>  
      {
        SyncRunning = true;

        try
        {
          List<TPicture> pictures = await SQLiteHelper.Instance.GetPicturesNotDoneAsync();

          TotalItems = pictures.Count;

          foreach (TPicture picture in pictures)
          {
            EPhotoViewModel photoViewModel = SyncPhotoViewModels.ContainsKey(picture.Id) ? SyncPhotoViewModels[picture.Id] : null;

            if (photoViewModel != null)
            {
              photoViewModel.Synced = false;
              photoViewModel.Syncing = true;
            }

            bool res = false;
            try
            {
              res = await WCFServiceHelper.UploadPictureAsync(picture);
            }
            catch (Exception ex)
            {
              res = false;
            }
            finally
            {
              if (photoViewModel != null)
                photoViewModel.Syncing = false;
            }

            if (photoViewModel != null)
            {
              if (res == true)
                photoViewModel.Synced = true;
              else
                photoViewModel.Error = true;
            }

            picture.Synced = res;
            picture.Error = !res;
            await SQLiteHelper.Instance.SavePictureAsync(picture);

          }
        }
        catch (Exception ex)
        {
          SyncRunning = false;
        }
        finally
        {
          SyncRunning = false;
        }
      });
    }

    public async Task CleanOldPictures(List<int> demandeIds)
    {
      List<TPicture> pictures = await SQLiteHelper.Instance.GetPicturesNotInAsync(demandeIds);
      foreach (TPicture picture in pictures)
      {
        try
        {
          DependencyService.Get<IDeleteFile>().Delete(picture.Path);
          await SQLiteHelper.Instance.DeletePictureAsync(picture);
        }
        catch { }
      }
    }
  }
}
