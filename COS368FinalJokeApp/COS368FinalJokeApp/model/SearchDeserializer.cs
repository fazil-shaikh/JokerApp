using Newtonsoft.Json;

namespace COS368FinalJokeApp {
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class SearchDeserializer {
            [JsonProperty("searches")] public Searches Searches { get; set; }
        }

        public partial class Searches {
            [JsonProperty("d")] public Dictionary<string, string> D { get; set; }

            [JsonProperty("da")] public Dictionary<string, string> Da { get; set; }

            [JsonProperty("dad")] public Dictionary<string, string> Dad { get; set; }

            [JsonProperty("dadjokes")] public Dictionary<string, string> Dadjokes { get; set; }
        }

        public partial class SearchDeserializer {
            public static SearchDeserializer FromJson(string json) =>
                JsonConvert.DeserializeObject<SearchDeserializer>(json, Converter.Settings);
        }
        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        }
    }
