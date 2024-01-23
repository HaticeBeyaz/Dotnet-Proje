using Autofac.Diagnostics;
using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ISellerService _sellerService;

        public SellerController(IMapper mapper, ISellerService sellerService)
        {
            _mapper = mapper;
            _sellerService = sellerService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var sellers = await _sellerService.GetAllAsync();//
            var sellersDto = _mapper.Map<List<SellerDTO>>(sellers.ToList());
            return CreateActionResult(ResponseDTO<List<SellerDTO>>.Success(200, sellersDto));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, Exception arithmeticException)
        {
            var seller = await _sellerService.GetById(id);
            var sellerDto = _mapper.Map<SellerDTO>(seller);
            return CreateActionResult(ResponseDTO<SellerDTO>.Success(200, sellerDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SellerDTO sellerDTO)
        {
            var seller =await _sellerService.AddAsync(_mapper.Map<Seller>(sellerDTO));
            var sellerDtos = _mapper.Map<SellerDTO>(seller);
            return CreateActionResult(ResponseDTO<SellerDTO>.Success(201, sellerDTO));
        }

        [HttpPut]
        public async Task<IActionResult>Update(SellerDTO sellerDTO)
        {
            //geri dönüş değeri olmadığı için var dememize gerek yok.
            await _sellerService.UpdateAsync(_mapper.Map<Seller>(sellerDTO)); //sellerdto entitysine çevir.
            return CreateActionResult(ResponseDTO<NoContentDTO>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var seller =_sellerService.GetById(id);//veritabanından model çekmek için getbyid kullanılır.
            await _sellerService.RemoveAsync(seller);
            return CreateActionResult(ResponseDTO<NoContentDTO>.Success(204));
        }
    }
}
