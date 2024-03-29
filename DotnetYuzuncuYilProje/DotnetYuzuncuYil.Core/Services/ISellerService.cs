﻿using DotnetYuzuncuYil.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Services
{
    public interface ISellerService : IService<Seller>
    {
        Task RemoveAsync(Task<Seller> seller);
    }
}
