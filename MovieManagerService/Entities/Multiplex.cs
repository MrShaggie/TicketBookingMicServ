﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagerService.Entities
{
    public class Multiplex
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MultiplexName { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int CityId { get; set; }
    }
}
