using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagerService.Entities
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Movie_Name { get; set; }
        public string Movie_Description { get; set; }
        public DateTime DateAndTime { get; set; }
        public string MovieImage { get; set; }
        public string MovieLanguage { get; set; }

        [ForeignKey("MultiplexId")]
        public Multiplex Multiplex { get; set; }
        public int MultiplexId { get; set; }
    }
}
