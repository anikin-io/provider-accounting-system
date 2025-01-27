using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Потенциальные абоненты"
    public class PotentialSubscriber
    {
        public int PotentialSubscriberId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string LastName { get; set; }

        // Навигационное свойство для связи с Заявками
        public ICollection<Request> Requests { get; set; }
    }
}