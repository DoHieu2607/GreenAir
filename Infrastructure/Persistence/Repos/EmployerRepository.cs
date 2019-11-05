using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class EmployerRepository : Repository<Employer>, IPersonBaseRepository<Employer>, IEmployerRepository
    {
        public EmployerRepository(GreenairContext context) : base(context)
        {
        }
    }
}