using System;
using Xamarin.Forms;

namespace WarhammerApp.Mobile.Views
{
    public partial class CharacterPage : ContentPage
    {
        private readonly int id;

        public CharacterPage(int id)
        {
            this.id = id;

            InitializeComponent();
        }

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            App.Token = null;

            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}