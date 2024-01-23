using DotnetYuzuncuYil.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerId).UseIdentityColumn();
            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PassWord).IsRequired().HasMaxLength(100);
        }
    }
}
