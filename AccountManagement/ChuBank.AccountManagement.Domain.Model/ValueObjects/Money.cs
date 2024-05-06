using ChuBank.Kernel.Domain.Model.ValueObjects;


namespace ChuBank.AccountManagement.Domain.Model.ValueObjects
{
    public class Money : ValueObject
    {
        public string CurrencyCode { get; }
        public decimal Amount { get; }

        public override string ToString()
        {
            return $"{CurrencyCode} {Amount}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return CurrencyCode;
        }
    }
}
