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
    public class SellerSeed : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
             builder.HasData(
            
                new Seller { Id = 1, SellerName = "ARGE", CreatedDate = DateTime.Now },
                new Seller { Id = 2, SellerName = "Sales", CreatedDate = DateTime.Now },
                new Seller { Id = 3, SellerName = "Marketing", CreatedDate = DateTime.Now },
                new Seller { Id = 4, SellerName = "IT", CreatedDate = DateTime.Now },
                new Seller { Id = 5, SellerName = "Finance", CreatedDate = DateTime.Now});
            }

        }
    }

