using System.Threading.Tasks;
using System;
namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Accounts { get; }
        IAirportRepository Airports { get; }
        IPersonRepository Persons { get; }
        ICustomerRepository Customers { get; }
        IEmployerRepository Employers { get; }
        IFlightRepository Flights { get; }
        IJobRepository Jobs { get; }
        IMakerRepository Makers { get; }
        IPlaneRepository Planes { get; }
        IRouteRepository Routes { get; }
        ITicketRepository Tickets { get; }
        ITicketTypeRepository TicketTypes { get; }

        Task<int> CompleteAsync();
        int Complete();
    }
}