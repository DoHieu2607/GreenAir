using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class TicketType : IAggregateRoot
    {

        [StringLength(3, MinimumLength = 3)]
        public string TicketTypeId { get; set; }

        [StringLength(10, MinimumLength = 5)]
        public string TicketTypeName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BasePrice { get; set; }

        public IList<Ticket> Tickets { get; set; }
    }
}