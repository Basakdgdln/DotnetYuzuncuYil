using DotnetYuzuncuYil.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
          new Category { Id = 1, Name = "Sanat", CategoryStatus = true },
          new Category { Id = 2, Name = "Ekonomi", CategoryStatus = true },
          new Category { Id = 3, Name = "Edebiyat", CategoryStatus = true },
          new Category { Id = 4, Name = "Spor", CategoryStatus = true }
         );
        }
    }
}
