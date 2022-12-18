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

        public TurfInfo TurfInfo { get; set; }


        public MainViewModel()
        {
            TurfInfo = new TurfInfo();
        }

        [RelayCommand]
        public async void AddTurf()
        {
            TurfService turfService = new TurfService();

            var turf = TurfInfo;
            await turfService.AddUpdateTurfAsync(turf);                       
        }


    }
}
