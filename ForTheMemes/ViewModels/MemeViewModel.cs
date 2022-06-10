namespace ForTheMemes.ViewModels
{
    public class MemeViewModel : ViewModelBase
    {
        public MemeViewModel(string id, string name, string url, int height, int width, int boxCount)
        {
            Id = id;
            Name = name;
            Url = url;
            Height = height;
            Width = width;
            BoxCount = boxCount;
        }

        public string Id { get; }
        public string Name { get; }
        public string Url { get; }
        public int Height { get; }
        public int Width { get; }
        public int BoxCount { get; }
    }
}