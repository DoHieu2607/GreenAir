using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence.Configuration
{
    public class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.OwnsOne(x => x.FlightTime).Property(x => x.Hour).HasColumnName("FlightHour");
            builder.OwnsOne(x => x.FlightTime).Property(x => x.Minute).HasColumnName("FlightMinute");
            builder.HasIndex(x => new { x.Origin, x.Destination }).IsUnique();
        }
    }
}