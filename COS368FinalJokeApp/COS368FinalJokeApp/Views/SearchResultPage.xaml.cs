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
    public partial class SearchResultPage : ContentPage
    {
        public SearchResultPage()
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Xamarin.Forms.Color.FromHex("F23333");
            SearchBar.Text = "";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SearchBar.Focus();
        }
    private void OnUnfocused(System.Object sender, FocusEventArgs e) {
        Label.Text = SearchBar.Text;
           
           SearchResults searchResults = new SearchResults();
           Label[] labels = new Label[] { Label1, Label2, Label3, Label3, Label4, Label5, Label6, Label7,Label8, Label9, Label10, Label11 };

           if (SearchBar.Text.Equals("d", StringComparison.OrdinalIgnoreCase)) {
               int i = 0;
               foreach (string result in searchResults.jsonData.D.Values) {
                   labels[i].Text = result;
                   i++;
               }
           }else if (SearchBar.Text.Equals("da", StringComparison.OrdinalIgnoreCase)) {
               int i = 0;
               foreach (string result in searchResults.jsonData.Da.Values) {
                   labels[i].Text = result;
                   i++;
               }
           }else if (SearchBar.Text.Equals("dad", StringComparison.OrdinalIgnoreCase)) {
               int i = 0;
               foreach (string result in searchResults.jsonData.Dad.Values) {
                   labels[i].Text = result;
                   i++;
               }
           }
           else if (SearchBar.Text.Equals("dad jokes", StringComparison.OrdinalIgnoreCase)){
               int i = 0;
               foreach (string result in searchResults.jsonData.Dadjokes.Values) {
                   labels[i].Text = result;
                   i++;
               }
           }
    }
    }
}