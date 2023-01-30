using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class BookingMap : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(b => b.UserId);
            builder.Property(b => b.BookingItemId);
            builder.Property(b => b.PaymentId);
            builder.Property(b => b.CreatedDate).IsRequired();
            builder.Property(b => b.IsActive).IsRequired();
            builder.ToTable("Bookings");
        }
    }
}
