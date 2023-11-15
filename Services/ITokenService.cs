using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.IdentityModels;

namespace TazaFood_Core.Services
{
    public interface ITokenService
    {
        Task<string> CreateTokenAsync(AppUser user,UserManager<AppUser> usermanger);
    }
}
