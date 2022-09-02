using System.Threading;
using System.Threading.Tasks;

namespace Pwes.Domain
{
    public interface IPayemtProcessor
    {
        Task<TResponse> ProcessAsync<TResponse>(IPaymentRequest<TResponse> paymentRequest, CancellationToken token) where TResponse:IPaymentResponse;
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
