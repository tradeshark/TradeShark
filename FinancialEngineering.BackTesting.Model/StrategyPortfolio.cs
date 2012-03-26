using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FinancialEngineering.BackTesting.Model
{
    public class StrategyPortfolio
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public Strategy Strategy { get; set; }
        [Required]
        public int InnerCode { get; set; }
        [Required]
        public string SecuCode { get; set; }
        public string SecuAbbr { get; set; }
        [Required]
        public DateTime OpenDate { get; set; }
    }
}
