using ForTheMemes.ViewModels;

namespace ForTheMemes.Models
{
    public class Meme
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int BoxCount { get; set; }


        public MemeViewModel ToViewModel() => new MemeViewModel(Id, Name, Url, Height, Width, BoxCount);
    }
}