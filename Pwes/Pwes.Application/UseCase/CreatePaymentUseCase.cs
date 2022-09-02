using System.Threading;
using Pwes.Domain.Payments;
using System.Threading.Tasks;
using Pwes.Domain;

namespace Pwes.Application.UseCase
{

    public class CreatePaymentUseCase
    {
        public readonly IPaymentValidator _validator;
        private readonly IPaymentRespository _respository;
        private readonly IPayemtProcessor _payemtProcessor;
        public CreatePaymentUseCase(
            IPaymentRespository respository,
            IPayemtProcessor payemtProcessor,
            IPaymentValidator validator)
        {
            _respository = respository;
            _payemtProcessor = payemtProcessor;
            _validator = validator;
        }

        public async Task<string> ExecuteAsync<TResponse>(IPaymentRequest<TResponse> request, CancellationToken token) where TResponse : IPaymentResponse
        {

            _validator.ValidatePayment(request);

            var payment = Payment.Create(request.RequestType, request, request.Reference, request.Amount);

            await _respository.SaveAsync(payment, token);

            var res = await _payemtProcessor.ProcessAsync(request, token);

            //

            return "Payment Accepted for proceesing...";
        }
    }

}