using System.Threading.Tasks;

namespace UrlShort
{
    public interface IUrlHandler
    {
        Task<string> UrlShorten(string urlLong);
    }
}