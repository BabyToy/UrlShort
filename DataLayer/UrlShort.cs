using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class UrlShort
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
    }
}