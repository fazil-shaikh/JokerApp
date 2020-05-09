using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace COS368FinalJokeApp
{
    public class Joke
    {
        public string User { get; set; }
        public string Image { get; set; }
        public string Likes { get; set; }
        public string Comments { get; set; }
    }

    public class JokeService
    {
        public List<Joke> GetJokesListHome()
        {
            return new List<Joke>()
            {
                new Joke() { User="Trump2020Bruda", Image= "https://www.startupvitamins.com/media/products/10419/variant_1075.jpg?v1409313541", Likes="50K Likes", Comments="90 Comments" },
                new Joke() { User="FeelTheBern12", Image= "https://pics.me.me/michael-reeves-michaelreeves08-a-microwave-that-only-turns-on-when-60911566.png", Likes="5.5K Likes", Comments="89 Comments" },
                new Joke() { User="GamerBoy76", Image= "https://1stwebdesigner.com/wp-content/uploads/2015/09/web-designer-developer-jokes-humour-funny-40.jpg", Likes="10K Likes", Comments="100 Comments" },
                new Joke() { User="Homerman12", Image= "https://i.pinimg.com/originals/0a/50/e4/0a50e43751ee7497d407c4642c85757e.jpg", Likes="2K Likes", Comments="76 Comments" },
                new Joke() { User="Cornchips", Image= "https://starecat.com/content/wp-content/uploads/pregnant-woman-smoking-drinking-no-it-doesnt-affect-my-baby-12-years-later-kid-playing-fortnite.jpg", Likes="2.5K Likes", Comments="120 Comments" }
            };
        }
        public List<Joke> GetJokesListFortnite()
        {
            return new List<Joke>()
            {
                new Joke() { User="BeegYoshi12", Image= "https://i.redd.it/68aexnue3uj01.jpg", Likes="100K Likes", Comments="190 Comments" },
                new Joke() { User="xxMacInTostitosxx", Image= "https://gameranx.com/wp-content/uploads/2018/05/a3Kj8be_700b-700x673.jpg", Likes="5.9K Likes", Comments="89 Comments" },
                new Joke() { User="MarioMan10", Image= "https://res.cloudinary.com/lmn/image/upload/e_sharpen:100/f_auto,fl_lossy,q_auto/v1/gameskinnyc/9/0/5/905c1d59bbb1f78.jpg", Likes="12K Likes", Comments="12 Comments" },
                new Joke() { User="GamerChan", Image= "https://i.imgflip.com/2zp41c.jpg", Likes="10K Likes", Comments="12 Comments" },
                new Joke() { User="TonySteve10", Image= "https://www.tynker.com/projects/screenshot/5c3e19a8ff13b75e205a26f7/fortnite-memes.png", Likes="190K Likes", Comments="122 Comments" },
                new Joke() { User="Tortillas", Image= "https://starecat.com/content/wp-content/uploads/pregnant-woman-smoking-drinking-no-it-doesnt-affect-my-baby-12-years-later-kid-playing-fortnite.jpg", Likes="90K Likes", Comments="18 Comments" }
            };
        }

        public List<Joke> GetJokesListSports()
        {
            return new List<Joke>()
            {
                new Joke() { User="SportsMan12", Image= "https://i.imgflip.com/3a3ww6.jpg", Likes="123K Likes", Comments="90 Comments" },
                new Joke() { User="David28Dunzo", Image= "https://pics.me.me/wellbealright-guys-16-0-nfl-memes-dustatej0e-flacco-sports-memes-of-49146431.png", Likes="5.1K Likes", Comments="90 Comments" },
                new Joke() { User="CantTell7Me", Image= "https://pbs.twimg.com/media/Ch9_K7eWMAAOf_z.jpg", Likes="20K Likes", Comments="21 Comments" },
                new Joke() { User="WhyThoMe10", Image= "https://sayingimages.com/wp-content/uploads/and-then-sport-memes.jpg", Likes="17K Likes", Comments="19 Comments" },
                new Joke() { User="ElonMuskBro", Image= "https://i.pinimg.com/originals/f8/d6/7c/f8d67cf2b8e7a3d92a28804f6863064e.png", Likes="20K Likes", Comments="92 Comments" },
            };
        }

        public List<Joke> GetJokesListDad()
        {
            return new List<Joke>()
            {
                new Joke() { User="FunnyGuy500", Image= "https://pun.me/pages/moon-restaurant-dad-joke.jpg", Likes="121K Likes", Comments="128 Comments" },
                new Joke() { User="MoonMan12", Image= "https://i.pinimg.com/736x/8d/bd/8a/8dbd8abce9cc88f1ab51f338f5491189.jpg", Likes="11K Likes", Comments="17 Comments" },
                new Joke() { User="ThrillerNight112", Image= "https://i.pinimg.com/originals/58/cd/5a/58cd5a5a7aca3aaa524b35c915bcb74e.jpg", Likes="29K Likes", Comments="21 Comments" },
                new Joke() { User="JynaKing18x", Image= "https://miro.medium.com/max/4200/1*HJbxQ5suRboRxGtg8kX4Zg.png", Likes="27K Likes", Comments="79 Comments" },
                new Joke() { User="MaxPayne11", Image= "https://i.imgur.com/prZUmKN.jpg", Likes="29K Likes", Comments="12 Comments" },
            };
        }
    }
}
