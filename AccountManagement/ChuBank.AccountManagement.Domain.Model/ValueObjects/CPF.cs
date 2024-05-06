

using ChuBank.Kernel.Domain.Model.ValueObjects;

namespace ChuBank.AccountManagement.Domain.Model.ValueObjects
{
    public class CPF : ValueObject
    {
        public string Code { get; }

        public CPF(string code)
        {
            if (!ValidateCPF(code))
                throw new ArgumentException("Invalid CPF", nameof(CODE));

            Code = code;
        }

        private bool ValidateCPF(string code)
        {
            // validation logic here

            return true;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
        }
    }
}
