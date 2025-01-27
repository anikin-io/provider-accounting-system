namespace ProvaiderEF
{
    // Модель "Счета"
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int? EmployeeId { get; set; }
        public int ContractId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal? InvoiceAmount { get; set; }

        // Навигационное свойство для связи с Договорами
        public Contract Contract { get; set; }
        // Навигационное свойство для связи с Сотрудниками
        public Employee Employee { get; set; }
        // Навигационное свойство для связи с Услугами через промежуточную таблицу
        public ICollection<Service> Services { get; set; }
        public ICollection<InvoiceService> InvoiceServices { get; set; } = new List<InvoiceService>();
    }
}