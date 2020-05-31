﻿using System;
using WarhammerApp.Mobile.Services;
using Xamarin.Forms;

namespace WarhammerApp.Mobile.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            errorMessage.IsVisible = false;

            var loginResult = await UserService.Login(usernameEntry.Text, passwordEntry.Text);

            if (loginResult.IsSuccessful)
            {
                App.IsUserLoggedIn = true;
                App.Token = loginResult.Token;

                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                errorMessage.Text = loginResult.ErrorMessage;
                errorMessage.IsVisible = true;
            }
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}