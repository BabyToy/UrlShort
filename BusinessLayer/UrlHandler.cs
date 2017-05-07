using DataLayer;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace UrlShort
{
    public class UrlHandler : IUrlHandler
    {
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
                    segment = NewSegment();

                    // throw exception if empty
                    //if (string.IsNullOrEmpty(segment))

                    url = new ShortUrl()
                    {
                        UrlLong = urlLong,
                        DateAdded = DateTime.Now,
                        Segment = segment
                    };

                    context.ShortUrls.Add(url);
                    context.SaveChanges();

                    return url;
                }
            });
        }

        private string NewSegment()
        {
            using (var context = new ShortContext())
            {
                int idx = 0;
                while (idx < 30)
                {
                    var segment = Guid.NewGuid().ToString().Substring(0, 6);
                    if (!context.ShortUrls.Where(x => x.Segment == segment).Any())
                    {
                        return segment;
                    }
                    idx++;
                }
            }
            return string.Empty;
        }
    }
}