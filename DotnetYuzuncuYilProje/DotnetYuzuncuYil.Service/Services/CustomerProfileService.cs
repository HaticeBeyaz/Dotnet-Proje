using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Repositories;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Core.UnitOfWork;
using Google.Api.Ads.AdWords.v201809;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Services
{
    public class CustomerProfileService : Service<CustomerProfile>, ICustomerProfileService
    {
        public CustomerProfileService(IGenericRepository<CustomerProfile> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }

}
