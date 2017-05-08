using DataLayer;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UrlHandler : IUrlHandler
    {
        public Task<Stat> Click(string segment, string referrer, string userHostAddress)
        {
            return Task.Run(() =>
            {
                using (var context = new ShortContext())
                {
                    var url = context.ShortUrls.Where(x => x.Segment == segment)
                        .FirstOrDefault();

                    if (url == null)
                        return null;

                    var stat = new Stat()
                    {
                        Ip = userHostAddress,
                        Referrer = referrer,
                        ShortUrl = url
                    };

                    context.Stats.Add(stat);
                    context.SaveChanges();

                    return stat;
                }
            });
        }

        public Task<ShortUrl> UrlShorten(string urlLong, string ip, string segment = "")
        {
            return Task.Run(() =>
            {
                using (var context = new ShortContext())
                {
                    var url = context.ShortUrls.Where(x => x.UrlLong == urlLong)
                        .FirstOrDefault();

                    if (url != null)
                        return url;

                    // throw exception on conflicting segments
                    //if (!string.IsNullOrEmpty(url.Segment))
                    //else

                    url = GetShortUrl(context, urlLong, segment);
                    context.ShortUrls.Add(url);
                    context.SaveChanges();

                    return url;
                }
            });
        }

        public ShortUrl GetShortUrl(ShortContext context, string longUrl, string segment = "")
        {
            var generator = new Generator(context);
            segment = generator.NewSegment();

            return new ShortUrl()
            {
                UrlLong = longUrl,
                DateAdded = DateTime.Now,
                Segment = segment
            };
        }
    }
}