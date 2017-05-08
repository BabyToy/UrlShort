using System.Data.Entity;

namespace DataLayer
{
    public class ShortContext : DbContext
    {
        public ShortContext() : base("UrlShortener")
        {
        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
        public DbSet<Stat> Stats { get; set; }
    }
}