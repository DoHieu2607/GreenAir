using System.Security.AccessControl;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence.Configuration;
namespace Infrastructure.Persistence
{
    public class GreenairContext : DbContext
    {
        public GreenairContext(DbContextOptions<GreenairContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AirportConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new MakerConfiguration());
            modelBuilder.ApplyConfiguration(new RouteConfiguration());
            modelBuilder.ApplyConfiguration(new EmployerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new FlightDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());

        }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Plane> Planes { get; set; }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightDetail> FlightDetails { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }

}