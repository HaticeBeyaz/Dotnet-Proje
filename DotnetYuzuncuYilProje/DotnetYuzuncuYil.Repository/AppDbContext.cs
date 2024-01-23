using DotnetYuzuncuYil.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get;set; }
        public DbSet<CustomerProfile> CustomersProfile { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                    if(item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Modified:
                            {
                                entityReference.UpdateDate = DateTime.Now; break;
                            }
                            case EntityState.Added:
                            {
                                entityReference.CreateDate= DateTime.Now;
                                entityReference.UpdateDate=null; break;
                            }
                            case EntityState.Deleted: 
                            { 
                                entityReference.UpdateDate= DateTime.Now;break;
                            }
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
            }
        }
    }
