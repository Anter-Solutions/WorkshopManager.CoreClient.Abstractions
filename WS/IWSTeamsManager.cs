using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.Entities;

namespace WorkshopManager.CoreClient.Abstractions.WS
{
    public interface IWSTeamsManager
    {
        IEnumerable<WSTeam> GetAll();
        WSTeam Get(int id);
        void Add(WSTeam team);
        void Delete(int id);
        void AddEmployeeToTeam(int teamId, int employeeId);
    }
}
