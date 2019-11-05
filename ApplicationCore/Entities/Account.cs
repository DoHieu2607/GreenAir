using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Account : IAggregateRoot
    {
        [Key]
        [StringLength(20, MinimumLength = 6)]
        public string Username { get; set; }

        [StringLength(20, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }

        [ForeignKey("Person")]
        [Required]
        public string PersonId { get; set; }
        public Person Person { get; set; }
    }
}