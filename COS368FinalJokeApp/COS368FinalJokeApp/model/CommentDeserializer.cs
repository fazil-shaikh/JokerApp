using Newtonsoft.Json;

namespace COS368FinalJokeApp {
    public class CommentDeserializer {

        public static CommentData Deserializer(string jsonData) {
            return  JsonConvert.DeserializeObject<CommentData>(jsonData);
        }

       
        public class CommentData {
            public Feed[] Feed;
            public Sports[] Sports;
            public Fortnite[] Fortnite;
            public DadJoke[] DadJokes;
        }

        public class Feed {
            public string username;
            public string comment;
        }

        public class Sports {
            public string username;
            public string comment;
        }

        public class Fortnite {
            public string username;
            public string comment;
        }

        public class DadJoke {
            public string username;
            public string comment;
        }
        
    }
}