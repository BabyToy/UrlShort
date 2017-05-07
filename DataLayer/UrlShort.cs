using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("shorturls")]
    public class ShortUrl
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("urllong")]
        [StringLength(1000)]
        public string UrlLong { get; set; }

        [Required]
        [Column("DateAdded")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Column("Segment")]
        [StringLength(20)]
        public string Segment { get; set; }
    }
}