namespace ProvaiderEF
{
    // Модель "Транзакции"
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int ContractId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }

        // Навигационное свойство для связи с Договорами
        public Contract Contract { get; set; }
    }
}