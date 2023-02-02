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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.ImageUrl).IsRequired();
            builder.Property(i => i.ImageUrl).HasMaxLength(500);
            builder.Property(i => i.CreatedDate).IsRequired();
            builder.Property(i => i.UpdatedDate);
            builder.ToTable("Images");

        }
    }
}
