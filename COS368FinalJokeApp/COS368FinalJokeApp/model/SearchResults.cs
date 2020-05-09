using System.IO;
using System.Reflection;

namespace COS368FinalJokeApp {
    public class SearchResults {

        public  Searches jsonData;
        
        public SearchResults() {
            initalizeData();
        }

        public void initalizeData() {
            setJsonData();
        }

        public void setJsonData() {
            string json;
            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("COS368FinalJokeApp.model.searchResults.json"))){
                json = reader.ReadToEnd();
            }
            jsonData = SearchDeserializer.FromJson(json).Searches;
        }
    }
}