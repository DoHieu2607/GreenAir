using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class AirportRepository : Repository<Airport>, IAirportRepository
    {
        public AirportRepository(GreenairContext context) : base(context)
        {
        }
    }
}