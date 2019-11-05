using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class CustomerRepository : Repository<Customer>, IPersonBaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(GreenairContext context) : base(context)
        {
        }
    }
}