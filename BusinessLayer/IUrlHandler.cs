using DataLayer;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IUrlHandler
    {
        Task<ShortUrl> UrlShorten(string urlLong, string ip, string segment = "");
        Task<Stat> Click(string segment, string referrer, string userHostAddress);
    }
}