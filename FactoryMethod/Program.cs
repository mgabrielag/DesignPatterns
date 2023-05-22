using FactoryMethod;

Console.WriteLine("Escolha um método de pagamento: \n * Credit Card \n * Ticket \n * Transfer");
string chosenPaymentMethod = Console.ReadLine();
var paymentMethod = PaymentMethodFactory.ChoosePaymentMethod(chosenPaymentMethod);
paymentMethod.Demand();


