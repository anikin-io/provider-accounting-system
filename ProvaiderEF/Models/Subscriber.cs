using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Абоненты"
    public class Subscriber
    {
        public int SubscriberId { get; set; }
        [Required]
        public string PassportSubscriber { get; set; }
        [Required]
        public string FirstNameSubscriber { get; set; }
        public string? MiddleNameSubscriber { get; set; }
        [Required]
        public string LastNameSubscriber { get; set; }
        [Required]
        public string PhoneSubscriber { get; set; }

        // Навигационное свойство для связи с Договорами
        public ICollection<Contract> Contracts { get; set; }
    }
}