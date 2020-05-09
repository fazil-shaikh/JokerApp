using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
        }

        async void OnForgotTapped(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RecoveryPage());
        }

        async void OnLoginTapped(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NavPage());
        }

    }
}