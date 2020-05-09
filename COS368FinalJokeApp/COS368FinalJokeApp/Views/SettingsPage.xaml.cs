using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
        }

        async void OnNotificationsToggled(Object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                await DisplayAlert("", "Notifications Turned On", "OK");
            }
        }
        async void Privacy_Cell_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }

        async void OnLangTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LanguagePage());
        }

        async void OnPrivTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }

        async void OnLogoutTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void OnDarkmodeToggled(object sender, ToggledEventArgs e) {
            App.Darkmode = e.Value; 
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
        }
    }
}