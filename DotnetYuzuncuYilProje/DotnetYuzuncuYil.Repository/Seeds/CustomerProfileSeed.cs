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
    public class CustomerProfileSeed : IEntityTypeConfiguration<CustomerProfile>
    {
        public void Configure(EntityTypeBuilder<CustomerProfile> builder)
        {
            builder.HasData(
                  new CustomerProfile { Id = 1, FirstName = "Hatice", LastName = "Beyaz" ,CustomerId = 1},
                  new CustomerProfile { Id = 2, FirstName = "Eren", LastName = "Şahin" ,CustomerId = 2},
                  new CustomerProfile { Id = 3, FirstName = "Elif", LastName = "Çakmak" ,CustomerId = 3},
                  new CustomerProfile { Id = 4, FirstName = "İlker", LastName = "Yılmaz", CustomerId = 4},
                  new CustomerProfile { Id = 5, FirstName = "Esra", LastName = "Yılmaz", CustomerId = 5}
                );
        }
    }
}
