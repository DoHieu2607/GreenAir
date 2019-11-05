using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class MakerRepository : Repository<Maker>, IMakerRepository
    {
        public MakerRepository(GreenairContext context) : base(context)
        {
        }
    }
}