using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PaymentMethods
{
    public class Transfer : IPaymentMethod
    {
        public void Demand()
        {
            Console.WriteLine("Chosen Payment Method: Transfer.");
        }
    }
}
