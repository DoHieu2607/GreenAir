using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IPersonRepository : IRepository<Person>, IPersonBaseRepository<Person>
    {

    }
}