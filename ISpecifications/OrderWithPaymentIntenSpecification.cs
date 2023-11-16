using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models.Order_Aggregate;

namespace TazaFood_Core.ISpecifications
{
    public class OrderWithPaymentIntenSpecification:BaseSpecification<Order>
    {
        public OrderWithPaymentIntenSpecification(string paymentid):base(o=>o.PaymentIntent==paymentid)
        {
            
        }
    }
}
