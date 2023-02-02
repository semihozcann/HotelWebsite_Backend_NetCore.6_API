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
    public class RoomTypeMap : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.ImageUrl);
            builder.Property(r => r.ImageUrl).HasMaxLength(500);
            builder.Property(r => r.Name).IsRequired();
            builder.Property(r => r.Name).HasMaxLength(50);
            builder.Property(r => r.NumberOfPeople).IsRequired();
            builder.Property(r => r.NumberOfPeople).HasMaxLength(1);
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.UpdatedDate);
            builder.ToTable("RoomTypes");
        }
    }
}
