using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Job : IAggregateRoot
    {
        [Key]
        [StringLength(3, MinimumLength = 3)]
        public string JobId { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string JobName { get; set; }
        public IList<Employer> Employers { get; set; }
    }
}