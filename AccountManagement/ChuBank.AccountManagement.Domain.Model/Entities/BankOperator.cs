using ChuBank.Kernel.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuBank.AccountManagement.Domain.Model.Entities
{
    public class BankOperator : EntityGuid
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public List<BankTransaction> AuthorizedTransactions { get; set; }
    }
}
