using CargoTracking.Server.Domain.Cargos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Server.Infrastructure.Configurations
{
    public sealed class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.OwnsOne(p => p.Sender, builder =>
            {
                builder.Property(p => p.FirstName).HasColumnType("varchar(50)");
                builder.Property(p => p.LastName).HasColumnType("varchar(50)");

            });
            builder.OwnsOne(p => p.Recipient);
            builder.OwnsOne(p => p.DeliveryAddress);
            builder.OwnsOne(p => p.CargoInformation, builder =>
            {
                builder.Property(p => p.cargoType).HasConversion(type => type.Value, value => CargoTypeEnum.FromValue(value));
            });

            builder.Property(p => p.cargoStatusEnum)
                .HasConversion(status => status.Value, value => Cargo.CargoStatusEnum.FromValue(value));
            

        }
    }
}
