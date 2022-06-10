using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ForTheMemes.Models
{
    public class GetMemesResponse
    {
        public bool Success { get; set; }

        [JsonPropertyName("data")]
        public Data ResponseData { get; set; }

        public class Data
        {
            public List<Meme> Memes { get; set; }
        }
    }
}