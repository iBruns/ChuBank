using ChuBank.AccountManagement.Domain.Model.ValueObjects;
using ChuBank.Kernel.Domain.Model.Entities;

namespace ChuBank.AccountManagement.Domain.Model.Entities
{
    public class BankClient : EntityGuid
    {
        public string Name { get; set; }
        public CPF CPF { get; set; } 
        public Email Email { get; set; }
    }
}