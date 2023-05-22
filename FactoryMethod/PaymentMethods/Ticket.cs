using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PaymentMethods
{
    internal class Ticket : IPaymentMethod
    {
        public void Demand()
        {
            Console.WriteLine("Chosen Payment Method: Ticket.");
        }
    }
}
