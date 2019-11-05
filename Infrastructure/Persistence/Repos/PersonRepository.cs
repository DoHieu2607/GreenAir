using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class PersonRepository : Repository<Person>, IPersonBaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(GreenairContext context) : base(context)
        {
        }
    }
}