using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.IRepositories
{
    public interface ICartItemsRepository
    {
        public Task<UserCart?> GetCartAsync(string cartId);

        public Task<UserCart?> UpdateCartAsync(UserCart cart);

        public Task<bool> DeleteCartAsync(string cartId);
    }
}
