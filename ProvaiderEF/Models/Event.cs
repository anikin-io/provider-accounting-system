namespace ProvaiderEF
{
    public class Event
    {
        public int EventId { get; set; }
        public int? ContractId { get; set; }
        public DateTime EventDate { get; set; }
        public string EventStatus { get; set; }
        public string EventDescription { get; set; }

        // Навигационное свойство для связи с Договорами
        public Contract Contract { get; set; }
    }
}