using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class PlaneRepository : Repository<Plane>, IPlaneRepository
    {
        public PlaneRepository(GreenairContext context) : base(context)
        {
        }
    }
}