using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("stats")]
    public class Stat
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("ip")]
        [StringLength(50)]
        public string Ip { get; set; }

        [Column("referrer")]
        [StringLength(500)]
        public string Referrer { get; set; }

        public ShortUrl ShortUrl { get; set; }
    }
}