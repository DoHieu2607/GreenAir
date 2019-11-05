using ApplicationCore.Entities;
namespace ApplicationCore.Interfaces
{
    public interface IEmployerRepository : IRepository<Employer>, IPersonBaseRepository<Employer>
    {

    }
}