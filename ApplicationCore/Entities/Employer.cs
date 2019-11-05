using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Employer : Person, IAggregateRoot
    {
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public double Salary { get; set; }

        [ForeignKey("Job")]
        [Required]
        public string JobId { get; set; }
        public Job Job { get; set; }
    }
}