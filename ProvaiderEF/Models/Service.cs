using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Услуги"
    public class Service
    {
        public int ServiceId { get; set; }
        public decimal? ServiceCost { get; set; }
        [Required]
        public string ServiceType { get; set; }

        // Навигационное свойство для связи с Счетами через промежуточную таблицу
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<InvoiceService> InvoiceServices { get; set; }
    }
}