using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Repositories;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Services
{
    public class SellerService : Service<Seller>, ISellerService
    {
        public SellerService(IGenericRepository<Seller> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public Task RemoveAsync(Task<Seller> seller)//gerekirse burayı sil.
        {
            throw new NotImplementedException();
        }
    }
}
