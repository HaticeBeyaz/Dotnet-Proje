using AutoMapper;
using DotnetYuzuncuYil.Core;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.DTOs.Authentication;
using DotnetYuzuncuYil.Core.Services;
using Google.Api.Ads.AdWords.v201809;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
    public class CustomerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly Core.Services.ICustomerService _CustomerService;
        public CustomerController(IMapper mapper, Core.Services.ICustomerService CustomerService)
        {
            _mapper = mapper;
            _CustomerService = CustomerService;
        }
     
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var customers = await _CustomerService.GetAllAsync();
            var CustomerDTO = _mapper.Map<List<CustomerDTO>>(customers.ToList());
            return CreateActionResult(ResponseDTO<List<CustomerDTO>>.Success(200, CustomerDTO));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Customer = await _CustomerService.GetById(id);
            var CustomerDTO = _mapper.Map<CustomerDTO>(Customer);
            return CreateActionResult(ResponseDTO<CustomerDTO>.Success(200, CustomerDTO));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CustomerDTO customerDTO)
        {
            await _CustomerService.UpdateAsync(_mapper.Map<CustomerDTO>(customerDTO));
            return CreateActionResult(ResponseDTO<NoContentDTO>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var customer = await _CustomerService.GetById(id);
            await _CustomerService.RemoveAsync(customer);
            return CreateActionResult(ResponseDTO<NoContentDTO>.Success(204));
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> SignUp(AuthRequestDTO authDto)
        {
            var Customer = _CustomerService.SignUp(authDto);
            var CustomerDto= _mapper.Map<CustomerDTO>(Customer);
            return CreateActionResult(ResponseDTO<CustomerDTO>.Success(201,CustomerDto));
        }

        [HttpPost("Login")]
        public IActionResult Login(AuthRequestDTO authDto)
        {
            AuthResponseDTO result = _CustomerService.Login(authDto);
            if (result.Customer != null)
                return CreateActionResult(ResponseDTO<AuthResponseDTO>.Success(200, result));
            else
                return CreateActionResult(ResponseDTO<AuthResponseDTO>.Success(401, result));
        }
    }
}