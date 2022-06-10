using ForTheMemes.Data;
using Splat;

namespace ForTheMemes
{
    internal class AppBootstrapper
    {
        private const string BaseAddress = "https://api.imgflip.com";

        public void RegisterDependencies()
        {
            Locator.CurrentMutable.RegisterConstant<IImgFlipDataSource>(new ImgFlipDataSource(BaseAddress));
            Locator.CurrentMutable.RegisterConstant<IMemeRepository>(new MemeRepository());
        }
    }

    internal static class AppBootstrapperExtensions
    {
        public static void Bootstrap(this App app)
        {
            var bootstrapper = new AppBootstrapper();
            bootstrapper.RegisterDependencies();
        }
    }
}