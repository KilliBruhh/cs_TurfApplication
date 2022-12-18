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
        public MainViewModel()
        {
            TurfInfo = new TurfInfo();
        }  

        [RelayCommand]
        public async void AddTurf()
        {
            var turf = TurfInfo;
            
        }

    }
}
