using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(GreenairContext context) : base(context)
        {
        }
    }
}