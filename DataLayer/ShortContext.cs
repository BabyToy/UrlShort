using System.Data.Entity;

namespace DataLayer
{
    public class ShortContext : DbContext
    {
        public ShortContext() : base()
        {
        }

        public DbSet<UrlShort> ShortUrls { get; set; }
    }
}