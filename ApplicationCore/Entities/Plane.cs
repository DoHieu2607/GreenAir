using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Plane : IAggregateRoot
    {
        [Key]
        [StringLength(5, MinimumLength = 5)]
        public string PlaneId { get; set; }
        public int SeatNum { get; set; }

        [ForeignKey("Maker")]
        [Required]
        public string MakerId { get; set; }
        public Maker Maker { get; set; }

        public IList<Flight> Flights { get; set; }
    }
}