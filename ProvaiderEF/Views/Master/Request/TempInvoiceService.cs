using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class TempInvoiceService
    {
        public Service Service { get; set; } 
        public int Quantity { get; set; } 
        public decimal TotalCost { get; set; }
    }
}
