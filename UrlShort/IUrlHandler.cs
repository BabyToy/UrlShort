using DataLayer;
using System.Threading.Tasks;
using UrlShort.Models;

namespace UrlShort
{
    public interface IUrlHandler
    {
        Task<ShortUrl> UrlShorten(string urlLong, string segment = "");
    }
}