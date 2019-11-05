using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class RouteRepository : Repository<Route>, IRouteRepository
    {
        public RouteRepository(GreenairContext context) : base(context)
        {
        }
    }
}