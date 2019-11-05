
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Maker : IAggregateRoot
    {
        [Key]
        [StringLength(3, MinimumLength = 3)]
        public string MakerId { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string MakerName { get; set; }

        public Address Address { get; set; }

        public IList<Plane> Planes { get; set; }
    }


}