using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.DTOs
{
    public class CustomerDTO:BaseDto
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
    }
}
