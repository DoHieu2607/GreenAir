using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(GreenairContext context) : base(context)
        {
        }
    }
}