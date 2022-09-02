using Pwes.Domain;

namespace Pwes.Infrastructure.Components.Processors.BankAccounts
{
    public class BankAccountRequest : IPaymentRequest<BankAccountResponse>
    {
        public string Reference { get; set; } = null!;
        public decimal Amount { get; set; }

        public string RequestType => "BankAccout";
    }

    public class BankAccountResponse : IPaymentResponse
    {
        public string Status { get; set; } = null!;

    }
}
