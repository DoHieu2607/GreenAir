using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Airport : IAggregateRoot
    {
        [Key]
        [StringLength(5, MinimumLength = 5)]
        public string AirportId { get; set; }

        [StringLength(30, MinimumLength = 5)]
        public string AirportName { get; set; }

        public Address Address { get; set; }

        [InverseProperty("OrgAirport")]
        public IList<Route> RouteStarts { get; set; }

        [InverseProperty("DesAirport")]
        public IList<Route> RouteEnds { get; set; }
    }


}