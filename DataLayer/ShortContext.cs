using System.Data.Entity;

namespace DataLayer
{
    public class ShortContext : DbContext
    {
        public ShortContext() : base("UrlShort20170509043548_db")
        {
        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
        public DbSet<Stat> Stats { get; set; }
    }
}