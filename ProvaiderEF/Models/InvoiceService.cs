using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class InvoiceService
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int? Amount { get; set; }
    }
}
