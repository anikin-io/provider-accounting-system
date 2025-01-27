using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Договоры"
    public class Contract
    {
        public int ContractId { get; set; }
        public int SubscriberId { get; set; }
        public int? TariffId { get; set; }
        public DateTime StartDate { get; set; }
        [Required]

        public string SubscriberLogin { get; set; }
        [Required]
        public string SubscriberPassword { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public string ConnectionAddress { get; set; }
        public bool IsSuspended { get; set; }

        // Навигационные свойства для связи с Абонентами, Тарифами и другими таблицами
        public Subscriber Subscriber { get; set; }
        public Tariff Tariff { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Equipment> Equipments { get; set; } = new List<Equipment>();
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}