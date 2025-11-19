////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.ViewModels   
//  --------															                              
//																		                                  
//  FILE    :	  EActionViewModel.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition du Vue-Modele du détail d'une Action (associée à une Demande d'Intervention)
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PictureDirect.Helpers;
using PictureDirect.Models;
using PictureDirect.Views;
using PictureDirect.WCFService;
using Plugin.Media;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  /// <summary>
  /// Vue Modèle du détail d'une Action
  /// </summary>
  public class EActionDetailViewModel : EBaseViewModel
  {
    /// <summary>
    /// Action liée à ce Vue Modèle
    /// </summary>
    public ActionContract Action { get; set; }

    /// <summary>
    /// DEmande liée à ce Vue Modèle
    /// </summary>
    public EDemandeViewModel Demande { get; set; }

    /// <summary>
    /// Liste des Images associées à cette Action
    /// </summary>
    public ObservableCollection<EPhotoViewModel> Images
    {
      get => _images;
      set => SetProperty(ref _images, value);
    }
    private ObservableCollection<EPhotoViewModel> _images;

    public Command TakePictureCommand { get; set; }

    public Command PickPictureCommand { get; set; }

    public string Name { get { return Action.Name; } }
        
    //----------------------------------------------------------------------------
    public EActionDetailViewModel(EDemandeViewModel demande, ActionContract action)
    {
      base.Title = demande.Name;
      Action = action;
      Demande = demande;

      TakePictureCommand = new Command(async () => await ExecuteTakePictureCommandAsync());
      PickPictureCommand = new Command(async () => await ExecutePickPictureCommandAsync());

      _images = new ObservableCollection<EPhotoViewModel>();
    }

    private async Task ExecuteTakePictureCommandAsync()
    {
      if (Images.Count >= App.Config.MaxNumberOfPictures)
      {
        SetContextInfo($"Nombre de photos limité à {App.Config.MaxNumberOfPictures}.", InfoType.Error);
        return;
      }

      using (EBusyManager.GetInstance(this))
      {
        try
        {
          var status = await Plugin.Permissions.CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
          if (status != PermissionStatus.Granted)
          {
            if (await Plugin.Permissions.CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Camera))
            {
              SetContextInfo("Asking for permission...", InfoType.Info);
            }

            var results = await Plugin.Permissions.CrossPermissions.Current.RequestPermissionsAsync(Permission.Camera);

            if (results.ContainsKey(Permission.Camera))
              status = results[Permission.Camera];
          }

          if (status == PermissionStatus.Granted || status == PermissionStatus.Unknown)
          {
            await CrossMedia.Current.Initialize();

            string filename = $"{Demande.Demande.Id}_{Action.Id}.jpg";

            // Dans le Manifest Android       : cases à cocher 'Camera', 'read external storage', 'write external storage'
            // Dans le Téléphone / Emulateur  : Settings / Permissions / <mon-appli> / 'Camera'
            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
              Directory = "PictureDirect",
              DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Rear,
              CompressionQuality = App.Config.CompressionQuality,
              PhotoSize = (Plugin.Media.Abstractions.PhotoSize)App.Config.PhotoSize,
              RotateImage = false,
              AllowCropping = true,
              Name = filename,
              SaveToAlbum = true
            });

            if (file == null)
              return;

            string filePath = file.Path;

            TPicture photoTaken = new TPicture() { DemandeId = Demande.Demande.Id, ActionId = Action.Id, Name = filename, Description = "", Path = filePath, Date = DateTime.Now, Synced = false };
            EPhotoViewModel photoViewModel = new EPhotoViewModel(this, photoTaken);

            await Navigation.PushModalAsync(new EPhotoDetailPage(photoViewModel));
          }
          else
          {
            SetContextInfo("Cannot continue, try again.", InfoType.Error);
          }
        }
        catch (Exception ex)
        {
          SetContextInfo(ex.Message, InfoType.Error);
        }
      }
    }

    private async Task ExecutePickPictureCommandAsync()
    {
      if (Images.Count >= App.Config.MaxNumberOfPictures)
      {
        SetContextInfo($"Nombre de photos limité à {App.Config.MaxNumberOfPictures}.", InfoType.Error);
        return;
      }

      try
      {
        var status = await Plugin.Permissions.CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
        if (status != PermissionStatus.Granted)
        {
          if (await Plugin.Permissions.CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Camera))
          {
            SetContextInfo("Asking for permission...", InfoType.Info);
          }

          var results = await Plugin.Permissions.CrossPermissions.Current.RequestPermissionsAsync(Permission.Camera);

          if (results.ContainsKey(Permission.Camera))
            status = results[Permission.Camera];
        }

        if (status == PermissionStatus.Granted || status == PermissionStatus.Unknown)
        {
          await CrossMedia.Current.Initialize();

          string filename = $"{Demande.Demande.Id}_{Action.Id}.jpg";

          // Dans le Manifest Android       : cases à cocher 'Camera', 'read external storage', 'write external storage'
          // Dans le Téléphone / Emulateur  : Settings / Permissions / <mon-appli> / 'Camera'
          var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
          {
            CompressionQuality = App.Config.CompressionQuality,
            PhotoSize =(Plugin.Media.Abstractions.PhotoSize)App.Config.PhotoSize,
            RotateImage = false
          });

          if (file == null)
            return;

          string filePath = file.Path;

          TPicture photoTaken = new TPicture() { DemandeId = Demande.Demande.Id, ActionId = Action.Id, Name = filename, Description = "", Path = filePath, Date = DateTime.Now, Synced = false };
          EPhotoViewModel photoViewModel = new EPhotoViewModel(this, photoTaken);

          await Navigation.PushModalAsync(new EPhotoDetailPage(photoViewModel));
        }
        else
        {
          SetContextInfo("Cannot continue, try again.", InfoType.Error);
        }
      }
      catch (Exception ex)
      {
        SetContextInfo(ex.Message, InfoType.Error);
      }
    }

    public async Task LoadPhotosAsync()
    {
      try
      {
        _images = new ObservableCollection<EPhotoViewModel>();

        foreach (TPicture pic in await SQLiteHelper.Instance.GetPicturesAsync(Demande.Demande.Id, Action.Id))
        {
          EPhotoViewModel photoViewModel = new EPhotoViewModel(this, pic);
          _images.Add(photoViewModel);
          SyncHelper.Instance.SyncPhotoViewModels.AddOrUpdate(pic.Id, photoViewModel, (key, oldValue) => photoViewModel);
        }
      }
      catch (Exception ex)
      {
        SetContextInfo(ex.Message, InfoType.Error);
      }
    }
  }
}
