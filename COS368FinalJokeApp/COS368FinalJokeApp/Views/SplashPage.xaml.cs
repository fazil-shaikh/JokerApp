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
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
            if(App.Darkmode)
            {
                Logo.TextColor = Color.White;
            }
        }
        async void OnTap(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}