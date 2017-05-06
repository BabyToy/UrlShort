using System.Threading.Tasks;

namespace UrlShort
{
    public class UrlHandler : IUrlHandler
    {
        public Task<string> UrlShorten(string urlLong)
        {
            return Task.Run(() =>
            {
                return "http://www.google.com";
            });
        }
    }
}