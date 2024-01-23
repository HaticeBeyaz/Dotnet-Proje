using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class CustomerProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CustomerId { get; set; } //foreign key

        //1-1 ilişki
        public Customer Customer { get; set; }  // customer profile customera bağlı
        public Seller Seller { get; set; }  //customer seller a bağlı

    }
}
