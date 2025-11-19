using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PictureDirect.ViewModels
{

  //----------------------------------------------------------------------------
  public class EBaseViewModel : INotifyPropertyChanged
  {
    public bool IsBusy
    {
      get { return _isBusy; }
      set { SetProperty(ref _isBusy, value); }
    }
    private bool _isBusy = false;

    public bool IsEmpty
    {
      get { return _isEmpty; }
      set
      {
        _isEmpty = value;
        OnEmptyChanged(this, new PropertyChangedEventArgs("IsEmpty"));
      }
    }
    private bool _isEmpty = false;

    public INavigation Navigation { get; set; }

    //----------------------------------------------------------------------------
    private void OnEmptyChanged(EBaseViewModel baseViewModel, PropertyChangedEventArgs propertyChangedEventArgs)
    {
      // si using Plugin.Toast; alors CrossToastPopUp.Current.ShowToastMessage("No Data Found");
    }

    public string Title
    {
      get => _title;
      set => SetProperty(ref _title, value);
    }
    private string _title = string.Empty;

    public string BusyText
    {
      get => _busyText;
      set => SetProperty(ref _busyText, value);
    }
    private string _busyText = string.Empty;

    public string ContextInfo
    {
      get => _contextInfo;
      set => SetProperty(ref _contextInfo, value);
    }
    private string _contextInfo = string.Empty;

    public InfoType ContextInfoType
    {
      get => _contextInfoType;
      set => SetProperty(ref _contextInfoType, value, propertiesToNotify: new[] { "HasContextInfo", "ContextInfoColor" });
    }
    private InfoType _contextInfoType = InfoType.None;

    public bool HasContextInfo
    {
      get { return ContextInfoType != InfoType.None; }
    }

    public Color ContextInfoColor
    {
      get
      {
        switch (_contextInfoType)
        {
          case InfoType.Error:
            return Color.Red;
            break;

          case InfoType.Info:
            return Color.Blue;
            break;

          case InfoType.Progress:
            return Color.Blue;
            break;

          case InfoType.None:
          default:
            return Color.Transparent;
            break;
        }
      }
    }

    private DateTime _lastSetContextInfo;
    protected void SetContextInfo(string info, InfoType infoType)
    {
      _lastSetContextInfo = DateTime.Now;
      ContextInfo = info;
      ContextInfoType = infoType;

      Task.Run(() =>
      {
        //Task.Delay(10000);
        while (DateTime.Now < _lastSetContextInfo.Add(new TimeSpan(0, 0, 10)))
        {
          Task.Delay(1000);
        }


        ContextInfo = "";
        ContextInfoType = InfoType.None;
      });
    }

    //----------------------------------------------------------------------------
    protected bool SetProperty<T>(ref T backingStore, T value,
    [CallerMemberName]string propertyName = "",
        Action onChanged = null, IEnumerable<string> propertiesToNotify = null)
    {
      if (EqualityComparer<T>.Default.Equals(backingStore, value))
        return false;

      backingStore = value;
      onChanged?.Invoke();
      OnPropertyChanged(propertyName);

      if (propertiesToNotify != null)
      {
        foreach (string propertyToNotify in propertiesToNotify)
          OnPropertyChanged(propertyToNotify);
      }

      return true;
    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;
    //----------------------------------------------------------------------------
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
      var changed = PropertyChanged;
      if (changed == null)
        return;

      changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
  }

  public enum InfoType
  {
    None,
    Progress,
    Info,
    Error
  }

  public class EBusyManager : IDisposable
  {
    private EBaseViewModel _baseViewModel;
    private bool _isBusyPreviousValue;

    protected EBusyManager(EBaseViewModel baseViewModel)
    {
      _baseViewModel = baseViewModel;
      _isBusyPreviousValue = _baseViewModel.IsBusy;

      _baseViewModel.IsBusy = true;
    }

    private static EBusyManager _instance;

    public static EBusyManager GetInstance(EBaseViewModel baseViewModel)
    {
      if (_instance == null)
        _instance = new EBusyManager(baseViewModel);

      return _instance;
    }

    public void Dispose()
    {
      if (_baseViewModel != null)
        _baseViewModel.IsBusy = _isBusyPreviousValue;

      _instance = null;
    }
  }
}
