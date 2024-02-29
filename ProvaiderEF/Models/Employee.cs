using System.ComponentModel.DataAnnotations;

namespace ProvaiderEF
{
    // Модель "Сотрудники"
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeePhone { get; set; }
        [Required]
        public string EmployeeFirstName { get; set; }
        public string? EmployeeMiddleName { get; set; }
        [Required]
        public string EmployeeLastName { get; set; }
        [Required]
        public string EmployeeAddress { get; set; }
        [Required]
        public string EmployeeType { get; set; }
        [Required]
        public string EmployeeLogin { get; set; }
        [Required]
        public string EmployeePassword { get; set; }

        // Навигационное свойство для связи с Договорами_Сотрудники
        public ICollection<Contract> Contracts { get; set; }
        // Навигационное свойство для связи с Счетами
        public ICollection<Invoice> Invoices { get; set; }
    }
}