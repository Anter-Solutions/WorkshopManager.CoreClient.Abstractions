using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.Auth;

namespace WorkshopManager.CoreClient.Abstractions.Auth
{
    /// <summary>
    /// Provides user info. (Usernames, emails, phones etc.)
    /// </summary>
    public interface IUserInfoProvider<U>
    {
        Task<U> GetUser();
    }
}
