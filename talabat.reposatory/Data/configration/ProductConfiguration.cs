using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talabat.core.entites;

namespace talabat.reposatory.Data
{
    internal class productConfigration : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
        
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p=>p.Price).HasColumnType("decimal(18,2)");

        }
    }
}
