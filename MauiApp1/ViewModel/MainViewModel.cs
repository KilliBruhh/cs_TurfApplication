using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;
        
        [ObservableProperty]
        string text;

        [ObservableProperty]
        string errorText;


        // ICommand changed to RelayCommand
        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(text);
            // Add new Turf
            Text = string.Empty;
            checkInput(text);
        }

        [RelayCommand]
        void Delete(String s)
        {
            if(Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Tap(String s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");

            // For sending objects
            /*
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}",
            new Dictionary<string, object>
                {
                    {nameof(DetailPage), new object()}
                });
            */

        }

        [RelayCommand]
        async Task Edit(String s)
        {
            await Shell.Current.GoToAsync($"{nameof(EditPage)}?Text={s}");
        }

        public void checkInput(String input)
        {
            // Use array to put in the Drinks and check if input is contained in array
            // Array must be saved in Database?

            string[] drinks = { "Cola", "Beer", "Sprite" };
            bool valid = false;

            foreach(string x in drinks)
            {
                if (input.Contains(x))
                {
                    // Correct
                    valid = true;
                }
            }

            if(valid)
            {
                // True
            }
            else
            {
                // Wrong Input               
                ErrorText = "Error: Wrong input";
            }
     
        }


    }
}
