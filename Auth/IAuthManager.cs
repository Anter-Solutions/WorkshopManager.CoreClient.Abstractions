using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Infrastructure.DTOs.Auth;

namespace WorkshopManager.CoreClient.Abstractions.Auth
{
    public interface IAuthManager
    {
        Task<bool> SignInAsync(LoginDTO loginDto);
    }
}
