using FactoryMethod.PaymentMethods;


namespace FactoryMethod
{
    public static class PaymentMethodFactory
    {
        public static IPaymentMethod ChoosePaymentMethod(string PaymentMethod)
        {
            switch (PaymentMethod)
            {
                case "CreditCard":
                    return new CreditCard();
                case "Ticket":
                    return new Ticket();
                case "Transfer":
                    return new Transfer();
                default:
                    throw new ArgumentException("Choose a valid payment method.");
            }
        }
    }
}
