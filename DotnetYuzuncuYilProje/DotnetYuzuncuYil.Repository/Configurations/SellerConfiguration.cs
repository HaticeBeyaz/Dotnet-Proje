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
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
           //Fluent API 

           //Primarykey
           builder.HasKey(x => x.Id);

            //primarykey otomatik olarak 1 er 1 er arttırma
            builder.Property(t=>t.Id)
                .UseIdentityColumn();

            //Sellername alanı için max uzunluk belirleme ve zorunlu alan yapma
            builder.Property(t => t.SellerName)
                .HasMaxLength(50)
                .IsRequired();

            /* tablo belirleme
             builder.ToTable("Seller");
             */
        }
    }
}
