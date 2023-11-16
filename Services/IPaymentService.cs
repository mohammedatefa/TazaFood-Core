using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.Services
{
    public interface IPaymentService
    {
        Task<UserCart> CreateOrUpdatePaymentIntent(string cartId);
    }
}
