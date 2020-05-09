using Xamarin.Forms;

namespace COS368FinalJokeApp
{
    public partial class CommentsPage : ContentPage {

        public CommentsPage(string title)
        {
            InitializeComponent();
            BackgroundImage = App.Darkmode ? "blackbackground.png" : "gradientbackground.png";
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Xamarin.Forms.Color.FromHex("F23333");

            LoadComments(title);
            Title.Text = "Comments";
        }

        private void LoadComments(string title) {
            Comments commentData = new Comments();

            Label[] users = {User, User1, User2, User3 ,User4 ,User5 , User6, }; 
            Label[] comments = {Comment, Comment1, Comment2, Comment3 ,Comment4 ,Comment5 , Comment6, }; 

            //this would be a thousand times better with an api 
            if (title.Equals("Feed")) {
                int i = 0;
                foreach (Label post in comments) {
                    users[i].Text = commentData.comments.Feed[i].username;
                    comments[i].Text = commentData.comments.Feed[i].comment;
                    i++;
                }
            }
            else if (title.Equals("Sports")) {
                int i = 0;
                foreach (Label post in comments) {
                    users[i].Text = commentData.comments.Sports[i].username;
                    comments[i].Text = commentData.comments.Sports[i].comment;
                    i++;
                }
            }
            else if (title.Equals("Fortnite")) {
                int i = 0;
                foreach (Label post in comments) {
                    users[i].Text = commentData.comments.Fortnite[i].username;
                    comments[i].Text = commentData.comments.Fortnite[i].comment;
                    i++;
                }
            }
            else {
                int i = 0;
                foreach (Label post in comments) {
                    users[i].Text = commentData.comments.DadJokes[i].username;
                    comments[i].Text = commentData.comments.DadJokes[i].comment;
                    i++;
                }
            }
        }
    }
}
