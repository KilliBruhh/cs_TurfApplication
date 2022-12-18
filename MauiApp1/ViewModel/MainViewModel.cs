using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp1.Services;
using MauiApp1.Models;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel
    {

        public ObservableCollection<TurfInfo> turfList { get;  }
        public TurfInfo TurfInfo { get; set; }

        public MainViewModel()
        {
            TurfInfo = new TurfInfo();
            turfList = new ObservableCollection<TurfInfo>();
        }

        [RelayCommand]
        public async void AddTurf()
        {
            TurfService turfService = new TurfService();

            var turf = TurfInfo;
            await turfService.AddUpdateTurfAsync(turf);
            OnLoad();
        }

        public async void OnLoad()
        {
            TurfService turfService = new TurfService();

            await turfService.GetTurfAsync();
        }

        [RelayCommand]
        public async void Edit()
        {
           // await Shell.Current.GoToAsync(nameof(EditPage));
        }

        [RelayCommand]
        public async void Delete()
        {
            TurfService turfService = new TurfService();

            var id = TurfInfo.Id;
            await turfService.DeleteTurfAsync(id);
        }

    }
}
