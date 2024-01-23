using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using Microsoft.OpenApi.Writers;

namespace DotnetYuzuncuYil.API.Controllers
{
    public class CustomerProfileController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICustomerProfileService _customerProfileService;
        public CustomerProfileController(IMapper mapper, ICustomerProfileService customerProfileService)
        {
            _mapper = mapper;
            _customerProfileService = customerProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var customerProfiles = await _customerProfileService.GetAllAsync();
            var customerProfileDTOs = _mapper.Map<List<CustomerProfileDTO>>(customerProfiles.ToList());
            return CreateActionResult(ResponseDTO<List<CustomerProfileDTO>>.Success(200, customerProfileDTOs));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var customerProfile = await _customerProfileService.GetById(id);
            var customerProfileDTOs = _mapper.Map<CustomerProfileDTO>(customerProfile);
            return CreateActionResult(ResponseDTO<CustomerProfileDTO>.Success(200,customerProfileDTOs));    
        }

        [HttpPost]

        public async Task <IActionResult> Save(CustomerProfileDTO customerProfileDTO)
        {
            var customerProfile = await _customerProfileService.AddAsync(_mapper.Map<CustomerProfile>(customerProfileDTO));
            var customerProfileDTOs= _mapper.Map<CustomerProfileDTO>(customerProfile);
            return CreateActionResult(ResponseDTO<CustomerProfileDTO>.Success(201, customerProfileDTOs));
        }
        [HttpPut]
        public async Task<IActionResult> Update(CustomerProfileDTO customerProfileDTO)
        {
            await _customerProfileService.UpdateAsync(_mapper.Map<CustomerProfile>(customerProfileDTO));
            return CreateActionResult(ResponseDTO<NoContentDTO>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var customerProfile = await _customerProfileService.GetById(id);
            await _customerProfileService.RemoveAsync(customerProfile);

            return CreateActionResult(ResponseDTO<NoContentDTO>.Success(204));
        }
    }
}
