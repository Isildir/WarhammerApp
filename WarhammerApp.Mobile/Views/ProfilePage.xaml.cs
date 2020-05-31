using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WarhammerApp.Mobile.Services;
using Xamarin.Forms;

namespace WarhammerApp.Mobile.Views
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            CharactersView.ItemsSource = Characters;

            LoadCharactersData();
        }

        public ObservableCollection<Character> Characters { get; set; } = new ObservableCollection<Character>();

        private async Task LoadCharactersData()
        {
            var values = await CharacterService.GetCharactersList();

            foreach (var value in values)
                Characters.Add(value);
        }

        private async void OnCharacterSelect(object sender, ItemTappedEventArgs e)
        {
            var t = e.Item as Character;

            Navigation.InsertPageBefore(new CharacterPage(t.Id), this);
            Navigation.PopAsync();
        }

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            App.Token = null;

            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }

        private async void OnNewCharacterButtonClicked(object sender, EventArgs e)
        {
        }
    }
}