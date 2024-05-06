
using ChuBank.AccountManagement.Domain.Model.ValueObjects;
using ChuBank.Kernel.Domain.Model.Entities;

namespace ChuBank.AccountManagement.Domain.Model.Entities
{
    public class BankAccount : EntityGuid
    {
        public string AccountNumber { get; set; }
        public string Agency { get; set; }
        public Money Balance { get; set; }
        public BankClient Holder { get; set; }
        public List<BankTransaction> Transactions { get; set; }
    }
}
