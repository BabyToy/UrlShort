using System.Data.Entity;

namespace DataLayer
{
    public class ShortContext : DbContext
    {
        public ShortContext() : base()
        {
        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
    }
}