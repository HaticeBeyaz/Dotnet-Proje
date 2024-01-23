using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.mapping
{
    public class mapProfile : Profile
    {
        public mapProfile()
        {
            CreateMap<Seller, SellerDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<CustomerProfile, CustomerProfileDTO>().ReverseMap();

            /*dto'dan entity'e çevirme
            CreateMap<SellerDTO, Seller>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<CustomerProfileDTO, CustomerProfile>();
        */
        }
    }
}