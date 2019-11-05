using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repos
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(GreenairContext context) : base(context)
        {
        }
    }
}