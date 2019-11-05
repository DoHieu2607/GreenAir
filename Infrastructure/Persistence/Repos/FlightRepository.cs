using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class FlightRepository : Repository<Flight>, IFlightRepository
    {
        public FlightRepository(GreenairContext context) : base(context)
        {

        }
        public void disable(string id)
        {
            //this.GetBy(id).Status = (int)Status.DISABLED;
        }
        public void activate(string id)
        {
            // this.GetBy(id).Status = (int)Status.DISABLED;
        }
    }
}