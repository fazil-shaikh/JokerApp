using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace COS368FinalJokeApp {
    public class Comments {
        public CommentDeserializer.CommentData comments;
        public Comments() { 
            initialzeData();

        }

        public void initialzeData() {
             comments = loadJsonFile();
             
        }
        
        public  CommentDeserializer.CommentData loadJsonFile() {

            string json;
            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("COS368FinalJokeApp.model.comments.json"))){
                json = reader.ReadToEnd();
            }
            
            return CommentDeserializer.Deserializer(json);
        }
    }
}