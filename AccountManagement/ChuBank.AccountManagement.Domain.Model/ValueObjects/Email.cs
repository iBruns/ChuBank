using ChuBank.Kernel.Domain.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuBank.AccountManagement.Domain.Model.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; }

        public Email(string address)
        {
            if (!ValidateEmail(address))
                throw new ArgumentException("Email inválido", nameof(address));

            Address = address;
        }

        private bool ValidateEmail(string address)
        {
            // validation logic here

            return true;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Address;
        }
    }
}
