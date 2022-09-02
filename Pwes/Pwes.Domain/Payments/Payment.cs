using System;

namespace Pwes.Domain.Payments
{
    public class Payment
    {
        public string RequestType { get; private set; } //Bank Account, STK, USSD, Card, Paypal
        public object Payload { get; private set; }
        public string Reference { get; private set; }
        public decimal Amount { get; private set; }

        public string Status { get; private set; }
        private Payment() { }
        public static Payment Create(string type, object payment, string reference, decimal amount)
        {
            return new Payment(type, payment, reference, amount);
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }
        private Payment(string type, object payment, string reference, decimal amount)
        {
            if (amount < 0)
                throw new Exception("Amount must not be less than zero");

            Status = PaymentStatus.Pending;
            RequestType = type;
            Payload = payment;
            Reference = reference;
            Amount = amount;
        }
    }

    public class PaymentStatus
    {
        public static string Pending => nameof(Pending);
        public static string Successful => nameof(Successful);
        public static string Failed => nameof(Failed);
    }
}