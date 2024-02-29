using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Заявки"
    public class Request
    {
        public int RequestId { get; set; }
        public int? TariffId { get; set; }
        public int? EquipmentId { get; set; }
        public int PotentialSubscriberId { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
        public string? RequestDescription { get; set; }
        [Required]
        public string RequestStatus { get; set; }

        // Навигационные свойства для связи с Тарифами, Оборудованием и Потенциальными абонентами
        public Tariff Tariff { get; set; }
        public Equipment Equipment { get; set; }
        public PotentialSubscriber PotentialSubscriber { get; set; }
    }
}