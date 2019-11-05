using ApplicationCore.Entities;
using System.Linq;
namespace Infrastructure.Persistence
{
    public class DataSeed
    {
        public static void Initialize(GreenairContext context)
        {
            context.Database.EnsureCreated();

            if (context.Makers.Any()) return;

            context.Makers.AddRange(

            );
            context.SaveChanges();
        }

    }
}