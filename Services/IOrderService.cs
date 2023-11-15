using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models.Order_Aggregate;

namespace TazaFood_Core.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrder(string userEmail, string cartId, int deliveryMethod, Address shippingAddress);
        Task<IReadOnlyList<Order>> GetAllOrdersForUser(string userEmail);
        Task<Order> GetOrderById(int orderId, string userEmail);

        Task<IReadOnlyList<DeliveryMethod>> GetDeleveryMethods();
    }
}
