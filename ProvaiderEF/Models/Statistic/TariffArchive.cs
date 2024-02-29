using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class TariffArchive
    {
        public int TariffArchiveId { get; set; }
        [Required]
        public string TariffName { get; set; }
        public int Speed { get; set; }
        public decimal TariffCost { get; set; }
        public string? TariffDescription { get; set; }
        [Required]
        public string PaymentType { get; set; }
        public DateTime DeletionDate { get; set; }
    }
}
