using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktura.Models
{
    public class Firm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long Bulstat { get; set; }

        public string Adress { get; set; }

        public string Mol { get; set; }

        public bool IsMyFirm { get; set; }

    }
}
