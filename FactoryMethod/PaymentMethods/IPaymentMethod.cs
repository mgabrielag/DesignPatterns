using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PaymentMethods
{
    public interface IPaymentMethod
    {
        void Demand();
    }
}
