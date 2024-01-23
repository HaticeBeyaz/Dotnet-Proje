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
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer { Id = 1, CustomerName = "Hatice", Email = "haticebeyaz@gmail.com", Phone = "555 555 55 55 ", PassWord = "passWord", CustomerId = 1, CreateDate = DateTime.Now },
                new Customer { Id = 2, CustomerName = "Eren", Email = "erenerensahin@gmail.com", Phone = "531 111 11 11 ", PassWord = "passWord1", CustomerId = 2, CreateDate = DateTime.Now },
                new Customer { Id = 3, CustomerName = "Elif", Email = "elifcakmak@gmail.com", Phone = "533 333 33 33 ", PassWord = "passWord2", CustomerId = 3, CreateDate = DateTime.Now },
                new Customer { Id = 4, CustomerName = "İlker", Email = "ilkerilker@gmail.com", Phone = "544 444 44 44 ", PassWord = "passWord3", CustomerId = 4, CreateDate = DateTime.Now },
                new Customer { Id = 5, CustomerName = "Esra", Email = "esrarse@gmail.com", Phone = "532 222 22 22 ", PassWord = "passWord4", CustomerId = 5, CreateDate = DateTime.Now }
                );
        }
    }
}

