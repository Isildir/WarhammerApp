using System;
using Xamarin.Forms;

namespace WarhammerApp.Mobile.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAbilitiesButtonClicked(object sender, EventArgs e)
        {
        }

        private async void OnItemsButtonClicked(object sender, EventArgs e)
        {
        }

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            App.Token = null;

            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }

        private async void OnProfessionsButtonClicked(object sender, EventArgs e)
        {
        }

        private async void OnProfileButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new ProfilePage(), this);
            await Navigation.PopAsync();
        }

        private async void OnSkillsButtonClicked(object sender, EventArgs e)
        {
        }
    }
}