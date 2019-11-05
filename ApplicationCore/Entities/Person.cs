using System.ComponentModel.DataAnnotations;
using ApplicationCore.Interfaces;
using ApplicationCore;
namespace ApplicationCore.Entities
{
    public class Person : IAggregateRoot
    {
        [StringLength(5, MinimumLength = 5)]
        public string Id { get; set; }

        [StringLength(25, MinimumLength = 5)]
        public string Name { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Số điện thoại không đúng")]
        public string Phone { get; set; }

        public Address Address { get; set; }
        public Account Account { get; set; }
        public int Status { get; set; }
    }

}