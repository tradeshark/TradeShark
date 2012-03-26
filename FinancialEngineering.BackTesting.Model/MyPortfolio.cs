using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FinancialEngineering.BackTesting.Model
{
    public class MyPortfolio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int InnerCode { get; set; }
        [Required]
        public string SecuCode { get; set; }
        [Required]
        public string SecuAbbr { get; set; }
        [Required]
        public DateTime OpenDate { get; set; }
        [Required]
        public decimal OpenPrice { get; set; }
        public DateTime? CloseDate { get; set; }
        public decimal? ClosePrice { get; set; }
        public decimal? Return { get; set; }
    }
}
