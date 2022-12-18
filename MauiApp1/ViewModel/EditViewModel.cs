using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using System.ComponentModel.DataAnnotations;

namespace MauiApp1.ViewModel
{
    public partial class EditViewModel : ObservableObject
    {
        [Required(ErrorMessage = "Fill In Forms")]
        public TurfInfo TurfInfo { get; set; }


        public EditViewModel()
        {
            TurfInfo = new TurfInfo();

        }


        [RelayCommand]
        public async void EditTurf()
        {
            TurfService turfService = new TurfService();

            var turf = TurfInfo;
            await turfService.AddUpdateTurfAsync(turf);
        }

    }
}
