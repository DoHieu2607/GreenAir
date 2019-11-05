using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repos;
namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GreenairContext _context;

        public UnitOfWork(GreenairContext context)
        {
            this.Accounts = new AccountRepository(context);
            this.Airports = new AirportRepository(context);
            this.Persons = new PersonRepository(context);
            this.Customers = new CustomerRepository(context);
            this.Employers = new EmployerRepository(context);
            this.Flights = new FlightRepository(context);
            this.Jobs = new JobRepository(context);
            this.Makers = new MakerRepository(context);
            this.Planes = new PlaneRepository(context);
            this.Routes = new RouteRepository(context);
            this.Tickets = new TicketRepository(context);
            this.TicketTypes = new TicketTypeRepository(context);
            _context = context;

        }
        public IAccountRepository Accounts { get; private set; }

        public IAirportRepository Airports { get; private set; }

        public IPersonRepository Persons { get; private set; }

        public ICustomerRepository Customers { get; private set; }

        public IEmployerRepository Employers { get; private set; }

        public IFlightRepository Flights { get; private set; }

        public IJobRepository Jobs { get; private set; }

        public IMakerRepository Makers { get; private set; }

        public IPlaneRepository Planes { get; private set; }

        public IRouteRepository Routes { get; private set; }

        public ITicketRepository Tickets { get; private set; }

        public ITicketTypeRepository TicketTypes { get; private set; }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}