
using System.ComponentModel.DataAnnotations;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Ticket : IAggregateRoot
    {
        [StringLength(5, MinimumLength = 5)]
        [RegularExpression("^[A-Z][0-9]{4}$")]
        public string TicketId { get; set; }

        [StringLength(25, MinimumLength = 5)]
        public string AssignedCus { get; set; }
        public int Status { get; set; }

        [Required]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public string TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

        [Required]
        public string FlightId { get; set; }
        public Flight Flight { get; set; }

        // public void disable() => status = (int)Status.DISABLED;
        // public void activate() => status = (int)Status.AVAILABLE;

        // [DataType(DataType.Currency)]
        // public decimal CalPrice()
        // {

        // }
    }
}