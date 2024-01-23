using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class Seller : BaseEntity //baseentityden türüyecek
    {
        public DateTime CreatedDate;

        public string SellerName { get; set; }

        //bire çok ilişki
        public ICollection<Customer> Customer { get; set; }
    }
}
