using Pwes.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Pwes.Infrastructure.Components.Processors.BankAccounts
{
    internal sealed class BankAccountPaymentProcessor : IPayemtProcessor
    {
        public Task<TResponse> ProcessAsync<TResponse>(IPaymentRequest<TResponse> paymentRequest, CancellationToken token) where TResponse : IPaymentResponse
        {
            throw new System.NotImplementedException();
        }
    }
}
