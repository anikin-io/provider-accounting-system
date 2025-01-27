using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Оборудование"
    public class Equipment
    {
        public int EquipmentId { get; set; }
        [Required]
        public decimal SellingCost { get; set; }
        [Required]
        public string Model { get; set; }

        // Навигационные свойства для связи с Договорами 
        public ICollection<Contract> Contracts { get; set; }
    }
}