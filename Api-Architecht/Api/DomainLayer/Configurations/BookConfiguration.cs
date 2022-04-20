using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(m => m.BookName).IsRequired().HasMaxLength(200);
            builder.Property(m => m.AuthorName).IsRequired().HasMaxLength(200);
            builder.Property(m => m.Price).IsRequired();
            builder.Property(m => m.Page).IsRequired();
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
            builder.Property(m => m.CreatTime).HasDefaultValue(DateTime.Now);
            builder.ToTable("Books");
        }
    }
}
