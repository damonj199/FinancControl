using FinanceControl.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Logic.Models
{
    public class TransactionModel
    {
        public string Name { get; set; }
        public decimal Summ { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public int ClientFinanceId { get; set; }
        public bool IsIncome { get; set; }
        public bool InApproved { get; set; }
    }
}
