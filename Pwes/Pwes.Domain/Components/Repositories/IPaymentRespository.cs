using Pwes.Domain.Payments;
using System.Threading;
using System.Threading.Tasks;

namespace Pwes.Domain
{

    public interface IPaymentValidator
    {
        public void ValidatePayment<TResposne>(IPaymentRequest<TResposne> paymentRequest) where TResposne : IPaymentResponse;
    }
    /// <summary>
    /// Request persistence
    /// </summary>
    public interface IPaymentRespository
    {
        Task SaveAsync(Payment payment, CancellationToken token);
    }

    /*
     * 1. A user wants make payment
     * 2. User can select one of the available payment options
     * 3. Based on the payment option,
     * 4. user can either recieve OTP or complete payment
     * 
     * Flow:
     * Get payment request from the User - save DB
     * Save the payment request - Process
     * Process the payment request - 
     * Return response to use
     */
}
