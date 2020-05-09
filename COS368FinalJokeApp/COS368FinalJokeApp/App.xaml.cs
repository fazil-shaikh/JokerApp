using Xamarin.Forms;

namespace COS368FinalJokeApp
{
    public partial class App : Application {

        public static bool Darkmode = false;  
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new SplashPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
