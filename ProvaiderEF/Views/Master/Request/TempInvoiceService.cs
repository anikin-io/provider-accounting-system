using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class TempInvoiceService
    {
        public Service Service { get; set; } // Объект класса Услуги
        public int Quantity { get; set; } // Количество услуг
        public decimal TotalCost { get; set; } // Общая стоимость для данной услуги
    }
}
