using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models.Order_Aggregate;

namespace TazaFood_Core.ISpecifications
{
    public class OrderSpecifications:BaseSpecification<Order>
    {
        public OrderSpecifications(string email) : base(o=>o.BuyerEmail==email)
        {
            Includes.Add(o => o.DeliveryMethod);
            Includes.Add(o => o.OrderItems);
            AddOrderByDesending(o => o.OrderDate);
        }
        public OrderSpecifications(int orderId,string email) 
            : base(o => o.BuyerEmail == email && o.Id==orderId)
        {
            Includes.Add(o => o.DeliveryMethod);
            Includes.Add(o => o.OrderItems);
            AddOrderByDesending(o => o.OrderDate);
        }

    }
}
