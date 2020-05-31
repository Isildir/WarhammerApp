using System;
using System.Linq;
using WarhammerApp.Mobile.Services;
using Xamarin.Forms;

namespace WarhammerApp.Mobile.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            errorMessage.IsVisible = false;

            var singupResult = await UserService.Register(usernameEntry.Text, passwordEntry.Text);

            if (singupResult.IsSuccessful)
            {
                Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First());
                await Navigation.PopToRootAsync();
            }
            else
            {
                errorMessage.Text = singupResult.ErrorMessage;
                errorMessage.IsVisible = true;
            }
        }
    }
}