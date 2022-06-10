using Splat;

namespace ForTheMemes.IoC
{
    public static class SplatExtensions
    {
        public static T Locate<T>(this T obj) where T : class => obj ?? Locator.Current.GetService<T>();
    }
}