using System.ComponentModel.DataAnnotations;

namespace UrlShort.Models
{
    public class Url
    {
        [Required]
        public string LongUrl { get; set; }

        public string ShortUrl { get; set; }
    }
}