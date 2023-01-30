using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=HotelDb;Trusted_Connection=true");
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingItem> BookingItems { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomActivity> RoomActivities { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookingItemMap());
            builder.ApplyConfiguration(new BookingMap());
            builder.ApplyConfiguration(new ImageMap());
            builder.ApplyConfiguration(new OperationClaimMap());
            builder.ApplyConfiguration(new PaymentDetailMap());
            builder.ApplyConfiguration(new PaymentTypeMap());
            builder.ApplyConfiguration(new RoomActivityMap());
            builder.ApplyConfiguration(new RoomMap());
            builder.ApplyConfiguration(new RoomTypeMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserOperationClaimMap());
           
        }

    }
}
