using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationCore.Entities;
namespace Infrastructure.Persistence.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.Metadata.FindNavigation(nameof(Flight.FlightDetails)).SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}