using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{

    // Модель "Тарифы"
    public class Tariff
    {
        public int TariffId { get; set; }
        [Required]
        public string TariffName { get; set; }
        public int Speed { get; set; }
        public decimal TariffCost { get; set; }
        public string? TariffDescription { get; set; }
        [Required]
        public string PaymentType { get; set; }

        // Навигационное свойство для связи с Договорами и Заявками
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}