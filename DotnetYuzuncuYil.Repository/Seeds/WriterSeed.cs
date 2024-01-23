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
    public class WriterSeed : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasData(
           new Writer { Id = 1, Name = "Gökçe", Surname = "Balcı", Email = "gokce_balci@gmail.com", Password = "1wfy54" , UserName="gokcebalci"},
           new Writer { Id = 2, Name = "Akın", Surname = "Yılmaz", Email = "akın_yılmaz@gmail.com", Password = "02ax5tp", UserName="akinyilmaz" },
           new Writer { Id = 3, Name = "Deniz", Surname = "Göktürk", Email = "deniz_gokturk@gmail.com", Password = "84dc774", UserName="denizgokturk" }
            );
        }
    }
}
