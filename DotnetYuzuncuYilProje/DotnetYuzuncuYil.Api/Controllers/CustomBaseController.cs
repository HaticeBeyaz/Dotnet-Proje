using DotnetYuzuncuYil.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(ResponseDTO<T> response)
        {
            if (response.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}