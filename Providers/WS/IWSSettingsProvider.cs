using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.WS;

namespace WorkshopManager.CoreClient.Abstractions.Providers.WS
{
    public interface IWSSettingsProvider
    {
        Task<WSSettings> GetWSSettings();
    }
}
