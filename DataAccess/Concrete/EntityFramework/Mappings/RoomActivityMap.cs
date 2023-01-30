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
    public class RoomActivityMap : IEntityTypeConfiguration<RoomActivity>
    {
        public void Configure(EntityTypeBuilder<RoomActivity> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.RoomTypeId);
            builder.Property(r => r.NumberOfRoom).IsRequired();
            builder.Property(r => r.Date).IsRequired();
            builder.ToTable("RoomActivities");
        }
    }
}
