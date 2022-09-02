namespace Pwes.Domain
{
    public interface IPaymentRequest<TResponse> where TResponse : IPaymentResponse
    {
        public string Reference { get; set; }
        public decimal Amount { get; set; }

        public string RequestType { get; }

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
