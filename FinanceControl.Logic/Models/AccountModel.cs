using FinanceControl.Logic.Enums;

namespace FinanceControl.Logic.Models
{
    public class AccountModel
    {
        public string Name { get; set; }
        public string Currence { get; set; }
        public decimal Balance { get; set; }
        public ClientFinanceType Type { get; set; }
    }
}
