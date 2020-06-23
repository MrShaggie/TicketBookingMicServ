using System;
using System.ComponentModel.DataAnnotations;

namespace MovieManagerService.DTO
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Movie_Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Movie_Description { get; set; }
        [Required]
        public DateTime DateAndTime { get; set; }
        [Required]
        public string MovieLanguage { get; set; }
        [Required]
        public int MultiplexId { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}
