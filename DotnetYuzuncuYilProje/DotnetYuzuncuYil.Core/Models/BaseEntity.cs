using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Models
{
    public abstract class BaseEntity //kodları tekrar etmemek adına BaseEntity kullanırız.
    {
        public int Id { get; set; } //id tanımlama -primary key
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
