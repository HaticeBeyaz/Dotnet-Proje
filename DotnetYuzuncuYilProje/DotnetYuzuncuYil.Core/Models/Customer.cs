using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public class Customer : BaseEntity //baseentitiyden inherit alacak
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PassWord { get; set; }
        //Eğer aşağıdaki gibi foreing key belirtmemiz istenirse;
        // [ForeignKey("CustomerId")] bu şekilde tanımlama yapabiliriz.
        //ilişkilendirme kısmında foreign key
        public int CustomerId { get; set; }
        public Seller Seller { get; set; } // customer ile seller arasında 1-n ilişki tanımlaması
    }
}
