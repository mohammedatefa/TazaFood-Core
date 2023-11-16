using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;
using TazaFood_Core.Models.Order_Aggregate;

namespace TazaFood_Core.Services
{
    public interface IPaymentService
    {
        Task<UserCart> CreateOrUpdatePaymentIntent(string cartId);
        Task<Order> UpdatePaymentIntentWithSucceededOrFaild(string paymentIntent, bool flag);
    }
}
