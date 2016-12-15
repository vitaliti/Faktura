using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktura.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public decimal PriceWithoutDDS { get; set; }

        public int ProcentDDS { get; set; }

        public string Barcode { get; set; }
    }
}
