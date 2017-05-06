using System.ComponentModel.DataAnnotations;

namespace UrlShort.Models
{
    public class Url
    {
        [Required]
        public string UrlLong { get; set; }

        public string UrlShort { get; set; }
    }
}