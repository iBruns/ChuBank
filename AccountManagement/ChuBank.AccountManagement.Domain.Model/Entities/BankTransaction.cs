using ChuBank.AccountManagement.Domain.Model.Enums;
using ChuBank.AccountManagement.Domain.Model.ValueObjects;
using ChuBank.Kernel.Domain.Model.Entities;

namespace ChuBank.AccountManagement.Domain.Model.Entities
{
    public class BankTransaction : EntityGuid
    {
        public DateTime TransactionDate { get; set; }
        public Money Amount { get; set; }
        public TransactionType Type { get; set; }
        public BankAccount SourceAccount { get; set; }
        public BankAccount DestinationAccount { get; set; }
    }
}