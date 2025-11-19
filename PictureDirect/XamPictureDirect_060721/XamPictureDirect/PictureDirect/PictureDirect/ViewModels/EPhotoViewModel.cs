

using PictureDirect.Helpers;
using PictureDirect.Models;
using PictureDirect.WCFService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  public class EPhotoViewModel : EBaseViewModel
  {
    //----------------------------------------------------------------------------
    /// <summary>
    /// Photo liée à ce Vue Modèle
    /// </summary>
    public TPicture Photo { get; }

    public EActionDetailViewModel Action { get; set; }

    public Command DiscardCommand { get; set; }

    public Command SaveCommand { get; set; }

    //----------------------------------------------------------------------------
    public EPhotoViewModel(EActionDetailViewModel action, TPicture photo)
    {
      Photo = photo;
      Action = action;

      if (Photo != null)
      {
        Synced = Photo.Synced;
        Error = Photo.Error;
      }

      DiscardCommand = new Command(async () => await ExecuteDiscardCommandAsync());
      SaveCommand = new Command(async () => await ExecuteSaveCommandAsync());
    }

    public Xamarin.Forms.ImageSource ImageSource { get { return Xamarin.Forms.ImageSource.FromFile(Photo.Path); } }

    /// <summary>
    /// Description de la Photo affichée
    /// </summary>
    [Required]
    public string Description
    {
      get { return Photo.Description; }
      set { Photo.Description = value; }
    }

    private bool _synced;
    public bool Synced
    {
      get
      {
        return _synced;
      }

      set
      {
        SetProperty(ref _synced, value, propertiesToNotify: new[] { "SyncImage" });
      }
    }

    private bool _syncing;
    public bool Syncing
    {
      get
      {
        return _syncing;
      }

      set
      {
        SetProperty(ref _syncing, value, propertiesToNotify: new[] { "NotSyncing" });
      }
    }

    private bool _error;
    public bool Error
    {
      get
      {
        return _error;
      }

      set
      {
        SetProperty(ref _error, value, propertiesToNotify: new[] { "SyncImage" });
      }
    }

    public bool NotSyncing
    {
      get
      {
        return !_syncing;
      }
    }

    public string SyncImage
    {
      get
      {
        if (Error)
          return "error.png";
        else if (Synced)
          return "ok.png";
        else
          return "nok.png";
      }
    }

    private async Task ExecuteDiscardCommandAsync()
    {
      try
      {
        await Navigation.PopModalAsync();
      }
      catch (Exception ex)
      {
        SetContextInfo(ex.Message, InfoType.Error);
      }
    }

    private async Task ExecuteSaveCommandAsync()
    {
      if (Description.Length == 0)
      {
        //SetContextInfo("Champ Commentaire obligatoir: \n Pour un équipement: nom de l'equipe.... \nPour document :....", InfoType.Info);
         await Application.Current.MainPage.DisplayAlert("Champ commentaire obligatoire", 
          "Pour un équipement : nom de l'équipement, marque, modèle, capacité ou poids, état visuel (Bon ou Moyen ou Mauvais), état fonctionnel (Bon ou En défaut ou HS) et Accessibilité \nExemple : Chauffe-eau, Atlantic, 50L, état visuel bon, état fonctionnel bon, accesibilité OK \n \nPour un document: nom du document (plan de prévention journalier, permis de travail, registre de sécurité...)\nExemple: PPJ station xxx", 
          "Ok");
      }
      else
      {
        try
        {
          Action.Images.Add(this);

          await SQLiteHelper.Instance.SavePictureAsync(Photo);

          SyncHelper.Instance.SyncPhotoViewModels.AddOrUpdate(Photo.Id, this, (key, oldValue) => this);

          Task.Run(async () => await SyncHelper.Instance.SyncAsync());

          await Navigation.PopModalAsync();
        }
        catch (Exception ex)
        {
          SetContextInfo(ex.Message, InfoType.Error);
        }
      }
      
    }
  }
}
