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
   public class CustomerProfileConfiguration : IEntityTypeConfiguration<CustomerProfile>
    {
        public void Configure(EntityTypeBuilder<CustomerProfile> builder)
        { 
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100); 
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.ToTable("CustomerProfile");
        }

        
    }
}
