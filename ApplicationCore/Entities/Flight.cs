using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Flight : IAggregateRoot
    {
        [Key]
        [StringLength(5, MinimumLength = 5)]
        public string FlightId { get; set; }
        public int Status { get; set; }

        [ForeignKey("Plane")]
        [Required]
        public string PlaneId { get; set; }
        public Plane Plane { get; set; }

        private IList<FlightDetail> _FlightDetails { get; set; }
        public IEnumerable<FlightDetail> FlightDetails => _FlightDetails?.ToList();

        public IList<Ticket> Tickets { get; set; }
    }
}