using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.OwnsOne(x => x.Address)
                .Property(x => x.Num).HasColumnName("AddressNum");
            builder.OwnsOne(x => x.Address)
                .Property(x => x.Street).HasColumnName("Street");
            builder.OwnsOne(x => x.Address)
                .Property(x => x.District).HasColumnName("District");
            builder.OwnsOne(x => x.Address)
                .Property(x => x.City).HasColumnName("City");
            builder.OwnsOne(x => x.Address)
                .Property(x => x.State).HasColumnName("State");
            builder.OwnsOne(x => x.Address)
                .Property(x => x.Country).HasColumnName("Country");
        }
    }
}