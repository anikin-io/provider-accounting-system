using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaiderEF
{
    public class MasterStatistic
    {
        [Key]
        public int MasterStatisticId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeFullName { get; set; }
        public int FinishedRequestsCount { get; set; }
        public decimal TotalAmount { get; set; }

        public Employee Employee { get; set; }
    }
}
