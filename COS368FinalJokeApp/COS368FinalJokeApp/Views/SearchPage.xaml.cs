using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "bOnAppearing": "gradientbackground.png";
        }

        async void OnSearchClicked(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SearchResultPage());
        }

        async void OnFortniteClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FortniteJokesPage());
        }

        async void OnSportsClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SportsJokesPage());
        }

        async void OnDadJokesClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DadJokesPage());
        }

        async void OnCovid19Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("", "Currently Unavailable...", "OK");
        }
        async void OnPoliticsClicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("", "Currently Unavailable...", "OK");
        }
        async void OnTigerKingClicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("", "Currently Unavailable...", "OK");
        }

        private void OnAppearing(object sender, EventArgs e) {
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
        }
    }
}