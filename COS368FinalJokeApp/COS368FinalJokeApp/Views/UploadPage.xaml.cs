using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.FilePicker;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COS368FinalJokeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadPage : ContentPage
    {
        public UploadPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
        }

        async void OnUploadTapped(Object sender, EventArgs args)
        {
            try
            {
                var file = await CrossFilePicker.Current.PickFile();
                if (file == null)
                    return;
                else
                    lbl.Text = file.FileName;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Using it again breaks it", ex.ToString(), "OK");
            }
        }

        async void OnSubmitTapped(Object sender, EventArgs args)
        {
            await DisplayAlert("Submit Successful", "Joke posted on your tag!", "OK");
        }

        private void OnAppearing(object sender, EventArgs e) {
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
 
        }
    }
}